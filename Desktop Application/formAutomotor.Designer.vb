﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAutomotor
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelAutomotorTipo As System.Windows.Forms.Label
        Dim labelCombustibleTipo As System.Windows.Forms.Label
        Dim labelFechaAdquisicion As System.Windows.Forms.Label
        Me.textboxModelo = New System.Windows.Forms.TextBox()
        Me.labelModelo = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDAutomotor = New System.Windows.Forms.TextBox()
        Me.labelIDAutomotor = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxAutomotorTipo = New System.Windows.Forms.ComboBox()
        Me.textboxNumero = New System.Windows.Forms.TextBox()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textboxMarca = New System.Windows.Forms.TextBox()
        Me.labelMarca = New System.Windows.Forms.Label()
        Me.textboxAnio = New System.Windows.Forms.TextBox()
        Me.labelAnio = New System.Windows.Forms.Label()
        Me.textboxDominio = New System.Windows.Forms.TextBox()
        Me.labelDominio = New System.Windows.Forms.Label()
        Me.comboboxCombustibleTipo = New System.Windows.Forms.ComboBox()
        Me.textboxKilometrajeInicial = New System.Windows.Forms.TextBox()
        Me.labelKilometrajeInicial = New System.Windows.Forms.Label()
        Me.textboxCapacidadAguaLitros = New System.Windows.Forms.TextBox()
        Me.labelCapacidadAguaLitros = New System.Windows.Forms.Label()
        Me.datetimepickerFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        labelEsActivo = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelAutomotorTipo = New System.Windows.Forms.Label()
        labelCombustibleTipo = New System.Windows.Forms.Label()
        labelFechaAdquisicion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(12, 367)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 24
        labelEsActivo.Text = "Activo:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(12, 341)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 22
        labelCuartel.Text = "Cuartel:"
        '
        'labelAutomotorTipo
        '
        labelAutomotorTipo.AutoSize = True
        labelAutomotorTipo.Location = New System.Drawing.Point(12, 183)
        labelAutomotorTipo.Name = "labelAutomotorTipo"
        labelAutomotorTipo.Size = New System.Drawing.Size(31, 13)
        labelAutomotorTipo.TabIndex = 10
        labelAutomotorTipo.Text = "Tipo:"
        '
        'textboxModelo
        '
        Me.textboxModelo.Location = New System.Drawing.Point(135, 128)
        Me.textboxModelo.MaxLength = 50
        Me.textboxModelo.Name = "textboxModelo"
        Me.textboxModelo.Size = New System.Drawing.Size(266, 20)
        Me.textboxModelo.TabIndex = 7
        '
        'labelModelo
        '
        Me.labelModelo.AutoSize = True
        Me.labelModelo.Location = New System.Drawing.Point(12, 131)
        Me.labelModelo.Name = "labelModelo"
        Me.labelModelo.Size = New System.Drawing.Size(45, 13)
        Me.labelModelo.TabIndex = 6
        Me.labelModelo.Text = "Modelo:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(417, 39)
        Me.toolstripMain.TabIndex = 26
        '
        'textboxIDAutomotor
        '
        Me.textboxIDAutomotor.Location = New System.Drawing.Point(135, 50)
        Me.textboxIDAutomotor.MaxLength = 10
        Me.textboxIDAutomotor.Name = "textboxIDAutomotor"
        Me.textboxIDAutomotor.ReadOnly = True
        Me.textboxIDAutomotor.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDAutomotor.TabIndex = 1
        Me.textboxIDAutomotor.TabStop = False
        Me.textboxIDAutomotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDAutomotor
        '
        Me.labelIDAutomotor.AutoSize = True
        Me.labelIDAutomotor.Location = New System.Drawing.Point(12, 53)
        Me.labelIDAutomotor.Name = "labelIDAutomotor"
        Me.labelIDAutomotor.Size = New System.Drawing.Size(21, 13)
        Me.labelIDAutomotor.TabIndex = 0
        Me.labelIDAutomotor.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(135, 367)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 25
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(135, 338)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 23
        '
        'comboboxAutomotorTipo
        '
        Me.comboboxAutomotorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAutomotorTipo.FormattingEnabled = True
        Me.comboboxAutomotorTipo.Location = New System.Drawing.Point(135, 180)
        Me.comboboxAutomotorTipo.Name = "comboboxAutomotorTipo"
        Me.comboboxAutomotorTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxAutomotorTipo.TabIndex = 11
        '
        'textboxNumero
        '
        Me.textboxNumero.Location = New System.Drawing.Point(135, 76)
        Me.textboxNumero.MaxLength = 5
        Me.textboxNumero.Name = "textboxNumero"
        Me.textboxNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxNumero.TabIndex = 3
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(12, 79)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 2
        Me.labelNumero.Text = "Número:"
        '
        'textboxMarca
        '
        Me.textboxMarca.Location = New System.Drawing.Point(135, 102)
        Me.textboxMarca.MaxLength = 50
        Me.textboxMarca.Name = "textboxMarca"
        Me.textboxMarca.Size = New System.Drawing.Size(266, 20)
        Me.textboxMarca.TabIndex = 5
        '
        'labelMarca
        '
        Me.labelMarca.AutoSize = True
        Me.labelMarca.Location = New System.Drawing.Point(12, 105)
        Me.labelMarca.Name = "labelMarca"
        Me.labelMarca.Size = New System.Drawing.Size(40, 13)
        Me.labelMarca.TabIndex = 4
        Me.labelMarca.Text = "Marca:"
        '
        'textboxAnio
        '
        Me.textboxAnio.Location = New System.Drawing.Point(135, 154)
        Me.textboxAnio.MaxLength = 4
        Me.textboxAnio.Name = "textboxAnio"
        Me.textboxAnio.Size = New System.Drawing.Size(47, 20)
        Me.textboxAnio.TabIndex = 9
        '
        'labelAnio
        '
        Me.labelAnio.AutoSize = True
        Me.labelAnio.Location = New System.Drawing.Point(12, 157)
        Me.labelAnio.Name = "labelAnio"
        Me.labelAnio.Size = New System.Drawing.Size(29, 13)
        Me.labelAnio.TabIndex = 8
        Me.labelAnio.Text = "Año:"
        '
        'textboxDominio
        '
        Me.textboxDominio.Location = New System.Drawing.Point(135, 233)
        Me.textboxDominio.MaxLength = 50
        Me.textboxDominio.Name = "textboxDominio"
        Me.textboxDominio.Size = New System.Drawing.Size(74, 20)
        Me.textboxDominio.TabIndex = 15
        '
        'labelDominio
        '
        Me.labelDominio.AutoSize = True
        Me.labelDominio.Location = New System.Drawing.Point(12, 236)
        Me.labelDominio.Name = "labelDominio"
        Me.labelDominio.Size = New System.Drawing.Size(48, 13)
        Me.labelDominio.TabIndex = 14
        Me.labelDominio.Text = "Dominio:"
        '
        'comboboxCombustibleTipo
        '
        Me.comboboxCombustibleTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCombustibleTipo.FormattingEnabled = True
        Me.comboboxCombustibleTipo.Location = New System.Drawing.Point(135, 259)
        Me.comboboxCombustibleTipo.Name = "comboboxCombustibleTipo"
        Me.comboboxCombustibleTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCombustibleTipo.TabIndex = 17
        '
        'labelCombustibleTipo
        '
        labelCombustibleTipo.AutoSize = True
        labelCombustibleTipo.Location = New System.Drawing.Point(12, 262)
        labelCombustibleTipo.Name = "labelCombustibleTipo"
        labelCombustibleTipo.Size = New System.Drawing.Size(106, 13)
        labelCombustibleTipo.TabIndex = 16
        labelCombustibleTipo.Text = "Tipo de Combustible:"
        '
        'textboxKilometrajeInicial
        '
        Me.textboxKilometrajeInicial.Location = New System.Drawing.Point(135, 286)
        Me.textboxKilometrajeInicial.MaxLength = 8
        Me.textboxKilometrajeInicial.Name = "textboxKilometrajeInicial"
        Me.textboxKilometrajeInicial.Size = New System.Drawing.Size(74, 20)
        Me.textboxKilometrajeInicial.TabIndex = 19
        '
        'labelKilometrajeInicial
        '
        Me.labelKilometrajeInicial.AutoSize = True
        Me.labelKilometrajeInicial.Location = New System.Drawing.Point(12, 289)
        Me.labelKilometrajeInicial.Name = "labelKilometrajeInicial"
        Me.labelKilometrajeInicial.Size = New System.Drawing.Size(91, 13)
        Me.labelKilometrajeInicial.TabIndex = 18
        Me.labelKilometrajeInicial.Text = "Kilometraje Inicial:"
        '
        'textboxCapacidadAguaLitros
        '
        Me.textboxCapacidadAguaLitros.Location = New System.Drawing.Point(135, 312)
        Me.textboxCapacidadAguaLitros.MaxLength = 8
        Me.textboxCapacidadAguaLitros.Name = "textboxCapacidadAguaLitros"
        Me.textboxCapacidadAguaLitros.Size = New System.Drawing.Size(74, 20)
        Me.textboxCapacidadAguaLitros.TabIndex = 21
        '
        'labelCapacidadAguaLitros
        '
        Me.labelCapacidadAguaLitros.AutoSize = True
        Me.labelCapacidadAguaLitros.Location = New System.Drawing.Point(12, 315)
        Me.labelCapacidadAguaLitros.Name = "labelCapacidadAguaLitros"
        Me.labelCapacidadAguaLitros.Size = New System.Drawing.Size(95, 13)
        Me.labelCapacidadAguaLitros.TabIndex = 20
        Me.labelCapacidadAguaLitros.Text = "Capacidad (Litros):"
        '
        'labelFechaAdquisicion
        '
        labelFechaAdquisicion.AutoSize = True
        labelFechaAdquisicion.Location = New System.Drawing.Point(12, 209)
        labelFechaAdquisicion.Name = "labelFechaAdquisicion"
        labelFechaAdquisicion.Size = New System.Drawing.Size(112, 13)
        labelFechaAdquisicion.TabIndex = 12
        labelFechaAdquisicion.Text = "Fecha de Adquisición:"
        '
        'datetimepickerFechaAdquisicion
        '
        Me.datetimepickerFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAdquisicion.Location = New System.Drawing.Point(135, 207)
        Me.datetimepickerFechaAdquisicion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.Name = "datetimepickerFechaAdquisicion"
        Me.datetimepickerFechaAdquisicion.ShowCheckBox = True
        Me.datetimepickerFechaAdquisicion.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaAdquisicion.TabIndex = 13
        '
        'formAutomotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 393)
        Me.Controls.Add(Me.datetimepickerFechaAdquisicion)
        Me.Controls.Add(labelFechaAdquisicion)
        Me.Controls.Add(Me.textboxCapacidadAguaLitros)
        Me.Controls.Add(Me.labelCapacidadAguaLitros)
        Me.Controls.Add(Me.textboxKilometrajeInicial)
        Me.Controls.Add(Me.labelKilometrajeInicial)
        Me.Controls.Add(Me.comboboxCombustibleTipo)
        Me.Controls.Add(labelCombustibleTipo)
        Me.Controls.Add(Me.textboxDominio)
        Me.Controls.Add(Me.labelDominio)
        Me.Controls.Add(Me.textboxAnio)
        Me.Controls.Add(Me.labelAnio)
        Me.Controls.Add(Me.textboxMarca)
        Me.Controls.Add(Me.labelMarca)
        Me.Controls.Add(Me.textboxNumero)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.comboboxAutomotorTipo)
        Me.Controls.Add(labelAutomotorTipo)
        Me.Controls.Add(Me.comboboxCuartel)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.labelIDAutomotor)
        Me.Controls.Add(Me.textboxIDAutomotor)
        Me.Controls.Add(Me.textboxModelo)
        Me.Controls.Add(Me.labelModelo)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formAutomotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ubicación"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxModelo As System.Windows.Forms.TextBox
    Friend WithEvents labelModelo As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxIDAutomotor As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAutomotor As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxAutomotorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelNumero As System.Windows.Forms.Label
    Friend WithEvents textboxMarca As System.Windows.Forms.TextBox
    Friend WithEvents labelMarca As System.Windows.Forms.Label
    Friend WithEvents textboxAnio As System.Windows.Forms.TextBox
    Friend WithEvents labelAnio As System.Windows.Forms.Label
    Friend WithEvents textboxDominio As System.Windows.Forms.TextBox
    Friend WithEvents labelDominio As System.Windows.Forms.Label
    Friend WithEvents comboboxCombustibleTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxKilometrajeInicial As System.Windows.Forms.TextBox
    Friend WithEvents labelKilometrajeInicial As System.Windows.Forms.Label
    Friend WithEvents textboxCapacidadAguaLitros As System.Windows.Forms.TextBox
    Friend WithEvents labelCapacidadAguaLitros As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaAdquisicion As System.Windows.Forms.DateTimePicker
End Class