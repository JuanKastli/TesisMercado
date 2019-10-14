Imports System.Data
Imports System.Data.SqlClient
Public Class ventaClass

    Dim Id_, nro_ticket_, id_cliente_, CantDeP_, Total_ As Integer
    Dim fecha_ As DateTime

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property nro_ticket() As Integer
        Get
            Return nro_ticket_
        End Get
        Set(ByVal value As Integer)
            nro_ticket_ = value
        End Set
    End Property

    Public Property id_cliente() As Integer
        Get
            Return id_cliente_
        End Get
        Set(ByVal value As Integer)
            id_cliente_ = value
        End Set
    End Property
    Public Property CantDeP() As Integer
        Get
            Return CantDeP_
        End Get
        Set(ByVal value As Integer)
            CantDeP_ = value
        End Set
    End Property
    Public Property Total() As Integer
        Get
            Return Total_
        End Get
        Set(ByVal value As Integer)
            Total_ = value
        End Set
    End Property

    Public Property fecha() As DateTime
        Get
            Return fecha_
        End Get
        Set(ByVal value As DateTime)
            fecha_ = value
        End Set
    End Property




End Class
