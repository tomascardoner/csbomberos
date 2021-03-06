﻿Public Class formSiniestroAsistencia

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro
    Private mSiniestroAsistenciaActual As SiniestroAsistencia

    Private mIsLoading As Boolean = False
    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef siniestroActual As Siniestro, ByVal idPersona As Integer)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (idPersona = 0)

        mSiniestroActual = siniestroActual
        If mIsNew Then
            ' Es Nuevo
            mSiniestroAsistenciaActual = New SiniestroAsistencia
            mSiniestroActual.SiniestroAsistencias.Add(mSiniestroAsistenciaActual)
        Else
            mSiniestroAsistenciaActual = mSiniestroActual.SiniestroAsistencias.Single(Function(sa) sa.IDPersona = idPersona)
        End If

        CS_Form.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(mParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        buttonPersona.Visible = mIsNew
        comboboxAsistenciaTipo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        Siniestros.LlenarComboBoxAsistenciaTipos(mdbContext, comboboxAsistenciaTipo, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_SINIESTRO_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroActual = Nothing
        mSiniestroAsistenciaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroAsistenciaActual
            textboxCuartel.Text = mSiniestroActual.Cuartel.Nombre
            textboxNumeroCompleto.Text = mSiniestroActual.NumeroCompleto
            textboxFecha.Text = mSiniestroActual.Fecha.ToShortDateString()

            If mIsNew Then
                textboxPersona.Text = ""
                textboxPersona.Tag = 0
            Else
                textboxPersona.Text = mSiniestroAsistenciaActual.Persona.ApellidoNombre
                textboxPersona.Tag = mSiniestroAsistenciaActual.IDPersona
            End If

            CardonerSistemas.ComboBox.SetSelectedValue(comboboxAsistenciaTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDSiniestroAsistenciaTipo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroAsistenciaActual
            If mIsNew Then
                .IDPersona = CInt(textboxPersona.Tag)
            End If
            .IDSiniestroAsistenciaTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxAsistenciaTipo.SelectedValue).Value
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

    Private Sub SeleccionarPersona() Handles buttonPersona.Click
        If mIsNew Then
            Dim fps As New formPersonasSeleccionar

            fps.EstablecerMultiseleccion(False)
            If fps.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim PersonaSeleccionada As Persona

                PersonaSeleccionada = CType(fps.datagridviewMain.SelectedRows(0).DataBoundItem, Persona)
                textboxPersona.Tag = PersonaSeleccionada.IDPersona
                textboxPersona.Text = PersonaSeleccionada.ApellidoNombre

                PersonaSeleccionada = Nothing
            End If
            fps.Dispose()
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If mIsNew Then
            If CInt(textboxPersona.Tag) = 0 Then
                MsgBox("Debe especificar la Persona.", MsgBoxStyle.Information, My.Application.Info.Title)
                buttonPersona.Focus()
                Exit Sub
            End If
        End If
        If comboboxAsistenciaTipo.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Asistencia.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxAsistenciaTipo.Focus()
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formSiniestro).AsistenciasRefreshData(mSiniestroAsistenciaActual.IDPersona)

        Me.Close()
    End Sub

#End Region

End Class