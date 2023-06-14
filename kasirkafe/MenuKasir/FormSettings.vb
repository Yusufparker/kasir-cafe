Public Class FormSettings
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.BackColor = MenuForm.txtNamaKasir.ForeColor
        Button1.ForeColor = Color.White

    End Sub

    Private Sub ConFormEnPanel(ByVal FormCon As Object)
        If Me.PanelSettings.Controls.Count > 0 Then
            Me.PanelSettings.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormCon, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelSettings.Controls.Add(fh)
        Me.PanelSettings.Tag = fh
        fh.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = MenuForm.txtNamaKasir.ForeColor
        Button1.ForeColor = Color.White
        Button2.BackColor = MenuForm.Panel1.BackColor
        Button2.ForeColor = MenuForm.txtNamaKasir.ForeColor
        Button3.BackColor = MenuForm.Panel1.BackColor
        Button3.ForeColor = MenuForm.txtNamaKasir.ForeColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = MenuForm.txtNamaKasir.ForeColor
        Button2.ForeColor = Color.White
        Button1.BackColor = MenuForm.Panel1.BackColor
        Button1.ForeColor = MenuForm.txtNamaKasir.ForeColor
        Button3.BackColor = MenuForm.Panel1.BackColor
        Button3.ForeColor = MenuForm.txtNamaKasir.ForeColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.BackColor = MenuForm.txtNamaKasir.ForeColor
        Button3.ForeColor = Color.White
        Button2.BackColor = MenuForm.Panel1.BackColor
        Button2.ForeColor = MenuForm.txtNamaKasir.ForeColor
        Button1.BackColor = MenuForm.Panel1.BackColor
        Button1.ForeColor = MenuForm.txtNamaKasir.ForeColor
    End Sub
End Class