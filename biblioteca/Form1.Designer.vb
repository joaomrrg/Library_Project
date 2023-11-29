<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button_check = New Button()
        Button_devolve = New Button()
        Button_renova = New Button()
        Button_adicionar = New Button()
        Label1 = New Label()
        TextBox_procurar = New TextBox()
        Button_procurar = New Button()
        Button_remover = New Button()
        ImageListLivros = New ImageList(components)
        ListaLivros = New ListView()
        SuspendLayout()
        ' 
        ' Button_check
        ' 
        Button_check.Location = New Point(669, 461)
        Button_check.Margin = New Padding(3, 4, 3, 4)
        Button_check.Name = "Button_check"
        Button_check.Size = New Size(100, 31)
        Button_check.TabIndex = 0
        Button_check.Text = "CheckOut"
        Button_check.UseVisualStyleBackColor = True
        ' 
        ' Button_devolve
        ' 
        Button_devolve.Location = New Point(775, 461)
        Button_devolve.Margin = New Padding(3, 4, 3, 4)
        Button_devolve.Name = "Button_devolve"
        Button_devolve.Size = New Size(100, 31)
        Button_devolve.TabIndex = 1
        Button_devolve.Text = "Devolução"
        Button_devolve.UseVisualStyleBackColor = True
        ' 
        ' Button_renova
        ' 
        Button_renova.Location = New Point(881, 461)
        Button_renova.Margin = New Padding(3, 4, 3, 4)
        Button_renova.Name = "Button_renova"
        Button_renova.Size = New Size(100, 31)
        Button_renova.TabIndex = 3
        Button_renova.Text = "Renovar"
        Button_renova.UseVisualStyleBackColor = True
        ' 
        ' Button_adicionar
        ' 
        Button_adicionar.Location = New Point(48, 461)
        Button_adicionar.Margin = New Padding(3, 4, 3, 4)
        Button_adicionar.Name = "Button_adicionar"
        Button_adicionar.Size = New Size(111, 31)
        Button_adicionar.TabIndex = 6
        Button_adicionar.Text = "Adicionar Livro"
        Button_adicionar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 7
        Label1.Text = "Livro"
        ' 
        ' TextBox_procurar
        ' 
        TextBox_procurar.Location = New Point(93, 32)
        TextBox_procurar.Margin = New Padding(3, 4, 3, 4)
        TextBox_procurar.Name = "TextBox_procurar"
        TextBox_procurar.Size = New Size(774, 27)
        TextBox_procurar.TabIndex = 8
        ' 
        ' Button_procurar
        ' 
        Button_procurar.Location = New Point(874, 32)
        Button_procurar.Margin = New Padding(3, 4, 3, 4)
        Button_procurar.Name = "Button_procurar"
        Button_procurar.Size = New Size(107, 31)
        Button_procurar.TabIndex = 9
        Button_procurar.Text = "Procurar"
        Button_procurar.UseVisualStyleBackColor = True
        ' 
        ' Button_remover
        ' 
        Button_remover.Location = New Point(166, 461)
        Button_remover.Margin = New Padding(3, 4, 3, 4)
        Button_remover.Name = "Button_remover"
        Button_remover.Size = New Size(86, 31)
        Button_remover.TabIndex = 10
        Button_remover.Text = "Remover"
        Button_remover.UseVisualStyleBackColor = True
        ' 
        ' ImageListLivros
        ' 
        ImageListLivros.ColorDepth = ColorDepth.Depth8Bit
        ImageListLivros.ImageSize = New Size(16, 16)
        ImageListLivros.TransparentColor = Color.Transparent
        ' 
        ' ListaLivros
        ' 
        ListaLivros.Alignment = ListViewAlignment.Left
        ListaLivros.FullRowSelect = True
        ListaLivros.Location = New Point(48, 92)
        ListaLivros.Margin = New Padding(3, 4, 3, 4)
        ListaLivros.MultiSelect = False
        ListaLivros.Name = "ListaLivros"
        ListaLivros.Size = New Size(933, 348)
        ListaLivros.TabIndex = 11
        ListaLivros.TileSize = New Size(200, 100)
        ListaLivros.UseCompatibleStateImageBehavior = False
        ListaLivros.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 528)
        Controls.Add(ListaLivros)
        Controls.Add(Button_remover)
        Controls.Add(Button_procurar)
        Controls.Add(TextBox_procurar)
        Controls.Add(Label1)
        Controls.Add(Button_adicionar)
        Controls.Add(Button_renova)
        Controls.Add(Button_devolve)
        Controls.Add(Button_check)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Gestor Biblioteca"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_check As Button
    Friend WithEvents Button_devolve As Button
    Friend WithEvents Button_renova As Button
    Friend WithEvents Button_adicionar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_procurar As TextBox
    Friend WithEvents Button_procurar As Button
    Friend WithEvents Button_remover As Button
    Friend WithEvents ImageListLivros As ImageList
    Friend WithEvents ListaLivros As ListView
End Class
