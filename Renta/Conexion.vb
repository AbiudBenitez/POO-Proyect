Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub Abrir()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-7FNTPKS;Initial Catalog=Renta;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se ha podido realizar la conexión con la base de datos", MsgBoxStyle.Critical, "Conexion con Base de Datos" + ex.ToString)
            End
        End Try
    End Sub

    Function ValidarUsua(ByVal usuario As String) As Boolean
        Dim res As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuarios where nomid_usua ='" & usuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                res = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return res
    End Function

    Function ValidarCont(ByVal usuario As String) As String
        Dim res As String = ""
        Try
            enunciado = New SqlCommand("Select conid_usua from Usuarios where nomid_usua ='" & usuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                res = respuesta.Item("conid_usua")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return res
    End Function
End Module
