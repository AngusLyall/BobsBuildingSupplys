Public Class Form3
    Dim listformat As String = "{0,1}{1,15}{2,-1}"
    Dim totalcostgst As Integer
    Dim totalcostnogst As Integer
    Dim ordersaved As Boolean = False
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


        Dim temp1 As Integer = -1

        lst_display.Items.Add($"Customer Details")
        lst_display.Items.Add($"First Name {CusFirstName}")
        lst_display.Items.Add($"Last Name {CusLastName}")
        lst_display.Items.Add($"Business Name {CusBusinessName}")
        lst_display.Items.Add($"Phone Number {CusPhoneNumber}")
        lst_display.Items.Add($"Billing Adress {CusBillAdress}")
        lst_display.Items.Add($"Delivery Adress {CusDeliveryAdress}")
        lst_display.Items.Add($"Trade Customer {cusTrade}")


        lst_display.Items.Add($"Kitchen Upgrades - Total {totalvalue(1).ToString("C")}")
        For Each upgrade As String In kitchenlist
            temp1 = temp1 + 1
            If temp1 = 5 Then
                Select Case Kitchen(5)
                    Case 0
                        kitchenupgradequntity = "0"
                    Case 1
                        kitchenupgradequntity = "A"
                    Case 2
                        kitchenupgradequntity = "B"
                    Case 3
                        kitchenupgradequntity = "C"
                End Select
            Else
                kitchenupgradequntity = Kitchen(temp1)
            End If

            kitchenupgradecost = kitchencost(temp1)
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & kitchenupgradequntity, "     Cost: " & kitchenupgradecost))

        Next


        lst_display.Items.Add("  ")
        lst_display.Items.Add($"Living Room Upgrades - Total {totalvalue(2).ToString("C")}")
        temp1 = -1

        For Each upgrade As String In otheroomslist
            temp1 = temp1 + 1
            otherupgradecost = LivingRoomCost(temp1)
            otherroomquninity = LivingRoom(temp1)
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost))
        Next

        lst_display.Items.Add("  ")
        lst_display.Items.Add($"Bed Room One Upgrades - Total {totalvalue(3).ToString("C")}")
        temp1 = -1

        For Each upgrade As String In otheroomslist
            temp1 = temp1 + 1
            otherupgradecost = BedRoomOneCost(temp1)
            otherroomquninity = BedRoomOne(temp1)
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost))
        Next

        lst_display.Items.Add("  ")
        lst_display.Items.Add($"Bed Room Two Upgrades - Total {totalvalue(4).ToString("C")}")
        temp1 = -1

        For Each upgrade As String In otheroomslist
            temp1 = temp1 + 1
            otherupgradecost = BedRoomTwoCost(temp1)
            otherroomquninity = BedRoomTwo(temp1)
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & otherroomquninity, "      Cost:" & otherupgradecost))
        Next

        lst_display.Items.Add("  ")
        lst_display.Items.Add($"Bathroom Upgrades - Total {totalvalue(5).ToString("C")}")

        temp1 = -1
        For Each upgrade As String In bathroomlist
            temp1 = temp1 + 1
            bathroomupgradecost = BathRoomCost(temp1)
            bathroomqunainity = BathRoom(temp1)
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & bathroomqunainity, "      Cost:" & bathroomupgradecost))
        Next


        lst_display.Items.Add("  ")
        If cusTrade = True Then
            totalcostnogst = (totalvalue(0) + Form4.BASICKIT) * Form4.TRADE
            totalcostgst = (totalcostnogst * 1.15) * Form4.TRADE
        Else
            totalcostnogst = totalvalue(0) + Form4.BASICKIT
            totalcostgst = totalcostnogst * Form4.GST
        End If



        lst_display.Items.Add($"Total Cost Excluding GST {totalcostnogst.ToString("C")} ")
        lst_display.Items.Add($"Total Cost Including GST {totalcostgst.ToString("C")} ")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim printoutlist As New List(Of String)
        Dim ordernumer As String
        Dim filename As String = "orderhistory.txt"
        ordernumer = My.Computer.FileSystem.ReadAllText("ordernumber.txt")
        Dim currentordernumber As Integer
        currentordernumber = Int(ordernumer)
        currentordernumber = currentordernumber + 1

        printoutlist.Add("  ")
        printoutlist.Add("  ")
        printoutlist.Add($"Order Number: {currentordernumber}")
        For Each item In lst_display.Items
            printoutlist.Add(item)
        Next
        Dim printoutstr As String = String.Join(vbCrLf, printoutlist)
        If ordersaved = False Then
            '' My.Computer.FileSystem.DeleteFile("ordernumber.txt")
            '' My.Computer.FileSystem.WriteAllText("ordernumber.txt", "" & currentordernumber, True)
            My.Computer.FileSystem.WriteAllText($"{filename}", "" & printoutstr, True)
            ordersaved = True
            MessageBox.Show($"Order Has Saved to {filename}")
        Else
            MessageBox.Show("Order Already Saved")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_OrderDetails.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        Dim printoutlist As New List(Of String)
        Dim ordernumer As String
        ordernumer = My.Computer.FileSystem.ReadAllText("ordernumber.txt")
        Dim currentordernumber As Integer
        currentordernumber = Int(ordernumer)
        currentordernumber = currentordernumber + 1
        printoutlist.Add("  ")
        printoutlist.Add("  ")
        printoutlist.Add($"Order Number: {currentordernumber}")
        For Each item In lst_display.Items
            printoutlist.Add(item)
        Next
        Dim printoutstr As String = String.Join(vbCrLf, printoutlist)
        MessageBox.Show("Not Implmented yet")
    End Sub
End Class