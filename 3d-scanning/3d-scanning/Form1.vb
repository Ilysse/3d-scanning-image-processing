﻿Public Class Form1
    Dim ImagePorcessing As New ImagePorcessing
    Dim dll As New DimensionnementImage.GestionImage
    Dim Drawing As Graphics
    Dim BlackPen As New Pen(Color.Black)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ImagePoints(,) As Color = ImagePorcessing.AfficherImage(TextBox1, PictureBox1, PictureBox2, PictureBox3)
    End Sub
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim RefPoints(,) As Color = ImagePorcessing.AfficherImage(TextBox2, PictureBox4, PictureBox5, PictureBox6)
    End Sub
  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Threshold(3) As Integer
        Threshold(0) = CInt(TextBox9.Text)
        Threshold(1) = CInt(TextBox10.Text)
        Threshold(2) = CInt(TextBox11.Text)
        Threshold(3) = CInt(TextBox4.Text)
        Dim RefPoints(,) As Color = ImagePorcessing.AfficherImageWithThreshold(TextBox2, PictureBox4, PictureBox5, PictureBox6, Threshold)
        Dim RefCentroid() As Double = ImagePorcessing.FindCentroid(RefPoints)
    End Sub


End Class

