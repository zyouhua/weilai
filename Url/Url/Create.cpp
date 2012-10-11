#include "Create.hpp"

namespace std {

	void Create::_runCreate(string nUrl)
	{
		__super::_saveDirty();
		__super::_setUrl(nUrl);
	}

	void Create::_runCreate(string nUrl, string nName)
	{

	}

}
