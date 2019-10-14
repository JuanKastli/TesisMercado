Imports System.Data
Imports System.Data.SqlClient

Public Class RubroClass

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

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("rubroAgregar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        'sqlComando.Parameters.AddWithValue("@id", Rubro.id)
        sqlComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)
        

        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub

    Public Sub Modificar(ByVal Rubro As RubroClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("rubroModificar", conex.sqlconexion)
        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@id", Rubro.id)
        sqlComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)


        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub

    Public Sub Eliminar(ByVal id As String)

        Dim conex As New Conexion
        conex.abrir()

        Dim sqlComando As New SqlCommand("rubroEliminar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@id", id)
        Try
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub




End Class
