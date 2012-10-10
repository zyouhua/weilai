#include "SaveSingleton.hpp"

namespace std {

	void SaveSingleton::_registerSave(ISave * nSave)
	{
		mSaves.push_back(nSave);
	}

	void SaveSingleton::_runSave()
	{
		list<ISave *>::iterator it = mSaves.begin();
		for ( ; it != mSaves.end(); it++ )
		{
			ISave * save = (*it);
			save->mRunSave(save);
		}
	}

	void SaveSingleton::_clearSave()
	{
		mSaves.clear();
	}

	SaveSingleton::SaveSingleton()
	{
		mSaves.clear();
	}

	SaveSingleton::~SaveSingleton()
	{
		mSaves.clear();
	}

}
