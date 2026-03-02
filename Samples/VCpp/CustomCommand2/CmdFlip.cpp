#include "stdafx.h"

//-----------------------------------------------
void CmdFlip_Create (HANDLE hLcWnd, int Id, LPCWSTR szName)
{
  lcCreateCommand( hLcWnd, Id, szName, true );
}

//-----------------------------------------------
void CmdFlip_Start (HANDLE hCmd, int Prm)
{
  // display a text in the command line
  lcCmdPrompt( hCmd, L"Input center point:" );
}

//-----------------------------------------------
void CmdFlip_Finish (HANDLE hCmd)
{
}

//-----------------------------------------------
void CmdFlip_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  HANDLE hBlock;

  hBlock = lcPropGetHandle( hCmd, LC_PROP_CMD_BLOCK );
  // rotate selected objects 90 degrees around point X,Y
  lcBlockSelRotate( hBlock, X,Y, 90*LC_DEG_TO_RAD, false, false );
  lcCmdRegen( hCmd, 0 );
  lcCmdRedraw( hCmd );
  lcCmdExit();
}

//-----------------------------------------------
void CmdFlip_MouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CmdFlip_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  // display a text near cursor
  lcCmdPrompt( hCmd, L"Input center point" );
}

//-----------------------------------------------
void CmdFlip_String (HANDLE hCmd, LPCWSTR szStr)
{
}

