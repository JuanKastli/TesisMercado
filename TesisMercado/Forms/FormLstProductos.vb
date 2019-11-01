Imports System.Data
Imports System.Data.SqlClient

Public Class FormLstProductos


    Private producto_ As New productosClass

    Public Property producto() As productosClass
        Get
            Return producto_
        End Get
        Set(ByVal value As productosClass)
            producto_ = value
        End Set
    End Property

    Dim Pro As New productosClass

    Private Sub FormLstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        producto.ConsultarProducto(DataGridView1)

    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
        producto.Precio = DataGridView1.Item("Precio", DataGridView1.CurrentRow.Index).Value
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

End Class