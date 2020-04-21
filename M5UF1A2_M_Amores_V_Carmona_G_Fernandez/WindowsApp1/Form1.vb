Public Class Form1
    'variables publicas
    Dim DATO1 As Double
    Dim DATO2 As Double
    Dim OPE As Double
    Dim RES As Double
    Dim CADENA As Double
    Dim MEM As String
    'Declaramos los botones de la interfaz del 0 al 9
    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        txtpantalla.Text = txtpantalla.Text & "1"
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        txtpantalla.Text = txtpantalla.Text & "2"
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        txtpantalla.Text = txtpantalla.Text & "3"
    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        txtpantalla.Text = txtpantalla.Text & "4"
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        txtpantalla.Text = txtpantalla.Text & "5"
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        txtpantalla.Text = txtpantalla.Text & "6"
    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        txtpantalla.Text = txtpantalla.Text & "7"
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        txtpantalla.Text = txtpantalla.Text & "8"
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        txtpantalla.Text = txtpantalla.Text & "9"
    End Sub

    Private Sub btnzero_Click(sender As Object, e As EventArgs) Handles btnzero.Click
        txtpantalla.Text = txtpantalla.Text & "0"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        Try
            If txtpantalla.Text.IndexOf(",") > 0 Then
                Beep()
            ElseIf txtpantalla.Text <> "," Then
                txtpantalla.Text = txtpantalla.Text & ","
            Else
                txtpantalla.Text = "0,"
            End If
        Catch ex As Exception
        End Try
    End Sub
    'codificación botones de operaciones
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        OPE = 1
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtref.Text = DATO1 & " + "
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        OPE = 2
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtref.Text = DATO1 & " - "
    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        OPE = 3
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtref.Text = DATO1 & " × "
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        OPE = 4
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtref.Text = DATO1 & " ÷ "
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        DATO2 = Val(txtpantalla.Text)

        If OPE = 1 Then
            RES = DATO1 + DATO2
            txtpantalla.Text = RES
            txtref.Text = txtref.Text & DATO2

        Else
            If OPE = 2 Then
                RES = DATO1 - DATO2
                txtpantalla.Text = RES
                txtref.Text = txtref.Text & DATO2

            Else
                If OPE = 3 Then
                    RES = DATO1 * DATO2
                    txtpantalla.Text = RES
                    txtref.Text = txtref.Text & DATO2

                Else
                    If OPE = 4 Then
                        RES = DATO1 / DATO2
                        txtpantalla.Text = RES
                        txtref.Text = txtref.Text & DATO2

                    Else
                        If OPE = 5 Then
                            RES = DATO1 ^ DATO2
                            txtpantalla.Text = RES
                            txtref.Text = txtref.Text & DATO2

                        Else
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    'Codificación botones "especiales" necesarios para operaciones en concreto
    Private Sub btnbackspace_Click(sender As Object, e As EventArgs) Handles btnbackspace.Click
        If txtpantalla.Text <> "" Then
            CADENA = txtpantalla.Text.Length
            txtpantalla.Text = Mid(txtpantalla.Text, 1, CADENA - 1)
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpantalla.Text = ""
        txtref.Text = ""
    End Sub

    Private Sub btnmasmenos_Click(sender As Object, e As EventArgs) Handles btnmasmenos.Click
        If txtpantalla.Text <> "" Then
            txtpantalla.Text = txtpantalla.Text * (-1)
        End If
    End Sub

    Private Sub btnreciproco_Click(sender As Object, e As EventArgs) Handles btnreciproco.Click
        DATO1 = txtpantalla.Text
        txtpantalla.Text = 1 / DATO1

        txtref.Text = "1 / " & DATO1
    End Sub

    Private Sub btncuadrado_Click(sender As Object, e As EventArgs) Handles btncuadrado.Click
        txtref.Text = "(" & txtpantalla.Text & ")" & "²"
        txtpantalla.Text = Val((txtpantalla.Text) ^ (2))
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        txtref.Text = "√" & "" & txtpantalla.Text & " "
        txtpantalla.Text = (Val(txtpantalla.Text)) ^ (1 / 2)
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click
        DATO2 = txtpantalla.Text
        txtref.Text = "% = (" & DATO1 & "x"
        RES = (DATO1 * DATO2) / 100
        txtpantalla.Text = RES
        txtref.Text = txtref.Text & DATO2 & ") / 100"
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        txtref.Text = "Log " & "(" & txtpantalla.Text & ")"
        txtpantalla.Text = Math.Log10(d:=Val(txtpantalla.Text))
    End Sub

    Private Sub btntan_Click(sender As Object, e As EventArgs) Handles btntan.Click
        txtref.Text = "Tan " & "(" & txtpantalla.Text & ")"
        txtpantalla.Text = Math.Tan(a:=Val(txtpantalla.Text))
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        txtref.Text = "Cos " & "(" & txtpantalla.Text & ")"
        txtpantalla.Text = Math.Cos(d:=Val(txtpantalla.Text))
    End Sub

    Private Sub btnsin_Click(sender As Object, e As EventArgs) Handles btnsin.Click
        txtref.Text = "Sin " & "(" & txtpantalla.Text & ")"
        txtpantalla.Text = Math.Sin(a:=Val(txtpantalla.Text))
    End Sub

    Private Sub bntpi_Click(sender As Object, e As EventArgs) Handles bntpi.Click

        txtpantalla.Text = Math.PI
    End Sub

    Private Sub btnexp_Click(sender As Object, e As EventArgs) Handles btnexp.Click

        txtpantalla.Text = Math.Exp(txtpantalla.Text)
    End Sub

    Private Sub btndiezx_Click(sender As Object, e As EventArgs) Handles btndiezx.Click

        DATO1 = 10
        txtref.Text = "10 ^" & "" & txtpantalla.Text
        DATO2 = Val(txtpantalla.Text)
        txtpantalla.Text = (DATO1) ^ (DATO2)

    End Sub

    Private Sub btnpotvariable_Click(sender As Object, e As EventArgs) Handles btnpotvariable.Click
        OPE = 5
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtref.Text = DATO1 & " ^ "
    End Sub

    Private Sub bntms_Click(sender As Object, e As EventArgs) Handles bntms.Click
        MEM = txtpantalla.Text

        lblMEM.Visible = True
    End Sub

    Private Sub btnmr_Click(sender As Object, e As EventArgs) Handles btnmr.Click
        txtpantalla.Text = MEM
    End Sub

    Private Sub btnmc_Click(sender As Object, e As EventArgs) Handles btnmc.Click
        MEM = ""
        lblMEM.Visible = False
    End Sub
End Class