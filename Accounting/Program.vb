'
' Created by SharpDevelop.
' User: ME
' Date: 02/03/2011
' Time: 11:56:52 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False ' MySettings are not supported in SharpDevelop.
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub
	End Class
End Namespace
