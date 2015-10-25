# SousaSoft.LogStuff
VB.NET AutoIncremental LogReader/LogWritter (Net.FrameWork 2.0)

Usage:
Add the DLL to your project References
Add Imports SousaSoft.LogStuff on beginnig of your file

Use SousaSoft.LogStuff.Log.LogFile = My.Computer.FileSystem.CurrentPath & "\Log.txt" //in order to save in LaunchPath with name Log (Just an example)
Use SousaSoft.LogStuff.Log.Header = Environment.NewLine & " MYAPP LOG .... " //in order to add an header to the start of log (this will only add on first time the file is created)
Use SousaSoft.LogStuff.Log.Add("Text") // order to add text in your log. Edit Text for your Text :D


Use SousaSoft.LogStuff.LogViewer.LogFile = My.Computer.FileSystem.CurrentPath & "\Log.txt" //in order to save in LaunchPath with name Log (Just an example)
Use SousaSoft.LogStuff.LogViewer.CLReader().ToString() // in order to get current log in some richtextbox or some data stream

Check ExampleApp to have a simple overview

Any questions you can send me an email to sousasoftware2010@gmail.com
