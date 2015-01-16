; Sudo Scripts Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

AddBrandingImage top 20
Icon CmdScript.ico
Caption "Sudo Scripts Installer"
Name "Sudo Scripts"
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

Section "Install Red Context Menu"
  SetOutPath $INSTDIR
  File "..\Binaries\sudoRED.cmd"
  SetOutPath $TEMP
  File "..\Binaries\RedContextMenu-data\gen.bat"
  ExecWait '$TEMP\gen.bat'
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install Sudo Scripts. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] CmdScript.ico"
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
  Delete "$INSTDIR\Sudo Scripts-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\Sudo Scripts.exe"
  
  Delete "$SMPROGRAMS\DeavmiOSS\Sudo Scripts Options.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall Sudo Scripts.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
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