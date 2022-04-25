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


        Dim query As String
        'Dim dataread As OleDbDataReader
        query = "select * from customer"
        'Define command object dynamic
        Dim cmd As New OleDbCommand(query, connection)

        Dim da1 As New OleDbDataAdapter()
        Console.WriteLine("Default data adapter")
        da1.SelectCommand = cmd
        Dim da2 As New OleDbDataAdapter(cmd)
        Console.WriteLine("passing oledb command object")
        Dim da3 As New OleDbDataAdapter(query, connection)   '  COMMONLY USED OBJECT
        Console.WriteLine("Passing query and connection")
        Dim da4 As New OleDbDataAdapter(query, con)
        Console.WriteLine("Passing query and connection string ")

        ' CREATING DATA SET OBJECT USING FILL METHOD
        Dim data_set As New DataSet()
        da3.Fill(data_set, "cusotmer")
        Console.WriteLine("data adapter filled")



        'CREATE DATA TABLE TO RETRIEVE DATA
        Dim data_table As New DataTable("customer")
        da3.Fill(data_table)


        connection.Close()
        Console.WriteLine("Connection Closed Successfully")
        Console.ReadKey()
    End Sub

End Module
