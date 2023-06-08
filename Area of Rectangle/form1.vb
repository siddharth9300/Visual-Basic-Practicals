Public Class Form1


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        Dim Principle As Decimal
        Principle = priBox.Text

        Dim Rate As Decimal
        Rate = ratBox.Text


        Dim Time As Decimal
        Time = timBox.Text


        siAns.Text = "Simple Interest is " & (Principle * Rate * Time) / 100




    End Sub





    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim length As Decimal
        length = lenBox.Text

        Dim width As Decimal
        width = widBox.Text


        ans.Text = "Area of Rectangle is " & length * width

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Radius As Decimal
        Radius = BoxRad.Text
        radAns.Text = "Area of Circle is " & 3.14 * Radius * Radius


    End Sub

    Private Sub cylCal_Click(sender As Object, e As EventArgs) Handles cylCal.Click

        Dim CylRad As Decimal
        CylRad = BoxCylRad.Text

        Dim CylHei As Decimal
        CylHei = BoxCylHei.Text


        cylAns.Text = "Volume of Cylinder is " & 3.14 * CylRad * CylRad * CylHei



    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Fer As Decimal
        Fer = ferBox.Text
        ferAns.Text = Fer & "F in Celsius is " & (Fer - 32) * 5 / 9



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




        Dim Fir As Decimal
        Fir = first.Text

        Dim Second As Decimal
        Second = sec.Text


        Dim Thi As Decimal
        Thi = third.Text

        Dim greatest As Decimal


        If Fir >= Second And Fir >= Thi Then
            greatest = Fir
        ElseIf Second >= Thi And Second >= Fir Then
            greatest = Second
        Else
            greatest = Thi
        End If


        greatAns.Text = greatest & " is the Greatest Number"




    End Sub

    Private Sub calculator_Click(sender As Object, e As EventArgs) Handles calculator.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double
        Dim operation As String

        num1 = txtOneNum.Text ' Example value
        num2 = txtSecNum.Text ' Example value
        operation = comOperation.Text ' Example value

        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                result = num1 / num2
            Case Else
                MsgBox("Invalid operation")
        End Select

        ansForCalc.Text = "The result is: " & result



    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click
        Dim number As Integer

        number = 5 ' Example value

        For i = 1 To 10
            ListBox1.Items.Add(number & " x " & i & " = " & number * i)
        Next i

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        ListBox1.Items.Clear()

        Dim number As Integer
        number = txtInpNum.Text ' Example value

        For i = 1 To 10
            ListBox1.Items.Add(number & " x " & i & " = " & number * i)
        Next i

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub


    Private Sub btnquadraticsolver_Click(sender As Object, e As EventArgs) Handles btnquadraticsolver.Click
        ' Create an instance of the form "Quadratic_Equation_Solver"
        Dim quadraticForm As New Quaratic_Equation_Solver()

        ' Show the "Quadratic_Equation_Solver" form
        quadraticForm.Show()
    End Sub

    Private Sub btnjigsaw_Click(sender As Object, e As EventArgs) Handles btnjigsaw.Click

        Dim jigsawform As New Jigsaw_Puzzle_Game()

        ' Show the "Quadratic_Equation_Solver" form
        jigsawform.Show()
    End Sub
End Class
