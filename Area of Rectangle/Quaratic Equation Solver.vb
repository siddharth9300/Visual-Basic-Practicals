Public Class Quaratic_Equation_Solver


    Private Sub Quaratic_Equation_Solver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub solveButton_Click(sender As Object, e As EventArgs) Handles solveButton.Click
        Dim a, b, c, det As Integer
        Dim root1, root2 As Single


        a = Val(Coeff_a.Text)
        b = Val(Coeff_b.Text)
        c = Val(Coeff_c.Text)
        ' To compute the value of the determinant
        det = (b ^ 2) - (4 * a * c)
        If det > 0 Then
            Lbl_numroot.Text = "2"
            root1 = (-b + Math.Sqrt(det)) / (2 * a)
            root2 = (-b - Math.Sqrt(det)) / (2 * a)
            Answers.Text = "The roots are"
            Lbl_and.Visible = True
            txt_root1.Visible = True
            txt_root2.Visible = True
            txt_root1.Text = Math.Round(root1, 4).ToString()
            txt_root2.Text = Math.Round(root2, 4).ToString()
        ElseIf det = 0 Then
            root1 = (-b) / (2 * a)
            Lbl_numroot.Text = "1"
            Answers.Text = "The root is"
            txt_root1.Visible = True
            txt_root1.Text = root1.ToString()
        Else
            Lbl_numroot.Text = "0"
            Answers.Text = "There is no root"
        End If
    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        Coeff_a.Text = ""
        Coeff_b.Text = ""
        Coeff_c.Text = ""
        Answers.Text = ""
        txt_root1.Visible = False
        txt_root2.Visible = False
        txt_root1.Text = ""
        txt_root2.Text = ""
        Lbl_and.Visible = False
        Lbl_numroot.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class