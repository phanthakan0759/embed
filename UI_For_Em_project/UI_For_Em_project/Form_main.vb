Public Class Form_main

    Dim s As Integer
    Dim d As Integer
    Dim d_min As Integer
    Dim d_max As Integer
    Dim v1 As Double
    Dim v2 As Double

    Private Sub V_car_1_Scroll(sender As Object, e As ScrollEventArgs) Handles V_car_1.Scroll
        v1 = (V_car_1.Value / 91) * (8.5 - 4.2) + 4.2
        lab_v1.Text = v1.ToString("F1")
        d_min = ((s * v1) / (8.1 + v1)) + 1
        d_max = (s * v1) / (3.6 + v1) - 1
        dis.Maximum = d_max - d_min
        d = d_min + dis.Value
        lab_dis.Text = d.ToString
    End Sub

    Private Sub dis_Scroll(sender As Object, e As EventArgs) Handles dis.Scroll
        d = d_min + dis.Value
        lab_dis.Text = d.ToString
    End Sub

    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d_min = 28
        d = 28
        s = 78
        v1 = 4.2
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lab_dis_2.Text = d
        lab_dis_2_2.Text = d
        lab_v1_2.Text = v1.ToString("F1")
        lab_v2.Text = ((s - d) * (v1 / d)).ToString("F1")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v1 = Convert.ToDouble(lab_v1.Text)
        Dim temp_v1 As Integer
        temp_v1 = Integer.Parse((v1 * 10).ToString())
        Console.WriteLine(temp_v1.ToString("D3") + d.ToString("D3"))
        to_pic.Open()
        to_pic.Write(temp_v1.ToString("D3") + d.ToString("D3"))
        to_pic.Close()
    End Sub
End Class