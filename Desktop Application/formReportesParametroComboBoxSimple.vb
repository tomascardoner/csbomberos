﻿Public Class formReportesParametroComboBoxSimple
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = ParametroActual.Nombre & ":"
        comboboxValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CARGO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UNIDAD Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_AREA Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION)

        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL
                pFillAndRefreshLists.Cuartel(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_CARGO
                pFillAndRefreshLists.Cargo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO
                pFillAndRefreshLists.PersonaBajaMotivo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_UNIDAD
                pFillAndRefreshLists.Unidad(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonAceptar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub Aceptar(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        mParametroActual.Valor = comboboxValor.SelectedValue
        mParametroActual.ValorParaMostrar = comboboxValor.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class