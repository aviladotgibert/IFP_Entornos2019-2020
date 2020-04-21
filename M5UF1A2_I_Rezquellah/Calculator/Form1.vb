Public Class Form1
    Dim value1 As String
    Dim value2 As String
    Dim value3 As String

    Dim operacion As Char

    Dim primerNumero As Double
    Dim segundoNumero As Double
    Dim tercerNumero As Double

    'Boton 9 
    'Saca el valor del boton y le asigna el valor 9 al textbox
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        'Con este if statement me aseguro que si hay un 0 en el textbox1 se hace un clear para que los numeros no empiecen por 0
        'Como por ejemplo --> 025 + 2 = 27 
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(9)
    End Sub
    'Boton 8 
    'Saca el valor del boton y le asigna el valor 8 al textbox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(8)
    End Sub
    'Boton 7 
    'Saca el valor del boton y le asigna el valor 7 al textbox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(7)
    End Sub
    'Boton 6 
    'Saca el valor del boton y le asigna el valor 6 al textbox
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(6)
    End Sub
    'Boton 5 
    'Saca el valor del boton y le asigna el valor 5 al textbox
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(5)
    End Sub
    'Boton 4 
    'Saca el valor del boton y le asigna el valor 4 al textbox
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(4)
    End Sub
    'Boton 3
    'Saca el valor del boton y le asigna el valor 3 al textbox
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(3)
    End Sub
    'Boton 2 
    'Saca el valor del boton y le asigna el valor 2 al textbox
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(2)
    End Sub
    'Boton 1 
    'Saca el valor del boton y le asigna el valor 1 al textbox
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(1)
    End Sub
    'Boton 0
    'Saca el valor del boton y le asigna el valor 0 al textbox
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_0.Click

        TextBox1.AppendText(0)
    End Sub
    'Boton ","
    'Saca el valor del boton y le asigna el valor "," al textbox
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_dot.Click

        TextBox1.AppendText(",")
        'Con el punto no funciona por eso he utilizado la coma '
    End Sub
    'reset
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox1.Clear()
        TextBox1.Text = "0"
        TextBox2.Clear()
        value1 = ""
        value3 = ""
        value2 = ""
    End Sub
    'Pasa los valores del textbox1 al textbox2(donde se muestra la operacion realizada)
    'Mismos pasos en los metodos sumar,multiplicar y dividir
    Private Sub btn_restar_Click(sender As Object, e As EventArgs) Handles btn_restar.Click
        value1 = TextBox1.Text
        value2 = "-"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()

    End Sub

    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        value1 = TextBox1.Text
        value2 = "+"
        'Con los appends de este metodo lo que hago es mostrar parte de la operacion en el textbox2
        'La operacion completa se mostrara en el textbox2 cuando se haga click en el boton "="
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    Private Sub btn_multip_Click(sender As Object, e As EventArgs) Handles btn_multip.Click
        value1 = TextBox1.Text
        value2 = "x"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        value1 = TextBox1.Text
        value2 = "/"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    'Metodo donde se realizan las operaciones 
    'En esta version de la calculadora tan solo se pueden realizar operciones simples
    Private Sub btn_resultado_Click(sender As Object, e As EventArgs) Handles btn_resultado.Click
        value3 = TextBox1.Text
        operacion = value2
        primerNumero = Convert.ToDouble(value1)
        If (TextBox1.Text.Equals("")) Then
            segundoNumero = primerNumero

        Else
            segundoNumero = Convert.ToDouble(value3)
        End If


        Select Case (operacion)
            Case "+"
                tercerNumero = primerNumero + segundoNumero
            Case "-"
                tercerNumero = primerNumero - segundoNumero
            Case "/"
                tercerNumero = primerNumero / segundoNumero
            Case "x"
                tercerNumero = primerNumero * segundoNumero
        End Select

        TextBox1.Text = Convert.ToString(tercerNumero)

        TextBox2.Clear()
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(operacion + " ")
        TextBox2.AppendText(value3 + " ")
        TextBox2.AppendText("=")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
