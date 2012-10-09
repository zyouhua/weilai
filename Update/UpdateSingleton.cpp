#include "UpdateSingleton.hpp"

namespace std {

	void UpdateSingleton::_registerUpdate(IUpdate * nUpdate)
	{
		mUpdates.push_back(nUpdate);
	}

	void UpdateSingleton::_runUpdate()
	{
		list<IUpdate *>::iterator it = mUpdates.begin();
		for ( ; it != mUpdates.end(); it++)
		{
			IUpdate * update = (*it);
			update->mRunUpdate(update);
		}
	}

	void UpdateSingleton::_clearUpdate()
	{
		mUpdates.clear();
	}

	UpdateSingleton::UpdateSingleton()
	{
		mUpdates.clear();
	}

	UpdateSingleton::~UpdateSingleton()
	{
		mUpdates.clear();
	}

}
