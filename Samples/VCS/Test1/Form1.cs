using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
  public partial class Form1 : Form
  {
    int m_hLcWnd, m_hDrw;
    const int KeyPline = 101;
    const int KeyTextV = 102;
    const int KeyTextX = 103;
    const int KeyTextY = 104;
    
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int hView;
      int hBlock, hEnt, hPline, hTextStyle;
      
      Lcad.Initialize("");
      // define event procedures
      Lcad.OnEventMouseDown(new F_MOUSEDOWN(Form1.MouseDownProc));
      Lcad.OnEventGripSelect(new F_GRIPSELECT(Form1.GripSelectProc));
      Lcad.OnEventGripMove(new F_GRIPMOVE(Form1.GripMoveProc));
      // create CAD window
      m_hLcWnd = Lcad.CreateWindow(Handle, 0, 0, 0, Width, Height);
      // create a drawing object
      m_hDrw = Lcad.CreateDrawing();
      Lcad.DrwNew( m_hDrw, "", m_hLcWnd );
      // get "Model" block
      hBlock = Lcad.DrwGetFirstObject( m_hDrw, Lcad.LC_OBJ_BLOCK );
      // get default view
      hView = Lcad.DrwGetFirstObject(m_hDrw, Lcad.LC_OBJ_VIEW);
      // disable grid
      Lcad.PropPutBool(hView, Lcad.LC_PROP_VIEW_GRID, false);
      // add Circle
      hEnt = Lcad.BlockAddCircle( hBlock, 0,0, 30, true );
      Lcad.PropPutStr( hEnt, Lcad.LC_PROP_ENT_COLOR, "cyan" );
      // add Rectangle
      hEnt = Lcad.BlockAddRect2( hBlock, 0, 0, 100, 20, 0, true );
      Lcad.PropPutStr( hEnt, Lcad.LC_PROP_ENT_COLOR, "green");
      // add Ellipse
      hEnt = Lcad.BlockAddEllipse( hBlock, 20, 30, 15, 40, 0,0,0 );
      Lcad.PropPutStr( hEnt, Lcad.LC_PROP_ENT_COLOR, "red");     
      Lcad.PropPutBool( hEnt, Lcad.LC_PROP_ELL_FILLED, true );
      // add Polyline
      hPline = Lcad.BlockAddPolyline( hBlock, 0, false, false );
      Lcad.PlineAddVer(hPline, 0,  0, 50);
      Lcad.PlineAddVer(hPline, 0, 20, 80);
      Lcad.PlineAddVer(hPline, 0, 40, 50);
      Lcad.PlineAddVer(hPline, 0, 60, 80);
      Lcad.PlineAddVer(hPline, 0, 80, 50);
      // mark this polyline
      Lcad.PropPutInt(hPline, Lcad.LC_PROP_ENT_KEY, KeyPline);
      // add texts 
      hTextStyle = Lcad.DrwGetFirstObject( m_hDrw, Lcad.LC_OBJ_TEXTSTYLE );
      Lcad.PropPutStr( hTextStyle, Lcad.LC_PROP_TSTYLE_FONT, "Arial" );
      Lcad.PropPutFloat(hTextStyle, Lcad.LC_PROP_TSTYLE_HEIGHT, 5.0);
      Lcad.PropPutInt(hTextStyle, Lcad.LC_PROP_TSTYLE_ALIGN, Lcad.LC_TA_RIGBOT);
      Lcad.BlockAddTextWin(hBlock, "Vertex:", 100, 100);
      Lcad.BlockAddTextWin(hBlock, "X:", 100, 90);
      Lcad.BlockAddTextWin(hBlock, "Y:", 100, 80);
      // add texts 
      Lcad.PropPutInt(hTextStyle, Lcad.LC_PROP_TSTYLE_ALIGN, Lcad.LC_TA_LEFBOT);
      hEnt = Lcad.BlockAddTextWin(hBlock, "_", 102, 100);
      Lcad.PropPutInt(hEnt, Lcad.LC_PROP_ENT_KEY, KeyTextV);
      hEnt = Lcad.BlockAddTextWin(hBlock, "_", 102, 90);
      Lcad.PropPutInt(hEnt, Lcad.LC_PROP_ENT_KEY, KeyTextX);
      hEnt = Lcad.BlockAddTextWin(hBlock, "_", 102, 80);
      Lcad.PropPutInt(hEnt, Lcad.LC_PROP_ENT_KEY, KeyTextY);
      // add prompt texts
      Lcad.PropPutFloat(hTextStyle, Lcad.LC_PROP_TSTYLE_HEIGHT, 4.0);
      Lcad.BlockAddTextWin(hBlock, "Select polyline and move grips", -30, 90);
      Lcad.BlockAddTextWin(hBlock, "Click on filled objects", 30, -23);
      Lcad.BlockAddTextWin(hBlock, "use <Shift> and <Ctrl> to change direction", 30, -30);
      // regenerate
      Lcad.DrwRegenViews(m_hDrw, 0);
      // zoom
      Lcad.WndExeCommand(m_hLcWnd, Lcad.LC_CMD_ZOOM_EXT, 0);
      Lcad.WndZoomScale(m_hLcWnd, 0.6);
      Lcad.WndSetFocus(m_hLcWnd);
    }
    
    private void Form1_Resize_1(object sender, EventArgs e)
    {
      Lcad.WndResize(m_hLcWnd, 0, 0, Width, Height);
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      Lcad.Uninitialize(false);
    }
    
    public static void MouseDownProc (int hLcWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y)
    {
      int    hView, nEnts, hEnt;
      int    i, key;
      double dx, dy;
      bool   bCtrl = ((Flags & Lcad.LC_CTRL) > 0) ? true : false;
      bool   bShift = ((Flags & Lcad.LC_SHIFT)> 0) ? true : false;
      
      if (Button == Lcad.LC_LBUTTON){
        hView = Lcad.PropGetHandle(hLcWnd, Lcad.LC_PROP_WND_VIEW);
/*        
        hEnt = Lcad.ViewGetEntByPoint( hView, X, Y, true );
        if (hEnt > 0){
          Lcad.EntMove(hEnt, 10, 0, 0);
          Lcad.ViewRegen(hView, 0);
          Lcad.WndRedraw(hLcWnd);
        }
 */ 
        nEnts = Lcad.ViewGetEntsByPoint( hView, X, Y, true );
        if (nEnts > 0){
          if (nEnts == 1){
            hEnt = Lcad.ViewGetEntity(0);
            key = Lcad.PropGetInt(hEnt, Lcad.LC_PROP_ENT_KEY);
            if (key == KeyPline){
              return;
            }
          }
          for (i=0; i<nEnts; i++){
            hEnt = Lcad.ViewGetEntity( i );
            if (bShift && bCtrl){
              dx = 0.0;
              dy = -10.0;
            }else{
              if (bShift){
                dx = -10.0;
                dy = 0.0;
              }else{
                if (bCtrl){
                  dx = 0.0;
                  dy = 10.0;
                }else{
                  dx = 10.0;
                  dy = 0.0;
                }
              }
            }
            Lcad.EntMove(hEnt, dx, dy);
          }
          Lcad.ViewRegen( hView, 0 );
          Lcad.WndRedraw( hLcWnd );
        }
        Lcad.EventReturnCode( 1 );
      }
    }

    public static void GripSelectProc(int hEnt, int iGrip, double X, double Y)
    {
      int hText;
      int hBlock = Lcad.PropGetHandle(hEnt, Lcad.LC_PROP_ENT_BLOCK);
      int hDrw = Lcad.PropGetHandle(hBlock, Lcad.LC_PROP_BLOCK_DRW);
      hText = Lcad.BlockGetEntByKey(hBlock, KeyTextV);
      if (hText > 0)
      {
        Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, iGrip.ToString());
        Lcad.DrwRegenViews(hDrw, hText);
      }
      hText = Lcad.BlockGetEntByKey(hBlock, KeyTextX);
      if (hText > 0)
      {
        Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, X.ToString("F02"));
        Lcad.DrwRegenViews(hDrw, hText);
      }
      hText = Lcad.BlockGetEntByKey(hBlock, KeyTextY);
      if (hText > 0)
      {
        Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, Y.ToString("F02"));
        Lcad.DrwRegenViews(hDrw, hText);
      }
