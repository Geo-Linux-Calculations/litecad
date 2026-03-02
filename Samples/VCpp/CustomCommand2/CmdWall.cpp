#include "stdafx.h"

//-----------------------------------------------
void CmdWall_Create (HANDLE hLcWnd, int Id, LPCWSTR szName)
{
  lcCreateCommand( hLcWnd, Id, szName, false );
}

//-----------------------------------------------
void CmdWall_Start (HANDLE hCmd, int Prm)
{
  HANDLE hView;
  int    bOrtho;

  hView = lcPropGetHandle( hCmd, LC_PROP_CMD_VIEW );
  // save current Ortho mode
  if (lcPropGetBool( hView, LC_PROP_VIEW_ORTHO )){
    bOrtho = 1;
  }else{
    bOrtho = 0;
  }
  lcPropPutInt( hCmd, LC_PROP_CMD_INT0, bOrtho );
  // set Ortho mode for the command
  lcPropPutBool( hView, LC_PROP_VIEW_ORTHO, true );
  // clear points buffer
  lcCmdClearPoints( hCmd );
}

//-----------------------------------------------
void CmdWall_Finish (HANDLE hCmd)
{
  int    i, nPnts, bOrtho;
  double x, y;
  HANDLE hBlock, hPline, hView;

  nPnts = lcPropGetInt( hCmd, LC_PROP_CMD_NPOINTS );
  if (nPnts >= 2){
    hBlock = lcPropGetHandle( hCmd, LC_PROP_CMD_BLOCK );
    hPline = lcBlockAddPolyline( hBlock, 0, false, false );
    for (i=0; i<nPnts; i++){
      lcCmdGetPoint( hCmd, i, &x, &y );
      lcPlineAddVer( hPline, 0, x, y );
    }
    lcPropPutFloat( hPline, LC_PROP_PLINE_WIDTH, 2.0 );
    lcPropPutStr( hPline, LC_PROP_ENT_COLOR, L"34" );
    lcCmdRegen( hCmd, hPline );
  }
  // restore previous Ortho mode
  hView = lcPropGetHandle( hCmd, LC_PROP_CMD_VIEW );
  bOrtho = lcPropGetInt( hCmd, LC_PROP_CMD_INT0 );
  if (bOrtho == 1){
    lcPropPutBool( hView, LC_PROP_VIEW_ORTHO, true );
  }else{
    lcPropPutBool( hView, LC_PROP_VIEW_ORTHO, false );
  }
}

//-----------------------------------------------
void CmdWall_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int nPnts;

  if (Button == LC_LBUTTON){
    nPnts = lcPropGetInt( hCmd, LC_PROP_CMD_NPOINTS );
    lcCmdAddPoint( hCmd, nPnts, X, Y );
    lcCmdSetBasePoint( hCmd, true, X,Y );
  }else{
    if (Button == LC_RBUTTON){
      lcCmdExit();  // exit command
    }
  }
}

//-----------------------------------------------
void CmdWall_MouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CmdWall_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int    i, nPnts;
  double x0, y0, x1, y1;

  nPnts = lcPropGetInt( hCmd, LC_PROP_CMD_NPOINTS );
  if (nPnts == 0){
    lcCmdPrompt( hCmd, L"First point" );
  }else{
    lcCmdPrompt( hCmd, L"Next point" );
    if (nPnts >= 2){
      lcCmdGetPoint( hCmd, 0, &x0, &y0 );
      for (i=1; i<nPnts; i++){
        lcCmdGetPoint( hCmd, i, &x1, &y1 );
        lcCmdDrawLine( hCmd, x0, y0, x1, y1 );
        x0 = x1;
        y0 = y1;
      }
    }
    lcCmdGetPoint( hCmd, nPnts-1, &x0, &y0 );
    lcCmdDrawLine( hCmd, x0, y0, X, Y );
  }
}

//-----------------------------------------------
void CmdWall_String (HANDLE hCmd, LPCWSTR szStr)
{
}

