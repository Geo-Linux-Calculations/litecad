#include "stdafx.h"

//-----------------------------------------------
void CmdSketch_Create (HANDLE hLcWnd, int Id, LPCWSTR szName)
{
  lcCreateCommand( hLcWnd, Id, szName, false );
}

//-----------------------------------------------
void CmdSketch_Start (HANDLE hCmd, int Prm)
{
  lcPropPutInt( hCmd, LC_PROP_CMD_INT0, 0 );    // do not draw
  lcPropPutHandle( hCmd, LC_PROP_CMD_HAND0, 0 ); // polyline
}

//-----------------------------------------------
void CmdSketch_Finish (HANDLE hCmd)
{
}

//-----------------------------------------------
void CmdSketch_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  HANDLE hBlock, hPline;

  switch( Button ){
    case LC_LBUTTON:
      hBlock = lcPropGetHandle( hCmd, LC_PROP_CMD_BLOCK );
      hPline = lcBlockAddPolyline( hBlock, 0, false, false );
      lcPropPutHandle( hCmd, LC_PROP_CMD_HAND0, hPline );  // polyline
      lcPropPutInt( hCmd, LC_PROP_CMD_INT0, 1 );   // draw
      break;
    case LC_RBUTTON:
      lcCmdExit();  // exit command
      break;
  }
}

//-----------------------------------------------
void CmdSketch_MouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  if (Button == LC_LBUTTON){
    lcPropPutInt( hCmd, LC_PROP_CMD_INT0, 0 );  // do not draw
  }
}

//-----------------------------------------------
void CmdSketch_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  HANDLE hPline;
  int    bDraw;

  bDraw = lcPropGetInt( hCmd, LC_PROP_CMD_INT0 );
  if (bDraw == 1){
    hPline = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND0 );
    lcPlineAddVer( hPline, 0, X, Y );
    lcCmdRegen( hCmd, hPline );
    lcCmdRedraw( hCmd );
  }
}

//-----------------------------------------------
void CmdSketch_String (HANDLE hCmd, LPCWSTR szStr)
{
}

