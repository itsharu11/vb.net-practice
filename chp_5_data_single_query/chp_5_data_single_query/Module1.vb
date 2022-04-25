Imports System.Data.OleDb

Module Module1

    Sub Main()
        Dim connection As OleDbConnection
        Dim con As String
        con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\study\access\Database2_1.mdb"
        connection = New OleDbConnection(con)
        connection.Open()
        Console.WriteLine("Connection opened Successfully")

        'Write data base code here

        'Define command object dynamic
        Dim cmd As New OleDbCommand()
        Dim query As String
        Dim dataread As Integer
        query = "Select count(*) FROM customer"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        'Dim icustomer As Integer
        cmd = New OleDbCommand(query, connection)
        dataread = Convert.ToInt16(cmd.ExecuteScalar)
        Console.WriteLine("The customers are " & " " & dataread)



        connection.Close()
        Console.WriteLine("Connection Closed Successfully")
        Console.ReadKey()
    End Sub

End Module
