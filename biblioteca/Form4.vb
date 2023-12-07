Imports System.IO

Public Class Form4
    ' Declaração de variável para o caminho do arquivo de checkout
    Dim checkoutFilePath As String = "checkout_info.txt"

    ' Variável para armazenar o ID do livro selecionado
    Dim bookID As String = ""

    ' Construtor da classe Form4 que recebe o ID do livro selecionado
    Public Sub New(selectedBookID As String)
        InitializeComponent()
        ' Define o ID do livro selecionado
        bookID = selectedBookID
        ' Carrega as informações do cliente relacionadas ao livro selecionado
        LoadClientInfo()
    End Sub

    ' Método para carregar as informações do cliente relacionadas ao livro selecionado
    Private Sub LoadClientInfo()
        ' Lê o arquivo de checkout e encontra o checkout mais recente para o ID do livro selecionado
        Dim latestCheckout As String = FindLatestCheckoutForBookID(bookID)

        ' Exibe os detalhes do checkout mais recente nos respectivos campos de texto
        If Not String.IsNullOrEmpty(latestCheckout) Then
            Dim checkoutDetails As String() = latestCheckout.Split("|"c)
            If checkoutDetails.Length >= 2 Then
                Dim clientDetails As String() = checkoutDetails(1).Split(","c)
                If clientDetails.Length >= 4 Then
                    ' Preenche os campos de texto com as informações do cliente
                    text_nome.Text = clientDetails(0).Trim()
                    text_localidade.Text = clientDetails(1).Trim()
                    text_nif.Text = clientDetails(2).Trim()
                    text_contacto.Text = clientDetails(3).Trim()
                End If
            End If
        End If
    End Sub

    ' Função para encontrar o checkout mais recente para um determinado ID de livro
    Private Function FindLatestCheckoutForBookID(bookID As String) As String
        Dim latestCheckout As String = ""
        ' Lê todas as linhas do arquivo de checkout
        Dim lines As String() = File.ReadAllLines(checkoutFilePath)

        ' Percorre as linhas do arquivo de checkout de trás para frente para encontrar o checkout mais recente para o ID do livro
        For i As Integer = lines.Length - 1 To 0 Step -1
            Dim parts As String() = lines(i).Split("|"c)
            If parts.Length >= 2 AndAlso parts(0).Trim() = bookID.Trim() Then
                ' Se encontrar um checkout correspondente ao ID do livro, armazena como o checkout mais recente
                latestCheckout = lines(i)
                Exit For
            End If
        Next

        Return latestCheckout ' Retorna o checkout mais recente encontrado
    End Function

End Class
