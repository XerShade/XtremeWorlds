﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditor_Job
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DarkGroupBox1 = New DarkUI.Controls.DarkGroupBox()
        lstIndex = New ListBox()
        DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        DarkGroupBox7 = New DarkUI.Controls.DarkGroupBox()
        nudStartY = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel15 = New DarkUI.Controls.DarkLabel()
        nudStartX = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel14 = New DarkUI.Controls.DarkLabel()
        nudStartMap = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel13 = New DarkUI.Controls.DarkLabel()
        DarkGroupBox6 = New DarkUI.Controls.DarkGroupBox()
        btnItemAdd = New DarkUI.Controls.DarkButton()
        nudItemAmount = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel12 = New DarkUI.Controls.DarkLabel()
        cmbItems = New DarkUI.Controls.DarkComboBox()
        DarkLabel11 = New DarkUI.Controls.DarkLabel()
        lstStartItems = New ListBox()
        DarkGroupBox5 = New DarkUI.Controls.DarkGroupBox()
        nudBaseExp = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel10 = New DarkUI.Controls.DarkLabel()
        nudSpirit = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel8 = New DarkUI.Controls.DarkLabel()
        DarkLabel9 = New DarkUI.Controls.DarkLabel()
        nudVitality = New DarkUI.Controls.DarkNumericUpDown()
        nudLuck = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel6 = New DarkUI.Controls.DarkLabel()
        DarkLabel7 = New DarkUI.Controls.DarkLabel()
        nudIntelligence = New DarkUI.Controls.DarkNumericUpDown()
        nudStrength = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel5 = New DarkUI.Controls.DarkLabel()
        DarkLabel3 = New DarkUI.Controls.DarkLabel()
        DarkGroupBox4 = New DarkUI.Controls.DarkGroupBox()
        nudFemaleSprite = New DarkUI.Controls.DarkNumericUpDown()
        DarkLabel4 = New DarkUI.Controls.DarkLabel()
        picFemale = New PictureBox()
        DarkGroupBox3 = New DarkUI.Controls.DarkGroupBox()
        nudMaleSprite = New DarkUI.Controls.DarkNumericUpDown()
        lblMaleSprite = New DarkUI.Controls.DarkLabel()
        picMale = New PictureBox()
        txtDescription = New DarkUI.Controls.DarkTextBox()
        DarkLabel2 = New DarkUI.Controls.DarkLabel()
        txtName = New DarkUI.Controls.DarkTextBox()
        DarkLabel1 = New DarkUI.Controls.DarkLabel()
        btnCancel = New DarkUI.Controls.DarkButton()
        btnSave = New DarkUI.Controls.DarkButton()
        btnDelete = New DarkUI.Controls.DarkButton()
        DarkGroupBox1.SuspendLayout()
        DarkGroupBox2.SuspendLayout()
        DarkGroupBox7.SuspendLayout()
        CType(nudStartY, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartX, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartMap, ComponentModel.ISupportInitialize).BeginInit()
        DarkGroupBox6.SuspendLayout()
        CType(nudItemAmount, ComponentModel.ISupportInitialize).BeginInit()
        DarkGroupBox5.SuspendLayout()
        CType(nudBaseExp, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSpirit, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEndurance, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudVitality, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLuck, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIntelligence, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStrength, ComponentModel.ISupportInitialize).BeginInit()
        DarkGroupBox4.SuspendLayout()
        CType(nudFemaleSprite, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFemale, ComponentModel.ISupportInitialize).BeginInit()
        DarkGroupBox3.SuspendLayout()
        CType(nudMaleSprite, ComponentModel.ISupportInitialize).BeginInit()
        CType(picMale, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DarkGroupBox1
        ' 
        DarkGroupBox1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox1.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox1.Controls.Add(lstIndex)
        DarkGroupBox1.ForeColor = Color.Gainsboro
        DarkGroupBox1.Location = New Point(2, 4)
        DarkGroupBox1.Margin = New Padding(7)
        DarkGroupBox1.Name = "DarkGroupBox1"
        DarkGroupBox1.Padding = New Padding(7)
        DarkGroupBox1.Size = New Size(375, 950)
        DarkGroupBox1.TabIndex = 0
        DarkGroupBox1.TabStop = False
        DarkGroupBox1.Text = "Job List"
        ' 
        ' lstIndex
        ' 
        lstIndex.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        lstIndex.BorderStyle = BorderStyle.FixedSingle
        lstIndex.ForeColor = Color.Gainsboro
        lstIndex.FormattingEnabled = True
        lstIndex.Location = New Point(13, 39)
        lstIndex.Margin = New Padding(7)
        lstIndex.Name = "lstIndex"
        lstIndex.Size = New Size(344, 898)
        lstIndex.TabIndex = 0
        ' 
        ' DarkGroupBox2
        ' 
        DarkGroupBox2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox2.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox2.Controls.Add(DarkGroupBox7)
        DarkGroupBox2.Controls.Add(DarkGroupBox6)
        DarkGroupBox2.Controls.Add(DarkGroupBox5)
        DarkGroupBox2.Controls.Add(DarkGroupBox4)
        DarkGroupBox2.Controls.Add(DarkGroupBox3)
        DarkGroupBox2.Controls.Add(txtDescription)
        DarkGroupBox2.Controls.Add(DarkLabel2)
        DarkGroupBox2.Controls.Add(txtName)
        DarkGroupBox2.Controls.Add(DarkLabel1)
        DarkGroupBox2.ForeColor = Color.Gainsboro
        DarkGroupBox2.Location = New Point(392, 4)
        DarkGroupBox2.Margin = New Padding(7)
        DarkGroupBox2.Name = "DarkGroupBox2"
        DarkGroupBox2.Padding = New Padding(7)
        DarkGroupBox2.Size = New Size(739, 1163)
        DarkGroupBox2.TabIndex = 1
        DarkGroupBox2.TabStop = False
        DarkGroupBox2.Text = "Properties"
        ' 
        ' DarkGroupBox7
        ' 
        DarkGroupBox7.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox7.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox7.Controls.Add(nudStartY)
        DarkGroupBox7.Controls.Add(DarkLabel15)
        DarkGroupBox7.Controls.Add(nudStartX)
        DarkGroupBox7.Controls.Add(DarkLabel14)
        DarkGroupBox7.Controls.Add(nudStartMap)
        DarkGroupBox7.Controls.Add(DarkLabel13)
        DarkGroupBox7.ForeColor = Color.Gainsboro
        DarkGroupBox7.Location = New Point(13, 1039)
        DarkGroupBox7.Margin = New Padding(7)
        DarkGroupBox7.Name = "DarkGroupBox7"
        DarkGroupBox7.Padding = New Padding(7)
        DarkGroupBox7.Size = New Size(711, 107)
        DarkGroupBox7.TabIndex = 8
        DarkGroupBox7.TabStop = False
        DarkGroupBox7.Text = "Starting Point"
        ' 
        ' nudStartY
        ' 
        nudStartY.Location = New Point(594, 34)
        nudStartY.Margin = New Padding(7)
        nudStartY.Name = "nudStartY"
        nudStartY.Size = New Size(104, 39)
        nudStartY.TabIndex = 5
        ' 
        ' DarkLabel15
        ' 
        DarkLabel15.AutoSize = True
        DarkLabel15.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel15.Location = New Point(490, 39)
        DarkLabel15.Margin = New Padding(7, 0, 7, 0)
        DarkLabel15.Name = "DarkLabel15"
        DarkLabel15.Size = New Size(74, 32)
        DarkLabel15.TabIndex = 4
        DarkLabel15.Text = "Start :"
        ' 
        ' nudStartX
        ' 
        nudStartX.Location = New Point(364, 34)
        nudStartX.Margin = New Padding(7)
        nudStartX.Name = "nudStartX"
        nudStartX.Size = New Size(104, 39)
        nudStartX.TabIndex = 3
        ' 
        ' DarkLabel14
        ' 
        DarkLabel14.AutoSize = True
        DarkLabel14.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel14.Location = New Point(260, 39)
        DarkLabel14.Margin = New Padding(7, 0, 7, 0)
        DarkLabel14.Name = "DarkLabel14"
        DarkLabel14.Size = New Size(88, 32)
        DarkLabel14.TabIndex = 2
        DarkLabel14.Text = "Start X:"
        ' 
        ' nudStartMap
        ' 
        nudStartMap.Location = New Point(147, 34)
        nudStartMap.Margin = New Padding(7)
        nudStartMap.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudStartMap.Name = "nudStartMap"
        nudStartMap.Size = New Size(100, 39)
        nudStartMap.TabIndex = 1
        nudStartMap.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel13
        ' 
        DarkLabel13.AutoSize = True
        DarkLabel13.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel13.Location = New Point(13, 39)
        DarkLabel13.Margin = New Padding(7, 0, 7, 0)
        DarkLabel13.Name = "DarkLabel13"
        DarkLabel13.Size = New Size(122, 32)
        DarkLabel13.TabIndex = 0
        DarkLabel13.Text = "Start Map:"
        ' 
        ' DarkGroupBox6
        ' 
        DarkGroupBox6.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox6.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox6.Controls.Add(btnItemAdd)
        DarkGroupBox6.Controls.Add(nudItemAmount)
        DarkGroupBox6.Controls.Add(DarkLabel12)
        DarkGroupBox6.Controls.Add(cmbItems)
        DarkGroupBox6.Controls.Add(DarkLabel11)
        DarkGroupBox6.Controls.Add(lstStartItems)
        DarkGroupBox6.ForeColor = Color.Gainsboro
        DarkGroupBox6.Location = New Point(13, 764)
        DarkGroupBox6.Margin = New Padding(7)
        DarkGroupBox6.Name = "DarkGroupBox6"
        DarkGroupBox6.Padding = New Padding(7)
        DarkGroupBox6.Size = New Size(711, 260)
        DarkGroupBox6.TabIndex = 7
        DarkGroupBox6.TabStop = False
        DarkGroupBox6.Text = "Starting Items"
        ' 
        ' btnItemAdd
        ' 
        btnItemAdd.Location = New Point(397, 179)
        btnItemAdd.Margin = New Padding(7)
        btnItemAdd.Name = "btnItemAdd"
        btnItemAdd.Padding = New Padding(11, 13, 11, 13)
        btnItemAdd.Size = New Size(301, 64)
        btnItemAdd.TabIndex = 6
        btnItemAdd.Text = "Update"
        ' 
        ' nudItemAmount
        ' 
        nudItemAmount.Location = New Point(509, 124)
        nudItemAmount.Margin = New Padding(7)
        nudItemAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudItemAmount.Name = "nudItemAmount"
        nudItemAmount.Size = New Size(189, 39)
        nudItemAmount.TabIndex = 5
        nudItemAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel12
        ' 
        DarkLabel12.AutoSize = True
        DarkLabel12.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel12.Location = New Point(397, 128)
        DarkLabel12.Margin = New Padding(7, 0, 7, 0)
        DarkLabel12.Name = "DarkLabel12"
        DarkLabel12.Size = New Size(105, 32)
        DarkLabel12.TabIndex = 4
        DarkLabel12.Text = "Amount:"
        ' 
        ' cmbItems
        ' 
        cmbItems.DrawMode = DrawMode.OwnerDrawFixed
        cmbItems.FormattingEnabled = True
        cmbItems.Location = New Point(397, 57)
        cmbItems.Margin = New Padding(7)
        cmbItems.Name = "cmbItems"
        cmbItems.Size = New Size(297, 40)
        cmbItems.TabIndex = 3
        ' 
        ' DarkLabel11
        ' 
        DarkLabel11.AutoSize = True
        DarkLabel11.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel11.Location = New Point(397, 17)
        DarkLabel11.Margin = New Padding(7, 0, 7, 0)
        DarkLabel11.Name = "DarkLabel11"
        DarkLabel11.Size = New Size(117, 32)
        DarkLabel11.TabIndex = 2
        DarkLabel11.Text = "Start Item"
        ' 
        ' lstStartItems
        ' 
        lstStartItems.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        lstStartItems.BorderStyle = BorderStyle.FixedSingle
        lstStartItems.ForeColor = Color.Gainsboro
        lstStartItems.FormattingEnabled = True
        lstStartItems.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        lstStartItems.Location = New Point(13, 47)
        lstStartItems.Margin = New Padding(7)
        lstStartItems.Name = "lstStartItems"
        lstStartItems.Size = New Size(368, 194)
        lstStartItems.TabIndex = 1
        ' 
        ' DarkGroupBox5
        ' 
        DarkGroupBox5.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox5.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox5.Controls.Add(nudBaseExp)
        DarkGroupBox5.Controls.Add(DarkLabel10)
        DarkGroupBox5.Controls.Add(nudSpirit)
        DarkGroupBox5.Controls.Add(nudEndurance)
        DarkGroupBox5.Controls.Add(DarkLabel8)
        DarkGroupBox5.Controls.Add(DarkLabel9)
        DarkGroupBox5.Controls.Add(nudVitality)
        DarkGroupBox5.Controls.Add(nudLuck)
        DarkGroupBox5.Controls.Add(DarkLabel6)
        DarkGroupBox5.Controls.Add(DarkLabel7)
        DarkGroupBox5.Controls.Add(nudIntelligence)
        DarkGroupBox5.Controls.Add(nudStrength)
        DarkGroupBox5.Controls.Add(DarkLabel5)
        DarkGroupBox5.Controls.Add(DarkLabel3)
        DarkGroupBox5.ForeColor = Color.Gainsboro
        DarkGroupBox5.Location = New Point(13, 501)
        DarkGroupBox5.Margin = New Padding(7)
        DarkGroupBox5.Name = "DarkGroupBox5"
        DarkGroupBox5.Padding = New Padding(7)
        DarkGroupBox5.Size = New Size(711, 245)
        DarkGroupBox5.TabIndex = 6
        DarkGroupBox5.TabStop = False
        DarkGroupBox5.Text = "Start Stats"
        ' 
        ' nudBaseExp
        ' 
        nudBaseExp.Location = New Point(221, 173)
        nudBaseExp.Margin = New Padding(7)
        nudBaseExp.Name = "nudBaseExp"
        nudBaseExp.Size = New Size(223, 39)
        nudBaseExp.TabIndex = 13
        ' 
        ' DarkLabel10
        ' 
        DarkLabel10.AutoSize = True
        DarkLabel10.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel10.Location = New Point(13, 177)
        DarkLabel10.Margin = New Padding(7, 0, 7, 0)
        DarkLabel10.Name = "DarkLabel10"
        DarkLabel10.Size = New Size(190, 32)
        DarkLabel10.TabIndex = 12
        DarkLabel10.Text = "Base Exp:"
        ' 
        ' nudSpirit
        ' 
        nudSpirit.Location = New Point(600, 98)
        nudSpirit.Margin = New Padding(7)
        nudSpirit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudSpirit.Name = "nudSpirit"
        nudSpirit.Size = New Size(97, 39)
        nudSpirit.TabIndex = 11
        nudSpirit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudEndurance
        ' 
        nudEndurance.Location = New Point(600, 34)
        nudEndurance.Margin = New Padding(7)
        nudEndurance.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudEndurance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudEndurance.Name = "nudEndurance"
        nudEndurance.Size = New Size(97, 39)
        nudEndurance.TabIndex = 10
        nudEndurance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel8
        ' 
        DarkLabel8.AutoSize = True
        DarkLabel8.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel8.Location = New Point(457, 103)
        DarkLabel8.Margin = New Padding(7, 0, 7, 0)
        DarkLabel8.Name = "DarkLabel8"
        DarkLabel8.Size = New Size(74, 32)
        DarkLabel8.TabIndex = 9
        DarkLabel8.Text = "Spirit:"
        ' 
        ' DarkLabel9
        ' 
        DarkLabel9.AutoSize = True
        DarkLabel9.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel9.Location = New Point(457, 39)
        DarkLabel9.Margin = New Padding(7, 0, 7, 0)
        DarkLabel9.Name = "DarkLabel9"
        DarkLabel9.Size = New Size(131, 32)
        DarkLabel9.TabIndex = 8
        DarkLabel9.Text = "Endurance:"
        ' 
        ' nudVitality
        ' 
        nudVitality.Location = New Point(347, 98)
        nudVitality.Margin = New Padding(7)
        nudVitality.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudVitality.Name = "nudVitality"
        nudVitality.Size = New Size(97, 39)
        nudVitality.TabIndex = 7
        nudVitality.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudLuck
        ' 
        nudLuck.Location = New Point(347, 34)
        nudLuck.Margin = New Padding(7)
        nudLuck.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudLuck.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudLuck.Name = "nudLuck"
        nudLuck.Size = New Size(97, 39)
        nudLuck.TabIndex = 6
        nudLuck.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel6
        ' 
        DarkLabel6.AutoSize = True
        DarkLabel6.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel6.Location = New Point(260, 103)
        DarkLabel6.Margin = New Padding(7, 0, 7, 0)
        DarkLabel6.Name = "DarkLabel6"
        DarkLabel6.Size = New Size(92, 32)
        DarkLabel6.TabIndex = 5
        DarkLabel6.Text = "Vitality:"
        ' 
        ' DarkLabel7
        ' 
        DarkLabel7.AutoSize = True
        DarkLabel7.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel7.Location = New Point(260, 39)
        DarkLabel7.Margin = New Padding(7, 0, 7, 0)
        DarkLabel7.Name = "DarkLabel7"
        DarkLabel7.Size = New Size(67, 32)
        DarkLabel7.TabIndex = 4
        DarkLabel7.Text = "Luck:"
        ' 
        ' nudIntelligence
        ' 
        nudIntelligence.Location = New Point(149, 98)
        nudIntelligence.Margin = New Padding(7)
        nudIntelligence.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudIntelligence.Name = "nudIntelligence"
        nudIntelligence.Size = New Size(97, 39)
        nudIntelligence.TabIndex = 3
        nudIntelligence.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStrength
        ' 
        nudStrength.Location = New Point(149, 34)
        nudStrength.Margin = New Padding(7)
        nudStrength.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudStrength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudStrength.Name = "nudStrength"
        nudStrength.Size = New Size(97, 39)
        nudStrength.TabIndex = 2
        nudStrength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel5
        ' 
        DarkLabel5.AutoSize = True
        DarkLabel5.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel5.Location = New Point(13, 103)
        DarkLabel5.Margin = New Padding(7, 0, 7, 0)
        DarkLabel5.Name = "DarkLabel5"
        DarkLabel5.Size = New Size(143, 32)
        DarkLabel5.TabIndex = 1
        DarkLabel5.Text = "Intelligence:"
        ' 
        ' DarkLabel3
        ' 
        DarkLabel3.AutoSize = True
        DarkLabel3.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel3.Location = New Point(13, 39)
        DarkLabel3.Margin = New Padding(7, 0, 7, 0)
        DarkLabel3.Name = "DarkLabel3"
        DarkLabel3.Size = New Size(110, 32)
        DarkLabel3.TabIndex = 0
        DarkLabel3.Text = "Strength:"
        ' 
        ' DarkGroupBox4
        ' 
        DarkGroupBox4.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox4.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox4.Controls.Add(nudFemaleSprite)
        DarkGroupBox4.Controls.Add(DarkLabel4)
        DarkGroupBox4.Controls.Add(picFemale)
        DarkGroupBox4.ForeColor = Color.Gainsboro
        DarkGroupBox4.Location = New Point(375, 213)
        DarkGroupBox4.Margin = New Padding(7)
        DarkGroupBox4.Name = "DarkGroupBox4"
        DarkGroupBox4.Padding = New Padding(7)
        DarkGroupBox4.Size = New Size(349, 273)
        DarkGroupBox4.TabIndex = 5
        DarkGroupBox4.TabStop = False
        DarkGroupBox4.Text = "Female Sprite"
        ' 
        ' nudFemaleSprite
        ' 
        nudFemaleSprite.Location = New Point(104, 207)
        nudFemaleSprite.Margin = New Padding(7)
        nudFemaleSprite.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudFemaleSprite.Name = "nudFemaleSprite"
        nudFemaleSprite.Size = New Size(119, 39)
        nudFemaleSprite.TabIndex = 18
        nudFemaleSprite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DarkLabel4
        ' 
        DarkLabel4.AutoSize = True
        DarkLabel4.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel4.Location = New Point(15, 211)
        DarkLabel4.Margin = New Padding(7, 0, 7, 0)
        DarkLabel4.Name = "DarkLabel4"
        DarkLabel4.Size = New Size(81, 32)
        DarkLabel4.TabIndex = 17
        DarkLabel4.Text = "Sprite:"
        ' 
        ' picFemale
        ' 
        picFemale.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        picFemale.BackgroundImageLayout = ImageLayout.None
        picFemale.Location = New Point(232, 25)
        picFemale.Margin = New Padding(7)
        picFemale.Name = "picFemale"
        picFemale.Size = New Size(104, 158)
        picFemale.TabIndex = 14
        picFemale.TabStop = False
        ' 
        ' DarkGroupBox3
        ' 
        DarkGroupBox3.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        DarkGroupBox3.BorderColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DarkGroupBox3.Controls.Add(nudMaleSprite)
        DarkGroupBox3.Controls.Add(lblMaleSprite)
        DarkGroupBox3.Controls.Add(picMale)
        DarkGroupBox3.ForeColor = Color.Gainsboro
        DarkGroupBox3.Location = New Point(13, 213)
        DarkGroupBox3.Margin = New Padding(7)
        DarkGroupBox3.Name = "DarkGroupBox3"
        DarkGroupBox3.Padding = New Padding(7)
        DarkGroupBox3.Size = New Size(349, 273)
        DarkGroupBox3.TabIndex = 4
        DarkGroupBox3.TabStop = False
        DarkGroupBox3.Text = "Male Sprite"
        ' 
        ' nudMaleSprite
        ' 
        nudMaleSprite.Location = New Point(104, 207)
        nudMaleSprite.Margin = New Padding(7)
        nudMaleSprite.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudMaleSprite.Name = "nudMaleSprite"
        nudMaleSprite.Size = New Size(119, 39)
        nudMaleSprite.TabIndex = 12
        nudMaleSprite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblMaleSprite
        ' 
        lblMaleSprite.AutoSize = True
        lblMaleSprite.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblMaleSprite.Location = New Point(15, 211)
        lblMaleSprite.Margin = New Padding(7, 0, 7, 0)
        lblMaleSprite.Name = "lblMaleSprite"
        lblMaleSprite.Size = New Size(81, 32)
        lblMaleSprite.TabIndex = 11
        lblMaleSprite.Text = "Sprite:"
        ' 
        ' picMale
        ' 
        picMale.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        picMale.BackgroundImageLayout = ImageLayout.None
        picMale.Location = New Point(232, 25)
        picMale.Margin = New Padding(7)
        picMale.Name = "picMale"
        picMale.Size = New Size(104, 158)
        picMale.TabIndex = 8
        picMale.TabStop = False
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = Color.FromArgb(CByte(69), CByte(73), CByte(74))
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.Font = New Font("Segoe UI", 8.25F)
        txtDescription.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        txtDescription.Location = New Point(163, 115)
        txtDescription.Margin = New Padding(7)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(559, 81)
        txtDescription.TabIndex = 3
        ' 
        ' DarkLabel2
        ' 
        DarkLabel2.AutoSize = True
        DarkLabel2.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel2.Location = New Point(15, 141)
        DarkLabel2.Margin = New Padding(7, 0, 7, 0)
        DarkLabel2.Name = "DarkLabel2"
        DarkLabel2.Size = New Size(140, 32)
        DarkLabel2.TabIndex = 2
        DarkLabel2.Text = "Description:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(69), CByte(73), CByte(74))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 8.25F)
        txtName.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        txtName.Location = New Point(108, 34)
        txtName.Margin = New Padding(7)
        txtName.Name = "txtName"
        txtName.Size = New Size(613, 37)
        txtName.TabIndex = 1
        ' 
        ' DarkLabel1
        ' 
        DarkLabel1.AutoSize = True
        DarkLabel1.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        DarkLabel1.Location = New Point(13, 39)
        DarkLabel1.Margin = New Padding(7, 0, 7, 0)
        DarkLabel1.Name = "DarkLabel1"
        DarkLabel1.Size = New Size(83, 32)
        DarkLabel1.TabIndex = 0
        DarkLabel1.Text = "Name:"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(16, 1110)
        btnCancel.Margin = New Padding(7)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(11, 13, 11, 13)
        btnCancel.Size = New Size(345, 57)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(16, 968)
        btnSave.Margin = New Padding(7)
        btnSave.Name = "btnSave"
        btnSave.Padding = New Padding(11, 13, 11, 13)
        btnSave.Size = New Size(345, 57)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(16, 1039)
        btnDelete.Margin = New Padding(7)
        btnDelete.Name = "btnDelete"
        btnDelete.Padding = New Padding(11, 13, 11, 13)
        btnDelete.Size = New Size(345, 57)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        ' 
        ' FrmEditor_Job
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        ClientSize = New Size(1143, 1178)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(DarkGroupBox2)
        Controls.Add(DarkGroupBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(7)
        Name = "FrmEditor_Job"
        Text = "Job Editor"
        DarkGroupBox1.ResumeLayout(False)
        DarkGroupBox2.ResumeLayout(False)
        DarkGroupBox2.PerformLayout()
        DarkGroupBox7.ResumeLayout(False)
        DarkGroupBox7.PerformLayout()
        CType(nudStartY, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartX, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartMap, ComponentModel.ISupportInitialize).EndInit()
        DarkGroupBox6.ResumeLayout(False)
        DarkGroupBox6.PerformLayout()
        CType(nudItemAmount, ComponentModel.ISupportInitialize).EndInit()
        DarkGroupBox5.ResumeLayout(False)
        DarkGroupBox5.PerformLayout()
        CType(nudBaseExp, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSpirit, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEndurance, ComponentModel.ISupportInitialize).EndInit()
        CType(nudVitality, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLuck, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIntelligence, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStrength, ComponentModel.ISupportInitialize).EndInit()
        DarkGroupBox4.ResumeLayout(False)
        DarkGroupBox4.PerformLayout()
        CType(nudFemaleSprite, ComponentModel.ISupportInitialize).EndInit()
        CType(picFemale, ComponentModel.ISupportInitialize).EndInit()
        DarkGroupBox3.ResumeLayout(False)
        DarkGroupBox3.PerformLayout()
        CType(nudMaleSprite, ComponentModel.ISupportInitialize).EndInit()
        CType(picMale, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DarkGroupBox1 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtDescription As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents lstIndex As System.Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox4 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkGroupBox3 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents picMale As System.Windows.Forms.PictureBox
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents picFemale As System.Windows.Forms.PictureBox
    Friend WithEvents lblMaleSprite As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnSave As DarkUI.Controls.DarkButton
    Friend WithEvents DarkGroupBox5 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents nudFemaleSprite As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudMaleSprite As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudIntelligence As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudStrength As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudVitality As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudLuck As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudSpirit As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudEndurance As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel8 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel9 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudBaseExp As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel10 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox6 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstStartItems As System.Windows.Forms.ListBox
    Friend WithEvents cmbItems As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel11 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudItemAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel12 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnItemAdd As DarkUI.Controls.DarkButton
    Friend WithEvents DarkGroupBox7 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents nudStartMap As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel13 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudStartY As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel15 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudStartX As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel14 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnDelete As DarkUI.Controls.DarkButton
End Class
