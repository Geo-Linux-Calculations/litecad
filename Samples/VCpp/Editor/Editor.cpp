/***********************************************************************
*                                                                      
*  Simple CAD editor                                                    
*                                                                      
************************************************************************/
#include "stdafx.h"
#include "Editor.h"

HWND   hwMain;     // Main window
HANDLE hLcWnd;     // Design window
HANDLE hLcCmd;     // Command window
HANDLE hLcProp;    // Properties window
HANDLE hLcDrw;     // LiteCAD drawing
HWND   hwStatBar;  // Status bar

#ifdef _OKDIVIDER
  COkDivider DivCmd;          // divider "CommandLine - CAD window" (horizontal)
  COkDivider DivProp;         // divider "Properties - CAD window" (vertical)
#endif
int CmdLineHeight = 100;
int PropWndWidth = 250;

void CALLBACK EventMouseMove    (HANDLE hWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);

#define APP_NAME  L"Test01"
#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;        // current instance
TCHAR     szTitle[MAX_LOADSTRING];      // The title bar text
TCHAR     szWindowClass[MAX_LOADSTRING];  // the main window class name

// Forward declarations of functions included in this code module:
ATOM  MyRegisterClass (HINSTANCE hInstance);
BOOL  InitInstance    (HINSTANCE, int);
bool  SaveChanges ();
void  FileNew     ();
void  FileOpen    (LPCWSTR szFileName=NULL);
void  FileRecent  ();
void  UpdateTitle ();

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK About(HWND, UINT, WPARAM, LPARAM);


