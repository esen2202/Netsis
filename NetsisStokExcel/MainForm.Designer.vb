<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txt_yol = New System.Windows.Forms.TextBox()
        Me.txt_Sayfa = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_excelSec = New System.Windows.Forms.Button()
        Me.chk_ekleIptal = New System.Windows.Forms.CheckBox()
        Me.btn_excelOku = New System.Windows.Forms.Button()
        Me.chk_guncelIptal = New System.Windows.Forms.CheckBox()
        Me.btn_guncelle = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.net_satdovtip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.net_alisdovtip = New System.Windows.Forms.TextBox()
        Me.birim = New System.Windows.Forms.TextBox()
        Me.net_stokkodu = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.fiyat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.net_stokadi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.net_satisfiat1 = New System.Windows.Forms.TextBox()
        Me.aciklama = New System.Windows.Forms.TextBox()
        Me.stokkodu = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_kayitIlerleme = New System.Windows.Forms.Label()
        Me.btn_sqlCalistir = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cb_stokIsmi = New System.Windows.Forms.ComboBox()
        Me.txt_sql = New System.Windows.Forms.TextBox()
        Me.txt_kayitSayisi = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_ekleCount = New System.Windows.Forms.TextBox()
        Me.txt_guncelCount = New System.Windows.Forms.TextBox()
        Me.txt_basarisizCount = New System.Windows.Forms.TextBox()
        Me.txt_basariliCount = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btn_eklenenKaydet = New System.Windows.Forms.Button()
        Me.btn_guncellenenKaydet = New System.Windows.Forms.Button()
        Me.lbl_ekle = New System.Windows.Forms.Label()
        Me.lbl_guncel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_guncel = New System.Windows.Forms.ListBox()
        Me.lb_eklenen = New System.Windows.Forms.ListBox()
        Me.btn_basariliKaydet = New System.Windows.Forms.Button()
        Me.lb_basarili = New System.Windows.Forms.ListBox()
        Me.btn_basarisizKaydet = New System.Windows.Forms.Button()
        Me.lb_basarisiz = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_yol
        '
        Me.txt_yol.Location = New System.Drawing.Point(6, 13)
        Me.txt_yol.Name = "txt_yol"
        Me.txt_yol.ReadOnly = True
        Me.txt_yol.Size = New System.Drawing.Size(494, 20)
        Me.txt_yol.TabIndex = 14
        '
        'txt_Sayfa
        '
        Me.txt_Sayfa.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Sayfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Sayfa.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Sayfa.Location = New System.Drawing.Point(158, 85)
        Me.txt_Sayfa.Name = "txt_Sayfa"
        Me.txt_Sayfa.Size = New System.Drawing.Size(111, 24)
        Me.txt_Sayfa.TabIndex = 18
        Me.txt_Sayfa.Text = "Sayfa1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Maroon
        Me.Label23.Location = New System.Drawing.Point(133, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 25)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(134, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Excel Sayfa İsmini Gir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(12, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "1-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(12, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "2-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(12, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "3-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(12, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "4-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_excelSec)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chk_ekleIptal)
        Me.GroupBox1.Controls.Add(Me.btn_excelOku)
        Me.GroupBox1.Controls.Add(Me.chk_guncelIptal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_guncelle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Sayfa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 264)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btn_excelSec
        '
        Me.btn_excelSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_excelSec.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_excelSec.Image = Global.NetsisStokExcel.My.Resources.Resources.excelIn
        Me.btn_excelSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excelSec.Location = New System.Drawing.Point(51, 13)
        Me.btn_excelSec.Name = "btn_excelSec"
        Me.btn_excelSec.Size = New System.Drawing.Size(220, 49)
        Me.btn_excelSec.TabIndex = 12
        Me.btn_excelSec.Text = "Excel Dosyasını Seç"
        Me.btn_excelSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excelSec.UseVisualStyleBackColor = True
        '
        'chk_ekleIptal
        '
        Me.chk_ekleIptal.AutoSize = True
        Me.chk_ekleIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chk_ekleIptal.ForeColor = System.Drawing.Color.Maroon
        Me.chk_ekleIptal.Location = New System.Drawing.Point(52, 188)
        Me.chk_ekleIptal.Name = "chk_ekleIptal"
        Me.chk_ekleIptal.Size = New System.Drawing.Size(180, 20)
        Me.chk_ekleIptal.TabIndex = 30
        Me.chk_ekleIptal.Text = "Olmayan Kayıtları Ekleme"
        Me.chk_ekleIptal.UseVisualStyleBackColor = True
        '
        'btn_excelOku
        '
        Me.btn_excelOku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_excelOku.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_excelOku.Image = Global.NetsisStokExcel.My.Resources.Resources.excelRead
        Me.btn_excelOku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excelOku.Location = New System.Drawing.Point(51, 112)
        Me.btn_excelOku.Name = "btn_excelOku"
        Me.btn_excelOku.Size = New System.Drawing.Size(220, 49)
        Me.btn_excelOku.TabIndex = 12
        Me.btn_excelOku.Text = "Excel'den Verileri Oku"
        Me.btn_excelOku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excelOku.UseVisualStyleBackColor = True
        '
        'chk_guncelIptal
        '
        Me.chk_guncelIptal.AutoSize = True
        Me.chk_guncelIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chk_guncelIptal.ForeColor = System.Drawing.Color.Maroon
        Me.chk_guncelIptal.Location = New System.Drawing.Point(52, 169)
        Me.chk_guncelIptal.Name = "chk_guncelIptal"
        Me.chk_guncelIptal.Size = New System.Drawing.Size(199, 20)
        Me.chk_guncelIptal.TabIndex = 30
        Me.chk_guncelIptal.Text = "Varolan Kayıtları Güncelleme"
        Me.chk_guncelIptal.UseVisualStyleBackColor = True
        '
        'btn_guncelle
        '
        Me.btn_guncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_guncelle.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_guncelle.Image = Global.NetsisStokExcel.My.Resources.Resources.excelToNetsis
        Me.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guncelle.Location = New System.Drawing.Point(51, 209)
        Me.btn_guncelle.Name = "btn_guncelle"
        Me.btn_guncelle.Size = New System.Drawing.Size(220, 49)
        Me.btn_guncelle.TabIndex = 12
        Me.btn_guncelle.Text = "Netsise Aktar"
        Me.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guncelle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.net_satdovtip)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.net_alisdovtip)
        Me.GroupBox2.Controls.Add(Me.birim)
        Me.GroupBox2.Controls.Add(Me.net_stokkodu)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.fiyat)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.net_stokadi)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.net_satisfiat1)
        Me.GroupBox2.Controls.Add(Me.aciklama)
        Me.GroupBox2.Controls.Add(Me.stokkodu)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 129)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(72, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "1- Stok Kodu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "1- Stok Kodu"
        '
        'net_satdovtip
        '
        Me.net_satdovtip.Location = New System.Drawing.Point(169, 230)
        Me.net_satdovtip.Name = "net_satdovtip"
        Me.net_satdovtip.ReadOnly = True
        Me.net_satdovtip.Size = New System.Drawing.Size(100, 22)
        Me.net_satdovtip.TabIndex = 23
        Me.net_satdovtip.Text = "SAT_DOV_TIP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(10, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "EXCEL KOLON İSİMLERİ"
        '
        'net_alisdovtip
        '
        Me.net_alisdovtip.Location = New System.Drawing.Point(169, 208)
        Me.net_alisdovtip.Name = "net_alisdovtip"
        Me.net_alisdovtip.ReadOnly = True
        Me.net_alisdovtip.Size = New System.Drawing.Size(100, 22)
        Me.net_alisdovtip.TabIndex = 24
        Me.net_alisdovtip.Text = "ALIS_DOV_TIP"
        '
        'birim
        '
        Me.birim.Location = New System.Drawing.Point(169, 100)
        Me.birim.Name = "birim"
        Me.birim.Size = New System.Drawing.Size(100, 22)
        Me.birim.TabIndex = 27
        Me.birim.Text = "Birim"
        '
        'net_stokkodu
        '
        Me.net_stokkodu.Location = New System.Drawing.Point(169, 145)
        Me.net_stokkodu.Name = "net_stokkodu"
        Me.net_stokkodu.ReadOnly = True
        Me.net_stokkodu.Size = New System.Drawing.Size(100, 22)
        Me.net_stokkodu.TabIndex = 27
        Me.net_stokkodu.Text = "STOK_KODU"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(72, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "2- Açıklama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(72, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "2- Açıklama"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(10, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "NETSİS KOLON İSİMLERİ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(72, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 16)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "3- Fiyat"
        '
        'fiyat
        '
        Me.fiyat.Location = New System.Drawing.Point(169, 79)
        Me.fiyat.Name = "fiyat"
        Me.fiyat.Size = New System.Drawing.Size(100, 22)
        Me.fiyat.TabIndex = 28
        Me.fiyat.Text = "Fiyat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "3- Fiyat"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(72, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "4- Birim"
        '
        'net_stokadi
        '
        Me.net_stokadi.Location = New System.Drawing.Point(169, 166)
        Me.net_stokadi.Name = "net_stokadi"
        Me.net_stokadi.ReadOnly = True
        Me.net_stokadi.Size = New System.Drawing.Size(100, 22)
        Me.net_stokadi.TabIndex = 26
        Me.net_stokadi.Text = "STOK_ADI"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(72, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "4- Birim"
        '
        'net_satisfiat1
        '
        Me.net_satisfiat1.Location = New System.Drawing.Point(169, 187)
        Me.net_satisfiat1.Name = "net_satisfiat1"
        Me.net_satisfiat1.ReadOnly = True
        Me.net_satisfiat1.Size = New System.Drawing.Size(100, 22)
        Me.net_satisfiat1.TabIndex = 25
        Me.net_satisfiat1.Text = "SATIS_FIAT1"
        '
        'aciklama
        '
        Me.aciklama.Location = New System.Drawing.Point(169, 58)
        Me.aciklama.Name = "aciklama"
        Me.aciklama.Size = New System.Drawing.Size(100, 22)
        Me.aciklama.TabIndex = 29
        Me.aciklama.Text = "Aciklama"
        '
        'stokkodu
        '
        Me.stokkodu.Location = New System.Drawing.Point(169, 37)
        Me.stokkodu.Name = "stokkodu"
        Me.stokkodu.Size = New System.Drawing.Size(100, 22)
        Me.stokkodu.TabIndex = 30
        Me.stokkodu.Text = "Stok_Kodu"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Crimson
        Me.Label19.Location = New System.Drawing.Point(303, 631)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "4- Exceldeki Kolon İsimlerini Giriniz"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Crimson
        Me.Label20.Location = New System.Drawing.Point(303, 609)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "3- Excel Sayfa İsmini Belirtiniz"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Crimson
        Me.Label22.Location = New System.Drawing.Point(314, 590)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(236, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Birim Kolonu Degerleri : TL , USD, EUR  olmalıdır"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Crimson
        Me.Label21.Location = New System.Drawing.Point(303, 570)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(334, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "2- Excel de Sırasıyla 4 Kolon Vardır. Stok Kodu, Açıklama, Fiyat, Birim "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Crimson
        Me.Label24.Location = New System.Drawing.Point(303, 550)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(351, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "1- Excel Dosyasının İlk Satırı Kolon İsimleridir Kolon Ayarlarıyla Eşleşmelidir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_kayitIlerleme)
        Me.GroupBox3.Controls.Add(Me.btn_sqlCalistir)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.cb_stokIsmi)
        Me.GroupBox3.Controls.Add(Me.txt_sql)
        Me.GroupBox3.Controls.Add(Me.txt_kayitSayisi)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.txt_yol)
        Me.GroupBox3.Location = New System.Drawing.Point(297, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 518)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'lbl_kayitIlerleme
        '
        Me.lbl_kayitIlerleme.AutoSize = True
        Me.lbl_kayitIlerleme.BackColor = System.Drawing.Color.Transparent
        Me.lbl_kayitIlerleme.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_kayitIlerleme.Location = New System.Drawing.Point(6, 502)
        Me.lbl_kayitIlerleme.Name = "lbl_kayitIlerleme"
        Me.lbl_kayitIlerleme.Size = New System.Drawing.Size(266, 13)
        Me.lbl_kayitIlerleme.TabIndex = 22
        Me.lbl_kayitIlerleme.Text = "Varolan Kayıtlar Güncelleniyor... Olmayanlar Ekleniyor..."
        Me.lbl_kayitIlerleme.Visible = False
        '
        'btn_sqlCalistir
        '
        Me.btn_sqlCalistir.Location = New System.Drawing.Point(425, 456)
        Me.btn_sqlCalistir.Name = "btn_sqlCalistir"
        Me.btn_sqlCalistir.Size = New System.Drawing.Size(75, 23)
        Me.btn_sqlCalistir.TabIndex = 31
        Me.btn_sqlCalistir.Text = "SQL Test"
        Me.btn_sqlCalistir.UseVisualStyleBackColor = True
        Me.btn_sqlCalistir.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 439)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(494, 14)
        Me.ProgressBar1.TabIndex = 23
        Me.ProgressBar1.Visible = False
        '
        'cb_stokIsmi
        '
        Me.cb_stokIsmi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_stokIsmi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_stokIsmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cb_stokIsmi.FormattingEnabled = True
        Me.cb_stokIsmi.Location = New System.Drawing.Point(6, 36)
        Me.cb_stokIsmi.Name = "cb_stokIsmi"
        Me.cb_stokIsmi.Size = New System.Drawing.Size(494, 26)
        Me.cb_stokIsmi.TabIndex = 21
        '
        'txt_sql
        '
        Me.txt_sql.Location = New System.Drawing.Point(6, 457)
        Me.txt_sql.Name = "txt_sql"
        Me.txt_sql.Size = New System.Drawing.Size(420, 20)
        Me.txt_sql.TabIndex = 30
        Me.txt_sql.Text = "select * from dbo.TBLSTSABIT Where STOK_KODU Like '%260-%'"
        Me.txt_sql.Visible = False
        '
        'txt_kayitSayisi
        '
        Me.txt_kayitSayisi.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_kayitSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kayitSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kayitSayisi.Location = New System.Drawing.Point(444, 493)
        Me.txt_kayitSayisi.Name = "txt_kayitSayisi"
        Me.txt_kayitSayisi.ReadOnly = True
        Me.txt_kayitSayisi.Size = New System.Drawing.Size(62, 24)
        Me.txt_kayitSayisi.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(312, 497)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 16)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Okunan Kayıt Sayısı"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(6, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(494, 375)
        Me.DataGridView1.TabIndex = 15
        '
        'txt_ekleCount
        '
        Me.txt_ekleCount.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_ekleCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ekleCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ekleCount.ForeColor = System.Drawing.Color.DarkViolet
        Me.txt_ekleCount.Location = New System.Drawing.Point(322, 600)
        Me.txt_ekleCount.Name = "txt_ekleCount"
        Me.txt_ekleCount.ReadOnly = True
        Me.txt_ekleCount.Size = New System.Drawing.Size(62, 24)
        Me.txt_ekleCount.TabIndex = 8
        '
        'txt_guncelCount
        '
        Me.txt_guncelCount.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_guncelCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guncelCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_guncelCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_guncelCount.Location = New System.Drawing.Point(322, 287)
        Me.txt_guncelCount.Name = "txt_guncelCount"
        Me.txt_guncelCount.ReadOnly = True
        Me.txt_guncelCount.Size = New System.Drawing.Size(62, 24)
        Me.txt_guncelCount.TabIndex = 8
        '
        'txt_basarisizCount
        '
        Me.txt_basarisizCount.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_basarisizCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_basarisizCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_basarisizCount.ForeColor = System.Drawing.Color.Red
        Me.txt_basarisizCount.Location = New System.Drawing.Point(130, 287)
        Me.txt_basarisizCount.Name = "txt_basarisizCount"
        Me.txt_basarisizCount.ReadOnly = True
        Me.txt_basarisizCount.Size = New System.Drawing.Size(62, 24)
        Me.txt_basarisizCount.TabIndex = 8
        '
        'txt_basariliCount
        '
        Me.txt_basariliCount.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_basariliCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_basariliCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_basariliCount.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_basariliCount.Location = New System.Drawing.Point(130, 599)
        Me.txt_basariliCount.Name = "txt_basariliCount"
        Me.txt_basariliCount.ReadOnly = True
        Me.txt_basariliCount.Size = New System.Drawing.Size(62, 24)
        Me.txt_basariliCount.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_ekleCount)
        Me.GroupBox4.Controls.Add(Me.txt_guncelCount)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.btn_eklenenKaydet)
        Me.GroupBox4.Controls.Add(Me.btn_guncellenenKaydet)
        Me.GroupBox4.Controls.Add(Me.lbl_ekle)
        Me.GroupBox4.Controls.Add(Me.lbl_guncel)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lb_guncel)
        Me.GroupBox4.Controls.Add(Me.txt_basarisizCount)
        Me.GroupBox4.Controls.Add(Me.lb_eklenen)
        Me.GroupBox4.Controls.Add(Me.btn_basariliKaydet)
        Me.GroupBox4.Controls.Add(Me.txt_basariliCount)
        Me.GroupBox4.Controls.Add(Me.lb_basarili)
        Me.GroupBox4.Controls.Add(Me.btn_basarisizKaydet)
        Me.GroupBox4.Controls.Add(Me.lb_basarisiz)
        Me.GroupBox4.Location = New System.Drawing.Point(810, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(390, 632)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkRed
        Me.Label30.Location = New System.Drawing.Point(6, 329)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 16)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Başarılı"
        '
        'btn_eklenenKaydet
        '
        Me.btn_eklenenKaydet.Location = New System.Drawing.Point(322, 328)
        Me.btn_eklenenKaydet.Name = "btn_eklenenKaydet"
        Me.btn_eklenenKaydet.Size = New System.Drawing.Size(63, 21)
        Me.btn_eklenenKaydet.TabIndex = 24
        Me.btn_eklenenKaydet.Text = "Kopyala"
        Me.btn_eklenenKaydet.UseVisualStyleBackColor = True
        '
        'btn_guncellenenKaydet
        '
        Me.btn_guncellenenKaydet.Location = New System.Drawing.Point(322, 15)
        Me.btn_guncellenenKaydet.Name = "btn_guncellenenKaydet"
        Me.btn_guncellenenKaydet.Size = New System.Drawing.Size(63, 21)
        Me.btn_guncellenenKaydet.TabIndex = 22
        Me.btn_guncellenenKaydet.Text = "Kopyala"
        Me.btn_guncellenenKaydet.UseVisualStyleBackColor = True
        '
        'lbl_ekle
        '
        Me.lbl_ekle.AutoSize = True
        Me.lbl_ekle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ekle.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_ekle.Location = New System.Drawing.Point(195, 332)
        Me.lbl_ekle.Name = "lbl_ekle"
        Me.lbl_ekle.Size = New System.Drawing.Size(72, 16)
        Me.lbl_ekle.TabIndex = 20
        Me.lbl_ekle.Text = "Eklenenler"
        '
        'lbl_guncel
        '
        Me.lbl_guncel.AutoSize = True
        Me.lbl_guncel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_guncel.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_guncel.Location = New System.Drawing.Point(198, 17)
        Me.lbl_guncel.Name = "lbl_guncel"
        Me.lbl_guncel.Size = New System.Drawing.Size(98, 16)
        Me.lbl_guncel.TabIndex = 20
        Me.lbl_guncel.Text = "Güncellenenler"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Başarısız"
        '
        'lb_guncel
        '
        Me.lb_guncel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lb_guncel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_guncel.ForeColor = System.Drawing.Color.Green
        Me.lb_guncel.FormattingEnabled = True
        Me.lb_guncel.Location = New System.Drawing.Point(198, 36)
        Me.lb_guncel.Name = "lb_guncel"
        Me.lb_guncel.Size = New System.Drawing.Size(186, 275)
        Me.lb_guncel.TabIndex = 21
        '
        'lb_eklenen
        '
        Me.lb_eklenen.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lb_eklenen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_eklenen.ForeColor = System.Drawing.Color.Green
        Me.lb_eklenen.FormattingEnabled = True
        Me.lb_eklenen.Location = New System.Drawing.Point(198, 349)
        Me.lb_eklenen.Name = "lb_eklenen"
        Me.lb_eklenen.Size = New System.Drawing.Size(186, 275)
        Me.lb_eklenen.TabIndex = 23
        '
        'btn_basariliKaydet
        '
        Me.btn_basariliKaydet.Location = New System.Drawing.Point(129, 327)
        Me.btn_basariliKaydet.Name = "btn_basariliKaydet"
        Me.btn_basariliKaydet.Size = New System.Drawing.Size(63, 21)
        Me.btn_basariliKaydet.TabIndex = 20
        Me.btn_basariliKaydet.Text = "Kopyala"
        Me.btn_basariliKaydet.UseVisualStyleBackColor = True
        '
        'lb_basarili
        '
        Me.lb_basarili.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lb_basarili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_basarili.ForeColor = System.Drawing.Color.Green
        Me.lb_basarili.FormattingEnabled = True
        Me.lb_basarili.Location = New System.Drawing.Point(6, 348)
        Me.lb_basarili.Name = "lb_basarili"
        Me.lb_basarili.Size = New System.Drawing.Size(186, 275)
        Me.lb_basarili.TabIndex = 19
        '
        'btn_basarisizKaydet
        '
        Me.btn_basarisizKaydet.Location = New System.Drawing.Point(129, 15)
        Me.btn_basarisizKaydet.Name = "btn_basarisizKaydet"
        Me.btn_basarisizKaydet.Size = New System.Drawing.Size(63, 21)
        Me.btn_basarisizKaydet.TabIndex = 18
        Me.btn_basarisizKaydet.Text = "Kopyala"
        Me.btn_basarisizKaydet.UseVisualStyleBackColor = True
        '
        'lb_basarisiz
        '
        Me.lb_basarisiz.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lb_basarisiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_basarisiz.ForeColor = System.Drawing.Color.Red
        Me.lb_basarisiz.FormattingEnabled = True
        Me.lb_basarisiz.Location = New System.Drawing.Point(6, 36)
        Me.lb_basarisiz.Name = "lb_basarisiz"
        Me.lb_basarisiz.Size = New System.Drawing.Size(186, 275)
        Me.lb_basarisiz.TabIndex = 11
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NetsisStokExcel.My.Resources.Resources.close1
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetsisStokExcel.My.Resources.Resources.EsenSoftware
        Me.PictureBox1.Location = New System.Drawing.Point(12, 413)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 531)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(181, 13)
        Me.LinkLabel1.TabIndex = 34
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/esen2202/Netsis"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 550)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel2.TabIndex = 35
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "www.esensoftware.com"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(12, 570)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(115, 13)
        Me.LinkLabel3.TabIndex = 35
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "erkanesen@gmail.com"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1208, 656)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_excelSec As System.Windows.Forms.Button
    Friend WithEvents btn_excelOku As System.Windows.Forms.Button
    Friend WithEvents btn_guncelle As System.Windows.Forms.Button
    Friend WithEvents txt_yol As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sayfa As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents net_satdovtip As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents net_alisdovtip As System.Windows.Forms.TextBox
    Friend WithEvents birim As System.Windows.Forms.TextBox
    Friend WithEvents net_stokkodu As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents net_stokadi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents net_satisfiat1 As System.Windows.Forms.TextBox
    Friend WithEvents aciklama As System.Windows.Forms.TextBox
    Friend WithEvents stokkodu As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_kayitSayisi As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_ekleCount As System.Windows.Forms.TextBox
    Friend WithEvents txt_guncelCount As System.Windows.Forms.TextBox
    Friend WithEvents txt_basarisizCount As System.Windows.Forms.TextBox
    Friend WithEvents txt_basariliCount As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cb_stokIsmi As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_kayitIlerleme As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btn_eklenenKaydet As System.Windows.Forms.Button
    Friend WithEvents btn_guncellenenKaydet As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_guncel As System.Windows.Forms.ListBox
    Friend WithEvents lb_eklenen As System.Windows.Forms.ListBox
    Friend WithEvents btn_basariliKaydet As System.Windows.Forms.Button
    Friend WithEvents lb_basarili As System.Windows.Forms.ListBox
    Friend WithEvents btn_basarisizKaydet As System.Windows.Forms.Button
    Friend WithEvents lb_basarisiz As System.Windows.Forms.ListBox
    Friend WithEvents lbl_ekle As System.Windows.Forms.Label
    Friend WithEvents lbl_guncel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txt_sql As System.Windows.Forms.TextBox
    Friend WithEvents btn_sqlCalistir As System.Windows.Forms.Button
    Friend WithEvents chk_guncelIptal As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_ekleIptal As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
