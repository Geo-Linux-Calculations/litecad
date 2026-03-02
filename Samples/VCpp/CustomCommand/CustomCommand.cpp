// CustomCommand.cpp : Defines the entry point for the application.
//

#include "stdafx.h"

HWND   hwMain;     // Main window
HANDLE hLcWnd;     // Design window
HANDLE hLcDrw;     // LiteCAD drawing
HANDLE hLcCmd;     // Command window
HWND   hwStatBar;  // Status bar

int CmdLineHeight = 100;

#define APP_NAME  L"Custom Commands"
#define MAX_LOADSTRING 100

// Commands Identifiers
#define CMD_SKETCH  LC_CMD_CUSTOM+1
#define CMD_FLIP    LC_CMD_CUSTOM+2
#define CMD_ARROW   LC_CMD_CUSTOM+3
#define CMD_WALL    LC_CMD_CUSTOM+4

const int NumCmds = 4;  // number of commands
CCmdBase* MyCmd[NumCmds]; 

void MyCmd_Alloc ();
void MyCmd_Free ();

void CALLBACK EventMouseMove    (HANDLE hWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CALLBACK EventAddCommand   (HANDLE hLcWnd);   
void CALLBACK EventCmdStart     (HANDLE hCmd, int Prm);
void CALLBACK EventCmdFinish    (HANDLE hCmd);
void CALLBACK EventCmdMouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CALLBACK EventCmdMouseUp   (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
void CALLBACK EventCmdMouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);

bool  SaveChanges ();
void  FileNew     ();
void  FileOpen    (LPCWSTR szFileName=NULL);
void  FileRecent  ();
void  UpdateTitle ();

// Global Variables:
HINSTANCE hInst;								// current instance
TCHAR szTitle[MAX_LOADSTRING];					// The title bar text
TCHAR szWindowClass[MAX_LOADSTRING];			// the main window class name

// Forward declarations of functions included in this code module:
ATOM				MyRegisterClass(HINSTANCE hInstance);
BOOL				InitInstance(HINSTANCE, int);
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK	About(HWND, UINT, WPARAM, LPARAM);

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
	LoadString( hInstance, IDC_CUSTOMCOMMAND, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

#ifdef _DYNALINK   // define if compile the project without Litecad.lib
  lcLoadLib();
#endif

  MyCmd_Alloc();    // define custom commands
  lcInitialize( L"" );  // loads "Litecad.cfg"

  // Perform application initialization:
	if (!InitInstance (hInstance, nCmdShow))
	{
    MyCmd_Free();
		return FALSE;
	}

	hAccelTable = LoadAccelerators( hInstance, MAKEINTRESOURCE(IDC_CUSTOMCOMMAND) );
	
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
  MyCmd_Free();
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
  wcex.hIcon			= ::LoadIcon(hInstance, MAKEINTRESOURCE(IDI_CUSTOMCOMMAND));
  wcex.hCursor		= ::LoadCursor(NULL, IDC_ARROW);
  wcex.hbrBackground	= NULL; //(HBRUSH)(COLOR_WINDOW+20);
  wcex.lpszMenuName	= MAKEINTRESOURCE(IDC_CUSTOMCOMMAND);
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
  lcOnEventAddCommand( EventAddCommand );   
  lcOnEventCmdStart( EventCmdStart );
  lcOnEventCmdFinish( EventCmdFinish );
  lcOnEventCmdMouseDown( EventCmdMouseDown );
  lcOnEventCmdMouseUp( EventCmdMouseUp );
  lcOnEventCmdMouseMove( EventCmdMouseMove );

  // create LiteCAD design window
  hLcWnd = lcCreateWindow( hwMain, LC_WS_DEFAULT, 8, 8, 400, 400 );
  // create a drawing
  hLcDrw = lcCreateDrawing();
  lcDrwNew( hLcDrw, L"", hLcWnd );
  // Command line window
  hLcCmd = lcCreateCmdwin( hwMain, 8, 8, 400, 400 );
  lcWndSetCmdwin( hLcWnd, hLcCmd );

  // degrees will be used for angle units
  lcPropPutInt( 0, LC_PROP_DRW_AUNITS, LC_ANGLE_DEGREE );

  ::ShowWindow( hwMain, nCmdShow );
  ::UpdateWindow( hwMain );
  lcWndSetFocus( hLcWnd );  

  return TRUE;
}


//-----------------------------------------------
void Resize (int SizeType, int Wmain, int Hmain, bool bFromEvent)
{
  int  x, y, w, h, Hsb;
  int  DivSize = 0;
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

  // "Command Line" position
  x = 0;
  y = Hmain - CmdLineHeight - Hsb + 1;
  w = Wmain;
  h = CmdLineHeight;
  lcCmdwinResize( hLcCmd, x, y, w, h );

  // Design window position
  x = 0;
  y = 0;
  w = Wmain;
  h = Hmain - CmdLineHeight - Hsb + 1;
  lcWndResize( hLcWnd, x, y, w, h );
}


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

        case ID_CCMD_SKETCH: lcWndExeCommand( hLcWnd, CMD_SKETCH, 0 ); break;
        case ID_CCMD_FLIP:   lcWndExeCommand( hLcWnd, CMD_FLIP, 0 ); break;
        case ID_CCMD_LINE2:  lcWndExeCommand( hLcWnd, CMD_ARROW, 0 ); break;
        case ID_CCMD_WALL:   lcWndExeCommand( hLcWnd, CMD_WALL, 0 ); break;

        default:
          return DefWindowProc(hWnd, message, wParam, lParam);
      }
      break;

    case WM_SIZE:
      Resize( wParam, LOWORD(lParam), HIWORD(lParam), true );
      break;

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
  int id = 0;

  if (hWnd == hLcWnd){
//    swprintf( szBuf, L"X=%.2f  Y=%.2f  Z=%.2f", X, Y, Z );
    swprintf( szBuf, L"X=%.2f  Y=%.2f", X, Y );
    ::SendMessage( hwStatBar, SB_SETTEXT, id, (LPARAM)szBuf );
  }
}


