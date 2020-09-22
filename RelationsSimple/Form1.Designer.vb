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
        Me.ContactsComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoneDataGridView = New System.Windows.Forms.DataGridView()
        Me.PhoneTypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PhoneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactsComboBox
        '
        Me.ContactsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ContactsComboBox.FormattingEnabled = True
        Me.ContactsComboBox.Location = New System.Drawing.Point(12, 22)
        Me.ContactsComboBox.Name = "ContactsComboBox"
        Me.ContactsComboBox.Size = New System.Drawing.Size(187, 21)
        Me.ContactsComboBox.TabIndex = 0
        '
        'PhoneDataGridView
        '
        Me.PhoneDataGridView.AllowUserToAddRows = False
        Me.PhoneDataGridView.AllowUserToDeleteRows = False
        Me.PhoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PhoneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhoneTypeColumn, Me.PhoneNumberColumn})
        Me.PhoneDataGridView.Location = New System.Drawing.Point(12, 64)
        Me.PhoneDataGridView.Name = "PhoneDataGridView"
        Me.PhoneDataGridView.ReadOnly = True
        Me.PhoneDataGridView.Size = New System.Drawing.Size(272, 117)
        Me.PhoneDataGridView.TabIndex = 1
        '
        'PhoneTypeColumn
        '
        Me.PhoneTypeColumn.DataPropertyName = "PhoneType"
        Me.PhoneTypeColumn.HeaderText = "Type"
        Me.PhoneTypeColumn.Name = "PhoneTypeColumn"
        Me.PhoneTypeColumn.ReadOnly = True
        '
        'PhoneNumberColumn
        '
        Me.PhoneNumberColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberColumn.HeaderText = "Number"
        Me.PhoneNumberColumn.Name = "PhoneNumberColumn"
        Me.PhoneNumberColumn.ReadOnly = True
        '
        'EmailDataGridView
        '
        Me.EmailDataGridView.AllowUserToAddRows = False
        Me.EmailDataGridView.AllowUserToDeleteRows = False
        Me.EmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.EmailDataGridView.Location = New System.Drawing.Point(307, 64)
        Me.EmailDataGridView.Name = "EmailDataGridView"
        Me.EmailDataGridView.ReadOnly = True
        Me.EmailDataGridView.Size = New System.Drawing.Size(272, 117)
        Me.EmailDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmailType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmailAddress"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 221)
        Me.Controls.Add(Me.EmailDataGridView)
        Me.Controls.Add(Me.PhoneDataGridView)
        Me.Controls.Add(Me.ContactsComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        CType(Me.PhoneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContactsComboBox As ComboBox
    Friend WithEvents PhoneDataGridView As DataGridView
    Friend WithEvents PhoneTypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
