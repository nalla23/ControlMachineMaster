Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frm_systema
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BBuscar.Click, BBuscar.Click, BBuscar.Click
        buscaprocessador()
        Buscadados()
        buscamemoria()

    End Sub

    Private Sub buscaprocessador()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")

            For Each queryObj As ManagementObject In searcher.Get()
                Dim processorName As String = queryObj("Name").ToString()
                Dim processorManufacturer As String = queryObj("Manufacturer").ToString()
                Dim numberOfCores As Integer = Convert.ToInt32(queryObj("NumberOfCores"))

                Tusuario.Text = Environment.UserName
                Tprocessador.Text = processorName & "Qtde Nucleos" & numberOfCores
                Tsistema.Text = My.Computer.Info.OSFullName
            Next
        Catch ex As ManagementException
            MessageBox.Show("Erro ao acessar informações do processador: " & ex.Message)
        End Try
    End Sub

    Private Sub Buscadados()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_ComputerSystem")

            For Each queryObj As ManagementObject In searcher.Get()
                Dim computerName As String = queryObj("Name").ToString()
                Dim manufacturer As String = queryObj("Manufacturer").ToString()
                Dim model As String = queryObj("Model").ToString()
                Dim totalPhysicalMemory As ULong = Convert.ToUInt64(queryObj("TotalPhysicalMemory"))
                Tnome.Text = computerName
                TFabMod.Text = manufacturer & " - " & model

            Next
        Catch ex As ManagementException
            MessageBox.Show("Erro ao acessar informações do computador: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BFechar.Click, BFechar.Click
        Close()

    End Sub

    Private Sub buscamemoria()
        ' Consulta WMI para obter informações sobre a memória física instalada no sistema
        Dim query As String = "SELECT * FROM Win32_PhysicalMemory"

        ' Executa a consulta WMI
        Dim searcher As New ManagementObjectSearcher(query)
        Dim memTotalBytes As Long = 0

        ' Itera sobre os resultados da consulta para calcular a quantidade total de memória
        For Each queryObj As ManagementObject In searcher.Get()
            Dim capacity As ULong = Convert.ToUInt64(queryObj("Capacity"))
            ' Adiciona a capacidade da memória encontrada à quantidade total
            memTotalBytes += capacity
        Next

        ' Converte a quantidade total de bytes para gigabytes
        Dim memTotalGB As Double = memTotalBytes / (1024 ^ 3)

        ' Exibe a quantidade total de memória instalada
        ' MsgBox("Total de memória instalada: " & memTotalGB.ToString("0.##") & " GB")
        Tmemoria.Text = memTotalGB.ToString("0.##") & " GB"
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        MsgBox("Função em produção aguarde! ", vbInformation, "Aviso! ")
    End Sub
End Class