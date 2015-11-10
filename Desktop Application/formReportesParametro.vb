﻿Public Class formReportesParametro
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        Me.Text = Title

        mParametroActual = ParametroActual

        datetimepickerValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATE Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATETIME)

        If Not mParametroActual.Valor Is Nothing Then
            Select Case mParametroActual.Tipo
                Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                    datetimepickerValor.Value = CDate(mParametroActual.Valor)
            End Select
        End If
    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                mParametroActual.Valor = datetimepickerValor.Value
                mParametroActual.ValorParaMostrar = FormatDateTime(datetimepickerValor.Value, DateFormat.LongDate)
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub formReportesParametro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class