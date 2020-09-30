Imports System.ComponentModel

Public Class Form1

    Private productBindingList As New BindingList(Of ProductItem)

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        CategoriesComboBox.DataSource = DataOperations.Categories()
        GetCategories()

        SelectedProductsListBox.DataSource = productBindingList

    End Sub
    Private Sub GetCategories()
        Dim category = CType(CategoriesComboBox.SelectedItem, Category)
        ProductsListBox.DataSource = DataOperations.ProductsByCategory(category.CategoryID)
    End Sub

    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriesComboBox.SelectedIndexChanged
        GetCategories()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If ProductsListBox.SelectedItem IsNot Nothing AndAlso QuantityNumericTextBox.AsInteger > 0 Then

            Dim product = CType(ProductsListBox.SelectedItem, Product)
            Dim productItem = DataOperations.SingleProduct(CInt(product.ProductID), QuantityNumericTextBox.AsInteger)

            productBindingList.Add(productItem)

        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If My.Dialogs.Question("Clear selections") Then
            productBindingList.Clear()
            TotalTextBox.Text = ""
        End If
    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        If productBindingList.Count > 0 Then
            TotalTextBox.Text = productBindingList.Select(Function(item) item.Quantity * item.UnitPrice).Sum().Value.ToString("C2")
        End If
    End Sub

    Private Sub PeekButton_Click(sender As Object, e As EventArgs) Handles PeekButton.Click
        If productBindingList.Count > 0 Then
            For index As Integer = 0 To productBindingList.Count - 1
                Console.WriteLine($"Category {productBindingList.Item(index).CategoryID}, product {productBindingList.Item(index).ProductName}, product id {productBindingList.Item(index).ProductID}, qty {productBindingList.Item(index).Quantity}, cost {productBindingList.Item(index).UnitPrice}")
            Next
        End If
    End Sub
End Class
