'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Entidades

    Partial Public Class ComprobantesCobros
        Public Property IdComprobante As Integer
        Public Property IdCtaCteMovimiento As Integer
        Public Property Fecha As Date
        Public Property Comprobante As String
        Public Property TipoComprobante As String
        Public Property PuntoVenta As Decimal
        Public Property NumeroComprobante As Decimal
        Public Property Monto As Decimal
        Public Property Observacion As String
        Public Property Activo As Boolean
    
        Public Overridable Property ClientesCtasCtes As ClientesCtasCtes
        Public Overridable Property ComprobantesCobrosDetalle As ICollection(Of ComprobantesCobrosDetalle) = New HashSet(Of ComprobantesCobrosDetalle)
    
    End Class

End Namespace
