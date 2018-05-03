; Sudo Scripts Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

!define ProgramName "Sudo Scripts"
Icon "ImageRes(#68).ico"

Name "${ProgramName}"
Caption "${ProgramName} Installer"
XPStyle on
ShowInstDetails show
AutoCloseWindow true

LicenseBkColor /windows
LicenseData "..\LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing ${ProgramName}. If you understand the notice, click the checkbox below and click Next."

InstallDir $WINDIR
OutFile "..\Binaries\${ProgramName}-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
Page custom postInstallShow postInstallFinish ": Install Complete"
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Uninstaller"
  SetOutPath $INSTDIR
  WriteUninstaller "SudoScripts-Uninst.exe"
SectionEnd

Section "Add to Windows Programs & Features"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "DisplayName" "${ProgramName}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "Publisher" "WalkmanOSS"
  
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "DisplayIcon" "C:\Windows\System32\cmd.exe"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "InstallLocation" "$INSTDIR\"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "UninstallString" "$INSTDIR\${ProgramName}-Uninst.exe"
  
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "NoRepair" 1
  
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "HelpLink" "https://github.com/Walkman100/${ProgramName}/issues/new"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "URLInfoAbout" "https://github.com/Walkman100/${ProgramName}" ; Support Link
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" "URLUpdateInfo" "https://github.com/Walkman100/${ProgramName}/releases" ; Update Info Link
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
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

; Custom Install Complete page

!include nsDialogs.nsh
!include LogicLib.nsh ; For ${IF} logic
Var Dialog
Var Label
Var CheckboxReadme
Var CheckboxReadme_State
Var CheckboxRunProgram
Var CheckboxRunProgram_State

Function postInstallShow
  nsDialogs::Create 1018
  Pop $Dialog
  ${If} $Dialog == error
    Abort
  ${EndIf}
  
  ${NSD_CreateLabel} 0 0 100% 12u "Setup will launch these tasks when you click close:"
  Pop $Label
  
  ${NSD_CreateCheckbox} 10u 30u 100% 10u "&Open Readme"
  Pop $CheckboxReadme
  ${If} $CheckboxReadme_State == ${BST_CHECKED}
    ${NSD_Check} $CheckboxReadme
  ${EndIf}
  
  ${NSD_CreateCheckbox} 10u 50u 100% 10u "&Launch ${ProgramName}"
  Pop $CheckboxRunProgram
  ${If} $CheckboxRunProgram_State == ${BST_CHECKED}
    ${NSD_Check} $CheckboxRunProgram
  ${EndIf}
  
  # alternative for the above ${If}:
  #${NSD_SetState} $Checkbox_State
  nsDialogs::Show
FunctionEnd

Function postInstallFinish
  ${NSD_GetState} $CheckboxReadme $CheckboxReadme_State
  ${NSD_GetState} $CheckboxRunProgram $CheckboxRunProgram_State
  
  ${If} $CheckboxReadme_State == ${BST_CHECKED}
    ExecShell "open" "https://github.com/Walkman100/Misc/blob/master/Binaries/README.md#sudocmd"
  ${EndIf}
  ${If} $CheckboxRunProgram_State == ${BST_CHECKED}
    ExecShell "open" "$INSTDIR\${ProgramName}.exe"
  ${EndIf}
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
  
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${ProgramName}" ; Remove Windows Programs & Features integration (uninstall info)
SectionEnd

; Uninstaller Functions

Function un.onInit
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function un.onUninstFailed
  MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
  MessageBox MB_OK "Uninstall Completed"
FunctionEnd
