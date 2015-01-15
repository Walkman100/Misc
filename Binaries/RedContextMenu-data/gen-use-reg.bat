@echo off
color 0A
cd %~dp0
xcopy "sudo.cmd" "%windir%"
xcopy "sudoRED.cmd" "%windir%"
"ShellItem.reg"
echo Install Complete!
pause