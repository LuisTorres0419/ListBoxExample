
Option Strict On
Option Explicit On

Public Class ListBoxExmpleForm
    Private Sub ListBoxExmpleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFakeData()
        UpdateListBox(DataKeeper(""))
    End Sub

    Sub UpdateListBox(displayData As List(Of String))


        ' DisplayListBox.Items.Add("hello")
        'DisplayListBox.Items.Add("Blah")
        'DisplayListBox.Items.Add("Bru")


        For Each thingy In displayData

            DisplayListBox.Items.Add("thingy")

        Next


    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Me.Text = DisplayListBox.SelectedItem.ToString
        'Me.Text = DisplayListBox.SelectedIndex.ToString
    End Sub

    Function DataKeeper(ByVal currentData As String) As List(Of String)
        Static Dim data As New List(Of String)
        data.Add(currentData)

        Return data
    End Function


    Sub LoadFakeData()

        For i = 0 To 10
            DataKeeper(StrDup(i, "*"))
        Next

    End Sub

    Private Sub ListBoxExmpleForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.Text = Me.Height.ToString
        DisplayListBox.Height = CInt(Me.Height * 0.8)
        DisplayListBox.Width = CInt(Me.Width * 0.6)
    End Sub
End Class

