// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

// Modify the following defines if you have to target a platform prior to the ones specified below.
// Refer to MSDN for the latest info on corresponding values for different platforms.

#ifndef WINVER                   // Specifies that the minimum required platform is
#define WINVER 0x0410            // Windows 98
#endif

#ifndef _WIN32_WINNT            // Specifies that the minimum required platform is
#define _WIN32_WINNT 0x0500     // Windows 2000
#endif

#ifndef _WIN32_WINDOWS          // Specifies that the minimum required platform is
#define _WIN32_WINDOWS 0x0410   // Windows 98
#endif

#ifndef _WIN32_IE               // Specifies that the minimum required platform is
#define _WIN32_IE 0x0600        // Internet Explorer 6.0
#endif

#define WIN32_LEAN_AND_MEAN		// Exclude rarely-used stuff from Windows headers
// Windows Header Files:
#include <windows.h>

// C RunTime Header Files
#include <stdlib.h>
#include <malloc.h>
#include <memory.h>
#include <tchar.h>
#include <commdlg.h>
#include <commctrl.h>


// TODO: reference additional headers your program requires here
#include "litecad.h"
#ifdef _OKDIVIDER
  #include "okDivider.h"
#endif
