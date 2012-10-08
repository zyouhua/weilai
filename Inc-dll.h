#ifndef Inc_dll_h__
#define Inc_dll_h__

#include "Inc.h"

#ifdef EXPROT
#define __funapi __declspec(dllexport)
#else
#define __funapi __declspec(dllimport)
#endif

#endif // Inc-dll_h__
