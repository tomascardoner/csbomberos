﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAccidente
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
        Dim labelFolioNumero As System.Windows.Forms.Label
        Dim labelLibroNumero As System.Windows.Forms.Label
        Dim labelActaNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDAccidente = New System.Windows.Forms.TextBox()
        Me.labelIDAccidente = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.textboxDisminucionFisica = New System.Windows.Forms.TextBox()
        Me.labelDisminucionFisica = New System.Windows.Forms.Label()
        Me.textboxCapacidad = New System.Windows.Forms.TextBox()
        Me.labelCapacidad = New System.Windows.Forms.Label()
        Me.labelFechaAlta = New System.Windows.Forms.Label()
        Me.datetimepickerFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.textboxDiagnostico = New System.Windows.Forms.TextBox()
        Me.labelDiagnostico = New System.Windows.Forms.Label()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        labelFolioNumero = New System.Windows.Forms.Label()
        labelLibroNumero = New System.Windows.Forms.Label()
        labelActaNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(197, 158)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelFolioNumero.TabIndex = 8
        labelFolioNumero.Text = "Folio N°:"
        '
        'labelLibroNumero
        '
        labelLibroNumero.AutoSize = True
        labelLibroNumero.Location = New System.Drawing.Point(12, 158)
        labelLibroNumero.Name = "labelLibroNumero"
        labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelLibroNumero.TabIndex = 6
        labelLibroNumero.Text = "Libro N°:"
        '
        'labelActaNumero
        '
        labelActaNumero.AutoSize = True
        labelActaNumero.Location = New System.Drawing.Point(330, 158)
        labelActaNumero.Name = "labelActaNumero"
        labelActaNumero.Size = New System.Drawing.Size(47, 13)
        labelActaNumero.TabIndex = 10
        labelActaNumero.Text = "Acta N°:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(473, 39)
        Me.toolstripMain.TabIndex = 20
        '
        'textboxIDAccidente
        '
        Me.textboxIDAccidente.Location = New System.Drawing.Point(117, 50)
        Me.textboxIDAccidente.MaxLength = 10
        Me.textboxIDAccidente.Name = "textboxIDAccidente"
        Me.textboxIDAccidente.ReadOnly = True
        Me.textboxIDAccidente.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDAccidente.TabIndex = 1
        Me.textboxIDAccidente.TabStop = False
        Me.textboxIDAccidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDAccidente
        '
        Me.labelIDAccidente.AutoSize = True
        Me.labelIDAccidente.Location = New System.Drawing.Point(12, 53)
        Me.labelIDAccidente.Name = "labelIDAccidente"
        Me.labelIDAccidente.Size = New System.Drawing.Size(21, 13)
        Me.labelIDAccidente.TabIndex = 0
        Me.labelIDAccidente.Text = "ID:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(117, 76)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 3
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(12, 82)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 2
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(117, 313)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(340, 47)
        Me.textboxNotas.TabIndex = 19
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(12, 316)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 18
        Me.labelNotas.Text = "Notas:"
        '
        'textboxDisminucionFisica
        '
        Me.textboxDisminucionFisica.Location = New System.Drawing.Point(117, 260)
        Me.textboxDisminucionFisica.MaxLength = 500
        Me.textboxDisminucionFisica.Multiline = True
        Me.textboxDisminucionFisica.Name = "textboxDisminucionFisica"
        Me.textboxDisminucionFisica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDisminucionFisica.Size = New System.Drawing.Size(340, 47)
        Me.textboxDisminucionFisica.TabIndex = 17
        '
        'labelDisminucionFisica
        '
        Me.labelDisminucionFisica.AutoSize = True
        Me.labelDisminucionFisica.Location = New System.Drawing.Point(12, 263)
        Me.labelDisminucionFisica.Name = "labelDisminucionFisica"
        Me.labelDisminucionFisica.Size = New System.Drawing.Size(99, 13)
        Me.labelDisminucionFisica.TabIndex = 16
        Me.labelDisminucionFisica.Text = "Disminución Física:"
        '
        'textboxCapacidad
        '
        Me.textboxCapacidad.Location = New System.Drawing.Point(117, 207)
        Me.textboxCapacidad.MaxLength = 500
        Me.textboxCapacidad.Multiline = True
        Me.textboxCapacidad.Name = "textboxCapacidad"
        Me.textboxCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxCapacidad.Size = New System.Drawing.Size(340, 47)
        Me.textboxCapacidad.TabIndex = 15
        '
        'labelCapacidad
        '
        Me.labelCapacidad.AutoSize = True
        Me.labelCapacidad.Location = New System.Drawing.Point(12, 210)
        Me.labelCapacidad.Name = "labelCapacidad"
        Me.labelCapacidad.Size = New System.Drawing.Size(61, 13)
        Me.labelCapacidad.TabIndex = 14
        Me.labelCapacidad.Text = "Capacidad:"
        '
        'labelFechaAlta
        '
        Me.labelFechaAlta.AutoSize = True
        Me.labelFechaAlta.Location = New System.Drawing.Point(12, 187)
        Me.labelFechaAlta.Name = "labelFechaAlta"
        Me.labelFechaAlta.Size = New System.Drawing.Size(61, 13)
        Me.labelFechaAlta.TabIndex = 12
        Me.labelFechaAlta.Text = "Fecha Alta:"
        '
        'datetimepickerFechaAlta
        '
        Me.datetimepickerFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAlta.Location = New System.Drawing.Point(117, 181)
        Me.datetimepickerFechaAlta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.Name = "datetimepickerFechaAlta"
        Me.datetimepickerFechaAlta.ShowCheckBox = True
        Me.datetimepickerFechaAlta.Size = New System.Drawing.Size(139, 20)
        Me.datetimepickerFechaAlta.TabIndex = 13
        '
        'textboxDiagnostico
        '
        Me.textboxDiagnostico.Location = New System.Drawing.Point(117, 102)
        Me.textboxDiagnostico.MaxLength = 500
        Me.textboxDiagnostico.Multiline = True
        Me.textboxDiagnostico.Name = "textboxDiagnostico"
        Me.textboxDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDiagnostico.Size = New System.Drawing.Size(340, 47)
        Me.textboxDiagnostico.TabIndex = 5
        '
        'labelDiagnostico
        '
        Me.labelDiagnostico.AutoSize = True
        Me.labelDiagnostico.Location = New System.Drawing.Point(12, 105)
        Me.labelDiagnostico.Name = "labelDiagnostico"
        Me.labelDiagnostico.Size = New System.Drawing.Size(66, 13)
        Me.labelDiagnostico.TabIndex = 4
        Me.labelDiagnostico.Text = "Diagnóstico:"
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(250, 155)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 9
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(117, 155)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 7
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(383, 155)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 11
        '
        'formPersonaAccidente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 379)
        Me.Controls.Add(Me.textboxFolioNumero)
        Me.Controls.Add(labelFolioNumero)
        Me.Controls.Add(labelLibroNumero)
        Me.Controls.Add(Me.textboxLibroNumero)
        Me.Controls.Add(labelActaNumero)
        Me.Controls.Add(Me.textboxActaNumero)
        Me.Controls.Add(Me.textboxDisminucionFisica)
        Me.Controls.Add(Me.labelDisminucionFisica)
        Me.Controls.Add(Me.textboxCapacidad)
        Me.Controls.Add(Me.labelCapacidad)
        Me.Controls.Add(Me.labelFechaAlta)
        Me.Controls.Add(Me.datetimepickerFechaAlta)
        Me.Controls.Add(Me.textboxDiagnostico)
        Me.Controls.Add(Me.labelDiagnostico)
        Me.Controls.Add(Me.textboxNotas)
        Me.Controls.Add(Me.labelNotas)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.datetimepickerFecha)
        Me.Controls.Add(Me.labelIDAccidente)
        Me.Controls.Add(Me.textboxIDAccidente)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAccidente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Accidente de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxIDAccidente As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAccidente As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents textboxDisminucionFisica As System.Windows.Forms.TextBox
    Friend WithEvents labelDisminucionFisica As System.Windows.Forms.Label
    Friend WithEvents textboxCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents labelCapacidad As System.Windows.Forms.Label
    Friend WithEvents labelFechaAlta As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents textboxDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents labelDiagnostico As System.Windows.Forms.Label
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
End Class
