Imports System.Globalization
Imports System.IO
Imports System.Net

Public Class Form5

    ' Declaração de variáveis para os caminhos dos arquivos
    Dim filePathChechout As String = "checkout_info.txt"
    Dim filePathRecords As String = "book_records.txt"

    Private mainForm As Form1

    ' Construtor da classe Form5
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    ' Método chamado quando o formulário é carregado
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar dados do arquivo no início do programa
        ConfigurarColunas() ' Configurar as colunas para as listas
        CarregarDados() ' Carregar dados para as listas
    End Sub

    ' Configurar as colunas das listas
    Private Sub ConfigurarColunas()
        ' Configurar colunas para lista_emprestimos
        lista_emprestimos.View = View.Details ' Definir o modo de exibição para Details
        lista_emprestimos.Columns.Add("ID", 50)
        lista_emprestimos.Columns.Add("Título", 125)
        lista_emprestimos.Columns.Add("Cliente", 80)
        lista_emprestimos.Columns.Add("Estado", 80)
        lista_emprestimos.Columns.Add("Data de Devolução", 100)

        ' Configurar colunas para lista_multas
        lista_multas.View = View.Details ' Definir o modo de exibição para Details
        lista_multas.Columns.Add("ID", 50)
        lista_multas.Columns.Add("Título", 125)
        lista_multas.Columns.Add("Cliente", 80)
        lista_multas.Columns.Add("Data de Devolução", 100)
        lista_multas.Columns.Add("Multa", 100)
    End Sub

    ' Carregar dados para as listas
    Private Sub CarregarDados()
        If File.Exists(filePathChechout) Then ' Verificar se o arquivo existe
            lista_emprestimos.Items.Clear() ' Limpar lista_emprestimos

            ' Abrir arquivo de checkout_info para leitura
            Using reader As New StreamReader(filePathChechout)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim id As String() = line.Split("|"c)
                    Dim parts As String() = id(1).Split(","c)

                    ' Obter informações do livro pelo ID
                    Dim bookInfo As String() = RetrieveBookInfoByID(id(0).Trim())

                    ' Verificar se existem informações suficientes para criar um ListViewItem
                    Dim emprestimo As New ListViewItem(id(0).Trim()) ' Criar um novo ListViewItem
                    emprestimo.SubItems.Add(bookInfo(0).Trim())
                    emprestimo.SubItems.Add(parts(0).Trim())
                    emprestimo.SubItems.Add(bookInfo(4).Trim())
                    emprestimo.SubItems.Add(bookInfo(5).Trim())
                    lista_emprestimos.Items.Add(emprestimo) ' Adicionar à lista

                    ' Cálculo de atraso e adição de multa, se aplicável
                    Dim dateString As String = "06/12/2023" ' Data fixa para exemplo
                    Dim dateFormat As String = "dd/MM/yyyy"
                    Dim bookDueDate As DateTime
                    Dim provider As CultureInfo = CultureInfo.InvariantCulture
                    bookDueDate = DateTime.ParseExact(dateString, dateFormat, provider)

                    Dim DiasPassados As Integer = DateTime.Now.Subtract(bookDueDate).Days
                    Dim currentDate As DateTime = DateTime.Now.Date

                    ' Verificar se o livro está emprestado e se está atrasado
                    If bookInfo(4).Trim().Equals("Emprestado") AndAlso bookDueDate.Date < currentDate Then
                        Dim atraso As New ListViewItem(id(0).Trim())
                        atraso.SubItems.Add(bookInfo(0).Trim())
                        atraso.SubItems.Add(parts(0).Trim())
                        atraso.SubItems.Add(bookInfo(5).Trim())
                        atraso.SubItems.Add((DiasPassados * 0.35).ToString() + "€")
                        lista_multas.Items.Add(atraso) ' Adicionar à lista de multas
                    End If
                End While
            End Using
        End If
    End Sub

    ' Função para obter informações do livro pelo ID
    Private Function RetrieveBookInfoByID(bookID As String) As String()
        Dim bookInfo As String() = Nothing

        If File.Exists(filePathRecords) Then
            ' Abrir arquivo de book_records para leitura
            Using reader As New StreamReader(filePathRecords)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split("|"c)
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
