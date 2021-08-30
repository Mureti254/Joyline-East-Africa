Public Class Employee_Form
    Private Sub EMPLOYEE_TABLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMPLOYEE_TABLEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLOYEE_TABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test_1_with_2003_versionDataSet)
        MsgBox("Save Successful")

    End Sub

    Private Sub Employee_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test_1_with_2003_versionDataSet2.DEPARTMENTS_TABLE' table. You can move, or remove it, as needed.
        Me.DEPARTMENTS_TABLETableAdapter.Fill(Me.Test_1_with_2003_versionDataSet2.DEPARTMENTS_TABLE)
        'TODO: This line of code loads data into the 'Test_1_with_2003_versionDataSet.EMPLOYEE_TABLE' table. You can move, or remove it, as needed.
        Me.EMPLOYEE_TABLETableAdapter.Fill(Me.Test_1_with_2003_versionDataSet.EMPLOYEE_TABLE)

    End Sub

    Private Sub ContactsTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactsTextBox.TextChanged

    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_NameTextBox.TextChanged

    End Sub

    Private Sub Department_IDTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        If True Then
            MsgBox("Back to Select")
            Me.Close()
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("Deleted")
    End Sub
End Class