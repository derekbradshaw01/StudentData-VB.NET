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
        Me.dgDisplay = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFullTime = New System.Windows.Forms.Button()
        Me.btnOrderDesc = New System.Windows.Forms.Button()
        Me.btnOrderAsc = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataDataSet = New Projecct5.StudentDataDataSet1()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDisplay
        '
        Me.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDisplay.Location = New System.Drawing.Point(12, 12)
        Me.dgDisplay.Name = "dgDisplay"
        Me.dgDisplay.Size = New System.Drawing.Size(597, 426)
        Me.dgDisplay.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnFullTime)
        Me.GroupBox1.Controls.Add(Me.btnOrderDesc)
        Me.GroupBox1.Controls.Add(Me.btnOrderAsc)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Location = New System.Drawing.Point(615, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 327)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(6, 267)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 47)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFullTime
        '
        Me.btnFullTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullTime.Location = New System.Drawing.Point(6, 205)
        Me.btnFullTime.Name = "btnFullTime"
        Me.btnFullTime.Size = New System.Drawing.Size(161, 56)
        Me.btnFullTime.TabIndex = 3
        Me.btnFullTime.Text = "Full Time Students"
        Me.btnFullTime.UseVisualStyleBackColor = True
        '
        'btnOrderDesc
        '
        Me.btnOrderDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderDesc.Location = New System.Drawing.Point(6, 143)
        Me.btnOrderDesc.Name = "btnOrderDesc"
        Me.btnOrderDesc.Size = New System.Drawing.Size(161, 56)
        Me.btnOrderDesc.TabIndex = 2
        Me.btnOrderDesc.Text = "Order Last Name Descending"
        Me.btnOrderDesc.UseVisualStyleBackColor = True
        '
        'btnOrderAsc
        '
        Me.btnOrderAsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderAsc.Location = New System.Drawing.Point(6, 81)
        Me.btnOrderAsc.Name = "btnOrderAsc"
        Me.btnOrderAsc.Size = New System.Drawing.Size(161, 56)
        Me.btnOrderAsc.TabIndex = 1
        Me.btnOrderAsc.Text = "Order Last Name Ascending"
        Me.btnOrderAsc.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(6, 19)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(161, 56)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Student Table"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.StudentDataDataSet
        Me.BindingSource1.Position = 0
        '
        'StudentDataDataSet
        '
        Me.StudentDataDataSet.DataSetName = "StudentDataDataSet1"
        Me.StudentDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(611, 342)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(184, 20)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search For A Student"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(621, 404)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(161, 34)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(621, 378)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(161, 20)
        Me.txtSearch.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgDisplay)
        Me.Name = "Form1"
        Me.Text = "CPT341 Fall 2021 - DataBases"
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgDisplay As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents StudentDataDataSet As StudentDataDataSet1
    Friend WithEvents btnOrderAsc As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnFullTime As Button
    Friend WithEvents btnOrderDesc As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
