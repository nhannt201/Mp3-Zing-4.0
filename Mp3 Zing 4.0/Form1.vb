Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wb.Navigate("http://nghenhac.luutru360.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tukhoa.Text = StrConv(tukhoa.Text, 2)
        tukhoa.Text = Replace(tukhoa.Text, "á", "a")
        tukhoa.Text = Replace(tukhoa.Text, "à", "a")
        tukhoa.Text = Replace(tukhoa.Text, "â", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ă", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ấ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ầ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ằ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ắ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ã", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ả", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ạ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẫ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẩ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẵ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẳ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ậ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ặ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "é", "e")
        tukhoa.Text = Replace(tukhoa.Text, "è", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẻ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẽ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẹ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ê", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ế", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ề", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ể", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ễ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ệ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ó", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ò", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỏ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "õ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ọ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ố", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ồ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ổ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỗ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ộ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ô", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ơ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ờ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ớ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ở", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỡ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ợ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ú", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ù", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ủ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ũ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ụ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ư", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ứ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ừ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ử", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ữ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ự", "u")
        tukhoa.Text = Replace(tukhoa.Text, "í", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ì", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ỉ", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ĩ", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ị", "i")
        tukhoa.Text = Replace(tukhoa.Text, "đ", "d")
        tukhoa.Text = Replace(tukhoa.Text, "ý", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỳ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỷ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỹ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỵ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "|", ",")
        wb.Navigate("http://mp3.zing.vn/tim-kiem/bai-hat.html?q=" & tukhoa.Text)
        tv.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub wb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        Try

            url.Text = Me.wb.Document.Url.ToString
            If InStr(url.Text, "http://mp3.zing.vn/") > 0 Then

            Else
                url.Text = ""
            End If
        Catch
            MsgBox("Trang này có chứa một số lệnh làm chương trình không thể chạy được!")
            wb.Navigate("http://mp3.zing.vn")
        End Try
    End Sub
   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If url.Text = "" Then
                MsgBox("Dường như bạn chưa nhập link mp3")
            Else
                Label7.Text = "Đang tải music nghe trước chất lượng thấp vui lòng đợi.."

                Panel2.Visible = False
                tv.Visible = False
                tv.URL = ""
                Button6.Visible = False
                Dim B As String
                Dim X() As String : X = Split(url.Text, "/")
                B = X(UBound(X))
                Dim xyz2 As String = ("http://nghenhac.luutru360.com/vipp.php?url=" & url.Text)
                Dim dwm2 As String = New System.Net.WebClient().DownloadString(xyz2)

                wmp.URL = dwm2
            End If
        Catch

            MsgBox("Lỗi không mong muốn đã xảy ra!")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' MsgBox("Không có nhiều thời gian nên chức năng tạm thời chưa có bạn thông cảm ^^!")
        Try
            If url.Text = "" Then
                MsgBox("DƯờng như bạn chưa nhập URL video")
            Else

                Label7.Text = "Đang tải video xem trước chất lượng thấp"
                wmp.URL = ""
                Dim xyz23 As String = ("http://nghenhac.luutru360.com/rev.php?link=" & url.Text)
                Dim dwm23 As String = New System.Net.WebClient().DownloadString(xyz23)

                Panel2.Visible = False
                tv.Visible = True
                Button6.Visible = True
                tv.URL = dwm23
            End If
        Catch

            MsgBox("Lỗi không mong muốn đã xảy ra hay do đường dẫn không hợp lệ!")
        End Try
       

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Label7.Text = "Vui lòng đợi ,đang triết xuất.."

            If url.Text = "" Then
                MsgBox("Vui lòng nhập link mp3")

            Else
                Panel2.Visible = True
                tv.Visible = False
                tv.URL = ""
                Button6.Visible = False
                Dim B As String
                Dim X() As String : X = Split(url.Text, "/")
                B = X(UBound(X))
                Dim xyz As String = ("http://nghenhac.luutru360.com/api.php?url=" & B)
                Dim dwm As String = New System.Net.WebClient().DownloadString(xyz)
                TextBox1.Text = dwm
                Dim xyz2 As String = ("http://nghenhac.luutru360.com/get2.php?url=" & url.Text)
                Dim dwm2 As String = New System.Net.WebClient().DownloadString(xyz2)
                Dim xyz20 As String = ("http://nghenhac.luutru360.com/vipp.php?url=" & url.Text)
                Dim dwm20 As String = New System.Net.WebClient().DownloadString(xyz20)
                TextBox2.Text = dwm2
                TextBox3.Text = dwm20
                wb.Navigate("http://nghenhac.luutru360.com/dw.php?url=" & dwm2)
              

            End If

        Catch
            MsgBox("Lỗi không mong muốn đã xảy ra!")

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        wb.Navigate("http://mp3.zing.vn")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '  MsgBox("Không có nhiều thời gian nên chức năng tạm thời chưa có bạn thông cảm ^^!")
        'http://nghenhac.luutru360.com/gettv.php?link=
        Try
        
            If url.Text = "" Then
                MsgBox("Bạn đang bỏ trống chưa nhập link video")
            Else
                Panel2.Visible = False
                tv.Visible = False
                tv.URL = ""
                Button6.Visible = False
                Dim acc As String = ("http://nghenhac.luutru360.com/gettv.php?link=" & url.Text)
                '  Dim dwm22 As String = New System.Net.WebClient().DownloadString(acc)

                Label7.Text = "Đang chờ máy chủ,vui lòng đợi..."
                ' tv.URL = dwm22
                wb.Navigate(acc)
                Timer1.Enabled = True
            End If

        Catch

            MsgBox("Lỗi không mong muốn đã xảy ra!")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tv.Visible = False
        Button6.Visible = False
    End Sub


    Private Sub url_DoubleClick(sender As Object, e As EventArgs) Handles url.DoubleClick
        url.Text = ""
    End Sub




    
    Private Sub tukhoa_DoubleClick(sender As Object, e As EventArgs) Handles tukhoa.DoubleClick
        tukhoa.Text = ""

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        tukhoa.Text = StrConv(tukhoa.Text, 2)
        tukhoa.Text = Replace(tukhoa.Text, "á", "a")
        tukhoa.Text = Replace(tukhoa.Text, "à", "a")
        tukhoa.Text = Replace(tukhoa.Text, "â", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ă", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ấ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ầ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ằ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ắ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ã", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ả", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ạ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẫ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẩ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẵ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ẳ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ậ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "ặ", "a")
        tukhoa.Text = Replace(tukhoa.Text, "é", "e")
        tukhoa.Text = Replace(tukhoa.Text, "è", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẻ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẽ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ẹ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ê", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ế", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ề", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ể", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ễ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ệ", "e")
        tukhoa.Text = Replace(tukhoa.Text, "ó", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ò", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỏ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "õ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ọ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ố", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ồ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ổ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỗ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ộ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ô", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ơ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ờ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ớ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ở", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ỡ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ợ", "o")
        tukhoa.Text = Replace(tukhoa.Text, "ú", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ù", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ủ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ũ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ụ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ư", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ứ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ừ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ử", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ữ", "u")
        tukhoa.Text = Replace(tukhoa.Text, "ự", "u")
        tukhoa.Text = Replace(tukhoa.Text, "í", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ì", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ỉ", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ĩ", "i")
        tukhoa.Text = Replace(tukhoa.Text, "ị", "i")
        tukhoa.Text = Replace(tukhoa.Text, "đ", "d")
        tukhoa.Text = Replace(tukhoa.Text, "ý", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỳ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỷ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỹ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "ỵ", "y")
        tukhoa.Text = Replace(tukhoa.Text, "|", ",")
        wb.Navigate("http://tainhaczingmp3.com/nhac-mp3/search.php?q=" & tukhoa.Text)
        tv.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub tukhoa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tukhoa.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            Try
                tukhoa.Text = StrConv(tukhoa.Text, 2)
                tukhoa.Text = Replace(tukhoa.Text, "á", "a")
                tukhoa.Text = Replace(tukhoa.Text, "à", "a")
                tukhoa.Text = Replace(tukhoa.Text, "â", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ă", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ấ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ầ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ằ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ắ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ã", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ả", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ạ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ẫ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ẩ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ẵ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ẳ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ậ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "ặ", "a")
                tukhoa.Text = Replace(tukhoa.Text, "é", "e")
                tukhoa.Text = Replace(tukhoa.Text, "è", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ẻ", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ẽ", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ẹ", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ê", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ế", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ề", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ể", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ễ", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ệ", "e")
                tukhoa.Text = Replace(tukhoa.Text, "ó", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ò", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ỏ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "õ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ọ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ố", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ồ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ổ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ỗ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ộ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ô", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ơ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ờ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ớ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ở", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ỡ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ợ", "o")
                tukhoa.Text = Replace(tukhoa.Text, "ú", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ù", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ủ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ũ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ụ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ư", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ứ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ừ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ử", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ữ", "u")
                tukhoa.Text = Replace(tukhoa.Text, "ự", "u")
                tukhoa.Text = Replace(tukhoa.Text, "í", "i")
                tukhoa.Text = Replace(tukhoa.Text, "ì", "i")
                tukhoa.Text = Replace(tukhoa.Text, "ỉ", "i")
                tukhoa.Text = Replace(tukhoa.Text, "ĩ", "i")
                tukhoa.Text = Replace(tukhoa.Text, "ị", "i")
                tukhoa.Text = Replace(tukhoa.Text, "đ", "d")
                tukhoa.Text = Replace(tukhoa.Text, "ý", "y")
                tukhoa.Text = Replace(tukhoa.Text, "ỳ", "y")
                tukhoa.Text = Replace(tukhoa.Text, "ỷ", "y")
                tukhoa.Text = Replace(tukhoa.Text, "ỹ", "y")
                tukhoa.Text = Replace(tukhoa.Text, "ỵ", "y")
                tukhoa.Text = Replace(tukhoa.Text, "|", ",")
                wb.Navigate("http://mp3.zing.vn/tim-kiem/bai-hat.html?q=" & tukhoa.Text)
                tv.Visible = False
                Button6.Visible = False
            Catch

            End Try

        End If
    End Sub

    Private Sub tukhoa_TextChanged(sender As Object, e As EventArgs) Handles tukhoa.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If InStr(url.Text, "http://nghenhac.luutru360.com/") > 0 Then
            url.Text = "http://mp3.zing.vn"
            Timer1.Enabled = False
        Else
            url.Text = ""
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub url_TextChanged(sender As Object, e As EventArgs) Handles url.TextChanged
        If InStr(url.Text, "http://nghenhac.luutru360.com/") > 0 Then
            url.Text = "http://mp3.zing.vn"

        Else


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If InStr(TextBox1.Text, "html") > 0 Then
            TextBox1.Text = "Không thể rút gọn link!"

        Else

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
      
    End Sub
End Class
