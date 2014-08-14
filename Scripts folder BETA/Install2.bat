@echo off
cd %~dp0
xcopy "install-data\sudo.cmd" "%windir%\system32"
xcopy "install-data\sudoRED.cmd" "%windir%\system32"
"install-data\Context menu item Combined.reg"
echo Install Complete!
pause