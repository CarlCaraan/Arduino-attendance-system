Imports System.IO
Imports System.IO.Ports


Public Class Form1




    Dim secs As Integer
    Dim mins As Integer
    Dim m As MsgBoxResult
    Dim t As String

    ' teacher flag
    Dim tflag As Integer

    'flags for students
    Dim sflag1 As Integer ' student1 flag
    Dim sflag2 As Integer 'student2 flag
    Dim sflag3 As Integer
    Dim sflag4 As Integer
    Dim sflag5 As Integer
    Dim sflag6 As Integer
    Dim sflag7 As Integer
    Dim sflag8 As Integer
    Dim sflag9 As Integer
    Dim sflag10 As Integer
    Dim sflag11 As Integer
    Dim sflag12 As Integer
    Dim sflag13 As Integer
    Dim sflag14 As Integer
    Dim sflag15 As Integer
    Dim sflag16 As Integer
    Dim sflag17 As Integer
    Dim sflag18 As Integer
    Dim sflag19 As Integer
    Dim sflag20 As Integer
    Dim sflag21 As Integer
    Dim sflag22 As Integer
    Dim sflag23 As Integer

    Dim second As Integer
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As MsgBoxResult
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString


        If Date.Today = MonthCalendar1.TodayDate And File.Exists(t & ".txt") = True Then
            m1 = MsgBox("Attendance Log this day, view them?", MsgBoxStyle.YesNo)
        End If

        If m1 = MsgBoxResult.Yes Then
            MonthCalendar1.Enabled = False
            MonthCalendar1.Hide()
            TxtUsername.Enabled = True
            TxtUsername.Show()
            TxtUsername.Text = ""
            TxtPassword.Enabled = True
            TxtPassword.Show()
            TxtPassword.Text = ""
            BtnLogin.Enabled = True
            BtnLogin.Show()
            BtnLogin.Enabled = True
            LblUsername.Show()
            LblUsername.Enabled = True
            LblPassword.Show()
            Button4.Enabled = True
            Button4.Hide()
            Button5.Enabled = True
            Button5.Hide()
            Button6.Enabled = True
            Button6.Hide()
        End If

        tflag = 0
        sflag1 = 0
        sflag2 = 0
        sflag3 = 0
        sflag4 = 0
        sflag5 = 0
        sflag6 = 0
        sflag7 = 0
        sflag8 = 0
        sflag9 = 0
        sflag10 = 0
        sflag11 = 0
        sflag12 = 0
        sflag13 = 0
        sflag14 = 0
        sflag15 = 0
        sflag16 = 0
        sflag17 = 0
        sflag18 = 0
        sflag19 = 0
        sflag20 = 0
        sflag21 = 0
        sflag22 = 0
        sflag23 = 0

        SerialPort1.Close()
        SerialPort1.PortName = "com3"
        SerialPort1.BaudRate = "9600"
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' if the students comes in time, within 2 mins then the students will be marked present.
        If InStr(TextBox1.Text, "01-ACERO") And (sflag13 = 0) And tflag = 1 And mins <= 2 Then
            c13.Checked = True
            sflag13 = 1


            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "02-BALELA") And (sflag1 = 0) And tflag = 1 And mins <= 2 Then
            c1.Checked = True
            sflag1 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "03-BUENO") And (sflag7 = 0) And tflag = 1 And mins <= 2 Then
            c7.Checked = True
            sflag7 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "04-CORONADO") And (sflag5 = 0) And tflag = 1 And mins <= 2 Then
            c5.Checked = True
            sflag5 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "05-DELFIN") And (sflag8 = 0) And tflag = 1 And mins <= 2 Then
            c8.Checked = True
            sflag8 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "06-DELOSSANTOS") And (sflag14 = 0) And tflag = 1 And mins <= 2 Then
            c14.Checked = True
            sflag14 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "07-DETORRES") And (sflag21 = 0) And tflag = 1 And mins <= 2 Then
            c21.Checked = True
            sflag21 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "08-ENCARNACION") And (sflag9 = 0) And tflag = 1 And mins <= 2 Then
            c9.Checked = True
            sflag9 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "09-ENRIQUEZ") And (sflag22 = 0) And tflag = 1 And mins <= 2 Then
            c22.Checked = True
            sflag22 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "10-FADER") And (sflag4 = 0) And tflag = 1 And mins <= 2 Then
            c4.Checked = True
            sflag4 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project/WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "11-FLORES") And (sflag16 = 0) And tflag = 1 And mins <= 2 Then
            c16.Checked = True
            sflag16 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "12-GONZALES") And (sflag10 = 0) And tflag = 1 And mins <= 2 Then
            c10.Checked = True
            sflag10 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "13-ILAGAN") And (sflag12 = 0) And tflag = 1 And mins <= 2 Then
            c12.Checked = True
            sflag12 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "14-LEOBRERA") And (sflag18 = 0) And tflag = 1 And mins <= 2 Then
            c18.Checked = True
            sflag18 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "15-MANALO") And (sflag19 = 0) And tflag = 1 And mins <= 2 Then
            c19.Checked = True
            sflag19 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "16-MARANA") And (sflag11 = 0) And tflag = 1 And mins <= 2 Then
            c11.Checked = True
            sflag11 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "17-MASILANG") And (sflag3 = 0) And tflag = 1 And mins <= 2 Then
            c3.Checked = True
            sflag3 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "18-PEREJA") And (sflag20 = 0) And tflag = 1 And mins <= 2 Then
            c20.Checked = True
            sflag20 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "19-BRIVERA") And (sflag15 = 0) And tflag = 1 And mins <= 2 Then
            c15.Checked = True
            sflag15 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "20-CRIVERA") And (sflag6 = 0) And tflag = 1 And mins <= 2 Then
            c6.Checked = True
            sflag6 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "21-ROAN") And (sflag17 = 0) And tflag = 1 And mins <= 2 Then
            c17.Checked = True
            sflag17 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "22-VILLANUEVA") And (sflag2 = 0) And tflag = 1 And mins <= 2 Then
            c2.Checked = True
            sflag2 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If

        If InStr(TextBox1.Text, "23-TEST") And (sflag23 = 0) And tflag = 1 And mins <= 2 Then
            c23.Checked = True
            sflag23 = 1

            PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
            Timer6.Interval = 1000
            Timer6.Start()

        End If
    End Sub

    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived


        Try

            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() TextBox1.Text &= mydata, MethodInvoker))
            Else
                TextBox1.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'timer2 will be used to empty the textbox1 for the new data. the timer interval is set to 1 second.
        TextBox1.Text = ""
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ' timer3 will be used for the elapsed time. and this timer will be activated only when the teacher will check the box.
        secs = secs + 1
        lblsecs.Text = secs
        lblmins.Text = mins
        If secs = 60 Then
            secs = 0
            mins = mins + 1
        End If

    End Sub

    Private Sub chkstart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkstart.CheckedChanged
        If chkstart.Enabled = True Then
            tflag = 1
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label4.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Enabled = False
        TextBox2.Hide()
        TextBox3.Enabled = False
        TextBox3.Hide()
        Button1.Enabled = False
        Button1.Hide()
        Button2.Enabled = False
        Button2.Hide()
        Button3.Enabled = False
        Button3.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Hide()
        Button4.Enabled = True
        Button4.Show()
        Button5.Enabled = True
        Button5.Show()
        Button6.Enabled = True
        Button6.Show()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox2.Text = "" Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                End If
            End If
            If TextBox2.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TextBox2.Text)
            End If

            If TextBox3.Text = "" Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                End If
            End If
            If TextBox3.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TextBox3.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString
        Dim attendance As Integer = 0
        Try
            If File.Exists(t & ".txt") = True Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TxtUsername.Enabled = True
                TxtUsername.Show()
                TxtUsername.Text = ""
                TxtPassword.Enabled = True
                TxtPassword.Show()
                TxtPassword.Text = ""
                BtnLogin.Enabled = True
                BtnLogin.Show()
                BtnLogin.Enabled = True
                LblUsername.Show()
                LblUsername.Enabled = True
                LblPassword.Show()
                LblPassword.Enabled = True
                LblPassword.Show()

            Else
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TxtUsername.Enabled = True
                TxtUsername.Show()
                TxtUsername.Text = ""
                TxtPassword.Enabled = True
                TxtPassword.Show()
                TxtPassword.Text = ""
                BtnLogin.Enabled = True
                BtnLogin.Show()
                BtnLogin.Enabled = True
                LblUsername.Show()
                LblUsername.Enabled = True
                LblPassword.Show()
                LblPassword.Enabled = True
                LblPassword.Show()
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub stats()

        Dim add As String = ""

        ' for absent
        If c13.Checked = False Then


            add = add & "Acero, Ram --------- Absent" & Environment.NewLine
        End If
        If c1.Checked = False Then

            add = add & "Balela, Manuel --------- Absent" & Environment.NewLine

        End If
        If c7.Checked = False Then

            add = add & "Bueno, Lineth --------- Absent" & Environment.NewLine

        End If
        If c5.Checked = False Then

            add = add & "Coronado, Felicisima --------- Absent" & Environment.NewLine

        End If
        If c8.Checked = False Then

            add = add & "Delfin, Vivien --------- Absent" & Environment.NewLine


        End If
        If c14.Checked = False Then

            add = add & "Delos Santos, Maria Carmelli --------- Absent" & Environment.NewLine


        End If
        If c21.Checked = False Then

            add = add & "De Torres, Joanne --------- Absent" & Environment.NewLine


        End If
        If c9.Checked = False Then

            add = add & "Encarnacion, Mirabeth --------- Absent" & Environment.NewLine


        End If
        If c22.Checked = False Then

            add = add & "Enriquez, Mary Joy --------- Absent" & Environment.NewLine


        End If
        If c4.Checked = False Then

            add = add & "Fader, Dean Vincent --------- Absent" & Environment.NewLine


        End If
        If c16.Checked = False Then

            add = add & "Flores, Jennalyn --------- Absent" & Environment.NewLine


        End If
        If c10.Checked = False Then

            add = add & "Gonzales, Belinda --------- Absent" & Environment.NewLine


        End If
        If c12.Checked = False Then

            add = add & "Ilagan, Cirilo --------- Absent" & Environment.NewLine


        End If
        If c18.Checked = False Then

            add = add & "Leobrera, Yolanda --------- Absent" & Environment.NewLine


        End If
        If c19.Checked = False Then

            add = add & "Manalo, Maria Chairmine -------- Absent" & Environment.NewLine


        End If
        If c11.Checked = False Then

            add = add & "Maraña, Christine Jane --------- Absent" & Environment.NewLine


        End If
        If c3.Checked = False Then

            add = add & "Masilang, Diane Allison --------- Absent" & Environment.NewLine


        End If
        If c20.Checked = False Then

            add = add & "Pereja, Rustom --------- Absent" & Environment.NewLine


        End If
        If c15.Checked = False Then

            add = add & "Rivera, Bea Jiselle --------- Absent" & Environment.NewLine


        End If
        If c6.Checked = False Then

            add = add & "Rivera, Celeste --------- Absent" & Environment.NewLine


        End If
        If c17.Checked = False Then

            add = add & "Roan, Marlet --------- Absent" & Environment.NewLine


        End If
        If c2.Checked = False Then

            add = add & "Villanueva, Edrian Peter --------- Absent" & Environment.NewLine


        End If
        If c23.Checked = False Then

            add = add & "Test --------- Absent" & Environment.NewLine


        End If


        TextBox2.Text = add
    End Sub
    Private Sub stats2()

        Dim add As String = ""

        ' for present
        If c13.Checked = True Then


            add = add & "Acero, Ram --------- Present" & Environment.NewLine
        End If
        If c1.Checked = True Then

            add = add & "Balela, Manuel --------- Present" & Environment.NewLine

        End If
        If c7.Checked = True Then

            add = add & "Bueno, Lineth --------- Present" & Environment.NewLine

        End If
        If c5.Checked = True Then

            add = add & "Coronado, Felicisima --------- Present" & Environment.NewLine

        End If
        If c8.Checked = True Then

            add = add & "Delfin, Vivien --------- Present" & Environment.NewLine


        End If
        If c14.Checked = True Then

            add = add & "Delos Santos, Maria Carmelli --------- Present" & Environment.NewLine


        End If
        If c21.Checked = True Then

            add = add & "De Torres, Joanne --------- Present" & Environment.NewLine


        End If
        If c9.Checked = True Then

            add = add & "Encarnacion, Mirabeth --------- Present" & Environment.NewLine


        End If
        If c22.Checked = True Then

            add = add & "Enriquez, Mary Joy --------- Present" & Environment.NewLine


        End If
        If c4.Checked = True Then

            add = add & "Fader, Dean Vincent --------- Present" & Environment.NewLine


        End If
        If c16.Checked = True Then

            add = add & "Flores, Jennalyn --------- Present" & Environment.NewLine


        End If
        If c10.Checked = True Then

            add = add & "Gonzales, Belinda --------- Present" & Environment.NewLine


        End If
        If c12.Checked = True Then

            add = add & "Ilagan, Cirilo --------- Present" & Environment.NewLine


        End If
        If c18.Checked = True Then

            add = add & "Leobrera, Yolanda --------- Present" & Environment.NewLine


        End If
        If c19.Checked = True Then

            add = add & "Manalo, Maria Chairmine -------- Present" & Environment.NewLine


        End If
        If c11.Checked = True Then

            add = add & "Maraña, Christine Jane --------- Present" & Environment.NewLine


        End If
        If c3.Checked = True Then

            add = add & "Masilang, Diane Allison --------- Present" & Environment.NewLine


        End If
        If c20.Checked = True Then

            add = add & "Pereja, Rustom --------- Present" & Environment.NewLine


        End If
        If c15.Checked = True Then

            add = add & "Rivera, Bea Jiselle --------- Present" & Environment.NewLine


        End If
        If c6.Checked = True Then

            add = add & "Rivera, Celeste --------- Present" & Environment.NewLine


        End If
        If c17.Checked = True Then

            add = add & "Roan, Marlet --------- Present" & Environment.NewLine


        End If
        If c2.Checked = True Then

            add = add & "Villanueva, Edrian Peter --------- Present" & Environment.NewLine


        End If
        If c23.Checked = True Then

            add = add & "TEST --------- Present" & Environment.NewLine


        End If

        TextBox3.Text = add
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        stats()
        stats2()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub c13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c13.CheckedChanged
        ' If chkstu1.Checked = True Then
        'PictureBox3.ImageLocation = "C:\Users\RALP ALBERT\Documents\Visual Studio 2010\Projects\AARON Project\WindowsApplication11\Pictures\Fingerprints-182668331.jpg"
        ' End If
        '
        'If chkstu1.Checked = False Then
        'PictureBox3.ImageLocation = Nothing
        ' End If

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        second = second + 1
        If second >= 2 Then
            Timer6.Stop()
            PictureBox3.ImageLocation = Nothing
            second = 0
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        If TxtUsername.Text = "Admin" And TxtPassword.Text = "SMA60" Then
            MsgBox("Success!")
            Button4.Enabled = True
            Button4.Show()
            Button5.Enabled = True
            Button5.Show()
            TxtUsername.Enabled = True
            TxtUsername.Hide()
            TxtUsername.Text = ""
            TxtPassword.Enabled = True
            TxtPassword.Hide()
            TxtPassword.Text = ""
            BtnLogin.Enabled = True
            BtnLogin.Hide()
            BtnLogin.Enabled = True
            LblUsername.Hide()
            LblUsername.Enabled = True
            LblPassword.Hide()
            LblPassword.Enabled = True
            LblPassword.Hide()
            Button6.Enabled = True
            Button6.Show()

        Else
            MsgBox("Login failed, Please try again")
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox2.Show()
        TextBox2.Enabled = True
        TextBox2.Text = ""
        Button1.Enabled = True
        Button1.Show()
        Button2.Enabled = True
        Button2.Show()
        Button3.Enabled = True
        Button3.Show()
        Button4.Enabled = True
        Button4.Hide()
        Button5.Enabled = True
        Button5.Hide()
        Button6.Enabled = True
        Button6.Hide()


        If File.Exists(t & ".txt") = True Then
            TextBox2.Text = File.ReadAllText(t & ".txt")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Show()
        TextBox3.Enabled = True
        TextBox3.Text = ""
        Button1.Enabled = True
        Button1.Show()
        Button2.Enabled = True
        Button2.Show()
        Button3.Enabled = True
        Button3.Show()
        Button4.Enabled = True
        Button4.Hide()
        Button5.Enabled = True
        Button5.Hide()
        Button6.Enabled = True
        Button6.Hide()

        If File.Exists(t & ".txt") = True Then
            TextBox3.Text = File.ReadAllText(t & ".txt")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()
        Button4.Enabled = True
        Button4.Hide()
        Button5.Enabled = True
        Button5.Hide()
        Button6.Enabled = True
        Button6.Hide()
    End Sub

End Class