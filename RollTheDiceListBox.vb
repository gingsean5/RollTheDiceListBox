
Option Strict On
Option Explicit On
'Sean Gingerich
'RCET0265
'Spring 2021
'Roll the Dice with List Box
'https://github.com/gingsean5/RolltheDiceListBox

Public Class RollTheDiceListBox
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim banana As Integer
        Dim RollCount As String
        RollCount = AddRandomNumbers()
        If DisplayListBox.Items.Count = 0 Then


            banana = CInt((77 - 14) / 2)
            'Header that reads Random Numbers in the middle
            DisplayListBox.Items.Add(StrDup(banana, " ") & "Random Numbers" & StrDup(banana, " "))
            'line of - 
            DisplayListBox.Items.Add(StrDup(100, "-"))
            'Just spaces out numbers 2 to 12
            'For i = 2 To 12
            'Next
            DisplayListBox.Items.Add(Str(2).PadLeft(6) & "|" _
                                 & Str(3).PadLeft(6) & "|" _
                                 & Str(3).PadLeft(6) & "|" _
                                 & Str(4).PadLeft(6) & "|" _
                                 & Str(5).PadLeft(6) & "|" _
                                 & Str(6).PadLeft(6) & "|" _
                                 & Str(7).PadLeft(6) & "|" _
                                 & Str(8).PadLeft(6) & "|" _
                                 & Str(9).PadLeft(6) & "|" _
                                 & Str(10).PadLeft(6) & "|" _
                                 & Str(11).PadLeft(6) & "|" _
                                 & Str(12).PadLeft(6) & "|")

            'line of -
            DisplayListBox.Items.Add(StrDup(100, "-"))

            DisplayListBox.Items.Add(RollCount)
        Else
            DisplayListBox.Items.Clear()
            banana = CInt((77 - 14) / 2)
            'Header that reads Random Numbers in the middle
            DisplayListBox.Items.Add(StrDup(banana, " ") & "Random Numbers" & StrDup(banana, " "))
            'line of - 
            DisplayListBox.Items.Add(StrDup(100, "-"))
            'Just spaces out numbers 2 to 12
            'For i = 2 To 12
            'Next
            DisplayListBox.Items.Add(Str(2).PadLeft(6) & "|" _
                                 & Str(3).PadLeft(6) & "|" _
                                 & Str(3).PadLeft(6) & "|" _
                                 & Str(4).PadLeft(6) & "|" _
                                 & Str(5).PadLeft(6) & "|" _
                                 & Str(6).PadLeft(6) & "|" _
                                 & Str(7).PadLeft(6) & "|" _
                                 & Str(8).PadLeft(6) & "|" _
                                 & Str(9).PadLeft(6) & "|" _
                                 & Str(10).PadLeft(6) & "|" _
                                 & Str(11).PadLeft(6) & "|" _
                                 & Str(12).PadLeft(6) & "|")

            'line of -
            DisplayListBox.Items.Add(StrDup(100, "-"))

            DisplayListBox.Items.Add(RollCount)

        End If
    End Sub

    Function AddRandomNumbers() As String
        Dim totalRoll As Integer
        Dim randomNumbers(12) As Integer
        Dim ReturnRandos As String
        For i = 0 To 1000
            totalRoll = (MakeRandoNumber(5) + 1) + (MakeRandoNumber(5) + 1)
            randomNumbers(totalRoll) += 1
        Next
        ReturnRandos = (CStr(randomNumbers(2)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(3)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(4)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(5)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(6)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(7)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(8)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(9)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(10)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(11)).PadLeft(6) & "|" _
                                     & CStr(randomNumbers(12)).PadLeft(6) & "|")
        Return ReturnRandos
    End Function
    Function MakeRandoNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
