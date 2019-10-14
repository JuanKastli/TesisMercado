
Imports System.Data
Imports System.Data.SqlClient
Public Class ClientesClass
    Dim Id_, telefono_ As Integer
    Dim nombre_, apellido_, direccion_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property telefono() As Integer
        Get
            Return telefono_
        End Get
        Set(ByVal value As Integer)
            telefono_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property apellido() As String
        Get
            Return apellido_
        End Get
        Set(ByVal value As String)
            apellido_ = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property


    Public Sub Agregar(ByVal clientes As ClientesClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ClientesAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@Id", clientes.Id)
            objComando.Parameters.AddWithValue("@nombre", clientes.nombre)
            objComando.Parameters.AddWithValue("@apellido", clientes.apellido)
            objComando.Parameters.AddWithValue("@direccion", clientes.direccion)
            objComando.Parameters.AddWithValue("@telefono", clientes.telefono)

            If objComando.ExecuteNonQuery Then

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal clientes As ClientesClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("clientesModificar", conex.sqlconexion)
        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id", clientes.Id)
        sqlComando.Parameters.AddWithValue("@nombre", clientes.nombre)
        sqlComando.Parameters.AddWithValue("@apellido", clientes.apellido)
        sqlComando.Parameters.AddWithValue("@direccion", clientes.direccion)
        sqlComando.Parameters.AddWithValue("@telefono", clientes.telefono)

        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub


    Public Sub Eliminar(ByVal au_id As String)

        Dim conex As New Conexion
        conex.abrir()

        Dim sqlComando As New SqlCommand("clientesEliminar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@Id", Id)
        Try
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub
End Class
