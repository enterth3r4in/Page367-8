Public Class Form1

    Dim busfares(,) As Double = {{7.5, 10.0, 12.0, 12.75}, _
                                 {14.0, 18.5, 22.0, 23.0}, _
                                 {20.0, 21.0, 32.0, 33.0}, _
                                 {25.0, 27.5, 36.0, 37.0}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbNumPass.Clear()
        tbNumZones.Clear()
        Label5.Text = String.Empty
        tbNumPass.Focus()

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Label5.Text = busfares(0, 2)
    End Sub
End Class
