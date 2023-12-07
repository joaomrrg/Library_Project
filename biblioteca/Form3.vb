Imports System.Globalization
Imports System.IO
Imports System.Net

Public Class Form3

    ' Declaração de variáveis e inicialização do caminho do arquivo de checkout
    Dim checkoutFilePath As String = "checkout_info.txt"
    Private mainForm As Form1

    ' Construtor da classe Form3 que recebe o formulário principal (mainForm) e o ID do livro
    Public Sub New(mainForm As Form1, bookID As String)
        InitializeComponent()
        Me.mainForm = mainForm
        Me.bookID = bookID
        LoadClientInfo()
    End Sub

    ' Método para armazenar informações de checkout no arquivo especificado
    Private Sub StoreCheckoutInfo(bookID As String, clientDetails As String)
        Dim checkoutInfo As String = $"{bookID} | {clientDetails}"
        File.AppendAllText(checkoutFilePath, checkoutInfo & Environment.NewLine)
    End Sub

    ' Método para lidar com o evento de clique do botão de salvar checkout em Form3
    Private Sub Button_SaveCheckout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtém detalhes do cliente a partir dos campos de texto
        Dim clientDetails As String = $"{text_nome.Text}, {text_localidade.Text}, {text_nif.Text}, {text_contacto.Text}"

        ' Acessa o ID do livro do mainForm
        Dim livroSelecionado As ListViewItem = mainForm.ListaLivros.SelectedItems(0)
        Dim bookID As String = livroSelecionado.SubItems(2).Text ' Presumindo que o ID do livro está na terceira coluna

        ' Armazena os detalhes do checkout usando a função em Form1
        StoreCheckoutInfo(bookID, clientDetails)

        ' Atualiza os detalhes na lista principal e salva os dados
        livroSelecionado.SubItems(4).Text = "Emprestado"
        livroSelecionado.SubItems(5).Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy")
        mainForm.GuardarDados()

        ' Exibe mensagem e fecha Form3
        MessageBox.Show("Livro Emprestado.")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Método para lidar com o evento de clique do botão de renovação em Form3
    Private Sub Button_Renovar_Click(sender As Object, e As EventArgs) Handles Button_renovar.Click
        ' Simula a renovação
        If mainForm.ListaLivros.SelectedItems.Count > 0 AndAlso mainForm.ListaLivros.SelectedItems(0).SubItems(4).Text = "Emprestado" Then

            Dim livroSelecionado As ListViewItem = mainForm.ListaLivros.SelectedItems(0)
            Dim selectedDate As DateTime = livroSelecionado.SubItems(5).Text ' Presumindo que a data está na sexta coluna

            Dim newDate As DateTime = selectedDate.AddDays(14).ToString("dd/MM/yyyy")

            mainForm.ListaLivros.SelectedItems(0).SubItems(5).Text = newDate
            mainForm.GuardarDados()
            MessageBox.Show("Renovação bem-sucedida!")
        Else
            MessageBox.Show("Não é possível renovar o livro no momento.")
        End If
    End Sub

    ' Declaração da variável bookID
    Dim bookID As String = ""

    ' Construtor da classe Form3 que recebe o ID do livro selecionado
    Public Sub New(selectedBookID As String)
        InitializeComponent()
        bookID = selectedBookID
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
                    text_nome.Text = clientDetails(0).Trim()
                    text_localidade.Text = clientDetails(1).Trim()
                    text_nif.Text = clientDetails(2).Trim()
                    text_contacto.Text = clientDetails(3).Trim()
                End If
            End If
        End If
    End Sub

    ' Método para encontrar o checkout mais recente para um determinado ID de livro
    Private Function FindLatestCheckoutForBookID(bookID As String) As String
        Dim latestCheckout As String = ""
        Dim lines As String() = File.ReadAllLines(checkoutFilePath)

        For i As Integer = lines.Length - 1 To 0 Step -1
            Dim parts As String() = lines(i).Split("|"c)
            If parts.Length >= 2 AndAlso parts(0).Trim() = bookID.Trim() Then
                latestCheckout = lines(i)
                Exit For
            End If
        Next

        Return latestCheckout
    End Function
End Class
