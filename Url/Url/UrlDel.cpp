#include "UrlDel.hpp"

namespace std {

	void UrlDel::_beforeDelete()
	{
	}

	void UrlDel::_runDelete()
	{
		__super::_saveDirty();
		__super::_setUrl("");
	}

}
