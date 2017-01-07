'
' Created by SharpDevelop.
' User: ME
' Date: 17/06/2011
' Time: 6:37:28 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports MySql
Imports MySql.Data.MySqlClient

Public Partial Class KemaskiniWangMasuk
	
	Dim myadp As MySqlDataAdapter
	Dim dt As New DataTable
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		If textBox1.Text = "" Then
			MsgBox("Sila pilih data untuk dikemaskini!")
		Else
			Try
				Dim sqlquery As String = "UPDATE transaction_type SET tt_name = '" & textBox1.Text & "'" & _
					" WHERE tt_seq_no = '" & textBox2.Text & "'"
			    Dim cmd As New MySqlCommand
				conn.Open()
			    cmd.CommandText = sqlquery
			    cmd.Connection = conn
			    If cmd.ExecuteNonQuery() = 1 Then
			    	read_data()
			    	MsgBox("Berjaya")
			    End If
			    conn.Close()
			Catch ex As Exception
	            MsgBox(ex.Message)
			End Try
		End If
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		If textBox1.Text = "" Then
			MsgBox("Sila pilih data untuk dihapuskan!")
		Else
			Try
				Dim sqlquery As String = "DELETE FROM transaction_type WHERE tt_seq_no = '" & textBox2.Text & "'"
					
			    Dim cmd As New MySqlCommand
				conn.Open()
			    cmd.CommandText = sqlquery
			    cmd.Connection = conn
			    If cmd.ExecuteNonQuery() = 1 Then
			    	read_data()
			    	MsgBox("Berjaya")
			    End If
			    conn.Close()
			Catch ex As Exception
	            MsgBox(ex.Message)
			End Try
		End If
	End Sub
	
	Private Sub read_data()
        Try
		 	Dim query As String = "SELECT * FROM transaction_type WHERE tt_type = 'IN'"
		    myadp = New MySqlDataAdapter(query, conn)
		    dt.Clear()
            myadp.Fill(dt)
            dataGridView1.DataSource = dt
            'dataGridView1.Columns(0).HeaderCell.Value = "Id" 
            dataGridView1.Columns(1).HeaderCell.Value = "Menu" 
            dataGridView1.Columns(0).Visible = False
            dataGridView1.Columns(2).Visible = False
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
	
	Sub KemaskiniWangMasukLoad(sender As Object, e As EventArgs)
		 conn.Open()
		 read_data()
		 conn.Close()
	End Sub
	
	Sub DataGridView1CellClick(sender As Object, e As DataGridViewCellEventArgs)
		textbox1.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
		textbox2.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		If textBox1.Text = "" Then
			MsgBox("Sila isi data yang diperlukan!")
		Else
			Try
		 	Dim sqlquery As String = "INSERT INTO transaction_type(tt_name,tt_type) VALUES ('" & textBox1.Text & "','"& "IN" & "')"
		    Dim cmd As New MySqlCommand
			conn.Open()
		    cmd.CommandText = sqlquery
		    cmd.Connection = conn
		    If cmd.ExecuteNonQuery() = 1 Then
		    	read_data()
		    	MsgBox("Berjaya")
		    End If
		    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
		End If
		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		KemaskiniWangMasuk.ActiveForm.Close
		conn.Open()
		MainForm.comboBox_masuk()
		conn.Close()
		MainForm.show
	End Sub
End Class
