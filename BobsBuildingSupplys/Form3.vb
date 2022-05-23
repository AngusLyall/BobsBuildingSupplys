Public Class Form3
    Dim listformat As String = "{0,1}{1,15}{2,15}"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kitchenupgradename As String = "TV Poinht"
        Dim kitchenupgradequntity As String
        Dim kitchenupgradecost As String

        Dim kitchenlist As New List(Of String) From {"Aerial Point           ", "Satellite Point      ", "Network Point      ", "1 Gang Socket    ", "2 Gang Socket    ", "Kitchen Upgrade"}



        Dim temp1 As Integer = -1
        lst_display.Items.Add("Kitchen Upgrades")
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
            lst_display.Items.Add(String.Format(listformat, upgrade, "Amount: " & kitchenupgradequntity, "Cost: " & kitchenupgradecost))

        Next

    End Sub
End Class