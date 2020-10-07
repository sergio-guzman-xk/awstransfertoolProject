Imports System.IO
Imports System.Management.Automation.Runspaces

'## Panel that controls the aws profile creation ##
Public Class configPanel
    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim accessKey = Trim(accessKeyTxt.Text())
        Dim secretKey = Trim(secretAccessTxt.Text())
        Dim profileName = Trim(profileNameTxt.Text())
        Dim awsPath = Environment.GetEnvironmentVariable("USERPROFILE")
        '## aws credentials format ##
        Dim inputString As String = "
[" & profileName & "]
aws_access_key_id=" & accessKey & "
aws_secret_access_key=" & secretKey & "
region=us-east-1"
        '## aws config input ##
        Dim configInput As String = "
[profile " & profileName & "]"

        If String.IsNullOrEmpty(accessKey) Or String.IsNullOrEmpty(secretKey) Or String.IsNullOrEmpty(profileName) Then
            MessageBox.Show("Make sure there are no empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            addProfile(profileName, awsPath, inputString, configInput)
        End If

    End Sub

    '## Checks if the aws credentials file exist. If not it creates it ##
    Private Sub addProfile(profile As String, awsPath As String, inputString As String, configInput As String)

        Try
            writeOnFile(profile, awsPath, inputString, configInput)
        Catch ex As Exception
            Dim dumbString As String = "[blank]
aws_access_key_id=foo
aws_secret_access_key=ohh
region=us-east-1"
            Dim dumbConfig As String = "[profile blank]"
            Try
                Dim objWriteroutputaws As New StreamWriter("" & awsPath & "\.aws\credentials", True, utf8WithoutBom)
                objWriteroutputaws.Close()
                Dim objWriteroutputaws2 As New StreamWriter("" & awsPath & "\.aws\config", True, utf8WithoutBom)
                objWriteroutputaws2.Close()
            Catch ex2 As Exception
                Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
                runspace.Open()
                Dim pipeline2 As Pipeline = runspace.CreatePipeline()
                pipeline2.Commands.AddScript("mkdir " & awsPath & "\.aws")
                pipeline2.Commands.Add("Out-String")
                pipeline2.Invoke()
                runspace.Close()
            End Try
            My.Computer.FileSystem.WriteAllText("" & awsPath & "\.aws\credentials", dumbString, True, utf8WithoutBom)
            My.Computer.FileSystem.WriteAllText("" & awsPath & "\.aws\config", dumbConfig, True, utf8WithoutBom)
            writeOnFile(profile, awsPath, inputString, configInput)
        End Try

    End Sub
    '## Writes on the aws credentials file ##
    Private Sub writeOnFile(profile As String, awsPath As String, inputString As String, configInput As String)

        Dim find = getSearchOnFile(profile)

        If find = False Then
            My.Computer.FileSystem.WriteAllText("" & awsPath & "\.aws\credentials", inputString, True, utf8WithoutBom)
            My.Computer.FileSystem.WriteAllText("" & awsPath & "\.aws\config", configInput, True, utf8WithoutBom)
            MsgBox("Profile Created", , "Profile")
            Me.Close()
            BbAWSControl.Show()
        Else
            MessageBox.Show("Profile name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Function getSearchOnFile(profile As String)
        Dim awsPath = Environment.GetEnvironmentVariable("USERPROFILE")
        Dim found As Boolean = searchOnFile(profile, awsPath)
        Return found
    End Function

    Private Function searchOnFile(profile As String, awsPath As String)
        Dim readerCredentials As New StreamReader("" & awsPath & "\.aws\config", utf8WithoutBom)
        Dim newLine As String = ""

        Do
            newLine = readerCredentials.ReadLine()
            If Not newLine Is Nothing Then
                If newLine = "[profile " & profile & "]" Then
                    readerCredentials.Close()
                    Return True
                    Exit Do
                End If
            End If

        Loop Until newLine Is Nothing
        readerCredentials.Close()
        Return False
    End Function

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '## Shows the "are you sure" box at closing
        Dim result As DialogResult = MessageBox.Show("Do you want to close this window?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            e.Cancel = True
            Me.Show()
        Else
            e.Cancel = False
            BbAWSControl.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class