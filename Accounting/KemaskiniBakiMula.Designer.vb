'
' Created by SharpDevelop.
' User: Force
' Date: 07/09/2015
' Time: 09:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class KemaskiniBakiMula
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(31, 95)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(101, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Tutup"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(31, 60)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(113, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Baki Tunai (RM) :"
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(31, 28)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(113, 23)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Baki Bank (RM) :"
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(150, 95)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(100, 23)
		Me.button2.TabIndex = 3
		Me.button2.Text = "Simpan"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(150, 60)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(100, 20)
		Me.textBox1.TabIndex = 4
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(150, 28)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(100, 20)
		Me.textBox2.TabIndex = 5
		'
		'KemaskiniBakiMula
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(292, 158)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.button1)
		Me.Name = "KemaskiniBakiMula"
		Me.Text = "Kemaskini Baki Permulaan"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private button2 As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
End Class
