Module Mod_Varivbles
    Public CusFirstName As String
    Public CusLastName As String
    Public CusBusinessName As String
    Public CusPhoneNumber As String
    Public CusBillAdress As String
    Public CusDeliveryAdress As String
    Public cusTrade As Boolean = False
    Public cusAdressSame As Boolean = False
    Public Kitchen(5) As Integer
    Public kitchencost(5) As Decimal
    Public BathRoom(2) As Integer
    Public BathRoomCost(2) As Decimal
    Public LivingRoom(5) As Integer
    Public LivingRoomCost(5) As Decimal
    Public BedRoomTwo(5) As Integer
    Public BedRoomTwoCost(5) As Decimal
    Public BedRoomOne(5) As Integer
    Public BedRoomOneCost(5) As Decimal
    Public totalvalue(5) As Integer ' 0 = total,  1 = kitchen,  2 = living room,  3= bedroom1, 4 = bedroom2, 5= bathroom
End Module
