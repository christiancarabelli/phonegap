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

    Partial Public Class ComprobantesEmitidosDetalle
        Public Property IdComprobanteEmitidoDetalle As Integer
        Public Property IdComprobante As Integer
        Public Property IdArticulo As Integer
        Public Property Descripcion As String
        Public Property Cantidad As Integer
        Public Property PrecioCostoNeto As Decimal
        Public Property PrecioCostoBruto As Decimal
        Public Property PrecioUnitarioNeto As Decimal
        Public Property PrecioUnitarioBruto As Decimal
        Public Property TasaIva As Decimal
        Public Property Remitido As Boolean
    
        Public Overridable Property Articulos As Articulos
        Public Overridable Property ArticulosCantidades As ICollection(Of ArticulosCantidades) = New HashSet(Of ArticulosCantidades)
        Public Overridable Property ComprobantesEmitidos As ComprobantesEmitidos
    
    End Class

End Namespace
