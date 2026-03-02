#include "stdafx.h"

// menu commands
#define CMD_FILLET_EXIT    1
#define CMD_FILLET_RESUME  2
#define CMD_FILLET_RADIUS  3
#define CMD_FILLET_BISECT  4
#define CMD_FILLET_TANGENT 5

bool SetLines   (HANDLE hCmd);
bool MakeFillet (HANDLE hCmd, double Radius, double Bis, double Tang);
int  PopupMenu  (HANDLE hCmd);
void InputValue (HANDLE hCmd, int MenuCmd);

//-----------------------------------------------
void CmdFillet_Create (HANDLE hLcWnd, int Id, LPCWSTR szName)
{
  lcCreateCommand( hLcWnd, Id, szName, false );
}

//-----------------------------------------------
void CmdFillet_Start (HANDLE hCmd, int Prm)
{
  BOOL   b;

  // save previous grip mode
  b = lcPropGetBool( 0, LC_PROP_G_ENABLEGRIPS );
  lcPropPutInt( hCmd, LC_PROP_CMD_INT0, b );  
  // disable grips
  lcPropPutBool( 0, LC_PROP_G_ENABLEGRIPS, false );

  // save previous cursor mode
  b = lcPropGetBool( 0, LC_PROP_G_CURSORCROSS );
  lcPropPutInt( hCmd, LC_PROP_CMD_INT1, b );  
  // disable cross cursor
  lcPropPutBool( 0, LC_PROP_G_CURSORCROSS, false );

  // clear current selection
  lcCmdSelectEnt( hCmd, 0, false );
  // redraw window
  lcCmdRedraw( hCmd );
  // set step
  lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 1 );
  lcCmdPrompt( hCmd, L"Select first line" );
}

//-----------------------------------------------
void CmdFillet_Finish (HANDLE hCmd)
{
  int    ival;

  // restore previous grip mode
  ival = lcPropGetInt( hCmd, LC_PROP_CMD_INT0 );  
  if (ival == 0){
    lcPropPutBool( 0, LC_PROP_G_ENABLEGRIPS, false );
  }else{
    lcPropPutBool( 0, LC_PROP_G_ENABLEGRIPS, true );
  }

  // restore previous cursor mode
  ival = lcPropGetInt( hCmd, LC_PROP_CMD_INT1 );  
  if (ival == 0){
    lcPropPutBool( 0, LC_PROP_G_CURSORCROSS, false );
  }else{
    lcPropPutBool( 0, LC_PROP_G_CURSORCROSS, true );
  }

  // clear selection
  lcCmdSelectEnt( hCmd, 0, false );
  // redraw window
  lcCmdRedraw( hCmd );
}

//-----------------------------------------------
void CmdFillet_MouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int    Step, EntType, MenuCmd;
  double Bis, Xip, Yip;
  HANDLE hEnt, hEnt2;

  if (Button == LC_LBUTTON){
    Step = lcPropGetInt( hCmd, LC_PROP_CMD_STEP );
    switch( Step ){
      case 1:
        hEnt = lcCmdGetEntByPoint( hCmd, Xwin, Ywin );
        if (hEnt){
          EntType = lcPropGetInt( hEnt, LC_PROP_ENT_TYPE );
          if (EntType == LC_ENT_LINE){
            lcPropPutHandle( hCmd, LC_PROP_CMD_HAND0, hEnt );  // save first line
            lcCmdSelectEnt( hCmd, hEnt, true );
            lcCmdRedraw( hCmd );
            lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 2 );
            lcCmdPrompt( hCmd, L"Select second line:" );
            break;
          }
        }
        // repeat first step
        lcCmdPrompt( hCmd, L"Select first line" );
        break;

      case 2:
        hEnt2 = lcCmdGetEntByPoint( hCmd, Xwin, Ywin );
        if (hEnt2){
          EntType = lcPropGetInt( hEnt2, LC_PROP_ENT_TYPE );
          if (EntType == LC_ENT_LINE){
            hEnt = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND0 );
            if (hEnt2 != hEnt){
              lcPropPutHandle( hCmd, LC_PROP_CMD_HAND1, hEnt2 );  // save second line
              if (SetLines( hCmd )){
                lcCmdSelectEnt( hCmd, hEnt2, true );
                lcPropPutInt( hCmd, LC_PROP_CMD_STEP, 3 );
                lcCmdPrompt( hCmd, L"Specify fillet radius:" );
                lcPropPutBool( 0, LC_PROP_G_CURSORCROSS, true );
                lcCmdRedraw( hCmd );
              }
              break;
            }
          }
        }
        // repeat second step
        lcCmdPrompt( hCmd, L"Select second line:" );
        break;

      case 3:
        lcFilletGetPoint( 6, &Xip, &Yip );  // lines intersection point
        Bis = _hypot( X-Xip, Y-Yip );   // distance from X,Y to the intersection point
        if (MakeFillet( hCmd, 0, Bis, 0 )){
          lcDrwRegenViews( lcPropGetHandle( hCmd, LC_PROP_CMD_DRW ), 0 );
          lcCmdExit();  // exit command
        }
        break;

    }
  }else{
    if (Button == LC_RBUTTON){
      MenuCmd = PopupMenu( hCmd );
      switch( MenuCmd ){
        case CMD_FILLET_EXIT:
          lcCmdExit();  // exit command
          break;
        case CMD_FILLET_RADIUS:
        case CMD_FILLET_BISECT:
        case CMD_FILLET_TANGENT:
          InputValue( hCmd, MenuCmd );
          break;
      }
    }
  }
}

