Public Class Jigsaw_Puzzle_Game

    Private PictureBoxes As PictureBox()

    Private Sub Jigsaw_Puzzle_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxes = New PictureBox() {Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9}

        For Each pb In PictureBoxes
            pb.AllowDrop = True
            AddHandler pb.MouseDown, AddressOf PictureBox_MouseDown
            AddHandler pb.DragEnter, AddressOf PictureBox_DragEnter
            AddHandler pb.DragDrop, AddressOf PictureBox_DragDrop
        Next
    End Sub

    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        If e.Button = MouseButtons.Left Then
            pb.DoDragDrop(pb, DragDropEffects.Move)
        End If
    End Sub

    Private Sub PictureBox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(GetType(PictureBox)) AndAlso DirectCast(e.Data.GetData(GetType(PictureBox)), PictureBox) IsNot DirectCast(sender, PictureBox) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PictureBox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim targetPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim draggedPictureBox As PictureBox = DirectCast(e.Data.GetData(GetType(PictureBox)), PictureBox)

        ' Swap the images between the target PictureBox and the dragged PictureBox
        Dim tempImage As Image = targetPictureBox.Image
        targetPictureBox.Image = draggedPictureBox.Image
        draggedPictureBox.Image = tempImage
    End Sub
End Class
