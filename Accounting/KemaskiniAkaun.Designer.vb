'
' Created by SharpDevelop.
' User: ME
' Date: 19/03/2011
' Time: 10:41:29 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class KemaskiniAkaun
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
	Public Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtAddress1 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.txtFax = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.txtAddress2 = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.txtPostcode = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.cbState = New System.Windows.Forms.ComboBox()
		Me.txtStaffName2 = New System.Windows.Forms.TextBox()
		Me.txtStaffName1 = New System.Windows.Forms.TextBox()
		Me.txtStaffName3 = New System.Windows.Forms.TextBox()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.txtStaffDesignation1 = New System.Windows.Forms.TextBox()
		Me.txtStaffDesignation2 = New System.Windows.Forms.TextBox()
		Me.txtStaffDesignation3 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.txtStaffName4 = New System.Windows.Forms.TextBox()
		Me.txtStaffName5 = New System.Windows.Forms.TextBox()
		Me.txtStaffDesignation4 = New System.Windows.Forms.TextBox()
		Me.txtStaffDesignation5 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.groupBox1.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(58, 34)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Nama :"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(117, 32)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(248, 20)
		Me.txtName.TabIndex = 2
		AddHandler Me.txtName.TextChanged, AddressOf Me.TextBox1TextChanged
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(52, 62)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(117, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Alamat :"
		'
		'txtAddress1
		'
		Me.txtAddress1.Location = New System.Drawing.Point(117, 61)
		Me.txtAddress1.Multiline = true
		Me.txtAddress1.Name = "txtAddress1"
		Me.txtAddress1.Size = New System.Drawing.Size(248, 20)
		Me.txtAddress1.TabIndex = 4
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(71, 228)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(117, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Tel :"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(117, 225)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(142, 20)
		Me.txtPhone.TabIndex = 6
		'
		'txtFax
		'
		Me.txtFax.Location = New System.Drawing.Point(117, 254)
		Me.txtFax.Name = "txtFax"
		Me.txtFax.Size = New System.Drawing.Size(142, 20)
		Me.txtFax.TabIndex = 8
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(70, 257)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(117, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Fax :"
		'
		'btnUpdate
		'
		Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUpdate.Location = New System.Drawing.Point(287, 489)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(92, 23)
		Me.btnUpdate.TabIndex = 9
		Me.btnUpdate.Text = "Kemaskini"
		Me.btnUpdate.UseVisualStyleBackColor = true
		AddHandler Me.btnUpdate.Click, AddressOf Me.Button1Click
		'
		'txtAddress2
		'
		Me.txtAddress2.Location = New System.Drawing.Point(117, 88)
		Me.txtAddress2.Multiline = true
		Me.txtAddress2.Name = "txtAddress2"
		Me.txtAddress2.Size = New System.Drawing.Size(248, 20)
		Me.txtAddress2.TabIndex = 10
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(54, 170)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(56, 23)
		Me.label5.TabIndex = 12
		Me.label5.Text = "Negeri :"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(50, 144)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(117, 23)
		Me.label6.TabIndex = 13
		Me.label6.Text = "Bandar :"
		'
		'txtCity
		'
		Me.txtCity.Location = New System.Drawing.Point(117, 140)
		Me.txtCity.Multiline = true
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(248, 20)
		Me.txtCity.TabIndex = 14
		'
		'txtPostcode
		'
		Me.txtPostcode.Location = New System.Drawing.Point(117, 114)
		Me.txtPostcode.MaxLength = 5
		Me.txtPostcode.Multiline = true
		Me.txtPostcode.Name = "txtPostcode"
		Me.txtPostcode.Size = New System.Drawing.Size(91, 20)
		Me.txtPostcode.TabIndex = 15
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(48, 116)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(117, 23)
		Me.label7.TabIndex = 16
		Me.label7.Text = "Poskod :"
		'
		'cbState
		'
		Me.cbState.FormattingEnabled = true
		Me.cbState.Items.AddRange(New Object() {"Perlis", "Kedah", "Pulau Pinang", "Perak ", "W.P Kuala Lumpur", "W.P Putrajaya", "Selangor", "Pahang", "Terengganu", "Kelantan", "Negeri Sembilan", "Melaka", "Johor", "Sabah ", "Sarawak", "W.P Labuan", ""})
		Me.cbState.Location = New System.Drawing.Point(117, 167)
		Me.cbState.Name = "cbState"
		Me.cbState.Size = New System.Drawing.Size(154, 21)
		Me.cbState.TabIndex = 17
		'
		'txtStaffName2
		'
		Me.txtStaffName2.Location = New System.Drawing.Point(7, 60)
		Me.txtStaffName2.Multiline = true
		Me.txtStaffName2.Name = "txtStaffName2"
		Me.txtStaffName2.Size = New System.Drawing.Size(453, 20)
		Me.txtStaffName2.TabIndex = 21
		'
		'txtStaffName1
		'
		Me.txtStaffName1.Location = New System.Drawing.Point(7, 34)
		Me.txtStaffName1.Name = "txtStaffName1"
		Me.txtStaffName1.Size = New System.Drawing.Size(453, 20)
		Me.txtStaffName1.TabIndex = 19
		'
		'txtStaffName3
		'
		Me.txtStaffName3.Location = New System.Drawing.Point(7, 86)
		Me.txtStaffName3.Multiline = true
		Me.txtStaffName3.Name = "txtStaffName3"
		Me.txtStaffName3.Size = New System.Drawing.Size(453, 20)
		Me.txtStaffName3.TabIndex = 23
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txtPassword)
		Me.groupBox1.Controls.Add(Me.txtUsername)
		Me.groupBox1.Controls.Add(Me.label11)
		Me.groupBox1.Controls.Add(Me.label10)
		Me.groupBox1.Controls.Add(Me.cbState)
		Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
		Me.groupBox1.Location = New System.Drawing.Point(0, 0)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(659, 204)
		Me.groupBox1.TabIndex = 24
		Me.groupBox1.TabStop = false
		'
		'groupBox2
		'
		Me.groupBox2.Location = New System.Drawing.Point(0, 204)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(659, 84)
		Me.groupBox2.TabIndex = 25
		Me.groupBox2.TabStop = false
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.txtStaffDesignation5)
		Me.groupBox3.Controls.Add(Me.txtStaffDesignation4)
		Me.groupBox3.Controls.Add(Me.txtStaffName5)
		Me.groupBox3.Controls.Add(Me.txtStaffName4)
		Me.groupBox3.Controls.Add(Me.txtStaffDesignation1)
		Me.groupBox3.Controls.Add(Me.txtStaffDesignation2)
		Me.groupBox3.Controls.Add(Me.txtStaffDesignation3)
		Me.groupBox3.Controls.Add(Me.txtStaffName1)
		Me.groupBox3.Controls.Add(Me.txtStaffName2)
		Me.groupBox3.Controls.Add(Me.txtStaffName3)
		Me.groupBox3.Controls.Add(Me.label9)
		Me.groupBox3.Controls.Add(Me.label8)
		Me.groupBox3.Location = New System.Drawing.Point(0, 288)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(659, 195)
		Me.groupBox3.TabIndex = 26
		Me.groupBox3.TabStop = false
		'
		'txtStaffDesignation1
		'
		Me.txtStaffDesignation1.Location = New System.Drawing.Point(479, 34)
		Me.txtStaffDesignation1.Name = "txtStaffDesignation1"
		Me.txtStaffDesignation1.Size = New System.Drawing.Size(135, 20)
		Me.txtStaffDesignation1.TabIndex = 24
		'
		'txtStaffDesignation2
		'
		Me.txtStaffDesignation2.Location = New System.Drawing.Point(479, 60)
		Me.txtStaffDesignation2.Multiline = true
		Me.txtStaffDesignation2.Name = "txtStaffDesignation2"
		Me.txtStaffDesignation2.Size = New System.Drawing.Size(135, 20)
		Me.txtStaffDesignation2.TabIndex = 25
		'
		'txtStaffDesignation3
		'
		Me.txtStaffDesignation3.Location = New System.Drawing.Point(479, 86)
		Me.txtStaffDesignation3.Multiline = true
		Me.txtStaffDesignation3.Name = "txtStaffDesignation3"
		Me.txtStaffDesignation3.Size = New System.Drawing.Size(135, 20)
		Me.txtStaffDesignation3.TabIndex = 26
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(94, 16)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(117, 23)
		Me.label9.TabIndex = 18
		Me.label9.Text = "Nama"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(523, 17)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(73, 23)
		Me.label8.TabIndex = 20
		Me.label8.Text = "Jawatan"
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(206, 489)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 28
		Me.button2.Text = "Tutup"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'txtStaffName4
		'
		Me.txtStaffName4.Location = New System.Drawing.Point(6, 112)
		Me.txtStaffName4.Name = "txtStaffName4"
		Me.txtStaffName4.Size = New System.Drawing.Size(454, 20)
		Me.txtStaffName4.TabIndex = 27
		'
		'txtStaffName5
		'
		Me.txtStaffName5.Location = New System.Drawing.Point(7, 141)
		Me.txtStaffName5.Name = "txtStaffName5"
		Me.txtStaffName5.Size = New System.Drawing.Size(453, 20)
		Me.txtStaffName5.TabIndex = 28
		'
		'txtStaffDesignation4
		'
		Me.txtStaffDesignation4.Location = New System.Drawing.Point(479, 112)
		Me.txtStaffDesignation4.Name = "txtStaffDesignation4"
		Me.txtStaffDesignation4.Size = New System.Drawing.Size(135, 20)
		Me.txtStaffDesignation4.TabIndex = 29
		'
		'txtStaffDesignation5
		'
		Me.txtStaffDesignation5.Location = New System.Drawing.Point(479, 141)
		Me.txtStaffDesignation5.Name = "txtStaffDesignation5"
		Me.txtStaffDesignation5.Size = New System.Drawing.Size(135, 20)
		Me.txtStaffDesignation5.TabIndex = 30
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(406, 34)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 18
		Me.label10.Text = "Id Pengguna :"
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(407, 64)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 19
		Me.label11.Text = "Kata Laluan"
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(512, 32)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(135, 20)
		Me.txtUsername.TabIndex = 20
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(512, 64)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(135, 20)
		Me.txtPassword.TabIndex = 21
		'
		'KemaskiniAkaun
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(659, 524)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.txtPostcode)
		Me.Controls.Add(Me.txtCity)
		Me.Controls.Add(Me.txtAddress2)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.txtFax)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.txtAddress1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.groupBox3)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Name = "KemaskiniAkaun"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Kemaskini Akaun"
		AddHandler Load, AddressOf Me.KemaskiniAkaunLoad
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private txtUsername As System.Windows.Forms.TextBox
	Private txtPassword As System.Windows.Forms.TextBox
	Private txtStaffDesignation4 As System.Windows.Forms.TextBox
	Private txtStaffDesignation5 As System.Windows.Forms.TextBox
	Private txtStaffName4 As System.Windows.Forms.TextBox
	Private txtStaffName5 As System.Windows.Forms.TextBox
	Private button2 As System.Windows.Forms.Button
	Public txtStaffDesignation3 As System.Windows.Forms.TextBox
	Public txtStaffDesignation2 As System.Windows.Forms.TextBox
	Public txtStaffDesignation1 As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Public txtStaffName3 As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Public txtStaffName1 As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Public txtStaffName2 As System.Windows.Forms.TextBox
	Public cbState As System.Windows.Forms.ComboBox
	Private label7 As System.Windows.Forms.Label
	Public txtPostcode As System.Windows.Forms.TextBox
	Public txtCity As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Public txtAddress2 As System.Windows.Forms.TextBox
	Public btnUpdate As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Public txtFax As System.Windows.Forms.TextBox
	Public txtPhone As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Public txtAddress1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Public txtName As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
End Class
