' Importação de bibliotecas necessárias
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

' Classe principal Form1
Public Class Form1
    ' Declaração de variáveis
    Private form3 As Form3 ' Variável para o formulário Form3
    Dim filePath As String = "biblioteca.txt" ' Caminho do arquivo de dados da biblioteca

    ' Evento de carregamento do formulário
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar dados do arquivo ao iniciar o programa
        ConfigurarColunas()
        CarregarDados()
    End Sub

    ' Método para configurar as colunas da lista de livros
    Private Sub ConfigurarColunas()
        ' Configura as colunas para a ListaLivros
        ' Define o modo de exibição para Details
        ListaLivros.View = View.Details

        ' Adiciona as colunas
        ListaLivros.Columns.Add("Título", 200)
        ListaLivros.Columns.Add("Autor", 150)
        ListaLivros.Columns.Add("ID", 50)
        ListaLivros.Columns.Add("Ano", 50)
        ListaLivros.Columns.Add("Estado", 100)
        ListaLivros.Columns.Add("Data de Devolução", 150)
    End Sub

    ' Método para carregar os dados do arquivo para a ListaLivros
    Private Sub CarregarDados()
        ' Verifica se o arquivo existe
        If File.Exists(filePath) Then
            ' Limpa a ListaLivros antes de carregar novos dados
            ListaLivros.Items.Clear()

            ' Carrega dados do arquivo para a ListaLivros
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split("|"c)

                    ' Verifica se há informações suficientes para criar um ListViewItem
                    If parts.Length >= 6 Then
                        ' Cria um novo ListViewItem
                        Dim livro As New ListViewItem(parts(0).Trim())

                        ' Adiciona subitens ao ListViewItem
                        livro.SubItems.Add(parts(1).Trim())
                        livro.SubItems.Add(parts(2).Trim())
                        livro.SubItems.Add(parts(3).Trim())
                        livro.SubItems.Add(parts(4).Trim())
                        livro.SubItems.Add(parts(5).Trim())

                        ' Adiciona o ListViewItem à ListaLivros
                        ListaLivros.Items.Add(livro)
                    Else
                        ' Exibe mensagem de depuração se houver menos de 6 partes
                        Console.WriteLine($"Erro ao processar a linha: {line}")
                    End If
                End While
            End Using
        End If
    End Sub

    Public Sub GuardarDados()
        Dim can As Boolean = True ' Variável 'can' parece não ser utilizada neste contexto
        Dim id As String ' Variável 'id' é declarada, mas não utilizada

        ' Salvar dados da ListaLivros no arquivo
        Using writer As New StreamWriter(filePath)
            For Each livro As ListViewItem In ListaLivros.Items
                ' Combine todos os subitens em uma única linha, separados por "|"
                Dim dadosLivro As String = String.Join(" | ", livro.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subitem) subitem.Text))
                writer.WriteLine(dadosLivro) ' Escreve os dados do livro no arquivo
            Next
        End Using
    End Sub

    Public Sub CreateBookRecordFile()
        Dim bookRecordsFilePath As String = "book_records.txt" ' Caminho do arquivo de registro de livros
        Dim recordedIDs As New HashSet(Of String)() ' Conjunto para armazenar IDs de livros já registrados

        ' Verifica se o arquivo de registro de livros já existe, se não, cria-o
        If Not File.Exists(bookRecordsFilePath) Then
            File.Create(bookRecordsFilePath).Dispose()
        End If

        ' Lê registros existentes para evitar duplicatas
        Using reader As New StreamReader(bookRecordsFilePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)
                If parts.Length >= 6 Then
                    ' Armazena IDs para evitar duplicatas
                    recordedIDs.Add(parts(2).Trim())
                End If
            End While
        End Using

        ' Adiciona novos registros sem duplicatas
        Using writer As New StreamWriter(bookRecordsFilePath, True)
            If File.Exists(filePath) Then
                Using reader As New StreamReader(filePath)
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim parts As String() = line.Split("|"c)
                        If parts.Length >= 6 Then
                            Dim bookID As String = parts(2).Trim()

                            ' Verifica se o ID do livro já está registrado
                            If Not recordedIDs.Contains(bookID) Then
                                writer.WriteLine(line) ' Escreve o registro no arquivo de registros
                                recordedIDs.Add(bookID) ' Adiciona o novo ID à lista de IDs registrados
                            End If
                        End If
                    End While
                End Using
            End If
        End Using
    End Sub


    Private Sub Button_check_Click(sender As Object, e As EventArgs) Handles Button_check.Click
        ' Verifica se algum livro foi selecionado
        If ListaLivros.SelectedItems.Count > 0 Then
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            ' Verifica se o livro está disponível para empréstimo
            If livroSelecionado.SubItems(4).Text = "Disponível" Then
                ' Abre o Form3 para detalhes do empréstimo
                Dim formAdicionar As New Form3(Me, 0)
                formAdicionar.ShowDialog()
            Else
                MessageBox.Show("Livro não disponível para empréstimo.")
            End If
        Else
            MessageBox.Show("Selecione um livro para empréstimo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button_devolve_Click(sender As Object, e As EventArgs) Handles Button_devolve.Click
        ' Simulação de Devolução

        If ListaLivros.SelectedItems.Count > 0 Then
            ' Obtém o livro selecionado
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            ' Verifica se o livro está emprestado
            If livroSelecionado.SubItems(4).Text = "Emprestado" Then
                ' Atualiza os subitens para simular a devolução
                livroSelecionado.SubItems(4).Text = "Disponível"
                livroSelecionado.SubItems(5).Text = ""

                ' Salva os dados após a devolução
                GuardarDados()

                MessageBox.Show("Livro devolvido com sucesso!")
            Else
                MessageBox.Show("Livro não está atualmente emprestado.")
            End If
        Else
            MessageBox.Show("Selecione um livro para devolver.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button_renova_Click(sender As Object, e As EventArgs) Handles Button_renova.Click
        ' Verifica se há algum livro selecionado
        If ListaLivros.SelectedItems.Count > 0 Then
            ' Obtém o ID do livro selecionado
            Dim selectedBookID As String = ListaLivros.SelectedItems(0).SubItems(2).Text

            ' Abre o Form3 para renovar o livro
            Dim formMostrarCliente As New Form3(Me, selectedBookID)
            formMostrarCliente.ShowDialog()
        Else
            MessageBox.Show("Selecione um livro para renovar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button_adicionar_Click(sender As Object, e As EventArgs) Handles Button_adicionar.Click
        ' Abre o Form2 para adicionar um novo livro à lista
        Dim formAdicionar As New Form2(Me)
        formAdicionar.ShowDialog()
    End Sub

    Private Sub Button_procurar_Click(sender As Object, e As EventArgs) Handles Button_procurar.Click
        ' Filtra os livros com base no texto de pesquisa
        FiltrarLivros(TextBox_procurar.Text)
    End Sub

    Private Sub Button_remover_Click(sender As Object, e As EventArgs) Handles Button_remover.Click
        ' Certifica-se de que há pelo menos um item selecionado
        If ListaLivros.SelectedItems.Count > 0 Then
            ' Obtém o item selecionado
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            If livroSelecionado.SubItems(4).Text = "Disponível" Then
                ' Pergunta ao usuário se ele deseja realmente remover o livro
                Dim resultado As DialogResult = MessageBox.Show("Tem certeza de que deseja remover este livro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then
                    ' Remove o item da ListaLivros
                    ListaLivros.Items.Remove(livroSelecionado)

                    ' Salva os dados após a remoção
                    GuardarDados()
                End If
            Else
                MessageBox.Show("Livro atualmente emprestado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Selecione um livro para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ListaLivros_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListaLivros.MouseDoubleClick
        ' Verifica se algum livro está selecionado e se está emprestado
        If ListaLivros.SelectedItems.Count > 0 AndAlso ListaLivros.SelectedItems(0).SubItems(4).Text = "Emprestado" Then
            ' Obtém o ID do livro selecionado
            Dim selectedBookID As String = ListaLivros.SelectedItems(0).SubItems(2).Text

            ' Abre o Form4 para mostrar detalhes do cliente que pegou o livro emprestado
            Dim formMostrarCliente As New Form4(selectedBookID)
            formMostrarCliente.ShowDialog()
        Else
            MessageBox.Show("Livro não emprestado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub FiltrarLivros(pesquisa As String)
        ' Limpar a lista de livros
        ListaLivros.Items.Clear()

        ' Carregar dados do arquivo para a ListaLivros
        ' (Formato do arquivo: Título do Livro | Disponibilidade (True/False) | Data de Devolução)
        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)
                Dim tituloLivro As String = parts(0).Trim()

                ' Verificar se o título do livro contém a pesquisa
                If tituloLivro.ToLower().Contains(pesquisa.ToLower()) Then
                    Dim livro As New ListViewItem(parts(0).Trim())
                    livro.SubItems.Add(parts(1).Trim())
                    livro.SubItems.Add(parts(2).Trim())
                    livro.SubItems.Add(parts(3).Trim())
                    livro.SubItems.Add(parts(4).Trim())
                    livro.SubItems.Add(parts(5).Trim())
                    ListaLivros.Items.Add(livro)
                End If
            End While
        End Using
    End Sub

    Private Sub button_info_Click(sender As Object, e As EventArgs) Handles button_info.Click
        Dim formAdicionar As New Form5(Me)
        formAdicionar.ShowDialog()
    End Sub
End Class
