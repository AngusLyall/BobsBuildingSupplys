Public Class Form3
    Dim listformat As String = "{0,1}{1,15}{2,-1}"
    Dim totalcostgst As Integer
    Dim totalcostnogst As Integer
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
        totalcostnogst = totalvalue(0) + BASICKIT
        totalcostgst = totalcostnogst * 1.15


        lst_display.Items.Add($"Total Cost Excluding GST {totalcostnogst.ToString("C")} ")
        lst_display.Items.Add($"Total Cost Including GST {totalcostgst.ToString("C")} ")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String
        x = lst_display.GetItemText(lst_display.Items.Count())

        MessageBox.Show(x)
    End Sub
End Class