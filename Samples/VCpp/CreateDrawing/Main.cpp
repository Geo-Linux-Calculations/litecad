/************************************************************************/
/* This console application creates LCD file                            */
/*                                                                      */
/* The file will be saved as "CreateDrawing.lcd"                        */
/*                                                                      */
/************************************************************************/
#include "stdafx.h"


//-----------------------------------------------
int _tmain (int argc, _TCHAR* argv[])
{
  WCHAR  szOutFile[256];
  HANDLE hDrw;
  HANDLE hView, hBlock, hLayer, hPline, hEnt, hText, hTStyle;
  double Lef, Bot, Rig, Top;
  BOOL   bSaved;
  WCHAR* szText = NULL;

  // Generate the drawing's filename
  ::GetModuleFileName( ::GetModuleHandle(NULL), szOutFile, 255 );
  WCHAR* p = wcsrchr( szOutFile, L'\\' );
  if (p){
    p[0] = 0;
    wcscat( szOutFile, L"\\CreateDrawing.lcd" );
  }else{
    return 1;
  }

  lcLoadLib();   // use this function if can't link with Litecad.lib (for non MS VC++ 2008 compiler)
  lcInitialize( L"" );  // loads "Litecad.cfg"

  hDrw = lcCreateDrawing();
  hBlock = lcDrwGetFirstObject( hDrw, LC_OBJ_BLOCK );
  // add lines
  lcBlockAddLine( hBlock, 0,0, 50,50 );
  lcBlockAddLine( hBlock, 20,0, 70,50 );
  // add circles
  lcBlockAddCircle( hBlock, 80,60, 14.142, false );
  lcBlockAddCircle( hBlock, 80,60, 7.071, false );
  //add arcs
  lcBlockAddArc( hBlock, 80, 40, 14.142, -45*LC_DEG_TO_RAD, -90*LC_DEG_TO_RAD );
  lcBlockAddArc3P( hBlock, 70,30, 80, 10, 90, 30 );
  hEnt = lcBlockAddArc( hBlock, 80, 22.5, 10, 250*LC_DEG_TO_RAD, 40*LC_DEG_TO_RAD );
  lcPropPutBool( hEnt, LC_PROP_ARC_SECTOR, true );
  lcPropPutBool( hEnt, LC_PROP_ARC_FILLED, true );
  lcPropPutBool( hEnt, LC_PROP_ARC_BORDER, true );
  lcPropPutStr( hEnt, LC_PROP_ENT_COLOR, L"100,200,250" );
  lcPropPutStr( hEnt, LC_PROP_ENT_BCOLOR, L"red" );
  // add ellipse
  lcBlockAddEllipse( hBlock, 80, 35.858, 5, 10, 0, 0, 0 );
  hEnt = lcBlockAddEllipse( hBlock, 100, 35.858, 5, 10, 0, 180*LC_DEG_TO_RAD, 270*LC_DEG_TO_RAD );
  lcPropPutBool( hEnt, LC_PROP_ELL_SECTOR, true );
  // add new layer and make it active
  hLayer = lcDrwAddLayer( hDrw, L"New Layer", L"red", 0, LC_LWEIGHT_DEFAULT );
  lcPropPutHandle( hDrw, LC_PROP_DRW_LAYER, hLayer );
  // add polyline
  hPline = lcBlockAddPolyline( hBlock, LC_PLFIT_QUAD, true, false );
  lcPlineAddVer( hPline, 0, 20, 80 );
  lcPlineAddVer( hPline, 0, 30, 90 );
  lcPlineAddVer( hPline, 0, 50, 70 );
  lcPlineAddVer( hPline, 0, 33, 63 );
  lcPlineAddVer( hPline, 0, 20, 50 );
  // add new text style and make it active
  hTStyle = lcDrwAddTextStyle( hDrw, L"New Style", L"Times New Roman" );
  lcPropPutHandle( hDrw, LC_PROP_DRW_TEXTSTYLE, hTStyle );
  // add text
  hText = lcBlockAddText2( hBlock, L"Polygon", 32,70, LC_TA_CENTER, 3, 0, 35*LC_DEG_TO_RAD, 0 );
  // copy and mirror the text and the polyline
  lcBlockSelectEnt( hBlock, hPline, true );
  lcBlockSelectEnt( hBlock, hText, true );
  lcBlockSelMirror( hBlock, 19.5, 0, 19.5, 100, true, false );
  hEnt = lcBlockGetLastEnt( hBlock );
  lcBlockSelectEnt( hBlock, hEnt, true );
  hEnt = lcBlockGetPrevEnt( hBlock, hEnt );
  lcBlockSelectEnt( hBlock, hEnt, true );
  lcBlockSelMirror( hBlock, 0, 87, 100, 87, true, false );
  lcBlockUnselect( hBlock );
  // regeneration
  lcDrwRegenViews( hDrw, 0 );

  // get extents of model view
  hView = lcDrwGetFirstObject( hDrw, LC_OBJ_VIEW );
  Lef = lcPropGetFloat( hView, LC_PROP_VIEW_XMIN );
  Bot = lcPropGetFloat( hView, LC_PROP_VIEW_YMIN );
  Rig = lcPropGetFloat( hView, LC_PROP_VIEW_XMAX );
  Top = lcPropGetFloat( hView, LC_PROP_VIEW_YMAX );
  // set visible rect (fit to the extents)
  lcViewSetRect2( hView, Lef, Bot, Rig, Top );
  // don't display grid
  lcPropPutBool( hView, LC_PROP_VIEW_GRID, false );

  // add paper view
  hView = lcDrwAddViewPaper( hDrw, L"", LC_PAPER_A4, LC_PAPER_BOOK, 0, 0 );
  // get the paper space block
  hBlock = lcPropGetHandle( hView, LC_PROP_VIEW_BLOCK );
  // set active layer
  hLayer = lcDrwGetObjectByName( hDrw, LC_OBJ_LAYER, L"0" );
  lcPropPutHandle( hDrw, LC_PROP_DRW_LAYER, hLayer );
  // set default parameters for a text
  lcPropPutInt( hTStyle, LC_PROP_TSTYLE_ALIGN, LC_TA_CENTOP );
  lcPropPutFloat( hTStyle, LC_PROP_TSTYLE_HEIGHT, 7.0 );
  lcPropPutFloat( hTStyle, LC_PROP_TSTYLE_OBLIQUE, 15.0*LC_DEG_TO_RAD );
  lcPropPutFloat( hTStyle, LC_PROP_TSTYLE_WSCALE, 1.5 );
  // add text
  lcBlockAddText( hBlock, L"Demo drawing", 105,290 );
  // add some more text
  szText = L"Move cursor inside a viewport and click right button, the popup menu "
           L"will appear. You can activate the viewport and set desired view by moving "
           L"the viewport rectangle on Model Space.\\P"
           L"Also you can activate / deactivate a viewport by left button "
           L"double click.";
  lcBlockAddMText( hBlock, szText, 10, 50, 90, LC_TA_LEFTOP, 0, 3.2, 1 );
  // add new layer for viewports and make it active
  hLayer = lcDrwAddLayer( hDrw, L"Viewports", L"96", 0, LC_LWEIGHT_DEFAULT );
  lcPropPutHandle( hDrw, LC_PROP_DRW_LAYER, hLayer );
  // add viewports on the paper view
  lcBlockAddViewport( hBlock, 10, 155, 190, 120, 0,0, 0, 0 ); 
  lcBlockAddViewport( hBlock, 10, 55, 90, 90, 19.5, 87, 0.745, 0 ); 
  lcBlockAddViewport( hBlock, 110, 55, 90, 90, 80, 35.858, 0.745, 45*LC_DEG_TO_RAD ); 
  // set active color
  lcPropPutStr( hDrw, LC_PROP_DRW_COLOR, L"blue" );
  // add dimension
  lcBlockAddDimHor( hBlock, 110, 55, 200, 55, 30, L"W=<>mm" );
  // regenerate paper view
  lcViewRegen( hView, 0 );

  // set active view (that will be dispayed in a window when the drawing will be opened in editor)
  lcPropPutHandle( hDrw, LC_PROP_DRW_VIEW, hView );
  // don't display grid
  lcPropPutBool( hView, LC_PROP_VIEW_GRID, false );
  // save the drawing into the file
  bSaved = lcDrwSave( hDrw, szOutFile, false, 0 );
  // delete drawing object (clear memory)
  lcDeleteDrawing( hDrw );

  lcUninitialize( false ); // if true - save config
  lcFreeLib();

  if (bSaved){
    wprintf( L"The drawing was saved to\n%s\nPress any key\n", szOutFile );
  }else{
    wprintf( L"Error of saving file\n%s\nPress any key\n", szOutFile );
  }
  _getch();

	return 0;
}

