; Rufus Context menu Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

Icon "Rufus.ico"
Caption "Rufus Context menu Installer"
Name "Rufus Context menu"
XPStyle on
AutoCloseWindow true
ShowInstDetails show

InstallDir $WINDIR
DirText "Select the folder containing Rufus:"

OutFile "Binaries\RufusContextMenuInstaller.exe"

; Pages

Page directory
Page components
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Add Rufus to context menu"
  WriteRegStr HKCR "Drive\shell\Rufus" "" "Format with Rufus..."
  WriteRegStr HKCR "Drive\shell\Rufus" "Icon" "$INSTDIR\Rufus.exe"
  WriteRegStr HKCR "Drive\shell\Rufus\command" "" "$\"$INSTDIR\Rufus.exe$\" $\"%1$\""
SectionEnd

Section /o "Remove Rufus from context menu"
  DeleteRegKey HKCR "Folder\shell\Rufus"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will add an entry to the Explorer Context menu on drives to open Rufus. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_OK "Install Complete"
FunctionEnd
