#include "stdafx.h"



//=============================================================================
CCmdBase::CCmdBase (int Id, LPCWSTR szName, bool bNeedSelection)
{
  m_ID = Id;
  wcsncpy( m_szName, szName, 31 );
  m_szName[31] = 0;
  m_bNeedSelection = bNeedSelection;
  m_hCmd = 0;
  m_hLcWnd = 0;
}
 
//-----------------------------------------------
bool CCmdBase::Create (HANDLE hLcWnd)
{
  m_hCmd = lcCreateCommand( hLcWnd, m_ID, m_szName, m_bNeedSelection );
  if (m_hCmd){
    m_hLcWnd = hLcWnd;
    return true;
  }
  m_hLcWnd = 0;
  return false;
}

//-----------------------------------------------
bool CCmdBase::IsHandle (HANDLE hCmd) const
{
  if (hCmd != 0 && hCmd == m_hCmd){
    return true;
  }
  return false;
}


//=============================================================================
CCmdSketch::CCmdSketch (int Id, LPCWSTR szName)
  : CCmdBase( Id, szName, false)
{
  m_bDraw = false;
  m_hPline = 0;
}

//-----------------------------------------------
void CCmdSketch::Start (int Prm)
{
  WCHAR* szText = L"Press left button and move mouse,\n"\
                  L"it will draw a polyline until left button released\n"\
                  L"To stop the command - click right button or press <Esc>";
  HWND hWnd;
  hWnd = (HWND)(lcPropGetHandle( m_hLcWnd, LC_PROP_WND_HWND ));
  // display info message about the command
  ::MessageBox( hWnd, szText, L"Sketch", MB_OK | MB_ICONINFORMATION );
  lcWndSetFocus( m_hLcWnd );

  m_bDraw = false;
  m_hPline = 0;
}

//-----------------------------------------------
void CCmdSketch::Finish ()
{
}

//-----------------------------------------------
void CCmdSketch::MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  HANDLE hBlock;

  switch( Button ){
    case LC_LBUTTON:
      hBlock = lcPropGetHandle( m_hCmd, LC_PROP_CMD_BLOCK );
      m_hPline = lcBlockAddPolyline( hBlock, 0, false, false );
      m_bDraw = true;
      break;
    case LC_RBUTTON:
      lcCmdExit();  // exit command
      break;
  }
}

//-----------------------------------------------
void CCmdSketch::MouseUp (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  if (Button == LC_LBUTTON){
    m_bDraw = false;
  }
}

//-----------------------------------------------
void CCmdSketch::MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  if (m_bDraw){
    lcPlineAddVer( m_hPline, 0, X, Y );
    lcCmdRegen( m_hCmd, m_hPline );
    lcWndRedraw( m_hLcWnd );
  }
}



//=============================================================================
CCmdFlip::CCmdFlip (int Id, LPCWSTR szName)
  : CCmdBase( Id, szName, true)
{
}

//-----------------------------------------------
void CCmdFlip::Start (int Prm)
{
  WCHAR* szText = L"This command rotates selected objects\n"\
                  L"90 degrees around specified point";
  HWND hWnd;
  hWnd = (HWND)(lcPropGetHandle( m_hLcWnd, LC_PROP_WND_HWND ));
  // display info message about the command
  ::MessageBox( hWnd, szText, L"Flip", MB_OK | MB_ICONINFORMATION );
  lcWndSetFocus( m_hLcWnd );

  // display a text in the command line
  lcCmdPrompt( m_hCmd, L"Input center point:" );
}

//-----------------------------------------------
void CCmdFlip::Finish ()
{
}

//-----------------------------------------------
void CCmdFlip::MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  HANDLE hBlock = lcPropGetHandle( m_hCmd, LC_PROP_CMD_BLOCK );
  // rotate selected objects 90 degrees around point X,Y
  lcBlockSelRotate( hBlock, X,Y, 90*LC_DEG_TO_RAD, false, false );
  lcCmdRegen( m_hCmd, 0 );
  lcWndRedraw( m_hLcWnd );
  lcCmdExit();
}

//-----------------------------------------------
void CCmdFlip::MouseUp (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CCmdFlip::MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  // display a text near cursor
  lcCmdPrompt( m_hCmd, L"Input center point" );
}



//=============================================================================
CCmdArrow::CCmdArrow (int Id, LPCWSTR szName)
  : CCmdBase( Id, szName, false)
{
  m_Step = 1;
  m_X0 = m_Y0 = 0.0;
}

//-----------------------------------------------
void CCmdArrow::Start (int Prm)
{
  WCHAR* szText = L"Draws arrows until you click right button or press <Esc>.\n"
                  L"Object snap is set to \"Endpoint\" for 1st point and \"Midpoint\" for 2nd point.";
  HWND hWnd;
  hWnd = (HWND)(lcPropGetHandle( m_hLcWnd, LC_PROP_WND_HWND ));
  // display info message about the command
  ::MessageBox( hWnd, szText, L"Arrows", MB_OK | MB_ICONINFORMATION );
  lcWndSetFocus( m_hLcWnd );

  m_Step = 1;
  // save current snap mode
  m_bOSnapOn = lcPropGetBool( m_hCmd, LC_PROP_CMD_OSNAP );
  m_OSnapMode = lcPropGetInt( m_hCmd, LC_PROP_CMD_OSNAP );
  // set snap mode for the command
  lcPropPutBool( m_hCmd, LC_PROP_CMD_OSNAP, true );
  lcPropPutInt( m_hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_ENDPOINT );
  lcCmdPrompt( m_hCmd, L"Input first point:" );
}

