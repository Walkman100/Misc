@echo off
color 0A
cd /d %~dp0
echo Copying CMD files...
xcopy "..\sudo.cmd" "%windir%"
xcopy "..\sudoRED.cmd" "%windir%"
echo Copying CMD files done.
echo.
echo Attempting to merge pre-generated registry keys...
ShellItem.reg

echo Install Complete!

pause