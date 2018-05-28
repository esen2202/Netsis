'' Project Author : Erkan Esen
'' Created Date   : 02.07.2015 
'' erkanesen2202@gmail.com

Imports System.Data.SqlClient 'Sql Server Connect (library)

Public Class Veritabani

    Public Shared server As String
    Public Shared port As String
    Public Shared database As String
    Public Shared userID As String
    Public Shared password As String
    Private connectionstring As String
    Public Shared baglanti As SqlConnection

    Overloads Sub Veritabani()
        connectionstring = "Server=" & server + "," & port + ";Database=" & database & ";User Id=" & userID & ";Password=" & password & ";"
        baglanti = New SqlConnection(connectionstring)
    End Sub

    Public Function BaglantiKontrol() As Boolean
        Veritabani()
        If (baglanti.State <> System.Data.ConnectionState.Open) Then
            Try
                baglanti.Open()
                baglanti.Close()
                BaglantiKontrol = True
            Catch ex As Exception
                BaglantiKontrol = False
                MessageBox.Show("Bağlantı Kurulamadı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
        End If
        Return BaglantiKontrol
    End Function

    Public Sub DataViewList(ByVal SQL As String, ByRef dv As DataView)
        Dim ds As New DataSet

        Try
            baglanti.Open()
            Dim adapter = New SqlDataAdapter(SQL, baglanti) ' Send SQL Query
            adapter.Fill(ds) ' Result fill Dataset
            baglanti.Close()
            dv = ds.Tables(0).DefaultView
            ds.Dispose()
        Catch ex As Exception
            baglanti.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, " VeritabaniHatasi")
        End Try
    End Sub

    Public Sub SqlRun(ByVal SQL As String)
        Try
            baglanti.Open()
            Dim cmd As SqlCommand = baglanti.CreateCommand()
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()
            baglanti.Close()
        Catch ex As Exception
            baglanti.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, " VeritabaniHatasi")
        End Try
    End Sub

    Public Function InsertRun(ByVal SQL As String) As Integer
        Try
            baglanti.Open()
            Dim cmd As SqlCommand = baglanti.CreateCommand()
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Select SCOPE_IDENTITY()"
            InsertRun = CInt(cmd.ExecuteScalar)
            baglanti.Close()
        Catch ex As Exception
            baglanti.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "VeritabaniHatasi")
            InsertRun = 0
        End Try
    End Function

End Class
