Public Class Inicio
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles ButtonJugar.Click
        Juego.Show()
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub
End Class