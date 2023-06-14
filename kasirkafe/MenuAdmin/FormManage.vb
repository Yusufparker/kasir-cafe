Imports System.Windows.Controls
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class FormManage
    Private Sub FormManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = MenuForm.Panel1.BackColor
        Panel2.BackColor = MenuForm.Panel1.BackColor
        Panel3.BackColor = MenuForm.Panel1.BackColor
        showTableBarang()
        setNoId()
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.Padding = New Padding(10)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = MenuForm.txtNamaKasir.ForeColor
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White



    End Sub


    Sub showTableBarang()
        Dim Query As String = "SELECT tbl_barang.id_barang, tbl_barang.nama_barang, tbl_detail_barang.ukuran, tbl_detail_barang.harga_barang
FROM tbl_barang
JOIN tbl_detail_barang
ON tbl_barang.id_barang = tbl_detail_barang.id_barang;
"
        Adp = New MySqlDataAdapter(Query, cn)
        Dst = New DataSet
        Dst.Clear()
        Adp.Fill(Dst, Query)
        DataGridView1.DataSource = (Dst.Tables(Query))
    End Sub

    Sub setNoId()
        Dim noId As Integer
        If DataGridView1.RowCount < 1 Then
            noId = 0
        Else
            Dim lastData As String = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0).Value
            noId = Int(lastData.Chars(2) + lastData.Chars(3))
        End If

        If noId + 1 < 10 Then
            txtId.Text = "KP0" & noId + 1

        Else
            txtId.Text = "KP" & noId + 1


        End If

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaM.KeyPress
        onlyNumber(e, txtHargaM)


    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNamaBarang.Text <> "" And txtHargaM.Text <> "" Then
            'tambah data tabel barang
            Dim query As String = "INSERT INTO tbl_barang value ('" & txtId.Text & "', '" & txtNamaBarang.Text & "')"
            Cmd = New MySqlCommand(query, cn)
            Cmd.ExecuteNonQuery()

            'tambah data tbl_detail_barang
            query = "INSERT INTO tbl_detail_barang value ('" & txtId.Text & "', '" & txtNamaBarang.Text & "')"
            Cmd = New MySqlCommand(query, cn)
            Cmd.ExecuteNonQuery()

            showTableBarang()
            reset()
            setNoId()


        Else
            MsgBox("Bidang Tidak Boleh Kosong")


        End If







    End Sub


    Sub reset()
        txtNamaBarang.Text = ""
        txtHargaM.Text = ""

    End Sub


    Sub getDataGrid()
        txtId.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtNamaBarang.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        txtHargaM.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()

    End Sub


    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        btnEdit.Visible = False
        btnReset.Visible = True
        btnKembali.Visible = False
        btnDelete.Visible = False

        setNoId()
        reset()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNamaBarang.Text <> "" And txtHargaM.Text <> "" Then
            Dim query As String = "UPDATE tbl_barang SET nama_barang ='" & txtNamaBarang.Text &
            "', harga_barang = '" & txtHargaM.Text & "' WHERE id ='" & txtId.Text & "'"
            Cmd = New MySqlCommand(query, cn)
            Cmd.ExecuteNonQuery()
            showTable("tbl_barang", DataGridView1)
            reset()
            setNoId()
            btnEdit.Visible = False
            btnReset.Visible = True
            btnKembali.Visible = False
            btnDelete.Visible = False

        Else
            MsgBox("Bidang Tidak Boleh Kosong")

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM tbl_barang  WHERE id ='" & txtId.Text & "'"
        Cmd = New MySqlCommand(query, cn)
        Cmd.ExecuteNonQuery()
        showTable("tbl_barang", DataGridView1)
        reset()
        setNoId()
        btnEdit.Visible = False
        btnReset.Visible = True
        btnKembali.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub DataGridView1_DoubleClick_1(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.RowCount > 0 Then
            getDataGrid()
            btnEdit.Visible = True
            btnReset.Visible = False
            btnKembali.Visible = True
            btnDelete.Visible = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class