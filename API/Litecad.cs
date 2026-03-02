using System;
using System.Runtime.InteropServices;

public delegate void F_LCEVENT (IntPtr hEvent);
public delegate void F_WAITPOINT (int FuncPrm, IntPtr hLcWnd);
public delegate void F_REDRAW (IntPtr hLcWnd, int Elapsed);

public static class Lcad
{
  public const int LC_FALSE = 0;
  public const int LC_TRUE = 1;
  public const int LC_WS_HSCROLL = 1;
  public const int LC_WS_VSCROLL = 2;
  public const int LC_WS_BORDER = 4;
  public const int LC_WS_CLIENTEDGE = 8;
  public const int LC_WS_SUNKEN = 8;
  public const int LC_WS_STATICEDGE = 16;
  public const int LC_WS_RULERS = 256;
  public const int LC_WS_VIEWTABS = 512;
  public const int LC_WS_FILETABS = 1024;
  public const int LC_WS_DEFAULT = 3;
  public const int LC_MRU_IMAGE_W = 348;
  public const int LC_MRU_IMAGE_H = 273;
  public const int LC_PS_SOLID = 0;
  public const int LC_PS_DASH = 1;
  public const int LC_PS_DOT = 2;
  public const int LC_PS_DASHDOT = 3;
  public const int LC_PS_DASHDOTDOT = 4;
  public const int LC_LW_THIN = 0;
  public const int LC_LW_REAL = 1;
  public const int LC_LW_PIXEL = 2;
  public const int LC_FILL_SOLID = 0;
  public const int LC_FILL_BDIAGONAL = 1;
  public const int LC_FILL_CROSS = 2;
  public const int LC_FILL_DIAGCROSS = 3;
  public const int LC_FILL_FDIAGONAL = 4;
  public const int LC_FILL_HORIZONTAL = 5;
  public const int LC_FILL_VERTICAL = 6;
  public const int LC_IMGRES_BOX = 0;
  public const int LC_IMGRES_BILINEAR = 1;
  public const int LC_IMGRES_BSPLINE = 2;
  public const int LC_IMGRES_BICUBIC = 3;
  public const int LC_IMGRES_CATMULLROM = 4;
  public const int LC_IMGRES_LANCZOS3 = 5;
  public const int LC_IMGPROC_GRAY = 1;
  public const int LC_IMGPROC_FLIPHOR = 2;
  public const int LC_IMGPROC_FLIPVER = 3;
  public const int LC_IMGPROC_ROT180 = 4;
  public const int LC_GRIP_POINT = 0;
  public const int LC_GRIP_CENROT = 1;
  public const int LC_GRIP_ANGLE = 2;
  public const int LC_GRIP_ANGLE2 = 3;
  public const int LC_GRIP_BEZIER = 4;
  public const int LC_GRIP_BEZIER0 = 5;
  public const int LC_GRIP_ARCRAD = 6;
  public const int LC_GRIP_NOMOVE = 1;
  public const int LC_GRIP_NOROTATE = 2;
  public const int LC_GRIP_NOSCALE = 4;
  public const int LC_BARTYPE_CODE39 = 0;
  public const int LC_BARTYPE_CODE93 = 1;
  public const int LC_BARTYPE_CODE128 = 6;
  public const int LC_BARTYPE_EAN13 = 7;
  public const int LC_BARTYPE_ITF = 8;
  public const int LC_BARTYPE_EAN8 = 9;
  public const int LC_BARTYPE_QR = 21;
  public const int LC_BARTYPE_MQR = 22;
  public const int LC_BARTYPE_DMATRIX = 23;
  public const int LC_BARTYPE_DM = 23;
  public const int LC_BARTYPE_DMATRIXR = 24;
  public const int LC_BARTYPE_DMR = 24;
  public const int LC_BARC_QRECL_L = 0;
  public const int LC_BARC_QRECL_M = 1;
  public const int LC_BARC_QRECL_Q = 2;
  public const int LC_BARC_QRECL_H = 3;
  public const int LC_LEADER_TCENTER = 0;
  public const int LC_LEADER_TLEFT = 1;
  public const int LC_LEADER_TRIGHT = 2;
  public const int LC_LEADER_VERT = 1;
  public const int LC_LEADER_CORNER = 2;
  public const int LC_VPL_CLEAR = 1;
  public const int LC_VPL_ADD = 2;
  public const int LC_VPL_DELETE = 3;
  public const int LC_VPL_PROP_BEGIN = 4;
  public const int LC_VPL_PROP_END = 5;
  public const double LC_RAD_TO_DEG = 57.2957795130823208768;
  public const double LC_DEG_TO_RAD = 0.01745329251994329577;
  public const double LC_PI = 3.14159265358979323846;
  public const double LC_PI2 = 1.57079632679489661923;
  public const double LC_PI4 = 0.78539816339744830962;
  public const double LC_2PI = 6.28318530717958647692;
  public const double LC_DEG1 = 0.01745329251994329577;
  public const double LC_DEG2 = 0.03490658503988659154;
  public const double LC_DEG3 = 0.05235987755982988731;
  public const double LC_DEG4 = 0.06981317007977318308;
  public const double LC_DEG5 = 0.08726646259971647885;
  public const double LC_DEG6 = 0.10471975511965977462;
  public const double LC_DEG7 = 0.12217304763960307038;
  public const double LC_DEG8 = 0.13962634015954636615;
  public const double LC_DEG9 = 0.15707963267948966192;
  public const double LC_DEG10 = 0.17453292519943295769;
  public const double LC_DEG20 = 0.34906585039886591538;
  public const double LC_DEG30 = 0.52359877559829887308;
  public const double LC_DEG40 = 0.69813170079773183077;
  public const double LC_DEG45 = 0.78539816339744830962;
  public const double LC_DEG50 = 0.87266462599716478846;
  public const double LC_DEG60 = 1.04719755119659774615;
  public const double LC_DEG70 = 1.22173047639603070385;
  public const double LC_DEG80 = 1.39626340159546366154;
  public const double LC_DEG90 = 1.57079632679489661923;
  public const double LC_DEG180 = 3.14159265358979323846;
  public const double LC_DEG270 = 4.71238898038468985769;
  public const double LC_DEG360 = 6.28318530717958647692;
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
  public const int LC_PAPER_CUSTOM = 0;
  public const int LC_PAPER_USER = 0;
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
  public const int LC_PAPER_UNLIMITED = 100;
  public const int LC_PAPER_PORTRAIT = 0;
  public const int LC_PAPER_BOOK = 0;
  public const int LC_PAPER_LANDSCAPE = 1;
  public const int LC_PAPER_ALBUM = 1;
  public const int LC_PRN_SCALELW = 1;
  public const int LC_PRN_1COLOR = 2;
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
  public const int LC_BTA_LEFT = 0;
  public const int LC_BTA_CENTER = 1;
  public const int LC_BTA_RIGHT = 2;
  public const int LC_PLFIT_BULGE = 0;
  public const int LC_PLFIT_NONE = 0;
  public const int LC_PLFIT_QUAD = 5;
  public const int LC_PLFIT_CUBIC = 6;
  public const int LC_PLFIT_BEZIER = 7;
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
  public const int LC_POINT_BEAM0 = 10000;
  public const int LC_POINT_BEAM1 = 10001;
  public const int LC_BLK_ENT_RETAIN = 0;
  public const int LC_BLK_ENT_CONVERT = 1;
  public const int LC_BLK_ENT_DELETE = 2;
  public const int LC_EA_LEFT = 1;
  public const int LC_EA_TOP = 2;
  public const int LC_EA_RIGHT = 3;
  public const int LC_EA_BOTTOM = 4;
  public const int LC_EA_CENTER = 5;
  public const int LC_EA_CENTERX = 6;
  public const int LC_EA_CENTERY = 7;
  public const int LC_IMGA_CENTER = 0;
  public const int LC_IMGA_LEFBOT = 1;
  public const int LC_IMGA_RIGBOT = 2;
  public const int LC_IMGA_LEFTOP = 3;
  public const int LC_IMGA_RIGTOP = 4;
  public const int LC_LBUTTON = 1;
  public const int LC_RBUTTON = 2;
  public const int LC_MBUTTON = 4;
  public const int LC_SHIFT = 1;
  public const int LC_CTRL = 2;
  public const int LC_ALT = 4;
  public const int LC_KBD_QWERTY = 0;
  public const int LC_KBD_AZERTY = 1;
  public const int LC_KBD_QWERTZ = 2;
  public const int LC_CURSOR_NULL = 0;
  public const int LC_CURSOR_ARROW = 1;
  public const int LC_CURSOR_CROSS = 2;
  public const int LC_CURSOR_HAND = 3;
  public const int LC_CURSOR_HELP = 4;
  public const int LC_CURSOR_NO = 5;
  public const int LC_CURSOR_WAIT = 6;
  public const int LC_CURSOR_PAN1 = 7;
  public const int LC_CURSOR_PAN2 = 8;
  public const int LC_EXP_OUTLINE = 1;
  public const int LC_EXP_HATCH = 2;
  public const int LC_EXP_ALL = 3;
  public const int LC_EXP_MAXRESOL = 4;
  public const int LC_EM_TOP = 0;
  public const int LC_EM_ENT = 1;
  public const int LC_EM_PLINE = 2;
  public const int LC_EM_VERTEX = 3;
  public const int LC_EM_ENDPLINE = 4;
  public const int LC_EM_ENDENT = 5;
  public const int LC_EMUL_START = 0;
  public const int LC_EMUL_STOP = 1;
  public const int LC_EMUL_PARAMS = 2;
  public const int LC_MAG_ZOOM_4 = 0;
  public const int LC_MAG_ZOOM_6 = 1;
  public const int LC_MAG_ZOOM_8 = 2;
  public const int LC_MAG_ZOOM_10 = 3;
  public const int LC_MAG_ZOOM_12 = 4;
  public const int LC_MAG_ZOOM_14 = 5;
  public const int LC_MAG_CENTER = 1;
  public const int LC_DRWEXP_L = 0;
  public const int LC_DRWEXP_P = 1;
  public const int LC_DRWEXP_LA = 10;
  public const int LC_DRWEXP_PA = 11;
  public const int LC_DRWEXP_BLOCKS = 20;
  public const int LC_HELP_DG_PRINT = 1;
  public const int LC_HELP_DG_RASTER = 2;
  public const int LC_HELP_DG_COLOR = 10;
  public const int LC_HELP_DG_LAYERS = 11;
  public const int LC_HELP_DG_SELLTYPE = 12;
  public const int LC_HELP_DG_LINETYPES = 13;
  public const int LC_HELP_DG_LOADLINETYPE = 14;
  public const int LC_HELP_DG_TEXTSTYLES = 15;
  public const int LC_HELP_DG_PNTSTYLES = 16;
  public const int LC_HELP_DG_DIMSTYLES = 17;
  public const int LC_HELP_DG_MLSTYLES = 18;
  public const int LC_HELP_DG_HATSTYLES = 19;
  public const int LC_HELP_DG_BLOCKS = 20;
  public const int LC_HELP_DG_LAYOUTS = 21;
  public const int LC_HELP_DG_IMAGES = 22;
  public const int LC_HELP_DG_IMAGEINSERT = 23;
  public const int LC_HELP_DG_SELBLOCK = 30;
  public const int LC_HELP_DG_SELTSTYLE = 31;
  public const int LC_HELP_DG_SELPTYPE = 32;
  public const int LC_HELP_DG_CREBLOCK = 33;
  public const int LC_HELP_DG_PAGEPROP = 34;
  public const int LC_HELP_DG_SELFONT = 35;
  public const int LC_HELP_DG_TEXT = 40;
  public const int LC_HELP_DG_ARCTEXT = 41;
  public const int LC_HELP_DG_INPUTCOORD = 42;
  public const int LC_HELP_DG_WORKFIELD = 43;
  public const int LC_HELP_DG_CRBITMAP = 44;
  public const int LC_HELP_DG_INSERT = 45;
  public const int LC_HELP_DG_TSP = 51;
  public const int LC_HELP_DG_ARRAY = 52;
  public const int LC_HELP_DG_ARRAYARC = 53;
  public const int LC_HELP_DG_HATCH = 54;
  public const int LC_HELP_DG_GRID = 61;
  public const int LC_HELP_DG_PTRACK = 62;
  public const int LC_HELP_DG_OSNAP = 63;
  public const int LC_HELP_DG_KBMOVE = 64;
  public const int LC_HELP_DG_DRWPROPS = 65;
  public const int LC_HELP_DG_SYSPROPS = 66;
  public const int LC_HELP_DG_SELECTION = 67;
  public const int LC_HELP_DG_QSELECT = 68;
  public const int LC_HELP_DG_RPOLYGON = 69;
  public const int LC_HELP_DG_LIMITS = 70;
  public const int LC_HELP_DG_NDLSET = 71;
  public const int LC_HELP_DG_LMESH = 72;
  public const int LC_HELP_DG_CRECTS = 73;
  public const int LC_HELP_DG_SELLINFILL = 74;
  public const int LC_MB_OK = 0;
  public const int LC_MB_OKCANCEL = 1;
  public const int LC_MB_ABORTRETRYIGNORE = 2;
  public const int LC_MB_YESNOCANCEL = 3;
  public const int LC_MB_YESNO = 4;
  public const int LC_MB_RETRYCANCEL = 5;
  public const int LC_MB_CANCELTRYCONTINUE = 6;
  public const int LC_MB_HELP = 16384;
  public const int LC_MB_ICONSTOP = 16;
  public const int LC_MB_ICONERROR = 16;
  public const int LC_MB_ICONHAND = 16;
  public const int LC_MB_ICONQUESTION = 32;
  public const int LC_MB_ICONEXCLAMATION = 48;
  public const int LC_MB_ICONWARNING = 48;
  public const int LC_MB_ICONINFORMATION = 64;
  public const int LC_MB_ICONASTERISK = 64;
  public const int LC_UNDO_BEGIN = 0;
  public const int LC_UNDO_END = 1;
  public const int LC_UNDO_CLEAR = 2;
  public const int LC_ERR_OBJTYPE = 1;
  public const int LC_ERR_NOTAG = 2;
  public const int LC_ERR_USERCANCEL = 3;
  public const int LC_ERR_FILENAME = 4;
  public const int LC_ERR_FILELOAD = 5;
  public const int LC_ERR_FILESAVE = 6;
  public const int LC_ERR_UNRESBLOCKREF = 7;
  public const int LC_ERR_UNRESVIEWREF = 8;
  public const int LC_ERR_UNRESHATCH = 9;
  public const int LC_ERR_FILE_TIN_SAVE = 101;
  public const int LC_OBJ_LAYER = 1;
  public const int LC_OBJ_LINETYPE = 2;
  public const int LC_OBJ_TEXTSTYLE = 3;
  public const int LC_OBJ_DIMSTYLE = 4;
  public const int LC_OBJ_PNTSTYLE = 5;
  public const int LC_OBJ_IMAGE = 6;
  public const int LC_OBJ_MLSTYLE = 8;
  public const int LC_OBJ_LINFILL = 9;
  public const int LC_OBJ_BLOCK = 10;
  public const int LC_OBJ_LAYOUT = 11;
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
  public const int LC_ENT_CLIPRECT = 117;
  public const int LC_ENT_RECT = 118;
  public const int LC_ENT_ATTDEF = 120;
  public const int LC_ENT_ECW = 121;
  public const int LC_ENT_MTEXT = 122;
  public const int LC_ENT_ARCTEXT = 123;
  public const int LC_ENT_HATCH = 124;
  public const int LC_ENT_FACE = 126;
  public const int LC_ENT_MLINE = 127;
  public const int LC_ENT_DIMROT = 131;
  public const int LC_ENT_DIMLIN = 131;
  public const int LC_ENT_DIMALI = 132;
  public const int LC_ENT_DIMORD = 133;
  public const int LC_ENT_DIMRAD = 134;
  public const int LC_ENT_DIMDIA = 135;
  public const int LC_ENT_DIMANG = 136;
  public const int LC_ENT_LEADER = 137;
  public const int LC_ENT_RPLAN = 141;
  public const int LC_ENT_TIN = 142;
  public const int LC_ENT_BARCODE = 150;
  public const int LC_ENT_SHAPE = 160;
  public const int LC_ENT_BRI = 161;
  public const int LC_ENT_XREF = 199;
  public const int LC_ENT_ARROW = 301;
  public const int LC_ENT_SPIRAL = 302;
  public const int LC_ENT_CAMERA = 303;
  public const int LC_ENT_PTARRAY = 304;
  public const int LC_ENT_PATHTEXT = 305;
  public const int LC_ENT_BEZIER = 306;
  public const int LC_ENT_CUSTOM = 1000;
  public const int LC_ENT_ALL = 32767;
  public const int LC_LWEIGHT_DEFAULT = -3;
  public const int LC_LWEIGHT_BYBLOCK = -2;
  public const int LC_LWEIGHT_BYLAYER = -1;
  public const int LC_LWIDTH_DEFAULT = -3;
  public const int LC_LWIDTH_BYBLOCK = -2;
  public const int LC_LWIDTH_BYLAYER = -1;
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
  public const int LC_COLOR_WIPEOUT = 259;
  public const int LC_MLINE_TOP = 0;
  public const int LC_MLINE_MIDDLE = 1;
  public const int LC_MLINE_BOTTOM = 2;
  public const int LC_TABLE_IDSET = 349000349;
  public const int LC_PLUG_IMPDRW = 2;
  public const int LC_PLUG_EXPDRW = 3;
  public const int LC_PLUG_IMGDIB = 4;
  public const int LC_FP_FLOAD = 0;
  public const int LC_FP_FSAVE = 1;
  public const int LC_FP_NITEMS = 2;
  public const int LC_FP_ITEM = 3;
  public const int LC_FP_ITEMPOS = 4;
  public const int LC_OSNAP_NULL = 0;
  public const int LC_OSNAP_NODE = 1;
  public const int LC_OSNAP_ENDPOINT = 2;
  public const int LC_OSNAP_MIDPOINT = 4;
  public const int LC_OSNAP_CENTER = 8;
  public const int LC_OSNAP_NEAREST = 16;
  public const int LC_OSNAP_INTER = 32;
  public const int LC_OSNAP_PERPEND = 64;
  public const int LC_OSNAP_TANGENT = 128;
  public const int LC_OSNAP_QUADRANT = 256;
  public const int LC_OSNAP_INSERT = 512;
  public const int LC_OSNAP_NONE = 1024;
  public const int LC_OSNAP_ALL = 1023;
  public const int LC_ATTRIB_HIDDEN = 1;
  public const int LC_ATTRIB_CONST = 2;
  public const int LC_ATTRIB_VERIFY = 4;
  public const int LC_ATTRIB_PRESET = 8;
  public const int LC_ATTRIB_LOCK = 16;
  public const int LC_ATTRIB_MTEXT = 32;
  public const int LC_FACE_EDGE1INVIS = 1;
  public const int LC_FACE_EDGE2INVIS = 2;
  public const int LC_FACE_EDGE3INVIS = 4;
  public const int LC_FACE_EDGE4INVIS = 8;
  public const int LC_FACE_EDGE1HIDDEN = 1;
  public const int LC_FACE_EDGE2HIDDEN = 2;
  public const int LC_FACE_EDGE3HIDDEN = 4;
  public const int LC_FACE_EDGE4HIDDEN = 8;
  public const int LC_BLOCK_OVERWRITENO = 0;
  public const int LC_BLOCK_OVERWRITEYES = 1;
  public const int LC_BLOCK_OVERWRITEDLG = 2;
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
  public const int LC_COFO_NONE = 0;
  public const int LC_COFO_Y800 = 1;
  public const int LC_COFO_RGB24 = 2;
  public const int LC_COFO_RGB32 = 3;
  public const int LC_COFO_UYVY = 4;
  public const int LC_COFO_Y16 = 5;
  public const int LC_COFO_MEGA = 65536;
  public const int LC_CMD_FILESAVE = 1;
  public const int LC_CMD_FILESAVEAS = 2;
  public const int LC_CMD_PRINT = 3;
  public const int LC_CMD_RASTERIZE = 4;
  public const int LC_CMD_FILENEW = 5;
  public const int LC_CMD_FILEOPEN = 6;
  public const int LC_CMD_FILERECENT = 7;
  public const int LC_CMD_FILEINSERT = 8;
  public const int LC_CMD_FILECLOSE = 9;
  public const int LC_CMD_ZOOM_IN = 31;
  public const int LC_CMD_ZOOM_OUT = 32;
  public const int LC_CMD_ZOOM_EXT = 33;
  public const int LC_CMD_ZOOM_PAGE = 34;
  public const int LC_CMD_ZOOM_PREV = 35;
  public const int LC_CMD_ZOOM_LIM = 36;
  public const int LC_CMD_PAN_LEFT = 37;
  public const int LC_CMD_PAN_RIGHT = 38;
  public const int LC_CMD_PAN_UP = 39;
  public const int LC_CMD_PAN_DOWN = 40;
  public const int LC_CMD_ZOOM_WIN = 51;
  public const int LC_CMD_ZOOM_RECT = 51;
  public const int LC_CMD_ZOOM_SEL = 52;
  public const int LC_CMD_PAGENEXT = 53;
  public const int LC_CMD_PAGEPREV = 54;
  public const int LC_CMD_PAGEMODEL = 55;
  public const int LC_CMD_PAGEVPORT = 56;
  public const int LC_CMD_VP_ACT = 57;
  public const int LC_CMD_VP_DEACT = 58;
  public const int LC_CMD_EDITMODE_ON = 59;
  public const int LC_CMD_EDITMODE_OFF = 60;
  public const int LC_CMD_MAGON = 71;
  public const int LC_CMD_MAGOFF = 72;
  public const int LC_CMD_MAGPRM = 73;
  public const int LC_CMD_MAGZOOM4 = 74;
  public const int LC_CMD_MAGZOOM6 = 75;
  public const int LC_CMD_MAGZOOM8 = 76;
  public const int LC_CMD_MAGZOOM10 = 77;
  public const int LC_CMD_MAGZOOM12 = 78;
  public const int LC_CMD_MAGZOOM14 = 79;
  public const int LC_CMD_GRID = 101;
  public const int LC_CMD_OSNAP = 102;
  public const int LC_CMD_PTRACK = 103;
  public const int LC_CMD_SELOPTS = 104;
  public const int LC_CMD_QSELECT = 105;
  public const int LC_CMD_KBMOVE = 106;
  public const int LC_CMD_DIST = 111;
  public const int LC_CMD_AREA = 112;
  public const int LC_CMD_SCALEBLK = 113;
  public const int LC_CMD_TSP2 = 116;
  public const int LC_CMD_LIMITS = 117;
  public const int LC_CMD_SAVESTR = 118;
  public const int LC_CMD_DELDUPVER = 119;
  public const int LC_CMD_DELEXVER = 120;
  public const int LC_CMD_UNHIDE = 136;
  public const int LC_CMD_SHDOTS = 137;
  public const int LC_CMD_SMALLVRECT = 138;
  public const int LC_CMD_PLUGINS = 141;
  public const int LC_CMD_CENTERCURSOR = 142;
  public const int LC_CMD_HELP = 1001;
  public const int LC_CMD_RESET = 1003;
  public const int LC_CMD_SW_GRID = 1011;
  public const int LC_CMD_SW_GRIDSNAP = 1012;
  public const int LC_CMD_SW_OSNAP = 1014;
  public const int LC_CMD_SW_PTRACK = 1015;
  public const int LC_CMD_SW_POLAR = 1015;
  public const int LC_CMD_SW_ORTHO = 1016;
  public const int LC_CMD_POINT = 201;
  public const int LC_CMD_LINE = 202;
  public const int LC_LINE_SERIAL = 1;
  public const int LC_LINE_SEPARATE = 2;
  public const int LC_LINE_CONT = 3;
  public const int LC_CMD_XLINE = 203;
  public const int LC_XLINE_BASE = 1;
  public const int LC_XLINE_ANG = 2;
  public const int LC_XLINE_SEP = 3;
  public const int LC_XLINE_RAY = 4;
  public const int LC_XLINE_XLINE = 5;
  public const int LC_CMD_LMESH = 204;
  public const int LC_CMD_POLYLINE = 205;
  public const int LC_CMD_PLINE = 205;
  public const int LC_CMD_SPLINE = 206;
  public const int LC_CMD_RPOLYGON = 207;
  public const int LC_CMD_RECT = 208;
  public const int LC_RECT_2P = 1;
  public const int LC_RECT_3P = 2;
  public const int LC_RECT_CSA = 3;
  public const int LC_CMD_CIRCLE = 209;
  public const int LC_CIRCLE_CR = 1;
  public const int LC_CIRCLE_2P = 2;
  public const int LC_CIRCLE_3P = 3;
  public const int LC_CMD_ARC = 210;
  public const int LC_ARC_SME = 1;
  public const int LC_ARC_SEM = 2;
  public const int LC_ARC_SEC = 3;
  public const int LC_ARC_SED = 4;
  public const int LC_ARC_CSE = 5;
  public const int LC_ARC_CONT = 6;
  public const int LC_CMD_ELLIPSE = 211;
  public const int LC_ELL_AX = 1;
  public const int LC_ELL_CEN = 2;
  public const int LC_ELL_RECT = 3;
  public const int LC_CMD_TEXT = 212;
  public const int LC_CMD_TEXTW = 213;
  public const int LC_CMD_ATEXT = 214;
  public const int LC_CMD_ARCTEXT = 214;
  public const int LC_CMD_MTEXT = 215;
  public const int LC_CMD_INSERT = 216;
  public const int LC_CMD_BLOCKREF = 216;
  public const int LC_INSERT_DLG = 1;
  public const int LC_INSERT_NODLG = 2;
  public const int LC_INSERT_RESET = 3;
  public const int LC_CMD_BARCODE = 217;
  public const int LC_BARCODE_39 = 1;
  public const int LC_BARCODE_93 = 2;
  public const int LC_BARCODE_128 = 3;
  public const int LC_BARCODE_EAN13 = 4;
  public const int LC_BARCODE_EAN8 = 5;
  public const int LC_BARCODE_ITF = 6;
  public const int LC_BARCODE_MQR = 7;
  public const int LC_BARCODE_QR = 8;
  public const int LC_BARCODE_DMATRIX = 9;
  public const int LC_BARCODE_DM = 9;
  public const int LC_BARCODE_DMATRIXR = 10;
  public const int LC_BARCODE_DMR = 10;
  public const int LC_CMD_DIMLIN = 221;
  public const int LC_CMD_DIMROT = 221;
  public const int LC_CMD_DIMALI = 223;
  public const int LC_CMD_DIMORD = 224;
  public const int LC_CMD_DIMRAD = 225;
  public const int LC_CMD_DIMDIA = 226;
  public const int LC_CMD_DIMANG = 227;
  public const int LC_CMD_LEADER = 228;
  public const int LC_CMD_ARROW = 231;
  public const int LC_CMD_SPIRAL = 232;
  public const int LC_CMD_HATCH = 233;
  public const int LC_CMD_ECW = 234;
  public const int LC_CMD_VPORT = 236;
  public const int LC_CMD_VIEWPORT = 236;
  public const int LC_CMD_PTARRAY = 237;
  public const int LC_CMD_FACE = 238;
  public const int LC_CMD_SHAPE = 239;
  public const int LC_CMD_SKETCH = 240;
  public const int LC_CMD_CLOUD = 241;
  public const int LC_CMD_RPLAN = 242;
  public const int LC_CMD_MLINE = 243;
  public const int LC_CMD_BEZIER = 244;
  public const int LC_CMD_BRI = 245;
  public const int LC_CMD_CLIPRECTS = 250;
  public const int LC_CMD_CRECTS = 250;
  public const int LC_CMD_ATTDEF = 251;
  public const int LC_CMD_TIN_LOAD = 301;
  public const int LC_CMD_TIN_LOADPT = 302;
  public const int LC_CMD_TIN_ADDPT = 303;
  public const int LC_CMD_TIN_DELETE = 304;
  public const int LC_CMD_TIN_PROPS = 305;
  public const int LC_CMD_TIN_PTYPES = 306;
  public const int LC_CMD_TIN_MOVEPT = 307;
  public const int LC_CMD_TIN_EDITPT = 308;
  public const int LC_CMD_TIN_DELPT = 309;
  public const int LC_CMD_TIN_BNDDELPT = 310;
  public const int LC_CMD_TIN_DELPTDUP = 311;
  public const int LC_CMD_TIN_DELTRALL = 312;
  public const int LC_CMD_TIN_DELTR = 313;
  public const int LC_CMD_TIN_BNDDELTR = 314;
  public const int LC_CMD_TIN_SWAPTR = 315;
  public const int LC_CMD_TIN_BNDAUTO = 316;
  public const int LC_CMD_TIN_BND = 317;
  public const int LC_CMD_TIN_BNDEDIT = 318;
  public const int LC_CMD_TIN_BNDCLEAR = 319;
  public const int LC_CMD_TIN_BNDTRANG = 320;
  public const int LC_CMD_TIN_BNDTRANG2 = 321;
  public const int LC_CMD_TIN_GENISO = 322;
  public const int LC_CMD_TIN_GENFILL = 323;
  public const int LC_CMD_TIN_RELOAD = 324;
  public const int LC_CMD_TIN_SAVE = 325;
  public const int LC_CMD_TIN_SAVEPT = 326;
  public const int LC_CMD_TIN_BNDSAVE = 327;
  public const int LC_CMD_TIN_BNDPLINE = 328;
  public const int LC_CMD_TIN_Z = 329;
  public const int LC_CMD_TIN_ZOOM = 330;
  public const int LC_CMD_TIN_ISOTODRW = 331;
  public const int LC_CMD_TIN_TILES = 332;
  public const int LC_CMD_CBCUT = 401;
  public const int LC_CMD_CBCOPY = 402;
  public const int LC_CMD_CBPASTE = 403;
  public const int LC_CMD_UNDO = 404;
  public const int LC_CMD_REDO = 405;
  public const int LC_CMD_UNDOCLEAR = 406;
  public const int LC_CMD_COPY = 410;
  public const int LC_COPY_MOVE = 1;
  public const int LC_COPY_ROTATE = 2;
  public const int LC_COPY_SCALE = 3;
  public const int LC_COPY_MIRROR = 4;
  public const int LC_COPY_ARRRECT = 5;
  public const int LC_COPY_ARRCIRC = 6;
  public const int LC_CMD_ERASE = 411;
  public const int LC_CMD_MOVE = 412;
  public const int LC_CMD_ROTATE = 413;
  public const int LC_CMD_SCALE = 414;
  public const int LC_CMD_MIRROR = 415;
  public const int LC_CMD_EXPLODE = 416;
  public const int LC_CMD_SPLIT = 417;
  public const int LC_CMD_JOIN = 418;
  public const int LC_CMD_ORDER = 420;
  public const int LC_ORDER_FRONT = 1;
  public const int LC_ORDER_BACK = 2;
  public const int LC_ORDER_ABOVE = 3;
  public const int LC_ORDER_UNDER = 4;
  public const int LC_ORDER_SWAP = 5;
  public const int LC_CMD_ORDER_SEQ = 430;
  public const int LC_CMD_ALIGN = 431;
  public const int LC_ALIGN_LEFT = 1;
  public const int LC_ALIGN_RIGHT = 2;
  public const int LC_ALIGN_TOP = 3;
  public const int LC_ALIGN_BOTTOM = 4;
  public const int LC_ALIGN_CENTER = 5;
  public const int LC_ALIGN_CENX = 6;
  public const int LC_ALIGN_CENY = 7;
  public const int LC_CMD_CLOSEBLOCK = 439;
  public const int LC_CMD_BASEPOINT = 440;
  public const int LC_CMD_TRIM = 441;
  public const int LC_CMD_EXTEND = 442;
  public const int LC_CMD_OFFSET = 443;
  public const int LC_CMD_OFFSET_POINT = 0;
  public const int LC_CMD_OFFSET_DIST = 1;
  public const int LC_CMD_BREAK = 444;
  public const int LC_CMD_STRETCH = 445;
  public const int LC_CMD_FILLET = 446;
  public const int LC_CMD_IMGRES = 451;
  public const int LC_CMD_IMGPOS = 452;
  public const int LC_CMD_XHL = 461;
  public const int LC_CMD_XHP = 462;
  public const int LC_CMD_JOINALL = 465;
  public const int LC_CMD_ENTEXT = 468;
  public const int LC_CMD_JUMPS = 469;
  public const int LC_CMD_UNSIMG = 470;
  public const int LC_CMD_UPDATE = 474;
  public const int LC_CMD_DELOVER = 475;
  public const int LC_CMD_CMPD = 476;
  public const int LC_CMD_LAYER = 501;
  public const int LC_CMD_LAYERORD = 502;
  public const int LC_CMD_COLOR = 503;
  public const int LC_CMD_FCOLOR = 504;
  public const int LC_CMD_LINETYPE = 505;
  public const int LC_CMD_TEXTSTYLE = 507;
  public const int LC_CMD_BLOCK = 508;
  public const int LC_CMD_CREBLOCK = 508;
  public const int LC_CMD_BLOCKS = 509;
  public const int LC_CMD_IMAGE = 510;
  public const int LC_CMD_PNTSTYLE = 511;
  public const int LC_CMD_DIMSTYLE = 512;
  public const int LC_CMD_MLSTYLE = 513;
  public const int LC_CMD_LINFILL = 515;
  public const int LC_CMD_LAYOUT = 516;
  public const int LC_CMD_XREFS = 517;
  public const int LC_CMD_UNITS = 521;
  public const int LC_CMD_DRWPRM = 522;
  public const int LC_CMD_SYSPRM = 523;
  public const int LC_CMD_3DVIEW = 601;
  public const int LC_CMD_3D = 601;
  public const int LC_CMD_3D_STDVIEW = 602;
  public const int LC_CMD_3D_PARAMS = 603;
  public const int LC_CMD_3D_SAVEIMAGE = 604;
  public const int LC_CMD_AKAGRIP = 29999;
  public const int LC_CMD_CUSTOM = 30000;
  public const int LC_PROP_G_REGCODE = 1;
  public const int LC_PROP_G_VERSION = 2;
  public const int LC_PROP_G_MSGTITLE = 3;
  public const int LC_PROP_G_APPFILENAME = 4;
  public const int LC_PROP_G_DWGAPP = 5;
  public const int LC_PROP_G_DXFAPP = 6;
  public const int LC_PROP_G_HELPFILE = 10;
  public const int LC_PROP_G_DIRDLL = 11;
  public const int LC_PROP_G_DIRFONTS = 13;
  public const int LC_PROP_G_DIRLNG = 14;
  public const int LC_PROP_G_DIRTPL = 16;
  public const int LC_PROP_G_DIRCFG = 17;
  public const int LC_PROP_G_ICON16 = 20;
  public const int LC_PROP_G_ICON32 = 21;
  public const int LC_PROP_G_RULERBMP = 22;
  public const int LC_PROP_G_RULERW = 23;
  public const int LC_PROP_G_RULERFS = 24;
  public const int LC_PROP_G_PRNUSEBMP = 25;
  public const int LC_PROP_G_PRNBMPFILE = 26;
  public const int LC_PROP_G_PRNBTNRAS = 27;
  public const int LC_PROP_G_PRNBTNSRIF = 28;
  public const int LC_PROP_G_PNTPIXSIZE = 29;
  public const int LC_PROP_G_GETDELENT = 30;
  public const int LC_PROP_G_SBARHEIGHT = 32;
  public const int LC_PROP_G_FILEPROGRESS = 33;
  public const int LC_PROP_G_FILEDEFEXT = 35;
  public const int LC_PROP_G_FILELCD = 31;
  public const int LC_PROP_G_DEMOTEXT = 36;
  public const int LC_PROP_G_DEMOSIZE = 37;
  public const int LC_PROP_G_DEMOCOLOR = 38;
  public const int LC_PROP_G_TABCMDWND = 39;
  public const int LC_PROP_G_UNDOMSG = 40;
  public const int LC_PROP_G_MINCHARSIZE = 41;
  public const int LC_PROP_G_PANREDQUAL = 42;
  public const int LC_PROP_G_ENTEXT = 43;
  public const int LC_PROP_G_BLKRELOADMODE = 44;
  public const int LC_PROP_G_TABFILE = 45;
  public const int LC_PROP_G_MSGSAVEAS = 46;
  public const int LC_PROP_G_JUR = 47;
  public const int LC_PROP_G_FILEEXTS = 48;
  public const int LC_PROP_G_DLGVAL = 50;
  public const int LC_PROP_G_STR = 51;
  public const int LC_PROP_G_INT = 52;
  public const int LC_PROP_G_FLOAT = 53;
  public const int LC_PROP_G_HANDLE = 54;
  public const int LC_PROP_G_DELKEYERASE = 55;
  public const int LC_PROP_SEL_PICKBOXSIZE = 61;
  public const int LC_PROP_SEL_PICKBYRECT = 62;
  public const int LC_PROP_SEL_PICKDRAG = 63;
  public const int LC_PROP_SEL_PICKADD = 64;
  public const int LC_PROP_SEL_PICKBYLAYER = 65;
  public const int LC_PROP_SEL_PICKINPGON = 66;
  public const int LC_PROP_SEL_PICKINPGONF = 67;
  public const int LC_PROP_SEL_PICKINIMG = 68;
  public const int LC_PROP_SEL_COLORL1 = 69;
  public const int LC_PROP_SEL_COLORL2 = 70;
  public const int LC_PROP_SEL_COLORF = 71;
  public const int LC_PROP_SEL_HATCHFILL = 72;
  public const int LC_PROP_SEL_ENABLEGRIPS = 73;
  public const int LC_PROP_SEL_GRIPSIZE = 74;
  public const int LC_PROP_SEL_GRIPCOLORF = 75;
  public const int LC_PROP_SEL_GRIPCOLORB = 76;
  public const int LC_PROP_SEL_GRIPENTLIM = 77;
  public const int LC_PROP_SEL_GRIPNUM = 78;
  public const int LC_PROP_G_CAMERA_COUNT = 90;
  public const int LC_PROP_G_CAMERA_I = 91;
  public const int LC_PROP_G_CAMERA_INAME = 92;
  public const int LC_PROP_G_CAMERA_CONNECTED = 93;
  public const int LC_PROP_G_CAMERA_NAME = 94;
  public const int LC_PROP_G_CAMERA_TIME = 95;
  public const int LC_PROP_G_CAMERA_WIDTH = 96;
  public const int LC_PROP_G_CAMERA_HEIGHT = 97;
  public const int LC_PROP_G_CAMERA_BPP = 98;
  public const int LC_PROP_G_CAMERA_COFO = 99;
  public const int LC_PROP_G_CAMERA_BITS = 100;
  public const int LC_PROP_G_CAMERA_BPROW = 101;
  public const int LC_PROP_G_PTBUFNEWPTS = 131;
  public const int LC_PROP_G_PTBUFCLR = 132;
  public const int LC_PROP_G_MPGONCLR = 133;
  public const int LC_PROP_G_TEXT_ALIGN = 141;
  public const int LC_PROP_G_TEXT_H = 142;
  public const int LC_PROP_G_TEXT_WS = 143;
  public const int LC_PROP_G_TEXT_CSPACE = 144;
  public const int LC_PROP_G_TEXT_ANG = 145;
  public const int LC_PROP_G_TEXT_OBL = 146;
  public const int LC_PROP_G_TEXT_UPDOWN = 147;
  public const int LC_PROP_G_TEXT_BACK = 148;
  public const int LC_PROP_G_TEXT_FILL = 149;
  public const int LC_PROP_G_TEXT_BORDER = 150;
  public const int LC_PROP_G_BARC_CENTER = 161;
  public const int LC_PROP_G_BARC_ANGLE = 162;
  public const int LC_PROP_G_BARC_BELOW = 163;
  public const int LC_PROP_G_BARC_QZONE = 164;
  public const int LC_PROP_G_BARC_CHKSUM = 165;
  public const int LC_PROP_G_BARC_ECL = 166;
  public const int LC_PROP_G_BARC_INVERT = 167;
  public const int LC_PROP_G_BARC_WRATIO = 168;
  public const int LC_PROP_G_BARC_LINEW = 169;
  public const int LC_PROP_G_BEAMCOLOR0D = 191;
  public const int LC_PROP_G_BEAMCOLOR1D = 192;
  public const int LC_PROP_G_BEAMCOLOR2D = 193;
  public const int LC_PROP_G_BEAMCOLOR0U = 194;
  public const int LC_PROP_G_BEAMCOLOR1U = 195;
  public const int LC_PROP_G_BEAMCOLOR2U = 196;
  public const int LC_PROP_G_NAV_LEFT = 201;
  public const int LC_PROP_G_NAV_TOP = 202;
  public const int LC_PROP_G_NAV_WIDTH = 203;
  public const int LC_PROP_G_NAV_HEIGHT = 204;
  public const int LC_PROP_G_JL_EALEN = 210;
  public const int LC_PROP_G_JL_EAW = 211;
  public const int LC_PROP_G_JL_JALEN = 212;
  public const int LC_PROP_G_JL_JAW = 213;
  public const int LC_PROP_G_JL_ACOLOR = 214;
  public const int LC_PROP_G_JL_NUMFONT = 215;
  public const int LC_PROP_G_JL_NUMSIZE = 216;
  public const int LC_PROP_G_JL_NUMCOLOR = 217;
  public const int LC_PROP_G_JL_DRAWJARR = 218;
  public const int LC_PROP_G_JL_DRAWJLINE = 219;
  public const int LC_PROP_G_JL_DRAWEDOT = 220;
  public const int LC_PROP_G_JL_DRAWEARR = 221;
  public const int LC_PROP_G_JL_DRAWENUM = 222;
  public const int LC_PROP_G_OSNAP_MARK = 226;
  public const int LC_PROP_G_OSNAP_APER = 227;
  public const int LC_PROP_G_OSNAP_MARKSIZE = 228;
  public const int LC_PROP_G_OSNAP_APERSIZE = 229;
  public const int LC_PROP_G_OSNAP_MARKCOLOR = 230;
  public const int LC_PROP_G_EMUL_OVERDIST = 232;
  public const int LC_PROP_G_EMUL_OVERCOLOR = 233;
  public const int LC_PROP_G_RAS_FILL = 250;
  public const int LC_PROP_G_RAS_COLOR = 251;
  public const int LC_PROP_G_RAS_NOPRINT = 252;
  public const int LC_PROP_G_WPT_TEXTX = 260;
  public const int LC_PROP_G_WPT_TEXTY = 261;
  public const int LC_PROP_G_WPT_TEXTA = 262;
  public const int LC_PROP_G_TIN_PT0 = 270;
  public const int LC_PROP_G_TIN_PT1 = 271;
  public const int LC_PROP_G_TIN_TR = 272;
  public const int LC_PROP_WND_ID = 301;
  public const int LC_PROP_WND_WIDTH = 302;
  public const int LC_PROP_WND_HEIGHT = 303;
  public const int LC_PROP_WND_PIXELSIZE = 304;
  public const int LC_PROP_WND_PICKBOXSIZE = 305;
  public const int LC_PROP_WND_CURSORX = 306;
  public const int LC_PROP_WND_CURX = 306;
  public const int LC_PROP_WND_CURSORY = 307;
  public const int LC_PROP_WND_CURY = 307;
  public const int LC_PROP_WND_CURLEF = 308;
  public const int LC_PROP_WND_CURBOT = 309;
  public const int LC_PROP_WND_CURRIG = 310;
  public const int LC_PROP_WND_CURTOP = 311;
  public const int LC_PROP_WND_XMIN = 312;
  public const int LC_PROP_WND_YMIN = 313;
  public const int LC_PROP_WND_XMAX = 314;
  public const int LC_PROP_WND_YMAX = 315;
  public const int LC_PROP_WND_XCEN = 316;
  public const int LC_PROP_WND_YCEN = 317;
  public const int LC_PROP_WND_DX = 318;
  public const int LC_PROP_WND_DY = 319;
  public const int LC_PROP_WND_RULERSENABLE = 320;
  public const int LC_PROP_WND_RULERS = 321;
  public const int LC_PROP_WND_SELECT = 322;
  public const int LC_PROP_WND_VIEWBLOCK = 323;
  public const int LC_PROP_WND_BLOCK = 323;
  public const int LC_PROP_WND_DRW = 324;
  public const int LC_PROP_WND_HWND = 325;
  public const int LC_PROP_WND_HASFOCUS = 326;
  public const int LC_PROP_WND_HASFILETABS = 327;
  public const int LC_PROP_WND_NUMFILETABS = 328;
  public const int LC_PROP_WND_NUMDRW = 328;
  public const int LC_PROP_WND_DROPFILES = 329;
  public const int LC_PROP_WND_ZOOMWHEEL = 330;
  public const int LC_PROP_WND_JUMPLINES = 339;
  public const int LC_PROP_WND_MAGNIFIER = 340;
  public const int LC_PROP_WND_NAVIGATOR = 341;
  public const int LC_PROP_WND_COLORBG = 342;
  public const int LC_PROP_WND_COLORCURSOR = 343;
  public const int LC_PROP_WND_COLORFORE = 344;
  public const int LC_PROP_WND_COLORINFBG = 345;
  public const int LC_PROP_WND_COLORINFBORD = 346;
  public const int LC_PROP_WND_COLORINFTEXT = 347;
  public const int LC_PROP_WND_CURSORSYS = 348;
  public const int LC_PROP_WND_CURSORARROW = 348;
  public const int LC_PROP_WND_CURSORCROSS = 349;
  public const int LC_PROP_WND_CURSORSIZE = 350;
  public const int LC_PROP_WND_CURSORPBOX = 351;
  public const int LC_PROP_WND_COORDS = 352;
  public const int LC_PROP_WND_ENT = 353;
  public const int LC_PROP_WND_PROPWND = 354;
  public const int LC_PROP_WND_BLOCKBPT = 355;
  public const int LC_PROP_WND_LWMODE = 355;
  public const int LC_PROP_WND_LWSCALE = 356;
  public const int LC_PROP_WND_ALPHABLEND = 360;
  public const int LC_PROP_WND_STDBLKFRAME = 361;
  public const int LC_PROP_WND_BLKBASEPT = 362;
  public const int LC_PROP_WND_SIZE = 363;
  public const int LC_PROP_WND_DTIME = 364;
  public const int LC_PROP_WND_DRAWPAPER = 365;
  public const int LC_PROP_WND_FROZEN = 366;
  public const int LC_PROP_WND_FROZENVIEW = 367;
  public const int LC_PROP_WND_COMMAND = 368;
  public const int LC_PROP_WND_CMD = 368;
  public const int LC_PROP_WND_CMDENT1 = 369;
  public const int LC_PROP_WND_OSNAP = 370;
  public const int LC_PROP_WND_OSNAPMENU = 371;
  public const int LC_PROP_WND_ORTHO = 372;
  public const int LC_PROP_WND_PTRACK = 373;
  public const int LC_PROP_WND_PTRACK_ANGLE = 374;
  public const int LC_PROP_WND_PTRACK_ANGREL = 375;
  public const int LC_PROP_WND_PTRACK_DIST = 376;
  public const int LC_PROP_WND_BASEPT = 377;
  public const int LC_PROP_WND_BASEX = 378;
  public const int LC_PROP_WND_BASEY = 379;
  public const int LC_PROP_WND_GRIDSNAP = 380;
  public const int LC_PROP_WND_GRIDSHOW = 381;
  public const int LC_PROP_WND_GRIDDX = 382;
  public const int LC_PROP_WND_GRIDDY = 383;
  public const int LC_PROP_WND_GRIDX0 = 384;
  public const int LC_PROP_WND_GRIDY0 = 385;
  public const int LC_PROP_WND_GRIDBOLDX = 386;
  public const int LC_PROP_WND_GRIDBOLDY = 387;
  public const int LC_PROP_WND_GRIDCOLOR = 388;
  public const int LC_PROP_WND_GRIDDOTTED = 389;
  public const int LC_PROP_WND_GRIDCOLOR2 = 390;
  public const int LC_PROP_WND_GRIDDOTTED2 = 391;
  public const int LC_PROP_WND_RSNAP = 402;
  public const int LC_PROP_WND_RSNAPSHOW = 403;
  public const int LC_PROP_WND_RSNAPLEF = 404;
  public const int LC_PROP_WND_RSNAPBOT = 405;
  public const int LC_PROP_WND_RSNAPRIG = 406;
  public const int LC_PROP_WND_RSNAPTOP = 407;
  public const int LC_PROP_WND_RSNAPW = 408;
  public const int LC_PROP_WND_RSNAPH = 409;
  public const int LC_PROP_WND_RSNAPCOLORM = 410;
  public const int LC_PROP_WND_RSNAPCOLORP = 411;
  public const int LC_PROP_WND_PANSTEP = 420;
  public const int LC_PROP_WND_PANLW = 421;
  public const int LC_PROP_WND_PANIMAGE = 422;
  public const int LC_PROP_WND_PANFILL = 423;
  public const int LC_PROP_WND_PANPIXSZ = 424;
  public const int LC_PROP_WND_MEASCOLORPNT = 430;
  public const int LC_PROP_WND_MEASCOLORLINE = 431;
  public const int LC_PROP_WND_MEASLINESIZE = 432;
  public const int LC_PROP_WND_MEASFONTSIZE = 433;
  public const int LC_PROP_WND_MEASFILLAREA = 434;
  public const int LC_PROP_WND_KBMOVE_ENABLE = 437;
  public const int LC_PROP_WND_KBMOVE_DIST = 438;
  public const int LC_PROP_WND_KBMOVE_ANGLE = 439;
  public const int LC_PROP_WND_KBMOVE_SCALE = 440;
  public const int LC_PROP_WND_XLINEANG = 444;
  public const int LC_PROP_WND_BGIMAGE = 445;
  public const int LC_PROP_WND_LTVIEWMIN = 446;
  public const int LC_PROP_WND_LTVIEWMAX = 447;
  public const int LC_PROP_WND_FRAME_LEFT = 451;
  public const int LC_PROP_WND_FRAME_TOP = 452;
  public const int LC_PROP_WND_FRAME_WIDTH = 453;
  public const int LC_PROP_WND_FRAME_HEIGHT = 454;
  public const int LC_PROP_WND_HANDLE0 = 460;
  public const int LC_PROP_WND_HANDLE1 = 461;
  public const int LC_PROP_WND_HANDLE2 = 462;
  public const int LC_PROP_WND_HANDLE3 = 463;
  public const int LC_PROP_WND_HANDLE4 = 464;
  public const int LC_PROP_WND_HANDLE5 = 465;
  public const int LC_PROP_WND_HANDLE6 = 466;
  public const int LC_PROP_WND_HANDLE7 = 467;
  public const int LC_PROP_WND_HANDLE8 = 468;
  public const int LC_PROP_WND_HANDLE9 = 469;
  public const int LC_PROP_WND_INT0 = 470;
  public const int LC_PROP_WND_INT1 = 471;
  public const int LC_PROP_WND_INT2 = 472;
  public const int LC_PROP_WND_INT3 = 473;
  public const int LC_PROP_WND_INT4 = 474;
  public const int LC_PROP_WND_INT5 = 475;
  public const int LC_PROP_WND_INT6 = 476;
  public const int LC_PROP_WND_INT7 = 477;
  public const int LC_PROP_WND_INT8 = 478;
  public const int LC_PROP_WND_INT9 = 479;
  public const int LC_PROP_WND_FLOAT0 = 480;
  public const int LC_PROP_WND_FLOAT1 = 481;
  public const int LC_PROP_WND_FLOAT2 = 482;
  public const int LC_PROP_WND_FLOAT3 = 483;
  public const int LC_PROP_WND_FLOAT4 = 484;
  public const int LC_PROP_WND_FLOAT5 = 485;
  public const int LC_PROP_WND_FLOAT6 = 486;
  public const int LC_PROP_WND_FLOAT7 = 487;
  public const int LC_PROP_WND_FLOAT8 = 488;
  public const int LC_PROP_WND_FLOAT9 = 489;
  public const int LC_PROP_WND_STR0 = 490;
  public const int LC_PROP_WND_STR1 = 491;
  public const int LC_PROP_WND_STR2 = 492;
  public const int LC_PROP_WND_STR3 = 493;
  public const int LC_PROP_WND_STR4 = 494;
  public const int LC_PROP_WND_STR5 = 495;
  public const int LC_PROP_WND_STR6 = 496;
  public const int LC_PROP_WND_STR7 = 497;
  public const int LC_PROP_WND_STR8 = 498;
  public const int LC_PROP_WND_STR9 = 499;
  public const int LC_PROP_SBAR_H = 501;
  public const int LC_PROP_SBAR_FONTNAME = 502;
  public const int LC_PROP_SBAR_FONTSIZE = 503;
  public const int LC_PROP_SBAR_TEXTY = 504;
  public const int LC_PROP_SBAR_TEXTCOLOR = 505;
  public const int LC_PROP_SBAR_BGCOLOR = 506;
  public const int LC_PROP_SBAR_FRAMECOLOR = 507;
  public const int LC_PROP_FONT_FILENAME = 601;
  public const int LC_PROP_FONT_NAME = 602;
  public const int LC_PROP_FONT_LCF = 603;
  public const int LC_PROP_FONT_HEIGHT = 604;
  public const int LC_PROP_FONT_FILLED = 605;
  public const int LC_PROP_FONT_TTF = 606;
  public const int LC_PROP_FONT_NCHARS = 607;
  public const int LC_PROP_MPGON_XMIN = 631;
  public const int LC_PROP_MPGON_YMIN = 632;
  public const int LC_PROP_MPGON_XMAX = 633;
  public const int LC_PROP_MPGON_YMAX = 634;
  public const int LC_PROP_MPGON_XCEN = 635;
  public const int LC_PROP_MPGON_YCEN = 636;
  public const int LC_PROP_MPGON_W = 637;
  public const int LC_PROP_MPGON_H = 638;
  public const int LC_PROP_TINPTYPE_NAME = 680;
  public const int LC_PROP_TINPTYPE_DTEXT = 681;
  public const int LC_PROP_TINPTYPE_COLOR = 682;
  public const int LC_PROP_TINPNT_TYPE = 701;
  public const int LC_PROP_TINPNT_I = 702;
  public const int LC_PROP_TINPNT_X = 703;
  public const int LC_PROP_TINPNT_Y = 704;
  public const int LC_PROP_TINPNT_Z = 705;
  public const int LC_PROP_TINPNT_COLOR = 706;
  public const int LC_PROP_TINPNT_NAME = 707;
  public const int LC_PROP_TINPNT_ONAME = 708;
  public const int LC_PROP_TINPNT_DESCR = 709;
  public const int LC_PROP_TINPNT_IMGFILE = 715;
  public const int LC_PROP_TINPNT_IMGFILE2 = 716;
  public const int LC_PROP_TINPNT_ATTR = 720;
  public const int LC_PROP_TINPNT_ATTR1 = 721;
  public const int LC_PROP_TINPNT_ATTR2 = 722;
  public const int LC_PROP_TINPNT_ATTR3 = 723;
  public const int LC_PROP_TINPNT_ATTR4 = 724;
  public const int LC_PROP_TINPNT_ATTR5 = 725;
  public const int LC_PROP_TINPNT_ATTR6 = 726;
  public const int LC_PROP_TINPNT_ATTR7 = 727;
  public const int LC_PROP_TINPNT_ATTR8 = 728;
  public const int LC_PROP_TINPNT_ATTR9 = 729;
  public const int LC_PROP_TINTR_I = 731;
  public const int LC_PROP_TINTR_IPT0 = 732;
  public const int LC_PROP_TINTR_IPT1 = 733;
  public const int LC_PROP_TINTR_IPT2 = 734;
  public const int LC_PROP_TINTR_PT0 = 735;
  public const int LC_PROP_TINTR_PT1 = 736;
  public const int LC_PROP_TINTR_PT2 = 737;
  public const int LC_PROP_TINTR_PT0X = 738;
  public const int LC_PROP_TINTR_PT0Y = 739;
  public const int LC_PROP_TINTR_PT0Z = 740;
  public const int LC_PROP_TINTR_PT1X = 741;
  public const int LC_PROP_TINTR_PT1Y = 742;
  public const int LC_PROP_TINTR_PT1Z = 743;
  public const int LC_PROP_TINTR_PT2X = 744;
  public const int LC_PROP_TINTR_PT2Y = 745;
  public const int LC_PROP_TINTR_PT2Z = 746;
  public const int LC_PROP_TINTR_XC = 747;
  public const int LC_PROP_TINTR_YC = 748;
  public const int LC_PROP_TINTR_ZC = 749;
  public const int LC_PROP_TINTR_NVX = 750;
  public const int LC_PROP_TINTR_NVY = 751;
  public const int LC_PROP_TINTR_NVZ = 752;
  public const int LC_PROP_TINTR_NANG = 753;
  public const int LC_PROP_TINTR_XMIN = 754;
  public const int LC_PROP_TINTR_YMIN = 755;
  public const int LC_PROP_TINTR_ZMIN = 756;
  public const int LC_PROP_TINTR_XMAX = 757;
  public const int LC_PROP_TINTR_YMAX = 758;
  public const int LC_PROP_TINTR_ZMAX = 759;
  public const int LC_PROP_TINTR_DX = 760;
  public const int LC_PROP_TINTR_DY = 761;
  public const int LC_PROP_TINTR_DZ = 762;
  public const int LC_PROP_TINTR_FLAGS = 763;
  public const int LC_PROP_TINTR_MARK = 764;
  public const int LC_PROP_TINTR_EDGE_PT0 = 771;
  public const int LC_PROP_TINTR_EDGE_PT1 = 772;
  public const int LC_PROP_TINTR_EDGE_TR = 773;
  public const int LC_PROP_TINISO_Z = 781;
  public const int LC_PROP_TINISO_NVERS = 782;
  public const int LC_PROP_TINISO_IVER = 783;
  public const int LC_PROP_TINISO_X = 784;
  public const int LC_PROP_TINISO_Y = 785;
  public const int LC_PROP_TINISO_CLOSED = 786;
  public const int LC_PROP_GRID_XMIN = 1882;
  public const int LC_PROP_GRID_XMAX = 1883;
  public const int LC_PROP_GRID_YMIN = 1884;
  public const int LC_PROP_GRID_YMAX = 1885;
  public const int LC_PROP_GRID_W = 1886;
  public const int LC_PROP_GRID_H = 1887;
  public const int LC_PROP_GRID_NCELLX = 1888;
  public const int LC_PROP_GRID_NCELLY = 1889;
  public const int LC_PROP_CMD_ID = 2001;
  public const int LC_PROP_CMD_PARAM = 2002;
  public const int LC_PROP_CMD_STEP = 2003;
  public const int LC_PROP_CMD_LCWND = 2004;
  public const int LC_PROP_CMD_HWND = 2005;
  public const int LC_PROP_CMD_DRW = 2006;
  public const int LC_PROP_CMD_BLOCK = 2007;
  public const int LC_PROP_CMD_CURSORCROSS = 2008;
  public const int LC_PROP_CMD_INT0 = 2010;
  public const int LC_PROP_CMD_INT1 = 2011;
  public const int LC_PROP_CMD_INT2 = 2012;
  public const int LC_PROP_CMD_INT3 = 2013;
  public const int LC_PROP_CMD_INT4 = 2014;
  public const int LC_PROP_CMD_INT5 = 2015;
  public const int LC_PROP_CMD_INT6 = 2016;
  public const int LC_PROP_CMD_INT7 = 2017;
  public const int LC_PROP_CMD_INT8 = 2018;
  public const int LC_PROP_CMD_INT9 = 2019;
  public const int LC_PROP_CMD_FLOAT0 = 2020;
  public const int LC_PROP_CMD_FLOAT1 = 2021;
  public const int LC_PROP_CMD_FLOAT2 = 2022;
  public const int LC_PROP_CMD_FLOAT3 = 2023;
  public const int LC_PROP_CMD_FLOAT4 = 2024;
  public const int LC_PROP_CMD_FLOAT5 = 2025;
  public const int LC_PROP_CMD_FLOAT6 = 2026;
  public const int LC_PROP_CMD_FLOAT7 = 2027;
  public const int LC_PROP_CMD_FLOAT8 = 2028;
  public const int LC_PROP_CMD_FLOAT9 = 2029;
  public const int LC_PROP_CMD_HAND0 = 2030;
  public const int LC_PROP_CMD_HAND1 = 2031;
  public const int LC_PROP_CMD_HAND2 = 2032;
  public const int LC_PROP_CMD_HAND3 = 2033;
  public const int LC_PROP_CMD_HAND4 = 2034;
  public const int LC_PROP_CMD_HAND5 = 2035;
  public const int LC_PROP_CMD_HAND6 = 2036;
  public const int LC_PROP_CMD_HAND7 = 2037;
  public const int LC_PROP_CMD_HAND8 = 2038;
  public const int LC_PROP_CMD_HAND9 = 2039;
  public const int LC_PROP_CMD_STR = 2040;
  public const int LC_PROP_DRW_UID = 3001;
  public const int LC_PROP_DRW_FILENAME = 3002;
  public const int LC_PROP_DRW_DESCR = 3003;
  public const int LC_PROP_DRW_COMMENT = 3003;
  public const int LC_PROP_DRW_READONLY = 3004;
  public const int LC_PROP_DRW_DIRTY = 3005;
  public const int LC_PROP_DRW_IDMAX = 3006;
  public const int LC_PROP_DRW_SYNCZOOM = 3011;
  public const int LC_PROP_DRW_HASALPHABLEND = 3013;
  public const int LC_PROP_DRW_BLKREFGRIPS = 3014;
  public const int LC_PROP_DRW_JL_BASE = 3015;
  public const int LC_PROP_DRW_JL_BASEX = 3016;
  public const int LC_PROP_DRW_JL_BASEY = 3017;
  public const int LC_PROP_DRW_JL_LAYER = 3018;
  public const int LC_PROP_DRW_EXTOFFLAYER = 3019;
  public const int LC_PROP_DRW_ENABLEUNDO = 3021;
  public const int LC_PROP_DRW_LOCKSEL = 3022;
  public const int LC_PROP_DRW_MAXHATDASH = 3023;
  public const int LC_PROP_DRW_PROPLINFILL = 3024;
  public const int LC_PROP_DRW_PROPZTH = 3025;
  public const int LC_PROP_DRW_3DVIEW = 3026;
  public const int LC_PROP_DRW_PBTEXT = 3027;
  public const int LC_PROP_DRW_LUNITS = 3031;
  public const int LC_PROP_DRW_LUPREC = 3032;
  public const int LC_PROP_DRW_AUNITS = 3033;
  public const int LC_PROP_DRW_AUPREC = 3034;
  public const int LC_PROP_DRW_ANGBASE = 3035;
  public const int LC_PROP_DRW_ANGDIR = 3036;
  public const int LC_PROP_DRW_INSUNITS = 3037;
  public const int LC_PROP_DRW_PDMODE = 3038;
  public const int LC_PROP_DRW_PDSIZE = 3039;
  public const int LC_PROP_DRW_CMLJUST = 3040;
  public const int LC_PROP_DRW_CMLSCALE = 3041;
  public const int LC_PROP_DRW_COLORBACKM = 3051;
  public const int LC_PROP_DRW_COLORBACKP = 3052;
  public const int LC_PROP_DRW_COLORFOREM = 3053;
  public const int LC_PROP_DRW_COLORFOREP = 3054;
  public const int LC_PROP_DRW_COLORCURSORM = 3055;
  public const int LC_PROP_DRW_COLORCURSORP = 3056;
  public const int LC_PROP_DRW_COLORPAPER = 3057;
  public const int LC_PROP_DRW_COLOR = 3061;
  public const int LC_PROP_DRW_COLORBYLAYER = 3062;
  public const int LC_PROP_DRW_COLORBYBLOCK = 3063;
  public const int LC_PROP_DRW_COLORI = 3064;
  public const int LC_PROP_DRW_COLORT = 3065;
  public const int LC_PROP_DRW_FCOLOR = 3066;
  public const int LC_PROP_DRW_FCOLORBYLAYER = 3067;
  public const int LC_PROP_DRW_FCOLORBYBLOCK = 3068;
  public const int LC_PROP_DRW_FCOLORI = 3069;
  public const int LC_PROP_DRW_FCOLORT = 3070;
  public const int LC_PROP_DRW_LAYER = 3081;
  public const int LC_PROP_DRW_LINETYPE = 3082;
  public const int LC_PROP_DRW_LTSCALE = 3083;
  public const int LC_PROP_DRW_TEXTSTYLE = 3084;
  public const int LC_PROP_DRW_DIMSTYLE = 3085;
  public const int LC_PROP_DRW_PNTSTYLE = 3086;
  public const int LC_PROP_DRW_MLSTYLE = 3087;
  public const int LC_PROP_DRW_BLOCK = 3089;
  public const int LC_PROP_DRW_VISBLOCK = 3090;
  public const int LC_PROP_DRW_LAYOUT = 3091;
  public const int LC_PROP_DRW_BARCTYPE = 3092;
  public const int LC_PROP_DRW_BARCSOLID = 3093;
  public const int LC_PROP_DRW_LWMODE = 3094;
  public const int LC_PROP_DRW_LWSCALE = 3095;
  public const int LC_PROP_DRW_LWIDTH = 3096;
  public const int LC_PROP_DRW_LWDEFAULT = 3097;
  public const int LC_PROP_DRW_LINFILL = 3098;
  public const int LC_PROP_DRW_TINPNT = 3102;
  public const int LC_PROP_DRW_TINTR = 3103;
  public const int LC_PROP_DRW_TINXY0 = 3104;
  public const int LC_PROP_DRW_EXPLODEARC = 3131;
  public const int LC_PROP_DRW_EXPPLINELA = 3132;
  public const int LC_PROP_DRW_EXPSIMPLINE = 3133;
  public const int LC_PROP_DRW_EXPTEXTSPLINE = 3134;
  public const int LC_PROP_DRW_BLOCK_MODEL = 3151;
  public const int LC_PROP_DRW_LAYER_0 = 3152;
  public const int LC_PROP_DRW_LINETYPE_CONT = 3153;
  public const int LC_PROP_DRW_LINETYPE_BYLAY = 3154;
  public const int LC_PROP_DRW_LINETYPE_BYBLK = 3155;
  public const int LC_PROP_DRW_TEXTSTYLE_STD = 3156;
  public const int LC_PROP_DRW_TSTYLE_STD = 3156;
  public const int LC_PROP_DRW_PNTSTYLE_STD = 3157;
  public const int LC_PROP_DRW_DIMSTYLE_STD = 3158;
  public const int LC_PROP_DRW_MLSTYLE_STD = 3159;
  public const int LC_PROP_DRW_RESOLARC = 3171;
  public const int LC_PROP_DRW_RESOLSPLINE = 3172;
  public const int LC_PROP_DRW_RESOLTEXT = 3173;
  public const int LC_PROP_DRW_LIM_MINPIXSIZE = 3181;
  public const int LC_PROP_DRW_LIM_MAXLEF = 3182;
  public const int LC_PROP_DRW_LIM_MAXBOT = 3183;
  public const int LC_PROP_DRW_LIM_MAXRIG = 3184;
  public const int LC_PROP_DRW_LIM_MAXTOP = 3185;
  public const int LC_PROP_DRW_LIM_MAXON = 3186;
  public const int LC_PROP_DRW_XDATASIZE = 3251;
  public const int LC_PROP_DRW_XDATA = 3252;
  public const int LC_PROP_DRW_INT0 = 3260;
  public const int LC_PROP_DRW_INT1 = 3261;
  public const int LC_PROP_DRW_INT2 = 3262;
  public const int LC_PROP_DRW_INT3 = 3263;
  public const int LC_PROP_DRW_INT4 = 3264;
  public const int LC_PROP_DRW_INT5 = 3265;
  public const int LC_PROP_DRW_INT6 = 3266;
  public const int LC_PROP_DRW_INT7 = 3267;
  public const int LC_PROP_DRW_INT8 = 3268;
  public const int LC_PROP_DRW_INT9 = 3269;
  public const int LC_PROP_DRW_FLOAT0 = 3270;
  public const int LC_PROP_DRW_FLOAT1 = 3271;
  public const int LC_PROP_DRW_FLOAT2 = 3272;
  public const int LC_PROP_DRW_FLOAT3 = 3273;
  public const int LC_PROP_DRW_FLOAT4 = 3274;
  public const int LC_PROP_DRW_FLOAT5 = 3275;
  public const int LC_PROP_DRW_FLOAT6 = 3276;
  public const int LC_PROP_DRW_FLOAT7 = 3277;
  public const int LC_PROP_DRW_FLOAT8 = 3278;
  public const int LC_PROP_DRW_FLOAT9 = 3279;
  public const int LC_PROP_DRW_STR0 = 3280;
  public const int LC_PROP_DRW_STR1 = 3281;
  public const int LC_PROP_DRW_STR2 = 3282;
  public const int LC_PROP_DRW_STR3 = 3283;
  public const int LC_PROP_DRW_STR4 = 3284;
  public const int LC_PROP_DRW_STR5 = 3285;
  public const int LC_PROP_DRW_STR6 = 3286;
  public const int LC_PROP_DRW_STR7 = 3287;
  public const int LC_PROP_DRW_STR8 = 3288;
  public const int LC_PROP_DRW_STR9 = 3289;
  public const int LC_PROP_TABLE_ID = 4001;
  public const int LC_PROP_TABLE_NAME = 4002;
  public const int LC_PROP_TABLE_DESC = 4003;
  public const int LC_PROP_TABLE_DESCR = 4003;
  public const int LC_PROP_TABLE_DRW = 4004;
  public const int LC_PROP_TABLE_DELETED = 4005;
  public const int LC_PROP_TABLE_ODA_HANDLE = 4010;
  public const int LC_PROP_TABLE_TYPE = 4011;
  public const int LC_PROP_TABLE_PRIORITY = 4012;
  public const int LC_PROP_TABLE_NREFS = 4013;
  public const int LC_PROP_TABLE_XDATASIZE = 4051;
  public const int LC_PROP_TABLE_XDATA = 4052;
  public const int LC_PROP_TABLE_XSTR = 4053;
  public const int LC_PROP_TABLE_INT0 = 4060;
  public const int LC_PROP_TABLE_INT1 = 4061;
  public const int LC_PROP_TABLE_INT2 = 4062;
  public const int LC_PROP_TABLE_INT3 = 4063;
  public const int LC_PROP_TABLE_INT4 = 4064;
  public const int LC_PROP_TABLE_FLOAT0 = 4070;
  public const int LC_PROP_TABLE_FLOAT1 = 4071;
  public const int LC_PROP_TABLE_FLOAT2 = 4072;
  public const int LC_PROP_TABLE_FLOAT3 = 4073;
  public const int LC_PROP_TABLE_FLOAT4 = 4074;
  public const int LC_PROP_LAYER_ID = 4001;
  public const int LC_PROP_LAYER_NAME = 4002;
  public const int LC_PROP_LAYER_DESC = 4003;
  public const int LC_PROP_LAYER_DESCR = 4003;
  public const int LC_PROP_LAYER_DRW = 4004;
  public const int LC_PROP_LAYER_DELETED = 4005;
  public const int LC_PROP_LAYER_COLOR = 4101;
  public const int LC_PROP_LAYER_COLORI = 4102;
  public const int LC_PROP_LAYER_COLORT = 4103;
  public const int LC_PROP_LAYER_FCOLOR = 4104;
  public const int LC_PROP_LAYER_FCOLORI = 4105;
  public const int LC_PROP_LAYER_FCOLORT = 4106;
  public const int LC_PROP_LAYER_LINETYPE = 4111;
  public const int LC_PROP_LAYER_LWEIGHT = 4112;
  public const int LC_PROP_LAYER_LWIDTH = 4112;
  public const int LC_PROP_LAYER_LOCKED = 4113;
  public const int LC_PROP_LAYER_NOPRINT = 4114;
  public const int LC_PROP_LAYER_VISIBLE = 4115;
  public const int LC_PROP_LAYER_0 = 4116;
  public const int LC_PROP_LAYER_NODLG = 4117;
  public const int LC_PROP_LAYER_JUMPLINES = 4118;
  public const int LC_PROP_LAYER_OSNAP = 4119;
  public const int LC_PROP_LAYER_NOEXPORT = 4120;
  public const int LC_PROP_LINETYPE_ID = 4001;
  public const int LC_PROP_LINETYPE_NAME = 4002;
  public const int LC_PROP_LINETYPE_DESC = 4003;
  public const int LC_PROP_LINETYPE_DESCR = 4003;
  public const int LC_PROP_LINETYPE_DRW = 4004;
  public const int LC_PROP_LINETYPE_DELETED = 4005;
  public const int LC_PROP_LINETYPE_DATA = 4145;
  public const int LC_PROP_LINETYPE_SCALE = 4146;
  public const int LC_PROP_LINETYPE_CONTINUOUS = 4147;
  public const int LC_PROP_LINETYPE_BYLAYER = 4148;
  public const int LC_PROP_LINETYPE_BYBLOCK = 4149;
  public const int LC_PROP_LINETYPE_STD = 4150;
  public const int LC_PROP_LINETYPE_PATLEN = 4151;
  public const int LC_PROP_LINETYPE_NELEM = 4153;
  public const int LC_PROP_LINETYPE_IELEM = 4154;
  public const int LC_PROP_LTELEM_LEN = 4155;
  public const int LC_PROP_LTELEM_COMPLEX = 4156;
  public const int LC_PROP_LTELEM_SHAPE = 4157;
  public const int LC_PROP_LTELEM_TEXT = 4158;
  public const int LC_PROP_LTELEM_STYLE = 4159;
  public const int LC_PROP_LTELEM_FONTNAME = 4160;
  public const int LC_PROP_LTELEM_SCALE = 4161;
  public const int LC_PROP_LTELEM_ANGLE = 4162;
  public const int LC_PROP_LTELEM_ABSANGLE = 4163;
  public const int LC_PROP_LTELEM_X = 4164;
  public const int LC_PROP_LTELEM_Y = 4165;
  public const int LC_PROP_TSTYLE_ID = 4001;
  public const int LC_PROP_TSTYLE_NAME = 4002;
  public const int LC_PROP_TSTYLE_DESC = 4003;
  public const int LC_PROP_TSTYLE_DESCR = 4003;
  public const int LC_PROP_TSTYLE_DRW = 4004;
  public const int LC_PROP_TSTYLE_DELETED = 4005;
  public const int LC_PROP_TSTYLE_FONT = 4175;
  public const int LC_PROP_TSTYLE_HFONT = 4176;
  public const int LC_PROP_TSTYLE_HEIGHT = 4177;
  public const int LC_PROP_TSTYLE_WSCALE = 4178;
  public const int LC_PROP_TSTYLE_OBLIQUE = 4179;
  public const int LC_PROP_TSTYLE_ANGLE = 4180;
  public const int LC_PROP_TSTYLE_ALIGN = 4181;
  public const int LC_PROP_TSTYLE_UPDOWN = 4182;
  public const int LC_PROP_TSTYLE_BACKWARD = 4183;
  public const int LC_PROP_TSTYLE_LINESPACE = 4184;
  public const int LC_PROP_TSTYLE_CHARSPACE = 4185;
  public const int LC_PROP_TSTYLE_STANDARD = 4186;
  public const int LC_PROP_TSTYLE_SHAPES = 4187;
  public const int LC_PROP_TSTYLE_WINFONT = 4188;
  public const int LC_PROP_TSTYLE_SOLID = 4189;
  public const int LC_PROP_TSTYLE_CLOSED = 4190;
  public const int LC_PROP_TSTYLE_HOLLOW = 4191;
  public const int LC_PROP_TSTYLE_BOLD = 4192;
  public const int LC_PROP_TSTYLE_ITALIC = 4193;
  public const int LC_PROP_TSTYLE_UNDERLINE = 4194;
  public const int LC_PROP_TSTYLE_STRIKEOUT = 4195;
  public const int LC_PROP_TSTYLE_MONOWIDTH = 4196;
  public const int LC_PROP_DIMST_ID = 4001;
  public const int LC_PROP_DIMST_NAME = 4002;
  public const int LC_PROP_DIMST_DESC = 4003;
  public const int LC_PROP_DIMST_DESCR = 4003;
  public const int LC_PROP_DIMST_DRW = 4004;
  public const int LC_PROP_DIMST_DELETED = 4005;
  public const int LC_PROP_DIMST_STANDARD = 4205;
  public const int LC_PROP_DIMST_ADEC = 4211;
  public const int LC_PROP_DIMST_ASZ = 4212;
  public const int LC_PROP_DIMST_AUNIT = 4213;
  public const int LC_PROP_DIMST_AZIN = 4214;
  public const int LC_PROP_DIMST_BLK1 = 4215;
  public const int LC_PROP_DIMST_BLK2 = 4216;
  public const int LC_PROP_DIMST_CEN = 4217;
  public const int LC_PROP_DIMST_CLRD = 4218;
  public const int LC_PROP_DIMST_CLRE = 4219;
  public const int LC_PROP_DIMST_CLRT = 4220;
  public const int LC_PROP_DIMST_DEC = 4221;
  public const int LC_PROP_DIMST_DSEP = 4222;
  public const int LC_PROP_DIMST_EXE = 4223;
  public const int LC_PROP_DIMST_EXO = 4224;
  public const int LC_PROP_DIMST_GAP = 4225;
  public const int LC_PROP_DIMST_LDRBLK = 4226;
  public const int LC_PROP_DIMST_LFAC = 4227;
  public const int LC_PROP_DIMST_LWD = 4228;
  public const int LC_PROP_DIMST_LWE = 4229;
  public const int LC_PROP_DIMST_POST = 4230;
  public const int LC_PROP_DIMST_RND = 4231;
  public const int LC_PROP_DIMST_SCALE = 4232;
  public const int LC_PROP_DIMST_TAD = 4233;
  public const int LC_PROP_DIMST_TIH = 4234;
  public const int LC_PROP_DIMST_TXT = 4235;
  public const int LC_PROP_DIMST_TXSTY = 4236;
  public const int LC_PROP_DIMST_TSTYLE = 4236;
  public const int LC_PROP_DIMST_LUNIT = 4237;
  public const int LC_PROP_DIMST_ZIN = 4238;
  public const int LC_PROP_PSTYLE_ID = 4001;
  public const int LC_PROP_PSTYLE_NAME = 4002;
  public const int LC_PROP_PSTYLE_DESC = 4003;
  public const int LC_PROP_PSTYLE_DESCR = 4003;
  public const int LC_PROP_PSTYLE_DRW = 4004;
  public const int LC_PROP_PSTYLE_DELETED = 4005;
  public const int LC_PROP_PSTYLE_STANDARD = 4265;
  public const int LC_PROP_PSTYLE_BLOCK = 4266;
  public const int LC_PROP_PSTYLE_BSCALE = 4267;
  public const int LC_PROP_PSTYLE_TSTYLE = 4268;
  public const int LC_PROP_PSTYLE_TH = 4269;
  public const int LC_PROP_PSTYLE_TWS = 4270;
  public const int LC_PROP_PSTYLE_PTMODE = 4271;
  public const int LC_PROP_PSTYLE_PTSIZE = 4272;
  public const int LC_PROP_PSTYLE_SNAP = 4273;
  public const int LC_PROP_PSTYLE_FIXED = 4274;
  public const int LC_PROP_MLSTYLE_ID = 4001;
  public const int LC_PROP_MLSTYLE_NAME = 4002;
  public const int LC_PROP_MLSTYLE_DESC = 4003;
  public const int LC_PROP_MLSTYLE_DESCR = 4003;
  public const int LC_PROP_MLSTYLE_DRW = 4004;
  public const int LC_PROP_MLSTYLE_DELETED = 4005;
  public const int LC_PROP_MLSTYLE_STANDARD = 4281;
  public const int LC_PROP_MLSTYLE_JOINTS = 4282;
  public const int LC_PROP_MLSTYLE_STARTLINE = 4283;
  public const int LC_PROP_MLSTYLE_STARTARC = 4284;
  public const int LC_PROP_MLSTYLE_ENDLINE = 4285;
  public const int LC_PROP_MLSTYLE_ENDARC = 4286;
  public const int LC_PROP_MLSTYLE_NLINES = 4287;
  public const int LC_PROP_MLSTYLE_ILINE = 4288;
  public const int LC_PROP_MLSTYLE_OFFSET = 4289;
  public const int LC_PROP_MLSTYLE_LTYPE = 4290;
  public const int LC_PROP_MLSTYLE_COLOR = 4291;
  public const int LC_PROP_IMAGE_ID = 4001;
  public const int LC_PROP_IMAGE_NAME = 4002;
  public const int LC_PROP_IMAGE_DESC = 4003;
  public const int LC_PROP_IMAGE_DESCR = 4003;
  public const int LC_PROP_IMAGE_DRW = 4004;
  public const int LC_PROP_IMAGE_DELETED = 4005;
  public const int LC_PROP_IMAGE_FILENAME = 4401;
  public const int LC_PROP_IMAGE_SIZE = 4402;
  public const int LC_PROP_IMAGE_WPIX = 4403;
  public const int LC_PROP_IMAGE_W = 4404;
  public const int LC_PROP_IMAGE_HPIX = 4405;
  public const int LC_PROP_IMAGE_H = 4406;
  public const int LC_PROP_IMAGE_CBIT = 4407;
  public const int LC_PROP_IMAGE_RGB = 4408;
  public const int LC_PROP_IMAGE_EMBEDDED = 4409;
  public const int LC_PROP_IMAGE_CREATED = 4410;
  public const int LC_PROP_IMAGE_COLORS = 4411;
  public const int LC_PROP_IMAGE_BITS = 4412;
  public const int LC_PROP_IMAGE_DIB = 4413;
  public const int LC_PROP_LFILL_ID = 4001;
  public const int LC_PROP_LFILL_NAME = 4002;
  public const int LC_PROP_LFILL_DESC = 4003;
  public const int LC_PROP_LFILL_DESCR = 4003;
  public const int LC_PROP_LFILL_DRW = 4004;
  public const int LC_PROP_LFILL_DELETED = 4005;
  public const int LC_PROP_LFILL_ENABLED0 = 4501;
  public const int LC_PROP_LFILL_DIST0 = 4502;
  public const int LC_PROP_LFILL_ANGLE0 = 4503;
  public const int LC_PROP_LFILL_GAP0 = 4504;
  public const int LC_PROP_LFILL_ENABLED1 = 4505;
  public const int LC_PROP_LFILL_DIST1 = 4506;
  public const int LC_PROP_LFILL_ANGLE1 = 4507;
  public const int LC_PROP_LFILL_GAP1 = 4508;
  public const int LC_PROP_BLOCK_ID = 4001;
  public const int LC_PROP_BLOCK_NAME = 4002;
  public const int LC_PROP_BLOCK_DESC = 4003;
  public const int LC_PROP_BLOCK_DESCR = 4003;
  public const int LC_PROP_BLOCK_DRW = 4004;
  public const int LC_PROP_BLOCK_DELETED = 4005;
  public const int LC_PROP_BLOCK_X = 4801;
  public const int LC_PROP_BLOCK_Y = 4802;
  public const int LC_PROP_BLOCK_UFSCALING = 4803;
  public const int LC_PROP_BLOCK_UNITS = 4804;
  public const int LC_PROP_BLOCK_UNITSCALE = 4810;
  public const int LC_PROP_BLOCK_MODEL = 4811;
  public const int LC_PROP_BLOCK_PAPER = 4812;
  public const int LC_PROP_BLOCK_LAYOUT = 4813;
  public const int LC_PROP_BLOCK_STANDARD = 4814;
  public const int LC_PROP_BLOCK_LAYOUTNAME = 4815;
  public const int LC_PROP_BLOCK_LAYOUTORDER = 4816;
  public const int LC_PROP_BLOCK_HIDDEN = 4818;
  public const int LC_PROP_BLOCK_DIM = 4819;
  public const int LC_PROP_BLOCK_HATCH = 4820;
  public const int LC_PROP_BLOCK_NOBJ = 4821;
  public const int LC_PROP_BLOCK_NENTS = 4821;
  public const int LC_PROP_BLOCK_NSELOBJ = 4822;
  public const int LC_PROP_BLOCK_NSELENTS = 4822;
  public const int LC_PROP_BLOCK_ATTRIBS = 4827;
  public const int LC_PROP_BLOCK_ODA_LAYOUTHANDLE = 4829;
  public const int LC_PROP_BLOCK_ODA_VPORTHANDLE = 4830;
  public const int LC_PROP_BLOCK_XMIN = 4831;
  public const int LC_PROP_BLOCK_YMIN = 4832;
  public const int LC_PROP_BLOCK_XMAX = 4833;
  public const int LC_PROP_BLOCK_YMAX = 4834;
  public const int LC_PROP_BLOCK_XCEN = 4835;
  public const int LC_PROP_BLOCK_YCEN = 4836;
  public const int LC_PROP_BLOCK_DX = 4837;
  public const int LC_PROP_BLOCK_DY = 4838;
  public const int LC_PROP_BLOCK_VISLEF = 4839;
  public const int LC_PROP_BLOCK_VISBOT = 4840;
  public const int LC_PROP_BLOCK_VISRIG = 4841;
  public const int LC_PROP_BLOCK_VISTOP = 4842;
  public const int LC_PROP_BLOCK_SELXMIN = 4843;
  public const int LC_PROP_BLOCK_SELYMIN = 4844;
  public const int LC_PROP_BLOCK_SELXMAX = 4845;
  public const int LC_PROP_BLOCK_SELYMAX = 4846;
  public const int LC_PROP_BLOCK_SELXCEN = 4847;
  public const int LC_PROP_BLOCK_SELYCEN = 4848;
  public const int LC_PROP_SHAPE_ANGLE = 4849;
  public const int LC_PROP_PAPER_INCH = 4851;
  public const int LC_PROP_PAPER_X0 = 4852;
  public const int LC_PROP_PAPER_Y0 = 4853;
  public const int LC_PROP_PAPER_SIZE = 4854;
  public const int LC_PROP_PAPER_ORIENT = 4855;
  public const int LC_PROP_PAPER_W = 4856;
  public const int LC_PROP_PAPER_H = 4857;
  public const int LC_PROP_ENT_TYPE = 5030;
  public const int LC_PROP_ENT_ID = 5001;
  public const int LC_PROP_ENT_KEY = 5002;
  public const int LC_PROP_ENT_BLOCK = 5024;
  public const int LC_PROP_ENT_DRW = 5025;
  public const int LC_PROP_ENT_LAYER = 5020;
  public const int LC_PROP_ENT_LINETYPE = 5021;
  public const int LC_PROP_ENT_LTSCALE = 5022;
  public const int LC_PROP_ENT_LWEIGHT = 5023;
  public const int LC_PROP_ENT_LWIDTH = 5023;
  public const int LC_PROP_ENT_PRIORITY = 5040;
  public const int LC_PROP_ENT_FROMCB = 5035;
  public const int LC_PROP_ENT_COLOR = 5003;
  public const int LC_PROP_ENT_COLORI = 5004;
  public const int LC_PROP_ENT_COLORT = 5005;
  public const int LC_PROP_ENT_COLORBYLAYER = 5006;
  public const int LC_PROP_ENT_COLORBYBLOCK = 5007;
  public const int LC_PROP_ENT_SOLIDFILL = 5008;
  public const int LC_PROP_ENT_FILLED = 5008;
  public const int LC_PROP_ENT_FILLING = 5008;
  public const int LC_PROP_ENT_WIPEOUT = 5011;
  public const int LC_PROP_ENT_FCOLOR = 5012;
  public const int LC_PROP_ENT_FCOLORI = 5013;
  public const int LC_PROP_ENT_FCOLORT = 5014;
  public const int LC_PROP_ENT_FCOLORBYLAYER = 5015;
  public const int LC_PROP_ENT_FCOLORBYBLOCK = 5016;
  public const int LC_PROP_ENT_FALPHA = 5017;
  public const int LC_PROP_ENT_LINFILL = 5018;
  public const int LC_PROP_ENT_LINFILLNL = 5019;
  public const int LC_PROP_ENT_LOCKED = 5026;
  public const int LC_PROP_ENT_VISIBLE = 5027;
  public const int LC_PROP_ENT_HIDDEN = 5028;
  public const int LC_PROP_ENT_BLINK = 5029;
  public const int LC_PROP_ENT_DELETED = 5031;
  public const int LC_PROP_ENT_IMMORTAL = 5032;
  public const int LC_PROP_ENT_SELECTED = 5033;
  public const int LC_PROP_ENT_GRIPMODE = 5034;
  public const int LC_PROP_ENT_XMIN = 5052;
  public const int LC_PROP_ENT_YMIN = 5053;
  public const int LC_PROP_ENT_XMAX = 5054;
  public const int LC_PROP_ENT_YMAX = 5055;
  public const int LC_PROP_ENT_XCEN = 5056;
  public const int LC_PROP_ENT_YCEN = 5057;
  public const int LC_PROP_ENT_DX = 5058;
  public const int LC_PROP_ENT_DY = 5059;
  public const int LC_PROP_ENT_LEN = 5060;
  public const int LC_PROP_ENT_Z = 5061;
  public const int LC_PROP_ENT_THICKNESS = 5062;
  public const int LC_PROP_ENT_XDATAID = 5041;
  public const int LC_PROP_ENT_XDATAFLAGS = 5042;
  public const int LC_PROP_ENT_XDATASIZE = 5043;
  public const int LC_PROP_ENT_XDATA = 5044;
  public const int LC_PROP_ENT_XSTR = 5045;
  public const int LC_PROP_POINT_STYLE = 5101;
  public const int LC_PROP_POINT_X = 5102;
  public const int LC_PROP_POINT_Y = 5103;
  public const int LC_PROP_POINT_Z = 5061;
  public const int LC_PROP_POINT_SIZE = 5104;
  public const int LC_PROP_POINT_MODE = 5105;
  public const int LC_PROP_POINT_BANGLE = 5106;
  public const int LC_PROP_POINT_TDX = 5107;
  public const int LC_PROP_POINT_TDY = 5108;
  public const int LC_PROP_POINT_TANGLE = 5109;
  public const int LC_PROP_POINT_TEXT = 5110;
  public const int LC_PROP_POINT_TEXTLEN = 5111;
  public const int LC_PROP_PTARR_FILENAME = 5112;
  public const int LC_PROP_PTARR_FNAME = 5113;
  public const int LC_PROP_PTARR_DIR = 5114;
  public const int LC_PROP_PTARR_LOADED = 5115;
  public const int LC_PROP_PTARR_NUM = 5116;
  public const int LC_PROP_PTARR_NUMVIS = 5117;
  public const int LC_PROP_PTARR_TEXTVLIM = 5118;
  public const int LC_PROP_PTARR_VLIM10 = 5119;
  public const int LC_PROP_PTARR_VLIM100 = 5120;
  public const int LC_PROP_LINE_X0 = 5131;
  public const int LC_PROP_LINE_Y0 = 5132;
  public const int LC_PROP_LINE_Z0 = 5133;
  public const int LC_PROP_LINE_X1 = 5134;
  public const int LC_PROP_LINE_Y1 = 5135;
  public const int LC_PROP_LINE_Z1 = 5136;
  public const int LC_PROP_LINE_DX = 5137;
  public const int LC_PROP_LINE_DY = 5138;
  public const int LC_PROP_LINE_DZ = 5139;
  public const int LC_PROP_LINE_ANG = 5140;
  public const int LC_PROP_LINE_LEN = 5141;
  public const int LC_PROP_LINE_DSARROW0 = 5142;
  public const int LC_PROP_LINE_DSARROW1 = 5143;
  public const int LC_PROP_LINE_W0 = 5144;
  public const int LC_PROP_LINE_W1 = 5145;
  public const int LC_PROP_LINE_SOLID = 5146;
  public const int LC_PROP_XLINE_X0 = 5151;
  public const int LC_PROP_XLINE_Y0 = 5152;
  public const int LC_PROP_XLINE_ANG = 5154;
  public const int LC_PROP_XLINE_DIRX = 5155;
  public const int LC_PROP_XLINE_DIRY = 5156;
  public const int LC_PROP_XLINE_RAY = 5157;
  public const int LC_PROP_CIRCLE_X = 5201;
  public const int LC_PROP_CIRCLE_Y = 5202;
  public const int LC_PROP_CIRCLE_R = 5204;
  public const int LC_PROP_CIRCLE_RAD = 5204;
  public const int LC_PROP_CIRCLE_RADIUS = 5204;
  public const int LC_PROP_CIRCLE_DIAM = 5205;
  public const int LC_PROP_CIRCLE_LEN = 5206;
  public const int LC_PROP_CIRCLE_AREA = 5207;
  public const int LC_PROP_CIRCLE_ANG0 = 5208;
  public const int LC_PROP_CIRCLE_DIRCW = 5209;
  public const int LC_PROP_CIRCLE_RESOL = 5210;
  public const int LC_PROP_CIRC_X = 5201;
  public const int LC_PROP_CIRC_Y = 5202;
  public const int LC_PROP_CIRC_R = 5204;
  public const int LC_PROP_CIRC_RAD = 5204;
  public const int LC_PROP_CIRC_RADIUS = 5204;
  public const int LC_PROP_CIRC_DIAM = 5205;
  public const int LC_PROP_CIRC_LEN = 5206;
  public const int LC_PROP_CIRC_AREA = 5207;
  public const int LC_PROP_CIRC_ANG0 = 5208;
  public const int LC_PROP_CIRC_DIRCW = 5209;
  public const int LC_PROP_CIRC_RESOL = 5210;
  public const int LC_PROP_ARC_X = 5231;
  public const int LC_PROP_ARC_Y = 5232;
  public const int LC_PROP_ARC_R = 5234;
  public const int LC_PROP_ARC_RAD = 5234;
  public const int LC_PROP_ARC_RADIUS = 5234;
  public const int LC_PROP_ARC_ANG0 = 5235;
  public const int LC_PROP_ARC_ANGARC = 5236;
  public const int LC_PROP_ARC_ANGEND = 5237;
  public const int LC_PROP_ARC_X0 = 5238;
  public const int LC_PROP_ARC_Y0 = 5239;
  public const int LC_PROP_ARC_Z0 = 5240;
  public const int LC_PROP_ARC_XMID = 5241;
  public const int LC_PROP_ARC_YMID = 5242;
  public const int LC_PROP_ARC_XEND = 5243;
  public const int LC_PROP_ARC_YEND = 5244;
  public const int LC_PROP_ARC_ZEND = 5245;
  public const int LC_PROP_ARC_LEN = 5246;
  public const int LC_PROP_ARC_CHLEN = 5247;
  public const int LC_PROP_ARC_AREA = 5248;
  public const int LC_PROP_ARC_CCW = 5249;
  public const int LC_PROP_ARC_SECTOR = 5250;
  public const int LC_PROP_ARC_RESOL = 5251;
  public const int LC_PROP_ELL_X = 5261;
  public const int LC_PROP_ELL_Y = 5262;
  public const int LC_PROP_ELL_R1 = 5264;
  public const int LC_PROP_ELL_R2 = 5265;
  public const int LC_PROP_ELL_RATIO = 5266;
  public const int LC_PROP_ELL_ANGLE = 5267;
  public const int LC_PROP_ELL_ANG0 = 5268;
  public const int LC_PROP_ELL_ANGARC = 5269;
  public const int LC_PROP_ELL_ANGEND = 5270;
  public const int LC_PROP_ELL_X0 = 5271;
  public const int LC_PROP_ELL_Y0 = 5272;
  public const int LC_PROP_ELL_XEND = 5273;
  public const int LC_PROP_ELL_YEND = 5274;
  public const int LC_PROP_ELL_LEN = 5276;
  public const int LC_PROP_ELL_AREA = 5277;
  public const int LC_PROP_ELL_FULL = 5278;
  public const int LC_PROP_ELL_CCW = 5279;
  public const int LC_PROP_ELL_SECTOR = 5282;
  public const int LC_PROP_ELL_RESOL = 5283;
  public const int LC_PROP_PLINE_FIT = 5301;
  public const int LC_PROP_PLINE_CLOSED = 5302;
  public const int LC_PROP_PLINE_NVERS = 5303;
  public const int LC_PROP_PLINE_WIDTH = 5305;
  public const int LC_PROP_PLINE_LEN = 5306;
  public const int LC_PROP_PLINE_AREA = 5307;
  public const int LC_PROP_PLINE_CW = 5308;
  public const int LC_PROP_PLINE_CCW = 5309;
  public const int LC_PROP_PLINE_Z = 5310;
  public const int LC_PROP_PLINE_CONSTZ = 5311;
  public const int LC_PROP_PLINE_RESOLA = 5312;
  public const int LC_PROP_PLINE_RESOLS = 5313;
  public const int LC_PROP_PLINE_RADIUS = 5314;
  public const int LC_PROP_PLINE_CHAMFER = 5315;
  public const int LC_PROP_PLINE_HASANG0 = 5316;
  public const int LC_PROP_PLINE_ANG0 = 5317;
  public const int LC_PROP_PLINE_HASANG2 = 5318;
  public const int LC_PROP_PLINE_ANG2 = 5319;
  public const int LC_PROP_PLINE_WIPEOUT = 5325;
  public const int LC_PROP_PLINE_ODSOLID = 5326;
  public const int LC_PROP_MLINE_STYLE = 5351;
  public const int LC_PROP_MLINE_JUST = 5352;
  public const int LC_PROP_MLINE_SCALE = 5353;
  public const int LC_PROP_MLINE_NVERS = 5354;
  public const int LC_PROP_MLINE_CLOSED = 5355;
  public const int LC_PROP_MLINE_FIT = 5356;
  public const int LC_PROP_MLINE_LEN = 5357;
  public const int LC_PROP_MLINE_AREA = 5358;
  public const int LC_PROP_RECT_X = 5371;
  public const int LC_PROP_RECT_Y = 5372;
  public const int LC_PROP_RECT_W = 5374;
  public const int LC_PROP_RECT_H = 5375;
  public const int LC_PROP_RECT_ANGLE = 5376;
  public const int LC_PROP_RECT_R = 5377;
  public const int LC_PROP_RECT_RAD = 5377;
  public const int LC_PROP_RECT_RADIUS = 5377;
  public const int LC_PROP_RECT_CHAMFER = 5378;
  public const int LC_PROP_RECT_DIRCW = 5379;
  public const int LC_PROP_RECT_START = 5380;
  public const int LC_PROP_RECT_LEN = 5381;
  public const int LC_PROP_RECT_AREA = 5382;
  public const int LC_PROP_RECT_RESOL = 5383;
  public const int LC_PROP_RECT_GRID = 5384;
  public const int LC_PROP_RECT_GRNW = 5385;
  public const int LC_PROP_RECT_GRNH = 5386;
  public const int LC_PROP_RECT_GRDW = 5387;
  public const int LC_PROP_RECT_GRDH = 5388;
  public const int LC_PROP_CRECT_ID = 5390;
  public const int LC_PROP_CRECT_NAME = 5391;
  public const int LC_PROP_CRECT_X = 5392;
  public const int LC_PROP_CRECT_Y = 5393;
  public const int LC_PROP_CRECT_W = 5394;
  public const int LC_PROP_CRECT_H = 5395;
  public const int LC_PROP_CRECT_ANGLE = 5396;
  public const int LC_PROP_CRECT_LEN = 5398;
  public const int LC_PROP_CRECT_AREA = 5399;
  public const int LC_PROP_TEXT_STYLE = 5401;
  public const int LC_PROP_TEXT_STR = 5402;
  public const int LC_PROP_TEXT_STRT = 5403;
  public const int LC_PROP_TEXT_LEN = 5404;
  public const int LC_PROP_TEXT_ALIGN = 5405;
  public const int LC_PROP_TEXT_H = 5406;
  public const int LC_PROP_TEXT_X = 5407;
  public const int LC_PROP_TEXT_Y = 5408;
  public const int LC_PROP_TEXT_DX = 5409;
  public const int LC_PROP_TEXT_DY = 5410;
  public const int LC_PROP_TEXT_WSCALE = 5412;
  public const int LC_PROP_TEXT_ANGLE = 5413;
  public const int LC_PROP_TEXT_OBLIQUE = 5414;
  public const int LC_PROP_TEXT_CHARSPACE = 5415;
  public const int LC_PROP_TEXT_WRECT = 5416;
  public const int LC_PROP_TEXT_X0 = 5417;
  public const int LC_PROP_TEXT_Y0 = 5418;
  public const int LC_PROP_TEXT_XFIT = 5419;
  public const int LC_PROP_TEXT_YFIT = 5420;
  public const int LC_PROP_TEXT_UPDOWN = 5421;
  public const int LC_PROP_TEXT_BACKWARD = 5422;
  public const int LC_PROP_TEXT_RESOL = 5423;
  public const int LC_PROP_TEXTW_STYLE = 5431;
  public const int LC_PROP_TEXTW_STR = 5432;
  public const int LC_PROP_TEXTW_STRT = 5433;
  public const int LC_PROP_TEXTW_LEN = 5434;
  public const int LC_PROP_TEXTW_ALIGN = 5435;
  public const int LC_PROP_TEXTW_X = 5436;
  public const int LC_PROP_TEXTW_Y = 5437;
  public const int LC_PROP_TEXTW_H = 5438;
  public const int LC_PROP_TEXTW_DX = 5440;
  public const int LC_PROP_TEXTW_DY = 5441;
  public const int LC_PROP_TEXTW_WSCALE = 5442;
  public const int LC_PROP_TEXTW_ANGLE = 5443;
  public const int LC_PROP_MTEXT_STYLE = 5451;
  public const int LC_PROP_MTEXT_STR = 5452;
  public const int LC_PROP_MTEXT_LEN = 5453;
  public const int LC_PROP_MTEXT_ALIGN = 5454;
  public const int LC_PROP_MTEXT_X = 5455;
  public const int LC_PROP_MTEXT_Y = 5456;
  public const int LC_PROP_MTEXT_H = 5458;
  public const int LC_PROP_MTEXT_WSCALE = 5459;
  public const int LC_PROP_MTEXT_ANGLE = 5460;
  public const int LC_PROP_MTEXT_OBLIQUE = 5461;
  public const int LC_PROP_MTEXT_WRECT = 5462;
  public const int LC_PROP_MTEXT_HRECT = 5463;
  public const int LC_PROP_MTEXT_WRAPWIDTH = 5464;
  public const int LC_PROP_MTEXT_LINESPACE = 5465;
  public const int LC_PROP_MTEXT_CHARSPACE = 5466;
  public const int LC_PROP_MTEXT_MIRROR = 5467;
  public const int LC_PROP_MTEXT_RESOL = 5468;
  public const int LC_PROP_ATEXT_STYLE = 5481;
  public const int LC_PROP_ATEXT_STR = 5482;
  public const int LC_PROP_ATEXT_STRT = 5483;
  public const int LC_PROP_ATEXT_LEN = 5484;
  public const int LC_PROP_ATEXT_X = 5485;
  public const int LC_PROP_ATEXT_Y = 5486;
  public const int LC_PROP_ATEXT_R = 5487;
  public const int LC_PROP_ATEXT_RAD = 5487;
  public const int LC_PROP_ATEXT_RADIUS = 5487;
  public const int LC_PROP_ATEXT_ANGLE = 5488;
  public const int LC_PROP_ATEXT_ANGSTA = 5489;
  public const int LC_PROP_ATEXT_ANGEND = 5490;
  public const int LC_PROP_ATEXT_CW = 5491;
  public const int LC_PROP_ATEXT_H = 5492;
  public const int LC_PROP_ATEXT_WSCALE = 5493;
  public const int LC_PROP_ATEXT_CHARSPACE = 5494;
  public const int LC_PROP_ATEXT_ALIGN = 5495;
  public const int LC_PROP_ATEXT_RESOL = 5496;
  public const int LC_PROP_ATT_MODE = 5501;
  public const int LC_PROP_ATT_TSTYLE = 5502;
  public const int LC_PROP_ATT_TAG = 5503;
  public const int LC_PROP_ATT_PROMPT = 5504;
  public const int LC_PROP_ATT_VALUE = 5505;
  public const int LC_PROP_ATT_ALIGN = 5506;
  public const int LC_PROP_ATT_X = 5507;
  public const int LC_PROP_ATT_Y = 5508;
  public const int LC_PROP_ATT_H = 5510;
  public const int LC_PROP_ATT_WSCALE = 5511;
  public const int LC_PROP_ATT_ANGLE = 5512;
  public const int LC_PROP_ATT_OBLIQUE = 5513;
  public const int LC_PROP_ATT_X0 = 5514;
  public const int LC_PROP_ATT_Y0 = 5515;
  public const int LC_PROP_ATT_XFIT = 5516;
  public const int LC_PROP_ATT_YFIT = 5517;
  public const int LC_PROP_ATT_UPDOWN = 5518;
  public const int LC_PROP_ATT_BACKWARD = 5519;
  public const int LC_PROP_ATT_COLOR = 5521;
  public const int LC_PROP_ATT_LAYER = 5522;
  public const int LC_PROP_ATT_LINETYPE = 5523;
  public const int LC_PROP_ATT_LTSCALE = 5524;
  public const int LC_PROP_ATT_LWIDTH = 5525;
  public const int LC_PROP_ATT_INVIS = 5526;
  public const int LC_PROP_ATT_LOCKPOS = 5527;
  public const int LC_PROP_ATT_MTEXT = 5528;
  public const int LC_PROP_BLKREF_BLOCK = 5531;
  public const int LC_PROP_BLKREF_X = 5532;
  public const int LC_PROP_BLKREF_Y = 5533;
  public const int LC_PROP_BLKREF_SCALE = 5534;
  public const int LC_PROP_BLKREF_SCX = 5535;
  public const int LC_PROP_BLKREF_SCY = 5536;
  public const int LC_PROP_BLKREF_UFSCALE = 5537;
  public const int LC_PROP_BLKREF_ANGLE = 5538;
  public const int LC_PROP_BLKREF_ARNX = 5539;
  public const int LC_PROP_BLKREF_ARDX = 5540;
  public const int LC_PROP_BLKREF_ARNY = 5541;
  public const int LC_PROP_BLKREF_ARDY = 5542;
  public const int LC_PROP_BLKREF_ARANG = 5543;
  public const int LC_PROP_BLKREF_ATTRIBS = 5544;
  public const int LC_PROP_BLKREF_GRIPMODE = 5545;
  public const int LC_PROP_BLKREF_ONS_XY = 5546;
  public const int LC_PROP_BLKREF_ONS_SCALE = 5547;
  public const int LC_PROP_BLKREF_ONS_ANGLE = 5548;
  public const int LC_PROP_BLKREF_RETURN = 5549;
  public const int LC_PROP_IMGREF_IMAGE = 5551;
  public const int LC_PROP_IMGREF_XC = 5552;
  public const int LC_PROP_IMGREF_YC = 5553;
  public const int LC_PROP_IMGREF_W = 5554;
  public const int LC_PROP_IMGREF_H = 5555;
  public const int LC_PROP_IMGREF_WPIX = 5556;
  public const int LC_PROP_IMGREF_HPIX = 5557;
  public const int LC_PROP_IMGREF_SCALE = 5558;
  public const int LC_PROP_IMGREF_PIXELSIZE = 5558;
  public const int LC_PROP_IMGREF_SCALEX = 5560;
  public const int LC_PROP_IMGREF_SCALEY = 5561;
  public const int LC_PROP_IMGREF_SQPIX = 5562;
  public const int LC_PROP_IMGREF_ANGLE = 5564;
  public const int LC_PROP_IMGREF_BORDER = 5565;
  public const int LC_PROP_IMGREF_TRANSP = 5566;
  public const int LC_PROP_IMGREF_TRCOLOR = 5567;
  public const int LC_PROP_IMGREF_TRALPHA = 5568;
  public const int LC_PROP_IMGREF_GRAYS = 5569;
  public const int LC_PROP_IMGREF_GREY = 5569;
  public const int LC_PROP_IMGREF_FLIPHOR = 5570;
  public const int LC_PROP_IMGREF_FLIPVER = 5571;
  public const int LC_PROP_IMGREF_PATH = 5573;
  public const int LC_PROP_IMGREF_GP_X = 5574;
  public const int LC_PROP_IMGREF_GP_Y = 5575;
  public const int LC_PROP_IMGREF_GP_COLOR = 5576;
  public const int LC_PROP_IMGREF_GP_GRAY = 5577;
  public const int LC_PROP_IMGREF_UNSCALABLE = 5578;
  public const int LC_PROP_IMGREF_UNSSCALE = 5579;
  public const int LC_PROP_IMGREF_UNSALIGN = 5580;
  public const int LC_PROP_ECW_FILENAME = 5581;
  public const int LC_PROP_ECW_LOADED = 5582;
  public const int LC_PROP_ECW_WPIX = 5583;
  public const int LC_PROP_ECW_HPIX = 5584;
  public const int LC_PROP_ECW_CBIT = 5585;
  public const int LC_PROP_ECW_XMIN = 5586;
  public const int LC_PROP_ECW_YMIN = 5587;
  public const int LC_PROP_ECW_XMAX = 5588;
  public const int LC_PROP_ECW_YMAX = 5589;
  public const int LC_PROP_ECW_W = 5590;
  public const int LC_PROP_ECW_H = 5591;
  public const int LC_PROP_ECW_SCALEX = 5592;
  public const int LC_PROP_ECW_SCALEY = 5593;
  public const int LC_PROP_ECW_BORDER = 5594;
  public const int LC_PROP_ECW_GRAYS = 5595;
  public const int LC_PROP_ECW_BRIGHT = 5596;
  public const int LC_PROP_BRI_FILENAME = 5601;
  public const int LC_PROP_BRI_LOADED = 5602;
  public const int LC_PROP_BRI_WPIX = 5603;
  public const int LC_PROP_BRI_HPIX = 5604;
  public const int LC_PROP_BRI_XMIN = 5605;
  public const int LC_PROP_BRI_YMIN = 5606;
  public const int LC_PROP_BRI_XMAX = 5607;
  public const int LC_PROP_BRI_YMAX = 5608;
  public const int LC_PROP_BRI_W = 5609;
  public const int LC_PROP_BRI_H = 5610;
  public const int LC_PROP_BRI_PIXSIZE = 5611;
  public const int LC_PROP_BRI_BORDER = 5612;
  public const int LC_PROP_CAMERA_X = 5621;
  public const int LC_PROP_CAMERA_Y = 5622;
  public const int LC_PROP_CAMERA_W = 5623;
  public const int LC_PROP_CAMERA_H = 5624;
  public const int LC_PROP_HATCH_NAME = 5631;
  public const int LC_PROP_HATCH_PATTERN = 5632;
  public const int LC_PROP_HATCH_SCALE = 5633;
  public const int LC_PROP_HATCH_ANGLE = 5634;
  public const int LC_PROP_HATCH_SIZE = 5635;
  public const int LC_PROP_HATCH_ASSOC = 5636;
  public const int LC_PROP_HATCH_SOLID = 5637;
  public const int LC_PROP_HATCH_CUSTOM = 5638;
  public const int LC_PROP_HATCH_NENTS = 5639;
  public const int LC_PROP_HATCH_NPT = 5640;
  public const int LC_PROP_HATCH_NLOOP = 5641;
  public const int LC_PROP_HATCH_NHPL = 5642;
  public const int LC_PROP_HATCH_IHPL = 5643;
  public const int LC_PROP_HATCH_FALPHA = 5644;
  public const int LC_PROP_HATCH_AREA = 5645;
  public const int LC_PROP_HATCH_NDASHES = 5646;
  public const int LC_PROP_HPL_ANGLE = 5651;
  public const int LC_PROP_HPL_X0 = 5652;
  public const int LC_PROP_HPL_Y0 = 5653;
  public const int LC_PROP_HPL_DX = 5654;
  public const int LC_PROP_HPL_DY = 5655;
  public const int LC_PROP_HPL_NDASH = 5656;
  public const int LC_PROP_HPL_DASH1 = 5657;
  public const int LC_PROP_HPL_DASH2 = 5658;
  public const int LC_PROP_HPL_DASH3 = 5659;
  public const int LC_PROP_HPL_DASH4 = 5660;
  public const int LC_PROP_HPL_DASH5 = 5661;
  public const int LC_PROP_HPL_DASH6 = 5662;
  public const int LC_PROP_HPL_DASH7 = 5663;
  public const int LC_PROP_HPL_DASH8 = 5664;
  public const int LC_PROP_VPORT_LEF = 5703;
  public const int LC_PROP_VPORT_BOT = 5704;
  public const int LC_PROP_VPORT_RIG = 5705;
  public const int LC_PROP_VPORT_TOP = 5706;
  public const int LC_PROP_VPORT_BORDER = 5707;
  public const int LC_PROP_VPORT_W = 5711;
  public const int LC_PROP_VPORT_H = 5712;
  public const int LC_PROP_VPORT_VX = 5713;
  public const int LC_PROP_VPORT_VY = 5714;
  public const int LC_PROP_VPORT_VSCALE = 5715;
  public const int LC_PROP_VPORT_VANGLE = 5716;
  public const int LC_PROP_VPORT_FIXSCALE = 5717;
  public const int LC_PROP_BARC_XC = 5751;
  public const int LC_PROP_BARC_X = 5751;
  public const int LC_PROP_BARC_YC = 5752;
  public const int LC_PROP_BARC_Y = 5752;
  public const int LC_PROP_BARC_W = 5753;
  public const int LC_PROP_BARC_H = 5754;
  public const int LC_PROP_BARC_ANG = 5755;
  public const int LC_PROP_BARC_TYPE = 5756;
  public const int LC_PROP_BARC_CODE = 5757;
  public const int LC_PROP_BARC_TEXT = 5757;
  public const int LC_PROP_BARC_CHECKSUM = 5758;
  public const int LC_PROP_BARC_NCHARS = 5759;
  public const int LC_PROP_BARC_NUBITS = 5760;
  public const int LC_PROP_BARC_NARSIZE = 5761;
  public const int LC_PROP_BARC_WIDERATIO = 5762;
  public const int LC_PROP_BARC_QZONE = 5763;
  public const int LC_PROP_BARC_OFFSET = 5764;
  public const int LC_PROP_BARC_INVERT = 5765;
  public const int LC_PROP_BARC_HIDETEXT = 5766;
  public const int LC_PROP_BARC_TSTYLE = 5767;
  public const int LC_PROP_BARC_TEXTH = 5768;
  public const int LC_PROP_BARC_TEXTW = 5769;
  public const int LC_PROP_BARC_TEXTCS = 5770;
  public const int LC_PROP_BARC_TEXTALIGN = 5771;
  public const int LC_PROP_BARC_TEXTRES = 5772;
  public const int LC_PROP_BARC_ECLEVEL = 5773;
  public const int LC_PROP_BARC_MASKPAT = 5774;
  public const int LC_PROP_BARC_DATATYPE = 5775;
  public const int LC_PROP_BARC_SIZE = 5776;
  public const int LC_PROP_BARC_NBARS = 5777;
  public const int LC_PROP_BARC_NMODX = 5777;
  public const int LC_PROP_BARC_NMODY = 5778;
  public const int LC_PROP_ARR_X0 = 5801;
  public const int LC_PROP_ARR_Y0 = 5802;
  public const int LC_PROP_ARR_X1 = 5803;
  public const int LC_PROP_ARR_Y1 = 5804;
  public const int LC_PROP_ARR_ANG = 5805;
  public const int LC_PROP_ARR_LEN = 5806;
  public const int LC_PROP_ARR_W = 5807;
  public const int LC_PROP_ARR_SW = 5808;
  public const int LC_PROP_ARR_SL = 5809;
  public const int LC_PROP_ARR_TIME = 5810;
  public const int LC_PROP_ARR_SHARP = 5811;
  public const int LC_PROP_SPIR_X = 5821;
  public const int LC_PROP_SPIR_Y = 5822;
  public const int LC_PROP_SPIR_R = 5823;
  public const int LC_PROP_SPIR_RADIUS = 5823;
  public const int LC_PROP_SPIR_R2 = 5824;
  public const int LC_PROP_SPIR_RATIO = 5825;
  public const int LC_PROP_SPIR_ANGLE = 5826;
  public const int LC_PROP_SPIR_TURNS = 5827;
  public const int LC_PROP_SPIR_DIRCW = 5829;
  public const int LC_PROP_SPIR_CLOSED = 5830;
  public const int LC_PROP_SPIR_DSTEP = 5831;
  public const int LC_PROP_SPIR_RESOL = 5832;
  public const int LC_PROP_XREF_FILENAME = 5841;
  public const int LC_PROP_XREF_FNAME = 5842;
  public const int LC_PROP_XREF_PATH = 5843;
  public const int LC_PROP_XREF_X = 5844;
  public const int LC_PROP_XREF_Y = 5845;
  public const int LC_PROP_XREF_SCX = 5846;
  public const int LC_PROP_XREF_SCY = 5847;
  public const int LC_PROP_XREF_ANGLE = 5848;
  public const int LC_PROP_DIM_STYLE = 6001;
  public const int LC_PROP_DIM_MEAS = 6003;
  public const int LC_PROP_DIM_TEXT = 6004;
  public const int LC_PROP_DIMANG_STYLE = 6001;
  public const int LC_PROP_DIMANG_MEAS = 6003;
  public const int LC_PROP_DIMANG_TEXT = 6004;
  public const int LC_PROP_DIMALI_STYLE = 6001;
  public const int LC_PROP_DIMALI_MEAS = 6003;
  public const int LC_PROP_DIMALI_TEXT = 6004;
  public const int LC_PROP_DIMDIA_STYLE = 6001;
  public const int LC_PROP_DIMDIA_MEAS = 6003;
  public const int LC_PROP_DIMDIA_TEXT = 6004;
  public const int LC_PROP_DIMRAD_STYLE = 6001;
  public const int LC_PROP_DIMRAD_MEAS = 6003;
  public const int LC_PROP_DIMRAD_TEXT = 6004;
  public const int LC_PROP_DIMORD_STYLE = 6001;
  public const int LC_PROP_DIMORD_MEAS = 6003;
  public const int LC_PROP_DIMORD_TEXT = 6004;
  public const int LC_PROP_DIMROT_STYLE = 6001;
  public const int LC_PROP_DIMROT_MEAS = 6003;
  public const int LC_PROP_DIMROT_TEXT = 6004;
  public const int LC_PROP_DIMLIN_STYLE = 6001;
  public const int LC_PROP_DIMLIN_MEAS = 6003;
  public const int LC_PROP_DIMLIN_TEXT = 6004;
  public const int LC_PROP_DIMANG_3PNT = 6011;
  public const int LC_PROP_DIMANG_2LINE = 6012;
  public const int LC_PROP_DIMANG_CPX = 6013;
  public const int LC_PROP_DIMANG_CPY = 6014;
  public const int LC_PROP_DIMANG_DP1X = 6015;
  public const int LC_PROP_DIMANG_DP1Y = 6016;
  public const int LC_PROP_DIMANG_DP2X = 6017;
  public const int LC_PROP_DIMANG_DP2Y = 6018;
  public const int LC_PROP_DIMANG_L1P1X = 6021;
  public const int LC_PROP_DIMANG_L1P1Y = 6022;
  public const int LC_PROP_DIMANG_L1P2X = 6023;
  public const int LC_PROP_DIMANG_L1P2Y = 6024;
  public const int LC_PROP_DIMANG_DP3X = 6023;
  public const int LC_PROP_DIMANG_DP3Y = 6024;
  public const int LC_PROP_DIMANG_L2P1X = 6025;
  public const int LC_PROP_DIMANG_L2P1Y = 6026;
  public const int LC_PROP_DIMANG_L2P2X = 6027;
  public const int LC_PROP_DIMANG_L2P2Y = 6028;
  public const int LC_PROP_DIMANG_DP4X = 6027;
  public const int LC_PROP_DIMANG_DP4Y = 6028;
  public const int LC_PROP_DIMANG_APX = 6029;
  public const int LC_PROP_DIMANG_APY = 6030;
  public const int LC_PROP_DIMANG_EXT1 = 6031;
  public const int LC_PROP_DIMANG_EXT2 = 6032;
  public const int LC_PROP_DIMANG_RAD = 6033;
  public const int LC_PROP_DIMANG_TPOS = 6034;
  public const int LC_PROP_DIMALI_DP1X = 6051;
  public const int LC_PROP_DIMALI_DP1Y = 6052;
  public const int LC_PROP_DIMALI_DP2X = 6053;
  public const int LC_PROP_DIMALI_DP2Y = 6054;
  public const int LC_PROP_DIMALI_TPX = 6055;
  public const int LC_PROP_DIMALI_TPY = 6056;
  public const int LC_PROP_DIMDIA_CPX = 6071;
  public const int LC_PROP_DIMDIA_CPY = 6072;
  public const int LC_PROP_DIMDIA_RPX = 6073;
  public const int LC_PROP_DIMDIA_RPY = 6074;
  public const int LC_PROP_DIMDIA_FPX = 6075;
  public const int LC_PROP_DIMDIA_FPY = 6076;
  public const int LC_PROP_DIMDIA_TPX = 6077;
  public const int LC_PROP_DIMDIA_TPY = 6078;
  public const int LC_PROP_DIMRAD_CPX = 6086;
  public const int LC_PROP_DIMRAD_CPY = 6087;
  public const int LC_PROP_DIMRAD_RPX = 6088;
  public const int LC_PROP_DIMRAD_RPY = 6089;
  public const int LC_PROP_DIMRAD_TPX = 6090;
  public const int LC_PROP_DIMRAD_TPY = 6091;
  public const int LC_PROP_DIMORD_XORD = 6101;
  public const int LC_PROP_DIMORD_DPX = 6102;
  public const int LC_PROP_DIMORD_DPY = 6103;
  public const int LC_PROP_DIMORD_TPX = 6104;
  public const int LC_PROP_DIMORD_TPY = 6105;
  public const int LC_PROP_DIMROT_ANGLE = 6121;
  public const int LC_PROP_DIMROT_DP1X = 6122;
  public const int LC_PROP_DIMROT_DP1Y = 6123;
  public const int LC_PROP_DIMROT_DP2X = 6124;
  public const int LC_PROP_DIMROT_DP2Y = 6125;
  public const int LC_PROP_DIMROT_TPX = 6126;
  public const int LC_PROP_DIMROT_TPY = 6127;
  public const int LC_PROP_DIMLIN_ANGLE = 6121;
  public const int LC_PROP_DIMLIN_DP1X = 6122;
  public const int LC_PROP_DIMLIN_DP1Y = 6123;
  public const int LC_PROP_DIMLIN_DP2X = 6124;
  public const int LC_PROP_DIMLIN_DP2Y = 6125;
  public const int LC_PROP_DIMLIN_TPX = 6126;
  public const int LC_PROP_DIMLIN_TPY = 6127;
  public const int LC_PROP_LEADER_STYLE = 6202;
  public const int LC_PROP_LEADER_TEXT = 6203;
  public const int LC_PROP_LEADER_ALIGN = 6204;
  public const int LC_PROP_LEADER_TPX = 6205;
  public const int LC_PROP_LEADER_TPY = 6206;
  public const int LC_PROP_LEADER_APX = 6207;
  public const int LC_PROP_LEADER_APY = 6208;
  public const int LC_PROP_LEADER_P1X = 6209;
  public const int LC_PROP_LEADER_P1Y = 6210;
  public const int LC_PROP_LEADER_P0X = 6211;
  public const int LC_PROP_LEADER_P0Y = 6212;
  public const int LC_PROP_LEADER_LDIST = 6213;
  public const int LC_PROP_LEADER_VERT = 6214;
  public const int LC_PROP_LEADER_CORNER = 6215;
  public const int LC_PROP_LEADER_TBW = 6216;
  public const int LC_PROP_LEADER_TBH = 6217;
  public const int LC_PROP_FACE_X0 = 6281;
  public const int LC_PROP_FACE_Y0 = 6282;
  public const int LC_PROP_FACE_Z0 = 6283;
  public const int LC_PROP_FACE_X1 = 6284;
  public const int LC_PROP_FACE_Y1 = 6285;
  public const int LC_PROP_FACE_Z1 = 6286;
  public const int LC_PROP_FACE_X2 = 6287;
  public const int LC_PROP_FACE_Y2 = 6288;
  public const int LC_PROP_FACE_Z2 = 6289;
  public const int LC_PROP_FACE_X3 = 6290;
  public const int LC_PROP_FACE_Y3 = 6291;
  public const int LC_PROP_FACE_Z3 = 6292;
  public const int LC_PROP_FACE_EDGE1 = 6293;
  public const int LC_PROP_FACE_EDGE2 = 6294;
  public const int LC_PROP_FACE_EDGE3 = 6295;
  public const int LC_PROP_FACE_EDGE4 = 6296;
  public const int LC_PROP_FACE_EDGE = 6297;
  public const int LC_PROP_FACE_NPTS = 6298;
  public const int LC_PROP_RPLAN_LEN = 6301;
  public const int LC_PROP_RPLAN_MARKARC = 6302;
  public const int LC_PROP_RPLAN_MARKSIZE = 6303;
  public const int LC_PROP_RPLAN_NVERS = 6311;
  public const int LC_PROP_RPLAN_IVER = 6312;
  public const int LC_PROP_SHAPE_NENTS = 6341;
  public const int LC_PROP_SHAPE_NPATHS = 6342;
  public const int LC_PROP_TIN_NAME = 7001;
  public const int LC_PROP_TIN_DESCR = 7002;
  public const int LC_PROP_TIN_FILENAME = 7003;
  public const int LC_PROP_TIN_NPTYPES = 7004;
  public const int LC_PROP_TIN_NPOINTS = 7005;
  public const int LC_PROP_TIN_NTRIANS = 7006;
  public const int LC_PROP_TIN_NBNDPTS = 7007;
  public const int LC_PROP_TIN_NISOLINES = 7008;
  public const int LC_PROP_TIN_HASCFILL = 7009;
  public const int LC_PROP_TIN_PNTIMGDIR = 7010;
  public const int LC_PROP_TIN_XMIN = 7020;
  public const int LC_PROP_TIN_XMAX = 7021;
  public const int LC_PROP_TIN_YMIN = 7022;
  public const int LC_PROP_TIN_YMAX = 7023;
  public const int LC_PROP_TIN_ZMIN = 7024;
  public const int LC_PROP_TIN_ZMAX = 7025;
  public const int LC_PROP_TIN_DX = 7026;
  public const int LC_PROP_TIN_DY = 7027;
  public const int LC_PROP_TIN_DZ = 7028;
  public const int LC_PROP_TIN_ISOBASE = 7031;
  public const int LC_PROP_TIN_ISOSTEP = 7032;
  public const int LC_PROP_TIN_ISOBOLD = 7033;
  public const int LC_PROP_TIN_ISOSPLINE = 7034;
  public const int LC_PROP_TIN_IMG_ZSTEP = 7041;
  public const int LC_PROP_TIN_IMG_PSIZE = 7043;
  public const int LC_PROP_TIN_IMG_NX = 7044;
  public const int LC_PROP_TIN_IMG_NY = 7045;
  public const int LC_PROP_TIN_VIEWPT = 7051;
  public const int LC_PROP_TIN_VIEWPTN = 7052;
  public const int LC_PROP_TIN_VIEWPTI = 7053;
  public const int LC_PROP_TIN_VIEWPTZ = 7054;
  public const int LC_PROP_TIN_VIEWTR = 7055;
  public const int LC_PROP_TIN_VIEWCF = 7056;
  public const int LC_PROP_TIN_VIEWTRI = 7058;
  public const int LC_PROP_TIN_VIEWTRV = 7059;
  public const int LC_PROP_TIN_VIEWBND = 7060;
  public const int LC_PROP_TIN_VIEWBNDI = 7061;
  public const int LC_PROP_TIN_VIEWISO = 7062;
  public const int LC_PROP_TIN_VIEWISOH = 7063;
  public const int LC_PROP_TIN_VIEWZ = 7065;
  public const int LC_PROP_VIEWTINTILES = 7066;
  public const int LC_PROP_VIEWTINCFIR = 7067;
  public const int LC_PROP_TIN_COLTR = 7071;
  public const int LC_PROP_TIN_COLTRI = 7072;
  public const int LC_PROP_TIN_COLTRV = 7073;
  public const int LC_PROP_TIN_COLISO = 7074;
  public const int LC_PROP_TIN_COLISOB = 7075;
  public const int LC_PROP_TIN_COLISOW = 7076;
  public const int LC_PROP_TIN_COLBND = 7077;
  public const int LC_PROP_TIN_COLBNDP = 7078;
  public const int LC_PROP_TIN_COLTRF = 7079;
  public const int LC_PROP_TIN_COLFRONT0 = 7080;
  public const int LC_PROP_TIN_COLFRONT = 7081;
  public const int LC_PROP_TIN_LX_PRJNAME = 7091;
  public const int LC_PROP_TIN_LX_APPNAME = 7092;
  public const int LC_PROP_TIN_LX_DESCR = 7093;
  public const int LC_PROP_TIN_LX_MANUF = 7094;
  public const int LC_PROP_TIN_LX_VER = 7095;
  public const int LC_PROP_TIN_LX_URL = 7096;
  public const int LC_PROP_TIN_LX_TIME = 7097;
  public const int LC_PROP_VER_X = 10001;
  public const int LC_PROP_VER_Y = 10002;
  public const int LC_PROP_VER_Z = 10003;
  public const int LC_PROP_VER_FIX = 10006;
  public const int LC_PROP_VER_RADIUS = 10007;
  public const int LC_PROP_VER_WEIGHT = 10008;
  public const int LC_PROP_VER_INDEX = 10009;
  public const int LC_PROP_VER_FIRST = 10010;
  public const int LC_PROP_VER_LAST = 10011;
  public const int LC_PROP_VER_W0 = 10012;
  public const int LC_PROP_VER_W1 = 10013;
  public const int LC_PROP_VER_SEGDX = 10014;
  public const int LC_PROP_VER_SEGDY = 10015;
  public const int LC_PROP_VER_SEGANG = 10016;
  public const int LC_PROP_VER_SEGLEN = 10017;
  public const int LC_PROP_VER_BULGE = 10021;
  public const int LC_PROP_VER_SEGARCANG = 10022;
  public const int LC_PROP_VER_SEGARCH = 10023;
  public const int LC_PROP_VER_SEGARCLEN = 10024;
  public const int LC_PROP_VER_SEGARCRAD = 10025;
  public const int LC_PROP_RPVER_X = 10041;
  public const int LC_PROP_RPVER_Y = 10042;
  public const int LC_PROP_RPVER_ANGLE = 10043;
  public const int LC_PROP_RPVER_DIRANG = 10044;
  public const int LC_PROP_RPVER_R = 10045;
  public const int LC_PROP_RPVER_L1 = 10046;
  public const int LC_PROP_RPVER_L2 = 10047;
  public const int LC_PROP_RPVER_ANGL1 = 10048;
  public const int LC_PROP_RPVER_ANGARC = 10049;
  public const int LC_PROP_RPVER_ANGL2 = 10050;
  public const int LC_PROP_RPVER_BISEC = 10051;
  public const int LC_PROP_RPVER_DOMER = 10052;
  public const int LC_PROP_RPVER_ARCLEN = 10053;
  public const int LC_PROP_RPVER_CURLEN = 10054;
  public const int LC_PROP_RPVER_LINE1 = 10055;
  public const int LC_PROP_RPVER_T1 = 10056;
  public const int LC_PROP_RPVER_T2 = 10057;
  public const int LC_PROP_RPVER_LINE2 = 10058;
  public const int LC_PROP_RPVER_DIST1 = 10059;
  public const int LC_PROP_RPVER_DIST2 = 10060;
  public const int LC_PROP_XDATA_BOOL = 10901;
  public const int LC_PROP_XDATA_INT = 10902;
  public const int LC_PROP_XDATA_FLOAT = 10903;
  public const int LC_PROP_XDATA_STR = 10907;
  public const int LC_PROP_CMDWND_ENABLE = 11001;
  public const int LC_PROP_PROPWND_ENABLE = 11002;
  public const int LC_PROP_PROPWND_DIVCOEF = 11003;
  public const int LC_PROP_EVENT_TYPE = 12001;
  public const int LC_PROP_EVENT_APPPRM1 = 12002;
  public const int LC_PROP_EVENT_APPPRM2 = 12003;
  public const int LC_PROP_EVENT_WND = 12004;
  public const int LC_PROP_EVENT_DRW = 12005;
  public const int LC_PROP_EVENT_BLOCK = 12006;
  public const int LC_PROP_EVENT_ENTITY = 12007;
  public const int LC_PROP_EVENT_ENT = 12007;
  public const int LC_PROP_EVENT_HCMD = 12008;
  public const int LC_PROP_EVENT_HOBJ = 12008;
  public const int LC_PROP_EVENT_HDC = 12009;
  public const int LC_PROP_EVENT_MODE = 12010;
  public const int LC_PROP_EVENT_INT1 = 12021;
  public const int LC_PROP_EVENT_INT2 = 12022;
  public const int LC_PROP_EVENT_INT3 = 12023;
  public const int LC_PROP_EVENT_INT4 = 12024;
  public const int LC_PROP_EVENT_INT5 = 12025;
  public const int LC_PROP_EVENT_INT6 = 12026;
  public const int LC_PROP_EVENT_FLOAT1 = 12031;
  public const int LC_PROP_EVENT_FLOAT2 = 12032;
  public const int LC_PROP_EVENT_FLOAT3 = 12033;
  public const int LC_PROP_EVENT_FLOAT4 = 12034;
  public const int LC_PROP_EVENT_FLOAT5 = 12035;
  public const int LC_PROP_EVENT_FLOAT6 = 12036;
  public const int LC_PROP_EVENT_STR1 = 12041;
  public const int LC_PROP_EVENT_STR2 = 12042;
  public const int LC_PROP_EVENT_STR3 = 12043;
  public const int LC_EVENT_HELP = 101;
  public const int LC_EVENT_PAINT = 102;
  public const int LC_EVENT_PAINTBG = 124;
  public const int LC_EVENT_WNDVIEW = 103;
  public const int LC_EVENT_MOUSEMOVE = 105;
  public const int LC_EVENT_LBDOWN = 106;
  public const int LC_EVENT_LBUP = 107;
  public const int LC_EVENT_LBDBLCLK = 108;
  public const int LC_EVENT_RBDOWN = 109;
  public const int LC_EVENT_RBUP = 110;
  public const int LC_EVENT_KEYDOWN = 111;
  public const int LC_EVENT_VIEWBLOCK = 112;
  public const int LC_EVENT_EXTENTS = 113;
  public const int LC_EVENT_SNAP = 114;
  public const int LC_EVENT_MAGNIFIER = 115;
  public const int LC_EVENT_NAVIGATOR = 116;
  public const int LC_EVENT_CMDINWND = 117;
  public const int LC_EVENT_GRID = 118;
  public const int LC_EVENT_OSNAP = 119;
  public const int LC_EVENT_PTRACK = 120;
  public const int LC_EVENT_ORTHO = 121;
  public const int LC_EVENT_FILETAB = 122;
  public const int LC_EVENT_WAITPOINT = 123;
  public const int LC_EVENT_FILE = 131;
  public const int LC_EVENT_ADDENTITY = 132;
  public const int LC_EVENT_WNDPROP = 133;
  public const int LC_EVENT_DRWPROP = 134;
  public const int LC_EVENT_ENTPROP = 135;
  public const int LC_EVENT_ENTMOVE = 136;
  public const int LC_EVENT_ENTSCALE = 137;
  public const int LC_EVENT_ENTROTATE = 138;
  public const int LC_EVENT_ENTMIRROR = 139;
  public const int LC_EVENT_ENTERASE = 140;
  public const int LC_EVENT_DRAWIMAGE = 141;
  public const int LC_EVENT_SELECT = 145;
  public const int LC_EVENT_PICKENT = 146;
  public const int LC_EVENT_ADDSTR = 147;
  public const int LC_EVENT_ADDCMD = 148;
  public const int LC_EVENT_CCMD = 149;
  public const int LC_EVENT_TIN = 150;
  public const int LC_EVENT_DRWFILEEXT = 151;
  public const int LC_EVENT_DRWPREVIEW = 152;
  public const int LC_EVENT_DRWLOAD = 153;
  public const int LC_EVENT_DRWSAVE = 154;
  public const int LC_EVENT_GRIPMOVE = 155;
  public const int LC_EVENT_GRIPDRAG = 156;
  public const int LC_EVENT_DIRTY = 157;
  public const int LC_EVENT_SELENT1 = 161;
  public const int LC_EVENT_SELENTS = 162;
  public const int LC_EVENT_GRIPPAINT = 165;
  public const int LC_EVENT_DRAWCURSOR = 166;
  public const int LC_EVENT_RULERCORNER = 167;
  public const int LC_EVENT_WNDTAB = 171;
  public const int LC_EVENT_CMD1 = 212;
  public const int LC_EVENT_LAYERS = 303;
  public const int LC_CCMD_CREATE = 1;
  public const int LC_CCMD_DESTROY = 2;
  public const int LC_CCMD_START = 3;
  public const int LC_CCMD_FINISH = 4;
  public const int LC_CCMD_LBDOWN = 5;
  public const int LC_CCMD_LBUP = 6;
  public const int LC_CCMD_RBDOWN = 7;
  public const int LC_CCMD_RBUP = 8;
  public const int LC_CCMD_MOUSEMOVE = 9;
  public const int LC_CCMD_PAINT = 10;
  public const int LC_CCMD_SNAP = 11;

