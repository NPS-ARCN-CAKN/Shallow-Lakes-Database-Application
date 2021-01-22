Public Class MainForm
    Private Sub TblPondsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblPondsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblPondsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AK_ShallowLakesDataSet)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AK_ShallowLakesDataSet.tblPonds' table. You can move, or remove it, as needed.
        Me.TblPondsTableAdapter.Fill(Me.AK_ShallowLakesDataSet.tblPonds)

    End Sub
End Class
