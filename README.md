# AutoScanner
An Windows automation for paper scanner service.

## Setting up

- Clone this repository, of course.
- Download Windows Image Acquisition Lib from here:
```https://www.dllme.com/dll/download/3857/wiaaut.dll```
- Copy the wiaaut.dll downloaded file to your system folder (that should be ```c:/windows/system32```)
- Register the component by typing “regsvr32 wiaaut.dll”
- When you start VS project, at Solution Explorer: right-click on the "References" node, choose "Add Reference" and find System.Drawing.dll and also search for wiaaut.dll. Only do this, of course, if they both aren't yet listed in References.

## Special contribution

This could NEVER be done without Miljenko's code and research: http://miljenkobarbir.com/using-a-scanner-without-dialogs-in-net/

