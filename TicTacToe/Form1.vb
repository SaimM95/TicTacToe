Public Class Form1

    Dim crossWin, circleWin As Boolean
    Dim crossA1, crossA2, crossA3, crossB1, crossB2, crossB3, crossC1, crossC2, crossC3 As Boolean
    Dim circleA1, circleA2, circleA3, circleB1, circleB2, circleB3, circleC1, circleC2, circleC3 As Boolean
    Dim turnCount, crossCount, circleCount, crossWinCount, crossWinCounttemp As Integer
    Dim crossx(4), crossy(4), circlex(3), circley(3) As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""

        set_boolFalse()

    End Sub

    'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    '    e.Graphics.DrawLine(Pens.Black, 100, 0, 100, 300)
    '    e.Graphics.DrawLine(Pens.Black, 200, 0, 200, 300)
    '    e.Graphics.DrawLine(Pens.Black, 0, 100, 300, 100)
    '    e.Graphics.DrawLine(Pens.Black, 0, 200, 300, 200)
    '    MyBase.OnPaint(e)
    'End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            'ReDim crossx(crossCount)
            PictureBox1.Image = My.Resources.Cross
            PictureBox1.Enabled = False
            crossA1 = True

            'crossx(crossCount) = PictureBox1.Location.X
            'crossy(crossCount) = PictureBox1.Location.Y
            'crossCount += 1
        Else
            PictureBox1.Image = My.Resources.Circle
            PictureBox1.Enabled = False
            circleA1 = True

            'circlex(circleCount) = PictureBox1.Location.X
            'circley(circleCount) = PictureBox1.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            'ReDim crossx(crossCount)
            PictureBox2.Image = My.Resources.Cross
            PictureBox2.Enabled = False
            crossA2 = True

            'crossx(crossCount) = PictureBox2.Location.X
            'crossy(crossCount) = PictureBox2.Location.Y
            'crossCount += 1
        Else
            PictureBox2.Image = My.Resources.Circle
            PictureBox2.Enabled = False
            circleA2 = True

            'circlex(circleCount) = PictureBox2.Location.X
            'circley(circleCount) = PictureBox2.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            'ReDim crossx(crossCount)
            PictureBox3.Image = My.Resources.Cross
            PictureBox3.Enabled = False
            crossA3 = True

            'crossx(crossCount) = PictureBox3.Location.X
            'crossy(crossCount) = PictureBox3.Location.Y
            'crossCount += 1
        Else
            PictureBox3.Image = My.Resources.Circle
            PictureBox3.Enabled = False
            circleA3 = True

            'circlex(circleCount) = PictureBox3.Location.X
            'circley(circleCount) = PictureBox3.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox4.Image = My.Resources.Cross
            PictureBox4.Enabled = False
            crossB1 = True

            'crossx(crossCount) = PictureBox4.Location.X
            'crossy(crossCount) = PictureBox4.Location.Y
            'crossCount += 1
        Else
            PictureBox4.Image = My.Resources.Circle
            PictureBox4.Enabled = False
            circleB1 = True

            'circlex(circleCount) = PictureBox4.Location.X
            'circley(circleCount) = PictureBox4.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox5.Image = My.Resources.Cross
            PictureBox5.Enabled = False
            crossB2 = True

            'crossx(crossCount) = PictureBox5.Location.X
            'crossy(crossCount) = PictureBox5.Location.Y
            'crossCount += 1
        Else
            PictureBox5.Image = My.Resources.Circle
            PictureBox5.Enabled = False
            circleB2 = True

            'circlex(circleCount) = PictureBox5.Location.X
            'circley(circleCount) = PictureBox5.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox6.Image = My.Resources.Cross
            PictureBox6.Enabled = False
            crossB3 = True

            'crossx(crossCount) = PictureBox6.Location.X
            'crossy(crossCount) = PictureBox6.Location.Y
            'crossCount += 1
        Else
            PictureBox6.Image = My.Resources.Circle
            PictureBox6.Enabled = False
            circleB3 = True

            'circlex(circleCount) = PictureBox6.Location.X
            'circley(circleCount) = PictureBox6.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox7.Image = My.Resources.Cross
            PictureBox7.Enabled = False
            crossC1 = True

            'crossx(crossCount) = PictureBox7.Location.X
            'crossy(crossCount) = PictureBox7.Location.Y
            'crossCount += 1
        Else
            PictureBox7.Image = My.Resources.Circle
            PictureBox7.Enabled = False
            circleC1 = True

            'circlex(circleCount) = PictureBox7.Location.X
            'circley(circleCount) = PictureBox7.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox8.Image = My.Resources.Cross
            PictureBox8.Enabled = False
            crossC2 = True

            'crossx(crossCount) = PictureBox8.Location.X
            'crossy(crossCount) = PictureBox8.Location.Y
            'crossCount += 1
        Else
            PictureBox8.Image = My.Resources.Circle
            PictureBox8.Enabled = False
            circleC2 = True

            'circlex(circleCount) = PictureBox8.Location.X
            'circley(circleCount) = PictureBox8.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        turnCount += 1

        If (turnCount Mod 2 = 1) Then
            PictureBox9.Image = My.Resources.Cross
            PictureBox9.Enabled = False
            crossC3 = True

            'crossx(crossCount) = PictureBox9.Location.X
            'crossy(crossCount) = PictureBox9.Location.Y
            'crossCount += 1
        Else
            PictureBox9.Image = My.Resources.Circle
            PictureBox9.Enabled = False
            circleC3 = True

            'circlex(circleCount) = PictureBox9.Location.X
            'circley(circleCount) = PictureBox9.Location.Y
            'circleCount += 1
        End If

        check()
    End Sub

    Private Sub abc()
        Label1.Text = "Crosses: "

        Dim crossx2() As Double = crossx

        Array.Sort(crossx2)

        For i = LBound(crossx2) To UBound(crossx2)
            Label1.Text &= crossx2(i) & "   "
            If Not crossx2(i) = 0 Then
                For i2 = LBound(crossx2) To UBound(crossx2)

                    If crossx2(i2) = crossx2(i) Then
                        crossWinCount += 1
                    Else
                        If crossWinCount > crossWinCounttemp Then
                            crossWinCounttemp = crossWinCount
                        End If
                        crossWinCount = 0
                    End If
                Next
            End If
        Next

        'If crossWinCount = 3 Then
        Label3.Text = crossWinCounttemp
        'End If

        Label2.Text = "Circles: "
        For j = LBound(circlex) To UBound(circlex)
            Label2.Text &= circlex(j) & "," & circley(j) & "   "
        Next
    End Sub

    Private Sub set_boolFalse()
        crossA1 = False
        crossA2 = False
        crossA3 = False
        crossB1 = False
        crossB2 = False
        crossB3 = False
        crossC1 = False
        crossC2 = False
        crossC3 = False

        circleA1 = False
        circleA2 = False
        circleA3 = False
        circleB1 = False
        circleB2 = False
        circleB3 = False
        circleC1 = False
        circleC2 = False
        circleC3 = False

        crossWin = False
        circleWin = False
    End Sub

    Private Sub check()
        If crossA1 = True And crossA2 = True And crossA3 = True Then
            crossWin = True
        ElseIf crossB1 = True And crossB2 = True And crossB3 = True Then
            crossWin = True
        ElseIf crossC1 = True And crossC2 = True And crossC3 = True Then
            crossWin = True
        ElseIf crossA1 = True And crossB1 = True And crossC1 = True Then
            crossWin = True
        ElseIf crossA2 = True And crossB2 = True And crossC2 = True Then
            crossWin = True
        ElseIf crossA3 = True And crossB3 = True And crossC3 = True Then
            crossWin = True
        ElseIf crossA1 = True And crossB2 = True And crossC3 = True Then
            crossWin = True
        ElseIf crossA3 = True And crossB2 = True And crossC1 = True Then
            crossWin = True
        End If

        If circleA1 = True And circleA2 = True And circleA3 = True Then
            circleWin = True
        ElseIf circleB1 = True And circleB2 = True And circleB3 = True Then
            circleWin = True
        ElseIf circleC1 = True And circleC2 = True And circleC3 = True Then
            circleWin = True
        ElseIf circleA1 = True And circleB1 = True And circleC1 = True Then
            circleWin = True
        ElseIf circleA2 = True And circleB2 = True And circleC2 = True Then
            circleWin = True
        ElseIf circleA3 = True And circleB3 = True And circleC3 = True Then
            circleWin = True
        ElseIf circleA1 = True And circleB2 = True And circleC3 = True Then
            circleWin = True
        ElseIf circleA3 = True And circleB2 = True And circleC1 = True Then
            circleWin = True
        End If

        If crossWin = True Then
            MsgBox("Crosses have WON!", MsgBoxStyle.Critical, "Game Over!")
            game_over()
        ElseIf circleWin = True Then
            MsgBox("Circles have WON!", MsgBoxStyle.Critical, "Game Over!")
            game_over()
        ElseIf turnCount >= 9 Then
            MsgBox("Tie Game!", MsgBoxStyle.Critical, "Game Over!")
            game_over()
        End If
    End Sub

    Private Sub game_over()
        set_boolFalse()

        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True

        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing
        PictureBox7.Image = Nothing
        PictureBox8.Image = Nothing
        PictureBox9.Image = Nothing

        turnCount = 0
    End Sub
End Class
