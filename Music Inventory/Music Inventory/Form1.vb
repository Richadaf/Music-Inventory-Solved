Public Class frmMusic
    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click

        'Declarations
        Dim strSong(4) As String
        Dim strArtist(4) As String
        Dim intIndex As Integer
        Dim intStep As Integer = 1
        Dim StrEnd As String

        'Input Loop 
        Do
            StrEnd = InputBox("Do you want to enter a song and its artist? Y or N")

            If StrEnd.ToUpper = "Y" Then
                strSong(intIndex) = InputBox("Enter the song Title")
                strArtist(intIndex) = InputBox("Enter the Artist or Group")
            End If
            intIndex += 1
        Loop While StrEnd.ToUpper = "Y"
        'Output
        For intIndex = 0 To strSong.Length - 1 Step intStep
            lblOutput.Text += intIndex + 1 & "    " & strSong(intIndex) & "    " & strArtist(intIndex) & vbCrLf
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOutput.Text = Nothing
    End Sub
End Class

