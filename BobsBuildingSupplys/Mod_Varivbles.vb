Module Mod_Varivbles
    Public CusFirstName As String
    Public CusLastName As String
    Public CusBusinessName As String
    Public CusPhoneNumber As String
    Public CusBillAdress As String
    Public CusDeliveryAdress As String
    Public cusTrade As Boolean = False
    Public cusAdressSame As Boolean = False
    Public Const BASICKIT As Decimal = 65217.3913043
    Public Const KITCHENOPTIONA As Integer = 2000
    Public Const KITCHENOPTIONB As Integer = 3500
    Public Const KITCHENOPTIONC As Integer = 6000
    Public Const BATHUPGRADE As Integer = 2500
    Public Const TV_AERIAL As Integer = 250
    Public Const TV_AERIAL_POINT As Integer = 50
    Public Const TV_SAT As Integer = 250
    Public Const TV_SAT_POINT As Integer = 50
    Public Const HEATPUMP1 As Integer = 1800
    Public Const HEATPUMP2 As Integer = 2500
    Public Const ONEGSOCKET As Integer = 40
    Public Const TWOGSOCKET As Integer = 50
    Public Const NETWORK_POINT As Integer = 50
    Public Const NETWORK_SWITCH As Integer = 100
    Public Const GST As Decimal = 1.15
    Public Const TRADE As Decimal = 0.9



    Public Kitchen(5) As Integer
    Public kitchencost(5) As Integer
    Public BathRoom(2) As Integer
    Public BathRoomCost(2) As Integer
    Public LivingRoom(5) As Integer
    Public LivingRoomCost As Integer
    Public BedRoomTwo(5) As Integer
    Public BedRoomTwoCost(5) As Integer
    Public BedRoomOne(5) As Integer
    Public BedRoomOneCost(5) As Integer
    Public totalvalue(5) As Integer ' 0 = total,  1 = kitchen,  2 = living room,  3= bedroom1, 4 = bedroom2, 5= bathroom



End Module
