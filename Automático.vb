Public Class Automático

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label5.Text = "Ativado"

        Label5.ForeColor = Color.Green
        If RadioButton1.Checked = True Then
            Timer1.Start()
            Timer1.Interval = 6500
            Timer2.Start()
        End If
        If RadioButton2.Checked = True Then
            Timer1.Start()
            Timer1.Interval = 9500
            Timer2.Start()
        End If
        If RadioButton3.Checked = True Then
            Timer1.Start()
            Timer1.Interval = 11500
            Timer2.Start()
        End If
        If RadioButton4.Checked = True Then
            Timer1.Start()
            Timer1.Interval = 16500
            Timer2.Start()
        End If
        On Error Resume Next
        ' Form1.WebBrowser3.Document.GetElementById("contents").InnerText = Form1.WebBrowser3.Document.GetElementById("contents").InnerText + 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim prs As Process() = Process.GetProcessesByName("Transformice")
        If prs.Length > 0 Then
            On Error Resume Next
            For Each po As Process In prs
                Dim pi As ProcessModuleCollection = po.Modules
                For Each pmod As ProcessModule In pi
                    If pmod.ModuleName = ("Adobe AIR.dll") Then
                        WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=-5.715674379E-29)
                    Else
                    End If

                Next
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim prs As Process() = Process.GetProcessesByName("Transformice")
        If prs.Length > 0 Then
            On Error Resume Next
            For Each po As Process In prs
                Dim pi As ProcessModuleCollection = po.Modules
                For Each pmod As ProcessModule In pi
                    If pmod.ModuleName = ("Adobe AIR.dll") Then
                        WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=1.930972782E-36)
                    Else
                    End If

                Next
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Start()
        Label5.Text = "Desativado"
        Label5.ForeColor = Color.Red
        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Manual.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.TransformiceHackers.com")
    End Sub
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(Panel2.Location.X - e.X - 131, Panel2.Location.Y - e.Y - 7)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Label7_MouseMove(sender As Object, e As MouseEventArgs) Handles Label7.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Label7_MouseUp(sender As Object, e As MouseEventArgs) Handles Label7.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer1.Stop()
        Timer2.Stop()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Form2.TextBox2.Focus()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class