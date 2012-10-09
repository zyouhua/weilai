#include "SaveSingleton.hpp"

namespace std {

	void SaveSingleton::_registerSave(ISave * nSave)
	{
		mSaves.push_back(nSave);
	}

	void SaveSingleton::_runSave()
	{
		mSaves.clear();
	}

	void SaveSingleton::_clearSave()
	{
		list<ISave *>::iterator it = mSaves.begin();
		for ( ; it != mSaves.end(); it++ )
		{
			ISave * save = (*it);
			save->mRunSave(save);
		}
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
