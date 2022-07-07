Public Class frm_OrderDetails
    Dim KTV As Integer = 0 : Dim KSAT As Integer = 0 : Dim KNET As Integer = 0 : Dim K1G As Integer = 0 : Dim K2G As Integer = 0 : Dim Kupgrade As Integer = 0 : Dim BROTV As Integer = 0 : Dim BROSAT As Integer = 0
    Dim BRONET As Integer = 0 : Dim BRO1G As Integer = 0 : Dim BRO2G As Integer = 0 : Dim BROHeatPump As Integer = 0 : Dim BRTTV As Integer = 0 : Dim BRTSAT As Integer = 0 : Dim BRTNET As Integer = 0 : Dim BRT1G As Integer = 0
    Dim BRT2G As Integer = 0 : Dim BRTHeatPump As Integer = 0 : Dim LRTV As Integer = 0 : Dim LRSAT As Integer = 0 : Dim LRNET As Integer = 0 : Dim LR1G As Integer = 0 : Dim LR2G As Integer = 0 : Dim LRHeatPump As Integer = 0
    Dim BATH1G As Integer = 0 : Dim BATH2G As Integer = 0 : Dim BATHUpgrades As Integer = 0 : Dim KitchenA As Boolean = False : Dim KitchenB As Boolean = False : Dim KitchenC As Boolean = False : Dim LRHeat As Boolean = False
    Dim BROHeat As Boolean = False : Dim BATHOption As Boolean = False : Dim BRTHeat As Boolean = False : Dim Kitchenupgradevalue As Integer : Dim kitchennetworkvalue As Integer = 0 : Dim kitchen1gvalue As Integer : Dim kitchen2gvalue As Integer
    Dim kitchenTVvalue As Integer : Dim kitchenSATvalue As Integer : Dim networkvalue As Integer : Dim livingTVvalue As Integer = 0 : Dim livingSATvalue As Integer = 0 : Dim livingnetworkvalue As Integer = 0 : Dim living1gvalue As Integer = 0
    Dim living2gvalue As Integer = 0 : Dim livingheatpumpvalue As Integer : Dim bedroomtwoTVvalue As Integer : Dim bedroomtwoSATvalue As Integer : Dim bedroomtwonetworkvalue As Integer : Dim bedroomtwo1gvalue As Integer
    Dim bedroomtwo2gvalue As Integer : Dim bedroomtwoheatpumpvalue As Integer : Dim bedroomoneTVvalue As Integer : Dim bedroomoneSATvalue As Integer : Dim bedroomonenetworkvalue As Integer : Dim bedroomone1gvalue As Integer
    Dim bedroomone2gvalue As Integer : Dim bedroomoneheatpumpvalue As Integer : Dim BathUpgradevalue As Integer : Dim Bath1gvalue As Integer : Dim Bath2gvalue As Integer : Dim netpointcheck As Integer : Dim tvpointdefult As Boolean = True
    Dim satpointdefult As Boolean = True : Dim userimputcheck As Boolean = False : Dim start_zerio As Boolean = False
    Private Sub frm_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDetails.Hide()
    End Sub
    Private Sub priceing_math()
        If Kitchen(2) > 0 Then kitchennetworkvalue = (Kitchen(2) * Form4.NETWORK_POINT) + Form4.NETWORK_SWITCH ' checks how many kitchen network points are selected if there are more then zero it time the amout of outlets by the price then adds 100 fro the switch
        kitchencost(2) = kitchennetworkvalue ' this sets the cost array as the networkworkvalue varible which is the cost of the kitchen network
        kitchen1gvalue = Kitchen(3) * Form4.ONEGSOCKET ' This times the amount of sockets the user has selected by the cost of one socket.
        kitchencost(3) = kitchen1gvalue ' this sets the cost array as the value worked out above.   
        kitchen2gvalue = Kitchen(4) * Form4.TWOGSOCKET ' Times the amount of selected 2g sockets selected in the kitchen with the price of twog socket
        kitchencost(4) = kitchen2gvalue ' this sets the cost array as the value of the 2g sockets worked out above
        Select Case Kitchen(5) ' This gives the case fucntion what value to look for the array stores the values 0 ,1,2 or 3 this corresponds to the kitchen option selected
            Case 0 ' if the kitchen array kitchen(5) is holding the value 0 run the next line
                Kitchenupgradevalue = 0 ' this sets the cost of the kitchen upgrade to 0 as no upgrade was selected
            Case 1 ' if the kitchen array kitchen(5) is holding the value 1 representing kitchen option A it will run the next line of code
                Kitchenupgradevalue = Form4.KITCHENOPTIONA ' this sets the cost varible as the cost of Kitchen Option A
            Case 2 ' if the kitchen array kitchen(5) is holding the value 2 representing kitchen option B it will run the next line of code
                Kitchenupgradevalue = Form4.KITCHENOPTIONB ' this sets the cost varible as the cost of Kitchen Option B
            Case 3 ' if the kitchen array kitchen(5) is holding the value 3 representing kitchen option C it will run the next line of code
                Kitchenupgradevalue = Form4.KITCHENOPTIONC ' this sets the cost varible as the cost of Kitchen Option C
        End Select ' this tells the program that the case function is over.
        kitchencost(5) = Kitchenupgradevalue ' this sets the cost array to be equal to the value of the kitchen upgrade set above in the case function it is used in the quote to display the value
        kitchenTVvalue = KTV * Form4.TV_AERIAL_POINT ' this sets the value varible of the to the amount of kitchen Tv points selected times by the cost of a tv aerial point.
        kitchencost(0) = kitchenTVvalue ' this sets the cost array value to the cost of the tv aerial point based on how many the user selected this is used on form 3 in the quote display
        kitchenSATvalue = KSAT * Form4.TV_SAT_POINT ' this set the cost varible value to the amount of User selected sat points times by the value of the Tv sat points 
        kitchencost(1) = kitchenSATvalue 'this sets cost array equal to the value set above and is used to display on the quote.
        livingTVvalue = LivingRoom(0) * Form4.TV_AERIAL ' this sets the LivingTVvalue equal to the price of tv aerial points and the amount of points selected in the living room
        livingSATvalue = LivingRoom(1) * Form4.TV_SAT ' this sets the value of the LivingSATvalue to be equal to the amount of user selected Sat points times by the price of sat points 
        livingnetworkvalue = LivingRoom(2) * Form4.NETWORK_POINT ' this sets the price of the living network value to the amount of network points selected in the living room and the price of network points
        living1gvalue = LivingRoom(3) * Form4.ONEGSOCKET ' Sets the value of living1gvalue to the amount of 1 gang sockets selected times by the price of a One G socket.
        living2gvalue = LivingRoom(4) * Form4.TWOGSOCKET ' sets the value of living2gvalue to the amount of 2 gang sockets selected times by the price of a two Gang socket.
        livingheatpumpvalue = LivingRoom(5) * Form4.HEATPUMP2 ' sets the value of the livingheatpumpvalue ot the amount of heat pumps selected this being 1 or 0 then times it by the price of 4.5 KW heat pump
        Bath1gvalue = BathRoom(0) * Form4.ONEGSOCKET ' sets the value of Bath1gvalue equal to the amount of one gang sockets in the bathroom times by the price of a one gang socket
        Bath2gvalue = BathRoom(1) * Form4.TWOGSOCKET ' sets the value of the Bath2gvalue equald to the amount of two gang sockets in the bathroom times by the pice of a two gang socket.
        BathUpgradevalue = BathRoom(2) * Form4.BATHUPGRADE ' Sets the value of the bathupgradevalue equal to value in the bathroom(2) array this is either 0 or 1 then times the array value by the price of the bathroom upgrade
        bedroomtwoTVvalue = BedRoomOne(0) * Form4.TV_AERIAL_POINT '  Sets the value of the bedroomtwoTVvalue the amount of tv points selected in the bedroom two times by the price of a tv aerial point.
        bedroomtwonetworkvalue = BedRoomTwo(2) * Form4.NETWORK_POINT '  Sets the value of the bedroomtwonetworkvalue the amount of network points selected in the bedroom two times by the price of a network point.
        bedroomtwo1gvalue = BedRoomTwo(3) * Form4.ONEGSOCKET ' this sets the value of bedroom1gvalue equal to the amount of 1g sockets selected in the bedroomtwo by the cost of a one gang socket.
        bedroomtwo2gvalue = BedRoomTwo(4) * Form4.TWOGSOCKET ' this sets the value of bedroom2gvalue equal to the amount of 2g sockets selected in the bedroomtwo by the cost of a two gang socket.
        bedroomoneTVvalue = BedRoomOne(0) * Form4.TV_AERIAL_POINT '  Sets the value of the bedroomoneTVvalue the amount of tv points selected in the bedroom one times by the price of a tv aerial point.
        bedroomoneSATvalue = BedRoomOne(1) * Form4.TV_SAT_POINT ' this sets the value of the bedroomSATvalue varible to the amount of sat points selected times by the cost of sat points.
        bedroomonenetworkvalue = BedRoomOne(2) * Form4.NETWORK_POINT ' this sets the value of bedroomonenetworkvalue equal to the amount of network points selected in bedroom ones times by tha cost of a network point
        bedroomone1gvalue = BedRoomOne(3) * Form4.ONEGSOCKET ' this sets the value of bedroom1gvalue equal to the amount of 1 gang sockets times by the cost of a one gang socket
        bedroomone2gvalue = BedRoomOne(4) * Form4.TWOGSOCKET ' this sets the value of bedroom2gvalue equal to the amount of 2 gang sockets times by the cost of a two gang socket
        bedroomoneheatpumpvalue = BedRoomOne(5) * Form4.HEATPUMP1 ' this sets the cost of bedroomoneheatpumpvalue to the amount the value stored in the BedRoomOne(5) array that will be 0 or 1 then times the the cost of a heat pump by that value
        totalvalue(1) = kitchennetworkvalue + kitchen1gvalue + kitchen2gvalue + Kitchenupgradevalue + kitchenTVvalue + kitchenSATvalue ' this adds and saves the  Total Kitchen COST
        totalvalue(2) = livingheatpumpvalue + livingnetworkvalue + living2gvalue + living1gvalue + livingTVvalue + livingSATvalue '  this adds and saves the Total Living Room COST
        totalvalue(3) = bedroomoneheatpumpvalue + bedroomonenetworkvalue + bedroomone1gvalue + bedroomone2gvalue + bedroomoneTVvalue + bedroomoneSATvalue 'this adds and saves the Total Bedroom One cost
        totalvalue(4) = bedroomtwoheatpumpvalue + bedroomtwonetworkvalue + bedroomtwo1gvalue + bedroomtwo2gvalue + bedroomtwoTVvalue + bedroomtwoSATvalue 'this adds and saves the Total Bedroom Two Cost
        totalvalue(5) = Bath1gvalue + Bath2gvalue + BathUpgradevalue 'this adds and saves the Total Bath Room Cost
        totalvalue(0) = totalvalue(1) + totalvalue(2) + totalvalue(3) + totalvalue(4) + totalvalue(5) 'this gets all the values added and saved above and saves it into the array.
        lbl_kitch_cost.Text = $" Kitchen Cost {totalvalue(1).ToString("C")}" ' this gets the value stored in totalvalue(1) then converts it to a string and sets the labels text value to the string to display
        lbl_living_cost.Text = $" Living Room Cost {totalvalue(2).ToString("C")}" ' this gets the value stored in totalvalue(2) then converts it to a string and sets the labels text value to the string to display
        lbl_bedroom_two_cost.Text = $" Bed Room Two Cost {totalvalue(4).ToString("C")}" ' this gets the value stored in totalvalue(3) then converts it to a string and sets the labels text value to the string to display
        lbl_bedroom_one.Text = $" Bed Room One Cost {totalvalue(3).ToString("C")}" ' this gets the value stored in totalvalue(4) then converts it to a string and sets the labels text value to the string to display
        lbl_bathroom_cost.Text = $" Bath Room Cost {totalvalue(5).ToString("C")}" ' this gets the value stored in totalvalue(5) then converts it to a string and sets the labels text value to the string to display
        lbl_totaldisplay.Text = $" Total Options Cost {totalvalue(0).ToString("C")} (+GST)" ' this gets the value stored in totalvalue(0) then converts it to a string and sets the labels text value to the string to display
        Dim bedroomonelist As New List(Of Integer) From {bedroomoneTVvalue, bedroomoneSATvalue, bedroomonenetworkvalue, bedroomone1gvalue, bedroomone2gvalue, bedroomoneheatpumpvalue} '
        Dim counter As Integer = -1
        For Each value In bedroomonelist
            counter = counter + 1
            BedRoomOneCost(0) = value
        Next
        Dim bedroomtwolist As New List(Of Integer) From {bedroomtwoTVvalue, bedroomtwoSATvalue, bedroomtwonetworkvalue, bedroomtwo1gvalue, bedroomtwo2gvalue, bedroomtwoheatpumpvalue}
        counter = -1
        For Each value As String In bedroomtwolist
            counter = counter + 1
            BedRoomTwoCost(0) = value
        Next
        BathRoomCost(0) = Bath1gvalue ' this stores the value done by the math into an array to be used in the next form
        BathRoomCost(1) = Bath2gvalue ' this stores the value done by the math into an array to be used in the next form
        BathRoomCost(2) = BathUpgradevalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(0) = livingTVvalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(1) = livingSATvalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(2) = livingnetworkvalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(3) = living1gvalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(4) = living2gvalue ' this stores the value done by the math into an array to be used in the next form
        LivingRoomCost(5) = livingheatpumpvalue ' this stores the value done by the math into an array to be used in the next form
        lbl_kitch_cost.Show() ' this shows the string displaying the cost of the upgrades room
        lbl_living_cost.Show() ' this shows the string displaying the cost of the upgrades room
        lbl_bedroom_two_cost.Show() ' this shows the string displaying the cost of the upgrades room
        lbl_bedroom_one.Show() ' this shows the string displaying the cost of the upgrades room
        lbl_bathroom_cost.Show() ' this shows the string displaying the cost of the upgrades room
        lbl_totaldisplay.Show() ' this shows the string displaying the cost of the upgrades room
    End Sub
    Private Sub value_store()
        ' This Stores the values into an array so I can access this infomation easily on other forms and save this infomation to text files.
        Kitchen(0) = KTV ' this stores the user input of kitchen tv points into an array
        Kitchen(1) = KSAT ' this stores the user input of kitchen Sat points into an array
        Kitchen(2) = KNET ' this stores the user input of kitchen net points into an array
        Kitchen(3) = K1G ' this stores the user input of kitchen 1 gang points into an array
        Kitchen(4) = K2G ' this stores the user input of kitchen 2 gang points into an array
        Kitchen(5) = Kupgrade ' this stores the user input of the selected kitchen upgrade into an array
        BedRoomOne(0) = BROTV ' this stores the user input of Bed room one tv points into an array
        BedRoomOne(1) = BROSAT ' this stores the user input of Bed room one Sat points into an array
        BedRoomOne(2) = BRONET ' this stores the user input of Bed room one Net points into an array
        BedRoomOne(3) = BRO1G ' this stores the user input of Bed room one 1 gang points into an array
        BedRoomOne(4) = BRO2G ' this stores the user input of Bed room one 2 gang points into an array
        BedRoomOne(5) = BROHeatPump ' this stores the user input of if a heatpump is selected into an array
        BedRoomTwo(0) = BRTTV ' this stores the user input of Bed room two tv points into an array
        BedRoomTwo(1) = BRTSAT  ' this stores the user input of Bed room two Sat points into an array
        BedRoomTwo(2) = BRTNET ' this stores the user input of Bed room two net points into an array
        BedRoomTwo(3) = BRT1G ' this stores the user input of Bed room two 1 gang points into an array
        BedRoomTwo(4) = BRT2G ' this stores the user input of Bed room two 2 gang points into an array
        BedRoomTwo(5) = BRTHeatPump ' this stores the user input of if a heatpump is selected into an array
        LivingRoom(0) = LRTV ' this stores the user input of Livingroom tv points into an array
        LivingRoom(1) = LRSAT  ' this stores the user input of Livingroom Sat points into an array
        LivingRoom(2) = LRNET ' this stores the user input of Livingroom net points into an array
        LivingRoom(3) = LR1G ' this stores the user input of Livingroom 1 gang points into an array
        LivingRoom(4) = LR2G ' this stores the user input of Livingroom 2 gang points into an array
        LivingRoom(5) = LRHeatPump ' this stores the user input of if a heatpump is selected into an array
        BathRoom(0) = BATH1G ' this stores the user input of bathroom 1 gang points into an array
        BathRoom(1) = BATH2G ' this stores the user input of bathroom 2 gang points into an array
        BathRoom(2) = BATHUpgrades ' this stores the user input of if a upgrade is selected in the bath room into an array
    End Sub
    Private Sub startingzero()
        cbo_kitchenSAT.Text = KSAT ' sets the text equal to 0
        cbo_kitchenTV.Text = KTV ' sets the text equal to 0
        cbo_LivingTV.Text = LRTV ' sets the text equal to 0
        cbo_LivingSAT.Text = LRSAT ' sets the text equal to 0
        cbo_bed1SAT.Text = BROSAT ' sets the text equal to 0
        cbo_bed1TV.Text = BROTV ' sets the text equal to 0
        cbo_bed2SAT.Text = BRTSAT ' sets the text equal to 0
        cbo_bed2TV.Text = BRTTV ' sets the text equal to 0
        start_zerio = True ' sets the varible to true so it doesn't run and reset the values to 0 
    End Sub
    Private Sub input_rules()
        ' This Sub is called when the Network Boxes are changed this forces the network points to never be able to go over the limit of 4 in a room or 8 in total. And Rules related to the 1G and 2G limits
        If start_zerio = False Then startingzero() ' this runs onces and sets the text to 0 for all the points that have not been changed.
        Dim netpointcheck As Integer : Dim swtichpoints As Integer : Dim kitchendefult As Boolean = True : Dim tvpointcheck As Integer : Dim satpointcheck As Integer : Dim socketscheck As Integer
        Dim remainingsocket As Integer = 12 : Dim remainingpoints As Integer = 8 : Dim BROList As Integer : Dim BRTList As Integer : Dim LRList As Integer : Dim KitList As Integer : Dim BROListsocket_2G As Integer
        Dim BROListsocket_1G As Integer : Dim BRTListsocket_2G As Integer : Dim BRTListsocket_1G As Integer : Dim LRListsocket_2G As Integer : Dim LRListsocket_1G As Integer : Dim KitListsocket_2G As Integer
        Dim KitListsocket_1G As Integer : Dim BathListScoket_1G As Integer : Dim BathListSocket_2G As Integer
        socketscheck = K1G + K2G + LR1G + LR2G + BATH1G + BATH2G + BRT1G + BRT2G + BRO1G + BRO2G ' This checks the amount of Sockets in toal we can only have 12 and total 4 per room
        swtichpoints = BRONET + BRTNET + LRNET ' This is used to check if one point is in the kitchen where the router is there needs to be one point from the router to the switch
        netpointcheck = KNET + BRONET + BRTNET + LRNET ' This Adds the SUM of all the current network points
        remainingpoints = 8 - netpointcheck ' this removes all the current points from 8 this then displays the remaining points we have acess to.
        remainingsocket = 12 - socketscheck
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
                KNET = 1 ' sets KNET varible to one so the system knows that the kitchen network should ahve one point.
                cbo_kitchenNet.Text = 1 ' this adds the one to the kitchen
                cbo_kitchenNet.Items.Remove("0") ' this removes the 0 option while more then one switch point is selected stopping the user from picking zero.
                kitchendefult = False ' this is to confirm its state
            End If
        End If

        'Checks if a Tv Point is slected and then forces one into the living room.
        If tvpointcheck > 0 Then ' if there is a tv point selected runs the following code
            If LRTV = 0 Then ' this checks if there is a point in the living room where the aerial roof mount has to be selected with a tv point
                LRTV = 1 ' this sets the tv aerial points to one in the living room when a point is selected in any other room
                cbo_LivingTV.Text = 1 ' this sets the text to match the vairble above so it displays to the user the correct value.
                cbo_LivingTV.Items.Remove("0") ' this remove the option 0 so the user cannot select more points
                tvpointdefult = False ' this tells the program that it is not in its defult state and is missing the 0 option this is needed so there are not alot of zeros or no zeros when some are wanted.
            End If
        End If
        If tvpointcheck = 0 And tvpointdefult = False Then ' this checks if there are any tv points selected and if it is in its defult state if it is it can contiune this stops if from adding lots of 0s
            cbo_LivingTV.Items.Add("0") ' because there were 0 tv points and it was not in its defult state it adds a 0
            tvpointdefult = True ' this sets it to the defult state because it has the zero option for the user to select.
        End If

        ' Checks if there is a SAT point in all rooms but Living room and forces one into the living room.
        If satpointcheck > 0 Then ' Checks if there is a Sat Point in the other rooms
            If LRSAT = 0 Then ' Checks if there is no option selected in the Living room for a SAT point
                LRSAT = 1 ' Sets the Value we complare and store to 1
                cbo_LivingSAT.Text = 1 ' Sets the text to 1 displaying they have one SAT point 
                cbo_LivingSAT.Items.Remove("0") ' Removes the 0 option from the living room if they have a SAT point in another room
                satpointdefult = False ' this sets the defult state to false telling the program that the user option 0 is not avalible. 
            End If
        End If
        If satpointcheck = 0 And satpointdefult = False Then ' this checks if there are 0 Sat points selected and that it is not in defult state to stop the program from adding more then one 0 option.
            cbo_LivingSAT.Items.Add("0") ' Adds 0 to the list when all other rooms have no SAT point and allows the user to select 0 points in livingroom
            satpointdefult = True ' This sets the varible so the program knows its in the defult state of having one zero.
        End If

        ' Bed Room One
        cbo_bed1Net.Items.Clear() ' This removes all the items from the combo box so starts empty 
        If remainingpoints < 5 Then BROList = remainingpoints + BRONET Else BROList = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BROList > 4 Then BROList = 4 ' in line 195 it can makes BROList more then 4. so if it does this makes it = 4 this stops the user for access more points I encounted this error though testing
        Do Until BROList = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed1Net.Items.Add(BROList) ' adds the numbers to the "collection" so the user can only select the avaible points so they cannot go over the limit
            BROList = BROList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed1Net.Text = BRONET ' this updates the text back to what the user selected because when the combo box is cleared it removes the user inputted value.

        ' Bed Room One (2G) Socket Check
        cbo_bed1_2G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BROListsocket_2G = remainingsocket + BRO2G Else BROListsocket_2G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BROListsocket_2G > 4 Then BROListsocket_2G = 4 ' BROList more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BROListsocket_2G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed1_2G.Items.Add(BROListsocket_2G) ' adds the numbers to the "collection" so the user can only select the avaible points so they cannot go over the limit
            BROListsocket_2G = BROListsocket_2G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed1_2G.Text = BRO2G ' this updates the text back to what the user selected because when the combo box is cleared it removes the user inputted value.

        ' Bed Room One (1G) Socket Check
        cbo_bed1_1G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BROListsocket_1G = remainingsocket + BRO1G Else BROListsocket_1G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points  
        If BROListsocket_1G > 4 Then BROListsocket_1G = 4 ' BROListsocket_1G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BROListsocket_1G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed1_1G.Items.Add(BROListsocket_1G)  ' Adds the amount of avaible points to the combobox
            BROListsocket_1G = BROListsocket_1G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed1_1G.Text = BRO1G

        ' Bed Room Two
        cbo_bed2Net.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingpoints < 5 Then BRTList = remainingpoints + BRTNET Else BRTList = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BRTList > 4 Then BRTList = 4 ' BRTList more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BRTList = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed2Net.Items.Add(BRTList)  ' Adds the amount of avaible points to the combobox
            BRTList = BRTList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed2Net.Text = BRTNET

        ' Bed Room 2 (2G) Socket Check
        cbo_bed2_2G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BRTListsocket_2G = remainingsocket + BRT2G Else BRTListsocket_2G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BRTListsocket_2G > 4 Then BRTListsocket_2G = 4 ' BRTListsocket_2G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BRTListsocket_2G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed2_2G.Items.Add(BRTListsocket_2G)  ' Adds the amount of avaible points to the combobox 
            BRTListsocket_2G = BRTListsocket_2G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed2_2G.Text = BRT2G

        ' Bed Room 2 (1G) Socket Check
        cbo_bed2_1G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BRTListsocket_1G = remainingsocket + BRT1G Else BRTListsocket_1G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BRTListsocket_1G > 4 Then BRTListsocket_1G = 4 ' BRTListsocket_1G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BRTListsocket_1G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bed2_1G.Items.Add(BRTListsocket_1G)  ' Adds the amount of avaible points to the combobox 
            BRTListsocket_1G = BRTListsocket_1G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bed2_1G.Text = BRT1G

        '  Living Room
        cbo_LivingNet.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingpoints < 5 Then LRList = remainingpoints + LRNET Else LRList = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If LRList > 4 Then LRList = 4 ' LRList more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until LRList = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_LivingNet.Items.Add(LRList)  ' Adds the amount of avaible points to the combobox
            LRList = LRList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_LivingNet.Text = LRNET

        ' Living Room (2G) Socket Check
        cbo_Living2G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then LRListsocket_2G = remainingsocket + LR2G Else LRListsocket_2G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If LRListsocket_2G > 4 Then LRListsocket_2G = 4 ' LRListsocket_2G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until LRListsocket_2G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_Living2G.Items.Add(LRListsocket_2G)  ' Adds the amount of avaible points to the combobox
            LRListsocket_2G = LRListsocket_2G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_Living2G.Text = LR2G

        ' Living Room 2 (1G) Socket Check
        cbo_Living1G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then LRListsocket_1G = remainingsocket + LR1G Else LRListsocket_1G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If LRListsocket_1G > 4 Then LRListsocket_1G = 4 ' LRListsocket_1G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until LRListsocket_1G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_Living1G.Items.Add(LRListsocket_1G)  ' Adds the amount of avaible points to the combobox
            LRListsocket_1G = LRListsocket_1G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_Living1G.Text = LR1G

        ' kitchen
        cbo_kitchenNet.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingpoints < 5 Then KitList = remainingpoints + KNET Else KitList = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If KitList > 4 Then KitList = 4 ' KitList more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Dim zerovalue As Integer ' vairble used to see if they can go below zero or must stop at one
        If kitchendefult = False Then zerovalue = 0 Else zerovalue = -1 ' this stops at 0 or 1 depeneding on if a net point is slected in another room
        Do Until KitList = zerovalue
            cbo_kitchenNet.Items.Add(KitList)  ' Adds the amount of avaible points to the combobox
            KitList = KitList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_kitchenNet.Text = KNET

        ' Kitchen 2 (2G) Socket Check
        cbo_kitchen2G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then KitListsocket_2G = remainingsocket + K2G Else KitListsocket_2G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If KitListsocket_2G > 4 Then KitListsocket_2G = 4 ' KitListsocket_2G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until KitListsocket_2G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_kitchen2G.Items.Add(KitListsocket_2G) ' Adds the amount of avaible points to the combobox
            KitListsocket_2G = KitListsocket_2G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_kitchen2G.Text = K2G

        ' Kitchen (1G) Socket Check
        cbo_kitchen1G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then KitListsocket_1G = remainingsocket + K1G Else KitListsocket_1G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If KitListsocket_1G > 4 Then KitListsocket_1G = 4 ' KitListsocket_1G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until KitListsocket_1G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_kitchen1G.Items.Add(KitListsocket_1G)  ' Adds the amount of avaible points to the combobox
            KitListsocket_1G = KitListsocket_1G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_kitchen1G.Text = K1G

        ' Bath Room One 2 (2G) Socket Check
        cbo_bath2G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BathListSocket_2G = remainingsocket + BATH2G Else BathListSocket_2G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BathListSocket_2G > 4 Then BathListSocket_2G = 4 ' BathListSocket_2G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BathListSocket_2G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bath2G.Items.Add(BathListSocket_2G)  ' Adds the amount of avaible points to the combobox
            BathListSocket_2G = BathListSocket_2G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bath2G.Text = BATH2G

        ' Bath Room One (1G) Socket Check
        cbo_bath1G.Items.Clear() ' This removes all the items from the combo box so starts empty
        If remainingsocket < 5 Then BathListScoket_1G = remainingsocket + BATH1G Else BathListScoket_1G = 4 ' checks if there are more then 5 points remaing if there are then sets the value to 4 else it sets it to the remaining points + the current selected points 
        If BathListScoket_1G > 4 Then BathListScoket_1G = 4 ' BathListScoket_1G more be more then 4. so if it does this makes it = 4 this stops the user for access more points 
        Do Until BathListScoket_1G = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
            cbo_bath1G.Items.Add(BathListScoket_1G) ' Adds the amount of avaible points to the combobox
            BathListScoket_1G = BathListScoket_1G - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
        Loop
        cbo_bath1G.Text = BATH1G

        value_store() ' calls the sub value_store to save the current values selected by the user must call before the priceing_math
        priceing_math() ' this uses the values from value_store to do some math to work out the cost.
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
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub chk_KitchenB_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenB.CheckedChanged
        If KitchenB = False Then ' This checks if the box is currently ticked if it is false it is not ticked to it runs the next statment
            If KitchenA Or KitchenC = True Then ' This looks if Kitchen option A or option C have been selected if it has one of then will be = to true
                chk_KitchenA.Checked = False ' if option A or C has been selected this unticks there box
                chk_KitchenC.Checked = False ' same as above
                KitchenA = False ' This sets the KitchenA varible to false this varible is used to check if they have been selected
                KitchenC = False ' This sets the KitchenC varible to false this varible is used to check if they have been selected
            End If
            KitchenB = True ' This makes Option A set to True so we know it is selected
            Kupgrade = 2 ' 2 is used to show no option has been selected and the user wants an upgrade 
        Else
            KitchenB = False ' This Sets the selected option to false because the user unselected this option
            Kupgrade = 0 ' 0 is used to show no option has been selected and the user does not want a kitchen Upgrade.
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub chk_KitchenC_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenC.CheckedChanged
        If KitchenC = False Then ' This checks if the box is currently ticked if it is false it is not ticked to it runs the next statment
            If KitchenA Or KitchenB = True Then ' This looks if Kitchen option A or option B have been selected if it has one of then will be = to true
                chk_KitchenA.Checked = False ' if option B or A has been selected this unticks there box
                chk_KitchenB.Checked = False ' same as above
                KitchenA = False ' This sets the KitchenA varible to false this varible is used to check if they have been selected
                KitchenB = False ' This sets the KitchenB varible to false this varible is used to check if they have been selected
            End If
            KitchenC = True ' This makes Option A set to True so we know it is selected
            Kupgrade = 3 ' 2 is used to show no option has been selected and the user wants an upgrade 
        Else
            KitchenB = False ' This Sets the selected option to false because the user unselected this option
            Kupgrade = 0 ' 0 is used to show no option has been selected and the user does not want a kitchen Upgrade.
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub chk_HeatPumpLiving_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpLiving.CheckedChanged
        If LRHeatPump = 0 Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            LRHeatPump = 1 ' Sets the Value to One meaning the user would like a heatpump in there living room
        Else
            LRHeatPump = 0 ' Sets the Value to One meaning the user would not like a heatpump in there living room
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub chk_HeatPumpBedOne_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedOne.CheckedChanged
        If BROHeatPump = 0 Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            BROHeatPump = 1 ' Sets the Value to One meaning the user would like a heatpump in there bedroom one
        Else
            BROHeatPump = 0 ' Sets the Value to One meaning the user would not like a heatpump in there  bedroom one
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub chk_HeatPumpBedTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedTwo.CheckedChanged
        If BRTHeatPump = 0 Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            BRTHeatPump = 1 ' Sets the Value to One meaning the user would like a heatpump in there Bedroom two
        Else
            BRTHeatPump = 0 ' Sets the Value to One meaning the user would not like a heatpump in there Bedroom two
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub chk_HeatPumpBathRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_UpgradeBathRoom.CheckedChanged
        If BATHUpgrades = 0 Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            BATHUpgrades = 1 ' Sets the Value to One meaning the user would like a heatpump in there  Bath room
        Else
            BATHUpgrades = 0 ' Sets the Value to One meaning the user would not like a heatpump in there Bath room
        End If
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_kitchenNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenNet.SelectedIndexChanged
        KNET = cbo_kitchenNet.Text ' This sets the value KNET to the value of the combo box
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules() ' This calls the sub Imput_Rules this sub is used to check and stop the user from having too many network points and limits it. This Doesn't give the user access to have more then the maxium so they cannot make a mistake and selected more then allowed.
        End If
    End Sub
    Private Sub kitchen_net_userinput() Handles cbo_kitchenNet.MouseClick, cbo_kitchenNet.Enter, cbo_kitchenNet.KeyPress, cbo_kitchenNet.KeyUp, cbo_kitchenNet.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_LivingNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingNet.SelectedIndexChanged
        LRNET = cbo_LivingNet.Text
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub cbo_LivingNet_userinput() Handles cbo_LivingNet.MouseClick, cbo_LivingNet.Enter, cbo_LivingNet.KeyPress, cbo_LivingNet.KeyUp, cbo_LivingNet.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bed1Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1Net.SelectedIndexChanged
        BRONET = cbo_bed1Net.Text
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub cbo_bed1Net_userinput() Handles cbo_bed1Net.MouseClick, cbo_bed1Net.Enter, cbo_bed1Net.KeyPress, cbo_bed1Net.KeyUp, cbo_bed1Net.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bed2Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2Net.SelectedIndexChanged
        BRTNET = cbo_bed2Net.Text
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub cbo_bed2Net_userinput() Handles cbo_bed2Net.MouseClick, cbo_bed2Net.Enter, cbo_bed2Net.KeyPress, cbo_bed2Net.KeyUp, cbo_bed2Net.KeyDown
        userimputcheck = True
    End Sub
    Private Sub cbo_kitchenTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenTV.SelectedIndexChanged
        KTV = cbo_kitchenTV.Text ' Sets the varible KTV to the value of the combo box this will be used to store in the array or can be used to check rules.
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub cbo_kitchenSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenSAT.SelectedIndexChanged
        KSAT = cbo_kitchenSAT.Text
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_kitchen1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen1G.SelectedIndexChanged
        K1G = cbo_kitchen1G.Text
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub kitchen_1G_userinput() Handles cbo_kitchen1G.MouseClick, cbo_kitchen1G.Enter, cbo_kitchen1G.KeyPress, cbo_kitchen1G.KeyUp, cbo_kitchen1G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_kitchen2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen2G.SelectedIndexChanged
        K2G = cbo_kitchen2G.Text
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub kitchen_2G_userinput() Handles cbo_kitchen2G.MouseClick, cbo_kitchen2G.Enter, cbo_kitchen2G.KeyPress, cbo_kitchen2G.KeyUp, cbo_kitchen2G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_LivingTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingTV.SelectedIndexChanged
        LRTV = cbo_LivingTV.Text
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_LivingSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingSAT.SelectedIndexChanged
        LRSAT = cbo_LivingSAT.Text
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_Living1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living1G.SelectedIndexChanged
        LR1G = cbo_Living1G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub living_1G_userinput() Handles cbo_Living1G.MouseClick, cbo_Living1G.Enter, cbo_Living1G.KeyPress, cbo_Living1G.KeyUp, cbo_Living1G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_Living2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living2G.SelectedIndexChanged
        LR2G = cbo_Living2G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub living_2G_userinput() Handles cbo_Living2G.MouseClick, cbo_Living2G.Enter, cbo_Living2G.KeyPress, cbo_Living2G.KeyUp, cbo_Living2G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bath1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath1G.SelectedIndexChanged
        BATH1G = cbo_bath1G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub bath_1G_userinput() Handles cbo_bath1G.MouseClick, cbo_bath1G.Enter, cbo_bath1G.KeyPress, cbo_bath1G.KeyUp, cbo_bath1G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bath2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath2G.SelectedIndexChanged
        BATH2G = cbo_bath2G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub bath_2G_userinput() Handles cbo_bath2G.MouseClick, cbo_bath2G.Enter, cbo_bath2G.KeyPress, cbo_bath2G.KeyUp, cbo_bath2G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bed2TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2TV.SelectedIndexChanged
        BRTTV = cbo_bed2TV.Text ' this updates the BRTTV varible when the amount of tv points in bed room two are updated.
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_bed2SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2SAT.SelectedIndexChanged
        BRTSAT = cbo_bed2SAT.Text 'Updates the varible BRTSAT when the amount of SAT points in bed room 2 are changed
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_bed2_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_1G.SelectedIndexChanged
        BRT1G = cbo_bed2_1G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
        End If
    End Sub
    Private Sub bed2_1G_userinput() Handles cbo_bed2_1G.MouseClick, cbo_bed2_1G.Enter, cbo_bed2_1G.KeyPress, cbo_bed2_1G.KeyUp, cbo_bed2_1G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub cbo_bed2_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_2G.SelectedIndexChanged
        BRT2G = cbo_bed2_2G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False  ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs

        End If
    End Sub
    Private Sub bed2_2G_userinput() Handles cbo_bed2_2G.MouseClick, cbo_bed2_2G.Enter, cbo_bed2_2G.KeyPress, cbo_bed2_2G.KeyUp, cbo_bed2_2G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub

    Private Sub cbo_bed1TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1TV.SelectedIndexChanged
        BROTV = cbo_bed1TV.Text ' when the amount of tv points are changed in the bed room one this varible will be changed to the selected value
        input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub
    Private Sub cbo_bed1SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1SAT.SelectedIndexChanged
        BROSAT = cbo_bed1SAT.Text ' When the amount of sat points in bedroom1 are changed it saves its value to a varible 
        input_rules() ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs
    End Sub

    Private Sub cbo_bed1_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_1G.SelectedIndexChanged
        BRO1G = cbo_bed1_1G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input
            userimputcheck = False ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules()  ' this calls for the sub that checks if this is a vaild input and trys to disallow invaild inputs

        End If
    End Sub
    Private Sub bed1_1G_userinput() Handles cbo_bed1_1G.MouseClick, cbo_bed1_1G.Enter, cbo_bed1_1G.KeyPress, cbo_bed1_1G.KeyUp, cbo_bed1_1G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub

    Private Sub cbo_bed1_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_2G.SelectedIndexChanged
        BRO2G = cbo_bed1_2G.Text ' when the selected item is changed it calls this sub and then sets this varible to the value of the selected item in the combo box.
        If userimputcheck = True Then ' to stop the from calling input rules because the input rules updates the combobox it was cause a loop to fix it this if stament checks if there was a user input 
            userimputcheck = False ' if there was a user input it then sets it to false to stop the program looping its self
            input_rules() ' calls the input_rules sub if it is not in this if statment it will loop itself and remove the values stored.

        End If
    End Sub
    Private Sub bed1_2G_userinput() Handles cbo_bed1_2G.MouseClick, cbo_bed1_2G.Enter, cbo_bed1_2G.KeyPress, cbo_bed1_2G.KeyUp, cbo_bed1_2G.KeyDown
        userimputcheck = True ' if the mouse is clicked enter is pressed a key is pressed or the up and down arrow is clicked on the combox it will then set userinputcheck to true or else it loops its self
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CustomerDetails.Show() ' if the back arrow is clicked it shows the Prvious form
        Me.Hide() ' hide current form
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit() ' if the exit icon is clicked this exits the application and closes it.
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        value_store() ' when the next button is hit it calls this sub to store the values into an array.
        input_rules() ' this then checks if the stored values are vaild and doesn't allow the user to have an invalid input
        Dim tempnetpointcheck As Integer = KNET + BRONET + BRTNET + LRNET ' this temp vairble is used to check how many network points are selected by adding them all up
        If tempnetpointcheck = 1 Then ' if they have one is shows a message box forceing the user to select more they can have 0 or 2 + they cannot have one
            MessageBox.Show("You need more then one network point!") ' this communicates with the user the error so they can fix it though a message box.
        Else ' if the condition that tempnetpointcheck = 1 is not met it runs the two lines below
            Form3.Show() ' if they have 0 or 2 + points selected it will show the next form
            Me.Hide() ' after the next form is opened it hides my current form.
        End If
    End Sub
End Class