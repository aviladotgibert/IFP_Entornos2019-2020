Public Class Juego

    'Declaramos las variables x_o y la inicializamos con valor de X, empate y dos contadores para X y O que inicializamos en 0 '
    Dim x_o As String = "x"
    Dim contadorX As Integer = 0
    Dim contadorO As Integer = 0
    Dim empate As Integer = 0

    'Declaramos la funcion o_x  si la variable eleccion es igual x la variable x_o cambia a 0 para que la siguiente  eleccion sea x'
    Public Function funcion_x_o(ByVal eleccion As String)

        If eleccion = "x" Then
            x_o = "o"
            Return "x"
        Else
            x_o = "x"
            Return "o"
        End If
    End Function

    'Subrutina en la cual asignamos los movimientos de X para ganar la partida'

    Public Sub Xganador()
        empate += 1
        If button_C1.Text = "x" And button_C2.Text = "x" And button_C3.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C4.Text = "x" And button_C5.Text = "x" And button_C6.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C7.Text = "x" And button_C8.Text = "x" And button_C9.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C1.Text = "x" And button_C4.Text = "x" And button_C7.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C2.Text = "x" And button_C5.Text = "x" And button_C8.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C3.Text = "x" And button_C6.Text = "x" And button_C9.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C1.Text = "x" And button_C5.Text = "x" And button_C9.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf button_C3.Text = "x" And button_C5.Text = "x" And button_C7.Text = "x" Then
            MsgBox("El ganador del juego es X.", MsgBoxStyle.Information, "Ganador X")
            juegoTerminado_X()
        ElseIf empate = 9 Then
            MsgBox("El Juego ha quedado empatado.", MsgBoxStyle.Information, "Empate")
            empate = 0

            'Condicion en la cual asignamos que mientras X no juegue en  los movimientos de la subruita X el ganador es O'

        End If
        Oganador()
    End Sub

    'Subrutina en la cual asignamos los movimientos de O para ganar la partida'

    Public Sub Oganador()
        empate += 1
        If button_C1.Text = "o" And button_C2.Text = "o" And button_C3.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C4.Text = "o" And button_C5.Text = "o" And button_C6.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C7.Text = "o" And button_C8.Text = "o" And button_C9.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C1.Text = "o" And button_C4.Text = "o" And button_C7.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C2.Text = "o" And button_C5.Text = "o" And button_C8.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C3.Text = "o" And button_C6.Text = "o" And button_C9.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C1.Text = "o" And button_C5.Text = "o" And button_C9.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()
        ElseIf button_C3.Text = "o" And button_C5.Text = "o" And button_C7.Text = "o" Then
            MsgBox("El ganador del juego es O.", MsgBoxStyle.Information, "Ganador O")
            juegoTerminado_O()

            'Condicion que si el contador empate es igual a 9  sabra que fueron seleccionado los 9 botones y la partida termina en empate'

        ElseIf empate = 9 Then
            MsgBox("El Juego ha quedado empatado.", MsgBoxStyle.Information, "Empate")
            empate = 0
        End If
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton1 se escriba X / O'

    Private Sub button_C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_C1.Click
        button_C1.Text = funcion_x_o(x_o)
        button_C1.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton2 se escriba X / O'

    Private Sub button_C2_Click(sender As Object, e As EventArgs) Handles button_C2.Click
        button_C2.Text = funcion_x_o(x_o)
        button_C2.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton3 se escriba X / O'

    Private Sub button_C3_Click(sender As Object, e As EventArgs) Handles button_C3.Click
        button_C3.Text = funcion_x_o(x_o)
        button_C3.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton4 se escriba X / O'

    Private Sub button_C4_Click(sender As Object, e As EventArgs) Handles button_C4.Click
        button_C4.Text = funcion_x_o(x_o)
        button_C4.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton5 se escriba X / O'

    Private Sub button_C5_Click(sender As Object, e As EventArgs) Handles button_C5.Click
        button_C5.Text = funcion_x_o(x_o)
        button_C5.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton6 se escriba X / O'

    Private Sub button_C6_Click(sender As Object, e As EventArgs) Handles button_C6.Click
        button_C6.Text = funcion_x_o(x_o)
        button_C6.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton7 se escriba X / O'

    Private Sub button_C7_Click(sender As Object, e As EventArgs) Handles button_C7.Click
        button_C7.Text = funcion_x_o(x_o)
        button_C7.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton8 se escriba X / O'

    Private Sub button_C8_Click(sender As Object, e As EventArgs) Handles button_C8.Click
        button_C8.Text = funcion_x_o(x_o)
        button_C8.Enabled = False
        Xganador()
    End Sub

    'Subrutina donde la funcion_x_o  hace que al clicar el boton9 se escriba X / O'

    Private Sub button_C9_Click(sender As Object, e As EventArgs) Handles button_C9.Click
        button_C9.Text = funcion_x_o(x_o)
        button_C9.Enabled = False
        Xganador()
    End Sub

    'Subrutina para que el juego termine si gana X y bloquee los botones'
    Public Sub juegoTerminado_X()
        button_C1.Enabled = False
        button_C2.Enabled = False
        button_C3.Enabled = False
        button_C4.Enabled = False
        button_C5.Enabled = False
        button_C6.Enabled = False
        button_C7.Enabled = False
        button_C8.Enabled = False
        button_C9.Enabled = False
        contadorX += 1
        empate = 0
        label_X.Text = contadorX.ToString
    End Sub

    'Subrutina para que el juego termine si gana O y bloquee los botones'
    Public Sub juegoTerminado_O()
        button_C1.Enabled = False
        button_C2.Enabled = False
        button_C3.Enabled = False
        button_C4.Enabled = False
        button_C5.Enabled = False
        button_C6.Enabled = False
        button_C7.Enabled = False
        button_C8.Enabled = False
        button_C9.Enabled = False
        contadorO += 1
        empate = 0
        label_O.Text = contadorO.ToString
    End Sub

    'Subrutina Resetear para volvel a jugar'
    Public Sub resetear()
        button_C1.Enabled = True
        button_C2.Enabled = True
        button_C3.Enabled = True
        button_C4.Enabled = True
        button_C5.Enabled = True
        button_C6.Enabled = True
        button_C7.Enabled = True
        button_C8.Enabled = True
        button_C9.Enabled = True

        'Limpiamos los cuadros para que queden sin x y o'

        button_C1.Text = ""
        button_C2.Text = ""
        button_C3.Text = ""
        button_C4.Text = ""
        button_C5.Text = ""
        button_C6.Text = ""
        button_C7.Text = ""
        button_C8.Text = ""
        button_C9.Text = ""
    End Sub


    'Subrutina para jugar de nuevo'

    Private Sub ToolStripMenuItem_NuevoJuego_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem_NuevoJuego.Click
        resetear()
        empate = 0
    End Sub


    'Subrutina para terminar el juego'
    Private Sub ToolStripMenuItem_Salir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem_Salir.Click
        Me.Close()
    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
