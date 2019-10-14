Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionClass

    Dim id_ As Integer
    Dim TdeComprobante_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property TdeComprobante() As String
        Get
            Return TdeComprobante_
        End Get
        Set(ByVal value As String)
            TdeComprobante_ = value
        End Set
    End Property

End Class
