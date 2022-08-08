' This code will use the addded reference "Microsoft Excel Object Model"
Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FrmIndexScreen
    Dim SngData() As Single ' This variable will hold the data to be displayed
    Dim SngMean As Single   ' This variable will hold the value of the mean
    Dim SngSD As Single     ' This variable will hold the value of the standard deviation
    Dim ExportDirectoryString = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Chart.gif"

    Private Sub FrmIndexScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PnlValue_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlValue.MouseClick
        TxtValue.Focus()
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        ' This block of code will input numbers of data and their corresponding values
        Try
            If IsNothing(SngData) Then
                Dim NumberOfData = InputBox("Please specify the number(s) of data.", "Number(s) of Data")
                If String.IsNullOrWhiteSpace(NumberOfData) Then
                    Exit Sub
                Else
                    ReDim SngData(Double.Parse(NumberOfData) - 1)
                    DisplayData()
                    PnlValue.BackColor = Color.White
                    TxtValue.BackColor = Color.White
                    PnlData.Enabled = True
                    PnlValue.Enabled = True
                    BtnChange.Enabled = True
                    TxtIndex.Text = 0
                    TxtValue.Focus()
                End If
            Else
                If Not String.IsNullOrWhiteSpace(TxtValue.Text) Then
                    SngData(TxtIndex.Text) = TxtValue.Text
                    TxtIndex.Text += 1
                    TxtValue.Clear()
                    TxtValue.Focus()
                    DisplayData()
                    If TxtIndex.Text = UBound(SngData) + 1 Then
                        PnlValue.BackColor = Color.FromArgb(225, 225, 225)
                        TxtValue.BackColor = Color.FromArgb(225, 225, 225)
                        PnlValue.Enabled = False
                        BtnInput.Enabled = False
                        BtnCompute.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        Try
            Dim TargetIndex As ULong = InputBox("Specify from which index.", "Change Value")
            SngData(TargetIndex) = InputBox("Change the value in index " & TargetIndex & " to:", "New Value", SngData(TargetIndex))
            BtnCompute.Enabled = True
            DisplayData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Try
            Dim dblSum As Double
            For i = 0 To UBound(SngData)
                dblSum += SngData(i)
            Next
            SngMean = dblSum / (TxtIndex.Text)
            Dim dblSum2 As Double
            For j = 0 To UBound(SngData)
                dblSum2 += (SngData(j) - SngMean) ^ 2
            Next
            SngSD = Math.Sqrt(dblSum2 / TxtIndex.Text)

            TxtData.Text &= vbCrLf & "MEAN = " & Math.Round(SngMean, 3) & vbCrLf _
                                & "STANDARD DEVIATION = " & Math.Round(SngSD, 3)
            BtnCompute.Enabled = False
            BtnReset.Enabled = True
            BtnShowNPDC.Enabled = True
            SngMean = Math.Round(SngMean, 3)
            SngSD = Math.Round(SngSD, 3)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ' This block of code will return the original state of the application
        SngData = Nothing
        SngMean = Nothing
        SngSD = Nothing
        TxtIndex.Clear()
        TxtValue.Clear()
        TxtData.Clear()
        PnlValue.BackColor = Color.FromArgb(225, 225, 225)
        TxtValue.BackColor = Color.FromArgb(225, 225, 225)
        PnlValue.Enabled = False
        PnlData.Enabled = False
        BtnCompute.Enabled = False
        BtnReset.Enabled = False
        BtnShowNPDC.Enabled = False
        BtnInput.Enabled = True
        If ExportDirectoryString <> Nothing Then
            pbxNPDC.Image.Dispose()
            pbxNPDC.Image = Nothing
            My.Computer.FileSystem.DeleteFile(ExportDirectoryString)
            ExportDirectoryString = Nothing
        End If
    End Sub

    Dim ExcelObject As New Excel.Application
    Dim ExcelObjectWorkbook As Excel.Workbook
    Dim ExcelObjectSheet As Excel.Worksheet
    Dim ExcelObjectChart As Excel.Chart


    Private Sub BtnShowNPDC_Click(sender As Object, e As EventArgs) Handles BtnShowNPDC.Click
        ' This block of code will try to show the graph and return error message once an error occured
        Try
            ' This code will create an instance of excel
            Dim ExcelObjectWorkbook As Excel.Workbook
            Dim ExcelObjectSheet As Excel.Worksheet
            Dim ExcelObjectChart As Excel.Chart

            ExcelObjectChart = Nothing
            ExcelObjectSheet = Nothing
            ExcelObjectWorkbook = Nothing

            Dim ExcelObject As New Excel.Application With {
                .Visible = True
            }

            ' This block of code will create an excel file and 2 sheets
            ExcelObjectWorkbook = ExcelObject.Workbooks.Add
            ExcelObjectSheet = ExcelObject.Sheets("Sheet1")
            ExcelObjectChart = ExcelObject.Charts.Add

            Dim IncrementValue = 0.25 * SngSD
            Dim XMin = SngMean - 4 * (SngSD)
            Dim XMax = SngMean + 4 * (SngSD)
            Dim RowIndex = 0

            With ExcelObjectSheet
                .Range("A1").Value = "SD Factoring"
                .Range("B1").Value = "Probability"
                .Range("D1").Value = "Mean"
                .Range("D2").Value = "SD"
                .Range("E1").Value = SngMean
                .Range("E2").Value = SngSD
            End With

            ' Column A
            For XCurrent = XMin To XMax Step IncrementValue
                ExcelObjectSheet.Cells(RowIndex + 2, 1).value = XCurrent
                RowIndex += 1
            Next

            RowIndex = 0

            ' Column B
            For XCurrent = XMin To XMax Step IncrementValue
                ExcelObjectSheet.Cells(RowIndex + 2, 2).formula = "=NORM.DIST(A" & (RowIndex + 2) & ",E1,E2,FALSE)"
                RowIndex += 1
            Next

            ' Chart
            With ExcelObjectChart
                .ApplyCustomType(Excel.XlChartType.xlXYScatterSmoothNoMarkers)
                .SetSourceData(Source:=ExcelObjectSheet.Range("A2:B" & RowIndex))
                .HasLegend = False
                .HasTitle = True
                .ChartTitle.Text = "Normal Probability Distribution Curve"
            End With

            ' Export chart
            ExportDirectoryString = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Chart.gif"
            ExcelObjectChart.Export(Filename:=ExportDirectoryString)
            pbxNPDC.SizeMode = PictureBoxSizeMode.Zoom
            pbxNPDC.Image = Image.FromFile(ExportDirectoryString)

            ' This will dispose the excel instance
            ExcelObjectWorkbook.Saved = True
            ExcelObjectChart = Nothing
            ExcelObjectSheet = Nothing
            ExcelObjectWorkbook = Nothing
            ExcelObject.Quit()

            BtnChange.Enabled = False
            BtnCompute.Enabled = False
            BtnShowNPDC.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmIndexScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This block of code will delete the image file
        If ExportDirectoryString <> Nothing Then
            pbxNPDC.Image.Dispose()
            pbxNPDC.Image = Nothing
            My.Computer.FileSystem.DeleteFile(ExportDirectoryString)
        End If
    End Sub

    Private Sub FrmIndexScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape AndAlso BtnReset.Enabled = True Then
            BtnReset.PerformClick()
        End If
    End Sub

    Private Sub DisplayData()
        Dim StrHeader As String = "INDEX " & vbTab & ":" & vbTab & "VALUES" & vbCrLf & "=========================="
        Dim StrBody As String = ""
        For Counter = 0 To UBound(SngData) Step 1
            StrBody &= Counter & vbTab & vbTab & SngData(Counter) & vbCrLf
        Next
        TxtData.Text = StrHeader & vbNewLine & StrBody
    End Sub
End Class
