Imports System.Data.SqlClient
Imports Microsoft.Win32.SafeHandles

Public Class Frm_Login

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result = MessageBox.Show("Deseja Cancelar a entrada no sistema?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtAcessar_Click(sender As Object, e As EventArgs) Handles BtAcessar.Click
        '        Frm_Principal.Show()
        login()

    End Sub
    Private Sub carregausuario()
        CbUsuario.Items.Clear()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_USUARIOS, NOME FROM USUARIOS  WHERE ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbUsuario.DisplayMember = ("NOME")
                CbUsuario.ValueMember = ("ID_USUARIOS")
                CbUsuario.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregausuario()
    End Sub
    Public Sub NOMEUSER()
        Dim NOME As String
        NOME = CbUsuario.Text
        Frm_Principal.USUARIO.Text = NOME
    End Sub
    Public Sub login()
        Dim acessopermitido As Boolean

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()

                Using cmd = New SqlCommand("SELECT NOME,SENHA FROM USUARIOS WHERE NOME=@nome AND SENHA=@senha", cn)
                    cmd.Parameters.AddWithValue("@nome", CbUsuario.Text)
                    cmd.Parameters.AddWithValue("@senha", TSenha.Text)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("senha") = TSenha.Text Then
                                    acessopermitido = True
                                End If
                            End If
                        End If
                    End Using
                    cn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha ao conectar ao banco login!", vbInformation, "Aviso")
        End Try
        If acessopermitido Then

            Frm_Principal.Show()
            Frm_Principal.TlbNomeusuario.Text = "Usuário: " + CbUsuario.Text
            NOMEUSER()
            Me.Dispose()
        Else
            MsgBox("Usuário ou senha incorreta, favor verificar!", vbInformation, "Aviso.")
            TSenha.Focus()
            TSenha.Text = ""
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Frm_ConexaoDb.ShowDialog()
    End Sub

End Class
