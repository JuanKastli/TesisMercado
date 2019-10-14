Imports System.Data
Imports System.Data.SqlClient

Public Class FormRubro

    Dim Rubro As New RubroClass
    Dim conex As New Conexion

    Private Sub FormRubro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarTabla(DataGridView1)

    End Sub


    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "rubroLlenarTabla"


        Dim sqlComando As New SqlCommand("rubroLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable

        tabla.Columns("nombreRubro").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FormRubroDetalle As New FormRubroDetalle

        FormRubroDetalle.ShowDialog()
        LlenarTabla(DataGridView1)

    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

      
        Rubro.id = DataGridView1.Item("id", DataGridView1.CurrentRow.Index).Value

        Rubro.nombreRubro = DataGridView1.Item("nombreRubro", DataGridView1.CurrentRow.Index).Value


        Dim FormRubroDetalle As New FormRubroDetalle(Rubro)
        FormRubroDetalle.ShowDialog()
        LlenarTabla(DataGridView1)


    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Rubro.id = DataGridView1.Item("id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Rubro.id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            Rubro.Eliminar(Rubro.id)
            LlenarTabla(DataGridView1)

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class