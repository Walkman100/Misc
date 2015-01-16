@echo off
color 0A
cd /d %~dp0
echo Copying CMD files...
xcopy "..\sudo.cmd" "%windir%"
xcopy "..\sudoRED.cmd" "%windir%"
echo Copying CMD files done.
echo.

gen.bat

echo Install Complete!

pause