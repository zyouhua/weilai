#ifndef ICommand_h__
#define ICommand_h__

#include "ICommand-.h"
#include "../Inc-lib.h"

#ifdef _MSC_VER
#pragma pack(push,1)
#endif

struct ICommand
{
	_setCommand_t mRunCommand;
	_setCommand_t mUninitialized;
	void * mCommand;
}__pack;

#ifdef _MSC_VER
#pragma pack(pop)
#endif
#endif // ICommand_h__