//-----------------------------------------------
void CALLBACK EventAddCommand (HANDLE hLcWnd)
{
  for (int i=0; i<NumCmds; i++){
    MyCmd[i]->Create( hLcWnd );
  }
}

//-----------------------------------------------
void CALLBACK EventCmdStart (HANDLE hCmd, int Prm)
{
  int i;
  for (i=0; i<NumCmds; i++){
    if (MyCmd[i]->IsHandle( hCmd )){
      MyCmd[i]->Start( Prm );
      break;
    }
  }
}

//-----------------------------------------------
void CALLBACK EventCmdFinish (HANDLE hCmd)
{
  int i;
  for (i=0; i<NumCmds; i++){
    if (MyCmd[i]->IsHandle( hCmd )){
      MyCmd[i]->Finish();
      break;
    }
  }
}

//-----------------------------------------------
void CALLBACK EventCmdMouseDown (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int i;
  for (i=0; i<NumCmds; i++){
    if (MyCmd[i]->IsHandle( hCmd )){
      MyCmd[i]->MouseDown( Button, Flags, Xwin, Ywin, X, Y );
      break;
    }
  }
}

//-----------------------------------------------
void CALLBACK EventCmdMouseUp (HANDLE hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int i;
  for (i=0; i<NumCmds; i++){
    if (MyCmd[i]->IsHandle( hCmd )){
      MyCmd[i]->MouseUp( Button, Flags, Xwin, Ywin, X, Y );
      break;
    }
  }
}

//-----------------------------------------------
void CALLBACK EventCmdMouseMove (HANDLE hCmd, HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y)
{
  int i;
  for (i=0; i<NumCmds; i++){
    if (MyCmd[i]->IsHandle( hCmd )){
      MyCmd[i]->MouseMove( hDC, Flags, Xwin, Ywin, X, Y );
      break;
    }
  }
}

//-----------------------------------------------
void MyCmd_Alloc ()
{
  MyCmd[0] = new CCmdSketch( CMD_SKETCH, L"SKETCH" );
  MyCmd[1] = new CCmdFlip(   CMD_FLIP  , L"FLIP" );
  MyCmd[2] = new CCmdArrow(  CMD_ARROW , L"ARROW" );
  MyCmd[3] = new CCmdWall(  CMD_WALL , L"WALL" );
}

//-----------------------------------------------
void MyCmd_Free ()
{
  for (int i=0; i<NumCmds; i++){
    delete MyCmd[i];
  }
}
