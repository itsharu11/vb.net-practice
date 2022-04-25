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
        Dim dataread As OleDbDataReader
        query = "Select * from customer"
        cmd = New OleDbCommand(query, connection)
        dataread = cmd.ExecuteReader()
        Console.WriteLine("Total number of columns = " & dataread.FieldCount)


        'Read all the data from the table 
        While dataread.Read
            ' Dim str_2 As String

            ' str_2 = dataread.GetString(1)
            ' Console.WriteLine("  " & str_2)
            Console.WriteLine(dataread(dataread.GetOrdinal("ID")) &
                              " " & dataread(dataread.GetOrdinal("Name")) &
                              " " & dataread(dataread.GetOrdinal("Address")) &
                              " " & dataread(dataread.GetOrdinal("Mobile Number")) &
                              " " & dataread(dataread.GetOrdinal("Email id")) & " ")

        End While

        connection.Close()
        Console.WriteLine("Connection Closed Successfully")
        Console.ReadKey()
    End Sub

End Module
