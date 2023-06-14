Imports MySql.Data.MySqlClient

Public Class FormTransaksi
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCon()
        AddToCmb()
        txtHarga.Text = ""

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCoffe.SelectedIndexChanged
        cmbSize.Enabled = True
        cmbSize.SelectedText = ""
        txtHarga.Text = ""


    End Sub

    Sub AddToCmb()
        myCon()
        Cmd = New MySqlCommand("select id_barang, nama_barang from tbl_barang", cn)
        Adp = New MySqlDataAdapter(Cmd)
        Dim Dt As New DataTable("tbl_barang")
        Adp.Fill(Dt)

        If Dt.Rows.Count > 0 Then
            cmbCoffe.DataSource = Dt
            cmbCoffe.DisplayMember = "nama_barang"
            cmbCoffe.ValueMember = "id_barang"
        End If

        cmbCoffe.Text = ""




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtQty.Text <> "" And txtHarga.Text <> "" And cmbCoffe.Text <> "" Then
            AddDataGrid()
            txtHarga.Text = ""
            txtQty.Text = ""
            cmbCoffe.Text = ""
            cmbSize.Text = ""
            cmbSize.Enabled = False
            txtTotalBayar.Text = TotalBayar()

        Else
            MsgBox("field cannot be empty")
        End If







    End Sub

    Private Function TotalBayar()
        Dim TtlByr As Integer = 0
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            TtlByr += DataGridView1.Item(4, i).Value
        Next

        Return TtlByr
    End Function


    Sub AddDataGrid()
        DataGridView1.Rows.Add()
        DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = cmbCoffe.Text
        DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = txtQty.Text
        DataGridView1.Item(2, DataGridView1.RowCount - 1).Value = cmbCoffe.SelectedValue
        DataGridView1.Item(3, DataGridView1.RowCount - 1).Value = txtHarga.Text
        DataGridView1.Item(4, DataGridView1.RowCount - 1).Value = txtQty.Text * txtHarga.Text

    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        onlyNumber(e, txtQty)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If DataGridView1.RowCount < 1 Then
            MessageBox.Show("The customer hasn't bought anything yet")
        Else
            If txtBayar.Text = "" Then
                MessageBox.Show("field cannot be empty")

            ElseIf Convert.toInt32(txtBayar.Text) < Convert.toInt32(txtTotalBayar.Text) Then
                MessageBox.Show("money paid should be greater")
            Else
                Pembayaran()
                MessageBox.Show("Payment Successfull")
                txtKembalian.Text = Convert.ToInt32(txtBayar.Text) - Convert.ToInt32(txtTotalBayar.Text)
                txtBayar.ReadOnly = True
                btnBayar.Enabled = False
                btnDelete.Enabled = False
                btnDelete.Cursor = Cursors.No
                btnDelete.Cursor = Cursors.No



            End If
        End If

    End Sub


    Private Function getLastId()
        myCon()
        Dim LastID As Integer
        Cmd = New MySqlCommand("SELECT id_transaksi FROM tbl_transaksi ORDER BY id_transaksi DESC LIMIT 1 ", cn)
        Rdr = Cmd.ExecuteReader
        Rdr.Read()
        LastID = Rdr.GetValue(0)
        Rdr.Close()

        Return LastID
    End Function

    Private Function getIdKasir()
        myCon()
        Dim IdKasir As Integer
        Cmd = New MySqlCommand("SELECT id FROM tbl_kasir where user='" & NamaKasir & "'", cn)
        Rdr = Cmd.ExecuteReader
        Rdr.Read()
        IdKasir = Rdr.GetValue(0)
        Rdr.Close()

        Return IdKasir

    End Function

    Sub Pembayaran()
        Dim IdTransaksi, i As Integer
        Dim TotalBayar = txtTotalBayar.Text
        Dim tgl_beli As String = Format(Now, "dd/MM/yyy")
        Dim Query As String
        Query = "insert into tbl_transaksi (username,tgl_pembelian,total_bayar) value ('" & Username & "', '" & tgl_beli & "','" & TotalBayar & "')"
        Cmd = New MySqlCommand(Query, cn)
        Cmd.ExecuteNonQuery()
        IdTransaksi = getLastId()


        For i = 0 To DataGridView1.RowCount - 1
            Dim id_barang As String
            Dim Qty, Total As Integer
            Qty = DataGridView1.Item(1, i).Value
            Total = DataGridView1.Item(4, i).Value
            id_barang = DataGridView1.Item(2, i).Value
            Query = "insert into tbl_detail_transaksi (id_transaksi,id_barang,qty,total) value ('" & IdTransaksi & "','" & id_barang & "','" & Qty & "','" & Total & "')"
            Cmd = New MySqlCommand(Query, cn)
            Cmd.ExecuteNonQuery()
        Next




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            txtTotalBayar.Text = TotalBayar()
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub




    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        onlyNumber(e, txtBayar)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnBayar.Enabled = True
        btnDelete.Enabled = True
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Cursor = Cursors.Hand
        DataGridView1.Rows.Clear()
        txtTotalBayar.Text = 0
        txtBayar.Text = 0
        txtBayar.ReadOnly = False
        txtKembalian.Text = 0
    End Sub

    Private Sub cmbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSize.SelectedIndexChanged
        myCon()
        Cmd = New MySqlCommand("select tbl_detail_barang.harga_barang from  tbl_detail_barang, tbl_barang where tbl_barang.id_barang = tbl_detail_barang.id_barang and tbl_barang.id_barang='" & cmbCoffe.SelectedValue & "' and tbl_detail_barang.ukuran='" & cmbSize.Text & "'", cn)
        Rdr = Cmd.ExecuteReader
        Rdr.Read()
        txtHarga.Text = Rdr.GetValue(0)
        Rdr.Close()
    End Sub
End Class