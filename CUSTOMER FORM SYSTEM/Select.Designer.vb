<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Direction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Direction))
        Me.CustomerInformationButton = New System.Windows.Forms.Button()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.EmployeeInfoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerInformationButton
        '
        Me.CustomerInformationButton.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerInformationButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInformationButton.Location = New System.Drawing.Point(197, 54)
        Me.CustomerInformationButton.Name = "CustomerInformationButton"
        Me.CustomerInformationButton.Size = New System.Drawing.Size(250, 66)
        Me.CustomerInformationButton.TabIndex = 0
        Me.CustomerInformationButton.Text = "Customer Information"
        Me.CustomerInformationButton.UseVisualStyleBackColor = False
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.BackColor = System.Drawing.SystemColors.Control
        Me.PlaceOrderButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOrderButton.Location = New System.Drawing.Point(197, 242)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(250, 66)
        Me.PlaceOrderButton.TabIndex = 1
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = False
        '
        'EmployeeInfoButton
        '
        Me.EmployeeInfoButton.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeInfoButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeInfoButton.Location = New System.Drawing.Point(197, 157)
        Me.EmployeeInfoButton.Name = "EmployeeInfoButton"
        Me.EmployeeInfoButton.Size = New System.Drawing.Size(250, 64)
        Me.EmployeeInfoButton.TabIndex = 2
        Me.EmployeeInfoButton.Text = "Employee Information"
        Me.EmployeeInfoButton.UseVisualStyleBackColor = False
        '
        'Direction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 355)
        Me.Controls.Add(Me.EmployeeInfoButton)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.CustomerInformationButton)
        Me.Name = "Direction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerInformationButton As Button
    Friend WithEvents PlaceOrderButton As Button
    Friend WithEvents EmployeeInfoButton As Button
End Class
