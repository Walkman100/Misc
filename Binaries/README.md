## sudo.cmd
- To 'install' this script, just copy the `sudo.cmd` file to your `C:\Windows` folder (requires admin rights)
- This script allows you to execute commands as administrator (it does ask for your password though, so not a security hack) in Windows command prompt (CMD) for example, without opening the command prompt as admin
- After install, try opening command prompt (<kbd>⊞ Win</kbd> & <kbd>R</kbd>, type `cmd`, <kbd>enter</kbd>) and executing `sudo taskmgr`
- It also allows making shortcuts that run as admin, for example you can make a shortcut on your desktop that links to `sudo taskmgr` and runs Task Manager as admin when you open it.

## sudoGUI.cmd
This file is almost exactly the same as `sudo.cmd`, the only difference is instead of using `cscript.exe` to launch the `sudo.tmp.vbs` file it uses `wscript.exe`:
- `csript` stands for Command Script, File Description is: `Microsoft ® Console Based Script Host`
- `wscript` stands for Window Script, File Description is: `Microsoft ® Windows Based Script Host`

## sudoRED.cmd
This file is part of the `InstallRedContextMenu` script - run `InstallRedContextMenu.vbs` with this file and the `RedContextMenu-data` folder in the same directory as it, and it will install this Windows Explorer context menu item for [RED (remove empty directories)](http://sourceforge.net/projects/rem-empty-dir/files/red-v2.2-setup.exe/download).

## SudoCMD.exe & SudoGUI.exe
These are very simple programs that I made myself, you can view the source [here](https://github.com/Walkman100/Misc/tree/master/Sudo.NET). As you can see in the [SudoCMD.vb](https://github.com/Walkman100/Misc/blob/master/Sudo.NET/SudoCMD.vb) file, the code is almost exactly the same (since the `sudo.cmd` file uses `VBS` - `Visual Basic Script`, and these projects are written in `VB.Net` - `Visual Basic in Microsoft Net`). Build status of current source code: [![Build status](https://ci.appveyor.com/api/projects/status/6ptclhrdhs1e5c8c)](https://ci.appveyor.com/project/Walkman100/misc-847)

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/Walkman100/Walkman?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
