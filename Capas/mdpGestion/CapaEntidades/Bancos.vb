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

    Partial Public Class Bancos
        Public Property IdBanco As Integer
        Public Property Banco As String
        Public Property Activo As Boolean
    
        Public Overridable Property DetalleChequesEmitidos As ICollection(Of DetalleChequesEmitidos) = New HashSet(Of DetalleChequesEmitidos)
        Public Overridable Property DetalleChequesRecibidos As ICollection(Of DetalleChequesRecibidos) = New HashSet(Of DetalleChequesRecibidos)
    
    End Class

End Namespace
