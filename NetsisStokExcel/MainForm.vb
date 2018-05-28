'' Project Author : Erkan Esen
'' Created Date   : 02.07.2015 
'' erkanesen2202@gmail.com

Imports System.Data.SqlClient 'Sql Server Connect (library)
Public Class MainForm
    Dim dosya As String
    Dim excelDs As New DataSet
    Dim kayitsayisi As Integer
    Dim dv, dv1 As New DataView
    Dim netsisDB As Veritabani = New Veritabani()
    Dim w As IO.StreamWriter
    Dim r As IO.StreamReader

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim Form1 As VTgiris = New VTgiris
        Form1.Visible = True
        Form1.btn_connect.Enabled = True
    End Sub

    Private Sub btn_excelSec_Click(sender As Object, e As EventArgs) Handles btn_excelSec.Click
        OpenFileDialog1.Filter = "Excel Files (*.xls)|*.xls"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            dosya = OpenFileDialog1.FileName
            txt_yol.Text = dosya
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_excelOku_Click(sender As Object, e As EventArgs) Handles btn_excelOku.Click
        Try
            'DataGridView1.Columns.Clear()
            excelDs.Tables.Clear()
            DataGridView1.Refresh()

            If dosya <> "" Then

                Dim erisim As New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" & dosya & ";Extended Properties=Excel 8.0")
                Dim adapter1 As New OleDb.OleDbDataAdapter("Select * from [" & txt_Sayfa.Text & "$]", erisim)

                excelDs.Clear()
                adapter1.Fill(excelDs, "NetsisStok")
                dv = excelDs.Tables("NetsisStok").DefaultView
                DataGridView1.DataSource = dv
                excelDs.Dispose()

                kayitsayisi = dv.Count.ToString()
                txt_kayitSayisi.Text = kayitsayisi.ToString()
                cb_stokIsmi.DataSource = dv
                cb_stokIsmi.DisplayMember = stokkodu.Text

            Else
                MsgBox("Önce Excel Dosyasını Seç")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hatalı İşlem: " + ex.ToString)
        End Try
    End Sub

    Private Sub islemdeDurum()
        If chk_ekleIptal.Checked Then
            lbl_ekle.Text = "Eklenmiyenler"
        Else
            lbl_ekle.Text = "Eklenenler"
        End If
        If chk_guncelIptal.Checked Then
            lbl_guncel.Text = "Güncellenmeyenler"
        Else
            lbl_guncel.Text = "Güncellenenler"
        End If
        btn_guncelle.Enabled = False
        btn_excelSec.Enabled = False
        btn_excelOku.Enabled = False
        chk_ekleIptal.Enabled = False
        chk_guncelIptal.Enabled = False
        ProgressBar1.Visible = True
        lbl_kayitIlerleme.Visible = True
        txt_Sayfa.Enabled = False
        stokkodu.Enabled = False
        aciklama.Enabled = False
        fiyat.Enabled = False
        birim.Enabled = False
        txt_sql.Enabled = False
        btn_sqlCalistir.Enabled = False

        txt_basariliCount.Text = "0"
        txt_basarisizCount.Text = "0"
        txt_ekleCount.Text = "0"
        txt_guncelCount.Text = "0"
    End Sub

    Private Sub varsayılanDurum()
        btn_guncelle.Enabled = True
        btn_excelSec.Enabled = True
        btn_excelOku.Enabled = True
        chk_ekleIptal.Enabled = True
        chk_guncelIptal.Enabled = True
        ProgressBar1.Visible = False
        lbl_kayitIlerleme.Visible = False
        txt_Sayfa.Enabled = True
        stokkodu.Enabled = True
        aciklama.Enabled = True
        fiyat.Enabled = True
        birim.Enabled = True
        txt_sql.Enabled = True
        btn_sqlCalistir.Enabled = True
    End Sub

    Private Sub btn_guncelle_Click(sender As Object, e As EventArgs) Handles btn_guncelle.Click
        Dim a As Integer
        Dim sira1 As Integer = 0
        Dim drv As DataRowView
        Dim guncelCount, ekleCount, basariliCount, basarisizCount As Integer
        Dim bosGec As Boolean = False
        islemdeDurum()
        lb_basarisiz.Items.Clear()
        lb_basarili.Items.Clear()
        lb_guncel.Items.Clear()
        lb_eklenen.Items.Clear()

        lbl_kayitIlerleme.Visible = True
        ProgressBar1.Visible = True

        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = kayitsayisi

        guncelCount = 0
        ekleCount = 0
        basariliCount = 0
        basarisizCount = 0

        Dim cmd As SqlCommand = Veritabani.baglanti.CreateCommand()

        For Each drv In dv
            bosGec = False
            ' Aranan Kayıt Varmı
            Try
                If drv(stokkodu.Text).ToString() <> "" And drv(fiyat.Text).ToString() <> "" And drv(birim.Text).ToString() <> "" Then
                    sira1 += 1

                    Dim fiyatValue As String
                    fiyatValue = drv(fiyat.Text).ToString().Replace(",", ".")

                    netsisDB.DataViewList("Select * From TBLSTSABIT Where  " & net_stokkodu.Text & " =  '" & drv(stokkodu.Text).ToString() & "' ", dv1)
                    Dim Sonuc As Integer = dv1.Count()

                    Veritabani.baglanti.Open()
                    'Dim cmd As SqlCommand = Veritabani.baglanti.CreateCommand()
                    Dim birimSTr As String = "0"
                    If drv(birim.Text).ToString() = "TL" Then
                        birimSTr = "0"
                    End If
                    If drv(birim.Text).ToString() = "USD" Then
                        birimSTr = "1"
                    End If
                    If drv(birim.Text).ToString() = "EUR" Then
                        birimSTr = "2"
                    End If

                    If Sonuc > 0 Then ' Stok kodlu Kayıt varsa

                        If Not chk_guncelIptal.Checked Then ' güncelleme aktif ise
                            cmd.CommandText = "update TBLSTSABIT set " & net_satisfiat1.Text & " = " & fiyatValue & "," & net_alisdovtip.Text & " = " & birimSTr & "," & net_satdovtip.Text & " = " & birimSTr & " where " & net_stokkodu.Text & " ='" & drv(stokkodu.Text).ToString() & "'"
                            cmd.ExecuteNonQuery()

                            basariliCount += 1
                            txt_basariliCount.Text = basariliCount.ToString()
                        Else
                            bosGec = True
                        End If

                        lb_guncel.Items.Add(CStr(sira1) & " : " & Chr(9) & drv(stokkodu.Text).ToString())

                        guncelCount += 1
                        txt_guncelCount.Text = guncelCount.ToString()

                    Else 'Kayıt Yoksa Ekle
                        If Not chk_ekleIptal.Checked Then ' ekleme aktif ise
                            cmd.CommandText = "Insert Into TBLSTSABIT (" & net_stokkodu.Text & ", " & net_stokadi.Text & ", " & net_satisfiat1.Text & "," & net_alisdovtip.Text & "," & net_satdovtip.Text & "," _
                            & "FIAT_BIRIMI, ISLETME_KODU, KDV_ORANI, OLCU_BR1, PAY_1, PAYDA_1, PAY2, PAYDA2, SUBE_KODU, UPDATE_KODU, ALIS_KDV_KODU) " _
                            & "VALUES ('" & drv(stokkodu.Text).ToString() & "', '" & drv(aciklama.Text).ToString() & "'," & fiyatValue & "," & birimSTr & "," _
                            & birimSTr & ",'1',1,18,'AD',1,1,1,1,0,'X',18)" ' update_kodu normale 'X'  ben yeni eklenenlerin ayırt edilebilmesi için 'E' yazıyorum                       
                            cmd.ExecuteNonQuery()

                            basariliCount += 1
                            txt_basariliCount.Text = basariliCount.ToString()
                        Else
                            bosGec = True
                        End If

                        lb_eklenen.Items.Add(CStr(sira1) & " : " & Chr(9) & drv(stokkodu.Text).ToString())

                        ekleCount += 1
                        txt_ekleCount.Text = ekleCount.ToString()

                    End If

                    If Not bosGec Then
                        cmd.CommandText = "Insert into TBLSTSABITEK(STOK_KODU) select stok_kodu from TBLSTSABIT where tblstsabit.STOK_KODU not in (select STOK_KODU from tblstsabitek)"
                        cmd.ExecuteNonQuery()
                        lb_basarili.Items.Add(CStr(sira1) & " : " & Chr(9) & drv(stokkodu.Text).ToString())
                    End If

                        Veritabani.baglanti.Close()
                Else
                    sira1 += 1
                    basarisizCount += 1
                    txt_basarisizCount.Text = basarisizCount.ToString()

                    lb_basarisiz.Items.Add(CStr(sira1) & " : " & Chr(9) & drv(stokkodu.Text).ToString())
                    Veritabani.baglanti.Close()

                    Dim result = MessageBox.Show("Devam Etmek İstiyormusunuz?", "Hata Satırı : " & CStr(sira1), MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        ProgressBar1.Value = 0
                        Exit For
                    End If
                End If



            Catch ex As Exception
                basarisizCount += 1
                txt_basarisizCount.Text = basarisizCount.ToString()

                lb_basarisiz.Items.Add(CStr(sira1) & " : " & Chr(9) & drv(stokkodu.Text).ToString())
                Veritabani.baglanti.Close()
                'MsgBox(ex.Message, MsgBoxStyle.Critical, " VeritabaniHatasi")
                Dim result = MessageBox.Show(ex.Message, "Devam Etmek İstiyormusunuz?", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    ProgressBar1.Value = 0
                    Exit For
                End If
            End Try

            a += 1
            ProgressBar1.Value = a
        Next
        varsayılanDurum()

    End Sub

    Private Sub btn_sqlCalistir_Click(sender As Object, e As EventArgs) Handles btn_sqlCalistir.Click
        Dim sql As String = txt_sql.Text
        netsisDB.DataViewList(sql, dv)
        DataGridView1.DataSource = dv
    End Sub


    Private Sub btn_basariliKaydet_Click(sender As Object, e As EventArgs) Handles btn_basariliKaydet.Click
        Dim i As Integer
        Dim kopyalanacak As String = String.Empty
        kopyalanacak &= "Excel'den Netsis'e Aktarımı Başarılı Olan Kayıtlar" & vbNewLine & vbNewLine
        kopyalanacak &= "Satır" & Chr(9) & "Stok_Kodu" & vbNewLine

        For i = 0 To lb_basarili.Items.Count - 1
            kopyalanacak &= lb_basarili.Items(i) & vbNewLine
        Next
        Clipboard.SetText(kopyalanacak)

        'Dim i As Integer
        'Try
        '    w = New IO.StreamWriter("c:\NetsisStok_Basarili.txt")
        '    For i = 0 To lb_basarili.Items.Count - 1
        '        w.WriteLine(lb_basarili.Items.Item(i))
        '    Next
        '    w.Close()
        '    Process.Start("c:\NetsisStok_Basarili.txt")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, " Dosya Kaydetme Hatası ")
        'End Try

    End Sub

    Private Sub btn_basarisizKaydet_Click(sender As Object, e As EventArgs) Handles btn_basarisizKaydet.Click
        Dim i As Integer
        Dim kopyalanacak As String = String.Empty
        kopyalanacak &= "Excel'den Netsis'e Aktarımı Başarısız Olan Kayıtlar" & vbNewLine & vbNewLine
        kopyalanacak &= "Satır" & Chr(9) & "Stok_Kodu" & vbNewLine

        For i = 0 To lb_basarisiz.Items.Count - 1
            kopyalanacak &= lb_basarisiz.Items(i) & vbNewLine
        Next
        Clipboard.SetText(kopyalanacak)


        'Try
        '    w = New IO.StreamWriter("c:\NetsisStok_Basarisiz.txt")
        '    For i = 0 To lb_basarisiz.Items.Count - 1
        '        w.WriteLine(lb_basarisiz.Items.Item(i))
        '    Next
        '    w.Close()
        '    Process.Start("c:\NetsisStok_Basarisiz.txt")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, " Dosya Kaydetme Hatası ")
        'End Try
    End Sub

    Private Sub btn_guncellenenKaydet_Click(sender As Object, e As EventArgs) Handles btn_guncellenenKaydet.Click
        Dim i As Integer
        Dim kopyalanacak As String = String.Empty
        kopyalanacak &= "Excel'den Netsis'e " & lbl_guncel.Text & " Kayıtlar" & vbNewLine & vbNewLine
        kopyalanacak &= "Satır" & Chr(9) & "Stok_Kodu" & vbNewLine

        For i = 0 To lb_guncel.Items.Count - 1
            kopyalanacak &= lb_guncel.Items(i) & vbNewLine
        Next
        Clipboard.SetText(kopyalanacak)


        'Dim i As Integer
        'Try
        '    w = New IO.StreamWriter("c:\NetsisStok_Guncellendi.txt")
        '    For i = 0 To lb_guncel.Items.Count - 1
        '        w.WriteLine(lb_guncel.Items.Item(i))
        '    Next
        '    w.Close()
        '    Process.Start("c:\NetsisStok_Guncellendi.txt")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, " Dosya Kaydetme Hatası ")
        'End Try
    End Sub

    Private Sub btn_eklenenKaydet_Click(sender As Object, e As EventArgs) Handles btn_eklenenKaydet.Click
        Dim i As Integer
        Dim kopyalanacak As String = String.Empty
        kopyalanacak &= "Excel'den Netsis'e " & lbl_ekle.Text & " Kayıtlar" & vbNewLine & vbNewLine
        kopyalanacak &= "Satır" & Chr(9) & "Stok_Kodu" & vbNewLine

        For i = 0 To lb_eklenen.Items.Count - 1
            kopyalanacak &= lb_eklenen.Items(i) & vbNewLine
        Next
        Clipboard.SetText(kopyalanacak)

        'Dim i As Integer
        'Try
        '    w = New IO.StreamWriter("c:\NetsisStok_Eklendi.txt")
        '    For i = 0 To lb_eklenen.Items.Count - 1
        '        w.WriteLine(lb_eklenen.Items.Item(i))
        '    Next
        '    w.Close()
        '    Process.Start("c:\NetsisStok_Eklendi.txt")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, " Dosya Kaydetme Hatası ")
        'End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/esen2202/Netsis")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("www.esensoftware.com")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(String.Format("mailto:{0}", "erkanesen@gmail.com"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Me.Dispose()
        VTgiris.Dispose()
    End Sub
End Class