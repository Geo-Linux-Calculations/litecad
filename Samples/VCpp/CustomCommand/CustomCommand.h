#pragma once

#include "resource.h"

// Base class for all commands
//-----------------------------------------------
class CCmdBase {
  int    m_ID;              // command ID
  WCHAR  m_szName[32];      // command name
protected:
  bool   m_bNeedSelection;  // TRUE if a command requires selected objects
  HANDLE m_hCmd;            // command handle
  HANDLE m_hLcWnd;
public:
    CCmdBase (int Id, LPCWSTR szName, bool szNeedSelection);
 
  virtual void Start     (int Prm) = 0;
  virtual void Finish    () = 0;
  virtual void MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y) = 0;
  virtual void MouseUp   (int Button, int Flags, int Xwin, int Ywin, double X, double Y) = 0;
  virtual void MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y) = 0;

  bool Create   (HANDLE hLcWnd);
  bool IsHandle (HANDLE hCmd) const;
};


//-----------------------------------------------
class CCmdSketch : public CCmdBase {
  bool   m_bDraw;
  HANDLE m_hPline;
public:
    CCmdSketch (int Id, LPCWSTR szName);

  void Start     (int Prm);
  void Finish    ();
  void MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseUp   (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
};

//-----------------------------------------------
class CCmdFlip : public CCmdBase {
public:
    CCmdFlip (int Id, LPCWSTR szName);

  void Start     (int Prm);
  void Finish    ();
  void MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseUp   (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
};

//-----------------------------------------------
class CCmdArrow : public CCmdBase {
  int    m_Step;
  double m_X0;
  double m_Y0;
  BOOL   m_bOSnapOn;
  int    m_OSnapMode;
public:
    CCmdArrow (int Id, LPCWSTR szName);

  void Start     (int Prm);
  void Finish    ();
  void MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseUp   (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
  bool AddArrow  (double x0, double y0, double x1, double y1);
};


#define WALL_MAXPNT 100

//-----------------------------------------------
class CCmdWall : public CCmdBase {
  double m_X[WALL_MAXPNT];
  double m_Y[WALL_MAXPNT];
  int    m_nPnts;   // number of points
  BOOL   m_bOrtho;
public:
    CCmdWall (int Id, LPCWSTR szName);

  void Start     (int Prm);
  void Finish    ();
  void MouseDown (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseUp   (int Button, int Flags, int Xwin, int Ywin, double X, double Y);
  void MouseMove (HDC hDC, int Flags, int Xwin, int Ywin, double X, double Y);
  bool AddArrow  (double x0, double y0, double x1, double y1);
};
