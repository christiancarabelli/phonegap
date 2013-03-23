Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports CapaEntidades.Entidades

Namespace Datos
    Public Class RubrosCD

        'public IEnumerable<Articulos> GetAllArticulos()
        '{
        '    using (Contexto = new mdpGestionEMPRESAEntities())
        '    {

        '        var result = Contexto.Articulos
        '            .Include("SubRubros.Rubros")
        '            .Include("SubRubros")
        '            .Include("Escalas1")
        '            .Include("Escalas2")
        '            .Include("Proveedores")
        '            .Include("ArticulosPreciosVenta")
        '            .Include("ArticulosPreciosCosto");

        '        return result.ToList();
        '    }

        '}

        Private Contexto As New mdpGestionEMPRESAEntities

        Public Function GetAll() As IEnumerable(Of Rubros)

            Dim result = From E In Contexto.Rubros Select E
            Return result.ToList()

        End Function

        Public Function GetById(ByVal Id As Integer) As Rubros

            Dim result = From E In Contexto.Rubros Where E.IdRubro = Id Select E
            Return result.SingleOrDefault

        End Function

        Public Sub Create(Rubro As Rubros)

            Contexto.Rubros.Add(Rubro)
            Contexto.SaveChanges()

        End Sub

        Public Sub Update(Rubro As Rubros)

            Dim R As Rubros = (From E In Contexto.Rubros
                Where E.IdRubro = Rubro.IdRubro).First()

            R.Rubro = Rubro.Rubro
            Contexto.SaveChanges()

        End Sub

        Public Sub Delete(ID As Integer)

            Dim Rubro As Rubros = (From E In Contexto.Rubros
                Where E.IdRubro = ID).First()
            Contexto.Rubros.Remove(Rubro)
            Contexto.SaveChanges()

        End Sub

        Public Sub Save(Rubro As Rubros)

            If Rubro.IdRubro <> 0 Then
                Dim R As Rubros = (From E In Contexto.Rubros
                    Where E.IdRubro = Rubro.IdRubro).First()

                R.Rubro = Rubro.Rubro
                R.Activo = Rubro.Activo
            Else
                Dim R As New Rubros()

                R.Rubro = Rubro.Rubro
                R.Activo = Rubro.Activo
                Contexto.Rubros.Add(Rubro)
            End If
            Contexto.SaveChanges()

        End Sub

    End Class


End Namespace



