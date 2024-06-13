<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastro_cliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_cadastro_cliente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TelaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeslogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_filtro = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Date_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_excluir = New System.Windows.Forms.Label()
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.chk_conv_nao = New System.Windows.Forms.CheckBox()
        Me.chk_conv_sim = New System.Windows.Forms.CheckBox()
        Me.chk_online = New System.Windows.Forms.CheckBox()
        Me.chk_presencial = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_responsavel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.btn_filtro.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TelaInicialToolStripMenuItem, Me.DeslogarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TelaInicialToolStripMenuItem
        '
        Me.TelaInicialToolStripMenuItem.Name = "TelaInicialToolStripMenuItem"
        Me.TelaInicialToolStripMenuItem.Size = New System.Drawing.Size(73, 22)
        Me.TelaInicialToolStripMenuItem.Text = "Tela Inicial"
        '
        'DeslogarToolStripMenuItem
        '
        Me.DeslogarToolStripMenuItem.Name = "DeslogarToolStripMenuItem"
        Me.DeslogarToolStripMenuItem.Size = New System.Drawing.Size(38, 22)
        Me.DeslogarToolStripMenuItem.Text = "Sair"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_filtro)
        Me.TabPage2.Controls.Add(Me.dgv_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(736, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_filtro
        '
        Me.btn_filtro.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.btn_filtro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.cmb_filtro})
        Me.btn_filtro.Location = New System.Drawing.Point(2, 2)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.btn_filtro.Size = New System.Drawing.Size(732, 31)
        Me.btn_filtro.TabIndex = 3
        Me.btn_filtro.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 28)
        Me.ToolStripLabel1.Text = "Pesquisar"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(68, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Nome", "CPF"})
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(82, 31)
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column3, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column1, Me.Column2})
        Me.dgv_dados.Location = New System.Drawing.Point(17, 25)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(718, 337)
        Me.dgv_dados.TabIndex = 2
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nº"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOME"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 290
        '
        'Column3
        '
        Me.Column3.HeaderText = "CELULAR"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "FORMA DE PAGAMENTO"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "VALOR"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "EDITAR"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 58
        '
        'Column2
        '
        Me.Column2.HeaderText = "EXCLUIR"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_valor)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.txt_celular)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Date_nascimento)
        Me.TabPage1.Controls.Add(Me.lbl_excluir)
        Me.TabPage1.Controls.Add(Me.lbl_cancelar)
        Me.TabPage1.Controls.Add(Me.btn_excluir)
        Me.TabPage1.Controls.Add(Me.btn_cancel)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.chk_conv_nao)
        Me.TabPage1.Controls.Add(Me.chk_conv_sim)
        Me.TabPage1.Controls.Add(Me.chk_online)
        Me.TabPage1.Controls.Add(Me.chk_presencial)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cmb_pagamento)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_comp)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_num)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_cidade)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_bairro)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_endereco)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_nome_responsavel)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(736, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(283, 262)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_valor.Mask = "$000.00"
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(58, 20)
        Me.txt_valor.TabIndex = 59
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(100, 151)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(62, 20)
        Me.txt_cep.TabIndex = 58
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(513, 101)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_celular.Mask = "(00) 00000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(84, 20)
        Me.txt_celular.TabIndex = 57
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(100, 49)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(84, 20)
        Me.txt_cpf.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(460, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 15)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Celular:"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Window
        Me.txt_email.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(100, 100)
        Me.txt_email.MaxLength = 60
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(348, 21)
        Me.txt_email.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(54, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 15)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Email:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(247, 262)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Valor"
        '
        'Date_nascimento
        '
        Me.Date_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_nascimento.Location = New System.Drawing.Point(573, 75)
        Me.Date_nascimento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Date_nascimento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.Date_nascimento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Date_nascimento.Name = "Date_nascimento"
        Me.Date_nascimento.Size = New System.Drawing.Size(97, 20)
        Me.Date_nascimento.TabIndex = 47
        Me.Date_nascimento.Value = New Date(2023, 6, 3, 0, 0, 0, 0)
        '
        'lbl_excluir
        '
        Me.lbl_excluir.AutoSize = True
        Me.lbl_excluir.Location = New System.Drawing.Point(612, 337)
        Me.lbl_excluir.Name = "lbl_excluir"
        Me.lbl_excluir.Size = New System.Drawing.Size(38, 13)
        Me.lbl_excluir.TabIndex = 46
        Me.lbl_excluir.Text = "Excluir"
        Me.lbl_excluir.Visible = False
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New System.Drawing.Point(532, 337)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 45
        Me.lbl_cancelar.Text = "Cancelar"
        Me.lbl_cancelar.Visible = False
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.Transparent
        Me.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_excluir.FlatAppearance.BorderSize = 0
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.ForeColor = System.Drawing.Color.Transparent
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.Location = New System.Drawing.Point(608, 296)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(41, 38)
        Me.btn_excluir.TabIndex = 44
        Me.btn_excluir.UseVisualStyleBackColor = False
        Me.btn_excluir.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(538, 299)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(35, 36)
        Me.btn_cancel.TabIndex = 43
        Me.btn_cancel.UseVisualStyleBackColor = True
        Me.btn_cancel.Visible = False
        '
        'txt_uf
        '
        Me.txt_uf.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.ForeColor = System.Drawing.Color.Black
        Me.txt_uf.Location = New System.Drawing.Point(99, 206)
        Me.txt_uf.MaxLength = 2
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(59, 21)
        Me.txt_uf.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "UF:"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar.Location = New System.Drawing.Point(282, 299)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(137, 49)
        Me.btn_cadastrar.TabIndex = 39
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'chk_conv_nao
        '
        Me.chk_conv_nao.AutoSize = True
        Me.chk_conv_nao.Location = New System.Drawing.Point(178, 260)
        Me.chk_conv_nao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_conv_nao.Name = "chk_conv_nao"
        Me.chk_conv_nao.Size = New System.Drawing.Size(46, 17)
        Me.chk_conv_nao.TabIndex = 38
        Me.chk_conv_nao.Text = "Não"
        Me.chk_conv_nao.UseVisualStyleBackColor = True
        '
        'chk_conv_sim
        '
        Me.chk_conv_sim.AutoSize = True
        Me.chk_conv_sim.Location = New System.Drawing.Point(125, 260)
        Me.chk_conv_sim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_conv_sim.Name = "chk_conv_sim"
        Me.chk_conv_sim.Size = New System.Drawing.Size(43, 17)
        Me.chk_conv_sim.TabIndex = 37
        Me.chk_conv_sim.Text = "Sim"
        Me.chk_conv_sim.UseVisualStyleBackColor = True
        '
        'chk_online
        '
        Me.chk_online.AutoSize = True
        Me.chk_online.Location = New System.Drawing.Point(259, 235)
        Me.chk_online.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_online.Name = "chk_online"
        Me.chk_online.Size = New System.Drawing.Size(56, 17)
        Me.chk_online.TabIndex = 36
        Me.chk_online.Text = "Online"
        Me.chk_online.UseVisualStyleBackColor = True
        '
        'chk_presencial
        '
        Me.chk_presencial.AutoSize = True
        Me.chk_presencial.Location = New System.Drawing.Point(179, 235)
        Me.chk_presencial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_presencial.Name = "chk_presencial"
        Me.chk_presencial.Size = New System.Drawing.Size(75, 17)
        Me.chk_presencial.TabIndex = 35
        Me.chk_presencial.Text = "Presencial"
        Me.chk_presencial.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Convênio:"
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"Selecione...", "PIX", "DINHEIRO", "CARTÃO", "BOLETO", "TED", "OUTRO"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(449, 234)
        Me.cmb_pagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pagamento.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(334, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Forma de pagamento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(53, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 15)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Forma de atendimento:"
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.ForeColor = System.Drawing.Color.Black
        Me.txt_comp.Location = New System.Drawing.Point(369, 208)
        Me.txt_comp.MaxLength = 20
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(199, 21)
        Me.txt_comp.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(287, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Complemento:"
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.ForeColor = System.Drawing.Color.Black
        Me.txt_num.Location = New System.Drawing.Point(215, 209)
        Me.txt_num.MaxLength = 5
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(49, 21)
        Me.txt_num.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Número:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Data de nascimento:"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.ForeColor = System.Drawing.Color.Black
        Me.txt_cidade.Location = New System.Drawing.Point(355, 179)
        Me.txt_cidade.MaxLength = 40
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(192, 21)
        Me.txt_cidade.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cidade:"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.ForeColor = System.Drawing.Color.Black
        Me.txt_bairro.Location = New System.Drawing.Point(99, 178)
        Me.txt_bairro.MaxLength = 40
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(192, 21)
        Me.txt_bairro.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Bairro:"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.ForeColor = System.Drawing.Color.Black
        Me.txt_endereco.Location = New System.Drawing.Point(256, 151)
        Me.txt_endereco.MaxLength = 60
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(400, 21)
        Me.txt_endereco.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Endereço:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CEP:"
        '
        'txt_nome_responsavel
        '
        Me.txt_nome_responsavel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_responsavel.ForeColor = System.Drawing.Color.Black
        Me.txt_nome_responsavel.Location = New System.Drawing.Point(283, 126)
        Me.txt_nome_responsavel.MaxLength = 60
        Me.txt_nome_responsavel.Name = "txt_nome_responsavel"
        Me.txt_nome_responsavel.Size = New System.Drawing.Size(315, 21)
        Me.txt_nome_responsavel.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nome do responsável (caso menor de idade):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(278, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cadastro de Cliente"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(100, 73)
        Me.txt_nome.MaxLength = 60
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(348, 21)
        Me.txt_nome.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CPF"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 26)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 383)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 58
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.MinimumWidth = 8
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 58
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_cadastro_cliente"
        Me.Text = "Cadastro de Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.btn_filtro.ResumeLayout(False)
        Me.btn_filtro.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_conv_nao As CheckBox
    Friend WithEvents chk_conv_sim As CheckBox
    Friend WithEvents chk_online As CheckBox
    Friend WithEvents chk_presencial As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_responsavel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents lbl_excluir As Label
    Friend WithEvents lbl_cancelar As Label
    Friend WithEvents btn_filtro As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Date_nascimento As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents TelaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeslogarToolStripMenuItem As ToolStripMenuItem
End Class
