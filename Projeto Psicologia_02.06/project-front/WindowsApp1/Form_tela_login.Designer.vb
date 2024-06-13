<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_tela_login
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
        Dim btn_entrar As System.Windows.Forms.Button
        Me.Licensing1 = New Guna.UI.Licensing.Licensing()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnk_esqueci_senha = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        btn_entrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_entrar
        '
        btn_entrar.BackColor = System.Drawing.SystemColors.ControlLightLight
        btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_entrar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_entrar.ForeColor = System.Drawing.Color.Black
        btn_entrar.Image = Global.WindowsApp1.My.Resources.Resources.entrar
        btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btn_entrar.Location = New System.Drawing.Point(386, 394)
        btn_entrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New System.Drawing.Size(254, 85)
        btn_entrar.TabIndex = 17
        btn_entrar.Text = "Entrar"
        btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btn_entrar.UseVisualStyleBackColor = False
        AddHandler btn_entrar.Click, AddressOf Me.btn_entrar_Click
        '
        'Licensing1
        '
        Me.Licensing1.BackColor = System.Drawing.Color.White
        Me.Licensing1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Licensing1.Location = New System.Drawing.Point(1132, 698)
        Me.Licensing1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Licensing1.MaximumSize = New System.Drawing.Size(522, 746)
        Me.Licensing1.MinimumSize = New System.Drawing.Size(522, 746)
        Me.Licensing1.Name = "Licensing1"
        Me.Licensing1.Size = New System.Drawing.Size(522, 746)
        Me.Licensing1.TabIndex = 0
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.Location = New System.Drawing.Point(298, 269)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_senha.Multiline = True
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(264, 36)
        Me.txt_senha.TabIndex = 15
        '
        'chk_visualizar
        '
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visualizar.Location = New System.Drawing.Point(634, 269)
        Me.chk_visualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(193, 31)
        Me.chk_visualizar.TabIndex = 18
        Me.chk_visualizar.Text = "Visualizar senha"
        Me.chk_visualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Login:"
        '
        'lnk_esqueci_senha
        '
        Me.lnk_esqueci_senha.AutoSize = True
        Me.lnk_esqueci_senha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_esqueci_senha.LinkColor = System.Drawing.Color.Red
        Me.lnk_esqueci_senha.Location = New System.Drawing.Point(350, 311)
        Me.lnk_esqueci_senha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnk_esqueci_senha.Name = "lnk_esqueci_senha"
        Me.lnk_esqueci_senha.Size = New System.Drawing.Size(166, 27)
        Me.lnk_esqueci_senha.TabIndex = 13
        Me.lnk_esqueci_senha.TabStop = True
        Me.lnk_esqueci_senha.Text = "Esqueci a senha"
        Me.lnk_esqueci_senha.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 36)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Senha:"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(298, 197)
        Me.txt_login.Multiline = True
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(265, 36)
        Me.txt_login.TabIndex = 20
        Me.txt_login.Tag = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.logo_resized__2_
        Me.PictureBox1.Location = New System.Drawing.Point(231, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(574, 183)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Form_tela_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 535)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.chk_visualizar)
        Me.Controls.Add(btn_entrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnk_esqueci_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Licensing1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_tela_login"
        Me.Text = "Mynd.SLN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Licensing1 As Guna.UI.Licensing.Licensing
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents chk_visualizar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lnk_esqueci_senha As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
