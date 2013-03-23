Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports CapaDatos.Datos
Imports CapaEntidades.Entidades
Imports System.Transactions

Namespace LogicaNegocios
    Public Class RubrosLN
        Shared Helper As New RubrosCD

        Public Shared Function GetAll() As IEnumerable(Of Rubros)
            Return Helper.GetAll()
        End Function

        Public Shared Function GetById(ByVal Id As Integer) As Rubros
            Return Helper.GetById(Id)
        End Function

        Public Shared Function Create(Rubro As Rubros) As Boolean
            Dim OperacionExistosa As Boolean = False
            Try
                If Validar(Rubro) Then
                    Using ts As New TransactionScope()
                        Helper.Create(Rubro)
                        ts.Complete()
                        OperacionExistosa = True
                    End Using
                End If
                Return OperacionExistosa
            Catch
                Return OperacionExistosa
            End Try
        End Function

        Public Shared Function Update(Rubro As Rubros) As Boolean
            Dim OperacionExistosa As Boolean = False
            Try
                If Validar(Rubro) Then
                    Using ts As New TransactionScope()
                        Helper.Update(Rubro)
                        ts.Complete()
                        OperacionExistosa = True
                    End Using
                End If
                Return OperacionExistosa
            Catch
                Return OperacionExistosa
            End Try
        End Function

        Public Shared Function Save(Rubro As Rubros) As Boolean
            Dim OperacionExistosa As Boolean = False
            Try
                If Validar(Rubro) Then
                    Using ts As New TransactionScope()
                        Helper.Save(Rubro)
                        ts.Complete()
                        OperacionExistosa = True
                    End Using
                End If
                Return OperacionExistosa
            Catch
                Return OperacionExistosa
            End Try
        End Function

        Public Shared Function Delete(ByVal Id As Integer) As Boolean
            Dim OperacionExistosa As Boolean = False
            Try

                Using ts As New TransactionScope()
                    Helper.Delete(ID)
                    ts.Complete()
                    OperacionExistosa = True
                End Using
                Return OperacionExistosa
            Catch
                Return OperacionExistosa
            End Try
        End Function

        Private Shared Function Validar(Rubro As Rubros) As Boolean

            If Rubro.Rubro.Length = 0 Then
                Throw New Exception("El Rubro esta vacio")
                Return False
            Else
                Return True
            End If

        End Function

    End Class
End Namespace