//      Lcad.WndRedraw(hLcWnd);
    }
    
    public static void GripMoveProc(int hEnt, int iGrip, ref double pX, ref double pY, ref double pAngle, bool bDrag)
    {
//        int hLcWnd
      int hText;
      int hBlock = Lcad.PropGetHandle( hEnt, Lcad.LC_PROP_ENT_BLOCK );
      int hDrw = Lcad.PropGetHandle( hBlock, Lcad.LC_PROP_BLOCK_DRW );
      if (bDrag == false){
        hText = Lcad.BlockGetEntByKey(hBlock, KeyTextV);
        if (hText > 0){
          Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, iGrip.ToString());
          Lcad.DrwRegenViews(hDrw, hText);
        }
        hText = Lcad.BlockGetEntByKey(hBlock, KeyTextX);
        if (hText > 0){
          Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, pX.ToString("F02"));
          Lcad.DrwRegenViews(hDrw, hText);
        }
        hText = Lcad.BlockGetEntByKey(hBlock, KeyTextY);
        if (hText > 0){
          Lcad.PropPutStr(hText, Lcad.LC_PROP_TEXTW_STR, pY.ToString("F02"));
          Lcad.DrwRegenViews(hDrw, hText);
        }
//        Lcad.WndRedraw(hLcWnd);
      }
    }

  }
}
