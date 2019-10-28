﻿
Imports System.Data
Imports System.Data.SqlClient
Public Class FormClientesDetalle

    Private pro_ As ClientesClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Private Property pro() As ClientesClass

        Get
            Return pro_

        End Get
        Set(ByVal value As ClientesClass)
            pro_ = value
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

    'constructor para modificar
    Public Sub New(ByVal pro As ClientesClass)
        InitializeComponent()
        pro_ = pro
        esNuevo = False
    End Sub

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim pro As New ClientesClass

        pro.nombre = ""
        pro.apellido = ""
        pro.direccion = Nothing
        pro.telefono = Nothing
        pro.CuentaTotal = 0
        pro.habilitado = Nothing

        pro_ = pro
        esNuevo = True
    End Sub


    Private Sub FormClientesDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtId.Text = pro.Id
        txtNombre.Text = pro.nombre
        txtApellido.Text = pro.apellido
        txtDireccion.Text = pro.direccion
        txtTelefono.Text = pro.telefono
        txtCuentaTotal.Text = pro.CuentaTotal

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If func.validarCampos(Me, ErrorProvider1) Then


            Dim pro As New ClientesClass


            pro.Id = txtId.Text
            pro.nombre = txtNombre.Text
            pro.apellido = txtApellido.Text
            pro.direccion = txtDireccion.Text
            pro.telefono = txtTelefono.Text
            pro.CuentaTotal = txtCuentaTotal.Text
            pro.habilitado = RadioButton1.Text

            If esNuevo Then

                pro.Agregar(pro)
            Else

                pro.Modificar(pro)
            End If


            Close()
        End If

    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub



    'Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim Elija As String

        If RadioButton1.Checked = True Then

            Elija = RadioButton1.Text

        ElseIf RadioButton2.Checked = True Then

            Elija = RadioButton2.Text
        End If

        MsgBox("Usted eligió  " & Elija)
    End Sub
End Class

