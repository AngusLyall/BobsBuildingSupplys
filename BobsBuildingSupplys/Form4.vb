Imports System.Xml ' used for the xml files that I create and read
Public Class Form4
    Dim ConfigPriceArray(16) As String

    Dim configxmldoc As XmlDocument ' Local Vairbles that will be used later this is for the location of the document and tells visual studio the format of xml
    Dim configresultlist As XmlNodeList
    Dim configresult As XmlNode

    Public BASICKIT As Decimal
    Public KITCHENOPTIONA As Integer
    Public KITCHENOPTIONB As Integer
    Public KITCHENOPTIONC As Integer
    Public BATHUPGRADE As Integer
    Public TV_AERIAL As Integer
    Public TV_AERIAL_POINT As Integer
    Public TV_SAT As Integer
    Public TV_SAT_POINT As Integer
    Public HEATPUMP1 As Integer
    Public HEATPUMP2 As Integer
    Public ONEGSOCKET As Integer
    Public TWOGSOCKET As Integer
    Public NETWORK_POINT As Integer
    Public NETWORK_SWITCH As Integer
    Public GST As Decimal
    Public TRADE As Decimal

    Public Sub configpriceset()
        Dim configoutput As String

        configxmldoc = New XmlDocument
        configxmldoc.Load("config.xml")
        configresultlist = configxmldoc.GetElementsByTagName("priceconfig")
        Dim loopvalue = -1

        For Each configresult In configresultlist
            configoutput = configresult.InnerText
            loopvalue = loopvalue + 1
            ConfigPriceArray(loopvalue) = configoutput
        Next

        BASICKIT = ConfigPriceArray(0)
        KITCHENOPTIONA = ConfigPriceArray(1)
        KITCHENOPTIONB = ConfigPriceArray(2)
        KITCHENOPTIONC = ConfigPriceArray(3)
        BATHUPGRADE = ConfigPriceArray(4)
        TV_AERIAL = ConfigPriceArray(5)
        TV_AERIAL_POINT = ConfigPriceArray(6)
        TV_SAT = ConfigPriceArray(7)
        TV_SAT_POINT = ConfigPriceArray(8)
        HEATPUMP1 = ConfigPriceArray(9)
        HEATPUMP2 = ConfigPriceArray(10)
        ONEGSOCKET = ConfigPriceArray(11)
        TWOGSOCKET = ConfigPriceArray(12)
        NETWORK_POINT = ConfigPriceArray(13)
        NETWORK_SWITCH = ConfigPriceArray(14)
        GST = ConfigPriceArray(15)
        TRADE = ConfigPriceArray(16)

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lbl_priceconfig_0.TextChanged

    End Sub
    Private Sub config()


        Dim configoutput As String

        configxmldoc = New XmlDocument
        configxmldoc.Load("config.xml")
        configresultlist = configxmldoc.GetElementsByTagName("priceconfig")
        Dim loopvalue = -1

        For Each configresult In configresultlist
            configoutput = configresult.InnerText
            loopvalue = loopvalue + 1
            ConfigPriceArray(loopvalue) = configoutput


        Next
        Dim labels() As TextBox
        labels = {lbl_priceconfig_0, lbl_priceconfig_1, lbl_priceconfig_2, lbl_priceconfig_3, lbl_priceconfig_4, lbl_priceconfig_5, lbl_priceconfig_6, lbl_priceconfig_7, lbl_priceconfig_8, lbl_priceconfig_9, lbl_priceconfig_10, lbl_priceconfig_11, lbl_priceconfig_12, lbl_priceconfig_13, lbl_priceconfig_14, lbl_priceconfig_15, lbl_priceconfig_16}
        loopvalue = -1
        For Each label In labels
            loopvalue = loopvalue + 1
            label.Text = ConfigPriceArray(loopvalue)
        Next



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim labels() As TextBox
        Dim loopvalue
        labels = {lbl_priceconfig_0, lbl_priceconfig_1, lbl_priceconfig_2, lbl_priceconfig_3, lbl_priceconfig_4, lbl_priceconfig_5, lbl_priceconfig_6, lbl_priceconfig_7, lbl_priceconfig_8, lbl_priceconfig_9, lbl_priceconfig_10, lbl_priceconfig_11, lbl_priceconfig_12, lbl_priceconfig_13, lbl_priceconfig_14, lbl_priceconfig_15, lbl_priceconfig_16}
        loopvalue = -1
        For Each label In labels
            loopvalue = loopvalue + 1
            ConfigPriceArray(loopvalue) = label.Text
        Next
        configxmldoc = New XmlDocument
        configxmldoc.Load("config.xml")
        configresultlist = configxmldoc.GetElementsByTagName("priceconfig")
        loopvalue = -1
        For Each price In configresultlist
            loopvalue = loopvalue + 1
            price.InnerText = ConfigPriceArray(loopvalue)
        Next
        configxmldoc.Save("config.xml")

        BASICKIT = ConfigPriceArray(0)
        KITCHENOPTIONA = ConfigPriceArray(1)
        KITCHENOPTIONB = ConfigPriceArray(2)
        KITCHENOPTIONC = ConfigPriceArray(3)
        BATHUPGRADE = ConfigPriceArray(4)
        TV_AERIAL = ConfigPriceArray(5)
        TV_AERIAL_POINT = ConfigPriceArray(6)
        TV_SAT = ConfigPriceArray(7)
        TV_SAT_POINT = ConfigPriceArray(8)
        HEATPUMP1 = ConfigPriceArray(9)
        HEATPUMP2 = ConfigPriceArray(10)
        ONEGSOCKET = ConfigPriceArray(11)
        TWOGSOCKET = ConfigPriceArray(12)
        NETWORK_POINT = ConfigPriceArray(13)
        NETWORK_SWITCH = ConfigPriceArray(14)
        GST = ConfigPriceArray(15)
        TRADE = ConfigPriceArray(16)

        MessageBox.Show("Prices Updated")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CustomerDetails.Show()
        Me.Hide()
    End Sub
End Class