//-----------------------------------------------
int APIENTRY _tWinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPTSTR    lpCmdLine,
                     int       nCmdShow)
{
	UNREFERENCED_PARAMETER(hPrevInstance);
	UNREFERENCED_PARAMETER(lpCmdLine);

	MSG msg;
	HACCEL hAccelTable;

	// Initialize global strings
	LoadString( hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadString( hInstance, IDC_TEST01, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

#ifdef _DYNALINK   // define if compile the project without Litecad.lib
  lcLoadLib();
#endif
  lcInitialize( L"" );  // loads "Litecad.cfg"
//  lcStrFileLoad( L"russian.lng" );

  // Perform application initialization:
	if (!InitInstance (hInstance, nCmdShow))
	{
		return FALSE;
	}

	hAccelTable = LoadAccelerators( hInstance, MAKEINTRESOURCE(IDC_TEST01) );
	
	// Main message loop:
	while (GetMessage(&msg, NULL, 0, 0))
	{
		if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}
  if (hLcDrw){
    lcDeleteDrawing( hLcDrw );
  }
  lcUninitialize( true ); // if true - save config
#ifdef _DYNALINK
  lcFreeLib();
#endif
	return (int) msg.wParam;
}



//-----------------------------------------------
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
//  COMMENTS:
//
//    This function and its usage are only necessary if you want this code
//    to be compatible with Win32 systems prior to the 'RegisterClassEx'
//    function that was added to Windows 95. It is important to call this function
//    so that the application will get 'well formed' small icons associated
//    with it.
//-----------------------------------------------
ATOM MyRegisterClass(HINSTANCE hInstance)
{
  WNDCLASSEX wcex;

  wcex.cbSize = sizeof(WNDCLASSEX);

  wcex.style			= CS_HREDRAW | CS_VREDRAW;
  wcex.lpfnWndProc	= WndProc;
  wcex.cbClsExtra		= 0;
  wcex.cbWndExtra		= 0;
  wcex.hInstance		= hInstance;
  wcex.hIcon			= ::LoadIcon(hInstance, MAKEINTRESOURCE(IDI_EDITOR));
  wcex.hCursor		= ::LoadCursor(NULL, IDC_ARROW);
  wcex.hbrBackground	= NULL; //(HBRUSH)(COLOR_WINDOW+20);
  wcex.lpszMenuName	= MAKEINTRESOURCE(IDC_TEST01);
  wcex.lpszClassName	= szWindowClass;
  wcex.hIconSm		= (HICON)::LoadImage( wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL), IMAGE_ICON, 16, 16, LR_DEFAULTCOLOR );

  return RegisterClassEx(&wcex);
}

//-----------------------------------------------
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//-----------------------------------------------
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
  hInst = hInstance; // Store instance handle in our global variable

  hwMain = ::CreateWindow( szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
                             CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, NULL, NULL, hInstance, NULL );
  if (!hwMain){
     return FALSE;
  }
//  HICON hIcon = ::LoadIcon( g_hInst, (LPCWSTR)ICON_LCAD );


  INITCOMMONCONTROLSEX InitCtrls;
  memset( &InitCtrls, 0, sizeof(InitCtrls) );
  InitCtrls.dwSize = sizeof(INITCOMMONCONTROLSEX);
  InitCtrls.dwICC = ICC_WIN95_CLASSES;
  ::InitCommonControlsEx( &InitCtrls );

  // StatusBar
  hwStatBar = ::CreateWindow( STATUSCLASSNAME, L"NULL", WS_CHILD|WS_VISIBLE|SBARS_SIZEGRIP, 
                            0,0,100,20, hwMain, (HMENU)101, hInstance, NULL );
  if (!hwStatBar){
    return FALSE;
  }
//  ::SendMessage( hwStatBar, SB_SIMPLE, TRUE, 0 );
  INT Parts[2];
  Parts[0] = 300;
  Parts[1] = -1;
  ::SendMessage (hwStatBar, SB_SETPARTS, (WPARAM)2, (LPARAM)Parts );

  // define functions for events processing
  lcOnEventMouseMove( EventMouseMove );

  // create LiteCAD design window
  hLcWnd = lcCreateWindow( hwMain, LC_WS_DEFAULT | LC_WS_VIEWTABS, 8, 8, 400, 400 );
  // Command line window
  hLcCmd = lcCreateCmdwin( hwMain, 8, 8, 400, 400 );
  // Properties window
  hLcProp = lcCreatePropwin( hwMain, 8, 8, 400, 400 );

#ifdef _OKDIVIDER
  // divider's parameters
  COkDivider::m_Color    = ::GetSysColor( COLOR_BTNFACE );
  COkDivider::m_Size     = 3;   
  COkDivider::m_hCurHorz = ::LoadCursor( hInst, MAKEINTRESOURCE(CUR_DIVHORZ) );
  COkDivider::m_hCurVert = ::LoadCursor( hInst, MAKEINTRESOURCE(CUR_DIVVERT) );
  // divider "Properties - CAD window"
  DivProp.CreateVer( hInst, hwMain, &PropWndWidth, true, true );
  // divider "CommandLine - CAD window"
  DivCmd.CreateHor( hInst, hwMain, &CmdLineHeight, false );
#endif // _OKDIVIDER

  // create a drawing
  hLcDrw = lcCreateDrawing();
  lcDrwNew( hLcDrw, L"", hLcWnd );
  lcWndSetCmdwin( hLcWnd, hLcCmd );
  lcWndSetPropwin( hLcWnd, hLcProp );
//  lcPropPutBool( hLcDrw, LC_PROP_DRW_LWDISPLAY, true );
//  lcPropPutBool( hLcDrw, LC_PROP_DRW_DIRTY, false );

  ::ShowWindow( hwMain, nCmdShow );
  ::UpdateWindow( hwMain );
  lcWndSetFocus( hLcWnd );  

  return TRUE;
}


//-----------------------------------------------
void Resize (int SizeType, int Wmain, int Hmain, bool bFromEvent)
{
  int  x, y, w, h, Hsb;
#ifdef _OKDIVIDER
  int  DivSize = COkDivider::m_Size;
#else
  int  DivSize = 0;
#endif 
  RECT rc;

  if (SizeType == SIZE_MINIMIZED){
    return;
  }
  if (Wmain==0 && Hmain==0){
    return;
  }
  // Statusbar position
  ::SendMessage( hwStatBar, WM_SIZE, (WPARAM)SIZE_RESTORED, MAKELONG(Wmain,Hmain) ); 
  ::GetWindowRect( hwStatBar, &rc ); 
  Hsb = rc.bottom - rc.top + 1;

  // Design window position
  x = PropWndWidth + DivSize;
  y = 0;
  w = Wmain - PropWndWidth - DivSize;
  h = Hmain - DivSize - CmdLineHeight - Hsb + 1;
  lcWndResize( hLcWnd, x, y, w, h );

  // "Command Line" position
  x = PropWndWidth + DivSize;
  y = Hmain - CmdLineHeight - Hsb + 1;
  w = Wmain - PropWndWidth - DivSize;
  h = CmdLineHeight;
  lcCmdwinResize( hLcCmd, x, y, w, h );

  // "Properties" window position
  x = 0;
  y = 0;
  w = PropWndWidth;
  h = Hmain - Hsb + 1; 
  lcPropwinResize( hLcProp, x, y, w, h );

#ifdef _OKDIVIDER
  // divider "Properties - CAD window"
  x = PropWndWidth;
  y = 0;
  h = Hmain - Hsb + 1;
  DivProp.Resize( x, y, h );

  // divider "CommandLine - CAD window"
  x = PropWndWidth + DivSize;
  y = Hmain - DivSize - CmdLineHeight - Hsb + 1;
  w = Wmain - PropWndWidth - DivSize;
  DivCmd.Resize( x, y, w );
#endif  // _OKDIVIDER
}


