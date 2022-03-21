Public Class CustomerDetails
    Public CusFirstName As String
    Public CusLastName As String
    Public CusBusinessName As String
    Public CusPhoneNumber As String
    Public CusBillAdress As String
    Public CusDeliveryAdress As String
    Public cusTrade As Boolean = False
    Public cusAdressSame As Boolean = False
    Private Sub lbl_CusTitle_Click(sender As Object, e As EventArgs) Handles lbl_CusTitle.Click

    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If cusAdressSame = True Then
            CusDeliveryAdress = CusBillAdress
            txt_CusDeliveryAddress.Text = CusDeliveryAdress
        End If
    End Sub

    Private Sub txt_CusDeliveryAddress_TextChanged(sender As Object, e As EventArgs) Handles txt_CusDeliveryAddress.TextChanged
        CusDeliveryAdress = txt_CusDeliveryAddress.Text
    End Sub

    Private Sub chk_TradeCus_CheckedChanged(sender As Object, e As EventArgs) Handles chk_TradeCus.CheckedChanged
        If cusTrade = False Then
            cusTrade = True
        Else
            cusTrade = False
        End If
    End Sub
End Class
