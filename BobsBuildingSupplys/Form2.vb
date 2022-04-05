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

    Private Sub value_store()
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
        Dim netpointcheck As Integer

    End Sub

    Private Sub chk_KitchenA_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenA.CheckedChanged
        If KitchenA = False Then
            If KitchenB Or KitchenC = True Then
                chk_KitchenB.Checked = False
                chk_KitchenC.Checked = False
                KitchenB = False
                KitchenC = False
            End If
            KitchenA = True
            Kupgrade = 1
        Else
            KitchenA = False
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
        If LRHeat = False Then
            LRHeat = True
            LRHeatPump = 1
        Else
            LRHeat = False
            LRHeatPump = 0
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
        KNET = cbo_kitchenNet.Text
    End Sub

    Private Sub cbo_LivingNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_LivingNet.SelectedIndexChanged
        LRNET = cbo_LivingNet.Text
    End Sub

    Private Sub cbo_bed1Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed1Net.SelectedIndexChanged
        BRONET = cbo_bed1Net.Text
    End Sub

    Private Sub cbo_bed2Net_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bed2Net.SelectedIndexChanged
        BRTNET = cbo_bed2Net.Text
    End Sub

    Private Sub cbo_kitchenTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_kitchenTV.SelectedIndexChanged
        KTV = cbo_kitchenTV.Text
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