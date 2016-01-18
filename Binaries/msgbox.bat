@echo off
if "z%1" == "z" (
        echo Usage: msgbox ^<main text^> [title] [buttons+style]
        echo "buttons+style" must be an integer or a vbValue
        echo For the list of vbValues see https://msdn.microsoft.com/en-us/library/sfw6660x%28v=vs.84%29.aspx#Anchor_2
        echo Example: msgbox "Continue?" "Batch Script" vbInformation+vbYesNo
        goto :EOF
    )
echo msgbox "%~1", %~3, "%~2" > %temp%\msgbox.tmp.vbs
rem To show the messagebox and continue, change the next line to start with "start wscript"
cscript %temp%\msgbox.tmp.vbs //Nologo