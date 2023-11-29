<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        text_contacto = New TextBox()
        text_nif = New TextBox()
        text_localidade = New TextBox()
        text_nome = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 16
        Label4.Text = "Localidade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 15
        Label3.Text = "NIF"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 14
        Label2.Text = "Contacto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 13
        Label1.Text = "Nome"
        ' 
        ' text_contacto
        ' 
        text_contacto.Location = New Point(111, 72)
        text_contacto.Name = "text_contacto"
        text_contacto.Size = New Size(247, 27)
        text_contacto.TabIndex = 12
        ' 
        ' text_nif
        ' 
        text_nif.Location = New Point(111, 118)
        text_nif.Name = "text_nif"
        text_nif.Size = New Size(247, 27)
        text_nif.TabIndex = 11
        ' 
        ' text_localidade
        ' 
        text_localidade.Location = New Point(111, 162)
        text_localidade.Name = "text_localidade"
        text_localidade.Size = New Size(247, 27)
        text_localidade.TabIndex = 10
        ' 
        ' text_nome
        ' 
        text_nome.Location = New Point(111, 30)
        text_nome.Name = "text_nome"
        text_nome.Size = New Size(247, 27)
        text_nome.TabIndex = 9
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 222)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(text_contacto)
        Controls.Add(text_nif)
        Controls.Add(text_localidade)
        Controls.Add(text_nome)
        Name = "Form4"
        Text = "Dados Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents text_contacto As TextBox
    Friend WithEvents text_nif As TextBox
    Friend WithEvents text_localidade As TextBox
    Friend WithEvents text_nome As TextBox
End Class
