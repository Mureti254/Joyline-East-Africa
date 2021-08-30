Public Class Invoice

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged

    End Sub


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click

        Dim PriceDecimal As Decimal
        Dim QuantityInteger As Integer
        PriceDecimal = Decimal.Parse(PriceComboBox.Text, Globalization.NumberStyles.Currency)
        QuantityInteger = Integer.Parse(QuantityTextBox.Text, Globalization.NumberStyles.Number)

        Dim SubTotalDecimal, SalesTaxDecimal, TotalDueDecimal As Decimal
        SubTotalDecimal = PriceDecimal * QuantityInteger

        Const SALES_TAX_RATE_SINGLE As Single = 0.16
        SalesTaxDecimal = Decimal.Round(Convert.ToDecimal(SubTotalDecimal * SALES_TAX_RATE_SINGLE), 2)

        TotalDueDecimal = SubTotalDecimal + SalesTaxDecimal

        SubTotalTextBox.Text = SubTotalDecimal.ToString("C")
        TaxTextBox.Text = SalesTaxDecimal.ToString("N")
        SubTotalTextBox.Text = TotalDueDecimal.ToString("C")

        Dim TotalQuantityinteger As Integer
        Dim TotalSalesDecimal As Decimal
        TotalQuantityinteger += QuantityInteger
        TotalSalesDecimal += TotalDueDecimal

        DataGridView1.Rows.Add(CustomerComboBox.Text, ContactsComboBox.Text, ItemComboBox.Text, QuantityInteger, TotalDueDecimal)

        Clear_Boxes()

    End Sub
    Private Sub Clear_Boxes()
        QuantityTextBox.Clear()
        QuantityTextBox.Select()

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test_1_with_2003_versionDataSet.CUSTOMER_TABLE' table. You can move, or remove it, as needed.
        Me.CUSTOMER_TABLETableAdapter.Fill(Me.Test_1_with_2003_versionDataSet.CUSTOMER_TABLE)
        'TODO: This line of code loads data into the 'Test_1_with_2003_versionDataSet.ORDER_TABLE' table. You can move, or remove it, as needed.
        Me.ORDER_TABLETableAdapter.Fill(Me.Test_1_with_2003_versionDataSet.ORDER_TABLE)

    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        DataGridView1.Rows.Clear()
        SubTotalTextBox.Clear()
        QuantityTextBox.Clear()

    End Sub

    Private Sub RemoveLineButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        If True Then
            MsgBox("Back to Select")
            Me.Close()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click
        ItemComboBox.Text = String.Empty
        QuantityTextBox.Text = String.Empty
        SubTotalTextBox.Text = String.Empty
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        Me.CUSTOMERTABLEBindingSource.Filter = "Customer Name LIKE '" & CustomerComboBox.Text & "%'"
    End Sub
End Class