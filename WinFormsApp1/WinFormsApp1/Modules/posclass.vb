Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SqlClient

Public Class posclass

    Function getpackstatus(id As Integer, productname As String) As Double
        Dim qty As Double = 0

        Using con As New SqlConnection(cs)
            con.Open()
            Dim cb4 As String = "SELECT * FROM Product WHERE PID = @d1 AND ispack = 1"
            Using cmd As New SqlCommand(cb4, con)
                cmd.Parameters.AddWithValue("@d1", id)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Select Case Trim(productname)
                            Case Trim(reader("productname").ToString() + "(" + reader("pn1").ToString() + ")")
                                qty = CDbl(reader("pq1"))
                            Case Trim(reader("productname").ToString() + "(" + reader("pn2").ToString() + ")")
                                qty = CDbl(reader("pq2"))
                            Case Trim(reader("productname").ToString() + "(" + reader("pn3").ToString() + ")")
                                qty = CDbl(reader("pq3"))
                            Case Trim(reader("productname").ToString() + "(" + reader("pn4").ToString() + ")")
                                qty = CDbl(reader("pq4"))
                            Case Else
                                qty = 0
                        End Select
                    End If
                End Using
            End Using
        End Using

        Return qty
    End Function


End Class
