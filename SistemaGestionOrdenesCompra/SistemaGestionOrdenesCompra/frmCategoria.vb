Imports System.Data.SqlClient

Public Class frmCategoria

    Dim conexion As New ConexionBD()
    Dim idCategoriaSelect As Integer


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim nombre As String = txtNombreCat.Text
        Dim desc As String = txtDescripcionCat.Text

        RegistrarCategoriaDirecto(nombre, desc)
        'RegistrarCategoriaSP(nombre, desc)

    End Sub

    Private Sub RegistrarCategoriaDirecto(ByVal nombre As String, ByVal desc As String)
        ' Obtener una conexión abierta
        Dim connection As SqlConnection = conexion.GetOpenConnection()
        Try
            ' Ejecutar un comando SQL
            Dim query As String = "INSERT INTO Categoria (nombre, descripcion) VALUES (@nombre, @descripcion)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", desc)
                command.ExecuteNonQuery()
            End Using

            MsgBox("Categoría agregada con éxito!", "Registro")

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            conexion.CloseConnection()
        End Try

    End Sub

    Private Sub RegistrarCategoriaSP(ByVal nombre As String, ByVal desc As String)
        ' Obtener una conexión abierta
        Dim connection As SqlConnection = conexion.GetOpenConnection()
        Try
            ' Ejecutar el procedimiento almacenado
            Using command As New SqlCommand("InsertarCategoria", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", desc)
                command.ExecuteNonQuery()
            End Using

            MsgBox("Categoría agregada con éxito!", "Registro")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            conexion.CloseConnection()
        End Try
    End Sub

    Private Sub ConsultarCategorias()
        ' Obtener una conexión abierta
        Dim connection As SqlConnection = conexion.GetOpenConnection()
        Try
            ' Obtener una conexión abierta
            connection = conexion.GetOpenConnection()

            ' Crear un comando para ejecutar el procedimiento almacenado
            Using command As New SqlCommand("ObtenerCategorias", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Ejecutar el comando y llenar un DataTable con los resultados
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                dgvDatos.DataSource = dataTable

            End Using

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión
            If connection IsNot Nothing Then
                conexion.CloseConnection()
            End If
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarCategorias()

    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        ' Verificar que la fila sea válida
        If e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = dgvDatos.Rows(e.RowIndex)

            ' Cargar los datos en los TextBox
            idCategoriaSelect = Integer.Parse(selectedRow.Cells("id").Value.ToString())
            txtNombreCat.Text = selectedRow.Cells("nombre").Value.ToString()
            txtDescripcionCat.Text = selectedRow.Cells("descripcion").Value.ToString()

            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim nombre As String = txtNombreCat.Text
        Dim desc As String = txtDescripcionCat.Text

        ModificarCategoria(idCategoriaSelect, nombre, desc)
    End Sub

    Private Sub ModificarCategoria(ByVal id As Integer, ByVal nombre As String, ByVal desc As String)
        ' Obtener una conexión abierta
        Dim connection As SqlConnection = conexion.GetOpenConnection()
        Try
            ' Ejecutar el procedimiento almacenado
            Using command As New SqlCommand("ActualizarCategoria", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", desc)
                command.ExecuteNonQuery()
            End Using

            MsgBox("Categoría modificada con éxito!", "Modificación")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            conexion.CloseConnection()
        End Try

        ' Actualizar la lista de categorías
        ConsultarCategorias()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarCategoria(idCategoriaSelect)
    End Sub

    Private Sub EliminarCategoria(ByVal id As Integer)
        ' Obtener una conexión abierta
        Dim connection As SqlConnection = conexion.GetOpenConnection()
        Try
            ' Ejecutar el procedimiento almacenado
            Using command As New SqlCommand("EliminarCategoria", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()
            End Using

            MsgBox("Categoría eliminada con éxito!", "Eliminación")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            conexion.CloseConnection()
        End Try

        ' Actualizar la lista de categorías
        ConsultarCategorias()
    End Sub
End Class