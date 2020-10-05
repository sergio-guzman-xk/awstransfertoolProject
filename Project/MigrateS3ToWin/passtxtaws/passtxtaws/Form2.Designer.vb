<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class configPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accessKeyTxt = New System.Windows.Forms.TextBox()
        Me.secretAccessTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.profileNameTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AWS Access Key ID"
        '
        'accessKeyTxt
        '
        Me.accessKeyTxt.Location = New System.Drawing.Point(302, 118)
        Me.accessKeyTxt.Name = "accessKeyTxt"
        Me.accessKeyTxt.Size = New System.Drawing.Size(353, 20)
        Me.accessKeyTxt.TabIndex = 1
        '
        'secretAccessTxt
        '
        Me.secretAccessTxt.Location = New System.Drawing.Point(303, 180)
        Me.secretAccessTxt.Name = "secretAccessTxt"
        Me.secretAccessTxt.Size = New System.Drawing.Size(353, 20)
        Me.secretAccessTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AWS Secret Access"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(189, 250)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 39)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(525, 250)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(90, 39)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'profileNameTxt
        '
        Me.profileNameTxt.Location = New System.Drawing.Point(303, 62)
        Me.profileNameTxt.Name = "profileNameTxt"
        Me.profileNameTxt.Size = New System.Drawing.Size(353, 20)
        Me.profileNameTxt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Profile Name"
        '
        'configPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 341)
        Me.Controls.Add(Me.profileNameTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.secretAccessTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.accessKeyTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "configPanel"
        Me.Text = "AWS Profile Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents accessKeyTxt As TextBox
    Friend WithEvents secretAccessTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents profileNameTxt As TextBox
    Friend WithEvents Label5 As Label
End Class
