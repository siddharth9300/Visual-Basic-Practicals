<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quaratic_Equation_Solver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Coeff_a = New TextBox()
        Coeff_b = New TextBox()
        Coeff_c = New TextBox()
        solveButton = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Answers = New Label()
        Lbl_and = New Label()
        Lbl_numroot = New TextBox()
        txt_root1 = New TextBox()
        txt_root2 = New TextBox()
        newButton = New Button()
        SuspendLayout()
        ' 
        ' Coeff_a
        ' 
        Coeff_a.Location = New Point(374, 89)
        Coeff_a.Name = "Coeff_a"
        Coeff_a.Size = New Size(100, 23)
        Coeff_a.TabIndex = 0
        ' 
        ' Coeff_b
        ' 
        Coeff_b.Location = New Point(374, 135)
        Coeff_b.Name = "Coeff_b"
        Coeff_b.Size = New Size(100, 23)
        Coeff_b.TabIndex = 1
        ' 
        ' Coeff_c
        ' 
        Coeff_c.Location = New Point(374, 177)
        Coeff_c.Name = "Coeff_c"
        Coeff_c.Size = New Size(100, 23)
        Coeff_c.TabIndex = 2
        ' 
        ' solveButton
        ' 
        solveButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        solveButton.Location = New Point(236, 349)
        solveButton.Name = "solveButton"
        solveButton.Size = New Size(75, 41)
        solveButton.TabIndex = 3
        solveButton.Text = "Solve"
        solveButton.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(489, 349)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 41)
        Button3.TabIndex = 5
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(223, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 17)
        Label1.TabIndex = 6
        Label1.Text = "Cofficíent b ="
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(223, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 17)
        Label2.TabIndex = 7
        Label2.Text = "Cofficíent b ="
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(222, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 8
        Label3.Text = "Cofficíent c ="
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(222, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 17)
        Label4.TabIndex = 9
        Label4.Text = "Number of Roots"
        ' 
        ' Answers
        ' 
        Answers.AutoSize = True
        Answers.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Answers.Location = New Point(222, 279)
        Answers.Name = "Answers"
        Answers.Size = New Size(90, 17)
        Answers.TabIndex = 10
        Answers.Text = "The roots are"
        ' 
        ' Lbl_and
        ' 
        Lbl_and.AutoSize = True
        Lbl_and.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_and.Location = New Point(420, 284)
        Lbl_and.Name = "Lbl_and"
        Lbl_and.Size = New Size(33, 17)
        Lbl_and.TabIndex = 11
        Lbl_and.Text = "And"
        ' 
        ' Lbl_numroot
        ' 
        Lbl_numroot.Location = New Point(374, 229)
        Lbl_numroot.Name = "Lbl_numroot"
        Lbl_numroot.Size = New Size(100, 23)
        Lbl_numroot.TabIndex = 12
        ' 
        ' txt_root1
        ' 
        txt_root1.Location = New Point(325, 278)
        txt_root1.Name = "txt_root1"
        txt_root1.Size = New Size(64, 23)
        txt_root1.TabIndex = 13
        ' 
        ' txt_root2
        ' 
        txt_root2.Location = New Point(476, 278)
        txt_root2.Name = "txt_root2"
        txt_root2.Size = New Size(64, 23)
        txt_root2.TabIndex = 14
        ' 
        ' newButton
        ' 
        newButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        newButton.Location = New Point(374, 349)
        newButton.Name = "newButton"
        newButton.Size = New Size(75, 41)
        newButton.TabIndex = 15
        newButton.Text = "New"
        newButton.UseVisualStyleBackColor = True
        ' 
        ' Quaratic_Equation_Solver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(newButton)
        Controls.Add(txt_root2)
        Controls.Add(txt_root1)
        Controls.Add(Lbl_numroot)
        Controls.Add(Lbl_and)
        Controls.Add(Answers)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(solveButton)
        Controls.Add(Coeff_c)
        Controls.Add(Coeff_b)
        Controls.Add(Coeff_a)
        Name = "Quaratic_Equation_Solver"
        Text = "Quaratic_Equation_Solver"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Coeff_a As TextBox
    Friend WithEvents Coeff_b As TextBox
    Friend WithEvents Coeff_c As TextBox
    Friend WithEvents solveButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Answers As Label
    Friend WithEvents Lbl_and As Label
    Friend WithEvents Lbl_numroot As TextBox
    Friend WithEvents txt_root1 As TextBox
    Friend WithEvents txt_root2 As TextBox
    Friend WithEvents newButton As Button
End Class
