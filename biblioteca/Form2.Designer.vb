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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        label_autor = New Label()
        TextBox_autor = New TextBox()
        Label_ano = New Label()
        TextBox_ano = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button_adicionar
        ' 
        Button_adicionar.Location = New Point(356, 240)
        Button_adicionar.Margin = New Padding(3, 4, 3, 4)
        Button_adicionar.Name = "Button_adicionar"
        Button_adicionar.Size = New Size(86, 31)
        Button_adicionar.TabIndex = 0
        Button_adicionar.Text = "Adicionar"
        Button_adicionar.UseVisualStyleBackColor = True
        ' 
        ' Button_cancelar
        ' 
        Button_cancelar.Location = New Point(448, 240)
        Button_cancelar.Margin = New Padding(3, 4, 3, 4)
        Button_cancelar.Name = "Button_cancelar"
        Button_cancelar.Size = New Size(86, 31)
        Button_cancelar.TabIndex = 1
        Button_cancelar.Text = "Cancelar"
        Button_cancelar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 2
        Label1.Text = "Título"
        ' 
        ' TextBox_titulo
        ' 
        TextBox_titulo.Location = New Point(74, 20)
        TextBox_titulo.Margin = New Padding(3, 4, 3, 4)
        TextBox_titulo.Name = "TextBox_titulo"
        TextBox_titulo.Size = New Size(459, 27)
        TextBox_titulo.TabIndex = 3
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(74, 97)
        TextBox_id.Margin = New Padding(3, 4, 3, 4)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(459, 27)
        TextBox_id.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 4
        ' 
        ' Label_id
        ' 
        Label_id.AutoSize = True
        Label_id.Location = New Point(25, 101)
        Label_id.Name = "Label_id"
        Label_id.Size = New Size(24, 20)
        Label_id.TabIndex = 6
        Label_id.Text = "ID"
        ' 
        ' label_autor
        ' 
        label_autor.AutoSize = True
        label_autor.Location = New Point(25, 63)
        label_autor.Name = "label_autor"
        label_autor.Size = New Size(46, 20)
        label_autor.TabIndex = 10
        label_autor.Text = "Autor"
        ' 
        ' TextBox_autor
        ' 
        TextBox_autor.Location = New Point(74, 59)
        TextBox_autor.Margin = New Padding(3, 4, 3, 4)
        TextBox_autor.Name = "TextBox_autor"
        TextBox_autor.Size = New Size(459, 27)
        TextBox_autor.TabIndex = 9
        ' 
        ' Label_ano
        ' 
        Label_ano.AutoSize = True
        Label_ano.Location = New Point(25, 140)
        Label_ano.Name = "Label_ano"
        Label_ano.Size = New Size(36, 20)
        Label_ano.TabIndex = 13
        Label_ano.Text = "Ano"
        ' 
        ' TextBox_ano
        ' 
        TextBox_ano.Location = New Point(74, 136)
        TextBox_ano.Margin = New Padding(3, 4, 3, 4)
        TextBox_ano.Name = "TextBox_ano"
        TextBox_ano.Size = New Size(459, 27)
        TextBox_ano.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 287)
        Controls.Add(Label_ano)
        Controls.Add(TextBox_ano)
        Controls.Add(Label5)
        Controls.Add(label_autor)
        Controls.Add(TextBox_autor)
        Controls.Add(Label_id)
        Controls.Add(TextBox_id)
        Controls.Add(Label2)
        Controls.Add(TextBox_titulo)
        Controls.Add(Label1)
        Controls.Add(Button_cancelar)
        Controls.Add(Button_adicionar)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents label_autor As Label
    Friend WithEvents TextBox_autor As TextBox
    Friend WithEvents Label_ano As Label
    Friend WithEvents TextBox_ano As TextBox
    Friend WithEvents Label5 As Label
End Class
