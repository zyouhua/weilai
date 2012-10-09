#include "Load.hpp"

namespace std {

	void Load::_runLoad(string nUrl)
	{
		this->_loadInit();
		__super::_saveDirty();
		__super::_setUrl(nUrl);
	}

	void Load::_loadInit()
	{
		if (!m_tLoadInit.empty())
		{
			this->m_tLoadInit();
		}
	}

}
