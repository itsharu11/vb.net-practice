﻿Imports System.Data.OleDb
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
        'Read all the data from the table 
        While dataread.Read
            Console.WriteLine(dataread("ID") & " " & dataread("Name") & " " & dataread("Address") & " " & dataread("Mobile Number") & " " & dataread("Email id") & " ")
        End While

        connection.Close()
        Console.WriteLine("Connection Closed Successfully")
        Console.ReadKey()

    End Sub

End Module
