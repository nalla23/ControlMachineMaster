Public Class Frm_ConexaoDb
    ' Dim arquivo = "C:\ControlMachine\ControlMachine.ini"
    Private Sub lerarquivo()
        Me.Refresh()
        TServidor.Text = server
        TNome.Text = database
        TUsuario.Text = user
        TSenha.Text = password
        TCaminhorelatorio.Text = Caminho
    End Sub


    Private Sub bttestar_Click(sender As Object, e As EventArgs) Handles bttestar.Click
        Verifica_conexao()
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub
    Private Sub salvararquivo()
        escreveINI(arquivo, "CONFIG", "Servidor", TServidor.Text)
        escreveINI(arquivo, "CONFIG", "Dados", TNome.Text)
        escreveINI(arquivo, "CONFIG", "Usuario", TUsuario.Text)
        escreveINI(arquivo, "CONFIG", "Senha", TSenha.Text)
        escreveINI(arquivo, "RELATORIO", "Caminho", TCaminhorelatorio.Text)
        MsgBox("Registro salvo com sucesso!", vbInformation, "Aviso")
        Me.Refresh()
        lerarquivo()
        Me.Close()

    End Sub
    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click
        salvararquivo()
    End Sub

    Private Sub Frm_ConexaoDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lerarquivo()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class