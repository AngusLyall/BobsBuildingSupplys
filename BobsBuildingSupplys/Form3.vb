Imports System.Drawing.Printing
Public Class Form3
    Dim listformat As String = "{0,1}{1,15}{2,-1}"
    Dim totalcostgst As Integer
    Dim totalcostnogst As Integer
    Dim ordersaved As Boolean = False
    Dim printoutstr As String
    Dim currentordernumber As Integer
    Dim ordernumer As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kitchenupgradename As String = "TV Poinht"
        Dim kitchenupgradequntity As String
        Dim kitchenupgradecost As String
        Dim bathroomqunainity As String
        Dim bathroomupgradecost As String
        Dim otherroomquninity As String
        Dim otherupgradecost As String
        Dim kitchenlist As New List(Of String) From {"Aerial Point    ", "Satellite Point ", "Network Point   ", "1 Gang Socket   ", "2 Gang Socket   ", "Kitchen Upgrade "}
        Dim bathroomlist As New List(Of String) From {"1 Gang Socket   ", "2 Gang Socket   ", "Bathroom Upgrade"}
        Dim otheroomslist As New List(Of String) From {"Aerial Point    ", "Satellite Point ", "Network Point   ", "1 Gang Socket   ", "2 Gang Socket   ", "HeatPump        "}


        Dim temp1 As Integer = -1 ' this is used for loops to get the amount of times it has run though the loop

        lst_display.Items.Add($"Customer Details") ' adds a heading with "cutomer details"
        lst_display.Items.Add($"First Name {CusFirstName}") ' addds the firstname as a string with the first name the user put in
        lst_display.Items.Add($"Last Name {CusLastName}") ' adds the last name as a string with the lastname the userput in
        lst_display.Items.Add($"Business Name {CusBusinessName}") ' adds the business name to the quote if the user provided one
        lst_display.Items.Add($"Phone Number {CusPhoneNumber}") ' adds the phone number to the quote as a string that the user provided
        lst_display.Items.Add($"Billing Adress {CusBillAdress}") ' adds the billing adress to the quote that the user provided
        lst_display.Items.Add($"Delivery Adress {CusDeliveryAdress}") ' adds the delivery adress the user provided
        lst_display.Items.Add($"Trade Customer {cusTrade}") ' will show true or false if the user ticked the trade customer box.
        lst_display.Items.Add("  ") ' adds a gap between the customer details and kitchen upgrades to make it easier for the user to read.


        lst_display.Items.Add($"Kitchen Upgrades - Total {totalvalue(1).ToString("C")}")
        For Each upgrade As String In kitchenlist 'This loops though each item in the Kitchen List
            temp1 = temp1 + 1 ' this adds one each time it loops
            If temp1 = 5 Then 'when its looped 5 times so the 5th item in the list it moves on
                Select Case Kitchen(5) ' this gets the value of Kitchen(5) array
                    Case 0 ' if the array is == to 0
                        kitchenupgradequntity = "0"
                    Case 1 ' if the array is == 1
                        kitchenupgradequntity = "A" ' this sets kitchenupgradequntity equal to A instaid of 1 so the user understands the input
                    Case 2  'If the array Is == 2
                        kitchenupgradequntity = "B" ' this sets kitchenupgradequntity equal to B instaid of 1 so the user understands the input
                    Case 3  'if the array is == 3
                        kitchenupgradequntity = "C" ' this sets kitchenupgradequntity equal to C instaid of 1 so the user understands the input
                End Select
            Else
                kitchenupgradequntity = Kitchen(temp1) ' The list is orded so its the same as the array so it gets the value of the array at that same point as the list and sets that as the value
            End If

            kitchenupgradecost = kitchencost(temp1) ' this works the same as above the list and array hold the same values at each point so this sets the cost of the current list item as the one stored in the array
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & kitchenupgradequntity, "     Cost: " & kitchenupgradecost)) ' this adds to the list after each loop the name upgrade amount and cost

        Next


        lst_display.Items.Add("  ") ' this adds a gap just to make it easier to read
        lst_display.Items.Add($"Living Room Upgrades - Total {totalvalue(2).ToString("C")}") ' this adds a header text
        temp1 = -1 ' resets the temp1 value used in loops

        For Each upgrade As String In otheroomslist ' this loops though each item in otheroomslist
            temp1 = temp1 + 1 ' each loop it adds one to temp1
            otherupgradecost = LivingRoomCost(temp1) ' gets the cost from the array the list and array have the values orded the same so array(number) is == to the item in the list List(number) at that point.
            otherroomquninity = LivingRoom(temp1) ' this gets the amount of items selected works the same as the cost
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost)) ' this adds it to the lst_display so it is added in a list then converted to a string
        Next

        lst_display.Items.Add("  ") ' this adds a gap between betroom one and the living room
        lst_display.Items.Add($"Bed Room One Upgrades - Total {totalvalue(3).ToString("C")}") ' this adds a header with the total upgrade cost in the bed room one.
        temp1 = -1 ' resets the temp value back to -1 

        For Each upgrade As String In otheroomslist ' loops though each item in the otheroomslist
            temp1 = temp1 + 1 ' adds one after each loop
            otherupgradecost = BedRoomOneCost(temp1) ' this gets the value of bedroomcost array from the amount of times its looped so the first value is BedRoomOneCost(0) which is equal orded the same as the list so its equal to  Aerial Point cost
            otherroomquninity = BedRoomOne(temp1) ' this gets the value of bedroomone array from the amount of times its looped so the first value is BedRoomOne(0) which is equal orded the same as the list so its equal to  Aerial Point selected.
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost)) ' this adds the item to the list after each loop
        Next

        lst_display.Items.Add("  ") ' adds a gap between bedroom one and two makes it more readable for the user.
        lst_display.Items.Add($"Bed Room Two Upgrades - Total {totalvalue(4).ToString("C")}") ' this adds a header with the total cost of the selected upgrades
        temp1 = -1 ' resets the tmp value used for loops back to -1

        For Each upgrade As String In otheroomslist 'this loops though each item in the otherroomslist
            temp1 = temp1 + 1 ' this adds one each time it loops to temp1
            otherupgradecost = BedRoomTwoCost(temp1) ' this gets the cost of the current upgrade in the loop
            otherroomquninity = BedRoomTwo(temp1) ' this gets the amount of items selected in the current loop
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost)) ' this adds the display to the list after each loop and is converted to a string later
        Next

        lst_display.Items.Add("  ") ' this adds a gap between bedroomtwo and bathroom
        lst_display.Items.Add($"Bathroom Upgrades - Total {totalvalue(5).ToString("C")}") ' this adds a header with the total of the selected upgrades from the bathroom

        temp1 = -1 ' resets temp1 value back to -1
        For Each upgrade As String In bathroomlist ' this gets each item from the bathroomlist
            temp1 = temp1 + 1 ' this adds one to temp1 after each time the loop runs
            bathroomupgradecost = BathRoomCost(temp1) ' this gets the upgrade cost of the item in the list we are currently looping
            bathroomqunainity = BathRoom(temp1) ' this gets how many items are selected for the current upgrade in the list we are looping
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & bathroomqunainity, "      Cost:" & bathroomupgradecost)) ' this adds the infomation 
        Next


        lst_display.Items.Add("  ") ' this adds a gap between the bathroom and displaying the cost.
        If cusTrade = True Then 'if the customer is a trade customer they get a discont so this adds the discount
            totalcostnogst = (totalvalue(0) + Form4.BASICKIT) * Form4.TRADE ' this times the total cost by the discount
            totalcostgst = (totalcostnogst * 1.15) * Form4.TRADE ' this times the total cost by the discount
        Else ' if they are not a trade customer
            totalcostnogst = totalvalue(0) + Form4.BASICKIT ' this gets the total cost without gst
            totalcostgst = totalcostnogst * Form4.GST 'this gets the total cost with gst
        End If



        lst_display.Items.Add($"Total Cost Excluding GST {totalcostnogst.ToString("C")} ") ' this adds the cost without gst to the lst_display list to then be displayed
        lst_display.Items.Add($"Total Cost Including GST {totalcostgst.ToString("C")} ") ' this adds the cost with gst to the lst_display list to then be displayed


        ordernumer = My.Computer.FileSystem.ReadAllText("ordernumber.txt") ' this gets the order number from the computer
        currentordernumber = Int(ordernumer) ' this then converts the number we got to a interger from a string
        currentordernumber = currentordernumber + 1 ' adds one to the ordernumber since we have a new order
        My.Computer.FileSystem.DeleteFile("ordernumber.txt") ' this deletes ordernumber.txt used if the file is missing so the computer makes one
        My.Computer.FileSystem.WriteAllText("ordernumber.txt", "" & currentordernumber, True) ' saves the current ordernumber to ordernumber.txt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printstring() ' saves a string of the selected userinput and the costs.
        Dim filename As String = "orderhistory.txt" ' sets the file to save too
        If ordersaved = False Then ' if it hasn't been saved before
            My.Computer.FileSystem.WriteAllText($"{filename}", "" & printoutstr, True) ' saves it to a document
            ordersaved = True ' tells the computer its been saved
            MessageBox.Show($"Order Has Saved to {filename}") ' Displays a message to the user that it is saved and where it is saved
        Else
            MessageBox.Show("Order Already Saved") ' if the order has been saved then it stops them resaveing
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit() ' closes the application
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_OrderDetails.Show() ' shows privious form
        Me.Close() ' closes current form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1 ' sets the document to print
        PrintPreviewDialog1.ShowDialog() ' shows a print preview 
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim localfont As New Font("Courier New", 14, FontStyle.Regular) 'sets the font and the size
        printstring() ' calls the sub to get the values selected by the user into a string
        e.Graphics.DrawString(printoutstr, localfont, Brushes.Black, 15, 0) ' adds the text from the prinoutsr into the a documnet for a printout
        e.Graphics.DrawImage(icon.Image, 420, 1) ' adds the logo to the print document.

    End Sub

    Private Sub printstring()
        Dim printoutlist As New List(Of String)

        printoutlist.Add("  ") ' adds spaces this is for the order history so they are not all together
        printoutlist.Add("  ")
        printoutlist.Add($"Order Number: {currentordernumber}") ' sets the order number at the top of the page to the current order
        For Each item In lst_display.Items ' for each item in the list lst_display it adds the item to a new list that will be converted to a string
            printoutlist.Add(item) 'adds the item from lst_display.items to the printoutlist list
        Next
        ' String.join compains the new line and the value of prinout list converting a list to a string at each new item adds a new line.
        printoutstr = String.Join(vbCrLf, printoutlist) ' sets the prinoutstr used for the display of the selected options and to print out the quote

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles icon.Click

    End Sub
End Class