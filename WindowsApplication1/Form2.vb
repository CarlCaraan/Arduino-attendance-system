Imports System.IO
Imports System.IO.Ports


Public Class Form2




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
    Dim sflag24 As Integer
    Dim sflag25 As Integer

    Dim second As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m1 As MsgBoxResult
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString


        If Date.Today = MonthCalendar1.TodayDate And File.Exists(t & ".txt") = True Then
            m1 = MsgBox("Attendance Log this day, view them?", MsgBoxStyle.YesNo)
            If m1 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TextBox2.Enabled = True
                TextBox2.Show()
                Button1.Enabled = True
                Button1.Show()
                Button2.Enabled = True
                Button2.Show()
                Button3.Enabled = True
                Button3.Show()
                TextBox2.Text = File.ReadAllText(t & ".txt")
            End If
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
        sflag24 = 0
        sflag25 = 0

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












    Private Sub chkstart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkstart.CheckedChanged
        If chkstart.Enabled = True Then
            tflag = 1
            Timer3.Enabled = True
        End If
    End Sub









    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub stats()

        Dim add As String = ""

        ' for absent
        If chkstu1.Checked = False Then


            add = add & "Mr. Manuel Balela --------- Absent" & Environment.NewLine
        End If
        If chkstu2.Checked = False Then

            add = add & "Mr. Edrian Peter Villanueva --------- Absent" & Environment.NewLine

        End If
        If chkstu3.Checked = False Then

            add = add & "Ms. Diane Allison Masilang --------- Absent" & Environment.NewLine

        End If
        If chkstu4.Checked = False Then

            add = add & "Mr. Dean fader --------- Absent" & Environment.NewLine

        End If
        If chkstu5.Checked = False Then

            add = add & "Ms. Felicisima Coronado --------- Absent" & Environment.NewLine


        End If
        If chkstu6.Checked = False Then

            add = add & "Ms. Celeste Rivera --------- Absent" & Environment.NewLine


        End If
        If chkstu7.Checked = False Then

            add = add & "Ms. Lineth Bueno --------- Absent" & Environment.NewLine


        End If
        If chkstu8.Checked = False Then

            add = add & "Ms. Vivien Delfin --------- Absent" & Environment.NewLine


        End If
        If chkstu9.Checked = False Then

            add = add & "Ms. Mirabeth Encarnacion --------- Absent" & Environment.NewLine


        End If
        If chkstu10.Checked = False Then

            add = add & "Ms. Belinda Gonzales --------- Absent" & Environment.NewLine


        End If
        If chkstu11.Checked = False Then

            add = add & "Ms. Christine Maraña --------- Absent" & Environment.NewLine


        End If
        If chkstu12.Checked = False Then

            add = add & "Mr. Cirilo Ilagan --------- Absent" & Environment.NewLine


        End If
        If chkstu13.Checked = False Then

            add = add & "Ms. Ram Acero --------- Absent" & Environment.NewLine


        End If
        If chkstu14.Checked = False Then

            add = add & "Ms. Maria Carmelli Delos Santos --------- Absent" & Environment.NewLine


        End If
        If chkstu15.Checked = False Then

            add = add & "Ms. Bea Jiselle Rivera--------- Absent" & Environment.NewLine


        End If
        If chkstu16.Checked = False Then

            add = add & "Ms. Jennalyn Flores--------- Absent" & Environment.NewLine


        End If
        If chkstu17.Checked = False Then

            add = add & "Ms. Marlet Roan--------- Absent" & Environment.NewLine


        End If
        If chkstu18.Checked = False Then

            add = add & "Ms. Yolanda Leobrera --------- Absent" & Environment.NewLine


        End If
        If chkstu19.Checked = False Then

            add = add & "Ms. Maria Chairmine Manalo --------- Absent" & Environment.NewLine


        End If
        If chkstu20.Checked = False Then

            add = add & "Mr. Rustom Pereja --------- Absent" & Environment.NewLine


        End If
        If chkstu21.Checked = False Then

            add = add & "Ms. Joanne De Torres --------- Absent" & Environment.NewLine


        End If
        If chkstu22.Checked = False Then

            add = add & "Ms. Mary Joy Enriquez --------- Absent" & Environment.NewLine


        End If
        If chkstu23.Checked = False Then

            add = add & "PAOLO --------- Absent" & Environment.NewLine


        End If
        If chkstu24.Checked = False Then

            add = add & "CARL --------- Absent" & Environment.NewLine


        End If
        If chkstu25.Checked = False Then

            add = add & "KIM --------- Absent" & Environment.NewLine


        End If




        TextBox2.Text = add
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        stats()


    End Sub





    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        second = second + 1
        If second >= 2 Then
            Timer6.Stop()
            PictureBox3.ImageLocation = Nothing
            second = 0
        End If
    End Sub




End Class