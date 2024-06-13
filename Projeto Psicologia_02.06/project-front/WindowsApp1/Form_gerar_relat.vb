Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Access

Public Class Form_gerar_relat
    Private Sub btn_gerar_relat_Click(sender As Object, e As EventArgs) Handles btn_gerar_relat.Click
        Try
            app.OpenCurrentDatabase(dir_banco) 'conecta com o Access
            If cmb_tipo_relat.SelectedItem = "Relatório de pagamentos" Then
                app.DoCmd.OpenReport("relat_pagamentos", Microsoft.Office.Interop.Access.AcView.acViewPreview)
                app.DoCmd.Maximize() 'muda pra tela cheia 
            ElseIf cmb_tipo_relat.SelectedItem = "Listagem de Clientes" Then
                app.DoCmd.OpenReport("relat_geral_clientes", Microsoft.Office.Interop.Access.AcView.acViewPreview)
                app.DoCmd.Maximize()
            ElseIf cmb_tipo_relat.Text = "Ficha de Cliente" Then
                Me.Hide()
                Try
                    app.DoCmd.OpenReport("relat_cliente", Microsoft.Office.Interop.Access.AcView.acViewPreview)
                    app.DoCmd.Maximize()
                    Me.Show()
                Catch es As Exception
                    Me.Show()
                End Try
            Else
                MsgBox("Selecione um tipo de relatório!",
                       MsgBoxStyle.Exclamation, "ATENÇÃO!")
                tentativa = 0
            End If
            cmb_tipo_relat.SelectedItem = "Selecione..."
        Catch ex As Exception
            Try
                If tentativa <= 1 Then
                    app.CloseCurrentDatabase() 'fecha o banco para testar se era esse o problema
                    tentativa = tentativa + 1
                    btn_gerar_relat.PerformClick() 'reseta a função
                Else
                    resp = MsgBox("Ocorreu um erro na geração do relatório!" + vbNewLine +
                                  "Tentar novamente", MsgBoxStyle.Exclamation, "ATENÇÃO")
                    tentativa = 0
                    cmb_tipo_relat.SelectedItem = "Selecione..."
                End If
            Catch es As Exception
            End Try
        End Try

    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form_gerar_relat_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
        Try
            app.CloseCurrentDatabase() 'fecha a conexão quando o form fecha
        Catch ex As Exception

        End Try
    End Sub


    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub Form_gerar_relat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosRelat()
        tentativa = 0 'diz quantas tentativas de abrir o relatório foram feitas
    End Sub

    Private Sub Form_gerar_relat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sair = True Then
            desejaSair()
            If resp = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub TelaInicialToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TelaInicialToolStripMenuItem.Click
        Form_tela_principal.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub DeslogarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeslogarToolStripMenuItem.Click
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
    Private Sub cmb_tipo_relat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_relat.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(3).Selected = True Then
                aux = .CurrentRow.Cells(1).Value
                Clipboard.SetText(aux)
                MsgBox("CPF " & aux & " copiado para área de transferência!",
                       MsgBoxStyle.Information, "ATENÇÃO!")
                TabControl1.SelectTab(0)
            End If
        End With
    End Sub
End Class