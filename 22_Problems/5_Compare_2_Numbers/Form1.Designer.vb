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
        Me.btCompare = New System.Windows.Forms.Button()
        Me.tbNum2 = New System.Windows.Forms.TextBox()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNum1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btCompare
        '
        Me.btCompare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCompare.Location = New System.Drawing.Point(96, 96)
        Me.btCompare.Name = "btCompare"
        Me.btCompare.Size = New System.Drawing.Size(92, 37)
        Me.btCompare.TabIndex = 18
        Me.btCompare.Text = "Compare"
        Me.btCompare.UseVisualStyleBackColor = True
        '
        'tbNum2
        '
        Me.tbNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNum2.Location = New System.Drawing.Point(139, 51)
        Me.tbNum2.Name = "tbNum2"
        Me.tbNum2.Size = New System.Drawing.Size(100, 31)
        Me.tbNum2.TabIndex = 17
        '
        'tbResult
        '
        Me.tbResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResult.Location = New System.Drawing.Point(33, 139)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(206, 31)
        Me.tbResult.TabIndex = 16
        Me.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "COMPARE 2 NUMBERS"
        '
        'tbNum1
        '
        Me.tbNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNum1.Location = New System.Drawing.Point(33, 51)
        Me.tbNum1.Name = "tbNum1"
        Me.tbNum1.Size = New System.Drawing.Size(100, 31)
        Me.tbNum1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.btCompare)
        Me.Controls.Add(Me.tbNum2)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btCompare As Button
    Friend WithEvents tbNum2 As TextBox
    Friend WithEvents tbResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNum1 As TextBox
End Class
