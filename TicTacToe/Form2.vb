Public Class Form2

    Dim crossWin, circleWin, pcTurn As Boolean
    Dim crossA1, crossA2, crossA3, crossB1, crossB2, crossB3, crossC1, crossC2, crossC3 As Boolean
    Dim circleA1, circleA2, circleA3, circleB1, circleB2, circleB3, circleC1, circleC2, circleC3 As Boolean
    Dim turnCount, random_num As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        set_boolFalse()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        turnCount += 1

        PictureBox1.Image = My.Resources.Cross
        PictureBox1.Enabled = False
        crossA1 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        turnCount += 1

        PictureBox2.Image = My.Resources.Cross
        PictureBox2.Enabled = False
        crossA2 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        turnCount += 1

        PictureBox3.Image = My.Resources.Cross
        PictureBox3.Enabled = False
        crossA3 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        turnCount += 1

        PictureBox4.Image = My.Resources.Cross
        PictureBox4.Enabled = False
        crossB1 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        turnCount += 1

        PictureBox5.Image = My.Resources.Cross
        PictureBox5.Enabled = False
        crossB2 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        turnCount += 1

        PictureBox6.Image = My.Resources.Cross
        PictureBox6.Enabled = False
        crossB3 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        turnCount += 1

        PictureBox7.Image = My.Resources.Cross
        PictureBox7.Enabled = False
        crossC1 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        turnCount += 1

        PictureBox8.Image = My.Resources.Cross
        PictureBox8.Enabled = False
        crossC2 = True
        pcTurn = True

        check()
        pc_turn()
        check()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        turnCount += 1

        PictureBox9.Image = My.Resources.Cross
        PictureBox9.Enabled = False
        crossC3 = True
        pcTurn = True

        check()
        pc_turn()
        check()
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
            pcTurn = False
            MsgBox("Crosses have WON!", MsgBoxStyle.Critical, "Game Over!")
            game_over()
        ElseIf circleWin = True Then
            pcTurn = False
            MsgBox("Circles have WON!", MsgBoxStyle.Critical, "Game Over!")
            game_over()
        ElseIf turnCount >= 9 Then
            pcTurn = False
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

    Private Sub pc_turn()
        While pcTurn = True
            Randomize()
            random_num = Int(Rnd() * 9) + 1

            Select Case random_num
                Case 1 And PictureBox1.Enabled = True
                    turnCount += 1
                    PictureBox1.Image = My.Resources.Circle
                    circleA1 = True
                    PictureBox1.Enabled = False
                    pcTurn = False
                Case 2 And PictureBox2.Enabled = True
                    turnCount += 1
                    PictureBox2.Image = My.Resources.Circle
                    circleA2 = True
                    PictureBox2.Enabled = False
                    pcTurn = False
                Case 3 And PictureBox3.Enabled = True
                    turnCount += 1
                    PictureBox3.Image = My.Resources.Circle
                    circleA3 = True
                    PictureBox3.Enabled = False
                    pcTurn = False
                Case 4 And PictureBox4.Enabled = True
                    turnCount += 1
                    PictureBox4.Image = My.Resources.Circle
                    circleB1 = True
                    PictureBox4.Enabled = False
                    pcTurn = False
                Case 5 And PictureBox5.Enabled = True
                    turnCount += 1
                    PictureBox5.Image = My.Resources.Circle
                    circleB2 = True
                    PictureBox5.Enabled = False
                    pcTurn = False
                Case 6 And PictureBox6.Enabled = True
                    turnCount += 1
                    PictureBox6.Image = My.Resources.Circle
                    circleB3 = True
                    PictureBox6.Enabled = False
                    pcTurn = False
                Case 7 And PictureBox7.Enabled = True
                    turnCount += 1
                    PictureBox7.Image = My.Resources.Circle
                    circleC1 = True
                    PictureBox7.Enabled = False
                    pcTurn = False
                Case 8 And PictureBox8.Enabled = True
                    turnCount += 1
                    PictureBox8.Image = My.Resources.Circle
                    circleC2 = True
                    PictureBox8.Enabled = False
                    pcTurn = False
                Case 9 And PictureBox9.Enabled = True
                    turnCount += 1
                    PictureBox9.Image = My.Resources.Circle
                    circleC3 = True
                    PictureBox9.Enabled = False
                    pcTurn = False
                Case Else
                    pc_turn()
            End Select
        End While
    End Sub

End Class