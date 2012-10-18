#include "GetUrl.hpp"

namespace std {

	const string GetUrl::_getUrl()
	{
		return mUrl;
	}

	void GetUrl::_setUrl(const char * nUrl)
	{
		mUrl = nUrl;
	}

	GetUrl::GetUrl()
		:mUrl("")
	{

	}

	GetUrl::~GetUrl()
	{
		mUrl = "";
	}

}
