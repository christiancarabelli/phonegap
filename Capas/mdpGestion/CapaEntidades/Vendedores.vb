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

    Partial Public Class Vendedores
        Public Property IdVendedor As Integer
        Public Property Nombre As String
        Public Property Domicilio As String
        Public Property IdLocalidad As Integer
        Public Property Telefonos As String
        Public Property Fax As String
        Public Property Email As String
        Public Property Web As String
        Public Property Observaciones As String
        Public Property Cuit As String
        Public Property IIBB As String
        Public Property Comision As Decimal
        Public Property Activo As Boolean
    
        Public Overridable Property ComprobantesEmitidos As ICollection(Of ComprobantesEmitidos) = New HashSet(Of ComprobantesEmitidos)
        Public Overridable Property ComprobantesPedidosRecibidos As ICollection(Of ComprobantesPedidosRecibidos) = New HashSet(Of ComprobantesPedidosRecibidos)
        Public Overridable Property ComprobantesPresupuestosEmitidos As ICollection(Of ComprobantesPresupuestosEmitidos) = New HashSet(Of ComprobantesPresupuestosEmitidos)
        Public Overridable Property ComprobantesRemitosEmitidos As ICollection(Of ComprobantesRemitosEmitidos) = New HashSet(Of ComprobantesRemitosEmitidos)
        Public Overridable Property ComprobantesRemitosRecibidos As ICollection(Of ComprobantesRemitosRecibidos) = New HashSet(Of ComprobantesRemitosRecibidos)
        Public Overridable Property Localidades As Localidades
    
    End Class

End Namespace
