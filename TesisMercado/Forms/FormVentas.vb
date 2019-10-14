Imports System.Data
Imports System.Data.SqlClient

Public Class FormVentas

    Dim Venta As New ventaClass
    Private comprobante As New FacturacionClass
    Private pro As New productosClass
    Dim conex As New Conexion
    Private vent_ As ventaClass
    Private esNuevo_ As Boolean


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

    'Public Sub New()
    '    InitializeComponent()

    '    Dim ventaPro As New productosClass

    '    ventaPro.Id = ""
    '    ventaPro.nombre = ""
    '    ventaPro.cantidad = ""


    '    vent_ = vent
    '    esNuevo = True

    'End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtIdVenta.Text = Venta.Id
        txtIdComprobante.Text = comprobante.id


        txtDescripcion.Text = pro.nombre
        txtIdProducto.Text = pro.Id
        txtCantidad.Text = pro.cantidad



    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click



        Dim FormLstProductos As New FormLstProductos

        FormLstProductos.ShowDialog()


        txtIdProducto.Text = FormLstProductos.producto.Id
        txtDescripcion.Text = FormLstProductos.producto.nombre


    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        txtCantDeProd.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
        txtTotal.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())


    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click



        'Dim pro As New productosClass


        'pro.Id = txtIdProducto.Text
        'pro.nombre = txtDescripcion.Text
        'pro.cantidad = txtCantidad.Text

        'If esNuevo Then

        '    pro.Agregar(pro)

        '    Close()

        'End If

    End Sub
End Class