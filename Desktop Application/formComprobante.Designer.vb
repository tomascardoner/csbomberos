﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComprobante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim labelFechaServicioDesde As System.Windows.Forms.Label
        Dim labelFechaServicioHasta As System.Windows.Forms.Label
        Dim labelNotas As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tabcontrolMain = New CSColegio.DesktopApplication.CS_Control_TabControl()
        Me.tabpageDetalle = New System.Windows.Forms.TabPage()
        Me.datagridviewDetalle = New System.Windows.Forms.DataGridView()
        Me.columnDetalle_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioUnitarioDescuentoImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalle = New System.Windows.Forms.ToolStrip()
        Me.buttonDetalle_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetalle_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetalle_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageImpuestos = New System.Windows.Forms.TabPage()
        Me.datagridviewImpuestos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripImpuestos = New System.Windows.Forms.ToolStrip()
        Me.buttonImpuestos_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImpuestos_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImpuestos_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageAplicaciones = New System.Windows.Forms.TabPage()
        Me.datagridviewAplicaciones = New System.Windows.Forms.DataGridView()
        Me.columnAplicaciones_Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_NumeroCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_ImporteAplicado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAplicaciones = New System.Windows.Forms.ToolStrip()
        Me.buttonAplicacion_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAplicacion_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageAsociaciones = New System.Windows.Forms.TabPage()
        Me.datagridviewAsociaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAsociaciones = New System.Windows.Forms.ToolStrip()
        Me.buttonAsociaciones_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsociaciones_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageMediosPago = New System.Windows.Forms.TabPage()
        Me.datagridviewMediosPago = New System.Windows.Forms.DataGridView()
        Me.columnMedioPagos_MedioPagoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_CajaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_BancoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripMediosPago = New System.Windows.Forms.ToolStrip()
        Me.buttonMediosPago_AgregarOtro = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_AgregarCheque = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.panelCabecera = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelIdentificacion = New System.Windows.Forms.Panel()
        Me.textboxPuntoVenta = New System.Windows.Forms.TextBox()
        Me.labelPuntoVenta = New System.Windows.Forms.Label()
        Me.comboboxComprobanteTipo = New System.Windows.Forms.ComboBox()
        Me.labelComprobanteTipo = New System.Windows.Forms.Label()
        Me.textboxNumero = New System.Windows.Forms.TextBox()
        Me.labelComprobanteNumero = New System.Windows.Forms.Label()
        Me.datetimepickerFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaEmision = New System.Windows.Forms.Label()
        Me.textboxIDComprobante = New System.Windows.Forms.TextBox()
        Me.labelIDComprobante = New System.Windows.Forms.Label()
        Me.panelFechas = New System.Windows.Forms.Panel()
        Me.datetimepickerFechaServicioHasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaServicioDesde = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaVencimiento = New System.Windows.Forms.Label()
        Me.panelEntidad = New System.Windows.Forms.Panel()
        Me.buttonEntidad = New System.Windows.Forms.Button()
        Me.textboxEntidad = New System.Windows.Forms.TextBox()
        Me.labelEntidad = New System.Windows.Forms.Label()
        Me.panelPie = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelSubtotales = New System.Windows.Forms.Panel()
        Me.textboxImporteTotal = New System.Windows.Forms.TextBox()
        Me.labelImporteTotal = New System.Windows.Forms.Label()
        Me.textboxImporteImpuesto = New System.Windows.Forms.TextBox()
        Me.labelImporteImpuesto = New System.Windows.Forms.Label()
        Me.textboxImporteSubtotal = New System.Windows.Forms.TextBox()
        Me.labelImporteSubtotal = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        labelFechaServicioDesde = New System.Windows.Forms.Label()
        labelFechaServicioHasta = New System.Windows.Forms.Label()
        labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageDetalle.SuspendLayout()
        CType(Me.datagridviewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripDetalle.SuspendLayout()
        Me.tabpageImpuestos.SuspendLayout()
        CType(Me.datagridviewImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripImpuestos.SuspendLayout()
        Me.tabpageAplicaciones.SuspendLayout()
        CType(Me.datagridviewAplicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAplicaciones.SuspendLayout()
        Me.tabpageAsociaciones.SuspendLayout()
        CType(Me.datagridviewAsociaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAsociaciones.SuspendLayout()
        Me.tabpageMediosPago.SuspendLayout()
        CType(Me.datagridviewMediosPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMediosPago.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.panelCabecera.SuspendLayout()
        Me.panelIdentificacion.SuspendLayout()
        Me.panelFechas.SuspendLayout()
        Me.panelEntidad.SuspendLayout()
        Me.panelPie.SuspendLayout()
        Me.panelSubtotales.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFechaServicioDesde
        '
        labelFechaServicioDesde.AutoSize = True
        labelFechaServicioDesde.Location = New System.Drawing.Point(251, 6)
        labelFechaServicioDesde.Name = "labelFechaServicioDesde"
        labelFechaServicioDesde.Size = New System.Drawing.Size(133, 13)
        labelFechaServicioDesde.TabIndex = 2
        labelFechaServicioDesde.Text = "Período Facturado Desde:"
        '
        'labelFechaServicioHasta
        '
        labelFechaServicioHasta.AutoSize = True
        labelFechaServicioHasta.Location = New System.Drawing.Point(516, 6)
        labelFechaServicioHasta.Name = "labelFechaServicioHasta"
        labelFechaServicioHasta.Size = New System.Drawing.Size(38, 13)
        labelFechaServicioHasta.TabIndex = 4
        labelFechaServicioHasta.Text = "Hasta:"
        '
        'labelNotas
        '
        labelNotas.AutoSize = True
        labelNotas.Location = New System.Drawing.Point(6, 9)
        labelNotas.Name = "labelNotas"
        labelNotas.Size = New System.Drawing.Size(38, 13)
        labelNotas.TabIndex = 31
        labelNotas.Text = "Notas:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 239)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 28
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 213)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 25
        labelCreacion.Text = "Creación:"
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMain.ColumnCount = 1
        Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelMain.Controls.Add(Me.tabcontrolMain, 0, 1)
        Me.panelMain.Controls.Add(Me.panelCabecera, 0, 0)
        Me.panelMain.Controls.Add(Me.panelPie, 0, 2)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 39)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.RowCount = 4
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panelMain.Size = New System.Drawing.Size(964, 475)
        Me.panelMain.TabIndex = 2
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Controls.Add(Me.tabpageDetalle)
        Me.tabcontrolMain.Controls.Add(Me.tabpageImpuestos)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAplicaciones)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAsociaciones)
        Me.tabcontrolMain.Controls.Add(Me.tabpageMediosPago)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolMain.Location = New System.Drawing.Point(3, 114)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(958, 288)
        Me.tabcontrolMain.TabIndex = 8
        '
        'tabpageDetalle
        '
        Me.tabpageDetalle.Controls.Add(Me.datagridviewDetalle)
        Me.tabpageDetalle.Controls.Add(Me.toolstripDetalle)
        Me.tabpageDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabpageDetalle.Name = "tabpageDetalle"
        Me.tabpageDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalle.Size = New System.Drawing.Size(950, 262)
        Me.tabpageDetalle.TabIndex = 0
        Me.tabpageDetalle.Text = "Detalle"
        '
        'datagridviewDetalle
        '
        Me.datagridviewDetalle.AllowUserToAddRows = False
        Me.datagridviewDetalle.AllowUserToDeleteRows = False
        Me.datagridviewDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDetalle_Descripcion, Me.columnDetalle_PrecioUnitario, Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje, Me.columnDetalle_PrecioUnitarioDescuentoImporte, Me.columnDetalle_PrecioTotal})
        Me.datagridviewDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalle.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewDetalle.MultiSelect = False
        Me.datagridviewDetalle.Name = "datagridviewDetalle"
        Me.datagridviewDetalle.ReadOnly = True
        Me.datagridviewDetalle.RowHeadersVisible = False
        Me.datagridviewDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalle.Size = New System.Drawing.Size(857, 256)
        Me.datagridviewDetalle.TabIndex = 4
        '
        'columnDetalle_Descripcion
        '
        Me.columnDetalle_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_Descripcion.DataPropertyName = "Descripcion"
        Me.columnDetalle_Descripcion.HeaderText = "Descripción"
        Me.columnDetalle_Descripcion.Name = "columnDetalle_Descripcion"
        Me.columnDetalle_Descripcion.ReadOnly = True
        Me.columnDetalle_Descripcion.Width = 88
        '
        'columnDetalle_PrecioUnitario
        '
        Me.columnDetalle_PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioUnitario.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnDetalle_PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnDetalle_PrecioUnitario.HeaderText = "Precio Unitario"
        Me.columnDetalle_PrecioUnitario.Name = "columnDetalle_PrecioUnitario"
        Me.columnDetalle_PrecioUnitario.ReadOnly = True
        Me.columnDetalle_PrecioUnitario.Width = 101
        '
        'columnDetalle_PrecioUnitarioDescuentoPorcentaje
        '
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.DataPropertyName = "PrecioUnitarioDescuentoPorcentaje"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "0.00"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.HeaderText = "% Descuento"
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.Name = "columnDetalle_PrecioUnitarioDescuentoPorcentaje"
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.ReadOnly = True
        Me.columnDetalle_PrecioUnitarioDescuentoPorcentaje.Width = 95
        '
        'columnDetalle_PrecioUnitarioDescuentoImporte
        '
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.DataPropertyName = "PrecioUnitarioDescuentoImporte"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.HeaderText = "$ Descuento"
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.Name = "columnDetalle_PrecioUnitarioDescuentoImporte"
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.ReadOnly = True
        Me.columnDetalle_PrecioUnitarioDescuentoImporte.Width = 93
        '
        'columnDetalle_PrecioTotal
        '
        Me.columnDetalle_PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioTotal.DataPropertyName = "PrecioTotal"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.columnDetalle_PrecioTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnDetalle_PrecioTotal.HeaderText = "Subtotal"
        Me.columnDetalle_PrecioTotal.Name = "columnDetalle_PrecioTotal"
        Me.columnDetalle_PrecioTotal.ReadOnly = True
        Me.columnDetalle_PrecioTotal.Width = 71
        '
        'toolstripDetalle
        '
        Me.toolstripDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonDetalle_Agregar, Me.buttonDetalle_Editar, Me.buttonDetalle_Eliminar})
        Me.toolstripDetalle.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripDetalle.Location = New System.Drawing.Point(3, 3)
        Me.toolstripDetalle.Name = "toolstripDetalle"
        Me.toolstripDetalle.Size = New System.Drawing.Size(87, 256)
        Me.toolstripDetalle.TabIndex = 5
        '
        'buttonDetalle_Agregar
        '
        Me.buttonDetalle_Agregar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonDetalle_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Agregar.Name = "buttonDetalle_Agregar"
        Me.buttonDetalle_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetalle_Agregar.Text = "Agregar"
        '
        'buttonDetalle_Editar
        '
        Me.buttonDetalle_Editar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonDetalle_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Editar.Name = "buttonDetalle_Editar"
        Me.buttonDetalle_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetalle_Editar.Text = "Editar"
        '
        'buttonDetalle_Eliminar
        '
        Me.buttonDetalle_Eliminar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonDetalle_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Eliminar.Name = "buttonDetalle_Eliminar"
        Me.buttonDetalle_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetalle_Eliminar.Text = "Eliminar"
        '
        'tabpageImpuestos
        '
        Me.tabpageImpuestos.Controls.Add(Me.datagridviewImpuestos)
        Me.tabpageImpuestos.Controls.Add(Me.toolstripImpuestos)
        Me.tabpageImpuestos.Location = New System.Drawing.Point(4, 22)
        Me.tabpageImpuestos.Name = "tabpageImpuestos"
        Me.tabpageImpuestos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageImpuestos.Size = New System.Drawing.Size(950, 262)
        Me.tabpageImpuestos.TabIndex = 1
        Me.tabpageImpuestos.Text = "Impuestos"
        '
        'datagridviewImpuestos
        '
        Me.datagridviewImpuestos.AllowUserToAddRows = False
        Me.datagridviewImpuestos.AllowUserToDeleteRows = False
        Me.datagridviewImpuestos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewImpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridviewImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewImpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.datagridviewImpuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewImpuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewImpuestos.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewImpuestos.MultiSelect = False
        Me.datagridviewImpuestos.Name = "datagridviewImpuestos"
        Me.datagridviewImpuestos.ReadOnly = True
        Me.datagridviewImpuestos.RowHeadersVisible = False
        Me.datagridviewImpuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewImpuestos.Size = New System.Drawing.Size(857, 256)
        Me.datagridviewImpuestos.TabIndex = 7
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 101
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PrecioUnitarioDescuentoPorcentaje"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "0.00"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn8.HeaderText = "% Descuento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 95
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PrecioUnitarioDescuentoImporte"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn9.HeaderText = "$ Descuento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 93
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrecioTotal"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn10.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 71
        '
        'toolstripImpuestos
        '
        Me.toolstripImpuestos.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripImpuestos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripImpuestos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonImpuestos_Agregar, Me.buttonImpuestos_Editar, Me.buttonImpuestos_Eliminar})
        Me.toolstripImpuestos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripImpuestos.Location = New System.Drawing.Point(3, 3)
        Me.toolstripImpuestos.Name = "toolstripImpuestos"
        Me.toolstripImpuestos.Size = New System.Drawing.Size(87, 256)
        Me.toolstripImpuestos.TabIndex = 6
        '
        'buttonImpuestos_Agregar
        '
        Me.buttonImpuestos_Agregar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonImpuestos_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonImpuestos_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImpuestos_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImpuestos_Agregar.Name = "buttonImpuestos_Agregar"
        Me.buttonImpuestos_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonImpuestos_Agregar.Text = "Agregar"
        '
        'buttonImpuestos_Editar
        '
        Me.buttonImpuestos_Editar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonImpuestos_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonImpuestos_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImpuestos_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImpuestos_Editar.Name = "buttonImpuestos_Editar"
        Me.buttonImpuestos_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonImpuestos_Editar.Text = "Editar"
        '
        'buttonImpuestos_Eliminar
        '
        Me.buttonImpuestos_Eliminar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonImpuestos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonImpuestos_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImpuestos_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImpuestos_Eliminar.Name = "buttonImpuestos_Eliminar"
        Me.buttonImpuestos_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonImpuestos_Eliminar.Text = "Eliminar"
        '
        'tabpageAplicaciones
        '
        Me.tabpageAplicaciones.Controls.Add(Me.datagridviewAplicaciones)
        Me.tabpageAplicaciones.Controls.Add(Me.toolstripAplicaciones)
        Me.tabpageAplicaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAplicaciones.Name = "tabpageAplicaciones"
        Me.tabpageAplicaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAplicaciones.Size = New System.Drawing.Size(950, 262)
        Me.tabpageAplicaciones.TabIndex = 2
        Me.tabpageAplicaciones.Text = "Aplicaciones"
        '
        'datagridviewAplicaciones
        '
        Me.datagridviewAplicaciones.AllowUserToAddRows = False
        Me.datagridviewAplicaciones.AllowUserToDeleteRows = False
        Me.datagridviewAplicaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAplicaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.datagridviewAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAplicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnAplicaciones_Tipo, Me.columnAplicaciones_NumeroCompleto, Me.columnAplicaciones_Fecha, Me.columnAplicaciones_ImporteTotal, Me.columnAplicaciones_ImporteAplicado})
        Me.datagridviewAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAplicaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAplicaciones.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAplicaciones.MultiSelect = False
        Me.datagridviewAplicaciones.Name = "datagridviewAplicaciones"
        Me.datagridviewAplicaciones.ReadOnly = True
        Me.datagridviewAplicaciones.RowHeadersVisible = False
        Me.datagridviewAplicaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAplicaciones.Size = New System.Drawing.Size(857, 256)
        Me.datagridviewAplicaciones.TabIndex = 9
        '
        'columnAplicaciones_Tipo
        '
        Me.columnAplicaciones_Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_Tipo.DataPropertyName = "ComprobanteTipoNombre"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_Tipo.DefaultCellStyle = DataGridViewCellStyle12
        Me.columnAplicaciones_Tipo.HeaderText = "Tipo"
        Me.columnAplicaciones_Tipo.Name = "columnAplicaciones_Tipo"
        Me.columnAplicaciones_Tipo.ReadOnly = True
        Me.columnAplicaciones_Tipo.Width = 53
        '
        'columnAplicaciones_NumeroCompleto
        '
        Me.columnAplicaciones_NumeroCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_NumeroCompleto.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_NumeroCompleto.DefaultCellStyle = DataGridViewCellStyle13
        Me.columnAplicaciones_NumeroCompleto.HeaderText = "Número"
        Me.columnAplicaciones_NumeroCompleto.Name = "columnAplicaciones_NumeroCompleto"
        Me.columnAplicaciones_NumeroCompleto.ReadOnly = True
        Me.columnAplicaciones_NumeroCompleto.Width = 69
        '
        'columnAplicaciones_Fecha
        '
        Me.columnAplicaciones_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_Fecha.DataPropertyName = "FechaEmision"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_Fecha.DefaultCellStyle = DataGridViewCellStyle14
        Me.columnAplicaciones_Fecha.HeaderText = "Fecha"
        Me.columnAplicaciones_Fecha.Name = "columnAplicaciones_Fecha"
        Me.columnAplicaciones_Fecha.ReadOnly = True
        Me.columnAplicaciones_Fecha.Width = 62
        '
        'columnAplicaciones_ImporteTotal
        '
        Me.columnAplicaciones_ImporteTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_ImporteTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.columnAplicaciones_ImporteTotal.DefaultCellStyle = DataGridViewCellStyle15
        Me.columnAplicaciones_ImporteTotal.HeaderText = "Importe Total"
        Me.columnAplicaciones_ImporteTotal.Name = "columnAplicaciones_ImporteTotal"
        Me.columnAplicaciones_ImporteTotal.ReadOnly = True
        Me.columnAplicaciones_ImporteTotal.Width = 87
        '
        'columnAplicaciones_ImporteAplicado
        '
        Me.columnAplicaciones_ImporteAplicado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_ImporteAplicado.DataPropertyName = "ImporteAplicado"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.columnAplicaciones_ImporteAplicado.DefaultCellStyle = DataGridViewCellStyle16
        Me.columnAplicaciones_ImporteAplicado.HeaderText = "Importe aplicado"
        Me.columnAplicaciones_ImporteAplicado.Name = "columnAplicaciones_ImporteAplicado"
        Me.columnAplicaciones_ImporteAplicado.ReadOnly = True
        Me.columnAplicaciones_ImporteAplicado.Width = 101
        '
        'toolstripAplicaciones
        '
        Me.toolstripAplicaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAplicaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAplicaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAplicacion_Agregar, Me.buttonAplicacion_Eliminar})
        Me.toolstripAplicaciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAplicaciones.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAplicaciones.Name = "toolstripAplicaciones"
        Me.toolstripAplicaciones.Size = New System.Drawing.Size(87, 256)
        Me.toolstripAplicaciones.TabIndex = 8
        '
        'buttonAplicacion_Agregar
        '
        Me.buttonAplicacion_Agregar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAplicacion_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAplicacion_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAplicacion_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAplicacion_Agregar.Name = "buttonAplicacion_Agregar"
        Me.buttonAplicacion_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAplicacion_Agregar.Text = "Agregar"
        '
        'buttonAplicacion_Eliminar
        '
        Me.buttonAplicacion_Eliminar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonAplicacion_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAplicacion_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAplicacion_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAplicacion_Eliminar.Name = "buttonAplicacion_Eliminar"
        Me.buttonAplicacion_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAplicacion_Eliminar.Text = "Eliminar"
        '
        'tabpageAsociaciones
        '
        Me.tabpageAsociaciones.Controls.Add(Me.datagridviewAsociaciones)
        Me.tabpageAsociaciones.Controls.Add(Me.toolstripAsociaciones)
        Me.tabpageAsociaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAsociaciones.Name = "tabpageAsociaciones"
        Me.tabpageAsociaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAsociaciones.Size = New System.Drawing.Size(950, 262)
        Me.tabpageAsociaciones.TabIndex = 3
        Me.tabpageAsociaciones.Text = "Asociaciones"
        '
        'datagridviewAsociaciones
        '
        Me.datagridviewAsociaciones.AllowUserToAddRows = False
        Me.datagridviewAsociaciones.AllowUserToDeleteRows = False
        Me.datagridviewAsociaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAsociaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.datagridviewAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAsociaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn11})
        Me.datagridviewAsociaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAsociaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAsociaciones.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAsociaciones.MultiSelect = False
        Me.datagridviewAsociaciones.Name = "datagridviewAsociaciones"
        Me.datagridviewAsociaciones.ReadOnly = True
        Me.datagridviewAsociaciones.RowHeadersVisible = False
        Me.datagridviewAsociaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAsociaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAsociaciones.Size = New System.Drawing.Size(857, 256)
        Me.datagridviewAsociaciones.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ComprobanteTipoNombre"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaEmision"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 62
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "C2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 87
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ImportePendiente"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "C2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe sin aplicar"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ImporteAplicado"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "C2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn11.HeaderText = "Importe aplicado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 101
        '
        'toolstripAsociaciones
        '
        Me.toolstripAsociaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAsociaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAsociaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAsociaciones_Agregar, Me.buttonAsociaciones_Eliminar})
        Me.toolstripAsociaciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAsociaciones.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAsociaciones.Name = "toolstripAsociaciones"
        Me.toolstripAsociaciones.Size = New System.Drawing.Size(87, 256)
        Me.toolstripAsociaciones.TabIndex = 10
        '
        'buttonAsociaciones_Agregar
        '
        Me.buttonAsociaciones_Agregar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAsociaciones_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsociaciones_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsociaciones_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsociaciones_Agregar.Name = "buttonAsociaciones_Agregar"
        Me.buttonAsociaciones_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAsociaciones_Agregar.Text = "Agregar"
        '
        'buttonAsociaciones_Eliminar
        '
        Me.buttonAsociaciones_Eliminar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonAsociaciones_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsociaciones_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsociaciones_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsociaciones_Eliminar.Name = "buttonAsociaciones_Eliminar"
        Me.buttonAsociaciones_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAsociaciones_Eliminar.Text = "Eliminar"
        '
        'tabpageMediosPago
        '
        Me.tabpageMediosPago.Controls.Add(Me.datagridviewMediosPago)
        Me.tabpageMediosPago.Controls.Add(Me.toolstripMediosPago)
        Me.tabpageMediosPago.Location = New System.Drawing.Point(4, 22)
        Me.tabpageMediosPago.Name = "tabpageMediosPago"
        Me.tabpageMediosPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageMediosPago.Size = New System.Drawing.Size(950, 262)
        Me.tabpageMediosPago.TabIndex = 4
        Me.tabpageMediosPago.Text = "Medios de Pago"
        '
        'datagridviewMediosPago
        '
        Me.datagridviewMediosPago.AllowUserToAddRows = False
        Me.datagridviewMediosPago.AllowUserToDeleteRows = False
        Me.datagridviewMediosPago.AllowUserToResizeRows = False
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMediosPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle24
        Me.datagridviewMediosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMediosPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnMedioPagos_MedioPagoNombre, Me.columnMedioPagos_CajaNombre, Me.columnMedioPagos_Importe, Me.columnMedioPagos_BancoNombre, Me.columnMedioPagos_Numero, Me.columnMedioPagos_FechaVencimiento})
        Me.datagridviewMediosPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMediosPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMediosPago.Location = New System.Drawing.Point(133, 3)
        Me.datagridviewMediosPago.MultiSelect = False
        Me.datagridviewMediosPago.Name = "datagridviewMediosPago"
        Me.datagridviewMediosPago.ReadOnly = True
        Me.datagridviewMediosPago.RowHeadersVisible = False
        Me.datagridviewMediosPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMediosPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMediosPago.Size = New System.Drawing.Size(814, 256)
        Me.datagridviewMediosPago.TabIndex = 3
        '
        'columnMedioPagos_MedioPagoNombre
        '
        Me.columnMedioPagos_MedioPagoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_MedioPagoNombre.DataPropertyName = "MedioPagoNombre"
        Me.columnMedioPagos_MedioPagoNombre.HeaderText = "Medio de Pago"
        Me.columnMedioPagos_MedioPagoNombre.Name = "columnMedioPagos_MedioPagoNombre"
        Me.columnMedioPagos_MedioPagoNombre.ReadOnly = True
        Me.columnMedioPagos_MedioPagoNombre.Width = 73
        '
        'columnMedioPagos_CajaNombre
        '
        Me.columnMedioPagos_CajaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_CajaNombre.DataPropertyName = "CajaNombre"
        Me.columnMedioPagos_CajaNombre.HeaderText = "Caja"
        Me.columnMedioPagos_CajaNombre.Name = "columnMedioPagos_CajaNombre"
        Me.columnMedioPagos_CajaNombre.ReadOnly = True
        Me.columnMedioPagos_CajaNombre.Width = 53
        '
        'columnMedioPagos_Importe
        '
        Me.columnMedioPagos_Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "C2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.columnMedioPagos_Importe.DefaultCellStyle = DataGridViewCellStyle25
        Me.columnMedioPagos_Importe.HeaderText = "Importe"
        Me.columnMedioPagos_Importe.Name = "columnMedioPagos_Importe"
        Me.columnMedioPagos_Importe.ReadOnly = True
        Me.columnMedioPagos_Importe.Width = 67
        '
        'columnMedioPagos_BancoNombre
        '
        Me.columnMedioPagos_BancoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_BancoNombre.DataPropertyName = "BancoNombre"
        Me.columnMedioPagos_BancoNombre.HeaderText = "Banco"
        Me.columnMedioPagos_BancoNombre.Name = "columnMedioPagos_BancoNombre"
        Me.columnMedioPagos_BancoNombre.ReadOnly = True
        Me.columnMedioPagos_BancoNombre.Visible = False
        '
        'columnMedioPagos_Numero
        '
        Me.columnMedioPagos_Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_Numero.DataPropertyName = "Numero"
        Me.columnMedioPagos_Numero.HeaderText = "Número"
        Me.columnMedioPagos_Numero.Name = "columnMedioPagos_Numero"
        Me.columnMedioPagos_Numero.ReadOnly = True
        Me.columnMedioPagos_Numero.Visible = False
        '
        'columnMedioPagos_FechaVencimiento
        '
        Me.columnMedioPagos_FechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_FechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle26.Format = "d"
        Me.columnMedioPagos_FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle26
        Me.columnMedioPagos_FechaVencimiento.HeaderText = "Fecha de Vencimiento"
        Me.columnMedioPagos_FechaVencimiento.Name = "columnMedioPagos_FechaVencimiento"
        Me.columnMedioPagos_FechaVencimiento.ReadOnly = True
        Me.columnMedioPagos_FechaVencimiento.Visible = False
        '
        'toolstripMediosPago
        '
        Me.toolstripMediosPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMediosPago.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMediosPago.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonMediosPago_AgregarOtro, Me.buttonMediosPago_AgregarCheque, Me.buttonMediosPago_Editar, Me.buttonMediosPago_Eliminar})
        Me.toolstripMediosPago.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripMediosPago.Location = New System.Drawing.Point(3, 3)
        Me.toolstripMediosPago.Name = "toolstripMediosPago"
        Me.toolstripMediosPago.Size = New System.Drawing.Size(130, 256)
        Me.toolstripMediosPago.TabIndex = 4
        '
        'buttonMediosPago_AgregarOtro
        '
        Me.buttonMediosPago_AgregarOtro.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonMediosPago_AgregarOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_AgregarOtro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_AgregarOtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_AgregarOtro.Name = "buttonMediosPago_AgregarOtro"
        Me.buttonMediosPago_AgregarOtro.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_AgregarOtro.Text = "Agregar..."
        '
        'buttonMediosPago_AgregarCheque
        '
        Me.buttonMediosPago_AgregarCheque.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonMediosPago_AgregarCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_AgregarCheque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_AgregarCheque.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_AgregarCheque.Name = "buttonMediosPago_AgregarCheque"
        Me.buttonMediosPago_AgregarCheque.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_AgregarCheque.Text = "Agregar Cheque"
        '
        'buttonMediosPago_Editar
        '
        Me.buttonMediosPago_Editar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonMediosPago_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_Editar.Name = "buttonMediosPago_Editar"
        Me.buttonMediosPago_Editar.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_Editar.Text = "Editar"
        '
        'buttonMediosPago_Eliminar
        '
        Me.buttonMediosPago_Eliminar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonMediosPago_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_Eliminar.Name = "buttonMediosPago_Eliminar"
        Me.buttonMediosPago_Eliminar.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_Eliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(labelNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 22)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(950, 262)
        Me.tabpageNotasAuditoria.TabIndex = 5
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(113, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.Size = New System.Drawing.Size(831, 198)
        Me.textboxNotas.TabIndex = 32
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(113, 210)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 26
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(240, 210)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 27
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(113, 236)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 29
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(240, 236)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 30
        '
        'panelCabecera
        '
        Me.panelCabecera.AutoSize = True
        Me.panelCabecera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelCabecera.Controls.Add(Me.panelIdentificacion)
        Me.panelCabecera.Controls.Add(Me.panelFechas)
        Me.panelCabecera.Controls.Add(Me.panelEntidad)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCabecera.Location = New System.Drawing.Point(3, 3)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(958, 105)
        Me.panelCabecera.TabIndex = 0
        '
        'panelIdentificacion
        '
        Me.panelIdentificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelIdentificacion.Controls.Add(Me.textboxPuntoVenta)
        Me.panelIdentificacion.Controls.Add(Me.labelPuntoVenta)
        Me.panelIdentificacion.Controls.Add(Me.comboboxComprobanteTipo)
        Me.panelIdentificacion.Controls.Add(Me.labelComprobanteTipo)
        Me.panelIdentificacion.Controls.Add(Me.textboxNumero)
        Me.panelIdentificacion.Controls.Add(Me.labelComprobanteNumero)
        Me.panelIdentificacion.Controls.Add(Me.datetimepickerFechaEmision)
        Me.panelIdentificacion.Controls.Add(Me.labelFechaEmision)
        Me.panelIdentificacion.Controls.Add(Me.textboxIDComprobante)
        Me.panelIdentificacion.Controls.Add(Me.labelIDComprobante)
        Me.panelIdentificacion.Location = New System.Drawing.Point(3, 3)
        Me.panelIdentificacion.Name = "panelIdentificacion"
        Me.panelIdentificacion.Size = New System.Drawing.Size(793, 29)
        Me.panelIdentificacion.TabIndex = 0
        '
        'textboxPuntoVenta
        '
        Me.textboxPuntoVenta.Location = New System.Drawing.Point(407, 3)
        Me.textboxPuntoVenta.MaxLength = 4
        Me.textboxPuntoVenta.Name = "textboxPuntoVenta"
        Me.textboxPuntoVenta.Size = New System.Drawing.Size(38, 20)
        Me.textboxPuntoVenta.TabIndex = 5
        Me.textboxPuntoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelPuntoVenta
        '
        Me.labelPuntoVenta.AutoSize = True
        Me.labelPuntoVenta.Location = New System.Drawing.Point(317, 6)
        Me.labelPuntoVenta.Name = "labelPuntoVenta"
        Me.labelPuntoVenta.Size = New System.Drawing.Size(84, 13)
        Me.labelPuntoVenta.TabIndex = 4
        Me.labelPuntoVenta.Text = "Punto de Venta:"
        '
        'comboboxComprobanteTipo
        '
        Me.comboboxComprobanteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxComprobanteTipo.FormattingEnabled = True
        Me.comboboxComprobanteTipo.Location = New System.Drawing.Point(152, 3)
        Me.comboboxComprobanteTipo.Name = "comboboxComprobanteTipo"
        Me.comboboxComprobanteTipo.Size = New System.Drawing.Size(159, 21)
        Me.comboboxComprobanteTipo.TabIndex = 3
        '
        'labelComprobanteTipo
        '
        Me.labelComprobanteTipo.AutoSize = True
        Me.labelComprobanteTipo.Location = New System.Drawing.Point(110, 6)
        Me.labelComprobanteTipo.Name = "labelComprobanteTipo"
        Me.labelComprobanteTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelComprobanteTipo.TabIndex = 2
        Me.labelComprobanteTipo.Text = "Tipo:"
        '
        'textboxNumero
        '
        Me.textboxNumero.Location = New System.Drawing.Point(510, 3)
        Me.textboxNumero.MaxLength = 8
        Me.textboxNumero.Name = "textboxNumero"
        Me.textboxNumero.Size = New System.Drawing.Size(62, 20)
        Me.textboxNumero.TabIndex = 7
        Me.textboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelComprobanteNumero
        '
        Me.labelComprobanteNumero.AutoSize = True
        Me.labelComprobanteNumero.Location = New System.Drawing.Point(457, 6)
        Me.labelComprobanteNumero.Name = "labelComprobanteNumero"
        Me.labelComprobanteNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelComprobanteNumero.TabIndex = 6
        Me.labelComprobanteNumero.Text = "Número:"
        '
        'datetimepickerFechaEmision
        '
        Me.datetimepickerFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaEmision.Location = New System.Drawing.Point(684, 3)
        Me.datetimepickerFechaEmision.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaEmision.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaEmision.Name = "datetimepickerFechaEmision"
        Me.datetimepickerFechaEmision.Size = New System.Drawing.Size(104, 20)
        Me.datetimepickerFechaEmision.TabIndex = 9
        '
        'labelFechaEmision
        '
        Me.labelFechaEmision.AutoSize = True
        Me.labelFechaEmision.Location = New System.Drawing.Point(584, 6)
        Me.labelFechaEmision.Name = "labelFechaEmision"
        Me.labelFechaEmision.Size = New System.Drawing.Size(94, 13)
        Me.labelFechaEmision.TabIndex = 8
        Me.labelFechaEmision.Text = "Fecha de Emisión:"
        '
        'textboxIDComprobante
        '
        Me.textboxIDComprobante.Location = New System.Drawing.Point(30, 3)
        Me.textboxIDComprobante.MaxLength = 10
        Me.textboxIDComprobante.Name = "textboxIDComprobante"
        Me.textboxIDComprobante.ReadOnly = True
        Me.textboxIDComprobante.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDComprobante.TabIndex = 1
        Me.textboxIDComprobante.TabStop = False
        Me.textboxIDComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDComprobante
        '
        Me.labelIDComprobante.AutoSize = True
        Me.labelIDComprobante.Location = New System.Drawing.Point(3, 6)
        Me.labelIDComprobante.Name = "labelIDComprobante"
        Me.labelIDComprobante.Size = New System.Drawing.Size(21, 13)
        Me.labelIDComprobante.TabIndex = 0
        Me.labelIDComprobante.Text = "ID:"
        '
        'panelFechas
        '
        Me.panelFechas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaServicioHasta)
        Me.panelFechas.Controls.Add(labelFechaServicioHasta)
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaServicioDesde)
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaVencimiento)
        Me.panelFechas.Controls.Add(labelFechaServicioDesde)
        Me.panelFechas.Controls.Add(Me.labelFechaVencimiento)
        Me.panelFechas.Location = New System.Drawing.Point(3, 38)
        Me.panelFechas.Name = "panelFechas"
        Me.panelFechas.Size = New System.Drawing.Size(685, 29)
        Me.panelFechas.TabIndex = 1
        '
        'datetimepickerFechaServicioHasta
        '
        Me.datetimepickerFechaServicioHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaServicioHasta.Location = New System.Drawing.Point(560, 2)
        Me.datetimepickerFechaServicioHasta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioHasta.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioHasta.Name = "datetimepickerFechaServicioHasta"
        Me.datetimepickerFechaServicioHasta.ShowCheckBox = True
        Me.datetimepickerFechaServicioHasta.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaServicioHasta.TabIndex = 5
        '
        'datetimepickerFechaServicioDesde
        '
        Me.datetimepickerFechaServicioDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaServicioDesde.Location = New System.Drawing.Point(390, 2)
        Me.datetimepickerFechaServicioDesde.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioDesde.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioDesde.Name = "datetimepickerFechaServicioDesde"
        Me.datetimepickerFechaServicioDesde.ShowCheckBox = True
        Me.datetimepickerFechaServicioDesde.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaServicioDesde.TabIndex = 3
        '
        'datetimepickerFechaVencimiento
        '
        Me.datetimepickerFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaVencimiento.Location = New System.Drawing.Point(125, 2)
        Me.datetimepickerFechaVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaVencimiento.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaVencimiento.Name = "datetimepickerFechaVencimiento"
        Me.datetimepickerFechaVencimiento.ShowCheckBox = True
        Me.datetimepickerFechaVencimiento.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaVencimiento.TabIndex = 1
        '
        'labelFechaVencimiento
        '
        Me.labelFechaVencimiento.AutoSize = True
        Me.labelFechaVencimiento.Location = New System.Drawing.Point(3, 6)
        Me.labelFechaVencimiento.Name = "labelFechaVencimiento"
        Me.labelFechaVencimiento.Size = New System.Drawing.Size(116, 13)
        Me.labelFechaVencimiento.TabIndex = 0
        Me.labelFechaVencimiento.Text = "Fecha de Vencimiento:"
        '
        'panelEntidad
        '
        Me.panelEntidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelEntidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEntidad.Controls.Add(Me.buttonEntidad)
        Me.panelEntidad.Controls.Add(Me.textboxEntidad)
        Me.panelEntidad.Controls.Add(Me.labelEntidad)
        Me.panelEntidad.Location = New System.Drawing.Point(3, 73)
        Me.panelEntidad.Name = "panelEntidad"
        Me.panelEntidad.Size = New System.Drawing.Size(565, 29)
        Me.panelEntidad.TabIndex = 2
        '
        'buttonEntidad
        '
        Me.buttonEntidad.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_SEARCH_16
        Me.buttonEntidad.Location = New System.Drawing.Point(538, 2)
        Me.buttonEntidad.Name = "buttonEntidad"
        Me.buttonEntidad.Size = New System.Drawing.Size(22, 22)
        Me.buttonEntidad.TabIndex = 2
        Me.buttonEntidad.Text = "…"
        Me.buttonEntidad.UseVisualStyleBackColor = True
        '
        'textboxEntidad
        '
        Me.textboxEntidad.Location = New System.Drawing.Point(55, 3)
        Me.textboxEntidad.MaxLength = 150
        Me.textboxEntidad.Name = "textboxEntidad"
        Me.textboxEntidad.ReadOnly = True
        Me.textboxEntidad.Size = New System.Drawing.Size(483, 20)
        Me.textboxEntidad.TabIndex = 1
        '
        'labelEntidad
        '
        Me.labelEntidad.AutoSize = True
        Me.labelEntidad.Location = New System.Drawing.Point(3, 6)
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(46, 13)
        Me.labelEntidad.TabIndex = 0
        Me.labelEntidad.Text = "Entidad:"
        '
        'panelPie
        '
        Me.panelPie.AutoSize = True
        Me.panelPie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelPie.Controls.Add(Me.panelSubtotales)
        Me.panelPie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPie.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.panelPie.Location = New System.Drawing.Point(3, 408)
        Me.panelPie.Name = "panelPie"
        Me.panelPie.Padding = New System.Windows.Forms.Padding(4)
        Me.panelPie.Size = New System.Drawing.Size(958, 44)
        Me.panelPie.TabIndex = 2
        '
        'panelSubtotales
        '
        Me.panelSubtotales.AutoSize = True
        Me.panelSubtotales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelSubtotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSubtotales.Controls.Add(Me.textboxImporteTotal)
        Me.panelSubtotales.Controls.Add(Me.labelImporteTotal)
        Me.panelSubtotales.Controls.Add(Me.textboxImporteImpuesto)
        Me.panelSubtotales.Controls.Add(Me.labelImporteImpuesto)
        Me.panelSubtotales.Controls.Add(Me.textboxImporteSubtotal)
        Me.panelSubtotales.Controls.Add(Me.labelImporteSubtotal)
        Me.panelSubtotales.Location = New System.Drawing.Point(441, 7)
        Me.panelSubtotales.Name = "panelSubtotales"
        Me.panelSubtotales.Size = New System.Drawing.Size(506, 29)
        Me.panelSubtotales.TabIndex = 0
        '
        'textboxImporteTotal
        '
        Me.textboxImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxImporteTotal.Location = New System.Drawing.Point(396, 2)
        Me.textboxImporteTotal.Name = "textboxImporteTotal"
        Me.textboxImporteTotal.Size = New System.Drawing.Size(105, 22)
        Me.textboxImporteTotal.TabIndex = 5
        Me.textboxImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelImporteTotal
        '
        Me.labelImporteTotal.AutoSize = True
        Me.labelImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelImporteTotal.Location = New System.Drawing.Point(342, 5)
        Me.labelImporteTotal.Name = "labelImporteTotal"
        Me.labelImporteTotal.Size = New System.Drawing.Size(48, 16)
        Me.labelImporteTotal.TabIndex = 4
        Me.labelImporteTotal.Text = "Total:"
        '
        'textboxImporteImpuesto
        '
        Me.textboxImporteImpuesto.Location = New System.Drawing.Point(232, 3)
        Me.textboxImporteImpuesto.Name = "textboxImporteImpuesto"
        Me.textboxImporteImpuesto.Size = New System.Drawing.Size(80, 20)
        Me.textboxImporteImpuesto.TabIndex = 3
        Me.textboxImporteImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelImporteImpuesto
        '
        Me.labelImporteImpuesto.AutoSize = True
        Me.labelImporteImpuesto.Location = New System.Drawing.Point(168, 6)
        Me.labelImporteImpuesto.Name = "labelImporteImpuesto"
        Me.labelImporteImpuesto.Size = New System.Drawing.Size(58, 13)
        Me.labelImporteImpuesto.TabIndex = 2
        Me.labelImporteImpuesto.Text = "Impuestos:"
        '
        'textboxImporteSubtotal
        '
        Me.textboxImporteSubtotal.Location = New System.Drawing.Point(58, 3)
        Me.textboxImporteSubtotal.Name = "textboxImporteSubtotal"
        Me.textboxImporteSubtotal.Size = New System.Drawing.Size(80, 20)
        Me.textboxImporteSubtotal.TabIndex = 1
        Me.textboxImporteSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelImporteSubtotal
        '
        Me.labelImporteSubtotal.AutoSize = True
        Me.labelImporteSubtotal.Location = New System.Drawing.Point(3, 6)
        Me.labelImporteSubtotal.Name = "labelImporteSubtotal"
        Me.labelImporteSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.labelImporteSubtotal.TabIndex = 0
        Me.labelImporteSubtotal.Text = "Subtotal:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(964, 39)
        Me.toolstripMain.TabIndex = 0
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'formComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 514)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.MinimumSize = New System.Drawing.Size(690, 38)
        Me.Name = "formComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle del Comprobante"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageDetalle.ResumeLayout(False)
        Me.tabpageDetalle.PerformLayout()
        CType(Me.datagridviewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripDetalle.ResumeLayout(False)
        Me.toolstripDetalle.PerformLayout()
        Me.tabpageImpuestos.ResumeLayout(False)
        Me.tabpageImpuestos.PerformLayout()
        CType(Me.datagridviewImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripImpuestos.ResumeLayout(False)
        Me.toolstripImpuestos.PerformLayout()
        Me.tabpageAplicaciones.ResumeLayout(False)
        Me.tabpageAplicaciones.PerformLayout()
        CType(Me.datagridviewAplicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAplicaciones.ResumeLayout(False)
        Me.toolstripAplicaciones.PerformLayout()
        Me.tabpageAsociaciones.ResumeLayout(False)
        Me.tabpageAsociaciones.PerformLayout()
        CType(Me.datagridviewAsociaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAsociaciones.ResumeLayout(False)
        Me.toolstripAsociaciones.PerformLayout()
        Me.tabpageMediosPago.ResumeLayout(False)
        Me.tabpageMediosPago.PerformLayout()
        CType(Me.datagridviewMediosPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMediosPago.ResumeLayout(False)
        Me.toolstripMediosPago.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.panelCabecera.ResumeLayout(False)
        Me.panelIdentificacion.ResumeLayout(False)
        Me.panelIdentificacion.PerformLayout()
        Me.panelFechas.ResumeLayout(False)
        Me.panelFechas.PerformLayout()
        Me.panelEntidad.ResumeLayout(False)
        Me.panelEntidad.PerformLayout()
        Me.panelPie.ResumeLayout(False)
        Me.panelPie.PerformLayout()
        Me.panelSubtotales.ResumeLayout(False)
        Me.panelSubtotales.PerformLayout()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelCabecera As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelIdentificacion As System.Windows.Forms.Panel
    Friend WithEvents panelPie As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelSubtotales As System.Windows.Forms.Panel
    Friend WithEvents textboxImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents labelImporteTotal As System.Windows.Forms.Label
    Friend WithEvents textboxImporteImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents labelImporteImpuesto As System.Windows.Forms.Label
    Friend WithEvents textboxImporteSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents labelImporteSubtotal As System.Windows.Forms.Label
    Friend WithEvents textboxNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelComprobanteNumero As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaEmision As System.Windows.Forms.Label
    Friend WithEvents textboxIDComprobante As System.Windows.Forms.TextBox
    Friend WithEvents labelIDComprobante As System.Windows.Forms.Label
    Friend WithEvents panelEntidad As System.Windows.Forms.Panel
    Friend WithEvents buttonEntidad As System.Windows.Forms.Button
    Friend WithEvents textboxEntidad As System.Windows.Forms.TextBox
    Friend WithEvents labelEntidad As System.Windows.Forms.Label
    Friend WithEvents labelComprobanteTipo As System.Windows.Forms.Label
    Friend WithEvents comboboxComprobanteTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxPuntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents labelPuntoVenta As System.Windows.Forms.Label
    Friend WithEvents panelFechas As System.Windows.Forms.Panel
    Friend WithEvents datetimepickerFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaServicioHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaServicioDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents columnDetalle_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioUnitarioDescuentoPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioUnitarioDescuentoImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonDetalle_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonDetalle_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewImpuestos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripImpuestos As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonImpuestos_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonImpuestos_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonImpuestos_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewMediosPago As System.Windows.Forms.DataGridView
    Friend WithEvents columnMedioPagos_MedioPagoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_CajaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_BancoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents buttonDetalle_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabcontrolMain As CSColegio.DesktopApplication.CS_Control_TabControl
    Friend WithEvents tabpageDetalle As System.Windows.Forms.TabPage
    Friend WithEvents tabpageImpuestos As System.Windows.Forms.TabPage
    Friend WithEvents tabpageAplicaciones As System.Windows.Forms.TabPage
    Friend WithEvents tabpageAsociaciones As System.Windows.Forms.TabPage
    Friend WithEvents tabpageMediosPago As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents toolstripAplicaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAplicacion_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAplicacion_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewAplicaciones As System.Windows.Forms.DataGridView
    Friend WithEvents datagridviewAsociaciones As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripAsociaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAsociaciones_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAsociaciones_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMediosPago As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonMediosPago_AgregarOtro As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_AgregarCheque As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnAplicaciones_Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_NumeroCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_ImporteTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_ImporteAplicado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
