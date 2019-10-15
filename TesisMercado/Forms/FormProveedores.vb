
'Imports System.Data
'Imports System.Data.SqlClient
'Public Class FormProveedores
'    Inherits Conexion
'    Dim proveedor As New ProveedoresClass

'    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
'        Dim FormProveedoresDetalle As New FormProveedoresDetalle

'        FormProveedoresDetalle.ShowDialog()
'        LlenarTabla(DataGridView1)

'    End Sub

'    Private Sub FormProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        LlenarTabla(DataGridView1)

'    End Sub
'    Private Sub LlenarTabla(ByVal tabla As DataGridView)
'        Try
'            Abrir()

'            Dim strComando As String = "proveedoresLlenarTabla"


'            Dim sqlComando As New SqlCommand("proveedoresLlenarTabla", objConexion)


'            sqlComando.CommandType = CommandType.StoredProcedure


'            Dim sqlAdapter As New SqlDataAdapter(sqlComando)
'            Dim sqlDataTable As New DataTable

'            sqlAdapter.Fill(sqlDataTable)
'            tabla.DataSource = sqlDataTable
'            tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'            tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'            tabla.Columns("Localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        Finally
'            Cerrar()
'        End Try

'    End Sub
'    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

'        proveedor.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
'        proveedor.Nombre = DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value
'        proveedor.Direccion = DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value
'        proveedor.Localidad = DataGridView1.Item("Localidad", DataGridView1.CurrentRow.Index).Value
'        proveedor.Telefono = DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value



'        Dim FormProveedorDetalle As New FormProveedoresDetalle(proveedor)
'        FormProveedorDetalle.ShowDialog()
'        LlenarTabla(DataGridView1)

'    End Sub

'    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
'        Proveedor.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
'        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Proveedor.Id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
'        If respuesta = Windows.Forms.DialogResult.OK Then

'            Proveedor.Eliminar(Proveedor.Id)
'            LlenarTabla(DataGridView1)

'        End If

'    End Sub

'    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
'        Close()
'    End Sub
'End Class