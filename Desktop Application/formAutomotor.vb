﻿Public Class formAutomotor

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mAutomotorActual As Automotor

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDAutomotor As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDAutomotor = 0 Then
            ' Es Nuevo
            mAutomotorActual = New Automotor
            With mAutomotorActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Automotor.Add(mAutomotorActual)
        Else
            mAutomotorActual = mdbContext.Automotor.Find(IDAutomotor)
        End If

        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        textboxNumero.ReadOnly = Not mEditMode
        textboxMarca.ReadOnly = Not mEditMode
        textboxModelo.ReadOnly = Not mEditMode
        textboxAnio.ReadOnly = Not mEditMode
        comboboxAutomotorTipo.Enabled = mEditMode
        datetimepickerFechaAdquisicion.Enabled = mEditMode
        textboxDominio.ReadOnly = Not mEditMode
        comboboxCombustibleTipo.Enabled = mEditMode
        textboxKilometrajeInicial.ReadOnly = Not mEditMode
        textboxCapacidadAguaLitros.ReadOnly = Not mEditMode
        comboboxCuartel.Enabled = mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mAutomotorActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mAutomotorActual
            If .IDAutomotor = 0 Then
                textboxIDAutomotor.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAutomotor.Text = String.Format(.IDAutomotor.ToString, "G")
            End If
            textboxNumero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Numero)
            textboxMarca.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Marca)
            textboxModelo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Modelo)
            textboxAnio.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Anio)
            CS_Control_ComboBox.SetSelectedValue(comboboxAutomotorTipo, SelectedItemOptions.ValueOrFirst, .IDAutomotorTipo)
            datetimepickerFechaAdquisicion.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaAdquisicion, datetimepickerFechaAdquisicion)
            textboxDominio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Dominio)
            CS_Control_ComboBox.SetSelectedValue(comboboxCombustibleTipo, SelectedItemOptions.ValueOrFirst, .IDCombustibleTipo)
            textboxKilometrajeInicial.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.KilometrajeInicial)
            textboxCapacidadAguaLitros.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.CapacidadAguaLitros)
            CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirst, .IDCuartel)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mAutomotorActual
            .Numero = CS_ValueTranslation.FromControlTextBoxToObjectInteger(textboxNumero.Text)
            .Marca = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxMarca.Text)
            .Modelo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxModelo.Text)
            .Anio = CS_ValueTranslation.FromControlTextBoxToObjectShort(textboxAnio.Text).Value
            .IDAutomotorTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxAutomotorTipo.SelectedValue).Value
            .FechaAdquisicion = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAdquisicion.Value, datetimepickerFechaAdquisicion.Checked)
            .Dominio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominio.Text)
            .IDCombustibleTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCombustibleTipo.SelectedValue).Value
            .KilometrajeInicial = CS_ValueTranslation.FromControlTextBoxToObjectInteger(textboxKilometrajeInicial.Text)
            .CapacidadAguaLitros = CS_ValueTranslation.FromControlTextBoxToObjectInteger(textboxCapacidadAguaLitros.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNumero.GotFocus, textboxMarca.GotFocus, textboxModelo.GotFocus, textboxAnio.GotFocus, textboxDominio.GotFocus, textboxKilometrajeInicial.GotFocus, textboxCapacidadAguaLitros.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.Automotor_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNumero.Focus()
            Exit Sub
        End If
        If textboxMarca.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar la Marca.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxMarca.Focus()
            Exit Sub
        End If
        If textboxModelo.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Modelo.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxModelo.Focus()
            Exit Sub
        End If
        If textboxAnio.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Año.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxAnio.Focus()
            Exit Sub
        End If

        If comboboxAutomotorTipo.SelectedIndex = 0 Then
            MsgBox("Debe especificar el Tipo de Automotor.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxAutomotorTipo.Focus()
            Exit Sub
        End If

        ' Fecha de Adquisición
        If datetimepickerFechaAdquisicion.Checked And datetimepickerFechaAdquisicion.Value > Today Then
            MsgBox("La Fecha de Adquisición debe ser igual o anterior a la fecha actual.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaAdquisicion.Focus()
            Exit Sub
        End If

        If comboboxCuartel.SelectedIndex = 0 Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mAutomotorActual.IDAutomotor = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Automotor.Count = 0 Then
                    mAutomotorActual.IDAutomotor = 1
                Else
                    mAutomotorActual.IDAutomotor = dbcMaxID.Automotor.Max(Function(a) a.IDAutomotor) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mAutomotorActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mAutomotorActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formAutomotores") Then
                    Dim formAutomotores As formAutomotores = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formAutomotores"), formAutomotores)
                    formAutomotores.RefreshData(mAutomotorActual.IDAutomotor)
                    formAutomotores = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Automotor con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub
#End Region

End Class