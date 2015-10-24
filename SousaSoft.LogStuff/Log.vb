Imports System.IO
Imports System.Text
Imports System.Windows.Forms


Public Class Log
    ''
    '' LogStuff.....
    ''
    '' Purpose= Read the current log from file and write the new messages to the log
    ''
    '' Usage= In any form just use LogStuff.Writer("Text") and it will add a new line of log
    ''


    Public Shared LogFile As String
    Public Shared PreviousLog As String '' Identifier to read current log from file
    Public Shared Header As String
    Public Shared Function PLReader() As String '' Function that will read the previous log from file
        If My.Computer.FileSystem.FileExists(LogFile) Then '' Check if we already have a log. If positive will load the previous log to memory
            Dim SR As New IO.StreamReader(LogFile)
            PreviousLog = SR.ReadToEnd()
            SR.Close()
        Else '' If negative will create a new log with default log message
            PreviousLog = Header & Environment.NewLine
        End If

    End Function
    Public Shared Function Add(ByVal Text As String) As String '' Will write any new text to the log file
        PLReader() '' Load function that will read the previous log from file
        Dim SW As New IO.StreamWriter(LogFile)
        SW.Write(PreviousLog)
        SW.WriteLine("[LOG]= " & Text & " | " & DateTime.Now.ToLongTimeString & " | " & DateTime.Now.ToLongDateString)
        SW.Close()
        Return ""
    End Function
End Class
Public Class LogShow
    Public Shared LogFile As String
    Public Shared CurrentLog As String
    Public Shared Function CLReader() As String

        If My.Computer.FileSystem.FileExists(LogFile) Then '' Check if we already have a log. If positive will load the previous log to memory
            Dim SR As New IO.StreamReader(LogFile)
            CurrentLog = SR.ReadToEnd()
            SR.Close()
        Else '' If negative will create a new log with default log message
            CurrentLog = Environment.NewLine
        End If
        Return CurrentLog
    End Function
End Class