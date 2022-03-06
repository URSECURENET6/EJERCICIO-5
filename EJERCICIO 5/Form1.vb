Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Check(txtPurchaseOrder.Text) Then
            If BackgroundWorker1.IsBusy = False Then
                BackgroundWorker1.RunWorkerAsync()
            End If
        Else
            MessageBox.Show("Purchase Order Format not valid.")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        num = CInt(Int((10 * Rnd()) + 1))
        For i As Integer = 0 To num
            Me.Invoke(New delegatefillDGV(AddressOf FilDGV), New Object)
            Threading.Thread.Sleep(1000)
            BackgroundWorker1.ReportProgress(i)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Maximum = num
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Process completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub FilDGV()
        Dim Stiffener As New Stiffener
        Stiffener._PartNumber = CInt(Int((1000 * Rnd()) + 1))
        Stiffener._Description = "Description x"
        Stiffener._IsCustom = False
        DataGridView1.Rows.Add(New String() {Stiffener._PartNumber, Stiffener._Description, Stiffener._IsCustom})
    End Sub
End Class
