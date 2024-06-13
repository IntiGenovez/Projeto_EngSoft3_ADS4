Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Form_cadastro_cliente

    Private Sub Form_cadastro_cliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sair = True Then
            desejaSair()
            If resp = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub TelaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_cadastro_cliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If txt_cpf.Text = "" Or
            txt_nome.Text = "" Or
            txt_celular.Text = "" Or
            Date_nascimento.Value = Today Or
            Not (txt_email.Text.Contains("@") And txt_email.Text.Contains(".")) Or
            chk_presencial.Checked = False And chk_online.Checked = False Or
            chk_conv_sim.Checked = False And chk_conv_nao.Checked = False Or
            cmb_pagamento.SelectedItem = "Selecione..." Or
            cmb_pagamento.Text = "" Or
            txt_valor.Text = "" Then

            MsgBox("Complete os campos obrigatórios!",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

        Else
            numTel = Regex.Replace(txt_celular.Text, "[^0-9]", "")
            sql = "select * from tb_clientes where cpf ='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_clientes values('" & txt_cpf.Text & "', '" &
                       txt_nome.Text & "', '" & Date_nascimento.Value.Date & "', '" &
                       txt_email.Text & "', '" & numTel & "', '" &
                       txt_nome_responsavel.Text & "', '" & txt_cep.Text & "', '" &
                       txt_endereco.Text & "', '" & txt_bairro.Text & "', '" &
                       txt_cidade.Text & "', '" & txt_uf.Text & "', '" &
                       txt_num.Text & "', '" & txt_comp.Text & "', '" &
                       atendimento & "', '" & cmb_pagamento.Text & "', '" &
                       txt_valor.Text & "', '" & convenio & "','" & Today.Date & "')"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados cadastrados com sucesso!",
                       MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_cpf.Focus()
            ElseIf btn_cadastrar.Text = "Salvar" Then 'caso modo edição
                sql = "update tb_clientes set nome='" & txt_nome.Text &
                      "', data_nasc='" & Date_nascimento.Value &
                      "', email='" & txt_email.Text & "', celular='" & txt_celular.Text &
                      "', nome_responsavel='" & txt_nome_responsavel.Text &
                      "', cep='" & txt_cep.Text & "', endereco='" & txt_endereco.Text &
                      "', bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text &
                      "', uf='" & txt_uf.Text & "', numero='" & txt_num.Text &
                      "', complemento='" & txt_comp.Text & "', atendimento='" & atendimento &
                      "', form_pagamento='" & cmb_pagamento.Text & "', valor='" & txt_valor.Text &
                      "', convenio='" & convenio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Cadastro atualizado com sucesso!",
                        MsgBoxStyle.Information, "ATENÇÃO")
                fimEdicaoCliente()
            Else
                MsgBox("CPF já cadastrado!",
                        MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_cpf.Clear()
                txt_cpf.Focus()
            End If
            limparDadosCliente()
            carregarDadosClientes()
        End If
    End Sub

    Private Sub chk_presencial_CheckedChanged(sender As Object, e As EventArgs) Handles chk_presencial.CheckedChanged
        If limpando Then
            Exit Sub
        Else
            If chk_presencial.Checked = True Then
                atendimento = "PRESENCIAL"
                chk_online.Checked = False
            ElseIf chk_online.Checked = False Then
                chk_presencial.Checked = True
            End If
        End If
    End Sub

    Private Sub chk_online_CheckedChanged(sender As Object, e As EventArgs) Handles chk_online.CheckedChanged
        If limpando Then
            Exit Sub
        Else
            If chk_online.Checked = True Then
                atendimento = "ONLINE"
                chk_presencial.Checked = False
            ElseIf chk_presencial.Checked = False Then
                chk_online.Checked = True
            End If
        End If
    End Sub

    Private Sub chk_conv_sim_CheckedChanged(sender As Object, e As EventArgs) Handles chk_conv_sim.CheckedChanged
        If limpando Then
            Exit Sub
        Else
            If chk_conv_sim.Checked = True Then
                convenio = "SIM"
                chk_conv_nao.Checked = False
            ElseIf chk_conv_nao.Checked = False Then
                chk_conv_sim.Checked = True
            End If
        End If
    End Sub

    Private Sub chk_conv_nao_CheckedChanged(sender As Object, e As EventArgs) Handles chk_conv_nao.CheckedChanged
        If limpando Then
            Exit Sub
        Else
            If chk_conv_nao.Checked = True Then
                convenio = "NÃO"
                chk_conv_sim.Checked = False
            ElseIf chk_conv_sim.Checked = False Then
                chk_conv_nao.Checked = True
            End If
        End If
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus
        If Not (txt_email.Text.Contains("@") And
           txt_email.Text.Contains(".")) Then

            MsgBox("Email incompleto!")
            txt_email.BackColor = Color.FromArgb(255, 255, 200)
        Else
            txt_email.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub Form_cadastro_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosClientes()
        If acessoAdm = False Then
            TabControl1.TabPages.Remove(TabPage2)
        End If
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(6).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value
                    TabControl1.SelectTab(0) 'selecione a aba dados pessoais
                    sql = "select * from tb_clientes where cpf='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        Date_nascimento.Value = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        txt_celular.Text = rs.Fields(4).Value
                        txt_nome_responsavel.Text = rs.Fields(5).Value
                        txt_cep.Text = rs.Fields(6).Value
                        txt_endereco.Text = rs.Fields(7).Value
                        txt_bairro.Text = rs.Fields(8).Value
                        txt_cidade.Text = rs.Fields(9).Value
                        txt_uf.Text = rs.Fields(10).Value
                        txt_num.Text = rs.Fields(11).Value
                        txt_comp.Text = rs.Fields(12).Value
                        cmb_pagamento.SelectedItem = rs.Fields(14).Value
                        txt_valor.Text = rs.Fields(15).Value

                        If rs.Fields(13).Value = "PRESENCIAL" Then
                            chk_presencial.Checked = True
                        Else
                            chk_online.Checked = True
                        End If

                        If rs.Fields(16).Value = "SIM" Then
                            chk_conv_sim.Checked = True
                        Else
                            chk_conv_nao.Checked = True
                        End If
                        modoEdicaoCliente()

                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_clientes where cpf='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o CPF: " & aux & "?",
                                       MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = vbYes Then
                            sql = "delete * from tb_clientes where cpf='" & aux & "'"
                            rs = db.Execute(sql)
                            MsgBox("Cadastro excluido com sucesso!",
                                   MsgBoxStyle.Information, "ATENÇÃO")
                        End If
                    End If
                End If
                carregarDadosClientes()
            End With
        Catch ex As Exception
            MsgBox("erro")
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        fimEdicaoCliente()
        limparDadosCliente()
        carregarDadosClientes()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            resp = MsgBox("Deseja realmente excluir o CPF: " & txt_cpf.Text & "?",
                           MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete * from tb_clientes where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Cadastro excluido com sucesso!",
                       MsgBoxStyle.Information, "ATENÇÃO")
                fimEdicaoCliente()
                carregarDadosClientes()
            End If
        End If
    End Sub

    Private Sub TelaInicialToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TelaInicialToolStripMenuItem.Click
        Form_tela_principal.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub DeslogarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DeslogarToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "ATENÇÃO!")
        If resp = vbYes Then
            Form_tela_login.Show()
            sair = False
            Me.Close()
        End If
    End Sub

    Private Sub txt_busca_Click(sender As Object, e As EventArgs) Handles txt_busca.Click

    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            If cmb_filtro.Text = "" Then
                cmb_filtro.SelectedItem = "Nome"
            End If
            If cmb_filtro.Text = "Nome" Then
                sql = "select * from tb_clientes where nome like '%" & txt_busca.Text & "%'"
            Else
                sql = "select * from tb_clientes where cpf like '%" & txt_busca.Text & "%'"
            End If
            rs = db.Execute(UCase(sql))
            With dgv_dados
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

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class