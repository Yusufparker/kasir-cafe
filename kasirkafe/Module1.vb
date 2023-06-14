Imports MySql.Data.MySqlClient

Module Module1
    Public cn As MySqlConnection
    Public Adp As MySqlDataAdapter
    Public Dst As DataSet
    Public Cmd As MySqlCommand
    Public Rdr As MySqlDataReader
    Public NamaKasir As String
    Public Username As String






    Sub myCon()
        Dim Alamat As String = "Server=127.0.0.1;Username=root;Password=;Database=db_kasir;Port=3306"
        cn = New MySqlConnection(Alamat)


        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()







            End If
        Catch ex As Exception



        End Try




    End Sub




    Sub showTable(ByVal Tbl As String, ByVal Grid As DataGridView)
        Dim Query As String = "Select * from " & Tbl & ""
        Adp = New MySqlDataAdapter(Query, cn)
        Dst = New DataSet
        Dst.Clear()
        Adp.Fill(Dst, Query)
        Grid.DataSource = (Dst.Tables(Query))


    End Sub






    Sub onlyNumber(ByVal e As KeyPressEventArgs, ByVal pos As TextBox)
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) And Not Char.IsControl(Ch) Then
            e.Handled = True
            Dim tol As New ToolTip()
            tol.ToolTipTitle = "Perhatian"
            tol.ShowAlways = True
            tol.SetToolTip(pos, "isi dengan number")


        End If






    End Sub




End Module
