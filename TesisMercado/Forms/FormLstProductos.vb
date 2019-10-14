Imports System.Data
Imports System.Data.SqlClient
Public Class FormLstProductos

    Private producto As New productosClass

    Private Sub FormLstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        producto.ConsultarProducto(DataGridView1)

    End Sub

    'Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

    '    Dim ProduProveForm As New ProduProveForm()
    '    ProduProveForm.ShowDialog()
    '    producto.ConsultarProducto(DataGridView1)

    'End Sub

    'Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
    '    producto.Id = DataGridView1.Item("id", DataGridView1.CurrentRow.Index).Value
    '    Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar  " & producto.id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
    '    If respuesta = Windows.Forms.DialogResult.OK Then
    '        producto.Borrar(producto)
    '    End If
    '    producto.ConsultarProducto(DataGridView1)
    'End Sub

    'Public Sub ModificarProducto()
    '    producto.Id = DataGridView1.Item("id", DataGridView1.CurrentRow.Index).Value
    '    producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
    '    producto.codigo = DataGridView1.Item("codigo", DataGridView1.CurrentRow.Index).Value
    '    producto.unidad = DataGridView1.Item("unidad", DataGridView1.CurrentRow.Index).Value
    '    producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
    '    producto.Precio = DataGridView1.Item("precio", DataGridView1.CurrentRow.Index).Value

    '    Dim ProduProveForm As New ProduProveForm(producto)
    '    ProduProveForm.ShowDialog()
    '    producto.ConsultarProducto(DataGridView1)

    'End Sub

    'Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    '    ModificarProducto()
    'End Sub

    'Private Sub dgvProductos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
    '    ModificarProducto()
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class