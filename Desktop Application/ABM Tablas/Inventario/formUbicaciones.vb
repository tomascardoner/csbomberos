﻿Public Class formUbicaciones

#Region "Declarations"

    Friend Class GridRowData
        Public Property IDUbicacion As Short
        Public Property Nombre As String
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property UnidadNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistUbicacionesBase As List(Of GridRowData)
    Private mlistUbicacionesFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel.ComboBox, True, False)
        End Using

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnNombre
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub
#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDUbicacion As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistUbicacionesBase = (From u In dbContext.Ubicacion
                                        Join c In dbContext.Cuartel On u.IDCuartel Equals c.IDCuartel
                                        Group Join a In dbContext.Unidad On u.IDUnidad Equals a.IDUnidad Into Unidades_Group = Group
                                        From ag In Unidades_Group.DefaultIfEmpty
                                        Select New GridRowData With {.IDUbicacion = u.IDUbicacion, .Nombre = u.Nombre, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .UnidadNombre = If(ag Is Nothing, "", ag.NumeroMarcaModelo), .EsActivo = u.EsActivo}).ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Ubicaciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDUbicacion = 0
            Else
                PositionIDUbicacion = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDUbicacion
            End If
        End If

        FilterData()

        If PositionIDUbicacion <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDUbicacion = PositionIDUbicacion Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
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
                mReportSelectionFormula = ""
                mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Ubicacion.IDCuartel} = " & CByte(comboboxCuartel.ComboBox.SelectedValue)
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.Where(Function(p) p.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Ubicacion.EsActivo} = 1"
                        mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Ubicacion.EsActivo} = 0"
                        mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistUbicacionesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Ubicaciones para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Ubicación.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Ubicaciones.", mlistUbicacionesFiltradaYOrdenada.Count)
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
        Select Case mOrdenColumna.Name
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.EsActivo).ToList
                Else
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.EsActivo).ToList
                End If
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnUnidad.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.UnidadNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.UnidadNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistUbicacionesFiltradaYOrdenada = mlistUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistUbicacionesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                If RowCurrent.Cells(columnNombre.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                    RowCurrent.Cells(columnNombre.Name).Selected = True
                    datagridviewMain.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub CambioFiltros() Handles comboboxCuartel.SelectedIndexChanged, comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn Is mOrdenColumna Then
            ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
            If mOrdenTipo = SortOrder.Ascending Then
                mOrdenTipo = SortOrder.Descending
            Else
                mOrdenTipo = SortOrder.Ascending
            End If
        Else
            ' La columna clickeada es diferencte a la que ya estaba ordenada.
            ' En primer lugar saco el ícono de orden de la columna vieja
            If mOrdenColumna IsNot Nothing Then
                mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
            End If

            ' Ahora preparo todo para la nueva columna
            mOrdenTipo = SortOrder.Ascending
            mOrdenColumna = ClickedColumn
        End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.UBICACION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formUbicacion.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Ubicación para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.UBICACION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formUbicacion.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUbicacion)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Ubicación para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.UBICACION_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor

                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Ubicación seleccionada.{0}{0}Nombre: {1}{0}Cuartel: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Nombre, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).CuartelNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim UbicacionEliminar As Ubicacion

                            UbicacionEliminar = dbContext.Ubicacion.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUbicacion)
                            dbContext.Ubicacion.Remove(UbicacionEliminar)
                            dbContext.SaveChanges()
                            UbicacionEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Ubicación porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Ubicación.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Ubicación para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formUbicacion.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUbicacion)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class