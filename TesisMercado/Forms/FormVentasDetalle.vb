
Imports System.Data
Imports System.Data.SqlClient
Public Class FormVentasDetalle

    Dim Ventas As New ventaClass
    Dim conex As New Conexion

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        FormVentas.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "VentasLlenarTabla"


        Dim sqlComando As New SqlCommand("VentasLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable

        'tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub


    Private Sub FormVentasDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LlenarTabla(DataGridView1)

    End Sub
End Class