mode con: cols=14 lines=1
@echo Set objShell = CreateObject("Shell.Application") > %temp%\sudo.tmp.vbs
@echo objShell.ShellExecute "%~dp0\Install2.bat", "", "", "runas" >> %temp%\sudo.tmp.vbs
@cscript %temp%\sudo.tmp.vbs