'Imports Skybound.Gecko
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ' WebBrowser3.Navigate("http://notepad.cc/qntattiw")
        GeckoWebBrowser1.Navigate("http://sh.st/vHdKb")

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.TransformiceHackers.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("www.TransformiceHackers.com")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Automático.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Manual.Show()

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub LinkLabel2_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("www.TransformiceHackers.com")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Manual.Show()
        On Error Resume Next
        ' WebBrowser3.Document.GetElementById("contents").InnerText = WebBrowser3.Document.GetElementById("contents").InnerText + 1
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Automático.Show()
        On Error Resume Next
        'WebBrowser3.Document.GetElementById("contents").InnerText = WebBrowser3.Document.GetElementById("contents").InnerText + 1
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Automático.Close()
        Manual.Close()
        Me.Close()
    End Sub
    Private isMouseDown As Boolean
    Private mouseOffset As Point
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X + 11, -e.Y + 10)
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(Panel2.Location.X - e.X - 120, Panel2.Location.Y - e.Y - -6)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form2.Show()
        Form2.TextBox2.Focus()
        ' WebBrowser3.Document.GetElementById("contents").InnerText = WebBrowser3.Document.GetElementById("contents").InnerText + 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each processo As Process In Process.GetProcesses()
            If (processo.MainWindowTitle <> "") Then
                ListBox1.Items.Add("Programa: " & processo.MainWindowTitle)
            Else
                ListBox1.Items.Add("Processo: " & processo.ProcessName)
            End If
        Next processo
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If (ListBox1.Items(i).ToString.Contains("Cheat")) = True Or (ListBox1.Items(i).ToString.Contains("Decomp")) = True Or (ListBox1.Items(i).ToString.Contains("Olly")) = True Or (ListBox1.Items(i).ToString.Contains("Debug")) = True Or (ListBox1.Items(i).ToString.Contains("Engine")) = True Or (ListBox1.Items(i).ToString.Contains("engine")) = True Then
                'msg()
                ' Timer3.Start()
            End If
        Next

        If GeckoWebBrowser1.Url.ToString = "http://www.transformicehackers.com/?m=1" Then
            GeckoWebBrowser1.Navigate("http://www.transformicehackers.com/2015/08/Instant-Win-V6-att-DRK.html?m=1")
            GeckoWebBrowser1.Visible = False
            Timer4.Stop()
            Button11.Visible = False
        End If

    End Sub
    Public Sub msg()
        Form3.Show()
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Close()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        On Error Resume Next
        WebBrowser2.Navigate("http://notepad.cc/share/EUdcrZELot")
        TextBox1.Text = WebBrowser2.Document.GetElementById("contents").InnerText
        If TextBox1.Text = "01" Then
            MsgBox("Este hacker está desatualizado, acesse o site www.TransformiceHackers.com e atualize o hack!", MsgBoxStyle.OkOnly)
            Process.Start("http://www.transformicehackers.com/")
            Me.Close()
        End If
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Timer6.Start()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        'WebBrowser1.Document.GetElementById("skip_button").InvokeMember("click")
    End Sub

    Private Sub WebbrowserDRK1_Click(sender As Object, e As EventArgs)
        'WebbrowserDRK1.Document.GetElementById("skip_button").invokeMember("click")
    End Sub

    Private Sub Class11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer4_Tick_1(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim txt2 As Double = TextBox2.Text

        If Not TextBox2.Text < 0 Then
            TextBox2.Text = txt2 - 1
            Button11.Text = "Ou aguarde " & txt2 & " segundos..."
        Else
            GeckoWebBrowser1.Navigate("http://www.transformicehackers.com/2015/08/Instant-Win-V6-att-DRK.html?m=1")
            GeckoWebBrowser1.Visible = False
            Button11.Visible = False
        End If
    End Sub

    Private Sub GeckoWebBrowser1_Click(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.Click

    End Sub

    Private Sub GeckoWebBrowser1_DocumentCompleted(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.DocumentCompleted
        Timer7.Start()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Timer4.Start()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
End Class