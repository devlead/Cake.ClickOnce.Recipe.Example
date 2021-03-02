#load "nuget:?package=Cake.ClickOnce.Recipe&version=0.2.0"

ClickOnce.ApplicationName = "MyApp";
ClickOnce.Publisher = "devlead";
ClickOnce.PublishUrl = "https://cakeclickonceexample.blob.core.windows.net/publish";
ClickOnce.RunBuild();