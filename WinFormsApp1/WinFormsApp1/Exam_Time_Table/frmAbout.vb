Imports System.Data.SqlClient
Imports WK.Libraries.TrialMakerNS

Public NotInheritable Class frmAbout
    Private Shared tm As New TrialMaker()

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
