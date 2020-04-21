<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.btn_multiplicacion = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_suma
        '
        Me.btn_suma.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_suma.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suma.Location = New System.Drawing.Point(296, 387)
        Me.btn_suma.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(197, 51)
        Me.btn_suma.TabIndex = 0
        Me.btn_suma.Text = "SUMA (+)"
        Me.btn_suma.UseVisualStyleBackColor = False
        '
        'btn_multiplicacion
        '
        Me.btn_multiplicacion.BackColor = System.Drawing.Color.Red
        Me.btn_multiplicacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiplicacion.Location = New System.Drawing.Point(25, 274)
        Me.btn_multiplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_multiplicacion.Name = "btn_multiplicacion"
        Me.btn_multiplicacion.Size = New System.Drawing.Size(255, 52)
        Me.btn_multiplicacion.TabIndex = 1
        Me.btn_multiplicacion.Text = "MULTIPLICACION (X)"
        Me.btn_multiplicacion.UseVisualStyleBackColor = False
        '
        'btn_division
        '
        Me.btn_division.BackColor = System.Drawing.Color.LightCoral
        Me.btn_division.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_division.Location = New System.Drawing.Point(525, 274)
        Me.btn_division.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(260, 52)
        Me.btn_division.TabIndex = 2
        Me.btn_division.Text = "DIVISION (/)"
        Me.btn_division.UseVisualStyleBackColor = False
        '
        'btn_resta
        '
        Me.btn_resta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_resta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resta.Location = New System.Drawing.Point(308, 180)
        Me.btn_resta.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(200, 58)
        Me.btn_resta.TabIndex = 3
        Me.btn_resta.Text = "RESTA (-)"
        Me.btn_resta.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(93, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(628, 45)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Vamos Jugar un poco con la Matematica"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Evaluacion.My.Resources.Resources.inicio
        Me.ClientSize = New System.Drawing.Size(808, 502)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_multiplicacion)
        Me.Controls.Add(Me.btn_suma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_suma As Button
    Friend WithEvents btn_multiplicacion As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_resta As Button
    Friend WithEvents Label4 As Label
End Class
