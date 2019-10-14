
Imports System.Data
Imports System.Data.SqlClient
Public Class FormUsuarios

    Dim Usuario As New UsuariosClass
    Dim conex As New Conexion

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "UsuariosLlenarTabla"


        Dim sqlComando As New SqlCommand("UsuariosLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable

        'tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub

    Private Sub FormUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarTabla(DataGridView1)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FormUsuariosDetalle As New FormUsuariosDetalle

        FormUsuariosDetalle.ShowDialog()
        LlenarTabla(DataGridView1)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click



        Usuario.Id_Usuario = DataGridView1.Item("Id_Usuario", DataGridView1.CurrentRow.Index).Value
        Usuario.NyA = DataGridView1.Item("NyA", DataGridView1.CurrentRow.Index).Value
        Usuario.Password = DataGridView1.Item("Password", DataGridView1.CurrentRow.Index).Value
        Usuario.TdeUsuario = DataGridView1.Item("TdeUsuario", DataGridView1.CurrentRow.Index).Value
        Usuario.Direccion = DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value
        Usuario.Tel = DataGridView1.Item("Tel", DataGridView1.CurrentRow.Index).Value

        Dim FormUsuariosDetalle As New FormUsuariosDetalle(Usuario)
        FormUsuariosDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Usuario.Id_Usuario = DataGridView1.Item("Id_Usuario", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Usuario.Id_Usuario.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            Usuario.Eliminar(Usuario.Id_Usuario)
            LlenarTabla(DataGridView1)

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class