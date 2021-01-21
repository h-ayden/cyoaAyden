Public Class Form1
    Dim intPage As Integer
    Dim intCase As Integer
    Dim sngMoney As Single
    Dim intSecMoney As Integer
    Dim intIndoGo As Integer
    Dim intTimer1 As Integer
    Dim intTimer2 As Integer
    Const TIMELIMIT As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer2.Start()
        intTimer2 = 10
        intIndoGo = 10
        picIndoraptor.Visible = False

        intPage = 1
        lblStory.Text = "You get a free ticket to go to Jurassic World from Dr. John Hammond."
        btnOption1.Text = "Go"
        btnOption2.Visible = True
        btnOption2.Text = "Don't Go"
        btnOption3.Visible = False
        intTimer1 = TIMELIMIT
        lblTimer.Text = "Timer: " & intTimer1
        sngMoney = 100
        lblMoney.Text = "Money: $" & sngMoney

        picImage.Image = My.Resources.jwLogo
        My.Computer.Audio.Play(My.Resources.jParkTheme, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        Randomize()
        Timer1.Stop()
        intTimer1 = TIMELIMIT
        ' Go

        If intPage = 4 Or intPage = 9 Or intPage = 11 Or intPage = 14 Or intPage = 23 Or intPage = 25 Then
            intPage = 1
            lblStory.Text = "You get a free ticket to go to Jurassic World from Dr. John Hammond."
            btnOption1.Text = "Go"
            btnOption2.Visible = True
            btnOption2.Text = "Don't Go"
            btnOption3.Visible = False
            sngMoney = 100
            lblMoney.Text = "Money: $" & sngMoney
            intTimer1 = TIMELIMIT

            picImage.Image = My.Resources.jwLogo

        ElseIf intPage = 1 Or intPage = 24 Then
            intPage = 2
            Timer1.Start()
            lblStory.Text = "How do you want to get there?"
            btnOption1.Text = "Helicopter"
            btnOption2.Visible = True
            btnOption2.Text = "Ferry"
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.dimorphodon

        ElseIf intPage = 2 Then
            intPage = 4
            lblStory.Text = "While you're flying over the island a Pteranodon escapes and crashes into the helicopter, you crash and die."
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblTimer.Text = "Timer: 10"
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.pteranodon

        ElseIf intPage = 3 Then
            intPage = 5
            lblStory.Text = "What exhibit do you want to go to first?"
            btnOption1.Text = "Mosasaurus"
            btnOption2.Visible = True
            btnOption2.Text = "Tyrannosaurus Rex"
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.gallimimus

        ElseIf intPage = 5 Then
            intPage = 6
            lblStory.Text = "You had a great time and won a free T-Shirt!"
            btnOption1.Text = "Continue"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.mosasaurus

        ElseIf intPage = 6 Or intPage = 8 Then
            intPage = 10
            lblStory.Text = "Where do you want to go now?"
            btnOption1.Text = "Egg Spinner Ride"
            btnOption2.Visible = True
            btnOption2.Text = "Gondola Lift"
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.stegosaurus

        ElseIf intPage = 10 Then
            intPage = 11
            lblStory.Text = "You get super dizzy and have to go home."
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.velociraptor

        End If


        If intPage = 7 And sngMoney >= 20 Then
            intPage = 8
            lblStory.Text = "The new pants cost $20."
            btnOption1.Text = "Continue"
            btnOption2.Visible = False
            btnOption3.Visible = False
            sngMoney = sngMoney - 20
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.velociraptor

        ElseIf intPage = 7 And sngMoney < 20 Then
            intPage = 9
            lblStory.Text = "You need to go home because you can't afford the pants. (They were $20)"
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.velociraptor

        ElseIf intPage = 12 Then
            intPage = 13
            lblStory.Text = "How do you want to get home?"
            btnOption1.Text = "Ferry"
            btnOption2.Visible = True
            btnOption2.Text = "Helicopter"
            btnOption3.Visible = True
            btnOption3.Text = "Stay Forever!!!"
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.dimorphodon

        ElseIf intPage = 13 Then
            intPage = 14
            lblStory.Text = "You get home nice and safely."
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.parasaurolophus
        End If

        ' Don't Go

        If intPage = 15 Then
            intPage = 16
            lblStory.Text = "She says that she thinks you had enough time. You decide to take it to the court"
            btnOption1.Text = "Take It To The Court"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.metriacanthosaurus

        ElseIf intPage = 17 Then
            intPage = 18
            lblStory.Text = "You are approached by a lawyer saying that, for a random cost for he can try to make a case so you can redo your test."
            btnOption1.Text = "Accpet His Offer"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.microceratus

        ElseIf intPage = 18 Then
            intSecMoney = (Rnd() * 35) + 65

            intPage = 19
            lblStory.Text = "His random cost was $" & intSecMoney & "."
            btnOption1.Text = "Continue"
            btnOption2.Visible = False
            btnOption3.Visible = False
            sngMoney = sngMoney - intSecMoney
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.pachycephalosaurus

        ElseIf intPage = 16 Or intPage = 19 Then
            intCase = (Rnd() * 10) + 1

            If intCase >= 7 Then
                intPage = 20
                lblStory.Text = "You win the case! You get to redo the test. You end up getting a 94%"
                btnOption1.Text = "Continue"
                btnOption2.Visible = False
                btnOption3.Visible = False
                lblMoney.Text = "Money: $" & sngMoney

                picImage.Image = My.Resources.suchomimus

            Else : intPage = 21
                lblStory.Text = "You lose the case! Your grade goes down by 10%"
                btnOption1.Text = "Continue"
                btnOption2.Visible = False
                btnOption3.Visible = False
                lblMoney.Text = "Money: $" & sngMoney

                picImage.Image = My.Resources.gallimimus
            End If


        ElseIf intPage = 20 Or intPage = 21 Then
            intPage = 22
            lblStory.Text = "You are tired."
            btnOption1.Text = "Go To Bed"
            btnOption2.Visible = True
            btnOption2.Text = "Find Dr. Hammond"
            btnOption3.Visible = False
            Timer1.Start()
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.triceratops

        ElseIf intPage = 22 Then
            intPage = 23
            lblStory.Text = "You die from shock in your sleep."
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblTimer.Text = "Timer: 10"
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.velociraptor
        End If

    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        Timer1.Stop()

        ' Go

        If intPage = 2 Then
            intPage = 3
            lblStory.Text = "You arrive at the dock unharmed and excited for your stay."
            btnOption1.Text = "Continue"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblTimer.Text = "Timer: 5"
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.triceratops


        ElseIf intPage = 5 Then
            intPage = 7
            lblStory.Text = "Someone spilled their drink on your pants, you need to go buy a new pair."
            btnOption1.Text = "Buy a new pair of pants"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.tyrannosaurusRex

        ElseIf intPage = 10 Then
            intPage = 12
            lblStory.Text = "On the gondola you find $500 dollars on the floor, you are unable to find the person who dropped it, so it's yours to keep."
            btnOption1.Text = "Time To Go Home"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.ankylosaurus

        ElseIf intPage = 13 Then
            intPage = 4
            lblStory.Text = "While you're flying over the island a Pteranodon escapes and crashes into the helicopter, you crash and die."
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.pteranodon

        End If

        ' Don't Go

        If intPage = 1 Then
            intPage = 15
            lblStory.Text = "You have a test and are given 5 minutes to do it. That's not enough time for you so you end up getting an 18%."
            btnOption1.Text = "Talk To Your Teacher"
            btnOption2.Visible = True
            btnOption2.Text = "Accept The Unfair Judgement"
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.apatosaurus

        ElseIf intPage = 15 Then
            intPage = 17
            lblStory.Text = "You go about your day mad because you know that her decision is completely unfair."
            btnOption1.Text = "Continue"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.baryonyx

        ElseIf intPage = 22 Then
            intPage = 24
            lblStory.Text = "You find Dr. Hammond and ask if the tickets are still available, he says yes."
            btnOption1.Text = "Take The Tickets"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblTimer.Text = "Timer: 10"
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.edmontosaurus

        End If
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        If intPage = 13 Then
            intPage = 25
            lblStory.Text = "Security starts hunting you through the park. You try and get away by hiding in one of the eclosure, unfortunately for you it's the T. Rex eclosure. Once you realize your mistake its already to late. CHOMP!"
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            btnOption3.Visible = False
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.tyrannosaurusRex
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If intPage = 26 Then
            intPage = 1
            lblStory.Text = "You get a free ticket to go to Jurassic World from Dr. John Hammond."
            btnOption1.Text = "Go"
            btnOption2.Visible = True
            btnOption2.Text = "Don't Go"
            btnOption3.Visible = False
            sngMoney = 100
            lblMoney.Text = "Money: $" & sngMoney
            intTimer1 = TIMELIMIT

            picImage.Image = My.Resources.jwLogo
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intTimer1 = intTimer1 - 1
        lblTimer.Text = "Timer: " & intTimer1

        If intTimer1 = 0 Then
            Timer1.Stop()
            MessageBox.Show("Out Of Time!")
            intPage = 1
            lblStory.Text = "You get a free ticket to go to Jurassic World from Dr. John Hammond."
            btnOption1.Text = "Go"
            btnOption2.Visible = True
            btnOption2.Text = "Don't Go"
            btnOption3.Visible = False
            intTimer1 = TIMELIMIT
            lblTimer.Text = "Timer:" & intTimer1
            sngMoney = 100
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.jwLogo
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        intTimer2 = intTimer2 - 1
        intIndoGo = intIndoGo - 1

        If intTimer2 = 0 Then
            intIndoGo = Int(Rnd() * 5) + 1
            picIndoraptor.Visible = True

            intTimer2 = Int(Rnd() * 40) + 20
        End If

        If intIndoGo = 0 Then
            picIndoraptor.Visible = False
        End If

    End Sub
End Class