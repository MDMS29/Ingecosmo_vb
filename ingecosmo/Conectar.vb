Imports MySql.Data.MySqlClient
Module Conectar
    Public con As String = "Server=localhost; database=db_ingecosmo; User ID=ingecosmos; Password=;"
    Public mycon As MySqlConnection = New MySqlConnection(con)
    Public rs As MySqlCommand = New MySqlCommand

    Public Function conexion() As Boolean
        Try
            mycon.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
            Return False
        End Try
    End Function

End Module
