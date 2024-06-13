Imports System.Net.Http

Public Class Form_tela_login

    Private Sub Form_tela_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        acessoAdm = False
        Me.lnk_esqueci_senha.Visible = False
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs)
        Try
            If txt_login.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Preencha o login e a senha!", "ATENÇÃO!")
            Else
                sql = "select * from tb_usuarios where login ='" & txt_login.Text &
                  "' and senha ='" & txt_senha.Text & "'"
                rs = db.Execute(sql)
                If rs.Fields(6).Value = "Administrador" Then
                    acessoAdm = True
                Else
                    acessoAdm = False
                End If
                If rs.EOF = False Then
                    txt_login.Text = ""
                    txt_senha.Text = ""
                    Form_tela_principal.Show()
                    Me.Close()
                Else
                    MsgBox("Login ou senha inválidos!",
                                MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer login")
        End Try
    End Sub

    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If chk_visualizar.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub Form_tela_login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
    End Sub

    Private Sub lnk_esqueci_senha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_esqueci_senha.LinkClicked

        sql = "select * from tb_usuarios where login = '" & InputBox("Digite o usuario", "Recuperar senha") & "'"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            Dim client As New HttpClient()
            Dim uri As New Uri("https://api.callmebot.com/whatsapp.php?phone=+" & rs.Fields(4).Value & "&text=Prezado+" & rs.Fields(2).Value & ",+sua+senha+é+" & rs.Fields(5).Value & "&apikey=" & rs.Fields(8).Value)
            client.GetAsync(uri)
            MsgBox("Sua senha foi enviada!",
                    MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            'Process.Start("https://api.callmebot.com/whatsapp.php?phone=+" & rs.Fields(4).Value & "&text=Prezado+" & rs.Fields(2).Value & ",+sua+senha+é+" & rs.Fields(5).Value & "&apikey=" & rs.Fields(8).Value)
        Else
            MsgBox("conta inválida")
        End If
    End Sub
End Class
