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
        Me.lbNumbers = New System.Windows.Forms.ListBox()
        Me.tbAdd = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEven = New System.Windows.Forms.TextBox()
        Me.tbOdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbNumbers
        '
        Me.lbNumbers.FormattingEnabled = True
        Me.lbNumbers.Location = New System.Drawing.Point(12, 12)
        Me.lbNumbers.Name = "lbNumbers"
        Me.lbNumbers.Size = New System.Drawing.Size(156, 134)
        Me.lbNumbers.TabIndex = 0
        '
        'tbAdd
        '
        Me.tbAdd.Location = New System.Drawing.Point(175, 13)
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(100, 20)
        Me.tbAdd.TabIndex = 1
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(200, 39)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 2
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Even:"
        '
        'tbEven
        '
        Me.tbEven.Location = New System.Drawing.Point(219, 90)
        Me.tbEven.Name = "tbEven"
        Me.tbEven.ReadOnly = True
        Me.tbEven.Size = New System.Drawing.Size(56, 20)
        Me.tbEven.TabIndex = 5
        Me.tbEven.Text = "0"
        Me.tbEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbOdd
        '
        Me.tbOdd.Location = New System.Drawing.Point(219, 116)
        Me.tbOdd.Name = "tbOdd"
        Me.tbOdd.ReadOnly = True
        Me.tbOdd.Size = New System.Drawing.Size(56, 20)
        Me.tbOdd.TabIndex = 6
        Me.tbOdd.Text = "0"
        Me.tbOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Odd:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 170)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbOdd)
        Me.Controls.Add(Me.tbEven)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tbAdd)
        Me.Controls.Add(Me.lbNumbers)
        Me.Name = "Form1"
        Me.Text = "Even Odd Nos Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNumbers As ListBox
    Friend WithEvents tbAdd As TextBox
    Friend WithEvents btAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEven As TextBox
    Friend WithEvents tbOdd As TextBox
    Friend WithEvents Label3 As Label
End Class
