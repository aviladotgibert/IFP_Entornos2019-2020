<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.ButtonJugar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTitulo
        '
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.Location = New System.Drawing.Point(100, 50)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(360, 85)
        Me.labelTitulo.TabIndex = 0
        Me.labelTitulo.Text = "TIC TAC TOE"
        '
        'ButtonJugar
        '
        Me.ButtonJugar.Location = New System.Drawing.Point(216, 196)
        Me.ButtonJugar.Name = "ButtonJugar"
        Me.ButtonJugar.Size = New System.Drawing.Size(108, 31)
        Me.ButtonJugar.TabIndex = 1
        Me.ButtonJugar.Text = "JUGAR"
        Me.ButtonJugar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(216, 251)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(108, 31)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 444)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonJugar)
        Me.Controls.Add(Me.labelTitulo)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTitulo As Label
    Friend WithEvents ButtonJugar As Button
    Friend WithEvents ButtonSalir As Button
End Class
