Imports System.IO

Public Class Form4
    Dim checkoutFilePath As String = "checkout_info.txt"

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
