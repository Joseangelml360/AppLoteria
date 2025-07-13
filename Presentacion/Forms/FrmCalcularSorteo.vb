Imports Negocio

Public Class FrmCalcularSorteo

    Public ReadOnly eje As New EjercicioActivoNegocio
    Public ReadOnly vendor As New VendedoresNegocio

    Private Sub FrmCalcularSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ejercicio As Integer = CInt(Me.LblEjercicioActivo.Text)
        Dim nVendorExtra As Integer = vendor.ObtenerVendedoresExtra(ejercicio)
        ImportarDatos()
        Me.TxtJuvenilesLoteria.Text = vendor.ObtenerNumeroJuveniles
        Me.TxtMayoresLotería.Text = vendor.ObtenerNumeroMayores
        Me.TxtTotalVendorExtra.Text = CInt(TxtImportePapeleta.Text * nVendorExtra)
        Me.TxtNumVendedoresExtra.Text = nVendorExtra
        Me.TxtNuevoNumDecimos.Text = 0
        Me.TxtNuevoNumPpta.Text = 0
        CalcularPrevision()

    End Sub

    Private Sub ImportarDatos()
        Dim numMay, numJuv, nValM, nValJ As Integer
        Dim ctipoSorteo As String = Me.TxtTipoSorteo.Text

        numMay = eje.GetLoteriaMayores()
        numJuv = eje.GetLoteriaJuveniles

        Select Case ctipoSorteo
            Case "Ordinario"
                nValJ = eje.GetOrdinarioJuveniles
                nValM = eje.GetOrdinarioMayores
            Case "Navidad"
                nValJ = eje.GetNavidadJuveniles
                nValM = eje.GetNavidadMayores
            Case "Niño"
                nValJ = eje.GetReyesJuveniles
                nValM = eje.GetReyesMayores
        End Select

        Me.LblAsignadoJuveniles.Text = nValJ
        Me.LblAsignadoMayores.Text = nValM

    End Sub

    Private Sub TxtNuevoNumPpta_Leave(sender As Object, e As EventArgs) Handles TxtNuevoNumPpta.Leave
        Dim Importeppta As Double = Convert.ToDouble(Me.TxtImportePapeleta.Text)
        Dim Importedecimo As Double = Convert.ToDouble(Me.TxtImporteDecimo.Text)
        Dim Nuevonumpptas As Integer = CInt(Me.TxtNuevoNumPpta.Text)

        If Not IsNumeric(CInt(TxtNuevoNumPpta.Text)) Then
            MsgBox("Debes introducir un número")
            Me.TxtNuevoNumPpta.Focus()
        Else
            Me.TxtNuevoNumDecimos.Text = Math.Ceiling(Nuevonumpptas * Importeppta * 0.8 / Importedecimo)
        End If
    End Sub

    Private Sub TxtNuevoNumDecimos_Leave(sender As Object, e As EventArgs) Handles TxtNuevoNumDecimos.Leave
        Dim Importeppta As Double = Convert.ToDouble(Me.TxtImportePapeleta.Text)
        Dim Importedecimo As Double = Convert.ToDouble(Me.TxtImporteDecimo.Text)
        Dim Nuevonumdecimos As Integer = CInt(Me.TxtNuevoNumDecimos.Text)

        If Not IsNumeric(CInt(Me.TxtNuevoNumDecimos.Text)) Then
            MsgBox("Debes introducir un número")
            Me.TxtNuevoNumDecimos.Focus()
        Else
            Me.TxtNuevoNumPpta.Text = CInt(TxtNuevoNumDecimos.Text) * Importedecimo / (Importeppta * 0.8)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CalcularPrevision()
        Dim nImporteDecimo, nNumDecimosComprar, nImportePpta,
        nTotalImporteCuotaLoteria, nTotalImporteVendorExtra, nTotalPptasVenta,
        nTotalPptasImpresas, nTotalImpDecimos, nBeneficioVendorExtra, nTotalACuotas, nTotalAComision,
        nPptasACuotas, nTotalBeneficio As Double
        Dim nNumMay, nNumJuv, nImpMay, nImpJuv, nPptaAImprimir, nPptaAVenta, nPptaAComision, nPptaVendorExtra As Integer


        nNumMay = Convert.ToDouble(Me.TxtMayoresLotería.Text)
        nNumJuv = Convert.ToDouble(Me.TxtJuvenilesLoteria.Text)
        nImpMay = Convert.ToDouble(Me.LblAsignadoMayores.Text)
        nImpJuv = Convert.ToDouble(Me.LblAsignadoJuveniles.Text)
        nImporteDecimo = Convert.ToDouble(Me.TxtImporteDecimo.Text)
        nImportePpta = Convert.ToDouble(Me.TxtImportePapeleta.Text)


        nTotalImporteCuotaLoteria = (nNumMay * nImpMay + nNumJuv * nImpJuv)
        'total € en papeletas de vendedores con cuota lotería
        nTotalImporteVendorExtra = Convert.ToDouble(Me.TxtTotalVendorExtra.Text)     'total € en papeletas de vendedores sin cuota lotería
        nPptaVendorExtra = nTotalImporteVendorExtra / nImportePpta                  'nº de vendedores sin cuota de loteria
        nPptaAVenta = nPptaVendorExtra + (nTotalImporteCuotaLoteria / nImportePpta)
        nTotalPptasVenta = nPptaAVenta * nImportePpta
        nNumDecimosComprar = Math.Ceiling(nTotalPptasVenta * 0.8 / nImporteDecimo)
        nTotalImpDecimos = nNumDecimosComprar * nImporteDecimo
        nPptaAImprimir = Math.Ceiling(nTotalImpDecimos / (nImportePpta * 0.8))
        nTotalPptasImpresas = nPptaAImprimir * nImportePpta
        nPptaAComision = nPptaAImprimir - nPptaAVenta                           'sobrante de papeletas no asignadas a vendedores
        nTotalAComision = nPptaAComision * nImportePpta * 0.8
        nBeneficioVendorExtra = nTotalImporteVendorExtra * 0.1                  'Beneficio aplicadble a vendedores sin cuota loteria
        nPptasACuotas = nPptaAVenta - nPptaVendorExtra
        nTotalACuotas = nPptasACuotas * nImportePpta * 0.2                         'Total a cuotas por vendedores con cuota de lotería
        nTotalBeneficio = nTotalPptasVenta - nTotalImpDecimos - nTotalAComision - nTotalACuotas - nBeneficioVendorExtra 'Beneficio a Comision (contabilidad)

        Me.TxtPrevDecimosComprar.Text = nNumDecimosComprar
        Me.TxtPrevTotalDecimosComprar.Text = nTotalImpDecimos
        Me.TxtPrevPptaImprimir.Text = nPptaAImprimir
        Me.TxTPrevTotalPptasImprimir.Text = nTotalPptasImpresas
        Me.TxtPrevPptasAVenta.Text = nPptaAVenta
        Me.TxtPrevTotalPptasAVenta.Text = nTotalPptasVenta
        Me.TxtPrevPptasAcuota.Text = nPptasACuotas
        Me.TxtPrevPptasAcomision.Text = nPptaAComision
        Me.TxtPrevTotalPptasAComision.Text = nTotalAComision
        Me.TxtPrevBeneficioPptasVendorExtra.Text = nPptaVendorExtra
        Me.TxtPrevTotalBenefVendorExtra.Text = nBeneficioVendorExtra
        Me.TxtPrevTotalPptasACuotas.Text = nTotalACuotas
        Me.TxtPrevTotalBeneficio.Text = String.Format("{0:F2}", nTotalBeneficio)
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim nImporteDecimo, nNumDecimosComprar, nImportePpta,
       nTotalImporteVendorExtra, nTotalImpPptasVenta,
       nTotalPptasImpresas, nTotalImpDecimos, nBeneficioVendorExtra, nTotalACuotas, nTotalAComision,
       nPptasACuotas, nTotalBeneficio As Double
        Dim nPptaAImprimir, nPptaAVenta, nPptaAComision, nPptaVendorExtra As Integer

        ' calculos. 
        nImporteDecimo = Convert.ToDouble(Me.TxtImporteDecimo.Text)
        nImportePpta = Convert.ToDouble(Me.TxtImportePapeleta.Text)
        nPptaAVenta = CInt(Me.TxtNuevoNumPpta.Text)
        nNumDecimosComprar = CInt(Me.TxtNuevoNumDecimos.Text) 'nº de décimos a comprar
        nTotalImpDecimos = nNumDecimosComprar * nImporteDecimo
        nPptaAImprimir = Math.Ceiling(nTotalImpDecimos / (nImportePpta * 0.8))
        nTotalPptasImpresas = nPptaAImprimir * nImportePpta
        nTotalImpPptasVenta = nPptaAVenta * nImportePpta
        nPptaAComision = nPptaAImprimir - nPptaAVenta
        nTotalAComision = nPptaAComision * nImportePpta * 0.8
        nTotalImporteVendorExtra = Convert.ToDouble(Me.TxtTotalVendorExtra.Text) 'total € en papeletas de vendedores sin cuota lotería
        nPptaVendorExtra = nTotalImporteVendorExtra / nImportePpta   'nº de vendedores sin cuota de loteria
        nBeneficioVendorExtra = nTotalImporteVendorExtra * 0.1    'Beneficio aplicadble a vendedores sin cuota loteria
        nPptasACuotas = nPptaAVenta - nPptaVendorExtra
        nTotalACuotas = nPptasACuotas * nImportePpta * 0.2  'Total a cuotas por vendedores con cuota de lotería
        nTotalBeneficio = nTotalImpPptasVenta - nTotalImpDecimos - nTotalAComision - nBeneficioVendorExtra - nTotalACuotas 'Beneficio a Comision (contabilidad)

        Me.TxtDecimosComprar.Text = nNumDecimosComprar
        Me.TxtTotalDecimosComprar.Text = nTotalImpDecimos
        Me.TxtPptaImprimir.Text = nPptaAImprimir
        Me.TxtTotalPptasImprimir.Text = nTotalPptasImpresas
        Me.TxtPptasAVenta.Text = nPptaAVenta
        Me.TxtTotalPptasAVenta.Text = nTotalImpPptasVenta
        Me.TxtPptasACuota.Text = nPptasACuotas
        Me.TxtPptasAComision.Text = nPptaAComision
        Me.TxtTotalPptasAComision.Text = nTotalAComision
        Me.TxtBeneficioPptasVendorExtra.Text = nPptaVendorExtra
        Me.TxtTotalBenefVendorExtra.Text = nBeneficioVendorExtra
        Me.TxtTotalPptasACuotas.Text = nTotalACuotas
        Me.TxtTotalBeneficio.Text = String.Format("{0:F2}", nTotalBeneficio)
    End Sub

    Private Sub TxtNuevoNumDecimos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNuevoNumDecimos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnCalcular.Focus()
        End If
    End Sub

    Private Sub TxtNuevoNumPpta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNuevoNumPpta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnCalcular.Focus()
        End If
    End Sub

    Private Sub BtnAceptarCambios_Click(sender As Object, e As EventArgs) Handles BtnAceptarCambios.Click

        Me.Close()
    End Sub
End Class