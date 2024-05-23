Module FrmFormulario
    Public campo(0) As String

    Public Sub ContarLinhasGrid(ByRef dgv As DataGridView, ByRef lblContador As Label)
        Dim numLinhas As Integer = dgv.RowCount
        lblContador.Text = numLinhas.ToString() & " Registros"
    End Sub

End Module
