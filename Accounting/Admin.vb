'
' Created by SharpDevelop.
' User: Force
' Date: 21/01/2016
' Time: 16:45
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Imports MySql

Public Partial Class Admin
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		If textBox1.Text = "" Or textBox2.Text = "" Then
				MsgBox("Sila isi data yang diperlukan!")
		Else If textBox1.Text = "root" Or textBox2.Text = "123456"
			Try
				Dim sqlquery As String = "UPDATE account_owner_detail Set " & _
					"aod_name = 'N/A',aod_address1 = 'N/A' ,aod_address2 = 'N/A',aod_postcode = 'N/A' ,aod_city = 'N/A'," & _
					"aod_state = 'N/A' ,aod_phone = 'N/A',aod_fax = 'N/A' ,aod_staff_name1 = 'N/A',aod_staff_name2 = 'N/A'," & _
					"aod_staff_name3 = 'N/A',aod_staff_designation1 = 'N/A',aod_staff_designation2 = 'N/A',aod_staff_designation3= 'N/A'"
				
				Dim cmd As New MySqlCommand
				conn.Open()
				cmd.Connection = conn
			    cmd.CommandText = sqlquery
			    If cmd.ExecuteNonQuery() = 1 Then
			    End If
			    
			    Dim sqlquery2 As String = "TRUNCATE TABLE asset_main"
			    
			    Dim cmd2 As New MySqlCommand
			    cmd2.Connection = conn
				cmd2.CommandText = sqlquery2
			    If cmd2.ExecuteNonQuery() = 1 Then
			    End If
				
				Dim sqlquery3 As String = "TRUNCATE TABLE account_ledger"
				
				
				Dim cmd3 As New MySqlCommand
				cmd3.Connection = conn
				cmd3.CommandText = sqlquery3
			    If cmd3.ExecuteNonQuery() = 1 Then
			    	MainForm.totalRemain()
			    	MainForm.read_asset_data()
			    End If
			    
			    MsgBox("Berjaya")	
			    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		Else
			MsgBox("Maaf, Sila Semak Nama Pengguna dan Kata Laluan !")
		End If
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Admin.ActiveForm.Close		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'pump data to db
		If textBox1.Text = "" Or textBox2.Text = "" Then
				MsgBox("Sila isi data yang diperlukan!")
		Else If textBox1.Text = "root" Or textBox2.Text = "123456"
			Dim file As String = "C:\\Account\backup.sql"
			Dim cmd As New MySqlCommand()
			Dim mb As New MySqlBackup(cmd)
			conn.Open()
			cmd.Connection = conn
			mb.ImportInfo.TargetDatabase = "accountingdb"
			mb.ImportInfo.DatabaseDefaultCharSet = "utf8"
			mb.ImportFromFile(file)
			MainForm.totalRemain()
			MainForm.read_asset_data()
			conn.Close()
			MsgBox("Berjaya")
		Else
			MsgBox("Maaf, Sila Semak Nama Pengguna dan Kata Laluan !")
		End If
		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Backup data
		If textBox1.Text = "" Or textBox2.Text = "" Then
			MsgBox("Sila isi data yang diperlukan!")
		Else If textBox1.Text = "root" Or textBox2.Text = "123456"
			Dim file As String = "C:\\Account\backup.sql"
			Dim cmd As New MySqlCommand()
			Dim mb As New MySqlBackup(cmd)
			conn.Open()
			cmd.Connection = conn
			mb.ExportInfo.AddCreateDatabase = True
			mb.ExportInfo.ExportTableStructure = True
			mb.ExportInfo.ExportRows = True
			mb.ExportToFile(file)
			conn.Close()
			MsgBox("Berjaya")
		Else
			MsgBox("Maaf, Sila Semak Nama Pengguna dan Kata Laluan !")	
		End If
			
	End Sub
End Class
