#include "IUpdateSingleton.h"

#include "UpdateSingleton.hpp"
#include "../Utility/__singleton.hpp"

using namespace std;

void UpdateSingleton_registerUpdate(IUpdate * nUpdate)
{
	UpdateSingleton& updatesingleton = __singleton<UpdateSingleton>::_instance();
	updatesingleton._registerUpdate(nUpdate);
}

void UpdateSingleton_runUpdate()
{
	UpdateSingleton& updatesingleton = __singleton<UpdateSingleton>::_instance();
	updatesingleton._runUpdate();
}

void UpdateSingleton_initialize()
{
	UpdateSingleton& updatesingleton = __singleton<UpdateSingleton>::_instance();
	updatesingleton._clearUpdate();
}

void UpdateSingleton_uninitialized()
{
	UpdateSingleton& updatesingleton = __singleton<UpdateSingleton>::_instance();
	updatesingleton._clearUpdate();
}
