@echo off
title Mednafen Updater
:choice
set /P c=Are you sure you want to continue [Y or N] = 
if /I "%c%" EQU "Y" goto :Start
if /I "%c%" EQU "N" goto :Exit
goto :Exit

:Start
TASKKILL /IM mednafen.exe /F
TASKKILL /IM mednafen-netplay.exe /F
wget.exe https://github.com/Retro-Nintendo-Online/Mednafen/raw/master/master.7z
7z x master.7z -y
mkdir temp
move mednafen.cfg temp
move config.dat temp
rmdir b /s /q
rmdir sav /s /q
cd master
move b ..\
move sav ..\
move cygwin1.dll ..\
move libcharset-1.dll ..\
move libFLAC-8.dll ..\
move libgcc_s_seh-1.dll ..\
move libiconv-2.dll ..\
move libogg-0.dll ..\
move libsndfile-1.dll ..\
move libstdc++-6.dll ..\
move libvorbis-0.dll ..\
move libvorbisenc-2.dll ..\
move mednafen.exe ..\
move mednafen.lck ..\
move mednafen-netplay.exe ..\
move mednafen-server.exe ..\
move netstart.bat ..\
move SCPH5501.BIN ..\
move SDL2.dll ..\
cd ..\
rmdir master /s /q
DEL master.zip
DEL .wget-hsts
cd temp
move mednafen.cfg ..\
move config.dat ..\
rmdir temp /s/ q
start mednafen-netplay.exe

:Exit
EXIT
