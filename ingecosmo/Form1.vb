Imports System.Data
Imports System.Reflection
Imports MySql.Data.MySqlClient
Public Class Form1
    Private conex
    Dim user As String
    Dim pass As String
    Private Sub Btn_entra_Click_1(sender As Object, e As EventArgs) Handles Btn_entra.Click
        Try
            user = Text_usuario.Text
            pass = Text_contra.Text

            If Conectar.conexion() Then
                MessageBox.Show("Se ha conectado")
                Hide()
                principal.Show()
            End If
        Catch ex As Exception

        End Try


    End Sub
End Class
