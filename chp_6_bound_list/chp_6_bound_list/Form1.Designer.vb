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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Mobile_NumberLabel As System.Windows.Forms.Label
        Dim Email_IdLabel As System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Database2_1DataSet = New chp_6_bound_list.Database2_1DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New chp_6_bound_list.Database2_1DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New chp_6_bound_list.Database2_1DataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Email_IdTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Mobile_NumberLabel = New System.Windows.Forms.Label()
        Email_IdLabel = New System.Windows.Forms.Label()
        CType(Me.Database2_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Database2_1DataSet, "Customer.ID", True))
        Me.ListBox1.DataSource = Me.CustomerBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(43, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(306, 388)
        Me.ListBox1.TabIndex = 10
        '
        'Database2_1DataSet
        '
        Me.Database2_1DataSet.DataSetName = "Database2_1DataSet"
        Me.Database2_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Database2_1DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = chp_6_bound_list.Database2_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(529, 103)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(642, 100)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 11
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(529, 131)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(642, 128)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 13
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(529, 159)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 14
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(642, 156)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 15
        '
        'Mobile_NumberLabel
        '
        Mobile_NumberLabel.AutoSize = True
        Mobile_NumberLabel.Location = New System.Drawing.Point(529, 187)
        Mobile_NumberLabel.Name = "Mobile_NumberLabel"
        Mobile_NumberLabel.Size = New System.Drawing.Size(107, 17)
        Mobile_NumberLabel.TabIndex = 16
        Mobile_NumberLabel.Text = "Mobile Number:"
        '
        'Mobile_NumberTextBox
        '
        Me.Mobile_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Mobile Number", True))
        Me.Mobile_NumberTextBox.Location = New System.Drawing.Point(642, 184)
        Me.Mobile_NumberTextBox.Name = "Mobile_NumberTextBox"
        Me.Mobile_NumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Mobile_NumberTextBox.TabIndex = 17
        '
        'Email_IdLabel
        '
        Email_IdLabel.AutoSize = True
        Email_IdLabel.Location = New System.Drawing.Point(529, 215)
        Email_IdLabel.Name = "Email_IdLabel"
        Email_IdLabel.Size = New System.Drawing.Size(61, 17)
        Email_IdLabel.TabIndex = 18
        Email_IdLabel.Text = "Email Id:"
        '
        'Email_IdTextBox
        '
        Me.Email_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email Id", True))
        Me.Email_IdTextBox.Location = New System.Drawing.Point(642, 212)
        Me.Email_IdTextBox.Name = "Email_IdTextBox"
        Me.Email_IdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Email_IdTextBox.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Mobile_NumberLabel)
        Me.Controls.Add(Me.Mobile_NumberTextBox)
        Me.Controls.Add(Email_IdLabel)
        Me.Controls.Add(Me.Email_IdTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database2_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Database2_1DataSet As Database2_1DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Database2_1DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Database2_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Mobile_NumberTextBox As TextBox
    Friend WithEvents Email_IdTextBox As TextBox
End Class
