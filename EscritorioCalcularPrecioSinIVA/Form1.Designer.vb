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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrecioT = New System.Windows.Forms.TextBox()
        Me.TipoIVA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PSinIVABox = New System.Windows.Forms.TextBox()
        Me.IVAPagarBox = New System.Windows.Forms.TextBox()
        Me.LabelErrors = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calcular IVA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio Total: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Precio sin IVA: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo de IVA: "
        '
        'PrecioT
        '
        Me.PrecioT.Location = New System.Drawing.Point(112, 74)
        Me.PrecioT.Name = "PrecioT"
        Me.PrecioT.Size = New System.Drawing.Size(100, 22)
        Me.PrecioT.TabIndex = 5
        '
        'TipoIVA
        '
        Me.TipoIVA.FormattingEnabled = True
        Me.TipoIVA.Items.AddRange(New Object() {"General", "Reducido", "Superreducido"})
        Me.TipoIVA.Location = New System.Drawing.Point(112, 113)
        Me.TipoIVA.Name = "TipoIVA"
        Me.TipoIVA.Size = New System.Drawing.Size(121, 24)
        Me.TipoIVA.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "IVA a pagar: "
        '
        'PSinIVABox
        '
        Me.PSinIVABox.Location = New System.Drawing.Point(112, 223)
        Me.PSinIVABox.Name = "PSinIVABox"
        Me.PSinIVABox.ReadOnly = True
        Me.PSinIVABox.Size = New System.Drawing.Size(100, 22)
        Me.PSinIVABox.TabIndex = 8
        '
        'IVAPagarBox
        '
        Me.IVAPagarBox.Location = New System.Drawing.Point(112, 259)
        Me.IVAPagarBox.Name = "IVAPagarBox"
        Me.IVAPagarBox.ReadOnly = True
        Me.IVAPagarBox.Size = New System.Drawing.Size(100, 22)
        Me.IVAPagarBox.TabIndex = 9
        '
        'LabelErrors
        '
        Me.LabelErrors.AutoSize = True
        Me.LabelErrors.Location = New System.Drawing.Point(24, 189)
        Me.LabelErrors.Name = "LabelErrors"
        Me.LabelErrors.Size = New System.Drawing.Size(12, 17)
        Me.LabelErrors.TabIndex = 10
        Me.LabelErrors.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelErrors)
        Me.Controls.Add(Me.IVAPagarBox)
        Me.Controls.Add(Me.PSinIVABox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TipoIVA)
        Me.Controls.Add(Me.PrecioT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PrecioT As TextBox
    Friend WithEvents TipoIVA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PSinIVABox As TextBox
    Friend WithEvents IVAPagarBox As TextBox
    Friend WithEvents LabelErrors As Label
End Class
