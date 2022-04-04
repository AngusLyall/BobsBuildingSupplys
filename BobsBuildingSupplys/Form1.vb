Imports System.IO ' used for the web requets
Imports System.Net ' used for web requests
Imports System.Xml ' used for the xml files that I create and read

Public Class CustomerDetails
    Dim Billingtextchanged As Boolean = False
    Dim deliverytextchanged As Boolean = False
    Dim requiredinfomation As Boolean = False
    Dim apiuserinput
    Private Sub lbl_CusTitle_Click(sender As Object, e As EventArgs) Handles lbl_CusTitle.Click

    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xmlfile As System.IO.StreamWriter
        xmlfile = My.Computer.FileSystem.OpenTextFileWriter("xmlfile.xml", True)
        xmlfile.Close()
    End Sub

    Private Sub txt_custfirstname_TextChanged(sender As Object, e As EventArgs) Handles txt_CusFirstName.TextChanged
        CusFirstName = txt_CusFirstName.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_custLastName.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_cusBillingAdress.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_DeliverySameBilling.CheckedChanged
        If cusAdressSame = False Then
            cusAdressSame = True
            CusDeliveryAdress = CusBillAdress
            txt_CusDeliveryAddress.Text = CusDeliveryAdress

        Else
            cusAdressSame = False
        End If
    End Sub

    Private Sub txt_CusLastName_TextChanged(sender As Object, e As EventArgs) Handles txt_CusLastName.TextChanged
        CusLastName = txt_CusLastName.Text
    End Sub

    Private Sub txt_CusBusinessName_TextChanged(sender As Object, e As EventArgs) Handles txt_CusBusinessName.TextChanged
        CusBusinessName = txt_CusBusinessName.Text
    End Sub

    Private Sub txt_CusPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_CusPhoneNumber.TextChanged
        CusPhoneNumber = txt_CusPhoneNumber.Text
    End Sub

    Private Sub txt_CusBillingAdress_TextChanged(sender As Object, e As EventArgs) Handles txt_CusBillingAdress.TextChanged
        CusBillAdress = txt_CusBillingAdress.Text
        Billingtextchanged = True
        If cusAdressSame = True Then
            CusDeliveryAdress = CusBillAdress
            txt_CusDeliveryAddress.Text = CusDeliveryAdress
        End If
    End Sub

    Private Sub txt_CusDeliveryAddress_TextChanged(sender As Object, e As EventArgs) Handles txt_CusDeliveryAddress.TextChanged
        CusDeliveryAdress = txt_CusDeliveryAddress.Text
        deliverytextchanged = True
    End Sub

    Private Sub chk_TradeCus_CheckedChanged(sender As Object, e As EventArgs) Handles chk_TradeCus.CheckedChanged
        If cusTrade = False Then
            cusTrade = True
        Else
            cusTrade = False
        End If
    End Sub
    Private Sub apirequest()

        Dim googleapirequest As WebRequest = WebRequest.Create("https://maps.googleapis.com/maps/api/place/autocomplete/xml?input=" + apiuserinput.text + "&components=country:nz&key=AIzaSyBSWiOSW4DHovOqKAecA_GoYK-_X2ZXJ8M") ' makes a request the /xml sets the response to xml ?input is what the user puts in &components sets country as nz so we dont get international streets &key is my google development api key
        Dim apiresponse As WebResponse = googleapirequest.GetResponse() ' this sets the result as a vairble that I can then use later stops me typing out alot.

        Using ResponseStream As Stream = apiresponse.GetResponseStream()
            Dim reader As New StreamReader(ResponseStream) ' this converts the result from the api into a reader that I can then turn into a string makes it easier to work with
            Dim responseFromApi As String = reader.ReadToEnd() ' makes the reader from above into a sting
            My.Computer.FileSystem.DeleteFile("xmlfile.xml") ' Gets rid of old results
            My.Computer.FileSystem.WriteAllText("xmlfile.xml", "" & responseFromApi, True) ' this pasts the string that is still in xml format into a xml document this is so I can make viusal studio read it as a xml since I dont really know how xmls work this was the easyest way to do it
            Dim apixmldoc As XmlDocument ' Local Vairbles that will be used later this is for the location of the document and tells visual studio the format of xml
            Dim apiresultlist As XmlNodeList ' Same as above but is to list all "predictions"
            Dim apiresult As XmlNode ' this is for the list it is used to sepreate the "predictions" from a list into single results.

            Dim apioutput As String ' this is what the user gets its the closes to what they have typed to auto fill there adress

            apixmldoc = New XmlDocument
            apixmldoc.Load("xmlfile.xml") ' tells Visual studio where to look for the xml
            apiresultlist = apixmldoc.GetElementsByTagName("prediction") 'makes it look though the xml file for the heading "Predictions"

            For Each apiresult In apiresultlist ' this loop is used to add all the preductions from the api into viusal basics txtbox autocomplete.
                apioutput = apiresult.Item("description").InnerText ' this reads in the predictions for the Description this is set by google and is make for humans to read
                apiuserinput.AutoCompleteCustomSource.Add(apioutput) ' this adds the descirtion (googles predicted adresses) to the viusal studio auto complete for the textbox.
            Next
        End Using
    End Sub

    Private Sub tmr_RequestLimiter_Tick(sender As Object, e As EventArgs) Handles tmr_RequestLimiter.Tick
        If Billingtextchanged = True Then
            apiuserinput = txt_CusBillingAdress
            apirequest()
            Billingtextchanged = False
        End If
        If deliverytextchanged = True Then
            apiuserinput = txt_CusDeliveryAddress
            apirequest()
            deliverytextchanged = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        RequiredInfomationCheck() ' checks if there are any empty boxes
        If requiredinfomation = True Then
            frm_OrderDetails.Show()





        Else
            MessageBox.Show("Please Fill out the Requried Infomation Marked by a Asterisk")
        End If



    End Sub


    Private Sub RequiredInfomationCheck()

        requiredinfomation = False ' makes the RequiredInfomation vailble False that means it required no More Infomation

        If CusFirstName = "" Then ' Checks if the vairble that stores the userinput contains anything if it does not it shows a red * and makes a varible true to stop the user moving on.
            lbl_FirstNameRequired.Show() ' Displays a label which is a red * if the infomation is missing
            requiredinfomation = True 'Makes the Requited infomation = true meaning we require more infomation if a box is empty
        Else
            lbl_FirstNameRequired.Hide()

        End If

        If CusLastName = "" Then
            lbl_LastNameRequired.Show()
            requiredinfomation = True
        Else
            lbl_LastNameRequired.Hide()
        End If

        If CusPhoneNumber = "" Then
            lbl_PhoneNumberRequired.Show()
            requiredinfomation = True
        Else
            lbl_PhoneNumberRequired.Hide()
        End If

        If CusBillAdress = "" Then
            lbl_BillingRequired.Show()
            requiredinfomation = True
        Else
            lbl_BillingRequired.Hide()
        End If

        If CusDeliveryAdress = "" Then
            lbl_DeliveryRequired.Show()
            requiredinfomation = True
        Else
            lbl_DeliveryRequired.Hide()
        End If

        If cusTrade = True Then ' Because not all users will be a trade user this option is only required if they request the Trade Discount.
            If CusBusinessName = "" Then
                lbl_BusinessNameRequired.Show()
                requiredinfomation = True
            Else
                lbl_BusinessNameRequired.Hide()
            End If
        End If


    End Sub
End Class