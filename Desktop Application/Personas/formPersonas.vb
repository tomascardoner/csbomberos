﻿Public Class formPersonas

#Region "Declarations"

    Private mlistPersonasBase As List(Of PersonasObtenerConEstadoYJerarquia_Result)
    Private mlistPersonasFiltradaYOrdenada As List(Of PersonasObtenerConEstadoYJerarquia_Result)

    Private mSkipFilterData As Boolean
    Private mBusquedaAplicada As Boolean

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImagePersona32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel.ComboBox, True, False)
        End Using
        pFillAndRefreshLists.PersonaEstadoActual(comboboxEstadoActual.ComboBox, True)

        mSkipFilterData = False

        OrdenColumna = columnApellido
        OrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistPersonasBase = Nothing
        mlistPersonasFiltradaYOrdenada = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistPersonasBase = dbContext.PersonasObtenerConEstadoYJerarquia().ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Personas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDPersona = 0
            Else
                PositionIDPersona = CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).IDPersona
            End If
        End If

        FilterData()

        If PositionIDPersona <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).IDPersona = PositionIDPersona Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnMatriculaNumero.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mlistPersonasFiltradaYOrdenada = mlistPersonasBase

                ' Filtro por Búsqueda en Matrícula o Apellido y Nombre
                If mBusquedaAplicada Then
                    Dim valorBusqueda As String = textboxBuscar.Text.ToLower().RemoveDiacritics().Trim()
                    If valorBusqueda.Length = 3 AndAlso valorBusqueda.IsAllDigits Then
                        ' Matrícula
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(p) p.MatriculaNumero.TrimEnd().EndsWith(valorBusqueda)).ToList
                    Else
                        ' Apellido y Nombre
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(p) p.ApellidoNombre.ToLower().RemoveDiacritics().Contains(valorBusqueda)).ToList
                    End If
                End If

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(p) p.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Estado actual
                Select Case comboboxEstadoActual.SelectedIndex
                    Case 0  ' Todos
                    Case 1  ' Desconocido
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(a) Not a.IDBajaMotivo.HasValue).ToList
                    Case 2  ' Activo
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value = 0).ToList
                    Case 3  ' Inactivo
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value > 0).ToList
                    Case Else
                        mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value = CByte(comboboxEstadoActual.ComboBox.SelectedValue)).ToList
                End Select

                Select Case mlistPersonasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Personas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Persona.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Personas.", mlistPersonasFiltradaYOrdenada.Count)
                End Select

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()

        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case columnMatriculaNumero.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderBy(Function(col) col.MatriculaNumero).ToList
                Else
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.MatriculaNumero).ToList
                End If
            Case columnApellido.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderBy(Function(col) col.Apellido).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.Apellido).ThenByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnNombre.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ThenBy(Function(col) col.Apellido).ToList
                Else
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ThenByDescending(Function(col) col.Apellido).ToList
                End If
            Case columnCuartelNombre.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderBy(Function(col) col.CuartelNombre).ThenBy(Function(col) col.Apellido).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistPersonasFiltradaYOrdenada = mlistPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.CuartelNombre).ThenByDescending(Function(col) col.Apellido).ThenByDescending(Function(col) col.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistPersonasFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not textboxBuscar.Focused Then
            If Char.IsLetter(e.KeyChar) Then
                For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                    If RowCurrent.Cells(columnApellido.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                        RowCurrent.Cells(columnMatriculaNumero.Name).Selected = True
                        datagridviewMain.Focus()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub textboxBuscar_GotFocus() Handles textboxBuscar.GotFocus
        textboxBuscar.SelectAll()
    End Sub

    Private Sub textboxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If textboxBuscar.Text.Trim.Length < 3 Then
                MsgBox("Se deben especificar al menos 3 letras para buscar.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxBuscar.Focus()
            Else
                mBusquedaAplicada = True
                FilterData()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub buttonBuscarBorrar_Click() Handles buttonBuscarBorrar.Click
        If mBusquedaAplicada Then
            textboxBuscar.Clear()
            mBusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub CuartelChanged() Handles comboboxCuartel.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub EstadoActualChanged() Handles comboboxEstadoActual.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnMatriculaNumero.Name Or ClickedColumn.Name = columnApellido.Name Or ClickedColumn.Name = columnNombre.Name Then
            If ClickedColumn Is OrdenColumna Then
                ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
                If OrdenTipo = SortOrder.Ascending Then
                    OrdenTipo = SortOrder.Descending
                Else
                    OrdenTipo = SortOrder.Ascending
                End If
            Else
                ' La columna clickeada es diferencte a la que ya estaba ordenada.
                ' En primer lugar saco el ícono de orden de la columna vieja
                If OrdenColumna IsNot Nothing Then
                    OrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
                End If

                ' Ahora preparo todo para la nueva columna
                OrdenTipo = SortOrder.Ascending
                OrdenColumna = ClickedColumn
            End If
        End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Agregar() Handles buttonAgregar.Click
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_AGREGAR) Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formPersona.LoadAndShow(True, Me, 0)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_EDITAR) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formPersona.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).IDPersona)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Eliminar() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_ELIMINAR) Then
            Return
        End If

        Dim Mensaje As String = String.Format("Se eliminará la Persona seleccionada.{0}{0}Matrícula Nº: {1}{0}Apellido y nombre: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).MatriculaNumero, CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).ApellidoNombre)
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Using dbContext = New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbContext.Persona.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).IDPersona)

                dbContext.Persona.Attach(PersonaActual)
                dbContext.Persona.Remove(PersonaActual)
                dbContext.SaveChanges()
            End Using
        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Me.Cursor = Cursors.Default
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                    MsgBox("No se puede eliminar la Persona porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            End Select
            Exit Sub
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Persona.")
        End Try

        RefreshData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formPersona.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result).IDPersona)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Imprimir_FichaPersonal(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimirFichaPersonal.Click
        Dim CurrentRow As PersonasObtenerConEstadoYJerarquia_Result

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para imprimir la Ficha.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_IMPRIMIR) Then
            Return
        End If

        CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstadoYJerarquia_Result)
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        Using dbContext As New CSBomberosContext(True)
            Dim ReporteActual As New Reporte
            ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_FICHA))
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDPersona").Single.Valor = CurrentRow.IDPersona
            ReporteActual.Open(True, ReporteActual.Nombre & " - " & CurrentRow.ApellidoNombre)
        End Using
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

#End Region

End Class