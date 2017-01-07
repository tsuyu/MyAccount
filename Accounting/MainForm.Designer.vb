'
' Created by SharpDevelop.
' User: ME
' Date: 02/03/2011
' Time: 11:56:52 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
		Me.PenyataUntungRugi = New System.Windows.Forms.TabPage()
		Me.groupBox9 = New System.Windows.Forms.GroupBox()
		Me.txtBakiMula = New System.Windows.Forms.TextBox()
		Me.textBox15 = New System.Windows.Forms.TextBox()
		Me.textBox14 = New System.Windows.Forms.TextBox()
		Me.textBox13 = New System.Windows.Forms.TextBox()
		Me.textBox12 = New System.Windows.Forms.TextBox()
		Me.comboBox7 = New System.Windows.Forms.ComboBox()
		Me.label31 = New System.Windows.Forms.Label()
		Me.button6 = New System.Windows.Forms.Button()
		Me.groupBox8 = New System.Windows.Forms.GroupBox()
		Me.txtBakiMulaBulan = New System.Windows.Forms.TextBox()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.textBox10 = New System.Windows.Forms.TextBox()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.comboBox5 = New System.Windows.Forms.ComboBox()
		Me.statusStrip4 = New System.Windows.Forms.StatusStrip()
		Me.comboBox6 = New System.Windows.Forms.ComboBox()
		Me.label29 = New System.Windows.Forms.Label()
		Me.label30 = New System.Windows.Forms.Label()
		Me.button5 = New System.Windows.Forms.Button()
		Me.menuStrip4 = New System.Windows.Forms.MenuStrip()
		Me.SemakAkaun = New System.Windows.Forms.TabPage()
		Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.comboBox8 = New System.Windows.Forms.ComboBox()
		Me.label34 = New System.Windows.Forms.Label()
		Me.comboBox10 = New System.Windows.Forms.ComboBox()
		Me.comboBox9 = New System.Windows.Forms.ComboBox()
		Me.button7 = New System.Windows.Forms.Button()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.menuStrip2 = New System.Windows.Forms.MenuStrip()
		Me.WangKeluar = New System.Windows.Forms.TabPage()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.label28 = New System.Windows.Forms.Label()
		Me.groupBox7 = New System.Windows.Forms.GroupBox()
		Me.textBox21 = New System.Windows.Forms.TextBox()
		Me.textBox20 = New System.Windows.Forms.TextBox()
		Me.label33 = New System.Windows.Forms.Label()
		Me.label32 = New System.Windows.Forms.Label()
		Me.toolStrip3 = New System.Windows.Forms.ToolStrip()
		Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.label14 = New System.Windows.Forms.Label()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me.checkBox4 = New System.Windows.Forms.CheckBox()
		Me.checkBox3 = New System.Windows.Forms.CheckBox()
		Me.comboBox4 = New System.Windows.Forms.ComboBox()
		Me.comboBox3 = New System.Windows.Forms.ComboBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.dateTimePicker4 = New System.Windows.Forms.DateTimePicker()
		Me.button3 = New System.Windows.Forms.Button()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.textBox8 = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.WangMasuk = New System.Windows.Forms.TabPage()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label25 = New System.Windows.Forms.Label()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.textBox19 = New System.Windows.Forms.TextBox()
		Me.textBox18 = New System.Windows.Forms.TextBox()
		Me.label27 = New System.Windows.Forms.Label()
		Me.label26 = New System.Windows.Forms.Label()
		Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
		Me.toolStripLabel1 = New System.Windows.Forms.ToolStripButton()
		Me.label15 = New System.Windows.Forms.Label()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.checkBox2 = New System.Windows.Forms.CheckBox()
		Me.checkBox1 = New System.Windows.Forms.CheckBox()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.comboBox2 = New System.Windows.Forms.ComboBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.dateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.button2 = New System.Windows.Forms.Button()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.Detail = New System.Windows.Forms.TabPage()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.textBox27 = New System.Windows.Forms.TextBox()
		Me.textBox26 = New System.Windows.Forms.TextBox()
		Me.textBox17 = New System.Windows.Forms.TextBox()
		Me.textBox16 = New System.Windows.Forms.TextBox()
		Me.label24 = New System.Windows.Forms.Label()
		Me.label23 = New System.Windows.Forms.Label()
		Me.label22 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.label20 = New System.Windows.Forms.Label()
		Me.label72 = New System.Windows.Forms.Label()
		Me.label21 = New System.Windows.Forms.Label()
		Me.menuStrip3 = New System.Windows.Forms.MenuStrip()
		Me.label19 = New System.Windows.Forms.Label()
		Me.label17 = New System.Windows.Forms.Label()
		Me.textBox7 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripSplitButton()
		Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
		Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.Login = New System.Windows.Forms.TabPage()
		Me.groupBox12 = New System.Windows.Forms.GroupBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.textBox30 = New System.Windows.Forms.TextBox()
		Me.textBox29 = New System.Windows.Forms.TextBox()
		Me.label43 = New System.Windows.Forms.Label()
		Me.label42 = New System.Windows.Forms.Label()
		Me.Aset = New System.Windows.Forms.TabPage()
		Me.groupBox11 = New System.Windows.Forms.GroupBox()
		Me.comboBox12 = New System.Windows.Forms.ComboBox()
		Me.comboBox11 = New System.Windows.Forms.ComboBox()
		Me.button11 = New System.Windows.Forms.Button()
		Me.label41 = New System.Windows.Forms.Label()
		Me.label40 = New System.Windows.Forms.Label()
		Me.groupBox10 = New System.Windows.Forms.GroupBox()
		Me.textBox28 = New System.Windows.Forms.TextBox()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.textBox25 = New System.Windows.Forms.TextBox()
		Me.textBox24 = New System.Windows.Forms.TextBox()
		Me.textBox23 = New System.Windows.Forms.TextBox()
		Me.textBox22 = New System.Windows.Forms.TextBox()
		Me.label39 = New System.Windows.Forms.Label()
		Me.label38 = New System.Windows.Forms.Label()
		Me.label37 = New System.Windows.Forms.Label()
		Me.label36 = New System.Windows.Forms.Label()
		Me.label35 = New System.Windows.Forms.Label()
		Me.button10 = New System.Windows.Forms.Button()
		Me.button9 = New System.Windows.Forms.Button()
		Me.button8 = New System.Windows.Forms.Button()
		Me.dataGridView2 = New System.Windows.Forms.DataGridView()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.PenyataUntungRugi.SuspendLayout
		Me.groupBox9.SuspendLayout
		Me.groupBox8.SuspendLayout
		Me.SemakAkaun.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox3.SuspendLayout
		Me.WangKeluar.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox7.SuspendLayout
		Me.toolStrip3.SuspendLayout
		Me.groupBox6.SuspendLayout
		Me.WangMasuk.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.groupBox4.SuspendLayout
		Me.toolStrip2.SuspendLayout
		Me.groupBox5.SuspendLayout
		Me.Detail.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.tabControl1.SuspendLayout
		Me.Login.SuspendLayout
		Me.groupBox12.SuspendLayout
		Me.panel1.SuspendLayout
		Me.Aset.SuspendLayout
		Me.groupBox11.SuspendLayout
		Me.groupBox10.SuspendLayout
		CType(Me.dataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
		Me.menuStrip1.Size = New System.Drawing.Size(623, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'toolStripSplitButton1
		'
		Me.toolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
		Me.toolStripSplitButton1.Size = New System.Drawing.Size(118, 20)
		Me.toolStripSplitButton1.Text = "Kemaskini Akaun"
		'
		'PenyataUntungRugi
		'
		Me.PenyataUntungRugi.Controls.Add(Me.groupBox9)
		Me.PenyataUntungRugi.Controls.Add(Me.groupBox8)
		Me.PenyataUntungRugi.Controls.Add(Me.menuStrip4)
		Me.PenyataUntungRugi.Location = New System.Drawing.Point(4, 25)
		Me.PenyataUntungRugi.Name = "PenyataUntungRugi"
		Me.PenyataUntungRugi.Size = New System.Drawing.Size(615, 398)
		Me.PenyataUntungRugi.TabIndex = 6
		Me.PenyataUntungRugi.Text = "Penyata Pendapatan & Perbelanjaan"
		Me.PenyataUntungRugi.UseVisualStyleBackColor = true
		'
		'groupBox9
		'
		Me.groupBox9.BackColor = System.Drawing.Color.Transparent
		Me.groupBox9.Controls.Add(Me.txtBakiMula)
		Me.groupBox9.Controls.Add(Me.textBox15)
		Me.groupBox9.Controls.Add(Me.textBox14)
		Me.groupBox9.Controls.Add(Me.textBox13)
		Me.groupBox9.Controls.Add(Me.textBox12)
		Me.groupBox9.Controls.Add(Me.comboBox7)
		Me.groupBox9.Controls.Add(Me.label31)
		Me.groupBox9.Controls.Add(Me.button6)
		Me.groupBox9.Dock = System.Windows.Forms.DockStyle.Top
		Me.groupBox9.Location = New System.Drawing.Point(0, 219)
		Me.groupBox9.Name = "groupBox9"
		Me.groupBox9.Size = New System.Drawing.Size(615, 179)
		Me.groupBox9.TabIndex = 21
		Me.groupBox9.TabStop = false
		Me.groupBox9.Text = "Penyata Untung dan Rugi Tahunan"
		'
		'txtBakiMula
		'
		Me.txtBakiMula.Location = New System.Drawing.Point(16, 60)
		Me.txtBakiMula.Name = "txtBakiMula"
		Me.txtBakiMula.Size = New System.Drawing.Size(100, 22)
		Me.txtBakiMula.TabIndex = 32
		Me.txtBakiMula.Visible = false
		AddHandler Me.txtBakiMula.TextChanged, AddressOf Me.TxtBakiMulaTextChanged
		'
		'textBox15
		'
		Me.textBox15.Location = New System.Drawing.Point(366, 120)
		Me.textBox15.Name = "textBox15"
		Me.textBox15.Size = New System.Drawing.Size(100, 22)
		Me.textBox15.TabIndex = 31
		Me.textBox15.Visible = false
		'
		'textBox14
		'
		Me.textBox14.Location = New System.Drawing.Point(366, 90)
		Me.textBox14.Name = "textBox14"
		Me.textBox14.Size = New System.Drawing.Size(100, 22)
		Me.textBox14.TabIndex = 30
		Me.textBox14.Visible = false
		'
		'textBox13
		'
		Me.textBox13.Location = New System.Drawing.Point(215, 120)
		Me.textBox13.Name = "textBox13"
		Me.textBox13.Size = New System.Drawing.Size(100, 22)
		Me.textBox13.TabIndex = 29
		Me.textBox13.Visible = false
		'
		'textBox12
		'
		Me.textBox12.Location = New System.Drawing.Point(215, 90)
		Me.textBox12.Name = "textBox12"
		Me.textBox12.Size = New System.Drawing.Size(100, 22)
		Me.textBox12.TabIndex = 28
		Me.textBox12.Visible = false
		'
		'comboBox7
		'
		Me.comboBox7.FormattingEnabled = true
		Me.comboBox7.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
		Me.comboBox7.Location = New System.Drawing.Point(215, 60)
		Me.comboBox7.Name = "comboBox7"
		Me.comboBox7.Size = New System.Drawing.Size(142, 24)
		Me.comboBox7.TabIndex = 27
		AddHandler Me.comboBox7.SelectedIndexChanged, AddressOf Me.ComboBox7SelectedIndexChanged
		'
		'label31
		'
		Me.label31.Location = New System.Drawing.Point(141, 63)
		Me.label31.Name = "label31"
		Me.label31.Size = New System.Drawing.Size(68, 23)
		Me.label31.TabIndex = 24
		Me.label31.Text = "Tahun :"
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(379, 61)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(87, 23)
		Me.button6.TabIndex = 0
		Me.button6.Text = "Cetak"
		Me.button6.UseVisualStyleBackColor = true
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'groupBox8
		'
		Me.groupBox8.BackColor = System.Drawing.Color.Transparent
		Me.groupBox8.Controls.Add(Me.txtBakiMulaBulan)
		Me.groupBox8.Controls.Add(Me.textBox11)
		Me.groupBox8.Controls.Add(Me.textBox9)
		Me.groupBox8.Controls.Add(Me.textBox10)
		Me.groupBox8.Controls.Add(Me.textBox6)
		Me.groupBox8.Controls.Add(Me.comboBox5)
		Me.groupBox8.Controls.Add(Me.statusStrip4)
		Me.groupBox8.Controls.Add(Me.comboBox6)
		Me.groupBox8.Controls.Add(Me.label29)
		Me.groupBox8.Controls.Add(Me.label30)
		Me.groupBox8.Controls.Add(Me.button5)
		Me.groupBox8.Dock = System.Windows.Forms.DockStyle.Top
		Me.groupBox8.Location = New System.Drawing.Point(0, 24)
		Me.groupBox8.Name = "groupBox8"
		Me.groupBox8.Size = New System.Drawing.Size(615, 195)
		Me.groupBox8.TabIndex = 20
		Me.groupBox8.TabStop = false
		Me.groupBox8.Text = "Penyata Untung dan Rugi Bulanan"
		AddHandler Me.groupBox8.Enter, AddressOf Me.GroupBox8Enter
		'
		'txtBakiMulaBulan
		'
		Me.txtBakiMulaBulan.Location = New System.Drawing.Point(22, 130)
		Me.txtBakiMulaBulan.Name = "txtBakiMulaBulan"
		Me.txtBakiMulaBulan.Size = New System.Drawing.Size(100, 22)
		Me.txtBakiMulaBulan.TabIndex = 32
		Me.txtBakiMulaBulan.Visible = false
		'
		'textBox11
		'
		Me.textBox11.Location = New System.Drawing.Point(531, 79)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(65, 22)
		Me.textBox11.TabIndex = 31
		Me.textBox11.Visible = false
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(531, 53)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(65, 22)
		Me.textBox9.TabIndex = 30
		Me.textBox9.Visible = false
		'
		'textBox10
		'
		Me.textBox10.Location = New System.Drawing.Point(16, 79)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(59, 22)
		Me.textBox10.TabIndex = 29
		Me.textBox10.Visible = false
		'
		'textBox6
		'
		Me.textBox6.Location = New System.Drawing.Point(15, 53)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(60, 22)
		Me.textBox6.TabIndex = 27
		Me.textBox6.Visible = false
		'
		'comboBox5
		'
		Me.comboBox5.FormattingEnabled = true
		Me.comboBox5.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
		Me.comboBox5.Location = New System.Drawing.Point(215, 55)
		Me.comboBox5.Name = "comboBox5"
		Me.comboBox5.Size = New System.Drawing.Size(142, 24)
		Me.comboBox5.TabIndex = 26
		AddHandler Me.comboBox5.SelectedIndexChanged, AddressOf Me.ComboBox5SelectedIndexChanged
		'
		'statusStrip4
		'
		Me.statusStrip4.BackColor = System.Drawing.SystemColors.HotTrack
		Me.statusStrip4.Location = New System.Drawing.Point(3, 170)
		Me.statusStrip4.Name = "statusStrip4"
		Me.statusStrip4.Size = New System.Drawing.Size(609, 22)
		Me.statusStrip4.TabIndex = 23
		Me.statusStrip4.Text = "statusStrip4"
		'
		'comboBox6
		'
		Me.comboBox6.FormattingEnabled = true
		Me.comboBox6.Items.AddRange(New Object() {"Januari", "Februari", "Mac", "April", "Mei", "Jun", "Julai", "Ogos", "September", "Oktober", "November", "Disember"})
		Me.comboBox6.Location = New System.Drawing.Point(215, 88)
		Me.comboBox6.Name = "comboBox6"
		Me.comboBox6.Size = New System.Drawing.Size(142, 24)
		Me.comboBox6.TabIndex = 18
		AddHandler Me.comboBox6.SelectedIndexChanged, AddressOf Me.ComboBox6SelectedIndexChanged
		'
		'label29
		'
		Me.label29.Location = New System.Drawing.Point(148, 91)
		Me.label29.Name = "label29"
		Me.label29.Size = New System.Drawing.Size(99, 23)
		Me.label29.TabIndex = 16
		Me.label29.Text = "Bulan :"
		'
		'label30
		'
		Me.label30.Location = New System.Drawing.Point(145, 58)
		Me.label30.Name = "label30"
		Me.label30.Size = New System.Drawing.Size(106, 23)
		Me.label30.TabIndex = 17
		Me.label30.Text = "Tahun :"
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(379, 56)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(87, 23)
		Me.button5.TabIndex = 0
		Me.button5.Text = "Cetak"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'menuStrip4
		'
		Me.menuStrip4.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip4.Name = "menuStrip4"
		Me.menuStrip4.Size = New System.Drawing.Size(615, 24)
		Me.menuStrip4.TabIndex = 0
		Me.menuStrip4.Text = "menuStrip4"
		'
		'SemakAkaun
		'
		Me.SemakAkaun.Controls.Add(Me.toolStrip1)
		Me.SemakAkaun.Controls.Add(Me.dataGridView1)
		Me.SemakAkaun.Controls.Add(Me.groupBox3)
		Me.SemakAkaun.Controls.Add(Me.menuStrip2)
		Me.SemakAkaun.Location = New System.Drawing.Point(4, 25)
		Me.SemakAkaun.Name = "SemakAkaun"
		Me.SemakAkaun.Size = New System.Drawing.Size(615, 398)
		Me.SemakAkaun.TabIndex = 2
		Me.SemakAkaun.Text = "Semak Akaun"
		Me.SemakAkaun.UseVisualStyleBackColor = true
		'
		'toolStrip1
		'
		Me.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack
		Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.toolStrip1.Location = New System.Drawing.Point(0, 373)
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.Size = New System.Drawing.Size(615, 25)
		Me.toolStrip1.TabIndex = 20
		Me.toolStrip1.Text = "toolStrip1"
		'
		'dataGridView1
		'
		Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridView1.Location = New System.Drawing.Point(0, 139)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(615, 259)
		Me.dataGridView1.TabIndex = 19
		'
		'groupBox3
		'
		Me.groupBox3.BackColor = System.Drawing.Color.Transparent
		Me.groupBox3.Controls.Add(Me.comboBox8)
		Me.groupBox3.Controls.Add(Me.label34)
		Me.groupBox3.Controls.Add(Me.comboBox10)
		Me.groupBox3.Controls.Add(Me.comboBox9)
		Me.groupBox3.Controls.Add(Me.button7)
		Me.groupBox3.Controls.Add(Me.label12)
		Me.groupBox3.Controls.Add(Me.label11)
		Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Top
		Me.groupBox3.Location = New System.Drawing.Point(0, 24)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(615, 115)
		Me.groupBox3.TabIndex = 18
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Pilih Melalui Tarikh"
		'
		'comboBox8
		'
		Me.comboBox8.FormattingEnabled = true
		Me.comboBox8.Items.AddRange(New Object() {"Bank", "Tunai"})
		Me.comboBox8.Location = New System.Drawing.Point(225, 66)
		Me.comboBox8.Name = "comboBox8"
		Me.comboBox8.Size = New System.Drawing.Size(121, 24)
		Me.comboBox8.TabIndex = 22
		AddHandler Me.comboBox8.SelectedIndexChanged, AddressOf Me.ComboBox8SelectedIndexChanged
		'
		'label34
		'
		Me.label34.Location = New System.Drawing.Point(120, 67)
		Me.label34.Name = "label34"
		Me.label34.Size = New System.Drawing.Size(100, 23)
		Me.label34.TabIndex = 21
		Me.label34.Text = "Jenis Penyata :"
		'
		'comboBox10
		'
		Me.comboBox10.FormattingEnabled = true
		Me.comboBox10.Items.AddRange(New Object() {"Januari", "Februari", "Mac", "April", "Mei", "Jun", "Julai", "Ogos", "September", "Oktober", "November", "Disember"})
		Me.comboBox10.Location = New System.Drawing.Point(224, 39)
		Me.comboBox10.Name = "comboBox10"
		Me.comboBox10.Size = New System.Drawing.Size(121, 24)
		Me.comboBox10.TabIndex = 20
		AddHandler Me.comboBox10.SelectedIndexChanged, AddressOf Me.ComboBox10SelectedIndexChanged
		'
		'comboBox9
		'
		Me.comboBox9.FormattingEnabled = true
		Me.comboBox9.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
		Me.comboBox9.Location = New System.Drawing.Point(224, 13)
		Me.comboBox9.Name = "comboBox9"
		Me.comboBox9.Size = New System.Drawing.Size(121, 24)
		Me.comboBox9.TabIndex = 19
		AddHandler Me.comboBox9.SelectedIndexChanged, AddressOf Me.ComboBox9SelectedIndexChanged
		'
		'button7
		'
		Me.button7.Location = New System.Drawing.Point(392, 66)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(75, 23)
		Me.button7.TabIndex = 18
		Me.button7.Text = "Cetak"
		Me.button7.UseVisualStyleBackColor = true
		AddHandler Me.button7.Click, AddressOf Me.Button7Click
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(120, 17)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(61, 23)
		Me.label12.TabIndex = 16
		Me.label12.Text = "Tahun :"
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(120, 41)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(51, 23)
		Me.label11.TabIndex = 17
		Me.label11.Text = "Bulan :"
		'
		'menuStrip2
		'
		Me.menuStrip2.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.menuStrip2.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip2.Name = "menuStrip2"
		Me.menuStrip2.Size = New System.Drawing.Size(615, 24)
		Me.menuStrip2.TabIndex = 0
		Me.menuStrip2.Text = "menuStrip2"
		'
		'WangKeluar
		'
		Me.WangKeluar.Controls.Add(Me.groupBox2)
		Me.WangKeluar.Location = New System.Drawing.Point(4, 25)
		Me.WangKeluar.Name = "WangKeluar"
		Me.WangKeluar.Padding = New System.Windows.Forms.Padding(3)
		Me.WangKeluar.Size = New System.Drawing.Size(615, 398)
		Me.WangKeluar.TabIndex = 1
		Me.WangKeluar.Text = "Wang Keluar"
		Me.WangKeluar.UseVisualStyleBackColor = true
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.button4)
		Me.groupBox2.Controls.Add(Me.label28)
		Me.groupBox2.Controls.Add(Me.groupBox7)
		Me.groupBox2.Controls.Add(Me.toolStrip3)
		Me.groupBox2.Controls.Add(Me.label14)
		Me.groupBox2.Controls.Add(Me.groupBox6)
		Me.groupBox2.Controls.Add(Me.label13)
		Me.groupBox2.Controls.Add(Me.dateTimePicker4)
		Me.groupBox2.Controls.Add(Me.button3)
		Me.groupBox2.Controls.Add(Me.textBox5)
		Me.groupBox2.Controls.Add(Me.label5)
		Me.groupBox2.Controls.Add(Me.textBox8)
		Me.groupBox2.Controls.Add(Me.label7)
		Me.groupBox2.Controls.Add(Me.label8)
		Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.groupBox2.Location = New System.Drawing.Point(3, 3)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(609, 392)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(334, 330)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(75, 23)
		Me.button4.TabIndex = 19
		Me.button4.Text = "Reset"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'label28
		'
		Me.label28.Location = New System.Drawing.Point(131, 180)
		Me.label28.Name = "label28"
		Me.label28.Size = New System.Drawing.Size(47, 23)
		Me.label28.TabIndex = 18
		Me.label28.Text = "Aset :"
		'
		'groupBox7
		'
		Me.groupBox7.Controls.Add(Me.textBox21)
		Me.groupBox7.Controls.Add(Me.textBox20)
		Me.groupBox7.Controls.Add(Me.label33)
		Me.groupBox7.Controls.Add(Me.label32)
		Me.groupBox7.Location = New System.Drawing.Point(184, 170)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(378, 60)
		Me.groupBox7.TabIndex = 17
		Me.groupBox7.TabStop = false
		'
		'textBox21
		'
		Me.textBox21.Enabled = false
		Me.textBox21.Location = New System.Drawing.Point(114, 34)
		Me.textBox21.Name = "textBox21"
		Me.textBox21.Size = New System.Drawing.Size(100, 22)
		Me.textBox21.TabIndex = 3
		'
		'textBox20
		'
		Me.textBox20.Enabled = false
		Me.textBox20.Location = New System.Drawing.Point(113, 10)
		Me.textBox20.Name = "textBox20"
		Me.textBox20.Size = New System.Drawing.Size(244, 22)
		Me.textBox20.TabIndex = 2
		'
		'label33
		'
		Me.label33.Location = New System.Drawing.Point(19, 36)
		Me.label33.Name = "label33"
		Me.label33.Size = New System.Drawing.Size(79, 18)
		Me.label33.TabIndex = 1
		Me.label33.Text = "Kuantiti :"
		'
		'label32
		'
		Me.label32.Location = New System.Drawing.Point(19, 13)
		Me.label32.Name = "label32"
		Me.label32.Size = New System.Drawing.Size(100, 23)
		Me.label32.TabIndex = 0
		Me.label32.Text = "Nama Aset :"
		'
		'toolStrip3
		'
		Me.toolStrip3.BackColor = System.Drawing.SystemColors.HotTrack
		Me.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.toolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1})
		Me.toolStrip3.Location = New System.Drawing.Point(3, 364)
		Me.toolStrip3.Name = "toolStrip3"
		Me.toolStrip3.Size = New System.Drawing.Size(603, 25)
		Me.toolStrip3.TabIndex = 16
		Me.toolStrip3.Text = "toolStrip3"
		'
		'toolStripButton1
		'
		Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.toolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"),System.Drawing.Image)
		Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton1.Name = "toolStripButton1"
		Me.toolStripButton1.Size = New System.Drawing.Size(157, 22)
		Me.toolStripButton1.Text = "Kemaskini Menu Transaksi"
		AddHandler Me.toolStripButton1.Click, AddressOf Me.ToolStripButton1Click
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(184, 27)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(36, 17)
		Me.label14.TabIndex = 15
		Me.label14.Text = "RM"
		'
		'groupBox6
		'
		Me.groupBox6.Controls.Add(Me.checkBox4)
		Me.groupBox6.Controls.Add(Me.checkBox3)
		Me.groupBox6.Controls.Add(Me.comboBox4)
		Me.groupBox6.Controls.Add(Me.comboBox3)
		Me.groupBox6.Location = New System.Drawing.Point(184, 92)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(378, 72)
		Me.groupBox6.TabIndex = 14
		Me.groupBox6.TabStop = false
		'
		'checkBox4
		'
		Me.checkBox4.Location = New System.Drawing.Point(11, 38)
		Me.checkBox4.Name = "checkBox4"
		Me.checkBox4.Size = New System.Drawing.Size(151, 24)
		Me.checkBox4.TabIndex = 6
		Me.checkBox4.Text = "Transaksi Tunai"
		Me.checkBox4.UseVisualStyleBackColor = true
		AddHandler Me.checkBox4.CheckedChanged, AddressOf Me.CheckBox4CheckedChanged
		'
		'checkBox3
		'
		Me.checkBox3.Location = New System.Drawing.Point(11, 15)
		Me.checkBox3.Name = "checkBox3"
		Me.checkBox3.Size = New System.Drawing.Size(136, 24)
		Me.checkBox3.TabIndex = 5
		Me.checkBox3.Text = "Transaksi Bank"
		Me.checkBox3.UseVisualStyleBackColor = true
		AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.CheckBox3CheckedChanged
		'
		'comboBox4
		'
		Me.comboBox4.Enabled = false
		Me.comboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox4.FormattingEnabled = true
		Me.comboBox4.Location = New System.Drawing.Point(164, 42)
		Me.comboBox4.Name = "comboBox4"
		Me.comboBox4.Size = New System.Drawing.Size(204, 24)
		Me.comboBox4.TabIndex = 4
		Me.comboBox4.Text = "Sila pilih yang berkenaan"
		AddHandler Me.comboBox4.SelectedIndexChanged, AddressOf Me.ComboBox4SelectedIndexChanged
		'
		'comboBox3
		'
		Me.comboBox3.Enabled = false
		Me.comboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox3.FormattingEnabled = true
		Me.comboBox3.Location = New System.Drawing.Point(165, 15)
		Me.comboBox3.Name = "comboBox3"
		Me.comboBox3.Size = New System.Drawing.Size(204, 24)
		Me.comboBox3.TabIndex = 2
		Me.comboBox3.Text = "Sila pilih yang berkenaan"
		AddHandler Me.comboBox3.SelectedIndexChanged, AddressOf Me.ComboBox3SelectedIndexChanged
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(109, 104)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(166, 23)
		Me.label13.TabIndex = 13
		Me.label13.Text = "Perkara :"
		'
		'dateTimePicker4
		'
		Me.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker4.Location = New System.Drawing.Point(184, 60)
		Me.dateTimePicker4.Name = "dateTimePicker4"
		Me.dateTimePicker4.Size = New System.Drawing.Size(115, 22)
		Me.dateTimePicker4.TabIndex = 10
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(415, 330)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(87, 23)
		Me.button3.TabIndex = 8
		Me.button3.Text = "Simpan"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(184, 241)
		Me.textBox5.Multiline = true
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(378, 77)
		Me.textBox5.TabIndex = 6
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(109, 241)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(69, 23)
		Me.label5.TabIndex = 7
		Me.label5.Text = "Catatan :"
		'
		'textBox8
		'
		Me.textBox8.Location = New System.Drawing.Point(221, 24)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(143, 22)
		Me.textBox8.TabIndex = 0
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(119, 60)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(165, 23)
		Me.label7.TabIndex = 3
		Me.label7.Text = "Tarikh :"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(18, 27)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(185, 23)
		Me.label8.TabIndex = 1
		Me.label8.Text = "Jumlah Wang Keluar :"
		'
		'WangMasuk
		'
		Me.WangMasuk.Controls.Add(Me.groupBox1)
		Me.WangMasuk.Location = New System.Drawing.Point(4, 25)
		Me.WangMasuk.Name = "WangMasuk"
		Me.WangMasuk.Padding = New System.Windows.Forms.Padding(3)
		Me.WangMasuk.Size = New System.Drawing.Size(615, 398)
		Me.WangMasuk.TabIndex = 0
		Me.WangMasuk.Text = "Wang Masuk"
		Me.WangMasuk.UseVisualStyleBackColor = true
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.button1)
		Me.groupBox1.Controls.Add(Me.label25)
		Me.groupBox1.Controls.Add(Me.groupBox4)
		Me.groupBox1.Controls.Add(Me.toolStrip2)
		Me.groupBox1.Controls.Add(Me.label15)
		Me.groupBox1.Controls.Add(Me.groupBox5)
		Me.groupBox1.Controls.Add(Me.label9)
		Me.groupBox1.Controls.Add(Me.dateTimePicker3)
		Me.groupBox1.Controls.Add(Me.button2)
		Me.groupBox1.Controls.Add(Me.textBox4)
		Me.groupBox1.Controls.Add(Me.label4)
		Me.groupBox1.Controls.Add(Me.textBox1)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.groupBox1.Location = New System.Drawing.Point(3, 3)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(609, 392)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(329, 330)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 20
		Me.button1.Text = "Reset"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label25
		'
		Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label25.Location = New System.Drawing.Point(119, 171)
		Me.label25.Name = "label25"
		Me.label25.Size = New System.Drawing.Size(59, 23)
		Me.label25.TabIndex = 19
		Me.label25.Text = "Aset :"
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.textBox19)
		Me.groupBox4.Controls.Add(Me.textBox18)
		Me.groupBox4.Controls.Add(Me.label27)
		Me.groupBox4.Controls.Add(Me.label26)
		Me.groupBox4.Location = New System.Drawing.Point(184, 165)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(380, 67)
		Me.groupBox4.TabIndex = 18
		Me.groupBox4.TabStop = false
		'
		'textBox19
		'
		Me.textBox19.Enabled = false
		Me.textBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox19.Location = New System.Drawing.Point(103, 39)
		Me.textBox19.Name = "textBox19"
		Me.textBox19.Size = New System.Drawing.Size(87, 22)
		Me.textBox19.TabIndex = 3
		'
		'textBox18
		'
		Me.textBox18.Enabled = false
		Me.textBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox18.Location = New System.Drawing.Point(103, 12)
		Me.textBox18.Name = "textBox18"
		Me.textBox18.Size = New System.Drawing.Size(261, 22)
		Me.textBox18.TabIndex = 2
		'
		'label27
		'
		Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label27.Location = New System.Drawing.Point(6, 41)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(100, 21)
		Me.label27.TabIndex = 1
		Me.label27.Text = "Kuantiti :"
		'
		'label26
		'
		Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label26.Location = New System.Drawing.Point(6, 15)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(100, 23)
		Me.label26.TabIndex = 0
		Me.label26.Text = "Nama Aset :"
		'
		'toolStrip2
		'
		Me.toolStrip2.BackColor = System.Drawing.SystemColors.HotTrack
		Me.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1})
		Me.toolStrip2.Location = New System.Drawing.Point(3, 364)
		Me.toolStrip2.Name = "toolStrip2"
		Me.toolStrip2.Size = New System.Drawing.Size(603, 25)
		Me.toolStrip2.TabIndex = 17
		Me.toolStrip2.Text = "Kemaskini Menu Transaksi"
		'
		'toolStripLabel1
		'
		Me.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.toolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripLabel1.Name = "toolStripLabel1"
		Me.toolStripLabel1.Size = New System.Drawing.Size(176, 22)
		Me.toolStripLabel1.Text = "Kemaskini Menu Transaksi"
		AddHandler Me.toolStripLabel1.Click, AddressOf Me.ToolStripLabel1Click
		'
		'label15
		'
		Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label15.Location = New System.Drawing.Point(184, 27)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(36, 17)
		Me.label15.TabIndex = 16
		Me.label15.Text = "RM"
		'
		'groupBox5
		'
		Me.groupBox5.Controls.Add(Me.checkBox2)
		Me.groupBox5.Controls.Add(Me.checkBox1)
		Me.groupBox5.Controls.Add(Me.comboBox1)
		Me.groupBox5.Controls.Add(Me.comboBox2)
		Me.groupBox5.Location = New System.Drawing.Point(184, 87)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(380, 72)
		Me.groupBox5.TabIndex = 12
		Me.groupBox5.TabStop = false
		'
		'checkBox2
		'
		Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.checkBox2.Location = New System.Drawing.Point(11, 38)
		Me.checkBox2.Name = "checkBox2"
		Me.checkBox2.Size = New System.Drawing.Size(166, 24)
		Me.checkBox2.TabIndex = 6
		Me.checkBox2.Text = "Transaksi Tunai"
		Me.checkBox2.UseVisualStyleBackColor = true
		AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.CheckBox2CheckedChanged
		'
		'checkBox1
		'
		Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.checkBox1.Location = New System.Drawing.Point(11, 11)
		Me.checkBox1.Name = "checkBox1"
		Me.checkBox1.Size = New System.Drawing.Size(139, 24)
		Me.checkBox1.TabIndex = 5
		Me.checkBox1.Text = "Transaksi Bank"
		Me.checkBox1.UseVisualStyleBackColor = true
		AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
		'
		'comboBox1
		'
		Me.comboBox1.Enabled = false
		Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Location = New System.Drawing.Point(183, 11)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(181, 24)
		Me.comboBox1.TabIndex = 4
		Me.comboBox1.Text = "Sila pilih yang berkenaan"
		AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.ComboBox1SelectedIndexChanged
		'
		'comboBox2
		'
		Me.comboBox2.Enabled = false
		Me.comboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox2.FormattingEnabled = true
		Me.comboBox2.Location = New System.Drawing.Point(183, 38)
		Me.comboBox2.Name = "comboBox2"
		Me.comboBox2.Size = New System.Drawing.Size(181, 24)
		Me.comboBox2.TabIndex = 2
		Me.comboBox2.Text = "Sila pilih yang berkenaan"
		AddHandler Me.comboBox2.SelectedIndexChanged, AddressOf Me.ComboBox2SelectedIndexChanged
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(105, 98)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(73, 23)
		Me.label9.TabIndex = 11
		Me.label9.Text = "Perkara :"
		'
		'dateTimePicker3
		'
		Me.dateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker3.Location = New System.Drawing.Point(184, 60)
		Me.dateTimePicker3.Name = "dateTimePicker3"
		Me.dateTimePicker3.Size = New System.Drawing.Size(115, 22)
		Me.dateTimePicker3.TabIndex = 9
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(410, 330)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(87, 23)
		Me.button2.TabIndex = 8
		Me.button2.Text = "Simpan"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'textBox4
		'
		Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox4.Location = New System.Drawing.Point(184, 238)
		Me.textBox4.Multiline = true
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(380, 77)
		Me.textBox4.TabIndex = 6
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(105, 238)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(76, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Catatan :"
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(221, 24)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(143, 22)
		Me.textBox1.TabIndex = 0
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(119, 60)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(165, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Tarikh :"
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(20, 23)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(161, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Jumlah Wang Masuk :"
		'
		'Detail
		'
		Me.Detail.BackgroundImage = CType(resources.GetObject("Detail.BackgroundImage"),System.Drawing.Image)
		Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Detail.Controls.Add(Me.btnLogout)
		Me.Detail.Controls.Add(Me.textBox27)
		Me.Detail.Controls.Add(Me.textBox26)
		Me.Detail.Controls.Add(Me.textBox17)
		Me.Detail.Controls.Add(Me.textBox16)
		Me.Detail.Controls.Add(Me.label24)
		Me.Detail.Controls.Add(Me.label23)
		Me.Detail.Controls.Add(Me.label22)
		Me.Detail.Controls.Add(Me.label16)
		Me.Detail.Controls.Add(Me.textBox3)
		Me.Detail.Controls.Add(Me.textBox2)
		Me.Detail.Controls.Add(Me.label20)
		Me.Detail.Controls.Add(Me.label72)
		Me.Detail.Controls.Add(Me.label21)
		Me.Detail.Controls.Add(Me.menuStrip3)
		Me.Detail.Controls.Add(Me.label19)
		Me.Detail.Controls.Add(Me.label17)
		Me.Detail.Controls.Add(Me.textBox7)
		Me.Detail.Controls.Add(Me.label10)
		Me.Detail.Controls.Add(Me.label3)
		Me.Detail.Controls.Add(Me.label6)
		Me.Detail.Controls.Add(Me.statusStrip1)
		Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Detail.Location = New System.Drawing.Point(4, 25)
		Me.Detail.Name = "Detail"
		Me.Detail.Size = New System.Drawing.Size(615, 398)
		Me.Detail.TabIndex = 3
		Me.Detail.Text = "Profil Intitusi"
		Me.Detail.UseVisualStyleBackColor = true
		AddHandler Me.Detail.Click, AddressOf Me.DetailClick
		'
		'btnLogout
		'
		Me.btnLogout.Location = New System.Drawing.Point(540, 0)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Size = New System.Drawing.Size(75, 23)
		Me.btnLogout.TabIndex = 67
		Me.btnLogout.Text = "Log Out"
		Me.btnLogout.UseVisualStyleBackColor = true
		AddHandler Me.btnLogout.Click, AddressOf Me.BtnLogoutClick
		'
		'textBox27
		'
		Me.textBox27.Location = New System.Drawing.Point(428, 128)
		Me.textBox27.Name = "textBox27"
		Me.textBox27.Size = New System.Drawing.Size(153, 20)
		Me.textBox27.TabIndex = 66
		Me.textBox27.Visible = false
		'
		'textBox26
		'
		Me.textBox26.Location = New System.Drawing.Point(428, 99)
		Me.textBox26.Name = "textBox26"
		Me.textBox26.Size = New System.Drawing.Size(153, 20)
		Me.textBox26.TabIndex = 65
		Me.textBox26.Visible = false
		'
		'textBox17
		'
		Me.textBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox17.Location = New System.Drawing.Point(268, 132)
		Me.textBox17.Name = "textBox17"
		Me.textBox17.Size = New System.Drawing.Size(152, 22)
		Me.textBox17.TabIndex = 63
		'
		'textBox16
		'
		Me.textBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox16.Location = New System.Drawing.Point(268, 107)
		Me.textBox16.Name = "textBox16"
		Me.textBox16.Size = New System.Drawing.Size(152, 22)
		Me.textBox16.TabIndex = 62
		'
		'label24
		'
		Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label24.Location = New System.Drawing.Point(231, 135)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(31, 23)
		Me.label24.TabIndex = 61
		Me.label24.Text = "RM"
		'
		'label23
		'
		Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label23.Location = New System.Drawing.Point(231, 110)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(31, 23)
		Me.label23.TabIndex = 60
		Me.label23.Text = "RM"
		'
		'label22
		'
		Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label22.Location = New System.Drawing.Point(109, 136)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(123, 23)
		Me.label22.TabIndex = 59
		Me.label22.Text = "Jumlah Baki  :"
		'
		'label16
		'
		Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label16.Location = New System.Drawing.Point(109, 109)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(116, 23)
		Me.label16.TabIndex = 58
		Me.label16.Text = "Baki di Bank :"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(426, 73)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(153, 20)
		Me.textBox3.TabIndex = 57
		Me.textBox3.Visible = false
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(426, 47)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(153, 20)
		Me.textBox2.TabIndex = 56
		Me.textBox2.Visible = false
		'
		'label20
		'
		Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label20.Location = New System.Drawing.Point(231, 55)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(103, 23)
		Me.label20.TabIndex = 53
		Me.label20.Text = "label20"
		'
		'label72
		'
		Me.label72.Image = CType(resources.GetObject("label72.Image"),System.Drawing.Image)
		Me.label72.Location = New System.Drawing.Point(552, 327)
		Me.label72.Name = "label72"
		Me.label72.Size = New System.Drawing.Size(61, 52)
		Me.label72.TabIndex = 37
		'
		'label21
		'
		Me.label21.BackColor = System.Drawing.SystemColors.HotTrack
		Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.label21.Location = New System.Drawing.Point(364, 379)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(255, 27)
		Me.label21.TabIndex = 23
		Me.label21.Text = "Copyright @ AJ Infinite (M) Sdn Bhd"
		'
		'menuStrip3
		'
		Me.menuStrip3.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip3.Name = "menuStrip3"
		Me.menuStrip3.Size = New System.Drawing.Size(615, 24)
		Me.menuStrip3.TabIndex = 64
		Me.menuStrip3.Text = "menuStrip3"
		'
		'label19
		'
		Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label19.Location = New System.Drawing.Point(231, 82)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(31, 17)
		Me.label19.TabIndex = 20
		Me.label19.Text = "RM"
		'
		'label17
		'
		Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label17.Location = New System.Drawing.Point(234, 30)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(156, 23)
		Me.label17.TabIndex = 18
		'
		'textBox7
		'
		Me.textBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox7.Location = New System.Drawing.Point(267, 79)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.Size = New System.Drawing.Size(153, 22)
		Me.textBox7.TabIndex = 15
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(109, 82)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(116, 23)
		Me.label10.TabIndex = 16
		Me.label10.Text = "Baki Tunai    :"
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(151, 55)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(167, 23)
		Me.label3.TabIndex = 13
		Me.label3.Text = "Masa   :"
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(65, 30)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(177, 23)
		Me.label6.TabIndex = 12
		Me.label6.Text = "Profil Intitusi Pada   :"
		'
		'statusStrip1
		'
		Me.statusStrip1.BackColor = System.Drawing.SystemColors.HotTrack
		Me.statusStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripSplitButton2, Me.toolStripStatusLabel3})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 375)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(615, 23)
		Me.statusStrip1.TabIndex = 21
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(130, 21)
		Me.toolStripStatusLabel1.Text = "Kemaskini Akaun"
		AddHandler Me.toolStripStatusLabel1.ButtonClick, AddressOf Me.ToolStripStatusLabel1ButtonClick
		'
		'toolStripStatusLabel2
		'
		Me.toolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
		Me.toolStripStatusLabel2.Size = New System.Drawing.Size(106, 18)
		Me.toolStripStatusLabel2.Text = "Baki Permulaan"
		AddHandler Me.toolStripStatusLabel2.Click, AddressOf Me.ToolStripStatusLabel2Click
		'
		'toolStripSplitButton2
		'
		Me.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
		Me.toolStripSplitButton2.Image = CType(resources.GetObject("toolStripSplitButton2.Image"),System.Drawing.Image)
		Me.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripSplitButton2.Name = "toolStripSplitButton2"
		Me.toolStripSplitButton2.Size = New System.Drawing.Size(16, 21)
		Me.toolStripSplitButton2.Text = "toolStripSplitButton2"
		'
		'toolStripStatusLabel3
		'
		Me.toolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
		Me.toolStripStatusLabel3.Size = New System.Drawing.Size(61, 18)
		Me.toolStripStatusLabel3.Text = "Tetapan"
		AddHandler Me.toolStripStatusLabel3.Click, AddressOf Me.ToolStripStatusLabel3Click
		'
		'tabControl1
		'
		Me.tabControl1.Controls.Add(Me.Login)
		Me.tabControl1.Controls.Add(Me.Detail)
		Me.tabControl1.Controls.Add(Me.WangMasuk)
		Me.tabControl1.Controls.Add(Me.WangKeluar)
		Me.tabControl1.Controls.Add(Me.SemakAkaun)
		Me.tabControl1.Controls.Add(Me.PenyataUntungRugi)
		Me.tabControl1.Controls.Add(Me.Aset)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tabControl1.Location = New System.Drawing.Point(0, 24)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(623, 427)
		Me.tabControl1.TabIndex = 1
		'
		'Login
		'
		Me.Login.Controls.Add(Me.groupBox12)
		Me.Login.Location = New System.Drawing.Point(4, 25)
		Me.Login.Name = "Login"
		Me.Login.Size = New System.Drawing.Size(615, 398)
		Me.Login.TabIndex = 8
		Me.Login.Text = "Login"
		Me.Login.UseVisualStyleBackColor = true
		'
		'groupBox12
		'
		Me.groupBox12.Controls.Add(Me.panel1)
		Me.groupBox12.Location = New System.Drawing.Point(60, 62)
		Me.groupBox12.Name = "groupBox12"
		Me.groupBox12.Size = New System.Drawing.Size(492, 286)
		Me.groupBox12.TabIndex = 6
		Me.groupBox12.TabStop = false
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.btnLogin)
		Me.panel1.Controls.Add(Me.textBox30)
		Me.panel1.Controls.Add(Me.textBox29)
		Me.panel1.Controls.Add(Me.label43)
		Me.panel1.Controls.Add(Me.label42)
		Me.panel1.Location = New System.Drawing.Point(43, 43)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(407, 200)
		Me.panel1.TabIndex = 6
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(286, 131)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(75, 23)
		Me.btnLogin.TabIndex = 4
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = true
		AddHandler Me.btnLogin.Click, AddressOf Me.BtnLoginClick
		'
		'textBox30
		'
		Me.textBox30.Location = New System.Drawing.Point(167, 92)
		Me.textBox30.Name = "textBox30"
		Me.textBox30.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.textBox30.Size = New System.Drawing.Size(194, 22)
		Me.textBox30.TabIndex = 3
		'
		'textBox29
		'
		Me.textBox29.Location = New System.Drawing.Point(167, 56)
		Me.textBox29.Name = "textBox29"
		Me.textBox29.Size = New System.Drawing.Size(194, 22)
		Me.textBox29.TabIndex = 2
		'
		'label43
		'
		Me.label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label43.Location = New System.Drawing.Point(48, 93)
		Me.label43.Name = "label43"
		Me.label43.Size = New System.Drawing.Size(100, 23)
		Me.label43.TabIndex = 1
		Me.label43.Text = "Kata Laluan :"
		'
		'label42
		'
		Me.label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label42.Location = New System.Drawing.Point(48, 56)
		Me.label42.Name = "label42"
		Me.label42.Size = New System.Drawing.Size(125, 23)
		Me.label42.TabIndex = 0
		Me.label42.Text = "Id Pengguna :"
		'
		'Aset
		'
		Me.Aset.Controls.Add(Me.groupBox11)
		Me.Aset.Controls.Add(Me.groupBox10)
		Me.Aset.Controls.Add(Me.dataGridView2)
		Me.Aset.Location = New System.Drawing.Point(4, 25)
		Me.Aset.Name = "Aset"
		Me.Aset.Padding = New System.Windows.Forms.Padding(3)
		Me.Aset.Size = New System.Drawing.Size(615, 398)
		Me.Aset.TabIndex = 7
		Me.Aset.Text = "Aset"
		Me.Aset.UseVisualStyleBackColor = true
		'
		'groupBox11
		'
		Me.groupBox11.Controls.Add(Me.comboBox12)
		Me.groupBox11.Controls.Add(Me.comboBox11)
		Me.groupBox11.Controls.Add(Me.button11)
		Me.groupBox11.Controls.Add(Me.label41)
		Me.groupBox11.Controls.Add(Me.label40)
		Me.groupBox11.Location = New System.Drawing.Point(8, 6)
		Me.groupBox11.Name = "groupBox11"
		Me.groupBox11.Size = New System.Drawing.Size(599, 56)
		Me.groupBox11.TabIndex = 18
		Me.groupBox11.TabStop = false
		'
		'comboBox12
		'
		Me.comboBox12.FormattingEnabled = true
		Me.comboBox12.Items.AddRange(New Object() {"Sila Pilih", "Januari", "Februari", "Mac", "April", "Mei", "Jun", "Julai", "Ogos", "September", "Oktober", "November", "Disember"})
		Me.comboBox12.Location = New System.Drawing.Point(311, 19)
		Me.comboBox12.Name = "comboBox12"
		Me.comboBox12.Size = New System.Drawing.Size(121, 24)
		Me.comboBox12.TabIndex = 4
		'
		'comboBox11
		'
		Me.comboBox11.FormattingEnabled = true
		Me.comboBox11.Items.AddRange(New Object() {"Sila Pilih", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
		Me.comboBox11.Location = New System.Drawing.Point(97, 21)
		Me.comboBox11.Name = "comboBox11"
		Me.comboBox11.Size = New System.Drawing.Size(121, 24)
		Me.comboBox11.TabIndex = 3
		'
		'button11
		'
		Me.button11.Location = New System.Drawing.Point(497, 19)
		Me.button11.Name = "button11"
		Me.button11.Size = New System.Drawing.Size(75, 23)
		Me.button11.TabIndex = 2
		Me.button11.Text = "Cetak"
		Me.button11.UseVisualStyleBackColor = true
		AddHandler Me.button11.Click, AddressOf Me.Button11Click
		'
		'label41
		'
		Me.label41.Location = New System.Drawing.Point(247, 22)
		Me.label41.Name = "label41"
		Me.label41.Size = New System.Drawing.Size(58, 23)
		Me.label41.TabIndex = 1
		Me.label41.Text = "Bulan :"
		'
		'label40
		'
		Me.label40.Location = New System.Drawing.Point(7, 24)
		Me.label40.Name = "label40"
		Me.label40.Size = New System.Drawing.Size(68, 23)
		Me.label40.TabIndex = 0
		Me.label40.Text = "Tahun :"
		'
		'groupBox10
		'
		Me.groupBox10.Controls.Add(Me.textBox28)
		Me.groupBox10.Controls.Add(Me.dateTimePicker1)
		Me.groupBox10.Controls.Add(Me.textBox25)
		Me.groupBox10.Controls.Add(Me.textBox24)
		Me.groupBox10.Controls.Add(Me.textBox23)
		Me.groupBox10.Controls.Add(Me.textBox22)
		Me.groupBox10.Controls.Add(Me.label39)
		Me.groupBox10.Controls.Add(Me.label38)
		Me.groupBox10.Controls.Add(Me.label37)
		Me.groupBox10.Controls.Add(Me.label36)
		Me.groupBox10.Controls.Add(Me.label35)
		Me.groupBox10.Controls.Add(Me.button10)
		Me.groupBox10.Controls.Add(Me.button9)
		Me.groupBox10.Controls.Add(Me.button8)
		Me.groupBox10.Location = New System.Drawing.Point(8, 68)
		Me.groupBox10.Name = "groupBox10"
		Me.groupBox10.Size = New System.Drawing.Size(599, 122)
		Me.groupBox10.TabIndex = 17
		Me.groupBox10.TabStop = false
		'
		'textBox28
		'
		Me.textBox28.Location = New System.Drawing.Point(497, 9)
		Me.textBox28.Name = "textBox28"
		Me.textBox28.Size = New System.Drawing.Size(75, 22)
		Me.textBox28.TabIndex = 17
		Me.textBox28.Visible = false
		'
		'dateTimePicker1
		'
		Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker1.Location = New System.Drawing.Point(97, 60)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(100, 22)
		Me.dateTimePicker1.TabIndex = 16
		'
		'textBox25
		'
		Me.textBox25.Location = New System.Drawing.Point(97, 80)
		Me.textBox25.Multiline = true
		Me.textBox25.Name = "textBox25"
		Me.textBox25.Size = New System.Drawing.Size(357, 33)
		Me.textBox25.TabIndex = 15
		'
		'textBox24
		'
		Me.textBox24.Location = New System.Drawing.Point(97, 38)
		Me.textBox24.Name = "textBox24"
		Me.textBox24.Size = New System.Drawing.Size(100, 22)
		Me.textBox24.TabIndex = 14
		'
		'textBox23
		'
		Me.textBox23.Location = New System.Drawing.Point(311, 38)
		Me.textBox23.Name = "textBox23"
		Me.textBox23.Size = New System.Drawing.Size(100, 22)
		Me.textBox23.TabIndex = 13
		'
		'textBox22
		'
		Me.textBox22.Location = New System.Drawing.Point(97, 15)
		Me.textBox22.Name = "textBox22"
		Me.textBox22.Size = New System.Drawing.Size(358, 22)
		Me.textBox22.TabIndex = 12
		'
		'label39
		'
		Me.label39.Location = New System.Drawing.Point(7, 64)
		Me.label39.Name = "label39"
		Me.label39.Size = New System.Drawing.Size(100, 23)
		Me.label39.TabIndex = 11
		Me.label39.Text = "Tarikh Belian :"
		'
		'label38
		'
		Me.label38.Location = New System.Drawing.Point(247, 38)
		Me.label38.Name = "label38"
		Me.label38.Size = New System.Drawing.Size(58, 23)
		Me.label38.TabIndex = 10
		Me.label38.Text = "Status :"
		'
		'label37
		'
		Me.label37.Location = New System.Drawing.Point(7, 41)
		Me.label37.Name = "label37"
		Me.label37.Size = New System.Drawing.Size(68, 23)
		Me.label37.TabIndex = 9
		Me.label37.Text = "Kuantiti :"
		'
		'label36
		'
		Me.label36.Location = New System.Drawing.Point(7, 90)
		Me.label36.Name = "label36"
		Me.label36.Size = New System.Drawing.Size(68, 23)
		Me.label36.TabIndex = 8
		Me.label36.Text = "Nota :"
		'
		'label35
		'
		Me.label35.Location = New System.Drawing.Point(7, 18)
		Me.label35.Name = "label35"
		Me.label35.Size = New System.Drawing.Size(100, 23)
		Me.label35.TabIndex = 7
		Me.label35.Text = "Nama Aset :"
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(497, 90)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(75, 23)
		Me.button10.TabIndex = 6
		Me.button10.Text = "Hapus"
		Me.button10.UseVisualStyleBackColor = true
		AddHandler Me.button10.Click, AddressOf Me.Button10Click
		'
		'button9
		'
		Me.button9.Location = New System.Drawing.Point(497, 61)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(75, 23)
		Me.button9.TabIndex = 5
		Me.button9.Text = "Kemaskini"
		Me.button9.UseVisualStyleBackColor = true
		AddHandler Me.button9.Click, AddressOf Me.Button9Click
		'
		'button8
		'
		Me.button8.Location = New System.Drawing.Point(497, 32)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(75, 23)
		Me.button8.TabIndex = 4
		Me.button8.Text = "Tambah"
		Me.button8.UseVisualStyleBackColor = true
		AddHandler Me.button8.Click, AddressOf Me.Button8Click
		'
		'dataGridView2
		'
		Me.dataGridView2.AllowUserToOrderColumns = true
		Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView2.Location = New System.Drawing.Point(8, 196)
		Me.dataGridView2.Name = "dataGridView2"
		Me.dataGridView2.Size = New System.Drawing.Size(599, 188)
		Me.dataGridView2.TabIndex = 3
		AddHandler Me.dataGridView2.CellClick, AddressOf Me.DataGridView2CellClick
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(623, 451)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MainMenuStrip = Me.menuStrip1
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Perisian Pengurusan Akaun"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.PenyataUntungRugi.ResumeLayout(false)
		Me.PenyataUntungRugi.PerformLayout
		Me.groupBox9.ResumeLayout(false)
		Me.groupBox9.PerformLayout
		Me.groupBox8.ResumeLayout(false)
		Me.groupBox8.PerformLayout
		Me.SemakAkaun.ResumeLayout(false)
		Me.SemakAkaun.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox3.ResumeLayout(false)
		Me.WangKeluar.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox7.ResumeLayout(false)
		Me.groupBox7.PerformLayout
		Me.toolStrip3.ResumeLayout(false)
		Me.toolStrip3.PerformLayout
		Me.groupBox6.ResumeLayout(false)
		Me.WangMasuk.ResumeLayout(false)
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox4.ResumeLayout(false)
		Me.groupBox4.PerformLayout
		Me.toolStrip2.ResumeLayout(false)
		Me.toolStrip2.PerformLayout
		Me.groupBox5.ResumeLayout(false)
		Me.Detail.ResumeLayout(false)
		Me.Detail.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.tabControl1.ResumeLayout(false)
		Me.Login.ResumeLayout(false)
		Me.groupBox12.ResumeLayout(false)
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.Aset.ResumeLayout(false)
		Me.groupBox11.ResumeLayout(false)
		Me.groupBox10.ResumeLayout(false)
		Me.groupBox10.PerformLayout
		CType(Me.dataGridView2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private txtBakiMulaBulan As System.Windows.Forms.TextBox
	Private txtBakiMula As System.Windows.Forms.TextBox
	Private btnLogout As System.Windows.Forms.Button
	Private label42 As System.Windows.Forms.Label
	Private label43 As System.Windows.Forms.Label
	Private textBox29 As System.Windows.Forms.TextBox
	Private textBox30 As System.Windows.Forms.TextBox
	Private btnLogin As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
	Private groupBox12 As System.Windows.Forms.GroupBox
	Private Login As System.Windows.Forms.TabPage
	Private toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
	Private textBox28 As System.Windows.Forms.TextBox
	Private textBox26 As System.Windows.Forms.TextBox
	Private textBox27 As System.Windows.Forms.TextBox
	Private checkBox3 As System.Windows.Forms.CheckBox
	Private checkBox4 As System.Windows.Forms.CheckBox
	Private checkBox1 As System.Windows.Forms.CheckBox
	Private checkBox2 As System.Windows.Forms.CheckBox
	Private toolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
	Private toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
	Private menuStrip3 As System.Windows.Forms.MenuStrip
	Private label35 As System.Windows.Forms.Label
	Private label36 As System.Windows.Forms.Label
	Private label37 As System.Windows.Forms.Label
	Private label38 As System.Windows.Forms.Label
	Private label39 As System.Windows.Forms.Label
	Private textBox22 As System.Windows.Forms.TextBox
	Private textBox23 As System.Windows.Forms.TextBox
	Private textBox24 As System.Windows.Forms.TextBox
	Private textBox25 As System.Windows.Forms.TextBox
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private groupBox10 As System.Windows.Forms.GroupBox
	Private label40 As System.Windows.Forms.Label
	Private label41 As System.Windows.Forms.Label
	Private button11 As System.Windows.Forms.Button
	Private comboBox11 As System.Windows.Forms.ComboBox
	Private comboBox12 As System.Windows.Forms.ComboBox
	Private groupBox11 As System.Windows.Forms.GroupBox
	Private button8 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button10 As System.Windows.Forms.Button
	Private dataGridView2 As System.Windows.Forms.DataGridView
	Private label34 As System.Windows.Forms.Label
	Private comboBox8 As System.Windows.Forms.ComboBox
	Private textBox20 As System.Windows.Forms.TextBox
	Private textBox21 As System.Windows.Forms.TextBox
	Private label33 As System.Windows.Forms.Label
	Private label32 As System.Windows.Forms.Label
	Private label28 As System.Windows.Forms.Label
	Private comboBox4 As System.Windows.Forms.ComboBox
	Private groupBox7 As System.Windows.Forms.GroupBox
	Private textBox18 As System.Windows.Forms.TextBox
	Private textBox19 As System.Windows.Forms.TextBox
	Private label27 As System.Windows.Forms.Label
	Private label26 As System.Windows.Forms.Label
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private label25 As System.Windows.Forms.Label
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private Aset As System.Windows.Forms.TabPage
	Private label16 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private label23 As System.Windows.Forms.Label
	Private label24 As System.Windows.Forms.Label
	Private textBox16 As System.Windows.Forms.TextBox
	Private textBox17 As System.Windows.Forms.TextBox
	Private textBox12 As System.Windows.Forms.TextBox
	Private textBox13 As System.Windows.Forms.TextBox
	Private textBox14 As System.Windows.Forms.TextBox
	Private textBox15 As System.Windows.Forms.TextBox
	Private textBox9 As System.Windows.Forms.TextBox
	Private textBox11 As System.Windows.Forms.TextBox
	Private textBox10 As System.Windows.Forms.TextBox
	Private textBox6 As System.Windows.Forms.TextBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private timer1 As System.Windows.Forms.Timer
	Private label20 As System.Windows.Forms.Label
	Private label72 As System.Windows.Forms.Label
	Private toolStripButton1 As System.Windows.Forms.ToolStripButton
	Private toolStripLabel1 As System.Windows.Forms.ToolStripButton
	Private comboBox9 As System.Windows.Forms.ComboBox
	Private comboBox10 As System.Windows.Forms.ComboBox
	Private button7 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private label31 As System.Windows.Forms.Label
	Private comboBox7 As System.Windows.Forms.ComboBox
	Private groupBox9 As System.Windows.Forms.GroupBox
	Private menuStrip4 As System.Windows.Forms.MenuStrip
	Private button5 As System.Windows.Forms.Button
	Private label30 As System.Windows.Forms.Label
	Private label29 As System.Windows.Forms.Label
	Private comboBox6 As System.Windows.Forms.ComboBox
	Private statusStrip4 As System.Windows.Forms.StatusStrip
	Private comboBox5 As System.Windows.Forms.ComboBox
	Private groupBox8 As System.Windows.Forms.GroupBox
	Private PenyataUntungRugi As System.Windows.Forms.TabPage
	Private toolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
	Private toolStrip3 As System.Windows.Forms.ToolStrip
	Private toolStrip2 As System.Windows.Forms.ToolStrip
	Private label21 As System.Windows.Forms.Label
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripSplitButton
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private label19 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private label17 As System.Windows.Forms.Label
	Private Detail As System.Windows.Forms.TabPage
	Private label13 As System.Windows.Forms.Label
	Public comboBox3 As System.Windows.Forms.ComboBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private label14 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Public comboBox2 As System.Windows.Forms.ComboBox
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private label6 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private textBox7 As System.Windows.Forms.TextBox
	Private dateTimePicker4 As System.Windows.Forms.DateTimePicker
	Private dateTimePicker3 As System.Windows.Forms.DateTimePicker
	Private menuStrip2 As System.Windows.Forms.MenuStrip
	Private SemakAkaun As System.Windows.Forms.TabPage
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private textBox8 As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private textBox5 As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private WangKeluar As System.Windows.Forms.TabPage
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private WangMasuk As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	
End Class
