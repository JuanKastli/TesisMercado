﻿Imports System.Data
Imports System.Data.SqlClient

Public Class FormVentas

    Dim Venta As New ventaClass
    Private comprobante As New FacturacionClass
    Private pro As New productosClass
    Private vent_ As ventaClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones


    Private Property vent() As ventaClass
        Get
            Return vent_

        End Get
        Set(ByVal value As ventaClass)
            vent_ = value
        End Set
    End Property

    Public Property esNuevo() As Boolean
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Boolean)
            esNuevo_ = value
        End Set
    End Property

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim pro As New productosClass

        pro.Id = 0
        pro.nombre = ""
        pro.Precio = 0
        'pro.cantidad = 1

        esNuevo = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub
    Dim idCliente As New ClientesClass
    Dim idComprobante As New ComprobantesClass
    Dim listaDetalles As New List(Of VentaDetalles)

    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtIdVenta.Text = Venta.Id
        idCliente.CargarComboCliente(CmbCliente)
        CmbCliente.SelectedValue = Venta.id_cliente

        idComprobante.CargarComboComprobante(ComboComprobante)
        ComboComprobante.SelectedValue = Venta.id_comprobante


        txtDescripcion.Text = pro.nombre
        txtIdProducto.Text = pro.Id
        txtCantidad.Text = pro.cantidad




    End Sub

    Public Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim FormLstProductos As New FormLstProductos(txtDescripcion.Text, txtIdProducto.Text)
        FormLstProductos.ShowDialog()
        txtIdProducto.Text = FormLstProductos.producto.Id
        txtDescripcion.Text = FormLstProductos.producto.nombre
        TxtPrecio.Text = FormLstProductos.producto.Precio
    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvventadetalle.CellContentClick


        'txtCantDeProd.Text = Convert.ToString(dgvventadetalle.Rows(e.RowIndex).Cells(0).Value.ToString())
        txtTotal.Text = Convert.ToString(dgvventadetalle.Rows(e.RowIndex).Cells(1).Value.ToString())


    End Sub

    Dim ventas As New ventaClass
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim vendeta As New VentaDetalles
        vendeta.idProducto = txtIdProducto.Text
        vendeta.cantidad = txtCantidad.Text
        vendeta.monto = TxtPrecio.Text
        vendeta.producto = txtDescripcion.Text
        vendeta.paraBorrar = False
        vendeta.agregaraLista(vendeta, dgvventadetalle)
        txtTotal.Text = vendeta.calcularTotal(dgvventadetalle)





    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        For Each vendeta As DataGridViewRow In dgvventadetalle.SelectedRows

            vendeta.Cells("paraBorrar").Value = True
            dgvventadetalle.CurrentCell = Nothing
            vendeta.Visible = False

        Next
    End Sub
End Class