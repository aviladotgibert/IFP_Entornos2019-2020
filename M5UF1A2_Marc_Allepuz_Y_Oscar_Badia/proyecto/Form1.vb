Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double
        ) = Nothing
    Dim Valor2 As Nullable(Of Double
        ) = Nothing
    Dim SePresionaOperador As Boolean

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        TextResultado.Text &= "9"
    End Sub

    Private Sub Buttonp_Click(sender As Object, e As EventArgs) Handles Buttonp.Click

        If InStr(TextResultado.Text, ".", CompareMethod.Text) = 0 Then
            TextResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"

    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub
    Private Sub Exp_Click(sender As Object, e As EventArgs) Handles Exp.Click
        EvaluayHazOperacion()
        Operacion = "^"
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextResultado.Text
                     )
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
                Case "^"
                    ValorResultado = ValorResultado ^ Valor2
            End Select
            TextResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2

        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextResultado.Text = ""
            SePresionaOperador = False
        ElseIf TextResultado.Text = "0" Then
            TextResultado.Text = ""
        End If
    End Sub

    Private Sub Buttoni_Click(sender As Object, e As EventArgs) Handles Buttoni.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub
End Class
