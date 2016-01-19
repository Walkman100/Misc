; Sudo Scripts Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

Icon "ImageRes(#68).ico"
Caption "Sudo Scripts Installer"
Name "Sudo Scripts"
XPStyle on
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "..\LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing Sudo Scripts. If you understand the notice, click the checkbox below and click Next."

InstallDir $WINDIR

OutFile "..\Binaries\Sudo Scripts-Installer.exe"

; Pages

Page license
Page components
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Uninstaller"
  SetOutPath $INSTDIR
  WriteUninstaller "SudoScripts-Uninst.exe"
SectionEnd

Section "Copy sudo.cmd to WinDir"
  SetOutPath $INSTDIR
  File "..\Binaries\sudo.cmd"
SectionEnd

Section "Copy sudoGUI.cmd to WinDir"
  SetOutPath $INSTDIR
  File "..\Binaries\sudoGUI.cmd"
SectionEnd

Section "Copy SudoCMD.exe to WinDir"
  SetOutPath $INSTDIR
  File "..\Binaries\SudoCMD.exe"
SectionEnd

Section "Copy SudoGUI.exe to WinDir"
  SetOutPath $INSTDIR
  File "..\Binaries\SudoGUI.exe"
SectionEnd

Section "Install RED Admin Context Menu"
  
  ; Copy command
  SetOutPath $INSTDIR
  File "..\Binaries\sudoRED.cmd"
  
  ; Link to it in registry
  WriteRegStr HKCR "Folder\shell\Remove empty dirs (ADMIN)" "" "Remove empty dirs (ADMIN)"
  WriteRegStr HKCR "Folder\shell\Remove empty dirs (ADMIN)" "Icon" "$PROGRAMFILES\Remove Empty Directories\RED2.exe"
  WriteRegStr HKCR "Folder\shell\Remove empty dirs (ADMIN)" "HasLUAShield" ""
  ; Above is what the item is called and it's icon, below is what is run on click:
  WriteRegStr HKCR "Folder\shell\Remove empty dirs (ADMIN)\command" "" "sudoRED $\"%1$\""
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install Sudo Scripts. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/Misc/blob/master/Binaries/README.md#sudocmd"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\SudoScripts-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\sudo.cmd"
  Delete "$INSTDIR\sudoGUI.cmd"
  Delete "$INSTDIR\SudoCMD.exe"
  Delete "$INSTDIR\SudoGUI.exe"
  Delete "$INSTDIR\sudoRED.cmd"
  DeleteRegKey HKCR "Folder\shell\Remove empty dirs (ADMIN)"
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall Sudo Scripts. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
