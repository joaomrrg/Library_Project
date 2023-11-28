Public Class Form2
    Private mainForm As Form1

    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles Button_adicionar.Click
        ' Adicionar um novo livro à lista
        Dim novoLivro As New ListViewItem(TextBox_titulo.Text)
        novoLivro.SubItems.Add(TextBox_autor.Text)
        novoLivro.SubItems.Add(TextBox_id.Text)
        novoLivro.SubItems.Add(TextBox_ano.Text)
        novoLivro.SubItems.Add("Disponível")
        novoLivro.SubItems.Add("")

        mainForm.ListaLivros.Items.Add(novoLivro)

        ' Salvar dados após a adição
        mainForm.GuardarDados()

        ' Fechar o formulário de adição
        Me.Close()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        ' Fechar o formulário de adição sem fazer alterações
        Me.Close()
    End Sub

End Class
