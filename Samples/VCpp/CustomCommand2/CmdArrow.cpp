#include "stdafx.h"

bool AddArrow (HANDLE hCmd, double x0, double y0, double x1, double y1);

//-----------------------------------------------
void CmdArrow_Create (HANDLE hLcWnd, int Id, LPCWSTR szName)
{
  lcCreateCommand( hLcWnd, Id, szName, false );
}

//-----------------------------------------------
void CmdArrow_Start (HANDLE hCmd, int Prm)
{
  int bOSnapOn, OSnapMode;

  lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 1 );
  // save current snap mode
  if (lcPropGetBool( hCmd, LC_PROP_CMD_OSNAP )){
    bOSnapOn = 1;
  }else{
    bOSnapOn = 0;
  }
  OSnapMode = lcPropGetInt( hCmd, LC_PROP_CMD_OSNAP );
  lcPropPutInt( hCmd, LC_PROP_CMD_INT0, bOSnapOn );
  lcPropPutInt( hCmd, LC_PROP_CMD_INT1, OSnapMode );
  // set snap mode for the command
  lcPropPutBool( hCmd, LC_PROP_CMD_OSNAP, true );
  lcPropPutInt( hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_ENDPOINT );
  lcCmdPrompt( hCmd, L"Input first point:" );
}

//-----------------------------------------------
void CmdArrow_Finish (HANDLE hCmd)
{
  int bOSnapOn, OSnapMode;

  // restore original snap modes
  bOSnapOn  = lcPropGetInt( hCmd, LC_PROP_CMD_INT0 );
  OSnapMode = lcPropGetInt( hCmd, LC_PROP_CMD_INT1 );
  if (bOSnapOn == 1){
    lcPropPutBool( hCmd, LC_PROP_CMD_OSNAP, true );
  }else{
    lcPropPutBool( hCmd, LC_PROP_CMD_OSNAP, false );
  }
  lcPropPutInt( hCmd, LC_PROP_CMD_OSNAP, OSnapMode );
}

//-----------------------------------------------
void CmdArrow_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  double X0, Y0;
  int Step;

  if (Button == LC_LBUTTON){
    Step = lcPropGetInt( hCmd, LC_PROP_CMD_STEP );
    switch( Step ){
      case 1:
        lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 2 );
        lcPropPutFloat( hCmd, LC_PROP_CMD_FLOAT0, X );
        lcPropPutFloat( hCmd, LC_PROP_CMD_FLOAT1, Y );
        lcPropPutInt( hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_MIDPOINT );
        lcCmdPrompt( hCmd, L"Input second point:" );
        break;
      case 2:
        X0 = lcPropGetFloat( hCmd, LC_PROP_CMD_FLOAT0 );
        Y0 = lcPropGetFloat( hCmd, LC_PROP_CMD_FLOAT1 );
        if (AddArrow( hCmd, X0, Y0, X, Y )){
          lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 1 );
          lcPropPutInt( hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_ENDPOINT );
          lcCmdPrompt( hCmd, L"Input first point:" );
        }else{
          lcCmdPrompt( hCmd, L"Input second point:" );
        }
        break;
    }
  }else{
    if (Button == LC_RBUTTON){
      lcCmdExit();  // exit command
    }
  }
}

//-----------------------------------------------
void CmdArrow_MouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CmdArrow_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  double X0, Y0;
  int Step;

  Step = lcPropGetInt( hCmd, LC_PROP_CMD_STEP );
  switch( Step ){
    case 1:
      lcCmdPrompt( hCmd, L"First point" );
      break;
    case 2:
      lcCmdPrompt( hCmd, L"Second point" );
      X0 = lcPropGetFloat( hCmd, LC_PROP_CMD_FLOAT0 );
      Y0 = lcPropGetFloat( hCmd, LC_PROP_CMD_FLOAT1 );
      lcCmdDrawLine( hCmd, X0, Y0, X, Y );
      break;
  }
}

//-----------------------------------------------
void CmdArrow_String (HANDLE hCmd, LPCWSTR szStr)
{
}


//-----------------------------------------------
bool AddArrow (HANDLE hCmd, double x0, double y0, double x1, double y1)
{
  HANDLE hBlock, hPline;
  double Len, x, y, dx, dy, w;

  dx = x1 - x0;
  dy = y1 - y0;
  Len = _hypot( dx, dy );
  if (Len > 0.0){
    x = x0 + (dx * 0.8);
    y = y0 + (dy * 0.8);
    w = Len * 0.02;
    hBlock = lcPropGetHandle( hCmd, LC_PROP_CMD_BLOCK );
    hPline = lcBlockAddPolyline( hBlock, 0, false, false );
    lcPlineAddVer2( hPline, 0, x0, y0, 0, w, w );
    lcPlineAddVer2( hPline, 0, x, y, 0, w*4.0, 0. );
    lcPlineAddVer2( hPline, 0, x1, y1, 0, 0.0, 0.0 );
    lcCmdRegen( hCmd, hPline );
    return true;
  }
  return false;
}

