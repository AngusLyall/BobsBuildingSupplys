Imports System.IO ' used for the web requets
Imports System.Net ' used for web requests
Imports System.Xml ' used for the xml files that I create and read

Public Class CustomerDetails
    Dim Billingtextchanged As Boolean = False ' these statments set up vairbles that are Booleans so they take a true False input.
    Dim deliverytextchanged As Boolean = False
    Dim requiredinfomation As Boolean = False
    Dim apiuserinput
    Private Sub lbl_CusTitle_Click(sender As Object, e As EventArgs) Handles lbl_CusTitle.Click

    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xmlfile As System.IO.StreamWriter
        xmlfile = My.Computer.FileSystem.OpenTextFileWriter("xmlfile.xml", True) ' this creates an XML file on start of the program for the google API results to be saved to and read from
        xmlfile.Close() ' This closes the file it will be reopened later in the program this stops any edits from happening.
        Form4.configpriceset()

    End Sub

    Private Sub txt_custfirstname_TextChanged(sender As Object, e As EventArgs) Handles txt_CusFirstName.TextChanged
        CusFirstName = txt_CusFirstName.Text ' Sets the value of the text box to a varible when the text in the textbox is changed
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_custLastName.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_cusBillingAdress.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_DeliverySameBilling.CheckedChanged
        If cusAdressSame = False Then ' This checks if the Adress same check box is checked if it is then it runs the code below
            cusAdressSame = True ' changes the varible so the program knows what state the box is in (if it is ticked or not)
            CusDeliveryAdress = CusBillAdress ' this makes the Delivery adress varible = to the billing adress important for storeing the values
            txt_CusDeliveryAddress.Text = CusDeliveryAdress ' this makes the Delivery Adress textbox value = to the customer delivery afres

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

    Private Sub txt_CusBillingAdress_TextChanged(sender As Object, e As EventArgs) Handles txt_CusBillingAdress.TextChanged
        CusBillAdress = txt_CusBillingAdress.Text
        Billingtextchanged = True
        If cusAdressSame = True Then ' this updates the delivery adress so as you type in the billing adress it updates the delivery adress if selected as being the same
            CusDeliveryAdress = CusBillAdress
            txt_CusDeliveryAddress.Text = CusDeliveryAdress
        End If
    End Sub

    Private Sub txt_CusDeliveryAddress_TextChanged(sender As Object, e As EventArgs) Handles txt_CusDeliveryAddress.TextChanged
        CusDeliveryAdress = txt_CusDeliveryAddress.Text ' this sets the varible = to the text
        deliverytextchanged = True ' this is used for the timer to make sure its not trying to make api requests too often causes the program to run slow
    End Sub

    Private Sub chk_TradeCus_CheckedChanged(sender As Object, e As EventArgs) Handles chk_TradeCus.CheckedChanged
        If cusTrade = False Then
            cusTrade = True
        Else
            cusTrade = False
        End If
    End Sub
    Private Sub apirequest()

        Dim googleapirequest As WebRequest = WebRequest.Create("https://maps.googleapis.com/maps/api/place/autocomplete/xml?input=" + apiuserinput.text + "&components=country:nz&key=" + Form4.APIKEY) ' makes a request the /xml sets the response to xml ?input is what the user puts in &components sets country as nz so we dont get international streets &key is my google development api key
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
        If Billingtextchanged = True Then ' if the billing adress is changed between the timer ticks then it calls the api 
            apiuserinput = txt_CusBillingAdress
            apirequest()
            Billingtextchanged = False ' tells the computer it has run this by setting it to False
        End If
        If deliverytextchanged = True Then ' Works the same as the billing adress but for the delivery adress
            apiuserinput = txt_CusDeliveryAddress
            apirequest()
            deliverytextchanged = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        RequiredInfomationCheck() ' checks if there are any empty boxes
        If requiredinfomation = False Then ' if requried infomation is set to False it then tells the code to move on if it doesn't it runs the else statment that tells the user to fill the infomation
            frm_OrderDetails.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please Fill out the Requried Infomation Marked by a Asterisk")
        End If



    End Sub


    Private Sub RequiredInfomationCheck()

        requiredinfomation = False ' makes the RequiredInfomation vailble False if some required infomation is missing it gets set to true then stops the user from moving on
        Dim customerdetailslist As New List(Of String) From {"CusFirstName", "CusLastName", "CusPhoneNumber", "CusBillAdress", "CusDeliveryAdress", "CusBusinessName "}


        If CusFirstName = "" Then ' Checks if the vairble that stores the userinput contains anything if it does not it shows a red * and makes a varible true to stop the user moving on.
            lbl_FirstNameRequired.Show() ' Displays a label which is a red * if the infomation is missing
            requiredinfomation = True 'Makes the Requited infomation = true meaning we require more infomation if a box is empty
        Else
            lbl_FirstNameRequired.Hide() ' If the infomation is not equal to blank then it hides the red Red Astix which shows the required infomation.

        End If

        If CusLastName = "" Then ' if the CustLastName is blank then 
            lbl_LastNameRequired.Show() ' it shows an red astics
            requiredinfomation = True ' and sets requred infomation to True so the program knows something is missing
        Else
            lbl_LastNameRequired.Hide() ' if the last time it ran it infomation was missing this would be displayed so it rehides it 
        End If

        If CusPhoneNumber = "" Then ' if the customer phone number slot is blank then it 
            lbl_PhoneNumberRequired.Show() ' shows the red *
            requiredinfomation = True ' and make requiredinmation = True telling the program something is missing
        Else
            lbl_PhoneNumberRequired.Hide() ' Hides the red *
        End If

        If CusBillAdress = "" Then ' if the customer bulling adress is blank then 
            lbl_BillingRequired.Show() ' it shows a red * leting the user know whats missing
            requiredinfomation = True ' Sets requiredinfomation = true so the program knows requred infomation is missing and not to move on
        Else
            lbl_BillingRequired.Hide() ' Hides the red *
        End If

        If CusDeliveryAdress = "" Then ' this checks if the delivery adress is blank
            lbl_DeliveryRequired.Show() ' if it is blank then it shows a red *
            requiredinfomation = True ' this then tells the program infomation is missing and not to move on
        Else
            lbl_DeliveryRequired.Hide() ' hides the red *
        End If


        If CusBusinessName = "" And cusTrade = True Then ' if the user selected they are a trade customer this then checks if they provided a business name
            lbl_BusinessNameRequired.Show() ' if they didn't provide a name it shows a red *
            requiredinfomation = True ' tells the program not to move on
        Else
            lbl_BusinessNameRequired.Hide() ' hides the red *

        End If


    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_CusPhoneNumber.MaskInputRejected
        CusPhoneNumber = txt_CusPhoneNumber.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        LoginForm1.Show() ' if the settings is selected it shows the login box
        Me.Hide() ' hides current form
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pic_exit.Click
        Application.Exit() ' when the user clicks the box it ends the program
    End Sub
End Class