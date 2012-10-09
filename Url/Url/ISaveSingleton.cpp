#include "ISaveSingleton.h"

#include "SaveSingleton.hpp"
#include "../../Utility/__singleton.hpp"

using namespace std;

void SaveSingleton_registerSave(ISave * nSave)
{
	SaveSingleton& saveSingleton = __singleton<SaveSingleton>::_instance();
	saveSingleton._registerSave(nSave);
}

void SaveSingleton_runSave()
{
	SaveSingleton& saveSingleton = __singleton<SaveSingleton>::_instance();
	saveSingleton._runSave();
}

void SaveSingleton_initialize()
{
	SaveSingleton& saveSingleton = __singleton<SaveSingleton>::_instance();
	saveSingleton._clearSave();
}

void SaveSingleton_uninitialized()
{
	SaveSingleton& saveSingleton = __singleton<SaveSingleton>::_instance();
	saveSingleton._clearSave();
}
