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
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCharacter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbInput
        '
        Me.tbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.Location = New System.Drawing.Point(12, 52)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(260, 31)
        Me.tbInput.TabIndex = 8
        Me.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LINEAR SEARCH"
        '
        'tbCharacter
        '
        Me.tbCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCharacter.Location = New System.Drawing.Point(12, 99)
        Me.tbCharacter.Name = "tbCharacter"
        Me.tbCharacter.Size = New System.Drawing.Size(67, 31)
        Me.tbCharacter.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Search Character"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbResult
        '
        Me.tbResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResult.Location = New System.Drawing.Point(12, 145)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(260, 31)
        Me.tbResult.TabIndex = 12
        Me.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCharacter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Linear Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCharacter As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbResult As TextBox
End Class
