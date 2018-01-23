Public Class frmStartWindow

    Private Sub cmdVBnet_Click(sender As System.Object, e As System.EventArgs) Handles cmdVBnet.Click

        Dim frmGetVBData As New VB_sqlServer_Connection.frmGetVBData

        frmGetVBData.ShowDialog(Me)

    End Sub

    Private Sub cmdCsharp_Click(sender As System.Object, e As System.EventArgs) Handles cmdCsharp.Click

        Dim frmGetCSharpData As New CSharp_sqlServer_Connection.frmGetCSharpData

        frmGetCSharpData.ShowDialog(Me)

    End Sub

End Class
