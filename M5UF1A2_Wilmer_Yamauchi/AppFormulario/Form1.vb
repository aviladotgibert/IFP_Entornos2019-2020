Imports System.Text.RegularExpressions 'Importar esta clase para validar el email

Public Class Form1
    Private Sub cb_tipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipoDocumento.SelectedIndexChanged
        'Decuardo al campo selecionado se activara el campo que corresponde
        txt_numNie.Enabled = True
        Select Case cb_tipoDocumento.Text
            Case "DNI"
                txt_numNie.Enabled = False
            Case "NIE"
                txt_numNie.Focus()

        End Select
    End Sub

    Private Sub cb_curso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_curso.SelectedIndexChanged
        Dim sedeBarcelona, sedeBadalona, dirSedeBarcelona, dirSedeBadalona As String
        'Inicializacion de variables 
        sedeBarcelona = "Barcelona"
        sedeBadalona = "Badalona"

        dirSedeBarcelona = "Av. Diagonal 1585 CP 08080"
        dirSedeBadalona = "Carrer Pomar 457 cp 08966"
        'Asignado las variables y tetxos en label correspondiente segun sea el caso
        Select Case cb_curso.Text
            Case "DAM-01"
                lb_curso.Text = "Desarrollo de Aplicaciones Multiplataforma 01"
                lb_aula.Text = "A01"
                lb_sede.Text = sedeBarcelona
                lb_direccSede.Text = dirSedeBarcelona
            Case "DAM-02"
                lb_curso.Text = "Desarrollo de Aplicaciones Multiplataforma 02"
                lb_aula.Text = "A02"
                lb_sede.Text = sedeBarcelona
                lb_direccSede.Text = dirSedeBarcelona
            Case "VDJ-01"
                lb_curso.Text = "Video Juegos 01"
                lb_aula.Text = "A05"
                lb_sede.Text = sedeBarcelona
                lb_direccSede.Text = dirSedeBarcelona
            Case "VDJ-02"
                lb_curso.Text = "Video Juegos 02"
                lb_aula.Text = "A08"
                lb_sede.Text = sedeBarcelona
                lb_direccSede.Text = dirSedeBarcelona
            Case "ADF-01"
                lb_curso.Text = "Administracion y Finanzas 01"
                lb_aula.Text = "A09"
                lb_sede.Text = sedeBadalona
                lb_direccSede.Text = dirSedeBadalona
            Case "ADF-02"
                lb_curso.Text = "Administracion y Finanzas 02"
                lb_aula.Text = "A10"
                lb_sede.Text = sedeBadalona
                lb_direccSede.Text = dirSedeBadalona
        End Select
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra devuelve true o false
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    'validar email con Regex (xxx@xxx.xxx)
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    'Validaciones de los campos Correspondiente numeros y letras     
    Private Sub txt_numDocumto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numDocumto.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txt_telf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telf.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_apellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoM.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_apellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoP.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_cuidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cuidad.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_email_Leave(sender As Object, e As EventArgs) Handles txt_email.Leave
        If validar_Mail(LCase(txt_email.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " &
             " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_email.SelectAll()
            txt_email.Focus()
        End If
    End Sub

    'Boton Guardar evento click
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'Declarando variables para obtener los valores
        Dim tipdoc, NumDoucmento, nombre, apellidoP, apellidoM, email, direccion, carrera As String
        Dim telef As Integer

        'Asignando los valores ingresado del formulario a las variables
        If cb_tipoDocumento.Text = "DNI" Then
            tipdoc = "DNI"
            NumDoucmento = txt_numDocumto.Text + "-" + txt_letraDni.Text.ToUpper
        Else
            tipdoc = "NIE"
            NumDoucmento = txt_numNie.Text + "-" + txt_numDocumto.Text + "-" + txt_letraDni.Text.ToUpper
        End If
        nombre = txt_nombre.Text.ToUpper
        apellidoP = txt_apellidoP.Text.ToUpper
        apellidoM = txt_apellidoM.Text.ToUpper
        telef = txt_telf.Text
        direccion = txt_direccion.Text.ToUpper + "-" + txt_cuidad.Text.ToUpper
        carrera = cb_curso.Text.ToUpper
        email = txt_email.Text

        Dim opcion As DialogResult
        'Cuadro de Diagolo antes de Guardar
        opcion = MessageBox.Show("Guardar",
                                 "Desea Guardar la informacion",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        'Añadir a los campos a listView
        If (opcion = DialogResult.Yes) Then
            With Me.Lista.Items.Add(tipdoc)
                .SubItems.Add(NumDoucmento)
                .SubItems.Add(nombre)
                .SubItems.Add(apellidoP)
                .SubItems.Add(apellidoM)
                .SubItems.Add(direccion)
                .SubItems.Add(telef)
                .SubItems.Add(email)
                .SubItems.Add(carrera)
            End With
            limpiar()
            lb_guardar.Text = "Se guardo correctamente los datos...."

        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
    End Sub
    'Metodo de limpiar los campos
    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_apellidoM.Text = ""
        txt_apellidoP.Text = ""
        txt_cuidad.Text = ""
        txt_direccion.Text = ""
        txt_letraDni.Text = ""
        txt_email.Text = ""
        txt_telf.Text = ""
        txt_numDocumto.Text = ""
        lb_aula.Text = ""
        lb_curso.Text = ""
        lb_direccSede.Text = ""
        lb_sede.Text = ""
    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    'Eliminar el campo seleccionado del listview(lista)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim indice As Integer
        indice = Lista.FocusedItem.Index
        Lista.Items.RemoveAt(indice)
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()  'Cerrar el formulario
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
