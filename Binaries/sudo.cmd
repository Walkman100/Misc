@echo args = Right("%*", (Len("%*") - Len("%1"))) > %temp%\sudo.tmp.vbs
@echo CreateObject("Shell.Application").ShellExecute "%1", args, "", "runas" >> %temp%\sudo.tmp.vbs
@cscript %temp%\sudo.tmp.vbs