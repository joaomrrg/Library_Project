<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        lista_emprestimos = New ListView()
        lista_multas = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lista_emprestimos
        ' 
        lista_emprestimos.Location = New Point(12, 48)
        lista_emprestimos.Name = "lista_emprestimos"
        lista_emprestimos.Size = New Size(446, 419)
        lista_emprestimos.TabIndex = 0
        lista_emprestimos.UseCompatibleStateImageBehavior = False
        lista_emprestimos.Scrollable = True
        lista_emprestimos.View = View.Details
        ' 
        ' lista_multas
        ' 
        lista_multas.Location = New Point(493, 48)
        lista_multas.Name = "lista_multas"
        lista_multas.Size = New Size(460, 419)
        lista_multas.TabIndex = 1
        lista_multas.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 20)
        Label1.TabIndex = 2
        Label1.Text = "Histórico de Empréstimos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(493, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 20)
        Label2.TabIndex = 3
        Label2.Text = "Devoluções em Ataso"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 495)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lista_multas)
        Controls.Add(lista_emprestimos)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lista_emprestimos As ListView
    Friend WithEvents lista_multas As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
