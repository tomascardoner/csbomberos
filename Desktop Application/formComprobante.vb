﻿Public Class formComprobante

    Private Sub formComprobanteCabecera_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Cargo los ComboBox
        FillAndRefreshLists.ComprobanteTipo(comboboxComprobanteTipo, OPERACIONTIPO_VENTA, False, False)

        FillAndRefreshLists.CategoriaIVA(comboboxCategoriaIVA, False)
        CS_ComboBox.SetSelectedValue(comboboxCategoriaIVA, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_CATEGORIAIVA_ID, 0))

        FillAndRefreshLists.Provincia(comboboxDomicilioProvincia, False)
        CS_ComboBox.SetSelectedValue(comboboxDomicilioProvincia, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetString(Parametros.DEFAULT_PROVINCIA_ID))

        CS_ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
    End Sub

    Private Sub comboboxDomicilioProvincia_SelectedIndexChanged() Handles comboboxDomicilioProvincia.SelectedIndexChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            comboboxDomicilioLocalidad.Items.Clear()
        Else
            FillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), False)
        End If
    End Sub

    Private Sub comboboxDomicilioLocalidad_SelectedIndexChanged() Handles comboboxDomicilioLocalidad.SelectedIndexChanged
        If Not comboboxDomicilioLocalidad.SelectedItem Is Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal
        End If
    End Sub
End Class