@echo off
NuGet Pack SDammann.T4WPF.nuspec
Copy /B *.nupkg SDammann.T4WPF.nupkg
NuGet Push SDammann.T4WPF.nupkg
Erase *.nupkg
Pause