﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIdVenta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboComprobante = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtIdComprobante = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.labelPrecio = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIdProducto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dgvventadetalle = New System.Windows.Forms.DataGridView
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvventadetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnEliminar.Location = New System.Drawing.Point(672, 373)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 55)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCancelar.Location = New System.Drawing.Point(672, 483)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 39)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(146, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Fecha de Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(178, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Id Cliente"
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(85, 37)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.ReadOnly = True
        Me.txtIdVenta.Size = New System.Drawing.Size(47, 20)
        Me.txtIdVenta.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Id Venta"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAceptar.Location = New System.Drawing.Point(4, 483)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(177, 39)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Imprimir"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.CmbCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 116)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Venta"
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(235, 32)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(203, 21)
        Me.CmbCliente.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(235, 73)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker2.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.ComboComprobante)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtIdComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(463, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 107)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Factura"
        '
        'ComboComprobante
        '
        Me.ComboComprobante.FormattingEnabled = True
        Me.ComboComprobante.Location = New System.Drawing.Point(167, 64)
        Me.ComboComprobante.Name = "ComboComprobante"
        Me.ComboComprobante.Size = New System.Drawing.Size(127, 21)
        Me.ComboComprobante.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(52, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Tipo de Comprobante"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(81, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "id comprobante"
        '
        'txtIdComprobante
        '
        Me.txtIdComprobante.Enabled = False
        Me.txtIdComprobante.Location = New System.Drawing.Point(167, 28)
        Me.txtIdComprobante.Name = "txtIdComprobante"
        Me.txtIdComprobante.ReadOnly = True
        Me.txtIdComprobante.Size = New System.Drawing.Size(47, 20)
        Me.txtIdComprobante.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Controls.Add(Me.TxtPrecio)
        Me.GroupBox4.Controls.Add(Me.labelPrecio)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtIdProducto)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(788, 129)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Productos"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(569, 61)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(72, 20)
        Me.TxtPrecio.TabIndex = 44
        '
        'labelPrecio
        '
        Me.labelPrecio.AutoSize = True
        Me.labelPrecio.Location = New System.Drawing.Point(526, 64)
        Me.labelPrecio.Name = "labelPrecio"
        Me.labelPrecio.Size = New System.Drawing.Size(37, 13)
        Me.labelPrecio.TabIndex = 43
        Me.labelPrecio.Text = "Precio"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(566, 98)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 20)
        Me.txtCantidad.TabIndex = 42
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAgregar.Location = New System.Drawing.Point(658, 42)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 55)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnBuscar.Location = New System.Drawing.Point(10, 43)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 55)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar Producto"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(511, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(390, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Codigo"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(436, 61)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(75, 20)
        Me.txtIdProducto.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(138, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(207, 61)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(177, 20)
        Me.txtDescripcion.TabIndex = 26
        '
        'dgvventadetalle
        '
        Me.dgvventadetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvventadetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventadetalle.Location = New System.Drawing.Point(4, 246)
        Me.dgvventadetalle.Name = "dgvventadetalle"
        Me.dgvventadetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvventadetalle.Size = New System.Drawing.Size(659, 182)
        Me.dgvventadetalle.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(12, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Total a Pagar"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(411, 438)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(69, 20)
        Me.TextBox8.TabIndex = 47
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(89, 438)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(67, 20)
        Me.txtTotal.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(300, 441)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 49
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(257, 438)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(168, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Dinero Recibido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(339, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Vuelto a Dar"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(476, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 39)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(796, 534)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvventadetalle)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvventadetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvventadetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ComboComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIdComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents labelPrecio As System.Windows.Forms.Label
End Class
