
Imports System.Data
Imports System.Data.SqlClient
Public Class Gastos
    Dim Id_, Nfactura_ As Integer
    Dim Monto_ As Decimal
    Dim Fecha_ As Date
    Dim Descripcion_ As String



    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nfactura() As Integer
        Get
            Return Nfactura_
        End Get
        Set(ByVal value As Integer)
            Nfactura_ = value
        End Set
    End Property
   
    Public Property Monto() As Decimal
        Get
            Return Monto_
        End Get
        Set(ByVal value As Decimal)
            Monto_ = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property


    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property


    'Public Property Fechapago() As Date
    '    Get
    '        Return Fechapago_
    '    End Get
    '    Set(ByVal value As Date)
    '        Fechapago_ = value
    '    End Set
    'End Property


    Public Sub Agregar(ByVal gasto As Gastos)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("GastosAgregar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@fecha", gasto.Fecha)
        sqlComando.Parameters.AddWithValue("@Nro_factura", gasto.Nfactura)
        sqlComando.Parameters.AddWithValue("@descripcion", gasto.descripcion)
        sqlComando.Parameters.AddWithValue("@monto", gasto.Monto)

        sqlComando.ExecuteNonQuery()
        conex.cerrar()

    End Sub

End Class
