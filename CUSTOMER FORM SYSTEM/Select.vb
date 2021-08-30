Public Class Direction
    Private Sub CustomerInformationButton_Click(sender As Object, e As EventArgs) Handles CustomerInformationButton.Click

        Dim Form As New Customer_Information
        Form.ShowDialog()
    End Sub

    Private Sub InvoiceButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click

        Dim Form As New Invoice
        Form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EmployeeInfoButton.Click

        Dim Form As New Employee_Form
        Form.ShowDialog()
    End Sub

    Private Sub Direction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class