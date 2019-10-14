
Imports System.Data
Imports System.Data.SqlClient
Public Class UsuariosClass

    Dim NyA_, TdeUsuario_ As String
    Dim Id_Usuario_, Password_, Direccion_, Tel_ As Integer
    Dim FdeN_ As Date


    Public Property Id_Usuario() As Integer
        Get
            Return Id_Usuario_
        End Get
        Set(ByVal value As Integer)
            Id_Usuario_ = value
        End Set
    End Property


    Public Property NyA() As String
        Get
            Return NyA_
        End Get
        Set(ByVal value As String)
            NyA_ = value
        End Set
    End Property


    Public Property Password() As Integer
        Get
            Return Password_
        End Get
        Set(ByVal value As Integer)
            Password_ = value
        End Set
    End Property

    Public Property TdeUsuario() As String
        Get
            Return TdeUsuario_
        End Get
        Set(ByVal value As String)
            TdeUsuario_ = value
        End Set
    End Property

    Public Property FdeN() As Date
        Get
            Return FdeN_
        End Get
        Set(ByVal value As Date)
            FdeN_ = value
        End Set
    End Property


    Public Property Direccion() As Integer
        Get
            Return Direccion_
        End Get
        Set(ByVal value As Integer)
            Direccion_ = value
        End Set
    End Property


    Public Property Tel() As Integer
        Get
            Return Tel_
        End Get
        Set(ByVal value As Integer)
            Tel_ = value
        End Set
    End Property



    Public Sub Agregar(ByVal Usuario As UsuariosClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("UsuariosAgregar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure


        sqlComando.Parameters.AddWithValue("@NyA", Usuario.NyA)
        sqlComando.Parameters.AddWithValue("@Password", Usuario.Password)
        sqlComando.Parameters.AddWithValue("@TdeUsuario", Usuario.TdeUsuario)
        sqlComando.Parameters.AddWithValue("@FdeN", Usuario.FdeN)
        sqlComando.Parameters.AddWithValue("@Direccion", Usuario.Direccion)
        sqlComando.Parameters.AddWithValue("@Tel", Usuario.Tel)

        sqlComando.ExecuteNonQuery()
        conex.cerrar()

    End Sub

    Public Sub Modificar(ByVal Usuario As UsuariosClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("UsuariosModificar", conex.sqlconexion)
        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id_Usuario", Usuario.Id_Usuario)
        sqlComando.Parameters.AddWithValue("@NyA", Usuario.NyA)
        sqlComando.Parameters.AddWithValue("@Password", Usuario.Password)
        sqlComando.Parameters.AddWithValue("@TdeUsuario", Usuario.TdeUsuario)
        sqlComando.Parameters.AddWithValue("@FdeN", Usuario.FdeN)
        sqlComando.Parameters.AddWithValue("@Direccion", Usuario.Direccion)
        sqlComando.Parameters.AddWithValue("@Tel", Usuario.Tel)

        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub


    Public Sub Eliminar(ByVal Id_Usuario As Integer)

        Dim conex As New Conexion
        conex.abrir()

        Dim sqlComando As New SqlCommand("UsuariosEliminar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario)
        Try
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

End Class