//-----------------------------------------------
void CCmdArrow::Finish ()
{
  // restore original snap modes
  lcPropPutBool( m_hCmd, LC_PROP_CMD_OSNAP, m_bOSnapOn );
  lcPropPutInt( m_hCmd, LC_PROP_CMD_OSNAP, m_OSnapMode );
}

//-----------------------------------------------
void CCmdArrow::MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  if (Button == LC_LBUTTON){
    switch( m_Step ){
      case 1:
        m_Step = 2;
        m_X0 = X;
        m_Y0 = Y;
        lcPropPutInt( m_hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_MIDPOINT );
        lcCmdPrompt( m_hCmd, L"Input second point:" );
        break;
      case 2:
        if (AddArrow( m_X0, m_Y0, X, Y )){
          m_Step = 1;
          lcPropPutInt( m_hCmd, LC_PROP_CMD_OSNAP, LC_SNAP_ENDPOINT );
          lcCmdPrompt( m_hCmd, L"Input first point:" );
        }else{
          lcCmdPrompt( m_hCmd, L"Input second point:" );
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
void CCmdArrow::MouseUp (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CCmdArrow::MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  switch( m_Step ){
    case 1:
      lcCmdPrompt( m_hCmd, L"First point" );
      break;
    case 2:
      lcCmdPrompt( m_hCmd, L"Second point" );
      lcCmdDrawLine( m_hCmd, m_X0, m_Y0, X, Y );
      break;
  }
}

//-----------------------------------------------
bool CCmdArrow::AddArrow (double x0, double y0, double x1, double y1)
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
    hBlock = lcPropGetHandle( m_hCmd, LC_PROP_CMD_BLOCK );
    hPline = lcBlockAddPolyline( hBlock, 0, false, false );
    lcPlineAddVer2( hPline, 0, x0, y0, 0, w, w );
    lcPlineAddVer2( hPline, 0, x, y, 0, w*4.0, 0. );
    lcPlineAddVer2( hPline, 0, x1, y1, 0, 0.0, 0.0 );
    lcCmdRegen( m_hCmd, hPline );
    return true;
  }
  return false;
}



//=============================================================================
CCmdWall::CCmdWall (int Id, LPCWSTR szName)
  : CCmdBase( Id, szName, false)
{
  memset( m_X, 0, sizeof(m_X) );
  memset( m_Y, 0, sizeof(m_Y) );
  m_nPnts = 0; 
}

//-----------------------------------------------
void CCmdWall::Start (int Prm)
{
  WCHAR* szText = L"Draws thick polyline with orthogonal segments\n"\
                  L"To stop the command - click right button or press <Esc>";
  HWND hWnd;
  hWnd = (HWND)(lcPropGetHandle( m_hLcWnd, LC_PROP_WND_HWND ));
  // display info message about the command
  ::MessageBox( hWnd, szText, L"Wall", MB_OK | MB_ICONINFORMATION );
  lcWndSetFocus( m_hLcWnd );

  m_nPnts = 0; 
  HANDLE hView = lcPropGetHandle( m_hCmd, LC_PROP_CMD_VIEW );
  m_bOrtho = lcPropGetBool( hView, LC_PROP_VIEW_ORTHO );
  lcPropPutBool( hView, LC_PROP_VIEW_ORTHO, true );
}

//-----------------------------------------------
void CCmdWall::Finish ()
{
  int    i;
  double x, y;
  HANDLE hBlock, hPline, hView;
  if (m_nPnts >= 2){
    hBlock = lcPropGetHandle( m_hCmd, LC_PROP_CMD_BLOCK );
    hPline = lcBlockAddPolyline( hBlock, 0, false, false );
    for (i=0; i<m_nPnts; i++){
      x = m_X[i];
      y = m_Y[i];
      lcPlineAddVer( hPline, 0, x, y );
    }
    lcPropPutFloat( hPline, LC_PROP_PLINE_WIDTH, 2.0 );
    lcPropPutStr( hPline, LC_PROP_ENT_COLOR, L"34" );
    lcCmdRegen( m_hCmd, hPline );
  }
  hView = lcPropGetHandle( m_hCmd, LC_PROP_CMD_VIEW );
  lcPropPutBool( hView, LC_PROP_VIEW_ORTHO, m_bOrtho );
}

//-----------------------------------------------
void CCmdWall::MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  if (Button == LC_LBUTTON){
    if (m_nPnts < WALL_MAXPNT){
      m_X[m_nPnts] = X;
      m_Y[m_nPnts] = Y;
      m_nPnts++;
      lcCmdSetBasePoint( m_hCmd, true, X,Y );
    }
  }else{
    if (Button == LC_RBUTTON){
      lcCmdExit();  // exit command
    }
  }
}

//-----------------------------------------------
void CCmdWall::MouseUp (int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
}

//-----------------------------------------------
void CCmdWall::MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int i;
  double x0, y0, x1, y1;

  if (m_nPnts == 0){
    lcCmdPrompt( m_hCmd, L"First point" );
  }else{
    lcCmdPrompt( m_hCmd, L"Next point" );
    if (m_nPnts >= 2){
      x0 = m_X[0];
      y0 = m_Y[0];
      for (i=1; i<m_nPnts; i++){
        x1 = m_X[i];
        y1 = m_Y[i];
        lcCmdDrawLine( m_hCmd, x0, y0, x1, y1 );
        x0 = x1;
        y0 = y1;
      }
    }
    x0 = m_X[m_nPnts-1];
    y0 = m_Y[m_nPnts-1];
    lcCmdDrawLine( m_hCmd, x0, y0, X, Y );
  }
}

