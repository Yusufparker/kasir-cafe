

Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCon()
        Me.WindowState = FormWindowState.Maximized
        txtNamaKasir.Text = NamaKasir
        ConFormEnPanel(New FormTransaksi)
        btnOrder.BackColor = txtNamaKasir.ForeColor
        btnOrder.ForeColor = Color.White



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


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ConFormEnPanel(New FormSettings)
        btnSettings.BackColor = txtNamaKasir.ForeColor
        btnSettings.ForeColor = Color.White
        btnHistory.BackColor = Panel1.BackColor
        btnHistory.ForeColor = txtNamaKasir.ForeColor
        btnOrder.BackColor = Panel1.BackColor
        btnOrder.ForeColor = txtNamaKasir.ForeColor




    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ConFormEnPanel(New FormHistory)
        btnSettings.BackColor = Panel1.BackColor
        btnSettings.ForeColor = txtNamaKasir.ForeColor
        btnHistory.BackColor = txtNamaKasir.ForeColor
        btnHistory.ForeColor = Color.White
        btnOrder.BackColor = Panel1.BackColor
        btnOrder.ForeColor = txtNamaKasir.ForeColor
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        ConFormEnPanel(New FormTransaksi)

        btnSettings.BackColor = Panel1.BackColor
        btnSettings.ForeColor = txtNamaKasir.ForeColor
        btnHistory.BackColor = Panel1.BackColor
        btnHistory.ForeColor = txtNamaKasir.ForeColor
        btnOrder.BackColor = txtNamaKasir.ForeColor
        btnOrder.ForeColor = Color.White
    End Sub


End Class