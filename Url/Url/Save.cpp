#include "Save.hpp"

namespace std {

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
		m_tRunSave.disconnect_all_slots();
	}

	Save::~Save()
	{
		m_tRunSave.disconnect_all_slots();
	}

}
