Public Class VLSM
    Public Sub CalculateVLSM(ByVal ipAddress As String, ByVal numSubnets As Integer, ByVal numHosts1 As Integer, ByVal numHosts2 As Integer, ByVal numHosts3 As Integer, ByVal numHosts4 As Integer)

        'Validate the IP address
        If Not ValidateIP(ipAddress) Then
            MessageBox.Show("Invalid IP address.")
            Exit Sub
        End If

        'Validate the number of subnets
        If numSubnets < 1 Then
            MessageBox.Show("Invalid number of subnets.")
            Exit Sub
        End If

        'Validate the number of hosts
        If numHosts1 < 2 Then
            MessageBox.Show("Invalid number of hosts.")
            Exit Sub
        End If
        'Validate the number of hosts
        If numHosts2 < 2 Then
            MessageBox.Show("Invalid number of hosts.")
            Exit Sub
        End If
        'Validate the number of hosts
        If numHosts3 < 2 Then
            MessageBox.Show("Invalid number of hosts.")
            Exit Sub
        End If
        'Validate the number of hosts
        If numHosts4 < 2 Then
            MessageBox.Show("Invalid number of hosts.")
            Exit Sub
        End If

        'Convert IP address to integers
        Dim ipInt As Integer = IPAddressToInt(ipAddress)

        'Determine the number of host bits needed
        Dim hostBits1 As Integer = Math.Ceiling(Math.Log(numHosts1, 2))
        Dim hostBits2 As Integer = Math.Ceiling(Math.Log(numHosts2, 2))
        Dim hostBits3 As Integer = Math.Ceiling(Math.Log(numHosts3, 2))
        Dim hostBits4 As Integer = Math.Ceiling(Math.Log(numHosts4, 2))

        'Determine the number of subnet bits needed
        Dim subnetBits As Integer = Math.Ceiling(Math.Log(numSubnets, 2))

        'Determine the total number of bits needed for the subnet mask
        Dim maskBits As Integer = 32 - hostBits1 - hostBits2 - hostBits3 - hostBits4

        'Create a subnet mask by setting the appropriate number of bits to 1
        Dim maskInt As Integer = CInt(Math.Pow(2, maskBits) - 1) << hostBits1 << hostBits2 << hostBits3 << hostBits4

        'Determine the network address by performing a bitwise AND operation
        Dim networkInt As Integer = ipInt And maskInt

        'Convert the network address back to a string representation
        Dim networkAddress As String = IntToIPAddress(networkInt)

        'Calculate the range of valid host addresses
        Dim validRangeStart1 As String = IntToIPAddress(networkInt + 1)
        Dim validRangeEnd1 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) - 2)
        Dim validRangeStart2 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + 1)
        Dim validRangeEnd2 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + (2 ^ hostBits2) - 3)
        Dim validRangeStart3 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + (2 ^ hostBits2) - 2)
        Dim validRangeEnd3 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + (2 ^ hostBits2) + (2 ^ hostBits3) - 4)
        Dim validRangeStart4 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + (2 ^ hostBits2) + (2 ^ hostBits3) - 3)
        Dim validRangeEnd4 As String = IntToIPAddress(networkInt + (2 ^ hostBits1) + (2 ^ hostBits2) + (2 ^ hostBits3) + (2 ^ hostBits4) - 5)
        'Determine the class of the IP address
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

        'Output the results
        MessageBox.Show("Network Address: " & networkAddress & vbCrLf & "Valid Host Range 1: " & validRangeStart1 & " - " & validRangeEnd1 & vbCrLf & "Valid Host Range 2: " & validRangeStart2 & " - " & validRangeEnd2 & vbCrLf & "Valid Host Range 3: " & validRangeStart3 & " - " & validRangeEnd3 & vbCrLf & "Valid Host Range 4: " & validRangeStart4 & " - " & validRangeEnd4 & vbCrLf & "IP Class: " & classOfIP)
    End Sub

    'Helper function to validate an IP address
    Private Function ValidateIP(ByVal ipAddress As String) As Boolean
        Dim parts() As String = ipAddress.Split(".")
        If parts.Length <> 4 Then
            Return False
        End If
        For Each part As String In parts
            If Not Integer.TryParse(part, 0) OrElse Integer.Parse(part) < 0 OrElse Integer.Parse(part) > 255 Then
                Return False
            End If
        Next
        Return True
    End Function

    'Helper function to convert an IP address to an integer
    Private Function IPAddressToInt(ByVal ipAddress As String) As Integer
        Dim parts() As String = ipAddress.Split(".")
        Return Integer.Parse(parts(0)) << 24 Or Integer.Parse(parts(1)) << 16 Or Integer.Parse(parts(2)) << 8 Or Integer.Parse(parts(3))
    End Function

    'Helper function to convert an integer to an IP address
    Private Function IntToIPAddress(ByVal int As Integer) As String
        Return (int >> 24 And 255) & "." & (int >> 16 And 255) & "." & (int >> 8 And 255) & "." & (int And 255)
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateVLSM(txtIP.Text, CInt(txtSubnet.Text), CInt(txtHost1.Text), CInt(txtHost2.Text), CInt(txtHost3.Text), CInt(txtHost4.Text))
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class

