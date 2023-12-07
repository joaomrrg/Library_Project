Public Class Form2
    ' Declaração de variável para o formulário principal (mainForm)
    Private mainForm As Form1

    ' Construtor da classe Form2 que recebe o formulário principal (mainForm)
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    ' Método para lidar com o evento de clique do botão de adicionar livro
    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles Button_adicionar.Click
        ' Adicionar um novo livro à lista de livros
        Dim novoLivro As New ListViewItem(TextBox_titulo.Text) ' Cria um novo ListViewItem com o título do livro
        novoLivro.SubItems.Add(TextBox_autor.Text) ' Adiciona o autor como subitem
        novoLivro.SubItems.Add(TextBox_id.Text) ' Adiciona o ID como subitem
        novoLivro.SubItems.Add(TextBox_ano.Text) ' Adiciona o ano como subitem
        novoLivro.SubItems.Add("Disponível") ' Define o status como Disponível
        novoLivro.SubItems.Add("") ' Define a data de devolução como vazio

        ' Adiciona o novo livro à lista de livros no formulário principal (mainForm)
        mainForm.ListaLivros.Items.Add(novoLivro)

        ' Salva os dados após a adição do novo livro
        mainForm.GuardarDados() ' Salva os dados da lista de livros
        mainForm.CreateBookRecordFile() ' Cria um arquivo de registro de livro

        ' Fecha o formulário de adição
        Me.Close()
    End Sub

    ' Método para lidar com o evento de clique do botão de cancelar adição
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        ' Fecha o formulário de adição sem fazer alterações
        Me.Close()
    End Sub
End Class