  [DllImport("Litecad.dll", EntryPoint="lcEventSetProc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void EventSetProc(int EventType, F_LCEVENT pFunc, int Prm1, IntPtr Prm2);

  [DllImport("Litecad.dll", EntryPoint="lcEventReturnCode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void EventReturnCode(int code);

  [DllImport("Litecad.dll", EntryPoint="lcEventsEnable", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EventsEnable(bool b);

  [DllImport("Litecad.dll", EntryPoint="lcInitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Initialize();

  [DllImport("Litecad.dll", EntryPoint="lcUninitialize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Uninitialize(bool bSaveConfig);

  [DllImport("Litecad.dll", EntryPoint="lcStrAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrAdd(string szTag, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcStrSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrSet(string szTag, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcStrGet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string StrGet(string szTag);

  [DllImport("Litecad.dll", EntryPoint="lcStrFileLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrFileLoad(string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcStrFileSave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StrFileSave(string szFileName, string szLanguage);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetBool", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropGetBool(IntPtr hObject, int idProp);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetInt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetInt(IntPtr hObject, int idProp);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetFloat", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern double PropGetFloat(IntPtr hObject, int idProp);

  public static string PropGetStr(IntPtr hObject, int idProp)
  {
    int nChars, i, ch;
    char[] Buf;
    nChars = Lcad.PropGetStr2(hObject, idProp);
    if (nChars > 0)
    {
      Buf = new char[nChars];
      for (i=0; i<nChars; ++i)
      {
        ch = Lcad.PropGetChar(i);
        Buf[i] = Convert.ToChar(ch);
      }
      return new string(Buf);
    }
    return "";
  }

  [DllImport("Litecad.dll", EntryPoint="lcPropGetStrA", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetStrA(IntPtr hObject, int idProp, out IntPtr szBuf, int BufSize);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetStr2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetStr2(IntPtr hObject, int idProp);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetChar", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PropGetChar(int iChar);

  [DllImport("Litecad.dll", EntryPoint="lcPropGetHandle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PropGetHandle(IntPtr hObject, int idProp);

  [DllImport("Litecad.dll", EntryPoint="lcPropPutBool", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutBool(IntPtr hObject, int idProp, bool bValue);

  [DllImport("Litecad.dll", EntryPoint="lcPropPutInt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutInt(IntPtr hObject, int idProp, int Value);

  [DllImport("Litecad.dll", EntryPoint="lcPropPutFloat", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutFloat(IntPtr hObject, int idProp, double Value);

  [DllImport("Litecad.dll", EntryPoint="lcPropPutStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutStr(IntPtr hObject, int idProp, string szValue);

  [DllImport("Litecad.dll", EntryPoint="lcPropPutHandle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropPutHandle(IntPtr hObject, int idProp, IntPtr hValue);

  [DllImport("Litecad.dll", EntryPoint="lcCreateWindow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateWindow(IntPtr hWndParent, int Style);

  [DllImport("Litecad.dll", EntryPoint="lcDeleteWindow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteWindow(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndOnClose", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndOnClose(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndExeCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndExeCommand(IntPtr hLcWnd, int Command, int CmdParam);

  [DllImport("Litecad.dll", EntryPoint="lcWndExitCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndExitCommand(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndResize(IntPtr hLcWnd, int Left, int Top, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcWndRedraw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndRedraw(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndRedrawAuto", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndRedrawAuto(IntPtr hLcWnd, int Elapse, F_REDRAW pFunc);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetFocus", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetFocus(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetExtents", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetExtents(IntPtr hLcWnd, double Xmin, double Ymin, double Xmax, double Ymax);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetBlock(IntPtr hLcWnd, IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetProps", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetProps(IntPtr hLcWnd, IntPtr hPropWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetCmdwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetCmdwin(IntPtr hLcWnd, IntPtr hCmdLine);

  [DllImport("Litecad.dll", EntryPoint="lcWndSetBasePoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndSetBasePoint(IntPtr hLcWnd, bool bState, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcWndEmulator", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndEmulator(IntPtr hLcWnd, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcWndMagnifier", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndMagnifier(IntPtr hLcWnd, bool bOn, int Width, int Height, int Zoom, int Flags);

  [DllImport("Litecad.dll", EntryPoint="lcWndHoverText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndHoverText(IntPtr hLcWnd, string szText, int X, int Y, int Align);

  [DllImport("Litecad.dll", EntryPoint="lcWndMessage", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int WndMessage(IntPtr hLcWnd, string szText, int uType);

  [DllImport("Litecad.dll", EntryPoint="lcWndWaitPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndWaitPoint(IntPtr hLcWnd, string szText, out double pXdrw, out double pYdrw);

  [DllImport("Litecad.dll", EntryPoint="lcWndWaitPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndWaitPoint2(IntPtr hLcWnd, string szText, out double pXdrw, out double pYdrw, F_WAITPOINT pFunc, int FuncPrm);

  [DllImport("Litecad.dll", EntryPoint="lcWndInputStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndInputStr(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndUpdate(IntPtr hLcWnd, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcWndDrwAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndDrwAdd(IntPtr hLcWnd, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcWndDrwDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndDrwDelete(IntPtr hLcWnd, IntPtr hLcDrw);

  [DllImport("Litecad.dll", EntryPoint="lcWndDrwGet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndDrwGet(IntPtr hLcWnd, int Index);

  [DllImport("Litecad.dll", EntryPoint="lcWndZoomRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomRect(IntPtr hLcWnd, double Left, double Bottom, double Right, double Top);

  [DllImport("Litecad.dll", EntryPoint="lcWndZoomScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomScale(IntPtr hLcWnd, double Scal);

  [DllImport("Litecad.dll", EntryPoint="lcWndZoomMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomMove(IntPtr hLcWnd, double DX, double DY);

  [DllImport("Litecad.dll", EntryPoint="lcWndZoomPos", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomPos(IntPtr hLcWnd, double Xc, double Yc, double PixSize);

  [DllImport("Litecad.dll", EntryPoint="lcWndZoomEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndZoomEnt(IntPtr hLcWnd, IntPtr hEnt, double Scal);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetCursorCoord", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndGetCursorCoord(IntPtr hLcWnd, out int pXwin, out int pYwin, out double pXdrw, out double pYdrw);

  [DllImport("Litecad.dll", EntryPoint="lcCoordDrwToWnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CoordDrwToWnd(IntPtr hLcWnd, double Xdrw, double Ydrw, out int pXwnd, out int pYwnd);

  [DllImport("Litecad.dll", EntryPoint="lcCoordWndToDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CoordWndToDrw(IntPtr hLcWnd, int Xwnd, int Ywnd, out double pXdrw, out double pYdrw);

  [DllImport("Litecad.dll", EntryPoint="lcWndCoordFromDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndCoordFromDrw(IntPtr hLcWnd, double Xdrw, double Ydrw, out int pXwin, out int pYwin);

  [DllImport("Litecad.dll", EntryPoint="lcWndCoordToDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndCoordToDrw(IntPtr hLcWnd, int Xwin, int Ywin, out double pXdrw, out double pYdrw);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntByPoint(IntPtr hLcWnd, int Xwin, int Ywin);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntByPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntByPoint2(IntPtr hLcWnd, double X, double Y, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntsByPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int WndGetEntsByPoint(IntPtr hLcWnd, int Xwin, int Ywin, int nMaxEnts);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntsByRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int WndGetEntsByRect(IntPtr hLcWnd, double Lef, double Bot, double Rig, double Top, bool bCross, int nMaxEnts);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntity", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntity(int iEnt);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntByID(IntPtr hLcWnd, int Id);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntByIDH(IntPtr hLcWnd, string szId);

  [DllImport("Litecad.dll", EntryPoint="lcWndGetEntByKey", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr WndGetEntByKey(IntPtr hLcWnd, int Key);

  [DllImport("Litecad.dll", EntryPoint="lcWndPickEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int WndPickEnt(IntPtr hLcWnd, string szTitle, string szCursorText);

  [DllImport("Litecad.dll", EntryPoint="lcFontGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontGetFirst();

  [DllImport("Litecad.dll", EntryPoint="lcFontGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontGetNext(IntPtr hFont);

  [DllImport("Litecad.dll", EntryPoint="lcFontAddRes", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontAddRes(string szFontName, IntPtr hModule, int idResource);

  [DllImport("Litecad.dll", EntryPoint="lcFontAddFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontAddFile(string szFontName, string szFilename, out IntPtr szOutFontName);

  [DllImport("Litecad.dll", EntryPoint="lcFontAddBin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontAddBin(string szFontName, IntPtr hData);

  [DllImport("Litecad.dll", EntryPoint="lcFontGetChar", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr FontGetChar(IntPtr hFont, int CharCode);

  [DllImport("Litecad.dll", EntryPoint="lcFontGetName", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string FontGetName(string szFilename);

  [DllImport("Litecad.dll", EntryPoint="lcProgressCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressCreate(IntPtr hLcWnd, int W, int H, string szTitle);

  [DllImport("Litecad.dll", EntryPoint="lcProgressSetText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressSetText(string szText);

  [DllImport("Litecad.dll", EntryPoint="lcProgressStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressStart(int MinVal, int MaxVal);

  [DllImport("Litecad.dll", EntryPoint="lcProgressSetPos", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressSetPos(int Val);

  [DllImport("Litecad.dll", EntryPoint="lcProgressInc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressInc();

  [DllImport("Litecad.dll", EntryPoint="lcProgressDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ProgressDelete();

  [DllImport("Litecad.dll", EntryPoint="lcQuadCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr QuadCreate();

  [DllImport("Litecad.dll", EntryPoint="lcQuadDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool QuadDelete(IntPtr hQuad);

  [DllImport("Litecad.dll", EntryPoint="lcQuadSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool QuadSet(IntPtr hQuad, double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3);

  [DllImport("Litecad.dll", EntryPoint="lcQuadTransXYtoUV", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool QuadTransXYtoUV(IntPtr hQuad, double X, double Y, out double pU, out double pV);

  [DllImport("Litecad.dll", EntryPoint="lcQuadTransUVtoXY", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool QuadTransUVtoXY(IntPtr hQuad, double U, double V, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcQuadContains", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool QuadContains(IntPtr hQuad, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcGridCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr GridCreate();

  [DllImport("Litecad.dll", EntryPoint="lcGridDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridDelete(IntPtr hGrid);

  [DllImport("Litecad.dll", EntryPoint="lcGridSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridSet(IntPtr hGrid, double X0, double Y0, double W, double H, int Nx, int Ny);

  [DllImport("Litecad.dll", EntryPoint="lcGridSetDest", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridSetDest(IntPtr hGrid, int Ix, int Iy, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcGridUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridUpdate(IntPtr hGrid);

  [DllImport("Litecad.dll", EntryPoint="lcGridTrans", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridTrans(IntPtr hGrid, double X, double Y, out double pXdest, out double pYdest);

  [DllImport("Litecad.dll", EntryPoint="lcGridGetNode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridGetNode(IntPtr hGrid, bool bDest, int Ix, int Iy, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcGridGetCell", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridGetCell(IntPtr hGrid, double X, double Y, out int pIx, out int pIy);

  [DllImport("Litecad.dll", EntryPoint="lcGridSetView", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GridSetView(IntPtr hGrid, int Mode, IntPtr hLcWnd, int ColLine, int ColNode);

  [DllImport("Litecad.dll", EntryPoint="lcCreateCmdwin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateCmdwin(IntPtr hWndParent, int Left, int Top, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcCmdwinResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdwinResize(IntPtr hCmdLine, int Left, int Top, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcCmdwinUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdwinUpdate(IntPtr hCmdLine);

  [DllImport("Litecad.dll", EntryPoint="lcCreateProps", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateProps(IntPtr hWndParent, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcDeleteProps", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteProps(IntPtr hPropWnd);

  [DllImport("Litecad.dll", EntryPoint="lcPropsResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropsResize(IntPtr hPropWnd, int Left, int Top, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcPropsUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PropsUpdate(IntPtr hPropWnd, bool bSelChanged);

  [DllImport("Litecad.dll", EntryPoint="lcCreateStatbar", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateStatbar(IntPtr hWndParent);

  [DllImport("Litecad.dll", EntryPoint="lcDeleteStatbar", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteStatbar(IntPtr hStatbar);

  [DllImport("Litecad.dll", EntryPoint="lcStatbarResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StatbarResize(IntPtr hStatbar, int Left, int Top, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcStatbarCell", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StatbarCell(IntPtr hStatbar, int Id, int Pos);

  [DllImport("Litecad.dll", EntryPoint="lcStatbarText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StatbarText(IntPtr hStatbar, int Id, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcStatbarRedraw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool StatbarRedraw(IntPtr hStatbar);

  [DllImport("Litecad.dll", EntryPoint="lcDgGetValue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DgGetValue(IntPtr hWnd, int Lef, int Top, string szTitle, string szPrompt);

  [DllImport("Litecad.dll", EntryPoint="lcHelp", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Help(string szTopic);

  [DllImport("Litecad.dll", EntryPoint="lcGetPolarPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void GetPolarPoint(double x0, double y0, double Angle, double Dist, out double pOutX, out double pOutY);

  [DllImport("Litecad.dll", EntryPoint="lcGetPolarPrm", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void GetPolarPrm(double x1, double y1, double x2, double y2, out double pAngle, out double pDist);

  [DllImport("Litecad.dll", EntryPoint="lcGetClientSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GetClientSize(IntPtr hWnd, out int pWidth, out int pHeight);

  [DllImport("Litecad.dll", EntryPoint="lcGetErrorCode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int GetErrorCode();

  [DllImport("Litecad.dll", EntryPoint="lcGetErrorStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string GetErrorStr();

  [DllImport("Litecad.dll", EntryPoint="lcGetStr", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GetStr(int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcGetDrwXData", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GetDrwXData(string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcGetDrwPreview", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int GetDrwPreview(string szFileName, out IntPtr pOutDIB);

  [DllImport("Litecad.dll", EntryPoint="lcFilletSetLines", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool FilletSetLines(double L1x0, double L1y0, double L1x1, double L1y1, double L2x0, double L2y0, double L2x1, double L2y1);

  [DllImport("Litecad.dll", EntryPoint="lcFillet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Fillet(double Rad, double Bis, double Tang);

  [DllImport("Litecad.dll", EntryPoint="lcFilletGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool FilletGetPoint(int iPnt, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcFileToStrA", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int FileToStrA(string szFileName, out IntPtr pBuf);

  [DllImport("Litecad.dll", EntryPoint="lcCreateCommand", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateCommand(IntPtr hLcWnd, int Id, string szTitle);

  [DllImport("Litecad.dll", EntryPoint="lcCmdExit", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdExit(IntPtr hCmd);

  [DllImport("Litecad.dll", EntryPoint="lcCmdCursorText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdCursorText(IntPtr hCmd, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcCmdMessage", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CmdMessage(IntPtr hCmd, string szText, int uType);

  [DllImport("Litecad.dll", EntryPoint="lcCmdResetLastPt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CmdResetLastPt(IntPtr hCmd);

  [DllImport("Litecad.dll", EntryPoint="lcTIS_InitLibrary", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIS_InitLibrary(string szLicenseKey, bool bErrMsg);

  [DllImport("Litecad.dll", EntryPoint="lcTIS_CloseLibrary", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIS_CloseLibrary();

  [DllImport("Litecad.dll", EntryPoint="lcCameraConnect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CameraConnect(string szName);

  [DllImport("Litecad.dll", EntryPoint="lcCameraDisconnect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CameraDisconnect();

  [DllImport("Litecad.dll", EntryPoint="lcCameraShot", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CameraShot();

  [DllImport("Litecad.dll", EntryPoint="lcCreateDrawing", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CreateDrawing();

  [DllImport("Litecad.dll", EntryPoint="lcDeleteDrawing", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DeleteDrawing(IntPtr hDrw);

  [DllImport("Litecad.dll", EntryPoint="lcDrwNew", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwNew(IntPtr hDrw, string szFileName, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwLoad(IntPtr hDrw, string szFileName, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwLoadMem", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwLoadMem(IntPtr hDrw, IntPtr hMem, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDxfLoadMem", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DxfLoadMem(IntPtr hDrw, IntPtr hMem, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwLoadTIN", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwLoadTIN(IntPtr hDrw, string szFileName, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwSaveTIN", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSaveTIN(IntPtr hDrw, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwInsert", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwInsert(IntPtr hDrw, string szFileName, int Overwrite, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwInsertSHP", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwInsertSHP(IntPtr hDrw, IntPtr hLayer, string szFileName, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwCopy", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwCopy(IntPtr hDrw, IntPtr hDrwSrc);

  [DllImport("Litecad.dll", EntryPoint="lcDrwSave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSave(IntPtr hDrw, string szFileName, bool bBak, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcDrwSaveMem", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwSaveMem(IntPtr hDrw, IntPtr hMem, int MemSize);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddLayer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddLayer(IntPtr hDrw, string szName, string szColor, IntPtr hLtype, int Lwidth);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddLayer2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddLayer2(IntPtr hDrw, string szName, IntPtr hFromLayer);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddLinetype", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddLinetype(IntPtr hDrw, string szName, string szDefinition);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddLinetypeF", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddLinetypeF(IntPtr hDrw, string szName, string szFileName, string szLtypeName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddTextStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddTextStyle(IntPtr hDrw, string szName, string szFontName, bool bWinFont);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddDimStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddDimStyle(IntPtr hDrw, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddMlineStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddMlineStyle(IntPtr hDrw, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddPntStyle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddPntStyle(IntPtr hDrw, string szName, IntPtr hBlock, double BlockScale, IntPtr hTStyle, double TextHeight, double TextWidth);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddFilling", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddFilling(IntPtr hDrw, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddImage", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddImage(IntPtr hDrw, string szName, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddImage2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddImage2(IntPtr hDrw, string szName, int Width, int Height, int nBits, IntPtr hData, bool bTopDown);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddImage3", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddImage3(IntPtr hDrw, string szName, IntPtr hMem);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddImageCam", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddImageCam(IntPtr hDrw, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlock(IntPtr hDrw, string szName, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlockFromFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlockFromFile(IntPtr hDrw, string szName, string szFileName, int Overwrite, IntPtr hwParent);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlockFromDrw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlockFromDrw(IntPtr hDrw, string szName, IntPtr hDrw2, int Overwrite, IntPtr hwParent);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlockFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlockFile(IntPtr hDrw, string szName, string szFileName, int Overwrite, IntPtr hwParent);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlockPaper", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlockPaper(IntPtr hDrw, string szName, int PaperSize, int Orient, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcDrwAddBlockCopy", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwAddBlockCopy(IntPtr hDrw, string szName, IntPtr hSrcBlock);

  [DllImport("Litecad.dll", EntryPoint="lcDrwDeleteObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwDeleteObject(IntPtr hDrw, IntPtr hObject);

  [DllImport("Litecad.dll", EntryPoint="lcDrwDeleteUnused", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwDeleteUnused(IntPtr hDrw, int ObjType);

  [DllImport("Litecad.dll", EntryPoint="lcDrwCountObjects", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int DrwCountObjects(IntPtr hDrw, int ObjType);

  [DllImport("Litecad.dll", EntryPoint="lcDrwSortObjects", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSortObjects(IntPtr hDrw, int ObjType);

  [DllImport("Litecad.dll", EntryPoint="lcDrwUpdateWinFonts", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwUpdateWinFonts(IntPtr hDrw, IntPtr hTStyle);

  [DllImport("Litecad.dll", EntryPoint="lcDrwUpdateBlkRefs", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwUpdateBlkRefs(IntPtr hDrw, IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcDrwUpdateTexts", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwUpdateTexts(IntPtr hDrw, IntPtr hTStyle);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetFirstObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetFirstObject(IntPtr hDrw, int ObjType);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetNextObject", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetNextObject(IntPtr hDrw, IntPtr hObject);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetObjectByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetObjectByID(IntPtr hDrw, int ObjType, int Id);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetObjectByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetObjectByIDH(IntPtr hDrw, int ObjType, string szId);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetObjectByName", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetObjectByName(IntPtr hDrw, int ObjType, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetEntByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetEntByID(IntPtr hDrw, int Id);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetEntByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetEntByIDH(IntPtr hDrw, string szId);

  [DllImport("Litecad.dll", EntryPoint="lcDrwGetEntByKey", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr DrwGetEntByKey(IntPtr hDrw, int Key);

  [DllImport("Litecad.dll", EntryPoint="lcDrwClearXData", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwClearXData(IntPtr hDrw, int ObjType, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcDrwPurge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwPurge(IntPtr hDrw);

  [DllImport("Litecad.dll", EntryPoint="lcDrwExplode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwExplode(IntPtr hDrw, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcDrwSetLimits", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwSetLimits(IntPtr hDrw, double Xmin, double Ymin, double Xmax, double Ymax);

  [DllImport("Litecad.dll", EntryPoint="lcDrwUndoRecord", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwUndoRecord(IntPtr hDrw, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcDrwUndo", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool DrwUndo(IntPtr hDrw, bool bRedo);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsClear(IntPtr hDrw);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsAdd(IntPtr hDrw, int ID, double Lef, double Bot, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsDivide", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int CRectsDivide(IntPtr hDrw, int NumX, int NumY, bool bClearExist);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CRectsGetFirst(IntPtr hDrw);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CRectsGetNext(IntPtr hDrw, IntPtr hCRect);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsGetWithID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CRectsGetWithID(IntPtr hDrw, int Id);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsActive", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsActive(IntPtr hDrw, IntPtr hCRect);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsGetActive", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr CRectsGetActive(IntPtr hDrw);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsDelete(IntPtr hDrw, IntPtr hCRect);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsSave", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsSave(IntPtr hDrw, IntPtr hCRect, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcCRectsBitmap", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool CRectsBitmap(IntPtr hDrw, IntPtr hCRect, string szFileName, double PixelSize);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSetViewRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSetViewRect(IntPtr hBlock, double Xcen, double Ycen, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSetViewRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSetViewRect2(IntPtr hBlock, double Lef, double Bot, double Rig, double Top);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSetPaperSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSetPaperSize(IntPtr hBlock, int PaperSize, int Orient, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcBlockRasterize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockRasterize(IntPtr hBlock, string szFileName, double Xmin, double Ymin, double Xmax, double Ymax, int ImgW, int ImgH);

  [DllImport("Litecad.dll", EntryPoint="lcBlockRasterizeMem", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockRasterizeMem(IntPtr hBlock, IntPtr hMem, double Xmin, double Ymin, double Xmax, double Ymax, int ImgW, int ImgH);

  [DllImport("Litecad.dll", EntryPoint="lcBlockUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockUpdate(IntPtr hBlock, bool bUpdEnts, IntPtr hNewEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockMove(IntPtr hBlock, double dX, double dY, bool bUpdate);

  [DllImport("Litecad.dll", EntryPoint="lcBlockScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockScale(IntPtr hBlock, double X, double Y, double Scal, bool bUpdate);

  [DllImport("Litecad.dll", EntryPoint="lcBlockRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockRotate(IntPtr hBlock, double X, double Y, double Angle, bool bUpdate);

  [DllImport("Litecad.dll", EntryPoint="lcBlockMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockMirror(IntPtr hBlock, double X1, double Y1, double X2, double Y2, bool bUpdate);

  [DllImport("Litecad.dll", EntryPoint="lcBlockClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockClear(IntPtr hBlock, IntPtr hLayer);

  [DllImport("Litecad.dll", EntryPoint="lcBlockPurge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockPurge(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSortEnts", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSortEnts(IntPtr hBlock, bool bByLayers, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSortEnts2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSortEnts2(IntPtr hBlock, IntPtr idEnts, int nEnts);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddPoint(IntPtr hBlock, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddPoint2(IntPtr hBlock, double X, double Y, int PtMode, double PtSize);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddPoint3d", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddPoint3d(IntPtr hBlock, double X, double Y, double Z);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddPointsF", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockAddPointsF(IntPtr hBlock, string szFileName, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddXline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddXline(IntPtr hBlock, double X, double Y, double Angle, bool bRay);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddXline2P", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddXline2P(IntPtr hBlock, double X, double Y, double X2, double Y2, bool bRay);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddLine(IntPtr hBlock, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddLineDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddLineDir(IntPtr hBlock, double X, double Y, double Angle, double Dist);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddLineTan", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddLineTan(IntPtr hBlock, IntPtr hEnt1, IntPtr hEnt2, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddPolyline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddPolyline(IntPtr hBlock, int FitType, bool bClosed, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddRPolygon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddRPolygon(IntPtr hBlock, int nVers, double Xc, double Yc, double R, double Ang0, bool bInscribed, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddSpline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddSpline(IntPtr hBlock, bool bClosed, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddBezier", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddBezier(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddMline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddMline(IntPtr hBlock, int FitType, bool bClosed);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddRect(IntPtr hBlock, double Xc, double Yc, double Width, double Height, double Angle, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddRect2(IntPtr hBlock, double Left, double Bottom, double Width, double Height, double Rad, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddCircle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddCircle(IntPtr hBlock, double X, double Y, double Radius, bool bFilled);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddArc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddArc(IntPtr hBlock, double X, double Y, double Radius, double StartAngle, double ArcAngle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddArc3P", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddArc3P(IntPtr hBlock, double X1, double Y1, double X2, double Y2, double X3, double Y3);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddFillet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddFillet(IntPtr hBlock, IntPtr hEnt1, IntPtr hEnt2, double Radius);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddEllipse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddEllipse(IntPtr hBlock, double X, double Y, double R1, double R2, double RotAngle, double StartAngle, double ArcAngle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddText(IntPtr hBlock, string szText, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddText2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddText2(IntPtr hBlock, string szText, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddText3", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddText3(IntPtr hBlock, string szText, double X1, double Y1, double X2, double Y2, int Align, double HW, double Oblique);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddTextWin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddTextWin(IntPtr hBlock, string szText, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddTextWin2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddTextWin2(IntPtr hBlock, string szText, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddMText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddMText(IntPtr hBlock, string szText, double X, double Y, double WrapWidth, int Align, double RotAngle, double H, double WScale);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddArcText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddArcText(IntPtr hBlock, string szText, double X, double Y, double Radius, double StartAngle, bool bClockwise, double H, double WScale, int Align);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddBlockRef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddBlockRef(IntPtr hBlock, IntPtr hRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddBlockRefID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddBlockRefID(IntPtr hBlock, int idRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddBlockRefIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddBlockRefIDH(IntPtr hBlock, string szIdRefBlock, double X, double Y, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddAttDef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddAttDef(IntPtr hBlock, int Mode, string szTag, string szPrompt, string szDefVal, double X, double Y, int Align, double H, double WScale, double RotAngle, double Oblique);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddXref", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddXref(IntPtr hBlock, string szFileName, double X, double Y, double ScalX, double ScalY, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddImageRef", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddImageRef(IntPtr hBlock, IntPtr hImage, double X, double Y, double Width, double Height, bool bBorder);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddImageRefUns", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddImageRefUns(IntPtr hBlock, IntPtr hImage, double X, double Y, double Scal, int Align, bool bBorder);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddImagePlace", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddImagePlace(IntPtr hBlock, int Id, double X, double Y, double Width, double Height, bool bBorder);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddEcw", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddEcw(IntPtr hBlock, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddBarcode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddBarcode(IntPtr hBlock, int BarType, double Xc, double Yc, double Width, double Height, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddHatch", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddHatch(IntPtr hBlock, string szFileName, string szPatName, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddViewport", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddViewport(IntPtr hBlock, double Lef, double Bot, double Width, double Height, double DrwPntX, double DrwPntY, double DrwScale, double DrwAngle);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddFace", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddFace(IntPtr hBlock, int Flags, double x0, double y0, double z0, double x1, double y1, double z1, double x2, double y2, double z2);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddFace4", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddFace4(IntPtr hBlock, int Flags, double x0, double y0, double z0, double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddLeader", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddLeader(IntPtr hBlock, string szText, double Xt, double Yt, double LandDist, double Xa, double Ya, int Attach, int Align);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimLin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimLin(IntPtr hBlock, double X0, double Y0, double X1, double Y1, double Xt, double Yt, double Angle, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimHor", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimHor(IntPtr hBlock, double X0, double Y0, double X1, double Y1, double Yt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimVer(IntPtr hBlock, double X0, double Y0, double X1, double Y1, double Xt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimAli", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimAli(IntPtr hBlock, double X0, double Y0, double X1, double Y1, double Xt, double Yt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimAli2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimAli2(IntPtr hBlock, double X0, double Y0, double X1, double Y1, double Dt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimOrd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimOrd(IntPtr hBlock, double Xd, double Yd, double Xt, double Yt, bool bX, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimRad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimRad(IntPtr hBlock, double Xc, double Yc, double Xr, double Yr, double Xt, double Yt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimRad2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimRad2(IntPtr hBlock, double Xc, double Yc, double R, double Angle, double TextOff, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimDia", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimDia(IntPtr hBlock, double Xc, double Yc, double Xr, double Yr, double Xt, double Yt, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimDia2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimDia2(IntPtr hBlock, double Xc, double Yc, double R, double Angle, double TextOff, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimAng", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimAng(IntPtr hBlock, double Xc, double Yc, double X1, double Y1, double X2, double Y2, double Xa, double Ya, double TextPos, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddDimAng2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddDimAng2(IntPtr hBlock, double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4, double Xa, double Ya, double TextPos, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddRPlan", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddRPlan(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddRPlan2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddRPlan2(IntPtr hBlock, IntPtr hStartEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddArrow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddArrow(IntPtr hBlock, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddSpiral", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddSpiral(IntPtr hBlock, double Xc, double Yc, double R, double Turns, bool bDirCW, bool bClosed);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddCamview", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddCamview(IntPtr hBlock, double Lef, double Bot, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddTIN", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddTIN(IntPtr hBlock, string szFileName, int FileType);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddClone", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddClone(IntPtr hBlock, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockBeginShape", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockBeginShape(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddShape", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddShape(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockAddShapeSel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockAddShapeSel(IntPtr hBlock, bool bErase);

  [DllImport("Litecad.dll", EntryPoint="lcBlockRepEllipse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockRepEllipse(IntPtr hBlock, IntPtr hEll, out int pRetType);

  [DllImport("Litecad.dll", EntryPoint="lcBlockJoinAll", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockJoinAll(IntPtr hBlock, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcBlockCopyLayer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int BlockCopyLayer(IntPtr hBlock, IntPtr hLayerSrc, IntPtr hLayerDest);

  [DllImport("Litecad.dll", EntryPoint="lcBlockDeleteEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockDeleteEnt(IntPtr hBlock, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetFirstEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetFirstEnt(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetNextEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetNextEnt(IntPtr hBlock, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetLastEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetLastEnt(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetPrevEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetPrevEnt(IntPtr hBlock, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetEntByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetEntByID(IntPtr hBlock, int Id);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetEntByIDH", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetEntByIDH(IntPtr hBlock, string szId);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetEntByKey", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetEntByKey(IntPtr hBlock, int Key);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetBlkRefByTag", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetBlkRefByTag(IntPtr hBlock, IntPtr hBlockAtt, string szTag, string szValue, bool bSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetTIN", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetTIN(IntPtr hBlock, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcBlockUnselect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockUnselect(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelectEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelectEnt(IntPtr hBlock, IntPtr hEntity, bool bSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelErase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelErase(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelMove(IntPtr hBlock, double dX, double dY, bool bCopy, bool bNewSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelScale(IntPtr hBlock, double X0, double Y0, double Scal, bool bCopy, bool bNewSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelRotate(IntPtr hBlock, double X0, double Y0, double Angle, bool bCopy, bool bNewSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelMirror(IntPtr hBlock, double X1, double Y1, double X2, double Y2, bool bCopy, bool bNewSelect);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelExplode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelExplode(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelSplit", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelSplit(IntPtr hBlock, int nParts);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelJoin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockSelJoin(IntPtr hBlock, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelAlign", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSelAlign(IntPtr hBlock, int Mode, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSelBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockSelBlock(IntPtr hBlock, string szName, double X, double Y, int Mode, bool bOverwrite);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetFirstSel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetFirstSel(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetNextSel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlockGetNextSel(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcBlockOrderByLayers", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockOrderByLayers(IntPtr hBlock, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcBlockSortTSP", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlockSortTSP(IntPtr hBlock, IntPtr hLayer, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcBlockGetJumpsLen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern double BlockGetJumpsLen(IntPtr hBlock, IntPtr hLayer, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcLayerClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool LayerClear(IntPtr hLayer, IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcLayerCopyProps", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool LayerCopyProps(IntPtr hLayer, IntPtr hFromLayer);

  [DllImport("Litecad.dll", EntryPoint="lcFillSetLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool FillSetLine(IntPtr hFill, int iLine, double Dist, double Angle, double W);

  [DllImport("Litecad.dll", EntryPoint="lcMLStyleAddLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool MLStyleAddLine(IntPtr hStyle, double Offset, string szColor, IntPtr hLtype);

  [DllImport("Litecad.dll", EntryPoint="lcMLStyleDelLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool MLStyleDelLine(IntPtr hStyle, int iLine);

  [DllImport("Litecad.dll", EntryPoint="lcMLStyleSortLines", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool MLStyleSortLines(IntPtr hStyle);

  [DllImport("Litecad.dll", EntryPoint="lcEntType", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntType(IntPtr hEnt, int Typ);

  [DllImport("Litecad.dll", EntryPoint="lcEntErase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntErase(IntPtr hEnt, bool bErase);

  [DllImport("Litecad.dll", EntryPoint="lcEntMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntMove(IntPtr hEnt, double dX, double dY);

  [DllImport("Litecad.dll", EntryPoint="lcEntAlign", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntAlign(IntPtr hEnt, int Alignment, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcEntScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntScale(IntPtr hEnt, double X0, double Y0, double Scal);

  [DllImport("Litecad.dll", EntryPoint="lcEntRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntRotate(IntPtr hEnt, double X0, double Y0, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcEntMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntMirror(IntPtr hEnt, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcEntExplode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntExplode(IntPtr hEnt, bool bSelect, bool bErase);

  [DllImport("Litecad.dll", EntryPoint="lcEntSplit", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr EntSplit(IntPtr hEnt, int nParts, bool bSelectNew, bool bDeleteEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntBreak", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr EntBreak(IntPtr hEnt, double X, double Y, double Delta, bool bSelectNew, bool bDeleteEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntBreak2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr EntBreak2(IntPtr hEnt, IntPtr hPtbuf, double Delta, bool bSelectNew, bool bDeleteEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntOffset", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntOffset(IntPtr hEnt, double Dist);

  [DllImport("Litecad.dll", EntryPoint="lcEntExtend", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntExtend(IntPtr hEnt, IntPtr hEntEdge, bool bApparent);

  [DllImport("Litecad.dll", EntryPoint="lcEntToTop", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToTop(IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntToBottom", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToBottom(IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntToAbove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToAbove(IntPtr hEnt, IntPtr hEnt2);

  [DllImport("Litecad.dll", EntryPoint="lcEntToUnder", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntToUnder(IntPtr hEnt, IntPtr hEnt2);

  [DllImport("Litecad.dll", EntryPoint="lcEntGetGrip", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntGetGrip(IntPtr hEnt, int iGrip, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcEntPutGrip", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntPutGrip(IntPtr hEnt, int iGrip, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcEntUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntUpdate(IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntCopyBase", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntCopyBase(IntPtr hEnt, IntPtr hEntFrom);

  [DllImport("Litecad.dll", EntryPoint="lcEntXData", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntXData(IntPtr hEnt, int Id, int Flags, int nBytes);

  [DllImport("Litecad.dll", EntryPoint="lcEntContainEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntContainEnt(IntPtr hEnt, IntPtr hEnt2);

  [DllImport("Litecad.dll", EntryPoint="lcEntCrossEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntCrossEnt(IntPtr hEnt, IntPtr hEnt2);

  [DllImport("Litecad.dll", EntryPoint="lcEntReverse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntReverse(IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcEntGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntGetPoint(IntPtr hEnt, double Dist, out double pX, out double pY, out double pAngle);

  [DllImport("Litecad.dll", EntryPoint="lcEntGetDist", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern double EntGetDist(IntPtr hEnt, double X, double Y, out double pX2, out double pY2, out double pDist);

  [DllImport("Litecad.dll", EntryPoint="lcEntTransform", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool EntTransform(IntPtr hEnt, IntPtr hTransform);

  [DllImport("Litecad.dll", EntryPoint="lcIntersection", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int Intersection(IntPtr hEnt, IntPtr hEnt2, int Apparent);

  [DllImport("Litecad.dll", EntryPoint="lcInterGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool InterGetPoint(int iPoint, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcLineGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool LineGetPoint(IntPtr hLine, int Mode, double Dist, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcPlineAddVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineAddVer(IntPtr hPline, IntPtr hVer, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcPlineAddVer2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineAddVer2(IntPtr hPline, IntPtr hVer, double X, double Y, double Param, double W0, double W1);

  [DllImport("Litecad.dll", EntryPoint="lcPlineAddVerDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineAddVerDir(IntPtr hPline, IntPtr hVer, double Ang, double Length);

  [DllImport("Litecad.dll", EntryPoint="lcPlineEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineEnd(IntPtr hPline);

  [DllImport("Litecad.dll", EntryPoint="lcPlineFromPtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineFromPtbuf(IntPtr hPline, IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPlineFromMpgon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineFromMpgon(IntPtr hPline, IntPtr hMpgon);

  [DllImport("Litecad.dll", EntryPoint="lcPlineFromFile", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineFromFile(IntPtr hPline, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcPlineDeleteVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineDeleteVer(IntPtr hPline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcPlineDelExVers", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineDelExVers(IntPtr hPline, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetFirstVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetFirstVer(IntPtr hPline);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetNextVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetNextVer(IntPtr hPline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetLastVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetLastVer(IntPtr hPline);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetPrevVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetPrevVer(IntPtr hPline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetVer(IntPtr hPline, int Index);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetVerPt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetVerPt(IntPtr hPline, double X, double Y, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetSeg", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineGetSeg(IntPtr hPline, double X, double Y, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcPlineReverse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineReverse(IntPtr hPline);

  [DllImport("Litecad.dll", EntryPoint="lcPlineSetStartVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineSetStartVer(IntPtr hPline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcPlineContainPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineContainPoint(IntPtr hPline, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetRoundPrm", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineGetRoundPrm(IntPtr hPline, IntPtr hVer, out double pX0, out double pY0, out double pBulge, out double pX1, out double pY1);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineGetPoint(IntPtr hPline, double Dist, out double pX, out double pY, out double pAngle);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetPointOpp", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineGetPointOpp(IntPtr hPline, double Dist, out double pX, out double pY, out double pAngle, out double pX2, out double pY2);

  [DllImport("Litecad.dll", EntryPoint="lcPlineGetDist", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern double PlineGetDist(IntPtr hPline, double X, double Y, out double pX2, out double pY2, out double pDist);

  [DllImport("Litecad.dll", EntryPoint="lcPlineDivide", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineDivide(IntPtr hPline, int nPoints, bool bAngle);

  [DllImport("Litecad.dll", EntryPoint="lcPlineDivide2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PlineDivide2(IntPtr hPline, double Delta, bool bAngle);

  [DllImport("Litecad.dll", EntryPoint="lcGetDivPt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GetDivPt(int iPnt, out double pX, out double pY, out double pAngle);

  [DllImport("Litecad.dll", EntryPoint="lcPlineMakeArrow", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlineMakeArrow(IntPtr hPline, double Hline, double Harr);

  [DllImport("Litecad.dll", EntryPoint="lcPlineSplitBySI", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr PlineSplitBySI(IntPtr hPline, bool bSelect, bool bErase);

  [DllImport("Litecad.dll", EntryPoint="lcBezierAddVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BezierAddVer(IntPtr hBez, IntPtr hVer, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcBezierEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BezierEnd(IntPtr hBez);

  [DllImport("Litecad.dll", EntryPoint="lcBezierSetVerPrm", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BezierSetVerPrm(IntPtr hBez, IntPtr hVer, int Side, double Leng, double Ang);

  [DllImport("Litecad.dll", EntryPoint="lcMlineAddVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineAddVer(IntPtr hMline, IntPtr hVer, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcMlineAddVerDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineAddVerDir(IntPtr hMline, IntPtr hVer, double Ang, double Length);

  [DllImport("Litecad.dll", EntryPoint="lcMlineDeleteVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool MlineDeleteVer(IntPtr hMline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetFirstVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetFirstVer(IntPtr hMline);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetNextVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetNextVer(IntPtr hMline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetLastVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetLastVer(IntPtr hMline);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetPrevVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetPrevVer(IntPtr hMline, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetVer(IntPtr hMline, int Index);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetVerPt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetVerPt(IntPtr hMline, double X, double Y, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcMlineGetSeg", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr MlineGetSeg(IntPtr hMline, double X, double Y, double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcMlineReverse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool MlineReverse(IntPtr hMline);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanAddVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanAddVer(IntPtr hRPlan, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanSetCurve", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanSetCurve(IntPtr hVer, double Radius, double LenClot1, double LenClot2);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanSetPos", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanSetPos(IntPtr hVer, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanDeleteVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanDeleteVer(IntPtr hRPlan, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetFirstVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanGetFirstVer(IntPtr hRPlan);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetNextVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanGetNextVer(IntPtr hRPlan, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetLastVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanGetLastVer(IntPtr hRPlan);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetPrevVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanGetPrevVer(IntPtr hRPlan, IntPtr hVer);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetVer", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr RPlanGetVer(IntPtr hRPlan, int Index);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanGetPoint(IntPtr hRPlan, double Dist, out double pX, out double pY, out double pAngle, out int pSide);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanGetDist", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanGetDist(IntPtr hRPlan, double X, double Y, out double pX2, out double pY2, out double pDist, out double pOffset);

  [DllImport("Litecad.dll", EntryPoint="lcRPlanWriteCSV", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool RPlanWriteCSV(IntPtr hRPlan, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcXlinePutDir", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool XlinePutDir(IntPtr hXline, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcRectGetPolyline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int RectGetPolyline(IntPtr hRect, out double pX, out double pY, out double pBulge);

  [DllImport("Litecad.dll", EntryPoint="lcImgRefGetPixel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImgRefGetPixel(IntPtr hImgRef, int iX, int iY, out double pX, out double pY, out int pColor);

  [DllImport("Litecad.dll", EntryPoint="lcImgRefResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImgRefResize(IntPtr hImgRef, int NewWidth, int NewHeight, int Method);

  [DllImport("Litecad.dll", EntryPoint="lcHatchSetPattern", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchSetPattern(IntPtr hHatch, string szFileName, string szPatName, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcHatchBoundStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundStart(IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcHatchBoundPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundPoint(IntPtr hHatch, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcHatchBoundEntity", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundEntity(IntPtr hHatch, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcHatchBoundEndLoop", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundEndLoop(IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcHatchBoundEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchBoundEnd(IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcHatchPatStart", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatStart(IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcHatchPatLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatLine(IntPtr hHatch, double Angle, double x0, double y0, double dx, double dy, int nDash, double L0, double L1, double L2, double L3, double L4, double L5, double L6, double L7);

  [DllImport("Litecad.dll", EntryPoint="lcHatchPatEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchPatEnd(IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcHatchGetLoopSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int HatchGetLoopSize(IntPtr hHatch, int iLoop);

  [DllImport("Litecad.dll", EntryPoint="lcHatchGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool HatchGetPoint(IntPtr hHatch, int iPnt, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcHatchGetEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr HatchGetEnt(IntPtr hHatch, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcVportSetView", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportSetView(IntPtr hVport, double Xcen, double Ycen, double Scal, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcVportLayerDlg", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportLayerDlg(IntPtr hVport, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcVportLayerCmd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool VportLayerCmd(IntPtr hVport, int Cmd, IntPtr hLayer);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefAddAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlkRefAddAtt(IntPtr hBlockRef, string szTag, string szValue);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefGetFirstAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlkRefGetFirstAtt(IntPtr hBlockRef);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefGetNextAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlkRefGetNextAtt(IntPtr hBlockRef, IntPtr hAttrib);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefGetAtt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr BlkRefGetAtt(IntPtr hBlockRef, string szTag);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefGetAttVal", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string BlkRefGetAttVal(IntPtr hBlockRef, string szTag);

  [DllImport("Litecad.dll", EntryPoint="lcBlkRefPutAttVal", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool BlkRefPutAttVal(IntPtr hBlockRef, string szTag, string szValue);

  [DllImport("Litecad.dll", EntryPoint="lcShapeAddEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ShapeAddEnt(IntPtr hShape, IntPtr hEnt, bool bErase);

  [DllImport("Litecad.dll", EntryPoint="lcShapeEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ShapeEnd(IntPtr hShape);

  [DllImport("Litecad.dll", EntryPoint="lcShapeGetFirstEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr ShapeGetFirstEnt(IntPtr hShape);

  [DllImport("Litecad.dll", EntryPoint="lcShapeGetNextEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr ShapeGetNextEnt(IntPtr hShape, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcShapeGetLastEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr ShapeGetLastEnt(IntPtr hShape);

  [DllImport("Litecad.dll", EntryPoint="lcShapeGetPrevEnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr ShapeGetPrevEnt(IntPtr hShape, IntPtr hEnt);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_AddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_AddPoint(IntPtr hTIN, string szNamePtype, double X, double Y, double Z);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PtypeGetByName", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PtypeGetByName(IntPtr hTIN, string szName);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PtypeGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PtypeGetFirst(IntPtr hTIN);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PtypeGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PtypeGetNext(IntPtr hTIN, IntPtr hPtype);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PntGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PntGetFirst(IntPtr hTIN);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PntGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PntGetNext(IntPtr hTIN, IntPtr hPnt);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PntGetNear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_PntGetNear(IntPtr hTIN, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_PntDelDup", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int TIN_PntDelDup(IntPtr hTIN, double Delta, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_TriGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_TriGetFirst(IntPtr hTIN);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_TriGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_TriGetNext(IntPtr hTIN, IntPtr hTrian);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_TriGetByPos", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_TriGetByPos(IntPtr hTIN, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_TriGetEdge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_TriGetEdge(IntPtr hTIN, IntPtr hTrian, int iEdge);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_TriUpdate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int TIN_TriUpdate(IntPtr hTIN, IntPtr hPnt);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Bnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_Bnd(IntPtr hTIN, double MaxDist, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_BndGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_BndGetPoint(IntPtr hTIN, int iPnt);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Triangulate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_Triangulate(IntPtr hTIN, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Isolines", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int TIN_Isolines(IntPtr hTIN, double Zstep, int BoldStep, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_IsoGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_IsoGetFirst(IntPtr hTIN);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_IsoGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_IsoGetNext(IntPtr hTIN, IntPtr hIso);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_IsoMakeLabels", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int TIN_IsoMakeLabels(IntPtr hIso);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_GetIsoLabel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_GetIsoLabel(int iLabel, out double pX, out double pY, out double pAngle, out int pAlign);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_GetZ", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_GetZ(IntPtr hTIN, double X, double Y, out double pZ);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_ColorFill", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_ColorFill(IntPtr hTIN, double Zstep, double PixelSize, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Save", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_Save(IntPtr hTIN, string szFileName, int Mode, bool bByBndr, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_InterLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int TIN_InterLine(IntPtr hTIN, double X0, double Y0, double X1, double Y1);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_InterGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_InterGetPoint(IntPtr hTIN, int iPnt, out double pX, out double pY, out double pZ);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Clear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_Clear(IntPtr hTIN);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_AddTrian", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr TIN_AddTrian(IntPtr hTIN, int iPnt0, int iPnt1, int iPnt2);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_BndAddPnt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_BndAddPnt(IntPtr hTIN, int iPnt);

  [DllImport("Litecad.dll", EntryPoint="lcTIN_Merge", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool TIN_Merge(IntPtr hTIN, string szFileName, IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcColorRGB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorRGB(int Red, int Green, int Blue);

  [DllImport("Litecad.dll", EntryPoint="lcColorIsRGB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorIsRGB(string szColor);

  [DllImport("Litecad.dll", EntryPoint="lcColorGetRed", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetRed(string szColor);

  [DllImport("Litecad.dll", EntryPoint="lcColorGetGreen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetGreen(string szColor);

  [DllImport("Litecad.dll", EntryPoint="lcColorGetBlue", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetBlue(string szColor);

  [DllImport("Litecad.dll", EntryPoint="lcColorGetIndex", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ColorGetIndex(string szColor, bool bLogicalEnabled);

  [DllImport("Litecad.dll", EntryPoint="lcColorToVal", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorToVal(string szColor, out int pbRGB, out int pIndex, out int pR, out int pG, out int pB);

  [DllImport("Litecad.dll", EntryPoint="lcColorSetPalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorSetPalette(int Index, int R, int G, int B);

  [DllImport("Litecad.dll", EntryPoint="lcColorGetPalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorGetPalette(int Index, out int pR, out int pG, out int pB);

  [DllImport("Litecad.dll", EntryPoint="lcColorSavePalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorSavePalette(string szFileName, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcColorLoadPalette", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ColorLoadPalette(string szFileName, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcImageSetPixelRGB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageSetPixelRGB(IntPtr hImage, int X, int Y, int Red, int Green, int Blue);

  [DllImport("Litecad.dll", EntryPoint="lcImageSetPixelI", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageSetPixelI(IntPtr hImage, int X, int Y, int iColor);

  [DllImport("Litecad.dll", EntryPoint="lcImageGetPixelRGB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageGetPixelRGB(IntPtr hImage, int X, int Y, out int pRed, out int pGreen, out int pBlue);

  [DllImport("Litecad.dll", EntryPoint="lcImageGetPixelI", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageGetPixelI(IntPtr hImage, int X, int Y, out int piColor);

  [DllImport("Litecad.dll", EntryPoint="lcImageSetPalColor", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageSetPalColor(IntPtr hImage, int iColor, int Red, int Green, int Blue);

  [DllImport("Litecad.dll", EntryPoint="lcImageGetPalColor", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageGetPalColor(IntPtr hImage, int iColor, out int pRed, out int pGreen, out int pBlue);

  [DllImport("Litecad.dll", EntryPoint="lcImageLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageLoad(IntPtr hImage, string szFilename, IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcImageLoadDIB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageLoadDIB(IntPtr hImage, IntPtr hDib2);

  [DllImport("Litecad.dll", EntryPoint="lcImageLoadCamera", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageLoadCamera(IntPtr hImage);

  [DllImport("Litecad.dll", EntryPoint="lcImageCopyQuad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageCopyQuad(IntPtr hImage, IntPtr hImageSrc, int W, int H, double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3);

  [DllImport("Litecad.dll", EntryPoint="lcImageProc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ImageProc(IntPtr hImage, int Mode);

  [DllImport("Litecad.dll", EntryPoint="lcExpEntity", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ExpEntity(IntPtr hEnt, int iChar, int Flags, bool bUnrotate);

  [DllImport("Litecad.dll", EntryPoint="lcExpGetPline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int ExpGetPline(double Delta);

  [DllImport("Litecad.dll", EntryPoint="lcExpGetVertex", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ExpGetVertex(out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcExpBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool ExpBlock(IntPtr hBlock, F_LCEVENT pFunc, int Prm1, IntPtr Prm2);

  [DllImport("Litecad.dll", EntryPoint="lcGbrLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GbrLoad(IntPtr hLcWnd, string szFileName0);

  [DllImport("Litecad.dll", EntryPoint="lcGbrClose", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GbrClose(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcPlugGetOption", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern string PlugGetOption(string szFileName, string szKey);

  [DllImport("Litecad.dll", EntryPoint="lcPlugGetOption2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlugGetOption2(string szFileName, string szKey);

  [DllImport("Litecad.dll", EntryPoint="lcPlugSetOption", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PlugSetOption(string szFileName, string szKey, string szValue, bool bSave);

  [DllImport("Litecad.dll", EntryPoint="lcPrintSetup", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int PrintSetup(IntPtr hWnd);

  [DllImport("Litecad.dll", EntryPoint="lcPrintLayout", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PrintLayout(IntPtr hBlock);

  [DllImport("Litecad.dll", EntryPoint="lcPrintBlock", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool PrintBlock(IntPtr hBlock, double X, double Y, double W, double H, double Scal, double PapLef, double PapTop, int Options);

  [DllImport("Litecad.dll", EntryPoint="lcXDataBegin", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr XDataBegin();

  [DllImport("Litecad.dll", EntryPoint="lcXDataEnd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern int XDataEnd(IntPtr hData);

  [DllImport("Litecad.dll", EntryPoint="lcXDataClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool XDataClear(IntPtr hData);

  [DllImport("Litecad.dll", EntryPoint="lcXDataSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool XDataSet(IntPtr hData);

  [DllImport("Litecad.dll", EntryPoint="lcWndTabClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndTabClear(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcWndTabAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndTabAdd(IntPtr hLcWnd, int TabID, string szLabel, string szTipText, IntPtr hObject);

  [DllImport("Litecad.dll", EntryPoint="lcWndTabSelect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndTabSelect(IntPtr hLcWnd, int TabID);

  [DllImport("Litecad.dll", EntryPoint="lcWndPaperEnable", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndPaperEnable(IntPtr hLcWnd, bool bEnable);

  [DllImport("Litecad.dll", EntryPoint="lcWndPaperSetSize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndPaperSetSize(IntPtr hLcWnd, int Size, int Orient);

  [DllImport("Litecad.dll", EntryPoint="lcWndPaperSetSize2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndPaperSetSize2(IntPtr hLcWnd, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcWndPaperSetPos", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool WndPaperSetPos(IntPtr hLcWnd, double Left, double Bottom);

  [DllImport("Litecad.dll", EntryPoint="lcGripClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GripClear(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcGripAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GripAdd(IntPtr hLcWnd, IntPtr hObj, int iGrip, int Typ, double X, double Y, double Ang, double X0, double Y0);

  [DllImport("Litecad.dll", EntryPoint="lcGripSet", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool GripSet(IntPtr hLcWnd, IntPtr hObj, int iGrip, double X, double Y, double Ang, double X0, double Y0);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PenCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_PenCreate(IntPtr hLcWnd, int Id, int Color, double Width, int PenStyle);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PenSelect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PenSelect(IntPtr hLcWnd, IntPtr hPen);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PenSelectID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PenSelectID(IntPtr hLcWnd, int IdPen);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_BrushCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_BrushCreate(IntPtr hLcWnd, int Id, int Color, int Pattern, int Alpha);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_BrushSelect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_BrushSelect(IntPtr hLcWnd, IntPtr hBrush);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_BrushSelectID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_BrushSelectID(IntPtr hLcWnd, int IdBrush);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawPtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawPtbuf(IntPtr hLcWnd, IntPtr hPtbuf, bool bClosed);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawMpgon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawMpgon(IntPtr hLcWnd, IntPtr hMpgon, bool bFill, bool bBorder);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawImage", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawImage(IntPtr hLcWnd, IntPtr hImage, double X, double Y, double PixelSize, int Transp, int TVal, IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawImage2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawImage2(IntPtr hLcWnd, IntPtr hImage, double X, double Y, double W, double H, int Transp, int TVal, IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawText(IntPtr hLcWnd, double X, double Y, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawText2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawText2(IntPtr hLcWnd, double X1, double Y1, double X2, double Y2, int Align, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawTextBC", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawTextBC(IntPtr hLcWnd, IntPtr hMpgon, double Gap, double Height, int Align, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawArcText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawArcText(IntPtr hLcWnd, string szText, double X, double Y, double Rad, double Ang0, bool bCW, double H, double WScale, int Align);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawHatch", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawHatch(IntPtr hLcWnd, IntPtr hHatch);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawPoint(IntPtr hLcWnd, double X, double Y, int PtMode, double PtSize);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawLine(IntPtr hLcWnd, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawXline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawXline(IntPtr hLcWnd, double X, double Y, double Angle, bool bRay);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawRect(IntPtr hLcWnd, double Xc, double Yc, double Width, double Height);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawRect2(IntPtr hLcWnd, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawPickBox", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawPickBox(IntPtr hLcWnd);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawGrid", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawGrid(IntPtr hLcWnd, IntPtr hGrid, bool bDest, int ColLine, int ColNode);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DrawCPrompt", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DrawCPrompt(IntPtr hLcWnd, int X, int Y, int Align, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_SetPixel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern void Paint_SetPixel(IntPtr hDC, int X, int Y, int Color);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_CreatePtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_CreatePtbuf();

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DeletePtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DeletePtbuf(IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufClear(IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddPoint(IntPtr hPtbuf, double X, double Y, double Prm1, double Prm2, int IntPrm);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddPoint2(IntPtr hPtbuf, double X, double Y);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddPointP", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddPointP(IntPtr hPtbuf, double Angle, double Dist);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddLine", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddLine(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddLineP", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddLineP(IntPtr hPtbuf, double X, double Y, double Angle, double Dist);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddCircle", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddCircle(IntPtr hPtbuf, double Xc, double Yc, double R, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddCircle2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddCircle2(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddCircle3", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddCircle3(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, double X3, double Y3, bool bInside, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArc", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArc(IntPtr hPtbuf, double Xc, double Yc, double R, double StartAngle, double ArcAngle, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArc3p", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArc3p(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, double X3, double Y3, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSDE", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSDE(IntPtr hPtbuf, double Xs, double Ys, double DirAng, double Xe, double Ye, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSDAR", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSDAR(IntPtr hPtbuf, double Xs, double Ys, double DirAng, double AngArc, double R, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSER", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSER(IntPtr hPtbuf, double Xs, double Ys, double Xe, double Ye, double Radius, bool bClockwise, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSEL", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSEL(IntPtr hPtbuf, double Xs, double Ys, double Xe, double Ye, double ArcLen, bool bClockwise, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSEA", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSEA(IntPtr hPtbuf, double Xs, double Ys, double Xe, double Ye, double AngArc, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcSEB", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcSEB(IntPtr hPtbuf, double Xs, double Ys, double Xe, double Ye, double Bulge, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcCSE", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcCSE(IntPtr hPtbuf, double Xc, double Yc, double Xs, double Ys, double Xe, double Ye, bool bClockwise, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcCSA", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcCSA(IntPtr hPtbuf, double Xc, double Yc, double Xs, double Ys, double AngArc, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcCSL", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcCSL(IntPtr hPtbuf, double Xc, double Yc, double Xs, double Ys, double ChordLen, bool bClockwise, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddArcCRAA", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddArcCRAA(IntPtr hPtbuf, double Xc, double Yc, double R, double AngStart, double AngEnd, bool bClockwise, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddEllipse", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddEllipse(IntPtr hPtbuf, double Xc, double Yc, double Rmaj, double Rmin, double RotAng, double StartAng, double ArcAng, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddEllipse2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddEllipse2(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddRect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddRect(IntPtr hPtbuf, double Xc, double Yc, double W, double H, double Angle, double R, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddRect2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddRect2(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, double R, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddRect3", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddRect3(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, double W, int Align, double R, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddWline", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddWline(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2, double W, int Align, bool bArc, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufAddPtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufAddPtbuf(IntPtr hPtbuf, IntPtr hPtbuf2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufGetPoint", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufGetPoint(IntPtr hPtbuf, int Mode, out double pX, out double pY);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufGetPoint2", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufGetPoint2(IntPtr hPtbuf, int Mode, out double pX, out double pY, out double pPrm1, out double pPrm2, out int pIntPrm);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufInterpolate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufInterpolate(IntPtr hPtbuf, bool bClosed, IntPtr hPtbufDest, int Mode, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufMove(IntPtr hPtbuf, double dx, double dy);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufRotate(IntPtr hPtbuf, double Xc, double Yc, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufScale(IntPtr hPtbuf, double Xc, double Yc, double ScaleX, double ScaleY);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufMirror(IntPtr hPtbuf, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_PtbufCopy", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_PtbufCopy(IntPtr hPtbuf, IntPtr hPtbufDest);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_CreateMpgon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_CreateMpgon();

  [DllImport("Litecad.dll", EntryPoint="lcPaint_DeleteMpgon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_DeleteMpgon(IntPtr hMpgon);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonClear", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonClear(IntPtr hMpgon);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonAddPgon", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonAddPgon(IntPtr hMpgon, IntPtr hPtbuf);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonAddText", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonAddText(IntPtr hMpgon, IntPtr hFont, double X, double Y, string szText, int Resol);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonAddBarcode", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonAddBarcode(IntPtr hMpgon, int BarType, double Xc, double Yc, double Width, double Height, string szText);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonMove", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonMove(IntPtr hMpgon, double dx, double dy);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonRotate(IntPtr hMpgon, double Xc, double Yc, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonScale", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonScale(IntPtr hMpgon, double Xc, double Yc, double ScaleX, double ScaleY);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonMirror", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonMirror(IntPtr hMpgon, double X1, double Y1, double X2, double Y2);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_MpgonCopy", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_MpgonCopy(IntPtr hMpgon, IntPtr hMpgonDest);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_HatchGen", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_HatchGen(IntPtr hMpgon, IntPtr hHatch, double Dist, double Angle, double Gap);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageAdd", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_ImageAdd(int Id);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageDelete", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageDelete(IntPtr hImage);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageGetFirst", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_ImageGetFirst();

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageGetNext", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_ImageGetNext(IntPtr hImage);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageGetByID", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_ImageGetByID(int Id);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageLoad", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageLoad(IntPtr hImage, string szFileName);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageCopy", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageCopy(IntPtr hImage, IntPtr hImageDest);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageCreate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageCreate(IntPtr hImage, int Width, int Height);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageSetPixel", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageSetPixel(IntPtr hImage, int X, int Y, int R, int G, int B);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageFlip", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageFlip(IntPtr hImage, bool bHor, bool bVert);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageRotate", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageRotate(IntPtr hImage, double Angle);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageGray", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageGray(IntPtr hImage);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageResize", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_ImageResize(IntPtr hImage, int NewWidth, int NewHeight, int ResizeFilter);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_ImageGetPtbuf", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_ImageGetPtbuf(IntPtr hImage, double RotAngle);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_FontOpenLC", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_FontOpenLC(string szFontName);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_FontOpenTT", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern IntPtr Paint_FontOpenTT(string szFontName, bool bBold, bool bItalic);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_FontClose", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_FontClose(IntPtr hFont);

  [DllImport("Litecad.dll", EntryPoint="lcPaint_FontSelect", CharSet = CharSet.Unicode, ExactSpelling = true)]
  public static extern bool Paint_FontSelect(IntPtr hLcWnd, IntPtr hFont);

}
