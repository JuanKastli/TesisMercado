Imports System.Data
Imports System.Data.SqlClient
Public Class FormGastos

    Dim gasto As New Gastos

    Private Sub FormGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarTabla(DataGridView1)
    End Sub


    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "gastosLlenarTabla"


        Dim sqlComando As New SqlCommand("gastosLlenarTabla", objConexion)


        sqlComando.CommandType = CommandType.StoredProcedure


        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable

        ' tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub


   
    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()

    End Sub


End Class