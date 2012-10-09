#include "GetUrl.hpp"

namespace std {

	string GetUrl::_getUrl()
	{
		return mUrl;
	}

	void GetUrl::_setUrl(string nUrl)
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
