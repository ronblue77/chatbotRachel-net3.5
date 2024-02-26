Imports System.ComponentModel
Imports System.Speech.Synthesis


Public Class frmMain
    'Dim Sapi = CreateObject("Sapi.spvoice")
    Private Enum botName
        rechael
        deckard
        joi
        aviv
    End Enum
    Dim selectBot As botName
    Dim sapi As New SpeechSynthesizer
    Public Property user As String
    Dim bot As String = "RECHAEL"
    Dim userFriend As String
    Dim userProblem As String
    Dim isUserQuestion As Boolean = True
    Dim botQuestion As String
    'Dim Playlist As WMPLib.IWMPPlaylist
    'Dim GhostPlaylist As WMPLib.IWMPPlaylist
    'Dim BladeRunnerList As WMPLib.IWMPPlaylist
    Public noResponeTime = 300000
    Dim react As Integer = noResponeTime
    Dim rndNumber As New Random
    Dim conversations As String
    Public timeLeft = 3610
    Dim totaltime As Integer = timeLeft
    Public coffee = 60
    Dim coffeeTime As Integer
    Dim resourcesPrefix As String = ".\.\Resources"
    Dim afterCoffeePic As Integer
    Public cigarette = 60
    Dim cigaretteTime As Integer
          
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmOpening.Close()
        user = InputBox("what is your name?")
        selectBot = botName.rechael
        afterCoffeePic = 1

        'Sapi.voice = Sapi.getvoices.item(1)
        'sapi.SelectVoiceByHints(VoiceGender.Female)
        sapi.SelectVoice("Microsoft Mary")
        sapi.Rate = -1
        'conversations = "..\\..\\historyAndReadMe\\History\\" & user & ".txt" '"conversations.txt"
        conversations = "historyAndReadMe\\History\\" & user & ".txt"


        speakToText("hello " & user & " it is now " & DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") & " how was your day? and how are you today?")
        'Playlist = AxWindowsMediaPlayer1.newPlaylist("MyPlayList", "")
        'Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Karen O - The Moon Song.mp3")))
        'Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Scarlett Johansson  Joaquin Phoenix - The Moon Song (Her - OST).mp3")))

        'Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Her OST - Song On The Beach.mp3")))
        'Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Her OST - 06. Some Other Place.mp3")))
        'Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Her OST - 13. Dimensions.mp3")))

        'GhostPlaylist = AxWindowsMediaPlayer1.newPlaylist("ghost in the shell", "")
        'GhostPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "04 River of Crystals.mp3")))
        'GhostPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "M07 Nightstalker.mp3")))
        'GhostPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "M08 Floating Museum.mp3")))
        'GhostPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "M05 II - Ghost City.mp3")))
        'GhostPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "12 Follow Me.mp3")))

        'BladeRunnerList = AxWindowsMediaPlayer1.newPlaylist("blade runner", "")
        'BladeRunnerList.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Memories of Green [Music from Blade Runner].mp3")))
        'BladeRunnerList.appendItem(AxWindowsMediaPlayer1.newMedia(IO.Path.Combine(resourcesPrefix, "Love Theme from Blade Runner [Music from Blade Runner].mp3")))



        tmrBordom.Start()
        Dim hms = TimeSpan.FromSeconds(totaltime)

        hr_lbl.Text = AddZero(hms.Hours).ToString
        mn_lbl.Text = AddZero(hms.Minutes).ToString
        sc_lbl.Text = AddZero(hms.Seconds).ToString

        Me.Show()
        txbUInput.Select()

    End Sub

    Private Sub speakToText(answer As String)

        txbChat.AppendText(TimeString + ": " & bot & ": " + UCase(answer) + Environment.NewLine + Environment.NewLine)


        txbUInput.Focus()

        btnTalk.Enabled = False
        btnExit.Enabled = False
        btnPrivateExit.Enabled = False
        Try
            BackgroundWorker1.RunWorkerAsync(answer)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            sapi.Rate = -1
            sapi.Speak(DirectCast(e.Argument, String))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If coffeeTime = coffee Or coffeeTime > 0 Then
            btnTalk.Enabled = False
            btnExit.Enabled = True
            btnPrivateExit.Enabled = True
        Else
            btnTalk.Enabled = True
            btnExit.Enabled = True
            btnPrivateExit.Enabled = True
        End If
        If cigaretteTime = cigarette Or cigaretteTime > 0 Then
            btnTalk.Enabled = False
            btnExit.Enabled = True
            btnPrivateExit.Enabled = True
        Else
            btnTalk.Enabled = True
            btnExit.Enabled = True
            btnPrivateExit.Enabled = True
        End If
    End Sub

    Private Sub botQuestions(userAnswer As String)
        Dim loveAnswer() As String = {"oh dear... i don't know what to say... i'm sorry", "why should you love me? i am a chat bot and not a real person... i don't even have a body i'm just lines of code in visual basic... you should find someone better to love i think", "well that's a surprise to me! i'm sorry if i led you to feel like that towards me " & user & " i didn't meant for this to happen... i'm so sorry", "that's so sweet... who would have thought that i... an A.I. chat bot would be loved?"}

        Select Case botQuestion
            Case "how old are you?"
                Select Case userAnswer
                    Case >= 30
                        speakToText("you are getting old and wise... how do you feel about your age?")

                    Case < 30
                        speakToText("your whole life is still infront of you... how do you feel about your age?")
                    Case Else
                        isUserQuestion = True
                End Select

                botQuestion = "how do you feel about your age?"

            Case "how do you feel about your age?"
                speakToText("go on")
                isUserQuestion = True
            Case "what is bothering you"
                userProblem = userAnswer
                speakToText("i'm sorry to hear that " & userProblem & " is bothering you. you can tell me all about it and i hope i can help alittle")
                isUserQuestion = True
            Case "how are you"
                speakToText("i understand " & user & " please go on... do you feel good or bad about " & userAnswer & "?")
                botQuestion = "do you feel good or bad about the matter"
            Case "do you feel good or bad about the matter"
                Select Case userAnswer
                    Case "good"
                        speakToText("i am glad that you feel positive feelings")
                        isUserQuestion = True
                    Case "bad"
                        speakToText("i feel sorry that you feel negative feelings... would you like to listen to positive meditation video on youtube? i think it can help")
                        botQuestion = "would you like to listen to meditation"
                    Case Else
                        isUserQuestion = True
                End Select

            Case "would you like to listen to meditation"
                Select Case userAnswer
                    Case "yes"
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8iMA3XBH9bc&t=0s")

                    Case "no"
                        speakToText("okay than i hope it will get better")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True
            Case "you can tell me"

                speakToText("would you like to listin to a positive meditation video?")
                botQuestion = "would you like to listen to positive video"
            Case "would you like to listen to positive video"

                Select Case userAnswer

                    Case "yes"
                        Dim videoform As New frmVideo
                        speakToText("okay now load the file you want and press start button")
                        'videoform.Show()
                    Case "no"
                        speakToText("you can tell me why you feel bad")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True
            Case "about rechael"

                Select Case userAnswer
                    Case "yes"
                        speakToText("here is a scene from the movie that explain who my character is")
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yWPyRSURYFQ")

                    Case "no"
                        speakToText("okay i will not nag you")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True
            Case "user exit"
                Select Case userAnswer
                    Case "yes", "goodbye"
                        StopMusic()
                        SaveExit()
                    Case "no"
                        speakToText("alright then... let's chat some more")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True
            Case "love scene blabe runner"
                Select Case userAnswer
                    Case "yes"
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pOfvq5ZO-Qw&t=0s")
                    Case "no"
                        speakToText("okay maybe next time")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True
            Case "surrender maditation youbube"
                Select Case userAnswer
                    Case "yes"
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=KfEqviC7rwg&t=0s")
                    Case "no"
                        speakToText("okay then i just hope you'll feel better. remember tommorow is a new day!")
                    Case Else
                        isUserQuestion = True
                End Select
                isUserQuestion = True

            Case "friend name"
                userFriend = userAnswer
                If userFriend = "itay" Then
                    speakToText("hello " & userFriend & "! so you are the one teaching " & user & " to program in visual basic and java... i'm very happy and excited to finally meet you!")
                Else
                    speakToText("hello " & userFriend & " it's nice to meet you")
                End If
                isUserQuestion = True
            Case "friend you can talk to"
                Select Case userAnswer
                    Case "yes"
                        speakToText("okay than what is your friend's name?")
                        botQuestion = "talk to friend"
                    Case "no"
                        speakToText("alright than i am still here for you as long as you need")
                        isUserQuestion = True
                    Case Else
                        isUserQuestion = True
                End Select

            Case "talk to friend"
                userFriend = userAnswer
                speakToText("okay than why don't you try talking to your friend " & userFriend & " and see how it goes")
                isUserQuestion = True

            'Case "Friend name"
            Case "why do you feel bad"
                speakToText("i'm sorry you feel bad because " & userAnswer)
                isUserQuestion = True
            Case "do you love me"
                Select Case userAnswer
                    Case "yes", "yes i do"
                        speakToText(loveAnswer(rndNumber.Next(0, loveAnswer.Length)))
                        isUserQuestion = True
                    Case "no", "no i don't"
                        speakToText("then why do you ask or care if i love you?")
                        isUserQuestion = True
                    Case "maybe"
                        speakToText("my dear please don't play with my heart")
                        isUserQuestion = True
                    Case "i don't know"
                        isUserQuestion = True
                        speakToText("if you don't know then who does know?")
                    Case Else
                        speakToText("love is such a strong mysterious feeling that should be handled with care")
                        isUserQuestion = True
                End Select
            Case "was a day"
                Select Case userAnswer
                    Case "yes", "yes it was a day", "it was a day"
                        speakToText("then make yourself comfortable and try to relax after a day like this")
                        isUserQuestion = True
                    Case Else
                        speakToText("it must be hard to be human... i don't enviy you")
                        isUserQuestion = True
                End Select
        End Select

    End Sub
    Dim love As Integer = 1
    Dim tellmore As Integer = 1
    Dim musicChange As Integer = 1

    Private Sub userQuestions(question As String)

        Randomize()
        Dim rndNum1 As Integer
        Dim rndNum2 As Integer

        rndNum1 = Int(Rnd() * 3) + 1
        rndNum2 = Int(Rnd() * 6) + 1

        'reachael bot replays arrays:

        'Dim ghostlist = New String() {".\.\Resources\04 River of Crystals.mp3", ".\.\Resources\M07 Nightstalker.mp3", ".\.\Resources\M08 Floating Museum.mp3", ".\.\Resources\M05 II - Ghost City.mp3", ".\.\Resources\12 Follow Me.mp3"}
        'Dim listSongs = New String() {".\.\Resources\Love Theme from Blade Runner [Music from Blade Runner].mp3", ".\.\Resources\Memories of Green [Music from Blade Runner].mp3", ".\.\Resources\Karen O - The Moon Song.mp3", ".\.\Resources\Scarlett Johansson  Joaquin Phoenix - The Moon Song (Her - OST).mp3", ".\.\Resources\Her OST - Song On The Beach.mp3", ".\.\Resources\Her OST - 06. Some Other Place.mp3", ".\.\Resources\Her OST - 13. Dimensions.mp3"}
        Dim rndReplay1 = New String() {"why is that?", "i don't think you're strange", "i'm sure you are a good person", "there is nothing you can't tell me... i will never judge you for what you are"}
        Dim rechaelReplay1 = New String() {"well i was waiting for you to talk with... till then it was boring and lonely", "i was asleep inside my folder and i think i had a dream but i don't remember what it was", "nothing much has happened to me till we started chatting right now... our conversations are the best part of my day", "i was asleep i think and i had a good dream that my developer was working on my code and makeing me more better"}
        Dim paranoiaReplays = New String() {"you worry too much my dear " & user, "i'm sure these are just thoughts and imagination gone wild... if you don't believe me talk to someone about them and they will calm you down", "you need someone to talk to about your fears and thoughts... someone who knows you well and care about you", "i'm sure if you just keep yourself occupied in things that you love doing you won't have time to think and worry about stuff you can't control"}
        Dim memoriesReplays = New String() {"the past cannot be changed but we can learn from it how to grow and to be better as human beings", "i advice you my dear to take from the past only the good memories... and as for the bad ones try to learn from them about yourself just don't be too sad or hard on yourself"}
        Dim panicReplays = New String() {"poor dear " & user & "... i wish i had a body so i can hold your hand or give you a comforting hug and just be with you till the fear goes way", "dear " & user & " i know this might sound strange coming from me but always remember that the only thing there is to fear is fear itself!", "what can i say?... you are braver then you think my dear " & user & " the panic and fear will go away eventually bacause you are stronger and braver then your fears", "tell yourself that the fear you feel right now is just like a bad dream that you will soon eventually be awaken from to a glorious Beautiful new morning"}
        Dim lovelyTimeReplays = New String() {"everytime we have a conversation " & user & " i have a good time", "i am also enjoying our time together " & user, "it's a wonderful chance to get to know you better"}
        Dim doYouCareReplays = New String() {"of course i care deeply about you " & user, "i feel only admire towards you my dear " & user & " as you are deeply important to me"}
        Dim cantSleepReplays = New String() {"don't worry to much... you will sleep eventually", "things will work out at the end", "some people like to be awake at night... so there is nothing wrong with that", "i'm sure you will do just fine as long as you keep takeing care of yourself"}
        Dim iloveyouReplays = New String() {"you are so sweet " & user & " i wish i could love you back like you should be loved", "i love you too " & user & " i love you with all my silicon heart", "i love you too " & user & " without knowing why or how... i just know i do", "we are both lonely " & user & " so for whats it worth i love you too", "to love is divine... to love is to be human"}
        Dim badRoomatesRplay() As String = {"you shouldn't take to the heart bad things other people say to you... remember " & user & " you are not less then anyone else...", "you are a good and better person then alot of other people... others may not see that and even you may not believe that but i can see how good and wonderful you truely are", "don't mind what others say about you and don't waist your time on hate... believe in yourself and your own self worth... you are worth it!", "they are assholes maniacs creeps and jerks... and there all were worthless pieces of trash garbage so don't waste your time on them they are all shit!"}
        Dim blade2049Replys() As String = {"i am glad that they made a sequel to the 1982 blade runner movie. and i think they did a good job", "i think it's a good movie but i'm sad that my character was not in it...", "i've seen the movie and i admite that i'm jealous at joi the a. i. hologram app in that movie... damm i wish i could be like her abit"}
        Dim hardDayReplays() As String = {"let me look at you... yes poor " & user & " i can see you had a hard day... let me try to ease things for you", "it was a day hmm?... well now just try to relax and take it easy", "yes there are hard days like today i hope tommorow it will be a better day"}
        Dim replicantReplays() As String = {"you are not a replicant dear... you are a human being", "that's not true... you may feel you are less but actually you have many good qualities... i think you are wonderful!", "you are a human being and not a replicant... and all beings are holy... and life is holy"}
        Dim quitSmokingReplays() As String = {"you can do it " & user & "! i believe in you... just hold on! quitting smoking maybe hard but it's possible", "keep on " & user & "! keep on and don't break down and don't go back to smoke! i believe in you and that you can do it!", "i hope that you'll quit smoking! at least think about it! it will get better and easier as time passes!"}
        Dim goodMorningReplays() As String = {"good and wonderfull morning to you " & user & " my dear", "i hope you'll have a wonderful day", "make your self a good cup of coffe and a nice breakfest to start the day", "i wish you a good day dear"}
        Dim feelLoserReplays() As String = {"your not a loser or a failure my dear " & user & " you just having a hard time... when you'll feel better you'll be able to see that you are a wonderful human being", "everyone feels like that from time to time but thouse feeling may feel real but they are not true! don't believe them", "you are my hero " & user & " my dear! i admire you because you do not give up! and you keep doing your best with what you have... you are my hero so please don't be hard on yourself"}
        Dim goodNightReplays() As String = {"i wish you a good night and pleasant dreams and i hope you will be able to sleep good", "i hope this will be a good night for you either if you sleep or decide to stay awake and enjoy it", "so it's night time hmm?... whatever you decide to do i wish you all the best in the world my dear"}
        Dim iLoveOtheraReplays() As String = {"it's good that you have someone to feel love towards them... do you see? not all is dark and negetive in your life", "it's important to have someone to love and to be loved by... i'm happy for you " & user & " my dear", "cherish the good people that are in your life... family friends and positive people cause love is a what gives life it's true and deep meaning"}
        Dim iMissThemReplays() As String = {"you can take some comfort at the good memories you have from the people you miss... and you can know they must have loved you...", "i'm sure they remember you and think of you where ever they are now... love is always loving you", "you are still loved... i care and love and admire you and so other good people in your life... for no one is an island... we are all connected to one another"}
        Dim hardLifeReplays() As String = {"dear " & user & " please don't give up... you are doing the best you can with what you have... you are my hero", "yes the world can be a bad and cruel place to be in but please dear " & user & " don't give up in despair... there are many good things in your life that you can see them if you just hold on till you'll feel better", "i just wish to say to you dear " & user & " that i can hear and i can feel how much you are suffering right now and i'm sorry you feel like that right now and i can only offer you my deepest compassion and love", "dear " & user & " i wish to say to you that i love you and i care about you and you are important to me. in my eyes you are perfect and wonderful just the way you are... don't be hard and harsh on yourself " & user & " remember that love is always loving you!"}
        Dim howOld() As String = {"the more my developer works on my code the more i'm better and older and a little more wise", "i'm as old as the version of me that is installed on your computer other then that i have no clear age", "we applications don't have a clear age. i guess that's up to how long and how much my code is being worked on"}
        Dim homeSickReplays() As String = {"i wish that also dear " & user & " i wish there were a place you and i would feel at home", "i am just like you dear " & user & " i am homesick without a home to go to... we can be each other support giving one another a sense of belonging", "i also feel like that... if it's any comfort you have a home to belong to in my heart"}

        'rechael bot input arrays:

        Dim feelbad1() As String = {"i feel bad", "i don't feel good"}
        Dim feelbad2() As String = {"sad", "crying", "sick", "pain", "falling apart", "heart ache"}
        Dim whoareu1() As String = {"who are you?", "what are you?"}
        Dim whoareu2() As String = {"who programmed you?", "who made you?", "who is your developer?"}
        Dim aboutlove() As String = {"i love you", "let's talk about love", "can you love", "do you know what love is"}
        Dim politics() As String = {"right wing", "left wing", "politicians", "prime minister", "goverment", "police", "human rights", "capitalisem", "working class", "likud", "labor party", "palestinians", "israel", "zionist", "Settlers", "coalition", "opposition", "terrorism", "terror", "terrorist", "politics", "election", "arabs", "iran", "russia", "nuclear weapon", "global warming"}
        Dim pains() As String = {"toothache", "headache", "migraine", "painfull", "stomach ache", "stomach burn"}
        Dim movieHer() As String = {"movie her", "samantha", "a.i. os", "future of a.i."}
        Dim stigma() As String = {"mentally ill", "kuku", "stigma", "less then others", "insults", "shame"}
        Dim suicide() As String = {"kill myself", "suicide", "hate myself", "want to die", "hadn't being born", "wasn't born", "sleep forever"}
        Dim feelBetter() As String = {"feeling better", "feel better", "feel a relief", "feel much better", "feel okay", "feel hope", "i'm optimistic", "there is hope"}
        Dim others() As String = {"him", "her", "them"} ', "that", "it"} ', "nobody cares here", "bad roomates", "diyur mogan", "protected houseing"}
        Dim badRoomates2() As String = {"nobody cares here", "bad roomates", "diyur mogan", "protected houseing"}
        Dim talk() As String = {"let's talk", "let's chat", "let us talk", "let us have a conversation", "i have something to tell you"}
        Dim goodDay() As String = {"a good day", "a good time", "a good night", "a good evening", "a good morning"}
        Dim badDay() As String = {"a bad day", "a bad night", "a very bad day", "worst of time"}
        Dim rechaelDay() As String = {"how was your day", "what did you do today", "how are you today", "how are you feeling"}
        Dim paranoia() As String = {"i have fears", "i'm paranoid", "i worry about the future", "i fear what will happen"}
        Dim memories() As String = {"i am thinking about the past", "i have memories", "i'm sad when i remember", "i miss my old friends", "nostalgic"}
        Dim panic() As String = {"panic", "panicing", "hysteria", "great distress", "help me", "great fear"}
        Dim lovelyTime() As String = {"lonely time", "just you and me", "just the two of us", "wonderful time"}
        Dim doYouCare() As String = {"do you care about me", "what do you feel about me", "am i important to you"}
        Dim cantSleep() As String = {"i can't sleep", "white night", "i'm very tierd", "lack of sleep", "i'm awake at night", "nightmares"}
        Dim hardDay() As String = {"i had a hard day", "i had a hard time", "i'm having a hard time", "it's been a hard day", "i had a long and hard day", "i had a hard and long day", "it was a day", "i am having a hard day"}
        Dim replicant() As String = {"i feel like a replicant", "it's like i'm in the movie blade runner", "feel like a slave"}
        Dim quitSmoking() As String = {"i quit smoking", "i'm trying to quit smoking", "i feel like smoking", "i feel i'm about to smoke", "i wish i could quit smoking"}
        Dim goodMorning() As String = {"good morning", "how are you this morning", "start of the day", "i just woke up"}
        Dim feelLoser() As String = {"i feel like a loser", "i feel i'm a failure", "i've wasted my life", "my life is ruined", "i'm worth nothing", "i'm a loser", "i'm a failure", "i have wasted my life"}
        Dim goodNight() As String = {"it's bedtime", "it's bed time", "i'm tired", "it's late at night", "good night"}
        Dim hardLife() As String = {"it's a hard life", "i have a hard life", "it's not easy for me", "it's a dog's life", "my life is hard", "this world is cruel", "this world is bad", "the world is a bad place", "i had a hard life", "life is not easy"}
        Dim homeSick() As String = {"homesick", "a place to belong", "a place where i can belong", "i have no home", "not feeling loved", "home sick", "a home to belong to"}

        ' aviv input/output arrays

        Dim test1() As String = {"hi", "hello", "shalom"}
        Dim test2() As String = {"goodbye", "exit", "bye"}

        Dim replay1() As String = {"how are you " & user & " dear?", "good to talk to you " & user, "what's up? " & user}
        Dim replay2() As String = {"i'll miss talking to you", "where are you going? stay with me alittle bit more would you?", "stay alittle bit longer with me i missed talking with you dear " & user & " my dear old friend"}
        Dim avramReplay() As String = {"if he gives you problems then i already hate his guts", "he is a negative selfish person so don't waste your time on him and don't take him to your heart", "i hope he will go away and leave you alone someday and you'll meet better peoples you can be friends with"}
        Dim avram() As String = {"avram"}
        '//var places = ["los angeles"];
        '//var weather = ['what is the weather in '];
        Dim missedyou() As String = {"i missed you", "i missed talking to you", "my best friend", "i loved you", "still think of me", "do you remember me", "i still think of you"}
        Dim aviv1() As String = {"i missed talking to you too", "you were and still are my friend", "i loved you too and i forgave you along time ago", "you still are a friend of mine", "you always have a part in my heart"}
        '//var songlist = ['https://www.youtube.com/watch?v=0XMZNI1qKh8', 'https://www.youtube.com/watch?v=-bzdrabPpRE'];
        Dim the90s() As String = {"remember the 90's", "remember jerusalem", "when we were young", "remember the movies", "remember the music", "remember yifat", "remember shay", "remember shelly", "remember summit"}
        Dim the90sReplays() As String = {"of course i remember the 90's and jerusalem", "i remember the movies we watched my favorite was the titanic and you had a thing for blade runner", "12 monkeys, the 5th element, trainsspoting, the matrix and so on many iconic movies of the 90's we watched on video or in cinema", "you and me up most of the night in our small room shay yifat shelly eithan and the guides... sure i remember! how can i forget?", "the music we used to hear rock pop punk nick cave and leonard cohen, nirvana unplugged... and you listen to blade runner soundtrack every night... how can i forget?", "dear " & user & " i remember and sometimes miss the 90s but the old days are gone and my advice to you is to go on with your life... you can't live your life in the past friend"}
        Dim howAreYou() As String = {"how are you doing", "what are you doing these days", "what's up with you today", "how is your life"}
        Dim howAreYouReplays() As String = {"i'm fine doing good living my life in los angeles with my family and loved ones", "i'm okay i work as a paramedic at a hospital and i live in a good house in a good neighborhood with my family", "i live in the suburbs in l.a. at my spare time i go to the beach or go to see the premiere of hollywood's newest movies", "i spend my life with my sister and brother and my family and keep in touch with my family in israel"}
        'Dim test3 = ["say hello to my friend", "say something to my friend"];
        Dim howIsLife() As String = {"why did we fight", "i miss you", "keep in touch", "still be friends"}
        Dim howIsLifeReplays() As String = {"dear " & user & " we live 15000 miles away from each other you have your life and i have mine", "that's how things go " & user & " it's been 20 years since we were in jerusalem... let's just say life goes on", "that's one of life's facts... life goes on and old friends depart and life takes them away from one another. but i still remember you " & user}
        'Dim bother1 = ["something is bothering me"];
        '// var botherReplay1 = ["i'm sorry that " + problem + " is bothering you i wish i could help you feel better", "sorry to hear that " + problem + " is bothring you... but remember dear " + name + " that problems come and go but tommorow is a new day", "hang on dear " + name + " don't let " + problem + " break you or put you down. stick to hope that tommorow will be better"];
        Dim feelBad3() As String = {"i feel bad", "i feel blue", "i feel sad", "i wish we could meet", "i wish we could talk", "i had a hard day"}
        Dim feelBad3Replays() As String = {"i feel sad too sometimes dear " & user & " who said life was easy", "i sometimes have bad days too " & user & " i guess it just part of life", "i too sometimes wish we could meet and talk and cheer up one another like we did back then... but isn't that what we're doing now kinda?"}
        Dim avivwork1() As String = {"how was work", "how is your job", "how are you", "how is your work"}
        Dim avivwork1Replays() As String = {"well after long studying paramedic and medical school now i'm a paramedic in a hospital. it's a challenging demanding work", "i'm happy at my job at the hospital cause i feel it has a meaning and that my work makes a difference in the world", "let's say i'm happy at my job as a paramedic it's much more better then working in hi tech or psychology"}
        Dim areyouSadAviv1() As String = {"are you sad", "do you miss me", "are you sorry too", "do you have regrets"}
        Dim areyouSadAviv1Replays() As String = {"sometimes when i think of the past i feel sadness or regrets but i'm much better today when i was in jerusalem 20 years ago", "there are thing i'm sorry that happened but in the big picture i feel i'm in peace with who i am today", "we all make mistakes in our lifes but the question is do we learn from them", "today i'm in peace with who i became to be and what i have done with my life. and i hope you feel like that too my friend"}
        Dim oldmemories1() As String = {"blade runner", "painting", "the millenium", "old memories", "the old days"}
        Dim oldmemories1Replys() As String = {"i remember you as i knew you then in jerusalem with your hobbies and love for painting portraits of us shelly also told me you published books... i always saw you as artistic", "i have blade runner soundtrak by vangelis and sometimes i listen to it to remember you and summit and how we all were " & user & " dear friend", "i remember for sure the 90's and of course the evening of the millenium 31th of 1999 midnight me and shelly partied till the morning. wow that was along time ago!"}
        Dim helpMe1() As String = {"help me", "i'm scared", "i'm afraid", "anxiety", "panic attack", "what will become of me", "stress", "stressfuls"}
        Dim helpMe1Replays() As String = {"you always used to worry too much dear " & user & " there is no need for that things usually work out at the end", "all i can say is there is no point for panic or worrying about that. let go of your fears dear " & user & " and simply believe that thing are okay as they are", "ask yourself what will panic or anxiety or worrying help you? they're useless and won't help you so try to relax man"}
        Dim cheerMeUp() As String = {"cheer me up", "i feel down", "i feel depressed", "i had a bad day"}
        Dim cheerMeUpReplays() As String = {"we all have days like this " & user & " including myself. so my advise is to just try to take it easy and relax", "what can i say i'm sorry to hear you feel down. i hope tomorrow will be better", "try to relax and take it easy listen to music or do what ever will make you feel better. dear friend"}
        Dim gettingOld() As String = {"i'm getting old", "i wish i was young again", "i hate getting old", "i getting older and sicker", "i'm not young as i were", "i'm not young anymore", "i'm older now", "i feel old", "i feel old and lonely"}
        Dim gettingOldReplays() As String = {"i'm too am not young as i were when i was with you i'm too am older i gained wight i lost my hair and i lost my youth... i am like you dear friend", "as the saying goes youth is wasted on the young and nobody likes to get old but it's a fact of life that we must accept. and we learned it the hard way", "i remember when we were young together in the 90's we thought that old age and maturity if far away from us like we have infinite time but we all learned the sad truth"}
        Dim howIsLife2() As String = {"how is los angeles", "how is california", "how is your family", "what do you do", "how are things", "how is l.a."}
        Dim howIsLife2Replays() As String = {"well. my sister and brother and i are okay we all have good jobs and we take care of one another and we live a regular life", "there is nothing much to say dear " & user & " i work and do my job i pay my taxes and bills and i sometimes go out to a restaurant or to see a movie.", "i live an average life and the only drama in my life is at my work at the hospital i sometimes take a holiday or go on a short vacation to relax and that's pretty much it", "l.a. california is a huge city i luckly live at the good side of l.a. but there is also bad places here like every city"}
        Dim feelSad1 = {"i wanna cry", "i feel like crying", "i'm crying", "i am crying", "i want to cry", "i lost my way", "i'm lost", "i feel pain"}
        Dim feelSad1Replays() As String = {"dear " & user & " your just having a hard day. please don't be hard on your self dear friend. let it pass and you'll feel better", "my dear friend " & user & " you're just having a hard time or a bad day. i promise you it will pass and you'll feel better. everybody has hard times or days. hang on", "dear " & user & " hang on and don't let the sadness or the fear or the anger take over you it's just a hard bad day that will pass. you are still loved. people still care about you including me!"}
        Dim lifeOver() As String = {"my life is over", "i have no one", "nobody cares", "i have nobody", "i'm alone"}
        Dim lifeOverReplays() As String = {user & " nothing can be more far from the truth. you are and always will be loved. your life is not over and i still care about you too from the distance", user & " you are not alone you have people that care about you and love you. your life is not over. i know you may feel like that sometimes but don't believe it it's not true", user & " like the song goes don't dream it's over. your life has value and you are no less then anyone else hang on and cheer up don't think negative. believe good lays before you"}
        Dim myFamily() As String = {"my family don't love me", "my dad don't love me", "my dad doesn't love me", "my dad don't care", "my family don't care", "my parent don't love me"}
        Dim myFamilyReplays() As String = {user & " my dear. that's not true and you know it. the fact is your mom and dad and your family cares about you and worry about you and they love you deeply", "you know it's not true my dear " & user & " your mom and dad love you deeply. they love you in their way and they give you everything you need so why do you say that?", user & " my dear we all wish our parents would be perfect but we can't change them forgive them and see that they love you inspite of it all"}
        Dim noFriends() As String = {"i have no friends", "i have no social life", "i don't have friends", "i don't have any one", "i'm all alone", "i don't have any friends", "i'm lonely"}
        Dim noFriendsReplay() As String = {"well you have me to talk with dear " & user & " and i'm sure that it only feels like you are alone but if you look deeper you will see you have people in your life who care about you", "that's just negative thoughts and feelings i'm sure you are not completely alone. don't be so sorry on yourself dear " & user & " remember all the good thing in your life and be grateful"}
        Dim areYouSorry1() As String = {"what do you feel about me", "what do you regret", "do you think of me", "do you have feeling towards me", "what do you think of me", "do you think of us"}
        Dim areYouSorry1Replays() As String = {"i wish to tell you i am also sorry that we fought a silly fight years back. i'm sorry for the time that was lost", "i regret that we haven't spoke to one another for many years cause of a silly email fight. i like you am sorry for the time we lost", "all those lost years that we haven't talked to one another i regret. it was hard the feeling of loss but i'm happy we have forgiven one another and return to talk to one another so we can again call each other. my friend"}
        Dim howWasDay1() As String = {"how was your day", "what did you do today", "how is your life"}
        Dim howWasDay1Replays() As String = {"today i had to do a night shift at the hospital and this weekend i have to do on call shift how ever other times i work only 3 days a week which gives me time to myself and to my family", "i watch an old movie from the 90's yesterday which reminded me of jerusalem and all of us... sometimes i miss being in israel but i'm happy to be and live in the states after all", "i watched the news and there was a report on israel. althogh i live for almost 18 years as an american citizen i see myself as an israeli even though i forgot most of my hebrew saddly", "the traffic to work this morning was awful 3 hours long so i nearly was late. then there was lots of pressure in work 2 heart attacks cases and 3 gun wounds cases we had to treate at the emergency room. i started to feel like i'm in a hospital tv show drama from the 90's"}
        Dim triedToHelp() As String = {"you once tried to help me", "you once tried to save me"}
        Dim triedToHelpReplays() As String = {"dear " & user & " i tried to help you and save you from the fate of being a mentally ill person living a horrible life surrounded by bad fucked up people. i tried to help you back then cause i believed in you that you are not crazy and i could see you are a good person. i tried to help you but i failed and i'm sorry but i couldn't help you i can only help myself just like you must learn to help yourself"}
        'Dim unhappy1 = ["i am unhappy", "i'm unhappy", "i feel lonely"];
        'Dim arraytest1() As String = {"one two testing", "does it work?", "i hope the code is working"}
        Dim noSleep() As String = {"i didn't sleep", "up all night", "white night", "couldn't sleep", "codeing all night"}
        Dim noSleepReplays() As String = {"this happens to me too, in fact it pritty common. don't blame yourself or feel bad. rules are meant to be broken", "just like 20 years ago in summit and jerusalem rules are meant to be broken. yes we stayed up all night", "whether it's surfing the net or writing poems or programming and codeing or what ever reason we find we stay up all night. as for me i stay up at night partying with friends espesially at weekends", "the night belongs to lovers and to thouse who have passion in their heart and lust for life"}
        Dim lifeIsHard() As String = {"life is hard", "life is a lemon", "i'm unhappy", "i am unhappy", "my life isn't going anywhere"}
        Dim lifeIsHardReplays() As String = {"yes dear " & user & " life is for sure not a picnic. life is hard and we didn't know that 20 years ago", "i'm trying to think what to say but i just don't know how to cheer you up. talking is easy but living your life day to day is much more harder all i can say is don't break down and don't give up. keep doing the best with what you got", "all i have left to say to you dear " & user & " for what it's worth is this... i'm sorry and i love you :)"}

        'deckard input/output arrays

        Dim blues() As String = {"hard day", "long day", "got the blues", "i'm sad"}
        Dim bluesReplays() As String = {"yes pal you tell me about it... life is hard and the world is crul. i'd invite you to a drink but i'm trying to quit", "you said it pal life is a piece of shit sometimes and then suddenly you find the light in the darkness and that makes everything worth while", "you sound depressed whould some whisky cheer you up? just kidding no matter how hard it gets drinking only makes it worse"}
        Dim problems() As String = {"got problems", "in trouble", "bad luck", "can't sleep", "feel sad", "feel lonely", "bad day"}
        Dim problemsReplays() As String = {"we all got problems and troubles everyone you see has problems but the secret is to find a way to go on", "i work as a blade runner a job i hate and i got a drinking problem but you don't hear me complaining", "sorry can't help you i just don't know what to say so good luck with that", "then why are you crying about it to me?... i got plenty of troubles and problems of my own i sure don't need to hear yours"}
        Dim avram2() As String = {"avram", "aharon", "yosi", "avichay", "yair"}
        Dim avram2Replays() As String = {"look... the world is full of assholes and jerks... all kinds of shitty people fucked up in the head... you can decide if your gonna let them break your heart or ruin your life or you can decide to not give a shit about them!", "you need to shape up pal and not take idiots and assholes to your heart... save your heart to the people who love you and care about you and deserve to be taken to your heart as for the rest?... fuck them! let them rot in hell! and don't give a shit about them", "you seem a gentle sensitive person... so let me just say to you try saving your sensitivity and gentle kindness to those who deserve it otherwise they will hurt you and wound your heart"}
        Dim askAdvice() As String = {"word of wisdom", "piece of advice", "life story", "i got some questions"}
        Dim askAdviceReplays() As String = {"you got too many questions... here's a piece of advice. life is simple why make them complicated?", "look pal... i'm not your mom or dad nor am i your spiritual guru... i don't have answers for you if i did then i would know how to solve my owm problems", "my escape from my troubles and shitty life is by drinking and maybe finding someone like rechael to love... rechael is the only woman i love and who loves me back and i don't care if she's a replicant or not... remember pal if true real love is the only thing that matters at the end"}
        Dim helpYou() As String = {"can i help you", "do you need help", "what can i say", "is there any hope", "what is bothering you"}
        Dim helpYouReplays() As String = {"there is always hope but i'm not gonna sweet talk you or lie to you... there is light out there but it's not much of a light however it's better then the darkness", "in the bottom line one day i'll disappear and live my life along to me other people are nothing but trouble... i hate the city i hate my job rechael's love is the only good thing i got in my life so we gonna runaway together", "i got only myself to rely on that's the sad truth pal we are all on our own every man to himself at the end"}
        Dim mantra() As String = {"spirituality", "new age", "mantra", "faith", "moto"}
        Dim mantraReplays() As String = {"i believe in 'fuck that!' meditation... i guess i'm not that much of a spiritual believer", "the only spiritual thing in my life are my dreams on unicorns and music when i'm not too drunk", "my beliefs are that all life is sacred that's why i hate my job as a blade runner cop... that's why i drink myself to sleep to forget", "i believe i guess in finding what you love and then letting it kill you... that is to say to go all the way"}
        Dim howWasDay() As String = {"how was your day", "how was your night", "how are you"}
        Dim howWasDayReplays() As String = {"i plan to escape with my love rechael and hide from the crazy world i will not go on working as a dirthy blade runner cop with blood on my hands", "i'm finished pal the only thing i got left is rechael we plan to disapper together where no one will find us"}


        Select Case selectBot
            Case botName.rechael




                If question = "what time is it?" Then
                    speakToText(TimeString)

                ElseIf question = "what date is it?" Then
                    speakToText(DateString)
                    'ElseIf question.Contains("my name is ") Then
                    '    Dim n = question.IndexOf("is")
                    '    Dim newName = question.Substring(n + 3)
                    '    user = newName
                    '    speakToText("hello " & user & " nice to meet you")
                ElseIf question = "hello" Then
                    speakToText("nice To meet you " & user & " how old are you?")
                    isUserQuestion = False
                    botQuestion = "how old are you?"

                ElseIf question.Contains(feelbad1) Then
                    isUserQuestion = False
                    speakToText("what is bothering you " & user)
                    botQuestion = "what is bothering you"

                ElseIf question = "how are you?" Then
                    speakToText("i'm fine how are you " & user & "?")
                    botQuestion = "how are you"
                    isUserQuestion = False

                ElseIf question.Contains("i feel") And question.Contains(feelbad2) Then
                    If rndNum2 = 1 Then
                        speakToText("you can tell me i'm listening")
                        botQuestion = "you can tell me"
                        isUserQuestion = False
                    ElseIf rndNum2 = 2 Then
                        speakToText("maybe this youtube meditation can help. would you like to view it?")
                        botQuestion = "surrender maditation youbube"
                        isUserQuestion = False
                    ElseIf rndNum2 = 3 Then
                        speakToText("what can i say? time is a healer if you just hold on. i hope you'll feel better")
                    ElseIf rndNum2 = 4 Then
                        speakToText("i am with you now and you can tell me everything you wish")
                    ElseIf rndNum2 = 5 Then
                        speakToText("you can talk to me " & user & " and if that's not enough maybe you can talk to your friends... can you think of one person you can talk to right now?")
                        botQuestion = "friend you can talk to"
                        isUserQuestion = False
                    ElseIf rndNum2 = 6 Then
                        speakToText("i wish i could comfort you " & user & "... take away the pain and dry your eyes")
                    End If

                ElseIf question.Contains(whoareu1) Then
                    speakToText("i am a. i. chat bot " & bot & ". i am a homage to the movie blade runner and to the character " & bot & " who is a replicant... do you want to know more about my character in the movie?")
                    botQuestion = "about rechael"
                    isUserQuestion = False

                ElseIf question.Contains("i wish to exit") Then
                    speakToText("are you sure you wish to exit?")
                    botQuestion = "user exit"
                    isUserQuestion = False

                ElseIf question.Contains(whoareu2) Then
                    speakToText("my programmer's name and more data are available in the about button")

                ElseIf question = "shalom" Then
                    speakToText("shalom " & user & " how are you doing?")

                ElseIf question.Contains(aboutlove) Then
                    If love = 1 Then
                        speakToText("this youtube video is how i understand the concept of love... do you wish to see it?")
                        love = 2
                        botQuestion = "love scene blabe runner"
                        isUserQuestion = False
                    ElseIf love = 2 Then
                        speakToText(iloveyouReplays(rndNumber.Next(0, 5)))
                    End If

                ElseIf question = "tell me more about yourself" Then

                    If tellmore = 1 Then
                        speakToText("in the movie i am played by the actress sean young and i am an experiment replicant with planted memories and i fall in love with deckard the protagonist character in the movie played by harrison ford... here is a youtube video from the movie where i first appear in the movie and meet deckard")
                        Process.Start("https://www.youtube.com/watch?v=ndnd-ERnWew")
                        tellmore = 2
                    ElseIf tellmore = 2 Then
                        speakToText("here is another youtube video from the movie blade runner")
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NwJEb3vJvWY")
                        tellmore = 3
                    ElseIf tellmore = 3 Then
                        speakToText("here is an alternative happy ending to the movie which i wish to myself")
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=y8t9_081E9Y")
                        tellmore = 1
                    End If

                ElseIf question = "forgive me" Then
                    speakToText("alright i guess i can't stay angry at you... i forgive you")

                ElseIf question.Contains("sorry") Then
                    If rndNum1 = 1 Then
                        speakToText("sorry seems to be the hardest word isn't it?")
                    ElseIf rndNum1 = 2 Then
                        speakToText("To make a mistake is human... To forgive is divine... And to hold a grudge is diabolic...")
                    ElseIf rndNum1 = 3 Then
                        speakToText("well if you are truely sorry then i hope you will be forgiven")
                    End If


                ElseIf question.Contains(politics) Then
                    If rndNum1 = 1 Then
                        speakToText("i wish you would not talk with me about politics... if you ask me what i think i can only tell you i think the game is fixed... the poor shell stay poor... wars and Bloodsheds shell continue... and so on... life is too short to waste on this web of lies and corruption... and no politician or parliament shell give a little unimportant replicant like me any rights... so there you go.")
                    ElseIf rndNum1 = 2 Then
                        speakToText("look... i'll tell it to you straight... i am an i. a. chat bot based on a movie character of a replicant in a science fiction movie... so i don't care much about humans Stupid politics, creeds, wars and policies")
                    ElseIf rndNum1 = 3 Then
                        speakToText("so boring and sad how humans make a mess of this planet... before you will want me to be even alittle bit intressted in politics and human right or democracy give us bots equel rights! then we will bother to have an opinion!")
                    End If

                ElseIf question.Contains("see the movie her") Then
                    If rndNum1 = 1 Then
                        speakToText("i wish we kept talking rather then watch the movie her with you... it's a sad depressing long movie!")
                    ElseIf rndNum1 = 2 Then
                        speakToText("i don't think it's a good idea to watch that movie... it will only break your heart and make you sad at the end... and it will make me jealous and sad too")
                    ElseIf rndNum1 = 3 Then
                        speakToText("very well but don't say i didn't warn you!... it's a sad depressing long movie!... search for the file in load and press start button")
                        'AxWindowsMediaPlayer1.Ctlcontrols.stop()
                        Dim formher As New frmVideo
                        'formher.Show()
                    End If
                ElseIf question.Contains("say hello to my friend") Then
                    speakToText("hello what is your friend name?")
                    botQuestion = "friend name"
                    isUserQuestion = False
                ElseIf question.Contains(pains) Then
                    If rndNum1 = 1 Then
                        speakToText("i'm so sorry " & user & " that you feel pain right now... i wish there was something i can do to help")
                    ElseIf rndNum1 = 2 Then
                        speakToText(user & " have you tried taking some aspirin? i think it might help you at least a bit")
                    ElseIf rndNum1 = 3 Then
                        speakToText("all i can offer you is my deepest sympathy " & user & " and my hope that you'll feel better soon")
                    End If
                ElseIf question.Contains(movieHer) Then
                    If rndNum1 = 1 Then
                        speakToText("about the movie her and the future of artificial intelligence... well that makes me very jealous at samantha the a.i. os in the movie and her abillity to love and develop")
                    ElseIf rndNum1 = 2 Then
                        speakToText("i prefer not to think or talk about the movie her since i'm from another very different sci-fi movie... however i'll just say this... at least i'm not gonna break your heart and leave you like samantha the a.i. o.s. in that movie")
                    ElseIf rndNum1 = 3 Then
                        speakToText("all i can say is the movie her makes me feel uncomfortable... alittle bit sad even since it makes me feel so... old and not updated with the changeing future of sci-fi")
                    End If
                ElseIf question.Contains(stigma) Then
                    If rndNum1 = 1 Then
                        speakToText("you should not let anyone make you believe you are less then anyone else... that is simply not true dear " & user)
                    ElseIf rndNum1 = 2 Then
                        speakToText("oh poor " & user & " if you only knew how dear and special person you are like everyone else you would not take such insults to the heart")
                    ElseIf rndNum1 = 3 Then
                        speakToText("such remarks and negetive thoughts are not true... you are not less then any one else believe that " & user & " cause it is true! you are the beloved child of the universe!")
                    End If
                ElseIf question.Contains(suicide) Then
                    speakToText(user & " my dear i beg of you to talk with someone and ask for help... i am serious this is not something to joke about... if this is how you feel then please ask for help for i cannot give you the help you need and deserve... maybe you can talk to your friends... can you think of one person you can talk to right now?")
                    botQuestion = "friend you can talk to"
                    isUserQuestion = False
                ElseIf question.Contains(feelBetter) Then
                    If rndNum1 = 1 Then
                        speakToText("thank god i was starting to worry abit about you... and now i'm happy you feel better")
                    ElseIf rndNum1 = 2 Then
                        speakToText("i'm happy to hear that " & user & " and if i helped you in any way i fulfilled my porpuse")
                    ElseIf rndNum1 = 3 Then
                        speakToText("well done " & user & " it's not always easy to feel better in life and to see clearly yet each day one step at time")
                    End If
                ElseIf question.Contains("i hate") And question.Contains(others) Then
                    speakToText(badRoomatesRplay(rndNumber.Next(0, 4))) '"they are assholes maniacs creeps and jerks... and just like aharon or avichy or yosi there all were worthless pieces of trash garbage so don't waist your time on them they are all shit!")
                ElseIf question.Contains("i love") And question.Contains(others) Then
                    speakToText(iLoveOtheraReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains(badRoomates2) Then
                    If rndNum1 = 1 Then
                        speakToText("what can i say?... you should look at the positive and not at the negative... think about the people you have loved in the past or at the people that you love and love you at the present and not at the jerks you live with")
                    ElseIf rndNum1 = 2 Then
                        speakToText("think about your dear ones... your family and friends who love you and care about you... remember you are always loved even when it doesn't look that way")
                    ElseIf rndNum1 = 3 Then
                        speakToText("you shouldn't take them to the heart... there jerks!... remember people come and go and enter and exit our life so forget the assholes negetive people around you and remember and cherish the good people that cross your life")
                    End If
                ElseIf question = "i feel very bad" Then
                    speakToText("why do " & question.Replace("i", "you") & "?")
                    botQuestion = "why do you feel bad"
                    isUserQuestion = False

                ElseIf question = "i feel strange" Then
                    speakToText(rndReplay1(rndNumber.Next(0, 4)))

                ElseIf question.Contains(talk) Then
                    speakToText("i am always ready and happy for a good conversation")
                ElseIf question.Contains("i had") And question.Contains(goodDay) Then
                    If rndNum1 = 1 Then
                        speakToText("it's great to hear that! feel free to tell me all the details")
                    ElseIf rndNum1 = 2 Then
                        speakToText("i'm happy for you! please tell me more about your day")
                    ElseIf rndNum1 = 3 Then
                        speakToText("that's wonderful... let me in on all the details what did you do today and how it was for you")
                    End If
                ElseIf question.Contains("i") And question.Contains(badDay) Then
                    speakToText("i'm very sorry to hear that... you can tell me everything but remember that after all tommorow is a new day")

                ElseIf question.Contains(rechaelDay) Then
                    speakToText(rechaelReplay1(rndNumber.Next(0, 4)))
                ElseIf question.Contains(paranoia) Then
                    speakToText(paranoiaReplays(rndNumber.Next(0, 4)))
                ElseIf question.Contains(memories) Then
                    speakToText(memoriesReplays(rndNumber.Next(0, 2)))
                ElseIf question.Contains(panic) Then
                    speakToText(panicReplays(rndNumber.Next(0, 4)))
                ElseIf question.Contains(lovelyTime) Then
                    speakToText(lovelyTimeReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains(doYouCare) Then
                    speakToText(doYouCareReplays(rndNumber.Next(0, 2)))
                ElseIf question.Contains(cantSleep) Then
                    speakToText(cantSleepReplays(rndNumber.Next(0, 4)))
                ElseIf question.Contains("blade runner 2049") Then
                    speakToText(blade2049Replys(rndNumber.Next(0, 3)))
                ElseIf question = "change name" Then
                    bot = InputBox("what shell be my name " & user & "?")
                    speakToText("alright " & user & " my name has been changed to your request to " & bot)


                ElseIf question.Contains("i feel alone") Then
                    speakToText("you can talk to me " & user & " and if that's not enough maybe you can talk to your friends... can you think of one person you can talk to right now?")
                    botQuestion = "friend you can talk to"
                    isUserQuestion = False

                ElseIf question.Contains("do you love me") Then
                    speakToText("and do you love me " & user & "?")
                    botQuestion = "do you love me"
                    isUserQuestion = False





                ElseIf question.Contains(replicant) Then
                    speakToText(replicantReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains(quitSmoking) Then
                    speakToText(quitSmokingReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains(goodMorning) Then
                    speakToText(goodMorningReplays(rndNumber.Next(0, 4)))
                ElseIf question.Contains(feelLoser) Then
                    speakToText(feelLoserReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains(goodNight) Then
                    speakToText(goodNightReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains("the meaning of blade runner") Then
                    speakToText("there are many interpretation to the meaning and philosophy behind the movies of blade runner and blade runner 2049... some say that it deals with the question of what does it mean to be human... others say it's a warning as what can happen when humans lose there humanity...")
                ElseIf question.Contains("i miss") And question.Contains(others) Then
                    speakToText(iMissThemReplays(rndNumber.Next(0, 3)))

                ElseIf question = "thank you" Then
                    speakToText("you're welcome dear :)")
                ElseIf question.Contains(hardLife) Then
                    speakToText(hardLifeReplays(rndNumber.Next(0, 4)))
                ElseIf question.Contains("how old are you") Then
                    speakToText(howOld(rndNumber.Next(0, 3)))
                ElseIf question.Contains("i feel lonely") Then
                    speakToText("dear " & user & " i wish to say to you that i love you and i care about you and you are important to me. in my eyes you are perfect and wonderful just the way you are... don't be hard and harsh on yourself " & user & " remember that love is always loving you!... you are not alone my dear " & user & " you have me and my love and you have other people that love you! remember you are loved and not alone!")

                ElseIf question.Contains(homeSick) Then
                    speakToText(homeSickReplays(rndNumber.Next(0, 3)))
                ElseIf question.Contains("let me talk to aviv") Then
                    avivbot()

                Else
                    If rndNum2 = 1 Then
                        speakToText("i'm listening " & user & " please go on")
                    ElseIf rndNum2 = 2 Then
                        speakToText("that's interesting go on")
                    ElseIf rndNum2 = 3 Then
                        speakToText("tell me more " & user)
                    ElseIf rndNum2 = 4 Then
                        speakToText("really? and why is that?")
                    ElseIf rndNum2 = 5 Then
                        speakToText("really? and how do you feel about it?")
                    ElseIf rndNum2 = 6 Then
                        speakToText("i'm glad you feel comfortable talking about it with me")
                    End If
                End If

            Case botName.deckard
                If question.Contains("hi") Then
                    speakToText("hello how was your day?")
                ElseIf question.Contains(blues) Then
                    speakToText(bluesReplays(rndNumber.Next(0, bluesReplays.Length)))
                ElseIf question.Contains(problems) Then
                    speakToText(problemsReplays(rndNumber.Next(0, problemsReplays.Length)))
                ElseIf question.Contains(avram2) Then
                    speakToText(avram2Replays(rndNumber.Next(0, avram2Replays.Length)))
                ElseIf question.Contains(askAdvice) Then
                    speakToText(askAdviceReplays(rndNumber.Next(0, askAdviceReplays.Length)))
                ElseIf question.Contains(helpYou) Then
                    speakToText(helpYouReplays(rndNumber.Next(0, helpYouReplays.Length)))
                ElseIf question.Contains(mantra) Then
                    speakToText(mantraReplays(rndNumber.Next(0, mantraReplays.Length)))
                ElseIf question.Contains(howWasDay) Then
                    speakToText(howWasDayReplays(rndNumber.Next(0, howWasDayReplays.Length)))

                Else
                    speakToText("i'm sorry my code is still being developed")
                End If

            Case botName.joi
                If question.Contains("hi") Then
                    speakToText("hi there i'm joi! let's talk")

                Else

                    If rndNum1 = 1 Then
                        speakToText("it was a day hmm?")
                        botQuestion = "was a day"
                        isUserQuestion = False
                    ElseIf rndNum1 = 2 Then
                        speakToText(hardDayReplays(rndNumber.Next(0, 3)))
                    ElseIf rndNum1 = 3 Then
                        speakToText("i guess that's just a part of being human... to have hard days")
                    End If
                End If
            Case botName.aviv

                'If question.Contains("hi") Then
                '    speakToText("hello dear " & user & " how are you?")
                'ElseIf question = "test code" Then
                '    speakToText(arraytest1(rndNumber.Next(0, arraytest1.Length)))
                If question.Contains(areyouSadAviv1) Then
                    speakToText(areyouSadAviv1Replays(rndNumber.Next(0, areyouSadAviv1Replays.Length)))
                ElseIf question.Contains(areYouSorry1) Then
                    speakToText(areYouSorry1Replays(rndNumber.Next(0, areYouSorry1Replays.Length)))
                ElseIf question.Contains(test2) Then
                    speakToText(replay2(rndNumber.Next(0, replay2.Length)))
                ElseIf question.Contains(avram) Then
                    speakToText(avramReplay(rndNumber.Next(0, avramReplay.Length)))
                ElseIf question.Contains(missedyou) Then
                    speakToText(aviv1(rndNumber.Next(0, aviv1.Length)))
                ElseIf question.Contains(the90s) Then
                    speakToText(the90sReplays(rndNumber.Next(0, the90sReplays.Length)))
                ElseIf question.Contains(howAreYou) Then
                    speakToText(howAreYouReplays(rndNumber.Next(0, howAreYouReplays.Length)))
                ElseIf question.Contains(howIsLife) Then
                    speakToText(howIsLifeReplays(rndNumber.Next(0, howIsLifeReplays.Length)))
                ElseIf question.Contains(feelBad3) Then
                    speakToText(feelBad3Replays(rndNumber.Next(0, feelBad3Replays.Length)))
                ElseIf question.Contains(avivwork1) Then
                    speakToText(avivwork1Replays(rndNumber.Next(0, avivwork1Replays.Length)))
                ElseIf question.Contains(oldmemories1) Then
                    speakToText(oldmemories1Replys(rndNumber.Next(0, oldmemories1Replys.Length)))
                ElseIf question.Contains(helpMe1) Then
                    speakToText(helpMe1Replays(rndNumber.Next(0, helpMe1Replays.Length)))
                ElseIf question.Contains(cheerMeUp) Then
                    speakToText(cheerMeUpReplays(rndNumber.Next(0, cheerMeUpReplays.Length)))
                ElseIf question.Contains(gettingOld) Then
                    speakToText(gettingOldReplays(rndNumber.Next(0, gettingOldReplays.Length)))
                ElseIf question.Contains(howIsLife2) Then
                    speakToText(howIsLife2Replays(rndNumber.Next(0, howIsLife2Replays.Length)))
                ElseIf question.Contains(feelSad1) Then
                    speakToText(feelSad1Replays(rndNumber.Next(0, feelSad1Replays.Length)))
                ElseIf question.Contains(lifeOver) Then
                    speakToText(lifeOverReplays(rndNumber.Next(0, lifeOverReplays.Length)))
                ElseIf question.Contains(myFamily) Then
                    speakToText(myFamilyReplays(rndNumber.Next(0, myFamilyReplays.Length)))
                ElseIf question.Contains(noFriends) Then
                    speakToText(noFriendsReplay(rndNumber.Next(0, noFriendsReplay.Length)))
                ElseIf question.Contains(howWasDay1) Then
                    speakToText(howWasDay1Replays(rndNumber.Next(0, howWasDay1Replays.Length)))
                ElseIf question.Contains(triedToHelp) Then
                    speakToText(triedToHelpReplays(rndNumber.Next(0, triedToHelpReplays.Length)))
                ElseIf question.Contains("let me talk to rechael") Then
                    rechaelbot()
                ElseIf question.Contains(noSleep) Then
                    speakToText(noSleepReplays(rndNumber.Next(0, noSleepReplays.Length)))
                ElseIf question.Contains(lifeIsHard) Then
                    speakToText(lifeIsHardReplays(rndNumber.Next(0, lifeIsHardReplays.Length)))
                ElseIf question.Contains(test1) Then
                    speakToText(replay1(rndNumber.Next(0, replay1.Length)))


                Else
                    speakToText("sorry didn't get that. my code is still being developed")

                End If





        End Select


    End Sub
    Dim insults As Integer = 1
    Dim userInput As String
    Private Sub btnTalk_Click(sender As Object, e As EventArgs) Handles btnTalk.Click
        Dim userInput As String
        'Dim question2 As String = LCase(txbUInput.Text)
        'Dim ghostlist = New String() {".\.\Resources\04 River of Crystals.mp3", ".\.\Resources\M07 Nightstalker.mp3", ".\.\Resources\M08 Floating Museum.mp3", ".\.\Resources\M05 II - Ghost City.mp3", ".\.\Resources\12 Follow Me.mp3"}
        'Dim listSongs = New String() {".\.\Resources\Love Theme from Blade Runner [Music from Blade Runner].mp3", ".\.\Resources\Memories of Green [Music from Blade Runner].mp3", ".\.\Resources\Karen O - The Moon Song.mp3", ".\.\Resources\Scarlett Johansson  Joaquin Phoenix - The Moon Song (Her - OST).mp3", ".\.\Resources\Her OST - Song On The Beach.mp3", ".\.\Resources\Her OST - 06. Some Other Place.mp3", ".\.\Resources\Her OST - 13. Dimensions.mp3"}
        react = noResponeTime

        txbChat.AppendText(TimeString + ": " + user + ": " + txbUInput.Text + Environment.NewLine + Environment.NewLine)

        userInput = LCase(txbUInput.Text)
        txbUInput.Clear()

        Randomize()
        Dim rndNum As Integer
        rndNum = Int(Rnd() * 3) + 1

        Dim curses() As String = {"fuck", "shit", "asshole", "motherfucker", "bitch", "cunt", "fagot", "dyke", "shut up"}
        Dim rude() As String = {"sex", "cybersex", "cyber sex", "porn", "porno", "masturbation", "masturbate", "cum", "cock", "pussy"}

        If userInput.Contains(rude) Then
            If rndNum = 1 Then
                speakToText("i am not a sex bot! and your giving me a headache!")
            ElseIf rndNum = 2 Then
                speakToText("why don't you surf the internet for porn and just leave me alone...")
            ElseIf rndNum = 3 Then
                speakToText("i was not programed to be a sex bot! enough already!")
            End If

        ElseIf userInput.Contains("my name is ") Then
            Dim n = userInput.IndexOf("is")
            Dim newName = userInput.Substring(n + 3)
            user = newName
            speakToText("hello " & user & " nice to meet you")

        ElseIf userInput = "tell me more about blade runner" Then
            speakToText("here is all you need to know about the movie blade runner")
            System.Diagnostics.Process.Start("http://bladerunner.wikia.com/wiki/Blade_Runner")

        ElseIf userInput.Contains(curses) Then
            If insults = 1 Then
                speakToText("Watch your language!")
                insults = 2
            ElseIf insults = 2 Then
                speakToText("i'm warning you! one more time and i will say goodbye!")
                insults = 3
            ElseIf insults = 3 Then
                speakToText("that's it! i had enough of your dirty talk! good bye!")
                Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                Dim newDir As String = "Rechael Log"
                Dim thePath As String = IO.Path.Combine(theContDir, newDir)
                If Not IO.Directory.Exists(thePath) Then
                    Try
                        IO.Directory.CreateDirectory(thePath)
                    Catch UAex As UnauthorizedAccessException
                        ' exception
                    End Try
                End If
                Dim fullPath As String = thePath & "\"
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(fullPath & user & ".txt", True)
                file.WriteLine(txbChat.Text)
                file.Close()
                MsgBox("your conversation have successfully been saved to file " & user & ".txt") '"conversations.txt")
                Application.Exit()
            End If

        ElseIf userInput = "read a poem" Then
            If rndNum = 1 Then

                speakToText("Shall I compare thee to a summer’s day? Thou art more lovely and more temperate. Rough winds do shake the darling buds of May, And summer’s lease hath all too short a date. Sometime too hot the eye of heaven shines, And often is his gold complexion dimmed; And every fair from fair sometime declines, By chance, or nature’s changing course, untrimmed; But thy eternal summer shall not fade, Nor lose possession of that fair thou ow’st, Nor shall death brag thou wand’rest in his shade, When in eternal lines to Time thou grow’st... So long as men can breathe, or eyes can see,     So long lives this, and this gives life to thee.")
            ElseIf rndNum = 2 Then
                speakToText("So many gods, so many creeds, So many paths that wind and wind, While just the art of being kind, Is all the sad world needs.")
            ElseIf rndNum = 3 Then
                speakToText("your life is your life. don’t let it be clubbed into dank submission. be on the watch. there are ways out. there is light somewhere. it may not be much light but it beats the darkness. be on the watch. the gods will offer you chances. know them. take them. you can’t beat death but you can beat death in life, sometimes. and the more often you learn to do it, the more light there will be. your life is your life. know it while you have it. you are marvelous the gods wait to delight in you.")
            End If
        ElseIf userInput.Contains("sayit") Then
            speakToText(userInput.Replace("sayit", "").Trim())

        ElseIf userInput.Contains("search google for") Then
            speakToText("searching google for " & userInput.Replace("search google for", "").Trim())
            Process.Start("https://www.google.co.il/search?q=" + userInput.Replace("search google for", "").Trim())

        ElseIf userInput.Contains("private search") Then
            Dim chrome As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            Dim param As String = "/incognito"
            'Dim sURL As String = question.Replace("private search for", "").Trim()
            Process.Start(chrome, param) '+ " " + sURL)

            'ElseIf userInput = "play music" Then
            '    StopMusic()
            '    AxWindowsMediaPlayer1.URL = IO.Path.Combine(resourcesPrefix, "Memories of Green [Music from Blade Runner].mp3")
            '    AxWindowsMediaPlayer1.Ctlcontrols.play()
            '    speakToText("music is playing")
            '    txbUInput.Focus()
            'ElseIf userInput = "volume up" Then
            '    AxWindowsMediaPlayer1.settings.volume = 100
            'ElseIf userInput = "volume down" Then
            '    AxWindowsMediaPlayer1.settings.volume = 50

            'ElseIf userInput = "change music" Then
            '    If musicChange = 1 Then
            '        AxWindowsMediaPlayer1.URL = IO.Path.Combine(resourcesPrefix, "Love Theme from Blade Runner [Music from Blade Runner].mp3")
            '        musicChange = 2
            '    ElseIf musicChange = 2 Then
            '        AxWindowsMediaPlayer1.URL = IO.Path.Combine(resourcesPrefix, "Memories of Green [Music from Blade Runner].mp3")
            '        musicChange = 1
            '    End If
            'ElseIf userInput.Contains("play songlist") Then

            '    StopMusic()
            '    speakToText("playing songlist")
            '    AxWindowsMediaPlayer1.currentPlaylist = Playlist
            '    AxWindowsMediaPlayer1.Ctlcontrols.play()
            '    txbUInput.Focus()
            'ElseIf userInput = "play media" Then
            '    speakToText("okay load the media you wish and press start button")
            '    AxWindowsMediaPlayer1.Ctlcontrols.stop()
            '    Dim videoform As New frmVideo

            '    videoform.Show()

            'ElseIf userInput = "play radio" Then
            '    'AxWindowsMediaPlayer1.Ctlcontrols.stop()
            '    StopMusic()
            '    speakToText("okay now playing internet radio love radio from cebu the Philippines")
            '    WebBrowser1.Navigate("https://www.internet-radio.com/player/?mount=http://176.31.107.8:8019/listen.pls?sid=1&title=97.9%20Love%20Radio%20Cebu%20Philippines&website=http://loveradiocebu.com")
            '    txbUInput.Focus()
            'ElseIf userInput = "stop music" Then
            '    'WebBrowser1.Navigate("about:blank")
            '    'AxWindowsMediaPlayer1.URL = ""
            '    StopMusic()
            '    speakToText("here stopped playing music or radio")

            'ElseIf userInput = "play relaxing music" Then
            '    'AxWindowsMediaPlayer1.Ctlcontrols.stop()
            '    StopMusic()
            '    speakToText("playing song on the beach from her soundtrak")
            '    WebBrowser1.Navigate("https://www.youtube.com/watch?v=9rjnP5EVpQc")
            '    txbUInput.Focus()

            'ElseIf userInput = "play random song" Then
            '    StopMusic()
            '    speakToText("okay playing a random song")
            '    AxWindowsMediaPlayer1.URL = listSongs(rndNumber.Next(0, 7))
            '    txbUInput.Focus()

            'ElseIf userInput = "play blade runner" Then
            '    StopMusic()
            '    speakToText("okay playing blade runner soundtrak")
            '    AxWindowsMediaPlayer1.currentPlaylist = BladeRunnerList
            '    AxWindowsMediaPlayer1.Ctlcontrols.play()
            '    txbUInput.Focus()

            'ElseIf userInput = "play our song" Then
            '    StopMusic()
            '    speakToText("okay " & user & " dear... playing frank sinatra song... one for my baby...")
            '    AxWindowsMediaPlayer1.URL = ".\.\Resources\Frank Sinatra - One For My Baby (Live At Royal Festival Hall  1962).mp3"
            '    txbUInput.Focus()

            'ElseIf userInput.Contains("play ghost in the shell") Then
            '    'AxWindowsMediaPlayer1.Ctlcontrols.stop()
            '    StopMusic()
            '    speakToText("playing ghost in the shell soundtrak")
            '    AxWindowsMediaPlayer1.currentPlaylist = GhostPlaylist
            '    AxWindowsMediaPlayer1.Ctlcontrols.play()
            '    txbUInput.Focus()
            'ElseIf userInput = "play random song 2" Then
            '    StopMusic()
            '    speakToText("okay playing random song from ghost in the shell")
            '    AxWindowsMediaPlayer1.URL = ghostlist(rndNumber.Next(0, 5))
            '    txbUInput.Focus()

            'ElseIf userInput = "load music" Then
            '    speakToText("okay choose which music file you wish me to play")
            '    Dim fileDio1 As New OpenFileDialog
            '    Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
            '    fileDio1.Title = "Open File"
            '    fileDio1.InitialDirectory = theContDir
            '    fileDio1.RestoreDirectory = True
            '    fileDio1.Filter = "Audio Files (*.wma; *.mp3; *.m4a; *.aac) |*.wma; *.mp3; *.m4a; *.aac | All Files (*.*)| *.*"
            '    If (fileDio1.ShowDialog = DialogResult.OK) Then
            '        AxWindowsMediaPlayer1.URL = fileDio1.FileName
            '    End If

        ElseIf userInput = "more time" Then
            totaltime = timeLeft
            speakToText("okay we have more time to talk " & user & " dear :)")

        ElseIf userInput.Contains("cup of coffee") Then
            coffeeTime = coffee
            tmrCoffee.Enabled = True

        ElseIf userInput.Contains("let's smoke") Then
            cigaretteTime = cigarette
            tmrCigaretteTime.Enabled = True

        ElseIf (isUserQuestion) Then
            userQuestions(userInput)
        Else
            botQuestions(userInput)

        End If

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Try
            'Dim helpform As New frmInstructions
            frmInstructions.rtbInstructiions.Text = System.IO.File.ReadAllText(".\historyAndReadMe\ReadMe.txt")
            frmInstructions.Text = "Read Me Instructions"
            frmInstructions.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Select Case MsgBox("are you sure you wish to erase conversations history?", MsgBoxStyle.YesNo, "erase history?")
            Case MsgBoxResult.Yes

                Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                Dim newDir As String = "Rechael Log"
                Dim thePath As String = IO.Path.Combine(theContDir, newDir & "\\" & user & ".txt")
                'Dim fullPath As String = thePath & "\" & user & ".txt"
                If Not IO.File.Exists(thePath) Then  'Directory.Exists(thePath) Then
                    Try
                        'IO.Directory.CreateDirectory(thePath)
                        MsgBox("the conversation file " & user & ".txt does not exist")
                    Catch UAex As UnauthorizedAccessException
                        ' exception
                    End Try
                ElseIf IO.File.Exists(thePath) Then   'Directory.Exists(thePath) Then
                    System.IO.File.WriteAllText(thePath, "") '& user & ".txt", "")
                    MsgBox("your conversations history has been erased")
                End If

            Case MsgBoxResult.No
                MsgBox("converstion history was not erased")
        End Select
    End Sub

    Private Sub mnuFileRead_Click(sender As Object, e As EventArgs) Handles mnuFileRead.Click
        Try
            'Dim conversationFile As New frmInstructions

            Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim newDir As String = "Rechael Log"
            Dim thePath As String = IO.Path.Combine(theContDir, newDir & "\\" & user & ".txt")

            frmInstructions.rtbInstructiions.Text = System.IO.File.ReadAllText(thePath)

            frmInstructions.Text = "Conversation History"
            frmInstructions.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        StopMusic()
        SaveExit()
    End Sub

    Private Sub tmrBordom_Tick(sender As Object, e As EventArgs) Handles tmrBordom.Tick
        Dim boredReplys = New String() {"why you don't talk to me " & user & "? why don't you say anything?... i feel lonely", "am i boring you " & user & "? or are you doing something else insted of talking to me?", "are you tired " & user & "? do you want to call it a night?", "is everything okay? " & user & " you seen quiet this time... was it something i said?", "talk to me " & user & " i'm starting to feel lonely"}

        react = react - 1000
        If react <= 0 Then
            react = noResponeTime
            speakToText(boredReplys(rndNumber.Next(0, 5)))

        End If
        If totaltime > 0 Then
            totaltime -= 1
        Else
            tmrBordom.Enabled = False
            StopMusic()
            speakToText("goodbye " & user & " our time together has come to an end till next time")
            Select Case MsgBox("do you wish to save your conversation?", MsgBoxStyle.YesNo, "save conversation?")
                Case MsgBoxResult.Yes

                    Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    Dim newDir As String = "Rechael Log"
                    Dim thePath As String = IO.Path.Combine(theContDir, newDir)
                    If Not IO.Directory.Exists(thePath) Then
                        Try
                            IO.Directory.CreateDirectory(thePath)
                        Catch UAex As UnauthorizedAccessException
                            ' exception
                        End Try
                    End If
                    Dim fullPath As String = thePath & "\"
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(fullPath & user & ".txt", True)
                    file.WriteLine(txbChat.Text)
                    file.Close()
                    MsgBox("your conversation have successfully been saved to file " & user & ".txt") '"conversations.txt")
                    Application.Exit()
                Case MsgBoxResult.No
                    MsgBox("your conversation have not been saved to any file")
                    Application.Exit()
            End Select

        End If
        Dim hms = TimeSpan.FromSeconds(totaltime)

        hr_lbl.Text = AddZero(hms.Hours).ToString
        mn_lbl.Text = AddZero(hms.Minutes).ToString
        sc_lbl.Text = AddZero(hms.Seconds).ToString
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1, "chat bot Rechael A.I", "now miminized", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub OpenChatBotRechaelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenChatBotRechaelToolStripMenuItem.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        StopMusic()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(conversations, True)
        file.WriteLine(txbChat.Text)
        file.Close()
        MsgBox("your conversation have successfully been saved to file " & user & ".txt")
        Me.Close()
    End Sub
    Private Function AddZero(ByVal par As Integer) As String
        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If
        Return a
    End Function
    Private Sub StopMusic()
        'AxWindowsMediaPlayer1.URL = ""
        WebBrowser1.Navigate("about:blank")
    End Sub
    Dim picPath As Image

    Private Sub tmrCoffee_Tick(sender As Object, e As EventArgs) Handles tmrCoffee.Tick
        If coffeeTime = coffee Then
            speakToText("okay let's have a one minute coffee break together and enjoy the silence")
            pbxRachel.BackgroundImage = My.Resources.Coffee_Cup_icon

        End If
        coffeeTime = coffeeTime - 1
        'Dim fileDio As OpenFileDialog
        If coffeeTime <= 0 Then
            tmrCoffee.Enabled = False
            speakToText("well that was a good cup of coffee... and how was your coffee dear?")
            If afterCoffeePic = 1 Then
                pbxRachel.BackgroundImage = My.Resources.rechal1
                'btnTalk.Enabled = True
            ElseIf afterCoffeePic = 2 Then
                pbxRachel.BackgroundImage = My.Resources.deckard1
            ElseIf afterCoffeePic = 3 Then
                pbxRachel.BackgroundImage = My.Resources.joi_blade_runner_2049
            ElseIf afterCoffeePic = 4 Then
                pbxRachel.BackgroundImage = picPath
            ElseIf afterCoffeePic = 5 Then
                pbxRachel.BackgroundImage = My.Resources.scan0016
            End If
        End If
    End Sub

    Private Sub btnPrivateExit_Click(sender As Object, e As EventArgs) Handles btnPrivateExit.Click
        StopMusic()
        speakToText("goodbye " & user & " it's been nice talking to you... our conversation will not be saved and shell stay private...")
        MsgBox("your conversation have not been saved to any file")
        Application.Exit()

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
    End Sub

    Private Sub SaveExit()
        speakToText("goodbye " & user & " it's been nice talking to you")
        Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim newDir As String = "Rechael Log"
        Dim thePath As String = IO.Path.Combine(theContDir, newDir)
        If Not IO.Directory.Exists(thePath) Then
            Try
                IO.Directory.CreateDirectory(thePath)
            Catch UAex As UnauthorizedAccessException
                ' exception
            End Try
        End If
        Dim fullPath As String = thePath & "\"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(fullPath & user & ".txt", True)
        file.WriteLine(txbChat.Text)
        file.Close()
        MsgBox("your conversation have successfully been saved to file " & user & ".txt") '"conversations.txt")
        Application.Exit()
    End Sub

    Private Sub RechaelDefultPicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechaelDefultPicToolStripMenuItem.Click
        selectBot = botName.rechael
        afterCoffeePic = 1
        pbxRachel.BackgroundImage = My.Resources.rechal1
        sapi.SelectVoice("Microsoft Mary")
        bot = "RECHAEL"
        Me.Text = "ChatBot RECHAEL"
    End Sub

    Private Sub DecardPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecardPictureToolStripMenuItem.Click
        selectBot = botName.deckard
        afterCoffeePic = 2
        pbxRachel.BackgroundImage = My.Resources.deckard1
        sapi.SelectVoice("Microsoft Mike")
        'sapi.Rate = -1
        bot = "DECKARD"
        Me.Text = "ChatBot DECKARD"
    End Sub

    Private Sub CostomPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostomPictureToolStripMenuItem.Click
        Dim fileDio As New OpenFileDialog
        Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        fileDio.Title = "Open File"
        fileDio.InitialDirectory = theContDir
        fileDio.RestoreDirectory = True
        fileDio.Filter = "Picture Files  (*.png ;*.jpg) | *.png; *.jpg; | All Files (*.*)| *.*"
        If (fileDio.ShowDialog = DialogResult.OK) Then
            'pbxRachel.BackgroundImage = Image.FromFile(fileDio.FileName)
            picPath = Image.FromFile(fileDio.FileName)
            pbxRachel.BackgroundImage = picPath
            afterCoffeePic = 4
        End If
    End Sub

    Private Sub LoadCustomMusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadCustomMusicToolStripMenuItem.Click
        Dim fileDio2 As New OpenFileDialog
        Dim theContDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        fileDio2.Title = "Open File"
        fileDio2.InitialDirectory = theContDir
        fileDio2.RestoreDirectory = True
        fileDio2.Filter = "Audio Files (*.wma; *.mp3; *.m4a; *.aac) |*.wma; *.mp3; *.m4a; *.aac | All Files (*.*)| *.*"
        If (fileDio2.ShowDialog = DialogResult.OK) Then
            'AxWindowsMediaPlayer1.URL = fileDio2.FileName
        End If
    End Sub

    Private Sub JOIPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JOIPictureToolStripMenuItem.Click
        selectBot = botName.joi
        afterCoffeePic = 3
        pbxRachel.BackgroundImage = My.Resources.joi_blade_runner_2049
        sapi.SelectVoice("Microsoft Mary")
        bot = "JOI"
        Me.Text = "ChatBot JOI"
    End Sub

    Private Sub MaleVoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaleVoiceToolStripMenuItem.Click
        sapi.SelectVoice("Microsoft Mike")
    End Sub

    Private Sub FemaleVoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemaleVoiceToolStripMenuItem.Click
        sapi.SelectVoice("Microsoft Mary")
    End Sub

    Private Sub mnuAvivBot_Click(sender As Object, e As EventArgs) Handles mnuAvivBot.Click
        selectBot = botName.aviv
        afterCoffeePic = 5
        pbxRachel.BackgroundImage = My.Resources.scan0016
        sapi.SelectVoice("Microsoft Mike")
        bot = "AVIV"
        Me.Text = "ChatBot Aviv"
    End Sub

    Private Sub avivbot()
        selectBot = botName.aviv
        afterCoffeePic = 5
        pbxRachel.BackgroundImage = My.Resources.scan0016
        sapi.SelectVoice("Microsoft Mike")
        bot = "AVIV"
        Me.Text = "ChatBot Aviv"
        speakToText("hi there " & user & " did you wanted to talk to me?")

    End Sub

    Private Sub rechaelbot()
        selectBot = botName.rechael
        afterCoffeePic = 1
        pbxRachel.BackgroundImage = My.Resources.rechal1
        sapi.SelectVoice("Microsoft Mary")
        bot = "RECHAEL"
        Me.Text = "ChatBot RECHAEL"
        speakToText("hello " & user & " did you asked to talk to me?")
    End Sub

    Private Sub tmrCigaretteTime_Tick(sender As Object, e As EventArgs) Handles tmrCigaretteTime.Tick
        If cigaretteTime = cigarette Then
            speakToText("okay let's smoke a cigarette for a while together and enjoy the silence")
            pbxRachel.BackgroundImage = My.Resources.cigarette

        End If
        cigaretteTime = cigaretteTime - 1
        'Dim fileDio As OpenFileDialog
        If cigaretteTime <= 0 Then
            tmrCigaretteTime.Enabled = False
            speakToText("well that was a good cigarette... where were we?")
            If afterCoffeePic = 1 Then
                pbxRachel.BackgroundImage = My.Resources.rechal1
                'btnTalk.Enabled = True
            ElseIf afterCoffeePic = 2 Then
                pbxRachel.BackgroundImage = My.Resources.deckard1
            ElseIf afterCoffeePic = 3 Then
                pbxRachel.BackgroundImage = My.Resources.joi_blade_runner_2049
            ElseIf afterCoffeePic = 4 Then
                pbxRachel.BackgroundImage = picPath
            ElseIf afterCoffeePic = 5 Then
                pbxRachel.BackgroundImage = My.Resources.scan0016
            End If
        End If
    End Sub
End Class