#ifdef _OKDIVIDER
//-----------------------------------------------
void UpdateLayout ()
{
  RECT rect;
  int W, H;

  ::GetClientRect( hwMain, &rect );
  W = rect.right;
  H = rect.bottom;

  if (PropWndWidth < 100){
    PropWndWidth = 100;
  }else{
    if (PropWndWidth > W/2){
      PropWndWidth = W/2;
    }
  }
  if (CmdLineHeight < 50){
    CmdLineHeight = 50;
  }else{
    if (CmdLineHeight > H/2){
      CmdLineHeight = H/2;
    }
  }
  Resize( -1, W, H, false );
  ::InvalidateRect( hwMain, NULL, false );
}
#endif  // _OKDIVIDER


//-----------------------------------------------
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE:  Processes messages for the main window.
//
//  WM_COMMAND	- process the application menu
//  WM_PAINT	- Paint the main window
//  WM_DESTROY	- post a quit message and return
//
//
//-----------------------------------------------
LRESULT CALLBACK WndProc (HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
  int wmId, wmEvent;

  switch (message){
    case WM_COMMAND:
      wmId    = LOWORD(wParam);
      wmEvent = HIWORD(wParam);
      // Parse the menu selections:
      switch( wmId ){
        case IDM_ABOUT:    DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);   break;
        case IDM_EXIT:		 DestroyWindow(hWnd); break;

        case ID_FILE_NEW:     FileNew(); break;
        case ID_FILE_OPEN:    FileOpen(); break;
        case ID_FILE_RECENT:  FileRecent(); break;
        case ID_FILE_SAVE:    lcWndExeCommand( hLcWnd, LC_CMD_FILESAVE, 0 );   break;
        case ID_FILE_SAVEAS:  lcWndExeCommand( hLcWnd, LC_CMD_FILESAVEAS, 0 ); break;
        case ID_FILE_PRINT:   lcWndExeCommand( hLcWnd, LC_CMD_PRINT, 0 ); break;

        case ID_VIEW_ZOOMEXT:   lcWndExeCommand( hLcWnd, LC_CMD_ZOOM_EXT, 0 ); break;
        case ID_VIEW_ZOOMWIN:   lcWndExeCommand( hLcWnd, LC_CMD_ZOOM_WIN, 0 ); break;
        case ID_VIEW_ZOOMPREV:  lcWndExeCommand( hLcWnd, LC_CMD_ZOOM_PREV, 0 ); break;
        case ID_VIEW_LIMITS:    lcWndExeCommand( hLcWnd, LC_CMD_LIMITS, 0 ); break;
        case ID_3DVIEWS_TOP:    lcWndExeCommand( hLcWnd, LC_CMD_VIEW_TOP, 0 ); break;
        case ID_3DVIEWS_BOTTOM: lcWndExeCommand( hLcWnd, LC_CMD_VIEW_BOTTOM, 0 ); break;
        case ID_3DVIEWS_LEFT:   lcWndExeCommand( hLcWnd, LC_CMD_VIEW_LEFT, 0 ); break;
        case ID_3DVIEWS_RIGHT:  lcWndExeCommand( hLcWnd, LC_CMD_VIEW_RIGHT, 0 ); break;
        case ID_3DVIEWS_FRONT:  lcWndExeCommand( hLcWnd, LC_CMD_VIEW_FRONT, 0 ); break;
        case ID_3DVIEWS_BACK:   lcWndExeCommand( hLcWnd, LC_CMD_VIEW_BACK, 0 ); break;
        case ID_3DVIEWS_SW:     lcWndExeCommand( hLcWnd, LC_CMD_VIEW_SW, 0 ); break;
        case ID_3DVIEWS_SE:     lcWndExeCommand( hLcWnd, LC_CMD_VIEW_SE, 0 ); break;
        case ID_3DVIEWS_NE:     lcWndExeCommand( hLcWnd, LC_CMD_VIEW_NE, 0 ); break;
        case ID_3DVIEWS_NW:     lcWndExeCommand( hLcWnd, LC_CMD_VIEW_NW, 0 ); break;
        case ID_3DVIEWS_VPSET:  lcWndExeCommand( hLcWnd, LC_CMD_VIEW_SET, 0 ); break;

        case ID_DRAW_LINE:      lcWndExeCommand( hLcWnd, LC_CMD_LINE, 0 ); break;
        case ID_DRAW_POLYLINE:  lcWndExeCommand( hLcWnd, LC_CMD_PLINE, 0 ); break;
        case ID_DRAW_POINT:     lcWndExeCommand( hLcWnd, LC_CMD_POINT, 0 ); break;
        case ID_CIRCLE_CR:      lcWndExeCommand( hLcWnd, LC_CMD_CIRCLE, 1 ); break;
        case ID_CIRCLE_CD:      lcWndExeCommand( hLcWnd, LC_CMD_CIRCLE, 2 ); break;
        case ID_CIRCLE_2P:      lcWndExeCommand( hLcWnd, LC_CMD_CIRCLE, 3 ); break;
        case ID_CIRCLE_3P:      lcWndExeCommand( hLcWnd, LC_CMD_CIRCLE, 4 ); break;
        case ID_ARC_3P:         lcWndExeCommand( hLcWnd, LC_CMD_ARC, 1 ); break;
        case ID_DRAW_TEXT:      lcWndExeCommand( hLcWnd, LC_CMD_TEXT, 0 ); break;
        case ID_DRAW_IMAGE:     lcWndExeCommand( hLcWnd, LC_CMD_IMAGE, 0 ); break;
        case ID_DRAW_INSBLOCK:  lcWndExeCommand( hLcWnd, LC_CMD_INSERT, 0 ); break;

        case ID_FORMAT_LAYERS:       lcWndExeCommand( hLcWnd, LC_CMD_LAYER, 0 ); break;
        case ID_FORMAT_COLORS:       lcWndExeCommand( hLcWnd, LC_CMD_COLOR, 0 ); break;
        case ID_FORMAT_LINETYPES:    lcWndExeCommand( hLcWnd, LC_CMD_LINETYPE, 0 ); break;
        case ID_FORMAT_LINEWEIGHTS:  lcWndExeCommand( hLcWnd, LC_CMD_LWEIGHT, 0 ); break;
        case ID_FORMAT_TEXTSTYLES:   lcWndExeCommand( hLcWnd, LC_CMD_TEXTSTYLE, 0 ); break;
        case ID_FORMAT_POINTSTYLES:  lcWndExeCommand( hLcWnd, LC_CMD_PNTSTYLE, 0 ); break;
        case ID_FORMAT_BLOCKS:       lcWndExeCommand( hLcWnd, LC_CMD_BLOCKS, 0 ); break;
        case ID_FORMAT_CREATEBLOCK:  lcWndExeCommand( hLcWnd, LC_CMD_BLOCK, 0 ); break;
        case ID_FORMAT_LAYOUTS:      lcWndExeCommand( hLcWnd, LC_CMD_LAYOUT, 0 ); break;
        case ID_FORMAT_IMAGES:       lcWndExeCommand( hLcWnd, LC_CMD_IMAGE, 0 ); break;

        case ID_TOOLS_DSET:          lcWndExeCommand( hLcWnd, LC_CMD_DAIDS, 0 ); break;
        case ID_TOOLS_OPTIONS:       lcWndExeCommand( hLcWnd, LC_CMD_OPTIONS, 0 ); break;
        case ID_TOOLS_PLUGINS:       lcWndExeCommand( hLcWnd, LC_CMD_PLUGIN, 0 ); break;
        case ID_TOOLS_MAKERASTER:    lcWndExeCommand( hLcWnd, LC_CMD_RASTERIZE, 0 ); break;

        default:
          return DefWindowProc(hWnd, message, wParam, lParam);
      }
      break;

    case WM_SIZE:
      Resize( wParam, LOWORD(lParam), HIWORD(lParam), true );
      break;

#ifdef _OKDIVIDER
    case WM_USER:
      if (wParam == MSG_DIV_MOVED){  // Divider was moved
        UpdateLayout();        
      }      
      break;
#endif  // _OKDIVIDER

    case WM_DESTROY:
      PostQuitMessage(0);
      break;

    default:
      return DefWindowProc(hWnd, message, wParam, lParam);
  }
  return 0;
}


