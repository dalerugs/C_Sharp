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
        Me.dataGrade = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSubject = New System.Windows.Forms.TextBox()
        Me.tbGrade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.colSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrade
        '
        Me.dataGrade.AllowUserToAddRows = False
        Me.dataGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSubject, Me.colGrade})
        Me.dataGrade.Location = New System.Drawing.Point(12, 70)
        Me.dataGrade.Name = "dataGrade"
        Me.dataGrade.ReadOnly = True
        Me.dataGrade.RowHeadersVisible = False
        Me.dataGrade.Size = New System.Drawing.Size(440, 176)
        Me.dataGrade.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject:"
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(66, 12)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(100, 20)
        Me.tbSubject.TabIndex = 2
        '
        'tbGrade
        '
        Me.tbGrade.Location = New System.Drawing.Point(66, 38)
        Me.tbGrade.Name = "tbGrade"
        Me.tbGrade.Size = New System.Drawing.Size(100, 20)
        Me.tbGrade.TabIndex = 4
        Me.tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grade:"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(172, 38)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 5
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'colSubject
        '
        Me.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSubject.HeaderText = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.ReadOnly = True
        '
        'colGrade
        '
        Me.colGrade.HeaderText = "Grade"
        Me.colGrade.Name = "colGrade"
        Me.colGrade.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 254)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tbGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataGrade)
        Me.Name = "Form1"
        Me.Text = "Marksheet Grades"
        CType(Me.dataGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGrade As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSubject As TextBox
    Friend WithEvents tbGrade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents colSubject As DataGridViewTextBoxColumn
    Friend WithEvents colGrade As DataGridViewTextBoxColumn
End Class
