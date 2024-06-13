Imports System.ComponentModel

Public Class Form_tela_principal
    Private Sub Form_tela_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sair = True
        If acessoAdm Then
            btn_usuarios.Visible = True
        End If
    End Sub
    Private Sub Form_tela_principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sair = True Then
            desejaSair()
            If resp = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Form_cadastro_cliente.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub btn_pagamentos_Click(sender As Object, e As EventArgs) Handles btn_pagamentos.Click
        form_pagamento.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "ATENÇÃO!")
        If resp = vbYes Then
            Form_tela_login.Show()
            sair = False
            Me.Close()
        End If
    End Sub

    Private Sub Form_tela_principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        Form_cadastro_usuarios.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs) Handles btn_relatorios.Click
        Form_gerar_relat.Show()
        sair = False
        Me.Close()
    End Sub
End Class