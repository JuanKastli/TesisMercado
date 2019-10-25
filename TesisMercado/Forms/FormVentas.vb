Imports System.Data
Imports System.Data.SqlClient

Public Class FormVentas

    Dim Venta As New ventaClass
    Private comprobante As New FacturacionClass
    Private pro As New productosClass
    Private vent_ As ventaClass
    Private esNuevo_ As Boolean


    Private Property vent() As ventaClass
        Get
            Return vent_

        End Get
        Set(ByVal value As ventaClass)
            vent_ = value
        End Set
    End Property

    Public Property esNuevo() As Boolean
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Boolean)
            esNuevo_ = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtIdVenta.Text = Venta.Id
        txtIdComprobante.Text = comprobante.id


        txtDescripcion.Text = pro.nombre
        txtIdProducto.Text = pro.Id
        txtCantidad.Text = pro.cantidad



    End Sub

    Public Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        Dim FormProductos As New FormProductos

        FormProductos.ShowDialog()


        ' txtIdProducto.Text = FormProductos.producto.Id
        ' txtDescripcion.Text = FormProductos.producto.nombre



    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        txtCantDeProd.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
        txtTotal.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())


    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

    End Sub
End Class