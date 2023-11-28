<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button_adicionar = New Button()
        Button_cancelar = New Button()
        Label1 = New Label()
        TextBox_titulo = New TextBox()
        TextBox_id = New TextBox()
        Label2 = New Label()
        Label_id = New Label()
        Label3 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Button_image = New Button()
        label_autor = New Label()
        TextBox_autor = New TextBox()
        Label_ano = New Label()
        TextBox_ano = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button_adicionar
        ' 
        Button_adicionar.Location = New Point(22, 180)
        Button_adicionar.Name = "Button_adicionar"
        Button_adicionar.Size = New Size(75, 23)
        Button_adicionar.TabIndex = 0
        Button_adicionar.Text = "Button1"
        Button_adicionar.UseVisualStyleBackColor = True
        ' 
        ' Button_cancelar
        ' 
        Button_cancelar.Location = New Point(392, 180)
        Button_cancelar.Name = "Button_cancelar"
        Button_cancelar.Size = New Size(75, 23)
        Button_cancelar.TabIndex = 1
        Button_cancelar.Text = "Button2"
        Button_cancelar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 2
        Label1.Text = "Título"
        ' 
        ' TextBox_titulo
        ' 
        TextBox_titulo.Location = New Point(65, 15)
        TextBox_titulo.Name = "TextBox_titulo"
        TextBox_titulo.Size = New Size(402, 23)
        TextBox_titulo.TabIndex = 3
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(65, 73)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(402, 23)
        TextBox_id.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 4
        ' 
        ' Label_id
        ' 
        Label_id.AutoSize = True
        Label_id.Location = New Point(22, 76)
        Label_id.Name = "Label_id"
        Label_id.Size = New Size(18, 15)
        Label_id.TabIndex = 6
        Label_id.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 7
        Label3.Text = "Capa"
        ' 
        ' Button_image
        ' 
        Button_image.Location = New Point(65, 131)
        Button_image.Name = "Button_image"
        Button_image.Size = New Size(106, 23)
        Button_image.TabIndex = 8
        Button_image.Text = "Selecionar"
        Button_image.UseVisualStyleBackColor = True
        ' 
        ' label_autor
        ' 
        label_autor.AutoSize = True
        label_autor.Location = New Point(22, 47)
        label_autor.Name = "label_autor"
        label_autor.Size = New Size(37, 15)
        label_autor.TabIndex = 10
        label_autor.Text = "Autor"
        ' 
        ' TextBox_autor
        ' 
        TextBox_autor.Location = New Point(65, 44)
        TextBox_autor.Name = "TextBox_autor"
        TextBox_autor.Size = New Size(402, 23)
        TextBox_autor.TabIndex = 9
        ' 
        ' Label_ano
        ' 
        Label_ano.AutoSize = True
        Label_ano.Location = New Point(22, 105)
        Label_ano.Name = "Label_ano"
        Label_ano.Size = New Size(29, 15)
        Label_ano.TabIndex = 13
        Label_ano.Text = "Ano"
        ' 
        ' TextBox_ano
        ' 
        TextBox_ano.Location = New Point(65, 102)
        TextBox_ano.Name = "TextBox_ano"
        TextBox_ano.Size = New Size(402, 23)
        TextBox_ano.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 105)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 215)
        Controls.Add(Label_ano)
        Controls.Add(TextBox_ano)
        Controls.Add(Label5)
        Controls.Add(label_autor)
        Controls.Add(TextBox_autor)
        Controls.Add(Button_image)
        Controls.Add(Label3)
        Controls.Add(Label_id)
        Controls.Add(TextBox_id)
        Controls.Add(Label2)
        Controls.Add(TextBox_titulo)
        Controls.Add(Label1)
        Controls.Add(Button_cancelar)
        Controls.Add(Button_adicionar)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_adicionar As Button
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_titulo As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_id As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button_image As Button
    Friend WithEvents label_autor As Label
    Friend WithEvents TextBox_autor As TextBox
    Friend WithEvents Label_ano As Label
    Friend WithEvents TextBox_ano As TextBox
    Friend WithEvents Label5 As Label
End Class
