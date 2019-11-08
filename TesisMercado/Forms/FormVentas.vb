Imports System.Data
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
    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        txtCantDeProd.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
        txtTotal.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())


    End Sub

    Dim ventas As New ventaClass
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        For Each ventas As DataGridViewRow In DataGridView1.SelectedRows
            Dim venta As New ventaClass

            venta.Id = ventas.Cells("id").Value
            'venta.nombre = ventas.Cells("nombre").Value
            'venta.cantidad = ventas.Cells("cantidad").Value
            pro.Precio = ventas.Cells("Precio").Value



            '    Dim productosSeleccionados As New List(Of productosClass)
            '    Dim lstProductos As New LstProductos(productosSeleccionados)
            '    lstProductos.ShowDialog()
            '    Venta.lis()

            '    .listaAlumnosMaterias(materia.id, alumnosSeleccionados, dgvAlumnosMateria)
        Next



    End Sub

End Class