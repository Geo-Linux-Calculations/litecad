Module Lcad

  Public Const LC_FALSE = 0
  Public Const LC_TRUE = 1
  Public Const LC_WS_HSCROLL = 1
  Public Const LC_WS_VSCROLL = 2
  Public Const LC_WS_BORDER = 4
  Public Const LC_WS_CLIENTEDGE = 8
  Public Const LC_WS_SUNKEN = 8
  Public Const LC_WS_STATICEDGE = 16
  Public Const LC_WS_RULERS = 256
  Public Const LC_WS_VIEWTABS = 512
  Public Const LC_WS_FILETABS = 1024
  Public Const LC_WS_DEFAULT = 3
  Public Const LC_MRU_IMAGE_W = 348
  Public Const LC_MRU_IMAGE_H = 273
  Public Const LC_PS_SOLID = 0
  Public Const LC_PS_DASH = 1
  Public Const LC_PS_DOT = 2
  Public Const LC_PS_DASHDOT = 3
  Public Const LC_PS_DASHDOTDOT = 4
  Public Const LC_LW_THIN = 0
  Public Const LC_LW_REAL = 1
  Public Const LC_LW_PIXEL = 2
  Public Const LC_FILL_SOLID = 0
  Public Const LC_FILL_BDIAGONAL = 1
  Public Const LC_FILL_CROSS = 2
  Public Const LC_FILL_DIAGCROSS = 3
  Public Const LC_FILL_FDIAGONAL = 4
  Public Const LC_FILL_HORIZONTAL = 5
  Public Const LC_FILL_VERTICAL = 6
  Public Const LC_IMGRES_BOX = 0
  Public Const LC_IMGRES_BILINEAR = 1
  Public Const LC_IMGRES_BSPLINE = 2
  Public Const LC_IMGRES_BICUBIC = 3
  Public Const LC_IMGRES_CATMULLROM = 4
  Public Const LC_IMGRES_LANCZOS3 = 5
  Public Const LC_IMGPROC_GRAY = 1
  Public Const LC_IMGPROC_FLIPHOR = 2
  Public Const LC_IMGPROC_FLIPVER = 3
  Public Const LC_IMGPROC_ROT180 = 4
  Public Const LC_GRIP_POINT = 0
  Public Const LC_GRIP_CENROT = 1
  Public Const LC_GRIP_ANGLE = 2
  Public Const LC_GRIP_ANGLE2 = 3
  Public Const LC_GRIP_BEZIER = 4
  Public Const LC_GRIP_BEZIER0 = 5
  Public Const LC_GRIP_ARCRAD = 6
  Public Const LC_GRIP_NOMOVE = 1
  Public Const LC_GRIP_NOROTATE = 2
  Public Const LC_GRIP_NOSCALE = 4
  Public Const LC_BARTYPE_CODE39 = 0
  Public Const LC_BARTYPE_CODE93 = 1
  Public Const LC_BARTYPE_CODE128 = 6
  Public Const LC_BARTYPE_EAN13 = 7
  Public Const LC_BARTYPE_ITF = 8
  Public Const LC_BARTYPE_EAN8 = 9
  Public Const LC_BARTYPE_QR = 21
  Public Const LC_BARTYPE_MQR = 22
  Public Const LC_BARTYPE_DMATRIX = 23
  Public Const LC_BARTYPE_DM = 23
  Public Const LC_BARTYPE_DMATRIXR = 24
  Public Const LC_BARTYPE_DMR = 24
  Public Const LC_BARC_QRECL_L = 0
  Public Const LC_BARC_QRECL_M = 1
  Public Const LC_BARC_QRECL_Q = 2
  Public Const LC_BARC_QRECL_H = 3
  Public Const LC_LEADER_TCENTER = 0
  Public Const LC_LEADER_TLEFT = 1
  Public Const LC_LEADER_TRIGHT = 2
  Public Const LC_LEADER_VERT = 1
  Public Const LC_LEADER_CORNER = 2
  Public Const LC_VPL_CLEAR = 1
  Public Const LC_VPL_ADD = 2
  Public Const LC_VPL_DELETE = 3
  Public Const LC_VPL_PROP_BEGIN = 4
  Public Const LC_VPL_PROP_END = 5
  Public Const LC_RAD_TO_DEG = 57.2957795130823208768
  Public Const LC_DEG_TO_RAD = 0.01745329251994329577
  Public Const LC_PI = 3.14159265358979323846
  Public Const LC_PI2 = 1.57079632679489661923
  Public Const LC_PI4 = 0.78539816339744830962
  Public Const LC_2PI = 6.28318530717958647692
  Public Const LC_DEG1 = 0.01745329251994329577
  Public Const LC_DEG2 = 0.03490658503988659154
  Public Const LC_DEG3 = 0.05235987755982988731
  Public Const LC_DEG4 = 0.06981317007977318308
  Public Const LC_DEG5 = 0.08726646259971647885
  Public Const LC_DEG6 = 0.10471975511965977462
  Public Const LC_DEG7 = 0.12217304763960307038
  Public Const LC_DEG8 = 0.13962634015954636615
  Public Const LC_DEG9 = 0.15707963267948966192
  Public Const LC_DEG10 = 0.17453292519943295769
  Public Const LC_DEG20 = 0.34906585039886591538
  Public Const LC_DEG30 = 0.52359877559829887308
  Public Const LC_DEG40 = 0.69813170079773183077
  Public Const LC_DEG45 = 0.78539816339744830962
  Public Const LC_DEG50 = 0.87266462599716478846
  Public Const LC_DEG60 = 1.04719755119659774615
  Public Const LC_DEG70 = 1.22173047639603070385
  Public Const LC_DEG80 = 1.39626340159546366154
  Public Const LC_DEG90 = 1.57079632679489661923
  Public Const LC_DEG180 = 3.14159265358979323846
  Public Const LC_DEG270 = 4.71238898038468985769
  Public Const LC_DEG360 = 6.28318530717958647692
  Public Const LC_INSUNIT_UNDEFINED = 0
  Public Const LC_INSUNIT_INCHES = 1
  Public Const LC_INSUNIT_FEET = 2
  Public Const LC_INSUNIT_MILES = 3
  Public Const LC_INSUNIT_MILLIMETERS = 4
  Public Const LC_INSUNIT_CENTIMETERS = 5
  Public Const LC_INSUNIT_METERS = 6
  Public Const LC_INSUNIT_KILOMETERS = 7
  Public Const LC_INSUNIT_MICROINCHES = 8
  Public Const LC_INSUNIT_MILS = 9
  Public Const LC_INSUNIT_YARDS = 10
  Public Const LC_INSUNIT_ANGSTROMS = 11
  Public Const LC_INSUNIT_NANOMETERS = 12
  Public Const LC_INSUNIT_MICRONS = 13
  Public Const LC_INSUNIT_DECIMETERS = 14
  Public Const LC_INSUNIT_DEKAMETERS = 15
  Public Const LC_INSUNIT_HECTOMETERS = 16
  Public Const LC_INSUNIT_GIGAMETERS = 17
  Public Const LC_INSUNIT_ASTRONOMICAL = 18
  Public Const LC_INSUNIT_LIGHTYEARS = 19
  Public Const LC_INSUNIT_PARSECS = 20
  Public Const LC_LUNIT_SCIEN = 1
  Public Const LC_LUNIT_DECIM = 2
  Public Const LC_LUNIT_ENGIN = 3
  Public Const LC_LUNIT_ARCHI = 4
  Public Const LC_LUNIT_FRACT = 5
  Public Const LC_AUNIT_DEGREE = 0
  Public Const LC_AUNIT_DMS = 1
  Public Const LC_AUNIT_GRAD = 2
  Public Const LC_AUNIT_RADIAN = 3
  Public Const LC_AUNIT_SURVEY = 4
  Public Const LC_ANGLE_DEGREE = 0
  Public Const LC_ANGLE_DMS = 1
  Public Const LC_ANGLE_GRAD = 2
  Public Const LC_ANGLE_RADIAN = 3
  Public Const LC_ANGLE_SURVEY = 4
  Public Const LC_PAPER_CUSTOM = 0
  Public Const LC_PAPER_USER = 0
  Public Const LC_PAPER_A0 = 1
  Public Const LC_PAPER_A1 = 2
  Public Const LC_PAPER_A2 = 3
  Public Const LC_PAPER_A3 = 4
  Public Const LC_PAPER_A4 = 5
  Public Const LC_PAPER_A5 = 6
  Public Const LC_PAPER_A6 = 7
  Public Const LC_PAPER_B0 = 11
  Public Const LC_PAPER_B1 = 12
  Public Const LC_PAPER_B2 = 13
  Public Const LC_PAPER_B3 = 14
  Public Const LC_PAPER_B4 = 15
  Public Const LC_PAPER_B5 = 16
  Public Const LC_PAPER_B6 = 17
  Public Const LC_PAPER_C0 = 21
  Public Const LC_PAPER_C1 = 22
  Public Const LC_PAPER_C2 = 23
  Public Const LC_PAPER_C3 = 24
  Public Const LC_PAPER_C4 = 25
  Public Const LC_PAPER_C5 = 26
  Public Const LC_PAPER_C6 = 27
  Public Const LC_PAPER_ANSI_A = 31
  Public Const LC_PAPER_ANSI_B = 32
  Public Const LC_PAPER_ANSI_C = 33
  Public Const LC_PAPER_ANSI_D = 34
  Public Const LC_PAPER_ANSI_E = 35
  Public Const LC_PAPER_LETTER = 36
  Public Const LC_PAPER_LEGAL = 37
  Public Const LC_PAPER_EXECUTIVE = 38
  Public Const LC_PAPER_LEDGER = 39
  Public Const LC_PAPER_UNLIMITED = 100
  Public Const LC_PAPER_PORTRAIT = 0
  Public Const LC_PAPER_BOOK = 0
  Public Const LC_PAPER_LANDSCAPE = 1
  Public Const LC_PAPER_ALBUM = 1
  Public Const LC_PRN_SCALELW = 1
  Public Const LC_PRN_1COLOR = 2
  Public Const LC_TA_LEFBOT = 0
  Public Const LC_TA_CENBOT = 1
  Public Const LC_TA_RIGBOT = 2
  Public Const LC_TA_LEFCEN = 3
  Public Const LC_TA_CENTER = 4
  Public Const LC_TA_RIGCEN = 5
  Public Const LC_TA_LEFTOP = 6
  Public Const LC_TA_CENTOP = 7
  Public Const LC_TA_RIGTOP = 8
  Public Const LC_TA_ALIGNED = 11
  Public Const LC_TA_FIT = 12
  Public Const LC_TEXT_BACKWARD = 2
  Public Const LC_TEXT_UPDOWN = 4
  Public Const LC_ATA_LEFT = 0
  Public Const LC_ATA_CENTER = 1
  Public Const LC_ATA_RIGHT = 2
  Public Const LC_BTA_LEFT = 0
  Public Const LC_BTA_CENTER = 1
  Public Const LC_BTA_RIGHT = 2
  Public Const LC_PLFIT_BULGE = 0
  Public Const LC_PLFIT_NONE = 0
  Public Const LC_PLFIT_QUAD = 5
  Public Const LC_PLFIT_CUBIC = 6
  Public Const LC_PLFIT_BEZIER = 7
  Public Const LC_PLFIT_SPLINE = 99
  Public Const LC_PLFIT_ROUND = 101
  Public Const LC_PLFIT_LINQUAD = 102
  Public Const LC_POINT_PIXEL = 0
  Public Const LC_POINT_NONE = 1
  Public Const LC_POINT_PLUS = 2
  Public Const LC_POINT_X = 3
  Public Const LC_POINT_TICK = 4
  Public Const LC_POINT_CIRCLE = 32
  Public Const LC_POINT_SQUARE = 64
  Public Const LC_POINT_RHOMB = 128
  Public Const LC_POINT_FILLED = 256
  Public Const LC_POINT_BEAM0 = 10000
  Public Const LC_POINT_BEAM1 = 10001
  Public Const LC_BLK_ENT_RETAIN = 0
  Public Const LC_BLK_ENT_CONVERT = 1
  Public Const LC_BLK_ENT_DELETE = 2
  Public Const LC_EA_LEFT = 1
  Public Const LC_EA_TOP = 2
  Public Const LC_EA_RIGHT = 3
  Public Const LC_EA_BOTTOM = 4
  Public Const LC_EA_CENTER = 5
  Public Const LC_EA_CENTERX = 6
  Public Const LC_EA_CENTERY = 7
  Public Const LC_IMGA_CENTER = 0
  Public Const LC_IMGA_LEFBOT = 1
  Public Const LC_IMGA_RIGBOT = 2
  Public Const LC_IMGA_LEFTOP = 3
  Public Const LC_IMGA_RIGTOP = 4
  Public Const LC_LBUTTON = 1
  Public Const LC_RBUTTON = 2
  Public Const LC_MBUTTON = 4
  Public Const LC_SHIFT = 1
  Public Const LC_CTRL = 2
  Public Const LC_ALT = 4
  Public Const LC_KBD_QWERTY = 0
  Public Const LC_KBD_AZERTY = 1
  Public Const LC_KBD_QWERTZ = 2
  Public Const LC_CURSOR_NULL = 0
  Public Const LC_CURSOR_ARROW = 1
  Public Const LC_CURSOR_CROSS = 2
  Public Const LC_CURSOR_HAND = 3
  Public Const LC_CURSOR_HELP = 4
  Public Const LC_CURSOR_NO = 5
  Public Const LC_CURSOR_WAIT = 6
  Public Const LC_CURSOR_PAN1 = 7
  Public Const LC_CURSOR_PAN2 = 8
  Public Const LC_EXP_OUTLINE = 1
  Public Const LC_EXP_HATCH = 2
  Public Const LC_EXP_ALL = 3
  Public Const LC_EXP_MAXRESOL = 4
  Public Const LC_EM_TOP = 0
  Public Const LC_EM_ENT = 1
  Public Const LC_EM_PLINE = 2
  Public Const LC_EM_VERTEX = 3
  Public Const LC_EM_ENDPLINE = 4
  Public Const LC_EM_ENDENT = 5
  Public Const LC_EMUL_START = 0
  Public Const LC_EMUL_STOP = 1
  Public Const LC_EMUL_PARAMS = 2
  Public Const LC_MAG_ZOOM_4 = 0
  Public Const LC_MAG_ZOOM_6 = 1
  Public Const LC_MAG_ZOOM_8 = 2
  Public Const LC_MAG_ZOOM_10 = 3
  Public Const LC_MAG_ZOOM_12 = 4
  Public Const LC_MAG_ZOOM_14 = 5
  Public Const LC_MAG_CENTER = 1
  Public Const LC_DRWEXP_L = 0
  Public Const LC_DRWEXP_P = 1
  Public Const LC_DRWEXP_LA = 10
  Public Const LC_DRWEXP_PA = 11
  Public Const LC_DRWEXP_BLOCKS = 20
  Public Const LC_HELP_DG_PRINT = 1
  Public Const LC_HELP_DG_RASTER = 2
  Public Const LC_HELP_DG_COLOR = 10
  Public Const LC_HELP_DG_LAYERS = 11
  Public Const LC_HELP_DG_SELLTYPE = 12
  Public Const LC_HELP_DG_LINETYPES = 13
  Public Const LC_HELP_DG_LOADLINETYPE = 14
  Public Const LC_HELP_DG_TEXTSTYLES = 15
  Public Const LC_HELP_DG_PNTSTYLES = 16
  Public Const LC_HELP_DG_DIMSTYLES = 17
  Public Const LC_HELP_DG_MLSTYLES = 18
  Public Const LC_HELP_DG_HATSTYLES = 19
  Public Const LC_HELP_DG_BLOCKS = 20
  Public Const LC_HELP_DG_LAYOUTS = 21
  Public Const LC_HELP_DG_IMAGES = 22
  Public Const LC_HELP_DG_IMAGEINSERT = 23
  Public Const LC_HELP_DG_SELBLOCK = 30
  Public Const LC_HELP_DG_SELTSTYLE = 31
  Public Const LC_HELP_DG_SELPTYPE = 32
  Public Const LC_HELP_DG_CREBLOCK = 33
  Public Const LC_HELP_DG_PAGEPROP = 34
  Public Const LC_HELP_DG_SELFONT = 35
  Public Const LC_HELP_DG_TEXT = 40
  Public Const LC_HELP_DG_ARCTEXT = 41
  Public Const LC_HELP_DG_INPUTCOORD = 42
  Public Const LC_HELP_DG_WORKFIELD = 43
  Public Const LC_HELP_DG_CRBITMAP = 44
  Public Const LC_HELP_DG_INSERT = 45
  Public Const LC_HELP_DG_TSP = 51
  Public Const LC_HELP_DG_ARRAY = 52
  Public Const LC_HELP_DG_ARRAYARC = 53
  Public Const LC_HELP_DG_HATCH = 54
  Public Const LC_HELP_DG_GRID = 61
  Public Const LC_HELP_DG_PTRACK = 62
  Public Const LC_HELP_DG_OSNAP = 63
  Public Const LC_HELP_DG_KBMOVE = 64
  Public Const LC_HELP_DG_DRWPROPS = 65
  Public Const LC_HELP_DG_SYSPROPS = 66
  Public Const LC_HELP_DG_SELECTION = 67
  Public Const LC_HELP_DG_QSELECT = 68
  Public Const LC_HELP_DG_RPOLYGON = 69
  Public Const LC_HELP_DG_LIMITS = 70
  Public Const LC_HELP_DG_NDLSET = 71
  Public Const LC_HELP_DG_LMESH = 72
  Public Const LC_HELP_DG_CRECTS = 73
  Public Const LC_HELP_DG_SELLINFILL = 74
  Public Const LC_MB_OK = 0
  Public Const LC_MB_OKCANCEL = 1
  Public Const LC_MB_ABORTRETRYIGNORE = 2
  Public Const LC_MB_YESNOCANCEL = 3
  Public Const LC_MB_YESNO = 4
  Public Const LC_MB_RETRYCANCEL = 5
  Public Const LC_MB_CANCELTRYCONTINUE = 6
  Public Const LC_MB_HELP = 16384
  Public Const LC_MB_ICONSTOP = 16
  Public Const LC_MB_ICONERROR = 16
  Public Const LC_MB_ICONHAND = 16
  Public Const LC_MB_ICONQUESTION = 32
  Public Const LC_MB_ICONEXCLAMATION = 48
  Public Const LC_MB_ICONWARNING = 48
  Public Const LC_MB_ICONINFORMATION = 64
  Public Const LC_MB_ICONASTERISK = 64
  Public Const LC_UNDO_BEGIN = 0
  Public Const LC_UNDO_END = 1
  Public Const LC_UNDO_CLEAR = 2
  Public Const LC_ERR_OBJTYPE = 1
  Public Const LC_ERR_NOTAG = 2
  Public Const LC_ERR_USERCANCEL = 3
  Public Const LC_ERR_FILENAME = 4
  Public Const LC_ERR_FILELOAD = 5
  Public Const LC_ERR_FILESAVE = 6
  Public Const LC_ERR_UNRESBLOCKREF = 7
  Public Const LC_ERR_UNRESVIEWREF = 8
  Public Const LC_ERR_UNRESHATCH = 9
  Public Const LC_ERR_FILE_TIN_SAVE = 101
  Public Const LC_OBJ_LAYER = 1
  Public Const LC_OBJ_LINETYPE = 2
  Public Const LC_OBJ_TEXTSTYLE = 3
  Public Const LC_OBJ_DIMSTYLE = 4
  Public Const LC_OBJ_PNTSTYLE = 5
  Public Const LC_OBJ_IMAGE = 6
  Public Const LC_OBJ_MLSTYLE = 8
  Public Const LC_OBJ_LINFILL = 9
  Public Const LC_OBJ_BLOCK = 10
  Public Const LC_OBJ_LAYOUT = 11
  Public Const LC_ENT_LINE = 101
  Public Const LC_ENT_POLYLINE = 102
  Public Const LC_ENT_CIRCLE = 103
  Public Const LC_ENT_ARC = 104
  Public Const LC_ENT_BLOCKREF = 105
  Public Const LC_ENT_POINT = 107
  Public Const LC_ENT_XLINE = 108
  Public Const LC_ENT_ELLIPSE = 109
  Public Const LC_ENT_TEXT = 110
  Public Const LC_ENT_TEXTWIN = 111
  Public Const LC_ENT_IMAGEREF = 115
  Public Const LC_ENT_VIEWPORT = 116
  Public Const LC_ENT_CLIPRECT = 117
  Public Const LC_ENT_RECT = 118
  Public Const LC_ENT_ATTDEF = 120
  Public Const LC_ENT_ECW = 121
  Public Const LC_ENT_MTEXT = 122
  Public Const LC_ENT_ARCTEXT = 123
  Public Const LC_ENT_HATCH = 124
  Public Const LC_ENT_FACE = 126
  Public Const LC_ENT_MLINE = 127
  Public Const LC_ENT_DIMROT = 131
  Public Const LC_ENT_DIMLIN = 131
  Public Const LC_ENT_DIMALI = 132
  Public Const LC_ENT_DIMORD = 133
  Public Const LC_ENT_DIMRAD = 134
  Public Const LC_ENT_DIMDIA = 135
  Public Const LC_ENT_DIMANG = 136
  Public Const LC_ENT_LEADER = 137
  Public Const LC_ENT_RPLAN = 141
  Public Const LC_ENT_TIN = 142
  Public Const LC_ENT_BARCODE = 150
  Public Const LC_ENT_SHAPE = 160
  Public Const LC_ENT_BRI = 161
  Public Const LC_ENT_XREF = 199
  Public Const LC_ENT_ARROW = 301
  Public Const LC_ENT_SPIRAL = 302
  Public Const LC_ENT_CAMERA = 303
  Public Const LC_ENT_PTARRAY = 304
  Public Const LC_ENT_PATHTEXT = 305
  Public Const LC_ENT_BEZIER = 306
  Public Const LC_ENT_CUSTOM = 1000
  Public Const LC_ENT_ALL = 32767
  Public Const LC_LWEIGHT_DEFAULT = -3
  Public Const LC_LWEIGHT_BYBLOCK = -2
  Public Const LC_LWEIGHT_BYLAYER = -1
  Public Const LC_LWIDTH_DEFAULT = -3
  Public Const LC_LWIDTH_BYBLOCK = -2
  Public Const LC_LWIDTH_BYLAYER = -1
  Public Const LC_COLOR_RGB = 0
  Public Const LC_COLOR_INDEX = 1
  Public Const LC_COLOR_RED = 1
  Public Const LC_COLOR_YELLOW = 2
  Public Const LC_COLOR_GREEN = 3
  Public Const LC_COLOR_CYAN = 4
  Public Const LC_COLOR_BLUE = 5
  Public Const LC_COLOR_MAGENTA = 6
  Public Const LC_COLOR_FOREGROUND = 7
  Public Const LC_COLOR_GRAY = 8
  Public Const LC_COLOR_LTGRAY = 9
  Public Const LC_COLOR_BYBLOCK = 0
  Public Const LC_COLOR_BYLAYER = 256
  Public Const LC_COLOR_WIPEOUT = 259
  Public Const LC_MLINE_TOP = 0
  Public Const LC_MLINE_MIDDLE = 1
  Public Const LC_MLINE_BOTTOM = 2
  Public Const LC_TABLE_IDSET = 349000349
  Public Const LC_PLUG_IMPDRW = 2
  Public Const LC_PLUG_EXPDRW = 3
  Public Const LC_PLUG_IMGDIB = 4
  Public Const LC_FP_FLOAD = 0
  Public Const LC_FP_FSAVE = 1
  Public Const LC_FP_NITEMS = 2
  Public Const LC_FP_ITEM = 3
  Public Const LC_FP_ITEMPOS = 4
  Public Const LC_OSNAP_NULL = 0
  Public Const LC_OSNAP_NODE = 1
  Public Const LC_OSNAP_ENDPOINT = 2
  Public Const LC_OSNAP_MIDPOINT = 4
  Public Const LC_OSNAP_CENTER = 8
  Public Const LC_OSNAP_NEAREST = 16
  Public Const LC_OSNAP_INTER = 32
  Public Const LC_OSNAP_PERPEND = 64
  Public Const LC_OSNAP_TANGENT = 128
  Public Const LC_OSNAP_QUADRANT = 256
  Public Const LC_OSNAP_INSERT = 512
  Public Const LC_OSNAP_NONE = 1024
  Public Const LC_OSNAP_ALL = 1023
  Public Const LC_ATTRIB_HIDDEN = 1
  Public Const LC_ATTRIB_CONST = 2
  Public Const LC_ATTRIB_VERIFY = 4
  Public Const LC_ATTRIB_PRESET = 8
  Public Const LC_ATTRIB_LOCK = 16
  Public Const LC_ATTRIB_MTEXT = 32
  Public Const LC_FACE_EDGE1INVIS = 1
  Public Const LC_FACE_EDGE2INVIS = 2
  Public Const LC_FACE_EDGE3INVIS = 4
  Public Const LC_FACE_EDGE4INVIS = 8
  Public Const LC_FACE_EDGE1HIDDEN = 1
  Public Const LC_FACE_EDGE2HIDDEN = 2
  Public Const LC_FACE_EDGE3HIDDEN = 4
  Public Const LC_FACE_EDGE4HIDDEN = 8
  Public Const LC_BLOCK_OVERWRITENO = 0
  Public Const LC_BLOCK_OVERWRITEYES = 1
  Public Const LC_BLOCK_OVERWRITEDLG = 2
  Public Const LC_ARROW_CLOSEDF = 0
  Public Const LC_ARROW_CLOSEDB = 1
  Public Const LC_ARROW_CLOSED = 2
  Public Const LC_ARROW_DOT = 3
  Public Const LC_ARROW_ARCHTICK = 4
  Public Const LC_ARROW_OBLIQUE = 5
  Public Const LC_ARROW_OPEN = 6
  Public Const LC_ARROW_ORIGIN = 7
  Public Const LC_ARROW_ORIGIN2 = 8
  Public Const LC_ARROW_OPEN90 = 9
  Public Const LC_ARROW_OPEN30 = 10
  Public Const LC_ARROW_DOTSMALL = 11
  Public Const LC_ARROW_DOTB = 12
  Public Const LC_ARROW_DOTSMALLB = 13
  Public Const LC_ARROW_BOX = 14
  Public Const LC_ARROW_BOXF = 15
  Public Const LC_ARROW_DATUM = 16
  Public Const LC_ARROW_DATUMF = 17
  Public Const LC_ARROW_INTEGRAL = 18
  Public Const LC_ARROW_NONE = 19
  Public Const LC_COFO_NONE = 0
  Public Const LC_COFO_Y800 = 1
  Public Const LC_COFO_RGB24 = 2
  Public Const LC_COFO_RGB32 = 3
  Public Const LC_COFO_UYVY = 4
  Public Const LC_COFO_Y16 = 5
  Public Const LC_COFO_MEGA = 65536
  Public Const LC_CMD_FILESAVE = 1
  Public Const LC_CMD_FILESAVEAS = 2
  Public Const LC_CMD_PRINT = 3
  Public Const LC_CMD_RASTERIZE = 4
  Public Const LC_CMD_FILENEW = 5
  Public Const LC_CMD_FILEOPEN = 6
  Public Const LC_CMD_FILERECENT = 7
  Public Const LC_CMD_FILEINSERT = 8
  Public Const LC_CMD_FILECLOSE = 9
  Public Const LC_CMD_ZOOM_IN = 31
  Public Const LC_CMD_ZOOM_OUT = 32
  Public Const LC_CMD_ZOOM_EXT = 33
  Public Const LC_CMD_ZOOM_PAGE = 34
  Public Const LC_CMD_ZOOM_PREV = 35
  Public Const LC_CMD_ZOOM_LIM = 36
  Public Const LC_CMD_PAN_LEFT = 37
  Public Const LC_CMD_PAN_RIGHT = 38
  Public Const LC_CMD_PAN_UP = 39
  Public Const LC_CMD_PAN_DOWN = 40
  Public Const LC_CMD_ZOOM_WIN = 51
  Public Const LC_CMD_ZOOM_RECT = 51
  Public Const LC_CMD_ZOOM_SEL = 52
  Public Const LC_CMD_PAGENEXT = 53
  Public Const LC_CMD_PAGEPREV = 54
  Public Const LC_CMD_PAGEMODEL = 55
  Public Const LC_CMD_PAGEVPORT = 56
  Public Const LC_CMD_VP_ACT = 57
  Public Const LC_CMD_VP_DEACT = 58
  Public Const LC_CMD_EDITMODE_ON = 59
  Public Const LC_CMD_EDITMODE_OFF = 60
  Public Const LC_CMD_MAGON = 71
  Public Const LC_CMD_MAGOFF = 72
  Public Const LC_CMD_MAGPRM = 73
  Public Const LC_CMD_MAGZOOM4 = 74
  Public Const LC_CMD_MAGZOOM6 = 75
  Public Const LC_CMD_MAGZOOM8 = 76
  Public Const LC_CMD_MAGZOOM10 = 77
  Public Const LC_CMD_MAGZOOM12 = 78
  Public Const LC_CMD_MAGZOOM14 = 79
  Public Const LC_CMD_GRID = 101
  Public Const LC_CMD_OSNAP = 102
  Public Const LC_CMD_PTRACK = 103
  Public Const LC_CMD_SELOPTS = 104
  Public Const LC_CMD_QSELECT = 105
  Public Const LC_CMD_KBMOVE = 106
  Public Const LC_CMD_DIST = 111
  Public Const LC_CMD_AREA = 112
  Public Const LC_CMD_SCALEBLK = 113
  Public Const LC_CMD_TSP2 = 116
  Public Const LC_CMD_LIMITS = 117
  Public Const LC_CMD_SAVESTR = 118
  Public Const LC_CMD_DELDUPVER = 119
  Public Const LC_CMD_DELEXVER = 120
  Public Const LC_CMD_UNHIDE = 136
  Public Const LC_CMD_SHDOTS = 137
  Public Const LC_CMD_SMALLVRECT = 138
  Public Const LC_CMD_PLUGINS = 141
  Public Const LC_CMD_CENTERCURSOR = 142
  Public Const LC_CMD_HELP = 1001
  Public Const LC_CMD_RESET = 1003
  Public Const LC_CMD_SW_GRID = 1011
  Public Const LC_CMD_SW_GRIDSNAP = 1012
  Public Const LC_CMD_SW_OSNAP = 1014
  Public Const LC_CMD_SW_PTRACK = 1015
  Public Const LC_CMD_SW_POLAR = 1015
  Public Const LC_CMD_SW_ORTHO = 1016
  Public Const LC_CMD_POINT = 201
  Public Const LC_CMD_LINE = 202
  Public Const LC_LINE_SERIAL = 1
  Public Const LC_LINE_SEPARATE = 2
  Public Const LC_LINE_CONT = 3
  Public Const LC_CMD_XLINE = 203
  Public Const LC_XLINE_BASE = 1
  Public Const LC_XLINE_ANG = 2
  Public Const LC_XLINE_SEP = 3
  Public Const LC_XLINE_RAY = 4
  Public Const LC_XLINE_XLINE = 5
  Public Const LC_CMD_LMESH = 204
  Public Const LC_CMD_POLYLINE = 205
  Public Const LC_CMD_PLINE = 205
  Public Const LC_CMD_SPLINE = 206
  Public Const LC_CMD_RPOLYGON = 207
  Public Const LC_CMD_RECT = 208
  Public Const LC_RECT_2P = 1
  Public Const LC_RECT_3P = 2
  Public Const LC_RECT_CSA = 3
  Public Const LC_CMD_CIRCLE = 209
  Public Const LC_CIRCLE_CR = 1
  Public Const LC_CIRCLE_2P = 2
  Public Const LC_CIRCLE_3P = 3
  Public Const LC_CMD_ARC = 210
  Public Const LC_ARC_SME = 1
  Public Const LC_ARC_SEM = 2
  Public Const LC_ARC_SEC = 3
  Public Const LC_ARC_SED = 4
  Public Const LC_ARC_CSE = 5
  Public Const LC_ARC_CONT = 6
  Public Const LC_CMD_ELLIPSE = 211
  Public Const LC_ELL_AX = 1
  Public Const LC_ELL_CEN = 2
  Public Const LC_ELL_RECT = 3
  Public Const LC_CMD_TEXT = 212
  Public Const LC_CMD_TEXTW = 213
  Public Const LC_CMD_ATEXT = 214
  Public Const LC_CMD_ARCTEXT = 214
  Public Const LC_CMD_MTEXT = 215
  Public Const LC_CMD_INSERT = 216
  Public Const LC_CMD_BLOCKREF = 216
  Public Const LC_INSERT_DLG = 1
  Public Const LC_INSERT_NODLG = 2
  Public Const LC_INSERT_RESET = 3
  Public Const LC_CMD_BARCODE = 217
  Public Const LC_BARCODE_39 = 1
  Public Const LC_BARCODE_93 = 2
  Public Const LC_BARCODE_128 = 3
  Public Const LC_BARCODE_EAN13 = 4
  Public Const LC_BARCODE_EAN8 = 5
  Public Const LC_BARCODE_ITF = 6
  Public Const LC_BARCODE_MQR = 7
  Public Const LC_BARCODE_QR = 8
  Public Const LC_BARCODE_DMATRIX = 9
  Public Const LC_BARCODE_DM = 9
  Public Const LC_BARCODE_DMATRIXR = 10
  Public Const LC_BARCODE_DMR = 10
  Public Const LC_CMD_DIMLIN = 221
  Public Const LC_CMD_DIMROT = 221
  Public Const LC_CMD_DIMALI = 223
  Public Const LC_CMD_DIMORD = 224
  Public Const LC_CMD_DIMRAD = 225
  Public Const LC_CMD_DIMDIA = 226
  Public Const LC_CMD_DIMANG = 227
  Public Const LC_CMD_LEADER = 228
  Public Const LC_CMD_ARROW = 231
  Public Const LC_CMD_SPIRAL = 232
  Public Const LC_CMD_HATCH = 233
  Public Const LC_CMD_ECW = 234
  Public Const LC_CMD_VPORT = 236
  Public Const LC_CMD_VIEWPORT = 236
  Public Const LC_CMD_PTARRAY = 237
  Public Const LC_CMD_FACE = 238
  Public Const LC_CMD_SHAPE = 239
  Public Const LC_CMD_SKETCH = 240
  Public Const LC_CMD_CLOUD = 241
  Public Const LC_CMD_RPLAN = 242
  Public Const LC_CMD_MLINE = 243
  Public Const LC_CMD_BEZIER = 244
  Public Const LC_CMD_BRI = 245
  Public Const LC_CMD_CLIPRECTS = 250
  Public Const LC_CMD_CRECTS = 250
  Public Const LC_CMD_ATTDEF = 251
  Public Const LC_CMD_TIN_LOAD = 301
  Public Const LC_CMD_TIN_LOADPT = 302
  Public Const LC_CMD_TIN_ADDPT = 303
  Public Const LC_CMD_TIN_DELETE = 304
  Public Const LC_CMD_TIN_PROPS = 305
  Public Const LC_CMD_TIN_PTYPES = 306
  Public Const LC_CMD_TIN_MOVEPT = 307
  Public Const LC_CMD_TIN_EDITPT = 308
  Public Const LC_CMD_TIN_DELPT = 309
  Public Const LC_CMD_TIN_BNDDELPT = 310
  Public Const LC_CMD_TIN_DELPTDUP = 311
  Public Const LC_CMD_TIN_DELTRALL = 312
  Public Const LC_CMD_TIN_DELTR = 313
  Public Const LC_CMD_TIN_BNDDELTR = 314
  Public Const LC_CMD_TIN_SWAPTR = 315
  Public Const LC_CMD_TIN_BNDAUTO = 316
  Public Const LC_CMD_TIN_BND = 317
  Public Const LC_CMD_TIN_BNDEDIT = 318
  Public Const LC_CMD_TIN_BNDCLEAR = 319
  Public Const LC_CMD_TIN_BNDTRANG = 320
  Public Const LC_CMD_TIN_BNDTRANG2 = 321
  Public Const LC_CMD_TIN_GENISO = 322
  Public Const LC_CMD_TIN_GENFILL = 323
  Public Const LC_CMD_TIN_RELOAD = 324
  Public Const LC_CMD_TIN_SAVE = 325
  Public Const LC_CMD_TIN_SAVEPT = 326
  Public Const LC_CMD_TIN_BNDSAVE = 327
  Public Const LC_CMD_TIN_BNDPLINE = 328
  Public Const LC_CMD_TIN_Z = 329
  Public Const LC_CMD_TIN_ZOOM = 330
  Public Const LC_CMD_TIN_ISOTODRW = 331
  Public Const LC_CMD_TIN_TILES = 332
  Public Const LC_CMD_CBCUT = 401
  Public Const LC_CMD_CBCOPY = 402
  Public Const LC_CMD_CBPASTE = 403
  Public Const LC_CMD_UNDO = 404
  Public Const LC_CMD_REDO = 405
  Public Const LC_CMD_UNDOCLEAR = 406
  Public Const LC_CMD_COPY = 410
  Public Const LC_COPY_MOVE = 1
  Public Const LC_COPY_ROTATE = 2
  Public Const LC_COPY_SCALE = 3
  Public Const LC_COPY_MIRROR = 4
  Public Const LC_COPY_ARRRECT = 5
  Public Const LC_COPY_ARRCIRC = 6
  Public Const LC_CMD_ERASE = 411
  Public Const LC_CMD_MOVE = 412
  Public Const LC_CMD_ROTATE = 413
  Public Const LC_CMD_SCALE = 414
  Public Const LC_CMD_MIRROR = 415
  Public Const LC_CMD_EXPLODE = 416
  Public Const LC_CMD_SPLIT = 417
  Public Const LC_CMD_JOIN = 418
  Public Const LC_CMD_ORDER = 420
  Public Const LC_ORDER_FRONT = 1
  Public Const LC_ORDER_BACK = 2
  Public Const LC_ORDER_ABOVE = 3
  Public Const LC_ORDER_UNDER = 4
  Public Const LC_ORDER_SWAP = 5
  Public Const LC_CMD_ORDER_SEQ = 430
  Public Const LC_CMD_ALIGN = 431
  Public Const LC_ALIGN_LEFT = 1
  Public Const LC_ALIGN_RIGHT = 2
  Public Const LC_ALIGN_TOP = 3
  Public Const LC_ALIGN_BOTTOM = 4
  Public Const LC_ALIGN_CENTER = 5
  Public Const LC_ALIGN_CENX = 6
  Public Const LC_ALIGN_CENY = 7
  Public Const LC_CMD_CLOSEBLOCK = 439
  Public Const LC_CMD_BASEPOINT = 440
  Public Const LC_CMD_TRIM = 441
  Public Const LC_CMD_EXTEND = 442
  Public Const LC_CMD_OFFSET = 443
  Public Const LC_CMD_OFFSET_POINT = 0
  Public Const LC_CMD_OFFSET_DIST = 1
  Public Const LC_CMD_BREAK = 444
  Public Const LC_CMD_STRETCH = 445
  Public Const LC_CMD_FILLET = 446
  Public Const LC_CMD_IMGRES = 451
  Public Const LC_CMD_IMGPOS = 452
  Public Const LC_CMD_XHL = 461
  Public Const LC_CMD_XHP = 462
  Public Const LC_CMD_JOINALL = 465
  Public Const LC_CMD_ENTEXT = 468
  Public Const LC_CMD_JUMPS = 469
  Public Const LC_CMD_UNSIMG = 470
  Public Const LC_CMD_UPDATE = 474
  Public Const LC_CMD_DELOVER = 475
  Public Const LC_CMD_CMPD = 476
  Public Const LC_CMD_LAYER = 501
  Public Const LC_CMD_LAYERORD = 502
  Public Const LC_CMD_COLOR = 503
  Public Const LC_CMD_FCOLOR = 504
  Public Const LC_CMD_LINETYPE = 505
  Public Const LC_CMD_TEXTSTYLE = 507
  Public Const LC_CMD_BLOCK = 508
  Public Const LC_CMD_CREBLOCK = 508
  Public Const LC_CMD_BLOCKS = 509
  Public Const LC_CMD_IMAGE = 510
  Public Const LC_CMD_PNTSTYLE = 511
  Public Const LC_CMD_DIMSTYLE = 512
  Public Const LC_CMD_MLSTYLE = 513
  Public Const LC_CMD_LINFILL = 515
  Public Const LC_CMD_LAYOUT = 516
  Public Const LC_CMD_XREFS = 517
  Public Const LC_CMD_UNITS = 521
  Public Const LC_CMD_DRWPRM = 522
  Public Const LC_CMD_SYSPRM = 523
  Public Const LC_CMD_3DVIEW = 601
  Public Const LC_CMD_3D = 601
  Public Const LC_CMD_3D_STDVIEW = 602
  Public Const LC_CMD_3D_PARAMS = 603
  Public Const LC_CMD_3D_SAVEIMAGE = 604
  Public Const LC_CMD_AKAGRIP = 29999
  Public Const LC_CMD_CUSTOM = 30000
  Public Const LC_PROP_G_REGCODE = 1
  Public Const LC_PROP_G_VERSION = 2
  Public Const LC_PROP_G_MSGTITLE = 3
  Public Const LC_PROP_G_APPFILENAME = 4
  Public Const LC_PROP_G_DWGAPP = 5
  Public Const LC_PROP_G_DXFAPP = 6
  Public Const LC_PROP_G_HELPFILE = 10
  Public Const LC_PROP_G_DIRDLL = 11
  Public Const LC_PROP_G_DIRFONTS = 13
  Public Const LC_PROP_G_DIRLNG = 14
  Public Const LC_PROP_G_DIRTPL = 16
  Public Const LC_PROP_G_DIRCFG = 17
  Public Const LC_PROP_G_ICON16 = 20
  Public Const LC_PROP_G_ICON32 = 21
  Public Const LC_PROP_G_RULERBMP = 22
  Public Const LC_PROP_G_RULERW = 23
  Public Const LC_PROP_G_RULERFS = 24
  Public Const LC_PROP_G_PRNUSEBMP = 25
  Public Const LC_PROP_G_PRNBMPFILE = 26
  Public Const LC_PROP_G_PRNBTNRAS = 27
  Public Const LC_PROP_G_PRNBTNSRIF = 28
  Public Const LC_PROP_G_PNTPIXSIZE = 29
  Public Const LC_PROP_G_GETDELENT = 30
  Public Const LC_PROP_G_SBARHEIGHT = 32
  Public Const LC_PROP_G_FILEPROGRESS = 33
  Public Const LC_PROP_G_FILEDEFEXT = 35
  Public Const LC_PROP_G_FILELCD = 31
  Public Const LC_PROP_G_DEMOTEXT = 36
  Public Const LC_PROP_G_DEMOSIZE = 37
  Public Const LC_PROP_G_DEMOCOLOR = 38
  Public Const LC_PROP_G_TABCMDWND = 39
  Public Const LC_PROP_G_UNDOMSG = 40
  Public Const LC_PROP_G_MINCHARSIZE = 41
  Public Const LC_PROP_G_PANREDQUAL = 42
  Public Const LC_PROP_G_ENTEXT = 43
  Public Const LC_PROP_G_BLKRELOADMODE = 44
  Public Const LC_PROP_G_TABFILE = 45
  Public Const LC_PROP_G_MSGSAVEAS = 46
  Public Const LC_PROP_G_JUR = 47
  Public Const LC_PROP_G_FILEEXTS = 48
  Public Const LC_PROP_G_DLGVAL = 50
  Public Const LC_PROP_G_STR = 51
  Public Const LC_PROP_G_INT = 52
  Public Const LC_PROP_G_FLOAT = 53
  Public Const LC_PROP_G_HANDLE = 54
  Public Const LC_PROP_G_DELKEYERASE = 55
  Public Const LC_PROP_SEL_PICKBOXSIZE = 61
  Public Const LC_PROP_SEL_PICKBYRECT = 62
  Public Const LC_PROP_SEL_PICKDRAG = 63
  Public Const LC_PROP_SEL_PICKADD = 64
  Public Const LC_PROP_SEL_PICKBYLAYER = 65
  Public Const LC_PROP_SEL_PICKINPGON = 66
  Public Const LC_PROP_SEL_PICKINPGONF = 67
  Public Const LC_PROP_SEL_PICKINIMG = 68
  Public Const LC_PROP_SEL_COLORL1 = 69
  Public Const LC_PROP_SEL_COLORL2 = 70
  Public Const LC_PROP_SEL_COLORF = 71
  Public Const LC_PROP_SEL_HATCHFILL = 72
  Public Const LC_PROP_SEL_ENABLEGRIPS = 73
  Public Const LC_PROP_SEL_GRIPSIZE = 74
  Public Const LC_PROP_SEL_GRIPCOLORF = 75
  Public Const LC_PROP_SEL_GRIPCOLORB = 76
  Public Const LC_PROP_SEL_GRIPENTLIM = 77
  Public Const LC_PROP_SEL_GRIPNUM = 78
  Public Const LC_PROP_G_CAMERA_COUNT = 90
  Public Const LC_PROP_G_CAMERA_I = 91
  Public Const LC_PROP_G_CAMERA_INAME = 92
  Public Const LC_PROP_G_CAMERA_CONNECTED = 93
  Public Const LC_PROP_G_CAMERA_NAME = 94
  Public Const LC_PROP_G_CAMERA_TIME = 95
  Public Const LC_PROP_G_CAMERA_WIDTH = 96
  Public Const LC_PROP_G_CAMERA_HEIGHT = 97
  Public Const LC_PROP_G_CAMERA_BPP = 98
  Public Const LC_PROP_G_CAMERA_COFO = 99
  Public Const LC_PROP_G_CAMERA_BITS = 100
  Public Const LC_PROP_G_CAMERA_BPROW = 101
  Public Const LC_PROP_G_PTBUFNEWPTS = 131
  Public Const LC_PROP_G_PTBUFCLR = 132
  Public Const LC_PROP_G_MPGONCLR = 133
  Public Const LC_PROP_G_TEXT_ALIGN = 141
  Public Const LC_PROP_G_TEXT_H = 142
  Public Const LC_PROP_G_TEXT_WS = 143
  Public Const LC_PROP_G_TEXT_CSPACE = 144
  Public Const LC_PROP_G_TEXT_ANG = 145
  Public Const LC_PROP_G_TEXT_OBL = 146
  Public Const LC_PROP_G_TEXT_UPDOWN = 147
  Public Const LC_PROP_G_TEXT_BACK = 148
  Public Const LC_PROP_G_TEXT_FILL = 149
  Public Const LC_PROP_G_TEXT_BORDER = 150
  Public Const LC_PROP_G_BARC_CENTER = 161
  Public Const LC_PROP_G_BARC_ANGLE = 162
  Public Const LC_PROP_G_BARC_BELOW = 163
  Public Const LC_PROP_G_BARC_QZONE = 164
  Public Const LC_PROP_G_BARC_CHKSUM = 165
  Public Const LC_PROP_G_BARC_ECL = 166
  Public Const LC_PROP_G_BARC_INVERT = 167
  Public Const LC_PROP_G_BARC_WRATIO = 168
  Public Const LC_PROP_G_BARC_LINEW = 169
  Public Const LC_PROP_G_BEAMCOLOR0D = 191
  Public Const LC_PROP_G_BEAMCOLOR1D = 192
  Public Const LC_PROP_G_BEAMCOLOR2D = 193
  Public Const LC_PROP_G_BEAMCOLOR0U = 194
  Public Const LC_PROP_G_BEAMCOLOR1U = 195
  Public Const LC_PROP_G_BEAMCOLOR2U = 196
  Public Const LC_PROP_G_NAV_LEFT = 201
  Public Const LC_PROP_G_NAV_TOP = 202
  Public Const LC_PROP_G_NAV_WIDTH = 203
  Public Const LC_PROP_G_NAV_HEIGHT = 204
  Public Const LC_PROP_G_JL_EALEN = 210
  Public Const LC_PROP_G_JL_EAW = 211
  Public Const LC_PROP_G_JL_JALEN = 212
  Public Const LC_PROP_G_JL_JAW = 213
  Public Const LC_PROP_G_JL_ACOLOR = 214
  Public Const LC_PROP_G_JL_NUMFONT = 215
  Public Const LC_PROP_G_JL_NUMSIZE = 216
  Public Const LC_PROP_G_JL_NUMCOLOR = 217
  Public Const LC_PROP_G_JL_DRAWJARR = 218
  Public Const LC_PROP_G_JL_DRAWJLINE = 219
  Public Const LC_PROP_G_JL_DRAWEDOT = 220
  Public Const LC_PROP_G_JL_DRAWEARR = 221
  Public Const LC_PROP_G_JL_DRAWENUM = 222
  Public Const LC_PROP_G_OSNAP_MARK = 226
  Public Const LC_PROP_G_OSNAP_APER = 227
  Public Const LC_PROP_G_OSNAP_MARKSIZE = 228
  Public Const LC_PROP_G_OSNAP_APERSIZE = 229
  Public Const LC_PROP_G_OSNAP_MARKCOLOR = 230
  Public Const LC_PROP_G_EMUL_OVERDIST = 232
  Public Const LC_PROP_G_EMUL_OVERCOLOR = 233
  Public Const LC_PROP_G_RAS_FILL = 250
  Public Const LC_PROP_G_RAS_COLOR = 251
  Public Const LC_PROP_G_RAS_NOPRINT = 252
  Public Const LC_PROP_G_WPT_TEXTX = 260
  Public Const LC_PROP_G_WPT_TEXTY = 261
  Public Const LC_PROP_G_WPT_TEXTA = 262
  Public Const LC_PROP_G_TIN_PT0 = 270
  Public Const LC_PROP_G_TIN_PT1 = 271
  Public Const LC_PROP_G_TIN_TR = 272
  Public Const LC_PROP_WND_ID = 301
  Public Const LC_PROP_WND_WIDTH = 302
  Public Const LC_PROP_WND_HEIGHT = 303
  Public Const LC_PROP_WND_PIXELSIZE = 304
  Public Const LC_PROP_WND_PICKBOXSIZE = 305
  Public Const LC_PROP_WND_CURSORX = 306
  Public Const LC_PROP_WND_CURX = 306
  Public Const LC_PROP_WND_CURSORY = 307
  Public Const LC_PROP_WND_CURY = 307
  Public Const LC_PROP_WND_CURLEF = 308
  Public Const LC_PROP_WND_CURBOT = 309
  Public Const LC_PROP_WND_CURRIG = 310
  Public Const LC_PROP_WND_CURTOP = 311
  Public Const LC_PROP_WND_XMIN = 312
  Public Const LC_PROP_WND_YMIN = 313
  Public Const LC_PROP_WND_XMAX = 314
  Public Const LC_PROP_WND_YMAX = 315
  Public Const LC_PROP_WND_XCEN = 316
  Public Const LC_PROP_WND_YCEN = 317
  Public Const LC_PROP_WND_DX = 318
  Public Const LC_PROP_WND_DY = 319
  Public Const LC_PROP_WND_RULERSENABLE = 320
  Public Const LC_PROP_WND_RULERS = 321
  Public Const LC_PROP_WND_SELECT = 322
  Public Const LC_PROP_WND_VIEWBLOCK = 323
  Public Const LC_PROP_WND_BLOCK = 323
  Public Const LC_PROP_WND_DRW = 324
  Public Const LC_PROP_WND_HWND = 325
  Public Const LC_PROP_WND_HASFOCUS = 326
  Public Const LC_PROP_WND_HASFILETABS = 327
  Public Const LC_PROP_WND_NUMFILETABS = 328
  Public Const LC_PROP_WND_NUMDRW = 328
  Public Const LC_PROP_WND_DROPFILES = 329
  Public Const LC_PROP_WND_ZOOMWHEEL = 330
  Public Const LC_PROP_WND_JUMPLINES = 339
  Public Const LC_PROP_WND_MAGNIFIER = 340
  Public Const LC_PROP_WND_NAVIGATOR = 341
  Public Const LC_PROP_WND_COLORBG = 342
  Public Const LC_PROP_WND_COLORCURSOR = 343
  Public Const LC_PROP_WND_COLORFORE = 344
  Public Const LC_PROP_WND_COLORINFBG = 345
  Public Const LC_PROP_WND_COLORINFBORD = 346
  Public Const LC_PROP_WND_COLORINFTEXT = 347
  Public Const LC_PROP_WND_CURSORSYS = 348
  Public Const LC_PROP_WND_CURSORARROW = 348
  Public Const LC_PROP_WND_CURSORCROSS = 349
  Public Const LC_PROP_WND_CURSORSIZE = 350
  Public Const LC_PROP_WND_CURSORPBOX = 351
  Public Const LC_PROP_WND_COORDS = 352
  Public Const LC_PROP_WND_ENT = 353
  Public Const LC_PROP_WND_PROPWND = 354
  Public Const LC_PROP_WND_BLOCKBPT = 355
  Public Const LC_PROP_WND_LWMODE = 355
  Public Const LC_PROP_WND_LWSCALE = 356
  Public Const LC_PROP_WND_ALPHABLEND = 360
  Public Const LC_PROP_WND_STDBLKFRAME = 361
  Public Const LC_PROP_WND_BLKBASEPT = 362
  Public Const LC_PROP_WND_SIZE = 363
  Public Const LC_PROP_WND_DTIME = 364
  Public Const LC_PROP_WND_DRAWPAPER = 365
  Public Const LC_PROP_WND_FROZEN = 366
  Public Const LC_PROP_WND_FROZENVIEW = 367
  Public Const LC_PROP_WND_COMMAND = 368
  Public Const LC_PROP_WND_CMD = 368
  Public Const LC_PROP_WND_CMDENT1 = 369
  Public Const LC_PROP_WND_OSNAP = 370
  Public Const LC_PROP_WND_OSNAPMENU = 371
  Public Const LC_PROP_WND_ORTHO = 372
  Public Const LC_PROP_WND_PTRACK = 373
  Public Const LC_PROP_WND_PTRACK_ANGLE = 374
  Public Const LC_PROP_WND_PTRACK_ANGREL = 375
  Public Const LC_PROP_WND_PTRACK_DIST = 376
  Public Const LC_PROP_WND_BASEPT = 377
  Public Const LC_PROP_WND_BASEX = 378
  Public Const LC_PROP_WND_BASEY = 379
  Public Const LC_PROP_WND_GRIDSNAP = 380
  Public Const LC_PROP_WND_GRIDSHOW = 381
  Public Const LC_PROP_WND_GRIDDX = 382
  Public Const LC_PROP_WND_GRIDDY = 383
  Public Const LC_PROP_WND_GRIDX0 = 384
  Public Const LC_PROP_WND_GRIDY0 = 385
  Public Const LC_PROP_WND_GRIDBOLDX = 386
  Public Const LC_PROP_WND_GRIDBOLDY = 387
  Public Const LC_PROP_WND_GRIDCOLOR = 388
  Public Const LC_PROP_WND_GRIDDOTTED = 389
  Public Const LC_PROP_WND_GRIDCOLOR2 = 390
  Public Const LC_PROP_WND_GRIDDOTTED2 = 391
  Public Const LC_PROP_WND_RSNAP = 402
  Public Const LC_PROP_WND_RSNAPSHOW = 403
  Public Const LC_PROP_WND_RSNAPLEF = 404
  Public Const LC_PROP_WND_RSNAPBOT = 405
  Public Const LC_PROP_WND_RSNAPRIG = 406
  Public Const LC_PROP_WND_RSNAPTOP = 407
  Public Const LC_PROP_WND_RSNAPW = 408
  Public Const LC_PROP_WND_RSNAPH = 409
  Public Const LC_PROP_WND_RSNAPCOLORM = 410
  Public Const LC_PROP_WND_RSNAPCOLORP = 411
  Public Const LC_PROP_WND_PANSTEP = 420
  Public Const LC_PROP_WND_PANLW = 421
  Public Const LC_PROP_WND_PANIMAGE = 422
  Public Const LC_PROP_WND_PANFILL = 423
  Public Const LC_PROP_WND_PANPIXSZ = 424
  Public Const LC_PROP_WND_MEASCOLORPNT = 430
  Public Const LC_PROP_WND_MEASCOLORLINE = 431
  Public Const LC_PROP_WND_MEASLINESIZE = 432
  Public Const LC_PROP_WND_MEASFONTSIZE = 433
  Public Const LC_PROP_WND_MEASFILLAREA = 434
  Public Const LC_PROP_WND_KBMOVE_ENABLE = 437
  Public Const LC_PROP_WND_KBMOVE_DIST = 438
  Public Const LC_PROP_WND_KBMOVE_ANGLE = 439
  Public Const LC_PROP_WND_KBMOVE_SCALE = 440
  Public Const LC_PROP_WND_XLINEANG = 444
  Public Const LC_PROP_WND_BGIMAGE = 445
  Public Const LC_PROP_WND_LTVIEWMIN = 446
  Public Const LC_PROP_WND_LTVIEWMAX = 447
  Public Const LC_PROP_WND_FRAME_LEFT = 451
  Public Const LC_PROP_WND_FRAME_TOP = 452
  Public Const LC_PROP_WND_FRAME_WIDTH = 453
  Public Const LC_PROP_WND_FRAME_HEIGHT = 454
  Public Const LC_PROP_WND_HANDLE0 = 460
  Public Const LC_PROP_WND_HANDLE1 = 461
  Public Const LC_PROP_WND_HANDLE2 = 462
  Public Const LC_PROP_WND_HANDLE3 = 463
  Public Const LC_PROP_WND_HANDLE4 = 464
  Public Const LC_PROP_WND_HANDLE5 = 465
  Public Const LC_PROP_WND_HANDLE6 = 466
  Public Const LC_PROP_WND_HANDLE7 = 467
  Public Const LC_PROP_WND_HANDLE8 = 468
  Public Const LC_PROP_WND_HANDLE9 = 469
  Public Const LC_PROP_WND_INT0 = 470
  Public Const LC_PROP_WND_INT1 = 471
  Public Const LC_PROP_WND_INT2 = 472
  Public Const LC_PROP_WND_INT3 = 473
  Public Const LC_PROP_WND_INT4 = 474
  Public Const LC_PROP_WND_INT5 = 475
  Public Const LC_PROP_WND_INT6 = 476
  Public Const LC_PROP_WND_INT7 = 477
  Public Const LC_PROP_WND_INT8 = 478
  Public Const LC_PROP_WND_INT9 = 479
  Public Const LC_PROP_WND_FLOAT0 = 480
  Public Const LC_PROP_WND_FLOAT1 = 481
  Public Const LC_PROP_WND_FLOAT2 = 482
  Public Const LC_PROP_WND_FLOAT3 = 483
  Public Const LC_PROP_WND_FLOAT4 = 484
  Public Const LC_PROP_WND_FLOAT5 = 485
  Public Const LC_PROP_WND_FLOAT6 = 486
  Public Const LC_PROP_WND_FLOAT7 = 487
  Public Const LC_PROP_WND_FLOAT8 = 488
  Public Const LC_PROP_WND_FLOAT9 = 489
  Public Const LC_PROP_WND_STR0 = 490
  Public Const LC_PROP_WND_STR1 = 491
  Public Const LC_PROP_WND_STR2 = 492
  Public Const LC_PROP_WND_STR3 = 493
  Public Const LC_PROP_WND_STR4 = 494
  Public Const LC_PROP_WND_STR5 = 495
  Public Const LC_PROP_WND_STR6 = 496
  Public Const LC_PROP_WND_STR7 = 497
  Public Const LC_PROP_WND_STR8 = 498
  Public Const LC_PROP_WND_STR9 = 499
  Public Const LC_PROP_SBAR_H = 501
  Public Const LC_PROP_SBAR_FONTNAME = 502
  Public Const LC_PROP_SBAR_FONTSIZE = 503
  Public Const LC_PROP_SBAR_TEXTY = 504
  Public Const LC_PROP_SBAR_TEXTCOLOR = 505
  Public Const LC_PROP_SBAR_BGCOLOR = 506
  Public Const LC_PROP_SBAR_FRAMECOLOR = 507
  Public Const LC_PROP_FONT_FILENAME = 601
  Public Const LC_PROP_FONT_NAME = 602
  Public Const LC_PROP_FONT_LCF = 603
  Public Const LC_PROP_FONT_HEIGHT = 604
  Public Const LC_PROP_FONT_FILLED = 605
  Public Const LC_PROP_FONT_TTF = 606
  Public Const LC_PROP_FONT_NCHARS = 607
  Public Const LC_PROP_MPGON_XMIN = 631
  Public Const LC_PROP_MPGON_YMIN = 632
  Public Const LC_PROP_MPGON_XMAX = 633
  Public Const LC_PROP_MPGON_YMAX = 634
  Public Const LC_PROP_MPGON_XCEN = 635
  Public Const LC_PROP_MPGON_YCEN = 636
  Public Const LC_PROP_MPGON_W = 637
  Public Const LC_PROP_MPGON_H = 638
  Public Const LC_PROP_TINPTYPE_NAME = 680
  Public Const LC_PROP_TINPTYPE_DTEXT = 681
  Public Const LC_PROP_TINPTYPE_COLOR = 682
  Public Const LC_PROP_TINPNT_TYPE = 701
  Public Const LC_PROP_TINPNT_I = 702
  Public Const LC_PROP_TINPNT_X = 703
  Public Const LC_PROP_TINPNT_Y = 704
  Public Const LC_PROP_TINPNT_Z = 705
  Public Const LC_PROP_TINPNT_COLOR = 706
  Public Const LC_PROP_TINPNT_NAME = 707
  Public Const LC_PROP_TINPNT_ONAME = 708
  Public Const LC_PROP_TINPNT_DESCR = 709
  Public Const LC_PROP_TINPNT_IMGFILE = 715
  Public Const LC_PROP_TINPNT_IMGFILE2 = 716
  Public Const LC_PROP_TINPNT_ATTR = 720
  Public Const LC_PROP_TINPNT_ATTR1 = 721
  Public Const LC_PROP_TINPNT_ATTR2 = 722
  Public Const LC_PROP_TINPNT_ATTR3 = 723
  Public Const LC_PROP_TINPNT_ATTR4 = 724
  Public Const LC_PROP_TINPNT_ATTR5 = 725
  Public Const LC_PROP_TINPNT_ATTR6 = 726
  Public Const LC_PROP_TINPNT_ATTR7 = 727
  Public Const LC_PROP_TINPNT_ATTR8 = 728
  Public Const LC_PROP_TINPNT_ATTR9 = 729
  Public Const LC_PROP_TINTR_I = 731
  Public Const LC_PROP_TINTR_IPT0 = 732
  Public Const LC_PROP_TINTR_IPT1 = 733
  Public Const LC_PROP_TINTR_IPT2 = 734
  Public Const LC_PROP_TINTR_PT0 = 735
  Public Const LC_PROP_TINTR_PT1 = 736
  Public Const LC_PROP_TINTR_PT2 = 737
  Public Const LC_PROP_TINTR_PT0X = 738
  Public Const LC_PROP_TINTR_PT0Y = 739
  Public Const LC_PROP_TINTR_PT0Z = 740
  Public Const LC_PROP_TINTR_PT1X = 741
  Public Const LC_PROP_TINTR_PT1Y = 742
  Public Const LC_PROP_TINTR_PT1Z = 743
  Public Const LC_PROP_TINTR_PT2X = 744
  Public Const LC_PROP_TINTR_PT2Y = 745
  Public Const LC_PROP_TINTR_PT2Z = 746
  Public Const LC_PROP_TINTR_XC = 747
  Public Const LC_PROP_TINTR_YC = 748
  Public Const LC_PROP_TINTR_ZC = 749
  Public Const LC_PROP_TINTR_NVX = 750
  Public Const LC_PROP_TINTR_NVY = 751
  Public Const LC_PROP_TINTR_NVZ = 752
  Public Const LC_PROP_TINTR_NANG = 753
  Public Const LC_PROP_TINTR_XMIN = 754
  Public Const LC_PROP_TINTR_YMIN = 755
  Public Const LC_PROP_TINTR_ZMIN = 756
  Public Const LC_PROP_TINTR_XMAX = 757
  Public Const LC_PROP_TINTR_YMAX = 758
  Public Const LC_PROP_TINTR_ZMAX = 759
  Public Const LC_PROP_TINTR_DX = 760
  Public Const LC_PROP_TINTR_DY = 761
  Public Const LC_PROP_TINTR_DZ = 762
  Public Const LC_PROP_TINTR_FLAGS = 763
  Public Const LC_PROP_TINTR_MARK = 764
  Public Const LC_PROP_TINTR_EDGE_PT0 = 771
  Public Const LC_PROP_TINTR_EDGE_PT1 = 772
  Public Const LC_PROP_TINTR_EDGE_TR = 773
  Public Const LC_PROP_TINISO_Z = 781
  Public Const LC_PROP_TINISO_NVERS = 782
  Public Const LC_PROP_TINISO_IVER = 783
  Public Const LC_PROP_TINISO_X = 784
  Public Const LC_PROP_TINISO_Y = 785
  Public Const LC_PROP_TINISO_CLOSED = 786
  Public Const LC_PROP_GRID_XMIN = 1882
  Public Const LC_PROP_GRID_XMAX = 1883
  Public Const LC_PROP_GRID_YMIN = 1884
  Public Const LC_PROP_GRID_YMAX = 1885
  Public Const LC_PROP_GRID_W = 1886
  Public Const LC_PROP_GRID_H = 1887
  Public Const LC_PROP_GRID_NCELLX = 1888
  Public Const LC_PROP_GRID_NCELLY = 1889
  Public Const LC_PROP_CMD_ID = 2001
  Public Const LC_PROP_CMD_PARAM = 2002
  Public Const LC_PROP_CMD_STEP = 2003
  Public Const LC_PROP_CMD_LCWND = 2004
  Public Const LC_PROP_CMD_HWND = 2005
  Public Const LC_PROP_CMD_DRW = 2006
  Public Const LC_PROP_CMD_BLOCK = 2007
  Public Const LC_PROP_CMD_CURSORCROSS = 2008
  Public Const LC_PROP_CMD_INT0 = 2010
  Public Const LC_PROP_CMD_INT1 = 2011
  Public Const LC_PROP_CMD_INT2 = 2012
  Public Const LC_PROP_CMD_INT3 = 2013
  Public Const LC_PROP_CMD_INT4 = 2014
  Public Const LC_PROP_CMD_INT5 = 2015
  Public Const LC_PROP_CMD_INT6 = 2016
  Public Const LC_PROP_CMD_INT7 = 2017
  Public Const LC_PROP_CMD_INT8 = 2018
  Public Const LC_PROP_CMD_INT9 = 2019
  Public Const LC_PROP_CMD_FLOAT0 = 2020
  Public Const LC_PROP_CMD_FLOAT1 = 2021
  Public Const LC_PROP_CMD_FLOAT2 = 2022
  Public Const LC_PROP_CMD_FLOAT3 = 2023
  Public Const LC_PROP_CMD_FLOAT4 = 2024
  Public Const LC_PROP_CMD_FLOAT5 = 2025
  Public Const LC_PROP_CMD_FLOAT6 = 2026
  Public Const LC_PROP_CMD_FLOAT7 = 2027
  Public Const LC_PROP_CMD_FLOAT8 = 2028
  Public Const LC_PROP_CMD_FLOAT9 = 2029
  Public Const LC_PROP_CMD_HAND0 = 2030
  Public Const LC_PROP_CMD_HAND1 = 2031
  Public Const LC_PROP_CMD_HAND2 = 2032
  Public Const LC_PROP_CMD_HAND3 = 2033
  Public Const LC_PROP_CMD_HAND4 = 2034
  Public Const LC_PROP_CMD_HAND5 = 2035
  Public Const LC_PROP_CMD_HAND6 = 2036
  Public Const LC_PROP_CMD_HAND7 = 2037
  Public Const LC_PROP_CMD_HAND8 = 2038
  Public Const LC_PROP_CMD_HAND9 = 2039
  Public Const LC_PROP_CMD_STR = 2040
  Public Const LC_PROP_DRW_UID = 3001
  Public Const LC_PROP_DRW_FILENAME = 3002
  Public Const LC_PROP_DRW_DESCR = 3003
  Public Const LC_PROP_DRW_COMMENT = 3003
  Public Const LC_PROP_DRW_READONLY = 3004
  Public Const LC_PROP_DRW_DIRTY = 3005
  Public Const LC_PROP_DRW_IDMAX = 3006
  Public Const LC_PROP_DRW_SYNCZOOM = 3011
  Public Const LC_PROP_DRW_HASALPHABLEND = 3013
  Public Const LC_PROP_DRW_BLKREFGRIPS = 3014
  Public Const LC_PROP_DRW_JL_BASE = 3015
  Public Const LC_PROP_DRW_JL_BASEX = 3016
  Public Const LC_PROP_DRW_JL_BASEY = 3017
  Public Const LC_PROP_DRW_JL_LAYER = 3018
  Public Const LC_PROP_DRW_EXTOFFLAYER = 3019
  Public Const LC_PROP_DRW_ENABLEUNDO = 3021
  Public Const LC_PROP_DRW_LOCKSEL = 3022
  Public Const LC_PROP_DRW_MAXHATDASH = 3023
  Public Const LC_PROP_DRW_PROPLINFILL = 3024
  Public Const LC_PROP_DRW_PROPZTH = 3025
  Public Const LC_PROP_DRW_3DVIEW = 3026
  Public Const LC_PROP_DRW_PBTEXT = 3027
  Public Const LC_PROP_DRW_LUNITS = 3031
  Public Const LC_PROP_DRW_LUPREC = 3032
  Public Const LC_PROP_DRW_AUNITS = 3033
  Public Const LC_PROP_DRW_AUPREC = 3034
  Public Const LC_PROP_DRW_ANGBASE = 3035
  Public Const LC_PROP_DRW_ANGDIR = 3036
  Public Const LC_PROP_DRW_INSUNITS = 3037
  Public Const LC_PROP_DRW_PDMODE = 3038
  Public Const LC_PROP_DRW_PDSIZE = 3039
  Public Const LC_PROP_DRW_CMLJUST = 3040
  Public Const LC_PROP_DRW_CMLSCALE = 3041
  Public Const LC_PROP_DRW_COLORBACKM = 3051
  Public Const LC_PROP_DRW_COLORBACKP = 3052
  Public Const LC_PROP_DRW_COLORFOREM = 3053
  Public Const LC_PROP_DRW_COLORFOREP = 3054
  Public Const LC_PROP_DRW_COLORCURSORM = 3055
  Public Const LC_PROP_DRW_COLORCURSORP = 3056
  Public Const LC_PROP_DRW_COLORPAPER = 3057
  Public Const LC_PROP_DRW_COLOR = 3061
  Public Const LC_PROP_DRW_COLORBYLAYER = 3062
  Public Const LC_PROP_DRW_COLORBYBLOCK = 3063
  Public Const LC_PROP_DRW_COLORI = 3064
  Public Const LC_PROP_DRW_COLORT = 3065
  Public Const LC_PROP_DRW_FCOLOR = 3066
  Public Const LC_PROP_DRW_FCOLORBYLAYER = 3067
  Public Const LC_PROP_DRW_FCOLORBYBLOCK = 3068
  Public Const LC_PROP_DRW_FCOLORI = 3069
  Public Const LC_PROP_DRW_FCOLORT = 3070
  Public Const LC_PROP_DRW_LAYER = 3081
  Public Const LC_PROP_DRW_LINETYPE = 3082
  Public Const LC_PROP_DRW_LTSCALE = 3083
  Public Const LC_PROP_DRW_TEXTSTYLE = 3084
  Public Const LC_PROP_DRW_DIMSTYLE = 3085
  Public Const LC_PROP_DRW_PNTSTYLE = 3086
  Public Const LC_PROP_DRW_MLSTYLE = 3087
  Public Const LC_PROP_DRW_BLOCK = 3089
  Public Const LC_PROP_DRW_VISBLOCK = 3090
  Public Const LC_PROP_DRW_LAYOUT = 3091
  Public Const LC_PROP_DRW_BARCTYPE = 3092
  Public Const LC_PROP_DRW_BARCSOLID = 3093
  Public Const LC_PROP_DRW_LWMODE = 3094
  Public Const LC_PROP_DRW_LWSCALE = 3095
  Public Const LC_PROP_DRW_LWIDTH = 3096
  Public Const LC_PROP_DRW_LWDEFAULT = 3097
  Public Const LC_PROP_DRW_LINFILL = 3098
  Public Const LC_PROP_DRW_TINPNT = 3102
  Public Const LC_PROP_DRW_TINTR = 3103
  Public Const LC_PROP_DRW_TINXY0 = 3104
  Public Const LC_PROP_DRW_EXPLODEARC = 3131
  Public Const LC_PROP_DRW_EXPPLINELA = 3132
  Public Const LC_PROP_DRW_EXPSIMPLINE = 3133
  Public Const LC_PROP_DRW_EXPTEXTSPLINE = 3134
  Public Const LC_PROP_DRW_BLOCK_MODEL = 3151
  Public Const LC_PROP_DRW_LAYER_0 = 3152
  Public Const LC_PROP_DRW_LINETYPE_CONT = 3153
  Public Const LC_PROP_DRW_LINETYPE_BYLAY = 3154
  Public Const LC_PROP_DRW_LINETYPE_BYBLK = 3155
  Public Const LC_PROP_DRW_TEXTSTYLE_STD = 3156
  Public Const LC_PROP_DRW_TSTYLE_STD = 3156
  Public Const LC_PROP_DRW_PNTSTYLE_STD = 3157
  Public Const LC_PROP_DRW_DIMSTYLE_STD = 3158
  Public Const LC_PROP_DRW_MLSTYLE_STD = 3159
  Public Const LC_PROP_DRW_RESOLARC = 3171
  Public Const LC_PROP_DRW_RESOLSPLINE = 3172
  Public Const LC_PROP_DRW_RESOLTEXT = 3173
  Public Const LC_PROP_DRW_LIM_MINPIXSIZE = 3181
  Public Const LC_PROP_DRW_LIM_MAXLEF = 3182
  Public Const LC_PROP_DRW_LIM_MAXBOT = 3183
  Public Const LC_PROP_DRW_LIM_MAXRIG = 3184
  Public Const LC_PROP_DRW_LIM_MAXTOP = 3185
  Public Const LC_PROP_DRW_LIM_MAXON = 3186
  Public Const LC_PROP_DRW_XDATASIZE = 3251
  Public Const LC_PROP_DRW_XDATA = 3252
  Public Const LC_PROP_DRW_INT0 = 3260
  Public Const LC_PROP_DRW_INT1 = 3261
  Public Const LC_PROP_DRW_INT2 = 3262
  Public Const LC_PROP_DRW_INT3 = 3263
  Public Const LC_PROP_DRW_INT4 = 3264
  Public Const LC_PROP_DRW_INT5 = 3265
  Public Const LC_PROP_DRW_INT6 = 3266
  Public Const LC_PROP_DRW_INT7 = 3267
  Public Const LC_PROP_DRW_INT8 = 3268
  Public Const LC_PROP_DRW_INT9 = 3269
  Public Const LC_PROP_DRW_FLOAT0 = 3270
  Public Const LC_PROP_DRW_FLOAT1 = 3271
  Public Const LC_PROP_DRW_FLOAT2 = 3272
  Public Const LC_PROP_DRW_FLOAT3 = 3273
  Public Const LC_PROP_DRW_FLOAT4 = 3274
  Public Const LC_PROP_DRW_FLOAT5 = 3275
  Public Const LC_PROP_DRW_FLOAT6 = 3276
  Public Const LC_PROP_DRW_FLOAT7 = 3277
  Public Const LC_PROP_DRW_FLOAT8 = 3278
  Public Const LC_PROP_DRW_FLOAT9 = 3279
  Public Const LC_PROP_DRW_STR0 = 3280
  Public Const LC_PROP_DRW_STR1 = 3281
  Public Const LC_PROP_DRW_STR2 = 3282
  Public Const LC_PROP_DRW_STR3 = 3283
  Public Const LC_PROP_DRW_STR4 = 3284
  Public Const LC_PROP_DRW_STR5 = 3285
  Public Const LC_PROP_DRW_STR6 = 3286
  Public Const LC_PROP_DRW_STR7 = 3287
  Public Const LC_PROP_DRW_STR8 = 3288
  Public Const LC_PROP_DRW_STR9 = 3289
  Public Const LC_PROP_TABLE_ID = 4001
  Public Const LC_PROP_TABLE_NAME = 4002
  Public Const LC_PROP_TABLE_DESC = 4003
  Public Const LC_PROP_TABLE_DESCR = 4003
  Public Const LC_PROP_TABLE_DRW = 4004
  Public Const LC_PROP_TABLE_DELETED = 4005
  Public Const LC_PROP_TABLE_ODA_HANDLE = 4010
  Public Const LC_PROP_TABLE_TYPE = 4011
  Public Const LC_PROP_TABLE_PRIORITY = 4012
  Public Const LC_PROP_TABLE_NREFS = 4013
  Public Const LC_PROP_TABLE_XDATASIZE = 4051
  Public Const LC_PROP_TABLE_XDATA = 4052
  Public Const LC_PROP_TABLE_XSTR = 4053
  Public Const LC_PROP_TABLE_INT0 = 4060
  Public Const LC_PROP_TABLE_INT1 = 4061
  Public Const LC_PROP_TABLE_INT2 = 4062
  Public Const LC_PROP_TABLE_INT3 = 4063
  Public Const LC_PROP_TABLE_INT4 = 4064
  Public Const LC_PROP_TABLE_FLOAT0 = 4070
  Public Const LC_PROP_TABLE_FLOAT1 = 4071
  Public Const LC_PROP_TABLE_FLOAT2 = 4072
  Public Const LC_PROP_TABLE_FLOAT3 = 4073
  Public Const LC_PROP_TABLE_FLOAT4 = 4074
  Public Const LC_PROP_LAYER_ID = 4001
  Public Const LC_PROP_LAYER_NAME = 4002
  Public Const LC_PROP_LAYER_DESC = 4003
  Public Const LC_PROP_LAYER_DESCR = 4003
  Public Const LC_PROP_LAYER_DRW = 4004
  Public Const LC_PROP_LAYER_DELETED = 4005
  Public Const LC_PROP_LAYER_COLOR = 4101
  Public Const LC_PROP_LAYER_COLORI = 4102
  Public Const LC_PROP_LAYER_COLORT = 4103
  Public Const LC_PROP_LAYER_FCOLOR = 4104
  Public Const LC_PROP_LAYER_FCOLORI = 4105
  Public Const LC_PROP_LAYER_FCOLORT = 4106
  Public Const LC_PROP_LAYER_LINETYPE = 4111
  Public Const LC_PROP_LAYER_LWEIGHT = 4112
  Public Const LC_PROP_LAYER_LWIDTH = 4112
  Public Const LC_PROP_LAYER_LOCKED = 4113
  Public Const LC_PROP_LAYER_NOPRINT = 4114
  Public Const LC_PROP_LAYER_VISIBLE = 4115
  Public Const LC_PROP_LAYER_0 = 4116
  Public Const LC_PROP_LAYER_NODLG = 4117
  Public Const LC_PROP_LAYER_JUMPLINES = 4118
  Public Const LC_PROP_LAYER_OSNAP = 4119
  Public Const LC_PROP_LAYER_NOEXPORT = 4120
  Public Const LC_PROP_LINETYPE_ID = 4001
  Public Const LC_PROP_LINETYPE_NAME = 4002
  Public Const LC_PROP_LINETYPE_DESC = 4003
  Public Const LC_PROP_LINETYPE_DESCR = 4003
  Public Const LC_PROP_LINETYPE_DRW = 4004
  Public Const LC_PROP_LINETYPE_DELETED = 4005
  Public Const LC_PROP_LINETYPE_DATA = 4145
  Public Const LC_PROP_LINETYPE_SCALE = 4146
  Public Const LC_PROP_LINETYPE_CONTINUOUS = 4147
  Public Const LC_PROP_LINETYPE_BYLAYER = 4148
  Public Const LC_PROP_LINETYPE_BYBLOCK = 4149
  Public Const LC_PROP_LINETYPE_STD = 4150
  Public Const LC_PROP_LINETYPE_PATLEN = 4151
  Public Const LC_PROP_LINETYPE_NELEM = 4153
  Public Const LC_PROP_LINETYPE_IELEM = 4154
  Public Const LC_PROP_LTELEM_LEN = 4155
  Public Const LC_PROP_LTELEM_COMPLEX = 4156
  Public Const LC_PROP_LTELEM_SHAPE = 4157
  Public Const LC_PROP_LTELEM_TEXT = 4158
  Public Const LC_PROP_LTELEM_STYLE = 4159
  Public Const LC_PROP_LTELEM_FONTNAME = 4160
  Public Const LC_PROP_LTELEM_SCALE = 4161
  Public Const LC_PROP_LTELEM_ANGLE = 4162
  Public Const LC_PROP_LTELEM_ABSANGLE = 4163
  Public Const LC_PROP_LTELEM_X = 4164
  Public Const LC_PROP_LTELEM_Y = 4165
  Public Const LC_PROP_TSTYLE_ID = 4001
  Public Const LC_PROP_TSTYLE_NAME = 4002
  Public Const LC_PROP_TSTYLE_DESC = 4003
  Public Const LC_PROP_TSTYLE_DESCR = 4003
  Public Const LC_PROP_TSTYLE_DRW = 4004
  Public Const LC_PROP_TSTYLE_DELETED = 4005
  Public Const LC_PROP_TSTYLE_FONT = 4175
  Public Const LC_PROP_TSTYLE_HFONT = 4176
  Public Const LC_PROP_TSTYLE_HEIGHT = 4177
  Public Const LC_PROP_TSTYLE_WSCALE = 4178
  Public Const LC_PROP_TSTYLE_OBLIQUE = 4179
  Public Const LC_PROP_TSTYLE_ANGLE = 4180
  Public Const LC_PROP_TSTYLE_ALIGN = 4181
  Public Const LC_PROP_TSTYLE_UPDOWN = 4182
  Public Const LC_PROP_TSTYLE_BACKWARD = 4183
  Public Const LC_PROP_TSTYLE_LINESPACE = 4184
  Public Const LC_PROP_TSTYLE_CHARSPACE = 4185
  Public Const LC_PROP_TSTYLE_STANDARD = 4186
  Public Const LC_PROP_TSTYLE_SHAPES = 4187
  Public Const LC_PROP_TSTYLE_WINFONT = 4188
  Public Const LC_PROP_TSTYLE_SOLID = 4189
  Public Const LC_PROP_TSTYLE_CLOSED = 4190
  Public Const LC_PROP_TSTYLE_HOLLOW = 4191
  Public Const LC_PROP_TSTYLE_BOLD = 4192
  Public Const LC_PROP_TSTYLE_ITALIC = 4193
  Public Const LC_PROP_TSTYLE_UNDERLINE = 4194
  Public Const LC_PROP_TSTYLE_STRIKEOUT = 4195
  Public Const LC_PROP_TSTYLE_MONOWIDTH = 4196
  Public Const LC_PROP_DIMST_ID = 4001
  Public Const LC_PROP_DIMST_NAME = 4002
  Public Const LC_PROP_DIMST_DESC = 4003
  Public Const LC_PROP_DIMST_DESCR = 4003
  Public Const LC_PROP_DIMST_DRW = 4004
  Public Const LC_PROP_DIMST_DELETED = 4005
  Public Const LC_PROP_DIMST_STANDARD = 4205
  Public Const LC_PROP_DIMST_ADEC = 4211
  Public Const LC_PROP_DIMST_ASZ = 4212
  Public Const LC_PROP_DIMST_AUNIT = 4213
  Public Const LC_PROP_DIMST_AZIN = 4214
  Public Const LC_PROP_DIMST_BLK1 = 4215
  Public Const LC_PROP_DIMST_BLK2 = 4216
  Public Const LC_PROP_DIMST_CEN = 4217
  Public Const LC_PROP_DIMST_CLRD = 4218
  Public Const LC_PROP_DIMST_CLRE = 4219
  Public Const LC_PROP_DIMST_CLRT = 4220
  Public Const LC_PROP_DIMST_DEC = 4221
  Public Const LC_PROP_DIMST_DSEP = 4222
  Public Const LC_PROP_DIMST_EXE = 4223
  Public Const LC_PROP_DIMST_EXO = 4224
  Public Const LC_PROP_DIMST_GAP = 4225
  Public Const LC_PROP_DIMST_LDRBLK = 4226
  Public Const LC_PROP_DIMST_LFAC = 4227
  Public Const LC_PROP_DIMST_LWD = 4228
  Public Const LC_PROP_DIMST_LWE = 4229
  Public Const LC_PROP_DIMST_POST = 4230
  Public Const LC_PROP_DIMST_RND = 4231
  Public Const LC_PROP_DIMST_SCALE = 4232
  Public Const LC_PROP_DIMST_TAD = 4233
  Public Const LC_PROP_DIMST_TIH = 4234
  Public Const LC_PROP_DIMST_TXT = 4235
  Public Const LC_PROP_DIMST_TXSTY = 4236
  Public Const LC_PROP_DIMST_TSTYLE = 4236
  Public Const LC_PROP_DIMST_LUNIT = 4237
  Public Const LC_PROP_DIMST_ZIN = 4238
  Public Const LC_PROP_PSTYLE_ID = 4001
  Public Const LC_PROP_PSTYLE_NAME = 4002
  Public Const LC_PROP_PSTYLE_DESC = 4003
  Public Const LC_PROP_PSTYLE_DESCR = 4003
  Public Const LC_PROP_PSTYLE_DRW = 4004
  Public Const LC_PROP_PSTYLE_DELETED = 4005
  Public Const LC_PROP_PSTYLE_STANDARD = 4265
  Public Const LC_PROP_PSTYLE_BLOCK = 4266
  Public Const LC_PROP_PSTYLE_BSCALE = 4267
  Public Const LC_PROP_PSTYLE_TSTYLE = 4268
  Public Const LC_PROP_PSTYLE_TH = 4269
  Public Const LC_PROP_PSTYLE_TWS = 4270
  Public Const LC_PROP_PSTYLE_PTMODE = 4271
  Public Const LC_PROP_PSTYLE_PTSIZE = 4272
  Public Const LC_PROP_PSTYLE_SNAP = 4273
  Public Const LC_PROP_PSTYLE_FIXED = 4274
  Public Const LC_PROP_MLSTYLE_ID = 4001
  Public Const LC_PROP_MLSTYLE_NAME = 4002
  Public Const LC_PROP_MLSTYLE_DESC = 4003
  Public Const LC_PROP_MLSTYLE_DESCR = 4003
  Public Const LC_PROP_MLSTYLE_DRW = 4004
  Public Const LC_PROP_MLSTYLE_DELETED = 4005
  Public Const LC_PROP_MLSTYLE_STANDARD = 4281
  Public Const LC_PROP_MLSTYLE_JOINTS = 4282
  Public Const LC_PROP_MLSTYLE_STARTLINE = 4283
  Public Const LC_PROP_MLSTYLE_STARTARC = 4284
  Public Const LC_PROP_MLSTYLE_ENDLINE = 4285
  Public Const LC_PROP_MLSTYLE_ENDARC = 4286
  Public Const LC_PROP_MLSTYLE_NLINES = 4287
  Public Const LC_PROP_MLSTYLE_ILINE = 4288
  Public Const LC_PROP_MLSTYLE_OFFSET = 4289
  Public Const LC_PROP_MLSTYLE_LTYPE = 4290
  Public Const LC_PROP_MLSTYLE_COLOR = 4291
  Public Const LC_PROP_IMAGE_ID = 4001
  Public Const LC_PROP_IMAGE_NAME = 4002
  Public Const LC_PROP_IMAGE_DESC = 4003
  Public Const LC_PROP_IMAGE_DESCR = 4003
  Public Const LC_PROP_IMAGE_DRW = 4004
  Public Const LC_PROP_IMAGE_DELETED = 4005
  Public Const LC_PROP_IMAGE_FILENAME = 4401
  Public Const LC_PROP_IMAGE_SIZE = 4402
  Public Const LC_PROP_IMAGE_WPIX = 4403
  Public Const LC_PROP_IMAGE_W = 4404
  Public Const LC_PROP_IMAGE_HPIX = 4405
  Public Const LC_PROP_IMAGE_H = 4406
  Public Const LC_PROP_IMAGE_CBIT = 4407
  Public Const LC_PROP_IMAGE_RGB = 4408
  Public Const LC_PROP_IMAGE_EMBEDDED = 4409
  Public Const LC_PROP_IMAGE_CREATED = 4410
  Public Const LC_PROP_IMAGE_COLORS = 4411
  Public Const LC_PROP_IMAGE_BITS = 4412
  Public Const LC_PROP_IMAGE_DIB = 4413
  Public Const LC_PROP_LFILL_ID = 4001
  Public Const LC_PROP_LFILL_NAME = 4002
  Public Const LC_PROP_LFILL_DESC = 4003
  Public Const LC_PROP_LFILL_DESCR = 4003
  Public Const LC_PROP_LFILL_DRW = 4004
  Public Const LC_PROP_LFILL_DELETED = 4005
  Public Const LC_PROP_LFILL_ENABLED0 = 4501
  Public Const LC_PROP_LFILL_DIST0 = 4502
  Public Const LC_PROP_LFILL_ANGLE0 = 4503
  Public Const LC_PROP_LFILL_GAP0 = 4504
  Public Const LC_PROP_LFILL_ENABLED1 = 4505
  Public Const LC_PROP_LFILL_DIST1 = 4506
  Public Const LC_PROP_LFILL_ANGLE1 = 4507
  Public Const LC_PROP_LFILL_GAP1 = 4508
  Public Const LC_PROP_BLOCK_ID = 4001
  Public Const LC_PROP_BLOCK_NAME = 4002
  Public Const LC_PROP_BLOCK_DESC = 4003
  Public Const LC_PROP_BLOCK_DESCR = 4003
  Public Const LC_PROP_BLOCK_DRW = 4004
  Public Const LC_PROP_BLOCK_DELETED = 4005
  Public Const LC_PROP_BLOCK_X = 4801
  Public Const LC_PROP_BLOCK_Y = 4802
  Public Const LC_PROP_BLOCK_UFSCALING = 4803
  Public Const LC_PROP_BLOCK_UNITS = 4804
  Public Const LC_PROP_BLOCK_UNITSCALE = 4810
  Public Const LC_PROP_BLOCK_MODEL = 4811
  Public Const LC_PROP_BLOCK_PAPER = 4812
  Public Const LC_PROP_BLOCK_LAYOUT = 4813
  Public Const LC_PROP_BLOCK_STANDARD = 4814
  Public Const LC_PROP_BLOCK_LAYOUTNAME = 4815
  Public Const LC_PROP_BLOCK_LAYOUTORDER = 4816
  Public Const LC_PROP_BLOCK_HIDDEN = 4818
  Public Const LC_PROP_BLOCK_DIM = 4819
  Public Const LC_PROP_BLOCK_HATCH = 4820
  Public Const LC_PROP_BLOCK_NOBJ = 4821
  Public Const LC_PROP_BLOCK_NENTS = 4821
  Public Const LC_PROP_BLOCK_NSELOBJ = 4822
  Public Const LC_PROP_BLOCK_NSELENTS = 4822
  Public Const LC_PROP_BLOCK_ATTRIBS = 4827
  Public Const LC_PROP_BLOCK_ODA_LAYOUTHANDLE = 4829
  Public Const LC_PROP_BLOCK_ODA_VPORTHANDLE = 4830
  Public Const LC_PROP_BLOCK_XMIN = 4831
  Public Const LC_PROP_BLOCK_YMIN = 4832
  Public Const LC_PROP_BLOCK_XMAX = 4833
  Public Const LC_PROP_BLOCK_YMAX = 4834
  Public Const LC_PROP_BLOCK_XCEN = 4835
  Public Const LC_PROP_BLOCK_YCEN = 4836
  Public Const LC_PROP_BLOCK_DX = 4837
  Public Const LC_PROP_BLOCK_DY = 4838
  Public Const LC_PROP_BLOCK_VISLEF = 4839
  Public Const LC_PROP_BLOCK_VISBOT = 4840
  Public Const LC_PROP_BLOCK_VISRIG = 4841
  Public Const LC_PROP_BLOCK_VISTOP = 4842
  Public Const LC_PROP_BLOCK_SELXMIN = 4843
  Public Const LC_PROP_BLOCK_SELYMIN = 4844
  Public Const LC_PROP_BLOCK_SELXMAX = 4845
  Public Const LC_PROP_BLOCK_SELYMAX = 4846
  Public Const LC_PROP_BLOCK_SELXCEN = 4847
  Public Const LC_PROP_BLOCK_SELYCEN = 4848
  Public Const LC_PROP_SHAPE_ANGLE = 4849
  Public Const LC_PROP_PAPER_INCH = 4851
  Public Const LC_PROP_PAPER_X0 = 4852
  Public Const LC_PROP_PAPER_Y0 = 4853
  Public Const LC_PROP_PAPER_SIZE = 4854
  Public Const LC_PROP_PAPER_ORIENT = 4855
  Public Const LC_PROP_PAPER_W = 4856
  Public Const LC_PROP_PAPER_H = 4857
  Public Const LC_PROP_ENT_TYPE = 5030
  Public Const LC_PROP_ENT_ID = 5001
  Public Const LC_PROP_ENT_KEY = 5002
  Public Const LC_PROP_ENT_BLOCK = 5024
  Public Const LC_PROP_ENT_DRW = 5025
  Public Const LC_PROP_ENT_LAYER = 5020
  Public Const LC_PROP_ENT_LINETYPE = 5021
  Public Const LC_PROP_ENT_LTSCALE = 5022
  Public Const LC_PROP_ENT_LWEIGHT = 5023
  Public Const LC_PROP_ENT_LWIDTH = 5023
  Public Const LC_PROP_ENT_PRIORITY = 5040
  Public Const LC_PROP_ENT_FROMCB = 5035
  Public Const LC_PROP_ENT_COLOR = 5003
  Public Const LC_PROP_ENT_COLORI = 5004
  Public Const LC_PROP_ENT_COLORT = 5005
  Public Const LC_PROP_ENT_COLORBYLAYER = 5006
  Public Const LC_PROP_ENT_COLORBYBLOCK = 5007
  Public Const LC_PROP_ENT_SOLIDFILL = 5008
  Public Const LC_PROP_ENT_FILLED = 5008
  Public Const LC_PROP_ENT_FILLING = 5008
  Public Const LC_PROP_ENT_WIPEOUT = 5011
  Public Const LC_PROP_ENT_FCOLOR = 5012
  Public Const LC_PROP_ENT_FCOLORI = 5013
  Public Const LC_PROP_ENT_FCOLORT = 5014
  Public Const LC_PROP_ENT_FCOLORBYLAYER = 5015
  Public Const LC_PROP_ENT_FCOLORBYBLOCK = 5016
  Public Const LC_PROP_ENT_FALPHA = 5017
  Public Const LC_PROP_ENT_LINFILL = 5018
  Public Const LC_PROP_ENT_LINFILLNL = 5019
  Public Const LC_PROP_ENT_LOCKED = 5026
  Public Const LC_PROP_ENT_VISIBLE = 5027
  Public Const LC_PROP_ENT_HIDDEN = 5028
  Public Const LC_PROP_ENT_BLINK = 5029
  Public Const LC_PROP_ENT_DELETED = 5031
  Public Const LC_PROP_ENT_IMMORTAL = 5032
  Public Const LC_PROP_ENT_SELECTED = 5033
  Public Const LC_PROP_ENT_GRIPMODE = 5034
  Public Const LC_PROP_ENT_XMIN = 5052
  Public Const LC_PROP_ENT_YMIN = 5053
  Public Const LC_PROP_ENT_XMAX = 5054
  Public Const LC_PROP_ENT_YMAX = 5055
  Public Const LC_PROP_ENT_XCEN = 5056
  Public Const LC_PROP_ENT_YCEN = 5057
  Public Const LC_PROP_ENT_DX = 5058
  Public Const LC_PROP_ENT_DY = 5059
  Public Const LC_PROP_ENT_LEN = 5060
  Public Const LC_PROP_ENT_Z = 5061
  Public Const LC_PROP_ENT_THICKNESS = 5062
  Public Const LC_PROP_ENT_XDATAID = 5041
  Public Const LC_PROP_ENT_XDATAFLAGS = 5042
  Public Const LC_PROP_ENT_XDATASIZE = 5043
  Public Const LC_PROP_ENT_XDATA = 5044
  Public Const LC_PROP_ENT_XSTR = 5045
  Public Const LC_PROP_POINT_STYLE = 5101
  Public Const LC_PROP_POINT_X = 5102
  Public Const LC_PROP_POINT_Y = 5103
  Public Const LC_PROP_POINT_Z = 5061
  Public Const LC_PROP_POINT_SIZE = 5104
  Public Const LC_PROP_POINT_MODE = 5105
  Public Const LC_PROP_POINT_BANGLE = 5106
  Public Const LC_PROP_POINT_TDX = 5107
  Public Const LC_PROP_POINT_TDY = 5108
  Public Const LC_PROP_POINT_TANGLE = 5109
  Public Const LC_PROP_POINT_TEXT = 5110
  Public Const LC_PROP_POINT_TEXTLEN = 5111
  Public Const LC_PROP_PTARR_FILENAME = 5112
  Public Const LC_PROP_PTARR_FNAME = 5113
  Public Const LC_PROP_PTARR_DIR = 5114
  Public Const LC_PROP_PTARR_LOADED = 5115
  Public Const LC_PROP_PTARR_NUM = 5116
  Public Const LC_PROP_PTARR_NUMVIS = 5117
  Public Const LC_PROP_PTARR_TEXTVLIM = 5118
  Public Const LC_PROP_PTARR_VLIM10 = 5119
  Public Const LC_PROP_PTARR_VLIM100 = 5120
  Public Const LC_PROP_LINE_X0 = 5131
  Public Const LC_PROP_LINE_Y0 = 5132
  Public Const LC_PROP_LINE_Z0 = 5133
  Public Const LC_PROP_LINE_X1 = 5134
  Public Const LC_PROP_LINE_Y1 = 5135
  Public Const LC_PROP_LINE_Z1 = 5136
  Public Const LC_PROP_LINE_DX = 5137
  Public Const LC_PROP_LINE_DY = 5138
  Public Const LC_PROP_LINE_DZ = 5139
  Public Const LC_PROP_LINE_ANG = 5140
  Public Const LC_PROP_LINE_LEN = 5141
  Public Const LC_PROP_LINE_DSARROW0 = 5142
  Public Const LC_PROP_LINE_DSARROW1 = 5143
  Public Const LC_PROP_LINE_W0 = 5144
  Public Const LC_PROP_LINE_W1 = 5145
  Public Const LC_PROP_LINE_SOLID = 5146
  Public Const LC_PROP_XLINE_X0 = 5151
  Public Const LC_PROP_XLINE_Y0 = 5152
  Public Const LC_PROP_XLINE_ANG = 5154
  Public Const LC_PROP_XLINE_DIRX = 5155
  Public Const LC_PROP_XLINE_DIRY = 5156
  Public Const LC_PROP_XLINE_RAY = 5157
  Public Const LC_PROP_CIRCLE_X = 5201
  Public Const LC_PROP_CIRCLE_Y = 5202
  Public Const LC_PROP_CIRCLE_R = 5204
  Public Const LC_PROP_CIRCLE_RAD = 5204
  Public Const LC_PROP_CIRCLE_RADIUS = 5204
  Public Const LC_PROP_CIRCLE_DIAM = 5205
  Public Const LC_PROP_CIRCLE_LEN = 5206
  Public Const LC_PROP_CIRCLE_AREA = 5207
  Public Const LC_PROP_CIRCLE_ANG0 = 5208
  Public Const LC_PROP_CIRCLE_DIRCW = 5209
  Public Const LC_PROP_CIRCLE_RESOL = 5210
  Public Const LC_PROP_CIRC_X = 5201
  Public Const LC_PROP_CIRC_Y = 5202
  Public Const LC_PROP_CIRC_R = 5204
  Public Const LC_PROP_CIRC_RAD = 5204
  Public Const LC_PROP_CIRC_RADIUS = 5204
  Public Const LC_PROP_CIRC_DIAM = 5205
  Public Const LC_PROP_CIRC_LEN = 5206
  Public Const LC_PROP_CIRC_AREA = 5207
  Public Const LC_PROP_CIRC_ANG0 = 5208
  Public Const LC_PROP_CIRC_DIRCW = 5209
  Public Const LC_PROP_CIRC_RESOL = 5210
  Public Const LC_PROP_ARC_X = 5231
  Public Const LC_PROP_ARC_Y = 5232
  Public Const LC_PROP_ARC_R = 5234
  Public Const LC_PROP_ARC_RAD = 5234
  Public Const LC_PROP_ARC_RADIUS = 5234
  Public Const LC_PROP_ARC_ANG0 = 5235
  Public Const LC_PROP_ARC_ANGARC = 5236
  Public Const LC_PROP_ARC_ANGEND = 5237
  Public Const LC_PROP_ARC_X0 = 5238
  Public Const LC_PROP_ARC_Y0 = 5239
  Public Const LC_PROP_ARC_Z0 = 5240
  Public Const LC_PROP_ARC_XMID = 5241
  Public Const LC_PROP_ARC_YMID = 5242
  Public Const LC_PROP_ARC_XEND = 5243
  Public Const LC_PROP_ARC_YEND = 5244
  Public Const LC_PROP_ARC_ZEND = 5245
  Public Const LC_PROP_ARC_LEN = 5246
  Public Const LC_PROP_ARC_CHLEN = 5247
  Public Const LC_PROP_ARC_AREA = 5248
  Public Const LC_PROP_ARC_CCW = 5249
  Public Const LC_PROP_ARC_SECTOR = 5250
  Public Const LC_PROP_ARC_RESOL = 5251
  Public Const LC_PROP_ELL_X = 5261
  Public Const LC_PROP_ELL_Y = 5262
  Public Const LC_PROP_ELL_R1 = 5264
  Public Const LC_PROP_ELL_R2 = 5265
  Public Const LC_PROP_ELL_RATIO = 5266
  Public Const LC_PROP_ELL_ANGLE = 5267
  Public Const LC_PROP_ELL_ANG0 = 5268
  Public Const LC_PROP_ELL_ANGARC = 5269
  Public Const LC_PROP_ELL_ANGEND = 5270
  Public Const LC_PROP_ELL_X0 = 5271
  Public Const LC_PROP_ELL_Y0 = 5272
  Public Const LC_PROP_ELL_XEND = 5273
  Public Const LC_PROP_ELL_YEND = 5274
  Public Const LC_PROP_ELL_LEN = 5276
  Public Const LC_PROP_ELL_AREA = 5277
  Public Const LC_PROP_ELL_FULL = 5278
  Public Const LC_PROP_ELL_CCW = 5279
  Public Const LC_PROP_ELL_SECTOR = 5282
  Public Const LC_PROP_ELL_RESOL = 5283
  Public Const LC_PROP_PLINE_FIT = 5301
  Public Const LC_PROP_PLINE_CLOSED = 5302
  Public Const LC_PROP_PLINE_NVERS = 5303
  Public Const LC_PROP_PLINE_WIDTH = 5305
  Public Const LC_PROP_PLINE_LEN = 5306
  Public Const LC_PROP_PLINE_AREA = 5307
  Public Const LC_PROP_PLINE_CW = 5308
  Public Const LC_PROP_PLINE_CCW = 5309
  Public Const LC_PROP_PLINE_Z = 5310
  Public Const LC_PROP_PLINE_CONSTZ = 5311
  Public Const LC_PROP_PLINE_RESOLA = 5312
  Public Const LC_PROP_PLINE_RESOLS = 5313
  Public Const LC_PROP_PLINE_RADIUS = 5314
  Public Const LC_PROP_PLINE_CHAMFER = 5315
  Public Const LC_PROP_PLINE_HASANG0 = 5316
  Public Const LC_PROP_PLINE_ANG0 = 5317
  Public Const LC_PROP_PLINE_HASANG2 = 5318
  Public Const LC_PROP_PLINE_ANG2 = 5319
  Public Const LC_PROP_PLINE_WIPEOUT = 5325
  Public Const LC_PROP_PLINE_ODSOLID = 5326
  Public Const LC_PROP_MLINE_STYLE = 5351
  Public Const LC_PROP_MLINE_JUST = 5352
  Public Const LC_PROP_MLINE_SCALE = 5353
  Public Const LC_PROP_MLINE_NVERS = 5354
  Public Const LC_PROP_MLINE_CLOSED = 5355
  Public Const LC_PROP_MLINE_FIT = 5356
  Public Const LC_PROP_MLINE_LEN = 5357
  Public Const LC_PROP_MLINE_AREA = 5358
  Public Const LC_PROP_RECT_X = 5371
  Public Const LC_PROP_RECT_Y = 5372
  Public Const LC_PROP_RECT_W = 5374
  Public Const LC_PROP_RECT_H = 5375
  Public Const LC_PROP_RECT_ANGLE = 5376
  Public Const LC_PROP_RECT_R = 5377
  Public Const LC_PROP_RECT_RAD = 5377
  Public Const LC_PROP_RECT_RADIUS = 5377
  Public Const LC_PROP_RECT_CHAMFER = 5378
  Public Const LC_PROP_RECT_DIRCW = 5379
  Public Const LC_PROP_RECT_START = 5380
  Public Const LC_PROP_RECT_LEN = 5381
  Public Const LC_PROP_RECT_AREA = 5382
  Public Const LC_PROP_RECT_RESOL = 5383
  Public Const LC_PROP_RECT_GRID = 5384
  Public Const LC_PROP_RECT_GRNW = 5385
  Public Const LC_PROP_RECT_GRNH = 5386
  Public Const LC_PROP_RECT_GRDW = 5387
  Public Const LC_PROP_RECT_GRDH = 5388
  Public Const LC_PROP_CRECT_ID = 5390
  Public Const LC_PROP_CRECT_NAME = 5391
  Public Const LC_PROP_CRECT_X = 5392
  Public Const LC_PROP_CRECT_Y = 5393
  Public Const LC_PROP_CRECT_W = 5394
  Public Const LC_PROP_CRECT_H = 5395
  Public Const LC_PROP_CRECT_ANGLE = 5396
  Public Const LC_PROP_CRECT_LEN = 5398
  Public Const LC_PROP_CRECT_AREA = 5399
  Public Const LC_PROP_TEXT_STYLE = 5401
  Public Const LC_PROP_TEXT_STR = 5402
  Public Const LC_PROP_TEXT_STRT = 5403
  Public Const LC_PROP_TEXT_LEN = 5404
  Public Const LC_PROP_TEXT_ALIGN = 5405
  Public Const LC_PROP_TEXT_H = 5406
  Public Const LC_PROP_TEXT_X = 5407
  Public Const LC_PROP_TEXT_Y = 5408
  Public Const LC_PROP_TEXT_DX = 5409
  Public Const LC_PROP_TEXT_DY = 5410
  Public Const LC_PROP_TEXT_WSCALE = 5412
  Public Const LC_PROP_TEXT_ANGLE = 5413
  Public Const LC_PROP_TEXT_OBLIQUE = 5414
  Public Const LC_PROP_TEXT_CHARSPACE = 5415
  Public Const LC_PROP_TEXT_WRECT = 5416
  Public Const LC_PROP_TEXT_X0 = 5417
  Public Const LC_PROP_TEXT_Y0 = 5418
  Public Const LC_PROP_TEXT_XFIT = 5419
  Public Const LC_PROP_TEXT_YFIT = 5420
  Public Const LC_PROP_TEXT_UPDOWN = 5421
  Public Const LC_PROP_TEXT_BACKWARD = 5422
  Public Const LC_PROP_TEXT_RESOL = 5423
  Public Const LC_PROP_TEXTW_STYLE = 5431
  Public Const LC_PROP_TEXTW_STR = 5432
  Public Const LC_PROP_TEXTW_STRT = 5433
  Public Const LC_PROP_TEXTW_LEN = 5434
  Public Const LC_PROP_TEXTW_ALIGN = 5435
  Public Const LC_PROP_TEXTW_X = 5436
  Public Const LC_PROP_TEXTW_Y = 5437
  Public Const LC_PROP_TEXTW_H = 5438
  Public Const LC_PROP_TEXTW_DX = 5440
  Public Const LC_PROP_TEXTW_DY = 5441
  Public Const LC_PROP_TEXTW_WSCALE = 5442
  Public Const LC_PROP_TEXTW_ANGLE = 5443
  Public Const LC_PROP_MTEXT_STYLE = 5451
  Public Const LC_PROP_MTEXT_STR = 5452
  Public Const LC_PROP_MTEXT_LEN = 5453
  Public Const LC_PROP_MTEXT_ALIGN = 5454
  Public Const LC_PROP_MTEXT_X = 5455
  Public Const LC_PROP_MTEXT_Y = 5456
  Public Const LC_PROP_MTEXT_H = 5458
  Public Const LC_PROP_MTEXT_WSCALE = 5459
  Public Const LC_PROP_MTEXT_ANGLE = 5460
  Public Const LC_PROP_MTEXT_OBLIQUE = 5461
  Public Const LC_PROP_MTEXT_WRECT = 5462
  Public Const LC_PROP_MTEXT_HRECT = 5463
  Public Const LC_PROP_MTEXT_WRAPWIDTH = 5464
  Public Const LC_PROP_MTEXT_LINESPACE = 5465
  Public Const LC_PROP_MTEXT_CHARSPACE = 5466
  Public Const LC_PROP_MTEXT_MIRROR = 5467
  Public Const LC_PROP_MTEXT_RESOL = 5468
  Public Const LC_PROP_ATEXT_STYLE = 5481
  Public Const LC_PROP_ATEXT_STR = 5482
  Public Const LC_PROP_ATEXT_STRT = 5483
  Public Const LC_PROP_ATEXT_LEN = 5484
  Public Const LC_PROP_ATEXT_X = 5485
  Public Const LC_PROP_ATEXT_Y = 5486
  Public Const LC_PROP_ATEXT_R = 5487
  Public Const LC_PROP_ATEXT_RAD = 5487
  Public Const LC_PROP_ATEXT_RADIUS = 5487
  Public Const LC_PROP_ATEXT_ANGLE = 5488
  Public Const LC_PROP_ATEXT_ANGSTA = 5489
  Public Const LC_PROP_ATEXT_ANGEND = 5490
  Public Const LC_PROP_ATEXT_CW = 5491
  Public Const LC_PROP_ATEXT_H = 5492
  Public Const LC_PROP_ATEXT_WSCALE = 5493
  Public Const LC_PROP_ATEXT_CHARSPACE = 5494
  Public Const LC_PROP_ATEXT_ALIGN = 5495
  Public Const LC_PROP_ATEXT_RESOL = 5496
  Public Const LC_PROP_ATT_MODE = 5501
  Public Const LC_PROP_ATT_TSTYLE = 5502
  Public Const LC_PROP_ATT_TAG = 5503
  Public Const LC_PROP_ATT_PROMPT = 5504
  Public Const LC_PROP_ATT_VALUE = 5505
  Public Const LC_PROP_ATT_ALIGN = 5506
  Public Const LC_PROP_ATT_X = 5507
  Public Const LC_PROP_ATT_Y = 5508
  Public Const LC_PROP_ATT_H = 5510
  Public Const LC_PROP_ATT_WSCALE = 5511
  Public Const LC_PROP_ATT_ANGLE = 5512
  Public Const LC_PROP_ATT_OBLIQUE = 5513
  Public Const LC_PROP_ATT_X0 = 5514
  Public Const LC_PROP_ATT_Y0 = 5515
  Public Const LC_PROP_ATT_XFIT = 5516
  Public Const LC_PROP_ATT_YFIT = 5517
  Public Const LC_PROP_ATT_UPDOWN = 5518
  Public Const LC_PROP_ATT_BACKWARD = 5519
  Public Const LC_PROP_ATT_COLOR = 5521
  Public Const LC_PROP_ATT_LAYER = 5522
  Public Const LC_PROP_ATT_LINETYPE = 5523
  Public Const LC_PROP_ATT_LTSCALE = 5524
  Public Const LC_PROP_ATT_LWIDTH = 5525
  Public Const LC_PROP_ATT_INVIS = 5526
  Public Const LC_PROP_ATT_LOCKPOS = 5527
  Public Const LC_PROP_ATT_MTEXT = 5528
  Public Const LC_PROP_BLKREF_BLOCK = 5531
  Public Const LC_PROP_BLKREF_X = 5532
  Public Const LC_PROP_BLKREF_Y = 5533
  Public Const LC_PROP_BLKREF_SCALE = 5534
  Public Const LC_PROP_BLKREF_SCX = 5535
  Public Const LC_PROP_BLKREF_SCY = 5536
  Public Const LC_PROP_BLKREF_UFSCALE = 5537
  Public Const LC_PROP_BLKREF_ANGLE = 5538
  Public Const LC_PROP_BLKREF_ARNX = 5539
  Public Const LC_PROP_BLKREF_ARDX = 5540
  Public Const LC_PROP_BLKREF_ARNY = 5541
  Public Const LC_PROP_BLKREF_ARDY = 5542
  Public Const LC_PROP_BLKREF_ARANG = 5543
  Public Const LC_PROP_BLKREF_ATTRIBS = 5544
  Public Const LC_PROP_BLKREF_GRIPMODE = 5545
  Public Const LC_PROP_BLKREF_ONS_XY = 5546
  Public Const LC_PROP_BLKREF_ONS_SCALE = 5547
  Public Const LC_PROP_BLKREF_ONS_ANGLE = 5548
  Public Const LC_PROP_BLKREF_RETURN = 5549
  Public Const LC_PROP_IMGREF_IMAGE = 5551
  Public Const LC_PROP_IMGREF_XC = 5552
  Public Const LC_PROP_IMGREF_YC = 5553
  Public Const LC_PROP_IMGREF_W = 5554
  Public Const LC_PROP_IMGREF_H = 5555
  Public Const LC_PROP_IMGREF_WPIX = 5556
  Public Const LC_PROP_IMGREF_HPIX = 5557
  Public Const LC_PROP_IMGREF_SCALE = 5558
  Public Const LC_PROP_IMGREF_PIXELSIZE = 5558
  Public Const LC_PROP_IMGREF_SCALEX = 5560
  Public Const LC_PROP_IMGREF_SCALEY = 5561
  Public Const LC_PROP_IMGREF_SQPIX = 5562
  Public Const LC_PROP_IMGREF_ANGLE = 5564
  Public Const LC_PROP_IMGREF_BORDER = 5565
  Public Const LC_PROP_IMGREF_TRANSP = 5566
  Public Const LC_PROP_IMGREF_TRCOLOR = 5567
  Public Const LC_PROP_IMGREF_TRALPHA = 5568
  Public Const LC_PROP_IMGREF_GRAYS = 5569
  Public Const LC_PROP_IMGREF_GREY = 5569
  Public Const LC_PROP_IMGREF_FLIPHOR = 5570
  Public Const LC_PROP_IMGREF_FLIPVER = 5571
  Public Const LC_PROP_IMGREF_PATH = 5573
  Public Const LC_PROP_IMGREF_GP_X = 5574
  Public Const LC_PROP_IMGREF_GP_Y = 5575
  Public Const LC_PROP_IMGREF_GP_COLOR = 5576
  Public Const LC_PROP_IMGREF_GP_GRAY = 5577
  Public Const LC_PROP_IMGREF_UNSCALABLE = 5578
  Public Const LC_PROP_IMGREF_UNSSCALE = 5579
  Public Const LC_PROP_IMGREF_UNSALIGN = 5580
  Public Const LC_PROP_ECW_FILENAME = 5581
  Public Const LC_PROP_ECW_LOADED = 5582
  Public Const LC_PROP_ECW_WPIX = 5583
  Public Const LC_PROP_ECW_HPIX = 5584
  Public Const LC_PROP_ECW_CBIT = 5585
  Public Const LC_PROP_ECW_XMIN = 5586
  Public Const LC_PROP_ECW_YMIN = 5587
  Public Const LC_PROP_ECW_XMAX = 5588
  Public Const LC_PROP_ECW_YMAX = 5589
  Public Const LC_PROP_ECW_W = 5590
  Public Const LC_PROP_ECW_H = 5591
  Public Const LC_PROP_ECW_SCALEX = 5592
  Public Const LC_PROP_ECW_SCALEY = 5593
  Public Const LC_PROP_ECW_BORDER = 5594
  Public Const LC_PROP_ECW_GRAYS = 5595
  Public Const LC_PROP_ECW_BRIGHT = 5596
  Public Const LC_PROP_BRI_FILENAME = 5601
  Public Const LC_PROP_BRI_LOADED = 5602
  Public Const LC_PROP_BRI_WPIX = 5603
  Public Const LC_PROP_BRI_HPIX = 5604
  Public Const LC_PROP_BRI_XMIN = 5605
  Public Const LC_PROP_BRI_YMIN = 5606
  Public Const LC_PROP_BRI_XMAX = 5607
  Public Const LC_PROP_BRI_YMAX = 5608
  Public Const LC_PROP_BRI_W = 5609
  Public Const LC_PROP_BRI_H = 5610
  Public Const LC_PROP_BRI_PIXSIZE = 5611
  Public Const LC_PROP_BRI_BORDER = 5612
  Public Const LC_PROP_CAMERA_X = 5621
  Public Const LC_PROP_CAMERA_Y = 5622
  Public Const LC_PROP_CAMERA_W = 5623
  Public Const LC_PROP_CAMERA_H = 5624
  Public Const LC_PROP_HATCH_NAME = 5631
  Public Const LC_PROP_HATCH_PATTERN = 5632
  Public Const LC_PROP_HATCH_SCALE = 5633
  Public Const LC_PROP_HATCH_ANGLE = 5634
  Public Const LC_PROP_HATCH_SIZE = 5635
  Public Const LC_PROP_HATCH_ASSOC = 5636
  Public Const LC_PROP_HATCH_SOLID = 5637
  Public Const LC_PROP_HATCH_CUSTOM = 5638
  Public Const LC_PROP_HATCH_NENTS = 5639
  Public Const LC_PROP_HATCH_NPT = 5640
  Public Const LC_PROP_HATCH_NLOOP = 5641
  Public Const LC_PROP_HATCH_NHPL = 5642
  Public Const LC_PROP_HATCH_IHPL = 5643
  Public Const LC_PROP_HATCH_FALPHA = 5644
  Public Const LC_PROP_HATCH_AREA = 5645
  Public Const LC_PROP_HATCH_NDASHES = 5646
  Public Const LC_PROP_HPL_ANGLE = 5651
  Public Const LC_PROP_HPL_X0 = 5652
  Public Const LC_PROP_HPL_Y0 = 5653
  Public Const LC_PROP_HPL_DX = 5654
  Public Const LC_PROP_HPL_DY = 5655
  Public Const LC_PROP_HPL_NDASH = 5656
  Public Const LC_PROP_HPL_DASH1 = 5657
  Public Const LC_PROP_HPL_DASH2 = 5658
  Public Const LC_PROP_HPL_DASH3 = 5659
  Public Const LC_PROP_HPL_DASH4 = 5660
  Public Const LC_PROP_HPL_DASH5 = 5661
  Public Const LC_PROP_HPL_DASH6 = 5662
  Public Const LC_PROP_HPL_DASH7 = 5663
  Public Const LC_PROP_HPL_DASH8 = 5664
  Public Const LC_PROP_VPORT_LEF = 5703
  Public Const LC_PROP_VPORT_BOT = 5704
  Public Const LC_PROP_VPORT_RIG = 5705
  Public Const LC_PROP_VPORT_TOP = 5706
  Public Const LC_PROP_VPORT_BORDER = 5707
  Public Const LC_PROP_VPORT_W = 5711
  Public Const LC_PROP_VPORT_H = 5712
  Public Const LC_PROP_VPORT_VX = 5713
  Public Const LC_PROP_VPORT_VY = 5714
  Public Const LC_PROP_VPORT_VSCALE = 5715
  Public Const LC_PROP_VPORT_VANGLE = 5716
  Public Const LC_PROP_VPORT_FIXSCALE = 5717
  Public Const LC_PROP_BARC_XC = 5751
  Public Const LC_PROP_BARC_X = 5751
  Public Const LC_PROP_BARC_YC = 5752
  Public Const LC_PROP_BARC_Y = 5752
  Public Const LC_PROP_BARC_W = 5753
  Public Const LC_PROP_BARC_H = 5754
  Public Const LC_PROP_BARC_ANG = 5755
  Public Const LC_PROP_BARC_TYPE = 5756
  Public Const LC_PROP_BARC_CODE = 5757
  Public Const LC_PROP_BARC_TEXT = 5757
  Public Const LC_PROP_BARC_CHECKSUM = 5758
  Public Const LC_PROP_BARC_NCHARS = 5759
  Public Const LC_PROP_BARC_NUBITS = 5760
  Public Const LC_PROP_BARC_NARSIZE = 5761
  Public Const LC_PROP_BARC_WIDERATIO = 5762
  Public Const LC_PROP_BARC_QZONE = 5763
  Public Const LC_PROP_BARC_OFFSET = 5764
  Public Const LC_PROP_BARC_INVERT = 5765
  Public Const LC_PROP_BARC_HIDETEXT = 5766
  Public Const LC_PROP_BARC_TSTYLE = 5767
  Public Const LC_PROP_BARC_TEXTH = 5768
  Public Const LC_PROP_BARC_TEXTW = 5769
  Public Const LC_PROP_BARC_TEXTCS = 5770
  Public Const LC_PROP_BARC_TEXTALIGN = 5771
  Public Const LC_PROP_BARC_TEXTRES = 5772
  Public Const LC_PROP_BARC_ECLEVEL = 5773
  Public Const LC_PROP_BARC_MASKPAT = 5774
  Public Const LC_PROP_BARC_DATATYPE = 5775
  Public Const LC_PROP_BARC_SIZE = 5776
  Public Const LC_PROP_BARC_NBARS = 5777
  Public Const LC_PROP_BARC_NMODX = 5777
  Public Const LC_PROP_BARC_NMODY = 5778
  Public Const LC_PROP_ARR_X0 = 5801
  Public Const LC_PROP_ARR_Y0 = 5802
  Public Const LC_PROP_ARR_X1 = 5803
  Public Const LC_PROP_ARR_Y1 = 5804
  Public Const LC_PROP_ARR_ANG = 5805
  Public Const LC_PROP_ARR_LEN = 5806
  Public Const LC_PROP_ARR_W = 5807
  Public Const LC_PROP_ARR_SW = 5808
  Public Const LC_PROP_ARR_SL = 5809
  Public Const LC_PROP_ARR_TIME = 5810
  Public Const LC_PROP_ARR_SHARP = 5811
  Public Const LC_PROP_SPIR_X = 5821
  Public Const LC_PROP_SPIR_Y = 5822
  Public Const LC_PROP_SPIR_R = 5823
  Public Const LC_PROP_SPIR_RADIUS = 5823
  Public Const LC_PROP_SPIR_R2 = 5824
  Public Const LC_PROP_SPIR_RATIO = 5825
  Public Const LC_PROP_SPIR_ANGLE = 5826
  Public Const LC_PROP_SPIR_TURNS = 5827
  Public Const LC_PROP_SPIR_DIRCW = 5829
  Public Const LC_PROP_SPIR_CLOSED = 5830
  Public Const LC_PROP_SPIR_DSTEP = 5831
  Public Const LC_PROP_SPIR_RESOL = 5832
  Public Const LC_PROP_XREF_FILENAME = 5841
  Public Const LC_PROP_XREF_FNAME = 5842
  Public Const LC_PROP_XREF_PATH = 5843
  Public Const LC_PROP_XREF_X = 5844
  Public Const LC_PROP_XREF_Y = 5845
  Public Const LC_PROP_XREF_SCX = 5846
  Public Const LC_PROP_XREF_SCY = 5847
  Public Const LC_PROP_XREF_ANGLE = 5848
  Public Const LC_PROP_DIM_STYLE = 6001
  Public Const LC_PROP_DIM_MEAS = 6003
  Public Const LC_PROP_DIM_TEXT = 6004
  Public Const LC_PROP_DIMANG_STYLE = 6001
  Public Const LC_PROP_DIMANG_MEAS = 6003
  Public Const LC_PROP_DIMANG_TEXT = 6004
  Public Const LC_PROP_DIMALI_STYLE = 6001
  Public Const LC_PROP_DIMALI_MEAS = 6003
  Public Const LC_PROP_DIMALI_TEXT = 6004
  Public Const LC_PROP_DIMDIA_STYLE = 6001
  Public Const LC_PROP_DIMDIA_MEAS = 6003
  Public Const LC_PROP_DIMDIA_TEXT = 6004
  Public Const LC_PROP_DIMRAD_STYLE = 6001
  Public Const LC_PROP_DIMRAD_MEAS = 6003
  Public Const LC_PROP_DIMRAD_TEXT = 6004
  Public Const LC_PROP_DIMORD_STYLE = 6001
  Public Const LC_PROP_DIMORD_MEAS = 6003
  Public Const LC_PROP_DIMORD_TEXT = 6004
  Public Const LC_PROP_DIMROT_STYLE = 6001
  Public Const LC_PROP_DIMROT_MEAS = 6003
  Public Const LC_PROP_DIMROT_TEXT = 6004
  Public Const LC_PROP_DIMLIN_STYLE = 6001
  Public Const LC_PROP_DIMLIN_MEAS = 6003
  Public Const LC_PROP_DIMLIN_TEXT = 6004
  Public Const LC_PROP_DIMANG_3PNT = 6011
  Public Const LC_PROP_DIMANG_2LINE = 6012
  Public Const LC_PROP_DIMANG_CPX = 6013
  Public Const LC_PROP_DIMANG_CPY = 6014
  Public Const LC_PROP_DIMANG_DP1X = 6015
  Public Const LC_PROP_DIMANG_DP1Y = 6016
  Public Const LC_PROP_DIMANG_DP2X = 6017
  Public Const LC_PROP_DIMANG_DP2Y = 6018
  Public Const LC_PROP_DIMANG_L1P1X = 6021
  Public Const LC_PROP_DIMANG_L1P1Y = 6022
  Public Const LC_PROP_DIMANG_L1P2X = 6023
  Public Const LC_PROP_DIMANG_L1P2Y = 6024
  Public Const LC_PROP_DIMANG_DP3X = 6023
  Public Const LC_PROP_DIMANG_DP3Y = 6024
  Public Const LC_PROP_DIMANG_L2P1X = 6025
  Public Const LC_PROP_DIMANG_L2P1Y = 6026
  Public Const LC_PROP_DIMANG_L2P2X = 6027
  Public Const LC_PROP_DIMANG_L2P2Y = 6028
  Public Const LC_PROP_DIMANG_DP4X = 6027
  Public Const LC_PROP_DIMANG_DP4Y = 6028
  Public Const LC_PROP_DIMANG_APX = 6029
  Public Const LC_PROP_DIMANG_APY = 6030
  Public Const LC_PROP_DIMANG_EXT1 = 6031
  Public Const LC_PROP_DIMANG_EXT2 = 6032
  Public Const LC_PROP_DIMANG_RAD = 6033
  Public Const LC_PROP_DIMANG_TPOS = 6034
  Public Const LC_PROP_DIMALI_DP1X = 6051
  Public Const LC_PROP_DIMALI_DP1Y = 6052
  Public Const LC_PROP_DIMALI_DP2X = 6053
  Public Const LC_PROP_DIMALI_DP2Y = 6054
  Public Const LC_PROP_DIMALI_TPX = 6055
  Public Const LC_PROP_DIMALI_TPY = 6056
  Public Const LC_PROP_DIMDIA_CPX = 6071
  Public Const LC_PROP_DIMDIA_CPY = 6072
  Public Const LC_PROP_DIMDIA_RPX = 6073
  Public Const LC_PROP_DIMDIA_RPY = 6074
  Public Const LC_PROP_DIMDIA_FPX = 6075
  Public Const LC_PROP_DIMDIA_FPY = 6076
  Public Const LC_PROP_DIMDIA_TPX = 6077
  Public Const LC_PROP_DIMDIA_TPY = 6078
  Public Const LC_PROP_DIMRAD_CPX = 6086
  Public Const LC_PROP_DIMRAD_CPY = 6087
  Public Const LC_PROP_DIMRAD_RPX = 6088
  Public Const LC_PROP_DIMRAD_RPY = 6089
  Public Const LC_PROP_DIMRAD_TPX = 6090
  Public Const LC_PROP_DIMRAD_TPY = 6091
  Public Const LC_PROP_DIMORD_XORD = 6101
  Public Const LC_PROP_DIMORD_DPX = 6102
  Public Const LC_PROP_DIMORD_DPY = 6103
  Public Const LC_PROP_DIMORD_TPX = 6104
  Public Const LC_PROP_DIMORD_TPY = 6105
  Public Const LC_PROP_DIMROT_ANGLE = 6121
  Public Const LC_PROP_DIMROT_DP1X = 6122
  Public Const LC_PROP_DIMROT_DP1Y = 6123
  Public Const LC_PROP_DIMROT_DP2X = 6124
  Public Const LC_PROP_DIMROT_DP2Y = 6125
  Public Const LC_PROP_DIMROT_TPX = 6126
  Public Const LC_PROP_DIMROT_TPY = 6127
  Public Const LC_PROP_DIMLIN_ANGLE = 6121
  Public Const LC_PROP_DIMLIN_DP1X = 6122
  Public Const LC_PROP_DIMLIN_DP1Y = 6123
  Public Const LC_PROP_DIMLIN_DP2X = 6124
  Public Const LC_PROP_DIMLIN_DP2Y = 6125
  Public Const LC_PROP_DIMLIN_TPX = 6126
  Public Const LC_PROP_DIMLIN_TPY = 6127
  Public Const LC_PROP_LEADER_STYLE = 6202
  Public Const LC_PROP_LEADER_TEXT = 6203
  Public Const LC_PROP_LEADER_ALIGN = 6204
  Public Const LC_PROP_LEADER_TPX = 6205
  Public Const LC_PROP_LEADER_TPY = 6206
  Public Const LC_PROP_LEADER_APX = 6207
  Public Const LC_PROP_LEADER_APY = 6208
  Public Const LC_PROP_LEADER_P1X = 6209
  Public Const LC_PROP_LEADER_P1Y = 6210
  Public Const LC_PROP_LEADER_P0X = 6211
  Public Const LC_PROP_LEADER_P0Y = 6212
  Public Const LC_PROP_LEADER_LDIST = 6213
  Public Const LC_PROP_LEADER_VERT = 6214
  Public Const LC_PROP_LEADER_CORNER = 6215
  Public Const LC_PROP_LEADER_TBW = 6216
  Public Const LC_PROP_LEADER_TBH = 6217
  Public Const LC_PROP_FACE_X0 = 6281
  Public Const LC_PROP_FACE_Y0 = 6282
  Public Const LC_PROP_FACE_Z0 = 6283
  Public Const LC_PROP_FACE_X1 = 6284
  Public Const LC_PROP_FACE_Y1 = 6285
  Public Const LC_PROP_FACE_Z1 = 6286
  Public Const LC_PROP_FACE_X2 = 6287
  Public Const LC_PROP_FACE_Y2 = 6288
  Public Const LC_PROP_FACE_Z2 = 6289
  Public Const LC_PROP_FACE_X3 = 6290
  Public Const LC_PROP_FACE_Y3 = 6291
  Public Const LC_PROP_FACE_Z3 = 6292
  Public Const LC_PROP_FACE_EDGE1 = 6293
  Public Const LC_PROP_FACE_EDGE2 = 6294
  Public Const LC_PROP_FACE_EDGE3 = 6295
  Public Const LC_PROP_FACE_EDGE4 = 6296
  Public Const LC_PROP_FACE_EDGE = 6297
  Public Const LC_PROP_FACE_NPTS = 6298
  Public Const LC_PROP_RPLAN_LEN = 6301
  Public Const LC_PROP_RPLAN_MARKARC = 6302
  Public Const LC_PROP_RPLAN_MARKSIZE = 6303
  Public Const LC_PROP_RPLAN_NVERS = 6311
  Public Const LC_PROP_RPLAN_IVER = 6312
  Public Const LC_PROP_SHAPE_NENTS = 6341
  Public Const LC_PROP_SHAPE_NPATHS = 6342
  Public Const LC_PROP_TIN_NAME = 7001
  Public Const LC_PROP_TIN_DESCR = 7002
  Public Const LC_PROP_TIN_FILENAME = 7003
  Public Const LC_PROP_TIN_NPTYPES = 7004
  Public Const LC_PROP_TIN_NPOINTS = 7005
  Public Const LC_PROP_TIN_NTRIANS = 7006
  Public Const LC_PROP_TIN_NBNDPTS = 7007
  Public Const LC_PROP_TIN_NISOLINES = 7008
  Public Const LC_PROP_TIN_HASCFILL = 7009
  Public Const LC_PROP_TIN_PNTIMGDIR = 7010
  Public Const LC_PROP_TIN_XMIN = 7020
  Public Const LC_PROP_TIN_XMAX = 7021
  Public Const LC_PROP_TIN_YMIN = 7022
  Public Const LC_PROP_TIN_YMAX = 7023
  Public Const LC_PROP_TIN_ZMIN = 7024
  Public Const LC_PROP_TIN_ZMAX = 7025
  Public Const LC_PROP_TIN_DX = 7026
  Public Const LC_PROP_TIN_DY = 7027
  Public Const LC_PROP_TIN_DZ = 7028
  Public Const LC_PROP_TIN_ISOBASE = 7031
  Public Const LC_PROP_TIN_ISOSTEP = 7032
  Public Const LC_PROP_TIN_ISOBOLD = 7033
  Public Const LC_PROP_TIN_ISOSPLINE = 7034
  Public Const LC_PROP_TIN_IMG_ZSTEP = 7041
  Public Const LC_PROP_TIN_IMG_PSIZE = 7043
  Public Const LC_PROP_TIN_IMG_NX = 7044
  Public Const LC_PROP_TIN_IMG_NY = 7045
  Public Const LC_PROP_TIN_VIEWPT = 7051
  Public Const LC_PROP_TIN_VIEWPTN = 7052
  Public Const LC_PROP_TIN_VIEWPTI = 7053
  Public Const LC_PROP_TIN_VIEWPTZ = 7054
  Public Const LC_PROP_TIN_VIEWTR = 7055
  Public Const LC_PROP_TIN_VIEWCF = 7056
  Public Const LC_PROP_TIN_VIEWTRI = 7058
  Public Const LC_PROP_TIN_VIEWTRV = 7059
  Public Const LC_PROP_TIN_VIEWBND = 7060
  Public Const LC_PROP_TIN_VIEWBNDI = 7061
  Public Const LC_PROP_TIN_VIEWISO = 7062
  Public Const LC_PROP_TIN_VIEWISOH = 7063
  Public Const LC_PROP_TIN_VIEWZ = 7065
  Public Const LC_PROP_VIEWTINTILES = 7066
  Public Const LC_PROP_VIEWTINCFIR = 7067
  Public Const LC_PROP_TIN_COLTR = 7071
  Public Const LC_PROP_TIN_COLTRI = 7072
  Public Const LC_PROP_TIN_COLTRV = 7073
  Public Const LC_PROP_TIN_COLISO = 7074
  Public Const LC_PROP_TIN_COLISOB = 7075
  Public Const LC_PROP_TIN_COLISOW = 7076
  Public Const LC_PROP_TIN_COLBND = 7077
  Public Const LC_PROP_TIN_COLBNDP = 7078
  Public Const LC_PROP_TIN_COLTRF = 7079
  Public Const LC_PROP_TIN_COLFRONT0 = 7080
  Public Const LC_PROP_TIN_COLFRONT = 7081
  Public Const LC_PROP_TIN_LX_PRJNAME = 7091
  Public Const LC_PROP_TIN_LX_APPNAME = 7092
  Public Const LC_PROP_TIN_LX_DESCR = 7093
  Public Const LC_PROP_TIN_LX_MANUF = 7094
  Public Const LC_PROP_TIN_LX_VER = 7095
  Public Const LC_PROP_TIN_LX_URL = 7096
  Public Const LC_PROP_TIN_LX_TIME = 7097
  Public Const LC_PROP_VER_X = 10001
  Public Const LC_PROP_VER_Y = 10002
  Public Const LC_PROP_VER_Z = 10003
  Public Const LC_PROP_VER_FIX = 10006
  Public Const LC_PROP_VER_RADIUS = 10007
  Public Const LC_PROP_VER_WEIGHT = 10008
  Public Const LC_PROP_VER_INDEX = 10009
  Public Const LC_PROP_VER_FIRST = 10010
  Public Const LC_PROP_VER_LAST = 10011
  Public Const LC_PROP_VER_W0 = 10012
  Public Const LC_PROP_VER_W1 = 10013
  Public Const LC_PROP_VER_SEGDX = 10014
  Public Const LC_PROP_VER_SEGDY = 10015
  Public Const LC_PROP_VER_SEGANG = 10016
  Public Const LC_PROP_VER_SEGLEN = 10017
  Public Const LC_PROP_VER_BULGE = 10021
  Public Const LC_PROP_VER_SEGARCANG = 10022
  Public Const LC_PROP_VER_SEGARCH = 10023
  Public Const LC_PROP_VER_SEGARCLEN = 10024
  Public Const LC_PROP_VER_SEGARCRAD = 10025
  Public Const LC_PROP_RPVER_X = 10041
  Public Const LC_PROP_RPVER_Y = 10042
  Public Const LC_PROP_RPVER_ANGLE = 10043
  Public Const LC_PROP_RPVER_DIRANG = 10044
  Public Const LC_PROP_RPVER_R = 10045
  Public Const LC_PROP_RPVER_L1 = 10046
  Public Const LC_PROP_RPVER_L2 = 10047
  Public Const LC_PROP_RPVER_ANGL1 = 10048
  Public Const LC_PROP_RPVER_ANGARC = 10049
  Public Const LC_PROP_RPVER_ANGL2 = 10050
  Public Const LC_PROP_RPVER_BISEC = 10051
  Public Const LC_PROP_RPVER_DOMER = 10052
  Public Const LC_PROP_RPVER_ARCLEN = 10053
  Public Const LC_PROP_RPVER_CURLEN = 10054
  Public Const LC_PROP_RPVER_LINE1 = 10055
  Public Const LC_PROP_RPVER_T1 = 10056
  Public Const LC_PROP_RPVER_T2 = 10057
  Public Const LC_PROP_RPVER_LINE2 = 10058
  Public Const LC_PROP_RPVER_DIST1 = 10059
  Public Const LC_PROP_RPVER_DIST2 = 10060
  Public Const LC_PROP_XDATA_BOOL = 10901
  Public Const LC_PROP_XDATA_INT = 10902
  Public Const LC_PROP_XDATA_FLOAT = 10903
  Public Const LC_PROP_XDATA_STR = 10907
  Public Const LC_PROP_CMDWND_ENABLE = 11001
  Public Const LC_PROP_PROPWND_ENABLE = 11002
  Public Const LC_PROP_PROPWND_DIVCOEF = 11003
  Public Const LC_PROP_EVENT_TYPE = 12001
  Public Const LC_PROP_EVENT_APPPRM1 = 12002
  Public Const LC_PROP_EVENT_APPPRM2 = 12003
  Public Const LC_PROP_EVENT_WND = 12004
  Public Const LC_PROP_EVENT_DRW = 12005
  Public Const LC_PROP_EVENT_BLOCK = 12006
  Public Const LC_PROP_EVENT_ENTITY = 12007
  Public Const LC_PROP_EVENT_ENT = 12007
  Public Const LC_PROP_EVENT_HCMD = 12008
  Public Const LC_PROP_EVENT_HOBJ = 12008
  Public Const LC_PROP_EVENT_HDC = 12009
  Public Const LC_PROP_EVENT_MODE = 12010
  Public Const LC_PROP_EVENT_INT1 = 12021
  Public Const LC_PROP_EVENT_INT2 = 12022
  Public Const LC_PROP_EVENT_INT3 = 12023
  Public Const LC_PROP_EVENT_INT4 = 12024
  Public Const LC_PROP_EVENT_INT5 = 12025
  Public Const LC_PROP_EVENT_INT6 = 12026
  Public Const LC_PROP_EVENT_FLOAT1 = 12031
  Public Const LC_PROP_EVENT_FLOAT2 = 12032
  Public Const LC_PROP_EVENT_FLOAT3 = 12033
  Public Const LC_PROP_EVENT_FLOAT4 = 12034
  Public Const LC_PROP_EVENT_FLOAT5 = 12035
  Public Const LC_PROP_EVENT_FLOAT6 = 12036
  Public Const LC_PROP_EVENT_STR1 = 12041
  Public Const LC_PROP_EVENT_STR2 = 12042
  Public Const LC_PROP_EVENT_STR3 = 12043
  Public Const LC_EVENT_HELP = 101
  Public Const LC_EVENT_PAINT = 102
  Public Const LC_EVENT_PAINTBG = 124
  Public Const LC_EVENT_WNDVIEW = 103
  Public Const LC_EVENT_MOUSEMOVE = 105
  Public Const LC_EVENT_LBDOWN = 106
  Public Const LC_EVENT_LBUP = 107
  Public Const LC_EVENT_LBDBLCLK = 108
  Public Const LC_EVENT_RBDOWN = 109
  Public Const LC_EVENT_RBUP = 110
  Public Const LC_EVENT_KEYDOWN = 111
  Public Const LC_EVENT_VIEWBLOCK = 112
  Public Const LC_EVENT_EXTENTS = 113
  Public Const LC_EVENT_SNAP = 114
  Public Const LC_EVENT_MAGNIFIER = 115
  Public Const LC_EVENT_NAVIGATOR = 116
  Public Const LC_EVENT_CMDINWND = 117
  Public Const LC_EVENT_GRID = 118
  Public Const LC_EVENT_OSNAP = 119
  Public Const LC_EVENT_PTRACK = 120
  Public Const LC_EVENT_ORTHO = 121
  Public Const LC_EVENT_FILETAB = 122
  Public Const LC_EVENT_WAITPOINT = 123
  Public Const LC_EVENT_FILE = 131
  Public Const LC_EVENT_ADDENTITY = 132
  Public Const LC_EVENT_WNDPROP = 133
  Public Const LC_EVENT_DRWPROP = 134
  Public Const LC_EVENT_ENTPROP = 135
  Public Const LC_EVENT_ENTMOVE = 136
  Public Const LC_EVENT_ENTSCALE = 137
  Public Const LC_EVENT_ENTROTATE = 138
  Public Const LC_EVENT_ENTMIRROR = 139
  Public Const LC_EVENT_ENTERASE = 140
  Public Const LC_EVENT_DRAWIMAGE = 141
  Public Const LC_EVENT_SELECT = 145
  Public Const LC_EVENT_PICKENT = 146
  Public Const LC_EVENT_ADDSTR = 147
  Public Const LC_EVENT_ADDCMD = 148
  Public Const LC_EVENT_CCMD = 149
  Public Const LC_EVENT_TIN = 150
  Public Const LC_EVENT_DRWFILEEXT = 151
  Public Const LC_EVENT_DRWPREVIEW = 152
  Public Const LC_EVENT_DRWLOAD = 153
  Public Const LC_EVENT_DRWSAVE = 154
  Public Const LC_EVENT_GRIPMOVE = 155
  Public Const LC_EVENT_GRIPDRAG = 156
  Public Const LC_EVENT_DIRTY = 157
  Public Const LC_EVENT_SELENT1 = 161
  Public Const LC_EVENT_SELENTS = 162
  Public Const LC_EVENT_GRIPPAINT = 165
  Public Const LC_EVENT_DRAWCURSOR = 166
  Public Const LC_EVENT_RULERCORNER = 167
  Public Const LC_EVENT_WNDTAB = 171
  Public Const LC_EVENT_CMD1 = 212
  Public Const LC_EVENT_LAYERS = 303
  Public Const LC_CCMD_CREATE = 1
  Public Const LC_CCMD_DESTROY = 2
  Public Const LC_CCMD_START = 3
  Public Const LC_CCMD_FINISH = 4
  Public Const LC_CCMD_LBDOWN = 5
  Public Const LC_CCMD_LBUP = 6
  Public Const LC_CCMD_RBDOWN = 7
  Public Const LC_CCMD_RBUP = 8
  Public Const LC_CCMD_MOUSEMOVE = 9
  Public Const LC_CCMD_PAINT = 10
  Public Const LC_CCMD_SNAP = 11

  Public Delegate Sub F_LCEVENT (ByVal hEvent As IntPtr)

  Public Delegate Sub F_WAITPOINT (ByVal FuncPrm As Integer, ByVal hLcWnd As IntPtr)

  Public Delegate Sub F_REDRAW (ByVal hLcWnd As IntPtr, ByVal Elapsed As Integer)

  Public Declare Sub EventSetProc Lib "Litecad.dll" Alias "lcEventSetProc" (ByVal EventType As Integer, pFunc As F_LCEVENT, ByVal Prm1 As Integer, ByVal Prm2 As IntPtr)

  Public Declare Sub EventReturnCode Lib "Litecad.dll" Alias "lcEventReturnCode" (ByVal code As Integer)

  Public Declare Function EventsEnable Lib "Litecad.dll" Alias "lcEventsEnable" (ByVal b As Integer) As Integer

  Public Declare Function Initialize Lib "Litecad.dll" Alias "lcInitialize" () As Integer

  Public Declare Function Uninitialize Lib "Litecad.dll" Alias "lcUninitialize" (ByVal bSaveConfig As Integer) As Integer

  Public Declare Unicode Function StrAdd Lib "Litecad.dll" Alias "lcStrAdd" (ByVal szTag As String, ByVal szText As String) As Integer

  Public Declare Unicode Function StrSet Lib "Litecad.dll" Alias "lcStrSet" (ByVal szTag As String, ByVal szText As String) As Integer

  Public Declare Unicode Function StrGet Lib "Litecad.dll" Alias "lcStrGet" (ByVal szTag As String) As Char

  Public Declare Unicode Function StrFileLoad Lib "Litecad.dll" Alias "lcStrFileLoad" (ByVal szFileName As String) As Integer

  Public Declare Unicode Function StrFileSave Lib "Litecad.dll" Alias "lcStrFileSave" (ByVal szFileName As String, ByVal szLanguage As String) As Integer

  Public Declare Function PropGetBool Lib "Litecad.dll" Alias "lcPropGetBool" (ByVal hObject As IntPtr, ByVal idProp As Integer) As Integer

  Public Declare Function PropGetInt Lib "Litecad.dll" Alias "lcPropGetInt" (ByVal hObject As IntPtr, ByVal idProp As Integer) As Integer

  Public Declare Function PropGetFloat Lib "Litecad.dll" Alias "lcPropGetFloat" (ByVal hObject As IntPtr, ByVal idProp As Integer) As Double

  Function PropGetStr (ByVal hObject As IntPtr, ByVal idProp As Integer) As String
    Dim Buf() As Char
    Dim nChars As Integer
    Dim ch As Integer

    nChars = Lcad.PropGetStr2(hObject, idProp)
    If nChars > 0 Then
      Buf = New Char(nChars) {}
      nChars = nChars - 1
      For i As Integer = 0 To nChars
        ch = Lcad.PropGetChar(i)
        Buf(i) = ChrW(ch)
      Next
      Return New String(Buf)
    End If
    Return ""
  End Function

  Public Declare Function PropGetStrA Lib "Litecad.dll" Alias "lcPropGetStrA" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal szBuf As IntPtr, ByVal BufSize As Integer) As Integer

  Public Declare Function PropGetStr2 Lib "Litecad.dll" Alias "lcPropGetStr2" (ByVal hObject As IntPtr, ByVal idProp As Integer) As Integer

  Public Declare Function PropGetChar Lib "Litecad.dll" Alias "lcPropGetChar" (ByVal iChar As Integer) As Integer

  Public Declare Function PropGetHandle Lib "Litecad.dll" Alias "lcPropGetHandle" (ByVal hObject As IntPtr, ByVal idProp As Integer) As IntPtr

  Public Declare Function PropPutBool Lib "Litecad.dll" Alias "lcPropPutBool" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal bValue As Integer) As Integer

  Public Declare Function PropPutInt Lib "Litecad.dll" Alias "lcPropPutInt" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal Value As Integer) As Integer

  Public Declare Function PropPutFloat Lib "Litecad.dll" Alias "lcPropPutFloat" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal Value As Double) As Integer

  Public Declare Unicode Function PropPutStr Lib "Litecad.dll" Alias "lcPropPutStr" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal szValue As String) As Integer

  Public Declare Function PropPutHandle Lib "Litecad.dll" Alias "lcPropPutHandle" (ByVal hObject As IntPtr, ByVal idProp As Integer, ByVal hValue As IntPtr) As Integer

  Public Declare Function CreateWindow Lib "Litecad.dll" Alias "lcCreateWindow" (ByVal hWndParent As IntPtr, ByVal Style As Integer) As IntPtr

  Public Declare Function DeleteWindow Lib "Litecad.dll" Alias "lcDeleteWindow" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndOnClose Lib "Litecad.dll" Alias "lcWndOnClose" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndExeCommand Lib "Litecad.dll" Alias "lcWndExeCommand" (ByVal hLcWnd As IntPtr, ByVal Command As Integer, ByVal CmdParam As Integer) As Integer

  Public Declare Function WndExitCommand Lib "Litecad.dll" Alias "lcWndExitCommand" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndResize Lib "Litecad.dll" Alias "lcWndResize" (ByVal hLcWnd As IntPtr, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function WndRedraw Lib "Litecad.dll" Alias "lcWndRedraw" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndRedrawAuto Lib "Litecad.dll" Alias "lcWndRedrawAuto" (ByVal hLcWnd As IntPtr, ByVal Elapse As Integer, pFunc As F_REDRAW) As Integer

  Public Declare Function WndSetFocus Lib "Litecad.dll" Alias "lcWndSetFocus" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndSetExtents Lib "Litecad.dll" Alias "lcWndSetExtents" (ByVal hLcWnd As IntPtr, ByVal Xmin As Double, ByVal Ymin As Double, ByVal Xmax As Double, ByVal Ymax As Double) As Integer

  Public Declare Function WndSetBlock Lib "Litecad.dll" Alias "lcWndSetBlock" (ByVal hLcWnd As IntPtr, ByVal hBlock As IntPtr) As Integer

  Public Declare Function WndSetProps Lib "Litecad.dll" Alias "lcWndSetProps" (ByVal hLcWnd As IntPtr, ByVal hPropWnd As IntPtr) As Integer

  Public Declare Function WndSetCmdwin Lib "Litecad.dll" Alias "lcWndSetCmdwin" (ByVal hLcWnd As IntPtr, ByVal hCmdLine As IntPtr) As Integer

  Public Declare Function WndSetBasePoint Lib "Litecad.dll" Alias "lcWndSetBasePoint" (ByVal hLcWnd As IntPtr, ByVal bState As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function WndEmulator Lib "Litecad.dll" Alias "lcWndEmulator" (ByVal hLcWnd As IntPtr, ByVal Mode As Integer) As Integer

  Public Declare Function WndMagnifier Lib "Litecad.dll" Alias "lcWndMagnifier" (ByVal hLcWnd As IntPtr, ByVal bOn As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal Zoom As Integer, ByVal Flags As Integer) As Integer

  Public Declare Unicode Function WndHoverText Lib "Litecad.dll" Alias "lcWndHoverText" (ByVal hLcWnd As IntPtr, ByVal szText As String, ByVal X As Integer, ByVal Y As Integer, ByVal Align As Integer) As Integer

  Public Declare Unicode Function WndMessage Lib "Litecad.dll" Alias "lcWndMessage" (ByVal hLcWnd As IntPtr, ByVal szText As String, ByVal uType As Integer) As Integer

  Public Declare Unicode Function WndWaitPoint Lib "Litecad.dll" Alias "lcWndWaitPoint" (ByVal hLcWnd As IntPtr, ByVal szText As String, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Unicode Function WndWaitPoint2 Lib "Litecad.dll" Alias "lcWndWaitPoint2" (ByVal hLcWnd As IntPtr, ByVal szText As String, ByRef pXdrw As Double, ByRef pYdrw As Double, pFunc As F_WAITPOINT, ByVal FuncPrm As Integer) As Integer

  Public Declare Function WndInputStr Lib "Litecad.dll" Alias "lcWndInputStr" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function WndUpdate Lib "Litecad.dll" Alias "lcWndUpdate" (ByVal hLcWnd As IntPtr, ByVal Mode As Integer) As Integer

  Public Declare Unicode Function WndDrwAdd Lib "Litecad.dll" Alias "lcWndDrwAdd" (ByVal hLcWnd As IntPtr, ByVal szFileName As String) As IntPtr

  Public Declare Function WndDrwDelete Lib "Litecad.dll" Alias "lcWndDrwDelete" (ByVal hLcWnd As IntPtr, ByVal hLcDrw As IntPtr) As Integer

  Public Declare Function WndDrwGet Lib "Litecad.dll" Alias "lcWndDrwGet" (ByVal hLcWnd As IntPtr, ByVal Index As Integer) As IntPtr

  Public Declare Function WndZoomRect Lib "Litecad.dll" Alias "lcWndZoomRect" (ByVal hLcWnd As IntPtr, ByVal Left As Double, ByVal Bottom As Double, ByVal Right As Double, ByVal Top As Double) As Integer

  Public Declare Function WndZoomScale Lib "Litecad.dll" Alias "lcWndZoomScale" (ByVal hLcWnd As IntPtr, ByVal Scal As Double) As Integer

  Public Declare Function WndZoomMove Lib "Litecad.dll" Alias "lcWndZoomMove" (ByVal hLcWnd As IntPtr, ByVal DX As Double, ByVal DY As Double) As Integer

  Public Declare Function WndZoomPos Lib "Litecad.dll" Alias "lcWndZoomPos" (ByVal hLcWnd As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal PixSize As Double) As Integer

  Public Declare Function WndZoomEnt Lib "Litecad.dll" Alias "lcWndZoomEnt" (ByVal hLcWnd As IntPtr, ByVal hEnt As IntPtr, ByVal Scal As Double) As Integer

  Public Declare Function WndGetCursorCoord Lib "Litecad.dll" Alias "lcWndGetCursorCoord" (ByVal hLcWnd As IntPtr, ByRef pXwin As Integer, ByRef pYwin As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Function CoordDrwToWnd Lib "Litecad.dll" Alias "lcCoordDrwToWnd" (ByVal hLcWnd As IntPtr, ByVal Xdrw As Double, ByVal Ydrw As Double, ByRef pXwnd As Integer, ByRef pYwnd As Integer) As Integer

  Public Declare Function CoordWndToDrw Lib "Litecad.dll" Alias "lcCoordWndToDrw" (ByVal hLcWnd As IntPtr, ByVal Xwnd As Integer, ByVal Ywnd As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Function WndCoordFromDrw Lib "Litecad.dll" Alias "lcWndCoordFromDrw" (ByVal hLcWnd As IntPtr, ByVal Xdrw As Double, ByVal Ydrw As Double, ByRef pXwin As Integer, ByRef pYwin As Integer) As Integer

  Public Declare Function WndCoordToDrw Lib "Litecad.dll" Alias "lcWndCoordToDrw" (ByVal hLcWnd As IntPtr, ByVal Xwin As Integer, ByVal Ywin As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Function WndGetEntByPoint Lib "Litecad.dll" Alias "lcWndGetEntByPoint" (ByVal hLcWnd As IntPtr, ByVal Xwin As Integer, ByVal Ywin As Integer) As IntPtr

  Public Declare Function WndGetEntByPoint2 Lib "Litecad.dll" Alias "lcWndGetEntByPoint2" (ByVal hLcWnd As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As IntPtr

  Public Declare Function WndGetEntsByPoint Lib "Litecad.dll" Alias "lcWndGetEntsByPoint" (ByVal hLcWnd As IntPtr, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal nMaxEnts As Integer) As Integer

  Public Declare Function WndGetEntsByRect Lib "Litecad.dll" Alias "lcWndGetEntsByRect" (ByVal hLcWnd As IntPtr, ByVal Lef As Double, ByVal Bot As Double, ByVal Rig As Double, ByVal Top As Double, ByVal bCross As Integer, ByVal nMaxEnts As Integer) As Integer

  Public Declare Function WndGetEntity Lib "Litecad.dll" Alias "lcWndGetEntity" (ByVal iEnt As Integer) As IntPtr

  Public Declare Function WndGetEntByID Lib "Litecad.dll" Alias "lcWndGetEntByID" (ByVal hLcWnd As IntPtr, ByVal Id As Integer) As IntPtr

  Public Declare Unicode Function WndGetEntByIDH Lib "Litecad.dll" Alias "lcWndGetEntByIDH" (ByVal hLcWnd As IntPtr, ByVal szId As String) As IntPtr

  Public Declare Function WndGetEntByKey Lib "Litecad.dll" Alias "lcWndGetEntByKey" (ByVal hLcWnd As IntPtr, ByVal Key As Integer) As IntPtr

  Public Declare Unicode Function WndPickEnt Lib "Litecad.dll" Alias "lcWndPickEnt" (ByVal hLcWnd As IntPtr, ByVal szTitle As String, ByVal szCursorText As String) As Integer

  Public Declare Function FontGetFirst Lib "Litecad.dll" Alias "lcFontGetFirst" () As IntPtr

  Public Declare Function FontGetNext Lib "Litecad.dll" Alias "lcFontGetNext" (ByVal hFont As IntPtr) As IntPtr

  Public Declare Unicode Function FontAddRes Lib "Litecad.dll" Alias "lcFontAddRes" (ByVal szFontName As String, ByVal hModule As IntPtr, ByVal idResource As Integer) As IntPtr

  Public Declare Unicode Function FontAddFile Lib "Litecad.dll" Alias "lcFontAddFile" (ByVal szFontName As String, ByVal szFilename As String, ByVal szOutFontName As IntPtr) As IntPtr

  Public Declare Unicode Function FontAddBin Lib "Litecad.dll" Alias "lcFontAddBin" (ByVal szFontName As String, ByVal hData As IntPtr) As IntPtr

  Public Declare Function FontGetChar Lib "Litecad.dll" Alias "lcFontGetChar" (ByVal hFont As IntPtr, ByVal CharCode As Integer) As IntPtr

  Public Declare Unicode Function FontGetName Lib "Litecad.dll" Alias "lcFontGetName" (ByVal szFilename As String) As Char

  Public Declare Unicode Function ProgressCreate Lib "Litecad.dll" Alias "lcProgressCreate" (ByVal hLcWnd As IntPtr, ByVal W As Integer, ByVal H As Integer, ByVal szTitle As String) As Integer

  Public Declare Unicode Function ProgressSetText Lib "Litecad.dll" Alias "lcProgressSetText" (ByVal szText As String) As Integer

  Public Declare Function ProgressStart Lib "Litecad.dll" Alias "lcProgressStart" (ByVal MinVal As Integer, ByVal MaxVal As Integer) As Integer

  Public Declare Function ProgressSetPos Lib "Litecad.dll" Alias "lcProgressSetPos" (ByVal Val As Integer) As Integer

  Public Declare Function ProgressInc Lib "Litecad.dll" Alias "lcProgressInc" () As Integer

  Public Declare Function ProgressDelete Lib "Litecad.dll" Alias "lcProgressDelete" () As Integer

  Public Declare Function QuadCreate Lib "Litecad.dll" Alias "lcQuadCreate" () As IntPtr

  Public Declare Function QuadDelete Lib "Litecad.dll" Alias "lcQuadDelete" (ByVal hQuad As IntPtr) As Integer

  Public Declare Function QuadSet Lib "Litecad.dll" Alias "lcQuadSet" (ByVal hQuad As IntPtr, ByVal x0 As Double, ByVal y0 As Double, ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByVal x3 As Double, ByVal y3 As Double) As Integer

  Public Declare Function QuadTransXYtoUV Lib "Litecad.dll" Alias "lcQuadTransXYtoUV" (ByVal hQuad As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pU As Double, ByRef pV As Double) As Integer

  Public Declare Function QuadTransUVtoXY Lib "Litecad.dll" Alias "lcQuadTransUVtoXY" (ByVal hQuad As IntPtr, ByVal U As Double, ByVal V As Double, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function QuadContains Lib "Litecad.dll" Alias "lcQuadContains" (ByVal hQuad As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function GridCreate Lib "Litecad.dll" Alias "lcGridCreate" () As IntPtr

  Public Declare Function GridDelete Lib "Litecad.dll" Alias "lcGridDelete" (ByVal hGrid As IntPtr) As Integer

  Public Declare Function GridSet Lib "Litecad.dll" Alias "lcGridSet" (ByVal hGrid As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal W As Double, ByVal H As Double, ByVal Nx As Integer, ByVal Ny As Integer) As Integer

  Public Declare Function GridSetDest Lib "Litecad.dll" Alias "lcGridSetDest" (ByVal hGrid As IntPtr, ByVal Ix As Integer, ByVal Iy As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function GridUpdate Lib "Litecad.dll" Alias "lcGridUpdate" (ByVal hGrid As IntPtr) As Integer

  Public Declare Function GridTrans Lib "Litecad.dll" Alias "lcGridTrans" (ByVal hGrid As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pXdest As Double, ByRef pYdest As Double) As Integer

  Public Declare Function GridGetNode Lib "Litecad.dll" Alias "lcGridGetNode" (ByVal hGrid As IntPtr, ByVal bDest As Integer, ByVal Ix As Integer, ByVal Iy As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function GridGetCell Lib "Litecad.dll" Alias "lcGridGetCell" (ByVal hGrid As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pIx As Integer, ByRef pIy As Integer) As Integer

  Public Declare Function GridSetView Lib "Litecad.dll" Alias "lcGridSetView" (ByVal hGrid As IntPtr, ByVal Mode As Integer, ByVal hLcWnd As IntPtr, ByVal ColLine As IntPtr, ByVal ColNode As IntPtr) As Integer

  Public Declare Function CreateCmdwin Lib "Litecad.dll" Alias "lcCreateCmdwin" (ByVal hWndParent As IntPtr, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As IntPtr

  Public Declare Function CmdwinResize Lib "Litecad.dll" Alias "lcCmdwinResize" (ByVal hCmdLine As IntPtr, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function CmdwinUpdate Lib "Litecad.dll" Alias "lcCmdwinUpdate" (ByVal hCmdLine As IntPtr) As Integer

  Public Declare Function CreateProps Lib "Litecad.dll" Alias "lcCreateProps" (ByVal hWndParent As IntPtr, ByVal Mode As Integer) As IntPtr

  Public Declare Function DeleteProps Lib "Litecad.dll" Alias "lcDeleteProps" (ByVal hPropWnd As IntPtr) As Integer

  Public Declare Function PropsResize Lib "Litecad.dll" Alias "lcPropsResize" (ByVal hPropWnd As IntPtr, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function PropsUpdate Lib "Litecad.dll" Alias "lcPropsUpdate" (ByVal hPropWnd As IntPtr, ByVal bSelChanged As Integer) As Integer

  Public Declare Function CreateStatbar Lib "Litecad.dll" Alias "lcCreateStatbar" (ByVal hWndParent As IntPtr) As IntPtr

  Public Declare Function DeleteStatbar Lib "Litecad.dll" Alias "lcDeleteStatbar" (ByVal hStatbar As IntPtr) As Integer

  Public Declare Function StatbarResize Lib "Litecad.dll" Alias "lcStatbarResize" (ByVal hStatbar As IntPtr, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function StatbarCell Lib "Litecad.dll" Alias "lcStatbarCell" (ByVal hStatbar As IntPtr, ByVal Id As Integer, ByVal Pos As Integer) As Integer

  Public Declare Unicode Function StatbarText Lib "Litecad.dll" Alias "lcStatbarText" (ByVal hStatbar As IntPtr, ByVal Id As Integer, ByVal szText As String) As Integer

  Public Declare Function StatbarRedraw Lib "Litecad.dll" Alias "lcStatbarRedraw" (ByVal hStatbar As IntPtr) As Integer

  Public Declare Unicode Function DgGetValue Lib "Litecad.dll" Alias "lcDgGetValue" (ByVal hWnd As IntPtr, ByVal Lef As Integer, ByVal Top As Integer, ByVal szTitle As String, ByVal szPrompt As String) As Integer

  Public Declare Unicode Function Help Lib "Litecad.dll" Alias "lcHelp" (ByVal szTopic As String) As Integer

  Public Declare Sub GetPolarPoint Lib "Litecad.dll" Alias "lcGetPolarPoint" (ByVal x0 As Double, ByVal y0 As Double, ByVal Angle As Double, ByVal Dist As Double, ByRef pOutX As Double, ByRef pOutY As Double)

  Public Declare Sub GetPolarPrm Lib "Litecad.dll" Alias "lcGetPolarPrm" (ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByRef pAngle As Double, ByRef pDist As Double)

  Public Declare Function GetClientSize Lib "Litecad.dll" Alias "lcGetClientSize" (ByVal hWnd As IntPtr, ByRef pWidth As Integer, ByRef pHeight As Integer) As Integer

  Public Declare Function GetErrorCode Lib "Litecad.dll" Alias "lcGetErrorCode" () As Integer

  Public Declare Unicode Function GetErrorStr Lib "Litecad.dll" Alias "lcGetErrorStr" () As Char

  Public Declare Function GetStr Lib "Litecad.dll" Alias "lcGetStr" (ByVal Mode As Integer) As Integer

  Public Declare Unicode Function GetDrwXData Lib "Litecad.dll" Alias "lcGetDrwXData" (ByVal szFileName As String) As Integer

  Public Declare Unicode Function GetDrwPreview Lib "Litecad.dll" Alias "lcGetDrwPreview" (ByVal szFileName As String, ByVal pOutDIB As IntPtr) As Integer

  Public Declare Function FilletSetLines Lib "Litecad.dll" Alias "lcFilletSetLines" (ByVal L1x0 As Double, ByVal L1y0 As Double, ByVal L1x1 As Double, ByVal L1y1 As Double, ByVal L2x0 As Double, ByVal L2y0 As Double, ByVal L2x1 As Double, ByVal L2y1 As Double) As Integer

  Public Declare Function Fillet Lib "Litecad.dll" Alias "lcFillet" (ByVal Rad As Double, ByVal Bis As Double, ByVal Tang As Double) As Integer

  Public Declare Function FilletGetPoint Lib "Litecad.dll" Alias "lcFilletGetPoint" (ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Unicode Function FileToStrA Lib "Litecad.dll" Alias "lcFileToStrA" (ByVal szFileName As String, ByVal pBuf As IntPtr) As Integer

  Public Declare Unicode Function CreateCommand Lib "Litecad.dll" Alias "lcCreateCommand" (ByVal hLcWnd As IntPtr, ByVal Id As Integer, ByVal szTitle As String) As IntPtr

  Public Declare Function CmdExit Lib "Litecad.dll" Alias "lcCmdExit" (ByVal hCmd As IntPtr) As Integer

  Public Declare Unicode Function CmdCursorText Lib "Litecad.dll" Alias "lcCmdCursorText" (ByVal hCmd As IntPtr, ByVal szText As String) As Integer

  Public Declare Unicode Function CmdMessage Lib "Litecad.dll" Alias "lcCmdMessage" (ByVal hCmd As IntPtr, ByVal szText As String, ByVal uType As Integer) As Integer

  Public Declare Function CmdResetLastPt Lib "Litecad.dll" Alias "lcCmdResetLastPt" (ByVal hCmd As IntPtr) As Integer

  Public Declare Unicode Function TIS_InitLibrary Lib "Litecad.dll" Alias "lcTIS_InitLibrary" (ByVal szLicenseKey As String, ByVal bErrMsg As Integer) As Integer

  Public Declare Function TIS_CloseLibrary Lib "Litecad.dll" Alias "lcTIS_CloseLibrary" () As Integer

  Public Declare Unicode Function CameraConnect Lib "Litecad.dll" Alias "lcCameraConnect" (ByVal szName As String) As Integer

  Public Declare Function CameraDisconnect Lib "Litecad.dll" Alias "lcCameraDisconnect" () As Integer

  Public Declare Function CameraShot Lib "Litecad.dll" Alias "lcCameraShot" () As Integer

  Public Declare Function CreateDrawing Lib "Litecad.dll" Alias "lcCreateDrawing" () As IntPtr

  Public Declare Function DeleteDrawing Lib "Litecad.dll" Alias "lcDeleteDrawing" (ByVal hDrw As IntPtr) As Integer

  Public Declare Unicode Function DrwNew Lib "Litecad.dll" Alias "lcDrwNew" (ByVal hDrw As IntPtr, ByVal szFileName As String, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function DrwLoad Lib "Litecad.dll" Alias "lcDrwLoad" (ByVal hDrw As IntPtr, ByVal szFileName As String, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function DrwLoadMem Lib "Litecad.dll" Alias "lcDrwLoadMem" (ByVal hDrw As IntPtr, ByVal hMem As IntPtr, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function DxfLoadMem Lib "Litecad.dll" Alias "lcDxfLoadMem" (ByVal hDrw As IntPtr, ByVal hMem As IntPtr, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function DrwLoadTIN Lib "Litecad.dll" Alias "lcDrwLoadTIN" (ByVal hDrw As IntPtr, ByVal szFileName As String, ByVal hLcWnd As IntPtr) As IntPtr

  Public Declare Function DrwSaveTIN Lib "Litecad.dll" Alias "lcDrwSaveTIN" (ByVal hDrw As IntPtr, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function DrwInsert Lib "Litecad.dll" Alias "lcDrwInsert" (ByVal hDrw As IntPtr, ByVal szFileName As String, ByVal Overwrite As Integer, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function DrwInsertSHP Lib "Litecad.dll" Alias "lcDrwInsertSHP" (ByVal hDrw As IntPtr, ByVal hLayer As IntPtr, ByVal szFileName As String, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function DrwCopy Lib "Litecad.dll" Alias "lcDrwCopy" (ByVal hDrw As IntPtr, ByVal hDrwSrc As IntPtr) As Integer

  Public Declare Unicode Function DrwSave Lib "Litecad.dll" Alias "lcDrwSave" (ByVal hDrw As IntPtr, ByVal szFileName As String, ByVal bBak As Integer, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function DrwSaveMem Lib "Litecad.dll" Alias "lcDrwSaveMem" (ByVal hDrw As IntPtr, ByVal hMem As IntPtr, ByVal MemSize As Integer) As Integer

  Public Declare Unicode Function DrwAddLayer Lib "Litecad.dll" Alias "lcDrwAddLayer" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szColor As String, ByVal hLtype As IntPtr, ByVal Lwidth As Integer) As IntPtr

  Public Declare Unicode Function DrwAddLayer2 Lib "Litecad.dll" Alias "lcDrwAddLayer2" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal hFromLayer As IntPtr) As IntPtr

  Public Declare Unicode Function DrwAddLinetype Lib "Litecad.dll" Alias "lcDrwAddLinetype" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szDefinition As String) As IntPtr

  Public Declare Unicode Function DrwAddLinetypeF Lib "Litecad.dll" Alias "lcDrwAddLinetypeF" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szFileName As String, ByVal szLtypeName As String) As IntPtr

  Public Declare Unicode Function DrwAddTextStyle Lib "Litecad.dll" Alias "lcDrwAddTextStyle" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szFontName As String, ByVal bWinFont As Integer) As IntPtr

  Public Declare Unicode Function DrwAddDimStyle Lib "Litecad.dll" Alias "lcDrwAddDimStyle" (ByVal hDrw As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Unicode Function DrwAddMlineStyle Lib "Litecad.dll" Alias "lcDrwAddMlineStyle" (ByVal hDrw As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Unicode Function DrwAddPntStyle Lib "Litecad.dll" Alias "lcDrwAddPntStyle" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal hBlock As IntPtr, ByVal BlockScale As Double, ByVal hTStyle As IntPtr, ByVal TextHeight As Double, ByVal TextWidth As Double) As IntPtr

  Public Declare Unicode Function DrwAddFilling Lib "Litecad.dll" Alias "lcDrwAddFilling" (ByVal hDrw As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Unicode Function DrwAddImage Lib "Litecad.dll" Alias "lcDrwAddImage" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szFileName As String) As IntPtr

  Public Declare Unicode Function DrwAddImage2 Lib "Litecad.dll" Alias "lcDrwAddImage2" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal Width As Integer, ByVal Height As Integer, ByVal nBits As Integer, ByVal hData As IntPtr, ByVal bTopDown As Integer) As IntPtr

  Public Declare Unicode Function DrwAddImage3 Lib "Litecad.dll" Alias "lcDrwAddImage3" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal hMem As IntPtr) As IntPtr

  Public Declare Unicode Function DrwAddImageCam Lib "Litecad.dll" Alias "lcDrwAddImageCam" (ByVal hDrw As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Unicode Function DrwAddBlock Lib "Litecad.dll" Alias "lcDrwAddBlock" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Unicode Function DrwAddBlockFromFile Lib "Litecad.dll" Alias "lcDrwAddBlockFromFile" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szFileName As String, ByVal Overwrite As Integer, ByVal hwParent As IntPtr) As IntPtr

  Public Declare Unicode Function DrwAddBlockFromDrw Lib "Litecad.dll" Alias "lcDrwAddBlockFromDrw" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal hDrw2 As IntPtr, ByVal Overwrite As Integer, ByVal hwParent As IntPtr) As IntPtr

  Public Declare Unicode Function DrwAddBlockFile Lib "Litecad.dll" Alias "lcDrwAddBlockFile" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal szFileName As String, ByVal Overwrite As Integer, ByVal hwParent As IntPtr) As IntPtr

  Public Declare Unicode Function DrwAddBlockPaper Lib "Litecad.dll" Alias "lcDrwAddBlockPaper" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal PaperSize As Integer, ByVal Orient As Integer, ByVal Width As Double, ByVal Height As Double) As IntPtr

  Public Declare Unicode Function DrwAddBlockCopy Lib "Litecad.dll" Alias "lcDrwAddBlockCopy" (ByVal hDrw As IntPtr, ByVal szName As String, ByVal hSrcBlock As IntPtr) As IntPtr

  Public Declare Function DrwDeleteObject Lib "Litecad.dll" Alias "lcDrwDeleteObject" (ByVal hDrw As IntPtr, ByVal hObject As IntPtr) As Integer

  Public Declare Function DrwDeleteUnused Lib "Litecad.dll" Alias "lcDrwDeleteUnused" (ByVal hDrw As IntPtr, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwCountObjects Lib "Litecad.dll" Alias "lcDrwCountObjects" (ByVal hDrw As IntPtr, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwSortObjects Lib "Litecad.dll" Alias "lcDrwSortObjects" (ByVal hDrw As IntPtr, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwUpdateWinFonts Lib "Litecad.dll" Alias "lcDrwUpdateWinFonts" (ByVal hDrw As IntPtr, ByVal hTStyle As IntPtr) As Integer

  Public Declare Function DrwUpdateBlkRefs Lib "Litecad.dll" Alias "lcDrwUpdateBlkRefs" (ByVal hDrw As IntPtr, ByVal hBlock As IntPtr) As Integer

  Public Declare Function DrwUpdateTexts Lib "Litecad.dll" Alias "lcDrwUpdateTexts" (ByVal hDrw As IntPtr, ByVal hTStyle As IntPtr) As Integer

  Public Declare Function DrwGetFirstObject Lib "Litecad.dll" Alias "lcDrwGetFirstObject" (ByVal hDrw As IntPtr, ByVal ObjType As Integer) As IntPtr

  Public Declare Function DrwGetNextObject Lib "Litecad.dll" Alias "lcDrwGetNextObject" (ByVal hDrw As IntPtr, ByVal hObject As IntPtr) As IntPtr

  Public Declare Function DrwGetObjectByID Lib "Litecad.dll" Alias "lcDrwGetObjectByID" (ByVal hDrw As IntPtr, ByVal ObjType As Integer, ByVal Id As Integer) As IntPtr

  Public Declare Unicode Function DrwGetObjectByIDH Lib "Litecad.dll" Alias "lcDrwGetObjectByIDH" (ByVal hDrw As IntPtr, ByVal ObjType As Integer, ByVal szId As String) As IntPtr

  Public Declare Unicode Function DrwGetObjectByName Lib "Litecad.dll" Alias "lcDrwGetObjectByName" (ByVal hDrw As IntPtr, ByVal ObjType As Integer, ByVal szName As String) As IntPtr

  Public Declare Function DrwGetEntByID Lib "Litecad.dll" Alias "lcDrwGetEntByID" (ByVal hDrw As IntPtr, ByVal Id As Integer) As IntPtr

  Public Declare Unicode Function DrwGetEntByIDH Lib "Litecad.dll" Alias "lcDrwGetEntByIDH" (ByVal hDrw As IntPtr, ByVal szId As String) As IntPtr

  Public Declare Function DrwGetEntByKey Lib "Litecad.dll" Alias "lcDrwGetEntByKey" (ByVal hDrw As IntPtr, ByVal Key As Integer) As IntPtr

  Public Declare Function DrwClearXData Lib "Litecad.dll" Alias "lcDrwClearXData" (ByVal hDrw As IntPtr, ByVal ObjType As Integer, ByVal Mode As Integer) As Integer

  Public Declare Function DrwPurge Lib "Litecad.dll" Alias "lcDrwPurge" (ByVal hDrw As IntPtr) As Integer

  Public Declare Function DrwExplode Lib "Litecad.dll" Alias "lcDrwExplode" (ByVal hDrw As IntPtr, ByVal Mode As Integer) As Integer

  Public Declare Function DrwSetLimits Lib "Litecad.dll" Alias "lcDrwSetLimits" (ByVal hDrw As IntPtr, ByVal Xmin As Double, ByVal Ymin As Double, ByVal Xmax As Double, ByVal Ymax As Double) As Integer

  Public Declare Function DrwUndoRecord Lib "Litecad.dll" Alias "lcDrwUndoRecord" (ByVal hDrw As IntPtr, ByVal Mode As Integer) As Integer

  Public Declare Function DrwUndo Lib "Litecad.dll" Alias "lcDrwUndo" (ByVal hDrw As IntPtr, ByVal bRedo As Integer) As Integer

  Public Declare Function CRectsClear Lib "Litecad.dll" Alias "lcCRectsClear" (ByVal hDrw As IntPtr) As Integer

  Public Declare Function CRectsAdd Lib "Litecad.dll" Alias "lcCRectsAdd" (ByVal hDrw As IntPtr, ByVal ID As Integer, ByVal Lef As Double, ByVal Bot As Double, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function CRectsDivide Lib "Litecad.dll" Alias "lcCRectsDivide" (ByVal hDrw As IntPtr, ByVal NumX As Integer, ByVal NumY As Integer, ByVal bClearExist As Integer) As Integer

  Public Declare Function CRectsGetFirst Lib "Litecad.dll" Alias "lcCRectsGetFirst" (ByVal hDrw As IntPtr) As IntPtr

  Public Declare Function CRectsGetNext Lib "Litecad.dll" Alias "lcCRectsGetNext" (ByVal hDrw As IntPtr, ByVal hCRect As IntPtr) As IntPtr

  Public Declare Function CRectsGetWithID Lib "Litecad.dll" Alias "lcCRectsGetWithID" (ByVal hDrw As IntPtr, ByVal Id As Integer) As IntPtr

  Public Declare Function CRectsActive Lib "Litecad.dll" Alias "lcCRectsActive" (ByVal hDrw As IntPtr, ByVal hCRect As IntPtr) As Integer

  Public Declare Function CRectsGetActive Lib "Litecad.dll" Alias "lcCRectsGetActive" (ByVal hDrw As IntPtr) As IntPtr

  Public Declare Function CRectsDelete Lib "Litecad.dll" Alias "lcCRectsDelete" (ByVal hDrw As IntPtr, ByVal hCRect As IntPtr) As Integer

  Public Declare Unicode Function CRectsSave Lib "Litecad.dll" Alias "lcCRectsSave" (ByVal hDrw As IntPtr, ByVal hCRect As IntPtr, ByVal szFileName As String) As Integer

  Public Declare Unicode Function CRectsBitmap Lib "Litecad.dll" Alias "lcCRectsBitmap" (ByVal hDrw As IntPtr, ByVal hCRect As IntPtr, ByVal szFileName As String, ByVal PixelSize As Double) As Integer

  Public Declare Function BlockSetViewRect Lib "Litecad.dll" Alias "lcBlockSetViewRect" (ByVal hBlock As IntPtr, ByVal Xcen As Double, ByVal Ycen As Double, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function BlockSetViewRect2 Lib "Litecad.dll" Alias "lcBlockSetViewRect2" (ByVal hBlock As IntPtr, ByVal Lef As Double, ByVal Bot As Double, ByVal Rig As Double, ByVal Top As Double) As Integer

  Public Declare Function BlockSetPaperSize Lib "Litecad.dll" Alias "lcBlockSetPaperSize" (ByVal hBlock As IntPtr, ByVal PaperSize As Integer, ByVal Orient As Integer, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Unicode Function BlockRasterize Lib "Litecad.dll" Alias "lcBlockRasterize" (ByVal hBlock As IntPtr, ByVal szFileName As String, ByVal Xmin As Double, ByVal Ymin As Double, ByVal Xmax As Double, ByVal Ymax As Double, ByVal ImgW As Integer, ByVal ImgH As Integer) As Integer

  Public Declare Function BlockRasterizeMem Lib "Litecad.dll" Alias "lcBlockRasterizeMem" (ByVal hBlock As IntPtr, ByVal hMem As IntPtr, ByVal Xmin As Double, ByVal Ymin As Double, ByVal Xmax As Double, ByVal Ymax As Double, ByVal ImgW As Integer, ByVal ImgH As Integer) As Integer

  Public Declare Function BlockUpdate Lib "Litecad.dll" Alias "lcBlockUpdate" (ByVal hBlock As IntPtr, ByVal bUpdEnts As Integer, ByVal hNewEnt As IntPtr) As Integer

  Public Declare Function BlockMove Lib "Litecad.dll" Alias "lcBlockMove" (ByVal hBlock As IntPtr, ByVal dX As Double, ByVal dY As Double, ByVal bUpdate As Integer) As Integer

  Public Declare Function BlockScale Lib "Litecad.dll" Alias "lcBlockScale" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal bUpdate As Integer) As Integer

  Public Declare Function BlockRotate Lib "Litecad.dll" Alias "lcBlockRotate" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal bUpdate As Integer) As Integer

  Public Declare Function BlockMirror Lib "Litecad.dll" Alias "lcBlockMirror" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bUpdate As Integer) As Integer

  Public Declare Function BlockClear Lib "Litecad.dll" Alias "lcBlockClear" (ByVal hBlock As IntPtr, ByVal hLayer As IntPtr) As Integer

  Public Declare Function BlockPurge Lib "Litecad.dll" Alias "lcBlockPurge" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function BlockSortEnts Lib "Litecad.dll" Alias "lcBlockSortEnts" (ByVal hBlock As IntPtr, ByVal bByLayers As Integer, ByVal hWnd As IntPtr) As Integer

  Public Declare Function BlockSortEnts2 Lib "Litecad.dll" Alias "lcBlockSortEnts2" (ByVal hBlock As IntPtr, ByVal idEnts As IntPtr, ByVal nEnts As Integer) As Integer

  Public Declare Function BlockAddPoint Lib "Litecad.dll" Alias "lcBlockAddPoint" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function BlockAddPoint2 Lib "Litecad.dll" Alias "lcBlockAddPoint2" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal PtMode As Integer, ByVal PtSize As Double) As IntPtr

  Public Declare Function BlockAddPoint3d Lib "Litecad.dll" Alias "lcBlockAddPoint3d" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Z As Double) As IntPtr

  Public Declare Unicode Function BlockAddPointsF Lib "Litecad.dll" Alias "lcBlockAddPointsF" (ByVal hBlock As IntPtr, ByVal szFileName As String, ByVal hWnd As IntPtr) As Integer

  Public Declare Function BlockAddXline Lib "Litecad.dll" Alias "lcBlockAddXline" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal bRay As Integer) As IntPtr

  Public Declare Function BlockAddXline2P Lib "Litecad.dll" Alias "lcBlockAddXline2P" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bRay As Integer) As IntPtr

  Public Declare Function BlockAddLine Lib "Litecad.dll" Alias "lcBlockAddLine" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As IntPtr

  Public Declare Function BlockAddLineDir Lib "Litecad.dll" Alias "lcBlockAddLineDir" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal Dist As Double) As IntPtr

  Public Declare Function BlockAddLineTan Lib "Litecad.dll" Alias "lcBlockAddLineTan" (ByVal hBlock As IntPtr, ByVal hEnt1 As IntPtr, ByVal hEnt2 As IntPtr, ByVal Mode As Integer) As IntPtr

  Public Declare Function BlockAddPolyline Lib "Litecad.dll" Alias "lcBlockAddPolyline" (ByVal hBlock As IntPtr, ByVal FitType As Integer, ByVal bClosed As Integer, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddRPolygon Lib "Litecad.dll" Alias "lcBlockAddRPolygon" (ByVal hBlock As IntPtr, ByVal nVers As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Ang0 As Double, ByVal bInscribed As Integer, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddSpline Lib "Litecad.dll" Alias "lcBlockAddSpline" (ByVal hBlock As IntPtr, ByVal bClosed As Integer, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddBezier Lib "Litecad.dll" Alias "lcBlockAddBezier" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockAddMline Lib "Litecad.dll" Alias "lcBlockAddMline" (ByVal hBlock As IntPtr, ByVal FitType As Integer, ByVal bClosed As Integer) As IntPtr

  Public Declare Function BlockAddRect Lib "Litecad.dll" Alias "lcBlockAddRect" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Width As Double, ByVal Height As Double, ByVal Angle As Double, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddRect2 Lib "Litecad.dll" Alias "lcBlockAddRect2" (ByVal hBlock As IntPtr, ByVal Left As Double, ByVal Bottom As Double, ByVal Width As Double, ByVal Height As Double, ByVal Rad As Double, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddCircle Lib "Litecad.dll" Alias "lcBlockAddCircle" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal bFilled As Integer) As IntPtr

  Public Declare Function BlockAddArc Lib "Litecad.dll" Alias "lcBlockAddArc" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal StartAngle As Double, ByVal ArcAngle As Double) As IntPtr

  Public Declare Function BlockAddArc3P Lib "Litecad.dll" Alias "lcBlockAddArc3P" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double) As IntPtr

  Public Declare Function BlockAddFillet Lib "Litecad.dll" Alias "lcBlockAddFillet" (ByVal hBlock As IntPtr, ByVal hEnt1 As IntPtr, ByVal hEnt2 As IntPtr, ByVal Radius As Double) As IntPtr

  Public Declare Function BlockAddEllipse Lib "Litecad.dll" Alias "lcBlockAddEllipse" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal R1 As Double, ByVal R2 As Double, ByVal RotAngle As Double, ByVal StartAngle As Double, ByVal ArcAngle As Double) As IntPtr

  Public Declare Unicode Function BlockAddText Lib "Litecad.dll" Alias "lcBlockAddText" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Unicode Function BlockAddText2 Lib "Litecad.dll" Alias "lcBlockAddText2" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As IntPtr

  Public Declare Unicode Function BlockAddText3 Lib "Litecad.dll" Alias "lcBlockAddText3" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Align As Integer, ByVal HW As Double, ByVal Oblique As Double) As IntPtr

  Public Declare Unicode Function BlockAddTextWin Lib "Litecad.dll" Alias "lcBlockAddTextWin" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Unicode Function BlockAddTextWin2 Lib "Litecad.dll" Alias "lcBlockAddTextWin2" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As IntPtr

  Public Declare Unicode Function BlockAddMText Lib "Litecad.dll" Alias "lcBlockAddMText" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal WrapWidth As Double, ByVal Align As Integer, ByVal RotAngle As Double, ByVal H As Double, ByVal WScale As Double) As IntPtr

  Public Declare Unicode Function BlockAddArcText Lib "Litecad.dll" Alias "lcBlockAddArcText" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal StartAngle As Double, ByVal bClockwise As Integer, ByVal H As Double, ByVal WScale As Double, ByVal Align As Integer) As IntPtr

  Public Declare Function BlockAddBlockRef Lib "Litecad.dll" Alias "lcBlockAddBlockRef" (ByVal hBlock As IntPtr, ByVal hRefBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As IntPtr

  Public Declare Function BlockAddBlockRefID Lib "Litecad.dll" Alias "lcBlockAddBlockRefID" (ByVal hBlock As IntPtr, ByVal idRefBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As IntPtr

  Public Declare Unicode Function BlockAddBlockRefIDH Lib "Litecad.dll" Alias "lcBlockAddBlockRefIDH" (ByVal hBlock As IntPtr, ByVal szIdRefBlock As String, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As IntPtr

  Public Declare Unicode Function BlockAddAttDef Lib "Litecad.dll" Alias "lcBlockAddAttDef" (ByVal hBlock As IntPtr, ByVal Mode As Integer, ByVal szTag As String, ByVal szPrompt As String, ByVal szDefVal As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As IntPtr

  Public Declare Unicode Function BlockAddXref Lib "Litecad.dll" Alias "lcBlockAddXref" (ByVal hBlock As IntPtr, ByVal szFileName As String, ByVal X As Double, ByVal Y As Double, ByVal ScalX As Double, ByVal ScalY As Double, ByVal Angle As Double) As IntPtr

  Public Declare Function BlockAddImageRef Lib "Litecad.dll" Alias "lcBlockAddImageRef" (ByVal hBlock As IntPtr, ByVal hImage As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Width As Double, ByVal Height As Double, ByVal bBorder As Integer) As IntPtr

  Public Declare Function BlockAddImageRefUns Lib "Litecad.dll" Alias "lcBlockAddImageRefUns" (ByVal hBlock As IntPtr, ByVal hImage As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Align As Integer, ByVal bBorder As Integer) As IntPtr

  Public Declare Function BlockAddImagePlace Lib "Litecad.dll" Alias "lcBlockAddImagePlace" (ByVal hBlock As IntPtr, ByVal Id As Integer, ByVal X As Double, ByVal Y As Double, ByVal Width As Double, ByVal Height As Double, ByVal bBorder As Integer) As IntPtr

  Public Declare Unicode Function BlockAddEcw Lib "Litecad.dll" Alias "lcBlockAddEcw" (ByVal hBlock As IntPtr, ByVal szFileName As String) As IntPtr

  Public Declare Unicode Function BlockAddBarcode Lib "Litecad.dll" Alias "lcBlockAddBarcode" (ByVal hBlock As IntPtr, ByVal BarType As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal Width As Double, ByVal Height As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddHatch Lib "Litecad.dll" Alias "lcBlockAddHatch" (ByVal hBlock As IntPtr, ByVal szFileName As String, ByVal szPatName As String, ByVal Scal As Double, ByVal Angle As Double) As IntPtr

  Public Declare Function BlockAddViewport Lib "Litecad.dll" Alias "lcBlockAddViewport" (ByVal hBlock As IntPtr, ByVal Lef As Double, ByVal Bot As Double, ByVal Width As Double, ByVal Height As Double, ByVal DrwPntX As Double, ByVal DrwPntY As Double, ByVal DrwScale As Double, ByVal DrwAngle As Double) As IntPtr

  Public Declare Function BlockAddFace Lib "Litecad.dll" Alias "lcBlockAddFace" (ByVal hBlock As IntPtr, ByVal Flags As Integer, ByVal x0 As Double, ByVal y0 As Double, ByVal z0 As Double, ByVal x1 As Double, ByVal y1 As Double, ByVal z1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByVal z2 As Double) As IntPtr

  Public Declare Function BlockAddFace4 Lib "Litecad.dll" Alias "lcBlockAddFace4" (ByVal hBlock As IntPtr, ByVal Flags As Integer, ByVal x0 As Double, ByVal y0 As Double, ByVal z0 As Double, ByVal x1 As Double, ByVal y1 As Double, ByVal z1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByVal z2 As Double, ByVal x3 As Double, ByVal y3 As Double, ByVal z3 As Double) As IntPtr

  Public Declare Unicode Function BlockAddLeader Lib "Litecad.dll" Alias "lcBlockAddLeader" (ByVal hBlock As IntPtr, ByVal szText As String, ByVal Xt As Double, ByVal Yt As Double, ByVal LandDist As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal Attach As Integer, ByVal Align As Integer) As IntPtr

  Public Declare Unicode Function BlockAddDimLin Lib "Litecad.dll" Alias "lcBlockAddDimLin" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal Angle As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimHor Lib "Litecad.dll" Alias "lcBlockAddDimHor" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Yt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimVer Lib "Litecad.dll" Alias "lcBlockAddDimVer" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimAli Lib "Litecad.dll" Alias "lcBlockAddDimAli" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimAli2 Lib "Litecad.dll" Alias "lcBlockAddDimAli2" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Dt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimOrd Lib "Litecad.dll" Alias "lcBlockAddDimOrd" (ByVal hBlock As IntPtr, ByVal Xd As Double, ByVal Yd As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal bX As Integer, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimRad Lib "Litecad.dll" Alias "lcBlockAddDimRad" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Xr As Double, ByVal Yr As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimRad2 Lib "Litecad.dll" Alias "lcBlockAddDimRad2" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Angle As Double, ByVal TextOff As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimDia Lib "Litecad.dll" Alias "lcBlockAddDimDia" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Xr As Double, ByVal Yr As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimDia2 Lib "Litecad.dll" Alias "lcBlockAddDimDia2" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Angle As Double, ByVal TextOff As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimAng Lib "Litecad.dll" Alias "lcBlockAddDimAng" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal TextPos As Double, ByVal szText As String) As IntPtr

  Public Declare Unicode Function BlockAddDimAng2 Lib "Litecad.dll" Alias "lcBlockAddDimAng2" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double, ByVal X4 As Double, ByVal Y4 As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal TextPos As Double, ByVal szText As String) As IntPtr

  Public Declare Function BlockAddRPlan Lib "Litecad.dll" Alias "lcBlockAddRPlan" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockAddRPlan2 Lib "Litecad.dll" Alias "lcBlockAddRPlan2" (ByVal hBlock As IntPtr, ByVal hStartEnt As IntPtr) As IntPtr

  Public Declare Function BlockAddArrow Lib "Litecad.dll" Alias "lcBlockAddArrow" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As IntPtr

  Public Declare Function BlockAddSpiral Lib "Litecad.dll" Alias "lcBlockAddSpiral" (ByVal hBlock As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Turns As Double, ByVal bDirCW As Integer, ByVal bClosed As Integer) As IntPtr

  Public Declare Function BlockAddCamview Lib "Litecad.dll" Alias "lcBlockAddCamview" (ByVal hBlock As IntPtr, ByVal Lef As Double, ByVal Bot As Double, ByVal Width As Double, ByVal Height As Double) As IntPtr

  Public Declare Unicode Function BlockAddTIN Lib "Litecad.dll" Alias "lcBlockAddTIN" (ByVal hBlock As IntPtr, ByVal szFileName As String, ByVal FileType As Integer) As IntPtr

  Public Declare Function BlockAddClone Lib "Litecad.dll" Alias "lcBlockAddClone" (ByVal hBlock As IntPtr, ByVal hEnt As IntPtr) As IntPtr

  Public Declare Function BlockBeginShape Lib "Litecad.dll" Alias "lcBlockBeginShape" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function BlockAddShape Lib "Litecad.dll" Alias "lcBlockAddShape" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockAddShapeSel Lib "Litecad.dll" Alias "lcBlockAddShapeSel" (ByVal hBlock As IntPtr, ByVal bErase As Integer) As IntPtr

  Public Declare Function BlockRepEllipse Lib "Litecad.dll" Alias "lcBlockRepEllipse" (ByVal hBlock As IntPtr, ByVal hEll As IntPtr, ByRef pRetType As Integer) As IntPtr

  Public Declare Function BlockJoinAll Lib "Litecad.dll" Alias "lcBlockJoinAll" (ByVal hBlock As IntPtr, ByVal Delta As Double) As Integer

  Public Declare Function BlockCopyLayer Lib "Litecad.dll" Alias "lcBlockCopyLayer" (ByVal hBlock As IntPtr, ByVal hLayerSrc As IntPtr, ByVal hLayerDest As IntPtr) As Integer

  Public Declare Function BlockDeleteEnt Lib "Litecad.dll" Alias "lcBlockDeleteEnt" (ByVal hBlock As IntPtr, ByVal hEnt As IntPtr) As Integer

  Public Declare Function BlockGetFirstEnt Lib "Litecad.dll" Alias "lcBlockGetFirstEnt" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockGetNextEnt Lib "Litecad.dll" Alias "lcBlockGetNextEnt" (ByVal hBlock As IntPtr, ByVal hEnt As IntPtr) As IntPtr

  Public Declare Function BlockGetLastEnt Lib "Litecad.dll" Alias "lcBlockGetLastEnt" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockGetPrevEnt Lib "Litecad.dll" Alias "lcBlockGetPrevEnt" (ByVal hBlock As IntPtr, ByVal hEnt As IntPtr) As IntPtr

  Public Declare Function BlockGetEntByID Lib "Litecad.dll" Alias "lcBlockGetEntByID" (ByVal hBlock As IntPtr, ByVal Id As Integer) As IntPtr

  Public Declare Unicode Function BlockGetEntByIDH Lib "Litecad.dll" Alias "lcBlockGetEntByIDH" (ByVal hBlock As IntPtr, ByVal szId As String) As IntPtr

  Public Declare Function BlockGetEntByKey Lib "Litecad.dll" Alias "lcBlockGetEntByKey" (ByVal hBlock As IntPtr, ByVal Key As Integer) As IntPtr

  Public Declare Unicode Function BlockGetBlkRefByTag Lib "Litecad.dll" Alias "lcBlockGetBlkRefByTag" (ByVal hBlock As IntPtr, ByVal hBlockAtt As IntPtr, ByVal szTag As String, ByVal szValue As String, ByVal bSelect As Integer) As IntPtr

  Public Declare Unicode Function BlockGetTIN Lib "Litecad.dll" Alias "lcBlockGetTIN" (ByVal hBlock As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Function BlockUnselect Lib "Litecad.dll" Alias "lcBlockUnselect" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function BlockSelectEnt Lib "Litecad.dll" Alias "lcBlockSelectEnt" (ByVal hBlock As IntPtr, ByVal hEntity As IntPtr, ByVal bSelect As Integer) As Integer

  Public Declare Function BlockSelErase Lib "Litecad.dll" Alias "lcBlockSelErase" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function BlockSelMove Lib "Litecad.dll" Alias "lcBlockSelMove" (ByVal hBlock As IntPtr, ByVal dX As Double, ByVal dY As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelScale Lib "Litecad.dll" Alias "lcBlockSelScale" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal Scal As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelRotate Lib "Litecad.dll" Alias "lcBlockSelRotate" (ByVal hBlock As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal Angle As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelMirror Lib "Litecad.dll" Alias "lcBlockSelMirror" (ByVal hBlock As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelExplode Lib "Litecad.dll" Alias "lcBlockSelExplode" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function BlockSelSplit Lib "Litecad.dll" Alias "lcBlockSelSplit" (ByVal hBlock As IntPtr, ByVal nParts As Integer) As Integer

  Public Declare Function BlockSelJoin Lib "Litecad.dll" Alias "lcBlockSelJoin" (ByVal hBlock As IntPtr, ByVal Delta As Double) As IntPtr

  Public Declare Function BlockSelAlign Lib "Litecad.dll" Alias "lcBlockSelAlign" (ByVal hBlock As IntPtr, ByVal Mode As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Unicode Function BlockSelBlock Lib "Litecad.dll" Alias "lcBlockSelBlock" (ByVal hBlock As IntPtr, ByVal szName As String, ByVal X As Double, ByVal Y As Double, ByVal Mode As Integer, ByVal bOverwrite As Integer) As IntPtr

  Public Declare Function BlockGetFirstSel Lib "Litecad.dll" Alias "lcBlockGetFirstSel" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockGetNextSel Lib "Litecad.dll" Alias "lcBlockGetNextSel" (ByVal hBlock As IntPtr) As IntPtr

  Public Declare Function BlockOrderByLayers Lib "Litecad.dll" Alias "lcBlockOrderByLayers" (ByVal hBlock As IntPtr, ByVal hWnd As IntPtr) As Integer

  Public Declare Function BlockSortTSP Lib "Litecad.dll" Alias "lcBlockSortTSP" (ByVal hBlock As IntPtr, ByVal hLayer As IntPtr, ByVal hWnd As IntPtr) As Integer

  Public Declare Function BlockGetJumpsLen Lib "Litecad.dll" Alias "lcBlockGetJumpsLen" (ByVal hBlock As IntPtr, ByVal hLayer As IntPtr, ByVal hWnd As IntPtr) As Double

  Public Declare Function LayerClear Lib "Litecad.dll" Alias "lcLayerClear" (ByVal hLayer As IntPtr, ByVal hBlock As IntPtr) As Integer

  Public Declare Function LayerCopyProps Lib "Litecad.dll" Alias "lcLayerCopyProps" (ByVal hLayer As IntPtr, ByVal hFromLayer As IntPtr) As Integer

  Public Declare Function FillSetLine Lib "Litecad.dll" Alias "lcFillSetLine" (ByVal hFill As IntPtr, ByVal iLine As Integer, ByVal Dist As Double, ByVal Angle As Double, ByVal W As Double) As Integer

  Public Declare Unicode Function MLStyleAddLine Lib "Litecad.dll" Alias "lcMLStyleAddLine" (ByVal hStyle As IntPtr, ByVal Offset As Double, ByVal szColor As String, ByVal hLtype As IntPtr) As Integer

  Public Declare Function MLStyleDelLine Lib "Litecad.dll" Alias "lcMLStyleDelLine" (ByVal hStyle As IntPtr, ByVal iLine As Integer) As Integer

  Public Declare Function MLStyleSortLines Lib "Litecad.dll" Alias "lcMLStyleSortLines" (ByVal hStyle As IntPtr) As Integer

  Public Declare Function EntType Lib "Litecad.dll" Alias "lcEntType" (ByVal hEnt As IntPtr, ByVal Typ As Integer) As Integer

  Public Declare Function EntErase Lib "Litecad.dll" Alias "lcEntErase" (ByVal hEnt As IntPtr, ByVal bErase As Integer) As Integer

  Public Declare Function EntMove Lib "Litecad.dll" Alias "lcEntMove" (ByVal hEnt As IntPtr, ByVal dX As Double, ByVal dY As Double) As Integer

  Public Declare Function EntAlign Lib "Litecad.dll" Alias "lcEntAlign" (ByVal hEnt As IntPtr, ByVal Alignment As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function EntScale Lib "Litecad.dll" Alias "lcEntScale" (ByVal hEnt As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal Scal As Double) As Integer

  Public Declare Function EntRotate Lib "Litecad.dll" Alias "lcEntRotate" (ByVal hEnt As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal Angle As Double) As Integer

  Public Declare Function EntMirror Lib "Litecad.dll" Alias "lcEntMirror" (ByVal hEnt As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function EntExplode Lib "Litecad.dll" Alias "lcEntExplode" (ByVal hEnt As IntPtr, ByVal bSelect As Integer, ByVal bErase As Integer) As Integer

  Public Declare Function EntSplit Lib "Litecad.dll" Alias "lcEntSplit" (ByVal hEnt As IntPtr, ByVal nParts As Integer, ByVal bSelectNew As Integer, ByVal bDeleteEnt As Integer) As IntPtr

  Public Declare Function EntBreak Lib "Litecad.dll" Alias "lcEntBreak" (ByVal hEnt As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double, ByVal bSelectNew As Integer, ByVal bDeleteEnt As Integer) As IntPtr

  Public Declare Function EntBreak2 Lib "Litecad.dll" Alias "lcEntBreak2" (ByVal hEnt As IntPtr, ByVal hPtbuf As IntPtr, ByVal Delta As Double, ByVal bSelectNew As Integer, ByVal bDeleteEnt As Integer) As IntPtr

  Public Declare Function EntOffset Lib "Litecad.dll" Alias "lcEntOffset" (ByVal hEnt As IntPtr, ByVal Dist As Double) As Integer

  Public Declare Function EntExtend Lib "Litecad.dll" Alias "lcEntExtend" (ByVal hEnt As IntPtr, ByVal hEntEdge As IntPtr, ByVal bApparent As Integer) As Integer

  Public Declare Function EntToTop Lib "Litecad.dll" Alias "lcEntToTop" (ByVal hEnt As IntPtr) As Integer

  Public Declare Function EntToBottom Lib "Litecad.dll" Alias "lcEntToBottom" (ByVal hEnt As IntPtr) As Integer

  Public Declare Function EntToAbove Lib "Litecad.dll" Alias "lcEntToAbove" (ByVal hEnt As IntPtr, ByVal hEnt2 As IntPtr) As Integer

  Public Declare Function EntToUnder Lib "Litecad.dll" Alias "lcEntToUnder" (ByVal hEnt As IntPtr, ByVal hEnt2 As IntPtr) As Integer

  Public Declare Function EntGetGrip Lib "Litecad.dll" Alias "lcEntGetGrip" (ByVal hEnt As IntPtr, ByVal iGrip As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function EntPutGrip Lib "Litecad.dll" Alias "lcEntPutGrip" (ByVal hEnt As IntPtr, ByVal iGrip As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function EntUpdate Lib "Litecad.dll" Alias "lcEntUpdate" (ByVal hEnt As IntPtr) As Integer

  Public Declare Function EntCopyBase Lib "Litecad.dll" Alias "lcEntCopyBase" (ByVal hEnt As IntPtr, ByVal hEntFrom As IntPtr) As Integer

  Public Declare Function EntXData Lib "Litecad.dll" Alias "lcEntXData" (ByVal hEnt As IntPtr, ByVal Id As Integer, ByVal Flags As Integer, ByVal nBytes As Integer) As Integer

  Public Declare Function EntContainEnt Lib "Litecad.dll" Alias "lcEntContainEnt" (ByVal hEnt As IntPtr, ByVal hEnt2 As IntPtr) As Integer

  Public Declare Function EntCrossEnt Lib "Litecad.dll" Alias "lcEntCrossEnt" (ByVal hEnt As IntPtr, ByVal hEnt2 As IntPtr) As Integer

  Public Declare Function EntReverse Lib "Litecad.dll" Alias "lcEntReverse" (ByVal hEnt As IntPtr) As Integer

  Public Declare Function EntGetPoint Lib "Litecad.dll" Alias "lcEntGetPoint" (ByVal hEnt As IntPtr, ByVal Dist As Double, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double) As Integer

  Public Declare Function EntGetDist Lib "Litecad.dll" Alias "lcEntGetDist" (ByVal hEnt As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pX2 As Double, ByRef pY2 As Double, ByRef pDist As Double) As Double

  Public Declare Function EntTransform Lib "Litecad.dll" Alias "lcEntTransform" (ByVal hEnt As IntPtr, ByVal hTransform As IntPtr) As Integer

  Public Declare Function Intersection Lib "Litecad.dll" Alias "lcIntersection" (ByVal hEnt As IntPtr, ByVal hEnt2 As IntPtr, ByVal Apparent As Integer) As Integer

  Public Declare Function InterGetPoint Lib "Litecad.dll" Alias "lcInterGetPoint" (ByVal iPoint As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function LineGetPoint Lib "Litecad.dll" Alias "lcLineGetPoint" (ByVal hLine As IntPtr, ByVal Mode As Integer, ByVal Dist As Double, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function PlineAddVer Lib "Litecad.dll" Alias "lcPlineAddVer" (ByVal hPline As IntPtr, ByVal hVer As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function PlineAddVer2 Lib "Litecad.dll" Alias "lcPlineAddVer2" (ByVal hPline As IntPtr, ByVal hVer As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Param As Double, ByVal W0 As Double, ByVal W1 As Double) As IntPtr

  Public Declare Function PlineAddVerDir Lib "Litecad.dll" Alias "lcPlineAddVerDir" (ByVal hPline As IntPtr, ByVal hVer As IntPtr, ByVal Ang As Double, ByVal Length As Double) As IntPtr

  Public Declare Function PlineEnd Lib "Litecad.dll" Alias "lcPlineEnd" (ByVal hPline As IntPtr) As Integer

  Public Declare Function PlineFromPtbuf Lib "Litecad.dll" Alias "lcPlineFromPtbuf" (ByVal hPline As IntPtr, ByVal hPtbuf As IntPtr) As Integer

  Public Declare Function PlineFromMpgon Lib "Litecad.dll" Alias "lcPlineFromMpgon" (ByVal hPline As IntPtr, ByVal hMpgon As IntPtr) As Integer

  Public Declare Unicode Function PlineFromFile Lib "Litecad.dll" Alias "lcPlineFromFile" (ByVal hPline As IntPtr, ByVal szFileName As String) As Integer

  Public Declare Function PlineDeleteVer Lib "Litecad.dll" Alias "lcPlineDeleteVer" (ByVal hPline As IntPtr, ByVal hVer As IntPtr) As Integer

  Public Declare Function PlineDelExVers Lib "Litecad.dll" Alias "lcPlineDelExVers" (ByVal hPline As IntPtr, ByVal Delta As Double) As Integer

  Public Declare Function PlineGetFirstVer Lib "Litecad.dll" Alias "lcPlineGetFirstVer" (ByVal hPline As IntPtr) As IntPtr

  Public Declare Function PlineGetNextVer Lib "Litecad.dll" Alias "lcPlineGetNextVer" (ByVal hPline As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function PlineGetLastVer Lib "Litecad.dll" Alias "lcPlineGetLastVer" (ByVal hPline As IntPtr) As IntPtr

  Public Declare Function PlineGetPrevVer Lib "Litecad.dll" Alias "lcPlineGetPrevVer" (ByVal hPline As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function PlineGetVer Lib "Litecad.dll" Alias "lcPlineGetVer" (ByVal hPline As IntPtr, ByVal Index As Integer) As IntPtr

  Public Declare Function PlineGetVerPt Lib "Litecad.dll" Alias "lcPlineGetVerPt" (ByVal hPline As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As IntPtr

  Public Declare Function PlineGetSeg Lib "Litecad.dll" Alias "lcPlineGetSeg" (ByVal hPline As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As IntPtr

  Public Declare Function PlineReverse Lib "Litecad.dll" Alias "lcPlineReverse" (ByVal hPline As IntPtr) As Integer

  Public Declare Function PlineSetStartVer Lib "Litecad.dll" Alias "lcPlineSetStartVer" (ByVal hPline As IntPtr, ByVal hVer As IntPtr) As Integer

  Public Declare Function PlineContainPoint Lib "Litecad.dll" Alias "lcPlineContainPoint" (ByVal hPline As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function PlineGetRoundPrm Lib "Litecad.dll" Alias "lcPlineGetRoundPrm" (ByVal hPline As IntPtr, ByVal hVer As IntPtr, ByRef pX0 As Double, ByRef pY0 As Double, ByRef pBulge As Double, ByRef pX1 As Double, ByRef pY1 As Double) As Integer

  Public Declare Function PlineGetPoint Lib "Litecad.dll" Alias "lcPlineGetPoint" (ByVal hPline As IntPtr, ByVal Dist As Double, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double) As Integer

  Public Declare Function PlineGetPointOpp Lib "Litecad.dll" Alias "lcPlineGetPointOpp" (ByVal hPline As IntPtr, ByVal Dist As Double, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double, ByRef pX2 As Double, ByRef pY2 As Double) As Integer

  Public Declare Function PlineGetDist Lib "Litecad.dll" Alias "lcPlineGetDist" (ByVal hPline As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pX2 As Double, ByRef pY2 As Double, ByRef pDist As Double) As Double

  Public Declare Function PlineDivide Lib "Litecad.dll" Alias "lcPlineDivide" (ByVal hPline As IntPtr, ByVal nPoints As Integer, ByVal bAngle As Integer) As Integer

  Public Declare Function PlineDivide2 Lib "Litecad.dll" Alias "lcPlineDivide2" (ByVal hPline As IntPtr, ByVal Delta As Double, ByVal bAngle As Integer) As Integer

  Public Declare Function GetDivPt Lib "Litecad.dll" Alias "lcGetDivPt" (ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double) As Integer

  Public Declare Function PlineMakeArrow Lib "Litecad.dll" Alias "lcPlineMakeArrow" (ByVal hPline As IntPtr, ByVal Hline As Double, ByVal Harr As Double) As Integer

  Public Declare Function PlineSplitBySI Lib "Litecad.dll" Alias "lcPlineSplitBySI" (ByVal hPline As IntPtr, ByVal bSelect As Integer, ByVal bErase As Integer) As IntPtr

  Public Declare Function BezierAddVer Lib "Litecad.dll" Alias "lcBezierAddVer" (ByVal hBez As IntPtr, ByVal hVer As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function BezierEnd Lib "Litecad.dll" Alias "lcBezierEnd" (ByVal hBez As IntPtr) As Integer

  Public Declare Function BezierSetVerPrm Lib "Litecad.dll" Alias "lcBezierSetVerPrm" (ByVal hBez As IntPtr, ByVal hVer As IntPtr, ByVal Side As Integer, ByVal Leng As Double, ByVal Ang As Double) As Integer

  Public Declare Function MlineAddVer Lib "Litecad.dll" Alias "lcMlineAddVer" (ByVal hMline As IntPtr, ByVal hVer As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function MlineAddVerDir Lib "Litecad.dll" Alias "lcMlineAddVerDir" (ByVal hMline As IntPtr, ByVal hVer As IntPtr, ByVal Ang As Double, ByVal Length As Double) As IntPtr

  Public Declare Function MlineDeleteVer Lib "Litecad.dll" Alias "lcMlineDeleteVer" (ByVal hMline As IntPtr, ByVal hVer As IntPtr) As Integer

  Public Declare Function MlineGetFirstVer Lib "Litecad.dll" Alias "lcMlineGetFirstVer" (ByVal hMline As IntPtr) As IntPtr

  Public Declare Function MlineGetNextVer Lib "Litecad.dll" Alias "lcMlineGetNextVer" (ByVal hMline As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function MlineGetLastVer Lib "Litecad.dll" Alias "lcMlineGetLastVer" (ByVal hMline As IntPtr) As IntPtr

  Public Declare Function MlineGetPrevVer Lib "Litecad.dll" Alias "lcMlineGetPrevVer" (ByVal hMline As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function MlineGetVer Lib "Litecad.dll" Alias "lcMlineGetVer" (ByVal hMline As IntPtr, ByVal Index As Integer) As IntPtr

  Public Declare Function MlineGetVerPt Lib "Litecad.dll" Alias "lcMlineGetVerPt" (ByVal hMline As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As IntPtr

  Public Declare Function MlineGetSeg Lib "Litecad.dll" Alias "lcMlineGetSeg" (ByVal hMline As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As IntPtr

  Public Declare Function MlineReverse Lib "Litecad.dll" Alias "lcMlineReverse" (ByVal hMline As IntPtr) As Integer

  Public Declare Function RPlanAddVer Lib "Litecad.dll" Alias "lcRPlanAddVer" (ByVal hRPlan As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function RPlanSetCurve Lib "Litecad.dll" Alias "lcRPlanSetCurve" (ByVal hVer As IntPtr, ByVal Radius As Double, ByVal LenClot1 As Double, ByVal LenClot2 As Double) As Integer

  Public Declare Function RPlanSetPos Lib "Litecad.dll" Alias "lcRPlanSetPos" (ByVal hVer As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function RPlanDeleteVer Lib "Litecad.dll" Alias "lcRPlanDeleteVer" (ByVal hRPlan As IntPtr, ByVal hVer As IntPtr) As Integer

  Public Declare Function RPlanGetFirstVer Lib "Litecad.dll" Alias "lcRPlanGetFirstVer" (ByVal hRPlan As IntPtr) As IntPtr

  Public Declare Function RPlanGetNextVer Lib "Litecad.dll" Alias "lcRPlanGetNextVer" (ByVal hRPlan As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function RPlanGetLastVer Lib "Litecad.dll" Alias "lcRPlanGetLastVer" (ByVal hRPlan As IntPtr) As IntPtr

  Public Declare Function RPlanGetPrevVer Lib "Litecad.dll" Alias "lcRPlanGetPrevVer" (ByVal hRPlan As IntPtr, ByVal hVer As IntPtr) As IntPtr

  Public Declare Function RPlanGetVer Lib "Litecad.dll" Alias "lcRPlanGetVer" (ByVal hRPlan As IntPtr, ByVal Index As Integer) As IntPtr

  Public Declare Function RPlanGetPoint Lib "Litecad.dll" Alias "lcRPlanGetPoint" (ByVal hRPlan As IntPtr, ByVal Dist As Double, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double, ByRef pSide As Integer) As Integer

  Public Declare Function RPlanGetDist Lib "Litecad.dll" Alias "lcRPlanGetDist" (ByVal hRPlan As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pX2 As Double, ByRef pY2 As Double, ByRef pDist As Double, ByRef pOffset As Double) As Integer

  Public Declare Unicode Function RPlanWriteCSV Lib "Litecad.dll" Alias "lcRPlanWriteCSV" (ByVal hRPlan As IntPtr, ByVal szFileName As String) As Integer

  Public Declare Function XlinePutDir Lib "Litecad.dll" Alias "lcXlinePutDir" (ByVal hXline As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function RectGetPolyline Lib "Litecad.dll" Alias "lcRectGetPolyline" (ByVal hRect As IntPtr, ByRef pX As Double, ByRef pY As Double, ByRef pBulge As Double) As Integer

  Public Declare Function ImgRefGetPixel Lib "Litecad.dll" Alias "lcImgRefGetPixel" (ByVal hImgRef As IntPtr, ByVal iX As Integer, ByVal iY As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pColor As Integer) As Integer

  Public Declare Function ImgRefResize Lib "Litecad.dll" Alias "lcImgRefResize" (ByVal hImgRef As IntPtr, ByVal NewWidth As Integer, ByVal NewHeight As Integer, ByVal Method As Integer) As Integer

  Public Declare Unicode Function HatchSetPattern Lib "Litecad.dll" Alias "lcHatchSetPattern" (ByVal hHatch As IntPtr, ByVal szFileName As String, ByVal szPatName As String, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Function HatchBoundStart Lib "Litecad.dll" Alias "lcHatchBoundStart" (ByVal hHatch As IntPtr) As Integer

  Public Declare Function HatchBoundPoint Lib "Litecad.dll" Alias "lcHatchBoundPoint" (ByVal hHatch As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function HatchBoundEntity Lib "Litecad.dll" Alias "lcHatchBoundEntity" (ByVal hHatch As IntPtr, ByVal hEnt As IntPtr) As Integer

  Public Declare Function HatchBoundEndLoop Lib "Litecad.dll" Alias "lcHatchBoundEndLoop" (ByVal hHatch As IntPtr) As Integer

  Public Declare Function HatchBoundEnd Lib "Litecad.dll" Alias "lcHatchBoundEnd" (ByVal hHatch As IntPtr) As Integer

  Public Declare Function HatchPatStart Lib "Litecad.dll" Alias "lcHatchPatStart" (ByVal hHatch As IntPtr) As Integer

  Public Declare Function HatchPatLine Lib "Litecad.dll" Alias "lcHatchPatLine" (ByVal hHatch As IntPtr, ByVal Angle As Double, ByVal x0 As Double, ByVal y0 As Double, ByVal dx As Double, ByVal dy As Double, ByVal nDash As Integer, ByVal L0 As Double, ByVal L1 As Double, ByVal L2 As Double, ByVal L3 As Double, ByVal L4 As Double, ByVal L5 As Double, ByVal L6 As Double, ByVal L7 As Double) As Integer

  Public Declare Function HatchPatEnd Lib "Litecad.dll" Alias "lcHatchPatEnd" (ByVal hHatch As IntPtr) As Integer

  Public Declare Function HatchGetLoopSize Lib "Litecad.dll" Alias "lcHatchGetLoopSize" (ByVal hHatch As IntPtr, ByVal iLoop As Integer) As Integer

  Public Declare Function HatchGetPoint Lib "Litecad.dll" Alias "lcHatchGetPoint" (ByVal hHatch As IntPtr, ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function HatchGetEnt Lib "Litecad.dll" Alias "lcHatchGetEnt" (ByVal hHatch As IntPtr, ByVal Mode As Integer) As IntPtr

  Public Declare Function VportSetView Lib "Litecad.dll" Alias "lcVportSetView" (ByVal hVport As IntPtr, ByVal Xcen As Double, ByVal Ycen As Double, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Function VportLayerDlg Lib "Litecad.dll" Alias "lcVportLayerDlg" (ByVal hVport As IntPtr, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function VportLayerCmd Lib "Litecad.dll" Alias "lcVportLayerCmd" (ByVal hVport As IntPtr, ByVal Cmd As Integer, ByVal hLayer As IntPtr) As Integer

  Public Declare Unicode Function BlkRefAddAtt Lib "Litecad.dll" Alias "lcBlkRefAddAtt" (ByVal hBlockRef As IntPtr, ByVal szTag As String, ByVal szValue As String) As IntPtr

  Public Declare Function BlkRefGetFirstAtt Lib "Litecad.dll" Alias "lcBlkRefGetFirstAtt" (ByVal hBlockRef As IntPtr) As IntPtr

  Public Declare Function BlkRefGetNextAtt Lib "Litecad.dll" Alias "lcBlkRefGetNextAtt" (ByVal hBlockRef As IntPtr, ByVal hAttrib As IntPtr) As IntPtr

  Public Declare Unicode Function BlkRefGetAtt Lib "Litecad.dll" Alias "lcBlkRefGetAtt" (ByVal hBlockRef As IntPtr, ByVal szTag As String) As IntPtr

  Public Declare Unicode Function BlkRefGetAttVal Lib "Litecad.dll" Alias "lcBlkRefGetAttVal" (ByVal hBlockRef As IntPtr, ByVal szTag As String) As Char

  Public Declare Unicode Function BlkRefPutAttVal Lib "Litecad.dll" Alias "lcBlkRefPutAttVal" (ByVal hBlockRef As IntPtr, ByVal szTag As String, ByVal szValue As String) As Integer

  Public Declare Function ShapeAddEnt Lib "Litecad.dll" Alias "lcShapeAddEnt" (ByVal hShape As IntPtr, ByVal hEnt As IntPtr, ByVal bErase As Integer) As Integer

  Public Declare Function ShapeEnd Lib "Litecad.dll" Alias "lcShapeEnd" (ByVal hShape As IntPtr) As Integer

  Public Declare Function ShapeGetFirstEnt Lib "Litecad.dll" Alias "lcShapeGetFirstEnt" (ByVal hShape As IntPtr) As IntPtr

  Public Declare Function ShapeGetNextEnt Lib "Litecad.dll" Alias "lcShapeGetNextEnt" (ByVal hShape As IntPtr, ByVal hEnt As IntPtr) As IntPtr

  Public Declare Function ShapeGetLastEnt Lib "Litecad.dll" Alias "lcShapeGetLastEnt" (ByVal hShape As IntPtr) As IntPtr

  Public Declare Function ShapeGetPrevEnt Lib "Litecad.dll" Alias "lcShapeGetPrevEnt" (ByVal hShape As IntPtr, ByVal hEnt As IntPtr) As IntPtr

  Public Declare Unicode Function TIN_AddPoint Lib "Litecad.dll" Alias "lcTIN_AddPoint" (ByVal hTIN As IntPtr, ByVal szNamePtype As String, ByVal X As Double, ByVal Y As Double, ByVal Z As Double) As IntPtr

  Public Declare Unicode Function TIN_PtypeGetByName Lib "Litecad.dll" Alias "lcTIN_PtypeGetByName" (ByVal hTIN As IntPtr, ByVal szName As String) As IntPtr

  Public Declare Function TIN_PtypeGetFirst Lib "Litecad.dll" Alias "lcTIN_PtypeGetFirst" (ByVal hTIN As IntPtr) As IntPtr

  Public Declare Function TIN_PtypeGetNext Lib "Litecad.dll" Alias "lcTIN_PtypeGetNext" (ByVal hTIN As IntPtr, ByVal hPtype As IntPtr) As IntPtr

  Public Declare Function TIN_PntGetFirst Lib "Litecad.dll" Alias "lcTIN_PntGetFirst" (ByVal hTIN As IntPtr) As IntPtr

  Public Declare Function TIN_PntGetNext Lib "Litecad.dll" Alias "lcTIN_PntGetNext" (ByVal hTIN As IntPtr, ByVal hPnt As IntPtr) As IntPtr

  Public Declare Function TIN_PntGetNear Lib "Litecad.dll" Alias "lcTIN_PntGetNear" (ByVal hTIN As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function TIN_PntDelDup Lib "Litecad.dll" Alias "lcTIN_PntDelDup" (ByVal hTIN As IntPtr, ByVal Delta As Double, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function TIN_TriGetFirst Lib "Litecad.dll" Alias "lcTIN_TriGetFirst" (ByVal hTIN As IntPtr) As IntPtr

  Public Declare Function TIN_TriGetNext Lib "Litecad.dll" Alias "lcTIN_TriGetNext" (ByVal hTIN As IntPtr, ByVal hTrian As IntPtr) As IntPtr

  Public Declare Function TIN_TriGetByPos Lib "Litecad.dll" Alias "lcTIN_TriGetByPos" (ByVal hTIN As IntPtr, ByVal X As Double, ByVal Y As Double) As IntPtr

  Public Declare Function TIN_TriGetEdge Lib "Litecad.dll" Alias "lcTIN_TriGetEdge" (ByVal hTIN As IntPtr, ByVal hTrian As IntPtr, ByVal iEdge As Integer) As Integer

  Public Declare Function TIN_TriUpdate Lib "Litecad.dll" Alias "lcTIN_TriUpdate" (ByVal hTIN As IntPtr, ByVal hPnt As IntPtr) As Integer

  Public Declare Function TIN_Bnd Lib "Litecad.dll" Alias "lcTIN_Bnd" (ByVal hTIN As IntPtr, ByVal MaxDist As Double, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function TIN_BndGetPoint Lib "Litecad.dll" Alias "lcTIN_BndGetPoint" (ByVal hTIN As IntPtr, ByVal iPnt As Integer) As IntPtr

  Public Declare Function TIN_Triangulate Lib "Litecad.dll" Alias "lcTIN_Triangulate" (ByVal hTIN As IntPtr, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function TIN_Isolines Lib "Litecad.dll" Alias "lcTIN_Isolines" (ByVal hTIN As IntPtr, ByVal Zstep As Double, ByVal BoldStep As Integer, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function TIN_IsoGetFirst Lib "Litecad.dll" Alias "lcTIN_IsoGetFirst" (ByVal hTIN As IntPtr) As IntPtr

  Public Declare Function TIN_IsoGetNext Lib "Litecad.dll" Alias "lcTIN_IsoGetNext" (ByVal hTIN As IntPtr, ByVal hIso As IntPtr) As IntPtr

  Public Declare Function TIN_IsoMakeLabels Lib "Litecad.dll" Alias "lcTIN_IsoMakeLabels" (ByVal hIso As IntPtr) As Integer

  Public Declare Function TIN_GetIsoLabel Lib "Litecad.dll" Alias "lcTIN_GetIsoLabel" (ByVal iLabel As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double, ByRef pAlign As Integer) As Integer

  Public Declare Function TIN_GetZ Lib "Litecad.dll" Alias "lcTIN_GetZ" (ByVal hTIN As IntPtr, ByVal X As Double, ByVal Y As Double, ByRef pZ As Double) As Integer

  Public Declare Function TIN_ColorFill Lib "Litecad.dll" Alias "lcTIN_ColorFill" (ByVal hTIN As IntPtr, ByVal Zstep As Double, ByVal PixelSize As Double, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function TIN_Save Lib "Litecad.dll" Alias "lcTIN_Save" (ByVal hTIN As IntPtr, ByVal szFileName As String, ByVal Mode As Integer, ByVal bByBndr As Integer, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function TIN_InterLine Lib "Litecad.dll" Alias "lcTIN_InterLine" (ByVal hTIN As IntPtr, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double) As Integer

  Public Declare Function TIN_InterGetPoint Lib "Litecad.dll" Alias "lcTIN_InterGetPoint" (ByVal hTIN As IntPtr, ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pZ As Double) As Integer

  Public Declare Function TIN_Clear Lib "Litecad.dll" Alias "lcTIN_Clear" (ByVal hTIN As IntPtr) As Integer

  Public Declare Function TIN_AddTrian Lib "Litecad.dll" Alias "lcTIN_AddTrian" (ByVal hTIN As IntPtr, ByVal iPnt0 As Integer, ByVal iPnt1 As Integer, ByVal iPnt2 As Integer) As IntPtr

  Public Declare Function TIN_BndAddPnt Lib "Litecad.dll" Alias "lcTIN_BndAddPnt" (ByVal hTIN As IntPtr, ByVal iPnt As Integer) As Integer

  Public Declare Unicode Function TIN_Merge Lib "Litecad.dll" Alias "lcTIN_Merge" (ByVal hTIN As IntPtr, ByVal szFileName As String, ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function ColorRGB Lib "Litecad.dll" Alias "lcColorRGB" (ByVal Red As Integer, ByVal Green As Integer, ByVal Blue As Integer) As Integer

  Public Declare Unicode Function ColorIsRGB Lib "Litecad.dll" Alias "lcColorIsRGB" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetRed Lib "Litecad.dll" Alias "lcColorGetRed" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetGreen Lib "Litecad.dll" Alias "lcColorGetGreen" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetBlue Lib "Litecad.dll" Alias "lcColorGetBlue" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetIndex Lib "Litecad.dll" Alias "lcColorGetIndex" (ByVal szColor As String, ByVal bLogicalEnabled As Integer) As Integer

  Public Declare Unicode Function ColorToVal Lib "Litecad.dll" Alias "lcColorToVal" (ByVal szColor As String, ByRef pbRGB As Integer, ByRef pIndex As Integer, ByRef pR As Integer, ByRef pG As Integer, ByRef pB As Integer) As Integer

  Public Declare Function ColorSetPalette Lib "Litecad.dll" Alias "lcColorSetPalette" (ByVal Index As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Integer

  Public Declare Function ColorGetPalette Lib "Litecad.dll" Alias "lcColorGetPalette" (ByVal Index As Integer, ByRef pR As Integer, ByRef pG As Integer, ByRef pB As Integer) As Integer

  Public Declare Unicode Function ColorSavePalette Lib "Litecad.dll" Alias "lcColorSavePalette" (ByVal szFileName As String, ByVal hWnd As IntPtr) As Integer

  Public Declare Unicode Function ColorLoadPalette Lib "Litecad.dll" Alias "lcColorLoadPalette" (ByVal szFileName As String, ByVal hWnd As IntPtr) As Integer

  Public Declare Function ImageSetPixelRGB Lib "Litecad.dll" Alias "lcImageSetPixelRGB" (ByVal hImage As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal Red As Integer, ByVal Green As Integer, ByVal Blue As Integer) As Integer

  Public Declare Function ImageSetPixelI Lib "Litecad.dll" Alias "lcImageSetPixelI" (ByVal hImage As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal iColor As Integer) As Integer

  Public Declare Function ImageGetPixelRGB Lib "Litecad.dll" Alias "lcImageGetPixelRGB" (ByVal hImage As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByRef pRed As Integer, ByRef pGreen As Integer, ByRef pBlue As Integer) As Integer

  Public Declare Function ImageGetPixelI Lib "Litecad.dll" Alias "lcImageGetPixelI" (ByVal hImage As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByRef piColor As Integer) As Integer

  Public Declare Function ImageSetPalColor Lib "Litecad.dll" Alias "lcImageSetPalColor" (ByVal hImage As IntPtr, ByVal iColor As Integer, ByVal Red As Integer, ByVal Green As Integer, ByVal Blue As Integer) As Integer

  Public Declare Function ImageGetPalColor Lib "Litecad.dll" Alias "lcImageGetPalColor" (ByVal hImage As IntPtr, ByVal iColor As Integer, ByRef pRed As Integer, ByRef pGreen As Integer, ByRef pBlue As Integer) As Integer

  Public Declare Unicode Function ImageLoad Lib "Litecad.dll" Alias "lcImageLoad" (ByVal hImage As IntPtr, ByVal szFilename As String, ByVal hWnd As IntPtr) As Integer

  Public Declare Function ImageLoadDIB Lib "Litecad.dll" Alias "lcImageLoadDIB" (ByVal hImage As IntPtr, ByVal hDib2 As IntPtr) As Integer

  Public Declare Function ImageLoadCamera Lib "Litecad.dll" Alias "lcImageLoadCamera" (ByVal hImage As IntPtr) As Integer

  Public Declare Function ImageCopyQuad Lib "Litecad.dll" Alias "lcImageCopyQuad" (ByVal hImage As IntPtr, ByVal hImageSrc As IntPtr, ByVal W As Integer, ByVal H As Integer, ByVal x0 As Double, ByVal y0 As Double, ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByVal x3 As Double, ByVal y3 As Double) As Integer

  Public Declare Function ImageProc Lib "Litecad.dll" Alias "lcImageProc" (ByVal hImage As IntPtr, ByVal Mode As Integer) As Integer

  Public Declare Function ExpEntity Lib "Litecad.dll" Alias "lcExpEntity" (ByVal hEnt As IntPtr, ByVal iChar As Integer, ByVal Flags As Integer, ByVal bUnrotate As Integer) As Integer

  Public Declare Function ExpGetPline Lib "Litecad.dll" Alias "lcExpGetPline" (ByVal Delta As Double) As Integer

  Public Declare Function ExpGetVertex Lib "Litecad.dll" Alias "lcExpGetVertex" (ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function ExpBlock Lib "Litecad.dll" Alias "lcExpBlock" (ByVal hBlock As IntPtr, pFunc As F_LCEVENT, ByVal Prm1 As Integer, ByVal Prm2 As IntPtr) As Integer

  Public Declare Unicode Function GbrLoad Lib "Litecad.dll" Alias "lcGbrLoad" (ByVal hLcWnd As IntPtr, ByVal szFileName0 As String) As Integer

  Public Declare Function GbrClose Lib "Litecad.dll" Alias "lcGbrClose" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function PlugGetOption Lib "Litecad.dll" Alias "lcPlugGetOption" (ByVal szFileName As String, ByVal szKey As String) As Char

  Public Declare Unicode Function PlugGetOption2 Lib "Litecad.dll" Alias "lcPlugGetOption2" (ByVal szFileName As String, ByVal szKey As String) As Integer

  Public Declare Unicode Function PlugSetOption Lib "Litecad.dll" Alias "lcPlugSetOption" (ByVal szFileName As String, ByVal szKey As String, ByVal szValue As String, ByVal bSave As Integer) As Integer

  Public Declare Function PrintSetup Lib "Litecad.dll" Alias "lcPrintSetup" (ByVal hWnd As IntPtr) As Integer

  Public Declare Function PrintLayout Lib "Litecad.dll" Alias "lcPrintLayout" (ByVal hBlock As IntPtr) As Integer

  Public Declare Function PrintBlock Lib "Litecad.dll" Alias "lcPrintBlock" (ByVal hBlock As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal W As Double, ByVal H As Double, ByVal Scal As Double, ByVal PapLef As Double, ByVal PapTop As Double, ByVal Options As Integer) As Integer

  Public Declare Function XDataBegin Lib "Litecad.dll" Alias "lcXDataBegin" () As IntPtr

  Public Declare Function XDataEnd Lib "Litecad.dll" Alias "lcXDataEnd" (ByVal hData As IntPtr) As Integer

  Public Declare Function XDataClear Lib "Litecad.dll" Alias "lcXDataClear" (ByVal hData As IntPtr) As Integer

  Public Declare Function XDataSet Lib "Litecad.dll" Alias "lcXDataSet" (ByVal hData As IntPtr) As Integer

  Public Declare Function WndTabClear Lib "Litecad.dll" Alias "lcWndTabClear" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Unicode Function WndTabAdd Lib "Litecad.dll" Alias "lcWndTabAdd" (ByVal hLcWnd As IntPtr, ByVal TabID As Integer, ByVal szLabel As String, ByVal szTipText As String, ByVal hObject As IntPtr) As Integer

  Public Declare Function WndTabSelect Lib "Litecad.dll" Alias "lcWndTabSelect" (ByVal hLcWnd As IntPtr, ByVal TabID As Integer) As Integer

  Public Declare Function WndPaperEnable Lib "Litecad.dll" Alias "lcWndPaperEnable" (ByVal hLcWnd As IntPtr, ByVal bEnable As Integer) As Integer

  Public Declare Function WndPaperSetSize Lib "Litecad.dll" Alias "lcWndPaperSetSize" (ByVal hLcWnd As IntPtr, ByVal Size As Integer, ByVal Orient As Integer) As Integer

  Public Declare Function WndPaperSetSize2 Lib "Litecad.dll" Alias "lcWndPaperSetSize2" (ByVal hLcWnd As IntPtr, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function WndPaperSetPos Lib "Litecad.dll" Alias "lcWndPaperSetPos" (ByVal hLcWnd As IntPtr, ByVal Left As Double, ByVal Bottom As Double) As Integer

  Public Declare Function GripClear Lib "Litecad.dll" Alias "lcGripClear" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function GripAdd Lib "Litecad.dll" Alias "lcGripAdd" (ByVal hLcWnd As IntPtr, ByVal hObj As IntPtr, ByVal iGrip As Integer, ByVal Typ As Integer, ByVal X As Double, ByVal Y As Double, ByVal Ang As Double, ByVal X0 As Double, ByVal Y0 As Double) As Integer

  Public Declare Function GripSet Lib "Litecad.dll" Alias "lcGripSet" (ByVal hLcWnd As IntPtr, ByVal hObj As IntPtr, ByVal iGrip As Integer, ByVal X As Double, ByVal Y As Double, ByVal Ang As Double, ByVal X0 As Double, ByVal Y0 As Double) As Integer

  Public Declare Function Paint_PenCreate Lib "Litecad.dll" Alias "lcPaint_PenCreate" (ByVal hLcWnd As IntPtr, ByVal Id As Integer, ByVal Color As IntPtr, ByVal Width As Double, ByVal PenStyle As Integer) As IntPtr

  Public Declare Function Paint_PenSelect Lib "Litecad.dll" Alias "lcPaint_PenSelect" (ByVal hLcWnd As IntPtr, ByVal hPen As IntPtr) As Integer

  Public Declare Function Paint_PenSelectID Lib "Litecad.dll" Alias "lcPaint_PenSelectID" (ByVal hLcWnd As IntPtr, ByVal IdPen As Integer) As Integer

  Public Declare Function Paint_BrushCreate Lib "Litecad.dll" Alias "lcPaint_BrushCreate" (ByVal hLcWnd As IntPtr, ByVal Id As Integer, ByVal Color As IntPtr, ByVal Pattern As Integer, ByVal Alpha As Integer) As IntPtr

  Public Declare Function Paint_BrushSelect Lib "Litecad.dll" Alias "lcPaint_BrushSelect" (ByVal hLcWnd As IntPtr, ByVal hBrush As IntPtr) As Integer

  Public Declare Function Paint_BrushSelectID Lib "Litecad.dll" Alias "lcPaint_BrushSelectID" (ByVal hLcWnd As IntPtr, ByVal IdBrush As Integer) As Integer

  Public Declare Function Paint_DrawPtbuf Lib "Litecad.dll" Alias "lcPaint_DrawPtbuf" (ByVal hLcWnd As IntPtr, ByVal hPtbuf As IntPtr, ByVal bClosed As Integer) As Integer

  Public Declare Function Paint_DrawMpgon Lib "Litecad.dll" Alias "lcPaint_DrawMpgon" (ByVal hLcWnd As IntPtr, ByVal hMpgon As IntPtr, ByVal bFill As Integer, ByVal bBorder As Integer) As Integer

  Public Declare Function Paint_DrawImage Lib "Litecad.dll" Alias "lcPaint_DrawImage" (ByVal hLcWnd As IntPtr, ByVal hImage As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal PixelSize As Double, ByVal Transp As Integer, ByVal TVal As Integer, ByVal hPtbuf As IntPtr) As Integer

  Public Declare Function Paint_DrawImage2 Lib "Litecad.dll" Alias "lcPaint_DrawImage2" (ByVal hLcWnd As IntPtr, ByVal hImage As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal W As Double, ByVal H As Double, ByVal Transp As Integer, ByVal TVal As Integer, ByVal hPtbuf As IntPtr) As Integer

  Public Declare Unicode Function Paint_DrawText Lib "Litecad.dll" Alias "lcPaint_DrawText" (ByVal hLcWnd As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function Paint_DrawText2 Lib "Litecad.dll" Alias "lcPaint_DrawText2" (ByVal hLcWnd As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Align As Integer, ByVal szText As String) As Integer

  Public Declare Unicode Function Paint_DrawTextBC Lib "Litecad.dll" Alias "lcPaint_DrawTextBC" (ByVal hLcWnd As IntPtr, ByVal hMpgon As IntPtr, ByVal Gap As Double, ByVal Height As Double, ByVal Align As Integer, ByVal szText As String) As Integer

  Public Declare Unicode Function Paint_DrawArcText Lib "Litecad.dll" Alias "lcPaint_DrawArcText" (ByVal hLcWnd As IntPtr, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Rad As Double, ByVal Ang0 As Double, ByVal bCW As Integer, ByVal H As Double, ByVal WScale As Double, ByVal Align As Integer) As Integer

  Public Declare Function Paint_DrawHatch Lib "Litecad.dll" Alias "lcPaint_DrawHatch" (ByVal hLcWnd As IntPtr, ByVal hHatch As IntPtr) As Integer

  Public Declare Function Paint_DrawPoint Lib "Litecad.dll" Alias "lcPaint_DrawPoint" (ByVal hLcWnd As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal PtMode As Integer, ByVal PtSize As Double) As Integer

  Public Declare Function Paint_DrawLine Lib "Litecad.dll" Alias "lcPaint_DrawLine" (ByVal hLcWnd As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function Paint_DrawXline Lib "Litecad.dll" Alias "lcPaint_DrawXline" (ByVal hLcWnd As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal bRay As Integer) As Integer

  Public Declare Function Paint_DrawRect Lib "Litecad.dll" Alias "lcPaint_DrawRect" (ByVal hLcWnd As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function Paint_DrawRect2 Lib "Litecad.dll" Alias "lcPaint_DrawRect2" (ByVal hLcWnd As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function Paint_DrawPickBox Lib "Litecad.dll" Alias "lcPaint_DrawPickBox" (ByVal hLcWnd As IntPtr) As Integer

  Public Declare Function Paint_DrawGrid Lib "Litecad.dll" Alias "lcPaint_DrawGrid" (ByVal hLcWnd As IntPtr, ByVal hGrid As IntPtr, ByVal bDest As Integer, ByVal ColLine As IntPtr, ByVal ColNode As IntPtr) As Integer

  Public Declare Unicode Function Paint_DrawCPrompt Lib "Litecad.dll" Alias "lcPaint_DrawCPrompt" (ByVal hLcWnd As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal Align As Integer, ByVal szText As String) As Integer

  Public Declare Sub Paint_SetPixel Lib "Litecad.dll" Alias "lcPaint_SetPixel" (ByVal hDC As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal Color As IntPtr)

  Public Declare Function Paint_CreatePtbuf Lib "Litecad.dll" Alias "lcPaint_CreatePtbuf" () As IntPtr

  Public Declare Function Paint_DeletePtbuf Lib "Litecad.dll" Alias "lcPaint_DeletePtbuf" (ByVal hPtbuf As IntPtr) As Integer

  Public Declare Function Paint_PtbufClear Lib "Litecad.dll" Alias "lcPaint_PtbufClear" (ByVal hPtbuf As IntPtr) As Integer

  Public Declare Function Paint_PtbufAddPoint Lib "Litecad.dll" Alias "lcPaint_PtbufAddPoint" (ByVal hPtbuf As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Prm1 As Double, ByVal Prm2 As Double, ByVal IntPrm As Integer) As Integer

  Public Declare Function Paint_PtbufAddPoint2 Lib "Litecad.dll" Alias "lcPaint_PtbufAddPoint2" (ByVal hPtbuf As IntPtr, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function Paint_PtbufAddPointP Lib "Litecad.dll" Alias "lcPaint_PtbufAddPointP" (ByVal hPtbuf As IntPtr, ByVal Angle As Double, ByVal Dist As Double) As Integer

  Public Declare Function Paint_PtbufAddLine Lib "Litecad.dll" Alias "lcPaint_PtbufAddLine" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function Paint_PtbufAddLineP Lib "Litecad.dll" Alias "lcPaint_PtbufAddLineP" (ByVal hPtbuf As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal Dist As Double) As Integer

  Public Declare Function Paint_PtbufAddCircle Lib "Litecad.dll" Alias "lcPaint_PtbufAddCircle" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddCircle2 Lib "Litecad.dll" Alias "lcPaint_PtbufAddCircle2" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddCircle3 Lib "Litecad.dll" Alias "lcPaint_PtbufAddCircle3" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double, ByVal bInside As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArc Lib "Litecad.dll" Alias "lcPaint_PtbufAddArc" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal StartAngle As Double, ByVal ArcAngle As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArc3p Lib "Litecad.dll" Alias "lcPaint_PtbufAddArc3p" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSDE Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSDE" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal DirAng As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSDAR Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSDAR" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal DirAng As Double, ByVal AngArc As Double, ByVal R As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSER Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSER" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal Radius As Double, ByVal bClockwise As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSEL Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSEL" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal ArcLen As Double, ByVal bClockwise As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSEA Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSEA" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal AngArc As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcSEB Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcSEB" (ByVal hPtbuf As IntPtr, ByVal Xs As Double, ByVal Ys As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal Bulge As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcCSE Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcCSE" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Xs As Double, ByVal Ys As Double, ByVal Xe As Double, ByVal Ye As Double, ByVal bClockwise As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcCSA Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcCSA" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Xs As Double, ByVal Ys As Double, ByVal AngArc As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcCSL Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcCSL" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Xs As Double, ByVal Ys As Double, ByVal ChordLen As Double, ByVal bClockwise As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddArcCRAA Lib "Litecad.dll" Alias "lcPaint_PtbufAddArcCRAA" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal AngStart As Double, ByVal AngEnd As Double, ByVal bClockwise As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddEllipse Lib "Litecad.dll" Alias "lcPaint_PtbufAddEllipse" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Rmaj As Double, ByVal Rmin As Double, ByVal RotAng As Double, ByVal StartAng As Double, ByVal ArcAng As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddEllipse2 Lib "Litecad.dll" Alias "lcPaint_PtbufAddEllipse2" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddRect Lib "Litecad.dll" Alias "lcPaint_PtbufAddRect" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal W As Double, ByVal H As Double, ByVal Angle As Double, ByVal R As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddRect2 Lib "Litecad.dll" Alias "lcPaint_PtbufAddRect2" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal R As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddRect3 Lib "Litecad.dll" Alias "lcPaint_PtbufAddRect3" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal W As Double, ByVal Align As Integer, ByVal R As Double, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddWline Lib "Litecad.dll" Alias "lcPaint_PtbufAddWline" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal W As Double, ByVal Align As Integer, ByVal bArc As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufAddPtbuf Lib "Litecad.dll" Alias "lcPaint_PtbufAddPtbuf" (ByVal hPtbuf As IntPtr, ByVal hPtbuf2 As IntPtr) As Integer

  Public Declare Function Paint_PtbufGetPoint Lib "Litecad.dll" Alias "lcPaint_PtbufGetPoint" (ByVal hPtbuf As IntPtr, ByVal Mode As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function Paint_PtbufGetPoint2 Lib "Litecad.dll" Alias "lcPaint_PtbufGetPoint2" (ByVal hPtbuf As IntPtr, ByVal Mode As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pPrm1 As Double, ByRef pPrm2 As Double, ByRef pIntPrm As Integer) As Integer

  Public Declare Function Paint_PtbufInterpolate Lib "Litecad.dll" Alias "lcPaint_PtbufInterpolate" (ByVal hPtbuf As IntPtr, ByVal bClosed As Integer, ByVal hPtbufDest As IntPtr, ByVal Mode As Integer, ByVal Resol As Integer) As Integer

  Public Declare Function Paint_PtbufMove Lib "Litecad.dll" Alias "lcPaint_PtbufMove" (ByVal hPtbuf As IntPtr, ByVal dx As Double, ByVal dy As Double) As Integer

  Public Declare Function Paint_PtbufRotate Lib "Litecad.dll" Alias "lcPaint_PtbufRotate" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Angle As Double) As Integer

  Public Declare Function Paint_PtbufScale Lib "Litecad.dll" Alias "lcPaint_PtbufScale" (ByVal hPtbuf As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal ScaleX As Double, ByVal ScaleY As Double) As Integer

  Public Declare Function Paint_PtbufMirror Lib "Litecad.dll" Alias "lcPaint_PtbufMirror" (ByVal hPtbuf As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function Paint_PtbufCopy Lib "Litecad.dll" Alias "lcPaint_PtbufCopy" (ByVal hPtbuf As IntPtr, ByVal hPtbufDest As IntPtr) As Integer

  Public Declare Function Paint_CreateMpgon Lib "Litecad.dll" Alias "lcPaint_CreateMpgon" () As IntPtr

  Public Declare Function Paint_DeleteMpgon Lib "Litecad.dll" Alias "lcPaint_DeleteMpgon" (ByVal hMpgon As IntPtr) As Integer

  Public Declare Function Paint_MpgonClear Lib "Litecad.dll" Alias "lcPaint_MpgonClear" (ByVal hMpgon As IntPtr) As Integer

  Public Declare Function Paint_MpgonAddPgon Lib "Litecad.dll" Alias "lcPaint_MpgonAddPgon" (ByVal hMpgon As IntPtr, ByVal hPtbuf As IntPtr) As Integer

  Public Declare Unicode Function Paint_MpgonAddText Lib "Litecad.dll" Alias "lcPaint_MpgonAddText" (ByVal hMpgon As IntPtr, ByVal hFont As IntPtr, ByVal X As Double, ByVal Y As Double, ByVal szText As String, ByVal Resol As Integer) As Integer

  Public Declare Unicode Function Paint_MpgonAddBarcode Lib "Litecad.dll" Alias "lcPaint_MpgonAddBarcode" (ByVal hMpgon As IntPtr, ByVal BarType As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal Width As Double, ByVal Height As Double, ByVal szText As String) As Integer

  Public Declare Function Paint_MpgonMove Lib "Litecad.dll" Alias "lcPaint_MpgonMove" (ByVal hMpgon As IntPtr, ByVal dx As Double, ByVal dy As Double) As Integer

  Public Declare Function Paint_MpgonRotate Lib "Litecad.dll" Alias "lcPaint_MpgonRotate" (ByVal hMpgon As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal Angle As Double) As Integer

  Public Declare Function Paint_MpgonScale Lib "Litecad.dll" Alias "lcPaint_MpgonScale" (ByVal hMpgon As IntPtr, ByVal Xc As Double, ByVal Yc As Double, ByVal ScaleX As Double, ByVal ScaleY As Double) As Integer

  Public Declare Function Paint_MpgonMirror Lib "Litecad.dll" Alias "lcPaint_MpgonMirror" (ByVal hMpgon As IntPtr, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function Paint_MpgonCopy Lib "Litecad.dll" Alias "lcPaint_MpgonCopy" (ByVal hMpgon As IntPtr, ByVal hMpgonDest As IntPtr) As Integer

  Public Declare Function Paint_HatchGen Lib "Litecad.dll" Alias "lcPaint_HatchGen" (ByVal hMpgon As IntPtr, ByVal hHatch As IntPtr, ByVal Dist As Double, ByVal Angle As Double, ByVal Gap As Double) As Integer

  Public Declare Function Paint_ImageAdd Lib "Litecad.dll" Alias "lcPaint_ImageAdd" (ByVal Id As Integer) As IntPtr

  Public Declare Function Paint_ImageDelete Lib "Litecad.dll" Alias "lcPaint_ImageDelete" (ByVal hImage As IntPtr) As Integer

  Public Declare Function Paint_ImageGetFirst Lib "Litecad.dll" Alias "lcPaint_ImageGetFirst" () As IntPtr

  Public Declare Function Paint_ImageGetNext Lib "Litecad.dll" Alias "lcPaint_ImageGetNext" (ByVal hImage As IntPtr) As IntPtr

  Public Declare Function Paint_ImageGetByID Lib "Litecad.dll" Alias "lcPaint_ImageGetByID" (ByVal Id As Integer) As IntPtr

  Public Declare Unicode Function Paint_ImageLoad Lib "Litecad.dll" Alias "lcPaint_ImageLoad" (ByVal hImage As IntPtr, ByVal szFileName As String) As Integer

  Public Declare Function Paint_ImageCopy Lib "Litecad.dll" Alias "lcPaint_ImageCopy" (ByVal hImage As IntPtr, ByVal hImageDest As IntPtr) As Integer

  Public Declare Function Paint_ImageCreate Lib "Litecad.dll" Alias "lcPaint_ImageCreate" (ByVal hImage As IntPtr, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function Paint_ImageSetPixel Lib "Litecad.dll" Alias "lcPaint_ImageSetPixel" (ByVal hImage As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Integer

  Public Declare Function Paint_ImageFlip Lib "Litecad.dll" Alias "lcPaint_ImageFlip" (ByVal hImage As IntPtr, ByVal bHor As Integer, ByVal bVert As Integer) As Integer

  Public Declare Function Paint_ImageRotate Lib "Litecad.dll" Alias "lcPaint_ImageRotate" (ByVal hImage As IntPtr, ByVal Angle As Double) As Integer

  Public Declare Function Paint_ImageGray Lib "Litecad.dll" Alias "lcPaint_ImageGray" (ByVal hImage As IntPtr) As Integer

  Public Declare Function Paint_ImageResize Lib "Litecad.dll" Alias "lcPaint_ImageResize" (ByVal hImage As IntPtr, ByVal NewWidth As Integer, ByVal NewHeight As Integer, ByVal ResizeFilter As Integer) As Integer

  Public Declare Function Paint_ImageGetPtbuf Lib "Litecad.dll" Alias "lcPaint_ImageGetPtbuf" (ByVal hImage As IntPtr, ByVal RotAngle As Double) As IntPtr

  Public Declare Unicode Function Paint_FontOpenLC Lib "Litecad.dll" Alias "lcPaint_FontOpenLC" (ByVal szFontName As String) As IntPtr

  Public Declare Unicode Function Paint_FontOpenTT Lib "Litecad.dll" Alias "lcPaint_FontOpenTT" (ByVal szFontName As String, ByVal bBold As Integer, ByVal bItalic As Integer) As IntPtr

  Public Declare Function Paint_FontClose Lib "Litecad.dll" Alias "lcPaint_FontClose" (ByVal hFont As IntPtr) As Integer

  Public Declare Function Paint_FontSelect Lib "Litecad.dll" Alias "lcPaint_FontSelect" (ByVal hLcWnd As IntPtr, ByVal hFont As IntPtr) As Integer


End Module
