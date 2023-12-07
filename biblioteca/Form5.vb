Imports System.Globalization
Imports System.IO
Imports System.Net

Public Class Form5

    Dim filePathChechout As String = "checkout_info.txt"
    Dim filePathRecords As String = "book_records.txt"


    Private mainForm As Form1
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar dados do arquivo no início do programa
        ConfigurarColunas()
        CarregarDados()
    End Sub

    Private Sub ConfigurarColunas()
        ' Configurar as colunas para a ListaLivros
        lista_emprestimos.View = View.Details ' Definir o modo de exibição para Details
        ' Adicionar as colunas
        lista_emprestimos.Columns.Add("ID", 50)
        lista_emprestimos.Columns.Add("Título", 125)
        lista_emprestimos.Columns.Add("Cliente", 80)
        lista_emprestimos.Columns.Add("Estado", 80)
        lista_emprestimos.Columns.Add("Data de Devolução", 100)

        lista_multas.View = View.Details ' Definir o modo de exibição para Details
        ' Adicionar as colunas
        lista_multas.Columns.Add("ID", 50)
        lista_multas.Columns.Add("Título", 125)
        lista_multas.Columns.Add("Cliente", 80)
        lista_multas.Columns.Add("Data de Devolução", 100)
        lista_multas.Columns.Add("Multa", 100)
    End Sub

    Private Sub CarregarDados()
        If File.Exists(filePathChechout) Then
            ' Limpar a ListaLivros antes de carregar novos dados
            lista_emprestimos.Items.Clear()

            ' Carregar dados do arquivo para a ListaLivros
            ' (Formato do arquivo: Título do Livro | Disponibilidade (True/False) | Data de Devolução | ID | Autor | Ano)
            Using reader As New StreamReader(filePathChechout)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim id As String() = line.Split("|"c)
                    Dim parts As String() = id(1).Split(","c)

                    Dim bookInfo As String() = RetrieveBookInfoByID(id(0).Trim())

                    Console.WriteLine(id(0).Trim())
                    Console.Out.Flush()

                    ' Verificar se há informações suficientes antes de criar um ListViewItem

                    ' Criar um novo ListViewItem
                    Dim emprestimo As New ListViewItem(id(0).Trim())
                    ' Adicionar subitens ao ListViewItem
                    emprestimo.SubItems.Add(bookInfo(0).Trim())
                    emprestimo.SubItems.Add(parts(0).Trim())
                    emprestimo.SubItems.Add(bookInfo(4).Trim())
                    emprestimo.SubItems.Add(bookInfo(5).Trim())

                    lista_emprestimos.Items.Add(emprestimo)

                    Dim dateString As String = "06/12/2023"
                    Dim dateFormat As String = "dd/MM/yyyy"
                    Dim bookDueDate As DateTime
                    Dim provider As CultureInfo = CultureInfo.InvariantCulture

                    bookDueDate = DateTime.ParseExact(dateString, dateFormat, provider)

                    Dim DiasPassados As Integer = DateTime.Now.Subtract(bookDueDate).Days

                    Dim currentDate As DateTime = DateTime.Now.Date
                    If bookInfo(4).Trim().Equals("Emprestado") AndAlso bookDueDate.Date < currentDate Then
                        Dim atraso As New ListViewItem(id(0).Trim())
                        ' Adicionar subitens ao ListViewItem
                        atraso.SubItems.Add(bookInfo(0).Trim())
                        atraso.SubItems.Add(parts(0).Trim())
                        atraso.SubItems.Add(bookInfo(5).Trim())
                        atraso.SubItems.Add((DiasPassados * 0.35).ToString() + "€")
                        lista_multas.Items.Add(atraso)
                    End If

                End While
            End Using
        End If
    End Sub

    Dim filePath As String = "biblioteca.txt"

    Private Function RetrieveBookInfoByID(bookID As String) As String()
        ' Search for the book in biblioteca.txt based on its ID
        Dim bookInfo As String() = Nothing

        If File.Exists(filePathRecords) Then
            Using reader As New StreamReader(filePathRecords)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split("|"c)
                    Console.WriteLine(parts(2).Trim())
                    If parts.Length >= 6 AndAlso parts(2).Trim() = bookID Then
                        bookInfo = parts
                        Exit While
                    End If
                End While
            End Using
        End If

        Return bookInfo
    End Function

End Class