//-----------------------------------------------
void CmdFillet_MouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CmdFillet_MouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int Step;

  Step = lcPropGetInt( hCmd, LC_PROP_CMD_STEP );
  switch( Step ){
    case 1:
      lcCmdPrompt( hCmd, L"Select first line" );
      lcCmdDrawPickbox( hCmd, Xwin, Ywin );
      break;
    case 2:
      lcCmdPrompt( hCmd, L"Select second line" );
      lcCmdDrawPickbox( hCmd, Xwin, Ywin );
      break;
    case 3:
      lcCmdPrompt( hCmd, L"Bisector Length" );
      break;
  }
}

//-----------------------------------------------
void CmdFillet_String (HANDLE hCmd, LPCWSTR szStr)
{
  double R;
  int    Step;
  Step = lcPropGetInt( hCmd, LC_PROP_CMD_STEP );
  switch( Step ){
    case 3:  // Radius
      R = wcstod( szStr, NULL );
      if (R > 0.){
        if (MakeFillet( hCmd, R, 0, 0 )){
          lcDrwRegenViews( lcPropGetHandle( hCmd, LC_PROP_CMD_DRW ), 0 );
          lcCmdExit();  // exit command
          break;
        }
      }
      lcCmdPrompt( hCmd, L"Invalid value" );
      break;
  }
}

//-----------------------------------------------
bool SetLines (HANDLE hCmd)
{
  HANDLE hLine1 = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND0 );
  HANDLE hLine2 = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND1 );
  double L1x0, L1y0, L1x1, L1y1;
  double L2x0, L2y0, L2x1, L2y1;
  L1x0 = lcPropGetFloat( hLine1, LC_PROP_LINE_X0 );
  L1y0 = lcPropGetFloat( hLine1, LC_PROP_LINE_Y0 );
  L1x1 = lcPropGetFloat( hLine1, LC_PROP_LINE_X1 );
  L1y1 = lcPropGetFloat( hLine1, LC_PROP_LINE_Y1 );
  L2x0 = lcPropGetFloat( hLine2, LC_PROP_LINE_X0 );
  L2y0 = lcPropGetFloat( hLine2, LC_PROP_LINE_Y0 );
  L2x1 = lcPropGetFloat( hLine2, LC_PROP_LINE_X1 );
  L2y1 = lcPropGetFloat( hLine2, LC_PROP_LINE_Y1 );
  if (lcFilletSetLines( L1x0, L1y0, L1x1, L1y1, L2x0, L2y0, L2x1, L2y1 )){
    return true;
  }
  return false;
}

//-----------------------------------------------
bool MakeFillet (HANDLE hCmd, double Radius, double Bis, double Tang)
{
  HANDLE hBlock = lcPropGetHandle( hCmd, LC_PROP_CMD_BLOCK );
  HANDLE hLine1 = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND0 );
  HANDLE hLine2 = lcPropGetHandle( hCmd, LC_PROP_CMD_HAND1 );
  double L1x0, L1y0, L1x1, L1y1;
  double L2x0, L2y0, L2x1, L2y1;
  double x, y;
  
  L1x0 = lcPropGetFloat( hLine1, LC_PROP_LINE_X0 );
  L1y0 = lcPropGetFloat( hLine1, LC_PROP_LINE_Y0 );
  L1x1 = lcPropGetFloat( hLine1, LC_PROP_LINE_X1 );
  L1y1 = lcPropGetFloat( hLine1, LC_PROP_LINE_Y1 );
  L2x0 = lcPropGetFloat( hLine2, LC_PROP_LINE_X0 );
  L2y0 = lcPropGetFloat( hLine2, LC_PROP_LINE_Y0 );
  L2x1 = lcPropGetFloat( hLine2, LC_PROP_LINE_X1 );
  L2y1 = lcPropGetFloat( hLine2, LC_PROP_LINE_Y1 );

  if (lcFillet( Radius, Bis, Tang )){
    // line1 1st point
    lcFilletGetPoint( 0, &L1x0, &L1y0 );  
    lcPropPutFloat( hLine1, LC_PROP_LINE_X0, L1x0 );
    lcPropPutFloat( hLine1, LC_PROP_LINE_Y0, L1y0 );
    // line1 2nd point and arc's start point
    lcFilletGetPoint( 1, &L1x1, &L1y1 );  
    lcPropPutFloat( hLine1, LC_PROP_LINE_X1, L1x1 );
    lcPropPutFloat( hLine1, LC_PROP_LINE_Y1, L1y1 );
    // arc middle point
    lcFilletGetPoint( 2, &x, &y );  
    // line2 1st point and arc's end point
    lcFilletGetPoint( 3, &L2x0, &L2y0 );  
    lcPropPutFloat( hLine2, LC_PROP_LINE_X0, L2x0 );
    lcPropPutFloat( hLine2, LC_PROP_LINE_Y0, L2y0 );
    // line2 2nd point
    lcFilletGetPoint( 4, &L2x1, &L2y1 );  
    lcPropPutFloat( hLine2, LC_PROP_LINE_X1, L2x1 );
    lcPropPutFloat( hLine2, LC_PROP_LINE_Y1, L2y1 );
    // arc center point (optional)
//    lcFilletGetPoint( 5, &xc, &yc );  
    // add arc
    lcBlockAddArc3P( hBlock, L1x1, L1y1, x, y,  L2x0, L2y0 ); 
    return true;
  }
  return false;
}


