<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnExit = New Button()
        lblTitle = New Label()
        lblSubTitle = New Label()
        lblScoreDeclare = New Label()
        lblFinalScore = New Label()
        btnFinish = New Button()
        ' GroupBoxes for each question
        grpQ1 = New GroupBox()
        radBtnQ1True = New RadioButton()
        radBtnQ1False = New RadioButton()
        lblQ1 = New Label()

        grpQ2 = New GroupBox()
        radBtnQ2True = New RadioButton()
        radBtnQ2False = New RadioButton()
        lblQ2 = New Label()

        grpQ3 = New GroupBox()
        radBtnQ3True = New RadioButton()
        radBtnQ3False = New RadioButton()
        lblQ3 = New Label()

        grpQ4 = New GroupBox()
        radBtnQ4True = New RadioButton()
        radBtnQ4False = New RadioButton()
        lblQ4 = New Label()

        grpQ5 = New GroupBox()
        radBtnQ5True = New RadioButton()
        radBtnQ5False = New RadioButton()
        lblQ5 = New Label()

        SuspendLayout()

        ' btnExit
        btnExit.Location = New Point(12, 602)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 20
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        AddHandler btnExit.Click, AddressOf btnExit_Click

        ' lblTitle
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(241, 45)
        lblTitle.TabIndex = 7
        lblTitle.Text = "Werewolf Quiz"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        ' lblSubTitle
        lblSubTitle.AutoSize = True
        lblSubTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSubTitle.Location = New Point(12, 54)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(287, 21)
        lblSubTitle.TabIndex = 8
        lblSubTitle.Text = "because I couldn't think of anything else"
        lblSubTitle.TextAlign = ContentAlignment.MiddleCenter

        ' lblScoreDeclare
        lblScoreDeclare.AutoSize = True
        lblScoreDeclare.Location = New Point(214, 606)
        lblScoreDeclare.Name = "lblScoreDeclare"
        lblScoreDeclare.Size = New Size(39, 15)
        lblScoreDeclare.TabIndex = 10
        lblScoreDeclare.Text = "Score:"

        ' lblFinalScore
        lblFinalScore.AutoSize = True
        lblFinalScore.BorderStyle = BorderStyle.Fixed3D
        lblFinalScore.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblFinalScore.Location = New Point(259, 606)
        lblFinalScore.Name = "lblFinalScore"
        lblFinalScore.Size = New Size(2, 17)
        lblFinalScore.TabIndex = 11

        ' btnFinish
        btnFinish.Location = New Point(93, 602)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(75, 23)
        btnFinish.TabIndex = 19
        btnFinish.Text = "Finish Quiz"
        btnFinish.UseVisualStyleBackColor = True
        AddHandler btnFinish.Click, AddressOf btnFinish_Click

        ' --- Question 1 GroupBox ---
        grpQ1.Location = New Point(12, 90)
        grpQ1.Name = "grpQ1"
        grpQ1.Size = New Size(375, 70)
        grpQ1.TabIndex = 30
        grpQ1.TabStop = False
        ' Add question label inside GroupBox
        lblQ1.Location = New Point(6, 10)
        lblQ1.Size = New Size(363, 30)
        lblQ1.Text = "1. Was 'The Wolf Man' (1941) the basis of the modern archetype?"
        lblQ1.AutoSize = False
        lblQ1.Name = "lblQ1"

        ' RadioButtons inside GroupBox Q1
        radBtnQ1True.Location = New Point(10, 40)
        radBtnQ1True.Name = "radBtnQ1True"
        radBtnQ1True.Size = New Size(48, 19)
        radBtnQ1True.TabIndex = 12
        radBtnQ1True.TabStop = True
        radBtnQ1True.Text = "True"
        radBtnQ1True.UseVisualStyleBackColor = True

        radBtnQ1False.Location = New Point(80, 40)
        radBtnQ1False.Name = "radBtnQ1False"
        radBtnQ1False.Size = New Size(51, 19)
        radBtnQ1False.TabIndex = 13
        radBtnQ1False.TabStop = True
        radBtnQ1False.Text = "False"
        radBtnQ1False.UseVisualStyleBackColor = True

        grpQ1.Controls.Add(lblQ1)
        grpQ1.Controls.Add(radBtnQ1True)
        grpQ1.Controls.Add(radBtnQ1False)

        ' --- Question 2 GroupBox ---
        grpQ2.Location = New Point(12, 170)
        grpQ2.Name = "grpQ2"
        grpQ2.Size = New Size(375, 70)
        grpQ2.TabIndex = 31
        grpQ2.TabStop = False

        lblQ2.Location = New Point(6, 10)
        lblQ2.Size = New Size(363, 30)
        lblQ2.Text = "2. Werewolves can only be killed by silver bullets?"
        lblQ2.AutoSize = False
        lblQ2.Name = "lblQ2"

        radBtnQ2True.Location = New Point(10, 40)
        radBtnQ2True.Name = "radBtnQ2True"
        radBtnQ2True.Size = New Size(48, 19)
        radBtnQ2True.TabIndex = 22
        radBtnQ2True.TabStop = True
        radBtnQ2True.Text = "True"
        radBtnQ2True.UseVisualStyleBackColor = True

        radBtnQ2False.Location = New Point(80, 40)
        radBtnQ2False.Name = "radBtnQ2False"
        radBtnQ2False.Size = New Size(51, 19)
        radBtnQ2False.TabIndex = 23
        radBtnQ2False.TabStop = True
        radBtnQ2False.Text = "False"
        radBtnQ2False.UseVisualStyleBackColor = True

        grpQ2.Controls.Add(lblQ2)
        grpQ2.Controls.Add(radBtnQ2True)
        grpQ2.Controls.Add(radBtnQ2False)

        ' --- Question 3 GroupBox ---
        grpQ3.Location = New Point(12, 250)
        grpQ3.Name = "grpQ3"
        grpQ3.Size = New Size(375, 70)
        grpQ3.TabIndex = 32
        grpQ3.TabStop = False

        lblQ3.Location = New Point(6, 10)
        lblQ3.Size = New Size(363, 30)
        lblQ3.Text = "3. Do werewolves transform only during a full moon?"
        lblQ3.AutoSize = False
        lblQ3.Name = "lblQ3"

        radBtnQ3True.Location = New Point(10, 40)
        radBtnQ3True.Name = "radBtnQ3True"
        radBtnQ3True.Size = New Size(48, 19)
        radBtnQ3True.TabIndex = 25
        radBtnQ3True.TabStop = True
        radBtnQ3True.Text = "True"
        radBtnQ3True.UseVisualStyleBackColor = True

        radBtnQ3False.Location = New Point(80, 40)
        radBtnQ3False.Name = "radBtnQ3False"
        radBtnQ3False.Size = New Size(51, 19)
        radBtnQ3False.TabIndex = 26
        radBtnQ3False.TabStop = True
        radBtnQ3False.Text = "False"
        radBtnQ3False.UseVisualStyleBackColor = True

        grpQ3.Controls.Add(lblQ3)
        grpQ3.Controls.Add(radBtnQ3True)
        grpQ3.Controls.Add(radBtnQ3False)

        ' --- Question 4 GroupBox ---
        grpQ4.Location = New Point(12, 330)
        grpQ4.Name = "grpQ4"
        grpQ4.Size = New Size(375, 70)
        grpQ4.TabIndex = 33
        grpQ4.TabStop = False

        lblQ4.Location = New Point(6, 10)
        lblQ4.Size = New Size(363, 30)
        lblQ4.Text = "4. Werewolves are immune to regular weapons?"
        lblQ4.AutoSize = False
        lblQ4.Name = "lblQ4"

        radBtnQ4True.Location = New Point(10, 40)
        radBtnQ4True.Name = "radBtnQ4True"
        radBtnQ4True.Size = New Size(48, 19)
        radBtnQ4True.TabIndex = 28
        radBtnQ4True.TabStop = True
        radBtnQ4True.Text = "True"
        radBtnQ4True.UseVisualStyleBackColor = True

        radBtnQ4False.Location = New Point(80, 40)
        radBtnQ4False.Name = "radBtnQ4False"
        radBtnQ4False.Size = New Size(51, 19)
        radBtnQ4False.TabIndex = 29
        radBtnQ4False.TabStop = True
        radBtnQ4False.Text = "False"
        radBtnQ4False.UseVisualStyleBackColor = True

        grpQ4.Controls.Add(lblQ4)
        grpQ4.Controls.Add(radBtnQ4True)
        grpQ4.Controls.Add(radBtnQ4False)

        ' --- Question 5 GroupBox ---
        grpQ5.Location = New Point(12, 410)
        grpQ5.Name = "grpQ5"
        grpQ5.Size = New Size(375, 70)
        grpQ5.TabIndex = 34
        grpQ5.TabStop = False

        lblQ5.Location = New Point(6, 10)
        lblQ5.Size = New Size(363, 30)
        lblQ5.Text = "5. Werewolf legends vary across cultures?"
        lblQ5.AutoSize = False
        lblQ5.Name = "lblQ5"

        radBtnQ5True.Location = New Point(10, 40)
        radBtnQ5True.Name = "radBtnQ5True"
        radBtnQ5True.Size = New Size(48, 19)
        radBtnQ5True.TabIndex = 31
        radBtnQ5True.TabStop = True
        radBtnQ5True.Text = "True"
        radBtnQ5True.UseVisualStyleBackColor = True

        radBtnQ5False.Location = New Point(80, 40)
        radBtnQ5False.Name = "radBtnQ5False"
        radBtnQ5False.Size = New Size(51, 19)
        radBtnQ5False.TabIndex = 32
        radBtnQ5False.TabStop = True
        radBtnQ5False.Text = "False"
        radBtnQ5False.UseVisualStyleBackColor = True

        grpQ5.Controls.Add(lblQ5)
        grpQ5.Controls.Add(radBtnQ5True)
        grpQ5.Controls.Add(radBtnQ5False)

        ' Form1
        ClientSize = New Size(400, 650)
        Controls.Add(btnExit)
        Controls.Add(lblTitle)
        Controls.Add(lblSubTitle)
        Controls.Add(lblScoreDeclare)
        Controls.Add(lblFinalScore)
        Controls.Add(btnFinish)
        Controls.Add(grpQ1)
        Controls.Add(grpQ2)
        Controls.Add(grpQ3)
        Controls.Add(grpQ4)
        Controls.Add(grpQ5)
        Name = "Form1"
        Text = "Werewolf Quiz"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblScoreDeclare As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents btnFinish As Button

    Friend WithEvents grpQ1 As GroupBox
    Friend WithEvents lblQ1 As Label
    Friend WithEvents radBtnQ1True As RadioButton
    Friend WithEvents radBtnQ1False As RadioButton

    Friend WithEvents grpQ2 As GroupBox
    Friend WithEvents lblQ2 As Label
    Friend WithEvents radBtnQ2True As RadioButton
    Friend WithEvents radBtnQ2False As RadioButton

    Friend WithEvents grpQ3 As GroupBox
    Friend WithEvents lblQ3 As Label
    Friend WithEvents radBtnQ3True As RadioButton
    Friend WithEvents radBtnQ3False As RadioButton

    Friend WithEvents grpQ4 As GroupBox
    Friend WithEvents lblQ4 As Label
    Friend WithEvents radBtnQ4True As RadioButton
    Friend WithEvents radBtnQ4False As RadioButton

    Friend WithEvents grpQ5 As GroupBox
    Friend WithEvents lblQ5 As Label
    Friend WithEvents radBtnQ5True As RadioButton
    Friend WithEvents radBtnQ5False As RadioButton
End Class
