Imports System.Net.Http
Imports System.Text


Public Class MinhaClasse
    Public Async Function FazerChamadaOAuth2() As Task(Of String)
        ' Configuração das credenciais e da URL do token
        Dim clientId As String = "b4c26229-d805-3b0e-9240-34ca863fb009"
        Dim clientSecret As String = "3df7a719-3ead-409b-a446-4bd44f24b3a2"
        Dim tokenUrl As String = "https://sandbox.devportal.itau.com.br/api/oauth/jwt"

        ' Construção do corpo da solicitação
        Dim requestBody As New StringBuilder()
        requestBody.Append("client_id=")
        requestBody.Append(Uri.EscapeDataString(clientId))
        requestBody.Append("&client_secret=")
        requestBody.Append(Uri.EscapeDataString(clientSecret))
        requestBody.Append("&grant_type=client_credentials")

        ' Criação do cliente HTTP
        Using httpClient As New HttpClient()
            Try
                ' Envia a solicitação POST para obter o token
                Dim response As HttpResponseMessage = Await httpClient.PostAsync(tokenUrl, New StringContent(requestBody.ToString(), Encoding.UTF8, "application/x-www-form-urlencoded"))

                ' Verifica se a resposta foi bem-sucedida
                If response.IsSuccessStatusCode Then
                    ' Lê e retorna o token de acesso
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Dim accessToken As String = Newtonsoft.Json.Linq.JObject.Parse(responseContent).GetValue("access_token").ToString()
                    Return accessToken
                Else
                    ' Se a resposta não for bem-sucedida, imprime o código de status
                    Console.WriteLine("Erro ao obter token de acesso. Código de status: " & response.StatusCode)
                End If
            Catch ex As Exception
                ' Se ocorrer um erro durante a solicitação, imprime a mensagem de erro
                Console.WriteLine("Erro durante a solicitação HTTP: " & ex.Message)
            End Try
        End Using

        ' Em caso de falha, retorna uma string vazia
        Return String.Empty
    End Function
End Class

