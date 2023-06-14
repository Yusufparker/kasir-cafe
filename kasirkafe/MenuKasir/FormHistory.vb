Imports MySql.Data.MySqlClient

Public Class FormHistory
    Private Sub FormHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loopButton()
    End Sub



    Private Sub ConFormEnPanelHistory(ByVal FormCon As Object, ByVal Tanggal As String)
        If Me.PanelHistory2.Controls.Count > 0 Then
            Me.PanelHistory2.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormCon, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelHistory2.Controls.Add(fh)
        Me.PanelHistory2.Tag = fh
        fh.Text = Tanggal
        fh.Show()


    End Sub





    Sub loopButton()
        Cmd = New MySqlCommand("Select tgl_pembelian from tbl_transaksi", cn)
        Rdr = Cmd.ExecuteReader()
        Dim Tgl As String = ""
        While Rdr.Read()
            If Rdr(0) <> Tgl Then
                Dim Btn = New Button
                Dim Size As New Point(353, 80)
                Btn.Parent = panelHistory
                Btn.Dock = DockStyle.Top
                Btn.FlatStyle = FlatStyle.Flat
                Btn.FlatAppearance.BorderSize = 0
                Btn.Font = FormSettings.Button1.Font
                Btn.Size = Size
                Btn.BackColor = panelHistory.BackColor
                Btn.Text = Rdr(0)
                Tgl = Rdr(0)

                AddHandler Btn.Click, Sub()
                                          ConFormEnPanelHistory(New FormDataHistory, Btn.Text)
                                      End Sub


            End If
        End While
        Rdr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConFormEnPanelHistory(New FormDataHistory, "all")
    End Sub
End Class