// Message handler for about box.
//-----------------------------------------------
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}


// Call dialog "Save Changes?"
//-----------------------------------------------
bool SaveChanges ()
{
  int   ret;
  WCHAR szFileName[256], szText[300];

  if (hLcDrw){
    if (lcPropGetBool( hLcDrw, LC_PROP_DRW_DIRTY )){
      wcscpy( szFileName, lcPropGetStr( hLcDrw, LC_PROP_DRW_FILENAME ) );
      if (szFileName[0] == 0){
        wcscpy( szFileName, lcStrGet(L"APP_NONAME") );
      }
      swprintf( szText, lcStrGet(L"APP_SAVECHANGES"), szFileName );
      ret = ::MessageBox( hwMain, szText, APP_NAME, MB_YESNOCANCEL | MB_ICONQUESTION );
      lcWndSetFocus( hLcWnd );
      switch( ret ){
        case IDYES:
          // save changes and close file
          if (lcDrwSave( hLcDrw, L"<Origin>", true, hwMain ) == false){
            // can't save, therefore do not close
            return false;
          }
          break;
        case IDNO:
          // don't save changes but close file
          break;
        case IDCANCEL:
          // don't close file
          return false;
      }
    }
  }
  return true;
}


//-----------------------------------------------
void FileNew ()
{
  if (SaveChanges()){
    lcWndSelectView( hLcWnd, 0 );
    lcDrwNew( hLcDrw, NULL, hLcWnd );
    UpdateTitle();
  }
}

