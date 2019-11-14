﻿Imports System.Data
Imports System.Data.SqlClient
Public Class ventaClass

    Inherits Conexion
    Dim Id_, id_cliente_, id_comprobante_, CantDeP_, Total_ As Integer
    Dim TdeComprobante_ As String
    Dim fecha_ As DateTime

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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

    Public Property TdeComprobante() As String
        Get
            Return TdeComprobante_
        End Get
        Set(ByVal value As String)
            TdeComprobante_ = value
        End Set
    End Property
    Public Property id_comprobante() As Integer
        Get
            Return id_comprobante_
        End Get
        Set(ByVal value As Integer)
            id_comprobante_ = value
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

    Public Sub VentasLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("VentasLlenarTabla", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    'listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    'listado.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                Else
                    listado.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try

    End Sub




End Class