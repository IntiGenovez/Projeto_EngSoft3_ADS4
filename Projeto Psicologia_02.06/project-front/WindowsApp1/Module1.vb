Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public app As New Microsoft.Office.Interop.Access.Application
    Public cont, id_conta, tentativa As Integer
    Public diretorio, sql, resp, nome, aux, convenio, atendimento, numTel As String
    Public dir_banco = Application.StartupPath & "\banco\banco.mdb"
    Public teste, sair, acessoAdm As Boolean
    Public limpando As Boolean = False
    'a variavel sair diz se é para aparecer a mensagem "deseja realmente sair"
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub desejaSair()
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Information + vbYesNo, "ATENÇÃO")
    End Sub

    Sub limparDadosCliente()
        limpando = True
        With Form_cadastro_cliente
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .Date_nascimento.Value = Today
            .txt_email.Clear()
            .txt_celular.Clear()
            .txt_nome_responsavel.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_uf.Clear()
            .txt_num.Clear()
            .txt_comp.Clear()
            .cmb_pagamento.SelectedItem = "Selecione..."
            .txt_valor.Clear()
            .chk_online.Checked = False
            .chk_presencial.Checked = False
            .chk_conv_sim.Checked = False
            .chk_conv_nao.Checked = False
            atendimento = ""
            convenio = ""
        End With
        limpando = False
    End Sub

    Sub limparDadosUsuario()
        With Form_cadastro_usuarios
            .txt_login.Clear()
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_celular.Clear()
            .txt_confirm_senha.Clear()
            .txt_senha.Clear()
            .cmb_acesso.SelectedItem = "Selecione..."
            .date_inicio.Value = Today
        End With
    End Sub
    Sub carregarDadosUsuarios()
        Try
            sql = "select * from tb_usuarios order by login asc" 'Puxa os logins em ordem alfabética
            rs = db.Execute(sql)
            With Form_cadastro_usuarios.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value,
                              rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Sub carregarDadosClientes()
        Try
            sql = "select * from tb_clientes order by nome asc" 'Puxa os logins em ordem alfabética
            rs = db.Execute(sql)
            With Form_cadastro_cliente.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value,
                              rs.Fields(4).Value, rs.Fields(14).Value,
                              rs.Fields(15).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Sub carregarDadosFinanceiros()
        Try
            sql = "select * from tb_clientes order by nome asc" 'Puxa os logins em ordem alfabética
            rs = db.Execute(sql)
            With form_pagamento.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value,
                              rs.Fields(15).Value, rs.Fields(17).Value, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
    Sub fimEdicaoCliente()
        limparDadosCliente()
        With Form_cadastro_cliente
            .btn_cadastrar.Text = "Cadastrar"
            .btn_excluir.Visible = False
            .btn_cancel.Visible = False
            .lbl_cancelar.Visible = False
            .lbl_excluir.Visible = False
            .txt_cpf.ReadOnly = False
            .txt_cpf.Focus()
        End With
    End Sub
    Sub modoEdicaoCliente()
        With Form_cadastro_cliente
            .btn_cadastrar.Text = "Salvar"
            .btn_excluir.Visible = True
            .btn_cancel.Visible = True
            .lbl_cancelar.Visible = True
            .lbl_excluir.Visible = True
            .txt_cpf.ReadOnly = True
            .txt_nome.Focus()
        End With
    End Sub

    Sub fimEdicaoUsuarios()
        limparDadosUsuario()
        With Form_cadastro_usuarios
            .btn_salvar.Text = "Cadastrar"
            .btn_cancelar.Visible = False
            .txt_login.ReadOnly = False
            .txt_cpf.ReadOnly = False
            .btn_excluir.Visible = False
            .lbl_excluir.Visible = False
        End With
    End Sub
    Sub carregarDadosRelat()
        Try
            sql = "select * from tb_clientes order by nome asc" 'Puxa os logins em ordem alfabética
            rs = db.Execute(sql)
            With Form_gerar_relat.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub
End Module
