<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        text_nome = New TextBox()
        text_localidade = New TextBox()
        text_nif = New TextBox()
        text_contacto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button_renovar = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(256, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "CheckOut"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' text_nome
        ' 
        text_nome.Location = New Point(103, 34)
        text_nome.Name = "text_nome"
        text_nome.Size = New Size(247, 27)
        text_nome.TabIndex = 1
        ' 
        ' text_localidade
        ' 
        text_localidade.Location = New Point(103, 166)
        text_localidade.Name = "text_localidade"
        text_localidade.Size = New Size(247, 27)
        text_localidade.TabIndex = 2
        ' 
        ' text_nif
        ' 
        text_nif.Location = New Point(103, 122)
        text_nif.Name = "text_nif"
        text_nif.Size = New Size(247, 27)
        text_nif.TabIndex = 3
        ' 
        ' text_contacto
        ' 
        text_contacto.Location = New Point(103, 76)
        text_contacto.Name = "text_contacto"
        text_contacto.Size = New Size(247, 27)
        text_contacto.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 6
        Label2.Text = "Contacto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 7
        Label3.Text = "NIF"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 8
        Label4.Text = "Localidade"
        ' 
        ' Button_renovar
        ' 
        Button_renovar.Location = New Point(12, 252)
        Button_renovar.Name = "Button_renovar"
        Button_renovar.Size = New Size(94, 29)
        Button_renovar.TabIndex = 9
        Button_renovar.Text = "Renovar"
        Button_renovar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 298)
        Controls.Add(Button_renovar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(text_contacto)
        Controls.Add(text_nif)
        Controls.Add(text_localidade)
        Controls.Add(text_nome)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents text_nome As TextBox
    Friend WithEvents text_localidade As TextBox
    Friend WithEvents text_nif As TextBox
    Friend WithEvents text_contacto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_renovar As Button
End Class
