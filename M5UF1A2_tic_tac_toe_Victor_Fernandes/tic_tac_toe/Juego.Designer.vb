<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
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
        Me.label_X = New System.Windows.Forms.Label()
        Me.label_O = New System.Windows.Forms.Label()
        Me.button_C1 = New System.Windows.Forms.Button()
        Me.button_C2 = New System.Windows.Forms.Button()
        Me.button_C3 = New System.Windows.Forms.Button()
        Me.button_C4 = New System.Windows.Forms.Button()
        Me.button_C5 = New System.Windows.Forms.Button()
        Me.button_C6 = New System.Windows.Forms.Button()
        Me.button_C7 = New System.Windows.Forms.Button()
        Me.button_C8 = New System.Windows.Forms.Button()
        Me.button_C9 = New System.Windows.Forms.Button()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelO = New System.Windows.Forms.Label()
        Me.Label_tic_tac_toe = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_NuevoJuego = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_X
        '
        Me.label_X.AutoSize = True
        Me.label_X.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_X.Location = New System.Drawing.Point(75, 69)
        Me.label_X.Name = "label_X"
        Me.label_X.Size = New System.Drawing.Size(0, 37)
        Me.label_X.TabIndex = 0
        '
        'label_O
        '
        Me.label_O.AutoSize = True
        Me.label_O.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_O.Location = New System.Drawing.Point(74, 128)
        Me.label_O.Name = "label_O"
        Me.label_O.Size = New System.Drawing.Size(0, 37)
        Me.label_O.TabIndex = 1
        '
        'button_C1
        '
        Me.button_C1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C1.Location = New System.Drawing.Point(136, 63)
        Me.button_C1.Name = "button_C1"
        Me.button_C1.Size = New System.Drawing.Size(164, 108)
        Me.button_C1.TabIndex = 2
        Me.button_C1.UseVisualStyleBackColor = True
        '
        'button_C2
        '
        Me.button_C2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C2.Location = New System.Drawing.Point(136, 177)
        Me.button_C2.Name = "button_C2"
        Me.button_C2.Size = New System.Drawing.Size(164, 108)
        Me.button_C2.TabIndex = 3
        Me.button_C2.UseVisualStyleBackColor = True
        '
        'button_C3
        '
        Me.button_C3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C3.Location = New System.Drawing.Point(136, 291)
        Me.button_C3.Name = "button_C3"
        Me.button_C3.Size = New System.Drawing.Size(164, 108)
        Me.button_C3.TabIndex = 4
        Me.button_C3.UseVisualStyleBackColor = True
        '
        'button_C4
        '
        Me.button_C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C4.Location = New System.Drawing.Point(306, 64)
        Me.button_C4.Name = "button_C4"
        Me.button_C4.Size = New System.Drawing.Size(164, 108)
        Me.button_C4.TabIndex = 5
        Me.button_C4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.button_C4.UseVisualStyleBackColor = True
        '
        'button_C5
        '
        Me.button_C5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C5.Location = New System.Drawing.Point(306, 178)
        Me.button_C5.Name = "button_C5"
        Me.button_C5.Size = New System.Drawing.Size(164, 108)
        Me.button_C5.TabIndex = 6
        Me.button_C5.UseVisualStyleBackColor = True
        '
        'button_C6
        '
        Me.button_C6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C6.Location = New System.Drawing.Point(306, 292)
        Me.button_C6.Name = "button_C6"
        Me.button_C6.Size = New System.Drawing.Size(164, 108)
        Me.button_C6.TabIndex = 7
        Me.button_C6.UseVisualStyleBackColor = True
        '
        'button_C7
        '
        Me.button_C7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C7.Location = New System.Drawing.Point(476, 64)
        Me.button_C7.Name = "button_C7"
        Me.button_C7.Size = New System.Drawing.Size(164, 108)
        Me.button_C7.TabIndex = 8
        Me.button_C7.UseVisualStyleBackColor = True
        '
        'button_C8
        '
        Me.button_C8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C8.Location = New System.Drawing.Point(476, 178)
        Me.button_C8.Name = "button_C8"
        Me.button_C8.Size = New System.Drawing.Size(164, 108)
        Me.button_C8.TabIndex = 9
        Me.button_C8.UseVisualStyleBackColor = True
        '
        'button_C9
        '
        Me.button_C9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_C9.Location = New System.Drawing.Point(476, 291)
        Me.button_C9.Name = "button_C9"
        Me.button_C9.Size = New System.Drawing.Size(164, 108)
        Me.button_C9.TabIndex = 10
        Me.button_C9.UseVisualStyleBackColor = True
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX.Location = New System.Drawing.Point(12, 64)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(46, 37)
        Me.LabelX.TabIndex = 11
        Me.LabelX.Text = "X: "
        '
        'LabelO
        '
        Me.LabelO.AutoSize = True
        Me.LabelO.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO.Location = New System.Drawing.Point(10, 128)
        Me.LabelO.Name = "LabelO"
        Me.LabelO.Size = New System.Drawing.Size(48, 37)
        Me.LabelO.TabIndex = 12
        Me.LabelO.Text = "O: "
        '
        'Label_tic_tac_toe
        '
        Me.Label_tic_tac_toe.AutoSize = True
        Me.Label_tic_tac_toe.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_tic_tac_toe.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tic_tac_toe.Location = New System.Drawing.Point(319, 9)
        Me.Label_tic_tac_toe.Name = "Label_tic_tac_toe"
        Me.Label_tic_tac_toe.Size = New System.Drawing.Size(138, 37)
        Me.Label_tic_tac_toe.TabIndex = 13
        Me.Label_tic_tac_toe.Text = "Tic Tac Toe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 29)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Menu})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(672, 29)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem_Menu
        '
        Me.ToolStripMenuItem_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_NuevoJuego, Me.ToolStripMenuItem_Salir})
        Me.ToolStripMenuItem_Menu.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem_Menu.Name = "ToolStripMenuItem_Menu"
        Me.ToolStripMenuItem_Menu.Size = New System.Drawing.Size(54, 25)
        Me.ToolStripMenuItem_Menu.Text = "Menu"
        '
        'ToolStripMenuItem_NuevoJuego
        '
        Me.ToolStripMenuItem_NuevoJuego.Name = "ToolStripMenuItem_NuevoJuego"
        Me.ToolStripMenuItem_NuevoJuego.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripMenuItem_NuevoJuego.Text = "NuevoJuego"
        '
        'ToolStripMenuItem_Salir
        '
        Me.ToolStripMenuItem_Salir.Name = "ToolStripMenuItem_Salir"
        Me.ToolStripMenuItem_Salir.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripMenuItem_Salir.Text = "Salir"
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 450)
        Me.Controls.Add(Me.Label_tic_tac_toe)
        Me.Controls.Add(Me.LabelO)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.button_C9)
        Me.Controls.Add(Me.button_C8)
        Me.Controls.Add(Me.button_C7)
        Me.Controls.Add(Me.button_C6)
        Me.Controls.Add(Me.button_C5)
        Me.Controls.Add(Me.button_C4)
        Me.Controls.Add(Me.button_C3)
        Me.Controls.Add(Me.button_C2)
        Me.Controls.Add(Me.button_C1)
        Me.Controls.Add(Me.label_O)
        Me.Controls.Add(Me.label_X)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Juego"
        Me.Text = "Form1"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_X As Label
    Friend WithEvents label_O As Label
    Friend WithEvents button_C1 As Button
    Friend WithEvents button_C2 As Button
    Friend WithEvents button_C3 As Button
    Friend WithEvents button_C4 As Button
    Friend WithEvents button_C5 As Button
    Friend WithEvents button_C6 As Button
    Friend WithEvents button_C7 As Button
    Friend WithEvents button_C8 As Button
    Friend WithEvents button_C9 As Button
    Friend WithEvents LabelX As Label
    Friend WithEvents LabelO As Label
    Friend WithEvents Label_tic_tac_toe As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem_Menu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_NuevoJuego As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Salir As ToolStripMenuItem
End Class
