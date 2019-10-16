Imports System.Data
Imports System.Data.SqlClient
Public Class FormGastos

    Dim gasto As New Gastos

    Private Sub FormGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Gastos.GastosConsultar(DataGridView1)
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