//-----------------------------------------------
int PopupMenu (HANDLE hCmd)
{
  int    cmd = CMD_FILLET_RESUME;
  POINT  pt;
  HWND   hWnd = (HWND)lcPropGetHandle( hCmd, LC_PROP_CMD_HWND );
  HMENU  hMenu = ::CreatePopupMenu();
  if (hMenu){
    ::AppendMenu( hMenu, MF_STRING, CMD_FILLET_RADIUS, L"Input radius..." );
    ::AppendMenu( hMenu, MF_STRING, CMD_FILLET_BISECT, L"Input bisector length..." );
    ::AppendMenu( hMenu, MF_STRING, CMD_FILLET_TANGENT, L"Input tangent length..." );
    ::AppendMenu( hMenu, MF_SEPARATOR, 0,  0 );
    ::AppendMenu( hMenu, MF_STRING, CMD_FILLET_EXIT  , L"Exit" );
    // display menu
    pt.x = lcPropGetInt( hCmd, LC_PROP_CMD_CURSORX );
    pt.y = lcPropGetInt( hCmd, LC_PROP_CMD_CURSORY );
    ::ClientToScreen( hWnd, &pt );
    cmd = ::TrackPopupMenu( hMenu, TPM_LEFTALIGN | TPM_LEFTBUTTON | TPM_RETURNCMD | TPM_NONOTIFY, 
                            pt.x, pt.y, 0, hWnd, NULL );
    ::DestroyMenu( hMenu );
    lcCmdRedraw( hCmd );
  }
  return cmd;
}

//-----------------------------------------------
void InputValue (HANDLE hCmd, int MenuCmd)
{
  WCHAR* szCaption = L"Fillet";
  WCHAR  szValue[32];
  HWND   hWnd = (HWND)lcPropGetHandle( hCmd, LC_PROP_CMD_HWND );
  int    x = lcPropGetInt( hCmd, LC_PROP_CMD_CURSORX );
  int    y = lcPropGetInt( hCmd, LC_PROP_CMD_CURSORY );
  double Rad = 0.0;
  double Bis = 0.0;
  double Tang = 0.0;

  szValue[0] = 0;
//  swprintf( szValue, L"%.3f", Rad );
  switch( MenuCmd ){
    case CMD_FILLET_RADIUS:
      wcscpy( szValue, lcGetValue( hWnd, x, y, szCaption, L"Enter Radius:", szValue ) );
      if (szValue[0] != 0){
        Rad = wcstod( szValue, NULL );
      }
      break;
    case CMD_FILLET_BISECT:
      wcscpy( szValue, lcGetValue( hWnd, x, y, szCaption, L"Enter Bisector Length:", szValue ) );
      if (szValue[0] != 0){
        Bis = wcstod( szValue, NULL );
      }
      break;
    case CMD_FILLET_TANGENT:
      wcscpy( szValue, lcGetValue( hWnd, x, y, szCaption, L"Enter Tangent Length:", szValue ) );
      if (szValue[0] != 0){
        Tang = wcstod( szValue, NULL );
      }
      break;
  }
  lcCmdSetFocus( hCmd );
  if (Rad > 0.0 || Bis > 0.0 || Tang > 0.0){
    if (MakeFillet( hCmd, Rad, Bis, Tang )){
      lcDrwRegenViews( lcPropGetHandle( hCmd, LC_PROP_CMD_DRW ), 0 );
      lcCmdExit();  // exit command
      return;
    }
  }
}