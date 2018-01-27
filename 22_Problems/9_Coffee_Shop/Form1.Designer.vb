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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.coffeeMachiato = New System.Windows.Forms.RadioButton()
        Me.coffeeEspresso = New System.Windows.Forms.RadioButton()
        Me.CoffeeMocha = New System.Windows.Forms.RadioButton()
        Me.coffeeAmericano = New System.Windows.Forms.RadioButton()
        Me.coffeeCafeLatte = New System.Windows.Forms.RadioButton()
        Me.coffeeCappucino = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbWater12Oz = New System.Windows.Forms.TextBox()
        Me.othersWater12Oz = New System.Windows.Forms.CheckBox()
        Me.tbBananaBread = New System.Windows.Forms.TextBox()
        Me.othersBananaBread = New System.Windows.Forms.CheckBox()
        Me.tbEggSandwich = New System.Windows.Forms.TextBox()
        Me.othersEggSandwich = New System.Windows.Forms.CheckBox()
        Me.tbPancake = New System.Windows.Forms.TextBox()
        Me.othersPancake = New System.Windows.Forms.CheckBox()
        Me.tbTunaSandwich = New System.Windows.Forms.TextBox()
        Me.othersTunaSandwich = New System.Windows.Forms.CheckBox()
        Me.tbBiscotti = New System.Windows.Forms.TextBox()
        Me.othersBiscotti = New System.Windows.Forms.CheckBox()
        Me.tbVeganCookies = New System.Windows.Forms.TextBox()
        Me.othersVeganCookies = New System.Windows.Forms.CheckBox()
        Me.tbFrenchPastry = New System.Windows.Forms.TextBox()
        Me.othersFrenchPastry = New System.Windows.Forms.CheckBox()
        Me.tbMuffin = New System.Windows.Forms.TextBox()
        Me.othersMuffin = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdCold = New System.Windows.Forms.RadioButton()
        Me.rdHot = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbTall = New System.Windows.Forms.TextBox()
        Me.sizeTall = New System.Windows.Forms.RadioButton()
        Me.tbReg = New System.Windows.Forms.TextBox()
        Me.sizeReg = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbCash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.coffeeMachiato)
        Me.GroupBox1.Controls.Add(Me.coffeeEspresso)
        Me.GroupBox1.Controls.Add(Me.CoffeeMocha)
        Me.GroupBox1.Controls.Add(Me.coffeeAmericano)
        Me.GroupBox1.Controls.Add(Me.coffeeCafeLatte)
        Me.GroupBox1.Controls.Add(Me.coffeeCappucino)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coffee"
        '
        'coffeeMachiato
        '
        Me.coffeeMachiato.AutoSize = True
        Me.coffeeMachiato.Location = New System.Drawing.Point(139, 78)
        Me.coffeeMachiato.Name = "coffeeMachiato"
        Me.coffeeMachiato.Size = New System.Drawing.Size(75, 17)
        Me.coffeeMachiato.TabIndex = 5
        Me.coffeeMachiato.TabStop = True
        Me.coffeeMachiato.Text = "Macchiato"
        Me.coffeeMachiato.UseVisualStyleBackColor = True
        '
        'coffeeEspresso
        '
        Me.coffeeEspresso.AutoSize = True
        Me.coffeeEspresso.Location = New System.Drawing.Point(139, 55)
        Me.coffeeEspresso.Name = "coffeeEspresso"
        Me.coffeeEspresso.Size = New System.Drawing.Size(68, 17)
        Me.coffeeEspresso.TabIndex = 4
        Me.coffeeEspresso.TabStop = True
        Me.coffeeEspresso.Text = "Espresso"
        Me.coffeeEspresso.UseVisualStyleBackColor = True
        '
        'CoffeeMocha
        '
        Me.CoffeeMocha.AutoSize = True
        Me.CoffeeMocha.Location = New System.Drawing.Point(139, 32)
        Me.CoffeeMocha.Name = "CoffeeMocha"
        Me.CoffeeMocha.Size = New System.Drawing.Size(58, 17)
        Me.CoffeeMocha.TabIndex = 3
        Me.CoffeeMocha.TabStop = True
        Me.CoffeeMocha.Text = "Mocha"
        Me.CoffeeMocha.UseVisualStyleBackColor = True
        '
        'coffeeAmericano
        '
        Me.coffeeAmericano.AutoSize = True
        Me.coffeeAmericano.Location = New System.Drawing.Point(17, 78)
        Me.coffeeAmericano.Name = "coffeeAmericano"
        Me.coffeeAmericano.Size = New System.Drawing.Size(75, 17)
        Me.coffeeAmericano.TabIndex = 2
        Me.coffeeAmericano.TabStop = True
        Me.coffeeAmericano.Text = "Americano"
        Me.coffeeAmericano.UseVisualStyleBackColor = True
        '
        'coffeeCafeLatte
        '
        Me.coffeeCafeLatte.AutoSize = True
        Me.coffeeCafeLatte.Location = New System.Drawing.Point(17, 55)
        Me.coffeeCafeLatte.Name = "coffeeCafeLatte"
        Me.coffeeCafeLatte.Size = New System.Drawing.Size(74, 17)
        Me.coffeeCafeLatte.TabIndex = 1
        Me.coffeeCafeLatte.TabStop = True
        Me.coffeeCafeLatte.Text = "Cafe Latte"
        Me.coffeeCafeLatte.UseVisualStyleBackColor = True
        '
        'coffeeCappucino
        '
        Me.coffeeCappucino.AutoSize = True
        Me.coffeeCappucino.Location = New System.Drawing.Point(17, 32)
        Me.coffeeCappucino.Name = "coffeeCappucino"
        Me.coffeeCappucino.Size = New System.Drawing.Size(76, 17)
        Me.coffeeCappucino.TabIndex = 0
        Me.coffeeCappucino.TabStop = True
        Me.coffeeCappucino.Text = "Cappucino"
        Me.coffeeCappucino.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbWater12Oz)
        Me.GroupBox3.Controls.Add(Me.othersWater12Oz)
        Me.GroupBox3.Controls.Add(Me.tbBananaBread)
        Me.GroupBox3.Controls.Add(Me.othersBananaBread)
        Me.GroupBox3.Controls.Add(Me.tbEggSandwich)
        Me.GroupBox3.Controls.Add(Me.othersEggSandwich)
        Me.GroupBox3.Controls.Add(Me.tbPancake)
        Me.GroupBox3.Controls.Add(Me.othersPancake)
        Me.GroupBox3.Controls.Add(Me.tbTunaSandwich)
        Me.GroupBox3.Controls.Add(Me.othersTunaSandwich)
        Me.GroupBox3.Controls.Add(Me.tbBiscotti)
        Me.GroupBox3.Controls.Add(Me.othersBiscotti)
        Me.GroupBox3.Controls.Add(Me.tbVeganCookies)
        Me.GroupBox3.Controls.Add(Me.othersVeganCookies)
        Me.GroupBox3.Controls.Add(Me.tbFrenchPastry)
        Me.GroupBox3.Controls.Add(Me.othersFrenchPastry)
        Me.GroupBox3.Controls.Add(Me.tbMuffin)
        Me.GroupBox3.Controls.Add(Me.othersMuffin)
        Me.GroupBox3.Location = New System.Drawing.Point(275, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 287)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Others"
        '
        'tbWater12Oz
        '
        Me.tbWater12Oz.Location = New System.Drawing.Point(151, 239)
        Me.tbWater12Oz.Name = "tbWater12Oz"
        Me.tbWater12Oz.Size = New System.Drawing.Size(100, 20)
        Me.tbWater12Oz.TabIndex = 18
        Me.tbWater12Oz.Text = "25.00"
        Me.tbWater12Oz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersWater12Oz
        '
        Me.othersWater12Oz.AutoSize = True
        Me.othersWater12Oz.Location = New System.Drawing.Point(34, 240)
        Me.othersWater12Oz.Name = "othersWater12Oz"
        Me.othersWater12Oz.Size = New System.Drawing.Size(86, 17)
        Me.othersWater12Oz.TabIndex = 17
        Me.othersWater12Oz.Text = "Water 12 Oz"
        Me.othersWater12Oz.UseVisualStyleBackColor = True
        '
        'tbBananaBread
        '
        Me.tbBananaBread.Location = New System.Drawing.Point(151, 213)
        Me.tbBananaBread.Name = "tbBananaBread"
        Me.tbBananaBread.Size = New System.Drawing.Size(100, 20)
        Me.tbBananaBread.TabIndex = 16
        Me.tbBananaBread.Text = "90.00"
        Me.tbBananaBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersBananaBread
        '
        Me.othersBananaBread.AutoSize = True
        Me.othersBananaBread.Location = New System.Drawing.Point(34, 214)
        Me.othersBananaBread.Name = "othersBananaBread"
        Me.othersBananaBread.Size = New System.Drawing.Size(94, 17)
        Me.othersBananaBread.TabIndex = 15
        Me.othersBananaBread.Text = "Banana Bread"
        Me.othersBananaBread.UseVisualStyleBackColor = True
        '
        'tbEggSandwich
        '
        Me.tbEggSandwich.Location = New System.Drawing.Point(151, 187)
        Me.tbEggSandwich.Name = "tbEggSandwich"
        Me.tbEggSandwich.Size = New System.Drawing.Size(100, 20)
        Me.tbEggSandwich.TabIndex = 14
        Me.tbEggSandwich.Text = "30.00"
        Me.tbEggSandwich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersEggSandwich
        '
        Me.othersEggSandwich.AutoSize = True
        Me.othersEggSandwich.Location = New System.Drawing.Point(34, 188)
        Me.othersEggSandwich.Name = "othersEggSandwich"
        Me.othersEggSandwich.Size = New System.Drawing.Size(95, 17)
        Me.othersEggSandwich.TabIndex = 13
        Me.othersEggSandwich.Text = "Egg Sandwich"
        Me.othersEggSandwich.UseVisualStyleBackColor = True
        '
        'tbPancake
        '
        Me.tbPancake.Location = New System.Drawing.Point(151, 161)
        Me.tbPancake.Name = "tbPancake"
        Me.tbPancake.Size = New System.Drawing.Size(100, 20)
        Me.tbPancake.TabIndex = 12
        Me.tbPancake.Text = "40.00"
        Me.tbPancake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersPancake
        '
        Me.othersPancake.AutoSize = True
        Me.othersPancake.Location = New System.Drawing.Point(34, 162)
        Me.othersPancake.Name = "othersPancake"
        Me.othersPancake.Size = New System.Drawing.Size(69, 17)
        Me.othersPancake.TabIndex = 11
        Me.othersPancake.Text = "Pancake"
        Me.othersPancake.UseVisualStyleBackColor = True
        '
        'tbTunaSandwich
        '
        Me.tbTunaSandwich.Location = New System.Drawing.Point(151, 135)
        Me.tbTunaSandwich.Name = "tbTunaSandwich"
        Me.tbTunaSandwich.Size = New System.Drawing.Size(100, 20)
        Me.tbTunaSandwich.TabIndex = 10
        Me.tbTunaSandwich.Text = "40.00"
        Me.tbTunaSandwich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersTunaSandwich
        '
        Me.othersTunaSandwich.AutoSize = True
        Me.othersTunaSandwich.Location = New System.Drawing.Point(34, 136)
        Me.othersTunaSandwich.Name = "othersTunaSandwich"
        Me.othersTunaSandwich.Size = New System.Drawing.Size(101, 17)
        Me.othersTunaSandwich.TabIndex = 9
        Me.othersTunaSandwich.Text = "Tuna Sandwich"
        Me.othersTunaSandwich.UseVisualStyleBackColor = True
        '
        'tbBiscotti
        '
        Me.tbBiscotti.Location = New System.Drawing.Point(151, 109)
        Me.tbBiscotti.Name = "tbBiscotti"
        Me.tbBiscotti.Size = New System.Drawing.Size(100, 20)
        Me.tbBiscotti.TabIndex = 8
        Me.tbBiscotti.Text = "120.00"
        Me.tbBiscotti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersBiscotti
        '
        Me.othersBiscotti.AutoSize = True
        Me.othersBiscotti.Location = New System.Drawing.Point(34, 110)
        Me.othersBiscotti.Name = "othersBiscotti"
        Me.othersBiscotti.Size = New System.Drawing.Size(60, 17)
        Me.othersBiscotti.TabIndex = 7
        Me.othersBiscotti.Text = "Biscotti"
        Me.othersBiscotti.UseVisualStyleBackColor = True
        '
        'tbVeganCookies
        '
        Me.tbVeganCookies.Location = New System.Drawing.Point(151, 83)
        Me.tbVeganCookies.Name = "tbVeganCookies"
        Me.tbVeganCookies.Size = New System.Drawing.Size(100, 20)
        Me.tbVeganCookies.TabIndex = 6
        Me.tbVeganCookies.Text = "30.00"
        Me.tbVeganCookies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersVeganCookies
        '
        Me.othersVeganCookies.AutoSize = True
        Me.othersVeganCookies.Location = New System.Drawing.Point(34, 84)
        Me.othersVeganCookies.Name = "othersVeganCookies"
        Me.othersVeganCookies.Size = New System.Drawing.Size(98, 17)
        Me.othersVeganCookies.TabIndex = 5
        Me.othersVeganCookies.Text = "Vegan Cookies"
        Me.othersVeganCookies.UseVisualStyleBackColor = True
        '
        'tbFrenchPastry
        '
        Me.tbFrenchPastry.Location = New System.Drawing.Point(151, 57)
        Me.tbFrenchPastry.Name = "tbFrenchPastry"
        Me.tbFrenchPastry.Size = New System.Drawing.Size(100, 20)
        Me.tbFrenchPastry.TabIndex = 4
        Me.tbFrenchPastry.Text = "60.00"
        Me.tbFrenchPastry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersFrenchPastry
        '
        Me.othersFrenchPastry.AutoSize = True
        Me.othersFrenchPastry.Location = New System.Drawing.Point(34, 58)
        Me.othersFrenchPastry.Name = "othersFrenchPastry"
        Me.othersFrenchPastry.Size = New System.Drawing.Size(91, 17)
        Me.othersFrenchPastry.TabIndex = 3
        Me.othersFrenchPastry.Text = "French Pastry"
        Me.othersFrenchPastry.UseVisualStyleBackColor = True
        '
        'tbMuffin
        '
        Me.tbMuffin.Location = New System.Drawing.Point(151, 31)
        Me.tbMuffin.Name = "tbMuffin"
        Me.tbMuffin.Size = New System.Drawing.Size(100, 20)
        Me.tbMuffin.TabIndex = 2
        Me.tbMuffin.Text = "40.00"
        Me.tbMuffin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'othersMuffin
        '
        Me.othersMuffin.AutoSize = True
        Me.othersMuffin.Location = New System.Drawing.Point(34, 32)
        Me.othersMuffin.Name = "othersMuffin"
        Me.othersMuffin.Size = New System.Drawing.Size(55, 17)
        Me.othersMuffin.TabIndex = 0
        Me.othersMuffin.Text = "Muffin"
        Me.othersMuffin.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdCold)
        Me.GroupBox2.Controls.Add(Me.rdHot)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 63)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hot or Cold"
        '
        'rdCold
        '
        Me.rdCold.AutoSize = True
        Me.rdCold.Location = New System.Drawing.Point(139, 32)
        Me.rdCold.Name = "rdCold"
        Me.rdCold.Size = New System.Drawing.Size(46, 17)
        Me.rdCold.TabIndex = 3
        Me.rdCold.TabStop = True
        Me.rdCold.Text = "Cold"
        Me.rdCold.UseVisualStyleBackColor = True
        '
        'rdHot
        '
        Me.rdHot.AutoSize = True
        Me.rdHot.Location = New System.Drawing.Point(17, 32)
        Me.rdHot.Name = "rdHot"
        Me.rdHot.Size = New System.Drawing.Size(42, 17)
        Me.rdHot.TabIndex = 0
        Me.rdHot.TabStop = True
        Me.rdHot.Text = "Hot"
        Me.rdHot.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbTall)
        Me.GroupBox4.Controls.Add(Me.sizeTall)
        Me.GroupBox4.Controls.Add(Me.tbReg)
        Me.GroupBox4.Controls.Add(Me.sizeReg)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 97)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Size"
        '
        'tbTall
        '
        Me.tbTall.Location = New System.Drawing.Point(103, 59)
        Me.tbTall.Name = "tbTall"
        Me.tbTall.Size = New System.Drawing.Size(100, 20)
        Me.tbTall.TabIndex = 3
        Me.tbTall.Text = "150.00"
        Me.tbTall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'sizeTall
        '
        Me.sizeTall.AutoSize = True
        Me.sizeTall.Location = New System.Drawing.Point(52, 60)
        Me.sizeTall.Name = "sizeTall"
        Me.sizeTall.Size = New System.Drawing.Size(42, 17)
        Me.sizeTall.TabIndex = 2
        Me.sizeTall.TabStop = True
        Me.sizeTall.Text = "Tall"
        Me.sizeTall.UseVisualStyleBackColor = True
        '
        'tbReg
        '
        Me.tbReg.Location = New System.Drawing.Point(103, 33)
        Me.tbReg.Name = "tbReg"
        Me.tbReg.Size = New System.Drawing.Size(100, 20)
        Me.tbReg.TabIndex = 1
        Me.tbReg.Text = "100.00"
        Me.tbReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'sizeReg
        '
        Me.sizeReg.AutoSize = True
        Me.sizeReg.Location = New System.Drawing.Point(52, 34)
        Me.sizeReg.Name = "sizeReg"
        Me.sizeReg.Size = New System.Drawing.Size(45, 17)
        Me.sizeReg.TabIndex = 0
        Me.sizeReg.TabStop = True
        Me.sizeReg.Text = "Reg"
        Me.sizeReg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(425, 316)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 6
        Me.tbTotal.Text = "0.00"
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCash
        '
        Me.tbCash.Location = New System.Drawing.Point(425, 342)
        Me.tbCash.Name = "tbCash"
        Me.tbCash.Size = New System.Drawing.Size(100, 20)
        Me.tbCash.TabIndex = 8
        Me.tbCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cash:"
        '
        'tbChange
        '
        Me.tbChange.Location = New System.Drawing.Point(425, 368)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.ReadOnly = True
        Me.tbChange.Size = New System.Drawing.Size(100, 20)
        Me.tbChange.TabIndex = 10
        Me.tbChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Change:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 405)
        Me.Controls.Add(Me.tbChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffee Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents coffeeMachiato As RadioButton
    Friend WithEvents coffeeEspresso As RadioButton
    Friend WithEvents CoffeeMocha As RadioButton
    Friend WithEvents coffeeAmericano As RadioButton
    Friend WithEvents coffeeCafeLatte As RadioButton
    Friend WithEvents coffeeCappucino As RadioButton
    Friend WithEvents tbWater12Oz As TextBox
    Friend WithEvents othersWater12Oz As CheckBox
    Friend WithEvents tbBananaBread As TextBox
    Friend WithEvents othersBananaBread As CheckBox
    Friend WithEvents tbEggSandwich As TextBox
    Friend WithEvents othersEggSandwich As CheckBox
    Friend WithEvents tbPancake As TextBox
    Friend WithEvents othersPancake As CheckBox
    Friend WithEvents tbTunaSandwich As TextBox
    Friend WithEvents othersTunaSandwich As CheckBox
    Friend WithEvents tbBiscotti As TextBox
    Friend WithEvents othersBiscotti As CheckBox
    Friend WithEvents tbVeganCookies As TextBox
    Friend WithEvents othersVeganCookies As CheckBox
    Friend WithEvents tbFrenchPastry As TextBox
    Friend WithEvents othersFrenchPastry As CheckBox
    Friend WithEvents tbMuffin As TextBox
    Friend WithEvents othersMuffin As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdCold As RadioButton
    Friend WithEvents rdHot As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbTall As TextBox
    Friend WithEvents sizeTall As RadioButton
    Friend WithEvents tbReg As TextBox
    Friend WithEvents sizeReg As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbCash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbChange As TextBox
    Friend WithEvents Label3 As Label
End Class
