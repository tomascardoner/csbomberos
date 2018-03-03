﻿Public Class formPersonaAltaBaja

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaAltaBajaActual As PersonaAltaBaja

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDAltaBaja As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDAltaBaja = 0 Then
            ' Es Nuevo
            mPersonaAltaBajaActual = New PersonaAltaBaja
            With mPersonaAltaBajaActual
                .IDPersona = IDPersona
                .AltaFecha = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaAltaBaja.Add(mPersonaAltaBajaActual)
        Else
            mPersonaAltaBajaActual = mdbContext.PersonaAltaBaja.Find(IDPersona, IDAltaBaja)
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

        datetimepickerAltaFecha.Enabled = mEditMode

        textboxAltaLibroNumero.ReadOnly = Not mEditMode
        textboxAltaFolioNumero.ReadOnly = Not mEditMode
        textboxAltaActaNumero.ReadOnly = Not mEditMode

        datetimepickerBajaFecha.Enabled = mEditMode

        textboxBajaLibroNumero.ReadOnly = Not mEditMode
        textboxBajaFolioNumero.ReadOnly = Not mEditMode
        textboxBajaActaNumero.ReadOnly = Not mEditMode

        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaAltaBajaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaAltaBajaActual
            If .IDAltaBaja = 0 Then
                textboxIDAltaBaja.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAltaBaja.Text = String.Format(.IDAltaBaja.ToString, "G")
            End If
            datetimepickerAltaFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.AltaFecha)
            textboxAltaLibroNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.AltaLibroNumero)
            textboxAltaFolioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.AltaFolioNumero)
            textboxAltaActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.AltaActaNumero)
            datetimepickerBajaFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.BajaFecha, datetimepickerBajaFecha)
            textboxBajaLibroNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.BajaLibroNumero)
            textboxBajaFolioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.BajaFolioNumero)
            textboxBajaActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.BajaActaNumero)
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaAltaBajaActual
            .AltaFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerAltaFecha.Value).Value
            .AltaLibroNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAltaLibroNumero.Text)
            .AltaFolioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAltaFolioNumero.Text)
            .AltaActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAltaActaNumero.Text)
            .BajaFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerBajaFecha.Value, datetimepickerBajaFecha.Checked)
            .BajaLibroNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxBajaLibroNumero.Text)
            .BajaFolioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxBajaFolioNumero.Text)
            .BajaActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxBajaActaNumero.Text)
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Generar el ID nuevo
        If mPersonaAltaBajaActual.IDAltaBaja = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaAltaBajaActual.IDPersona)
                If PersonaActual.PersonaAltasBajas.Count = 0 Then
                    mPersonaAltaBajaActual.IDAltaBaja = 1
                Else
                    mPersonaAltaBajaActual.IDAltaBaja = PersonaActual.PersonaAltasBajas.Max(Function(pab) pab.IDAltaBaja) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaAltaBajaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaAltaBajaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formPersonaAltasBajas") Then
                    Dim formPersonaAltasBajas As formPersonaAltasBajas = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formPersonaAltasBajas"), formPersonaAltasBajas)
                    formPersonaAltasBajas.RefreshData(mPersonaAltaBajaActual.IDAltaBaja)
                    formPersonaAltasBajas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Alta-Baja con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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