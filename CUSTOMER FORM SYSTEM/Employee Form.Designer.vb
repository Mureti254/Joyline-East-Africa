<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ContactsLabel As System.Windows.Forms.Label
        Dim ResidenceLabel As System.Windows.Forms.Label
        Dim Department_IDLabel1 As System.Windows.Forms.Label
        Dim Department_NameLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Form))
        Me.EmployeeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLOYEE_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test_1_with_2003_versionDataSet = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ResidenceTextBox = New System.Windows.Forms.TextBox()
        Me.ContactsTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.EMPLOYEE_TABLETableAdapter = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.EMPLOYEE_TABLETableAdapter()
        Me.TableAdapterManager = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager()
        Me.EMPLOYEE_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DEPARTMENTS_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test_1_with_2003_versionDataSet2 = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet2()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DEPARTMENTS_TABLETableAdapter = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet2TableAdapters.DEPARTMENTS_TABLETableAdapter()
        Me.TableAdapterManager1 = New CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet2TableAdapters.TableAdapterManager()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ContactsLabel = New System.Windows.Forms.Label()
        ResidenceLabel = New System.Windows.Forms.Label()
        Department_IDLabel1 = New System.Windows.Forms.Label()
        Department_NameLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Me.EmployeeGroupBox.SuspendLayout()
        CType(Me.EMPLOYEE_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEE_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPLOYEE_TABLEBindingNavigator.SuspendLayout()
        Me.DepartmentGroupBox.SuspendLayout()
        CType(Me.DEPARTMENTS_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test_1_with_2003_versionDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(21, 59)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(106, 22)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(20, 90)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(102, 22)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(36, 120)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(74, 22)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'ContactsLabel
        '
        ContactsLabel.AutoSize = True
        ContactsLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactsLabel.Location = New System.Drawing.Point(29, 147)
        ContactsLabel.Name = "ContactsLabel"
        ContactsLabel.Size = New System.Drawing.Size(84, 22)
        ContactsLabel.TabIndex = 8
        ContactsLabel.Text = "Contacts:"
        '
        'ResidenceLabel
        '
        ResidenceLabel.AutoSize = True
        ResidenceLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResidenceLabel.Location = New System.Drawing.Point(20, 179)
        ResidenceLabel.Name = "ResidenceLabel"
        ResidenceLabel.Size = New System.Drawing.Size(95, 22)
        ResidenceLabel.TabIndex = 10
        ResidenceLabel.Text = "Residence:"
        '
        'Department_IDLabel1
        '
        Department_IDLabel1.AutoSize = True
        Department_IDLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Department_IDLabel1.Location = New System.Drawing.Point(14, 26)
        Department_IDLabel1.Name = "Department_IDLabel1"
        Department_IDLabel1.Size = New System.Drawing.Size(134, 22)
        Department_IDLabel1.TabIndex = 0
        Department_IDLabel1.Text = "Department ID:"
        '
        'Department_NameLabel
        '
        Department_NameLabel.AutoSize = True
        Department_NameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Department_NameLabel.Location = New System.Drawing.Point(16, 60)
        Department_NameLabel.Name = "Department_NameLabel"
        Department_NameLabel.Size = New System.Drawing.Size(161, 22)
        Department_NameLabel.TabIndex = 2
        Department_NameLabel.Text = "Department Name:"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_IDLabel.Location = New System.Drawing.Point(17, 24)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(119, 22)
        Employee_IDLabel.TabIndex = 27
        Employee_IDLabel.Text = "Employee ID:"
        '
        'EmployeeGroupBox
        '
        Me.EmployeeGroupBox.Controls.Add(Employee_IDLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.Employee_IDTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.ComboBox1)
        Me.EmployeeGroupBox.Controls.Add(ResidenceLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.ResidenceTextBox)
        Me.EmployeeGroupBox.Controls.Add(ContactsLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.ContactsTextBox)
        Me.EmployeeGroupBox.Controls.Add(GenderLabel)
        Me.EmployeeGroupBox.Controls.Add(Last_NameLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.Last_NameTextBox)
        Me.EmployeeGroupBox.Controls.Add(First_NameLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.First_NameTextBox)
        Me.EmployeeGroupBox.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeGroupBox.Location = New System.Drawing.Point(12, 28)
        Me.EmployeeGroupBox.Name = "EmployeeGroupBox"
        Me.EmployeeGroupBox.Size = New System.Drawing.Size(336, 221)
        Me.EmployeeGroupBox.TabIndex = 0
        Me.EmployeeGroupBox.TabStop = False
        Me.EmployeeGroupBox.Text = "Employee"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEE_TABLEBindingSource, "Employee ID", True))
        Me.Employee_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(142, 26)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Employee_IDTextBox.TabIndex = 28
        '
        'EMPLOYEE_TABLEBindingSource
        '
        Me.EMPLOYEE_TABLEBindingSource.DataMember = "EMPLOYEE TABLE"
        Me.EMPLOYEE_TABLEBindingSource.DataSource = Me.Test_1_with_2003_versionDataSet
        '
        'Test_1_with_2003_versionDataSet
        '
        Me.Test_1_with_2003_versionDataSet.DataSetName = "test_1_with_2003_versionDataSet"
        Me.Test_1_with_2003_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPLOYEE_TABLEBindingSource, "Gender", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(142, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'ResidenceTextBox
        '
        Me.ResidenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEE_TABLEBindingSource, "Residence", True))
        Me.ResidenceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResidenceTextBox.Location = New System.Drawing.Point(142, 181)
        Me.ResidenceTextBox.Name = "ResidenceTextBox"
        Me.ResidenceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ResidenceTextBox.TabIndex = 11
        '
        'ContactsTextBox
        '
        Me.ContactsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEE_TABLEBindingSource, "Contacts", True))
        Me.ContactsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactsTextBox.Location = New System.Drawing.Point(142, 149)
        Me.ContactsTextBox.Name = "ContactsTextBox"
        Me.ContactsTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ContactsTextBox.TabIndex = 9
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEE_TABLEBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(142, 88)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEE_TABLEBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(142, 57)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.First_NameTextBox.TabIndex = 3
        '
        'EMPLOYEE_TABLETableAdapter
        '
        Me.EMPLOYEE_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMER_TABLETableAdapter = Nothing
        Me.TableAdapterManager.DEPARTMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEE_TABLETableAdapter = Me.EMPLOYEE_TABLETableAdapter
        Me.TableAdapterManager.ORDER_TABLETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMPLOYEE_TABLEBindingNavigator
        '
        Me.EMPLOYEE_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPLOYEE_TABLEBindingNavigator.BindingSource = Me.EMPLOYEE_TABLEBindingSource
        Me.EMPLOYEE_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPLOYEE_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPLOYEE_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPLOYEE_TABLEBindingNavigatorSaveItem})
        Me.EMPLOYEE_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPLOYEE_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPLOYEE_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPLOYEE_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPLOYEE_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPLOYEE_TABLEBindingNavigator.Name = "EMPLOYEE_TABLEBindingNavigator"
        Me.EMPLOYEE_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPLOYEE_TABLEBindingNavigator.Size = New System.Drawing.Size(1242, 25)
        Me.EMPLOYEE_TABLEBindingNavigator.TabIndex = 1
        Me.EMPLOYEE_TABLEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'EMPLOYEE_TABLEBindingNavigatorSaveItem
        '
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPLOYEE_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem.Name = "EMPLOYEE_TABLEBindingNavigatorSaveItem"
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMPLOYEE_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DepartmentGroupBox
        '
        Me.DepartmentGroupBox.Controls.Add(Me.ComboBox3)
        Me.DepartmentGroupBox.Controls.Add(Me.ComboBox2)
        Me.DepartmentGroupBox.Controls.Add(Department_NameLabel)
        Me.DepartmentGroupBox.Controls.Add(Department_IDLabel1)
        Me.DepartmentGroupBox.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentGroupBox.Location = New System.Drawing.Point(12, 254)
        Me.DepartmentGroupBox.Name = "DepartmentGroupBox"
        Me.DepartmentGroupBox.Size = New System.Drawing.Size(347, 106)
        Me.DepartmentGroupBox.TabIndex = 3
        Me.DepartmentGroupBox.TabStop = False
        Me.DepartmentGroupBox.Text = "Department"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DEPARTMENTS_TABLEBindingSource, "Department Name", True))
        Me.ComboBox3.DataSource = Me.DEPARTMENTS_TABLEBindingSource
        Me.ComboBox3.DisplayMember = "Department Name"
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(185, 68)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox3.TabIndex = 27
        Me.ComboBox3.ValueMember = "Department Name"
        '
        'DEPARTMENTS_TABLEBindingSource
        '
        Me.DEPARTMENTS_TABLEBindingSource.DataMember = "DEPARTMENTS TABLE"
        Me.DEPARTMENTS_TABLEBindingSource.DataSource = Me.Test_1_with_2003_versionDataSet2
        '
        'Test_1_with_2003_versionDataSet2
        '
        Me.Test_1_with_2003_versionDataSet2.DataSetName = "test_1_with_2003_versionDataSet2"
        Me.Test_1_with_2003_versionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPLOYEE_TABLEBindingSource, "Department ID", True))
        Me.ComboBox2.DataSource = Me.DEPARTMENTS_TABLEBindingSource
        Me.ComboBox2.DisplayMember = "Department ID"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(185, 26)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox2.TabIndex = 27
        Me.ComboBox2.ValueMember = "Department ID"
        '
        'DEPARTMENTS_TABLETableAdapter
        '
        Me.DEPARTMENTS_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.DEPARTMENTS_TABLETableAdapter = Me.DEPARTMENTS_TABLETableAdapter
        Me.TableAdapterManager1.UpdateOrder = CUSTOMER_FORM_SYSTEM.test_1_with_2003_versionDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(374, 228)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(77, 34)
        Me.LogOutButton.TabIndex = 34
        Me.LogOutButton.Text = "Exit"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.ContactsDataGridViewTextBoxColumn, Me.ResidenceDataGridViewTextBoxColumn, Me.DepartmentIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEE_TABLEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(493, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 324)
        Me.DataGridView1.TabIndex = 35
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'ContactsDataGridViewTextBoxColumn
        '
        Me.ContactsDataGridViewTextBoxColumn.DataPropertyName = "Contacts"
        Me.ContactsDataGridViewTextBoxColumn.HeaderText = "Contacts"
        Me.ContactsDataGridViewTextBoxColumn.Name = "ContactsDataGridViewTextBoxColumn"
        '
        'ResidenceDataGridViewTextBoxColumn
        '
        Me.ResidenceDataGridViewTextBoxColumn.DataPropertyName = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.HeaderText = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.Name = "ResidenceDataGridViewTextBoxColumn"
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "Department ID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "Department ID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        '
        'Employee_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 364)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.DepartmentGroupBox)
        Me.Controls.Add(Me.EMPLOYEE_TABLEBindingNavigator)
        Me.Controls.Add(Me.EmployeeGroupBox)
        Me.Name = "Employee_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EmployeeGroupBox.ResumeLayout(False)
        Me.EmployeeGroupBox.PerformLayout()
        CType(Me.EMPLOYEE_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test_1_with_2003_versionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEE_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPLOYEE_TABLEBindingNavigator.ResumeLayout(False)
        Me.EMPLOYEE_TABLEBindingNavigator.PerformLayout()
        Me.DepartmentGroupBox.ResumeLayout(False)
        Me.DepartmentGroupBox.PerformLayout()
        CType(Me.DEPARTMENTS_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test_1_with_2003_versionDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeGroupBox As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Test_1_with_2003_versionDataSet As test_1_with_2003_versionDataSet
    Friend WithEvents EMPLOYEE_TABLEBindingSource As BindingSource
    Friend WithEvents EMPLOYEE_TABLETableAdapter As test_1_with_2003_versionDataSetTableAdapters.EMPLOYEE_TABLETableAdapter
    Friend WithEvents TableAdapterManager As test_1_with_2003_versionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPLOYEE_TABLEBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EMPLOYEE_TABLEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ResidenceTextBox As TextBox
    Friend WithEvents ContactsTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents DepartmentGroupBox As GroupBox
    Friend WithEvents Test_1_with_2003_versionDataSet2 As test_1_with_2003_versionDataSet2
    Friend WithEvents DEPARTMENTS_TABLEBindingSource As BindingSource
    Friend WithEvents DEPARTMENTS_TABLETableAdapter As test_1_with_2003_versionDataSet2TableAdapters.DEPARTMENTS_TABLETableAdapter
    Friend WithEvents TableAdapterManager1 As test_1_with_2003_versionDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LogOutButton As Button
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
