mode con: cols=14 lines=1
@echo Set objShell = CreateObject("Shell.Application") > %temp%\sudo.tmp.vbs
@echo args = %1 >> %temp%\sudo.tmp.vbs
@echo objShell.ShellExecute "%ProgramFiles%\Remove Empty Directories\RED2.exe", args, "", "runas" >> %temp%\sudo.tmp.vbs
@cscript %temp%\sudo.tmp.vbs