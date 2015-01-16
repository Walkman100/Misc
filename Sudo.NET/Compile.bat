@echo off

"%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release Sudo.NET.sln

"%ProgramFiles%\NSIS\makensis.exe" "NSIS Installer for Sudo.NET.nsi"

explorer.exe "%~dp0..\Binaries"