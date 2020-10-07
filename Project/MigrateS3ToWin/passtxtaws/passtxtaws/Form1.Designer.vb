<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BbAWSControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnGetList = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtInputProfile = New System.Windows.Forms.TextBox()
        Me.lbTamanoPaquete = New System.Windows.Forms.Label()
        Me.lbProfile = New System.Windows.Forms.Label()
        Me.txtLocalPath = New System.Windows.Forms.TextBox()
        Me.lbRutaDeDestino = New System.Windows.Forms.Label()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.installButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAwsPath = New System.Windows.Forms.TextBox()
        Me.btnGetS3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDestinationProfile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDestinationPath = New System.Windows.Forms.TextBox()
        Me.awsFlag = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(35, 98)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'btnGetList
        '
        Me.btnGetList.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnGetList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetList.ForeColor = System.Drawing.Color.DarkGray
        Me.btnGetList.Location = New System.Drawing.Point(795, 32)
        Me.btnGetList.Name = "btnGetList"
        Me.btnGetList.Size = New System.Drawing.Size(115, 23)
        Me.btnGetList.TabIndex = 3
        Me.btnGetList.Text = "Save Configuration"
        Me.btnGetList.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDownload.ForeColor = System.Drawing.Color.DarkGray
        Me.btnDownload.Location = New System.Drawing.Point(1008, 32)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(115, 23)
        Me.btnDownload.TabIndex = 4
        Me.btnDownload.Text = "Start"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOutput.Location = New System.Drawing.Point(12, 202)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(1240, 387)
        Me.txtOutput.TabIndex = 5
        Me.txtOutput.WordWrap = False
        '
        'txtInputProfile
        '
        Me.txtInputProfile.BackColor = System.Drawing.Color.White
        Me.txtInputProfile.Location = New System.Drawing.Point(338, 103)
        Me.txtInputProfile.Name = "txtInputProfile"
        Me.txtInputProfile.Size = New System.Drawing.Size(178, 20)
        Me.txtInputProfile.TabIndex = 6
        '
        'lbTamanoPaquete
        '
        Me.lbTamanoPaquete.AutoSize = True
        Me.lbTamanoPaquete.ForeColor = System.Drawing.Color.LightGray
        Me.lbTamanoPaquete.Location = New System.Drawing.Point(32, 82)
        Me.lbTamanoPaquete.Name = "lbTamanoPaquete"
        Me.lbTamanoPaquete.Size = New System.Drawing.Size(76, 13)
        Me.lbTamanoPaquete.TabIndex = 7
        Me.lbTamanoPaquete.Text = "Package Size:"
        '
        'lbProfile
        '
        Me.lbProfile.AutoSize = True
        Me.lbProfile.ForeColor = System.Drawing.Color.LightGray
        Me.lbProfile.Location = New System.Drawing.Point(334, 87)
        Me.lbProfile.Name = "lbProfile"
        Me.lbProfile.Size = New System.Drawing.Size(69, 13)
        Me.lbProfile.TabIndex = 8
        Me.lbProfile.Text = "Origin Profile:"
        '
        'txtLocalPath
        '
        Me.txtLocalPath.BackColor = System.Drawing.Color.White
        Me.txtLocalPath.Location = New System.Drawing.Point(35, 154)
        Me.txtLocalPath.Name = "txtLocalPath"
        Me.txtLocalPath.Size = New System.Drawing.Size(237, 20)
        Me.txtLocalPath.TabIndex = 9
        '
        'lbRutaDeDestino
        '
        Me.lbRutaDeDestino.AutoSize = True
        Me.lbRutaDeDestino.ForeColor = System.Drawing.Color.LightGray
        Me.lbRutaDeDestino.Location = New System.Drawing.Point(32, 138)
        Me.lbRutaDeDestino.Name = "lbRutaDeDestino"
        Me.lbRutaDeDestino.Size = New System.Drawing.Size(140, 13)
        Me.lbRutaDeDestino.TabIndex = 10
        Me.lbRutaDeDestino.Text = "Local Path:  Ex. C:\...\path\"
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfig.ForeColor = System.Drawing.Color.DarkGray
        Me.btnConfig.Location = New System.Drawing.Point(369, 32)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(115, 23)
        Me.btnConfig.TabIndex = 11
        Me.btnConfig.Text = "AWS Profile config"
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'installButton
        '
        Me.installButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.installButton.ForeColor = System.Drawing.Color.DarkGray
        Me.installButton.Location = New System.Drawing.Point(156, 32)
        Me.installButton.Name = "installButton"
        Me.installButton.Size = New System.Drawing.Size(115, 23)
        Me.installButton.TabIndex = 13
        Me.installButton.Text = "Check Tools"
        Me.installButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(334, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "AWS Source Path: Ex. s3://.../path/"
        '
        'txtAwsPath
        '
        Me.txtAwsPath.BackColor = System.Drawing.Color.White
        Me.txtAwsPath.Location = New System.Drawing.Point(338, 154)
        Me.txtAwsPath.Name = "txtAwsPath"
        Me.txtAwsPath.Size = New System.Drawing.Size(281, 20)
        Me.txtAwsPath.TabIndex = 14
        '
        'btnGetS3
        '
        Me.btnGetS3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGetS3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnGetS3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetS3.ForeColor = System.Drawing.Color.DarkGray
        Me.btnGetS3.Location = New System.Drawing.Point(582, 32)
        Me.btnGetS3.Name = "btnGetS3"
        Me.btnGetS3.Size = New System.Drawing.Size(115, 23)
        Me.btnGetS3.TabIndex = 16
        Me.btnGetS3.Text = "Inspect s3"
        Me.btnGetS3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(665, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Destination Profile:"
        '
        'txtDestinationProfile
        '
        Me.txtDestinationProfile.BackColor = System.Drawing.Color.White
        Me.txtDestinationProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationProfile.Location = New System.Drawing.Point(668, 103)
        Me.txtDestinationProfile.Name = "txtDestinationProfile"
        Me.txtDestinationProfile.Size = New System.Drawing.Size(178, 20)
        Me.txtDestinationProfile.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(665, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "AWS Destination Path: Ex. s3://.../path/"
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.BackColor = System.Drawing.Color.White
        Me.txtDestinationPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationPath.Location = New System.Drawing.Point(668, 154)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(281, 20)
        Me.txtDestinationPath.TabIndex = 19
        '
        'awsFlag
        '
        Me.awsFlag.AutoSize = True
        Me.awsFlag.ForeColor = System.Drawing.Color.LightGray
        Me.awsFlag.Location = New System.Drawing.Point(898, 103)
        Me.awsFlag.Name = "awsFlag"
        Me.awsFlag.Size = New System.Drawing.Size(51, 17)
        Me.awsFlag.TabIndex = 21
        Me.awsFlag.Text = "AWS"
        Me.awsFlag.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(1008, 100)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(215, 20)
        Me.ProgressBar1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(1005, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Progress:"
        '
        'BbAWSControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 601)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.awsFlag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDestinationPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDestinationProfile)
        Me.Controls.Add(Me.btnGetS3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAwsPath)
        Me.Controls.Add(Me.installButton)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.lbRutaDeDestino)
        Me.Controls.Add(Me.txtLocalPath)
        Me.Controls.Add(Me.lbProfile)
        Me.Controls.Add(Me.lbTamanoPaquete)
        Me.Controls.Add(Me.txtInputProfile)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnGetList)
        Me.Controls.Add(Me.txtCantidad)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BbAWSControl"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AWSControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnGetList As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtInputProfile As TextBox
    Friend WithEvents lbTamanoPaquete As Label
    Friend WithEvents lbProfile As Label
    Friend WithEvents txtLocalPath As TextBox
    Friend WithEvents lbRutaDeDestino As Label
    Friend WithEvents btnConfig As Button
    Friend WithEvents installButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAwsPath As TextBox
    Friend WithEvents btnGetS3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDestinationProfile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDestinationPath As TextBox
    Friend WithEvents awsFlag As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
End Class
