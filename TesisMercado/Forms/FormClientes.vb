
Imports System.Data
Imports System.Data.SqlClient

Public Class FormClientes

    Dim Clientes As New ClientesClass
    Dim conex As New Conexion

    Private Sub FormClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarTabla(DataGridView1)

    End Sub

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "clientesLlenarTabla"


        Dim sqlComando As New SqlCommand("clientesLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable

        tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim FormClientesDetalle As New FormClientesDetalle

        FormClientesDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Clientes.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Clientes.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        Clientes.apellido = DataGridView1.Item("apellido", DataGridView1.CurrentRow.Index).Value
        Clientes.direccion = DataGridView1.Item("direccion", DataGridView1.CurrentRow.Index).Value
        Clientes.telefono = DataGridView1.Item("telefono", DataGridView1.CurrentRow.Index).Value

        Dim FormClientesDetalle As New FormClientesDetalle(clientes)
        FormClientesDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Clientes.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Clientes.Id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            Clientes.Eliminar(Clientes.Id)
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

