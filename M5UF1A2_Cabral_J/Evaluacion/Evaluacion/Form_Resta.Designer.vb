<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Resta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Resta))
        Me.Mensaj = New System.Windows.Forms.Label()
        Me.verif_miRespueta = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_tiempoS = New System.Windows.Forms.Label()
        Me.Label_tiempoM = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mensaj
        '
        Me.Mensaj.AutoSize = True
        Me.Mensaj.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensaj.Location = New System.Drawing.Point(85, 377)
        Me.Mensaj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Mensaj.Name = "Mensaj"
        Me.Mensaj.Size = New System.Drawing.Size(95, 23)
        Me.Mensaj.TabIndex = 47
        Me.Mensaj.Text = "Mensaje: "
        '
        'verif_miRespueta
        '
        Me.verif_miRespueta.AutoSize = True
        Me.verif_miRespueta.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verif_miRespueta.Location = New System.Drawing.Point(287, 331)
        Me.verif_miRespueta.Margin = New System.Windows.Forms.Padding(4)
        Me.verif_miRespueta.Name = "verif_miRespueta"
        Me.verif_miRespueta.Size = New System.Drawing.Size(197, 23)
        Me.verif_miRespueta.TabIndex = 46
        Me.verif_miRespueta.Text = "Verificar Mi respuesta"
        Me.verif_miRespueta.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(273, 413)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 50)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Limpiar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Su respuesta:"
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(411, 285)
        Me.Text3.Margin = New System.Windows.Forms.Padding(4)
        Me.Text3.Multiline = True
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(72, 24)
        Me.Text3.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(518, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 37)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "?"
        '
        'Text1
        '
        Me.Text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.Color.Red
        Me.Text1.Location = New System.Drawing.Point(304, 196)
        Me.Text1.Margin = New System.Windows.Forms.Padding(4)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(73, 49)
        Me.Text1.TabIndex = 38
        Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 43)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 32)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "¿ Cuanto es:"
        '
        'Text2
        '
        Me.Text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.Color.Red
        Me.Text2.Location = New System.Drawing.Point(437, 198)
        Me.Text2.Margin = New System.Windows.Forms.Padding(4)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(73, 49)
        Me.Text2.TabIndex = 35
        Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(200, 112)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(371, 41)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "MUSTRA PROBLEMAS A RESOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.Location = New System.Drawing.Point(653, 13)
        Me.btn_volver.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(54, 50)
        Me.btn_volver.TabIndex = 48
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label_tiempoS
        '
        Me.Label_tiempoS.AutoSize = True
        Me.Label_tiempoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tiempoS.Location = New System.Drawing.Point(105, 70)
        Me.Label_tiempoS.Name = "Label_tiempoS"
        Me.Label_tiempoS.Size = New System.Drawing.Size(36, 25)
        Me.Label_tiempoS.TabIndex = 50
        Me.Label_tiempoS.Text = "00"
        '
        'Label_tiempoM
        '
        Me.Label_tiempoM.AutoSize = True
        Me.Label_tiempoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tiempoM.Location = New System.Drawing.Point(39, 71)
        Me.Label_tiempoM.Name = "Label_tiempoM"
        Me.Label_tiempoM.Size = New System.Drawing.Size(36, 25)
        Me.Label_tiempoM.TabIndex = 51
        Me.Label_tiempoM.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 26)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = ":"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Evaluacion.My.Resources.Resources.reloj3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'Form_Resta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(720, 494)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label_tiempoM)
        Me.Controls.Add(Me.Label_tiempoS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.Mensaj)
        Me.Controls.Add(Me.verif_miRespueta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Resta"
        Me.Text = "Form_Resta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_volver As Button
    Friend WithEvents Mensaj As Label
    Friend WithEvents verif_miRespueta As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_tiempoS As Label
    Friend WithEvents Label_tiempoM As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
