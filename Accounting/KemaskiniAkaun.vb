'
' Created by SharpDevelop.
' User: ME
' Date: 19/03/2011
' Time: 10:41:29 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Imports MySql

Public Partial Class KemaskiniAkaun
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Private Sub read_data()
        Try
		 	Dim sqlquery As String = "SELECT aod_name,aod_address1,aod_address2,aod_postcode,aod_city," & _
		 		"aod_state,aod_phone,aod_fax,aod_staff_name1,aod_staff_name2,aod_staff_name3,aod_staff_designation1," & _
		 		"aod_staff_designation2,aod_staff_designation3, aod_username, aod_password,aod_staff_name4,aod_staff_name5,aod_staff_designation4,aod_staff_designation5 " & _
		 		"from account_owner_detail limit 1"
		    Dim data As MySqlDataReader
		    Dim adapter As New MySqlDataAdapter
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
		    cmd.CommandText = sqlquery
		    adapter.SelectCommand = cmd
		    data = cmd.ExecuteReader
			While data.Read()
				txtName.Text = data(0).ToString()
				txtAddress1.Text	= data(1).ToString()
				txtAddress2.Text	= data(2).ToString()
				txtPostcode.Text	= data(3).ToString()
				txtCity.Text	= data(4).ToString()
				cbState.SelectedIndex = cbState.FindString(data(5).ToString())
				txtPhone.Text	= data(6).ToString()
				txtFax.Text	= data(7).ToString()
				txtUsername.Text	= data(14).ToString()
				txtPassword.Text	= data(15).ToString()
				txtStaffName1.Text	= data(8).ToString()
				txtStaffName2.Text	= data(9).ToString()
				txtStaffName3.Text	= data(10).ToString()
				txtStaffName4.Text	= data(16).ToString()
				txtStaffName5.Text	= data(17).ToString()
				txtStaffDesignation1.Text = data(11).ToString()
				txtStaffDesignation2.Text = data(12).ToString()
				txtStaffDesignation3.Text = data(13).ToString()
				txtStaffDesignation4.Text = data(18).ToString()
				txtStaffDesignation5.Text = data(19).ToString()
			End While
			data.Close()
		   ' conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
	
	Sub KemaskiniAkaunLoad(sender As Object, e As EventArgs)
		 conn.Open()
		 read_data()
		 conn.Close()
	End Sub
	
	Sub TextBox1TextChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
		KemaskiniAkaun.ActiveForm.Close
	End Sub

	Sub Button1Click(sender As Object, e As EventArgs)
		Try
			Dim sqlquery As String = "UPDATE account_owner_detail Set " & _
				"aod_name = '" & txtName.Text & "',aod_address1 = '" & txtAddress1.Text & "' ,aod_address2 = '" & txtAddress2.Text & "',aod_postcode = '" & txtPostcode.Text & "' ,aod_city = '" & txtCity.Text & "'," & _
				"aod_state = '" & cbState.Text & "' ,aod_phone = '" & txtPhone.Text & "',aod_fax = '" & txtFax.Text & "' ,aod_staff_name1 = '" & txtStaffName1.Text & "',aod_staff_name2 = '" & txtStaffName2.Text & "'," & _
				"aod_staff_name3 = '" & txtStaffName3.Text & "',aod_staff_designation1 = '" & txtStaffDesignation1.Text & "',aod_staff_designation2 = '" & txtStaffDesignation2.Text & "',aod_staff_designation3= '" & txtStaffDesignation3.Text & "'," & _
				"aod_username = '" & txtUsername.Text & "',	aod_password = '" & txtPassword.Text & "', aod_staff_name4= '" & txtStaffName4.Text & "', aod_staff_name5 = '" & txtStaffName5.Text & "', " & _
				"aod_staff_designation4 = '" & txtStaffDesignation4.Text & "', aod_staff_designation5 = '" & txtStaffDesignation5.Text & "' "
		    Dim cmd As New MySqlCommand
			cmd.Connection = conn
			conn.Open()
		    cmd.CommandText = sqlquery
		    If cmd.ExecuteNonQuery() = 1 Then
		    	read_data()
		    	MsgBox("Berjaya")
		    End If
		    conn.Close()
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Sub
End Class
