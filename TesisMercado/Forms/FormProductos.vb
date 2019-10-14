Imports System.Data
Imports System.Data.SqlClient

Public Class FormProductos

    Dim Producto As New productosClass
    Dim conex As New Conexion

    Private Sub FormProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarTabla(DataGridView1)

    End Sub

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "productosLlenarTabla"


        Dim sqlComando As New SqlCommand("productosLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable


      
        tabla.Columns("precio_venta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim FormProductosDetalle As New FormProductosDetalle

        FormProductosDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        Producto.unidad = DataGridView1.Item("unidad", DataGridView1.CurrentRow.Index).Value
        Producto.codigo = DataGridView1.Item("codigo", DataGridView1.CurrentRow.Index).Value
        Producto.Precio = DataGridView1.Item("Precio", DataGridView1.CurrentRow.Index).Value
        Producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
        'Producto.id_Rubro = DataGridView1.Item("id_Rubro", DataGridView1.CurrentRow.Index).Value
        Producto.Ganancia = DataGridView1.Item("Ganancia", DataGridView1.CurrentRow.Index).Value
        Producto.precio_venta = DataGridView1.Item("precio_venta", DataGridView1.CurrentRow.Index).Value



        Dim FormProductosDetalle As New FormProductosDetalle(Producto)
        FormProductosDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Producto.Id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            Producto.Eliminar(Producto.Id)
            LlenarTabla(DataGridView1)

        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class