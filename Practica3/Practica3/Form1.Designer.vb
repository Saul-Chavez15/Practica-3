<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Materia2 = New System.Windows.Forms.TextBox()
        Me.Materia1 = New System.Windows.Forms.TextBox()
        Me.Materia4 = New System.Windows.Forms.TextBox()
        Me.Materia3 = New System.Windows.Forms.TextBox()
        Me.Materia5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soc. y Cultura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matematicas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Med. y Tec IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inglés"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Or. Vocacional"
        '
        'Materia2
        '
        Me.Materia2.Location = New System.Drawing.Point(133, 38)
        Me.Materia2.Name = "Materia2"
        Me.Materia2.Size = New System.Drawing.Size(100, 20)
        Me.Materia2.TabIndex = 5
        '
        'Materia1
        '
        Me.Materia1.Location = New System.Drawing.Point(133, 9)
        Me.Materia1.Name = "Materia1"
        Me.Materia1.Size = New System.Drawing.Size(100, 20)
        Me.Materia1.TabIndex = 6
        '
        'Materia4
        '
        Me.Materia4.Location = New System.Drawing.Point(133, 87)
        Me.Materia4.Name = "Materia4"
        Me.Materia4.Size = New System.Drawing.Size(100, 20)
        Me.Materia4.TabIndex = 7
        '
        'Materia3
        '
        Me.Materia3.Location = New System.Drawing.Point(133, 64)
        Me.Materia3.Name = "Materia3"
        Me.Materia3.Size = New System.Drawing.Size(100, 20)
        Me.Materia3.TabIndex = 8
        '
        'Materia5
        '
        Me.Materia5.Location = New System.Drawing.Point(133, 109)
        Me.Materia5.Name = "Materia5"
        Me.Materia5.Size = New System.Drawing.Size(100, 20)
        Me.Materia5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Promedio:"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(398, 38)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(43, 46)
        Me.resultado.TabIndex = 11
        Me.resultado.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(354, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 87)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calcular Promedio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Materia5)
        Me.Controls.Add(Me.Materia3)
        Me.Controls.Add(Me.Materia4)
        Me.Controls.Add(Me.Materia1)
        Me.Controls.Add(Me.Materia2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Soc. y Cultura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Materia2 As TextBox
    Friend WithEvents Materia1 As TextBox
    Friend WithEvents Materia4 As TextBox
    Friend WithEvents Materia3 As TextBox
    Friend WithEvents Materia5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents resultado As Label
    Friend WithEvents Button1 As Button
End Class
