#pragma once

#include "resource.h"

void CmdSketch_Create    (HANDLE hLcWnd, int Id, LPCWSTR szName);
void CmdSketch_Start     (HANDLE hCmd, int Prm);
void CmdSketch_Finish    (HANDLE hCmd);
void CmdSketch_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdSketch_MouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdSketch_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdSketch_String    (HANDLE hCmd, LPCWSTR szStr);

void CmdFlip_Create    (HANDLE hLcWnd, int Id, LPCWSTR szName);
void CmdFlip_Start     (HANDLE hCmd, int Prm);
void CmdFlip_Finish    (HANDLE hCmd);
void CmdFlip_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFlip_MouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFlip_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFlip_String    (HANDLE hCmd, LPCWSTR szStr);

void CmdArrow_Create    (HANDLE hLcWnd, int Id, LPCWSTR szName);
void CmdArrow_Start     (HANDLE hCmd, int Prm);
void CmdArrow_Finish    (HANDLE hCmd);
void CmdArrow_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdArrow_MouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdArrow_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdArrow_String    (HANDLE hCmd, LPCWSTR szStr);

void CmdWall_Create    (HANDLE hLcWnd, int Id, LPCWSTR szName);
void CmdWall_Start     (HANDLE hCmd, int Prm);
void CmdWall_Finish    (HANDLE hCmd);
void CmdWall_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdWall_MouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdWall_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdWall_String    (HANDLE hCmd, LPCWSTR szStr);

void CmdFillet_Create    (HANDLE hLcWnd, int Id, LPCWSTR szName);
void CmdFillet_Start     (HANDLE hCmd, int Prm);
void CmdFillet_Finish    (HANDLE hCmd);
void CmdFillet_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFillet_MouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFillet_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
void CmdFillet_String    (HANDLE hCmd, LPCWSTR szStr);
