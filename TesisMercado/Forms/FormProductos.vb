Imports System.Data
Imports System.Data.SqlClient

Public Class FormProductos

    Dim Producto As New productosClass


    Private Sub FormProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Producto.ConsultarProducto(dgvProductos)

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        Producto.Id = dgvProductos.Item("Id", dgvProductos.CurrentRow.Index).Value
        Producto.nombre = dgvProductos.Item("nombre", dgvProductos.CurrentRow.Index).Value
        Producto.cantidad = dgvProductos.Item("cantidad", dgvProductos.CurrentRow.Index).Value
        Producto.Precio = dgvProductos.Item("Precio", dgvProductos.CurrentRow.Index).Value
        Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class