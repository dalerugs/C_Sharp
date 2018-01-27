Public Class Form1
    Private Sub ComputeTotal()
        Dim total As Double = 0
        Dim reg, tall, muffin, frenchPastry, veganCookies, biscotti, tunaSandwich, pancake, eggSandwich,
            bananaBread, water12Oz As Double
        Try
            reg = CDbl(tbReg.Text)
            tall = CDbl(tbTall.Text)
            muffin = CDbl(tbMuffin.Text)
            frenchPastry = CDbl(tbFrenchPastry.Text)
            veganCookies = CDbl(tbVeganCookies.Text)
            biscotti = CDbl(tbBiscotti.Text)
            tunaSandwich = CDbl(tbTunaSandwich.Text)
            pancake = CDbl(tbPancake.Text)
            eggSandwich = CDbl(tbEggSandwich.Text)
            bananaBread = CDbl(tbBananaBread.Text)
            water12Oz = CDbl(tbWater12Oz.Text)

            If sizeReg.Checked Then
                total += reg
            End If
            If sizeTall.Checked Then
                total += tall
            End If
            If othersMuffin.Checked Then
                total += muffin
            End If
            If othersFrenchPastry.Checked Then
                total += frenchPastry
            End If
            If othersVeganCookies.Checked Then
                total += veganCookies
            End If
            If othersBiscotti.Checked Then
                total += biscotti
            End If
            If othersTunaSandwich.Checked Then
                total += tunaSandwich
            End If
            If othersPancake.Checked Then
                total += pancake
            End If
            If othersEggSandwich.Checked Then
                total += eggSandwich
            End If
            If othersBananaBread.Checked Then
                total += bananaBread
            End If
            If othersWater12Oz.Checked Then
                total += water12Oz
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input")
        End Try
        tbTotal.Text = total
    End Sub

    Private Sub SizeReg_Click(sender As Object, e As EventArgs) Handles sizeReg.Click, sizeTall.Click,
            othersMuffin.Click, othersFrenchPastry.Click, othersVeganCookies.Click, othersBiscotti.Click,
            othersTunaSandwich.Click, othersPancake.Click, othersEggSandwich.Click, othersBananaBread.Click,
            othersWater12Oz.Click
        ComputeTotal()
    End Sub

    Private Sub TbCash_TextChanged(sender As Object, e As EventArgs) Handles tbCash.TextChanged
        Try
            Dim total As Double = CDbl(tbTotal.Text)
            tbChange.Text = CDbl(tbCash.Text) - total
        Catch ex As Exception
            MessageBox.Show("Invalid Input")
        End Try

    End Sub

    Private Sub tbReg_Leave(sender As Object, e As EventArgs) Handles tbWater12Oz.Leave, tbVeganCookies.Leave, tbTunaSandwich.Leave, tbTall.Leave, tbReg.Leave, tbPancake.Leave, tbMuffin.Leave, tbFrenchPastry.Leave, tbEggSandwich.Leave, tbBiscotti.Leave, tbBananaBread.Leave
        ComputeTotal()
    End Sub
End Class
