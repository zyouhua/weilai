#ifndef ISave_h__
#define ISave_h__

#include "ISave-.h"
#include "../../Inc-dll.h"

#ifdef _MSC_VER
#pragma pack(push,1)
#endif

struct ISave
{
	_setSave_t mRunSave;
	void * mSave;
}__pack;

#ifdef _MSC_VER
#pragma pack(pop)
#endif
#endif // ISave_h__
