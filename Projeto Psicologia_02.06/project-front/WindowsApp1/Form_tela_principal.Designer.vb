<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_tela_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tela_principal))
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_pagamentos = New System.Windows.Forms.Button()
        Me.btn_relatorios = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.FlatAppearance.BorderSize = 4
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_logout.Image = Global.WindowsApp1.My.Resources.Resources.logout_icon_icons_com_51025
        Me.btn_logout.Location = New System.Drawing.Point(730, 388)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 62)
        Me.btn_logout.TabIndex = 13
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_usuarios
        '
        Me.btn_usuarios.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios.Image = CType(resources.GetObject("btn_usuarios.Image"), System.Drawing.Image)
        Me.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuarios.Location = New System.Drawing.Point(297, 331)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(248, 89)
        Me.btn_usuarios.TabIndex = 3
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_usuarios.UseVisualStyleBackColor = True
        Me.btn_usuarios.Visible = False
        '
        'btn_pagamentos
        '
        Me.btn_pagamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_pagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pagamentos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pagamentos.Image = Global.WindowsApp1.My.Resources.Resources.business_cash_coin_dollar_finance_money_payment_icon_123244__1_
        Me.btn_pagamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pagamentos.Location = New System.Drawing.Point(297, 197)
        Me.btn_pagamentos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_pagamentos.Name = "btn_pagamentos"
        Me.btn_pagamentos.Size = New System.Drawing.Size(248, 89)
        Me.btn_pagamentos.TabIndex = 2
        Me.btn_pagamentos.TabStop = False
        Me.btn_pagamentos.Text = "Pagamentos de Clientes"
        Me.btn_pagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pagamentos.UseCompatibleTextRendering = True
        Me.btn_pagamentos.UseVisualStyleBackColor = True
        '
        'btn_relatorios
        '
        Me.btn_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorios.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.Image = Global.WindowsApp1.My.Resources.Resources.btn_relatorio
        Me.btn_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_relatorios.Location = New System.Drawing.Point(576, 195)
        Me.btn_relatorios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(248, 91)
        Me.btn_relatorios.TabIndex = 1
        Me.btn_relatorios.Text = "  Gerar   Relatórios"
        Me.btn_relatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_relatorios.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.Image = Global.WindowsApp1.My.Resources.Resources.business_table_order_report_history_2332__1_
        Me.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Location = New System.Drawing.Point(18, 195)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(248, 91)
        Me.btn_clientes.TabIndex = 0
        Me.btn_clientes.Text = "Cadastro de Clientes"
        Me.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clientes.UseCompatibleTextRendering = True
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.logo_resized__2_
        Me.PictureBox1.Location = New System.Drawing.Point(124, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(585, 183)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form_tela_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_pagamentos)
        Me.Controls.Add(Me.btn_relatorios)
        Me.Controls.Add(Me.btn_clientes)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_tela_principal"
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_relatorios As Button
    Friend WithEvents btn_pagamentos As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
