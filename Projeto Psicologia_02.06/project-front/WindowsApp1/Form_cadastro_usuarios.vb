Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Form_cadastro_usuarios

    Private Sub Form_cadastro_funcionarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sair = True
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Form_cadastro_funcionarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sair = True Then
            desejaSair()
            If resp = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_login.Text = "" Or
          txt_cpf.Text = "" Or
          txt_nome.Text = "" Or
          txt_email.Text = "" Or
          Not (txt_email.Text.Contains("@") And txt_email.Text.Contains(".")) Or
          txt_celular.Text = "" Or
          txt_senha.Text = "" Or
          cmb_acesso.SelectedItem = "Selecione..." Or
          cmb_acesso.Text = "" Then

            MsgBox("Preencha todos os campos!",
                    MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

        Else
            If txt_senha.Text <> txt_confirm_senha.Text Then
                MsgBox("As senhas não confere!",
                    MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                sql = "select * from tb_usuarios where login ='" & txt_login.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    numTel = Regex.Replace(txt_celular.Text, "[^0-9]", "")
                    sql = "insert into tb_usuarios values('" & txt_login.Text &
                          "', '" & txt_cpf.Text & "', '" & UCase(txt_nome.Text) &
                          "', '" & UCase(txt_email.Text) & "', '" & numTel &
                          "', '" & txt_senha.Text & "', '" & cmb_acesso.Text &
                          "', '" & date_inicio.Value.Date & "', '" & Nothing & "')"
                    rs = db.Execute(sql)

                    MsgBox("Dados cadastrados com sucesso!",
                            MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limparDadosUsuario()
                ElseIf btn_salvar.Text = "Salvar" Then
                    numTel = Regex.Replace(txt_celular.Text, "[^0-9]", "")
                    sql = "update tb_usuarios set cpf ='" & txt_cpf.Text &
                          "', nome='" & UCase(txt_nome.Text) & "', email ='" & UCase(txt_email.Text) &
                          "', celular='" & numTel & "', senha='" & txt_senha.Text &
                          "', acesso='" & cmb_acesso.Text & "' where login='" & txt_login.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Cadastro atualizado com sucesso",
                            MsgBoxStyle.Information, "ATENÇÃO")
                    fimEdicaoUsuarios()
                Else
                    MsgBox("Esse nome de login já existe", MsgBoxStyle.Information, "ATENÇÃO")
                    txt_login.Focus()
                End If
            End If
        End If
        carregarDadosUsuarios()
    End Sub

    Private Sub chk_vizu_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vizu_senha.CheckedChanged
        If chk_vizu_senha.Checked = True Then
            txt_senha.PasswordChar = ""
            txt_confirm_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
            txt_confirm_senha.PasswordChar = "*"
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

    Private Sub Form_cadastro_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosUsuarios()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(2).Value
                    TabControl1.SelectTab(0) 'selecione a aba dados pessoais
                    sql = "select * from tb_usuarios where login='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_login.Text = rs.Fields(0).Value
                        txt_cpf.Text = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        txt_celular.Text = rs.Fields(4).Value
                        txt_senha.Text = rs.Fields(5).Value
                        cmb_acesso.SelectedItem = rs.Fields(6).Value
                        date_inicio.Value = rs.Fields(7).Value
                        btn_salvar.Text = "Salvar"
                        btn_cancelar.Visible = True
                        btn_excluir.Visible = True
                        lbl_excluir.Visible = True
                        txt_login.ReadOnly = True
                        txt_cpf.ReadOnly = True
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux = .CurrentRow.Cells(2).Value
                    sql = "select * from tb_usuarios where login='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o login: " & aux & "?",
                                       MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = vbYes Then
                            sql = "delete * from tb_usuarios where login='" & aux & "'"
                            rs = db.Execute(sql)
                        End If
                    End If
                End If
                carregarDadosUsuarios()
            End With
        Catch ex As Exception
            MsgBox("erro")
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        fimEdicaoUsuarios()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        sql = "select * from tb_usuarios where login='" & txt_login.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            resp = MsgBox("Deseja realmente excluir o login: " & txt_login.Text & "?",
                           MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete * from tb_usuarios where login='" & txt_login.Text & "'"
                rs = db.Execute(sql)
                carregarDadosUsuarios()
                fimEdicaoUsuarios()
            End If
        End If
    End Sub

    Private Sub TelaInícialToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TelaInícialToolStripMenuItem.Click
        Form_tela_principal.Show()
        sair = False
        Me.Close()
    End Sub

    Private Sub SairToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "ATENÇÃO!")
        If resp = vbYes Then
            Form_tela_login.Show()
            sair = False
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            If cmb_filtro.Text = "" Then
                cmb_filtro.SelectedItem = "Login"
            End If
            If cmb_filtro.Text = "Nome" Then
                sql = "select * from tb_usuarios where nome like '%" & UCase(txt_busca.Text) & "%'"
            ElseIf cmb_filtro.Text = "CPF" Then
                sql = "select * from tb_usuarios where cpf like '%" & txt_busca.Text & "%'"
            Else
                sql = "select * from tb_usuarios where login like '%" & txt_busca.Text & "%'"
            End If
            rs = db.Execute(sql)
            With dgv_dados
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

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles txt_busca.Click

    End Sub
End Class