﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSiniestroFinalizar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textboxPersona = New System.Windows.Forms.TextBox()
        Me.verificationcontrolHuellas = New DPFP.Gui.Verification.VerificationControl()
        Me.pictureboxFoto = New System.Windows.Forms.PictureBox()
        Me.pictureboxFlecha = New System.Windows.Forms.PictureBox()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.controlPersonaAsignar = New CSBomberos.ControlPersona()
        Me.buttonAsignar = New System.Windows.Forms.Button()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'textboxPersona
        '
        Me.textboxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPersona.Location = New System.Drawing.Point(226, 95)
        Me.textboxPersona.Name = "textboxPersona"
        Me.textboxPersona.ReadOnly = True
        Me.textboxPersona.Size = New System.Drawing.Size(388, 22)
        Me.textboxPersona.TabIndex = 2
        Me.textboxPersona.TabStop = False
        '
        'verificationcontrolHuellas
        '
        Me.verificationcontrolHuellas.Active = True
        Me.verificationcontrolHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.verificationcontrolHuellas.Location = New System.Drawing.Point(12, 82)
        Me.verificationcontrolHuellas.Name = "verificationcontrolHuellas"
        Me.verificationcontrolHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.verificationcontrolHuellas.Size = New System.Drawing.Size(48, 48)
        Me.verificationcontrolHuellas.TabIndex = 9
        '
        'pictureboxFoto
        '
        Me.pictureboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureboxFoto.Location = New System.Drawing.Point(130, 61)
        Me.pictureboxFoto.Name = "pictureboxFoto"
        Me.pictureboxFoto.Size = New System.Drawing.Size(90, 90)
        Me.pictureboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxFoto.TabIndex = 94
        Me.pictureboxFoto.TabStop = False
        '
        'pictureboxFlecha
        '
        Me.pictureboxFlecha.Image = Global.CSBomberos.My.Resources.Resources.ImageSiguiente24
        Me.pictureboxFlecha.Location = New System.Drawing.Point(79, 96)
        Me.pictureboxFlecha.Name = "pictureboxFlecha"
        Me.pictureboxFlecha.Size = New System.Drawing.Size(24, 24)
        Me.pictureboxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxFlecha.TabIndex = 95
        Me.pictureboxFlecha.TabStop = False
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(627, 39)
        Me.toolstripMain.TabIndex = 96
        '
        'controlPersonaAsignar
        '
        Me.controlPersonaAsignar.ApellidoNombre = Nothing
        Me.controlPersonaAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlPersonaAsignar.dbContext = Nothing
        Me.controlPersonaAsignar.IDCuartel = Nothing
        Me.controlPersonaAsignar.IDPersona = Nothing
        Me.controlPersonaAsignar.Location = New System.Drawing.Point(226, 123)
        Me.controlPersonaAsignar.MatriculaNumeroDigitos = Nothing
        Me.controlPersonaAsignar.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.controlPersonaAsignar.MinimumSize = New System.Drawing.Size(150, 21)
        Me.controlPersonaAsignar.Name = "controlPersonaAsignar"
        Me.controlPersonaAsignar.ReadOnlyText = False
        Me.controlPersonaAsignar.Size = New System.Drawing.Size(316, 21)
        Me.controlPersonaAsignar.SoloMostrarEnAsistencia = False
        Me.controlPersonaAsignar.SoloMostrarEstadoActivo = True
        Me.controlPersonaAsignar.TabIndex = 99
        Me.controlPersonaAsignar.Visible = False
        '
        'buttonAsignar
        '
        Me.buttonAsignar.Location = New System.Drawing.Point(548, 123)
        Me.buttonAsignar.Name = "buttonAsignar"
        Me.buttonAsignar.Size = New System.Drawing.Size(66, 21)
        Me.buttonAsignar.TabIndex = 98
        Me.buttonAsignar.Text = "Asignar"
        Me.buttonAsignar.UseVisualStyleBackColor = True
        Me.buttonAsignar.Visible = False
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'formSiniestroFinalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 166)
        Me.Controls.Add(Me.controlPersonaAsignar)
        Me.Controls.Add(Me.buttonAsignar)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.pictureboxFlecha)
        Me.Controls.Add(Me.pictureboxFoto)
        Me.Controls.Add(Me.verificationcontrolHuellas)
        Me.Controls.Add(Me.textboxPersona)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroFinalizar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Finalizar siniestro"
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxPersona As TextBox
    Friend WithEvents verificationcontrolHuellas As DPFP.Gui.Verification.VerificationControl
    Friend WithEvents pictureboxFoto As PictureBox
    Friend WithEvents pictureboxFlecha As PictureBox
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents controlPersonaAsignar As ControlPersona
    Friend WithEvents buttonAsignar As Button
    Friend WithEvents buttonCerrar As ToolStripButton
End Class
