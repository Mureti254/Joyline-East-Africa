<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Information
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
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim ContactsLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Information))
        Me.CustomerInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test_1_with_2003_versionDataSet = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactsTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_TABLETableAdapter = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.CUSTOMER_TABLETableAdapter()
        Me.TableAdapterManager = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.CUSTOMER_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ORDER_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Customer_NameLabel = New System.Windows.Forms.Label()
        ContactsLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Me.CustomerInfoGroupBox.SuspendLayout()
        CType(Me.CUSTOMER_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMER_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMER_TABLEBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(18, 60)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(144, 22)
        Customer_NameLabel.TabIndex = 2
        Customer_NameLabel.Text = "Customer Name:"
        '
        'ContactsLabel
        '
        ContactsLabel.AutoSize = True
        ContactsLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactsLabel.Location = New System.Drawing.Point(72, 92)
        ContactsLabel.Name = "ContactsLabel"
        ContactsLabel.Size = New System.Drawing.Size(84, 22)
        ContactsLabel.TabIndex = 4
        ContactsLabel.Text = "Contacts:"
        AddHandler ContactsLabel.Click, AddressOf Me.ContactsLabel_Click
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(72, 132)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(67, 22)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(45, 25)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(117, 22)
        Customer_IDLabel.TabIndex = 33
        Customer_IDLabel.Text = "Customer ID:"
        '
        'CustomerInfoGroupBox
        '
        Me.CustomerInfoGroupBox.Controls.Add(Me.Button1)
        Me.CustomerInfoGroupBox.Controls.Add(Customer_IDLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Customer_IDTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.LogOutButton)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Delete)
        Me.CustomerInfoGroupBox.Controls.Add(Me.AddButton)
        Me.CustomerInfoGroupBox.Controls.Add(EmailLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.EmailTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(ContactsLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.ContactsTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Customer_NameLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Customer_NameTextBox)
        Me.CustomerInfoGroupBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfoGroupBox.Location = New System.Drawing.Point(41, 61)
        Me.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        Me.CustomerInfoGroupBox.Size = New System.Drawing.Size(497, 254)
        Me.CustomerInfoGroupBox.TabIndex = 0
        Me.CustomerInfoGroupBox.TabStop = False
        Me.CustomerInfoGroupBox.Text = "Customers Information"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_TABLEBindingSource, "Customer ID", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(211, 22)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Customer_IDTextBox.TabIndex = 34
        '
        'CUSTOMER_TABLEBindingSource
        '
        Me.CUSTOMER_TABLEBindingSource.DataMember = "CUSTOMER TABLE"
        Me.CUSTOMER_TABLEBindingSource.DataSource = Me.Test_1_with_2003_versionDataSet
        '
        'Test_1_with_2003_versionDataSet
        '
        Me.Test_1_with_2003_versionDataSet.DataSetName = "test_1_with_2003_versionDataSet"
        Me.Test_1_with_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(331, 173)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(124, 40)
        Me.LogOutButton.TabIndex = 33
        Me.LogOutButton.Text = "Exit"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(211, 173)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(114, 40)
        Me.Delete.TabIndex = 16
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(117, 173)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(89, 40)
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "Add New"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_TABLEBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(211, 129)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(229, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'ContactsTextBox
        '
        Me.ContactsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_TABLEBindingSource, "Contacts", True))
        Me.ContactsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactsTextBox.Location = New System.Drawing.Point(211, 92)
        Me.ContactsTextBox.Name = "ContactsTextBox"
        Me.ContactsTextBox.Size = New System.Drawing.Size(229, 20)
        Me.ContactsTextBox.TabIndex = 5
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_TABLEBindingSource, "Customer Name", True))
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(211, 62)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Customer_NameTextBox.TabIndex = 3
        '
        'CUSTOMER_TABLETableAdapter
        '
        Me.CUSTOMER_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMER_TABLETableAdapter = Me.CUSTOMER_TABLETableAdapter
        Me.TableAdapterManager.DEPARTMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEE_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ORDER_TABLETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUSTOMER_TABLEBindingNavigator
        '
        Me.CUSTOMER_TABLEBindingNavigator.AddNewItem = Nothing
        Me.CUSTOMER_TABLEBindingNavigator.BindingSource = Me.CUSTOMER_TABLEBindingSource
        Me.CUSTOMER_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMER_TABLEBindingNavigator.DeleteItem = Nothing
        Me.CUSTOMER_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ORDER_TABLEBindingNavigatorSaveItem})
        Me.CUSTOMER_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMER_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUSTOMER_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUSTOMER_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUSTOMER_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUSTOMER_TABLEBindingNavigator.Name = "CUSTOMER_TABLEBindingNavigator"
        Me.CUSTOMER_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMER_TABLEBindingNavigator.Size = New System.Drawing.Size(1112, 25)
        Me.CUSTOMER_TABLEBindingNavigator.TabIndex = 1
        Me.CUSTOMER_TABLEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ORDER_TABLEBindingNavigatorSaveItem
        '
        Me.ORDER_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ORDER_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("ORDER_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ORDER_TABLEBindingNavigatorSaveItem.Name = "ORDER_TABLEBindingNavigatorSaveItem"
        Me.ORDER_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ORDER_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.ContactsDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CUSTOMER_TABLEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(544, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 232)
        Me.DataGridView1.TabIndex = 2
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'ContactsDataGridViewTextBoxColumn
        '
        Me.ContactsDataGridViewTextBoxColumn.DataPropertyName = "Contacts"
        Me.ContactsDataGridViewTextBoxColumn.HeaderText = "Contacts"
        Me.ContactsDataGridViewTextBoxColumn.Name = "ContactsDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 40)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Customer_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 391)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CUSTOMER_TABLEBindingNavigator)
        Me.Controls.Add(Me.CustomerInfoGroupBox)
        Me.Name = "Customer_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CustomerInfoGroupBox.ResumeLayout(False)
        Me.CustomerInfoGroupBox.PerformLayout()
        CType(Me.CUSTOMER_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMER_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMER_TABLEBindingNavigator.ResumeLayout(False)
        Me.CUSTOMER_TABLEBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerInfoGroupBox As GroupBox
    Friend WithEvents Test_1_with_2003_versionDataSet As test_1_with_2003_versionDataSet
    Friend WithEvents CUSTOMER_TABLEBindingSource As BindingSource
    Friend WithEvents CUSTOMER_TABLETableAdapter As test_1_with_2003_versionDataSetTableAdapters.CUSTOMER_TABLETableAdapter
    Friend WithEvents TableAdapterManager As test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMER_TABLEBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactsTextBox As TextBox
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents ORDER_TABLEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
