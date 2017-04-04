# AutoScanner


A Windows automation for paper scanner service. Made for a post-graduation office -- where I currently work as an intern at university -- scan some documents quickly and easily. 

Unlike the standard "Windows Fax and Scan" software, AutoScanner is simpler and has an improved design of user experience (although a little ugly), ergonomic for my office's requirements.

Tested device: HP LaserJet Pro M1536dnf MFP.

Warning: I am not a C# programmer, so if you find some weirdo code... er... tell me. :)

## Special contribution

This could never be done without Miljenko's code and research for using WIA without dialogs:

http://miljenkobarbir.com/using-a-scanner-without-dialogs-in-net/

## Setting up

It's a regular Visual Studio project (2017 Community, but it should be ok at any VS IDE). The solution file is inside AutoScanner subfolder.

If any errors occur or you're trying to develop this code by your own from the start, just read/remember/obey MIT License and follow these instructions (or contact me, I'd be glad to help, despite I'm not a C# developer):

- Download Windows Image Acquisition Lib from here: https://www.dllme.com/dll/download/3857/wiaaut.dll
- Copy the ```wiaaut.dll``` downloaded file to your system folder (that should be ```c:/windows/system32```)
- Register the component by typing ```regsvr32 wiaaut.dll``` (I did this here but I don't know if it was really useful)
- When you start VS project, open the project, and at Solution Explorer: right-click on the "References" node, choose "Add Reference" and find ```System.Drawing.dll``` and also search for ```wiaaut.dll```. Only do this, of course, if they both aren't yet listed in References.

In case you're noob as I am for C# and .NET programming, let me help you to understand the code:

- ```/AutoScanner/AutoScanner/MainForm.Designer.cs```: Where the Windows Form (our GUI) elements are organized (still as C#, cause I'm dumb and don't know how to use VS Designing functions).
- ```/AutoScanner/AutoScanner/MainForm.cs```: Here should be the form "control center", where I make good use of "./WIA/WIAScanner.cs" methods.
- ```/AutoScanner/AutoScanner/Program.cs```: It's the very beginning, contains the main function calling the form.
- ```/AutoScanner/AutoScanner/WIA/WIAScanner.cs```: It's the WIA class that Miljenko's wrote to access devices and use them -- I would say it's an abstraction layer for you and I only use as a magic stuff (actually, there is a pretty short and readable code, so take a look, cause the really heavy work is done by WIA dll).
- There are other files, but I really don't know what they are... I'll keep believing they're important for a while, because they are (at least for .NET and VS environment).
