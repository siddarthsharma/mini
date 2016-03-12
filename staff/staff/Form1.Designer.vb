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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim STAFF_NAMELabel As System.Windows.Forms.Label
        Me.STAFFDataSet = New staff.STAFFDataSet()
        Me.STAFF_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFF_TABLETableAdapter = New staff.STAFFDataSetTableAdapters.STAFF_TABLETableAdapter()
        Me.TableAdapterManager = New staff.STAFFDataSetTableAdapters.TableAdapterManager()
        Me.STAFF_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.STAFF_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.STAFF_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.STAFF_TABLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        S_IDLabel = New System.Windows.Forms.Label()
        STAFF_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.STAFFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STAFF_TABLEBindingNavigator.SuspendLayout()
        CType(Me.STAFF_TABLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STAFFDataSet
        '
        Me.STAFFDataSet.DataSetName = "STAFFDataSet"
        Me.STAFFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFF_TABLEBindingSource
        '
        Me.STAFF_TABLEBindingSource.DataMember = "STAFF_TABLE"
        Me.STAFF_TABLEBindingSource.DataSource = Me.STAFFDataSet
        '
        'STAFF_TABLETableAdapter
        '
        Me.STAFF_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.STAFF_TABLETableAdapter = Me.STAFF_TABLETableAdapter
        Me.TableAdapterManager.UpdateOrder = staff.STAFFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STAFF_TABLEBindingNavigator
        '
        Me.STAFF_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STAFF_TABLEBindingNavigator.BindingSource = Me.STAFF_TABLEBindingSource
        Me.STAFF_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STAFF_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STAFF_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STAFF_TABLEBindingNavigatorSaveItem})
        Me.STAFF_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STAFF_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STAFF_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STAFF_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STAFF_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STAFF_TABLEBindingNavigator.Name = "STAFF_TABLEBindingNavigator"
        Me.STAFF_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STAFF_TABLEBindingNavigator.Size = New System.Drawing.Size(652, 25)
        Me.STAFF_TABLEBindingNavigator.TabIndex = 0
        Me.STAFF_TABLEBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'STAFF_TABLEBindingNavigatorSaveItem
        '
        Me.STAFF_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STAFF_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("STAFF_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STAFF_TABLEBindingNavigatorSaveItem.Name = "STAFF_TABLEBindingNavigatorSaveItem"
        Me.STAFF_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.STAFF_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(10, 78)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(31, 13)
        S_IDLabel.TabIndex = 1
        S_IDLabel.Text = "S ID:"
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TABLEBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(93, 71)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.S_IDTextBox.TabIndex = 2
        '
        'STAFF_NAMELabel
        '
        STAFF_NAMELabel.AutoSize = True
        STAFF_NAMELabel.Location = New System.Drawing.Point(10, 111)
        STAFF_NAMELabel.Name = "STAFF_NAMELabel"
        STAFF_NAMELabel.Size = New System.Drawing.Size(77, 13)
        STAFF_NAMELabel.TabIndex = 3
        STAFF_NAMELabel.Text = "STAFF NAME:"
        '
        'STAFF_NAMETextBox
        '
        Me.STAFF_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_TABLEBindingSource, "STAFF_NAME", True))
        Me.STAFF_NAMETextBox.Location = New System.Drawing.Point(93, 108)
        Me.STAFF_NAMETextBox.Name = "STAFF_NAMETextBox"
        Me.STAFF_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.STAFF_NAMETextBox.TabIndex = 4
        '
        'STAFF_TABLEDataGridView
        '
        Me.STAFF_TABLEDataGridView.AutoGenerateColumns = False
        Me.STAFF_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STAFF_TABLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.STAFF_TABLEDataGridView.DataSource = Me.STAFF_TABLEBindingSource
        Me.STAFF_TABLEDataGridView.Location = New System.Drawing.Point(269, 71)
        Me.STAFF_TABLEDataGridView.Name = "STAFF_TABLEDataGridView"
        Me.STAFF_TABLEDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.STAFF_TABLEDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "S_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "S_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "STAFF_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "STAFF_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.STAFF_TABLEDataGridView)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(STAFF_NAMELabel)
        Me.Controls.Add(Me.STAFF_NAMETextBox)
        Me.Controls.Add(Me.STAFF_TABLEBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.STAFFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STAFF_TABLEBindingNavigator.ResumeLayout(False)
        Me.STAFF_TABLEBindingNavigator.PerformLayout()
        CType(Me.STAFF_TABLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents STAFFDataSet As STAFFDataSet
    Friend WithEvents STAFF_TABLEBindingSource As BindingSource
    Friend WithEvents STAFF_TABLETableAdapter As STAFFDataSetTableAdapters.STAFF_TABLETableAdapter
    Friend WithEvents TableAdapterManager As STAFFDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STAFF_TABLEBindingNavigator As BindingNavigator
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
    Friend WithEvents STAFF_TABLEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents STAFF_NAMETextBox As TextBox
    Friend WithEvents STAFF_TABLEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
