Imports System.Net

Public Class IP_Subnetvb
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Get the IP address and CIDR from the text boxes
        Dim ipAddress As String = txtIP.Text
        Dim cidr As String = txtSubnet.Text

        ' Create an IPNetwork object from the IP address and CIDR
        Dim ipnetwork As IPNetwork = IPNetwork.Parse(ipAddress & "/" & cidr)

        ' Get the valid range
        Dim validRange = ipnetwork.FirstUsable.ToString & " - " & ipnetwork.LastUsable.ToString

        ' Get the new subnet mask
        Dim newSubnet = ipnetwork.Netmask.ToString

        ' Get the actual host IP
        Dim hostIP = ipnetwork.LastUsable.ToString

        ' Get the actual network ID
        Dim networkID = ipnetwork.Network.ToString

        ' Get the IP class
        Dim classOfIP As String
        Dim firstOctet As Integer = Integer.Parse(ipAddress.Split(".")(0))
        If firstOctet >= 1 And firstOctet <= 127 Then
            classOfIP = "A"
        ElseIf firstOctet >= 128 And firstOctet <= 191 Then
            classOfIP = "B"
        ElseIf firstOctet >= 192 And firstOctet <= 223 Then
            classOfIP = "C"
        ElseIf firstOctet >= 224 And firstOctet <= 239 Then
            classOfIP = "D"
        Else
            classOfIP = "E"
        End If

        ' Display the results
        lblResults.Text = "Class of IP: " & classOfIP & Environment.NewLine & "Valid Range: " & validRange & Environment.NewLine & "Subnet Mask: " & newSubnet & Environment.NewLine & "Actual Host: " & hostIP & Environment.NewLine & "Actual Network: " & networkID
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSubnet.Clear()
        txtIP.Clear()
        lblResults.ResetText()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class
