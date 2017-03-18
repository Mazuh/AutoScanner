# AutoScanner

An Windows automation for paper scanner service.

## Special contribution

This could NEVER be done without Miljenko's code and research for using WIA without dialogs:

http://miljenkobarbir.com/using-a-scanner-without-dialogs-in-net/

## Setting up

It's a regular Visual Studio project (2017 Community, but it should be work fine at any VS IDE). The solution file is inside AutoScanner subfolder.

If any errors occur, follow these instructions (or contact me):

- Download Windows Image Acquisition Lib from here: https://www.dllme.com/dll/download/3857/wiaaut.dll
- Copy the ```wiaaut.dll``` downloaded file to your system folder (that should be ```c:/windows/system32```)
- Register the component by typing ```regsvr32 wiaaut.dll```
- When you start VS project, open the project, and at Solution Explorer: right-click on the "References" node, choose "Add Reference" and find ```System.Drawing.dll``` and also search for ```wiaaut.dll```. Only do this, of course, if they both aren't yet listed in References.
