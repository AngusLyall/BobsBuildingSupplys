Module Mod_Varivbles
    Public CusFirstName As String
    Public CusLastName As String
    Public CusBusinessName As String
    Public CusPhoneNumber As String
    Public CusBillAdress As String
    Public CusDeliveryAdress As String
    Public cusTrade As Boolean = False
    Public cusAdressSame As Boolean = False
    Public Const BasicKit As Decimal = 65217.3913043
    Public Const KitchenOptionA As Integer = 2000
    Public Const KitchenOptionB As Integer = 3500
    Public Const KitchenOptionC As Integer = 6000
    Public Const TV_Aerial As Integer = 250
    Public Const TV_Aerial_Point As Integer = 50
    Public Const TV_SAT As Integer = 250
    Public Const TV_SAT_Point As Integer = 50
    Public Const HeatPump As Integer = 1800
    Public Const OneGSocket As Integer = 40
    Public Const TwoGSocket As Integer = 50
    Public Const Network_Point As Integer = 50
    Public Const Network_Switch As Integer = 100
    Public Const GST As Integer = 1.15
    Public Const Trade As Integer = 0.9

    Public Kitchen(5) As Integer
    Public BathRoom(2) As Integer
    Public LivingRoom(5) As Integer
    Public BedRoomTwo(5) As Integer
    Public BedRoomOne(5) As Integer
End Module
