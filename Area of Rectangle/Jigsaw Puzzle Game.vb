Public Class Jigsaw_Puzzle_Game
    Private Sub Jigsaw_Puzzle_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the event handler for each PictureBox control
        For i = 1 To 9
            Dim pictureBox As PictureBox = DirectCast(Me.Controls("Image" & i), PictureBox)
            pictureBox.AllowDrop = True
            pictureBox.Tag = i ' Set the tag value to identify the pieces

            AddHandler pictureBox.MouseDown, AddressOf Image_MouseDown
            AddHandler pictureBox.DragEnter, AddressOf Image_DragEnter
            AddHandler pictureBox.DragDrop, AddressOf Image_DragDrop
        Next i
    End Sub

    Private Sub Image_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
            pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move)
        End If
    End Sub

    Private Sub Image_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Image_DragDrop(sender As Object, e As DragEventArgs)
        Dim targetPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim sourcePictureBox As PictureBox = DirectCast(e.Data.GetData(GetType(PictureBox)), PictureBox)

        ' Swap the images between source and target picture boxes
        Dim tempImage As Image = targetPictureBox.Image
        targetPictureBox.Image = sourcePictureBox.Image
        sourcePictureBox.Image = tempImage
    End Sub
End Class
