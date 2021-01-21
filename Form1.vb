Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim side1 As Double
        Dim side2 As Double
        Dim side3 As Double
        Dim eq As Double
        Dim eq1 As Double
        Dim eq2 As Double
        Dim eq3 As Double
        Dim s As Double
        Dim area As Double
        side1 = CDbl(txtSide1.Text)
        side2 = CDbl(txtSide2.Text)
        side3 = CDbl(txtSide3.Text)
        eq = side1 + side2
        If eq >= side3 Then
            txtQuestion.Text = "Yes"
            s = (side1 + side2 + side3) / 2
            eq1 = s - side1
            eq2 = s - side2
            eq3 = s - side3
            area = Math.Sqrt(s * eq1 * eq2 * eq3)
            txtArea.Text = String.Format("{0:N}", area)
        Else
            txtQuestion.Text = "No"
            txtArea.Text = "N/A"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtArea.Text = ""
        txtQuestion.Text = ""
        txtSide1.Text = ""
        txtSide2.Text = ""
        txtSide3.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
