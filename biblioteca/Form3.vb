Imports System.Globalization
Imports System.IO
Imports System.Net

Public Class Form3

    Dim checkoutFilePath As String = "checkout_info.txt"
    Private mainForm As Form1

    Public Sub New()
    End Sub

    Public Sub New(mainForm As Form1, bookID As String)
        InitializeComponent()
        Me.mainForm = mainForm
        Me.bookID = bookID
        LoadClientInfo()
    End Sub

    Private Sub StoreCheckoutInfo(bookID As String, clientDetails As String)
        ' Store checkout details in the specified checkout file
        Dim checkoutInfo As String = $"{bookID} | {clientDetails}"
        File.AppendAllText(checkoutFilePath, checkoutInfo & Environment.NewLine)
    End Sub

    ' Method to handle the button click event in Form3
    Private Sub Button_SaveCheckout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Assuming Form3 has text boxes text_nome, text_localidade, text_nif, and text_contacto
        Dim clientDetails As String = $"{text_nome.Text}, {text_localidade.Text}, {text_nif.Text}, {text_contacto.Text}"

        ' Access book ID from mainForm
        Dim livroSelecionado As ListViewItem = mainForm.ListaLivros.SelectedItems(0)
        Dim bookID As String = livroSelecionado.SubItems(2).Text ' Assuming the book ID is in the third column

        ' Store checkout details using the function in Form1
        StoreCheckoutInfo(bookID, clientDetails)

        livroSelecionado.SubItems(4).Text = "Emprestado"
        livroSelecionado.SubItems(5).Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy")

        mainForm.GuardarDados()

        MessageBox.Show("Livro Emprestado.")
        ' Close Form3
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button_Renovar_Click(sender As Object, e As EventArgs) Handles Button_renovar.Click
        ' Simulação de Renovação
        If mainForm.ListaLivros.SelectedItems.Count > 0 AndAlso mainForm.ListaLivros.SelectedItems(0).SubItems(4).Text = "Emprestado" Then

            Dim livroSelecionado As ListViewItem = mainForm.ListaLivros.SelectedItems(0)
            Dim selectedDate As DateTime = livroSelecionado.SubItems(5).Text ' Assuming the date is in the sixth column

            Dim newDate As DateTime = selectedDate.AddDays(14).ToString("dd/MM/yyyy")

            mainForm.ListaLivros.SelectedItems(0).SubItems(5).Text = newDate
            mainForm.GuardarDados()
            MessageBox.Show("Renovação bem-sucedida!")
        Else
                MessageBox.Show("Não é possível renovar o livro no momento.")
            End If
    End Sub

    Dim bookID As String = ""

    Public Sub New(selectedBookID As String)
        InitializeComponent()
        bookID = selectedBookID
        LoadClientInfo()
    End Sub

    Private Sub LoadClientInfo()
        ' Read the checkout file and find the most recent checkout for the selected book ID
        Dim latestCheckout As String = FindLatestCheckoutForBookID(bookID)

        ' Display the latest checkout details in the respective text boxes
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
