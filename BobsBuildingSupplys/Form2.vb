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

    Private Sub chk_KitchenA_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenA.CheckedChanged
        If KitchenA = False Then
            KitchenA = True
            Kupgrade = 1
        Else
            KitchenA = False
        End If
    End Sub

    Private Sub chk_KitchenB_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenB.CheckedChanged
        If KitchenB = False Then
            KitchenB = True
            Kupgrade = 2
        Else
            KitchenB = False
        End If
    End Sub

    Private Sub chk_KitchenC_CheckedChanged(sender As Object, e As EventArgs) Handles chk_KitchenC.CheckedChanged
        If KitchenC = False Then
            KitchenC = True
            Kupgrade = 3
        Else
            KitchenC = False
        End If
    End Sub

    Private Sub chk_HeatPumpLiving_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpLiving.CheckedChanged
        If LRHeat = False Then
            LRHeat = True
            LRHeatPump = 1
        Else
            LRHeat = False
        End If
    End Sub

    Private Sub chk_HeatPumpBedOne_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedOne.CheckedChanged
        If BROHeat = False Then
            BROHeat = True
            BROHeatPump = 1
        Else
            BROHeat = False
        End If
    End Sub

    Private Sub chk_HeatPumpBedTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBedTwo.CheckedChanged
        If BRTHeat = False Then
            BRTHeat = True
            BRTHeatPump = 1
        Else
            BRTHeat = False
        End If
    End Sub

    Private Sub chk_HeatPumpBathRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HeatPumpBathRoom.CheckedChanged
        If BATHOption = False Then
            BATHOption = True
            BATHUpgrade = 1
        Else
            BATHOption = False
        End If
    End Sub
End Class