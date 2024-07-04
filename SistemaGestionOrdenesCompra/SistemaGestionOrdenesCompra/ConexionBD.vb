Imports System.Data.SqlClient

Public Class ConexionBD
    Private server As String = "SAVITAR\SQLEXPRESS"
    Private database As String = "gestionOrdenCompra"
    Private userId As String = "sa"
    Private password As String = "1234"
    Private connection As SqlConnection

    ' Construir la cadena de conexión
    Private Function GetConnectionString(Optional ByVal autenticacion As Boolean = False) As String
        If (autenticacion) Then
            Return $"Server={server};Database={database};User Id={userId};Password={password};"
        Else
            Return $"Server={server};Database={database};Integrated Security=True;"
        End If

    End Function

    ' Obtener una conexión abierta
    Public Function GetOpenConnection() As SqlConnection
        connection = New SqlConnection(GetConnectionString())
        Try
            connection.Open()
        Catch ex As Exception
            Throw New Exception("Error al abrir la conexión: " & ex.Message)
        End Try
        Return connection
    End Function

    ' Cerrar la conexión
    Public Sub CloseConnection()
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Class
