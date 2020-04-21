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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lb_guardar = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_direccSede = New System.Windows.Forms.Label()
        Me.lb_sede = New System.Windows.Forms.Label()
        Me.lb_aula = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_curso = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_curso = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numDocumto = New System.Windows.Forms.TextBox()
        Me.txt_cuidad = New System.Windows.Forms.TextBox()
        Me.cb_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_numNie = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_letraDni = New System.Windows.Forms.TextBox()
        Me.txt_telf = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_apellidoP = New System.Windows.Forms.TextBox()
        Me.txt_apellidoM = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Num_Documento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido_P = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido_M = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.carerra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(67, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(708, 534)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.lb_guardar)
        Me.TabPage1.Controls.Add(Me.btn_salir)
        Me.TabPage1.Controls.Add(Me.btn_nuevo)
        Me.TabPage1.Controls.Add(Me.btn_guardar)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(700, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingreso Datos"
        '
        'lb_guardar
        '
        Me.lb_guardar.AutoSize = True
        Me.lb_guardar.Location = New System.Drawing.Point(52, 453)
        Me.lb_guardar.Name = "lb_guardar"
        Me.lb_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lb_guardar.TabIndex = 18
        Me.lb_guardar.Text = "Label17"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(538, 453)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(89, 31)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(538, 292)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(89, 32)
        Me.btn_nuevo.TabIndex = 16
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(538, 349)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(89, 33)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_direccSede)
        Me.GroupBox2.Controls.Add(Me.lb_sede)
        Me.GroupBox2.Controls.Add(Me.lb_aula)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lb_curso)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cb_curso)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 157)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Academicos"
        '
        'lb_direccSede
        '
        Me.lb_direccSede.AutoSize = True
        Me.lb_direccSede.Location = New System.Drawing.Point(91, 124)
        Me.lb_direccSede.Name = "lb_direccSede"
        Me.lb_direccSede.Size = New System.Drawing.Size(0, 13)
        Me.lb_direccSede.TabIndex = 21
        '
        'lb_sede
        '
        Me.lb_sede.AutoSize = True
        Me.lb_sede.Location = New System.Drawing.Point(78, 98)
        Me.lb_sede.Name = "lb_sede"
        Me.lb_sede.Size = New System.Drawing.Size(0, 13)
        Me.lb_sede.TabIndex = 20
        '
        'lb_aula
        '
        Me.lb_aula.AutoSize = True
        Me.lb_aula.Location = New System.Drawing.Point(78, 70)
        Me.lb_aula.Name = "lb_aula"
        Me.lb_aula.Size = New System.Drawing.Size(0, 13)
        Me.lb_aula.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Direccion"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Sede"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Aula"
        '
        'lb_curso
        '
        Me.lb_curso.AutoSize = True
        Me.lb_curso.Location = New System.Drawing.Point(121, 32)
        Me.lb_curso.Name = "lb_curso"
        Me.lb_curso.Size = New System.Drawing.Size(0, 13)
        Me.lb_curso.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Curso"
        '
        'cb_curso
        '
        Me.cb_curso.FormattingEnabled = True
        Me.cb_curso.Items.AddRange(New Object() {"DAM-01", "DAM-02", "VDJ-01", "VDJ-02", "ADF-01", "ADF-02"})
        Me.cb_curso.Location = New System.Drawing.Point(16, 32)
        Me.cb_curso.Name = "cb_curso"
        Me.cb_curso.Size = New System.Drawing.Size(64, 21)
        Me.cb_curso.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_numDocumto)
        Me.GroupBox1.Controls.Add(Me.txt_cuidad)
        Me.GroupBox1.Controls.Add(Me.cb_tipoDocumento)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_numNie)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_letraDni)
        Me.GroupBox1.Controls.Add(Me.txt_telf)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_date)
        Me.GroupBox1.Controls.Add(Me.txt_apellidoP)
        Me.GroupBox1.Controls.Add(Me.txt_apellidoM)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 227)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ciudad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Direccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Telef."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fecha Nac."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Apellido M"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Apellido P"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nro. Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo Doc"
        '
        'txt_numDocumto
        '
        Me.txt_numDocumto.Location = New System.Drawing.Point(121, 34)
        Me.txt_numDocumto.Name = "txt_numDocumto"
        Me.txt_numDocumto.Size = New System.Drawing.Size(100, 20)
        Me.txt_numDocumto.TabIndex = 2
        '
        'txt_cuidad
        '
        Me.txt_cuidad.Location = New System.Drawing.Point(369, 189)
        Me.txt_cuidad.Name = "txt_cuidad"
        Me.txt_cuidad.Size = New System.Drawing.Size(115, 20)
        Me.txt_cuidad.TabIndex = 11
        '
        'cb_tipoDocumento
        '
        Me.cb_tipoDocumento.FormattingEnabled = True
        Me.cb_tipoDocumento.Items.AddRange(New Object() {"DNI", "NIE"})
        Me.cb_tipoDocumento.Location = New System.Drawing.Point(26, 34)
        Me.cb_tipoDocumento.Name = "cb_tipoDocumento"
        Me.cb_tipoDocumento.Size = New System.Drawing.Size(48, 21)
        Me.cb_tipoDocumento.TabIndex = 0
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(81, 189)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(224, 20)
        Me.txt_direccion.TabIndex = 10
        '
        'txt_numNie
        '
        Me.txt_numNie.Location = New System.Drawing.Point(93, 34)
        Me.txt_numNie.Name = "txt_numNie"
        Me.txt_numNie.Size = New System.Drawing.Size(22, 20)
        Me.txt_numNie.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(63, 153)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(251, 20)
        Me.txt_email.TabIndex = 9
        '
        'txt_letraDni
        '
        Me.txt_letraDni.Location = New System.Drawing.Point(227, 35)
        Me.txt_letraDni.Name = "txt_letraDni"
        Me.txt_letraDni.Size = New System.Drawing.Size(26, 20)
        Me.txt_letraDni.TabIndex = 3
        '
        'txt_telf
        '
        Me.txt_telf.Location = New System.Drawing.Point(259, 119)
        Me.txt_telf.Name = "txt_telf"
        Me.txt_telf.Size = New System.Drawing.Size(100, 20)
        Me.txt_telf.TabIndex = 8
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(326, 34)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(137, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'txt_date
        '
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(93, 120)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(88, 20)
        Me.txt_date.TabIndex = 7
        '
        'txt_apellidoP
        '
        Me.txt_apellidoP.Location = New System.Drawing.Point(81, 79)
        Me.txt_apellidoP.Name = "txt_apellidoP"
        Me.txt_apellidoP.Size = New System.Drawing.Size(140, 20)
        Me.txt_apellidoP.TabIndex = 5
        '
        'txt_apellidoM
        '
        Me.txt_apellidoM.Location = New System.Drawing.Point(326, 76)
        Me.txt_apellidoM.Name = "txt_apellidoM"
        Me.txt_apellidoM.Size = New System.Drawing.Size(137, 20)
        Me.txt_apellidoM.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Lista)
        Me.TabPage2.Controls.Add(Me.btn_eliminar)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(700, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado Alunmos"
        '
        'Lista
        '
        Me.Lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Num_Documento, Me.ColumnHeader2, Me.Apellido_P, Me.Apellido_M, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.carerra})
        Me.Lista.FullRowSelect = True
        Me.Lista.GridLines = True
        Me.Lista.HideSelection = False
        Me.Lista.Location = New System.Drawing.Point(6, 113)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(683, 186)
        Me.Lista.TabIndex = 3
        Me.Lista.UseCompatibleStateImageBehavior = False
        Me.Lista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TipoDoc"
        Me.ColumnHeader1.Width = 42
        '
        'Num_Documento
        '
        Me.Num_Documento.Text = "Num_Documento"
        Me.Num_Documento.Width = 74
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 73
        '
        'Apellido_P
        '
        Me.Apellido_P.Text = "Apellido P"
        Me.Apellido_P.Width = 76
        '
        'Apellido_M
        '
        Me.Apellido_M.Text = "Apellido M"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Direccion"
        Me.ColumnHeader3.Width = 109
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        Me.ColumnHeader5.Width = 98
        '
        'carerra
        '
        Me.carerra.Text = "Carrera"
        Me.carerra.Width = 93
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(233, 330)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(123, 28)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(192, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(287, 25)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Listado de Alumnos Inscritos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(262, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 29)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Matricula de Alumnos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 612)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_cuidad As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_telf As TextBox
    Friend WithEvents txt_date As DateTimePicker
    Friend WithEvents txt_apellidoM As TextBox
    Friend WithEvents txt_apellidoP As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_letraDni As TextBox
    Friend WithEvents txt_numDocumto As TextBox
    Friend WithEvents txt_numNie As TextBox
    Friend WithEvents cb_tipoDocumento As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_curso As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lb_curso As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lb_direccSede As Label
    Friend WithEvents lb_sede As Label
    Friend WithEvents lb_aula As Label
    Friend WithEvents Lista As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Num_Documento As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Apellido_P As ColumnHeader
    Friend WithEvents Apellido_M As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents carerra As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents lb_guardar As Label
End Class
