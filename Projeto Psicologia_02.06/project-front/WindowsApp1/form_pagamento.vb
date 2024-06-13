Imports System.ComponentModel

Public Class form_pagamento

    Private Sub form_pagamento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sair = True Then
            desejaSair()
            If resp = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub form_pagamento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub form_pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosFinanceiros()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        ' Try
        With dgv_dados
            If .CurrentRow.Cells(5).Selected = True Then
                aux = .CurrentRow.Cells(1).Value
                TabControl1.SelectTab(1) 'selecione a aba dados pessoais
                sql = "select * from tb_clientes where cpf='" & aux & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_cpf.Text = rs.Fields(0).Value
                    txt_nome.Text = rs.Fields(1).Value
                    txt_data_ult_pag.Text = rs.Fields(17).Value
                End If
            End If
        End With
        ' Catch ex As Exception
        '  MsgBox("erro")
        ' End Try
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If cmb_form_pag.SelectedItem <> "Selecione..." And
           cmb_form_pag.Text <> "" And
           txt_valor.Text <> "" Then

            sql = "update tb_clientes set form_pagamento ='" & UCase(cmb_form_pag.Text) &
                    "', valor ='" & txt_valor.Text & "', ultimo_pag ='" & date_novo_pagamento.Value.Date &
                    "' where cpf ='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Dados atualizados com sucesso!", +MsgBoxStyle.Information, "Pagamento")
            txt_nome.Clear()
            txt_cpf.Clear()
            txt_data_ult_pag.Clear()
            txt_valor.Clear()
            cmb_form_pag.SelectedItem = "Selecione..."
            date_novo_pagamento.Value = Today
            carregarDadosFinanceiros()
        Else
            MsgBox("Preencha todos os campos!")
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
                sql = "select * from tb_clientes where nome like '%" & UCase(txt_busca.Text) & "%'"
            Else
                sql = "select * from tb_clientes where cpf like '%" & txt_busca.Text & "%'"
            End If
            rs = db.Execute(sql)
            With dgv_dados
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
End Class