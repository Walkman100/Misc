@echo off
echo Generating registry keys...

@echo Windows Registry Editor Version 5.00 > %temp%\REDContext.reg
@echo. >> %temp%\REDContext.reg
@echo [HKEY_CLASSES_ROOT\Folder\shell\Remove empty dirs] >> %temp%\REDContext.reg
@echo @="Remove empty dirs" >> %temp%\REDContext.reg
@echo "Icon"="%ProgramFiles%\\Remove Empty Directories\\RED2.exe" >> %temp%\REDContext.reg
@echo. >> %temp%\REDContext.reg
@echo [HKEY_CLASSES_ROOT\Folder\shell\Remove empty dirs\command] >> %temp%\REDContext.reg
@echo @="%ProgramFiles%\\Remove Empty Directories\\RED2.exe \"%%1\"" >> %temp%\REDContext.reg
@echo. >> %temp%\REDContext.reg
@echo [HKEY_CLASSES_ROOT\Folder\shell\Remove empty dirs (ADMIN)] >> %temp%\REDContext.reg
@echo @="Remove empty dirs (ADMIN)" >> %temp%\REDContext.reg
@echo "Icon"="%ProgramFiles%\\Remove Empty Directories\\RED2.exe" >> %temp%\REDContext.reg
@echo "HasLUAShield"="" >> %temp%\REDContext.reg
@echo. >> %temp%\REDContext.reg
@echo [HKEY_CLASSES_ROOT\Folder\shell\Remove empty dirs (ADMIN)\command] >> %temp%\REDContext.reg
@echo @="sudoRED \"%%1\"" >> %temp%\REDContext.reg

echo Generating registry keys done, attempting to merge...
%temp%\REDContext.reg