Public Class Customer_Information
    Private Sub CUSTOMER_TABLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CUSTOMER_TABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test_1_with_2003_versionDataSet)

    End Sub

    Private Sub CUSTOMER_TABLEBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CUSTOMER_TABLEBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Test_1_with_2003_versionDataSet)

    End Sub

    Private Sub Customer_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test_1_with_2003_versionDataSet.CUSTOMER_TABLE' table. You can move, or remove it, as needed.
        Me.CUSTOMER_TABLETableAdapter.Fill(Me.Test_1_with_2003_versionDataSet.CUSTOMER_TABLE)

    End Sub

    Private Sub ContactsLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles CustomerInfoGroupBox.Enter

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs)

        CUSTOMER_TABLEBindingSource.MoveNext()

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs)

        CUSTOMER_TABLEBindingSource.MovePrevious()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Delete.Click

        CUSTOMER_TABLEBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        CUSTOMER_TABLEBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        CUSTOMER_TABLEBindingSource.EndEdit()
        CUSTOMER_TABLETableAdapter.Update(Test_1_with_2003_versionDataSet.CUSTOMER_TABLE)
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click

        If True Then
            MsgBox("Back to Select")
            Me.Close()
        End If

    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub CUSTOMER_TABLEBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CUSTOMER_TABLEBindingNavigator.RefreshItems

    End Sub

    Private Sub ORDER_TABLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ORDER_TABLEBindingNavigatorSaveItem.Click
        MsgBox("Save Successful")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CUSTOMER_TABLEBindingSource.AddNew()
        MsgBox("Save Successful")
    End Sub
End Class