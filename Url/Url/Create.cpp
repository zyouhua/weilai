#include "Create.hpp"

namespace std {

	void Create::_runCreate(const char * nUrl, const char * nName)
	{
		string url_ = this->_getUrl(nUrl, nName);
		this->_runCreate(url_.c_str());
	}

	void Create::_runCreate(const char * nUrl)
	{
		__super::_saveDirty();
		__super::_setUrl(nUrl);
	}

	Create::Create()
	{

	}

	Create::~Create()
	{

	}

}