/*
  // add filled circle
  lcPropPutStr( g_hDrw, LC_PROP_DRW_COLOR, L"green" );
  lcBlockAddCircle( hBlock, 0,0, 50, true );
  // add filled circle
  lcPropPutStr( g_hDrw, LC_PROP_DRW_COLOR, L"255,200,150" );
  lcBlockAddCircle( hBlock, 0,0, 25, true );
  // add filled rectangle
  lcPropPutStr( g_hDrw, LC_PROP_DRW_COLOR, L"cyan" );
  lcBlockAddRect( hBlock, 200,0, 10,20, 45*LC_DEG_TO_RAD, true );
  // add new layer and make it active
  hLayer = lcDrwAddLayer( g_hDrw, L"New Layer", L"red", 0, LC_LWEIGHT_DEFAULT );
  lcPropPutHandle( g_hDrw, LC_PROP_DRW_LAYER, hLayer );
  // set active color "ByLayer"
  lcPropPutStr( g_hDrw, LC_PROP_DRW_COLOR, L"ByLayer" );
  // add a polyline on the new layer
  hPline = lcBlockAddPolyline( hBlock, LC_PLFIT_QUAD, true, false );
  lcPlineAddVer( hPline, 0, 20, 80 );
  lcPlineAddVer( hPline, 0, 30, 90 );
  lcPlineAddVer( hPline, 0, 50, 70 );
  lcPlineAddVer( hPline, 0, 33, 63 );
  lcPlineAddVer( hPline, 0, 20, 50 );
*/
