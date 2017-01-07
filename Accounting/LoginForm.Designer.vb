'
' Created by SharpDevelop.
' User: Force
' Date: 06/01/2017
' Time: 09:47
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class LoginForm
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
		'
		'LoginForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Name = "LoginForm"
		Me.Text = "LoginForm"
	End Sub
End Class
