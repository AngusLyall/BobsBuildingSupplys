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
    Dim BATHUpgrade As Integer = 0

    Dim KitchenA As Boolean = False
    Dim KitchenB As Boolean = False
    Dim KitchenC As Boolean = False
    Dim LRHeat As Boolean = False
    Dim BROHeat As Boolean = False
    Dim BATHOption As Boolean = False
    Dim BRTHeat As Boolean = False





    Private Sub frm_OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDetails.Hide()


    End Sub
    Private Sub priceing_math()

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
        BathRoom(2) = BATHUpgrade

    End Sub

    Private Sub input_rules()
        ' This Sub is called when the Network Boxes are changed this forces the network points to never be able to go over the limit of 4 in a room or 8 in total.


        Dim netpointcheck As Integer
        Dim swtichpoints As Integer
        Dim kitchendefult As Boolean = True

        Dim remainingpoints As Integer = 8

        Dim BROList As Integer
        Dim BRTList As Integer
        Dim LRList As Integer
        Dim KitList As Integer



        swtichpoints = BRONET + BRTNET + LRNET ' This is used to check if one point is in the kitchen where the router is there needs to be one point from the router to the switch
        netpointcheck = KNET + BRONET + BRTNET + LRNET ' This Adds the SUM of all the current network points

        remainingpoints = 8 - netpointcheck ' this removes all the current points from 8 this then displays the remaining points we have acess to.



        If swtichpoints = 0 Then
            cbo_kitchenNet.Items.Add("0") ' this adds 0 to the list after it is cleared.
            kitchendefult = True ' this is used as a check to confirm its state
        End If

        If swtichpoints > 1 And KNET = 0 Then ' this checks if anyother point has a value grater then one this means a point has been selected in another form this then adds 1 to the Kitchen
            cbo_kitchenNet.Text = 1 ' this adds the one to the kitchen
            kitchendefult = False ' this is to confirm its state
        Else
            If netpointcheck = 1 Then

            End If

        End If

        ' Bed Room One
        If remainingpoints < 5 Then ' If there are less then 5 Points remaining this then forces the box to have less 4 or less points
            cbo_bed1Net.Items.Clear() ' this clears the items stored in the box
            BROList = remainingpoints + BRONET ' this adds the current amount in Bedroom 1 to the remaining points this is so its not counted so we can changed the remaining points and dont have to set this value to 0 or we can only select less values then what is avaible.
            Do Until BROList = -1 ' this loops adding the itme to the list untill the value is at -1 so it stops at 0
                cbo_bed1Net.Items.Add(BROList) ' adds the numbers to the "collection" so the user can only select the avaible points so they cannot go over the limit
                BROList = BROList - 1 ' this removes one from the loop each time because the list is counting down or the loop would just keep adding the same number
            Loop
        Else ' If there are more then 5 remaining points this forces the Box to have its maxium of 4 per room
            cbo_bed1Net.Items.Clear() ' clears the box to remove old values and stop duplicates
            BROList = 4 ' this sets the list to 4 the limit per room
            Do Until BROList = -1 ' loops the value so the list will display 0 1 2 3 4.
                cbo_bed1Net.Items.Add(BROList) ' this adds the values to the list (combo box)
                BROList = BROList - 1 ' this removes one each time so it counts down or it would just loop adding 4 endlessly so it now will do  4 then remove one then 3 then remove one ect.
            Loop
        End If

        ' Bed Room Two
        If remainingpoints < 5 Then
            cbo_bed2Net.Items.Clear()
            BRTList = remainingpoints + BRTNET
            Do Until BRTList = -1
                cbo_bed2Net.Items.Add(BRTList)
                BRTList = BRTList - 1
            Loop
        Else
            cbo_bed2Net.Items.Clear()
            BRTList = 4
            Do Until BRTList = -1
                cbo_bed2Net.Items.Add(BRTList)
                BRTList = BRTList - 1
            Loop
        End If


        '  Living Room
        If remainingpoints < 5 Then
            cbo_LivingNet.Items.Clear()
            LRList = remainingpoints + LRNET
            Do Until LRList = -1
                cbo_LivingNet.Items.Add(LRList)
                LRList = LRList - 1
            Loop
        Else
            cbo_LivingNet.Items.Clear()
            LRList = 4
            Do Until LRList = -1
                cbo_LivingNet.Items.Add(LRList)
                LRList = LRList - 1
            Loop
        End If

        ' kitchen
        If remainingpoints < 5 Then
            cbo_kitchenNet.Items.Clear()
            cbo_kitchenNet.Text = KNET
            KitList = remainingpoints + KNET
            Do Until KitList = -1
                cbo_kitchenNet.Items.Add(KitList)
                KitList = KitList - 1
            Loop
        Else
            cbo_kitchenNet.Items.Clear()
            cbo_kitchenNet.Text = KNET
            KitList = 4
            Do Until KitList = -1
                cbo_kitchenNet.Items.Add(KitList)
                KitList = KitList - 1
            Loop
        End If

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
    End Sub

    Private Sub chk_HeatPumpLiving_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpLiving.CheckedChanged
        If LRHeat = False Then ' Checks if the Option is already ticked since this is called each time the checkbox has been changed.
            LRHeat = True ' This then changes the varible to true indicating the the tick box has not been selected.
            LRHeatPump = 1 ' Sets the Value to One meaning the user would like a heatpump in there living room
        Else
            LRHeat = False ' If the Box was already ticked this then sets it to False unticking the box
            LRHeatPump = 0 ' Sets the Value to One meaning the user would not like a heatpump in there living room
        End If
    End Sub

    Private Sub chk_HeatPumpBedOne_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedOne.CheckedChanged
        If BROHeat = False Then
            BROHeat = True
            BROHeatPump = 1
        Else
            BROHeat = False
            BROHeatPump = 0
        End If
    End Sub

    Private Sub chk_HeatPumpBedTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedTwo.CheckedChanged
        If BRTHeat = False Then
            BRTHeat = True
            BRTHeatPump = 1
        Else
            BRTHeat = False
            BRTHeatPump = 0
        End If
    End Sub

    Private Sub chk_HeatPumpBathRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_UpgradeBathRoom.CheckedChanged
        If BATHOption = False Then
            BATHOption = True
            BATHUpgrade = 1
        Else
            BATHOption = False
            BATHUpgrade = 0
        End If
    End Sub

    Private Sub cbo_kitchenNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenNet.SelectedIndexChanged
        KNET = cbo_kitchenNet.Text ' This sets the value KNET to the value of the combo box
        lbl_knet.Text = KNET ' Because I'm using a combo box as a list the text cant change and because I clear the combox this label is used instaid to display the value of the combox so it cant be cleared 
        input_rules() ' This calls the sub Imput_Rules this sub is used to check and stop the user from having too many network points and limits it. This Doesn't give the user access to have more then the maxium so they cannot make a mistake and selected more then allowed.
    End Sub

    Private Sub cbo_LivingNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingNet.SelectedIndexChanged
        LRNET = cbo_LivingNet.Text
        lbl_LRNET.Text = LRNET
        input_rules()
    End Sub

    Private Sub cbo_bed1Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1Net.SelectedIndexChanged
        BRONET = cbo_bed1Net.Text
        lbl_BRONET.Text = BRONET
        input_rules()

    End Sub

    Private Sub cbo_bed2Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2Net.SelectedIndexChanged
        BRTNET = cbo_bed2Net.Text
        lbl_BRTNET.Text = BRTNET
        input_rules()

    End Sub

    Private Sub cbo_kitchenTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenTV.SelectedIndexChanged
        KTV = cbo_kitchenTV.Text ' Sets the varible KTV to the value of the combo box this will be used to store in the array or can be used to check rules.
    End Sub

    Private Sub cbo_kitchenSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenSAT.SelectedIndexChanged
        KSAT = cbo_kitchenSAT.Text
    End Sub

    Private Sub cbo_kitchen1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen1G.SelectedIndexChanged
        K1G = cbo_kitchen1G.Text
    End Sub

    Private Sub cbo_kitchen2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchen2G.SelectedIndexChanged
        K2G = cbo_kitchen2G.Text
    End Sub

    Private Sub cbo_LivingTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingTV.SelectedIndexChanged
        LRTV = cbo_LivingTV.Text
    End Sub

    Private Sub cbo_LivingSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingSAT.SelectedIndexChanged
        LRSAT = cbo_LivingSAT.Text
    End Sub

    Private Sub cbo_Living1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living1G.SelectedIndexChanged
        LR1G = cbo_Living1G.Text
    End Sub

    Private Sub cbo_Living2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Living2G.SelectedIndexChanged
        LR2G = cbo_Living2G.Text
    End Sub

    Private Sub cbo_bath1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath1G.SelectedIndexChanged
        BATH1G = cbo_bath1G.Text
    End Sub

    Private Sub cbo_bath2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bath2G.SelectedIndexChanged
        BATH2G = cbo_bath2G.Text
    End Sub

    Private Sub cbo_bed2TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2TV.SelectedIndexChanged
        BRTTV = cbo_bed2TV.Text
    End Sub

    Private Sub cbo_bed2SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2SAT.SelectedIndexChanged
        BRTSAT = cbo_bed2SAT.Text
    End Sub

    Private Sub cbo_bed2_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_1G.SelectedIndexChanged
        BRT1G = cbo_bed1_1G.Text
    End Sub

    Private Sub cbo_bed2_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2_2G.SelectedIndexChanged
        BRT2G = cbo_bed1_2G.Text
    End Sub

    Private Sub cbo_bed1TV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1TV.SelectedIndexChanged
        BROTV = cbo_bed1TV.Text
    End Sub

    Private Sub cbo_bed1SAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1SAT.SelectedIndexChanged
        BROSAT = cbo_bed1SAT.Text
    End Sub

    Private Sub cbo_bed1_1G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_1G.SelectedIndexChanged
        BRO1G = cbo_bed1_1G.Text
    End Sub

    Private Sub cbo_bed1_2G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1_2G.SelectedIndexChanged
        BRO2G = cbo_bed2_2G.Text
    End Sub
End Class