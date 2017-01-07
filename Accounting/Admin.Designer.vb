'
' Created by SharpDevelop.
' User: Force
' Date: 21/01/2016
' Time: 16:45
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Admin
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.button4)
		Me.groupBox1.Controls.Add(Me.button3)
		Me.groupBox1.Controls.Add(Me.button2)
		Me.groupBox1.Controls.Add(Me.textBox2)
		Me.groupBox1.Controls.Add(Me.textBox1)
		Me.groupBox1.Controls.Add(Me.button1)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(12, 28)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(371, 222)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Pengurusan Data"
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(21, 98)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(153, 36)
		Me.button4.TabIndex = 7
		Me.button4.Text = "Masuk Data Baru"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(21, 140)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(153, 36)
		Me.button3.TabIndex = 6
		Me.button3.Text = "Salin Pengkalan Data"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(191, 98)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(153, 36)
		Me.button2.TabIndex = 5
		Me.button2.Text = "Tutup"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(138, 56)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.textBox2.Size = New System.Drawing.Size(196, 20)
		Me.textBox2.TabIndex = 4
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(138, 27)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(196, 20)
		Me.textBox1.TabIndex = 3
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(191, 140)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(153, 36)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Hapus Data Sedia Ada"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(21, 53)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Kata Laluan :"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(21, 30)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(111, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Nama Pengguna :"
		'
		'Admin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(416, 262)
		Me.Controls.Add(Me.groupBox1)
		Me.Name = "Admin"
		Me.Text = "Pengurusan Data"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private button3 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private button2 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
