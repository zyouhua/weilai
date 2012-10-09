#ifndef IUpdateSingleton_h__
#define IUpdateSingleton_h__

#include "IUpdate.h"

#ifdef __cplusplus
extern "C" {
#endif

	__funapi void UpdateSingleton_registerUpdate(IUpdate * nUpdate);
	__funapi void UpdateSingleton_runUpdate();
	__funapi void UpdateSingleton_initialize();
	__funapi void UpdateSingleton_uninitialized();

#ifdef __cplusplus
}
#endif
#endif // IUpdateSingleton_h__
