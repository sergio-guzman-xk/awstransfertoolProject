Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text

Public Class BbAWSControl

    Dim redFlag As Boolean = False

    '## Control de Save Configuration Button ##
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnGetList.Click
        '## creates the writter for the lss3.txt file ##
        Dim objWriteroutputaws As New StreamWriter("lss3.txt")
        Dim defaultSize = Trim(txtCantidad.Text())
        Dim profile = Trim(txtInputProfile.Text())
        Dim destProfile = Trim(txtDestinationProfile.Text())
        Dim localPath = Trim(txtLocalPath.Text())
        Dim destinationAWS = Trim(txtDestinationPath.Text())
        Dim awsPath = Trim(txtAwsPath.Text())

        txtOutput.Clear()

        If profile = "" Or localPath = "" Or awsPath = "" Then
            MsgBox("Invalid profile, local path or aws path", , "Error")
            objWriteroutputaws.Close()
        Else
            redFlag = True
            txtOutput.AppendText("Processing... " & Environment.NewLine)
            txtOutput.AppendText("Please Wait... " & Environment.NewLine)

            Console.WriteLine("Default: " & defaultSize)

            Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
            runspace.Open()
            Dim pipeline As Pipeline = runspace.CreatePipeline()
            '## Downloads the list of items the S3 and places them in the lss3.txt file ##
            If defaultSize = "" Then
                pipeline.Commands.AddScript("aws s3 ls --profile " & profile & " " & awsPath)
            Else
                pipeline.Commands.AddScript("aws s3 ls --profile " & profile & " " & awsPath & " | Select -First " & defaultSize)
            End If
            pipeline.Commands.Add("Out-String")
            Dim results As Collection(Of PSObject) = pipeline.Invoke()


            For Each ps As PSObject In results
                objWriteroutputaws.WriteLine(ps.ToString())
            Next
            objWriteroutputaws.Close()

            '## checks if it is a local download or a S3 to S3 transfer ##
            If awsFlag.CheckState = 1 Then
                If destProfile = "" Or destinationAWS = "" Then
                    redFlag = False
                    MsgBox("Invalid destination profile, or destination aws path", , "Error")
                    txtOutput.AppendText(Environment.NewLine & "The currnet configuration could not be saved..." & Environment.NewLine)
                Else
                    processCreation(profile, localPath, awsPath, destinationAWS, destProfile)
                    txtOutput.AppendText(Environment.NewLine & "Loading list... " & Environment.NewLine)

                    getList()

                    runspace.Close()
                End If
            ElseIf awsFlag.CheckState = 0 Then
                processCreation(profile, localPath, awsPath)
                txtOutput.AppendText(Environment.NewLine & "Loading list... " & Environment.NewLine)

                getList()

                runspace.Close()
            Else
                txtOutput.AppendText(Environment.NewLine & "Something wrong with aws flag..." & Environment.NewLine)
            End If

        End If

    End Sub

    '## creates the namesfiles.txt used when the download to local is chose. ##
    Private Sub processCreation(profile As String, localPath As String, awsPath As String)
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline2 As Pipeline = runspace.CreatePipeline()
        pipeline2.Commands.AddScript("Get-Content -Path lss3.txt |
Select-String -Pattern '^(.+) (.+) (\d+) (.+)' |
Foreach-Object {
$one, $two, $three, $four= $_.Matches[0].Groups[1..4].Value
[string] ""aws s3 cp --profile " & profile & " " & awsPath & "$four " & localPath & "  --no-progress""
} | Out-File -FilePath namesfiles.txt")
        pipeline2.Commands.Add("Out-String")
        pipeline2.Invoke()
        runspace.Close()
        txtOutput.AppendText(Environment.NewLine & "Process completed... " & Environment.NewLine)
    End Sub

    '## creates the namesfiles.txt used when the transer from S3 to S3 is selected ##
    Private Sub processCreation(profile As String, localPath As String, awsPath As String, destinationAWS As String, destProfile As String)
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline2 As Pipeline = runspace.CreatePipeline()
        pipeline2.Commands.AddScript("Get-Content -Path lss3.txt |
Select-String -Pattern '^(.+) (.+) (\d+) (.+)' |
Foreach-Object {
$one, $two, $three, $four= $_.Matches[0].Groups[1..4].Value
[string] ""aws s3 mv --profile " & profile & " " & awsPath & "$four " & localPath & "  --no-progress"", 
[string] ""aws s3 mv --profile " & destProfile & " " & localPath & "$four " & destinationAWS & "  --no-progress""
} | Out-File -FilePath namesfiles.txt")
        pipeline2.Commands.Add("Out-String")
        pipeline2.Invoke()
        runspace.Close()
        txtOutput.AppendText(Environment.NewLine & "Process completed... " & Environment.NewLine)
    End Sub

    '## creates the easy to read list displayed in console when clicking the get list button ##
    Private Sub getList()
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline5 As Pipeline = Runspace.CreatePipeline()
        pipeline5.Commands.AddScript("$count = 1
Get-Content -Path lss3.txt |
	Select-String -Pattern '^(.+) (\d+) (.+)' |
	Foreach-Object {
		$one, $two, $three= $_.Matches[0].Groups[1..3].Value
		[PSCustomObject] @{
			Number = $count
			Size = [string] $two
			Course = [string] $three			
		}
		$count = $count + 1
	}")
        pipeline5.Commands.Add("Out-String")
        Dim resulsizeresults As Collection(Of PSObject) = pipeline5.Invoke()

        Dim stringBuilder As StringBuilder = New StringBuilder()

        For Each ps As PSObject In resulsizeresults
            stringBuilder.AppendLine(ps.ToString)
        Next

        txtOutput.AppendText(Environment.NewLine & stringBuilder.ToString())
        runspace.Close()
        txtOutput.AppendText(Environment.NewLine & "List loaded." & Environment.NewLine)
    End Sub

    '## Takes the data from the lss3.txt file and isolates the size of the files to sum them. Returns that sum ##
    Private Function getNumbers()
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim sizeInBt As String
        Dim testList As New ArrayList()

        Dim pipeline4 As Pipeline = runspace.CreatePipeline()
        pipeline4.Commands.AddScript("Get-Content -Path lss3.txt |
	Select-String -Pattern '^(.+) (\d+) (.+)' |
	Foreach-Object {
		$one, $two, $three= $_.Matches[0].Groups[1..3].Value
		[PSCustomObject] @{
			Size = [string] $two
		}
	}")
        pipeline4.Commands.Add("Out-String")

        txtOutput.AppendText(Environment.NewLine & "Estmating size..." & Environment.NewLine)

        Dim resulsizeresults As Collection(Of PSObject) = pipeline4.Invoke()
        For Each ps As PSObject In resulsizeresults
            sizeInBt = ps.ToString
        Next
        '## Removing what we don't need from the string generated and started to orgnize the file in multple lines ##
        sizeInBt = System.Text.RegularExpressions.Regex.Replace(sizeInBt, Environment.NewLine, " ")
        sizeInBt = System.Text.RegularExpressions.Regex.Replace(sizeInBt, "[^\d]", " ")
        sizeInBt = System.Text.RegularExpressions.Regex.Replace(sizeInBt, "\s+", ",")

        Dim result As String() = sizeInBt.Split(New String() {","}, StringSplitOptions.None)
        '## Creates an array using the string created before, then it sums reach item in the array ##
        For Each s As String In result
            If String.IsNullOrWhiteSpace(s) Then

            Else
                testList.Add(s)
            End If
        Next

        Dim total As Double
        For Each number In testList
            total = CDbl(Val(number)) + total
        Next

        Return total
    End Function

    '## Starts the download to local or transfer from S3 to S3 process. it uses the data in the namesfiles.txt created in the procesCreation method ##
    Private Sub Ejecutar_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        If redFlag Then
            Dim nameFilesReader As New StreamReader("namesfiles.txt")
            Dim newLine As String = ""
            Dim lista As New ArrayList()

            Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
            runspace.Open()

            txtOutput.Clear()
            txtOutput.AppendText("Starting..." & Environment.NewLine & Environment.NewLine)
            Do

                newLine = nameFilesReader.ReadLine()
                If Not newLine Is Nothing Then
                    Dim pipeline As Pipeline = runspace.CreatePipeline()
                    pipeline.Commands.AddScript(newLine)
                    pipeline.Commands.Add("Out-String")
                    Dim results = pipeline.Invoke()

                    Dim stringBuilder As StringBuilder = New StringBuilder()

                    For Each ps As PSObject In results
                        stringBuilder.AppendLine(ps.ToString)
                    Next

                    txtOutput.AppendText(stringBuilder.ToString())
                End If
            Loop Until newLine Is Nothing
            nameFilesReader.Close()

            txtOutput.AppendText(Environment.NewLine & "Process completed." & Environment.NewLine)
            MsgBox("Process completed", , "")
        Else
            MessageBox.Show("Save the configuration first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Me.Hide()
        configPanel.Show()
    End Sub

    Private Sub installButton_Click(sender As Object, e As EventArgs) Handles installButton.Click
        Me.Hide()
        installationWindow.Show()
    End Sub

    '## Using the total returned from getnumbers it translate the information in a more human readable format ##
    Private Sub btnEstimate_Click(sender As Object, e As EventArgs) Handles btnEstimateSize.Click

        If redFlag Then

            Dim total As Double = getNumbers()

            If total < Math.Pow(1024, 2) Then
                total = total / 1024
                txtOutput.AppendText(Environment.NewLine & txtOutput.Text & Environment.NewLine & "The total size of this package is: " & total.ToString & " KB.")
            ElseIf total < Math.Pow(1024, 3) Then
                total = total / Math.Pow(1024, 2)
                txtOutput.AppendText(Environment.NewLine & txtOutput.Text & Environment.NewLine & "The total size of this package is: " & total.ToString & " MB.")
            ElseIf total < Math.Pow(1024, 4) Then
                total = total / Math.Pow(1024, 3)
                txtOutput.AppendText(Environment.NewLine & txtOutput.Text & Environment.NewLine & "The total size of this package is: " & total.ToString & " GB.")
            Else
                total = total / Math.Pow(1024, 4)
                txtOutput.AppendText(Environment.NewLine & txtOutput.Text & Environment.NewLine & "The total size of this package is: " & total.ToString & " TB.")
            End If
        Else
            MessageBox.Show("Execute Get List first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    '## gets all the data from the origin S3. Controls the inspect S3 button ##
    Private Sub btnGetS3_Click(sender As Object, e As EventArgs) Handles btnGetS3.Click

        Dim profile = txtInputProfile.Text()
        Dim awsPath = txtAwsPath.Text()

        If String.IsNullOrEmpty(profile) Or String.IsNullOrEmpty(awsPath) Then
            MessageBox.Show("Profile and AWS source path are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            txtOutput.AppendText(Environment.NewLine & "Processing..." & Environment.NewLine & Environment.NewLine & "Getting number of files and their size at the specified s3 location...." & Environment.NewLine)

            Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
            runspace.Open()

            Dim pipeline As Pipeline = runspace.CreatePipeline()
            pipeline.Commands.AddScript("aws s3 ls --profile " & profile & " " & awsPath & " --summarize --human-readable")
            pipeline.Commands.Add("Out-String")
            Dim resulsizeresults As Collection(Of PSObject) = pipeline.Invoke()

            Dim stringBuilder As StringBuilder = New StringBuilder()

            For Each ps As PSObject In resulsizeresults
                stringBuilder.AppendLine(ps.ToString)
            Next

            txtOutput.AppendText(Environment.NewLine & stringBuilder.ToString())

            txtOutput.AppendText(Environment.NewLine & "Process completed." & Environment.NewLine)

            runspace.Close()
        End If

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '## removes the files created at the start ##
        My.Computer.FileSystem.DeleteFile("lss3.txt")
        My.Computer.FileSystem.DeleteFile("namesfiles.txt")
    End Sub

    Private Sub BbAWSControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '## Initialize the status of the checkbox and disable the textboxes accordingly ##
        awsFlag.Checked = False
        txtDestinationPath.Enabled = False
        txtDestinationProfile.Enabled = False
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline As Pipeline = runspace.CreatePipeline()
        '## Changes the execution policy to allow the app to run scripts using shell ##
        pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned -Scope CurrentUser -force ; Set-ExecutionPolicy RemoteSigned -Scope LocalMachine -force;")
        pipeline.Commands.Add("Out-String")
        pipeline.Invoke()

        '## creates the files needed for the app to function ##
        Dim objWriteroutputaws As New StreamWriter("lss3.txt")
        objWriteroutputaws.Close()
        Dim objWritenamesfiles As New StreamWriter("namesfiles.txt")
        objWritenamesfiles.Close()

    End Sub

    '## controls the availability of the aws estination boxes ##
    Private Sub awsFlag_CheckedChanged(sender As Object, e As EventArgs) Handles awsFlag.CheckedChanged
        If awsFlag.CheckState = 1 Then
            redFlag = False
            txtDestinationPath.Enabled = True
            txtDestinationProfile.Enabled = True
        Else
            txtDestinationPath.Enabled = False
            txtDestinationProfile.Enabled = False
        End If
    End Sub
End Class
