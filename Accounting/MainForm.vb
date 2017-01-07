'
' Created by SharpDevelop.
' User: ME
' Date: 02/03/2011
' Time: 11:56:52 PM
'
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Windows.Forms.DataGridView
Imports Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word
Imports MySql.Data.MySqlClient
Imports MySql

Public Partial Class MainForm
	
	
	Dim myadp As MySqlDataAdapter
	Dim dt As New DataTable
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Timer1.start ()
		label17.Text = CDate(today)
		'MenuMasuk ComboBox
		conn.Open()
		comboBox_masuk()
		comboBox_keluar()
		totalRemain()
		read_asset_data()
		conn.Close()
		tabControl1.TabPages.Remove(Detail)
		tabControl1.TabPages.Remove(WangMasuk)
		tabControl1.TabPages.Remove(WangKeluar)
		tabControl1.TabPages.Remove(SemakAkaun)
		tabControl1.TabPages.Remove(PenyataUntungRugi)
		tabControl1.TabPages.Remove(Aset)
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		Try
			conn.Open()
			totalRemain()
			
			Dim calculate_remain As Double = 0.00
			Dim sqlquery As String
			
			
			If comboBox3.Enabled = True Then
				calculate_remain =  CDbl(textBox16.Text) - CDbl(textBox8.Text)
				sqlquery = "INSERT INTO account_ledger (al_date,al_note,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
				" VALUES ('" & Format(dateTimePicker4.Value, "yyyy-MM-dd") & "','" & textBox5.Text & "','" & textBox8.Text & "','" & calculate_remain & "','"& "OUT" & "','"& comboBox3.SelectedValue & "','"& "BANK" & "')"
			
			End If
			
			If comboBox4.Enabled = True Then
				calculate_remain =  CDbl(textBox7.Text) - CDbl(textBox8.Text)
				sqlquery = "INSERT INTO account_ledger (al_date,al_note,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
				" VALUES ('" & Format(dateTimePicker4.Value, "yyyy-MM-dd") & "','" & textBox5.Text & "','" & textBox8.Text & "','" & calculate_remain & "','"& "OUT" & "','"& comboBox4.SelectedValue & "','"& "CASH" & "')"
			
			End If
			
			Dim cmd As New MySqlCommand
			Dim last_id As Integer = 0
			cmd.Connection = conn
			cmd.CommandText = sqlquery
		    If cmd.ExecuteNonQuery() = 1 Then
		    	MsgBox("Berjaya")
		    	If comboBox3.Text = "Aset" Or comboBox4.Text = "Aset" Then
			    	cmd.CommandText = "SELECT LAST_INSERT_ID()"
			    	last_id = cmd.ExecuteScalar()
			    	Dim sqlquery2 As String = "INSERT INTO asset_main (am_name,am_quantity,am_date_purchase,am_al_seq_no) " & _
						" VALUES ('" & textBox20.Text & "','" & textBox21.Text & "','" & Format(dateTimePicker4.Value, "yyyy-MM-dd") & "','" & last_id & "')"
				    Dim cmd2 As New MySqlCommand
					cmd2.Connection = conn
					
				    cmd2.CommandText = sqlquery2
				    cmd2.Connection = conn
				    If cmd2.ExecuteNonQuery() = 1 Then
				    	'MsgBox("Berjaya")
				    	read_asset_data()
				    End If
			    End If
		    End If
		    totalRemain()
		    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
			
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		textBox1.Text = ""
		textBox18.Text = ""
		textBox19.Text = ""
		textBox4.Text = ""
		checkBox1.CheckState = CheckState.Unchecked
		checkBox2.CheckState = CheckState.Unchecked
		dateTimePicker3.ResetText
	End Sub
	
	
	Sub SearchClick(sender As Object, e As EventArgs)
 
		
	End Sub
	
	Sub DetailClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Public Sub comboBox_masuk()
		
		Dim comboSource As New Dictionary(Of String, String)()
		Dim query As String = "SELECT * FROM transaction_type WHERE tt_type = 'IN'"
	    Dim data As MySqlDataReader
	    Dim adapter As New MySqlDataAdapter
	    Dim cmd As New MySqlCommand
			
        Try
		 	cmd.Connection = conn
		    cmd.CommandText = query
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
		    comboSource.Add("0", "Sila pilih mana yang berkenaan")
		    While data.Read()
		    	comboSource.Add(data(0).ToString(), data(1).ToString())
		    End While
		    data.Close() 
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		comboBox1.DataSource = New BindingSource(comboSource, Nothing)
        comboBox1.DisplayMember = "Value"
        comboBox1.ValueMember = "Key"
		comboBox2.DataSource = New BindingSource(comboSource, Nothing)
        comboBox2.DisplayMember = "Value"
        comboBox2.ValueMember = "Key"
	End Sub
	
	
	Public Sub comboBox_keluar()
		Dim comboSource As New Dictionary(Of String, String)()
		Dim query As String = "SELECT * FROM transaction_type WHERE tt_type = 'OUT'"
	    Dim data As MySqlDataReader
	    Dim adapter As New MySqlDataAdapter
	    Dim cmd As New MySqlCommand
			
		Try
		 	cmd.Connection = conn
		    cmd.CommandText = query
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
		    comboSource.Add("0", "Sila pilih mana yang berkenaan")
		    While data.Read()
		    	comboSource.Add(data(0).ToString(), data(1).ToString())
		    End While
		    data.Close() 
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		comboBox3.DataSource = New BindingSource(comboSource, Nothing)
        comboBox3.DisplayMember = "Value"
        comboBox3.ValueMember = "Key"
        comboBox4.DataSource = New BindingSource(comboSource, Nothing)
        comboBox4.DisplayMember = "Value"
        comboBox4.ValueMember = "Key"
	End Sub
	
	

	Sub ToolStripButton1Click(sender As Object, e As EventArgs)
		KemaskiniWangKeluar.show
	End Sub
	

	Sub ToolStripStatusLabel1ButtonClick(sender As Object, e As EventArgs)
	 	kemaskiniakaun.show
	End Sub
	
	
	Sub DateTimePicker7ValueChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	
	
	Sub GroupBox8Enter(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub DataGridView4CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		
	End Sub
	
	Sub ComboBox5SelectedIndexChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub ComboBox6SelectedIndexChanged(sender As Object, e As EventArgs)
	
	End Sub
	
	Sub ComboBox7SelectedIndexChanged(sender As Object, e As EventArgs)
			
	End Sub
		
	Sub ComboBox8SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim bulan as string  = "-"
			If combobox10.Text = "Januari" Then
				bulan = "01"
			Else If combobox10.Text = "Februari" Then
				bulan = "02"
			Else If combobox10.Text = "Mac" Then
				bulan = "03"
			Else If combobox10.Text = "April" Then
				bulan = "04"
			Else If combobox10.Text = "Mei" Then
				bulan = "05"
			Else If combobox10.Text = "Jun" Then
				bulan = "06"
			Else If combobox10.Text = "Julai" Then
				bulan = "07"
			Else If combobox10.Text = "Ogos" Then
				bulan = "08"
			Else If combobox10.Text = "September" Then
				bulan = "09"
			Else If combobox10.Text = "Oktober" Then
				bulan = "10"
			Else If combobox10.Text = "November" Then
				bulan = "11"
			Else If combobox10.Text = "Disember" Then
				bulan = "12"
			End If
			
			Try
				conn.Open()
				Dim dt As New DataTable
				Dim typeAccount As String
				If comboBox8.Text = "Tunai" Then
					typeAccount = "CASH"
				ElseIf comboBox8.Text = "Bank" Then
					typeAccount = "BANK"
				End If
				Dim query As String  = "SELECT DATE_FORMAT(al_date,'%d-%m-%Y'),al_note,tt_name,Case al_type When 'OUT' Then FORMAT(al_amount,2) End As 'out', " & _
					"Case al_type When 'IN' Then FORMAT(al_amount,2) End As 'In', FORMAT(al_remain,2) FROM account_ledger INNER JOIN transaction_type ON " & _
					" al_trans_type = tt_seq_no WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "' AND al_account_type = '" & typeAccount & "' ORDER BY al_seq_no ASC "
				myadp = New MySqlDataAdapter(query, conn)
			    dt.Clear()
	            myadp.Fill(dt)
	            dataGridView1.DataSource = dt
	            dataGridView1.Columns(0).HeaderCell.Value = "Tarikh" 
	            dataGridView1.Columns(1).HeaderCell.Value = "Perkara"
	            dataGridView1.Columns(2).HeaderCell.Value = "Catatan"
	            dataGridView1.Columns(3).HeaderCell.Value = "Pengeluaran"
	            dataGridView1.Columns(4).HeaderCell.Value = "Simpanan"
	            dataGridView1.Columns(5).HeaderCell.Value = "Baki"
	            conn.Close()
			Catch ex As Exception
	            MsgBox(ex.Message)
			End Try
				
			
	End Sub
	
	Public Sub bakiMulaBulan(bulan As String)
        Try
        	Dim sqlquery As String = "Select al_remain FROM account_ledger where al_seq_no = (Select min(al_seq_no) FROM account_ledger where YEAR(al_date) = '" & comboBox5.Text & "' AND MONTH(al_date) = '" & bulan & "') " & _
        		" and YEAR(al_date) = '" & comboBox5.Text & "' AND MONTH(al_date) = '" & bulan & "' limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				txtBakiMulaBulan.Text =  CDbl(data(0).ToString).ToString("0.00")
			End While
			data.Close()
			If txtBakiMulaBulan.Text = Nothing Then
			txtBakiMulaBulan.Text = "0.00"
		End If
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
	
	Sub Button5Click(sender As Object, e As EventArgs)
		
	Dim objWord As Word.Application
	Dim objDoc As Word.Document
	Dim objTable As Word.Table
	Dim objPara1 As Word.Paragraph, objPara2 As Word.Paragraph
	  
    objWord = CreateObject("Word.Application")
    objWord.Visible = False
    objDoc = objWord.Documents.Add
    conn.Open()
    
    If textBox6.Text = "" Then
    	textBox6.Text = "0"
    End If
    
    If textBox9.Text = "" Then
    	textBox9.Text = "0"
    End If
    
    If textBox10.Text = "" Then
    	textBox10.Text = "0"
    End If
    
    If textBox11.Text = "" Then
    	textBox11.Text = "0"
    End If
    
    Dim aod_name As String = "-"
        
    Try
    	
	 	Dim sqlquery As String = "SELECT aod_name,aod_address1,aod_address2,aod_postcode,aod_city," & _
	 		"aod_state FROM account_owner_detail LIMIT 1"
	    Dim data As MySqlDataReader
	    Dim adapter As New MySqlDataAdapter
	    Dim cmd As New MySqlCommand
		cmd.Connection = conn
	    cmd.CommandText = sqlquery
	    adapter.SelectCommand = cmd
	    data = cmd.ExecuteReader
		While data.Read()
			aod_name = data(0).ToString()
		End While
		data.Close()
	   ' conn.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
	End Try
	
	objPara2 = objDoc.Content.Paragraphs.Add
    objPara2.Range.Text = aod_name
    objPara2.Range.Font.Bold = False
    objPara2.Range.Font.Size = 14
    objPara2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    'oPara1.Range.Font.Size = 18
    objPara2.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
    objPara2.Range.InsertParagraphAfter()
    
    Dim bulan As String
    
	If combobox6.Text = "Januari" Then
		bulan = "01"
	Else If combobox6.Text = "Februari" Then
		bulan = "02"
	Else If combobox6.Text = "Mac" Then
		bulan = "03"
	Else If combobox6.Text = "April" Then
		bulan = "04"
	Else If combobox6.Text = "Mei" Then
		bulan = "05"
	Else If combobox6.Text = "Jun" Then
		bulan = "06"
	Else If combobox6.Text = "Julai" Then
		bulan = "07"
	Else If combobox6.Text = "Ogos" Then
		bulan = "08"
	Else If combobox6.Text = "September" Then
		bulan = "09"
	Else If combobox6.Text = "Oktober" Then
		bulan = "10"
	Else If combobox6.Text = "November" Then
		bulan = "11"
	Else If combobox6.Text = "Disember" Then
		bulan = "12"
	End If
    
    bakiMulaBulan(bulan)
    
	'Insert a paragraph at the beginning of the document.
    objPara1 = objDoc.Content.Paragraphs.Add
    objPara1.Range.Text = "Penyata Pendapatan dan Perbelanjaan bagi bulan " + combobox6.Text +" "+ combobox5.Text
    objPara1.Range.Font.Bold = True
    objPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    objPara1.Range.Font.Size = 11
    objPara1.Format.SpaceAfter = 30    '24 pt spacing after paragraph.
    objPara1.Range.InsertParagraphAfter()
    
    Dim v As Integer = 0
    Dim ttin As Integer = 0
    
    Try
    	Dim sqlquery3 As String = "SELECT count(tt_seq_no) FROM transaction_type"
	    Dim data3 As MySqlDataReader
	    Dim adapter3 As New MySqlDataAdapter
	    Dim cmd3 As New MySqlCommand
		cmd3.Connection = conn
	    cmd3.CommandText = sqlquery3
	    adapter3.SelectCommand = cmd3
	    data3 = cmd3.ExecuteReader
	    While data3.Read()
			ttin = Convert.ToInt32(data3(0).ToString())
		End While
		data3.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
    End Try
        
    objTable = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, ttin+10, 3)
    objTable.Rows.Height = 8
    objTable.Range.ParagraphFormat.SpaceAfter = 12
    objTable.Range.Font.Size = 11
    objtable.range.font.bold = False
    objtable.Range.Font.underline = False
        
    objTable.Cell(1,2).Range.Text = "RM"
    objTable.Cell(1,2).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
    objTable.Cell(1,3).Range.Text = "RM"
    objTable.Cell(1,3).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	objTable.Columns(1).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
	objTable.Columns(2).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    objTable.Columns(3).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    
    objTable.Cell(3,1).Range.Text = "Baki Pemulaan"
    objTable.Cell(3,1).Range.Font.underline = True
    objTable.Cell(3,1).Range.Font.Bold = True
    
    objTable.Cell(3,3).Range.Text = txtBakiMulaBulan.Text
    objTable.Cell(3,3).Range.Font.Bold = True
    objTable.Cell(2,3).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
    
    objTable.Cell(4,1).Range.Text = "Pendapatan"
    objTable.Cell(4,1).Range.Font.underline = True
    objTable.Cell(4,1).Range.Font.Bold = True

	Try
		Dim count As Integer = 4
		Dim totalIn As Double
    	Dim sqlquery2 As String = "Select tt_seq_no,tt_name,FORMAT(SUM(al_amount),2) FROM transaction_type LEFT JOIN account_ledger " & _
    		"ON tt_seq_no = al_trans_type WHERE tt_type = 'IN'  AND YEAR(al_date) = '" & comboBox5.Text & "' AND MONTH(al_date) = '" & bulan & "' GROUP BY tt_seq_no"
    	
	    Dim data2 As MySqlDataReader
	    Dim adapter2 As New MySqlDataAdapter
	    Dim cmd2 As New MySqlCommand
		cmd2.Connection = conn
	    cmd2.CommandText = sqlquery2
	    adapter2.SelectCommand = cmd2
	    data2 = cmd2.ExecuteReader
	    While data2.Read()
	    	count = count + 1
	    	objTable.Cell(count,1).Range.Text = data2(1).ToString()
	    	If data2(2).ToString()  = "" Then
	    		objTable.Cell(count,2).Range.Text = "0"
	    	Else
	    		objTable.Cell(count,2).Range.Text = data2(2).ToString()
	    		totalIn = totalIn+CDbl(data2(2).ToString())
	    	End If
	    	textBox6.Text = count.ToString
	    End While
	    textBox10.Text = totalIn.ToString
		data2.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
	End Try
	
    
    objTable.Cell(Convert.ToInt32(textBox6.Text)+1,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	objTable.Cell(Convert.ToInt32(textBox6.Text)+2,3).Range.Text = (CDbl(textBox10.Text)).ToString("0.00")
	objTable.Cell(Convert.ToInt32(textBox6.Text)+2,3).Range.Font.Bold = True
	
	objTable.Cell(Convert.ToInt32(textBox6.Text)+3,1).Range.Text = "Perbelanjaan"
    objTable.Cell(Convert.ToInt32(textBox6.Text)+3,1).Range.Font.underline = True
    objTable.Cell(Convert.ToInt32(textBox6.Text)+3,1).Range.Font.Bold = True
    
    Try
		Dim count2 As Integer = Convert.ToInt32(textBox6.Text)+3
		Dim totalIn As Double
    	Dim sqlquery3 As String = "Select tt_seq_no,tt_name,FORMAT(SUM(al_amount),2) FROM transaction_type LEFT JOIN account_ledger " & _
    		"ON tt_seq_no = al_trans_type WHERE  YEAR(al_date) = '" & comboBox5.Text & "' AND MONTH(al_date) = '" & bulan & "' AND tt_type = 'OUT' GROUP BY tt_seq_no"
    	
	    Dim data3 As MySqlDataReader
	    Dim adapter3 As New MySqlDataAdapter
	    Dim cmd3 As New MySqlCommand
		cmd3.Connection = conn
	    cmd3.CommandText = sqlquery3
	    adapter3.SelectCommand = cmd3
	    data3= cmd3.ExecuteReader
	    While data3.Read()
	    	count2 = count2 + 1
	    	objTable.Cell(count2,1).Range.Text = data3(1).ToString()
	    	If data3(2).ToString()  = "" Then
	    		objTable.Cell(count2,2).Range.Text = "0"
	    	Else
	    		objTable.Cell(count2,2).Range.Text = data3(2).ToString()
	    		totalIn = totalIn+CDbl(data3(2).ToString())
	    	End If
	    End While
	    textBox9.Text = count2.ToString
	    textBox11.Text = totalIn.ToString
		data3.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
	End Try
	
	Dim rowAdd As Integer = Convert.ToInt32(textBox9.Text)
	
	objTable.Cell(rowAdd+1,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	
	objTable.Cell(rowAdd+2,3).Range.Text = (CDbl(textBox11.Text)).ToString("0.00")
	objTable.Cell(rowAdd+2,3).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+2,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	objTable.Cell(rowAdd+3,1).Range.Text = "Baki Akhir"
	objTable.Cell(rowAdd+3,1).Range.Font.underline = True
	objTable.Cell(rowAdd+3,1).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+3,3).Range.Text = (CDBL(textBox10.Text) - CDbl(textBox11.Text)).ToString("0.00")
	objTable.Cell(rowAdd+3,3).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+3,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	objTable.Cell(rowAdd+11,1).Range.Text = "Disediakan"
	objTable.Cell(rowAdd+11,1).Range.Font.Bold = True
	objTable.Cell(rowAdd+11,2).Range.Text = "Disemak"
	objTable.Cell(rowAdd+11,2).Range.Font.Bold = True
	objTable.Cell(rowAdd+11,3).Range.Text = "Diluluskan"
	objTable.Cell(rowAdd+11,3).Range.Font.Bold = True
	
    objTable.Cell(rowAdd+14,1).Range.Text = "-----------------------------"
    objTable.Cell(rowAdd+14,2).Range.Text = "-----------------------------"
    objTable.Cell(rowAdd+14,3).Range.Text = "-----------------------------"
	
	
    conn.Close()
 	objDoc.SaveAs("C:\account\ur_bulanan")
	objDoc.Close()        
	objWord.Quit()
	objDoc = Nothing
	objWord = Nothing
	
	Dim appWord As New Microsoft.Office.Interop.Word.Application()
	
	Try 
		wordDocument = appWord.Documents.Open("C:\account\ur_bulanan.docx")
		wordDocument.ExportAsFixedFormat("C:\account\ur_bulanan.pdf", WdExportFormat.wdExportFormatPDF)
		wordDocument.Close
		appWord.Quit()
		GC.Collect()
    	System.Diagnostics.Process.Start("C:\account\ur_bulanan.pdf")
	Catch ex As Exception
        System.Windows.Forms.MessageBox.Show(ex.Message)
	End Try
    
	End Sub
	
	Public Sub bakiMulaTahun()
		
        Try
        	Dim sqlquery As String = "Select al_remain FROM account_ledger where al_seq_no = (Select min(al_seq_no) FROM account_ledger where YEAR(al_date) = '" & comboBox7.Text & "') and YEAR(al_date) = '" & comboBox7.Text & "' limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				txtBakiMula.Text = CDbl(data(0).ToString).ToString("0.00")
			End While
			data.Close()
			If txtBakiMula.Text = Nothing Then
			txtBakiMula.Text = "0.00"
		End If
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
	
	Sub Button6Click(sender As Object, e As EventArgs)
		
	conn.Open()
		
	bakiMulaTahun()
	
	Dim objWord As Word.Application
	Dim objDoc As Word.Document
	Dim objTable As Word.Table
	Dim objPara1 As Word.Paragraph, objPara2 As Word.Paragraph
	  
    objWord = CreateObject("Word.Application")
    objWord.Visible = False
    objDoc = objWord.Documents.Add
    
    If textBox12.Text = "" Then
    	textBox12.Text = "0"
    End If
    
    If textBox13.Text = "" Then
    	textBox13.Text = "0"
    End If
    
    If textBox14.Text = "" Then
    	textBox14.Text = "0"
    End If
    
    If textBox15.Text = "" Then
    	textBox15.Text = "0"
    End If
    
    Dim aod_name As String  = "-"
        
    Try
    	
	 	Dim sqlquery As String = "SELECT aod_name,aod_address1,aod_address2,aod_postcode,aod_city," & _
	 		"aod_state FROM account_owner_detail LIMIT 1"
	    Dim data As MySqlDataReader
	    Dim adapter As New MySqlDataAdapter
	    Dim cmd As New MySqlCommand
		cmd.Connection = conn
	    cmd.CommandText = sqlquery
	    adapter.SelectCommand = cmd
	    data = cmd.ExecuteReader
		While data.Read()
			aod_name = data(0).ToString()
		End While
		data.Close()
	   ' conn.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
	End Try
	
	objPara2 = objDoc.Content.Paragraphs.Add
    objPara2.Range.Text = aod_name
    objPara2.Range.Font.Bold = False
    objPara2.Range.Font.Size = 14
    objPara2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    'oPara1.Range.Font.Size = 18
    objPara2.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
    objPara2.Range.InsertParagraphAfter()
    
    Dim bulan As String
    
	'Insert a paragraph at the beginning of the document.
    objPara1 = objDoc.Content.Paragraphs.Add
    objPara1.Range.Text = "Penyata Pendapatan dan Perbelanjaan bagi tahun berakhir 31/12/"+ comboBox7.Text
    objPara1.Range.Font.Bold = True
    objPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    objPara1.Range.Font.Size = 11
    objPara1.Format.SpaceAfter = 30    '24 pt spacing after paragraph.
    objPara1.Range.InsertParagraphAfter()
    
    'Dim v As Integer = 0
    Dim ttin As Integer = 0
    
    Try
    	Dim sqlquery3 As String = "SELECT count(tt_seq_no) FROM transaction_type"
	    Dim data3 As MySqlDataReader
	    Dim adapter3 As New MySqlDataAdapter
	    Dim cmd3 As New MySqlCommand
		cmd3.Connection = conn
	    cmd3.CommandText = sqlquery3
	    adapter3.SelectCommand = cmd3
	    data3 = cmd3.ExecuteReader
	    While data3.Read()
			ttin = Convert.ToInt32(data3(0).ToString())
		End While
		data3.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    
    'v = ttin + 10
        
    objTable = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, ttin+10, 3)
    objTable.Rows.Height = 8
    objTable.Range.ParagraphFormat.SpaceAfter = 12
    objTable.Range.Font.Size = 11
    objtable.range.font.bold = False
    objtable.Range.Font.underline = False
        
    objTable.Cell(1,2).Range.Text = "RM"
    objTable.Cell(1,2).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
    objTable.Cell(1,3).Range.Text = "RM"
    objTable.Cell(1,3).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	objTable.Columns(1).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
	objTable.Columns(2).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    objTable.Columns(3).Select
    objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
    
    objTable.Cell(3,1).Range.Text = "Baki Pemulaan"
    objTable.Cell(3,1).Range.Font.underline = True
    objTable.Cell(3,1).Range.Font.Bold = True
    
    objTable.Cell(3,3).Range.Text = txtBakiMula.Text
    objTable.Cell(3,3).Range.Font.Bold = True
    objTable.Cell(2,3).Range.select
     With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
    
    objTable.Cell(4,1).Range.Text = "Pendapatan"
    objTable.Cell(4,1).Range.Font.underline = True
    objTable.Cell(4,1).Range.Font.Bold = True
    
   
	
	Try
		Dim count As Integer = 4
		Dim totalIn As Double
    	Dim sqlquery2 As String = "Select tt_seq_no,tt_name,FORMAT(SUM(al_amount),2) FROM transaction_type LEFT JOIN account_ledger " & _
    		"ON tt_seq_no = al_trans_type WHERE tt_type = 'IN'  AND YEAR(al_date) = '" & comboBox7.Text & "' GROUP BY tt_seq_no"
    	
	    Dim data2 As MySqlDataReader
	    Dim adapter2 As New MySqlDataAdapter
	    Dim cmd2 As New MySqlCommand
		cmd2.Connection = conn
	    cmd2.CommandText = sqlquery2
	    adapter2.SelectCommand = cmd2
	    data2 = cmd2.ExecuteReader
	    While data2.Read()
	    	count = count + 1
	    	objTable.Cell(count,1).Range.Text = data2(1).ToString()
	    	If data2(2).ToString()  = "" Then
	    		objTable.Cell(count,2).Range.Text = "0"
	    	Else
	    		objTable.Cell(count,2).Range.Text = data2(2).ToString()
	    		totalIn = totalIn+CDbl(data2(2).ToString())
	    	End If
	    	textBox12.Text = count.ToString
	    End While
	    textBox13.Text = totalIn.ToString
		data2.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    
    objTable.Cell(Convert.ToInt32(textBox12.Text)+1,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	objTable.Cell(Convert.ToInt32(textBox12.Text)+2,3).Range.Text = (CDbl(textBox13.Text)).ToString("0.00")
	objTable.Cell(Convert.ToInt32(textBox12.Text)+2,3).Range.Font.Bold = True
	
	objTable.Cell(Convert.ToInt32(textBox12.Text)+3,1).Range.Text = "Perbelanjaan"
    objTable.Cell(Convert.ToInt32(textBox12.Text)+3,1).Range.Font.underline = True
    objTable.Cell(Convert.ToInt32(textBox12.Text)+3,1).Range.Font.Bold = True
    
    Try
		Dim count As Integer = Convert.ToInt32(textBox12.Text)+3
		Dim totalIn As Double
    	Dim sqlquery3 As String = "Select tt_seq_no,tt_name,FORMAT(SUM(al_amount),2) FROM transaction_type LEFT JOIN account_ledger " & _
    		"ON tt_seq_no = al_trans_type WHERE  YEAR(al_date) = '" & comboBox7.Text & "' AND tt_type = 'OUT' GROUP BY tt_seq_no"
    	
	    Dim data3 As MySqlDataReader
	    Dim adapter3 As New MySqlDataAdapter
	    Dim cmd3 As New MySqlCommand
		cmd3.Connection = conn
	    cmd3.CommandText = sqlquery3
	    adapter3.SelectCommand = cmd3
	    data3= cmd3.ExecuteReader
	    While data3.Read()
	    	count = count + 1
	    	objTable.Cell(count,1).Range.Text = data3(1).ToString()
	    	If data3(2).ToString()  = "" Then
	    		objTable.Cell(count,2).Range.Text = "0"
	    	Else
	    		objTable.Cell(count,2).Range.Text = data3(2).ToString()
	    		totalIn = totalIn+CDbl(data3(2).ToString())
	    	End If
	    	textBox14.Text = count.ToString
	    End While
	    textBox15.Text = totalIn.ToString
		data3.Close()
	Catch ex As Exception
        MsgBox(ex.Message)
	End Try
	
	Dim rowAdd As Integer = Convert.ToInt32(textBox14.Text)
	
	 objTable.Cell(rowAdd+1,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	
	objTable.Cell(rowAdd+2,3).Range.Text = (CDbl(textBox15.Text)).ToString("0.00")
	objTable.Cell(rowAdd+2,3).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+2,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	objTable.Cell(rowAdd+3,1).Range.Text = "Baki Akhir"
	objTable.Cell(rowAdd+3,1).Range.Font.underline = True
	objTable.Cell(rowAdd+3,1).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+3,3).Range.Text = (CDBL(textBox13.Text) - CDbl(textBox15.Text)).ToString("0.00")
	objTable.Cell(rowAdd+3,3).Range.Font.Bold = True
	
	objTable.Cell(rowAdd+3,3).Range.Select
	With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
	.LineStyle = objWord.Options.DefaultBorderLineStyle
	.LineWidth = objWord.Options.DefaultBorderLineWidth
	.Color = objWord.Options.DefaultBorderColor
	End With
	
	objTable.Cell(rowAdd+11,1).Range.Text = "Disediakan"
	objTable.Cell(rowAdd+11,1).Range.Font.Bold = True
	objTable.Cell(rowAdd+11,2).Range.Text = "Disemak"
	objTable.Cell(rowAdd+11,2).Range.Font.Bold = True
	objTable.Cell(rowAdd+11,3).Range.Text = "Diluluskan"
	objTable.Cell(rowAdd+11,3).Range.Font.Bold = True
    
    objTable.Cell(rowAdd+14,1).Range.Text = "-----------------------------"
    objTable.Cell(rowAdd+14,2).Range.Text = "-----------------------------"
    objTable.Cell(rowAdd+14,3).Range.Text = "-----------------------------"
	
		
	
    conn.Close()
 	objDoc.SaveAs("C:\account\ur_tahunan")
	objDoc.Close()        
	objWord.Quit()
	objDoc = Nothing
	objWord = Nothing
	
	Dim appWord As New Microsoft.Office.Interop.Word.Application()
	
	Try 
		wordDocument = appWord.Documents.Open("C:\account\ur_tahunan.docx")
		wordDocument.ExportAsFixedFormat("C:\account\ur_tahunan.pdf", WdExportFormat.wdExportFormatPDF)
		wordDocument.Close
		appWord.Quit()
		GC.Collect()
    	System.Diagnostics.Process.Start("C:\account\ur_tahunan.pdf")
	Catch ex As Exception
        System.Windows.Forms.MessageBox.Show(ex.Message)
	End Try
	
	End Sub
	
	Sub Button7Click(sender As Object, e As EventArgs)
		
		Dim objWord As Word.Application
        Dim objDoc As Word.Document
        Dim objTable1 As Word.Table, objTable As Word.Table, objTable2 As Word.Table
        Dim objPara1 As Word.Paragraph, objPara2 As Word.Paragraph
        Dim objPara3 As Word.Paragraph, objPara4 As Word.Paragraph
        Dim objPara5 As Word.Paragraph, objPara6 As Word.Paragraph
        Dim objPara7 As Word.Paragraph, objPara8 As Word.Paragraph
        Dim objPara9 As Word.Paragraph
        
        objWord = CreateObject("Word.Application")
        objWord.Visible = False
        objDoc = objWord.Documents.Add
        
        objPara1 = objDoc.Content.Paragraphs.Add
        objPara1.Range.Text = "Penyata Akaun"
        objPara1.Range.Font.Bold = True
        objPara1.Range.Font.Size = 16
        objPara1.Format.SpaceAfter = 36    '24 pt spacing after paragraph.
        objPara1.Range.InsertParagraphAfter()
        
        'owner detail
        Dim aod_name As String = "-"
        Dim aod_address As String = "-"
        Dim aod_address1 As String = "-"
        Dim aod_postcode As String = "-"
        Dim aod_city As String = "-"
        Dim aod_state As String = "-"
        
        conn.Open
        
        Try
        	
		 	Dim sqlquery As String = "SELECT aod_name,aod_address1,aod_address2,aod_postcode,aod_city," & _
		 		"aod_state FROM account_owner_detail LIMIT 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				aod_name = data(0).ToString()
				aod_address	= data(1).ToString()
				aod_address1	= data(2).ToString()
				aod_postcode	= data(3).ToString()
				aod_city	= data(4).ToString()
				aod_state = data(5).ToString()
			End While
			data.Close()
		   ' conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        objPara2 = objDoc.Content.Paragraphs.Add
        objPara2.Range.Text = aod_name
        objPara2.Range.Font.Bold = False
        objPara2.Range.Font.Size = 11
        objPara2.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
        objPara2.Range.InsertParagraphAfter()
        
        objPara3 = objDoc.Content.Paragraphs.Add
        objPara3.Range.Text = aod_address
        objPara3.Range.Font.Bold = False
        objPara3.Range.Font.Size = 11
        objPara3.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
        objPara3.Range.InsertParagraphAfter()
        
        If aod_address1 = "" Then
        	GoTo textline3
        Else
        objPara4 = objDoc.Content.Paragraphs.Add
        objPara4.Range.Text = aod_address1
        objPara4.Range.Font.Bold = False
        objPara4.Range.Font.Size = 11
        objPara4.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
        objPara4.Range.InsertParagraphAfter()
        End If
        
        Textline3: 
        
        objPara5 = objDoc.Content.Paragraphs.Add
        objPara5.Range.Text = aod_postcode + " " + aod_city
        objPara5.Range.Font.Bold = False
        objPara5.Range.Font.Size = 11
        objPara5.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
        objPara5.Range.InsertParagraphAfter()
        
        objPara6 = objDoc.Content.Paragraphs.Add
        objPara6.Range.Text = aod_state
        objPara6.Range.Font.Bold = False
        objPara6.Range.Font.Size = 11
        objPara6.Format.SpaceAfter = 36    '24 pt spacing after paragraph.
        objPara6.Range.InsertParagraphAfter()
        'owner detail end
        
        Dim bulan as string
			If combobox10.Text = "Januari" Then
				bulan = "01"
			Else If combobox10.Text = "Februari" Then
				bulan = "02"
			Else If combobox10.Text = "Mac" Then
				bulan = "03"
			Else If combobox10.Text = "April" Then
				bulan = "04"
			Else If combobox10.Text = "Mei" Then
				bulan = "05"
			Else If combobox10.Text = "Jun" Then
				bulan = "06"
			Else If combobox10.Text = "Julai" Then
				bulan = "07"
			Else If combobox10.Text = "Ogos" Then
				bulan = "08"
			Else If combobox10.Text = "September" Then
				bulan = "09"
			Else If combobox10.Text = "Oktober" Then
				bulan = "10"
			Else If combobox10.Text = "November" Then
				bulan = "11"
			Else If combobox10.Text = "Disember" Then
				bulan = "12"
			End If
			
			Dim remainStart As String,remainDate As String
			Dim typeAccount As String
			
			If comboBox8.Text = "Tunai" Then
				typeAccount = "CASH"
			ElseIf comboBox8.Text = "Bank" Then
				typeAccount = "BANK"
			End If
        Try
	    	Dim sqlquery2 As String = "SELECT FORMAT(al_remain,2), DATE_FORMAT(al_date,'%d-%m-%Y') FROM account_ledger " & _
	    		"WHERE  YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "' AND al_account_type = '" & typeAccount & "' " & _
	    		" AND al_seq_no = (SELECT MIN(al_seq_no) FROM account_ledger WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "' AND al_account_type = '" & typeAccount & "')"
	    	'System.Diagnostics.Debug.WriteLine(sqlquery2)
	    	'MsgBox(sqlquery2)
	    	
		    Dim data2 As MySqlDataReader
		    Dim adapter2 As New MySqlDataAdapter
		    Dim cmd2 As New MySqlCommand
			cmd2.Connection = conn
		    cmd2.CommandText = sqlquery2
		    adapter2.SelectCommand = cmd2
		    data2 = cmd2.ExecuteReader
			While data2.Read()
				remainStart = data2(0).ToString()
				remainDate = data2(1).ToString()
			End While
			data2.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		If remainStart = "" Then
			remainStart = "0.00"
		End If
		
		Dim countOut As String
		
		Try
	    	Dim sqlquery3 As String = "SELECT count(al_seq_no) FROM account_ledger " & _
	    		"WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' AND al_type = 'OUT' "
	    	'System.Diagnostics.Debug.WriteLine(sqlquery3)
	    	
		    Dim data3 As MySqlDataReader
		    Dim adapter3 As New MySqlDataAdapter
		    Dim cmd3 As New MySqlCommand
			cmd3.Connection = conn
		    cmd3.CommandText = sqlquery3
		    adapter3.SelectCommand = cmd3
		    data3 = cmd3.ExecuteReader
			While data3.Read()
				countOut = data3(0).ToString()
			End While
			data3.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		If countOut = "" Then
			countOut = "0"
		End If
		
		Dim totalOut As String
		
		Try
	    	Dim sqlquery4 As String = "SELECT FORMAT(sum(al_amount),2) FROM account_ledger " & _
	    		"WHERE  YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' AND al_type = 'OUT' "
	    	'System.Diagnostics.Debug.WriteLine(sqlquery4)
	    	
		    Dim data4 As MySqlDataReader
		    Dim adapter4 As New MySqlDataAdapter
		    Dim cmd4 As New MySqlCommand
			cmd4.Connection = conn
		    cmd4.CommandText = sqlquery4
		    adapter4.SelectCommand = cmd4
		    data4 = cmd4.ExecuteReader
			While data4.Read()
				totalOut = data4(0).ToString()
			End While
			data4.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		If totalOut = "" Then
			totalOut = "0.00"
		End If
		
		Dim countIn As String
		
		Try
	    	Dim sqlquery5 As String = "SELECT count(al_seq_no) FROM account_ledger " & _
	    		"WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' AND al_type = 'IN' "
	    	'System.Diagnostics.Debug.WriteLine(sqlquery5)
	    	
		    Dim data5 As MySqlDataReader
		    Dim adapter5 As New MySqlDataAdapter
		    Dim cmd5 As New MySqlCommand
			cmd5.Connection = conn
		    cmd5.CommandText = sqlquery5
		    adapter5.SelectCommand = cmd5
		    data5 = cmd5.ExecuteReader
			While data5.Read()
				countIn = data5(0).ToString()
			End While
			data5.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		If countIn = "" Then
			countIn = "0"
		End If
		
		Dim totalIn As String
		
		Try
	    	Dim sqlquery6 As String = "SELECT FORMAT(sum(al_amount),2) FROM account_ledger " & _
	    		"WHERE  YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' AND al_type = 'IN' "
	    	'System.Diagnostics.Debug.WriteLine(sqlquery6)
	    	
		    Dim data6 As MySqlDataReader
		    Dim adapter6 As New MySqlDataAdapter
		    Dim cmd6 As New MySqlCommand
			cmd6.Connection = conn
		    cmd6.CommandText = sqlquery6
		    adapter6.SelectCommand = cmd6
		    data6 = cmd6.ExecuteReader
			While data6.Read()
				totalIn = data6(0).ToString()
			End While
			data6.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		
		If totalIn = "" Then
			totalIn = "0.00"
		End If
		
        Dim remainEnd As String
        
         Try
	    	Dim sqlquery7 As String = "SELECT FORMAT(al_remain,2) FROM account_ledger " & _
	    		"WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' " & _
	    		" AND al_seq_no = (SELECT MAX(al_seq_no) FROM account_ledger WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "' AND al_account_type = '" & typeAccount & "')"
	    	'System.Diagnostics.Debug.WriteLine(sqlquery7)
	    	
		    Dim data7 As MySqlDataReader
		    Dim adapter7 As New MySqlDataAdapter
		    Dim cmd7 As New MySqlCommand
			cmd7.Connection = conn
		    cmd7.CommandText = sqlquery7
		    adapter7.SelectCommand = cmd7
		    data7 = cmd7.ExecuteReader
			While data7.Read()
				remainEnd = data7(0).ToString()
			End While
			data7.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		If remainEnd = "" Then
			remainEnd = "0.00"
		End If
        
        objTable1 = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, 3, 6)
        objTable1.Range.ParagraphFormat.SpaceAfter = 5
        objTable1.Range.Font.Size = 11
        objTable1.range.font.bold = True
        objTable1.Range.Font.underline = False
        objTable1.cell(1,1).Range.text = "Baki Permulaan"
        objTable1.Cell(1,1).Merge (objTable1.Cell(2,1))
        objTable1.cell(3,1).Range.text = remainStart
        objTable1.Cell(3,1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        objTable1.cell(1,2).Range.text = "Pengeluaran"
        objTable1.Cell(1,2).Merge (objTable1.Cell(1,3))
        objTable1.cell(2,2).Range.text = "Bil"
        objTable1.cell(2,3).Range.text = "Jumlah"
        objTable1.cell(3,2).Range.text = countOut
        objTable1.Cell(3,2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        objTable1.cell(3,3).Range.text = totalOut
        objTable1.Cell(3,3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        objTable1.cell(1,4).Range.text = "Simpanan"
        objTable1.Cell(1,3).Merge (objTable1.Cell(1,4))
        objTable1.cell(2,4).Range.text = "Bil"
        objTable1.cell(2,5).Range.text = "Jumlah"
        objTable1.cell(3,4).Range.text = countIn
        objTable1.Cell(3,4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        objTable1.cell(3,5).Range.text = totalIn
        objTable1.Cell(3,5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        objTable1.cell(1,4).Range.text = "Baki Penutup"
        objTable1.Cell(1,4).Merge (objTable1.Cell(2,6))
        objTable1.cell(3,6).Range.text = remainEnd
        objTable1.Cell(3,6).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        
        objTable1.Select
        'objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        
       
        
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
        End With
        
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderBottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.Cell(3,1).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
        End With
        
       
        
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(1,1).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(2,2).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(3,2).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(2,3).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(3,3).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(2,4).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(3,4).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(2,5).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(3,5).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderRight)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(1,3).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderBottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable1.cell(1,4).Select
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderLeft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderBottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objPara7 = objDoc.Content.Paragraphs.Add
        objPara7.Range.Text = ""
        objPara7.Range.Font.Bold = False
        objPara7.Range.Font.Size = 11
        objPara7.Format.SpaceAfter = 5    '24 pt spacing after paragraph.
        objPara7.Range.InsertParagraphAfter()
		
        objPara8 = objDoc.Content.Paragraphs.Add
        objPara8.Range.Text = "TRANSAKSI AKAUN"
        objPara8.Range.Font.Bold = True
        objPara8.Range.Font.Size = 11
        objPara8.Format.SpaceAfter = 10    '24 pt spacing after paragraph.
        objPara8.Range.InsertParagraphAfter()
        
        Dim countRow As Integer = 0
        
        Try
	    	Dim sqlquery8 As String = "SELECT count(al_seq_no) FROM account_ledger " & _
	    		"WHERE YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "' "
	    	'System.Diagnostics.Debug.WriteLine(sqlquery8)
	    	
		    Dim data8 As MySqlDataReader
		    Dim adapter8 As New MySqlDataAdapter
		    Dim cmd8 As New MySqlCommand
			cmd8.Connection = conn
		    cmd8.CommandText = sqlquery8
		    adapter8.SelectCommand = cmd8
		    data8 = cmd8.ExecuteReader
			While data8.Read()
				countRow = Convert.ToInt32(data8(0).ToString())
			End While
			data8.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		
		Dim row1 As Integer
		row1 = countRow + 2
		System.Diagnostics.Debug.WriteLine(row1)
		'System.Diagnostics.Debug.WriteLine(countRow)
		
		objTable = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, row1, 6)
        objTable.Range.ParagraphFormat.SpaceAfter = 12
        objTable.Range.Font.Size = 11
        objTable.range.font.bold = True
        objTable.Range.Font.underline = False
        objTable.Cell(1,1).Range.Text = "Tarikh"
        objTable.Cell(1,2).Range.Text = "Perkara"
        objTable.Cell(1,3).Range.Text = "Catatan"
        objTable.Cell(1,4).Range.Text = "Pengeluaran"
        objTable.Cell(1,5).Range.Text = "Simpanan"
        objTable.Cell(1,6).Range.Text = "Baki"
        objTable.rows(1).Select
        objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        'objTable.Range.border.
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(1).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(3).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(5).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(6).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.rows(row1).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		objTable.cell(2,1).Range.Text = remainDate
 		objTable.Cell(2,2).Range.Text = "Baki Pembukaan....."
 		objTable.Cell(2,6).Range.Text = remainStart
 		objTable.Cell(2,6).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
 		
        Try
	    	Dim sqlquery9 As String = "SELECT DATE_FORMAT(al_date,'%d-%m-%Y'),al_note,tt_name,Case al_type When 'OUT' Then FORMAT(al_amount,2) End As 'out',Case al_type When 'In' Then FORMAT(al_amount,2) End As 'In',FORMAT(al_remain,2) FROM account_ledger INNER JOIN transaction_type ON al_trans_type = tt_seq_no " & _
	    		"WHERE  YEAR(al_date) = '" & comboBox9.Text & "' AND MONTH(al_date) = '" & bulan & "'  AND al_account_type = '" & typeAccount & "'"
	    		
	    	'System.Diagnostics.Debug.WriteLine(sqlquery9)
	    	
		    Dim data9 As MySqlDataReader
		    Dim adapter9 As New MySqlDataAdapter
		    Dim cmd9 As New MySqlCommand
			cmd9.Connection = conn
		    cmd9.CommandText = sqlquery9
		    adapter9.SelectCommand = cmd9
		    data9 = cmd9.ExecuteReader
		    Dim j As Integer = 2
		    While data9.Read()
		    	j += 1
		    	objTable.Cell(j,1).Range.Text  = data9(0).ToString()
		    	objTable.Cell(j,2).Range.Text  = data9(2).ToString()
		    	objTable.Cell(j,3).Range.Text  = data9(1).ToString()
		    	objTable.Cell(j,4).Range.Text  = data9(3).ToString()
		    	objTable.Cell(j,4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	objTable.Cell(j,5).Range.Text  = data9(4).ToString()
		    	objTable.Cell(j,5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	objTable.Cell(j,6).Range.Text  = data9(5).ToString()
		    	objTable.Cell(j,6).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	'System.Diagnostics.Debug.WriteLine(j)
			End While
			data9.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		objPara9 = objDoc.Content.Paragraphs.Add
        objPara9.Range.Text = ""
        objPara9.Range.Font.Bold = False
        objPara9.Range.Font.Size = 11
        objPara9.Format.SpaceAfter = 20    '24 pt spacing after paragraph.
        objPara9.Range.InsertParagraphAfter()
	
		objTable2 = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, 3 , 3)
        objTable2.Range.ParagraphFormat.SpaceAfter = 12
        objTable2.Range.Font.Size = 11
        objTable2.range.font.bold = True
        objTable2.Range.Font.underline = False
        objTable2.Cell(1,1).Range.Text = "Disediakan"
        objTable2.Cell(1,2).Range.Text = "Disemak"
        objTable2.Cell(1,3).Range.Text = "Diluluskan"
        
        objTable2.Cell(3,1).Range.Text = "-----------------------------"
        objTable2.Cell(3,2).Range.Text = "-----------------------------"
        objTable2.Cell(3,3).Range.Text = "-----------------------------"
        
		conn.Close()

        objDoc.SaveAs("C:\account\pk_bulanan")
		objDoc.Close()        
		objWord.Quit()
		objDoc = Nothing
		objWord = Nothing
		
		Dim appWord As New Microsoft.Office.Interop.Word.Application()
		
		Try 
			wordDocument = appWord.Documents.Open("C:\account\pk_bulanan.docx")
			wordDocument.ExportAsFixedFormat("C:\account\pk_bulanan.pdf", WdExportFormat.wdExportFormatPDF)
			wordDocument.Close
			appWord.Quit()
			GC.Collect()
        	System.Diagnostics.Process.Start("C:\account\pk_bulanan.pdf")
		Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
		End Try
		
     End Sub   
        		
	Public Property wordDocument() As Microsoft.Office.Interop.Word.Document
	Get
	    Return m_wordDocument
	End Get
	
	Set(value As Microsoft.Office.Interop.Word.Document)
	    m_wordDocument = value
	End Set
	
	End Property
	    
    Private m_wordDocument As Microsoft.Office.Interop.Word.Document
    
	Sub ComboBox9SelectedIndexChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub ComboBox10SelectedIndexChanged(sender As Object, e As EventArgs)
			
	End Sub
	
	Sub ToolStripLabel1Click(sender As Object, e As EventArgs)	
		KemaskiniWangMasuk.show
	End Sub

	Sub Timer1Tick(sender As Object, e As EventArgs)
		label20.Text = TimeOfDay
	End Sub
	
	Sub RadioButton2CheckedChanged(sender As Object, e As EventArgs)
	
	End Sub
	
	Sub Button8Click(sender As Object, e As EventArgs)
		If textBox22.Text = "" Then
			MsgBox("Sila isi data yang diperlukan!")
		Else
			Try
			Dim sqlquery As String = "INSERT INTO asset_main (am_name,am_note,am_quantity,am_status,am_date_purchase) " & _
					"		 		VALUES ('" & textBox22.Text & "','" & textBox25.Text & "','" & textBox24.Text & "','" & textBox23.Text & "','" & Format(dateTimePicker1.Value, "yyyy-MM-dd") & "')"
		    Dim cmd As New MySqlCommand
			conn.Open()
		    cmd.CommandText = sqlquery
		    cmd.Connection = conn
		    If cmd.ExecuteNonQuery() = 1 Then
		    	read_asset_data()
		    	MsgBox("Berjaya")
		    End If
		    conn.Close()
			Catch ex As Exception
	            MsgBox(ex.Message)
	        End Try
		End If		
	End Sub
	
	Sub ToolStripStatusLabel2Click(sender As Object, e As EventArgs)
		MainForm.ActiveForm.Hide
		KemaskiniBakiMula.show
	End Sub
		
	Private Sub totalIn()
		
        Try
        	Dim sqlquery As String = "Select SUM(al_amount) FROM account_ledger where al_type = 'IN' AND " & _
        		"al_account_type = 'CASH' limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				textBox2.Text = data(0).ToString
			End While
			data.Close()
			If textBox2.Text = Nothing Then
			textBox2.Text = "0.00"
		End If
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
	
	Private Sub totalInBank()
		
        Try
		 	Dim sqlquery As String = "Select SUM(al_amount) FROM account_ledger where al_type = 'IN' AND " & _
		 		"al_account_type = 'BANK' limit 1"
		 	Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				textBox26.Text = data(0).ToString
			End While
			data.Close()
			If textBox26.Text = Nothing Then
			textBox26.Text = "0.00"
		End If
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
	
	Private Sub totalOut()
		Try
			
			Dim sqlquery As String = "Select SUM(al_amount) FROM account_ledger where al_type = 'OUT' " & _
				"AND  al_account_type = 'CASH' limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				textBox3.Text = data(0).ToString
			End While
			data.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		If textBox3.Text = Nothing Then
			textBox3.Text = "0.00"
		End If
	End Sub
	
	Private Sub totalOutBank()
		Try
			
			Dim sqlquery As String = "Select SUM(al_amount) FROM account_ledger where al_type = 'OUT' " & _
				"AND  al_account_type = 'BANK' limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				textBox27.Text = data(0).ToString
			End While
			data.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		If textBox27.Text = Nothing Then
			textBox27.Text = "0.00"
		End If
	End Sub
	
	Public Sub totalRemain()
		totalIn()
		totalOut()
		totalInBank()
		totalOutBank()
		textBox7.Text = (CDbl(textBox2.Text)-CDbl(textBox3.Text)).ToString("0.00")
		textBox16.Text = (CDbl(textBox26.Text)-CDbl(textBox27.Text)).ToString("0.00")
		textBox17.Text = (CDbl(textBox7.Text)+CDbl(textBox16.Text)).ToString("0.00")
	End Sub
	
	Sub ComboBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBox1.Text = "Aset" Then
			textBox18.Enabled = True
			textBox19.Enabled = True
		End If
	End Sub
	
	Sub ComboBox2SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBox2.Text = "Aset" Then
			textBox18.Enabled = True
			textBox19.Enabled = True
		End If
	End Sub
	
	Sub ComboBox3SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBox3.Text = "Aset" Then
			textBox20.Enabled = True
			textBox21.Enabled = True
		End If
	End Sub
	
	Sub ComboBox4SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBox4.Text = "Aset" Then
			textBox20.Enabled = True
			textBox21.Enabled = True
		End If
	End Sub
	
	Sub CheckBox1CheckedChanged(sender As Object, e As EventArgs)
		If checkBox1.Checked Then
			comboBox1.Enabled = True
			checkBox2.Enabled = False
			comboBox2.Enabled = False
		Else
			comboBox1.Enabled = False
			checkBox2.Enabled = True
			If comboBox1.Text = "Aset" Then
				textBox18.Enabled = False
				textBox19.Enabled = False
			End If
		End If
	End Sub
	
	Sub CheckBox2CheckedChanged(sender As Object, e As EventArgs)
		If checkBox2.Checked Then
			comboBox2.Enabled = True
			checkBox1.Enabled = False
			comboBox1.Enabled = False
		Else
			comboBox2.Enabled = False
			checkBox1.Enabled = True
			If comboBox2.Text = "Aset" Then
				textBox18.Enabled = False
				textBox19.Enabled = False
			End If
		End If
	End Sub
	
	Sub CheckBox3CheckedChanged(sender As Object, e As EventArgs)
		If checkBox3.Checked Then
			comboBox3.Enabled = True
			checkBox4.Enabled = False
			comboBox4.Enabled = False
		Else
			comboBox3.Enabled = False
			checkBox4.Enabled = True
			If comboBox3.Text = "Aset" Then
				textBox20.Enabled = False
				textBox21.Enabled = False
			End If
		End If
	End Sub
	
	Sub CheckBox4CheckedChanged(sender As Object, e As EventArgs)
		If checkBox4.Checked Then
			comboBox4.Enabled = True
			checkBox3.Enabled = False
			comboBox3.Enabled = False
		Else
			comboBox4.Enabled = False
			checkBox3.Enabled = True
			If comboBox4.Text = "Aset" Then
				textBox20.Enabled = False
				textBox21.Enabled = False
			End If
		End If
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Try
			conn.Open()
			totalRemain()
			Dim calculate_remain As Double = 0.00
			Dim sqlquery As String
			Dim last_id As Integer = 0
			
			If comboBox1.Enabled =  True Then
				calculate_remain =  CDbl(textBox16.Text) + CDbl(textBox1.Text)
				sqlquery = "INSERT INTO account_ledger (al_date,al_note,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
				" VALUES ('" & Format(dateTimePicker3.Value, "yyyy-MM-dd") & "','" & textBox4.Text & "','" & textBox1.Text & "','" & calculate_remain & "','"& "IN" & "','"& comboBox1.SelectedValue & "','"& "BANK" & "')"
			End If
			
			If comboBox2.Enabled =  True Then
				calculate_remain =  CDbl(textBox7.Text) + CDbl(textBox1.Text)
				sqlquery = "INSERT INTO account_ledger (al_date,al_note,al_amount,al_remain,al_type,al_trans_type,al_account_type) " & _
				" VALUES ('" & Format(dateTimePicker3.Value, "yyyy-MM-dd") & "','" & textBox4.Text & "','" & textBox1.Text & "','" & calculate_remain & "','"& "IN" & "','"& comboBox2.SelectedValue & "','"& "CASH" & "')"
			End If
			
			Dim cmd As New MySqlCommand
			cmd.Connection = conn
			cmd.CommandText = sqlquery
		    If cmd.ExecuteNonQuery() = 1 Then
		    	MsgBox("Berjaya")
		    	cmd.CommandText = "SELECT LAST_INSERT_ID()"
		    	last_id = cmd.ExecuteScalar()
		    	If comboBox1.Text = "Aset" Or comboBox2.Text = "Aset" Then
		    		Dim sqlquery2 As String = "INSERT INTO asset_main (am_name,am_quantity,am_date_purchase,am_al_seq_no) " & _
						" VALUES ('" & textBox18.Text & "','" & textBox19.Text & "','" & Format(dateTimePicker3.Value, "yyyy-MM-dd") & "','" & last_id & "')"
				    Dim cmd2 As New MySqlCommand
					cmd2.Connection = conn
					cmd2.CommandText = sqlquery2
				    cmd2.Connection = conn
				    If cmd2.ExecuteNonQuery() = 1 Then
				    	'MsgBox("Berjaya")
				    	read_asset_data()
				    
				    End If
			    End If
		    End If
		    
		    totalRemain()
		    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
		
	Sub DataGridView2CellClick(sender As Object, e As DataGridViewCellEventArgs)
		textbox22.Text = Convert.ToString(DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value)
		textbox25.Text = Convert.ToString(DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value)
		textbox24.Text = Convert.ToString(DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value)
		textbox23.Text = Convert.ToString(DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value)
		textbox28.Text = Convert.ToString(DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value)
		dateTimePicker1.Text = DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value
		
	End Sub
	
	Sub Button11Click(sender As Object, e As EventArgs)
		
		Dim objWord As Word.Application
		Dim objDoc As Word.Document
		Dim objTable As Word.Table
		Dim objPara As Word.Paragraph
		  
		objWord = CreateObject("Word.Application")
		objWord.Visible = False
		objDoc = objWord.Documents.Add
		conn.Open()
		
		objPara = objDoc.Content.Paragraphs.Add
		objPara.Range.Text = "Senarai aset"
		objPara.Range.Font.Bold = False
		objPara.Range.Font.Size = 14
		objPara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
		objPara.Format.SpaceAfter = 8    '24 pt spacing after paragraph.
		objPara.Range.InsertParagraphAfter()
		
		Dim bulan as string
		If combobox12.Text = "Januari" Then
			bulan = "01"
		Else If combobox12.Text = "Februari" Then
			bulan = "02"
		Else If combobox12.Text = "Mac" Then
			bulan = "03"
		Else If combobox12.Text = "April" Then
			bulan = "04"
		Else If combobox12.Text = "Mei" Then
			bulan = "05"
		Else If combobox12.Text = "Jun" Then
			bulan = "06"
		Else If combobox12.Text = "Julai" Then
			bulan = "07"
		Else If combobox12.Text = "Ogos" Then
			bulan = "08"
		Else If combobox12.Text = "September" Then
			bulan = "09"
		Else If combobox12.Text = "Oktober" Then
			bulan = "10"
		Else If combobox12.Text = "November" Then
			bulan = "11"
		Else If combobox12.Text = "Disember" Then
			bulan = "12"
		End If
			
		Dim countRow As Integer = 0
		Dim sqlquery8 As String
		
		Try
			
			If comboBox11.Text = "Sila Pilih" And comboBox12.Text = "Sila Pilih" Then
				sqlquery8  = "SELECT count(am_seq_no) FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' "
			ElseIf comboBox11.Text = "" And comboBox12.Text = "" Then
				sqlquery8  = "SELECT count(am_seq_no) FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' "
			Else
				sqlquery8  = "SELECT count(am_seq_no) FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' " & _
	    		"AND YEAR(am_date_purchase) = '" & comboBox11.Text & "' AND MONTH(am_date_purchase) = '" & bulan & "' "
			End If

	    	'System.Diagnostics.Debug.WriteLine(sqlquery8)
	    	
		    Dim data8 As MySqlDataReader
		    Dim adapter8 As New MySqlDataAdapter
		    Dim cmd8 As New MySqlCommand
			cmd8.Connection = conn
		    cmd8.CommandText = sqlquery8
		    adapter8.SelectCommand = cmd8
		    data8 = cmd8.ExecuteReader
			While data8.Read()
				countRow = Convert.ToInt32(data8(0).ToString())
			End While
			data8.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		Dim row1 As Integer
		row1 = countRow + 1
		System.Diagnostics.Debug.WriteLine(row1)
		
		objTable = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, row1, 7)
        objTable.Range.ParagraphFormat.SpaceAfter = 12
        objTable.Range.Font.Size = 11
        objTable.range.font.bold = True
        objTable.Range.Font.underline = False
        objTable.Cell(1,1).Range.Text = "Bil."
        objTable.Cell(1,2).Range.Text = "Nama"
        objTable.Cell(1,3).Range.Text = "Nota"
        objTable.Cell(1,4).Range.Text = "Kuantiti"
        objTable.Cell(1,5).Range.Text = "Harga"
        objTable.Cell(1,6).Range.Text = "Status"
        objTable.Cell(1,7).Range.Text = "Tarikh Pembelian"
        objTable.rows(1).Select
        objWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        'objTable.Range.border.
        With objWord.Selection.Borders(Word.WdBorderType.wdBorderTop)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(1).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(3).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(5).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderleft)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(6).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.columns(7).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderright)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		objTable.rows(row1).select
        'objTable.Range.border.
		With objWord.Selection.Borders(Word.WdBorderType.wdBorderbottom)
		.LineStyle = objWord.Options.DefaultBorderLineStyle
		.LineWidth = objWord.Options.DefaultBorderLineWidth
		.Color = objWord.Options.DefaultBorderColor
		End With
		
		Try
			Dim sqlquery9 As String
			
			If comboBox11.Text = "Sila Pilih" And comboBox12.Text = "Sila Pilih" Then
				sqlquery9 = "Select am_name,am_note,am_quantity,am_status,FORMAT(al_amount,2),DATE_FORMAT(am_date_purchase,'%d-%m-%Y') FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' "
			ElseIf comboBox11.Text = "" And comboBox12.Text = "" Then
				sqlquery9 = "Select am_name,am_note,am_quantity,am_status,FORMAT(al_amount,2),DATE_FORMAT(am_date_purchase,'%d-%m-%Y') FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' "
			Else
				sqlquery9 = "Select am_name,am_note,am_quantity,am_status,FORMAT(al_amount,2),DATE_FORMAT(am_date_purchase,'%d-%m-%Y') FROM asset_main JOIN account_ledger ON am_al_seq_no = al_seq_no WHERE al_type = 'IN' " & _
	    		"AND YEAR(am_date_purchase) = '" & comboBox11.Text & "' AND MONTH(am_date_purchase) = '" & bulan & "'"
	    	End If
			
		    Dim data9 As MySqlDataReader
		    Dim adapter9 As New MySqlDataAdapter
		    Dim cmd9 As New MySqlCommand
			cmd9.Connection = conn
		    cmd9.CommandText = sqlquery9
		    adapter9.SelectCommand = cmd9
		    data9 = cmd9.ExecuteReader
		    Dim i As Integer = 0
		    Dim j As Integer = 1
		    While data9.Read()
		    	i += 1
		    	j += 1
		    	objTable.Cell(j,1).Range.Text  = i.ToString()
		    	objTable.Cell(j,1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	objTable.Cell(j,2).Range.Text  = data9(0).ToString()
		    	objTable.Cell(j,3).Range.Text  = data9(1).ToString()
		    	objTable.Cell(j,4).Range.Text  = data9(2).ToString()
		    	objTable.Cell(j,4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	objTable.Cell(j,5).Range.Text  = data9(4).ToString()
		    	objTable.Cell(j,5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
		    	objTable.Cell(j,6).Range.Text  = data9(3).ToString()
		    	objTable.Cell(j,7).Range.Text  = data9(5).ToString()
		    	'System.Diagnostics.Debug.WriteLine(j)
			End While
			data9.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		
		conn.Close()

        objDoc.SaveAs("C:\account\aset")
		objDoc.Close()        
		objWord.Quit()
		objDoc = Nothing
		objWord = Nothing
		
		Dim appWord As New Microsoft.Office.Interop.Word.Application()
		
		Try 
			wordDocument = appWord.Documents.Open("C:\account\aset.docx")
			wordDocument.ExportAsFixedFormat("C:\account\aset.pdf", WdExportFormat.wdExportFormatPDF)
			wordDocument.Close
			appWord.Quit()
			GC.Collect()
        	System.Diagnostics.Process.Start("C:\account\aset.pdf")
		Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
		End Try

	End Sub
	
	Sub Button9Click(sender As Object, e As EventArgs)
		If textBox28.Text = "" Then
			MsgBox("Sila pilih data untuk dikemaskini!")
		Else
			Try
				Dim sqlquery As String = "UPDATE asset_main SET am_name = '" & textBox22.Text & "',am_note = '" & textBox25.Text & "',am_quantity = '" & textBox24.Text & "'," & _
					" am_status = '" & textBox23.Text & "', am_date_purchase = '" & Format(dateTimePicker1.Value, "yyyy-MM-dd") & "' WHERE am_seq_no = '"& textBox28.Text &"' "
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
			conn.Open()
		    cmd.CommandText = sqlquery
		    cmd.Connection = conn
		    If cmd.ExecuteNonQuery() = 1 Then
		    	MsgBox("Berjaya")
		    	read_asset_data()
		    End If
		    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
		End Try
		End If
	End Sub
	
	Sub Button10Click(sender As Object, e As EventArgs)
		If textBox28.Text = "" Then
			MsgBox("Sila pilih data untuk dihapuskan!")
		Else
			Try
				Dim sqlquery As String = "DELETE FROM asset_main WHERE am_seq_no = '" & textBox28.Text & "'"
					
			    Dim cmd As New MySqlCommand
				cmd.Connection = conn
				conn.Open()
			    cmd.CommandText = sqlquery
			    cmd.Connection = conn
			    If cmd.ExecuteNonQuery() = 1 Then
			    	read_asset_data()
			    	MsgBox("Berjaya")
			    End If
			    conn.Close()
			Catch ex As Exception
		        MsgBox(ex.Message)
			End Try	
		End If
	End Sub
	
	Public Sub read_asset_data()
        Try
        	Dim query As String = "Select am_seq_no,am_al_seq_no,am_name,am_note,am_quantity,am_status,FORMAT(al_amount,2),DATE_FORMAT(am_date_purchase,'%d/%m/%Y') FROM asset_main " & _
        		" LEFT JOIN account_ledger ON am_al_seq_no = al_seq_no "
		    myadp = New MySqlDataAdapter(query, conn)
		    dt.Clear()
            myadp.Fill(dt)
            dataGridView2.DataSource = dt
            dataGridView2.Columns(0).HeaderCell.Value = "Id" 
            dataGridView2.Columns(2).HeaderCell.Value = "Nama"
            dataGridView2.Columns(3).HeaderCell.Value = "Nota"
            dataGridView2.Columns(4).HeaderCell.Value = "Kuantiti"
            dataGridView2.Columns(5).HeaderCell.Value = "Status"
            dataGridView2.Columns(6).HeaderCell.Value = "Harga"
            dataGridView2.Columns(7).HeaderCell.Value = "Tarikh Belian"
            dataGridView2.Columns(0).Visible = False
            dataGridView2.Columns(1).Visible = False
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
			dataGridView2.AutoResizeColumns()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
	
	
	Sub ToolStripStatusLabel3Click(sender As Object, e As EventArgs)
		Admin.show		
	End Sub
	
	Sub BtnLoginClick(sender As Object, e As EventArgs)
		
		If textBox29.Text = "" Or textBox30.Text = "" Then
			MsgBox("Sila isi data yang diperlukan !")
		Else
			Try
				    conn.Open()
					Dim sqlquery As String = "SELECT * FROM account_owner_detail WHERE aod_username = '" & textBox29.Text & "' AND aod_password = '" & textBox30.Text & "'"
					
					Dim data As MySqlDataReader
				    Dim adapter As New MySqlDataAdapter
				    Dim cmd As New MySqlCommand
					cmd.Connection = conn
				    cmd.CommandText = sqlquery
				    adapter.SelectCommand = cmd
				    data = cmd.ExecuteReader
					If data.HasRows
						'MsgBox("Berjaya")
				    	tabControl1.TabPages.Remove(Login)
				    	tabControl1.TabPages.Insert(0,Detail)
						tabControl1.TabPages.Insert(1,WangMasuk)
						tabControl1.TabPages.Insert(2,WangKeluar)
						tabControl1.TabPages.Insert(3,SemakAkaun)
						tabControl1.TabPages.Insert(4,PenyataUntungRugi)
						tabControl1.TabPages.Insert(5,Aset)
					Else
            			MsgBox("Sila cuba sekali lagi")
       				 End If
					data.Close()
					conn.Close()
				Catch ex As Exception
	            	MsgBox(ex.Message)
        	End Try
		End If
	End Sub
	
	Sub BtnLogoutClick(sender As Object, e As EventArgs)
		tabControl1.TabPages.Remove(Detail)
		tabControl1.TabPages.Remove(WangMasuk)
		tabControl1.TabPages.Remove(WangKeluar)
		tabControl1.TabPages.Remove(SemakAkaun)
		tabControl1.TabPages.Remove(PenyataUntungRugi)
		tabControl1.TabPages.Remove(Aset)
		tabControl1.TabPages.Insert(0,Login)
	End Sub
	
	Sub TextBox31TextChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub TxtBakiMulaTextChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		textBox8.Text = ""
		textBox20.Text = ""
		textBox21.Text = ""
		textBox5.Text = ""
		checkBox3.CheckState = CheckState.Unchecked
		checkBox4.CheckState = CheckState.Unchecked	
		dateTimePicker4.ResetText
	End Sub
End Class