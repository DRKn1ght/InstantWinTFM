Public Class Manual

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Timer1.Stop()
        'Timer2.Stop()
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

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short

    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim hotkey As Boolean
        hotkey = GetAsyncKeyState(Keys.F1)
        If hotkey = True Then
            Dim prs As Process() = Process.GetProcessesByName("Transformice")
            If prs.Length > 0 Then
                On Error Resume Next
                For Each po As Process In prs
                    Dim pi As ProcessModuleCollection = po.Modules
                    For Each pmod As ProcessModule In pi
                        If pmod.ModuleName = ("Adobe AIR.dll") Then
                            ' WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=1.930972782E-36)
                            WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=-5.715674379E-29)
                            TextBox1.Text = "1"
                        End If
                    Next
                Next
            End If
        Else
            Dim prs As Process() = Process.GetProcessesByName("Transformice")
            If prs.Length > 0 Then
                On Error Resume Next
                For Each po As Process In prs
                    Dim pi As ProcessModuleCollection = po.Modules
                    For Each pmod As ProcessModule In pi
                        If pmod.ModuleName = ("Adobe AIR.dll") Then
                            'WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=1.930972782E-36)
                            ' WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=-5.715674379E-29)
                            WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=1.930972782E-36)
                            TextBox1.Text = "22"
                        End If
                    Next
                Next
            End If
            '  WriteFloat("Transformice", pmod.BaseAddress + &H37110E, Value:=-5.715674379E-29)
            'TextBox1.Text = 2
        End If



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim prs As Process() = Process.GetProcessesByName("Transformice")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Automático.Show()

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            mousePos.Offset(mouseOffset.X - -13, mouseOffset.Y - -2)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label13_MouseDown(sender As Object, e As MouseEventArgs) Handles Label13.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(Panel2.Location.X - e.X - 80, Panel2.Location.Y - e.Y - 5)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Label13_MouseMove(sender As Object, e As MouseEventArgs) Handles Label13.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X - -13, mouseOffset.Y - -2)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Label13_MouseUp(sender As Object, e As MouseEventArgs) Handles Label13.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Form2.TextBox2.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub
End Class