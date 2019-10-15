Imports System.Data
Imports System.Data.SqlClient

Public Class RubroClass
    Inherits Conexion
    Dim id_ As Integer
    Dim nombreRubro_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombreRubro() As String
        Get
            Return nombreRubro_
        End Get
        Set(ByVal value As String)
            nombreRubro_ = value
        End Set
    End Property


    Public Sub Agregar(ByVal Rubro As RubroClass)
        Try
            Abrir()


            Dim objComando As New SqlCommand("rubroAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@id", Rubro.id)
            objComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)


            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal Rubro As RubroClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("rubroModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@id", Rubro.id)
            objComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)


            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Eliminar(ByVal id As String)

        Try
            Abrir()

            Dim sqlComando As New SqlCommand("rubroEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@id", id)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub




End Class
