#include "Save.hpp"

#include "ISaveSingleton.h"

namespace std {

	static void _runSave(ISave * nSave)
	{
		Save * save = reinterpret_cast<Save *>(nSave->mSave);
		save->_runSave();
	}

	void Save::_runSaveAs(const char * nUrl, const char * nName)
	{
		this->_runDelete();
		this->_runCreate(nUrl, nName);
	}

	void Save::_runSaveAs(const char * nUrl)
	{
		this->_runDelete();
		this->_runCreate(nUrl);
	}

	void Save::_runSave()
	{
		if (!m_tRunSave.empty())
		{
			m_tRunSave();
		}
		__super::_saveDirty();
	}

	Save::Save()
	{
		mSave.mSave = reinterpret_cast<void *>(this);
		mSave.mRunSave = std::_runSave;
		m_tRunSave.disconnect_all_slots();
	}

	Save::~Save()
	{
		mSave.mSave = NULL;
		mSave.mRunSave = NULL;
		m_tRunSave.disconnect_all_slots();
	}

}
