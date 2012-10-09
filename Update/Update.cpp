#include "Update.hpp"

namespace std{

	static void _runUpdate(IUpdate * nUpdate)
	{
		Update * update = reinterpret_cast<Update *>(nUpdate->mUpdate);
		update->_runUpdate();
	}

	IUpdate * Update::_getUpdate()
	{
		return (&mUpdate);
	}

	Update::Update()
	{
		mUpdate.mUpdate = reinterpret_cast<void *>(this);
		mUpdate.mRunUpdate = std::_runUpdate;
	}

	Update::~Update()
	{
		mUpdate.mUpdate = NULL;
		mUpdate.mRunUpdate = NULL;
	}

}
