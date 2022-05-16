Public Class frm_OrderDetails
    Dim KTV As Integer = 0
    Dim KSAT As Integer = 0
    Dim KNET As Integer = 0
    Dim K1G As Integer = 0
    Dim K2G As Integer = 0
    Dim Kupgrade As Integer = 0

    Dim BROTV As Integer = 0
    Dim BROSAT As Integer = 0
    Dim BRONET As Integer = 0
    Dim BRO1G As Integer = 0
    Dim BRO2G As Integer = 0
    Dim BROHeatPump As Integer = 0

    Dim BRTTV As Integer = 0
    Dim BRTSAT As Integer = 0
    Dim BRTNET As Integer = 0
    Dim BRT1G As Integer = 0
    Dim BRT2G As Integer = 0
    Dim BRTHeatPump As Integer = 0

    Dim LRTV As Integer = 0
    Dim LRSAT As Integer = 0
    Dim LRNET As Integer = 0
    Dim LR1G As Integer = 0
    Dim LR2G As Integer = 0
    Dim LRHeatPump As Integer = 0

    Dim BATH1G As Integer = 0
    Dim BATH2G As Integer = 0
    Dim BATHUpgrades As Integer = 0

    Dim KitchenA As Boolean = False
    Dim KitchenB As Boolean = False
    Dim KitchenC As Boolean = False
    Dim LRHeat As Boolean = False
    Dim BROHeat As Boolean = False
    Dim BATHOption As Boolean = False
    Dim BRTHeat As Boolean = False

    Dim Kitchenupgradevalue As Integer
    Dim kitchennetworkvalue As Integer
    Dim kitchen1gvalue As Integer
    Dim kitchen2gvalue As Integer
    Dim kitchenTVvalue As Integer
    Dim kitchenSATvalue As Integer

    Dim networkvalue As Integer

    Dim livingTVvalue As Integer
    Dim livingSATvalue As Integer
    Dim livingnetworkvalue As Integer
    Dim living1gvalue As Integer
    Dim living2gvalue As Integer
    Dim livingheatpumpvalue As Integer

    Dim bedroomtwoTVvalue As Integer
    Dim bedroomtwoSATvalue As Integer
    Dim bedroomtwonetworkvalue As Integer
    Dim bedroomtwo1gvalue As Integer
    Dim bedroomtwo2gvalue As Integer
    Dim bedroomtwoheatpumpvalue As Integer

    Dim bedroomoneTVvalue As Integer
    Dim bedroomoneSATvalue As Integer
    Dim bedroomonenetworkvalue As Integer
    Dim bedroomone1gvalue As Integer
    Dim bedroomone2gvalue As Integer
    Dim bedroomoneheatpumpvalue As Integer

    Dim BathUpgradevalue As Integer
    Dim Bath1gvalue As Integer
    Dim Bath2gvalue As Integer




    Dim tvpointdefult As Boolean = True
    Dim satpointdefult As Boolean = True

    Dim userimputcheck As Boolean = False

    Dim start_zerio As Boolean = False




    Private Sub frm_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDetails.Hide()

    End Sub
    Private Sub priceing_math()
        'kitchen Options'

        ' Kitchen newtork
        If Kitchen(2) > 0 Then
            kitchennetworkvalue = (Kitchen(2) * Network_Point) + Network_Switch

        Else
            kitchennetworkvalue = 0
        End If

        'kitchen one G socket
        If Kitchen(3) > 0 Then
            kitchen1gvalue = Kitchen(3) * OneGSocket
        Else
            kitchen1gvalue = 0
        End If

        'Kitchen Two G socket
        If Kitchen(4) > 0 Then
            kitchen2gvalue = Kitchen(4) * TwoGSocket
        Else
            kitchen2gvalue = 0
        End If

        'Kitchen upgrade option.
        Select Case Kitchen(5)
            Case 0
                Kitchenupgradevalue = 0
            Case 1
                Kitchenupgradevalue = KitchenOptionA
            Case 2
                Kitchenupgradevalue = KitchenOptionB
            Case 3
                Kitchenupgradevalue = KitchenOptionC

        End Select

        'Kitchen TV Point
        If Kitchen(0) > 0 Then
            kitchenTVvalue = KTV * TV_Aerial_Point
        End If

        'Kitchen SAT point
        If Kitchen(1) > 0 Then
            kitchenSATvalue = KSAT * TV_SAT_Point
        End If


        ' Living room Values '
        ' Living Room Roof Aerial + TV Point
        If LivingRoom(0) > 0 Then
            livingTVvalue = TV_Aerial
        Else
            livingTVvalue = 0
        End If

        'Living Room Sat dish + Tv point
        If LivingRoom(1) > 0 Then
            livingSATvalue = TV_SAT
        Else
            livingSATvalue = 0
        End If

        ' Living Room Network Point
        If LivingRoom(2) > 0 Then
            livingnetworkvalue = LivingRoom(2) * Network_Point
        Else
            livingnetworkvalue = 0
        End If

        'Living Room One G socket
        If LivingRoom(3) > 0 Then
            living1gvalue = LivingRoom(3) * OneGSocket
        Else
            living1gvalue = 0
        End If

        'Living Room Two G socket
        If LivingRoom(4) > 0 Then
            living2gvalue = LivingRoom(4) * TwoGSocket
        Else
            living2gvalue = 0
        End If
        ' Living room HeatPump
        If LivingRoom(5) > 0 Then
            livingheatpumpvalue = HeatPump2
        Else
            livingheatpumpvalue = 0
        End If


        ''Bath Room Options ''

        'Bath Room One G socket
        If BathRoom(0) > 0 Then
            Bath1gvalue = BathRoom(0) * OneGSocket
        Else
            Bath1gvalue = 0
        End If


        'Bath Room Two G socket
        If BathRoom(1) > 0 Then
            Bath2gvalue = BathRoom(1) * TwoGSocket
        Else
            Bath2gvalue = 0
        End If

        If BathRoom(2) > 0 Then
            BathUpgradevalue = BathRoom(2) * BathUpgrade
        Else
            BathUpgradevalue = 0
        End If


        ' Bed room Two Values '

        ' TV Point
        If BedRoomTwo(0) > 0 Then
            bedroomtwoTVvalue = TV_Aerial
        Else
            bedroomtwoTVvalue = 0
        End If

        ' Sat point
        If BedRoomTwo(1) > 0 Then
            bedroomtwoSATvalue = TV_SAT
        Else
            bedroomtwoSATvalue = 0
        End If

        ' Network Point
        If BedRoomTwo(2) > 0 Then
            bedroomtwonetworkvalue = BedRoomTwo(2) * Network_Point
        Else
            bedroomtwonetworkvalue = 0
        End If

        ' One G socket
        If BedRoomTwo(3) > 0 Then
            bedroomtwo1gvalue = BedRoomTwo(3) * OneGSocket
        Else
            bedroomtwo1gvalue = 0
        End If

        ' Two G socket
        If BedRoomTwo(4) > 0 Then
            bedroomtwo2gvalue = BedRoomTwo(4) * TwoGSocket
        Else
            bedroomtwo2gvalue = 0
        End If
        ' HeatPump
        If BedRoomTwo(5) > 0 Then
            bedroomtwoheatpumpvalue = HeatPump1
        Else
            bedroomtwoheatpumpvalue = 0
        End If


        ' Bed room One Values '

        ' TV Point
        If BedRoomOne(0) > 0 Then
            bedroomoneTVvalue = TV_Aerial
        Else
            bedroomoneTVvalue = 0
        End If

        ' Sat point
        If BedRoomOne(1) > 0 Then
            bedroomoneSATvalue = TV_SAT
        Else
            bedroomoneSATvalue = 0
        End If

        ' Network Point
        If BedRoomOne(2) > 0 Then
            bedroomonenetworkvalue = BedRoomOne(2) * Network_Point
        Else
            bedroomonenetworkvalue = 0
        End If

        ' One G socket
        If BedRoomOne(3) > 0 Then
            bedroomone1gvalue = BedRoomOne(3) * OneGSocket
        Else
            bedroomone1gvalue = 0
        End If

        ' Two G socket
        If BedRoomOne(4) > 0 Then
            bedroomone2gvalue = BedRoomOne(4) * TwoGSocket
        Else
            bedroomone2gvalue = 0
        End If
        ' HeatPump
        If BedRoomOne(5) > 0 Then
            bedroomoneheatpumpvalue = HeatPump1
        Else
            bedroomoneheatpumpvalue = 0
        End If


        ' total values 

        totalvalue(1) = kitchennetworkvalue + kitchen1gvalue + kitchen2gvalue + Kitchenupgradevalue + kitchenTVvalue + kitchenSATvalue ' Total Kitchen COST
        totalvalue(2) = livingheatpumpvalue + livingnetworkvalue + living2gvalue + living1gvalue + livingTVvalue + livingSATvalue ' Total Living Room COST
        totalvalue(3) = bedroomoneheatpumpvalue + bedroomonenetworkvalue + bedroomone1gvalue + bedroomone2gvalue + bedroomoneTVvalue + bedroomoneSATvalue ' Total Bedroom One cost
        totalvalue(4) = bedroomtwoheatpumpvalue + bedroomtwonetworkvalue + bedroomtwo1gvalue + bedroomtwo2gvalue + bedroomtwoTVvalue + bedroomtwoSATvalue ' Total Bedroom Two Cost
        totalvalue(5) = Bath1gvalue + Bath2gvalue + BathUpgradevalue ' Total Bath Room Cost
        totalvalue(0) = totalvalue(1) + totalvalue(2) + totalvalue(3) + totalvalue(4) + totalvalue(5) ' All up Total

        Label1.Text = totalvalue(1).ToString("C")
        Label2.Text = totalvalue(2).ToString("C")
        Label22.Text = totalvalue(4).ToString("C")
        Label28.Text = totalvalue(3).ToString("C")
        Label16.Text = totalvalue(5).ToString("C")
        Label6.Text = totalvalue(0).ToString("C")
    End Sub

    Private Sub value_store()
        ' This Stores the values into an array so I can access this infomation easily on other forms and save this infomation to text files.
        Kitchen(0) = KTV
        Kitchen(1) = KSAT
        Kitchen(2) = KNET
        Kitchen(3) = K1G
        Kitchen(4) = K2G
        Kitchen(5) = Kupgrade

        BedRoomOne(0) = BROTV
        BedRoomOne(1) = BROSAT
        BedRoomOne(2) = BRONET
        BedRoomOne(3) = BRO1G
        BedRoomOne(4) = BRO2G
        BedRoomOne(5) = BROHeatPump

        BedRoomTwo(0) = BRTTV
        BedRoomTwo(1) = BRTSAT
        BedRoomTwo(2) = BRTNET
        BedRoomTwo(3) = BRT1G
        BedRoomTwo(4) = BRT2G
        BedRoomTwo(5) = BRTHeatPump

        LivingRoom(0) = LRTV
        LivingRoom(1) = LRSAT
        LivingRoom(2) = LRNET
        LivingRoom(3) = LR1G
        LivingRoom(4) = LR2G
        LivingRoom(5) = LRHeatPump

        BathRoom(0) = BATH1G
        BathRoom(1) = BATH2G
        BathRoom(2) = BATHUpgrades

    End Sub

    Private Sub startingzero()
        cbo_kitchenSAT.Text = KSAT
        cbo_kitchenTV.Text = KTV

        cbo_LivingTV.Text = LRTV
        cbo_LivingSAT.Text = LRSAT

        cbo_bed1SAT.Text = BROSAT
        cbo_bed1TV.Text = BROTV

        cbo_bed2SAT.Text = BRTSAT
        cbo_bed2TV.Text = BRTTV

        start_zerio = True




    End Sub
    Private Sub input_rules()
        ' This Sub is called when the Network Boxes are changed this forces the network points to never be able to go over the limit of 4 in a room or 8 in total. And Rules related to the 1G and 2G limits
        If start_zerio = False Then startingzero()

        Dim netpointcheck As Integer
        Dim swtichpoints As Integer
        Dim kitchendefult As Boolean = True
        Dim tvpointcheck As Integer
        Dim satpointcheck As Integer
        Dim socketscheck As Integer

        Dim remainingsocket As Integer = 12

        Dim remainingpoints As Integer = 8

        Dim BROList As Integer
        Dim BRTList As Integer
        Dim LRList As Integer
        Dim KitList As Integer

        Dim BROListsocket_2G As Integer
        Dim BROListsocket_1G As Integer
        Dim BRTListsocket_2G As Integer
        Dim BRTListsocket_1G As Integer
        Dim LRListsocket_2G As Integer
        Dim LRListsocket_1G As Integer
        Dim KitListsocket_2G As Integer
        Dim KitListsocket_1G As Integer
        Dim BathListScoket_1G As Integer
        Dim BathListSocket_2G As Integer



        socketscheck = K1G + K2G + LR1G + LR2G + BATH1G + BATH2G + BRT1G + BRT2G + BRO1G + BRO2G ' This checks the amount of Sockets in toal we can only have 12 and total 4 per room

        swtichpoints = BRONET + BRTNET + LRNET ' This is used to check if one point is in the kitchen where the router is there needs to be one point from the router to the switch
        netpointcheck = KNET + BRONET + BRTNET + LRNET ' This Adds the SUM of all the current network points

        remainingpoints = 8 - netpointcheck ' this removes all the current points from 8 this then displays the remaining points we have acess to.
        remainingsocket = 12 - socketscheck
        'Label2.Text = remainingsocket

        tvpointcheck = KTV + BROTV + BRTTV
        satpointcheck = KSAT + BROSAT + BRTSAT

        If swtichpoints = 0 Then
            If kitchendefult = False Then
                cbo_kitchenNet.Items.Add("0") ' this adds 0 to the list after it is cleared.
                kitchendefult = True ' this is used as a check to confirm its state
            End If
        End If

        If swtichpoints > 0 Then ' this checks if anyother point has a value grater then one this means a point has been selected in another form this then adds 1 to the Kitchen
            If KNET = 0 Then
                KNET = 1
                cbo_kitchenNet.Text = 1 ' this adds the one to the kitchen
                cbo_kitchenNet.Items.Remove("0")
                kitchendefult = False ' this is to confirm its state
            End If
        End If

        'Checks if a Tv Point is slected and then forces one into the living room.
        If tvpointcheck > 0 Then
            If LRTV = 0 Then
                LRTV = 1
                cbo_LivingTV.Text = 1
                cbo_LivingTV.Items.Remove("0")
                tvpointdefult = False
            End If
        End If

        If tvpointcheck = 0 Then
            If tvpointdefult = False Then
                cbo_LivingTV.Items.Add("0")
                tvpointdefult = True
            End If
        End If

        ' Checks if there is a SAT point in all rooms but Living room and forces one into the living room.
        If satpointcheck > 0 Then ' Checks if there is a Sat Point in the other rooms
            If LRSAT = 0 Then ' Checks if there is no option selected in the Living room for a SAT point
                LRSAT = 1 ' Sets the Value we complare and store to 1
                cbo_LivingSAT.Text = 1 ' Sets the text to 1 displaying they have one SAT point 
                cbo_LivingSAT.Items.Remove("0") ' Removes the 0 option from the living room if they have a SAT point in another room
                satpointdefult = False
            End If
        End If

        If satpointcheck = 0 Then
            If satpointdefult = False Then
                cbo_LivingSAT.Items.Add("0") ' Adds 0 to the list when all other rooms have no SAT point and allows the user to select 0 points in livingroom
                satpointdefult = True ' This Checks if it is in the defult list state of 0,1 
            End If
        End If

        ' Bed Room One
        If remainingpoints < 5 Then ' If there are less then 5 Points remaining this then forces the box to have less 4 or less points
            cbo_bed1Net.Items.Clear() ' this clears the items stored in the box
            BROList = remainingpoints + BRONET ' this adds the current amount in Bedroom 1 to the remaining points this is so its not counted so we can changed the remaining points and dont have to set this value to 0 or we can only select less values then what is avaible.
            If BROList > 4 Then BROList = 4 ' If the Previous line makes BROList more then 4 it makes it = 4 this stops the user for access more points I encounted this error though testing
            Do Until BROList = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
                cbo_bed1Net.Items.Add(BROList) ' adds the numbers to the "collection" so the user can only select the avaible points so they cannot go over the limit
                BROList = BROList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
            Loop
            cbo_bed1Net.Text = BRONET
        Else ' If there are more then 5 remaining points this forces the Box to have its maxium of 4 per room
            cbo_bed1Net.Items.Clear() ' clears the box to remove old values and stop duplicates
            BROList = 4 ' this sets the list to 4 the limit per room
            Do Until BROList = -1 ' loops the value so the list will display 0 1 2 3 4.
                cbo_bed1Net.Items.Add(BROList) ' this adds the values to the list (combo box)
                BROList = BROList - 1 ' this removes one each time so it counts down or it would just loop adding 4 endlessly so it now will do  4 then remove one then 3 then remove one ect.
            Loop
            cbo_bed1Net.Text = BRONET

        End If

        ' Bed Room One (2G) Socket Check

        If remainingsocket < 5 Then
            cbo_bed1_2G.Items.Clear()
            BROListsocket_2G = remainingsocket + BRO2G
            If BROListsocket_2G > 4 Then BROListsocket_2G = 4
            Do Until BROListsocket_2G = -1
                cbo_bed1_2G.Items.Add(BROListsocket_2G) ' Change cbo_bed2Net to the Box 
                BROListsocket_2G = BROListsocket_2G - 1
            Loop
            cbo_bed1_2G.Text = BRO2G
        Else
            cbo_bed1_2G.Items.Clear()
            BROListsocket_2G = 4
            Do Until BROListsocket_2G = -1
                cbo_bed1_2G.Items.Add(BROListsocket_2G)
                BROListsocket_2G = BROListsocket_2G - 1
            Loop
            cbo_bed1_2G.Text = BRO2G
        End If



        ' Bed Room One (1G) Socket Check
        If remainingsocket < 5 Then
            cbo_bed1_1G.Items.Clear()
            BROListsocket_1G = remainingsocket + BRO1G
            If BROListsocket_1G > 4 Then BROListsocket_1G = 4
            Do Until BROListsocket_1G = -1
                cbo_bed1_1G.Items.Add(BROListsocket_1G) ' Change cbo_bed2Net to the Box 
                BROListsocket_1G = BROListsocket_1G - 1
            Loop
            cbo_bed1_1G.Text = BRO1G
        Else
            cbo_bed1_1G.Items.Clear()
            BROListsocket_1G = 4
            Do Until BROListsocket_1G = -1
                cbo_bed1_1G.Items.Add(BROListsocket_1G)
                BROListsocket_1G = BROListsocket_1G - 1
            Loop
            cbo_bed1_1G.Text = BRO1G
        End If


        ' Bed Room Two
        If remainingpoints < 5 Then
            cbo_bed2Net.Items.Clear()
            BRTList = remainingpoints + BRTNET
            If BRTList > 4 Then BRTList = 4
            Do Until BRTList = -1
                cbo_bed2Net.Items.Add(BRTList)
                BRTList = BRTList - 1
            Loop
            cbo_bed2Net.Text = BRTNET
        Else
            cbo_bed2Net.Items.Clear()
            BRTList = 4
            Do Until BRTList = -1
                cbo_bed2Net.Items.Add(BRTList)
                BRTList = BRTList - 1
            Loop
            cbo_bed2Net.Text = BRTNET
        End If

        ' Bed Room 2 (2G) Socket Check
        If remainingsocket < 5 Then
            cbo_bed2_2G.Items.Clear()
            BRTListsocket_2G = remainingsocket + BRT2G
            If BRTListsocket_2G > 4 Then BRTListsocket_2G = 4
            Do Until BRTListsocket_2G = -1
                cbo_bed2_2G.Items.Add(BRTListsocket_2G) ' Change cbo_bed2Net to the Box 
                BRTListsocket_2G = BRTListsocket_2G - 1
            Loop
            cbo_bed2_2G.Text = BRT2G
        Else
            cbo_bed2_2G.Items.Clear()
            BRTListsocket_2G = 4
            Do Until BRTListsocket_2G = -1
                cbo_bed2_2G.Items.Add(BRTListsocket_2G)
                BRTListsocket_2G = BRTListsocket_2G - 1
            Loop
            cbo_bed2_2G.Text = BRT2G
        End If


        ' Bed Room 2 (1G) Socket Check
        If remainingsocket < 5 Then
            cbo_bed2_1G.Items.Clear()
            BRTListsocket_1G = remainingsocket + BRT1G
            If BRTListsocket_1G > 4 Then BRTListsocket_1G = 4
            Do Until BRTListsocket_1G = -1
                cbo_bed2_1G.Items.Add(BRTListsocket_1G) ' Change cbo_bed2Net to the Box 
                BRTListsocket_1G = BRTListsocket_1G - 1
            Loop
            cbo_bed2_1G.Text = BRT1G
        Else
            cbo_bed2_1G.Items.Clear()
            BRTListsocket_1G = 4
            Do Until BRTListsocket_1G = -1
                cbo_bed2_1G.Items.Add(BRTListsocket_1G)
                BRTListsocket_1G = BRTListsocket_1G - 1
            Loop
            cbo_bed2_1G.Text = BRT1G
        End If




        '  Living Room
        If remainingpoints < 5 Then
            cbo_LivingNet.Items.Clear()
            LRList = remainingpoints + LRNET
            If LRList > 4 Then LRList = 4
            Do Until LRList = -1
                cbo_LivingNet.Items.Add(LRList)
                LRList = LRList - 1
            Loop
            cbo_LivingNet.Text = LRNET
        Else
            cbo_LivingNet.Items.Clear()
            LRList = 4
            Do Until LRList = -1
                cbo_LivingNet.Items.Add(LRList)
                LRList = LRList - 1
            Loop
            cbo_LivingNet.Text = LRNET
        End If


        ' Living Room (2G) Socket Check
        If remainingsocket < 5 Then
            cbo_Living2G.Items.Clear()
            LRListsocket_2G = remainingsocket + LR2G
            If LRListsocket_2G > 4 Then LRListsocket_2G = 4
            Do Until LRListsocket_2G = -1
                cbo_Living2G.Items.Add(LRListsocket_2G) ' Change cbo_bed2Net to the Box 
                LRListsocket_2G = LRListsocket_2G - 1
            Loop
            cbo_Living2G.Text = LR2G
        Else
            cbo_Living2G.Items.Clear()
            LRListsocket_2G = 4
            Do Until LRListsocket_2G = -1
                cbo_Living2G.Items.Add(LRListsocket_2G)
                LRListsocket_2G = LRListsocket_2G - 1
            Loop
            cbo_Living2G.Text = LR2G
        End If


        ' Living Room 2 (1G) Socket Check
        If remainingsocket < 5 Then
            cbo_Living1G.Items.Clear()
            LRListsocket_1G = remainingsocket + LR1G
            If LRListsocket_1G > 4 Then LRListsocket_1G = 4
            Do Until LRListsocket_1G = -1
                cbo_Living1G.Items.Add(LRListsocket_1G) ' Change cbo_bed2Net to the Box 
                LRListsocket_1G = LRListsocket_1G - 1
            Loop
            cbo_Living1G.Text = LR1G
        Else
            cbo_Living1G.Items.Clear()
            LRListsocket_1G = 4
            Do Until LRListsocket_1G = -1
                cbo_Living1G.Items.Add(LRListsocket_1G)
                LRListsocket_1G = LRListsocket_1G - 1
            Loop
            cbo_Living1G.Text = LR1G
        End If


        ' kitchen
        If remainingpoints < 5 Then
            cbo_kitchenNet.Items.Clear()
            cbo_kitchenNet.Text = KNET
            KitList = remainingpoints + KNET
            If KitList > 4 Then KitList = 4
            Dim zerovalue As Integer
            If kitchendefult = False Then zerovalue = 0 Else zerovalue = -1
            Do Until KitList = zerovalue
                cbo_kitchenNet.Items.Add(KitList)
                KitList = KitList - 1
            Loop
            cbo_kitchenNet.Text = KNET
        Else
            cbo_kitchenNet.Items.Clear()
            cbo_kitchenNet.Text = KNET
            KitList = 4
            Dim zerovalue As Integer
            If kitchendefult = False Then zerovalue = 0 Else zerovalue = -1
            Do Until KitList = zerovalue
                cbo_kitchenNet.Items.Add(KitList)
                KitList = KitList - 1
            Loop
            cbo_kitchenNet.Text = KNET
        End If

        ' Kitchen 2 (2G) Socket Check
        If remainingsocket < 5 Then
            cbo_kitchen2G.Items.Clear()
            KitListsocket_2G = remainingsocket + K2G
            If KitListsocket_2G > 4 Then KitListsocket_2G = 4
            Do Until KitListsocket_2G = -1
                cbo_kitchen2G.Items.Add(KitListsocket_2G) ' Change cbo_bed2Net to the Box 
                KitListsocket_2G = KitListsocket_2G - 1
            Loop
            cbo_kitchen2G.Text = K2G
        Else
            cbo_kitchen2G.Items.Clear()
            KitListsocket_2G = 4
            Do Until KitListsocket_2G = -1
                cbo_kitchen2G.Items.Add(KitListsocket_2G)
                KitListsocket_2G = KitListsocket_2G - 1
            Loop
            cbo_kitchen2G.Text = K2G
        End If


        ' Kitchen (1G) Socket Check
        If remainingsocket < 5 Then
            cbo_kitchen1G.Items.Clear()
            KitListsocket_1G = remainingsocket + K1G
            If KitListsocket_1G > 4 Then KitListsocket_1G = 4
            Do Until KitListsocket_1G = -1
                cbo_kitchen1G.Items.Add(KitListsocket_1G) ' Change cbo_bed2Net to the Box 
                KitListsocket_1G = KitListsocket_1G - 1
            Loop
            cbo_kitchen1G.Text = K1G
        Else
            cbo_kitchen1G.Items.Clear()
            KitListsocket_1G = 4
            Do Until KitListsocket_1G = -1
                cbo_kitchen1G.Items.Add(KitListsocket_1G)
                KitListsocket_1G = KitListsocket_1G - 1
            Loop
            cbo_kitchen1G.Text = K1G
        End If


        ' Bath Room

        ' Bath Room One 2 (2G) Socket Check

        If remainingsocket < 5 Then
            cbo_bath2G.Items.Clear()
            BathListSocket_2G = remainingsocket + BATH2G
            If BathListSocket_2G > 4 Then BathListSocket_2G = 4
            Do Until BathListSocket_2G = -1
                cbo_bath2G.Items.Add(BathListSocket_2G) ' Change cbo_bed2Net to the Box 
                BathListSocket_2G = BathListSocket_2G - 1
            Loop
            cbo_bath2G.Text = BATH2G
        Else
            cbo_bath2G.Items.Clear()
            BathListSocket_2G = 4
            Do Until BathListSocket_2G = -1
                cbo_bath2G.Items.Add(BathListSocket_2G)
                BathListSocket_2G = BathListSocket_2G - 1
            Loop
            cbo_bath2G.Text = BATH2G
        End If


        ' Bath Room One (1G) Socket Check
        If remainingsocket < 5 Then
            cbo_bath1G.Items.Clear()
            BathListScoket_1G = remainingsocket + BATH1G
            If BathListScoket_1G > 4 Then BathListScoket_1G = 4
            Do Until BathListScoket_1G = -1
                cbo_bath1G.Items.Add(BathListScoket_1G) ' Change cbo_bed2Net to the Box 
                BathListScoket_1G = BathListScoket_1G - 1
            Loop
            cbo_bath1G.Text = BATH1G
        Else
            cbo_bath1G.Items.Clear()
            BathListScoket_1G = 4
            Do Until BathListScoket_1G = -1
                cbo_bath1G.Items.Add(BathListScoket_1G)
                BathListScoket_1G = BathListScoket_1G - 1
            Loop
            cbo_bath1G.Text = BATH1G
        End If

        value_store()
        priceing_math()
    End Sub

    Private Sub chk_KitchenA_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenA.CheckedChanged
        If KitchenA = False Then ' This checks if the box is currently ticked if it is false it is not ticked to it runs the next statment
            If KitchenB Or KitchenC = True Then ' This looks if Kitchen option B or option C have been selected if it has one of then will be = to true
                chk_KitchenB.Checked = False ' if option B or C has been selected this unticks there box
                chk_KitchenC.Checked = False ' Same as above
                KitchenB = False ' This sets the KitchB varible to false this varible is used to check if they have been selected
                KitchenC = False
            End If
            KitchenA = True ' This makes Option A set to True so we know it is selected
            Kupgrade = 1 ' This sets the value we check later on to detmian what option was selected in other forms and this one.
        Else
            KitchenA = False ' This Sets the selected option to false because the user unselected this option
            Kupgrade = 0 ' 0 is used to show no option has been selected and the user does not want a kitchen Upgrade.
        End If
        input_rules()
    End Sub

    Private Sub chk_KitchenB_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenB.CheckedChanged
        If KitchenB = False Then
            If KitchenA Or KitchenC = True Then
                chk_KitchenA.Checked = False
                chk_KitchenC.Checked = False
                KitchenA = False
                KitchenC = False
            End If
            KitchenB = True
            Kupgrade = 2
        Else
            KitchenB = False
            Kupgrade = 0
        End If
        input_rules()
    End Sub

    Private Sub chk_KitchenC_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenC.CheckedChanged
        If KitchenC = False Then
            If KitchenA Or KitchenB = True Then
                chk_KitchenA.Checked = False
                chk_KitchenB.Checked = False
                KitchenA = False
                KitchenB = False
            End If
            KitchenC = True
            Kupgrade = 3
        Else
            KitchenC = False
            Kupgrade = 0
        End If
        input_rules()
    End Sub

    Private Sub chk_HeatPumpLiving_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpLiving.CheckedChanged
        If LRHeat = False Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            LRHeat = True ' This then changes the varible to true indicating the the tick box has not been selected.
            LRHeatPump = 1 ' Sets the Value to One meaning the user would like a heatpump in there living room
        Else
            LRHeat = False ' If the Box was already ticked this then sets it to False unticking the box
            LRHeatPump = 0 ' Sets the Value to One meaning the user would not like a heatpump in there living room
        End If
        input_rules()
    End Sub

    Private Sub chk_HeatPumpBedOne_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedOne.CheckedChanged
        If BROHeat = False Then
            BROHeat = True
            BROHeatPump = 1
        Else
            BROHeat = False
            BROHeatPump = 0
        End If
        input_rules()
    End Sub

    Private Sub chk_HeatPumpBedTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedTwo.CheckedChanged
        If BRTHeat = False Then
            BRTHeat = True
            BRTHeatPump = 1
        Else
            BRTHeat = False
            BRTHeatPump = 0
        End If
        input_rules()
    End Sub

    Private Sub chk_HeatPumpBathRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_UpgradeBathRoom.CheckedChanged
        If BATHOption = False Then
            BATHOption = True
            BATHUpgrades = 1
        Else
            BATHOption = False
            BATHUpgrades = 0
        End If
        input_rules()
    End Sub

    Private Sub cbo_kitchenNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenNet.SelectedIndexChanged
        KNET = cbo_kitchenNet.Text ' This sets the value KNET to the value of the combo box

        If userimputcheck = True Then
            userimputcheck = False
            input_rules() ' This calls the sub Imput_Rules this sub is used to check and stop the user from having too many network points and limits it. This Doesn't give the user access to have more then the maxium so they cannot make a mistake and selected more then allowed.
        End If
    End Sub
    Private Sub kitchen_net_userinput() Handles cbo_kitchenNet.MouseClick, cbo_kitchenNet.Enter, cbo_kitchenNet.KeyPress, cbo_kitchenNet.KeyUp, cbo_kitchenNet.KeyDown
        userimputcheck = True
    End Sub
    Private Sub cbo_LivingNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingNet.SelectedIndexChanged
        LRNET = cbo_LivingNet.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()
        End If
    End Sub
    Private Sub cbo_LivingNet_userinput() Handles cbo_LivingNet.MouseClick, cbo_LivingNet.Enter, cbo_LivingNet.KeyPress, cbo_LivingNet.KeyUp, cbo_LivingNet.KeyDown
        userimputcheck = True
    End Sub
    Private Sub cbo_bed1Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1Net.SelectedIndexChanged
        BRONET = cbo_bed1Net.Text

        If userimputcheck = True Then
            userimputcheck = False
            input_rules()
        End If
    End Sub
    Private Sub cbo_bed1Net_userinput() Handles cbo_bed1Net.MouseClick, cbo_bed1Net.Enter, cbo_bed1Net.KeyPress, cbo_bed1Net.KeyUp, cbo_bed1Net.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bed2Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2Net.SelectedIndexChanged
        BRTNET = cbo_bed2Net.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()
        End If
    End Sub
    Private Sub cbo_bed2Net_userinput() Handles cbo_bed2Net.MouseClick, cbo_bed2Net.Enter, cbo_bed2Net.KeyPress, cbo_bed2Net.KeyUp, cbo_bed2Net.KeyDown
        userimputcheck = True
    End Sub
    Private Sub cbo_kitchenTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenTV.SelectedIndexChanged
        KTV = cbo_kitchenTV.Text ' Sets the varible KTV to the value of the combo box this will be used to store in the array or can be used to check rules.
        input_rules()
    End Sub

    Private Sub cbo_kitchenSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenSAT.SelectedIndexChanged
        KSAT = cbo_kitchenSAT.Text
        input_rules()
    End Sub

    Private Sub cbo_kitchen1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen1G.SelectedIndexChanged
        K1G = cbo_kitchen1G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub
    Private Sub kitchen_1G_userinput() Handles cbo_kitchen1G.MouseClick, cbo_kitchen1G.Enter, cbo_kitchen1G.KeyPress, cbo_kitchen1G.KeyUp, cbo_kitchen1G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_kitchen2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen2G.SelectedIndexChanged
        K2G = cbo_kitchen2G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub kitchen_2G_userinput() Handles cbo_kitchen2G.MouseClick, cbo_kitchen2G.Enter, cbo_kitchen2G.KeyPress, cbo_kitchen2G.KeyUp, cbo_kitchen2G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_LivingTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingTV.SelectedIndexChanged
        LRTV = cbo_LivingTV.Text
        input_rules()
    End Sub

    Private Sub cbo_LivingSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingSAT.SelectedIndexChanged
        LRSAT = cbo_LivingSAT.Text
        input_rules()
    End Sub

    Private Sub cbo_Living1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living1G.SelectedIndexChanged
        LR1G = cbo_Living1G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()
        End If
    End Sub
    Private Sub living_1G_userinput() Handles cbo_Living1G.MouseClick, cbo_Living1G.Enter, cbo_Living1G.KeyPress, cbo_Living1G.KeyUp, cbo_Living1G.KeyDown
        userimputcheck = True
    End Sub


    Private Sub cbo_Living2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living2G.SelectedIndexChanged
        LR2G = cbo_Living2G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub living_2G_userinput() Handles cbo_Living2G.MouseClick, cbo_Living2G.Enter, cbo_Living2G.KeyPress, cbo_Living2G.KeyUp, cbo_Living2G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bath1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath1G.SelectedIndexChanged
        BATH1G = cbo_bath1G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub bath_1G_userinput() Handles cbo_bath1G.MouseClick, cbo_bath1G.Enter, cbo_bath1G.KeyPress, cbo_bath1G.KeyUp, cbo_bath1G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bath2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath2G.SelectedIndexChanged
        BATH2G = cbo_bath2G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub bath_2G_userinput() Handles cbo_bath2G.MouseClick, cbo_bath2G.Enter, cbo_bath2G.KeyPress, cbo_bath2G.KeyUp, cbo_bath2G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bed2TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2TV.SelectedIndexChanged
        BRTTV = cbo_bed2TV.Text
        input_rules()
    End Sub

    Private Sub cbo_bed2SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2SAT.SelectedIndexChanged
        BRTSAT = cbo_bed2SAT.Text
        input_rules()
    End Sub

    Private Sub cbo_bed2_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_1G.SelectedIndexChanged
        BRT1G = cbo_bed2_1G.Text

        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If

    End Sub
    Private Sub bed2_1G_userinput() Handles cbo_bed2_1G.MouseClick, cbo_bed2_1G.Enter, cbo_bed2_1G.KeyPress, cbo_bed2_1G.KeyUp, cbo_bed2_1G.KeyDown
        userimputcheck = True
    End Sub
    Private Sub cbo_bed2_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_2G.SelectedIndexChanged
        BRT2G = cbo_bed2_2G.Text

        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub bed2_2G_userinput() Handles cbo_bed2_2G.MouseClick, cbo_bed2_2G.Enter, cbo_bed2_2G.KeyPress, cbo_bed2_2G.KeyUp, cbo_bed2_2G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bed1TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1TV.SelectedIndexChanged
        BROTV = cbo_bed1TV.Text
        input_rules()
    End Sub

    Private Sub cbo_bed1SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1SAT.SelectedIndexChanged
        BROSAT = cbo_bed1SAT.Text
        input_rules()
    End Sub

    Private Sub cbo_bed1_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_1G.SelectedIndexChanged
        BRO1G = cbo_bed1_1G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub bed1_1G_userinput() Handles cbo_bed1_1G.MouseClick, cbo_bed1_1G.Enter, cbo_bed1_1G.KeyPress, cbo_bed1_1G.KeyUp, cbo_bed1_1G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub cbo_bed1_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_2G.SelectedIndexChanged
        BRO2G = cbo_bed1_2G.Text
        If userimputcheck = True Then
            userimputcheck = False
            input_rules()

        End If
    End Sub

    Private Sub bed1_2G_userinput() Handles cbo_bed1_2G.MouseClick, cbo_bed1_2G.Enter, cbo_bed1_2G.KeyPress, cbo_bed1_2G.KeyUp, cbo_bed1_2G.KeyDown
        userimputcheck = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class