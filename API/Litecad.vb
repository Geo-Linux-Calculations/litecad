Module Lcad

  Public Const LC_FALSE = 0
  Public Const LC_TRUE = 1
  Public Const LC_LBUTTON = 1
  Public Const LC_RBUTTON = 2
  Public Const LC_MBUTTON = 4
  Public Const LC_SHIFT = 1
  Public Const LC_CTRL = 2
  Public Const LC_ALT = 4
  Public Const LC_WS_HSCROLL = 1
  Public Const LC_WS_VSCROLL = 2
  Public Const LC_WS_BORDER = 4
  Public Const LC_WS_CLIENTEDGE = 8
  Public Const LC_WS_SUNKEN = 8
  Public Const LC_WS_STATICEDGE = 16
  Public Const LC_WS_VIEWTABS = 256
  Public Const LC_WS_DEFAULT = 3
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
  Public Const LC_PI = 3.14159265358979323846
  Public Const LC_PI2 = 1.57079632679489661923
  Public Const LC_PI4 = 0.785398163397448309615
  Public Const LC_2PI = 6.28318530717958647692
  Public Const LC_DEG45 = 0.785398163397448309615
  Public Const LC_DEG90 = 1.57079632679489661923
  Public Const LC_DEG180 = 3.14159265358979323846
  Public Const LC_DEG270 = 4.71238898038468985769
  Public Const LC_DEG360 = 6.28318530717958647692
  Public Const LC_RAD_TO_DEG = 57.2957795130823208
  Public Const LC_DEG_TO_RAD = 0.0174532925199433
  Public Const LC_VIEW_TOP = 0
  Public Const LC_VIEW_PLAN = 0
  Public Const LC_VIEW_BOTTOM = 1
  Public Const LC_VIEW_LEFT = 2
  Public Const LC_VIEW_RIGHT = 3
  Public Const LC_VIEW_FRONT = 4
  Public Const LC_VIEW_BACK = 5
  Public Const LC_VIEW_SW = 6
  Public Const LC_VIEW_SE = 7
  Public Const LC_VIEW_NE = 8
  Public Const LC_VIEW_NW = 9
  Public Const LC_VIEW_ISOMETRIC = 10
  Public Const LC_VIEW_PERSPECTIVE = 11
  Public Const LC_PLANE_XY = 0
  Public Const LC_PLANE_XZ = 1
  Public Const LC_PLANE_YZ = 2
  Public Const LC_PAPER_CUSTOM = 0
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
  Public Const LC_PAPER_PORTRAIT = 0
  Public Const LC_PAPER_BOOK = 0
  Public Const LC_PAPER_LANDSCAPE = 1
  Public Const LC_PAPER_ALBUM = 1
  Public Const LC_BLOCK_OVERWRITENO = 0
  Public Const LC_BLOCK_OVERWRITEYES = 1
  Public Const LC_BLOCK_OVERWRITEDLG = 2
  Public Const LC_OBJ_LAYER = 1
  Public Const LC_OBJ_LINETYPE = 2
  Public Const LC_OBJ_TEXTSTYLE = 3
  Public Const LC_OBJ_DIMSTYLE = 4
  Public Const LC_OBJ_BLOCK = 5
  Public Const LC_OBJ_IMAGE = 6
  Public Const LC_OBJ_VIEW = 7
  Public Const LC_OBJ_MLSTYLE = 8
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
  Public Const LC_ENT_RECT = 118
  Public Const LC_ENT_ATTRIB = 120
  Public Const LC_ENT_ECW = 121
  Public Const LC_ENT_MTEXT = 122
  Public Const LC_ENT_ARCTEXT = 123
  Public Const LC_ENT_HATCH = 124
  Public Const LC_ENT_BEZIER = 125
  Public Const LC_ENT_MLINE = 127
  Public Const LC_ENT_DIMROT = 131
  Public Const LC_ENT_DIMALI = 132
  Public Const LC_ENT_DIMORD = 133
  Public Const LC_ENT_DIMRAD = 134
  Public Const LC_ENT_DIMDIA = 135
  Public Const LC_ENT_DIMANG = 136
  Public Const LC_ENT_LEADER = 137
  Public Const LC_ENT_CUSTOM = 1000
  Public Const LC_ENT_ALL = 32767
  Public Const LC_LWEIGHT_DEFAULT = -3
  Public Const LC_LWEIGHT_BYBLOCK = -2
  Public Const LC_LWEIGHT_BYLAYER = -1
  Public Const LC_LWEIGHT_000 = 0
  Public Const LC_LWEIGHT_005 = 5
  Public Const LC_LWEIGHT_009 = 9
  Public Const LC_LWEIGHT_013 = 13
  Public Const LC_LWEIGHT_015 = 15
  Public Const LC_LWEIGHT_018 = 18
  Public Const LC_LWEIGHT_020 = 20
  Public Const LC_LWEIGHT_025 = 25
  Public Const LC_LWEIGHT_030 = 30
  Public Const LC_LWEIGHT_035 = 35
  Public Const LC_LWEIGHT_040 = 40
  Public Const LC_LWEIGHT_050 = 50
  Public Const LC_LWEIGHT_053 = 53
  Public Const LC_LWEIGHT_060 = 60
  Public Const LC_LWEIGHT_070 = 70
  Public Const LC_LWEIGHT_080 = 80
  Public Const LC_LWEIGHT_090 = 90
  Public Const LC_LWEIGHT_100 = 100
  Public Const LC_LWEIGHT_106 = 106
  Public Const LC_LWEIGHT_120 = 120
  Public Const LC_LWEIGHT_140 = 140
  Public Const LC_LWEIGHT_158 = 158
  Public Const LC_LWEIGHT_200 = 200
  Public Const LC_LWEIGHT_211 = 211
  Public Const LC_KBD_QWERTY = 0
  Public Const LC_KBD_AZERTY = 1
  Public Const LC_CMD_FILESAVE = 4
  Public Const LC_CMD_FILESAVEAS = 5
  Public Const LC_CMD_PRINT = 7
  Public Const LC_CMD_RASTERIZE = 8
  Public Const LC_CMD_POINT = 201
  Public Const LC_CMD_LINE = 202
  Public Const LC_CMD_XLINE = 203
  Public Const LC_CMD_RAY = 204
  Public Const LC_CMD_PLINE = 205
  Public Const LC_CMD_POLYLINE = 205
  Public Const LC_CMD_RECT = 206
  Public Const LC_CMD_CIRCLE = 207
  Public Const LC_CMD_ARC = 208
  Public Const LC_CMD_ELLIPSE = 209
  Public Const LC_CMD_TEXT = 210
  Public Const LC_CMD_MTEXT = 211
  Public Const LC_CMD_ATEXT = 212
  Public Const LC_CMD_INSERT = 213
  Public Const LC_CMD_VPORT = 214
  Public Const LC_CMD_BASEPOINT = 215
  Public Const LC_CMD_ATTDEF = 216
  Public Const LC_CMD_HATCH = 217
  Public Const LC_CMD_BOUNDARY = 218
  Public Const LC_CMD_WTEXT = 219
  Public Const LC_CMD_DIMROT = 231
  Public Const LC_CMD_DIMALI = 232
  Public Const LC_CMD_DIMORD = 233
  Public Const LC_CMD_DIMRAD = 234
  Public Const LC_CMD_DIMDIA = 235
  Public Const LC_CMD_DIMANG = 236
  Public Const LC_CMD_LEADER = 237
  Public Const LC_CMD_CENTER = 238
  Public Const LC_CMD_ECW = 239
  Public Const LC_CMD_MLINE = 240
  Public Const LC_CMD_CBCUT = 301
  Public Const LC_CMD_CBCOPY = 302
  Public Const LC_CMD_CBPASTE = 303
  Public Const LC_CMD_UNDO = 304
  Public Const LC_CMD_REDO = 305
  Public Const LC_CMD_COPY = 306
  Public Const LC_CMD_ERASE = 307
  Public Const LC_CMD_MOVE = 308
  Public Const LC_CMD_ROTATE = 309
  Public Const LC_CMD_SCALE = 310
  Public Const LC_CMD_MIRROR = 311
  Public Const LC_CMD_EXPLODE = 312
  Public Const LC_CMD_JOIN = 314
  Public Const LC_CMD_DEP = 315
  Public Const LC_CMD_ORDER = 316
  Public Const LC_CMD_CLOSEBLOCK = 317
  Public Const LC_CMD_TRIM = 318
  Public Const LC_CMD_EXTEND = 319
  Public Const LC_CMD_OFFSET = 320
  Public Const LC_CMD_OFFSET_POINT = 0
  Public Const LC_CMD_OFFSET_DIST = 1
  Public Const LC_CMD_BREAK = 321
  Public Const LC_CMD_VIEWSTART = 401
  Public Const LC_CMD_ZOOM_IN = 401
  Public Const LC_CMD_ZOOM_OUT = 402
  Public Const LC_CMD_ZOOM_EXT = 403
  Public Const LC_CMD_ZOOM_LIM = 404
  Public Const LC_CMD_ZOOM_PREV = 405
  Public Const LC_CMD_ZOOM_SEL = 406
  Public Const LC_CMD_PAN_LEFT = 407
  Public Const LC_CMD_PAN_RIGHT = 408
  Public Const LC_CMD_PAN_UP = 409
  Public Const LC_CMD_PAN_DOWN = 410
  Public Const LC_CMD_VIEWEND = 410
  Public Const LC_CMD_PAN_RT = 419
  Public Const LC_CMD_ZOOM_RT = 420
  Public Const LC_CMD_ZOOM_WIN = 421
  Public Const LC_CMD_PAGENEXT = 423
  Public Const LC_CMD_PAGEPREV = 424
  Public Const LC_CMD_PAGEMODEL = 425
  Public Const LC_CMD_PAGEVPORT = 426
  Public Const LC_CMD_VP_ACT = 427
  Public Const LC_CMD_VP_DEACT = 428
  Public Const LC_CMD_VIEW_TOP = 430
  Public Const LC_CMD_VIEW_BOTTOM = 431
  Public Const LC_CMD_VIEW_LEFT = 432
  Public Const LC_CMD_VIEW_RIGHT = 433
  Public Const LC_CMD_VIEW_FRONT = 434
  Public Const LC_CMD_VIEW_BACK = 435
  Public Const LC_CMD_VIEW_SW = 436
  Public Const LC_CMD_VIEW_SE = 437
  Public Const LC_CMD_VIEW_NE = 438
  Public Const LC_CMD_VIEW_NW = 439
  Public Const LC_CMD_VIEW_SET = 440
  Public Const LC_CMD_LAYER = 501
  Public Const LC_CMD_LAYERNF = 502
  Public Const LC_CMD_LAYER2 = 502
  Public Const LC_CMD_COLOR = 503
  Public Const LC_CMD_BCOLOR = 504
  Public Const LC_CMD_LINETYPE = 505
  Public Const LC_CMD_LWEIGHT = 506
  Public Const LC_CMD_TEXTSTYLE = 507
  Public Const LC_CMD_BLOCK = 508
  Public Const LC_CMD_BLOCKS = 509
  Public Const LC_CMD_IMAGE = 510
  Public Const LC_CMD_PNTSTYLE = 511
  Public Const LC_CMD_DIMSTYLE = 512
  Public Const LC_CMD_MLSTYLE = 513
  Public Const LC_CMD_LAYOUT = 514
  Public Const LC_CMD_LIMITS = 515
  Public Const LC_CMD_UNITS = 516
  Public Const LC_CMD_DRWPRM = 517
  Public Const LC_CMD_SNAP = 105
  Public Const LC_CMD_DAIDS = 106
  Public Const LC_CMD_GRID = 107
  Public Const LC_CMD_POLAR = 108
  Public Const LC_CMD_OSNAP = 109
  Public Const LC_CMD_OPTIONS = 118
  Public Const LC_CMD_PLUGIN = 119
  Public Const LC_CMD_REGEN = 120
  Public Const LC_CMD_SELOPTS = 122
  Public Const LC_CMD_QSELECT = 123
  Public Const LC_CMD_DIST = 124
  Public Const LC_CMD_AREA = 125
  Public Const LC_CMD_SELPGON = 126
  Public Const LC_CMD_SELCLAYER = 127
  Public Const LC_CMD_SELALL = 128
  Public Const LC_CMD_UNSELALL = 129
  Public Const LC_CMD_HELP = 1001
  Public Const LC_CMD_REPEAT = 1002
  Public Const LC_CMD_RESET = 1003
  Public Const LC_CMD_SW_GRID = 1011
  Public Const LC_CMD_SW_GRIDSNAP = 1012
  Public Const LC_CMD_SW_LWEIGHT = 1013
  Public Const LC_CMD_SW_OSNAP = 1014
  Public Const LC_CMD_SW_POLAR = 1015
  Public Const LC_CMD_SW_ORTHO = 1016
  Public Const LC_CMD_SNAP_NONE = 1100
  Public Const LC_CMD_SNAP_NODE = 1101
  Public Const LC_CMD_SNAP_ENDPOINT = 1102
  Public Const LC_CMD_SNAP_MIDPOINT = 1103
  Public Const LC_CMD_SNAP_CENTER = 1104
  Public Const LC_CMD_SNAP_QUADRANT = 1105
  Public Const LC_CMD_SNAP_NEAREST = 1106
  Public Const LC_CMD_SNAP_INTER = 1107
  Public Const LC_CMD_SNAP_PERPEND = 1108
  Public Const LC_CMD_SNAP_TANGENT = 1109
  Public Const LC_CMD_SNAP_INSERT = 1110
  Public Const LC_CMD_SNAP_DIALOG = 1111
  Public Const LC_CMD_CUSTOM = 30000
  Public Const LC_SNAP_NULL = 0
  Public Const LC_SNAP_NODE = 1
  Public Const LC_SNAP_ENDPOINT = 2
  Public Const LC_SNAP_MIDPOINT = 4
  Public Const LC_SNAP_CENTER = 8
  Public Const LC_SNAP_NEAREST = 16
  Public Const LC_SNAP_INTER = 32
  Public Const LC_SNAP_PERPEND = 64
  Public Const LC_SNAP_TANGENT = 128
  Public Const LC_SNAP_QUADRANT = 256
  Public Const LC_SNAP_INSERT = 512
  Public Const LC_SNAP_NONE = 1024
  Public Const LC_SNAP_ALL = 1023
  Public Const LC_SNAP_DBLTANG = 65536
  Public Const LC_HELP_DG_LIMITS = 1
  Public Const LC_HELP_DG_GRID = 2
  Public Const LC_HELP_DG_PSNAP = 3
  Public Const LC_HELP_DG_OSNAP = 4
  Public Const LC_HELP_DG_OSNAP2 = 5
  Public Const LC_HELP_DG_OPTIONS = 6
  Public Const LC_HELP_DG_INPUTCOORD = 7
  Public Const LC_HELP_DG_LAYERS = 8
  Public Const LC_HELP_DG_LAYSTATES = 9
  Public Const LC_HELP_DG_TEXTSTYLES = 10
  Public Const LC_HELP_DG_PNTSTYLE = 11
  Public Const LC_HELP_DG_SELFONT = 13
  Public Const LC_HELP_DG_LINETYPES = 14
  Public Const LC_HELP_DG_LOADLINETYPE = 15
  Public Const LC_HELP_DG_SELLTYPE = 16
  Public Const LC_HELP_DG_COLOR = 17
  Public Const LC_HELP_DG_TEXT = 18
  Public Const LC_HELP_DG_LINEWEIGHT = 19
  Public Const LC_HELP_DG_IMAGES = 20
  Public Const LC_HELP_DG_IMAGEINSERT = 21
  Public Const LC_HELP_DG_BLOCKS = 22
  Public Const LC_HELP_DG_INSERT = 23
  Public Const LC_HELP_DG_PRINT = 24
  Public Const LC_HELP_DG_RASTER = 25
  Public Const LC_HELP_DG_LAYOUTS = 26
  Public Const LC_HELP_DG_PAGEPROP = 27
  Public Const LC_HELP_DG_CREBLOCK = 28
  Public Const LC_HELP_DG_SELBLOCK = 29
  Public Const LC_HELP_DG_SELTSTYLE = 30
  Public Const LC_HELP_DG_ATEXT = 31
  Public Const LC_HELP_DG_FONTREPLACE = 32
  Public Const LC_HELP_DG_ATTDEF = 33
  Public Const LC_HELP_DG_HATCH = 34
  Public Const LC_HELP_DG_DRWPROPS = 35
  Public Const LC_HELP_DG_UNITS = 36
  Public Const LC_HELP_DG_MLSTYLES = 37
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
  Public Const LC_PLFIT_BULGE = 0
  Public Const LC_PLFIT_QUAD = 5
  Public Const LC_PLFIT_CUBIC = 6
  Public Const LC_PLFIT_SPLINE = 99
  Public Const LC_PLFIT_ROUND = 101
  Public Const LC_PLFIT_LINQUAD = 102
  Public Const LC_MLINE_TOP = 0
  Public Const LC_MLINE_MIDDLE = 1
  Public Const LC_MLINE_BOTTOM = 2
  Public Const LC_POINT_PIXEL = 0
  Public Const LC_POINT_NONE = 1
  Public Const LC_POINT_PLUS = 2
  Public Const LC_POINT_X = 3
  Public Const LC_POINT_TICK = 4
  Public Const LC_POINT_CIRCLE = 32
  Public Const LC_POINT_SQUARE = 64
  Public Const LC_POINT_RHOMB = 128
  Public Const LC_POINT_FILLED = 256
  Public Const LC_LEADER_TCENTER = 0
  Public Const LC_LEADER_TLEFT = 1
  Public Const LC_LEADER_TRIGHT = 2
  Public Const LC_LEADER_VERT = 1
  Public Const LC_LEADER_CORNER = 2
  Public Const LC_ATTRIB_HIDDEN = 1
  Public Const LC_ATTRIB_CONST = 2
  Public Const LC_ATTRIB_VERIFY = 4
  Public Const LC_ATTRIB_PRESET = 8
  Public Const LC_ATTRIB_LOCK = 16
  Public Const LC_ATTRIB_MTEXT = 32
  Public Const LC_DECSEP_POINT = 0
  Public Const LC_DECSEP_COMMA = 1
  Public Const LC_DECSEP_NONE = 2
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
  Public Const LC_PLUG_IMPDRW = 2
  Public Const LC_PLUG_EXPDRW = 3
  Public Const LC_PLUG_IMGDIB = 4
  Public Const LC_FP_FLOAD = 0
  Public Const LC_FP_FSAVE = 1
  Public Const LC_FP_NITEMS = 2
  Public Const LC_FP_ITEM = 3
  Public Const LC_DG_SELFILE = 0
  Public Const LC_DG_RECENT = 1
  Public Const LC_DG_TEMPLATE = 2
  Public Const LC_ERR_USERCANCEL = 1
  Public Const LC_ERR_OBJTYPE = 2
  Public Const LC_ERR_FILENAME = 3
  Public Const LC_ERR_FILELOAD = 4
  Public Const LC_ERR_FILESAVE = 5
  Public Const LC_ERR_NOTAG = 6
  Public Const LC_ERR_UNRESBLOCKREF = 7
  Public Const LC_ERR_UNRESVIEWREF = 8
  Public Const LC_ERR_UNRESHATCH = 9
  Public Const LC_ERR_SELBLOCKM = 10
  Public Const LC_ERR_SELBLOCKP = 11
  Public Const LC_MAX_USERPNT = 100
  Public Const LC_PROP_G_REGCODE = 1
  Public Const LC_PROP_G_VERSION = 2
  Public Const LC_PROP_G_DIRDLL = 3
  Public Const LC_PROP_G_DIRCFG = 4
  Public Const LC_PROP_G_DIRFONTS = 5
  Public Const LC_PROP_G_FILEHATCH = 6
  Public Const LC_PROP_G_FILELTYPE = 7
  Public Const LC_PROP_G_TEMPLATE = 8
  Public Const LC_PROP_G_DIRTEMPLATE = 9
  Public Const LC_PROP_G_OWNDXFR = 10
  Public Const LC_PROP_G_OWNDXFW = 11
  Public Const LC_PROP_G_PANSTEP = 12
  Public Const LC_PROP_G_PANFILLING = 13
  Public Const LC_PROP_G_PANHATCH = 14
  Public Const LC_PROP_G_PANPLWIDTH = 15
  Public Const LC_PROP_G_PANLWEIGHT = 16
  Public Const LC_PROP_G_PANFILLCHAR = 17
  Public Const LC_PROP_G_PANRECTCHAR = 18
  Public Const LC_PROP_G_CURSORARROW = 101
  Public Const LC_PROP_G_CURSORCROSS = 102
  Public Const LC_PROP_G_CURSORSIZE = 103
  Public Const LC_PROP_G_AUTOSELECT = 110
  Public Const LC_PROP_G_PICKFIRST = 111
  Public Const LC_PROP_G_PICKAUTO = 112
  Public Const LC_PROP_G_PICKDRAG = 113
  Public Const LC_PROP_G_PICKADD = 114
  Public Const LC_PROP_G_PICKBOXSIZE = 115
  Public Const LC_PROP_G_AUTOUNSELECT = 116
  Public Const LC_PROP_G_SELBYLAYER = 117
  Public Const LC_PROP_G_SELINSIDE = 118
  Public Const LC_PROP_G_ENABLEGRIPS = 119
  Public Const LC_PROP_G_GRIPSIZE = 120
  Public Const LC_PROP_G_GRIPCOLOR = 121
  Public Const LC_PROP_G_GRIPSLIMIT = 122
  Public Const LC_PROP_G_SELCOLOR = 123
  Public Const LC_PROP_G_DRAGCOLOR = 124
  Public Const LC_PROP_G_DLGRECENT = 125
  Public Const LC_PROP_G_AXES = 139
  Public Const LC_PROP_G_AXESTOP = 140
  Public Const LC_PROP_G_GETDELENT = 143
  Public Const LC_PROP_G_WNDSTYLE = 144
  Public Const LC_PROP_G_OCXSAVECFG = 145
  Public Const LC_PROP_G_INITCOUNT = 146
  Public Const LC_PROP_G_CMDFONT = 147
  Public Const LC_PROP_G_CMDFONTSIZE = 148
  Public Const LC_PROP_G_ANGSEPDMS = 149
  Public Const LC_PROP_G_ADDRECENT = 150
  Public Const LC_PROP_LNG_TAG = 251
  Public Const LC_PROP_LNG_STR = 252
  Public Const LC_PROP_LNG_STR0 = 253
  Public Const LC_PROP_LNG_OLD = 254
  Public Const LC_PROP_FONT_FILENAME = 281
  Public Const LC_PROP_FONT_NAME = 282
  Public Const LC_PROP_FONT_HEIGHT = 283
  Public Const LC_PROP_FONT_FILLED = 284
  Public Const LC_PROP_FONT_TTF = 285
  Public Const LC_PROP_FONT_NCHARS = 286
  Public Const LC_PROP_FONT_CHARCODE = 287
  Public Const LC_PROP_FONT_CHAR = 288
  Public Const LC_PROP_WND_ID = 301
  Public Const LC_PROP_WND_VIEW = 302
  Public Const LC_PROP_WND_VIEWBLOCK = 303
  Public Const LC_PROP_WND_VIEWDRW = 304
  Public Const LC_PROP_WND_WIDTH = 306
  Public Const LC_PROP_WND_HEIGHT = 307
  Public Const LC_PROP_WND_HWND = 308
  Public Const LC_PROP_WND_FOCUS = 309
  Public Const LC_PROP_WND_EMPTYTEXT = 310
  Public Const LC_PROP_WND_CURSORX = 311
  Public Const LC_PROP_WND_CURX = 311
  Public Const LC_PROP_WND_CURSORY = 312
  Public Const LC_PROP_WND_CURY = 312
  Public Const LC_PROP_WND_HASBASE = 314
  Public Const LC_PROP_WND_BASEX = 315
  Public Const LC_PROP_WND_BASEY = 316
  Public Const LC_PROP_WND_BASEDIST = 318
  Public Const LC_PROP_WND_BASEANGLE = 319
  Public Const LC_PROP_WND_HOCX = 321
  Public Const LC_PROP_WND_DRAWPICKBOX = 322
  Public Const LC_PROP_WND_COMMAND = 323
  Public Const LC_PROP_WND_PIXELSIZE = 324
  Public Const LC_PROP_WND_PICKBOXSIZE = 325
  Public Const LC_PROP_WND_CURLEF = 326
  Public Const LC_PROP_WND_CURBOT = 327
  Public Const LC_PROP_WND_CURRIG = 328
  Public Const LC_PROP_WND_CURTOP = 329
  Public Const LC_PROP_DRW_GUID = 401
  Public Const LC_PROP_DRW_FILENAME = 402
  Public Const LC_PROP_DRW_READONLY = 403
  Public Const LC_PROP_DRW_BLOCKX = 404
  Public Const LC_PROP_DRW_BLOCKY = 405
  Public Const LC_PROP_DRW_BLOCKZ = 406
  Public Const LC_PROP_DRW_COLORBACKM = 414
  Public Const LC_PROP_DRW_COLORBACKP = 415
  Public Const LC_PROP_DRW_COLORFOREM = 416
  Public Const LC_PROP_DRW_COLORFOREP = 417
  Public Const LC_PROP_DRW_COLORCURSORM = 418
  Public Const LC_PROP_DRW_COLORCURSORP = 419
  Public Const LC_PROP_DRW_COLORPAPER = 420
  Public Const LC_PROP_DRW_COLORPAPER2 = 421
  Public Const LC_PROP_DRW_LUNITS = 422
  Public Const LC_PROP_DRW_LUPREC = 423
  Public Const LC_PROP_DRW_INSUNITS = 424
  Public Const LC_PROP_DRW_AUNITS = 425
  Public Const LC_PROP_DRW_AUPREC = 426
  Public Const LC_PROP_DRW_ANGBASE = 427
  Public Const LC_PROP_DRW_ANGDIR = 428
  Public Const LC_PROP_DRW_PDMODE = 429
  Public Const LC_PROP_DRW_PDSIZE = 430
  Public Const LC_PROP_DRW_COLOR = 501
  Public Const LC_PROP_DRW_BCOLOR = 502
  Public Const LC_PROP_DRW_COLORBYLAYER = 503
  Public Const LC_PROP_DRW_COLORBYBLOCK = 504
  Public Const LC_PROP_DRW_BCOLORBYLAYER = 505
  Public Const LC_PROP_DRW_BCOLORBYBLOCK = 506
  Public Const LC_PROP_DRW_COLORI = 507
  Public Const LC_PROP_DRW_COLORT = 508
  Public Const LC_PROP_DRW_BCOLORI = 509
  Public Const LC_PROP_DRW_BCOLORT = 510
  Public Const LC_PROP_DRW_LAYER = 511
  Public Const LC_PROP_DRW_LINETYPE = 512
  Public Const LC_PROP_DRW_LTSCALE = 513
  Public Const LC_PROP_DRW_TEXTSTYLE = 514
  Public Const LC_PROP_DRW_DIMSTYLE = 515
  Public Const LC_PROP_DRW_MLSTYLE = 516
  Public Const LC_PROP_DRW_VIEW = 517
  Public Const LC_PROP_DRW_LWEIGHT = 518
  Public Const LC_PROP_DRW_LWDEFAULT = 519
  Public Const LC_PROP_DRW_LWSCALE = 520
  Public Const LC_PROP_DRW_LWDISPLAY = 521
  Public Const LC_PROP_DRW_SYNCZOOM = 522
  Public Const LC_PROP_DRW_DESCR = 559
  Public Const LC_PROP_DRW_COMMENT = 559
  Public Const LC_PROP_DRW_INT0 = 560
  Public Const LC_PROP_DRW_INT1 = 561
  Public Const LC_PROP_DRW_INT2 = 562
  Public Const LC_PROP_DRW_INT3 = 563
  Public Const LC_PROP_DRW_INT4 = 564
  Public Const LC_PROP_DRW_INT5 = 565
  Public Const LC_PROP_DRW_INT6 = 566
  Public Const LC_PROP_DRW_INT7 = 567
  Public Const LC_PROP_DRW_INT8 = 568
  Public Const LC_PROP_DRW_INT9 = 569
  Public Const LC_PROP_DRW_FLOAT0 = 570
  Public Const LC_PROP_DRW_FLOAT1 = 571
  Public Const LC_PROP_DRW_FLOAT2 = 572
  Public Const LC_PROP_DRW_FLOAT3 = 573
  Public Const LC_PROP_DRW_FLOAT4 = 574
  Public Const LC_PROP_DRW_FLOAT5 = 575
  Public Const LC_PROP_DRW_FLOAT6 = 576
  Public Const LC_PROP_DRW_FLOAT7 = 577
  Public Const LC_PROP_DRW_FLOAT8 = 578
  Public Const LC_PROP_DRW_FLOAT9 = 579
  Public Const LC_PROP_DRW_STR0 = 580
  Public Const LC_PROP_DRW_STR1 = 581
  Public Const LC_PROP_DRW_STR2 = 582
  Public Const LC_PROP_DRW_STR3 = 583
  Public Const LC_PROP_DRW_STR4 = 584
  Public Const LC_PROP_DRW_STR5 = 585
  Public Const LC_PROP_DRW_STR6 = 586
  Public Const LC_PROP_DRW_STR7 = 587
  Public Const LC_PROP_DRW_STR8 = 588
  Public Const LC_PROP_DRW_STR9 = 589
  Public Const LC_PROP_DRW_XDATASIZE = 590
  Public Const LC_PROP_DRW_XDATA = 591
  Public Const LC_PROP_DRW_HOCX = 598
  Public Const LC_PROP_DRW_DIRTY = 599
  Public Const LC_PROP_TABLE_ID = 1001
  Public Const LC_PROP_TABLE_NAME = 1002
  Public Const LC_PROP_TABLE_DESC = 1003
  Public Const LC_PROP_TABLE_DESCR = 1003
  Public Const LC_PROP_TABLE_DELETED = 1004
  Public Const LC_PROP_TABLE_DRW = 1005
  Public Const LC_PROP_TABLE_ODHANDLE = 1005
  Public Const LC_PROP_TABLE_PRIORITY = 1006
  Public Const LC_PROP_TABLE_XDATASIZE = 1007
  Public Const LC_PROP_TABLE_XDATA = 1008
  Public Const LC_PROP_TABLE_XSTR = 1009
  Public Const LC_PROP_TABLE_INT0 = 1010
  Public Const LC_PROP_TABLE_INT1 = 1011
  Public Const LC_PROP_TABLE_INT2 = 1012
  Public Const LC_PROP_TABLE_INT3 = 1013
  Public Const LC_PROP_TABLE_INT4 = 1014
  Public Const LC_PROP_TABLE_FLOAT0 = 1015
  Public Const LC_PROP_TABLE_FLOAT1 = 1016
  Public Const LC_PROP_TABLE_FLOAT2 = 1017
  Public Const LC_PROP_TABLE_FLOAT3 = 1018
  Public Const LC_PROP_TABLE_FLOAT4 = 1019
  Public Const LC_PROP_LAYER_ID = 1021
  Public Const LC_PROP_LAYER_NAME = 1022
  Public Const LC_PROP_LAYER_DESC = 1023
  Public Const LC_PROP_LAYER_DELETED = 1024
  Public Const LC_PROP_LAYER_COLOR = 1025
  Public Const LC_PROP_LAYER_BCOLOR = 1026
  Public Const LC_PROP_LAYER_COLORI = 1027
  Public Const LC_PROP_LAYER_COLORT = 1028
  Public Const LC_PROP_LAYER_BCOLORI = 1029
  Public Const LC_PROP_LAYER_BCOLORT = 1030
  Public Const LC_PROP_LAYER_LINETYPE = 1031
  Public Const LC_PROP_LAYER_LWEIGHT = 1032
  Public Const LC_PROP_LAYER_LOCKED = 1033
  Public Const LC_PROP_LAYER_NOPRINT = 1034
  Public Const LC_PROP_LAYER_VISIBLE = 1035
  Public Const LC_PROP_LAYER_0 = 1036
  Public Const LC_PROP_LAYER_DRW = 1037
  Public Const LC_PROP_LAYER_NODLG = 1038
  Public Const LC_PROP_LINETYPE_ID = 1041
  Public Const LC_PROP_LINETYPE_NAME = 1042
  Public Const LC_PROP_LINETYPE_DESC = 1043
  Public Const LC_PROP_LINETYPE_DELETED = 1044
  Public Const LC_PROP_LINETYPE_DATA = 1045
  Public Const LC_PROP_LINETYPE_SCALE = 1046
  Public Const LC_PROP_LINETYPE_CONTINUOUS = 1047
  Public Const LC_PROP_LINETYPE_BYLAYER = 1048
  Public Const LC_PROP_LINETYPE_BYBLOCK = 1049
  Public Const LC_PROP_LINETYPE_STD = 1050
  Public Const LC_PROP_LINETYPE_PATLEN = 1051
  Public Const LC_PROP_LINETYPE_DRW = 1052
  Public Const LC_PROP_LINETYPE_NELEM = 1053
  Public Const LC_PROP_LINETYPE_IELEM = 1054
  Public Const LC_PROP_LTELEM_LEN = 1055
  Public Const LC_PROP_LTELEM_COMPLEX = 1056
  Public Const LC_PROP_LTELEM_SHAPE = 1057
  Public Const LC_PROP_LTELEM_TEXT = 1058
  Public Const LC_PROP_LTELEM_STYLE = 1059
  Public Const LC_PROP_LTELEM_FONTNAME = 1060
  Public Const LC_PROP_LTELEM_SCALE = 1061
  Public Const LC_PROP_LTELEM_ANGLE = 1062
  Public Const LC_PROP_LTELEM_ABSANGLE = 1063
  Public Const LC_PROP_LTELEM_X = 1064
  Public Const LC_PROP_LTELEM_Y = 1065
  Public Const LC_PROP_TSTYLE_ID = 1071
  Public Const LC_PROP_TSTYLE_NAME = 1072
  Public Const LC_PROP_TSTYLE_DESC = 1073
  Public Const LC_PROP_TSTYLE_DELETED = 1074
  Public Const LC_PROP_TSTYLE_FONT = 1075
  Public Const LC_PROP_TSTYLE_HEIGHT = 1076
  Public Const LC_PROP_TSTYLE_WSCALE = 1077
  Public Const LC_PROP_TSTYLE_OBLIQUE = 1078
  Public Const LC_PROP_TSTYLE_ANGLE = 1079
  Public Const LC_PROP_TSTYLE_ALIGN = 1080
  Public Const LC_PROP_TSTYLE_UPDOWN = 1081
  Public Const LC_PROP_TSTYLE_BACKWARD = 1082
  Public Const LC_PROP_TSTYLE_LINESPACE = 1083
  Public Const LC_PROP_TSTYLE_CHARSPACE = 1084
  Public Const LC_PROP_TSTYLE_STANDARD = 1085
  Public Const LC_PROP_TSTYLE_SHAPES = 1086
  Public Const LC_PROP_TSTYLE_WINFONT = 1087
  Public Const LC_PROP_TSTYLE_BOLD = 1088
  Public Const LC_PROP_TSTYLE_ITALIC = 1089
  Public Const LC_PROP_TSTYLE_UNDERLINE = 1090
  Public Const LC_PROP_TSTYLE_STRIKEOUT = 1091
  Public Const LC_PROP_TSTYLE_DRW = 1092
  Public Const LC_PROP_DIMST_ID = 1101
  Public Const LC_PROP_DIMST_NAME = 1102
  Public Const LC_PROP_DIMST_DESC = 1103
  Public Const LC_PROP_DIMST_DELETED = 1104
  Public Const LC_PROP_DIMST_STANDARD = 1114
  Public Const LC_PROP_DIMST_DRW = 1115
  Public Const LC_PROP_DIMST_TSTYLE = 1116
  Public Const LC_PROP_BLOCK_ID = 1131
  Public Const LC_PROP_BLOCK_NAME = 1132
  Public Const LC_PROP_BLOCK_DESC = 1133
  Public Const LC_PROP_BLOCK_DELETED = 1134
  Public Const LC_PROP_BLOCK_X = 1135
  Public Const LC_PROP_BLOCK_Y = 1136
  Public Const LC_PROP_BLOCK_Z = 1137
  Public Const LC_PROP_BLOCK_UFSCALING = 1138
  Public Const LC_PROP_BLOCK_UNITS = 1139
  Public Const LC_PROP_BLOCK_UNITSCALE = 1140
  Public Const LC_PROP_BLOCK_MODEL = 1141
  Public Const LC_PROP_BLOCK_PAPER = 1142
  Public Const LC_PROP_BLOCK_LAYOUT = 1143
  Public Const LC_PROP_BLOCK_STANDARD = 1144
  Public Const LC_PROP_BLOCK_HIDDEN = 1145
  Public Const LC_PROP_BLOCK_DIM = 1146
  Public Const LC_PROP_BLOCK_HATCH = 1147
  Public Const LC_PROP_BLOCK_DRW = 1148
  Public Const LC_PROP_BLOCK_NOBJ = 1149
  Public Const LC_PROP_BLOCK_NSELOBJ = 1150
  Public Const LC_PROP_BLOCK_ATTRIBS = 1157
  Public Const LC_PROP_BLOCK_BASE = 1159
  Public Const LC_PROP_VIEW_ID = 1161
  Public Const LC_PROP_VIEW_NAME = 1162
  Public Const LC_PROP_VIEW_DESC = 1163
  Public Const LC_PROP_VIEW_DELETED = 1164
  Public Const LC_PROP_VIEW_BLOCK = 1165
  Public Const LC_PROP_VIEW_MODEL = 1166
  Public Const LC_PROP_VIEW_PAPER = 1168
  Public Const LC_PROP_VIEW_XMIN = 1173
  Public Const LC_PROP_VIEW_YMIN = 1174
  Public Const LC_PROP_VIEW_XMAX = 1175
  Public Const LC_PROP_VIEW_YMAX = 1176
  Public Const LC_PROP_VIEW_LEF = 1177
  Public Const LC_PROP_VIEW_BOT = 1178
  Public Const LC_PROP_VIEW_RIG = 1179
  Public Const LC_PROP_VIEW_TOP = 1180
  Public Const LC_PROP_VIEW_PIXELSIZE = 1181
  Public Const LC_PROP_VIEW_PICKBOXSIZE = 1182
  Public Const LC_PROP_VIEW_LIMITS = 1185
  Public Const LC_PROP_VIEW_COLORBACK = 1186
  Public Const LC_PROP_VIEW_COLORFORE = 1187
  Public Const LC_PROP_VIEW_COLORCURSOR = 1188
  Public Const LC_PROP_VIEW_GRID = 1191
  Public Const LC_PROP_VIEW_GRIDSNAP = 1192
  Public Const LC_PROP_VIEW_OSNAP = 1193
  Public Const LC_PROP_VIEW_OSNAPMODE = 1194
  Public Const LC_PROP_VIEW_PTRACK = 1195
  Public Const LC_PROP_VIEW_ORTHO = 1196
  Public Const LC_PROP_VIEW_ORDER = 1230
  Public Const LC_PROP_VIEW_DRW = 1231
  Public Const LC_PROP_PAPER_SIZE = 1241
  Public Const LC_PROP_PAPER_ORIENT = 1242
  Public Const LC_PROP_PAPER_W = 1243
  Public Const LC_PROP_PAPER_H = 1244
  Public Const LC_PROP_PAPER_X0 = 1245
  Public Const LC_PROP_PAPER_Y0 = 1246
  Public Const LC_PROP_PAPER_INCH = 1247
  Public Const LC_PROP_IMAGE_ID = 1301
  Public Const LC_PROP_IMAGE_NAME = 1302
  Public Const LC_PROP_IMAGE_DESC = 1303
  Public Const LC_PROP_IMAGE_DELETED = 1304
  Public Const LC_PROP_IMAGE_FILENAME = 1305
  Public Const LC_PROP_IMAGE_SIZE = 1306
  Public Const LC_PROP_IMAGE_WPIX = 1307
  Public Const LC_PROP_IMAGE_HPIX = 1308
  Public Const LC_PROP_IMAGE_CBIT = 1309
  Public Const LC_PROP_IMAGE_DRW = 1310
  Public Const LC_PROP_ENT_ID = 3001
  Public Const LC_PROP_ENT_KEY = 3002
  Public Const LC_PROP_ENT_COLOR = 3003
  Public Const LC_PROP_ENT_BCOLOR = 3004
  Public Const LC_PROP_ENT_COLORBYLAYER = 3005
  Public Const LC_PROP_ENT_COLORBYBLOCK = 3006
  Public Const LC_PROP_ENT_BCOLORBYLAYER = 3007
  Public Const LC_PROP_ENT_BCOLORBYBLOCK = 3008
  Public Const LC_PROP_ENT_COLORI = 3009
  Public Const LC_PROP_ENT_COLORT = 3010
  Public Const LC_PROP_ENT_BCOLORI = 3011
  Public Const LC_PROP_ENT_BCOLORT = 3012
  Public Const LC_PROP_ENT_LAYER = 3013
  Public Const LC_PROP_ENT_LINETYPE = 3014
  Public Const LC_PROP_ENT_LTSCALE = 3015
  Public Const LC_PROP_ENT_LWEIGHT = 3016
  Public Const LC_PROP_ENT_BLOCK = 3017
  Public Const LC_PROP_ENT_DRW = 3018
  Public Const LC_PROP_ENT_BORDER = 3019
  Public Const LC_PROP_ENT_LOCKED = 3020
  Public Const LC_PROP_ENT_FILLED = 3021
  Public Const LC_PROP_ENT_VISIBLE = 3022
  Public Const LC_PROP_ENT_HIDDEN = 3023
  Public Const LC_PROP_ENT_BLINK = 3024
  Public Const LC_PROP_ENT_TYPE = 3025
  Public Const LC_PROP_ENT_DELETED = 3026
  Public Const LC_PROP_ENT_IMMORTAL = 3027
  Public Const LC_PROP_ENT_SELECTED = 3028
  Public Const LC_PROP_ENT_PRIORITY = 3029
  Public Const LC_PROP_ENT_XDATASIZE = 3031
  Public Const LC_PROP_ENT_XDATA = 3032
  Public Const LC_PROP_ENT_XSTR = 3033
  Public Const LC_PROP_ENT_XGUID = 3034
  Public Const LC_PROP_ENT_Z = 3035
  Public Const LC_PROP_POINT_X = 3102
  Public Const LC_PROP_POINT_Y = 3103
  Public Const LC_PROP_POINT_OWNSTYLE = 3105
  Public Const LC_PROP_POINT_SIZE = 3106
  Public Const LC_PROP_POINT_MODE = 3107
  Public Const LC_PROP_POINT_BORDER = 3108
  Public Const LC_PROP_POINT_POS = 3109
  Public Const LC_PROP_LINE_X0 = 3121
  Public Const LC_PROP_LINE_Y0 = 3122
  Public Const LC_PROP_LINE_X1 = 3124
  Public Const LC_PROP_LINE_Y1 = 3125
  Public Const LC_PROP_LINE_DX = 3127
  Public Const LC_PROP_LINE_DY = 3128
  Public Const LC_PROP_LINE_ANG = 3130
  Public Const LC_PROP_LINE_LEN = 3131
  Public Const LC_PROP_LINE_START = 3132
  Public Const LC_PROP_LINE_END = 3133
  Public Const LC_PROP_XLINE_X0 = 3141
  Public Const LC_PROP_XLINE_Y0 = 3142
  Public Const LC_PROP_XLINE_ANG = 3144
  Public Const LC_PROP_XLINE_DIRX = 3145
  Public Const LC_PROP_XLINE_DIRY = 3146
  Public Const LC_PROP_XLINE_RAY = 3147
  Public Const LC_PROP_XLINE_BASE = 3148
  Public Const LC_PROP_CIRCLE_X = 3201
  Public Const LC_PROP_CIRCLE_Y = 3202
  Public Const LC_PROP_CIRCLE_RAD = 3204
  Public Const LC_PROP_CIRCLE_DIAM = 3205
  Public Const LC_PROP_CIRCLE_LEN = 3206
  Public Const LC_PROP_CIRCLE_AREA = 3207
  Public Const LC_PROP_CIRCLE_FILLED = 3208
  Public Const LC_PROP_CIRCLE_BORDER = 3209
  Public Const LC_PROP_CIRCLE_CENTER = 3210
  Public Const LC_PROP_ARC_X = 3231
  Public Const LC_PROP_ARC_Y = 3232
  Public Const LC_PROP_ARC_RAD = 3234
  Public Const LC_PROP_ARC_ANG0 = 3235
  Public Const LC_PROP_ARC_ANGARC = 3236
  Public Const LC_PROP_ARC_ANGEND = 3237
  Public Const LC_PROP_ARC_X0 = 3238
  Public Const LC_PROP_ARC_Y0 = 3239
  Public Const LC_PROP_ARC_XEND = 3241
  Public Const LC_PROP_ARC_YEND = 3242
  Public Const LC_PROP_ARC_LEN = 3244
  Public Const LC_PROP_ARC_CHLEN = 3245
  Public Const LC_PROP_ARC_AREA = 3246
  Public Const LC_PROP_ARC_FILLED = 3247
  Public Const LC_PROP_ARC_BORDER = 3248
  Public Const LC_PROP_ARC_SECTOR = 3249
  Public Const LC_PROP_ARC_CENTER = 3250
  Public Const LC_PROP_ELL_X = 3261
  Public Const LC_PROP_ELL_Y = 3262
  Public Const LC_PROP_ELL_R1 = 3264
  Public Const LC_PROP_ELL_R2 = 3265
  Public Const LC_PROP_ELL_ANGLE = 3266
  Public Const LC_PROP_ELL_ANG0 = 3267
  Public Const LC_PROP_ELL_ANGARC = 3268
  Public Const LC_PROP_ELL_ANGEND = 3269
  Public Const LC_PROP_ELL_X0 = 3270
  Public Const LC_PROP_ELL_Y0 = 3271
  Public Const LC_PROP_ELL_XEND = 3273
  Public Const LC_PROP_ELL_YEND = 3274
  Public Const LC_PROP_ELL_LEN = 3276
  Public Const LC_PROP_ELL_AREA = 3277
  Public Const LC_PROP_ELL_FILLED = 3278
  Public Const LC_PROP_ELL_BORDER = 3279
  Public Const LC_PROP_ELL_SECTOR = 3280
  Public Const LC_PROP_ELL_CENTER = 3281
  Public Const LC_PROP_PLINE_FIT = 3301
  Public Const LC_PROP_PLINE_NVERS = 3302
  Public Const LC_PROP_PLINE_NPATHS = 3303
  Public Const LC_PROP_PLINE_WIDTH = 3305
  Public Const LC_PROP_PLINE_RADIUS = 3306
  Public Const LC_PROP_PLINE_CHAMFER = 3307
  Public Const LC_PROP_PLINE_LEN = 3308
  Public Const LC_PROP_PLINE_AREA = 3309
  Public Const LC_PROP_PLINE_CLOSED = 3310
  Public Const LC_PROP_PLINE_FILLED = 3311
  Public Const LC_PROP_PLINE_BORDER = 3312
  Public Const LC_PROP_PLINE_HASANG0 = 3313
  Public Const LC_PROP_PLINE_ANG0 = 3314
  Public Const LC_PROP_PLINE_HASANG2 = 3315
  Public Const LC_PROP_PLINE_ANG2 = 3316
  Public Const LC_PROP_MLINE_STYLE = 3351
  Public Const LC_PROP_MLINE_JUST = 3352
  Public Const LC_PROP_MLINE_SCALE = 3353
  Public Const LC_PROP_MLINE_NVERS = 3354
  Public Const LC_PROP_MLINE_CLOSED = 3355
  Public Const LC_PROP_MLINE_FIT = 3356
  Public Const LC_PROP_MLINE_LEN = 3357
  Public Const LC_PROP_MLINE_AREA = 3358
  Public Const LC_PROP_RECT_X = 3371
  Public Const LC_PROP_RECT_Y = 3372
  Public Const LC_PROP_RECT_W = 3374
  Public Const LC_PROP_RECT_H = 3375
  Public Const LC_PROP_RECT_ANGLE = 3376
  Public Const LC_PROP_RECT_RAD = 3377
  Public Const LC_PROP_RECT_CHAMFER = 3378
  Public Const LC_PROP_RECT_FILLED = 3379
  Public Const LC_PROP_RECT_BORDER = 3380
  Public Const LC_PROP_RECT_LEN = 3381
  Public Const LC_PROP_RECT_AREA = 3382
  Public Const LC_PROP_RECT_CENTER = 3383
  Public Const LC_PROP_TEXT_STYLE = 3401
  Public Const LC_PROP_TEXT_STR = 3402
  Public Const LC_PROP_TEXT_LEN = 3403
  Public Const LC_PROP_TEXT_ALIGN = 3404
  Public Const LC_PROP_TEXT_X = 3405
  Public Const LC_PROP_TEXT_Y = 3406
  Public Const LC_PROP_TEXT_H = 3411
  Public Const LC_PROP_TEXT_WSCALE = 3412
  Public Const LC_PROP_TEXT_ANGLE = 3413
  Public Const LC_PROP_TEXT_OBLIQUE = 3414
  Public Const LC_PROP_TEXT_CHARSPACE = 3415
  Public Const LC_PROP_TEXT_WRECT = 3416
  Public Const LC_PROP_TEXT_X0 = 3417
  Public Const LC_PROP_TEXT_Y0 = 3418
  Public Const LC_PROP_TEXT_XFIT = 3419
  Public Const LC_PROP_TEXT_YFIT = 3420
  Public Const LC_PROP_TEXT_UPDOWN = 3421
  Public Const LC_PROP_TEXT_BACKWARD = 3422
  Public Const LC_PROP_TEXT_POS = 3423
  Public Const LC_PROP_TEXT_FIT = 3424
  Public Const LC_PROP_TEXTW_STYLE = 3431
  Public Const LC_PROP_TEXTW_STR = 3432
  Public Const LC_PROP_TEXTW_LEN = 3433
  Public Const LC_PROP_TEXTW_ALIGN = 3434
  Public Const LC_PROP_TEXTW_X = 3435
  Public Const LC_PROP_TEXTW_Y = 3436
  Public Const LC_PROP_TEXTW_H = 3438
  Public Const LC_PROP_TEXTW_PIXH = 3439
  Public Const LC_PROP_TEXTW_LABEL = 3439
  Public Const LC_PROP_TEXTW_DX = 3440
  Public Const LC_PROP_TEXTW_DY = 3441
  Public Const LC_PROP_TEXTW_WSCALE = 3442
  Public Const LC_PROP_TEXTW_ANGLE = 3443
  Public Const LC_PROP_TEXTW_POS = 3444
  Public Const LC_PROP_TEXTW_OFFSET = 3445
  Public Const LC_PROP_MTEXT_STYLE = 3451
  Public Const LC_PROP_MTEXT_STR = 3452
  Public Const LC_PROP_MTEXT_LEN = 3453
  Public Const LC_PROP_MTEXT_ALIGN = 3454
  Public Const LC_PROP_MTEXT_X = 3455
  Public Const LC_PROP_MTEXT_Y = 3456
  Public Const LC_PROP_MTEXT_H = 3458
  Public Const LC_PROP_MTEXT_WSCALE = 3459
  Public Const LC_PROP_MTEXT_ANGLE = 3460
  Public Const LC_PROP_MTEXT_OBLIQUE = 3461
  Public Const LC_PROP_MTEXT_WRECT = 3462
  Public Const LC_PROP_MTEXT_HRECT = 3463
  Public Const LC_PROP_MTEXT_WRAPWIDTH = 3464
  Public Const LC_PROP_MTEXT_LINESPACE = 3465
  Public Const LC_PROP_MTEXT_CHARSPACE = 3466
  Public Const LC_PROP_MTEXT_MIRROR = 3467
  Public Const LC_PROP_MTEXT_POS = 3468
  Public Const LC_PROP_ATEXT_STYLE = 3481
  Public Const LC_PROP_ATEXT_STR = 3482
  Public Const LC_PROP_ATEXT_LEN = 3483
  Public Const LC_PROP_ATEXT_X = 3484
  Public Const LC_PROP_ATEXT_Y = 3485
  Public Const LC_PROP_ATEXT_RADIUS = 3487
  Public Const LC_PROP_ATEXT_ANGLE = 3488
  Public Const LC_PROP_ATEXT_CW = 3489
  Public Const LC_PROP_ATEXT_H = 3490
  Public Const LC_PROP_ATEXT_WSCALE = 3491
  Public Const LC_PROP_ATEXT_CHARSPACE = 3492
  Public Const LC_PROP_ATEXT_ALIGN = 3493
  Public Const LC_PROP_ATEXT_POS = 3494
  Public Const LC_PROP_ATT_MODE = 3501
  Public Const LC_PROP_ATT_STYLE = 3502
  Public Const LC_PROP_ATT_TAG = 3503
  Public Const LC_PROP_ATT_PROMPT = 3504
  Public Const LC_PROP_ATT_VALUE = 3505
  Public Const LC_PROP_ATT_ALIGN = 3506
  Public Const LC_PROP_ATT_X = 3507
  Public Const LC_PROP_ATT_Y = 3508
  Public Const LC_PROP_ATT_Z = 3509
  Public Const LC_PROP_ATT_H = 3510
  Public Const LC_PROP_ATT_WSCALE = 3511
  Public Const LC_PROP_ATT_ANGLE = 3512
  Public Const LC_PROP_ATT_OBLIQUE = 3513
  Public Const LC_PROP_ATT_X0 = 3514
  Public Const LC_PROP_ATT_Y0 = 3515
  Public Const LC_PROP_ATT_XFIT = 3516
  Public Const LC_PROP_ATT_YFIT = 3517
  Public Const LC_PROP_ATT_UPDOWN = 3518
  Public Const LC_PROP_ATT_BACKWARD = 3519
  Public Const LC_PROP_ATT_POS = 3520
  Public Const LC_PROP_ATT_FIT = 3521
  Public Const LC_PROP_BLKREF_BLOCK = 3531
  Public Const LC_PROP_BLKREF_X = 3532
  Public Const LC_PROP_BLKREF_Y = 3533
  Public Const LC_PROP_BLKREF_SCALE = 3535
  Public Const LC_PROP_BLKREF_SCX = 3536
  Public Const LC_PROP_BLKREF_SCY = 3537
  Public Const LC_PROP_BLKREF_UFSCALE = 3539
  Public Const LC_PROP_BLKREF_ANGLE = 3540
  Public Const LC_PROP_BLKREF_ATTRIBS = 3541
  Public Const LC_PROP_BLKREF_POS = 3542
  Public Const LC_PROP_IMGREF_IMAGE = 3551
  Public Const LC_PROP_IMGREF_X = 3552
  Public Const LC_PROP_IMGREF_Y = 3553
  Public Const LC_PROP_IMGREF_XC = 3554
  Public Const LC_PROP_IMGREF_YC = 3555
  Public Const LC_PROP_IMGREF_W = 3556
  Public Const LC_PROP_IMGREF_H = 3557
  Public Const LC_PROP_IMGREF_SCALE = 3558
  Public Const LC_PROP_IMGREF_SCX = 3559
  Public Const LC_PROP_IMGREF_SCY = 3560
  Public Const LC_PROP_IMGREF_ANGLE = 3561
  Public Const LC_PROP_IMGREF_UFSCALE = 3562
  Public Const LC_PROP_IMGREF_BORDER = 3563
  Public Const LC_PROP_IMGREF_POS = 3564
  Public Const LC_PROP_IMGREF_PATH = 3566
  Public Const LC_PROP_VPORT_LEF = 3603
  Public Const LC_PROP_VPORT_BOT = 3604
  Public Const LC_PROP_VPORT_RIG = 3605
  Public Const LC_PROP_VPORT_TOP = 3606
  Public Const LC_PROP_VPORT_W = 3607
  Public Const LC_PROP_VPORT_H = 3608
  Public Const LC_PROP_VPORT_VX = 3609
  Public Const LC_PROP_VPORT_VY = 3610
  Public Const LC_PROP_VPORT_VSCALE = 3611
  Public Const LC_PROP_VPORT_VANGLE = 3612
  Public Const LC_PROP_VPORT_FIXSCALE = 3613
  Public Const LC_PROP_VPORT_NFL = 3614
  Public Const LC_PROP_VPORT_RECT = 3615
  Public Const LC_PROP_VPORT_VRECT = 3616
  Public Const LC_PROP_HATCH_NAME = 3631
  Public Const LC_PROP_HATCH_PATTERN = 3632
  Public Const LC_PROP_HATCH_SCALE = 3633
  Public Const LC_PROP_HATCH_ANGLE = 3634
  Public Const LC_PROP_HATCH_SIZE = 3635
  Public Const LC_PROP_HATCH_ASSOC = 3636
  Public Const LC_PROP_HATCH_SOLID = 3637
  Public Const LC_PROP_HATCH_CUSTOM = 3638
  Public Const LC_PROP_HATCH_NPT = 3639
  Public Const LC_PROP_HATCH_NLOOP = 3640
  Public Const LC_PROP_HATCH_NHPL = 3641
  Public Const LC_PROP_HATCH_IHPL = 3642
  Public Const LC_PROP_HPL_ANGLE = 3651
  Public Const LC_PROP_HPL_X0 = 3652
  Public Const LC_PROP_HPL_Y0 = 3653
  Public Const LC_PROP_HPL_DX = 3654
  Public Const LC_PROP_HPL_DY = 3655
  Public Const LC_PROP_HPL_NDASH = 3656
  Public Const LC_PROP_HPL_DASH1 = 3657
  Public Const LC_PROP_HPL_DASH2 = 3658
  Public Const LC_PROP_HPL_DASH3 = 3659
  Public Const LC_PROP_HPL_DASH4 = 3660
  Public Const LC_PROP_HPL_DASH5 = 3661
  Public Const LC_PROP_HPL_DASH6 = 3662
  Public Const LC_PROP_HPL_DASH7 = 3663
  Public Const LC_PROP_HPL_DASH8 = 3664
  Public Const LC_PROP_ECW_FILENAME = 3901
  Public Const LC_PROP_ECW_LOADED = 3902
  Public Const LC_PROP_ECW_XMIN = 3903
  Public Const LC_PROP_ECW_YMIN = 3904
  Public Const LC_PROP_ECW_XMAX = 3905
  Public Const LC_PROP_ECW_YMAX = 3906
  Public Const LC_PROP_ECW_W = 3907
  Public Const LC_PROP_ECW_H = 3908
  Public Const LC_PROP_ECW_WPIX = 3909
  Public Const LC_PROP_ECW_HPIX = 3910
  Public Const LC_PROP_ECW_CBIT = 3911
  Public Const LC_PROP_ECW_SCALEX = 3912
  Public Const LC_PROP_ECW_SCALEY = 3913
  Public Const LC_PROP_ECW_BORDER = 3914
  Public Const LC_PROP_DIM_STYLE = 4001
  Public Const LC_PROP_DIM_MEAS = 4003
  Public Const LC_PROP_DIM_TEXT = 4004
  Public Const LC_PROP_DIMANG_STYLE = 4001
  Public Const LC_PROP_DIMANG_Z = 4002
  Public Const LC_PROP_DIMANG_MEAS = 4003
  Public Const LC_PROP_DIMANG_TEXT = 4004
  Public Const LC_PROP_DIMALI_STYLE = 4001
  Public Const LC_PROP_DIMALI_MEAS = 4003
  Public Const LC_PROP_DIMALI_TEXT = 4004
  Public Const LC_PROP_DIMDIA_STYLE = 4001
  Public Const LC_PROP_DIMDIA_MEAS = 4003
  Public Const LC_PROP_DIMDIA_TEXT = 4004
  Public Const LC_PROP_DIMRAD_STYLE = 4001
  Public Const LC_PROP_DIMRAD_MEAS = 4003
  Public Const LC_PROP_DIMRAD_TEXT = 4004
  Public Const LC_PROP_DIMORD_STYLE = 4001
  Public Const LC_PROP_DIMORD_MEAS = 4003
  Public Const LC_PROP_DIMORD_TEXT = 4004
  Public Const LC_PROP_DIMROT_STYLE = 4001
  Public Const LC_PROP_DIMROT_MEAS = 4003
  Public Const LC_PROP_DIMROT_TEXT = 4004
  Public Const LC_PROP_DIMANG_CPX = 4021
  Public Const LC_PROP_DIMANG_CPY = 4022
  Public Const LC_PROP_DIMANG_DP1X = 4023
  Public Const LC_PROP_DIMANG_DP1Y = 4024
  Public Const LC_PROP_DIMANG_DP2X = 4025
  Public Const LC_PROP_DIMANG_DP2Y = 4026
  Public Const LC_PROP_DIMANG_DP3X = 4027
  Public Const LC_PROP_DIMANG_DP3Y = 4028
  Public Const LC_PROP_DIMANG_DP4X = 4029
  Public Const LC_PROP_DIMANG_DP4Y = 4030
  Public Const LC_PROP_DIMANG_APX = 4031
  Public Const LC_PROP_DIMANG_APY = 4032
  Public Const LC_PROP_DIMANG_EXT1 = 4033
  Public Const LC_PROP_DIMANG_EXT2 = 4034
  Public Const LC_PROP_DIMANG_RAD = 4035
  Public Const LC_PROP_DIMANG_TPOS = 4036
  Public Const LC_PROP_DIMANG_CP = 4037
  Public Const LC_PROP_DIMANG_DP1 = 4038
  Public Const LC_PROP_DIMANG_DP2 = 4039
  Public Const LC_PROP_DIMANG_DP3 = 4040
  Public Const LC_PROP_DIMANG_DP4 = 4041
  Public Const LC_PROP_DIMANG_AP = 4042
  Public Const LC_PROP_DIMANG_TP = 4043
  Public Const LC_PROP_DIMALI_DP1X = 4051
  Public Const LC_PROP_DIMALI_DP1Y = 4052
  Public Const LC_PROP_DIMALI_DP2X = 4053
  Public Const LC_PROP_DIMALI_DP2Y = 4054
  Public Const LC_PROP_DIMALI_TPX = 4055
  Public Const LC_PROP_DIMALI_TPY = 4056
  Public Const LC_PROP_DIMALI_DP1 = 4057
  Public Const LC_PROP_DIMALI_DP2 = 4058
  Public Const LC_PROP_DIMALI_TP = 4059
  Public Const LC_PROP_DIMDIA_CPX = 4071
  Public Const LC_PROP_DIMDIA_CPY = 4072
  Public Const LC_PROP_DIMDIA_RPX = 4073
  Public Const LC_PROP_DIMDIA_RPY = 4074
  Public Const LC_PROP_DIMDIA_TPX = 4075
  Public Const LC_PROP_DIMDIA_TPY = 4076
  Public Const LC_PROP_DIMDIA_CP = 4077
  Public Const LC_PROP_DIMDIA_RP = 4078
  Public Const LC_PROP_DIMDIA_TP = 4079
  Public Const LC_PROP_DIMRAD_CPX = 4086
  Public Const LC_PROP_DIMRAD_CPY = 4087
  Public Const LC_PROP_DIMRAD_RPX = 4088
  Public Const LC_PROP_DIMRAD_RPY = 4089
  Public Const LC_PROP_DIMRAD_TPX = 4090
  Public Const LC_PROP_DIMRAD_TPY = 4091
  Public Const LC_PROP_DIMRAD_CP = 4092
  Public Const LC_PROP_DIMRAD_RP = 4093
  Public Const LC_PROP_DIMRAD_TP = 4094
  Public Const LC_PROP_DIMORD_XORD = 4101
  Public Const LC_PROP_DIMORD_DPX = 4102
  Public Const LC_PROP_DIMORD_DPY = 4103
  Public Const LC_PROP_DIMORD_TPX = 4104
  Public Const LC_PROP_DIMORD_TPY = 4105
  Public Const LC_PROP_DIMORD_DP = 4106
  Public Const LC_PROP_DIMORD_TP = 4107
  Public Const LC_PROP_DIMROT_ANGLE = 4121
  Public Const LC_PROP_DIMROT_DP1X = 4122
  Public Const LC_PROP_DIMROT_DP1Y = 4123
  Public Const LC_PROP_DIMROT_DP2X = 4124
  Public Const LC_PROP_DIMROT_DP2Y = 4125
  Public Const LC_PROP_DIMROT_TPX = 4126
  Public Const LC_PROP_DIMROT_TPY = 4127
  Public Const LC_PROP_DIMROT_DP1 = 4128
  Public Const LC_PROP_DIMROT_DP2 = 4129
  Public Const LC_PROP_DIMROT_TP = 4130
  Public Const LC_PROP_LEADER_STYLE = 4502
  Public Const LC_PROP_LEADER_TEXT = 4503
  Public Const LC_PROP_LEADER_ALIGN = 4504
  Public Const LC_PROP_LEADER_TPX = 4505
  Public Const LC_PROP_LEADER_TPY = 4506
  Public Const LC_PROP_LEADER_APX = 4507
  Public Const LC_PROP_LEADER_APY = 4508
  Public Const LC_PROP_LEADER_LDIST = 4510
  Public Const LC_PROP_LEADER_VERT = 4511
  Public Const LC_PROP_LEADER_CORNER = 4512
  Public Const LC_PROP_LEADER_ATTACH = 4513
  Public Const LC_PROP_LEADER_TP = 4514
  Public Const LC_PROP_LEADER_AP = 4515
  Public Const LC_PROP_VER_X = 5001
  Public Const LC_PROP_VER_Y = 5002
  Public Const LC_PROP_VER_Z = 5003
  Public Const LC_PROP_VER_ENDPATH = 5005
  Public Const LC_PROP_VER_FIX = 5006
  Public Const LC_PROP_VER_RADIUS = 5007
  Public Const LC_PROP_VER_W0 = 5011
  Public Const LC_PROP_VER_W1 = 5012
  Public Const LC_PROP_VER_SEGDX = 5013
  Public Const LC_PROP_VER_SEGDY = 5014
  Public Const LC_PROP_VER_SEGANG = 5015
  Public Const LC_PROP_VER_SEGLEN = 5016
  Public Const LC_PROP_VER_BULGE = 5021
  Public Const LC_PROP_VER_POS = 5031
  Public Const LC_PROP_VER_PRM = 5032
  Public Const LC_PROP_CMD_ID = 5102
  Public Const LC_PROP_CMD_STEP = 5103
  Public Const LC_PROP_CMD_LCWND = 5104
  Public Const LC_PROP_CMD_HWND = 5105
  Public Const LC_PROP_CMD_DRW = 5106
  Public Const LC_PROP_CMD_BLOCK = 5107
  Public Const LC_PROP_CMD_VIEW = 5108
  Public Const LC_PROP_CMD_CURSORX = 5109
  Public Const LC_PROP_CMD_CURX = 5109
  Public Const LC_PROP_CMD_CURSORY = 5110
  Public Const LC_PROP_CMD_CURY = 5110
  Public Const LC_PROP_CMD_PIXELSIZE = 5111
  Public Const LC_PROP_CMD_PICKBOXSIZE = 5112
  Public Const LC_PROP_CMD_CURLEF = 5113
  Public Const LC_PROP_CMD_CURBOT = 5114
  Public Const LC_PROP_CMD_CURRIG = 5115
  Public Const LC_PROP_CMD_CURTOP = 5116
  Public Const LC_PROP_CMD_OSNAP = 5117
  Public Const LC_PROP_CMD_OSNAPONCE = 5118
  Public Const LC_PROP_CMD_NPOINTS = 5119
  Public Const LC_PROP_CMD_INT0 = 5120
  Public Const LC_PROP_CMD_INT1 = 5121
  Public Const LC_PROP_CMD_INT2 = 5122
  Public Const LC_PROP_CMD_INT3 = 5123
  Public Const LC_PROP_CMD_INT4 = 5124
  Public Const LC_PROP_CMD_INT5 = 5125
  Public Const LC_PROP_CMD_INT6 = 5126
  Public Const LC_PROP_CMD_INT7 = 5127
  Public Const LC_PROP_CMD_INT8 = 5128
  Public Const LC_PROP_CMD_INT9 = 5129
  Public Const LC_PROP_CMD_FLOAT0 = 5130
  Public Const LC_PROP_CMD_FLOAT1 = 5131
  Public Const LC_PROP_CMD_FLOAT2 = 5132
  Public Const LC_PROP_CMD_FLOAT3 = 5133
  Public Const LC_PROP_CMD_FLOAT4 = 5134
  Public Const LC_PROP_CMD_FLOAT5 = 5135
  Public Const LC_PROP_CMD_FLOAT6 = 5136
  Public Const LC_PROP_CMD_FLOAT7 = 5137
  Public Const LC_PROP_CMD_FLOAT8 = 5138
  Public Const LC_PROP_CMD_FLOAT9 = 5139
  Public Const LC_PROP_CMD_HAND0 = 5140
  Public Const LC_PROP_CMD_HAND1 = 5141
  Public Const LC_PROP_CMD_HAND2 = 5142
  Public Const LC_PROP_CMD_HAND3 = 5143
  Public Const LC_PROP_CMD_HAND4 = 5144
  Public Const LC_PROP_CMD_HAND5 = 5145
  Public Const LC_PROP_CMD_HAND6 = 5146
  Public Const LC_PROP_CMD_HAND7 = 5147
  Public Const LC_PROP_CMD_HAND8 = 5148
  Public Const LC_PROP_CMD_HAND9 = 5149
  Public Const LC_PROP_CMD_STR = 5150
  Public Const LC_PROP_CMDWND_ENABLE = 9001
  Public Const LC_PROP_PROPWND_ENABLE = 9002
  Public Const LC_PROP_PROPWND_DIVCOEF = 9003
  Public Const LC_MOD_ENT_PROP = 1
  Public Const LC_MOD_ENT_SET = 2
  Public Const LC_MOD_PLINE_ADDVER = 4
  Public Const LC_MOD_PLINE_INSVER = 5
  Public Const LC_MOD_PLINE_DELVER = 6
  Public Const LC_MOD_PLINE_REVERSE = 7
  Public Const LC_MOD_MLINE_ADDVER = 14
  Public Const LC_MOD_MLINE_INSVER = 15
  Public Const LC_MOD_MLINE_DELVER = 16
  Public Const LC_MOD_MLINE_REVERSE = 17
  Public Const LC_MOD_ENT_MOVE = 20
  Public Const LC_MOD_ENT_ROTATE = 21
  Public Const LC_MOD_ENT_SCALE = 22
  Public Const LC_MOD_ENT_MIRROR = 23
  Public Const LC_MOD_ENT_JOIN = 24
  Public Const LC_MOD_OBJ_PROP = 31
  Public Const LC_MOD_BLOCK_PURGE = 32
  Public Const LC_MOD_BLOCK_ADDENT = 33
  Public Const LC_MOD_DRW_PROP = 51

  Public Declare Unicode Function Initialize Lib "Litecad.dll" Alias "lcInitialize" (ByVal szConfigDir As String) As Integer

  Public Declare Function Uninitialize Lib "Litecad.dll" Alias "lcUninitialize" (ByVal bSaveConfig As Integer) As Integer

  Public Declare Unicode Function CfgGetValue Lib "Litecad.dll" Alias "lcCfgGetValue" (ByVal hCfg As Integer, ByVal szTag As String) As String

  Public Declare Unicode Function CfgSetValue Lib "Litecad.dll" Alias "lcCfgSetValue" (ByVal hCfg As Integer, ByVal szTagValue As String) As Integer

  Public Declare Unicode Function AddFontRes Lib "Litecad.dll" Alias "lcAddFontRes" (ByVal hModule As Integer, ByVal idResource As Integer, ByVal szFontName As String) As Integer

  Public Declare Unicode Function AddFontFile Lib "Litecad.dll" Alias "lcAddFontFile" (ByVal szFilename As String, ByVal szFontName As String) As Integer

  Public Declare Unicode Function AddFontBin Lib "Litecad.dll" Alias "lcAddFontBin" (ByVal hData As Integer, ByVal szFontName As String) As Integer

  Public Declare Unicode Function StrAdd Lib "Litecad.dll" Alias "lcStrAdd" (ByVal szTag As String, ByVal szText As String) As Integer

  Public Declare Unicode Function StrSet Lib "Litecad.dll" Alias "lcStrSet" (ByVal szTag As String, ByVal szText As String) As Integer

  Public Declare Unicode Function StrGet Lib "Litecad.dll" Alias "lcStrGet" (ByVal szTag As String) As String

  Public Declare Unicode Function StrFileLoad Lib "Litecad.dll" Alias "lcStrFileLoad" (ByVal szFileName As String) As Integer

  Public Declare Unicode Function StrFileSave Lib "Litecad.dll" Alias "lcStrFileSave" (ByVal szFileName As String, ByVal szLanguage As String, ByVal bInit As Integer) As Integer

  Public Declare Function PropGetBool Lib "Litecad.dll" Alias "lcPropGetBool" (ByVal hObject As Integer, ByVal idProp As Integer) As Integer

  Public Declare Function PropGetInt Lib "Litecad.dll" Alias "lcPropGetInt" (ByVal hObject As Integer, ByVal idProp As Integer) As Integer

  Public Declare Function PropGetFloat Lib "Litecad.dll" Alias "lcPropGetFloat" (ByVal hObject As Integer, ByVal idProp As Integer) As Double

  Public Declare Unicode Function PropGetStr Lib "Litecad.dll" Alias "lcPropGetStr" (ByVal hObject As Integer, ByVal idProp As Integer) As String

  Public Declare Function PropGetHandle Lib "Litecad.dll" Alias "lcPropGetHandle" (ByVal hObject As Integer, ByVal idProp As Integer) As Integer

  Public Declare Function PropPutBool Lib "Litecad.dll" Alias "lcPropPutBool" (ByVal hObject As Integer, ByVal idProp As Integer, ByVal bValue As Integer) As Integer

  Public Declare Function PropPutInt Lib "Litecad.dll" Alias "lcPropPutInt" (ByVal hObject As Integer, ByVal idProp As Integer, ByVal Value As Integer) As Integer

  Public Declare Function PropPutFloat Lib "Litecad.dll" Alias "lcPropPutFloat" (ByVal hObject As Integer, ByVal idProp As Integer, ByVal Value As Double) As Integer

  Public Declare Unicode Function PropPutStr Lib "Litecad.dll" Alias "lcPropPutStr" (ByVal hObject As Integer, ByVal idProp As Integer, ByVal szValue As String) As Integer

  Public Declare Function PropPutHandle Lib "Litecad.dll" Alias "lcPropPutHandle" (ByVal hObject As Integer, ByVal idProp As Integer, ByVal hValue As Integer) As Integer

  Public Declare Function CreateDrawing Lib "Litecad.dll" Alias "lcCreateDrawing" () As Integer

  Public Declare Function DeleteDrawing Lib "Litecad.dll" Alias "lcDeleteDrawing" (ByVal hDrw As Integer) As Integer

  Public Declare Unicode Function DrwNew Lib "Litecad.dll" Alias "lcDrwNew" (ByVal hDrw As Integer, ByVal szFileName As String, ByVal hLcWnd As Integer) As Integer

  Public Declare Unicode Function DrwNewT Lib "Litecad.dll" Alias "lcDrwNewT" (ByVal hDrw As Integer, ByVal szFileName As String, ByVal szTemplate As String, ByVal hLcWnd As Integer) As Integer

  Public Declare Unicode Function DrwLoad Lib "Litecad.dll" Alias "lcDrwLoad" (ByVal hDrw As Integer, ByVal szFileName As String, ByVal hWnd As Integer, ByVal hLcWnd As Integer) As Integer

  Public Declare Unicode Function DrwSave Lib "Litecad.dll" Alias "lcDrwSave" (ByVal hDrw As Integer, ByVal szFileName As String, ByVal bBak As Integer, ByVal hWnd As Integer) As Integer

  Public Declare Function DrwPurge Lib "Litecad.dll" Alias "lcDrwPurge" (ByVal hDrw As Integer) As Integer

  Public Declare Function DrwRegenViews Lib "Litecad.dll" Alias "lcDrwRegenViews" (ByVal hDrw As Integer, ByVal hEnt As Integer) As Integer

  Public Declare Function DrwSortObjects Lib "Litecad.dll" Alias "lcDrwSortObjects" (ByVal hDrw As Integer, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwClearXData Lib "Litecad.dll" Alias "lcDrwClearXData" (ByVal hDrw As Integer, ByVal ObjType As Integer, ByVal Mode As Integer) As Integer

  Public Declare Function DrwResolveBlocks Lib "Litecad.dll" Alias "lcDrwResolveBlocks" (ByVal hDrw As Integer, ByVal szError As Integer) As Integer

  Public Declare Unicode Function DrwAddLayer Lib "Litecad.dll" Alias "lcDrwAddLayer" (ByVal hDrw As Integer, ByVal szName As String, ByVal szColor As String, ByVal hLtype As Integer, ByVal Lweight As Integer) As Integer

  Public Declare Unicode Function DrwAddLinetype Lib "Litecad.dll" Alias "lcDrwAddLinetype" (ByVal hDrw As Integer, ByVal szName As String, ByVal szDefinition As String) As Integer

  Public Declare Unicode Function DrwAddLinetypeF Lib "Litecad.dll" Alias "lcDrwAddLinetypeF" (ByVal hDrw As Integer, ByVal szName As String, ByVal szFileName As String, ByVal szLtypeName As String) As Integer

  Public Declare Unicode Function DrwAddTextStyle Lib "Litecad.dll" Alias "lcDrwAddTextStyle" (ByVal hDrw As Integer, ByVal szName As String, ByVal szFontName As String) As Integer

  Public Declare Unicode Function DrwAddDimStyle Lib "Litecad.dll" Alias "lcDrwAddDimStyle" (ByVal hDrw As Integer, ByVal szName As String) As Integer

  Public Declare Unicode Function DrwAddImage Lib "Litecad.dll" Alias "lcDrwAddImage" (ByVal hDrw As Integer, ByVal szName As String, ByVal szFileName As String) As Integer

  Public Declare Unicode Function DrwAddBlock Lib "Litecad.dll" Alias "lcDrwAddBlock" (ByVal hDrw As Integer, ByVal szName As String, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Unicode Function DrwAddBlockFromFile Lib "Litecad.dll" Alias "lcDrwAddBlockFromFile" (ByVal hDrw As Integer, ByVal szName As String, ByVal szFileName As String, ByVal Overwrite As Integer, ByVal hwParent As Integer) As Integer

  Public Declare Unicode Function DrwAddBlockFromDrw Lib "Litecad.dll" Alias "lcDrwAddBlockFromDrw" (ByVal hDrw As Integer, ByVal szName As String, ByVal hDrw2 As Integer, ByVal Overwrite As Integer, ByVal hwParent As Integer) As Integer

  Public Declare Unicode Function DrwAddBlockFile Lib "Litecad.dll" Alias "lcDrwAddBlockFile" (ByVal hDrw As Integer, ByVal szName As String, ByVal szFileName As String, ByVal Overwrite As Integer, ByVal hwParent As Integer) As Integer

  Public Declare Unicode Function DrwAddViewPaper Lib "Litecad.dll" Alias "lcDrwAddViewPaper" (ByVal hDrw As Integer, ByVal szName As String, ByVal PaperSize As Integer, ByVal Orient As Integer, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function DrwDeleteObject Lib "Litecad.dll" Alias "lcDrwDeleteObject" (ByVal hDrw As Integer, ByVal hObject As Integer) As Integer

  Public Declare Function DrwGetFirstObject Lib "Litecad.dll" Alias "lcDrwGetFirstObject" (ByVal hDrw As Integer, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwGetNextObject Lib "Litecad.dll" Alias "lcDrwGetNextObject" (ByVal hDrw As Integer, ByVal hObject As Integer) As Integer

  Public Declare Function DrwGetObjectByID Lib "Litecad.dll" Alias "lcDrwGetObjectByID" (ByVal hDrw As Integer, ByVal ObjType As Integer, ByVal Id As Integer) As Integer

  Public Declare Unicode Function DrwGetObjectByIDH Lib "Litecad.dll" Alias "lcDrwGetObjectByIDH" (ByVal hDrw As Integer, ByVal ObjType As Integer, ByVal szId As String) As Integer

  Public Declare Unicode Function DrwGetObjectByName Lib "Litecad.dll" Alias "lcDrwGetObjectByName" (ByVal hDrw As Integer, ByVal ObjType As Integer, ByVal szName As String) As Integer

  Public Declare Function DrwCountObjects Lib "Litecad.dll" Alias "lcDrwCountObjects" (ByVal hDrw As Integer, ByVal ObjType As Integer) As Integer

  Public Declare Function DrwGetViewByBlock Lib "Litecad.dll" Alias "lcDrwGetViewByBlock" (ByVal hDrw As Integer, ByVal hBlock As Integer) As Integer

  Public Declare Function DrwGetEntByID Lib "Litecad.dll" Alias "lcDrwGetEntByID" (ByVal hDrw As Integer, ByVal Id As Integer) As Integer

  Public Declare Unicode Function DrwGetEntByIDH Lib "Litecad.dll" Alias "lcDrwGetEntByIDH" (ByVal hDrw As Integer, ByVal szId As String) As Integer

  Public Declare Function DrwGetEntByKey Lib "Litecad.dll" Alias "lcDrwGetEntByKey" (ByVal hDrw As Integer, ByVal Key As Integer) As Integer

  Public Declare Function ViewSetRect Lib "Litecad.dll" Alias "lcViewSetRect" (ByVal hView As Integer, ByVal Xcen As Double, ByVal Ycen As Double, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function ViewSetRect2 Lib "Litecad.dll" Alias "lcViewSetRect2" (ByVal hView As Integer, ByVal Lef As Double, ByVal Bot As Double, ByVal Rig As Double, ByVal Top As Double) As Integer

  Public Declare Function ViewSetLimits Lib "Litecad.dll" Alias "lcViewSetLimits" (ByVal hView As Integer, ByVal Xmin As Double, ByVal Ymin As Double, ByVal Xmax As Double, ByVal Ymax As Double) As Integer

  Public Declare Function ViewSetGrid Lib "Litecad.dll" Alias "lcViewSetGrid" (ByVal hView As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal dX As Double, ByVal dY As Double) As Integer

  Public Declare Function ViewRegen Lib "Litecad.dll" Alias "lcViewRegen" (ByVal hView As Integer, ByVal hEnt As Integer) As Integer

  Public Declare Function ViewSetPaperSize Lib "Litecad.dll" Alias "lcViewSetPaperSize" (ByVal hView As Integer, ByVal PaperSize As Integer, ByVal Orient As Integer, ByVal Width As Double, ByVal Height As Double) As Integer

  Public Declare Function ViewGetEntByPoint Lib "Litecad.dll" Alias "lcViewGetEntByPoint" (ByVal hView As Integer, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double, ByVal Mode As Integer) As Integer

  Public Declare Function ViewGetEntsByRect Lib "Litecad.dll" Alias "lcViewGetEntsByRect" (ByVal hView As Integer, ByVal Lef As Double, ByVal Bot As Double, ByVal Rig As Double, ByVal Top As Double, ByVal bCross As Integer, ByVal MaxNum As Integer) As Integer

  Public Declare Function ViewGetEntity Lib "Litecad.dll" Alias "lcViewGetEntity" (ByVal iEnt As Integer) As Integer

  Public Declare Unicode Function ViewRasterize Lib "Litecad.dll" Alias "lcViewRasterize" (ByVal hView As Integer, ByVal szFileName As String, ByVal Lef As Double, ByVal Bot As Double, ByVal Rig As Double, ByVal Top As Double, ByVal Scale As Double) As Integer

  Public Declare Function ViewDrawMarker Lib "Litecad.dll" Alias "lcViewDrawMarker" (ByVal hView As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function ViewDrawLine Lib "Litecad.dll" Alias "lcViewDrawLine" (ByVal hView As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double) As Integer

  Public Declare Function ViewDrawXline Lib "Litecad.dll" Alias "lcViewDrawXline" (ByVal hView As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal bRay As Integer) As Integer

  Public Declare Function ViewDrawRect Lib "Litecad.dll" Alias "lcViewDrawRect" (ByVal hView As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double) As Integer

  Public Declare Function BlockClear Lib "Litecad.dll" Alias "lcBlockClear" (ByVal hBlock As Integer, ByVal hLayer As Integer) As Integer

  Public Declare Function BlockPurge Lib "Litecad.dll" Alias "lcBlockPurge" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockSortEnts Lib "Litecad.dll" Alias "lcBlockSortEnts" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockAddPoint Lib "Litecad.dll" Alias "lcBlockAddPoint" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function BlockAddPoint2 Lib "Litecad.dll" Alias "lcBlockAddPoint2" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal PtMode As Integer, ByVal PtSize As Double) As Integer

  Public Declare Function BlockAddXline Lib "Litecad.dll" Alias "lcBlockAddXline" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal bRay As Integer) As Integer

  Public Declare Function BlockAddXline2P Lib "Litecad.dll" Alias "lcBlockAddXline2P" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bRay As Integer) As Integer

  Public Declare Function BlockAddLine Lib "Litecad.dll" Alias "lcBlockAddLine" (ByVal hBlock As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function BlockAddLineDir Lib "Litecad.dll" Alias "lcBlockAddLineDir" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Angle As Double, ByVal Dist As Double) As Integer

  Public Declare Function BlockAddLineTan Lib "Litecad.dll" Alias "lcBlockAddLineTan" (ByVal hBlock As Integer, ByVal hEnt1 As Integer, ByVal hEnt2 As Integer, ByVal Mode As Integer) As Integer

  Public Declare Function BlockAddPolyline Lib "Litecad.dll" Alias "lcBlockAddPolyline" (ByVal hBlock As Integer, ByVal FitType As Integer, ByVal bClosed As Integer, ByVal bFilled As Integer) As Integer

  Public Declare Function BlockAddRect Lib "Litecad.dll" Alias "lcBlockAddRect" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal Width As Double, ByVal Height As Double, ByVal Angle As Double, ByVal bFilled As Integer) As Integer

  Public Declare Function BlockAddRect2 Lib "Litecad.dll" Alias "lcBlockAddRect2" (ByVal hBlock As Integer, ByVal Left As Double, ByVal Bottom As Double, ByVal Width As Double, ByVal Height As Double, ByVal Rad As Double, ByVal bFilled As Integer) As Integer

  Public Declare Function BlockAddCircle Lib "Litecad.dll" Alias "lcBlockAddCircle" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal bFilled As Integer) As Integer

  Public Declare Function BlockAddArc Lib "Litecad.dll" Alias "lcBlockAddArc" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal StartAngle As Double, ByVal ArcAngle As Double) As Integer

  Public Declare Function BlockAddArc3P Lib "Litecad.dll" Alias "lcBlockAddArc3P" (ByVal hBlock As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double) As Integer

  Public Declare Function BlockAddEllipse Lib "Litecad.dll" Alias "lcBlockAddEllipse" (ByVal hBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal R1 As Double, ByVal R2 As Double, ByVal RotAngle As Double, ByVal StartAngle As Double, ByVal ArcAngle As Double) As Integer

  Public Declare Unicode Function BlockAddText Lib "Litecad.dll" Alias "lcBlockAddText" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Unicode Function BlockAddText2 Lib "Litecad.dll" Alias "lcBlockAddText2" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As Integer

  Public Declare Unicode Function BlockAddTextWin Lib "Litecad.dll" Alias "lcBlockAddTextWin" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Unicode Function BlockAddTextWin2 Lib "Litecad.dll" Alias "lcBlockAddTextWin2" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As Integer

  Public Declare Unicode Function BlockAddMText Lib "Litecad.dll" Alias "lcBlockAddMText" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal WrapWidth As Double, ByVal Align As Integer, ByVal RotAngle As Double, ByVal H As Double, ByVal WScale As Double) As Integer

  Public Declare Unicode Function BlockAddArcText Lib "Litecad.dll" Alias "lcBlockAddArcText" (ByVal hBlock As Integer, ByVal szText As String, ByVal X As Double, ByVal Y As Double, ByVal Radius As Double, ByVal StartAngle As Double, ByVal bClockwise As Integer, ByVal H As Double, ByVal WScale As Double) As Integer

  Public Declare Function BlockAddBlockRef Lib "Litecad.dll" Alias "lcBlockAddBlockRef" (ByVal hBlock As Integer, ByVal hRefBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Function BlockAddBlockRefID Lib "Litecad.dll" Alias "lcBlockAddBlockRefID" (ByVal hBlock As Integer, ByVal idRefBlock As Integer, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Unicode Function BlockAddBlockRefIDH Lib "Litecad.dll" Alias "lcBlockAddBlockRefIDH" (ByVal hBlock As Integer, ByVal szIdRefBlock As String, ByVal X As Double, ByVal Y As Double, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Function BlockAddImageRef Lib "Litecad.dll" Alias "lcBlockAddImageRef" (ByVal hBlock As Integer, ByVal hImage As Integer, ByVal X As Double, ByVal Y As Double, ByVal Width As Double, ByVal Height As Double, ByVal bBorder As Integer) As Integer

  Public Declare Unicode Function BlockAddEcw Lib "Litecad.dll" Alias "lcBlockAddEcw" (ByVal hBlock As Integer, ByVal szFileName As String) As Integer

  Public Declare Unicode Function BlockAddAttDef Lib "Litecad.dll" Alias "lcBlockAddAttDef" (ByVal hBlock As Integer, ByVal Mode As Integer, ByVal szTag As String, ByVal szPrompt As String, ByVal szDefVal As String, ByVal X As Double, ByVal Y As Double, ByVal Align As Integer, ByVal H As Double, ByVal WScale As Double, ByVal RotAngle As Double, ByVal Oblique As Double) As Integer

  Public Declare Unicode Function BlockAddHatch Lib "Litecad.dll" Alias "lcBlockAddHatch" (ByVal hBlock As Integer, ByVal szFileName As String, ByVal szPatName As String, ByVal Scal As Double, ByVal Angle As Double) As Integer

  Public Declare Function BlockAddViewport Lib "Litecad.dll" Alias "lcBlockAddViewport" (ByVal hBlock As Integer, ByVal Lef As Double, ByVal Bot As Double, ByVal Width As Double, ByVal Height As Double, ByVal DrwPntX As Double, ByVal DrwPntY As Double, ByVal DrwScale As Double, ByVal DrwAngle As Double) As Integer

  Public Declare Unicode Function BlockAddLeader Lib "Litecad.dll" Alias "lcBlockAddLeader" (ByVal hBlock As Integer, ByVal szText As String, ByVal Xt As Double, ByVal Yt As Double, ByVal LandDist As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal Attach As Integer, ByVal Align As Integer) As Integer

  Public Declare Unicode Function BlockAddDimRot Lib "Litecad.dll" Alias "lcBlockAddDimRot" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal Angle As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimHor Lib "Litecad.dll" Alias "lcBlockAddDimHor" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Yt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimVer Lib "Litecad.dll" Alias "lcBlockAddDimVer" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimAli Lib "Litecad.dll" Alias "lcBlockAddDimAli" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimAli2 Lib "Litecad.dll" Alias "lcBlockAddDimAli2" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Dt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimOrd Lib "Litecad.dll" Alias "lcBlockAddDimOrd" (ByVal hBlock As Integer, ByVal Xd As Double, ByVal Yd As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal bX As Integer, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimRad Lib "Litecad.dll" Alias "lcBlockAddDimRad" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal Xr As Double, ByVal Yr As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimRad2 Lib "Litecad.dll" Alias "lcBlockAddDimRad2" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Angle As Double, ByVal TextOff As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimDia Lib "Litecad.dll" Alias "lcBlockAddDimDia" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal Xr As Double, ByVal Yr As Double, ByVal Xt As Double, ByVal Yt As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimDia2 Lib "Litecad.dll" Alias "lcBlockAddDimDia2" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal R As Double, ByVal Angle As Double, ByVal TextOff As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimAng Lib "Litecad.dll" Alias "lcBlockAddDimAng" (ByVal hBlock As Integer, ByVal Xc As Double, ByVal Yc As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal TextPos As Double, ByVal szText As String) As Integer

  Public Declare Unicode Function BlockAddDimAng2 Lib "Litecad.dll" Alias "lcBlockAddDimAng2" (ByVal hBlock As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double, ByVal X4 As Double, ByVal Y4 As Double, ByVal Xa As Double, ByVal Ya As Double, ByVal TextPos As Double, ByVal szText As String) As Integer

  Public Declare Function BlockGetFirstEnt Lib "Litecad.dll" Alias "lcBlockGetFirstEnt" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockGetNextEnt Lib "Litecad.dll" Alias "lcBlockGetNextEnt" (ByVal hBlock As Integer, ByVal hEnt As Integer) As Integer

  Public Declare Function BlockGetLastEnt Lib "Litecad.dll" Alias "lcBlockGetLastEnt" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockGetPrevEnt Lib "Litecad.dll" Alias "lcBlockGetPrevEnt" (ByVal hBlock As Integer, ByVal hEnt As Integer) As Integer

  Public Declare Function BlockGetEntByID Lib "Litecad.dll" Alias "lcBlockGetEntByID" (ByVal hBlock As Integer, ByVal Id As Integer) As Integer

  Public Declare Unicode Function BlockGetEntByIDH Lib "Litecad.dll" Alias "lcBlockGetEntByIDH" (ByVal hBlock As Integer, ByVal szId As String) As Integer

  Public Declare Function BlockGetEntByKey Lib "Litecad.dll" Alias "lcBlockGetEntByKey" (ByVal hBlock As Integer, ByVal Key As Integer) As Integer

  Public Declare Function BlockUnselect Lib "Litecad.dll" Alias "lcBlockUnselect" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockSelectEnt Lib "Litecad.dll" Alias "lcBlockSelectEnt" (ByVal hBlock As Integer, ByVal hEntity As Integer, ByVal bSelect As Integer) As Integer

  Public Declare Function BlockSelErase Lib "Litecad.dll" Alias "lcBlockSelErase" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockSelMove Lib "Litecad.dll" Alias "lcBlockSelMove" (ByVal hBlock As Integer, ByVal dX As Double, ByVal dY As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelScale Lib "Litecad.dll" Alias "lcBlockSelScale" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Scal As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelRotate Lib "Litecad.dll" Alias "lcBlockSelRotate" (ByVal hBlock As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Angle As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelMirror Lib "Litecad.dll" Alias "lcBlockSelMirror" (ByVal hBlock As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bCopy As Integer, ByVal bNewSelect As Integer) As Integer

  Public Declare Function BlockSelExplode Lib "Litecad.dll" Alias "lcBlockSelExplode" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockSelJoin Lib "Litecad.dll" Alias "lcBlockSelJoin" (ByVal hBlock As Integer, ByVal Delta As Double) As Integer

  Public Declare Function BlockGetFirstSel Lib "Litecad.dll" Alias "lcBlockGetFirstSel" (ByVal hBlock As Integer) As Integer

  Public Declare Function BlockGetNextSel Lib "Litecad.dll" Alias "lcBlockGetNextSel" (ByVal hBlock As Integer) As Integer

  Public Declare Function EntErase Lib "Litecad.dll" Alias "lcEntErase" (ByVal hEnt As Integer, ByVal bErase As Integer) As Integer

  Public Declare Function EntMove Lib "Litecad.dll" Alias "lcEntMove" (ByVal hEnt As Integer, ByVal dX As Double, ByVal dY As Double) As Integer

  Public Declare Function EntScale Lib "Litecad.dll" Alias "lcEntScale" (ByVal hEnt As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Scal As Double) As Integer

  Public Declare Function EntRotate Lib "Litecad.dll" Alias "lcEntRotate" (ByVal hEnt As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Angle As Double) As Integer

  Public Declare Function EntMirror Lib "Litecad.dll" Alias "lcEntMirror" (ByVal hEnt As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Integer

  Public Declare Function EntExplode Lib "Litecad.dll" Alias "lcEntExplode" (ByVal hEnt As Integer, ByVal bSelect As Integer) As Integer

  Public Declare Function EntOffset Lib "Litecad.dll" Alias "lcEntOffset" (ByVal hEnt As Integer, ByVal Dist As Double) As Integer

  Public Declare Function EntToTop Lib "Litecad.dll" Alias "lcEntToTop" (ByVal hEnt As Integer) As Integer

  Public Declare Function EntToBottom Lib "Litecad.dll" Alias "lcEntToBottom" (ByVal hEnt As Integer) As Integer

  Public Declare Function EntToAbove Lib "Litecad.dll" Alias "lcEntToAbove" (ByVal hEnt As Integer, ByVal hEnt2 As Integer) As Integer

  Public Declare Function EntToUnder Lib "Litecad.dll" Alias "lcEntToUnder" (ByVal hEnt As Integer, ByVal hEnt2 As Integer) As Integer

  Public Declare Function EntGetGrip Lib "Litecad.dll" Alias "lcEntGetGrip" (ByVal hEnt As Integer, ByVal iGrip As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function EntPutGrip Lib "Litecad.dll" Alias "lcEntPutGrip" (ByVal hEnt As Integer, ByVal iGrip As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function EntUpdate Lib "Litecad.dll" Alias "lcEntUpdate" (ByVal hEnt As Integer) As Integer

  Public Declare Function Intersection Lib "Litecad.dll" Alias "lcIntersection" (ByVal hEnt As Integer, ByVal hEnt2 As Integer) As Integer

  Public Declare Function InterGetPoint Lib "Litecad.dll" Alias "lcInterGetPoint" (ByVal iPoint As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function PlineAddVer Lib "Litecad.dll" Alias "lcPlineAddVer" (ByVal hPline As Integer, ByVal hVer0 As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function PlineAddVer2 Lib "Litecad.dll" Alias "lcPlineAddVer2" (ByVal hPline As Integer, ByVal hVer0 As Integer, ByVal X As Double, ByVal Y As Double, ByVal Param As Double, ByVal W0 As Double, ByVal W1 As Double) As Integer

  Public Declare Function PlineAddVerDir Lib "Litecad.dll" Alias "lcPlineAddVerDir" (ByVal hPline As Integer, ByVal hVer0 As Integer, ByVal Ang As Double, ByVal Len As Double) As Integer

  Public Declare Function PlineDeleteVer Lib "Litecad.dll" Alias "lcPlineDeleteVer" (ByVal hPline As Integer, ByVal hVer As Integer) As Integer

  Public Declare Function PlineGetFirstVer Lib "Litecad.dll" Alias "lcPlineGetFirstVer" (ByVal hPline As Integer) As Integer

  Public Declare Function PlineGetNextVer Lib "Litecad.dll" Alias "lcPlineGetNextVer" (ByVal hPline As Integer, ByVal hVer As Integer) As Integer

  Public Declare Function PlineGetLastVer Lib "Litecad.dll" Alias "lcPlineGetLastVer" (ByVal hPline As Integer) As Integer

  Public Declare Function PlineGetPrevVer Lib "Litecad.dll" Alias "lcPlineGetPrevVer" (ByVal hPline As Integer, ByVal hVer As Integer) As Integer

  Public Declare Function PlineGetVer Lib "Litecad.dll" Alias "lcPlineGetVer" (ByVal hPline As Integer, ByVal Index As Integer) As Integer

  Public Declare Function PlineGetVerPt Lib "Litecad.dll" Alias "lcPlineGetVerPt" (ByVal hPline As Integer, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As Integer

  Public Declare Function PlineGetSeg Lib "Litecad.dll" Alias "lcPlineGetSeg" (ByVal hPline As Integer, ByVal X As Double, ByVal Y As Double, ByVal Delta As Double) As Integer

  Public Declare Function PlineReverse Lib "Litecad.dll" Alias "lcPlineReverse" (ByVal hPline As Integer) As Integer

  Public Declare Function VportSetView Lib "Litecad.dll" Alias "lcVportSetView" (ByVal hVport As Integer, ByVal Xcen As Double, ByVal Ycen As Double, ByVal Scale As Double, ByVal Angle As Double) As Integer

  Public Declare Function VportFrolClear Lib "Litecad.dll" Alias "lcVportFrolClear" (ByVal hVport As Integer) As Integer

  Public Declare Function VportFrolAdd Lib "Litecad.dll" Alias "lcVportFrolAdd" (ByVal hVport As Integer, ByVal hLayer As Integer) As Integer

  Public Declare Function VportFrolGet Lib "Litecad.dll" Alias "lcVportFrolGet" (ByVal hVport As Integer, ByVal iLayer As Integer) As Integer

  Public Declare Function VportIsFrol Lib "Litecad.dll" Alias "lcVportIsFrol" (ByVal hVport As Integer, ByVal hLayer As Integer) As Integer

  Public Declare Unicode Function BlkRefAddAtt Lib "Litecad.dll" Alias "lcBlkRefAddAtt" (ByVal hBlockRef As Integer, ByVal szTag As String, ByVal szValue As String) As Integer

  Public Declare Function BlkRefGetFirstAtt Lib "Litecad.dll" Alias "lcBlkRefGetFirstAtt" (ByVal hBlockRef As Integer) As Integer

  Public Declare Function BlkRefGetNextAtt Lib "Litecad.dll" Alias "lcBlkRefGetNextAtt" (ByVal hBlockRef As Integer, ByVal hAttrib As Integer) As Integer

  Public Declare Unicode Function BlkRefGetAtt Lib "Litecad.dll" Alias "lcBlkRefGetAtt" (ByVal hBlockRef As Integer, ByVal szTag As String) As Integer

  Public Declare Function HatchBoundStart Lib "Litecad.dll" Alias "lcHatchBoundStart" (ByVal hHatch As Integer) As Integer

  Public Declare Function HatchBoundPoint Lib "Litecad.dll" Alias "lcHatchBoundPoint" (ByVal hHatch As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function HatchBoundEndLoop Lib "Litecad.dll" Alias "lcHatchBoundEndLoop" (ByVal hHatch As Integer) As Integer

  Public Declare Function HatchBoundEnd Lib "Litecad.dll" Alias "lcHatchBoundEnd" (ByVal hHatch As Integer) As Integer

  Public Declare Function HatchPatStart Lib "Litecad.dll" Alias "lcHatchPatStart" (ByVal hHatch As Integer) As Integer

  Public Declare Function HatchPatLine Lib "Litecad.dll" Alias "lcHatchPatLine" (ByVal hHatch As Integer, ByVal Angle As Double, ByVal x0 As Double, ByVal y0 As Double, ByVal dx As Double, ByVal dy As Double, ByVal nDash As Integer, ByVal L0 As Double, ByVal L1 As Double, ByVal L2 As Double, ByVal L3 As Double, ByVal L4 As Double, ByVal L5 As Double, ByVal L6 As Double, ByVal L7 As Double) As Integer

  Public Declare Function HatchPatEnd Lib "Litecad.dll" Alias "lcHatchPatEnd" (ByVal hHatch As Integer) As Integer

  Public Declare Function HatchGetLoopSize Lib "Litecad.dll" Alias "lcHatchGetLoopSize" (ByVal hHatch As Integer, ByVal iLoop As Integer) As Integer

  Public Declare Function HatchGetPoint Lib "Litecad.dll" Alias "lcHatchGetPoint" (ByVal hHatch As Integer, ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function RectGetPolyline Lib "Litecad.dll" Alias "lcRectGetPolyline" (ByVal hRect As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pBulge As Double) As Integer

  Public Declare Function XlinePutDir Lib "Litecad.dll" Alias "lcXlinePutDir" (ByVal hXline As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function CreateWindow Lib "Litecad.dll" Alias "lcCreateWindow" (ByVal hWndParent As Integer, ByVal Style As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function DeleteWindow Lib "Litecad.dll" Alias "lcDeleteWindow" (ByVal hLcWnd As Integer) As Integer

  Public Declare Function WndResize Lib "Litecad.dll" Alias "lcWndResize" (ByVal hLcWnd As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function WndSelectView Lib "Litecad.dll" Alias "lcWndSelectView" (ByVal hLcWnd As Integer, ByVal hView As Integer) As Integer

  Public Declare Function WndZoomRect Lib "Litecad.dll" Alias "lcWndZoomRect" (ByVal hLcWnd As Integer, ByVal Left As Double, ByVal Bottom As Double, ByVal Right As Double, ByVal Top As Double) As Integer

  Public Declare Function WndZoomScale Lib "Litecad.dll" Alias "lcWndZoomScale" (ByVal hLcWnd As Integer, ByVal Scal As Double) As Integer

  Public Declare Function WndRedraw Lib "Litecad.dll" Alias "lcWndRedraw" (ByVal hLcWnd As Integer) As Integer

  Public Declare Function WndSetFocus Lib "Litecad.dll" Alias "lcWndSetFocus" (ByVal hLcWnd As Integer) As Integer

  Public Declare Function WndExeCommand Lib "Litecad.dll" Alias "lcWndExeCommand" (ByVal hLcWnd As Integer, ByVal Command As Integer, ByVal CmdParam As Integer) As Integer

  Public Declare Function WndCoordFromDrw Lib "Litecad.dll" Alias "lcWndCoordFromDrw" (ByVal hLcWnd As Integer, ByVal Xdrw As Double, ByVal Ydrw As Double, ByRef pXwin As Integer, ByRef pYwin As Integer) As Integer

  Public Declare Function WndCoordToDrw Lib "Litecad.dll" Alias "lcWndCoordToDrw" (ByVal hLcWnd As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Function WndGetCursorCoord Lib "Litecad.dll" Alias "lcWndGetCursorCoord" (ByVal hLcWnd As Integer, ByRef pXwin As Integer, ByRef pYwin As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Function WndGetEntByPoint Lib "Litecad.dll" Alias "lcWndGetEntByPoint" (ByVal hLcWnd As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer) As Integer

  Public Declare Function WndSetCmdwin Lib "Litecad.dll" Alias "lcWndSetCmdwin" (ByVal hLcWnd As Integer, ByVal hCmdLine As Integer) As Integer

  Public Declare Function WndSetPropwin Lib "Litecad.dll" Alias "lcWndSetPropwin" (ByVal hLcWnd As Integer, ByVal hPropWnd As Integer) As Integer

  Public Declare Function WndOnClose Lib "Litecad.dll" Alias "lcWndOnClose" (ByVal hLcWnd As Integer) As Integer

  Public Declare Unicode Function WndGetPoint Lib "Litecad.dll" Alias "lcWndGetPoint" (ByVal hLcWnd As Integer, ByVal szPrompt As String, ByVal SnapMode As Integer, ByVal Index As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function WndGetPointBuf Lib "Litecad.dll" Alias "lcWndGetPointBuf" (ByVal hLcWnd As Integer, ByVal Index As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function CoordDrwToWnd Lib "Litecad.dll" Alias "lcCoordDrwToWnd" (ByVal hLcWnd As Integer, ByVal Xdrw As Double, ByVal Ydrw As Double, ByRef pXwin As Integer, ByRef pYwin As Integer) As Integer

  Public Declare Function CoordWndToDrw Lib "Litecad.dll" Alias "lcCoordWndToDrw" (ByVal hLcWnd As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByRef pXdrw As Double, ByRef pYdrw As Double) As Integer

  Public Declare Unicode Function ColorIsRGB Lib "Litecad.dll" Alias "lcColorIsRGB" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetRed Lib "Litecad.dll" Alias "lcColorGetRed" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetGreen Lib "Litecad.dll" Alias "lcColorGetGreen" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetBlue Lib "Litecad.dll" Alias "lcColorGetBlue" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorGetIndex Lib "Litecad.dll" Alias "lcColorGetIndex" (ByVal szColor As String) As Integer

  Public Declare Unicode Function ColorToVal Lib "Litecad.dll" Alias "lcColorToVal" (ByVal szColor As String, ByRef pbRGB As Integer, ByRef pIndex As Integer, ByRef pR As Integer, ByRef pG As Integer, ByRef pB As Integer) As Integer

  Public Declare Function ColorSetPalette Lib "Litecad.dll" Alias "lcColorSetPalette" (ByVal Index As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Integer

  Public Declare Function ColorGetPalette Lib "Litecad.dll" Alias "lcColorGetPalette" (ByVal Index As Integer, ByRef pR As Integer, ByRef pG As Integer, ByRef pB As Integer) As Integer

  Public Declare Function CreateCmdwin Lib "Litecad.dll" Alias "lcCreateCmdwin" (ByVal hWndParent As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function CmdwinResize Lib "Litecad.dll" Alias "lcCmdwinResize" (ByVal hCmdLine As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function CreatePropwin Lib "Litecad.dll" Alias "lcCreatePropwin" (ByVal hWndParent As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function PropwinResize Lib "Litecad.dll" Alias "lcPropwinResize" (ByVal hPropWnd As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Width As Integer, ByVal Height As Integer) As Integer

  Public Declare Function PropwinUpdate Lib "Litecad.dll" Alias "lcPropwinUpdate" (ByVal hPropWnd As Integer, ByVal bSelChanged As Integer) As Integer

  Public Declare Function GetErrorCode Lib "Litecad.dll" Alias "lcGetErrorCode" () As Integer

  Public Declare Unicode Function GetErrorStr Lib "Litecad.dll" Alias "lcGetErrorStr" () As String

  Public Declare Unicode Function ExtractPreview Lib "Litecad.dll" Alias "lcExtractPreview" (ByVal szFileName As String, ByVal hGlob As Integer, ByVal MaxSize As Integer) As Integer

  Public Declare Unicode Function ExtractFileInfo Lib "Litecad.dll" Alias "lcExtractFileInfo" (ByVal szFileName As String, ByVal szGuid As Integer, ByVal szComment As Integer, ByRef pInt0 As Integer, ByRef pInt1 As Integer) As Integer

  Public Declare Function GetClientSize Lib "Litecad.dll" Alias "lcGetClientSize" (ByVal hWnd As Integer, ByRef pWidth As Integer, ByRef pHeight As Integer) As Integer

  Public Declare Unicode Function GetFileName Lib "Litecad.dll" Alias "lcGetFileName" (ByVal hWnd As Integer, ByVal Mode As Integer) As String

  Public Declare Unicode Function GetValue Lib "Litecad.dll" Alias "lcGetValue" (ByVal hWnd As Integer, ByVal Lef As Integer, ByVal Top As Integer, ByVal szCaption As String, ByVal szPrompt As String, ByVal szValue As String) As String

  Public Declare Sub TextOut Lib "Litecad.dll" Alias "lcTextOut" (ByVal hDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal szText As String, ByVal ColorRGB As Integer)

  Public Declare Function FilletSetLines Lib "Litecad.dll" Alias "lcFilletSetLines" (ByVal L1x0 As Double, ByVal L1y0 As Double, ByVal L1x1 As Double, ByVal L1y1 As Double, ByVal L2x0 As Double, ByVal L2y0 As Double, ByVal L2x1 As Double, ByVal L2y1 As Double) As Integer

  Public Declare Function Fillet Lib "Litecad.dll" Alias "lcFillet" (ByVal Rad As Double, ByVal Bis As Double, ByVal Tang As Double) As Integer

  Public Declare Function FilletGetPoint Lib "Litecad.dll" Alias "lcFilletGetPoint" (ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Unicode Function CreateCommand Lib "Litecad.dll" Alias "lcCreateCommand" (ByVal hLcWnd As Integer, ByVal Id As Integer, ByVal szName As String, ByVal bNeedSel As Integer) As Integer

  Public Declare Function CmdExit Lib "Litecad.dll" Alias "lcCmdExit" () As Integer

  Public Declare Unicode Function CmdPrompt Lib "Litecad.dll" Alias "lcCmdPrompt" (ByVal hCmd As Integer, ByVal szText As String) As Integer

  Public Declare Function CmdGetEntByPoint Lib "Litecad.dll" Alias "lcCmdGetEntByPoint" (ByVal hCmd As Integer, ByVal Xwnd As Integer, ByVal Ywnd As Integer) As Integer

  Public Declare Function CmdSelectEnt Lib "Litecad.dll" Alias "lcCmdSelectEnt" (ByVal hCmd As Integer, ByVal hEntity As Integer, ByVal bSelect As Integer) As Integer

  Public Declare Function CmdRedraw Lib "Litecad.dll" Alias "lcCmdRedraw" (ByVal hCmd As Integer) As Integer

  Public Declare Function CmdSetFocus Lib "Litecad.dll" Alias "lcCmdSetFocus" (ByVal hCmd As Integer) As Integer

  Public Declare Function CmdRegen Lib "Litecad.dll" Alias "lcCmdRegen" (ByVal hCmd As Integer, ByVal hEnt As Integer) As Integer

  Public Declare Function CmdClearPoints Lib "Litecad.dll" Alias "lcCmdClearPoints" (ByVal hCmd As Integer) As Integer

  Public Declare Function CmdAddPoint Lib "Litecad.dll" Alias "lcCmdAddPoint" (ByVal hCmd As Integer, ByVal Id As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function CmdGetPoint Lib "Litecad.dll" Alias "lcCmdGetPoint" (ByVal hCmd As Integer, ByVal Id As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Declare Function CmdSetBasePoint Lib "Litecad.dll" Alias "lcCmdSetBasePoint" (ByVal hCmd As Integer, ByVal bEnable As Integer, ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function CmdDrawLine Lib "Litecad.dll" Alias "lcCmdDrawLine" (ByVal hCmd As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double) As Integer

  Public Declare Function CmdDrawPickbox Lib "Litecad.dll" Alias "lcCmdDrawPickbox" (ByVal hCmd As Integer, ByVal Xwnd As Integer, ByVal Ywnd As Integer) As Integer

  Public Declare Function CmdEqualPoints Lib "Litecad.dll" Alias "lcCmdEqualPoints" (ByVal hCmd As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Delta As Integer) As Integer

  Public Declare Sub SurfInitialize Lib "Litecad.dll" Alias "lcSurfInitialize" (ByVal MaxSectPnt As Integer, ByVal AngStep As Double)

  Public Declare Sub SurfUnInitialize Lib "Litecad.dll" Alias "lcSurfUnInitialize" ()

  Public Declare Sub SurfClearTriangles Lib "Litecad.dll" Alias "lcSurfClearTriangles" ()

  Public Declare Function SurfAddTriangle Lib "Litecad.dll" Alias "lcSurfAddTriangle" (ByVal X0 As Double, ByVal Y0 As Double, ByVal Z0 As Double, ByVal X1 As Double, ByVal Y1 As Double, ByVal Z1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal Z2 As Double) As Integer

  Public Declare Function SurfGetZ Lib "Litecad.dll" Alias "lcSurfGetZ" (ByVal X As Double, ByVal Y As Double, ByRef pZ As Double) As Integer

  Public Declare Function SurfGetZ_dbg Lib "Litecad.dll" Alias "lcSurfGetZ_dbg" (ByVal X As Double, ByVal Y As Double, ByRef pZ As Double, ByRef pX0 As Double, ByRef pY0 As Double, ByRef pZ0 As Double, ByRef pX1 As Double, ByRef pY1 As Double, ByRef pZ1 As Double, ByRef pX2 As Double, ByRef pY2 As Double, ByRef pZ2 As Double) As Integer

  Public Declare Sub SurfClearPlan Lib "Litecad.dll" Alias "lcSurfClearPlan" ()

  Public Declare Function SurfAddPlanVer Lib "Litecad.dll" Alias "lcSurfAddPlanVer" (ByVal X As Double, ByVal Y As Double, ByVal Bulge As Double) As Integer

  Public Declare Function SurfMakeSection Lib "Litecad.dll" Alias "lcSurfMakeSection" () As Integer

  Public Declare Function SurfGetSectPoint Lib "Litecad.dll" Alias "lcSurfGetSectPoint" (ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pZ As Double) As Integer

  Public Declare Sub CrossSetTolerance Lib "Litecad.dll" Alias "lcCrossSetTolerance" (ByVal Zero1 As Double, ByVal One1 As Double, ByVal Zero2 As Double, ByVal One2 As Double, ByVal NearPt As Double, ByVal Clas As Double, ByVal CutGr As Double, ByVal RigPt As Double)

  Public Declare Function CrossClear Lib "Litecad.dll" Alias "lcCrossClear" () As Integer

  Public Declare Function CrossBegin Lib "Litecad.dll" Alias "lcCrossBegin" (ByVal PlineType As Integer) As Integer

  Public Declare Function CrossAddPoint Lib "Litecad.dll" Alias "lcCrossAddPoint" (ByVal X As Double, ByVal Y As Double) As Integer

  Public Declare Function CrossEnd Lib "Litecad.dll" Alias "lcCrossEnd" () As Integer

  Public Declare Function CrossCalcArea Lib "Litecad.dll" Alias "lcCrossCalcArea" () As Integer

  Public Declare Function CrossCalcArea2 Lib "Litecad.dll" Alias "lcCrossCalcArea2" (ByVal hDrw As Integer, ByVal GroundKey As Integer, ByVal RoadKey As Integer, ByVal LinkKey As Integer) As Integer

  Public Declare Function CrossGetArea Lib "Litecad.dll" Alias "lcCrossGetArea" (ByVal iArea As Integer, ByRef pAreaVal As Double, ByRef pNumPnts As Integer) As Integer

  Public Declare Function CrossGetAreaPoint Lib "Litecad.dll" Alias "lcCrossGetAreaPoint" (ByVal iArea As Integer, ByVal iPnt As Integer, ByRef pX As Double, ByRef pY As Double) As Integer

  Public Delegate Sub F_MOUSEMOVE (ByVal hLcWnd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_MOUSEDOWN (ByVal hLcWnd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_MOUSEUP (ByVal hLcWnd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_MOUSEDBLCLK (ByVal hLcWnd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_MOUSESNAP (ByVal hLcWnd As Integer, ByVal Delta As Double, ByRef pX As Double, ByRef pY As Double)
  Public Delegate Sub F_MOUSELEAVE (ByVal hLcWnd As Integer)
  Public Delegate Sub F_MOUSEWHEEL (ByVal hLcWnd As Integer, ByVal Flags As Integer, ByVal Delta As Integer)
  Public Delegate Sub F_KEYDOWN (ByVal hLcWnd As Integer, ByVal VirtKey As Integer, ByVal Flags As Integer, ByVal bCtrl As Integer, ByVal bShift As Integer)
  Public Delegate Sub F_PAINT (ByVal hLcWnd As Integer, ByVal hView As Integer, ByVal Mode As Integer, ByVal hDC As Integer, ByVal Left As Integer, ByVal Top As Integer, ByVal Right As Integer, ByVal Bottom As Integer)
  Public Delegate Sub F_ZOOM (ByVal hLcWnd As Integer, ByVal Left As Double, ByVal Bottom As Double, ByVal Right As Double, ByVal Top As Double, ByVal PixelSize As Double)
  Public Delegate Sub F_SELECTVIEW (ByVal hLcWnd As Integer, ByVal hView As Integer)
  Public Delegate Sub F_GETPOINT (ByVal hLcWnd As Integer, ByVal hView As Integer, ByVal Index As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_ADDCOMMAND (ByVal hLcWnd As Integer)
  Public Delegate Sub F_CMD_START (ByVal hCmd As Integer, ByVal Prm As Integer)
  Public Delegate Sub F_CMD_FINISH (ByVal hCmd As Integer)
  Public Delegate Sub F_CMD_MOUSEDOWN (ByVal hCmd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_CMD_MOUSEUP (ByVal hCmd As Integer, ByVal Button As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_CMD_MOUSEMOVE (ByVal hCmd As Integer, ByVal hDC As Integer, ByVal Flags As Integer, ByVal Xwin As Integer, ByVal Ywin As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_CMD_STRING (ByVal hCmd As Integer, ByVal szStr As String)
  Public Delegate Sub F_ADDENTITY (ByVal hDrw As Integer, ByVal hBlock As Integer, ByVal hEntity As Integer)
  Public Delegate Sub F_REGEN (ByVal hDrw As Integer, ByVal hView As Integer, ByVal Percent As Integer)
  Public Delegate Sub F_FIOPROGRESS (ByVal hDrw As Integer, ByVal Mode As Integer, ByVal IntVal As Integer, ByVal szFileName As String)
  Public Delegate Sub F_SELECTION (ByVal hDrw As Integer, ByVal hBlock As Integer, ByVal bSelect As Integer, ByVal nEnts As Integer, ByVal hEnt As Integer, ByVal nTotal As Integer)
  Public Delegate Sub F_PROPCHANGED (ByVal hDrw As Integer, ByVal idProp As Integer, ByVal hObj As Integer)
  Public Delegate Sub F_GRIPSELECT (ByVal hEnt As Integer, ByVal iGrip As Integer, ByVal X As Double, ByVal Y As Double)
  Public Delegate Sub F_GRIPMOVE (ByVal hEnt As Integer, ByVal iGrip As Integer, ByRef pX As Double, ByRef pY As Double, ByRef pAngle As Double, ByVal bDrag As Integer)
  Public Delegate Sub F_ENTERASE (ByVal hEnt As Integer)
  Public Delegate Sub F_ENTMOVE (ByVal hEnt As Integer, ByVal DX As Double, ByVal DY As Double, ByVal bDrag As Integer)
  Public Delegate Sub F_ENTROTATE (ByVal hEnt As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Angle As Double, ByVal bDrag As Integer)
  Public Delegate Sub F_ENTSCALE (ByVal hEnt As Integer, ByVal X0 As Double, ByVal Y0 As Double, ByVal Scale As Double, ByVal bDrag As Integer)
  Public Delegate Sub F_ENTMIRROR (ByVal hEnt As Integer, ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal bDrag As Integer)
  Public Delegate Sub F_ENTPROP (ByVal hEnt As Integer, ByVal idProp As Integer)
  Public Delegate Sub F_FONTREPLACE (ByVal hDrw As Integer, ByVal szStyleName As String, ByVal szOrigName As String)
  Public Delegate Sub F_ADDSTR ()
  Public Delegate Sub F_HELP (ByVal hDrw As Integer, ByVal idTopic As Integer)

  Public Declare Sub EventReturnCode Lib "Litecad.dll" Alias "lcEventReturnCode" (ByVal code As Integer)

  Public Declare Sub EventsEnable Lib "Litecad.dll" Alias "lcEventsEnable" (ByVal bEnable As Integer)

  Public Declare Sub OnEventMouseMove Lib "Litecad.dll" Alias "lcOnEventMouseMove" (pFunc As F_MOUSEMOVE)

  Public Declare Sub OnEventMouseDown Lib "Litecad.dll" Alias "lcOnEventMouseDown" (pFunc As F_MOUSEDOWN)

  Public Declare Sub OnEventMouseUp Lib "Litecad.dll" Alias "lcOnEventMouseUp" (pFunc As F_MOUSEUP)

  Public Declare Sub OnEventMouseDblClk Lib "Litecad.dll" Alias "lcOnEventMouseDblClk" (pFunc As F_MOUSEDBLCLK)

  Public Declare Sub OnEventMouseSnap Lib "Litecad.dll" Alias "lcOnEventMouseSnap" (pFunc As F_MOUSESNAP)

  Public Declare Sub OnEventMouseLeave Lib "Litecad.dll" Alias "lcOnEventMouseLeave" (pFunc As F_MOUSELEAVE)

  Public Declare Sub OnEventMouseWheel Lib "Litecad.dll" Alias "lcOnEventMouseWheel" (pFunc As F_MOUSEWHEEL)

  Public Declare Sub OnEventKeyDown Lib "Litecad.dll" Alias "lcOnEventKeyDown" (pFunc As F_KEYDOWN)

  Public Declare Sub OnEventPaint Lib "Litecad.dll" Alias "lcOnEventPaint" (pFunc As F_PAINT)

  Public Declare Sub OnEventZoom Lib "Litecad.dll" Alias "lcOnEventZoom" (pFunc As F_ZOOM)

  Public Declare Sub OnEventSelectView Lib "Litecad.dll" Alias "lcOnEventSelectView" (pFunc As F_SELECTVIEW)

  Public Declare Sub OnEventGetPoint Lib "Litecad.dll" Alias "lcOnEventGetPoint" (pFunc As F_GETPOINT)

  Public Declare Sub OnEventAddCommand Lib "Litecad.dll" Alias "lcOnEventAddCommand" (pFunc As F_ADDCOMMAND)

  Public Declare Sub OnEventCmdStart Lib "Litecad.dll" Alias "lcOnEventCmdStart" (pFunc As F_CMD_START)

  Public Declare Sub OnEventCmdFinish Lib "Litecad.dll" Alias "lcOnEventCmdFinish" (pFunc As F_CMD_FINISH)

  Public Declare Sub OnEventCmdMouseDown Lib "Litecad.dll" Alias "lcOnEventCmdMouseDown" (pFunc As F_CMD_MOUSEDOWN)

  Public Declare Sub OnEventCmdMouseUp Lib "Litecad.dll" Alias "lcOnEventCmdMouseUp" (pFunc As F_CMD_MOUSEUP)

  Public Declare Sub OnEventCmdMouseMove Lib "Litecad.dll" Alias "lcOnEventCmdMouseMove" (pFunc As F_CMD_MOUSEMOVE)

  Public Declare Sub OnEventCmdString Lib "Litecad.dll" Alias "lcOnEventCmdString" (pFunc As F_CMD_STRING)

  Public Declare Sub OnEventAddEntity Lib "Litecad.dll" Alias "lcOnEventAddEntity" (pFunc As F_ADDENTITY)

  Public Declare Sub OnEventRegen Lib "Litecad.dll" Alias "lcOnEventRegen" (pFunc As F_REGEN)

  Public Declare Sub OnEventFioProgress Lib "Litecad.dll" Alias "lcOnEventFioProgress" (pFunc As F_FIOPROGRESS)

  Public Declare Sub OnEventSelection Lib "Litecad.dll" Alias "lcOnEventSelection" (pFunc As F_SELECTION)

  Public Declare Sub OnEventPropChanged Lib "Litecad.dll" Alias "lcOnEventPropChanged" (pFunc As F_PROPCHANGED)

  Public Declare Sub OnEventGripSelect Lib "Litecad.dll" Alias "lcOnEventGripSelect" (pFunc As F_GRIPSELECT)

  Public Declare Sub OnEventGripMove Lib "Litecad.dll" Alias "lcOnEventGripMove" (pFunc As F_GRIPMOVE)

  Public Declare Sub OnEventEntErase Lib "Litecad.dll" Alias "lcOnEventEntErase" (pFunc As F_ENTERASE)

  Public Declare Sub OnEventEntMove Lib "Litecad.dll" Alias "lcOnEventEntMove" (pFunc As F_ENTMOVE)

  Public Declare Sub OnEventEntRotate Lib "Litecad.dll" Alias "lcOnEventEntRotate" (pFunc As F_ENTROTATE)

  Public Declare Sub OnEventEntScale Lib "Litecad.dll" Alias "lcOnEventEntScale" (pFunc As F_ENTSCALE)

  Public Declare Sub OnEventEntMirror Lib "Litecad.dll" Alias "lcOnEventEntMirror" (pFunc As F_ENTMIRROR)

  Public Declare Sub OnEventEntProp Lib "Litecad.dll" Alias "lcOnEventEntProp" (pFunc As F_ENTPROP)

  Public Declare Sub OnEventHelp Lib "Litecad.dll" Alias "lcOnEventHelp" (pFunc As F_HELP)

  Public Declare Sub OnEventAddStr Lib "Litecad.dll" Alias "lcOnEventAddStr" (pFunc As F_ADDSTR)

  Public Declare Sub OnEventFontReplace Lib "Litecad.dll" Alias "lcOnEventFontReplace" (pFunc As F_FONTREPLACE)


End Module
