using System;
using System.Runtime.InteropServices;

public delegate void F_MOUSEMOVE (int hLcWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_MOUSEDOWN (int hLcWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_MOUSEUP (int hLcWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_MOUSEDBLCLK (int hLcWnd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_MOUSESNAP (int hLcWnd, double Delta, ref double pX, ref double pY);
public delegate void F_MOUSELEAVE (int hLcWnd);
public delegate void F_MOUSEWHEEL (int hLcWnd, int Flags, int Delta);
public delegate void F_KEYDOWN (int hLcWnd, int VirtKey, int Flags, bool bCtrl, bool bShift);
public delegate void F_PAINT (int hLcWnd, int hView, int Mode, IntPtr hDC, int Left, int Top, int Right, int Bottom);
public delegate void F_ZOOM (int hLcWnd, double Left, double Bottom, double Right, double Top, double PixelSize);
public delegate void F_SELECTVIEW (int hLcWnd, int hView);
public delegate void F_GETPOINT (int hLcWnd, int hView, int Index, double X, double Y);
public delegate void F_ADDCOMMAND (int hLcWnd);
public delegate void F_CMD_START (int hCmd, int Prm);
public delegate void F_CMD_FINISH (int hCmd);
public delegate void F_CMD_MOUSEDOWN (int hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_CMD_MOUSEUP (int hCmd, int Button, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_CMD_MOUSEMOVE (int hCmd, IntPtr hDC, int Flags, int Xwin, int Ywin, double X, double Y);
public delegate void F_CMD_STRING (int hCmd, string szStr);
public delegate void F_ADDENTITY (int hDrw, int hBlock, int hEntity);
public delegate void F_REGEN (int hDrw, int hView, int Percent);
public delegate void F_FIOPROGRESS (int hDrw, int Mode, int IntVal, string szFileName);
public delegate void F_SELECTION (int hDrw, int hBlock, bool bSelect, int nEnts, int hEnt, int nTotal);
public delegate void F_PROPCHANGED (int hDrw, int idProp, int hObj);
public delegate void F_GRIPSELECT (int hEnt, int iGrip, double X, double Y);
public delegate void F_GRIPMOVE (int hEnt, int iGrip, ref double pX, ref double pY, ref double pAngle, bool bDrag);
public delegate void F_ENTERASE (int hEnt);
public delegate void F_ENTMOVE (int hEnt, double DX, double DY, bool bDrag);
public delegate void F_ENTROTATE (int hEnt, double X0, double Y0, double Angle, bool bDrag);
public delegate void F_ENTSCALE (int hEnt, double X0, double Y0, double Scale, bool bDrag);
public delegate void F_ENTMIRROR (int hEnt, double X1, double Y1, double X2, double Y2, bool bDrag);
public delegate void F_FONTREPLACE (int hDrw, string szStyleName, string szOrigName);
public delegate void F_ADDSTR ();
public delegate void F_HELP (int hDrw, int idTopic);

static class Lcad
{
  public const int LC_FALSE = 0;
  public const int LC_TRUE = 1;
  public const int LC_LBUTTON = 1;
  public const int LC_RBUTTON = 2;
  public const int LC_MBUTTON = 4;
  public const int LC_SHIFT = 1;
  public const int LC_CTRL = 2;
  public const int LC_ALT = 4;
  public const int LC_WS_HSCROLL = 1;
  public const int LC_WS_VSCROLL = 2;
  public const int LC_WS_BORDER = 4;
  public const int LC_WS_CLIENTEDGE = 8;
  public const int LC_WS_SUNKEN = 8;
  public const int LC_WS_STATICEDGE = 16;
  public const int LC_WS_VIEWTABS = 256;
  public const int LC_WS_DEFAULT = 3;
  public const int LC_INSUNIT_UNDEFINED = 0;
  public const int LC_INSUNIT_INCHES = 1;
  public const int LC_INSUNIT_FEET = 2;
  public const int LC_INSUNIT_MILES = 3;
  public const int LC_INSUNIT_MILLIMETERS = 4;
  public const int LC_INSUNIT_CENTIMETERS = 5;
  public const int LC_INSUNIT_METERS = 6;
  public const int LC_INSUNIT_KILOMETERS = 7;
  public const int LC_INSUNIT_MICROINCHES = 8;
  public const int LC_INSUNIT_MILS = 9;
  public const int LC_INSUNIT_YARDS = 10;
  public const int LC_INSUNIT_ANGSTROMS = 11;
  public const int LC_INSUNIT_NANOMETERS = 12;
  public const int LC_INSUNIT_MICRONS = 13;
  public const int LC_INSUNIT_DECIMETERS = 14;
  public const int LC_INSUNIT_DEKAMETERS = 15;
  public const int LC_INSUNIT_HECTOMETERS = 16;
  public const int LC_INSUNIT_GIGAMETERS = 17;
  public const int LC_INSUNIT_ASTRONOMICAL = 18;
  public const int LC_INSUNIT_LIGHTYEARS = 19;
  public const int LC_INSUNIT_PARSECS = 20;
  public const int LC_LUNIT_SCIEN = 1;
  public const int LC_LUNIT_DECIM = 2;
  public const int LC_LUNIT_ENGIN = 3;
  public const int LC_LUNIT_ARCHI = 4;
  public const int LC_LUNIT_FRACT = 5;
  public const int LC_AUNIT_DEGREE = 0;
  public const int LC_AUNIT_DMS = 1;
  public const int LC_AUNIT_GRAD = 2;
  public const int LC_AUNIT_RADIAN = 3;
  public const int LC_AUNIT_SURVEY = 4;
  public const int LC_ANGLE_DEGREE = 0;
  public const int LC_ANGLE_DMS = 1;
  public const int LC_ANGLE_GRAD = 2;
  public const int LC_ANGLE_RADIAN = 3;
  public const int LC_ANGLE_SURVEY = 4;
  public const double LC_PI = 3.14159265358979323846;
  public const double LC_PI2 = 1.57079632679489661923;
  public const double LC_PI4 = 0.785398163397448309615;
  public const double LC_2PI = 6.28318530717958647692;
  public const double LC_DEG45 = 0.785398163397448309615;
  public const double LC_DEG90 = 1.57079632679489661923;
  public const double LC_DEG180 = 3.14159265358979323846;
  public const double LC_DEG270 = 4.71238898038468985769;
  public const double LC_DEG360 = 6.28318530717958647692;
  public const double LC_RAD_TO_DEG = 57.2957795130823208;
  public const double LC_DEG_TO_RAD = 0.0174532925199433;
  public const int LC_VIEW_TOP = 0;
  public const int LC_VIEW_PLAN = 0;
  public const int LC_VIEW_BOTTOM = 1;
  public const int LC_VIEW_LEFT = 2;
  public const int LC_VIEW_RIGHT = 3;
  public const int LC_VIEW_FRONT = 4;
  public const int LC_VIEW_BACK = 5;
  public const int LC_VIEW_SW = 6;
  public const int LC_VIEW_SE = 7;
  public const int LC_VIEW_NE = 8;
  public const int LC_VIEW_NW = 9;
  public const int LC_VIEW_ISOMETRIC = 10;
  public const int LC_VIEW_PERSPECTIVE = 11;
  public const int LC_PLANE_XY = 0;
  public const int LC_PLANE_XZ = 1;
  public const int LC_PLANE_YZ = 2;
  public const int LC_PAPER_CUSTOM = 0;
  public const int LC_PAPER_A0 = 1;
  public const int LC_PAPER_A1 = 2;
  public const int LC_PAPER_A2 = 3;
  public const int LC_PAPER_A3 = 4;
  public const int LC_PAPER_A4 = 5;
  public const int LC_PAPER_A5 = 6;
  public const int LC_PAPER_A6 = 7;
  public const int LC_PAPER_B0 = 11;
  public const int LC_PAPER_B1 = 12;
  public const int LC_PAPER_B2 = 13;
  public const int LC_PAPER_B3 = 14;
  public const int LC_PAPER_B4 = 15;
  public const int LC_PAPER_B5 = 16;
  public const int LC_PAPER_B6 = 17;
  public const int LC_PAPER_C0 = 21;
  public const int LC_PAPER_C1 = 22;
  public const int LC_PAPER_C2 = 23;
  public const int LC_PAPER_C3 = 24;
  public const int LC_PAPER_C4 = 25;
  public const int LC_PAPER_C5 = 26;
  public const int LC_PAPER_C6 = 27;
  public const int LC_PAPER_ANSI_A = 31;
  public const int LC_PAPER_ANSI_B = 32;
  public const int LC_PAPER_ANSI_C = 33;
  public const int LC_PAPER_ANSI_D = 34;
  public const int LC_PAPER_ANSI_E = 35;
  public const int LC_PAPER_LETTER = 36;
  public const int LC_PAPER_LEGAL = 37;
  public const int LC_PAPER_EXECUTIVE = 38;
  public const int LC_PAPER_LEDGER = 39;
  public const int LC_PAPER_PORTRAIT = 0;
  public const int LC_PAPER_BOOK = 0;
  public const int LC_PAPER_LANDSCAPE = 1;
  public const int LC_PAPER_ALBUM = 1;
  public const int LC_BLOCK_OVERWRITENO = 0;
  public const int LC_BLOCK_OVERWRITEYES = 1;
  public const int LC_BLOCK_OVERWRITEDLG = 2;
  public const int LC_OBJ_LAYER = 1;
  public const int LC_OBJ_LINETYPE = 2;
  public const int LC_OBJ_TEXTSTYLE = 3;
  public const int LC_OBJ_DIMSTYLE = 4;
  public const int LC_OBJ_BLOCK = 5;
  public const int LC_OBJ_IMAGE = 6;
  public const int LC_OBJ_VIEW = 7;
  public const int LC_ENT_LINE = 101;
  public const int LC_ENT_POLYLINE = 102;
  public const int LC_ENT_CIRCLE = 103;
  public const int LC_ENT_ARC = 104;
  public const int LC_ENT_BLOCKREF = 105;
  public const int LC_ENT_POINT = 107;
  public const int LC_ENT_XLINE = 108;
  public const int LC_ENT_ELLIPSE = 109;
  public const int LC_ENT_TEXT = 110;
  public const int LC_ENT_TEXTWIN = 111;
  public const int LC_ENT_IMAGEREF = 115;
  public const int LC_ENT_VIEWPORT = 116;
  public const int LC_ENT_RECT = 118;
  public const int LC_ENT_ATTRIB = 120;
  public const int LC_ENT_ECW = 121;
  public const int LC_ENT_MTEXT = 122;
  public const int LC_ENT_ARCTEXT = 123;
  public const int LC_ENT_HATCH = 124;
  public const int LC_ENT_BEZIER = 125;
  public const int LC_ENT_DIMROT = 131;
  public const int LC_ENT_DIMALI = 132;
  public const int LC_ENT_DIMORD = 133;
  public const int LC_ENT_DIMRAD = 134;
  public const int LC_ENT_DIMDIA = 135;
  public const int LC_ENT_DIMANG = 136;
  public const int LC_ENT_LEADER = 137;
  public const int LC_ENT_CUSTOM = 1000;
  public const int LC_ENT_ALL = 32767;
  public const int LC_LWEIGHT_DEFAULT = -3;
  public const int LC_LWEIGHT_BYBLOCK = -2;
  public const int LC_LWEIGHT_BYLAYER = -1;
  public const int LC_LWEIGHT_000 = 0;
  public const int LC_LWEIGHT_005 = 5;
  public const int LC_LWEIGHT_009 = 9;
  public const int LC_LWEIGHT_013 = 13;
  public const int LC_LWEIGHT_015 = 15;
  public const int LC_LWEIGHT_018 = 18;
  public const int LC_LWEIGHT_020 = 20;
  public const int LC_LWEIGHT_025 = 25;
  public const int LC_LWEIGHT_030 = 30;
  public const int LC_LWEIGHT_035 = 35;
  public const int LC_LWEIGHT_040 = 40;
  public const int LC_LWEIGHT_050 = 50;
  public const int LC_LWEIGHT_053 = 53;
  public const int LC_LWEIGHT_060 = 60;
  public const int LC_LWEIGHT_070 = 70;
  public const int LC_LWEIGHT_080 = 80;
  public const int LC_LWEIGHT_090 = 90;
  public const int LC_LWEIGHT_100 = 100;
  public const int LC_LWEIGHT_106 = 106;
  public const int LC_LWEIGHT_120 = 120;
  public const int LC_LWEIGHT_140 = 140;
  public const int LC_LWEIGHT_158 = 158;
  public const int LC_LWEIGHT_200 = 200;
  public const int LC_LWEIGHT_211 = 211;
  public const int LC_KBD_QWERTY = 0;
  public const int LC_KBD_AZERTY = 1;
  public const int LC_CMD_FILESAVE = 4;
  public const int LC_CMD_FILESAVEAS = 5;
  public const int LC_CMD_PRINT = 7;
  public const int LC_CMD_RASTERIZE = 8;
  public const int LC_CMD_POINT = 201;
  public const int LC_CMD_LINE = 202;
  public const int LC_CMD_XLINE = 203;
  public const int LC_CMD_RAY = 204;
  public const int LC_CMD_PLINE = 205;
  public const int LC_CMD_POLYLINE = 205;
  public const int LC_CMD_RECT = 206;
  public const int LC_CMD_CIRCLE = 207;
  public const int LC_CMD_ARC = 208;
  public const int LC_CMD_ELLIPSE = 209;
  public const int LC_CMD_TEXT = 210;
  public const int LC_CMD_MTEXT = 211;
  public const int LC_CMD_ATEXT = 212;
  public const int LC_CMD_INSERT = 213;
  public const int LC_CMD_VPORT = 214;
  public const int LC_CMD_BASEPOINT = 215;
  public const int LC_CMD_ATTDEF = 216;
  public const int LC_CMD_HATCH = 217;
  public const int LC_CMD_BOUNDARY = 218;
  public const int LC_CMD_WTEXT = 219;
  public const int LC_CMD_DIMROT = 231;
  public const int LC_CMD_DIMALI = 232;
  public const int LC_CMD_DIMORD = 233;
  public const int LC_CMD_DIMRAD = 234;
  public const int LC_CMD_DIMDIA = 235;
  public const int LC_CMD_DIMANG = 236;
  public const int LC_CMD_LEADER = 237;
  public const int LC_CMD_CENTER = 238;
  public const int LC_CMD_ECW = 239;
  public const int LC_CMD_CBCUT = 301;
  public const int LC_CMD_CBCOPY = 302;
  public const int LC_CMD_CBPASTE = 303;
  public const int LC_CMD_UNDO = 304;
  public const int LC_CMD_REDO = 305;
  public const int LC_CMD_COPY = 306;
  public const int LC_CMD_ERASE = 307;
  public const int LC_CMD_MOVE = 308;
  public const int LC_CMD_ROTATE = 309;
  public const int LC_CMD_SCALE = 310;
  public const int LC_CMD_MIRROR = 311;
  public const int LC_CMD_EXPLODE = 312;
  public const int LC_CMD_JOIN = 314;
  public const int LC_CMD_DEP = 315;
  public const int LC_CMD_ORDER = 316;
  public const int LC_CMD_CLOSEBLOCK = 317;
  public const int LC_CMD_TRIM = 318;
  public const int LC_CMD_EXTEND = 319;
  public const int LC_CMD_OFFSET = 320;
  public const int LC_CMD_OFFSET_POINT = 0;
  public const int LC_CMD_OFFSET_DIST = 1;
  public const int LC_CMD_BREAK = 321;
  public const int LC_CMD_VIEWSTART = 401;
  public const int LC_CMD_ZOOM_IN = 401;
  public const int LC_CMD_ZOOM_OUT = 402;
  public const int LC_CMD_ZOOM_EXT = 403;
  public const int LC_CMD_ZOOM_LIM = 404;
  public const int LC_CMD_ZOOM_PREV = 405;
  public const int LC_CMD_ZOOM_SEL = 406;
  public const int LC_CMD_PAN_LEFT = 407;
  public const int LC_CMD_PAN_RIGHT = 408;
  public const int LC_CMD_PAN_UP = 409;
  public const int LC_CMD_PAN_DOWN = 410;
  public const int LC_CMD_VIEWEND = 410;
  public const int LC_CMD_PAN_RT = 419;
  public const int LC_CMD_ZOOM_RT = 420;
  public const int LC_CMD_ZOOM_WIN = 421;
  public const int LC_CMD_PAGENEXT = 423;
  public const int LC_CMD_PAGEPREV = 424;
  public const int LC_CMD_PAGEMODEL = 425;
  public const int LC_CMD_PAGEVPORT = 426;
  public const int LC_CMD_VP_ACT = 427;
  public const int LC_CMD_VP_DEACT = 428;
  public const int LC_CMD_VIEW_TOP = 430;
  public const int LC_CMD_VIEW_BOTTOM = 431;
  public const int LC_CMD_VIEW_LEFT = 432;
  public const int LC_CMD_VIEW_RIGHT = 433;
  public const int LC_CMD_VIEW_FRONT = 434;
  public const int LC_CMD_VIEW_BACK = 435;
  public const int LC_CMD_VIEW_SW = 436;
  public const int LC_CMD_VIEW_SE = 437;
  public const int LC_CMD_VIEW_NE = 438;
  public const int LC_CMD_VIEW_NW = 439;
  public const int LC_CMD_VIEW_SET = 440;
  public const int LC_CMD_LAYER = 501;
  public const int LC_CMD_LAYERNF = 502;
  public const int LC_CMD_LAYER2 = 502;
  public const int LC_CMD_COLOR = 503;
  public const int LC_CMD_BCOLOR = 504;
  public const int LC_CMD_LINETYPE = 505;
  public const int LC_CMD_LWEIGHT = 506;
  public const int LC_CMD_TEXTSTYLE = 507;
  public const int LC_CMD_BLOCK = 508;
  public const int LC_CMD_BLOCKS = 509;
  public const int LC_CMD_IMAGE = 510;
  public const int LC_CMD_PNTSTYLE = 511;
  public const int LC_CMD_DIMSTYLE = 512;
  public const int LC_CMD_LAYOUT = 513;
  public const int LC_CMD_LIMITS = 514;
  public const int LC_CMD_UNITS = 515;
  public const int LC_CMD_DRWPRM = 117;
  public const int LC_CMD_SNAP = 105;
  public const int LC_CMD_DAIDS = 106;
  public const int LC_CMD_GRID = 107;
  public const int LC_CMD_POLAR = 108;
  public const int LC_CMD_OSNAP = 109;
  public const int LC_CMD_OPTIONS = 118;
  public const int LC_CMD_PLUGIN = 119;
  public const int LC_CMD_REGEN = 120;
  public const int LC_CMD_SELOPTS = 122;
  public const int LC_CMD_QSELECT = 123;
  public const int LC_CMD_DIST = 124;
  public const int LC_CMD_AREA = 125;
  public const int LC_CMD_SELPGON = 126;
  public const int LC_CMD_SELCLAYER = 127;
  public const int LC_CMD_SELALL = 128;
  public const int LC_CMD_UNSELALL = 129;
  public const int LC_CMD_HELP = 1001;
  public const int LC_CMD_REPEAT = 1002;
  public const int LC_CMD_RESET = 1003;
  public const int LC_CMD_SW_GRID = 1011;
  public const int LC_CMD_SW_GRIDSNAP = 1012;
  public const int LC_CMD_SW_LWEIGHT = 1013;
  public const int LC_CMD_SW_OSNAP = 1014;
  public const int LC_CMD_SW_POLAR = 1015;
  public const int LC_CMD_SW_ORTHO = 1016;
  public const int LC_CMD_SNAP_NONE = 1100;
  public const int LC_CMD_SNAP_NODE = 1101;
  public const int LC_CMD_SNAP_ENDPOINT = 1102;
  public const int LC_CMD_SNAP_MIDPOINT = 1103;
  public const int LC_CMD_SNAP_CENTER = 1104;
  public const int LC_CMD_SNAP_QUADRANT = 1105;
  public const int LC_CMD_SNAP_NEAREST = 1106;
  public const int LC_CMD_SNAP_INTER = 1107;
  public const int LC_CMD_SNAP_PERPEND = 1108;
  public const int LC_CMD_SNAP_TANGENT = 1109;
  public const int LC_CMD_SNAP_INSERT = 1110;
  public const int LC_CMD_SNAP_DIALOG = 1111;
  public const int LC_CMD_CUSTOM = 30000;
  public const int LC_SNAP_NULL = 0;
  public const int LC_SNAP_NODE = 1;
  public const int LC_SNAP_ENDPOINT = 2;
  public const int LC_SNAP_MIDPOINT = 4;
  public const int LC_SNAP_CENTER = 8;
  public const int LC_SNAP_NEAREST = 16;
  public const int LC_SNAP_INTER = 32;
  public const int LC_SNAP_PERPEND = 64;
  public const int LC_SNAP_TANGENT = 128;
  public const int LC_SNAP_QUADRANT = 256;
  public const int LC_SNAP_INSERT = 512;
  public const int LC_SNAP_NONE = 1024;
  public const int LC_SNAP_ALL = 1023;
  public const int LC_SNAP_DBLTANG = 65536;
  public const int LC_HELP_DG_LIMITS = 1;
  public const int LC_HELP_DG_GRID = 2;
  public const int LC_HELP_DG_PSNAP = 3;
  public const int LC_HELP_DG_OSNAP = 4;
  public const int LC_HELP_DG_OSNAP2 = 5;
  public const int LC_HELP_DG_OPTIONS = 6;
  public const int LC_HELP_DG_INPUTCOORD = 7;
  public const int LC_HELP_DG_LAYERS = 8;
  public const int LC_HELP_DG_LAYSTATES = 9;
  public const int LC_HELP_DG_TEXTSTYLES = 10;
  public const int LC_HELP_DG_PNTSTYLE = 11;
  public const int LC_HELP_DG_SELFONT = 13;
  public const int LC_HELP_DG_LINETYPES = 14;
  public const int LC_HELP_DG_LOADLINETYPE = 15;
  public const int LC_HELP_DG_SELLTYPE = 16;
  public const int LC_HELP_DG_COLOR = 17;
  public const int LC_HELP_DG_TEXT = 18;
  public const int LC_HELP_DG_LINEWEIGHT = 19;
  public const int LC_HELP_DG_IMAGES = 20;
  public const int LC_HELP_DG_IMAGEINSERT = 21;
  public const int LC_HELP_DG_BLOCKS = 22;
  public const int LC_HELP_DG_INSERT = 23;
  public const int LC_HELP_DG_PRINT = 24;
  public const int LC_HELP_DG_RASTER = 25;
  public const int LC_HELP_DG_LAYOUTS = 26;
  public const int LC_HELP_DG_PAGEPROP = 27;
  public const int LC_HELP_DG_CREBLOCK = 28;
  public const int LC_HELP_DG_SELBLOCK = 29;
  public const int LC_HELP_DG_SELTSTYLE = 30;
  public const int LC_HELP_DG_ATEXT = 31;
  public const int LC_HELP_DG_FONTREPLACE = 32;
  public const int LC_HELP_DG_ATTDEF = 33;
  public const int LC_HELP_DG_HATCH = 34;
  public const int LC_HELP_DG_DRWPROPS = 35;
  public const int LC_HELP_DG_UNITS = 36;
  public const int LC_COLOR_RGB = 0;
  public const int LC_COLOR_INDEX = 1;
  public const int LC_COLOR_RED = 1;
  public const int LC_COLOR_YELLOW = 2;
  public const int LC_COLOR_GREEN = 3;
  public const int LC_COLOR_CYAN = 4;
  public const int LC_COLOR_BLUE = 5;
  public const int LC_COLOR_MAGENTA = 6;
  public const int LC_COLOR_FOREGROUND = 7;
  public const int LC_COLOR_GRAY = 8;
  public const int LC_COLOR_LTGRAY = 9;
  public const int LC_COLOR_BYBLOCK = 0;
  public const int LC_COLOR_BYLAYER = 256;
  public const int LC_TA_LEFBOT = 0;
  public const int LC_TA_CENBOT = 1;
  public const int LC_TA_RIGBOT = 2;
  public const int LC_TA_LEFCEN = 3;
  public const int LC_TA_CENTER = 4;
  public const int LC_TA_RIGCEN = 5;
  public const int LC_TA_LEFTOP = 6;
  public const int LC_TA_CENTOP = 7;
  public const int LC_TA_RIGTOP = 8;
  public const int LC_TA_ALIGNED = 11;
  public const int LC_TA_FIT = 12;
  public const int LC_TEXT_BACKWARD = 2;
  public const int LC_TEXT_UPDOWN = 4;
  public const int LC_ATA_LEFT = 0;
  public const int LC_ATA_CENTER = 1;
  public const int LC_ATA_RIGHT = 2;
  public const int LC_PLFIT_BULGE = 0;
  public const int LC_PLFIT_QUAD = 5;
  public const int LC_PLFIT_CUBIC = 6;
  public const int LC_PLFIT_SPLINE = 99;
  public const int LC_PLFIT_ROUND = 101;
  public const int LC_PLFIT_LINQUAD = 102;
  public const int LC_POINT_PIXEL = 0;
  public const int LC_POINT_NONE = 1;
  public const int LC_POINT_PLUS = 2;
  public const int LC_POINT_X = 3;
  public const int LC_POINT_TICK = 4;
  public const int LC_POINT_CIRCLE = 32;
  public const int LC_POINT_SQUARE = 64;
  public const int LC_POINT_RHOMB = 128;
  public const int LC_POINT_FILLED = 256;
  public const int LC_FACE_EDGE1HIDDEN = 1;
  public const int LC_FACE_EDGE2HIDDEN = 2;
  public const int LC_FACE_EDGE3HIDDEN = 4;
  public const int LC_FACE_EDGE4HIDDEN = 8;
  public const int LC_LEADER_TCENTER = 0;
  public const int LC_LEADER_TLEFT = 1;
  public const int LC_LEADER_TRIGHT = 2;
  public const int LC_LEADER_VERT = 1;
  public const int LC_LEADER_CORNER = 2;
  public const int LC_ATTRIB_HIDDEN = 1;
  public const int LC_ATTRIB_CONST = 2;
  public const int LC_ATTRIB_VERIFY = 4;
  public const int LC_ATTRIB_PRESET = 8;
  public const int LC_ATTRIB_LOCK = 16;
  public const int LC_ATTRIB_MTEXT = 32;
  public const int LC_DECSEP_POINT = 0;
  public const int LC_DECSEP_COMMA = 1;
  public const int LC_DECSEP_NONE = 2;
  public const int LC_ARROW_CLOSEDF = 0;
  public const int LC_ARROW_CLOSEDB = 1;
  public const int LC_ARROW_CLOSED = 2;
  public const int LC_ARROW_DOT = 3;
  public const int LC_ARROW_ARCHTICK = 4;
  public const int LC_ARROW_OBLIQUE = 5;
  public const int LC_ARROW_OPEN = 6;
  public const int LC_ARROW_ORIGIN = 7;
  public const int LC_ARROW_ORIGIN2 = 8;
  public const int LC_ARROW_OPEN90 = 9;
  public const int LC_ARROW_OPEN30 = 10;
  public const int LC_ARROW_DOTSMALL = 11;
  public const int LC_ARROW_DOTB = 12;
  public const int LC_ARROW_DOTSMALLB = 13;
  public const int LC_ARROW_BOX = 14;
  public const int LC_ARROW_BOXF = 15;
  public const int LC_ARROW_DATUM = 16;
  public const int LC_ARROW_DATUMF = 17;
  public const int LC_ARROW_INTEGRAL = 18;
  public const int LC_ARROW_NONE = 19;
  public const int LC_PLUG_IMPDRW = 2;
  public const int LC_PLUG_EXPDRW = 3;
  public const int LC_PLUG_IMGDIB = 4;
  public const int LC_FP_FLOAD = 0;
  public const int LC_FP_FSAVE = 1;
  public const int LC_FP_NITEMS = 2;
  public const int LC_FP_ITEM = 3;
  public const int LC_DG_SELFILE = 0;
  public const int LC_DG_RECENT = 1;
  public const int LC_DG_TEMPLATE = 2;
  public const int LC_ERR_USERCANCEL = 1;
  public const int LC_ERR_OBJTYPE = 2;
  public const int LC_ERR_FILENAME = 3;
  public const int LC_ERR_FILELOAD = 4;
  public const int LC_ERR_FILESAVE = 5;
  public const int LC_ERR_NOTAG = 6;
  public const int LC_ERR_UNRESBLOCKREF = 7;
  public const int LC_ERR_UNRESVIEWREF = 8;
  public const int LC_ERR_UNRESHATCH = 9;
  public const int LC_ERR_SELBLOCKM = 10;
  public const int LC_ERR_SELBLOCKP = 11;
  public const int LC_MAX_USERPNT = 100;
  public const int LC_PROP_G_REGCODE = 1;
  public const int LC_PROP_G_VERSION = 2;
  public const int LC_PROP_G_DIRDLL = 3;
  public const int LC_PROP_G_DIRCFG = 4;
  public const int LC_PROP_G_DIRFONTS = 5;
  public const int LC_PROP_G_FILEHATCH = 6;
  public const int LC_PROP_G_FILELTYPE = 7;
  public const int LC_PROP_G_TEMPLATE = 8;
  public const int LC_PROP_G_DIRTEMPLATE = 9;
  public const int LC_PROP_G_OWNDXFR = 10;
  public const int LC_PROP_G_OWNDXFW = 11;
  public const int LC_PROP_G_PANSTEP = 12;
  public const int LC_PROP_G_PANFILLING = 13;
  public const int LC_PROP_G_PANHATCH = 14;
  public const int LC_PROP_G_PANPLWIDTH = 15;
  public const int LC_PROP_G_PANLWEIGHT = 16;
  public const int LC_PROP_G_PANFILLCHAR = 17;
  public const int LC_PROP_G_PANRECTCHAR = 18;
  public const int LC_PROP_G_CURSORARROW = 101;
  public const int LC_PROP_G_CURSORCROSS = 102;
  public const int LC_PROP_G_CURSORSIZE = 103;
  public const int LC_PROP_G_AUTOSELECT = 110;
  public const int LC_PROP_G_PICKFIRST = 111;
  public const int LC_PROP_G_PICKAUTO = 112;
  public const int LC_PROP_G_PICKDRAG = 113;
  public const int LC_PROP_G_PICKADD = 114;
  public const int LC_PROP_G_PICKBOXSIZE = 115;
  public const int LC_PROP_G_AUTOUNSELECT = 116;
  public const int LC_PROP_G_SELBYLAYER = 117;
  public const int LC_PROP_G_SELINSIDE = 118;
  public const int LC_PROP_G_ENABLEGRIPS = 119;
  public const int LC_PROP_G_GRIPSIZE = 120;
  public const int LC_PROP_G_GRIPCOLOR = 121;
  public const int LC_PROP_G_GRIPSLIMIT = 122;
  public const int LC_PROP_G_SELCOLOR = 123;
  public const int LC_PROP_G_DRAGCOLOR = 124;
  public const int LC_PROP_G_DLGRECENT = 125;
  public const int LC_PROP_G_AXES = 139;
  public const int LC_PROP_G_AXESTOP = 140;
  public const int LC_PROP_G_GETDELENT = 143;
  public const int LC_PROP_G_WNDSTYLE = 144;
  public const int LC_PROP_G_OCXSAVECFG = 145;
  public const int LC_PROP_G_INITCOUNT = 146;
  public const int LC_PROP_G_CMDFONT = 147;
  public const int LC_PROP_G_CMDFONTSIZE = 148;
  public const int LC_PROP_G_ANGSEPDMS = 149;
  public const int LC_PROP_G_ADDRECENT = 150;
  public const int LC_PROP_LNG_TAG = 251;
  public const int LC_PROP_LNG_STR = 252;
  public const int LC_PROP_LNG_STR0 = 253;
  public const int LC_PROP_LNG_OLD = 254;
  public const int LC_PROP_FONT_FILENAME = 281;
  public const int LC_PROP_FONT_NAME = 282;
  public const int LC_PROP_FONT_HEIGHT = 283;
  public const int LC_PROP_FONT_FILLED = 284;
  public const int LC_PROP_FONT_TTF = 285;
  public const int LC_PROP_FONT_NCHARS = 286;
  public const int LC_PROP_FONT_CHARCODE = 287;
  public const int LC_PROP_FONT_CHAR = 288;
  public const int LC_PROP_WND_ID = 301;
  public const int LC_PROP_WND_VIEW = 302;
  public const int LC_PROP_WND_VIEWBLOCK = 303;
  public const int LC_PROP_WND_VIEWDRW = 304;
  public const int LC_PROP_WND_WIDTH = 306;
  public const int LC_PROP_WND_HEIGHT = 307;
  public const int LC_PROP_WND_HWND = 308;
  public const int LC_PROP_WND_FOCUS = 309;
  public const int LC_PROP_WND_EMPTYTEXT = 310;
  public const int LC_PROP_WND_CURSORX = 311;
  public const int LC_PROP_WND_CURSORY = 312;
  public const int LC_PROP_WND_HASBASE = 314;
  public const int LC_PROP_WND_BASEX = 315;
  public const int LC_PROP_WND_BASEY = 316;
  public const int LC_PROP_WND_BASEDIST = 318;
  public const int LC_PROP_WND_BASEANGLE = 319;
  public const int LC_PROP_WND_HOCX = 321;
  public const int LC_PROP_WND_DRAWPICKBOX = 322;
  public const int LC_PROP_WND_COMMAND = 323;
  public const int LC_PROP_WND_PIXELSIZE = 324;
  public const int LC_PROP_DRW_GUID = 401;
  public const int LC_PROP_DRW_FILENAME = 402;
  public const int LC_PROP_DRW_READONLY = 403;
  public const int LC_PROP_DRW_COLORBACKM = 414;
  public const int LC_PROP_DRW_COLORBACKP = 415;
  public const int LC_PROP_DRW_COLORFOREM = 416;
  public const int LC_PROP_DRW_COLORFOREP = 417;
  public const int LC_PROP_DRW_COLORCURSORM = 418;
  public const int LC_PROP_DRW_COLORCURSORP = 419;
  public const int LC_PROP_DRW_COLORPAPER = 420;
  public const int LC_PROP_DRW_COLORPAPER2 = 421;
  public const int LC_PROP_DRW_LUNITS = 422;
  public const int LC_PROP_DRW_LUPREC = 423;
  public const int LC_PROP_DRW_INSUNITS = 424;
  public const int LC_PROP_DRW_AUNITS = 425;
  public const int LC_PROP_DRW_AUPREC = 426;
  public const int LC_PROP_DRW_ANGBASE = 427;
  public const int LC_PROP_DRW_ANGDIR = 428;
  public const int LC_PROP_DRW_PDMODE = 429;
  public const int LC_PROP_DRW_PDSIZE = 430;
  public const int LC_PROP_DRW_COLOR = 501;
  public const int LC_PROP_DRW_BCOLOR = 502;
  public const int LC_PROP_DRW_COLORBYLAYER = 503;
  public const int LC_PROP_DRW_COLORBYBLOCK = 504;
  public const int LC_PROP_DRW_BCOLORBYLAYER = 505;
  public const int LC_PROP_DRW_BCOLORBYBLOCK = 506;
  public const int LC_PROP_DRW_COLORI = 507;
  public const int LC_PROP_DRW_COLORT = 508;
  public const int LC_PROP_DRW_BCOLORI = 509;
  public const int LC_PROP_DRW_BCOLORT = 510;
  public const int LC_PROP_DRW_LAYER = 511;
  public const int LC_PROP_DRW_LINETYPE = 512;
  public const int LC_PROP_DRW_LTSCALE = 513;
  public const int LC_PROP_DRW_TEXTSTYLE = 514;
  public const int LC_PROP_DRW_VIEW = 515;
  public const int LC_PROP_DRW_LWEIGHT = 516;
  public const int LC_PROP_DRW_LWDEFAULT = 517;
  public const int LC_PROP_DRW_LWSCALE = 518;
  public const int LC_PROP_DRW_LWDISPLAY = 519;
  public const int LC_PROP_DRW_DESCR = 559;
  public const int LC_PROP_DRW_COMMENT = 559;
  public const int LC_PROP_DRW_INT0 = 560;
  public const int LC_PROP_DRW_INT1 = 561;
  public const int LC_PROP_DRW_INT2 = 562;
  public const int LC_PROP_DRW_INT3 = 563;
  public const int LC_PROP_DRW_INT4 = 564;
  public const int LC_PROP_DRW_INT5 = 565;
  public const int LC_PROP_DRW_INT6 = 566;
  public const int LC_PROP_DRW_INT7 = 567;
  public const int LC_PROP_DRW_INT8 = 568;
  public const int LC_PROP_DRW_INT9 = 569;
  public const int LC_PROP_DRW_FLOAT0 = 570;
  public const int LC_PROP_DRW_FLOAT1 = 571;
  public const int LC_PROP_DRW_FLOAT2 = 572;
  public const int LC_PROP_DRW_FLOAT3 = 573;
  public const int LC_PROP_DRW_FLOAT4 = 574;
  public const int LC_PROP_DRW_FLOAT5 = 575;
  public const int LC_PROP_DRW_FLOAT6 = 576;
  public const int LC_PROP_DRW_FLOAT7 = 577;
  public const int LC_PROP_DRW_FLOAT8 = 578;
  public const int LC_PROP_DRW_FLOAT9 = 579;
  public const int LC_PROP_DRW_STR0 = 580;
  public const int LC_PROP_DRW_STR1 = 581;
  public const int LC_PROP_DRW_STR2 = 582;
  public const int LC_PROP_DRW_STR3 = 583;
  public const int LC_PROP_DRW_STR4 = 584;
  public const int LC_PROP_DRW_STR5 = 585;
  public const int LC_PROP_DRW_STR6 = 586;
  public const int LC_PROP_DRW_STR7 = 587;
  public const int LC_PROP_DRW_STR8 = 588;
  public const int LC_PROP_DRW_STR9 = 589;
  public const int LC_PROP_DRW_XDATASIZE = 590;
  public const int LC_PROP_DRW_XDATA = 591;
  public const int LC_PROP_DRW_HOCX = 598;
  public const int LC_PROP_DRW_DIRTY = 599;
  public const int LC_PROP_TABLE_ID = 1001;
  public const int LC_PROP_TABLE_NAME = 1002;
  public const int LC_PROP_TABLE_DESC = 1003;
  public const int LC_PROP_TABLE_DESCR = 1003;
  public const int LC_PROP_TABLE_DELETED = 1004;
  public const int LC_PROP_TABLE_DRW = 1005;
  public const int LC_PROP_TABLE_ODHANDLE = 1005;
  public const int LC_PROP_TABLE_PRIORITY = 1006;
  public const int LC_PROP_TABLE_XDATASIZE = 1007;
  public const int LC_PROP_TABLE_XDATA = 1008;
  public const int LC_PROP_TABLE_XSTR = 1009;
  public const int LC_PROP_TABLE_INT0 = 1010;
  public const int LC_PROP_TABLE_INT1 = 1011;
  public const int LC_PROP_TABLE_INT2 = 1012;
  public const int LC_PROP_TABLE_INT3 = 1013;
  public const int LC_PROP_TABLE_INT4 = 1014;
  public const int LC_PROP_TABLE_FLOAT0 = 1015;
  public const int LC_PROP_TABLE_FLOAT1 = 1016;
  public const int LC_PROP_TABLE_FLOAT2 = 1017;
  public const int LC_PROP_TABLE_FLOAT3 = 1018;
  public const int LC_PROP_TABLE_FLOAT4 = 1019;
  public const int LC_PROP_LAYER_ID = 1021;
  public const int LC_PROP_LAYER_NAME = 1022;
  public const int LC_PROP_LAYER_DESC = 1023;
  public const int LC_PROP_LAYER_DELETED = 1024;
  public const int LC_PROP_LAYER_COLOR = 1025;
  public const int LC_PROP_LAYER_BCOLOR = 1026;
  public const int LC_PROP_LAYER_COLORI = 1027;
  public const int LC_PROP_LAYER_COLORT = 1028;
  public const int LC_PROP_LAYER_BCOLORI = 1029;
  public const int LC_PROP_LAYER_BCOLORT = 1030;
  public const int LC_PROP_LAYER_LINETYPE = 1031;
  public const int LC_PROP_LAYER_LWEIGHT = 1032;
  public const int LC_PROP_LAYER_LOCKED = 1033;
  public const int LC_PROP_LAYER_NOPRINT = 1034;
  public const int LC_PROP_LAYER_VISIBLE = 1035;
  public const int LC_PROP_LAYER_0 = 1036;
  public const int LC_PROP_LAYER_DRW = 1037;
  public const int LC_PROP_LAYER_NODLG = 1038;
  public const int LC_PROP_LINETYPE_ID = 1041;
  public const int LC_PROP_LINETYPE_NAME = 1042;
  public const int LC_PROP_LINETYPE_DESC = 1043;
  public const int LC_PROP_LINETYPE_DELETED = 1044;
  public const int LC_PROP_LINETYPE_DATA = 1045;
  public const int LC_PROP_LINETYPE_SCALE = 1046;
  public const int LC_PROP_LINETYPE_CONTINUOUS = 1047;
  public const int LC_PROP_LINETYPE_BYLAYER = 1048;
  public const int LC_PROP_LINETYPE_BYBLOCK = 1049;
  public const int LC_PROP_LINETYPE_STD = 1050;
  public const int LC_PROP_LINETYPE_PATLEN = 1051;
  public const int LC_PROP_LINETYPE_DRW = 1052;
  public const int LC_PROP_LINETYPE_NELEM = 1053;
  public const int LC_PROP_LINETYPE_IELEM = 1054;
  public const int LC_PROP_LTELEM_LEN = 1055;
  public const int LC_PROP_LTELEM_COMPLEX = 1056;
  public const int LC_PROP_LTELEM_SHAPE = 1057;
  public const int LC_PROP_LTELEM_TEXT = 1058;
  public const int LC_PROP_LTELEM_STYLE = 1059;
  public const int LC_PROP_LTELEM_FONTNAME = 1060;
  public const int LC_PROP_LTELEM_SCALE = 1061;
  public const int LC_PROP_LTELEM_ANGLE = 1062;
  public const int LC_PROP_LTELEM_ABSANGLE = 1063;
  public const int LC_PROP_LTELEM_X = 1064;
  public const int LC_PROP_LTELEM_Y = 1065;
  public const int LC_PROP_TSTYLE_ID = 1071;
  public const int LC_PROP_TSTYLE_NAME = 1072;
  public const int LC_PROP_TSTYLE_DESC = 1073;
  public const int LC_PROP_TSTYLE_DELETED = 1074;
  public const int LC_PROP_TSTYLE_FONT = 1075;
  public const int LC_PROP_TSTYLE_HEIGHT = 1076;
  public const int LC_PROP_TSTYLE_WSCALE = 1077;
  public const int LC_PROP_TSTYLE_OBLIQUE = 1078;
  public const int LC_PROP_TSTYLE_ANGLE = 1079;
  public const int LC_PROP_TSTYLE_ALIGN = 1080;
  public const int LC_PROP_TSTYLE_UPDOWN = 1081;
  public const int LC_PROP_TSTYLE_BACKWARD = 1082;
  public const int LC_PROP_TSTYLE_LINESPACE = 1083;
  public const int LC_PROP_TSTYLE_CHARSPACE = 1084;
  public const int LC_PROP_TSTYLE_STANDARD = 1085;
  public const int LC_PROP_TSTYLE_SHAPES = 1086;
  public const int LC_PROP_TSTYLE_WINFONT = 1087;
  public const int LC_PROP_TSTYLE_BOLD = 1088;
  public const int LC_PROP_TSTYLE_ITALIC = 1089;
  public const int LC_PROP_TSTYLE_UNDERLINE = 1090;
  public const int LC_PROP_TSTYLE_STRIKEOUT = 1091;
  public const int LC_PROP_TSTYLE_DRW = 1092;
  public const int LC_PROP_DIMST_ID = 1101;
  public const int LC_PROP_DIMST_NAME = 1102;
  public const int LC_PROP_DIMST_DESC = 1103;
  public const int LC_PROP_DIMST_DELETED = 1104;
  public const int LC_PROP_DIMST_STANDARD = 1114;
  public const int LC_PROP_DIMST_DRW = 1115;
  public const int LC_PROP_DIMST_TSTYLE = 1116;
  public const int LC_PROP_BLOCK_ID = 1131;
  public const int LC_PROP_BLOCK_NAME = 1132;
  public const int LC_PROP_BLOCK_DESC = 1133;
  public const int LC_PROP_BLOCK_DELETED = 1134;
  public const int LC_PROP_BLOCK_X = 1135;
  public const int LC_PROP_BLOCK_Y = 1136;
  public const int LC_PROP_BLOCK_Z = 1137;
  public const int LC_PROP_BLOCK_UFSCALING = 1138;
  public const int LC_PROP_BLOCK_UNITS = 1139;
  public const int LC_PROP_BLOCK_UNITSCALE = 1140;
  public const int LC_PROP_BLOCK_MODEL = 1141;
  public const int LC_PROP_BLOCK_PAPER = 1142;
  public const int LC_PROP_BLOCK_LAYOUT = 1143;
  public const int LC_PROP_BLOCK_STANDARD = 1144;
  public const int LC_PROP_BLOCK_HIDDEN = 1145;
  public const int LC_PROP_BLOCK_DIM = 1146;
  public const int LC_PROP_BLOCK_HATCH = 1147;
  public const int LC_PROP_BLOCK_DRW = 1148;
  public const int LC_PROP_BLOCK_NOBJ = 1149;
  public const int LC_PROP_BLOCK_NSELOBJ = 1150;
  public const int LC_PROP_BLOCK_ATTRIBS = 1157;
  public const int LC_PROP_BLOCK_BASE = 1159;
  public const int LC_PROP_VIEW_ID = 1161;
  public const int LC_PROP_VIEW_NAME = 1162;
  public const int LC_PROP_VIEW_DESC = 1163;
  public const int LC_PROP_VIEW_DELETED = 1164;
  public const int LC_PROP_VIEW_BLOCK = 1165;
  public const int LC_PROP_VIEW_MODEL = 1166;
  public const int LC_PROP_VIEW_PAPER = 1168;
  public const int LC_PROP_VIEW_XMIN = 1173;
  public const int LC_PROP_VIEW_YMIN = 1174;
  public const int LC_PROP_VIEW_XMAX = 1175;
  public const int LC_PROP_VIEW_YMAX = 1176;
  public const int LC_PROP_VIEW_LEF = 1177;
  public const int LC_PROP_VIEW_BOT = 1178;
  public const int LC_PROP_VIEW_RIG = 1179;
  public const int LC_PROP_VIEW_TOP = 1180;
  public const int LC_PROP_VIEW_PIXELSIZE = 1181;
  public const int LC_PROP_VIEW_LIMITS = 1182;
  public const int LC_PROP_VIEW_COLORBACK = 1186;
  public const int LC_PROP_VIEW_COLORFORE = 1187;
  public const int LC_PROP_VIEW_COLORCURSOR = 1188;
  public const int LC_PROP_VIEW_GRID = 1191;
  public const int LC_PROP_VIEW_GRIDSNAP = 1192;
  public const int LC_PROP_VIEW_OSNAP = 1193;
  public const int LC_PROP_VIEW_OSNAPMODE = 1194;
  public const int LC_PROP_VIEW_PTRACK = 1195;
  public const int LC_PROP_VIEW_ORTHO = 1196;
  public const int LC_PROP_VIEW_ORDER = 1230;
  public const int LC_PROP_VIEW_DRW = 1231;
  public const int LC_PROP_PAPER_SIZE = 1241;
  public const int LC_PROP_PAPER_ORIENT = 1242;
  public const int LC_PROP_PAPER_W = 1243;
  public const int LC_PROP_PAPER_H = 1244;
  public const int LC_PROP_PAPER_X0 = 1245;
  public const int LC_PROP_PAPER_Y0 = 1246;
  public const int LC_PROP_PAPER_INCH = 1247;
  public const int LC_PROP_IMAGE_ID = 1301;
  public const int LC_PROP_IMAGE_NAME = 1302;
  public const int LC_PROP_IMAGE_DESC = 1303;
  public const int LC_PROP_IMAGE_DELETED = 1304;
  public const int LC_PROP_IMAGE_FILENAME = 1305;
  public const int LC_PROP_IMAGE_SIZE = 1306;
  public const int LC_PROP_IMAGE_WPIX = 1307;
  public const int LC_PROP_IMAGE_HPIX = 1308;
  public const int LC_PROP_IMAGE_CBIT = 1309;
  public const int LC_PROP_IMAGE_DRW = 1310;
  public const int LC_PROP_ENT_ID = 3001;
  public const int LC_PROP_ENT_KEY = 3002;
  public const int LC_PROP_ENT_COLOR = 3003;
  public const int LC_PROP_ENT_BCOLOR = 3004;
  public const int LC_PROP_ENT_COLORBYLAYER = 3005;
  public const int LC_PROP_ENT_COLORBYBLOCK = 3006;
  public const int LC_PROP_ENT_BCOLORBYLAYER = 3007;
  public const int LC_PROP_ENT_BCOLORBYBLOCK = 3008;
  public const int LC_PROP_ENT_COLORI = 3009;
  public const int LC_PROP_ENT_COLORT = 3010;
  public const int LC_PROP_ENT_BCOLORI = 3011;
  public const int LC_PROP_ENT_BCOLORT = 3012;
  public const int LC_PROP_ENT_LAYER = 3013;
  public const int LC_PROP_ENT_LINETYPE = 3014;
  public const int LC_PROP_ENT_LTSCALE = 3015;
  public const int LC_PROP_ENT_LWEIGHT = 3016;
  public const int LC_PROP_ENT_BLOCK = 3017;
  public const int LC_PROP_ENT_DRW = 3018;
  public const int LC_PROP_ENT_BORDER = 3019;
  public const int LC_PROP_ENT_LOCKED = 3020;
  public const int LC_PROP_ENT_FILLED = 3021;
  public const int LC_PROP_ENT_VISIBLE = 3022;
  public const int LC_PROP_ENT_HIDDEN = 3023;
  public const int LC_PROP_ENT_BLINK = 3024;
  public const int LC_PROP_ENT_TYPE = 3025;
  public const int LC_PROP_ENT_DELETED = 3026;
  public const int LC_PROP_ENT_IMMORTAL = 3027;
  public const int LC_PROP_ENT_SELECTED = 3028;
  public const int LC_PROP_ENT_PRIORITY = 3029;
  public const int LC_PROP_ENT_XDATASIZE = 3031;
  public const int LC_PROP_ENT_XDATA = 3032;
  public const int LC_PROP_ENT_XSTR = 3033;
  public const int LC_PROP_ENT_XGUID = 3034;
  public const int LC_PROP_ENT_Z = 3035;
  public const int LC_PROP_POINT_X = 3102;
  public const int LC_PROP_POINT_Y = 3103;
  public const int LC_PROP_POINT_OWNSTYLE = 3105;
  public const int LC_PROP_POINT_SIZE = 3106;
  public const int LC_PROP_POINT_MODE = 3107;
  public const int LC_PROP_POINT_BORDER = 3108;
  public const int LC_PROP_POINT_POS = 3109;
  public const int LC_PROP_LINE_X0 = 3121;
  public const int LC_PROP_LINE_Y0 = 3122;
  public const int LC_PROP_LINE_X1 = 3124;
  public const int LC_PROP_LINE_Y1 = 3125;
  public const int LC_PROP_LINE_DX = 3127;
  public const int LC_PROP_LINE_DY = 3128;
  public const int LC_PROP_LINE_ANG = 3130;
  public const int LC_PROP_LINE_LEN = 3131;
  public const int LC_PROP_LINE_START = 3132;
  public const int LC_PROP_LINE_END = 3133;
  public const int LC_PROP_XLINE_X0 = 3141;
  public const int LC_PROP_XLINE_Y0 = 3142;
  public const int LC_PROP_XLINE_ANG = 3144;
  public const int LC_PROP_XLINE_DIRX = 3145;
  public const int LC_PROP_XLINE_DIRY = 3146;
  public const int LC_PROP_XLINE_RAY = 3147;
  public const int LC_PROP_XLINE_BASE = 3148;
  public const int LC_PROP_CIRCLE_X = 3201;
  public const int LC_PROP_CIRCLE_Y = 3202;
  public const int LC_PROP_CIRCLE_RAD = 3204;
  public const int LC_PROP_CIRCLE_DIAM = 3205;
  public const int LC_PROP_CIRCLE_LEN = 3206;
  public const int LC_PROP_CIRCLE_AREA = 3207;
  public const int LC_PROP_CIRCLE_FILLED = 3208;
  public const int LC_PROP_CIRCLE_BORDER = 3209;
  public const int LC_PROP_CIRCLE_CENTER = 3210;
  public const int LC_PROP_ARC_X = 3231;
  public const int LC_PROP_ARC_Y = 3232;
  public const int LC_PROP_ARC_RAD = 3234;
  public const int LC_PROP_ARC_ANG0 = 3235;
  public const int LC_PROP_ARC_ANGARC = 3236;
  public const int LC_PROP_ARC_ANGEND = 3237;
  public const int LC_PROP_ARC_X0 = 3238;
  public const int LC_PROP_ARC_Y0 = 3239;
  public const int LC_PROP_ARC_XEND = 3241;
  public const int LC_PROP_ARC_YEND = 3242;
  public const int LC_PROP_ARC_LEN = 3244;
  public const int LC_PROP_ARC_CHLEN = 3245;
  public const int LC_PROP_ARC_AREA = 3246;
  public const int LC_PROP_ARC_FILLED = 3247;
  public const int LC_PROP_ARC_BORDER = 3248;
  public const int LC_PROP_ARC_SECTOR = 3249;
  public const int LC_PROP_ARC_CENTER = 3250;
  public const int LC_PROP_ELL_X = 3261;
  public const int LC_PROP_ELL_Y = 3262;
  public const int LC_PROP_ELL_R1 = 3264;
  public const int LC_PROP_ELL_R2 = 3265;
  public const int LC_PROP_ELL_ANGLE = 3266;
  public const int LC_PROP_ELL_ANG0 = 3267;
  public const int LC_PROP_ELL_ANGARC = 3268;
  public const int LC_PROP_ELL_ANGEND = 3269;
  public const int LC_PROP_ELL_X0 = 3270;
  public const int LC_PROP_ELL_Y0 = 3271;
  public const int LC_PROP_ELL_XEND = 3273;
  public const int LC_PROP_ELL_YEND = 3274;
  public const int LC_PROP_ELL_LEN = 3276;
  public const int LC_PROP_ELL_AREA = 3277;
  public const int LC_PROP_ELL_FILLED = 3278;
  public const int LC_PROP_ELL_BORDER = 3279;
  public const int LC_PROP_ELL_SECTOR = 3280;
  public const int LC_PROP_ELL_CENTER = 3281;
  public const int LC_PROP_PLINE_FIT = 3301;
  public const int LC_PROP_PLINE_NVERS = 3302;
  public const int LC_PROP_PLINE_NPATHS = 3303;
  public const int LC_PROP_PLINE_WIDTH = 3305;
  public const int LC_PROP_PLINE_RADIUS = 3306;
  public const int LC_PROP_PLINE_CHAMFER = 3307;
  public const int LC_PROP_PLINE_LEN = 3308;
  public const int LC_PROP_PLINE_AREA = 3309;
  public const int LC_PROP_PLINE_CLOSED = 3310;
  public const int LC_PROP_PLINE_FILLED = 3311;
  public const int LC_PROP_PLINE_BORDER = 3312;
  public const int LC_PROP_PLINE_HASANG0 = 3313;
  public const int LC_PROP_PLINE_ANG0 = 3314;
  public const int LC_PROP_PLINE_HASANG2 = 3315;
  public const int LC_PROP_PLINE_ANG2 = 3316;
  public const int LC_PROP_RECT_X = 3351;
  public const int LC_PROP_RECT_Y = 3352;
  public const int LC_PROP_RECT_W = 3354;
  public const int LC_PROP_RECT_H = 3355;
  public const int LC_PROP_RECT_ANGLE = 3356;
  public const int LC_PROP_RECT_RAD = 3357;
  public const int LC_PROP_RECT_CHAMFER = 3358;
  public const int LC_PROP_RECT_FILLED = 3359;
  public const int LC_PROP_RECT_BORDER = 3360;
  public const int LC_PROP_RECT_LEN = 3361;
  public const int LC_PROP_RECT_AREA = 3362;
  public const int LC_PROP_RECT_CENTER = 3363;
  public const int LC_PROP_TEXT_STYLE = 3401;
  public const int LC_PROP_TEXT_STR = 3402;
  public const int LC_PROP_TEXT_LEN = 3403;
  public const int LC_PROP_TEXT_ALIGN = 3404;
  public const int LC_PROP_TEXT_X = 3405;
  public const int LC_PROP_TEXT_Y = 3406;
  public const int LC_PROP_TEXT_H = 3411;
  public const int LC_PROP_TEXT_WSCALE = 3412;
  public const int LC_PROP_TEXT_ANGLE = 3413;
  public const int LC_PROP_TEXT_OBLIQUE = 3414;
  public const int LC_PROP_TEXT_CHARSPACE = 3415;
  public const int LC_PROP_TEXT_WRECT = 3416;
  public const int LC_PROP_TEXT_X0 = 3417;
  public const int LC_PROP_TEXT_Y0 = 3418;
  public const int LC_PROP_TEXT_XFIT = 3419;
  public const int LC_PROP_TEXT_YFIT = 3420;
  public const int LC_PROP_TEXT_UPDOWN = 3421;
  public const int LC_PROP_TEXT_BACKWARD = 3422;
  public const int LC_PROP_TEXT_POS = 3423;
  public const int LC_PROP_TEXT_FIT = 3424;
  public const int LC_PROP_TEXTW_STYLE = 3431;
  public const int LC_PROP_TEXTW_STR = 3432;
  public const int LC_PROP_TEXTW_LEN = 3433;
  public const int LC_PROP_TEXTW_ALIGN = 3434;
  public const int LC_PROP_TEXTW_X = 3435;
  public const int LC_PROP_TEXTW_Y = 3436;
  public const int LC_PROP_TEXTW_H = 3438;
  public const int LC_PROP_TEXTW_PIXH = 3439;
  public const int LC_PROP_TEXTW_LABEL = 3439;
  public const int LC_PROP_TEXTW_DX = 3440;
  public const int LC_PROP_TEXTW_DY = 3441;
  public const int LC_PROP_TEXTW_WSCALE = 3442;
  public const int LC_PROP_TEXTW_ANGLE = 3443;
  public const int LC_PROP_TEXTW_POS = 3444;
  public const int LC_PROP_TEXTW_OFFSET = 3445;
  public const int LC_PROP_MTEXT_STYLE = 3451;
  public const int LC_PROP_MTEXT_STR = 3452;
  public const int LC_PROP_MTEXT_LEN = 3453;
  public const int LC_PROP_MTEXT_ALIGN = 3454;
  public const int LC_PROP_MTEXT_X = 3455;
  public const int LC_PROP_MTEXT_Y = 3456;
  public const int LC_PROP_MTEXT_H = 3458;
  public const int LC_PROP_MTEXT_WSCALE = 3459;
  public const int LC_PROP_MTEXT_ANGLE = 3460;
  public const int LC_PROP_MTEXT_OBLIQUE = 3461;
  public const int LC_PROP_MTEXT_WRECT = 3462;
  public const int LC_PROP_MTEXT_HRECT = 3463;
  public const int LC_PROP_MTEXT_WRAPWIDTH = 3464;
  public const int LC_PROP_MTEXT_LINESPACE = 3465;
  public const int LC_PROP_MTEXT_CHARSPACE = 3466;
  public const int LC_PROP_MTEXT_MIRROR = 3467;
  public const int LC_PROP_MTEXT_POS = 3468;
  public const int LC_PROP_ATEXT_STYLE = 3481;
  public const int LC_PROP_ATEXT_STR = 3482;
  public const int LC_PROP_ATEXT_LEN = 3483;
  public const int LC_PROP_ATEXT_X = 3484;
  public const int LC_PROP_ATEXT_Y = 3485;
  public const int LC_PROP_ATEXT_RADIUS = 3487;
  public const int LC_PROP_ATEXT_ANGLE = 3488;
  public const int LC_PROP_ATEXT_CW = 3489;
  public const int LC_PROP_ATEXT_H = 3490;
  public const int LC_PROP_ATEXT_WSCALE = 3491;
  public const int LC_PROP_ATEXT_CHARSPACE = 3492;
  public const int LC_PROP_ATEXT_ALIGN = 3493;
  public const int LC_PROP_ATEXT_POS = 3494;
  public const int LC_PROP_ATT_MODE = 3501;
  public const int LC_PROP_ATT_STYLE = 3502;
  public const int LC_PROP_ATT_TAG = 3503;
  public const int LC_PROP_ATT_PROMPT = 3504;
  public const int LC_PROP_ATT_VALUE = 3505;
  public const int LC_PROP_ATT_ALIGN = 3506;
  public const int LC_PROP_ATT_X = 3507;
  public const int LC_PROP_ATT_Y = 3508;
  public const int LC_PROP_ATT_Z = 3509;
  public const int LC_PROP_ATT_H = 3510;
  public const int LC_PROP_ATT_WSCALE = 3511;
  public const int LC_PROP_ATT_ANGLE = 3512;
  public const int LC_PROP_ATT_OBLIQUE = 3513;
  public const int LC_PROP_ATT_X0 = 3514;
  public const int LC_PROP_ATT_Y0 = 3515;
  public const int LC_PROP_ATT_XFIT = 3516;
  public const int LC_PROP_ATT_YFIT = 3517;
  public const int LC_PROP_ATT_UPDOWN = 3518;
  public const int LC_PROP_ATT_BACKWARD = 3519;
  public const int LC_PROP_ATT_POS = 3520;
  public const int LC_PROP_ATT_FIT = 3521;
  public const int LC_PROP_BLKREF_BLOCK = 3531;
  public const int LC_PROP_BLKREF_X = 3532;
  public const int LC_PROP_BLKREF_Y = 3533;
  public const int LC_PROP_BLKREF_SCALE = 3535;
  public const int LC_PROP_BLKREF_SCX = 3536;
  public const int LC_PROP_BLKREF_SCY = 3537;
  public const int LC_PROP_BLKREF_UFSCALE = 3539;
  public const int LC_PROP_BLKREF_ANGLE = 3540;
  public const int LC_PROP_BLKREF_ATTRIBS = 3541;
  public const int LC_PROP_BLKREF_POS = 3542;
  public const int LC_PROP_IMGREF_IMAGE = 3551;
  public const int LC_PROP_IMGREF_X = 3552;
  public const int LC_PROP_IMGREF_Y = 3553;
  public const int LC_PROP_IMGREF_XC = 3554;
  public const int LC_PROP_IMGREF_YC = 3555;
  public const int LC_PROP_IMGREF_W = 3556;
  public const int LC_PROP_IMGREF_H = 3557;
  public const int LC_PROP_IMGREF_SCALE = 3558;
  public const int LC_PROP_IMGREF_SCX = 3559;
  public const int LC_PROP_IMGREF_SCY = 3560;
  public const int LC_PROP_IMGREF_ANGLE = 3561;
  public const int LC_PROP_IMGREF_UFSCALE = 3562;
  public const int LC_PROP_IMGREF_BORDER = 3563;
  public const int LC_PROP_IMGREF_POS = 3564;
  public const int LC_PROP_IMGREF_PATH = 3566;
  public const int LC_PROP_VPORT_LEF = 3603;
  public const int LC_PROP_VPORT_BOT = 3604;
  public const int LC_PROP_VPORT_RIG = 3605;
  public const int LC_PROP_VPORT_TOP = 3606;
  public const int LC_PROP_VPORT_W = 3607;
  public const int LC_PROP_VPORT_H = 3608;
  public const int LC_PROP_VPORT_VX = 3609;
  public const int LC_PROP_VPORT_VY = 3610;
  public const int LC_PROP_VPORT_VSCALE = 3611;
  public const int LC_PROP_VPORT_VANGLE = 3612;
  public const int LC_PROP_VPORT_FIXSCALE = 3613;
  public const int LC_PROP_VPORT_NFL = 3614;
  public const int LC_PROP_VPORT_RECT = 3615;
  public const int LC_PROP_VPORT_VRECT = 3616;
  public const int LC_PROP_HATCH_NAME = 3631;
  public const int LC_PROP_HATCH_PATTERN = 3632;
  public const int LC_PROP_HATCH_SCALE = 3633;
  public const int LC_PROP_HATCH_ANGLE = 3634;
  public const int LC_PROP_HATCH_SIZE = 3635;
  public const int LC_PROP_HATCH_ASSOC = 3636;
  public const int LC_PROP_HATCH_SOLID = 3637;
  public const int LC_PROP_HATCH_CUSTOM = 3638;
  public const int LC_PROP_HATCH_NPT = 3639;
  public const int LC_PROP_HATCH_NLOOP = 3640;
  public const int LC_PROP_HATCH_NHPL = 3641;
  public const int LC_PROP_HATCH_IHPL = 3642;
  public const int LC_PROP_HPL_ANGLE = 3651;
  public const int LC_PROP_HPL_X0 = 3652;
  public const int LC_PROP_HPL_Y0 = 3653;
  public const int LC_PROP_HPL_DX = 3654;
  public const int LC_PROP_HPL_DY = 3655;
  public const int LC_PROP_HPL_NDASH = 3656;
  public const int LC_PROP_HPL_DASH1 = 3657;
  public const int LC_PROP_HPL_DASH2 = 3658;
  public const int LC_PROP_HPL_DASH3 = 3659;
  public const int LC_PROP_HPL_DASH4 = 3660;
  public const int LC_PROP_HPL_DASH5 = 3661;
  public const int LC_PROP_HPL_DASH6 = 3662;
  public const int LC_PROP_HPL_DASH7 = 3663;
  public const int LC_PROP_HPL_DASH8 = 3664;
  public const int LC_PROP_ECW_FILENAME = 3901;
  public const int LC_PROP_ECW_LOADED = 3902;
  public const int LC_PROP_ECW_X = 3903;
  public const int LC_PROP_ECW_Y = 3904;
  public const int LC_PROP_ECW_W = 3905;
  public const int LC_PROP_ECW_H = 3906;
  public const int LC_PROP_ECW_WPIX = 3907;
  public const int LC_PROP_ECW_HPIX = 3908;
  public const int LC_PROP_ECW_CBIT = 3909;
  public const int LC_PROP_ECW_BORDER = 3910;
  public const int LC_PROP_DIM_STYLE = 4001;
  public const int LC_PROP_DIM_MEAS = 4003;
  public const int LC_PROP_DIM_TEXT = 4004;
  public const int LC_PROP_DIMANG_STYLE = 4001;
  public const int LC_PROP_DIMANG_Z = 4002;
  public const int LC_PROP_DIMANG_MEAS = 4003;
  public const int LC_PROP_DIMANG_TEXT = 4004;
  public const int LC_PROP_DIMALI_STYLE = 4001;
  public const int LC_PROP_DIMALI_MEAS = 4003;
  public const int LC_PROP_DIMALI_TEXT = 4004;
  public const int LC_PROP_DIMDIA_STYLE = 4001;
  public const int LC_PROP_DIMDIA_MEAS = 4003;
  public const int LC_PROP_DIMDIA_TEXT = 4004;
  public const int LC_PROP_DIMRAD_STYLE = 4001;
  public const int LC_PROP_DIMRAD_MEAS = 4003;
  public const int LC_PROP_DIMRAD_TEXT = 4004;
  public const int LC_PROP_DIMORD_STYLE = 4001;
  public const int LC_PROP_DIMORD_MEAS = 4003;
  public const int LC_PROP_DIMORD_TEXT = 4004;
  public const int LC_PROP_DIMROT_STYLE = 4001;
  public const int LC_PROP_DIMROT_MEAS = 4003;
  public const int LC_PROP_DIMROT_TEXT = 4004;
  public const int LC_PROP_DIMANG_CPX = 4021;
  public const int LC_PROP_DIMANG_CPY = 4022;
  public const int LC_PROP_DIMANG_DP1X = 4023;
  public const int LC_PROP_DIMANG_DP1Y = 4024;
  public const int LC_PROP_DIMANG_DP2X = 4025;
  public const int LC_PROP_DIMANG_DP2Y = 4026;
  public const int LC_PROP_DIMANG_DP3X = 4027;
  public const int LC_PROP_DIMANG_DP3Y = 4028;
  public const int LC_PROP_DIMANG_DP4X = 4029;
  public const int LC_PROP_DIMANG_DP4Y = 4030;
  public const int LC_PROP_DIMANG_APX = 4031;
  public const int LC_PROP_DIMANG_APY = 4032;
  public const int LC_PROP_DIMANG_EXT1 = 4033;
  public const int LC_PROP_DIMANG_EXT2 = 4034;
  public const int LC_PROP_DIMANG_RAD = 4035;
  public const int LC_PROP_DIMANG_TPOS = 4036;
  public const int LC_PROP_DIMANG_CP = 4037;
  public const int LC_PROP_DIMANG_DP1 = 4038;
  public const int LC_PROP_DIMANG_DP2 = 4039;
  public const int LC_PROP_DIMANG_DP3 = 4040;
  public const int LC_PROP_DIMANG_DP4 = 4041;
  public const int LC_PROP_DIMANG_AP = 4042;
  public const int LC_PROP_DIMANG_TP = 4043;
  public const int LC_PROP_DIMALI_DP1X = 4051;
  public const int LC_PROP_DIMALI_DP1Y = 4052;
  public const int LC_PROP_DIMALI_DP2X = 4053;
  public const int LC_PROP_DIMALI_DP2Y = 4054;
  public const int LC_PROP_DIMALI_TPX = 4055;
  public const int LC_PROP_DIMALI_TPY = 4056;
  public const int LC_PROP_DIMALI_DP1 = 4057;
  public const int LC_PROP_DIMALI_DP2 = 4058;
  public const int LC_PROP_DIMALI_TP = 4059;
  public const int LC_PROP_DIMDIA_CPX = 4071;
  public const int LC_PROP_DIMDIA_CPY = 4072;
  public const int LC_PROP_DIMDIA_RPX = 4073;
  public const int LC_PROP_DIMDIA_RPY = 4074;
  public const int LC_PROP_DIMDIA_TPX = 4075;
  public const int LC_PROP_DIMDIA_TPY = 4076;
  public const int LC_PROP_DIMDIA_CP = 4077;
  public const int LC_PROP_DIMDIA_RP = 4078;
  public const int LC_PROP_DIMDIA_TP = 4079;
  public const int LC_PROP_DIMRAD_CPX = 4086;
  public const int LC_PROP_DIMRAD_CPY = 4087;
  public const int LC_PROP_DIMRAD_RPX = 4088;
  public const int LC_PROP_DIMRAD_RPY = 4089;
  public const int LC_PROP_DIMRAD_TPX = 4090;
  public const int LC_PROP_DIMRAD_TPY = 4091;
  public const int LC_PROP_DIMRAD_CP = 4092;
  public const int LC_PROP_DIMRAD_RP = 4093;
  public const int LC_PROP_DIMRAD_TP = 4094;
  public const int LC_PROP_DIMORD_XORD = 4101;
  public const int LC_PROP_DIMORD_DPX = 4102;
  public const int LC_PROP_DIMORD_DPY = 4103;
  public const int LC_PROP_DIMORD_TPX = 4104;
  public const int LC_PROP_DIMORD_TPY = 4105;
  public const int LC_PROP_DIMORD_DP = 4106;
  public const int LC_PROP_DIMORD_TP = 4107;
  public const int LC_PROP_DIMROT_ANGLE = 4121;
  public const int LC_PROP_DIMROT_DP1X = 4122;
  public const int LC_PROP_DIMROT_DP1Y = 4123;
  public const int LC_PROP_DIMROT_DP2X = 4124;
  public const int LC_PROP_DIMROT_DP2Y = 4125;
  public const int LC_PROP_DIMROT_TPX = 4126;
  public const int LC_PROP_DIMROT_TPY = 4127;
  public const int LC_PROP_DIMROT_DP1 = 4128;
  public const int LC_PROP_DIMROT_DP2 = 4129;
  public const int LC_PROP_DIMROT_TP = 4130;
  public const int LC_PROP_LEADER_STYLE = 4502;
  public const int LC_PROP_LEADER_TEXT = 4503;
  public const int LC_PROP_LEADER_ALIGN = 4504;
  public const int LC_PROP_LEADER_TPX = 4505;
  public const int LC_PROP_LEADER_TPY = 4506;
  public const int LC_PROP_LEADER_APX = 4507;
  public const int LC_PROP_LEADER_APY = 4508;
  public const int LC_PROP_LEADER_LDIST = 4510;
  public const int LC_PROP_LEADER_VERT = 4511;
  public const int LC_PROP_LEADER_CORNER = 4512;
  public const int LC_PROP_LEADER_ATTACH = 4513;
  public const int LC_PROP_LEADER_TP = 4514;
  public const int LC_PROP_LEADER_AP = 4515;
  public const int LC_PROP_VER_X = 5001;
  public const int LC_PROP_VER_Y = 5002;
  public const int LC_PROP_VER_Z = 5003;
  public const int LC_PROP_VER_ENDPATH = 5005;
  public const int LC_PROP_VER_FIX = 5006;
  public const int LC_PROP_VER_RADIUS = 5007;
  public const int LC_PROP_VER_W0 = 5011;
  public const int LC_PROP_VER_W1 = 5012;
  public const int LC_PROP_VER_SEGDX = 5013;
  public const int LC_PROP_VER_SEGDY = 5014;
  public const int LC_PROP_VER_SEGANG = 5015;
  public const int LC_PROP_VER_SEGLEN = 5016;
  public const int LC_PROP_VER_BULGE = 5021;
  public const int LC_PROP_VER_POS = 5031;
  public const int LC_PROP_VER_PRM = 5032;
  public const int LC_PROP_CMD_ID = 5102;
  public const int LC_PROP_CMD_STEP = 5103;
  public const int LC_PROP_CMD_LCWND = 5104;
  public const int LC_PROP_CMD_HWND = 5105;
  public const int LC_PROP_CMD_DRW = 5106;
  public const int LC_PROP_CMD_BLOCK = 5107;
  public const int LC_PROP_CMD_VIEW = 5108;
  public const int LC_PROP_CMD_CURSORX = 5109;
  public const int LC_PROP_CMD_CURSORY = 5110;
  public const int LC_PROP_CMD_CURSORZ = 5111;
  public const int LC_PROP_CMD_OSNAP = 5112;
  public const int LC_PROP_CMD_OSNAPONCE = 5113;
  public const int LC_PROP_CMD_NPOINTS = 5114;
  public const int LC_PROP_CMD_INT0 = 5120;
  public const int LC_PROP_CMD_INT1 = 5121;
  public const int LC_PROP_CMD_INT2 = 5122;
  public const int LC_PROP_CMD_INT3 = 5123;
  public const int LC_PROP_CMD_INT4 = 5124;
  public const int LC_PROP_CMD_INT5 = 5125;
  public const int LC_PROP_CMD_INT6 = 5126;
  public const int LC_PROP_CMD_INT7 = 5127;
  public const int LC_PROP_CMD_INT8 = 5128;
  public const int LC_PROP_CMD_INT9 = 5129;
  public const int LC_PROP_CMD_FLOAT0 = 5130;
  public const int LC_PROP_CMD_FLOAT1 = 5131;
  public const int LC_PROP_CMD_FLOAT2 = 5132;
  public const int LC_PROP_CMD_FLOAT3 = 5133;
  public const int LC_PROP_CMD_FLOAT4 = 5134;
  public const int LC_PROP_CMD_FLOAT5 = 5135;
  public const int LC_PROP_CMD_FLOAT6 = 5136;
  public const int LC_PROP_CMD_FLOAT7 = 5137;
  public const int LC_PROP_CMD_FLOAT8 = 5138;
  public const int LC_PROP_CMD_FLOAT9 = 5139;
  public const int LC_PROP_CMD_HAND0 = 5140;
  public const int LC_PROP_CMD_HAND1 = 5141;
  public const int LC_PROP_CMD_HAND2 = 5142;
  public const int LC_PROP_CMD_HAND3 = 5143;
  public const int LC_PROP_CMD_HAND4 = 5144;
  public const int LC_PROP_CMD_HAND5 = 5145;
  public const int LC_PROP_CMD_HAND6 = 5146;
  public const int LC_PROP_CMD_HAND7 = 5147;
  public const int LC_PROP_CMD_HAND8 = 5148;
  public const int LC_PROP_CMD_HAND9 = 5149;
  public const int LC_PROP_CMD_STR = 5150;
  public const int LC_PROP_CMDWND_ENABLE = 9001;
  public const int LC_PROP_PROPWND_ENABLE = 9002;
  public const int LC_PROP_PROPWND_DIVCOEF = 9003;
  public const int LC_MOD_ENT_PROP = 1;
  public const int LC_MOD_ENT_SET = 2;
  public const int LC_MOD_ENT_NORMVEC = 3;
  public const int LC_MOD_PLINE_ADDVER = 4;
  public const int LC_MOD_PLINE_INSVER = 5;
  public const int LC_MOD_PLINE_DELVER = 6;
  public const int LC_MOD_PLINE_REVERSE = 7;
  public const int LC_MOD_ENT_MOVE = 10;
  public const int LC_MOD_ENT_ROTATE = 11;
  public const int LC_MOD_ENT_SCALE = 12;
  public const int LC_MOD_ENT_MIRROR = 13;
  public const int LC_MOD_ENT_JOIN = 14;
  public const int LC_MOD_OBJ_PROP = 31;
  public const int LC_MOD_BLOCK_PURGE = 32;
  public const int LC_MOD_BLOCK_ADDENT = 33;
  public const int LC_MOD_DRW_PROP = 51;

  [DllImport("litecad.dll", EntryPoint="lcInitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Initialize(string szConfigDir);

  [DllImport("litecad.dll", EntryPoint="lcUninitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Uninitialize(bool bSaveConfig);

  [DllImport("litecad.dll", EntryPoint="lcCfgGetValue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string CfgGetValue(int hCfg, string szTag);

  [DllImport("litecad.dll", EntryPoint="lcCfgSetValue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CfgSetValue(int hCfg, string szTagValue);

  [DllImport("litecad.dll", EntryPoint="lcAddFontRes", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int AddFontRes(int hModule, int idResource, string szFontName);

  [DllImport("litecad.dll", EntryPoint="lcAddFontFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int AddFontFile(string szFilename, string szFontName);

  [DllImport("litecad.dll", EntryPoint="lcAddFontBin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int AddFontBin(int hData, string szFontName);

  [DllImport("litecad.dll", EntryPoint="lcStrAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrAdd(string szTag, string szText);

  [DllImport("litecad.dll", EntryPoint="lcStrSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrSet(string szTag, string szText);

  [DllImport("litecad.dll", EntryPoint="lcStrGet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string StrGet(string szTag);

  [DllImport("litecad.dll", EntryPoint="lcStrFileLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrFileLoad(string szFileName);

  [DllImport("litecad.dll", EntryPoint="lcStrFileSave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrFileSave(string szFileName, string szLanguage, bool bInit);

  [DllImport("litecad.dll", EntryPoint="lcPropGetBool", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropGetBool(int hObject, int idProp);

  [DllImport("litecad.dll", EntryPoint="lcPropGetInt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetInt(int hObject, int idProp);

  [DllImport("litecad.dll", EntryPoint="lcPropGetFloat", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern double PropGetFloat(int hObject, int idProp);

  [DllImport("litecad.dll", EntryPoint="lcPropGetStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string PropGetStr(int hObject, int idProp);

  [DllImport("litecad.dll", EntryPoint="lcPropGetHandle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetHandle(int hObject, int idProp);

  [DllImport("litecad.dll", EntryPoint="lcPropPutBool", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutBool(int hObject, int idProp, bool bValue);

  [DllImport("litecad.dll", EntryPoint="lcPropPutInt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutInt(int hObject, int idProp, int Value);

  [DllImport("litecad.dll", EntryPoint="lcPropPutFloat", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutFloat(int hObject, int idProp, double Value);

  [DllImport("litecad.dll", EntryPoint="lcPropPutStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutStr(int hObject, int idProp, string szValue);

  [DllImport("litecad.dll", EntryPoint="lcPropPutHandle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutHandle(int hObject, int idProp, int hValue);

  [DllImport("litecad.dll", EntryPoint="lcCreateDrawing", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CreateDrawing();

  [DllImport("litecad.dll", EntryPoint="lcDeleteDrawing", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteDrawing(int hDrw);

  [DllImport("litecad.dll", EntryPoint="lcDrwNew", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwNew(int hDrw, string szFileName, int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcDrwNewT", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwNewT(int hDrw, string szFileName, string szTemplate, int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcDrwLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwLoad(int hDrw, string szFileName, IntPtr hWnd, int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcDrwSave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSave(int hDrw, string szFileName, bool bBak, IntPtr hWnd);

  [DllImport("litecad.dll", EntryPoint="lcDrwPurge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwPurge(int hDrw);

  [DllImport("litecad.dll", EntryPoint="lcDrwRegenViews", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwRegenViews(int hDrw, int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcDrwSortObjects", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSortObjects(int hDrw, int ObjType);

  [DllImport("litecad.dll", EntryPoint="lcDrwClearXData", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwClearXData(int hDrw, int ObjType, int Mode);

  [DllImport("litecad.dll", EntryPoint="lcDrwResolveBlocks", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwResolveBlocks(int hDrw, out IntPtr szError);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddLayer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddLayer(int hDrw, string szName, string szColor, int hLtype, int Lweight);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddLinetype", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddLinetype(int hDrw, string szName, string szDefinition);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddLinetypeF", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddLinetypeF(int hDrw, string szName, string szFileName, string szLtypeName);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddTextStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddTextStyle(int hDrw, string szName, string szFontName);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddDimStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddDimStyle(int hDrw, string szName);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddImage", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddImage(int hDrw, string szName, string szFileName);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddBlock(int hDrw, string szName, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddBlockFromFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddBlockFromFile(int hDrw, string szName, string szFileName, int Overwrite, IntPtr hwParent);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddBlockFromDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddBlockFromDrw(int hDrw, string szName, int hDrw2, int Overwrite, IntPtr hwParent);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddBlockFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddBlockFile(int hDrw, string szName, string szFileName, int Overwrite, IntPtr hwParent);

  [DllImport("litecad.dll", EntryPoint="lcDrwAddViewPaper", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwAddViewPaper(int hDrw, string szName, int PaperSize, int Orient, double Width, double Height);

  [DllImport("litecad.dll", EntryPoint="lcDrwDeleteObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwDeleteObject(int hDrw, int hObject);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetFirstObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetFirstObject(int hDrw, int ObjType);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetNextObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetNextObject(int hDrw, int hObject);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetObjectByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetObjectByID(int hDrw, int ObjType, int Id);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetObjectByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetObjectByIDH(int hDrw, int ObjType, string szId);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetObjectByName", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetObjectByName(int hDrw, int ObjType, string szName);

  [DllImport("litecad.dll", EntryPoint="lcDrwCountObjects", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwCountObjects(int hDrw, int ObjType);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetViewByBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetViewByBlock(int hDrw, int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetEntByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetEntByID(int hDrw, int Id);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetEntByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetEntByIDH(int hDrw, string szId);

  [DllImport("litecad.dll", EntryPoint="lcDrwGetEntByKey", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwGetEntByKey(int hDrw, int Key);

  [DllImport("litecad.dll", EntryPoint="lcViewSetRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewSetRect(int hView, double Xcen, double Ycen, double Width, double Height);

  [DllImport("litecad.dll", EntryPoint="lcViewSetRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewSetRect2(int hView, double Lef, double Bot, double Rig, double Top);

  [DllImport("litecad.dll", EntryPoint="lcViewSetLimits", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewSetLimits(int hView, double Xmin, double Ymin, double Xmax, double Ymax);

  [DllImport("litecad.dll", EntryPoint="lcViewSetGrid", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewSetGrid(int hView, double X0, double Y0, double dX, double dY);

  [DllImport("litecad.dll", EntryPoint="lcViewRegen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewRegen(int hView, int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcViewSetPaperSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewSetPaperSize(int hView, int PaperSize, int Orient, double Width, double Height);

  [DllImport("litecad.dll", EntryPoint="lcViewGetEntByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ViewGetEntByPoint(int hView, double Xview, double Yview, bool bOnlyFilled);

  [DllImport("litecad.dll", EntryPoint="lcViewGetEntByRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ViewGetEntByRect(int hView, double Lef, double Bot, double Rig, double Top);

  [DllImport("litecad.dll", EntryPoint="lcViewGetEntsByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ViewGetEntsByPoint(int hView, double Xview, double Yview, bool bOnlyFilled);

  [DllImport("litecad.dll", EntryPoint="lcViewGetEntsByRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ViewGetEntsByRect(int hView, double Lef, double Bot, double Rig, double Top, bool bCross);

  [DllImport("litecad.dll", EntryPoint="lcViewGetEntity", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ViewGetEntity(int iEnt);

  [DllImport("litecad.dll", EntryPoint="lcViewRasterize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewRasterize(int hView, string szFileName, double Lef, double Bot, double Rig, double Top, double Scale);

  [DllImport("litecad.dll", EntryPoint="lcViewDrawMarker", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewDrawMarker(int hView, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcViewDrawLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewDrawLine(int hView, double X0, double Y0, double X1, double Y1);

  [DllImport("litecad.dll", EntryPoint="lcViewDrawXline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewDrawXline(int hView, double X0, double Y0, double X1, double Y1, bool bRay);

  [DllImport("litecad.dll", EntryPoint="lcViewDrawRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ViewDrawRect(int hView, double X0, double Y0, double X1, double Y1);

  [DllImport("litecad.dll", EntryPoint="lcBlockClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockClear(int hBlock, int hLayer);

  [DllImport("litecad.dll", EntryPoint="lcBlockPurge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockPurge(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockSortEnts", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSortEnts(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddPoint(int hBlock, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddPoint2(int hBlock, double X, double Y, int PtMode, double PtSize);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddXline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddXline(int hBlock, double X, double Y, double Angle, bool bRay);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddXline2P", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddXline2P(int hBlock, double X, double Y, double X2, double Y2, bool bRay);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddLine(int hBlock, double X1, double Y1, double X2, double Y2);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddLineDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddLineDir(int hBlock, double X, double Y, double Angle, double Dist);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddLineTan", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddLineTan(int hBlock, int hEnt1, int hEnt2, int Mode);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddPolyline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddPolyline(int hBlock, int FitType, bool bClosed, bool bFilled);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddRect(int hBlock, double Xc, double Yc, double Width, double Height, double Angle, bool bFilled);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddRect2(int hBlock, double Left, double Bottom, double Width, double Height, double Rad, bool bFilled);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddCircle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddCircle(int hBlock, double X, double Y, double Radius, bool bFilled);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddArc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddArc(int hBlock, double X, double Y, double Radius, double StartAngle, double ArcAngle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddArc3P", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddArc3P(int hBlock, double X1, double Y1, double X2, double Y2, double X3, double Y3);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddEllipse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddEllipse(int hBlock, double X, double Y, double R1, double R2, double RotAngle, double StartAngle, double ArcAngle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddText(int hBlock, string szText, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddText2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddText2(int hBlock, string szText, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddTextWin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddTextWin(int hBlock, string szText, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddTextWin2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddTextWin2(int hBlock, string szText, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddMText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddMText(int hBlock, string szText, double X, double Y, double WrapWidth, int Align, double RotAngle, double H, double WScale);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddArcText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddArcText(int hBlock, string szText, double X, double Y, double Radius, double StartAngle, bool bClockwise, double H, double WScale);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddBlockRef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddBlockRef(int hBlock, int hRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddBlockRefID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddBlockRefID(int hBlock, int idRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddBlockRefIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddBlockRefIDH(int hBlock, string szIdRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddImageRef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddImageRef(int hBlock, int hImage, double X, double Y, double Width, double Height, bool bBorder);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddEcw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddEcw(int hBlock, string szFileName);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddAttDef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddAttDef(int hBlock, int Mode, string szTag, string szPrompt, string szDefVal, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddHatch", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddHatch(int hBlock, string szFileName, string szPatName, double Scal, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddViewport", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddViewport(int hBlock, double Lef, double Bot, double Width, double Height, double DrwPntX, double DrwPntY, double DrwScale, double DrwAngle);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddLeader", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddLeader(int hBlock, string szText, double Xt, double Yt, double LandDist, double Xa, double Ya, int Attach, int Align);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimRot", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimRot(int hBlock, double X0, double Y0, double X1, double Y1, double Xt, double Yt, double Angle, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimHor", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimHor(int hBlock, double X0, double Y0, double X1, double Y1, double Yt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimVer(int hBlock, double X0, double Y0, double X1, double Y1, double Xt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimAli", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimAli(int hBlock, double X0, double Y0, double X1, double Y1, double Xt, double Yt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimAli2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimAli2(int hBlock, double X0, double Y0, double X1, double Y1, double Dt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimOrd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimOrd(int hBlock, double Xd, double Yd, double Xt, double Yt, bool bX, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimRad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimRad(int hBlock, double Xc, double Yc, double Xr, double Yr, double Xt, double Yt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimRad2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimRad2(int hBlock, double Xc, double Yc, double R, double Angle, double TextOff, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimDia", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimDia(int hBlock, double Xc, double Yc, double Xr, double Yr, double Xt, double Yt, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimDia2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimDia2(int hBlock, double Xc, double Yc, double R, double Angle, double TextOff, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimAng", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimAng(int hBlock, double Xc, double Yc, double X1, double Y1, double X2, double Y2, double Xa, double Ya, double TextPos, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockAddDimAng2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddDimAng2(int hBlock, double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4, double Xa, double Ya, double TextPos, string szText);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetFirstEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetFirstEnt(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetNextEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetNextEnt(int hBlock, int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetLastEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetLastEnt(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetPrevEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetPrevEnt(int hBlock, int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetEntByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetEntByID(int hBlock, int Id);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetEntByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetEntByIDH(int hBlock, string szId);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetEntByKey", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetEntByKey(int hBlock, int Key);

  [DllImport("litecad.dll", EntryPoint="lcBlockUnselect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockUnselect(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelectEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelectEnt(int hBlock, int hEntity, bool bSelect);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelErase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelErase(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelMove(int hBlock, double dX, double dY, bool bCopy, bool bNewSelect);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelScale(int hBlock, double X0, double Y0, double Scal, bool bCopy, bool bNewSelect);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelRotate(int hBlock, double X0, double Y0, double Angle, bool bCopy, bool bNewSelect);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelMirror(int hBlock, double X1, double Y1, double X2, double Y2, bool bCopy, bool bNewSelect);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelExplode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelExplode(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockSelJoin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockSelJoin(int hBlock, double Delta);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetFirstSel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetFirstSel(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcBlockGetNextSel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockGetNextSel(int hBlock);

  [DllImport("litecad.dll", EntryPoint="lcEntErase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntErase(int hEnt, bool bErase);

  [DllImport("litecad.dll", EntryPoint="lcEntMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntMove(int hEnt, double dX, double dY);

  [DllImport("litecad.dll", EntryPoint="lcEntScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntScale(int hEnt, double X0, double Y0, double Scal);

  [DllImport("litecad.dll", EntryPoint="lcEntRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntRotate(int hEnt, double X0, double Y0, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcEntMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntMirror(int hEnt, double X1, double Y1, double X2, double Y2);

  [DllImport("litecad.dll", EntryPoint="lcEntExplode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntExplode(int hEnt, bool bSelect);

  [DllImport("litecad.dll", EntryPoint="lcEntOffset", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntOffset(int hEnt, double Dist);

  [DllImport("litecad.dll", EntryPoint="lcEntToTop", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToTop(int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcEntToBottom", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToBottom(int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcEntToAbove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToAbove(int hEnt, int hEnt2);

  [DllImport("litecad.dll", EntryPoint="lcEntToUnder", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToUnder(int hEnt, int hEnt2);

  [DllImport("litecad.dll", EntryPoint="lcEntGetGrip", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntGetGrip(int hEnt, int iGrip, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcEntPutGrip", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntPutGrip(int hEnt, int iGrip, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcEntUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntUpdate(int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcIntersection", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int Intersection(int hEnt, int hEnt2);

  [DllImport("litecad.dll", EntryPoint="lcInterGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool InterGetPoint(int iPoint, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcPlineAddVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineAddVer(int hPline, int hVer0, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcPlineAddVer2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineAddVer2(int hPline, int hVer0, double X, double Y, double Param, double W0, double W1);

  [DllImport("litecad.dll", EntryPoint="lcPlineAddVerDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineAddVerDir(int hPline, int hVer0, double Ang, double Len);

  [DllImport("litecad.dll", EntryPoint="lcPlineDeleteVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineDeleteVer(int hPline, int hVer);

  [DllImport("litecad.dll", EntryPoint="lcPlineGetFirstVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineGetFirstVer(int hPline);

  [DllImport("litecad.dll", EntryPoint="lcPlineGetNextVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineGetNextVer(int hPline, int hVer);

  [DllImport("litecad.dll", EntryPoint="lcPlineGetLastVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineGetLastVer(int hPline);

  [DllImport("litecad.dll", EntryPoint="lcPlineGetPrevVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineGetPrevVer(int hPline, int hVer);

  [DllImport("litecad.dll", EntryPoint="lcPlineGetVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineGetVer(int hPline, int Index);

  [DllImport("litecad.dll", EntryPoint="lcPlineReverse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineReverse(int hPline);

  [DllImport("litecad.dll", EntryPoint="lcVportSetView", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportSetView(int hVport, double Xcen, double Ycen, double Scale, double Angle);

  [DllImport("litecad.dll", EntryPoint="lcVportFrolClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportFrolClear(int hVport);

  [DllImport("litecad.dll", EntryPoint="lcVportFrolAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportFrolAdd(int hVport, int hLayer);

  [DllImport("litecad.dll", EntryPoint="lcVportFrolGet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int VportFrolGet(int hVport, int iLayer);

  [DllImport("litecad.dll", EntryPoint="lcVportIsFrol", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportIsFrol(int hVport, int hLayer);

  [DllImport("litecad.dll", EntryPoint="lcBlkRefAddAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlkRefAddAtt(int hBlockRef, string szTag, string szValue);

  [DllImport("litecad.dll", EntryPoint="lcBlkRefGetFirstAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlkRefGetFirstAtt(int hBlockRef);

  [DllImport("litecad.dll", EntryPoint="lcBlkRefGetNextAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlkRefGetNextAtt(int hBlockRef, int hAttrib);

  [DllImport("litecad.dll", EntryPoint="lcBlkRefGetAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlkRefGetAtt(int hBlockRef, string szTag);

  [DllImport("litecad.dll", EntryPoint="lcHatchBoundStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundStart(int hHatch);

  [DllImport("litecad.dll", EntryPoint="lcHatchBoundPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundPoint(int hHatch, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcHatchBoundEndLoop", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundEndLoop(int hHatch);

  [DllImport("litecad.dll", EntryPoint="lcHatchBoundEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundEnd(int hHatch);

  [DllImport("litecad.dll", EntryPoint="lcHatchPatStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatStart(int hHatch);

  [DllImport("litecad.dll", EntryPoint="lcHatchPatLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatLine(int hHatch, double Angle, double x0, double y0, double dx, double dy, int nDash, double L0, double L1, double L2, double L3, double L4, double L5, double L6, double L7);

  [DllImport("litecad.dll", EntryPoint="lcHatchPatEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatEnd(int hHatch);

  [DllImport("litecad.dll", EntryPoint="lcHatchGetLoopSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int HatchGetLoopSize(int hHatch, int iLoop);

  [DllImport("litecad.dll", EntryPoint="lcHatchGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchGetPoint(int hHatch, int iPnt, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcRectGetPolyline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int RectGetPolyline(int hRect, out double pX, out double pY, out double pBulge);

  [DllImport("litecad.dll", EntryPoint="lcXlinePutDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool XlinePutDir(int hXline, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcCreateWindow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CreateWindow(IntPtr hWndParent, int Style, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcDeleteWindow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteWindow(int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcWndResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndResize(int hLcWnd, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcWndSelectView", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSelectView(int hLcWnd, int hView);

  [DllImport("litecad.dll", EntryPoint="lcWndZoomRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomRect(int hLcWnd, double Left, double Bottom, double Right, double Top);

  [DllImport("litecad.dll", EntryPoint="lcWndZoomScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomScale(int hLcWnd, double Scal);

  [DllImport("litecad.dll", EntryPoint="lcWndRedraw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndRedraw(int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcWndSetFocus", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetFocus(int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcWndExeCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndExeCommand(int hLcWnd, int Command, int CmdParam);

  [DllImport("litecad.dll", EntryPoint="lcWndCoordFromDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndCoordFromDrw(int hLcWnd, double Xdrw, double Ydrw, out int pXwin, out int pYwin);

  [DllImport("litecad.dll", EntryPoint="lcWndCoordToDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndCoordToDrw(int hLcWnd, int Xwin, int Ywin, out double pXdrw, out double pYdrw);

  [DllImport("litecad.dll", EntryPoint="lcWndGetCursorCoord", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndGetCursorCoord(int hLcWnd, out int pXwin, out int pYwin, out double pXdrw, out double pYdrw);

  [DllImport("litecad.dll", EntryPoint="lcWndGetEntByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int WndGetEntByPoint(int hLcWnd, int Xwin, int Ywin);

  [DllImport("litecad.dll", EntryPoint="lcWndSetCmdwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetCmdwin(int hLcWnd, int hCmdLine);

  [DllImport("litecad.dll", EntryPoint="lcWndSetPropwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetPropwin(int hLcWnd, int hPropWnd);

  [DllImport("litecad.dll", EntryPoint="lcWndOnClose", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndOnClose(int hLcWnd);

  [DllImport("litecad.dll", EntryPoint="lcWndGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndGetPoint(int hLcWnd, string szPrompt, int SnapMode, int Index, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcWndGetPointBuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndGetPointBuf(int hLcWnd, int Index, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcCoordDrwToWnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CoordDrwToWnd(int hLcWnd, double Xdrw, double Ydrw, out int pXwin, out int pYwin);

  [DllImport("litecad.dll", EntryPoint="lcCoordWndToDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CoordWndToDrw(int hLcWnd, int Xwin, int Ywin, out double pXdrw, out double pYdrw);

  [DllImport("litecad.dll", EntryPoint="lcColorIsRGB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorIsRGB(string szColor);

  [DllImport("litecad.dll", EntryPoint="lcColorGetRed", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetRed(string szColor);

  [DllImport("litecad.dll", EntryPoint="lcColorGetGreen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetGreen(string szColor);

  [DllImport("litecad.dll", EntryPoint="lcColorGetBlue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetBlue(string szColor);

  [DllImport("litecad.dll", EntryPoint="lcColorGetIndex", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetIndex(string szColor);

  [DllImport("litecad.dll", EntryPoint="lcColorToVal", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorToVal(string szColor, out int pbRGB, out int pIndex, out int pR, out int pG, out int pB);

  [DllImport("litecad.dll", EntryPoint="lcColorSetPalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorSetPalette(int Index, int R, int G, int B);

  [DllImport("litecad.dll", EntryPoint="lcColorGetPalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorGetPalette(int Index, out int pR, out int pG, out int pB);

  [DllImport("litecad.dll", EntryPoint="lcCreateCmdwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CreateCmdwin(IntPtr hWndParent, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcCmdwinResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdwinResize(int hCmdLine, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcCreatePropwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CreatePropwin(IntPtr hWndParent, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcPropwinResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropwinResize(int hPropWnd, int Left, int Top, int Width, int Height);

  [DllImport("litecad.dll", EntryPoint="lcPropwinUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropwinUpdate(int hPropWnd, bool bSelChanged);

  [DllImport("litecad.dll", EntryPoint="lcGetErrorCode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int GetErrorCode();

  [DllImport("litecad.dll", EntryPoint="lcGetErrorStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string GetErrorStr();

  [DllImport("litecad.dll", EntryPoint="lcExtractPreview", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ExtractPreview(string szFileName, int hGlob, int MaxSize);

  [DllImport("litecad.dll", EntryPoint="lcExtractFileInfo", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ExtractFileInfo(string szFileName, out IntPtr szGuid, out IntPtr szComment, out int pInt0, out int pInt1);

  [DllImport("litecad.dll", EntryPoint="lcGetClientSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GetClientSize(IntPtr hWnd, out int pWidth, out int pHeight);

  [DllImport("litecad.dll", EntryPoint="lcGetFileName", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string GetFileName(IntPtr hWnd, int Mode);

  [DllImport("litecad.dll", EntryPoint="lcGetValue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string GetValue(IntPtr hWnd, int Lef, int Top, string szCaption, string szPrompt, string szValue);

  [DllImport("litecad.dll", EntryPoint="lcTextOut", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void TextOut(IntPtr hDC, int x, int y, string szText, int ColorRGB);

  [DllImport("litecad.dll", EntryPoint="lcFilletSetLines", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool FilletSetLines(double L1x0, double L1y0, double L1x1, double L1y1, double L2x0, double L2y0, double L2x1, double L2y1);

  [DllImport("litecad.dll", EntryPoint="lcFillet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Fillet(double Rad, double Bis, double Tang);

  [DllImport("litecad.dll", EntryPoint="lcFilletGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool FilletGetPoint(int iPnt, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcCreateCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CreateCommand(int hLcWnd, int Id, string szName, bool bNeedSel);

  [DllImport("litecad.dll", EntryPoint="lcCmdExit", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdExit();

  [DllImport("litecad.dll", EntryPoint="lcCmdPrompt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdPrompt(int hCmd, string szText);

  [DllImport("litecad.dll", EntryPoint="lcCmdGetEntByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CmdGetEntByPoint(int hCmd, int Xwnd, int Ywnd);

  [DllImport("litecad.dll", EntryPoint="lcCmdSelectEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdSelectEnt(int hCmd, int hEntity, bool bSelect);

  [DllImport("litecad.dll", EntryPoint="lcCmdRedraw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdRedraw(int hCmd);

  [DllImport("litecad.dll", EntryPoint="lcCmdSetFocus", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdSetFocus(int hCmd);

  [DllImport("litecad.dll", EntryPoint="lcCmdRegen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdRegen(int hCmd, int hEnt);

  [DllImport("litecad.dll", EntryPoint="lcCmdClearPoints", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdClearPoints(int hCmd);

  [DllImport("litecad.dll", EntryPoint="lcCmdAddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdAddPoint(int hCmd, int Id, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcCmdGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdGetPoint(int hCmd, int Id, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcCmdSetBasePoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdSetBasePoint(int hCmd, bool bEnable, double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcCmdDrawLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdDrawLine(int hCmd, double X0, double Y0, double X1, double Y1);

  [DllImport("litecad.dll", EntryPoint="lcCmdDrawPickbox", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdDrawPickbox(int hCmd, int Xwnd, int Ywnd);

  [DllImport("litecad.dll", EntryPoint="lcCmdEqualPoints", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdEqualPoints(int hCmd, double X0, double Y0, double X1, double Y1, int Delta);

  [DllImport("litecad.dll", EntryPoint="lcSurfInitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void SurfInitialize(int MaxSectPnt, double AngStep);

  [DllImport("litecad.dll", EntryPoint="lcSurfUnInitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void SurfUnInitialize();

  [DllImport("litecad.dll", EntryPoint="lcSurfClearTriangles", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void SurfClearTriangles();

  [DllImport("litecad.dll", EntryPoint="lcSurfAddTriangle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool SurfAddTriangle(double X0, double Y0, double Z0, double X1, double Y1, double Z1, double X2, double Y2, double Z2);

  [DllImport("litecad.dll", EntryPoint="lcSurfGetZ", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool SurfGetZ(double X, double Y, out double pZ);

  [DllImport("litecad.dll", EntryPoint="lcSurfGetZ_dbg", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool SurfGetZ_dbg(double X, double Y, out double pZ, out double pX0, out double pY0, out double pZ0, out double pX1, out double pY1, out double pZ1, out double pX2, out double pY2, out double pZ2);

  [DllImport("litecad.dll", EntryPoint="lcSurfClearPlan", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void SurfClearPlan();

  [DllImport("litecad.dll", EntryPoint="lcSurfAddPlanVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool SurfAddPlanVer(double X, double Y, double Bulge);

  [DllImport("litecad.dll", EntryPoint="lcSurfMakeSection", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int SurfMakeSection();

  [DllImport("litecad.dll", EntryPoint="lcSurfGetSectPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool SurfGetSectPoint(int iPnt, out double pX, out double pY, out double pZ);

  [DllImport("litecad.dll", EntryPoint="lcCrossSetTolerance", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void CrossSetTolerance(double Zero1, double One1, double Zero2, double One2, double NearPt, double Clas, double CutGr, double RigPt);

  [DllImport("litecad.dll", EntryPoint="lcCrossClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossClear();

  [DllImport("litecad.dll", EntryPoint="lcCrossBegin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossBegin(int PlineType);

  [DllImport("litecad.dll", EntryPoint="lcCrossAddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossAddPoint(double X, double Y);

  [DllImport("litecad.dll", EntryPoint="lcCrossEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossEnd();

  [DllImport("litecad.dll", EntryPoint="lcCrossCalcArea", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CrossCalcArea();

  [DllImport("litecad.dll", EntryPoint="lcCrossCalcArea2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CrossCalcArea2(int hDrw, int GroundKey, int RoadKey, int LinkKey);

  [DllImport("litecad.dll", EntryPoint="lcCrossGetArea", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossGetArea(int iArea, out double pAreaVal, out int pNumPnts);

  [DllImport("litecad.dll", EntryPoint="lcCrossGetAreaPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CrossGetAreaPoint(int iArea, int iPnt, out double pX, out double pY);

  [DllImport("litecad.dll", EntryPoint="lcEventReturnCode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void EventReturnCode(int code);

  [DllImport("litecad.dll", EntryPoint="lcEventsEnable", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void EventsEnable(bool bEnable);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseMove(F_MOUSEMOVE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseDown", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseDown(F_MOUSEDOWN pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseUp", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseUp(F_MOUSEUP pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseDblClk", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseDblClk(F_MOUSEDBLCLK pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseSnap", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseSnap(F_MOUSESNAP pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseLeave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseLeave(F_MOUSELEAVE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventMouseWheel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventMouseWheel(F_MOUSEWHEEL pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventKeyDown", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventKeyDown(F_KEYDOWN pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventPaint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventPaint(F_PAINT pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventZoom", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventZoom(F_ZOOM pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventSelectView", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventSelectView(F_SELECTVIEW pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventGetPoint(F_GETPOINT pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventAddCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventAddCommand(F_ADDCOMMAND pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdStart(F_CMD_START pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdFinish", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdFinish(F_CMD_FINISH pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdMouseDown", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdMouseDown(F_CMD_MOUSEDOWN pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdMouseUp", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdMouseUp(F_CMD_MOUSEUP pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdMouseMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdMouseMove(F_CMD_MOUSEMOVE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventCmdString", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventCmdString(F_CMD_STRING pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventAddEntity", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventAddEntity(F_ADDENTITY pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventRegen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventRegen(F_REGEN pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventFioProgress", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventFioProgress(F_FIOPROGRESS pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventSelection", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventSelection(F_SELECTION pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventPropChanged", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventPropChanged(F_PROPCHANGED pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventGripSelect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventGripSelect(F_GRIPSELECT pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventGripMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventGripMove(F_GRIPMOVE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventEntErase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventEntErase(F_ENTERASE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventEntMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventEntMove(F_ENTMOVE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventEntRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventEntRotate(F_ENTROTATE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventEntScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventEntScale(F_ENTSCALE pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventEntMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventEntMirror(F_ENTMIRROR pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventHelp", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventHelp(F_HELP pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventAddStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventAddStr(F_ADDSTR pFunc);

  [DllImport("litecad.dll", EntryPoint="lcOnEventFontReplace", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void OnEventFontReplace(F_FONTREPLACE pFunc);

}
