<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ans = New Label()
        widBox = New TextBox()
        widLab = New Label()
        calcBtn = New Button()
        lenBox = New TextBox()
        lenLab = New Label()
        TabPage2 = New TabPage()
        radAns = New Label()
        Button1 = New Button()
        BoxRad = New TextBox()
        labRad = New Label()
        TabPage3 = New TabPage()
        cylAns = New Label()
        BoxCylHei = New TextBox()
        Label2 = New Label()
        cylCal = New Button()
        BoxCylRad = New TextBox()
        Label3 = New Label()
        siPage = New TabPage()
        timBox = New TextBox()
        Label6 = New Label()
        siAns = New Label()
        ratBox = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        priBox = New TextBox()
        Label5 = New Label()
        TabPage5 = New TabPage()
        ferAns = New Label()
        Button3 = New Button()
        ferBox = New TextBox()
        Label7 = New Label()
        TabPage6 = New TabPage()
        third = New TextBox()
        Label1 = New Label()
        greatAns = New Label()
        sec = New TextBox()
        Label9 = New Label()
        Button4 = New Button()
        first = New TextBox()
        Label10 = New Label()
        TabPage4 = New TabPage()
        comOperation = New ComboBox()
        Label8 = New Label()
        ansForCalc = New Label()
        txtSecNum = New TextBox()
        Label12 = New Label()
        calculator = New Button()
        txtOneNum = New TextBox()
        Label13 = New Label()
        TabPage7 = New TabPage()
        btnInsert = New Button()
        txtInpNum = New TextBox()
        ListBox1 = New ListBox()
        TabPage8 = New TabPage()
        btnjigsaw = New Button()
        btnquadraticsolver = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        siPage.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage7.SuspendLayout()
        TabPage8.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(siPage)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage7)
        TabControl1.Controls.Add(TabPage8)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1184, 516)
        TabControl1.TabIndex = 8
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(ans)
        TabPage1.Controls.Add(widBox)
        TabPage1.Controls.Add(widLab)
        TabPage1.Controls.Add(calcBtn)
        TabPage1.Controls.Add(lenBox)
        TabPage1.Controls.Add(lenLab)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1176, 488)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Area of Rectangle"
        ' 
        ' ans
        ' 
        ans.AutoSize = True
        ans.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ans.Location = New Point(243, 225)
        ans.Name = "ans"
        ans.Size = New Size(0, 32)
        ans.TabIndex = 12
        ' 
        ' widBox
        ' 
        widBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        widBox.Location = New Point(353, 145)
        widBox.Name = "widBox"
        widBox.Size = New Size(100, 39)
        widBox.TabIndex = 11
        widBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' widLab
        ' 
        widLab.AutoSize = True
        widLab.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        widLab.Location = New Point(226, 145)
        widLab.Name = "widLab"
        widLab.Size = New Size(83, 32)
        widLab.TabIndex = 10
        widLab.Text = "Width"
        ' 
        ' calcBtn
        ' 
        calcBtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        calcBtn.Location = New Point(316, 290)
        calcBtn.Name = "calcBtn"
        calcBtn.Size = New Size(183, 70)
        calcBtn.TabIndex = 9
        calcBtn.Text = "Calculate"
        calcBtn.UseVisualStyleBackColor = True
        ' 
        ' lenBox
        ' 
        lenBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lenBox.Location = New Point(353, 78)
        lenBox.Name = "lenBox"
        lenBox.Size = New Size(100, 39)
        lenBox.TabIndex = 8
        lenBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' lenLab
        ' 
        lenLab.AutoSize = True
        lenLab.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lenLab.Location = New Point(217, 78)
        lenLab.Name = "lenLab"
        lenLab.Size = New Size(92, 32)
        lenLab.TabIndex = 7
        lenLab.Text = "Length"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(radAns)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(BoxRad)
        TabPage2.Controls.Add(labRad)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(976, 488)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Area of Circle"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' radAns
        ' 
        radAns.AutoSize = True
        radAns.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        radAns.Location = New Point(235, 224)
        radAns.Name = "radAns"
        radAns.Size = New Size(0, 32)
        radAns.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(308, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 70)
        Button1.TabIndex = 16
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BoxRad
        ' 
        BoxRad.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BoxRad.Location = New Point(345, 77)
        BoxRad.Name = "BoxRad"
        BoxRad.Size = New Size(100, 39)
        BoxRad.TabIndex = 15
        BoxRad.TextAlign = HorizontalAlignment.Center
        ' 
        ' labRad
        ' 
        labRad.AutoSize = True
        labRad.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        labRad.Location = New Point(209, 77)
        labRad.Name = "labRad"
        labRad.Size = New Size(91, 32)
        labRad.TabIndex = 14
        labRad.Text = "Radius"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(cylAns)
        TabPage3.Controls.Add(BoxCylHei)
        TabPage3.Controls.Add(Label2)
        TabPage3.Controls.Add(cylCal)
        TabPage3.Controls.Add(BoxCylRad)
        TabPage3.Controls.Add(Label3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(976, 488)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Volume of Cylinder"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' cylAns
        ' 
        cylAns.AutoSize = True
        cylAns.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        cylAns.Location = New Point(235, 224)
        cylAns.Name = "cylAns"
        cylAns.Size = New Size(0, 32)
        cylAns.TabIndex = 19
        ' 
        ' BoxCylHei
        ' 
        BoxCylHei.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BoxCylHei.Location = New Point(345, 144)
        BoxCylHei.Name = "BoxCylHei"
        BoxCylHei.Size = New Size(100, 39)
        BoxCylHei.TabIndex = 18
        BoxCylHei.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(218, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 32)
        Label2.TabIndex = 17
        Label2.Text = "Height"
        ' 
        ' cylCal
        ' 
        cylCal.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        cylCal.Location = New Point(308, 289)
        cylCal.Name = "cylCal"
        cylCal.Size = New Size(183, 70)
        cylCal.TabIndex = 16
        cylCal.Text = "Calculate"
        cylCal.UseVisualStyleBackColor = True
        ' 
        ' BoxCylRad
        ' 
        BoxCylRad.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BoxCylRad.Location = New Point(345, 77)
        BoxCylRad.Name = "BoxCylRad"
        BoxCylRad.Size = New Size(100, 39)
        BoxCylRad.TabIndex = 15
        BoxCylRad.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(209, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 32)
        Label3.TabIndex = 14
        Label3.Text = "Radius"
        ' 
        ' siPage
        ' 
        siPage.Controls.Add(timBox)
        siPage.Controls.Add(Label6)
        siPage.Controls.Add(siAns)
        siPage.Controls.Add(ratBox)
        siPage.Controls.Add(Label4)
        siPage.Controls.Add(Button2)
        siPage.Controls.Add(priBox)
        siPage.Controls.Add(Label5)
        siPage.Location = New Point(4, 24)
        siPage.Name = "siPage"
        siPage.Padding = New Padding(3)
        siPage.Size = New Size(976, 488)
        siPage.TabIndex = 3
        siPage.Text = "Simple Interest"
        siPage.UseVisualStyleBackColor = True
        ' 
        ' timBox
        ' 
        timBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        timBox.Location = New Point(377, 183)
        timBox.Name = "timBox"
        timBox.Size = New Size(100, 39)
        timBox.TabIndex = 27
        timBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(250, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 32)
        Label6.TabIndex = 26
        Label6.Text = "Time"
        ' 
        ' siAns
        ' 
        siAns.AutoSize = True
        siAns.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        siAns.Location = New Point(265, 241)
        siAns.Name = "siAns"
        siAns.Size = New Size(0, 32)
        siAns.TabIndex = 25
        ' 
        ' ratBox
        ' 
        ratBox.BackColor = SystemColors.Window
        ratBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ratBox.Location = New Point(377, 116)
        ratBox.Name = "ratBox"
        ratBox.Size = New Size(100, 39)
        ratBox.TabIndex = 24
        ratBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(250, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 32)
        Label4.TabIndex = 23
        Label4.Text = "Rate"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(327, 313)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 70)
        Button2.TabIndex = 22
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' priBox
        ' 
        priBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        priBox.Location = New Point(377, 49)
        priBox.Name = "priBox"
        priBox.Size = New Size(100, 39)
        priBox.TabIndex = 21
        priBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(241, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 32)
        Label5.TabIndex = 20
        Label5.Text = "Principle"
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(ferAns)
        TabPage5.Controls.Add(Button3)
        TabPage5.Controls.Add(ferBox)
        TabPage5.Controls.Add(Label7)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(976, 488)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Fahrenheit to Celsius"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' ferAns
        ' 
        ferAns.AutoSize = True
        ferAns.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ferAns.Location = New Point(130, 220)
        ferAns.Name = "ferAns"
        ferAns.Size = New Size(0, 32)
        ferAns.TabIndex = 23
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(383, 289)
        Button3.Name = "Button3"
        Button3.Size = New Size(183, 70)
        Button3.TabIndex = 22
        Button3.Text = "Calculate"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ferBox
        ' 
        ferBox.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ferBox.Location = New Point(432, 74)
        ferBox.Name = "ferBox"
        ferBox.Size = New Size(100, 39)
        ferBox.TabIndex = 21
        ferBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(284, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 32)
        Label7.TabIndex = 20
        Label7.Text = "Fahrenheit"
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(third)
        TabPage6.Controls.Add(Label1)
        TabPage6.Controls.Add(greatAns)
        TabPage6.Controls.Add(sec)
        TabPage6.Controls.Add(Label9)
        TabPage6.Controls.Add(Button4)
        TabPage6.Controls.Add(first)
        TabPage6.Controls.Add(Label10)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(976, 488)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Greatest of 3 Number"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' third
        ' 
        third.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        third.Location = New Point(427, 185)
        third.Name = "third"
        third.Size = New Size(133, 39)
        third.TabIndex = 35
        third.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(249, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 32)
        Label1.TabIndex = 34
        Label1.Text = "3rd Number"
        ' 
        ' greatAns
        ' 
        greatAns.AutoSize = True
        greatAns.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        greatAns.Location = New Point(264, 243)
        greatAns.Name = "greatAns"
        greatAns.Size = New Size(0, 32)
        greatAns.TabIndex = 33
        ' 
        ' sec
        ' 
        sec.BackColor = SystemColors.Window
        sec.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        sec.Location = New Point(427, 118)
        sec.Name = "sec"
        sec.Size = New Size(133, 39)
        sec.TabIndex = 32
        sec.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(249, 118)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 32)
        Label9.TabIndex = 31
        Label9.Text = "2nd Number"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(316, 320)
        Button4.Name = "Button4"
        Button4.Size = New Size(183, 70)
        Button4.TabIndex = 30
        Button4.Text = "Calculate"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' first
        ' 
        first.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        first.Location = New Point(427, 51)
        first.Name = "first"
        first.Size = New Size(133, 39)
        first.TabIndex = 29
        first.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(249, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 32)
        Label10.TabIndex = 28
        Label10.Text = "1st Number"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(comOperation)
        TabPage4.Controls.Add(Label8)
        TabPage4.Controls.Add(ansForCalc)
        TabPage4.Controls.Add(txtSecNum)
        TabPage4.Controls.Add(Label12)
        TabPage4.Controls.Add(calculator)
        TabPage4.Controls.Add(txtOneNum)
        TabPage4.Controls.Add(Label13)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(976, 488)
        TabPage4.TabIndex = 6
        TabPage4.Text = "Calculator using Select Case"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' comOperation
        ' 
        comOperation.DropDownStyle = ComboBoxStyle.DropDownList
        comOperation.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        comOperation.FormattingEnabled = True
        comOperation.Items.AddRange(New Object() {"+", "-", "/", "*"})
        comOperation.Location = New Point(469, 209)
        comOperation.Name = "comOperation"
        comOperation.Size = New Size(121, 40)
        comOperation.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(291, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 32)
        Label8.TabIndex = 42
        Label8.Text = "Operation"
        ' 
        ' ansForCalc
        ' 
        ansForCalc.AutoSize = True
        ansForCalc.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ansForCalc.Location = New Point(311, 267)
        ansForCalc.Name = "ansForCalc"
        ansForCalc.Size = New Size(0, 32)
        ansForCalc.TabIndex = 41
        ' 
        ' txtSecNum
        ' 
        txtSecNum.BackColor = SystemColors.Window
        txtSecNum.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtSecNum.Location = New Point(469, 142)
        txtSecNum.Name = "txtSecNum"
        txtSecNum.Size = New Size(133, 39)
        txtSecNum.TabIndex = 40
        txtSecNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(291, 142)
        Label12.Name = "Label12"
        Label12.Size = New Size(159, 32)
        Label12.TabIndex = 39
        Label12.Text = "2nd Number"
        ' 
        ' calculator
        ' 
        calculator.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        calculator.Location = New Point(346, 334)
        calculator.Name = "calculator"
        calculator.Size = New Size(183, 70)
        calculator.TabIndex = 42
        calculator.Text = "Calculate"
        calculator.UseVisualStyleBackColor = True
        ' 
        ' txtOneNum
        ' 
        txtOneNum.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtOneNum.Location = New Point(469, 75)
        txtOneNum.Name = "txtOneNum"
        txtOneNum.Size = New Size(133, 39)
        txtOneNum.TabIndex = 37
        txtOneNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(291, 75)
        Label13.Name = "Label13"
        Label13.Size = New Size(149, 32)
        Label13.TabIndex = 36
        Label13.Text = "1st Number"
        ' 
        ' TabPage7
        ' 
        TabPage7.Controls.Add(btnInsert)
        TabPage7.Controls.Add(txtInpNum)
        TabPage7.Controls.Add(ListBox1)
        TabPage7.Location = New Point(4, 24)
        TabPage7.Name = "TabPage7"
        TabPage7.Padding = New Padding(3)
        TabPage7.Size = New Size(976, 488)
        TabPage7.TabIndex = 7
        TabPage7.Text = "Table"
        TabPage7.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnInsert.Location = New Point(173, 239)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(133, 86)
        btnInsert.TabIndex = 2
        btnInsert.Text = "Generate Table"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' txtInpNum
        ' 
        txtInpNum.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtInpNum.Location = New Point(173, 138)
        txtInpNum.Name = "txtInpNum"
        txtInpNum.Size = New Size(133, 39)
        txtInpNum.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 32
        ListBox1.Location = New Point(443, 40)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(329, 324)
        ListBox1.TabIndex = 0
        ' 
        ' TabPage8
        ' 
        TabPage8.Controls.Add(btnjigsaw)
        TabPage8.Controls.Add(btnquadraticsolver)
        TabPage8.Location = New Point(4, 24)
        TabPage8.Name = "TabPage8"
        TabPage8.Padding = New Padding(3)
        TabPage8.Size = New Size(976, 488)
        TabPage8.TabIndex = 8
        TabPage8.Text = "Other"
        TabPage8.UseVisualStyleBackColor = True
        ' 
        ' btnjigsaw
        ' 
        btnjigsaw.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnjigsaw.Location = New Point(323, 50)
        btnjigsaw.Name = "btnjigsaw"
        btnjigsaw.Size = New Size(215, 115)
        btnjigsaw.TabIndex = 1
        btnjigsaw.Text = "Open Jigsaw Puzzle Game"
        btnjigsaw.UseVisualStyleBackColor = True
        ' 
        ' btnquadraticsolver
        ' 
        btnquadraticsolver.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnquadraticsolver.Location = New Point(51, 50)
        btnquadraticsolver.Name = "btnquadraticsolver"
        btnquadraticsolver.Size = New Size(215, 115)
        btnquadraticsolver.TabIndex = 0
        btnquadraticsolver.Text = "Open Quaratic Equation Solver"
        btnquadraticsolver.UseVisualStyleBackColor = True
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1184, 516)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Programs"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        siPage.ResumeLayout(False)
        siPage.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        TabPage8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ans As Label
    Friend WithEvents widBox As TextBox
    Friend WithEvents widLab As Label
    Friend WithEvents calcBtn As Button
    Friend WithEvents lenBox As TextBox
    Friend WithEvents lenLab As Label
    Friend WithEvents radAns As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BoxRad As TextBox
    Friend WithEvents labRad As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cylAns As Label
    Friend WithEvents BoxCylHei As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cylCal As Button
    Friend WithEvents BoxCylRad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents siPage As TabPage
    Friend WithEvents timBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents siAns As Label
    Friend WithEvents ratBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents priBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ferAns As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ferBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents third As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents greatAns As Label
    Friend WithEvents sec As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents first As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtOpe As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ansForCalc As Label
    Friend WithEvents txtSecNum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents calculator As Button
    Friend WithEvents txtOneNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents comOperation As ComboBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtInpNum As TextBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnquadraticsolver As Button
    Friend WithEvents btnjigsaw As Button
End Class
