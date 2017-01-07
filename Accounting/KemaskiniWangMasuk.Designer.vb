'
' Created by SharpDevelop.
' User: ME
' Date: 17/06/2011
' Time: 6:37:28 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class KemaskiniWangMasuk
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
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.button4 = New System.Windows.Forms.Button()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(82, 33)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(187, 20)
		Me.textBox1.TabIndex = 0
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 33)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(64, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Menu 1 :"
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(285, 64)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(92, 23)
		Me.button1.TabIndex = 26
		Me.button1.Text = "Kemaskini"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(285, 33)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(92, 23)
		Me.button2.TabIndex = 27
		Me.button2.Text = "Tambah"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(285, 95)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(92, 23)
		Me.button3.TabIndex = 28
		Me.button3.Text = "Hapus"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(13, 126)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(364, 267)
		Me.dataGridView1.TabIndex = 29
		AddHandler Me.dataGridView1.CellClick, AddressOf Me.DataGridView1CellClick
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(302, 405)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(75, 23)
		Me.button4.TabIndex = 30
		Me.button4.Text = "Tutup"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(53, 83)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(100, 20)
		Me.textBox2.TabIndex = 31
		Me.textBox2.Visible = false
		'
		'KemaskiniWangMasuk
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(400, 440)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Name = "KemaskiniWangMasuk"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Kemaskini Menu Transaksi"
		AddHandler Load, AddressOf Me.KemaskiniWangMasukLoad
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox2 As System.Windows.Forms.TextBox
	Private button4 As System.Windows.Forms.Button
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Public textBox1 As System.Windows.Forms.TextBox
End Class
