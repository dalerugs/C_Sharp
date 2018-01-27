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
        Me.tbSum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAddend1 = New System.Windows.Forms.TextBox()
        Me.tbAddend2 = New System.Windows.Forms.TextBox()
        Me.btCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbSum
        '
        Me.tbSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSum.Location = New System.Drawing.Point(132, 139)
        Me.tbSum.Name = "tbSum"
        Me.tbSum.ReadOnly = True
        Me.tbSum.Size = New System.Drawing.Size(100, 31)
        Me.tbSum.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sum:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Addends"
        '
        'tbAddend1
        '
        Me.tbAddend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddend1.Location = New System.Drawing.Point(39, 51)
        Me.tbAddend1.Name = "tbAddend1"
        Me.tbAddend1.Size = New System.Drawing.Size(100, 31)
        Me.tbAddend1.TabIndex = 6
        '
        'tbAddend2
        '
        Me.tbAddend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddend2.Location = New System.Drawing.Point(145, 51)
        Me.tbAddend2.Name = "tbAddend2"
        Me.tbAddend2.Size = New System.Drawing.Size(100, 31)
        Me.tbAddend2.TabIndex = 11
        '
        'btCalculate
        '
        Me.btCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalculate.Location = New System.Drawing.Point(102, 96)
        Me.btCalculate.Name = "btCalculate"
        Me.btCalculate.Size = New System.Drawing.Size(92, 37)
        Me.btCalculate.TabIndex = 12
        Me.btCalculate.Text = "Calculate"
        Me.btCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 198)
        Me.Controls.Add(Me.btCalculate)
        Me.Controls.Add(Me.tbAddend2)
        Me.Controls.Add(Me.tbSum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAddend1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAddend1 As TextBox
    Friend WithEvents tbAddend2 As TextBox
    Friend WithEvents btCalculate As Button
End Class
