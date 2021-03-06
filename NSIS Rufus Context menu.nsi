; Rufus Context menu Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download

Icon "Rufus.ico"
Caption "Rufus Context menu Installer"
Name "Rufus Context menu"
XPStyle on
Unicode true
AutoCloseWindow true
ShowInstDetails show
Var RufusPath

OutFile "Binaries\RufusContextMenuInstaller.exe"

; Pages

Page components
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Add Rufus to context menu"
  MessageBox MB_OK "Select the Rufus exe that you are using in the next window"
  Call nsDialogsPage
  WriteRegStr HKCR "Drive\shell\Rufus" "" "Format with Rufus..."
  WriteRegStr HKCR "Drive\shell\Rufus" "Icon" "$RufusPath"
  WriteRegStr HKCR "Drive\shell\Rufus" "HasLuaShield" ""
  WriteRegStr HKCR "Drive\shell\Rufus\command" "" "$\"$RufusPath$\" $\"%1$\""
SectionEnd

Section /o "Remove Rufus from context menu"
  DeleteRegKey HKCR "Drive\shell\Rufus"
SectionEnd

; Functions

Function nsDialogsPage
  nsDialogs::SelectFileDialog "open" $WINDIR "Executables|*.exe"
  Pop $RufusPath
FunctionEnd

Function .onInit
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
  MessageBox MB_OK "Install Complete"
FunctionEnd
