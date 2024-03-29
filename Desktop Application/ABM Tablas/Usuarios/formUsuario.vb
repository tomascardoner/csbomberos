﻿Public Class formUsuario

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mUsuarioActual As Usuario

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDUsuario As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDUsuario = 0)

        If mIsNew Then
            ' Es Nuevo
            mUsuarioActual = New Usuario
            With mUsuarioActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Usuario.Add(mUsuarioActual)
        Else
            mUsuarioActual = mdbContext.Usuario.Find(IDUsuario)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        textboxDescripcion.ReadOnly = Not mEditMode
        textboxPassword.ReadOnly = Not mEditMode
        comboboxGenero.Enabled = mEditMode
        comboboxUsuarioGrupo.Enabled = mEditMode
        comboboxCuartel.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        FillAndRefreshLists.Genero(comboboxGenero, False)
        pFillAndRefreshLists.UsuarioGrupo(comboboxUsuarioGrupo, True, False, False)
        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mUsuarioActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mUsuarioActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)
            textboxPassword.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Password)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxGenero, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxUsuarioGrupo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDUsuarioGrupo)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxIDUsuario.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDUsuario.Text = String.Format(.IDUsuario.ToString, "G")
            End If
            textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
            If .UsuarioCreacion Is Nothing Then
                textboxUsuarioCreacion.Text = ""
            Else
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
            If .UsuarioModificacion Is Nothing Then
                textboxUsuarioModificacion.Text = ""
            Else
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mUsuarioActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcion.Text)
            .Password = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxPassword.Text)
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGenero.SelectedValue)
            .IDUsuarioGrupo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxUsuarioGrupo.SelectedValue).Value
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.USUARIO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Usuario.Any() Then
                    mUsuarioActual.IDUsuario = dbcMaxID.Usuario.Max(Function(a) a.IDUsuario) + CByte(1)
                Else
                    mUsuarioActual.IDUsuario = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mUsuarioActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mUsuarioActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formUsuarios.RefreshData(mUsuarioActual.IDUsuario)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Usuario con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub textboxNombre_Leave(sender As Object, e As EventArgs) Handles textboxNombre.Leave
        textboxNombre.Text = textboxNombre.Text.Replace(" ", "")
    End Sub

    Private Sub textboxNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxNombre.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        ' Nombre
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Return False
        End If
        If textboxNombre.TextLength < 4 Then
            MsgBox("El Nombre debe contener al menos 4 caracteres.", vbInformation, My.Application.Info.Title)
            textboxNombre.Focus()
            Return False
        End If
        If comboboxUsuarioGrupo.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxUsuarioGrupo.Focus()
            Return False
        End If

        ' Contraseña
        If textboxPassword.TextLength = 0 Then
            MsgBox("Debe ingresar la Contraseña.", vbInformation, My.Application.Info.Title)
            textboxPassword.Focus()
            Return False
        End If
        If CS_Parameter_System.GetBoolean(Parametros.USER_PASSWORD_SECURE_REQUIRED, True) Then
            If textboxPassword.TextLength < CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8) Then
                MsgBox(String.Format("La Contraseña debe contener al menos {0} caracteres.", CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8)), vbInformation, My.Application.Info.Title)
                textboxPassword.Focus()
                Return False
            End If
        Else
            If textboxPassword.TextLength < 4 Then
                MsgBox("La Contraseña debe contener al menos 4 caracteres.", vbInformation, My.Application.Info.Title)
                textboxPassword.Focus()
                Return False
            End If
        End If

        If comboboxGenero.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe seleccionar el Género.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxGenero.Focus()
            Return False
        End If

        If comboboxUsuarioGrupo.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe seleccionar el Grupo de Usuarios.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxUsuarioGrupo.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class