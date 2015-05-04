mode con: cols=14 lines=1
@echo CreateObject("Shell.Application").ShellExecute "%ProgramFiles%\Remove Empty Directories\RED2.exe", ""%1"", "", "runas" >> %temp%\sudo.tmp.vbs
@cscript %temp%\sudo.tmp.vbs