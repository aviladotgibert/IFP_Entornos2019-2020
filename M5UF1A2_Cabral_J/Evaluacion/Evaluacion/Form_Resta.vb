Public Class Form_Resta


    Dim valor1 As Integer
    Dim valor2 As Integer

    Dim respoUser As String
    Dim sumaS As String
    Dim suma As Integer

    Dim time As Timer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        time = Timer1

        Label_tiempoS.Text = "00"
        Label_tiempoM.Text = "00"

        time.Start()

        Dim num1 As New Random()
        Dim num2 As New Random()


        valor2 = num1.Next(1, 11)

        valor1 = num2.Next(2, 22)


        ' Dim valor1 As Integer = num1.Next(1, 11) '

        'Dim valor2 As Integer = num2.Next(2, 22)'
        Text1.Text = System.Convert.ToString(valor1)
        Text2.Text = System.Convert.ToString(valor2)
    End Sub

    Private Sub verif_miRespueta_CheckedChanged(sender As Object, e As EventArgs) Handles verif_miRespueta.CheckedChanged

        suma = valor1 - valor2

        respoUser = Text3.Text 'is ok' 


        Dim sumaSistema As Integer = CInt(Fix(suma))
        sumaS = sumaSistema.ToString

        'Text4.Text = respoUser' 'fue una preuba'

        If respoUser = sumaS Then

            Mensaj.Text = System.Convert.ToString("--- Heñorabuena, Has conseguido. Elige outro recto ---")
            time.Stop()
            My.Computer.Audio.Play(My.Resources.aplausos, playMode:=AudioPlayMode.BackgroundLoop)
        Else
            Mensaj.Text = System.Convert.ToString("--- Has Fallado. Volve a intentarlo ---")

        End If
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Dim inicio As New Form2
        inicio.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Label_tiempoS.Text += 1
        If Label_tiempoS.Text = "60" Then
            Label_tiempoM.Text += 1
            Label_tiempoS.Text = "00"
        End If

        If Label_tiempoM.Text = "1" And Label_tiempoS.Text = "30" Then
            time.Stop()
            Mensaj.Text = System.Convert.ToString("--- Lo Siento, se ha agotado el tiempo volve a intentarlo ---")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label_tiempoS.Text = "00"
        Label_tiempoM.Text = "00"
        Text1.Text = System.Convert.ToString("")
        Text2.Text = System.Convert.ToString("")
        Text3.Text = System.Convert.ToString("")
        Mensaj.Text = System.Convert.ToString("Mensaje:")
    End Sub

    Private Sub Mensaj_Click(sender As Object, e As EventArgs) Handles Mensaj.Click

    End Sub

    Private Sub Label_tiempoM_Click(sender As Object, e As EventArgs) Handles Label_tiempoM.Click

    End Sub

    Private Sub Label_tiempoS_Click(sender As Object, e As EventArgs) Handles Label_tiempoS.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Text3_TextChanged(sender As Object, e As EventArgs) Handles Text3.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Text1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Text2_TextChanged(sender As Object, e As EventArgs) Handles Text2.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class