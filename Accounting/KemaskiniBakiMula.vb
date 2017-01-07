'
' Created by SharpDevelop.
' User: Force
' Date: 07/09/2015
' Time: 09:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Imports MySql

Public Partial Class KemaskiniBakiMula
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		KemaskiniBakiMula.ActiveForm.Close
		MainForm.show
		conn.Open()
		MainForm.totalRemain()
		conn.Close()
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Try
			If textBox1.Text = "" And textBox2.Text = "" Then
				MsgBox("Sila isi data yang diperlukan!")
			Else
				conn.Open()
				Dim sqlquery As String = "INSERT INTO account_ledger (al_date,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
					" VALUES ( NOW(),'" & textBox1.Text & "','" & textBox1.Text & "','"& "IN" &"','"& "12" &"','"& "CASH" &"')"
			    Dim cmd As New MySqlCommand
				cmd.Connection = conn
				cmd.CommandText = sqlquery
			    cmd.Connection = conn
			    If cmd.ExecuteNonQuery() = 1 Then
			    	'MsgBox("Berjaya")
			    End If
			    
		    	Dim sqlquery2 As String = "INSERT INTO account_ledger (al_date,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
				" VALUES ( NOW(),'" & textBox2.Text & "','" & textBox2.Text & "','"& "IN" & "','"& "12" &"','"& "BANK" &"')"
			    Dim cmd2 As New MySqlCommand
				cmd2.Connection = conn
				cmd2.CommandText = sqlquery2
			    cmd2.Connection = conn
			    If cmd2.ExecuteNonQuery() = 1 Then
			    	MsgBox("Berjaya")
			    End If
			    conn.Close()
			End If
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
End Class
