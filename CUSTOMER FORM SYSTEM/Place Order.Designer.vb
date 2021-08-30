<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.ORDERTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test_1_with_2003_versionDataSet = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet()
        Me.Test1with2003versionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.Contacts = New System.Windows.Forms.Label()
        Me.ORDER_TABLETableAdapter = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.ORDER_TABLETableAdapter()
        Me.PriceComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.CUSTOMERTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMER_TABLETableAdapter = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.CUSTOMER_TABLETableAdapter()
        Me.ORDERTABLEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CustomerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.ContactsComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.ORDERTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1with2003versionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERTABLEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemComboBox
        '
        Me.ItemComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERTABLEBindingSource, "Item Ordered", True))
        Me.ItemComboBox.DataSource = Me.ORDERTABLEBindingSource
        Me.ItemComboBox.DisplayMember = "Item Ordered"
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.Location = New System.Drawing.Point(224, 139)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(220, 21)
        Me.ItemComboBox.TabIndex = 7
        Me.ItemComboBox.ValueMember = "Item Ordered"
        '
        'ORDERTABLEBindingSource
        '
        Me.ORDERTABLEBindingSource.DataMember = "ORDER TABLE"
        Me.ORDERTABLEBindingSource.DataSource = Me.Test_1_with_2003_versionDataSet
        '
        'Test_1_with_2003_versionDataSet
        '
        Me.Test_1_with_2003_versionDataSet.DataSetName = "test_1_with_2003_versionDataSet"
        Me.Test_1_with_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Test1with2003versionDataSetBindingSource
        '
        Me.Test1with2003versionDataSetBindingSource.DataSource = Me.Test_1_with_2003_versionDataSet
        Me.Test1with2003versionDataSetBindingSource.Position = 0
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(224, 178)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(82, 20)
        Me.QuantityTextBox.TabIndex = 9
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel.Location = New System.Drawing.Point(111, 182)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(80, 22)
        Me.QuantityLabel.TabIndex = 8
        Me.QuantityLabel.Text = "Quantity"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(307, 177)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(51, 22)
        Me.PriceLabel.TabIndex = 10
        Me.PriceLabel.Text = "Price"
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLabel.Location = New System.Drawing.Point(99, 144)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(98, 22)
        Me.ItemLabel.TabIndex = 6
        Me.ItemLabel.Text = "Item Name"
        '
        'TotalButton
        '
        Me.TotalButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalButton.Location = New System.Drawing.Point(613, 303)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(124, 31)
        Me.TotalButton.TabIndex = 12
        Me.TotalButton.Text = "Total"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(613, 340)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(124, 40)
        Me.RemoveButton.TabIndex = 14
        Me.RemoveButton.Text = "Cancel"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(613, 386)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(124, 30)
        Me.PrintButton.TabIndex = 16
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerColumn, Me.Column1, Me.ItemName, Me.Quantity, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(532, 248)
        Me.DataGridView1.TabIndex = 15
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLabel.Location = New System.Drawing.Point(75, 19)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(138, 22)
        Me.CustomerNameLabel.TabIndex = 0
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(125, 96)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(61, 22)
        Me.EmailLabel.TabIndex = 4
        Me.EmailLabel.Text = "Email"
        '
        'Contacts
        '
        Me.Contacts.AutoSize = True
        Me.Contacts.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacts.Location = New System.Drawing.Point(108, 55)
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Size = New System.Drawing.Size(78, 22)
        Me.Contacts.TabIndex = 2
        Me.Contacts.Text = "Contacts"
        '
        'ORDER_TABLETableAdapter
        '
        Me.ORDER_TABLETableAdapter.ClearBeforeFill = True
        '
        'PriceComboBox
        '
        Me.PriceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERTABLEBindingSource, "Price", True))
        Me.PriceComboBox.DataSource = Me.ORDERTABLEBindingSource
        Me.PriceComboBox.DisplayMember = "Price"
        Me.PriceComboBox.FormattingEnabled = True
        Me.PriceComboBox.Location = New System.Drawing.Point(364, 175)
        Me.PriceComboBox.Name = "PriceComboBox"
        Me.PriceComboBox.Size = New System.Drawing.Size(88, 21)
        Me.PriceComboBox.TabIndex = 17
        Me.PriceComboBox.ValueMember = "Price"
        '
        'PrintDocument1
        '
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(649, 220)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(88, 20)
        Me.TaxTextBox.TabIndex = 18
        Me.TaxTextBox.Text = "0.16"
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxLabel.Location = New System.Drawing.Point(550, 218)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(93, 22)
        Me.TaxLabel.TabIndex = 19
        Me.TaxLabel.Text = "Tax (VAT)"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(649, 180)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(88, 20)
        Me.SubTotalTextBox.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 22)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Subtotal"
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(613, 422)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(124, 40)
        Me.LogOutButton.TabIndex = 34
        Me.LogOutButton.Text = "Exit"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'CUSTOMERTABLEBindingSource
        '
        Me.CUSTOMERTABLEBindingSource.DataMember = "CUSTOMER TABLE"
        Me.CUSTOMERTABLEBindingSource.DataSource = Me.Test1with2003versionDataSetBindingSource
        '
        'CUSTOMER_TABLETableAdapter
        '
        Me.CUSTOMER_TABLETableAdapter.ClearBeforeFill = True
        '
        'ORDERTABLEBindingSource1
        '
        Me.ORDERTABLEBindingSource1.DataMember = "ORDER TABLE"
        Me.ORDERTABLEBindingSource1.DataSource = Me.Test1with2003versionDataSetBindingSource
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(613, 266)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(124, 31)
        Me.AddButton.TabIndex = 35
        Me.AddButton.Text = "Add New"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CustomerColumn
        '
        Me.CustomerColumn.HeaderText = "Customer Name"
        Me.CustomerColumn.Name = "CustomerColumn"
        Me.CustomerColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Contacts"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "Item Ordered"
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CUSTOMERTABLEBindingSource, "Customer Name", True))
        Me.CustomerComboBox.DataSource = Me.CUSTOMERTABLEBindingSource
        Me.CustomerComboBox.DisplayMember = "Customer Name"
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(224, 19)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(220, 21)
        Me.CustomerComboBox.TabIndex = 36
        Me.CustomerComboBox.ValueMember = "Customer Name"
        '
        'ContactsComboBox
        '
        Me.ContactsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CUSTOMERTABLEBindingSource, "Contacts", True))
        Me.ContactsComboBox.DataSource = Me.CUSTOMERTABLEBindingSource
        Me.ContactsComboBox.DisplayMember = "Contacts"
        Me.ContactsComboBox.FormattingEnabled = True
        Me.ContactsComboBox.Location = New System.Drawing.Point(224, 57)
        Me.ContactsComboBox.Name = "ContactsComboBox"
        Me.ContactsComboBox.Size = New System.Drawing.Size(220, 21)
        Me.ContactsComboBox.TabIndex = 37
        Me.ContactsComboBox.ValueMember = "Contacts"
        '
        'EmailComboBox
        '
        Me.EmailComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CUSTOMERTABLEBindingSource, "Email", True))
        Me.EmailComboBox.DataSource = Me.CUSTOMERTABLEBindingSource
        Me.EmailComboBox.DisplayMember = "Email"
        Me.EmailComboBox.FormattingEnabled = True
        Me.EmailComboBox.Location = New System.Drawing.Point(224, 96)
        Me.EmailComboBox.Name = "EmailComboBox"
        Me.EmailComboBox.Size = New System.Drawing.Size(220, 21)
        Me.EmailComboBox.TabIndex = 38
        Me.EmailComboBox.ValueMember = "Email"
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 480)
        Me.Controls.Add(Me.EmailComboBox)
        Me.Controls.Add(Me.ContactsComboBox)
        Me.Controls.Add(Me.CustomerComboBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.TaxTextBox)
        Me.Controls.Add(Me.PriceComboBox)
        Me.Controls.Add(Me.Contacts)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.ItemLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ORDERTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1with2003versionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERTABLEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemComboBox As ComboBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ItemLabel As Label
    Friend WithEvents TotalButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Contacts As Label
    Friend WithEvents Test1with2003versionDataSetBindingSource As BindingSource
    Friend WithEvents Test_1_with_2003_versionDataSet As test_1_with_2003_versionDataSet
    Friend WithEvents ORDERTABLEBindingSource As BindingSource
    Friend WithEvents ORDER_TABLETableAdapter As test_1_with_2003_versionDataSetTableAdapters.ORDER_TABLETableAdapter
    Friend WithEvents PriceComboBox As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents TaxLabel As Label
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogOutButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents CUSTOMERTABLEBindingSource As BindingSource
    Friend WithEvents CUSTOMER_TABLETableAdapter As test_1_with_2003_versionDataSetTableAdapters.CUSTOMER_TABLETableAdapter
    Friend WithEvents ORDERTABLEBindingSource1 As BindingSource
    Friend WithEvents AddButton As Button
    Friend WithEvents CustomerColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents ContactsComboBox As ComboBox
    Friend WithEvents EmailComboBox As ComboBox
End Class
