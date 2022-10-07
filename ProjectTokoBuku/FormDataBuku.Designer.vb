<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txboxCari = New System.Windows.Forms.TextBox()
        Me.dgvBuku = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txboxKdBuku = New System.Windows.Forms.TextBox()
        Me.txboxJudul = New System.Windows.Forms.TextBox()
        Me.txboxPenulis = New System.Windows.Forms.TextBox()
        Me.txboxPenerbit = New System.Windows.Forms.TextBox()
        Me.txboxStok = New System.Windows.Forms.TextBox()
        Me.txboxHarga = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmboxAdmin = New System.Windows.Forms.ComboBox()
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txboxCari
        '
        Me.txboxCari.Location = New System.Drawing.Point(71, 59)
        Me.txboxCari.Name = "txboxCari"
        Me.txboxCari.Size = New System.Drawing.Size(169, 20)
        Me.txboxCari.TabIndex = 0
        '
        'dgvBuku
        '
        Me.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuku.Location = New System.Drawing.Point(12, 102)
        Me.dgvBuku.Name = "dgvBuku"
        Me.dgvBuku.Size = New System.Drawing.Size(468, 350)
        Me.dgvBuku.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Location = New System.Drawing.Point(486, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 350)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmboxAdmin)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.txboxKdBuku)
        Me.GroupBox2.Controls.Add(Me.txboxJudul)
        Me.GroupBox2.Controls.Add(Me.txboxPenulis)
        Me.GroupBox2.Controls.Add(Me.txboxPenerbit)
        Me.GroupBox2.Controls.Add(Me.txboxStok)
        Me.GroupBox2.Controls.Add(Me.txboxHarga)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 350)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txboxKdBuku
        '
        Me.txboxKdBuku.Location = New System.Drawing.Point(91, 42)
        Me.txboxKdBuku.Name = "txboxKdBuku"
        Me.txboxKdBuku.Size = New System.Drawing.Size(169, 20)
        Me.txboxKdBuku.TabIndex = 4
        '
        'txboxJudul
        '
        Me.txboxJudul.Location = New System.Drawing.Point(91, 68)
        Me.txboxJudul.Name = "txboxJudul"
        Me.txboxJudul.Size = New System.Drawing.Size(169, 20)
        Me.txboxJudul.TabIndex = 5
        '
        'txboxPenulis
        '
        Me.txboxPenulis.Location = New System.Drawing.Point(91, 94)
        Me.txboxPenulis.Name = "txboxPenulis"
        Me.txboxPenulis.Size = New System.Drawing.Size(169, 20)
        Me.txboxPenulis.TabIndex = 6
        '
        'txboxPenerbit
        '
        Me.txboxPenerbit.Location = New System.Drawing.Point(91, 120)
        Me.txboxPenerbit.Name = "txboxPenerbit"
        Me.txboxPenerbit.Size = New System.Drawing.Size(169, 20)
        Me.txboxPenerbit.TabIndex = 7
        '
        'txboxStok
        '
        Me.txboxStok.Location = New System.Drawing.Point(91, 146)
        Me.txboxStok.Name = "txboxStok"
        Me.txboxStok.Size = New System.Drawing.Size(169, 20)
        Me.txboxStok.TabIndex = 8
        '
        'txboxHarga
        '
        Me.txboxHarga.Location = New System.Drawing.Point(91, 172)
        Me.txboxHarga.Name = "txboxHarga"
        Me.txboxHarga.Size = New System.Drawing.Size(169, 20)
        Me.txboxHarga.TabIndex = 9
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(246, 53)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 30)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(12, 120)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 30)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 156)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(12, 192)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 30)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(39, 248)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 30)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(161, 248)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Judul Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Penulis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Stok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Admin"
        Me.Label8.Visible = False
        '
        'cmboxAdmin
        '
        Me.cmboxAdmin.FormattingEnabled = True
        Me.cmboxAdmin.Location = New System.Drawing.Point(91, 198)
        Me.cmboxAdmin.Name = "cmboxAdmin"
        Me.cmboxAdmin.Size = New System.Drawing.Size(169, 21)
        Me.cmboxAdmin.TabIndex = 13
        Me.cmboxAdmin.Visible = False
        '
        'FormDataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 464)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBuku)
        Me.Controls.Add(Me.txboxCari)
        Me.MaximizeBox = False
        Me.Name = "FormDataBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Buku"
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txboxCari As TextBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txboxKdBuku As TextBox
    Friend WithEvents txboxJudul As TextBox
    Friend WithEvents txboxPenulis As TextBox
    Friend WithEvents txboxPenerbit As TextBox
    Friend WithEvents txboxStok As TextBox
    Friend WithEvents txboxHarga As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmboxAdmin As ComboBox
    Friend WithEvents Label8 As Label
End Class
