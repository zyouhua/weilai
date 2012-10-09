#ifndef ISaveSingleton_h__
#define ISaveSingleton_h__

#include "ISave.h"

#ifdef __cplusplus
extern "C" {
#endif

	__funapi void SaveSingleton_registerSave(ISave * nSave);
	__funapi void SaveSingleton_runSave();
	__funapi void SaveSingleton_initialize();
	__funapi void SaveSingleton_uninitialized();

#ifdef __cplusplus
}
#endif
#endif // ISaveSingleton_h__
