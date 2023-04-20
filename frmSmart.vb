' Program Name: Smart Home Electric Savings Windows Application
' Purpose:      The smart home electric savings windows application uses a
'               text file that contains the 12 months od electric bill savings
'               after the smart home devices were activated.

Option Strict On

Public Class frmSmart
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmSmart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmBill load event reads the savings text file
        ' fills the combobox object with the months
        ' Initialize an instance of the StreamReader object
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblSavings.Text = ""
        lblAverageSavings.Text = ""
        lblMaxSavings.Text = ""

        ' The if statement verifies that the file exists
        If IO.File.Exists("C:\VB\SmartHomeApplication\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\VB\SmartHomeApplication\savings.txt")
            ' The file is read line by line until the file is completed
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            ' The combobox object is filled with bill years
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        ' The cboMonths SelectedIndexChanged displays the savings for the selected month
        Dim intSelectedCityInteger As Integer

        intSelectedCityInteger = cboMonths.SelectedIndex
        lblSavings.Text = "The electric savings for " & _strSavings(intSelectedCityInteger) & " is $" & _decBill(intSelectedCityInteger).ToString()
        btnStatistics.Visible = True
    End Sub
    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ' The btnStatistics click event calls two sub methods to compute the average monthly savings and
        ' the most savings for a given month
        ComputeAverage()
        ComputeMaxSavings()

    End Sub

    Private Sub ComputeMaxSavings()
        ' The ComputeMaxSavings Sub method determines the month with the most electric bill savings for the year
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMaxSavings.Text = strYearValue & " had the most significant monthly savings"
    End Sub

    Private Sub ComputeAverage()
        ' The ComputeAverage Sub method computes the average number of electric bill savings of bill
        ' in the years from 2000-2017
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageSavings.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")

    End Sub
End Class
