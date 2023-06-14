Public Class MenuFormAdmin

    Private Sub MenuFormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCon()
        Me.WindowState = FormWindowState.Maximized
        txtNamaKasir.Text = NamaKasir
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are You Sure Want to Log Out From " & NamaKasir & "? ", vbYesNo) = vbYes Then
            Me.Close()
            FormLogin.Show()
        End If
    End Sub

    Private Sub ConFormEnPanel(ByVal FormCon As Object)
        If Me.Panel2.Controls.Count > 0 Then
            Me.Panel2.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormCon, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(fh)
        Me.Panel2.Tag = fh
        fh.Show()
    End Sub



    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ConFormEnPanel(New FormManage)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub
End Class