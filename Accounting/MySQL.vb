'
' Created by SharpDevelop.
' User: Force
' Date: 10/07/2015
' Time: 15:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Module MySQL
	'SETTING UP THE CONNECTION
    Public Function open() As MySqlConnection
        Return New MySqlConnection("server=localhost;port=3300;user id=root;password=123456;database=accountingdb")
    End Function
    Public conn As MySqlConnection = open()
    'DECLARING CLASSES AND VARIABLE
End Module
