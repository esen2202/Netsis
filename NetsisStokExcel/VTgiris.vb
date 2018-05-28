'' Project Author : Erkan Esen
'' Created Date   : 02.07.2015 
'' erkanesen2202@gmail.com
Public Class VTgiris
    Dim BaglantiKontrol As Boolean
    Dim MainForm1 As MainForm = New MainForm

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Veritabani.server = txt_server.Text
        Veritabani.database = txt_database.Text
        Veritabani.userID = txt_userId.Text
        Veritabani.password = txt_password.Text
        Veritabani.port = nud_port.Value.ToString()

        If Not BackgroundWorker1.IsBusy Then
            Me.Text = "Bekleyin."
            Timer1.Enabled = True
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim netsisDB As Veritabani = New Veritabani()
        BaglantiKontrol = netsisDB.BaglantiKontrol()
        BackgroundWorker1.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BackgroundWorker1.IsBusy Then
            btn_connect.Enabled = False

            If Me.Text = "Bekleyin." Then
                Me.Text = "Bekleyin.."
            ElseIf Me.Text = "Bekleyin.." Then
                Me.Text = "Bekleyin..."
            ElseIf Me.Text = "Bekleyin..." Then
                Me.Text = "Bekleyin."
            End If
        Else
            If BaglantiKontrol Then

                MainForm1.Show()
                Me.Hide()
            Else
                btn_connect.Enabled = True
            End If

            Timer1.Enabled = False
            Me.Text = "Netsis Stok Kartı"
        End If

    End Sub

    Private Sub VTgiris_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MainForm1.Created Then
            MainForm1.Dispose()
        End If
    End Sub


    Private Sub VTgiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
