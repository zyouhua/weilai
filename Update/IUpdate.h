#ifndef IUpdate_h__
#define IUpdate_h__

#include "IUpdate-.h"
#include "../Inc-I.h"

#ifdef _MSC_VER
#pragma pack(push,1)
#endif

struct IUpdate
{
	_setUpdate_t mRunUpdate;
	void * mUpdate;
}__pack;

#ifdef _MSC_VER
#pragma pack(pop)
#endif
#endif // IUpdate_h__
