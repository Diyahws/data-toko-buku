Public Class FormDataBuku
    Sub panggildatabuku()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT kodeBuku, judulBuku, penulis, penerbit, stok, harga, username FROM databuku 
                                                          INNER JOIN admin ON kodeAdmin = databuku.adminKode", conn)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvBuku.DataSource = dt
            dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBuku.Columns(0).HeaderText = "Kode Buku"
            dgvBuku.Columns(1).HeaderText = "Judul Buku"
            dgvBuku.Columns(2).HeaderText = "Penulis"
            dgvBuku.Columns(3).HeaderText = "Penerbit"
            dgvBuku.Columns(4).HeaderText = "Stok"
            dgvBuku.Columns(5).HeaderText = "Harga"
            dgvBuku.Columns(6).HeaderText = "Admin"
        Else
            dgvBuku.DataSource = Nothing
        End If
    End Sub

    Sub datacbAdmin()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM admin", conn)
        dt = New DataTable
        da.Fill(dt)

        cmboxAdmin.DataSource = dt
        cmboxAdmin.DisplayMember = "username"
        cmboxAdmin.ValueMember = "kodeAdmin"
    End Sub

    Sub autokodebuku()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM databuku WHERE kodeBuku IN (SELECT MAX(kodeBuku) FROM databuku) 
                                                                                             ORDER BY kodeBuku DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "BK" + "001"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            str = "BK" + Microsoft.VisualBasic.Right("000" & lng, 3)
        End If
        txboxKdBuku.Text = str
    End Sub

    Sub kondisiawal()
        txboxKdBuku.Text = ""
        txboxKdBuku.Enabled = False
        txboxJudul.Enabled = False
        txboxPenulis.Enabled = False
        txboxPenerbit.Enabled = False
        txboxStok.Enabled = False
        txboxHarga.Enabled = False
        btnSimpan.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Sub kondisibatal()
        txboxCari.Text = ""
        txboxKdBuku.Text = ""
        txboxJudul.Text = ""
        txboxPenulis.Text = ""
        txboxPenerbit.Text = ""
        txboxStok.Text = ""
        txboxHarga.Text = ""
    End Sub

    Private Sub FormDataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildatabuku()
        datacbAdmin()
        autokodebuku()
        kondisiawal()
    End Sub

    Private Sub dgvBuku_Click(sender As Object, e As EventArgs) Handles dgvBuku.Click
        i = dgvBuku.CurrentRow.Index
        With dgvBuku.Rows.Item(i)
            txboxKdBuku.Text = .Cells(0).Value
            txboxJudul.Text = .Cells(1).Value
            txboxPenulis.Text = .Cells(2).Value
            txboxPenerbit.Text = .Cells(3).Value
            txboxStok.Text = .Cells(4).Value
            txboxHarga.Text = .Cells(5).Value
            cmboxAdmin.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT kodeBuku, judulBuku, penulis, penerbit, stok, harga, username FROM databuku 
                                                          INNER JOIN admin ON kodeAdmin = databuku.adminKode
                                                          WHERE kodeBuku LIKE '%" & txboxCari.Text & "%' OR
                                                                judulBuku LIKE '%" & txboxCari.Text & "%' OR
                                                                penulis LIKE '%" & txboxCari.Text & "%' OR
                                                                penerbit LIKE '%" & txboxCari.Text & "%' OR
                                                                stok LIKE '%" & txboxCari.Text & "%' OR
                                                                harga LIKE '%" & txboxCari.Text & "%' OR
                                                                username LIKE '%" & txboxCari.Text & "%'", conn)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvBuku.DataSource = dt
            dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBuku.Columns(0).HeaderText = "Kode Buku"
            dgvBuku.Columns(1).HeaderText = "Judul Buku"
            dgvBuku.Columns(2).HeaderText = "Penulis"
            dgvBuku.Columns(3).HeaderText = "Penerbit"
            dgvBuku.Columns(4).HeaderText = "Stok"
            dgvBuku.Columns(5).HeaderText = "Harga"
            dgvBuku.Columns(6).HeaderText = "Admin"
        Else
            dgvBuku.DataSource = Nothing
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        autokodebuku()
        datacbAdmin()
        txboxJudul.Select()
        txboxKdBuku.Enabled = True
        txboxJudul.Enabled = True
        txboxPenulis.Enabled = True
        txboxPenerbit.Enabled = True
        txboxStok.Enabled = True
        txboxHarga.Enabled = True
        btnSimpan.Enabled = True
        btnEdit.Enabled = True
        txboxCari.Text = ""
        txboxJudul.Text = ""
        txboxPenulis.Text = ""
        txboxPenerbit.Text = ""
        txboxStok.Text = ""
        txboxHarga.Text = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE databuku SET kodeBuku = '" & txboxKdBuku.Text & "',
                                                                           judulBuku = '" & txboxJudul.Text & "',
                                                                           penulis = '" & txboxPenulis.Text & "',
                                                                           penerbit = '" & txboxPenerbit.Text & "',
                                                                           stok = '" & txboxStok.Text & "',
                                                                           harga = '" & txboxHarga.Text & "',
                                                                           adminKode = '" & cmboxAdmin.SelectedValue & "'
                                                                     WHERE kodeBuku = '" & txboxKdBuku.Text & "'", conn)
        cmd.ExecuteNonQuery()
        panggildatabuku()
        MessageBox.Show("Data Berhasil Diedit", "Informasi", MessageBoxButtons.OK)
        kondisibatal()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()

        If MessageBox.Show("Yakin Akan Menghapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM databuku WHERE kodeBuku = '" & txboxKdBuku.Text & "'", conn)
            cmd.ExecuteNonQuery()
            panggildatabuku()
            MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK)
            kondisibatal()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        kondisibatal()
        kondisiawal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        If txboxKdBuku.Text = "" Or txboxJudul.Text = "" Or txboxPenulis.Text = "" Or txboxPenerbit.Text = "" Or txboxStok.Text = "" Or txboxHarga.Text = "" Or cmboxAdmin.Text = "" Then
            MessageBox.Show("Data Harus Diisi", "Peringatan!", MessageBoxButtons.OK)
        Else
            cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO databuku VALUES ('" & txboxKdBuku.Text & "',
                                                                                        '" & txboxJudul.Text & "',
                                                                                        '" & txboxPenulis.Text & "',
                                                                                        '" & txboxPenerbit.Text & "',
                                                                                        '" & txboxStok.Text & "',
                                                                                        '" & txboxHarga.Text & "',
                                                                                        '" & cmboxAdmin.SelectedValue & "')", conn)
            cmd.ExecuteNonQuery()
            panggildatabuku()
            MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK)
            kondisibatal()
            autokodebuku()
        End If
    End Sub
End Class