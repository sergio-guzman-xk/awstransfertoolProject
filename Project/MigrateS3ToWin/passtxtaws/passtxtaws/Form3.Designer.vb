<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installationWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(installationWindow))
        Me.installButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textOutput = New System.Windows.Forms.TextBox()
        Me.checkInstallButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'installButton
        '
        Me.installButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.installButton.ForeColor = System.Drawing.Color.DarkGray
        Me.installButton.Location = New System.Drawing.Point(583, 286)
        Me.installButton.Name = "installButton"
        Me.installButton.Size = New System.Drawing.Size(101, 43)
        Me.installButton.TabIndex = 0
        Me.installButton.Text = "Check AWS"
        Me.installButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 104)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'textOutput
        '
        Me.textOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.textOutput.Location = New System.Drawing.Point(130, 134)
        Me.textOutput.Multiline = True
        Me.textOutput.Name = "textOutput"
        Me.textOutput.Size = New System.Drawing.Size(390, 217)
        Me.textOutput.TabIndex = 2
        '
        'checkInstallButton
        '
        Me.checkInstallButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.checkInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkInstallButton.ForeColor = System.Drawing.Color.DarkGray
        Me.checkInstallButton.Location = New System.Drawing.Point(583, 159)
        Me.checkInstallButton.Name = "checkInstallButton"
        Me.checkInstallButton.Size = New System.Drawing.Size(101, 44)
        Me.checkInstallButton.TabIndex = 3
        Me.checkInstallButton.Text = "Check Python"
        Me.checkInstallButton.UseVisualStyleBackColor = False
        '
        'installationWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(825, 417)
        Me.Controls.Add(Me.checkInstallButton)
        Me.Controls.Add(Me.textOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.installButton)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "installationWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tools Instalation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents installButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textOutput As TextBox
    Friend WithEvents checkInstallButton As Button
End Class
