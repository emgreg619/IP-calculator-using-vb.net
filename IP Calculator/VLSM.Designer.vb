<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VLSM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtSubnet = New System.Windows.Forms.TextBox()
        Me.txtHost1 = New System.Windows.Forms.TextBox()
        Me.txtHost2 = New System.Windows.Forms.TextBox()
        Me.txtHost3 = New System.Windows.Forms.TextBox()
        Me.txtHost4 = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(183, 33)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(76, 20)
        Me.txtIP.TabIndex = 0
        '
        'txtSubnet
        '
        Me.txtSubnet.Enabled = False
        Me.txtSubnet.Location = New System.Drawing.Point(183, 88)
        Me.txtSubnet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSubnet.Name = "txtSubnet"
        Me.txtSubnet.Size = New System.Drawing.Size(76, 20)
        Me.txtSubnet.TabIndex = 1
        Me.txtSubnet.Text = "4"
        Me.txtSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHost1
        '
        Me.txtHost1.Location = New System.Drawing.Point(340, 69)
        Me.txtHost1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHost1.Name = "txtHost1"
        Me.txtHost1.Size = New System.Drawing.Size(76, 20)
        Me.txtHost1.TabIndex = 2
        '
        'txtHost2
        '
        Me.txtHost2.Location = New System.Drawing.Point(340, 105)
        Me.txtHost2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHost2.Name = "txtHost2"
        Me.txtHost2.Size = New System.Drawing.Size(76, 20)
        Me.txtHost2.TabIndex = 3
        '
        'txtHost3
        '
        Me.txtHost3.Location = New System.Drawing.Point(340, 140)
        Me.txtHost3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHost3.Name = "txtHost3"
        Me.txtHost3.Size = New System.Drawing.Size(76, 20)
        Me.txtHost3.TabIndex = 4
        '
        'txtHost4
        '
        Me.txtHost4.Location = New System.Drawing.Point(340, 175)
        Me.txtHost4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHost4.Name = "txtHost4"
        Me.txtHost4.Size = New System.Drawing.Size(76, 20)
        Me.txtHost4.TabIndex = 5
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(11, 223)
        Me.btnback.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(87, 40)
        Me.btnback.TabIndex = 6
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(353, 223)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 40)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number Of Subnets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Input Hosts"
        '
        'VLSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(451, 274)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtHost4)
        Me.Controls.Add(Me.txtHost3)
        Me.Controls.Add(Me.txtHost2)
        Me.Controls.Add(Me.txtHost1)
        Me.Controls.Add(Me.txtSubnet)
        Me.Controls.Add(Me.txtIP)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "VLSM"
        Me.Text = "9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtSubnet As TextBox
    Friend WithEvents txtHost1 As TextBox
    Friend WithEvents txtHost2 As TextBox
    Friend WithEvents txtHost3 As TextBox
    Friend WithEvents txtHost4 As TextBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
