Imports System.Net

Public Class Host_subnetting
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Get the input values
        Dim numHosts As Integer
        Dim ipAndMask As String = txtIPAddress.Text.Trim()

        'Split the input into IP address and subnet mask in CIDR notation
        Dim parts() As String = ipAndMask.Split("/")
        Dim ipAddressString As String = parts(0)
        Dim subnetBits As Integer

        'Check if the entered value is valid and within the valid range
        If Not Integer.TryParse(parts(1), subnetBits) Or subnetBits < 0 Or subnetBits > 32 Then
            MessageBox.Show("Invalid subnet mask")
            Return
        End If

        'Check if the entered value is valid and within the valid range
        If Not Integer.TryParse(txtNumHosts.Text, numHosts) Or numHosts < 0 Then
            MessageBox.Show("Invalid number of hosts")
            Return
        End If

        'Check if the entered IP address is valid
        If Not System.Text.RegularExpressions.Regex.IsMatch(ipAddressString, "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$") Then
            MessageBox.Show("Invalid IP address")
            Return
        End If

        ' Convert the IP address to bytes
        Dim ipBytes() As Byte = IPAddress.Parse(ipAddressString).GetAddressBytes()

        ' Get the number of bits required for the subnet mask
        Dim hostBits As Integer = CInt(Math.Ceiling(Math.Log(numHosts, 2)))
        subnetBits = 32 - hostBits

        ' Create the subnet mask bytes array
        Dim subnetMaskBytes(3) As Byte
        For i As Integer = 0 To 3
            If (i < subnetBits / 8) Then
                subnetMaskBytes(i) = 255
            ElseIf (i = subnetBits / 8) Then
                Dim subnetMaskByte As Byte = BitConverter.GetBytes(CInt(256 - 2 ^ (32 - subnetBits)) - 1)(0)
                subnetMaskBytes(i) = subnetMaskByte
            Else
                subnetMaskBytes(i) = 0
            End If
        Next
        ' Create the subnet mask
        Dim subnetMask As New IPAddress(subnetMaskBytes)

        ' Calculate the network address
        Dim networkBytes(3) As Byte
        For i As Integer = 0 To 3
            networkBytes(i) = CByte(ipBytes(i) And subnetMaskBytes(i))
        Next
        Dim networkAddress As New IPAddress(networkBytes)

        ' Calculate the broadcast address
        Dim broadcastBytes(3) As Byte
        For i As Integer = 0 To 3
            broadcastBytes(i) = CByte(ipBytes(i) Or (255 - subnetMaskBytes(i)))
        Next
        Dim broadcastAddress As New IPAddress(broadcastBytes)

        ' Calculate the first and last host addresses
        Dim firstHostBytes(3) As Byte
        Array.Copy(networkBytes, firstHostBytes, 4)
        firstHostBytes(3) += 1
        Dim firstHost As New IPAddress(firstHostBytes)

        Dim lastHostBytes(3) As Byte
        Array.Copy(broadcastBytes, lastHostBytes, 4)
        lastHostBytes(3) -= 1
        Dim lastHost As New IPAddress(lastHostBytes)
        lblResults.Text = "Subnet Mask: " & subnetMask.ToString() & Environment.NewLine & "Network Address: " & networkAddress.ToString() & Environment.NewLine & "First Host: " & firstHost.ToString() & Environment.NewLine & "Last Host: " & lastHost.ToString() & Environment.NewLine & "Broadcast Address: " & broadcastAddress.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class