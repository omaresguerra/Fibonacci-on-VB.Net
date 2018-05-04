Public Class Form1

    Dim fibo As Double, _
    first As Double, _
    second As Double, _
    ending As Double, _
    position As Double

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        fibo = 0
        first = Val(txtStart.Text)
        second = Val(txtSecond.Text)
        ending = Val(txtEnd.Text)


        If txtStart.Text = "" Or txtSecond.Text = "" Or txtEnd.Text = "" Then
            MessageBox.Show("Enter number to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf ending <= 1 And ending > 0 Then
            MessageBox.Show("Enter higher number to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEnd.Text = ""
            txtEnd.Focus()

        ElseIf ending <= 0 Then
            MessageBox.Show("Enter positive number to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEnd.Text = ""
            txtEnd.Focus()
        Else
            btnOk.Enabled = False
            lstOutput.Items.Add(first)
            lstOutput.Items.Add(second)

            For i As Integer = 1 To ending - 2
                fibo = first + second
                first = second
                second = fibo
                lstOutput.Items.Add(fibo.ToString)
            Next

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtStart.Text = ""
        txtSecond.Text = ""
        txtEnd.Text = ""
        txtPosition.Text = ""
        lblPos.Text = ""
        lblDisplay.Text = ""
        txtStart.Focus()
        lstOutput.Items.Clear()
        btnOk.Enabled = True

    End Sub

    Private Sub btnPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPosition.Click
        position = Val(txtPosition.Text)
        ending = Val(txtEnd.Text)

        If txtStart.Text = "" Or txtSecond.Text = "" Or txtEnd.Text = "" Or txtPosition.Text = "" Then
            MessageBox.Show("Enter number to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStart.Focus()

        ElseIf position <= 0 Then
            MessageBox.Show("Out of index range!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblDisplay.Text = ""
            lblPos.Text = ""
            txtPosition.Text = ""
            txtPosition.Focus()
        Else

            If position <= ending Then
                lblPos.Text = position
                lblDisplay.Text = lstOutput.Items(position - 1)

            Else
                MessageBox.Show("Out of index range!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblDisplay.Text = ""
                lblPos.Text = ""
                txtPosition.Text = ""
                txtPosition.Focus()
            End If
        End If
    End Sub

End Class
