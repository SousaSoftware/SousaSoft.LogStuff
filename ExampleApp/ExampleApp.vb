Imports SousaSoft.LogStuff

Public Class ExampleApp
    Public Log As SousaSoft.LogStuff.Log
    Public LogShow As SousaSoft.LogStuff.LogShow
    Public Shared appinfover As String
    Private Sub ExampleApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Never use Application.StartUpPath since DLL is not reading from your main app and will crash
        '' Use My.Computer.FileSystem.CurrentDirectory instead
        Label2.Text = My.Computer.FileSystem.CurrentDirectory & "\Example.log.txt"
        Log.LogFile = Label2.Text
        LogShow.LogFile = Label2.Text
        '' You can use a Public Shared String in order to send some info from your main application like ProductVersion or CompanyName
        appinfover = "AppName= " & Application.ProductName & " | AppVersion= " & Application.ProductVersion
        Log.Header = "Default Text on StartUp" & Environment.NewLine & appinfover
        '' Update our log richtextbox
        UpdateLOGViewer()
    End Sub
    Public Sub UpdateLOGViewer()
        RichTextBox1.Text = LogShow.CLReader.ToString()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            '' Add text to log :D
            Log.Add("CheckBox1 Checked")
            '' Update our log richtextbox
            UpdateLOGViewer()
        End If
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Log.Add("CheckBox1 Unchecked")
            UpdateLOGViewer()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log.Add("Test Button Clicked")
        UpdateLOGViewer()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Log.Add("Test ComboBox1 with Text= " & ComboBox1.Text)
        UpdateLOGViewer()
    End Sub
End Class
