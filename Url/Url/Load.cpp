#include "Load.hpp"

namespace std {

	void Load::_runLoad(const char * nUrl, const char * nName)
	{
		string url_ = this->_getUrl(nUrl, nName);
		this->_runLoad(url_.c_str());
	}

	void Load::_runLoad(const char * nUrl)
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

	Load::Load()
	{
		m_tLoadInit.disconnect_all_slots();
	}

	Load::~Load()
	{
		m_tLoadInit.disconnect_all_slots();
	}

}
