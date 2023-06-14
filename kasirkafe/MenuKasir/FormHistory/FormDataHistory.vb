Imports MySql.Data.MySqlClient

Public Class FormDataHistory
    Private Sub FormDataHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowTableHistory(Me.Text)
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.Padding = New Padding(10)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = MenuForm.txtNamaKasir.ForeColor
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Sub ShowTableHistory(ByVal tgl As String)
        Dim Query As String
        If tgl = "all" Then
            Query = "select * from tbl_transaksi"
        Else
            Query = "select * from tbl_transaksi where tgl_pembelian = '" & tgl & "'"
        End If
        Adp = New MySqlDataAdapter(Query, cn)
        Dst = New DataSet
        Dst.Clear()
        Adp.Fill(Dst, Query)
        DataGridView1.DataSource = (Dst.Tables(Query))


    End Sub


End Class