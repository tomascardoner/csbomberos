﻿Imports System.IO

Public Class formComprobantesTransmitirPagomiscuentas

#Region "Declarations"
    Private dbContext As New CSColegioContext(True)
    Private listComprobantes As List(Of GridDataRow)

    Private Class GridDataRow
        Public Property IDComprobante As Integer
        Public Property ComprobanteTipoNombre As String
        Public Property NumeroCompleto As String
        Public Property ApellidoNombre As String
        Public Property ImporteTotal As Decimal
    End Class
#End Region

#Region "Form stuff"
    Private Sub formComprobantesTransmitirPagomiscuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonTransmitir.Enabled = False
        comboboxCantidad.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, "500", "200", "100", "50", "20", "10", "5", "1"})
    End Sub

    Private Sub formComprobantesTransmitirPagomiscuentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dbContext.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Private Sub RefreshData()
        Me.Cursor = Cursors.WaitCursor

        Try

            Select Case comboboxCantidad.SelectedIndex
                Case 0  ' Todos
                    listComprobantes = (From c In dbContext.Comprobante
                                        Join ct In dbContext.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                                        Where ct.EmisionElectronica And c.CAE IsNot Nothing And c.IDUsuarioTransmisionPagomiscuentas Is Nothing And c.IDUsuarioAnulacion Is Nothing
                                        Order By ct.Nombre, c.NumeroCompleto
                                        Select New GridDataRow With {.IDComprobante = c.IDComprobante, .ComprobanteTipoNombre = ct.Nombre, .NumeroCompleto = c.NumeroCompleto, .ApellidoNombre = c.ApellidoNombre, .ImporteTotal = c.ImporteTotal}).ToList

                Case Is > 0 ' Cantidad de Comprobantes
                    listComprobantes = (From c In dbContext.Comprobante
                                        Join ct In dbContext.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                                        Where ct.EmisionElectronica And c.CAE IsNot Nothing And c.IDUsuarioTransmisionPagomiscuentas Is Nothing And c.IDUsuarioAnulacion Is Nothing
                                        Order By ct.Nombre, c.PuntoVenta, c.Numero
                                        Select New GridDataRow With {.IDComprobante = c.IDComprobante, .ComprobanteTipoNombre = ct.Nombre, .NumeroCompleto = c.NumeroCompleto, .ApellidoNombre = c.ApellidoNombre, .ImporteTotal = c.ImporteTotal}).Take(CInt(comboboxCantidad.Text)).ToList

            End Select

            datagridviewComprobantes.AutoGenerateColumns = False
            datagridviewComprobantes.DataSource = listComprobantes

            Select Case listComprobantes.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Comprobantes para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Comprobante.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Comprobantes.", listComprobantes.Count)
            End Select

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al obtener la lista de Comprobantes.")
        End Try

        Me.Cursor = Cursors.Default

        buttonTransmitir.Enabled = (listComprobantes.Count > 0)
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub comboboxLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxCantidad.SelectedIndexChanged
        RefreshData()
    End Sub

    Private Sub buttonTransmitir_Click(sender As Object, e As EventArgs) Handles buttonTransmitir.Click
        If listComprobantes.Count > 0 Then
            If CS_Parameter.GetIntegerAsShort(Parametros.EMPRESA_PRISMA_NUMERO) = 0 Then
                MsgBox("No está especificado el Número de Empresa otorgado por PRISMA.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            TransmitirComprobantes()
        End If
    End Sub
#End Region

#Region "Extra stuff"
    Private Function TransmitirComprobantes() As Boolean
        Dim HeaderTextStream As String
        Dim DetalleTextStream As String
        Dim TrailerTextStream As String

        Dim GridDataRowActual As GridDataRow
        Dim ComprobanteActual As Comprobante
        Dim DetalleCount As Integer = 0
        Dim DetalleImporteTotal As Decimal = 0

        Dim FolderName As String
        Dim FileName As String

        Foldername = CS_SpecialFolders.ProcessString(My.Settings.Exchange_Outbound_Folder)
        If Not Foldername.EndsWith("\") Then
            Foldername &= "\"
        End If
        FolderName &= "PagoMisCuentas\"
        If Not Directory.Exists(FolderName) Then
            Directory.CreateDirectory(FolderName)
        End If

        FileName = "FAC" & CS_Parameter.GetIntegerAsShort(Parametros.EMPRESA_PRISMA_NUMERO).ToString.PadRight(4, "0"c) & "." & DateTime.Today.ToString("ddMMyy")

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Using outputFile As New StreamWriter(FolderName & FileName)

            ' Header
            HeaderTextStream = "0"                                                                              ' Código de Registro
            HeaderTextStream &= "400"                                                                           ' Código Prisma
            HeaderTextStream &= CS_Parameter.GetIntegerAsShort(Parametros.EMPRESA_PRISMA_NUMERO).ToString.PadRight(4, "0"c)     ' Código Empresa Prisma
            HeaderTextStream &= DateTime.Today.ToString("yyyyMMdd")                                             ' Fecha de generación del archivo
            HeaderTextStream &= StrDup(264, "0"c)                                                               ' Filler
            outputFile.WriteLine(HeaderTextStream)

            For Each RowActual As DataGridViewRow In datagridviewComprobantes.Rows
                GridDataRowActual = CType(RowActual.DataBoundItem, GridDataRow)
                ComprobanteActual = dbContext.Comprobante.Find(GridDataRowActual.IDComprobante)
                If Not ComprobanteActual Is Nothing Then
                    ' Detalle
                    DetalleTextStream = "5"                                                                 ' Código de Registro
                    DetalleTextStream &= ComprobanteActual.Entidad.IDEntidad.ToString.PadLeft(6, "0"c) & StrDup(13, " "c)      ' Número de Referencia
                    DetalleTextStream &= ComprobanteActual.NumeroCompleto.ToString.PadLeft(20, "0"c)        ' Id. Factura
                    DetalleTextStream &= "0"                                                                ' Código de Moneda
                    DetalleTextStream &= ComprobanteActual.FechaEmision.ToString("yyyyMMdd")                ' Fecha 1er. vencimiento
                    DetalleTextStream &= ComprobanteActual.ImporteTotal.ToString("000000000.00").Replace(My.Application.Culture.NumberFormat.NumberDecimalSeparator, "")    ' Importe 1er. vencimiento
                    DetalleTextStream &= StrDup(8, " "c)                                                    ' Fecha 2do. vencimiento
                    DetalleTextStream &= StrDup(11, "0"c)                                                   ' Importe 2do. vencimiento
                    DetalleTextStream &= StrDup(8, " "c)                                                    ' Fecha 3er. vencimiento
                    DetalleTextStream &= StrDup(11, "0"c)                                                   ' Importe 3er. vencimiento
                    DetalleTextStream &= StrDup(19, "0"c)                                                   ' Filler
                    DetalleTextStream &= ComprobanteActual.Entidad.IDEntidad.ToString.PadLeft(6, "0"c) & StrDup(13, " "c)      ' Número de Referencia anterior
                    DetalleTextStream &= (ComprobanteActual.ComprobanteTipo.NombreConLetra & " " & ComprobanteActual.NumeroCompleto).PadLeft(40, " "c)          ' Mensaje Ticket
                    DetalleTextStream &= (ComprobanteActual.ComprobanteTipo.Sigla & ComprobanteActual.PuntoVenta & ComprobanteActual.Numero).PadLeft(15, " "c)  ' Mensaje Pantalla
                    DetalleTextStream &= StrDup(60, " "c)                                                   ' Código de barras
                    DetalleTextStream &= StrDup(29, "0"c)                                                   ' Filler
                    outputFile.WriteLine(DetalleTextStream)

                    DetalleCount += 1
                    DetalleImporteTotal += ComprobanteActual.ImporteTotal
                End If
            Next

            ' Tariler
            TrailerTextStream = "9"                                                                             ' Código de Registro
            TrailerTextStream &= "400"                                                                          ' Código Prisma
            TrailerTextStream &= CS_Parameter.GetIntegerAsShort(Parametros.EMPRESA_PRISMA_NUMERO).ToString.PadRight(4, "0"c)        ' Código Empresa Prisma
            TrailerTextStream &= DateTime.Today.ToString("yyyyMMdd")                                            ' Fecha de generación del archivo
            TrailerTextStream &= DetalleCount.ToString.PadRight(7, "0"c)                                        ' Cantidad de regostros de detalle
            TrailerTextStream &= StrDup(7, "0"c)                                                                ' Filler
            TrailerTextStream &= DetalleImporteTotal.ToString("00000000000000.00").Replace(My.Application.Culture.NumberFormat.NumberDecimalSeparator, "")      ' Total Importe 1er. vencimiento
            TrailerTextStream &= StrDup(234, "0"c)                                                              ' Filler
            outputFile.WriteLine(TrailerTextStream)

        End Using

        MsgBox(String.Format("Se ha generado exitosamente el archivo de intercambio con PagoMisCuentas, conteniendo {0} Comprobantes.", listComprobantes.Count), MsgBoxStyle.Information, My.Application.Info.Title)

        RefreshData()

        Me.Cursor = Cursors.Default

        Return True
    End Function

#End Region

End Class