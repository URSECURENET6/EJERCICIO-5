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
        txtPurchaseOrder = New TextBox()
        btnOk = New Button()
        DataGridView1 = New DataGridView()
        PartNumber = New DataGridViewTextBoxColumn()
        Description = New DataGridViewTextBoxColumn()
        IsCustom = New DataGridViewTextBoxColumn()
        ProgressBar1 = New ProgressBar()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtPurchaseOrder
        ' 
        txtPurchaseOrder.Location = New Point(14, 16)
        txtPurchaseOrder.Margin = New Padding(3, 4, 3, 4)
        txtPurchaseOrder.Name = "txtPurchaseOrder"
        txtPurchaseOrder.Size = New Size(649, 27)
        txtPurchaseOrder.TabIndex = 0
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(670, 15)
        btnOk.Margin = New Padding(3, 4, 3, 4)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(86, 31)
        btnOk.TabIndex = 1
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PartNumber, Description, IsCustom})
        DataGridView1.Location = New Point(14, 55)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(742, 365)
        DataGridView1.TabIndex = 2
        ' 
        ' PartNumber
        ' 
        PartNumber.HeaderText = "PartNumber"
        PartNumber.MinimumWidth = 6
        PartNumber.Name = "PartNumber"
        PartNumber.Width = 150
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.MinimumWidth = 6
        Description.Name = "Description"
        Description.Width = 150
        ' 
        ' IsCustom
        ' 
        IsCustom.HeaderText = "IsCustom"
        IsCustom.MinimumWidth = 6
        IsCustom.Name = "IsCustom"
        IsCustom.Width = 150
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(14, 428)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(742, 18)
        ProgressBar1.TabIndex = 3
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerReportsProgress = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(769, 456)
        Controls.Add(ProgressBar1)
        Controls.Add(DataGridView1)
        Controls.Add(btnOk)
        Controls.Add(txtPurchaseOrder)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPurchaseOrder As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PartNumber As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents IsCustom As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
