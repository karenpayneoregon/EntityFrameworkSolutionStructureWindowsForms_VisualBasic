<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CategoriesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectedProductsListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityNumericTextBox = New CategoriesProducts.ChunkIncomingTextFile.Controls.NumericTextBox()
        Me.PeekButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(12, 39)
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(187, 21)
        Me.CategoriesComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categories"
        '
        'ProductsListBox
        '
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(10, 73)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(203, 186)
        Me.ProductsListBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'SelectedProductsListBox
        '
        Me.SelectedProductsListBox.FormattingEnabled = True
        Me.SelectedProductsListBox.Location = New System.Drawing.Point(327, 73)
        Me.SelectedProductsListBox.Name = "SelectedProductsListBox"
        Me.SelectedProductsListBox.Size = New System.Drawing.Size(202, 186)
        Me.SelectedProductsListBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "List"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(232, 99)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 7
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(232, 128)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(232, 157)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(75, 23)
        Me.TotalButton.TabIndex = 9
        Me.TotalButton.Text = "Total"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(374, 287)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 11
        '
        'QuantityNumericTextBox
        '
        Me.QuantityNumericTextBox.Location = New System.Drawing.Point(232, 73)
        Me.QuantityNumericTextBox.Name = "QuantityNumericTextBox"
        Me.QuantityNumericTextBox.Size = New System.Drawing.Size(75, 20)
        Me.QuantityNumericTextBox.TabIndex = 3
        '
        'PeekButton
        '
        Me.PeekButton.Location = New System.Drawing.Point(10, 284)
        Me.PeekButton.Name = "PeekButton"
        Me.PeekButton.Size = New System.Drawing.Size(75, 23)
        Me.PeekButton.TabIndex = 12
        Me.PeekButton.Text = "Peek"
        Me.PeekButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 334)
        Me.Controls.Add(Me.PeekButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SelectedProductsListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuantityNumericTextBox)
        Me.Controls.Add(Me.ProductsListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoriesComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoriesComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductsListBox As ListBox
    Friend WithEvents QuantityNumericTextBox As ChunkIncomingTextFile.Controls.NumericTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SelectedProductsListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents TotalButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PeekButton As Button
End Class
