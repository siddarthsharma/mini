Public Class Form1
    Private Sub STAFF_TABLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles STAFF_TABLEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STAFF_TABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.STAFFDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STAFFDataSet.STAFF_TABLE' table. You can move, or remove it, as needed.
        Me.STAFF_TABLETableAdapter.Fill(Me.STAFFDataSet.STAFF_TABLE)

    End Sub
End Class
