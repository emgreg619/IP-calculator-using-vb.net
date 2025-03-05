Public Class Form1
    Private Sub btnVLSM_Click(sender As Object, e As EventArgs) Handles btnVLSM.Click
        Dim VLSM As New VLSM()
        VLSM.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IP_Subnetvb As New IP_Subnetvb()
        IP_Subnetvb.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Host_Subnetting As New Host_subnetting()
        Host_Subnetting.Show()
        Me.Hide()
    End Sub
End Class
