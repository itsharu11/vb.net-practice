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

        Dim da3 As New OleDbDataAdapter(query, connection)   '  COMMONLY USED OBJECT
        Console.WriteLine("Passing query and connection")

        ' CREATING DATA SET OBJECT USING FILL METHOD
        Dim data_set As New DataSet()
        da3.Fill(data_set, "cusotmer")
        Console.WriteLine("data adapter filled")



        'CREATE DATA TABLE TO RETRIEVE DATA
        Dim data_table As DataTable = data_set.Tables(0)
        Console.WriteLine("column information for " & data_table.TableName)
        For Each col In data_table.Columns
            Console.WriteLine("  " & col.columnName & " - " & col.DataType.ToString())
        Next

        'DATA ROW
        Dim data_row As DataRow = data_table.Rows(0)
        Console.WriteLine(" Id " & data_row("ID"))
        Console.WriteLine(" Name " & data_row("Name"))
        Console.WriteLine(" Address " & data_row("Address"))
        Console.WriteLine("Mobile Number" & data_row("Mobile Number"))
        Console.WriteLine(" Email Id " & data_row("Email Id"))
        Console.WriteLine("-------------------------------------------------------------------------")

        connection.Close()
        Console.WriteLine("Connection Closed Successfully")
        Console.ReadKey()
    End Sub

End Module
