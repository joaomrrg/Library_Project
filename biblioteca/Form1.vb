Imports System.IO

Public Class Form1
    Dim filePath As String = "biblioteca.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar dados do arquivo no início do programa
        ConfigurarColunas()
        CarregarDados()
    End Sub

    Private Sub ConfigurarColunas()
        ' Configurar as colunas para a ListaLivros
        ListaLivros.View = View.Details ' Definir o modo de exibição para Details

        ' Adicionar as colunas
        ListaLivros.Columns.Add("Título", 200)
        ListaLivros.Columns.Add("Autor", 150)
        ListaLivros.Columns.Add("ID", 50)
        ListaLivros.Columns.Add("Ano", 50)
        ListaLivros.Columns.Add("Estado", 80)
        ListaLivros.Columns.Add("Data de Devolução", 100)
    End Sub

    Private Sub CarregarDados()
        If File.Exists(filePath) Then
            ' Limpar a ListaLivros antes de carregar novos dados
            ListaLivros.Items.Clear()

            ' Carregar dados do arquivo para a ListaLivros
            ' (Formato do arquivo: Título do Livro | Disponibilidade (True/False) | Data de Devolução | ID | Autor | Ano)
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split("|"c)

                    ' Verificar se há informações suficientes antes de criar um ListViewItem
                    If parts.Length >= 6 Then
                        ' Criar um novo ListViewItem
                        Dim livro As New ListViewItem(parts(0).Trim())

                        ' Adicionar subitens ao ListViewItem
                        livro.SubItems.Add(parts(1).Trim())
                        livro.SubItems.Add(parts(2).Trim())
                        livro.SubItems.Add(parts(3).Trim())
                        livro.SubItems.Add(parts(4).Trim())
                        livro.SubItems.Add(parts(5).Trim())

                        ' Adicionar o ListViewItem à ListaLivros
                        ListaLivros.Items.Add(livro)
                    Else
                        ' Se houver menos de 6 partes, algo está errado. Exibir mensagem de depuração.
                        Console.WriteLine($"Erro ao processar a linha: {line}")
                    End If
                End While
            End Using
        End If
    End Sub

    Public Sub GuardarDados()
        ' Salvar dados da ListaLivros no arquivo
        Using writer As New StreamWriter(filePath)
            For Each livro As ListViewItem In ListaLivros.Items
                ' Combine todos os subitens em uma única linha, separados por "|"
                Dim dadosLivro As String = String.Join(" | ", livro.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subitem) subitem.Text))
                writer.WriteLine(dadosLivro)
            Next
        End Using
    End Sub

    Private Sub Button_check_Click(sender As Object, e As EventArgs) Handles Button_check.Click
        ' Certificar-se de que há pelo menos um item selecionado
        If ListaLivros.SelectedItems.Count > 0 Then
            ' Obter o item selecionado
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            ' Verificar se o livro está disponível para empréstimo
            If livroSelecionado.SubItems(4).Text = "Disponível" Then
                ' Atualizar os subitens para simular o Check-Out
                livroSelecionado.SubItems(4).Text = "Emprestado"
                livroSelecionado.SubItems(5).Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy")

                ' Salvar os dados após a atualização
                GuardarDados()

                MessageBox.Show("Livro emprestado com sucesso!")
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
            ' Obter o item selecionado
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            ' Verificar se o livro está disponível para empréstimo
            If livroSelecionado.SubItems(4).Text = "Emprestado" Then
                ' Atualizar os subitens para simular o Check-Out
                livroSelecionado.SubItems(4).Text = "Disponível"
                livroSelecionado.SubItems(5).Text = ""

                ' Salvar os dados após a atualização
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
        ' Simulação de Renovação
        If ListaLivros.SelectedItems.Count > 0 AndAlso ListaLivros.SelectedItems(0).SubItems(1).Text = "Empréstimo" Then
            ListaLivros.SelectedItems(0).SubItems(2).Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy")
            GuardarDados()
            MessageBox.Show("Renovação bem-sucedida!")
        Else
            MessageBox.Show("Não é possível renovar o livro no momento.")
        End If
    End Sub

    Private Sub Button_adicionar_Click(sender As Object, e As EventArgs) Handles Button_adicionar.Click
        Dim formAdicionar As New Form2(Me)
        formAdicionar.ShowDialog()
    End Sub


    Private Sub Button_procurar_Click(sender As Object, e As EventArgs) Handles Button_procurar.Click
        FiltrarLivros(TextBox_procurar.Text)
    End Sub

    Private Sub Button_remover_Click(sender As Object, e As EventArgs) Handles Button_remover.Click
        ' Certificar-se de que há pelo menos um item selecionado
        If ListaLivros.SelectedItems.Count > 0 Then
            ' Obter o item selecionado
            Dim livroSelecionado As ListViewItem = ListaLivros.SelectedItems(0)

            ' Perguntar ao usuário se ele realmente deseja remover o livro
            Dim resultado As DialogResult = MessageBox.Show("Tem certeza de que deseja remover este livro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' Remover o item da ListaLivros
                ListaLivros.Items.Remove(livroSelecionado)

                ' Salvar os dados após a remoção
                GuardarDados()
            End If
        Else
            MessageBox.Show("Selecione um livro para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

End Class