//-----------------------------------------------
void FileOpen (LPCWSTR szFileName)
{
  BOOL   bRet;

  if (SaveChanges()){
    if (szFileName){
      bRet = lcDrwLoad( hLcDrw, szFileName, 0, hLcWnd );
    }else{
      bRet = lcDrwLoad( hLcDrw, L"<Dialog>", hwMain, hLcWnd );
    }
    if (!bRet){
      if (lcGetErrorCode() != LC_ERR_USERCANCEL){
        ::MessageBox( hwMain, L"Could not load the file", APP_NAME, MB_OK | MB_ICONSTOP ); 
      }
    }
    lcWndSetFocus( hLcWnd );
    UpdateTitle();
  }
}

//-----------------------------------------------
void FileRecent ()
{
  BOOL   bRet;

  if (SaveChanges()){
    bRet = lcDrwLoad( hLcDrw, L"<Recent>", hwMain, hLcWnd );
    if (!bRet){
      if (lcGetErrorCode() != LC_ERR_USERCANCEL){
        ::MessageBox( hwMain, L"Could not load the file", APP_NAME, MB_OK | MB_ICONSTOP ); 
      }
    }
    lcWndSetFocus( hLcWnd );
    UpdateTitle();
  }
}

//-----------------------------------------------
void UpdateTitle ()
{
  WCHAR szBuf[300], szFileName[256];
  wcscpy( szFileName, lcPropGetStr( hLcDrw, LC_PROP_DRW_FILENAME ) );
  if (szFileName[0] == 0){
    wcscpy( szFileName, L"noname" );
  }
  swprintf( szBuf, L"%s - [%s]", APP_NAME, szFileName );
  ::SetWindowText( hwMain, szBuf );
}


//-----------------------------------------------
void CALLBACK EventMouseMove (HANDLE hWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  WCHAR szBuf[64];
  int id = 0; //SB_SIMPLEID;

  if (hWnd == hLcWnd){
    swprintf( szBuf, L"X=%.2f  Y=%.2f", X, Y );
    ::SendMessage( hwStatBar, SB_SETTEXT, id, (LPARAM)szBuf );
  }
}

