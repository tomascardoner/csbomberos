﻿Public Class formAcademiaAsistencia

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaActual As Academia
    Private mIDCuartel As Byte
    Private mCuartelNombre As String
    Private mFecha As String
    Private mAcademiaAsistenciaActual As AcademiaAsistencia

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef siniestroActual As Academia, ByVal idPersona As Integer, ByVal idCuartel As Byte, ByVal CuartelNombre As String, ByVal Fecha As String)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (idPersona = 0)

        mAcademiaActual = siniestroActual
        mIDCuartel = idCuartel
        mCuartelNombre = CuartelNombre
        mFecha = Fecha
        If mIsNew Then
            ' Es Nuevo
            mAcademiaAsistenciaActual = New AcademiaAsistencia With {
                .IDAsistenciaMetodo = Constantes.ASISTENCIA_METODO_MANUAL_ID,
                .IDUsuarioCreacion = pUsuario.IDUsuario,
                .FechaHoraCreacion = Now,
                .IDUsuarioModificacion = pUsuario.IDUsuario,
                .FechaHoraModificacion = Now
                }
            mAcademiaActual.AcademiasAsistencias.Add(mAcademiaAsistenciaActual)
        Else
            mAcademiaAsistenciaActual = mAcademiaActual.AcademiasAsistencias.Single(Function(sa) sa.IDPersona = idPersona)
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

        Academias.LlenarComboBoxAsistenciaTipos(mdbContext, comboboxAsistenciaTipo, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAcademia32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mAcademiaActual = Nothing
        mAcademiaAsistenciaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mAcademiaAsistenciaActual
            textboxCuartel.Text = mCuartelNombre
            textboxFecha.Text = mFecha

            If mIsNew Then
                textboxPersona.Text = ""
                textboxPersona.Tag = 0
            Else
                textboxPersona.Text = mAcademiaAsistenciaActual.Persona.ApellidoNombre
                textboxPersona.Tag = mAcademiaAsistenciaActual.IDPersona
            End If

            CardonerSistemas.ComboBox.SetSelectedValue(comboboxAsistenciaTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDAcademiaAsistenciaTipo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mAcademiaAsistenciaActual
            If mIsNew Then
                .IDPersona = CInt(textboxPersona.Tag)
            End If
            .IDAcademiaAsistenciaTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxAsistenciaTipo.SelectedValue).Value
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
            Dim fps As New formPersonasSeleccionar(False, mIDCuartel, True)

            If fps.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim PersonaSeleccionada As uspPersonasObtenerConEstado_Result

                PersonaSeleccionada = CType(fps.datagridviewMain.SelectedRows(0).DataBoundItem, uspPersonasObtenerConEstado_Result)
                textboxPersona.Tag = PersonaSeleccionada.IDPersona
                textboxPersona.Text = PersonaSeleccionada.ApellidoNombre
            End If
            fps.Dispose()
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ACADEMIA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mIsNew Then
            mAcademiaActual.AcademiasAsistencias.Remove(mAcademiaAsistenciaActual)
        End If
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

        mAcademiaAsistenciaActual.IDUsuarioModificacion = pUsuario.IDUsuario
        mAcademiaAsistenciaActual.FechaHoraModificacion = Now

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formAcademia).AsistenciasRefreshData(mAcademiaAsistenciaActual.IDPersona)

        Me.Close()
    End Sub

#End Region

End Class