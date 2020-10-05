Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text

'## Controls the form that checks for the status of the tools require to run this ##
Public Class installationWindow
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Do you want to close this window?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            e.Cancel = True
            Me.Show()
        Else
            e.Cancel = False
            BbAWSControl.Show()
        End If

    End Sub

    Private Sub checkInstallButton_Click(sender As Object, e As EventArgs) Handles checkInstallButton.Click
        textOutput.Clear()

        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()

        textOutput.AppendText("Checking Python version... " & Environment.NewLine)
        '## Checks if pyton and PIP are installed ##
        Dim pipeline As Pipeline = runspace.CreatePipeline()
        pipeline.Commands.AddScript("python --version")
        pipeline.Commands.Add("Out-String")

        Dim resultString2 As StringBuilder = New StringBuilder()

        Try
            Dim result1 = pipeline.Invoke()

            Dim resultString As StringBuilder = New StringBuilder()

            For Each ps As PSObject In result1
                resultString.AppendLine(ps.ToString)
            Next
            textOutput.AppendText(resultString.ToString())

            textOutput.AppendText("Checking PIP version... " & Environment.NewLine)

            Dim pipeline2 As Pipeline = runspace.CreatePipeline()
            pipeline2.Commands.AddScript("pip3 --version")
            pipeline2.Commands.Add("Out-String")
            Dim result2 = pipeline2.Invoke()


            For Each ps As PSObject In result2
                resultString2.AppendLine(ps.ToString)
            Next
        Catch ex As Exception
            MessageBox.Show("Python not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textOutput.AppendText("Please reinstall the latest version of Python." & Environment.NewLine)
        End Try


        textOutput.AppendText(resultString2.ToString())

        textOutput.AppendText("Check Completed. ")

        runspace.Close()
    End Sub

    '## Checks if awscli is installed ##
    Private Sub installButton_Click(sender As Object, e As EventArgs) Handles installButton.Click
        textOutput.Clear()
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()

        textOutput.AppendText("Checking awscli... " & Environment.NewLine)

        Try
            Dim pipeline As Pipeline = runspace.CreatePipeline()
            pipeline.Commands.AddScript("aws --version")
            pipeline.Commands.Add("Out-String")
            Dim result = pipeline.Invoke()
            Dim resultString As StringBuilder = New StringBuilder()
            For Each ps As PSObject In result
                resultString.AppendLine(ps.ToString)
            Next
            textOutput.AppendText(Environment.NewLine & resultString.ToString())

            textOutput.AppendText(Environment.NewLine & "Check Completed. ")

        Catch ex As Exception
            MessageBox.Show("AWSCLI not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textOutput.AppendText("Please run: 'pip3 install awscli' in CMD." & Environment.NewLine)
        End Try

        runspace.Close()
    End Sub
End Class