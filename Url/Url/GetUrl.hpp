#pragma once

#include "../../Incpp.hpp"

namespace std {

	class GetUrl
	{
	public:
		const string _getUrl();

	protected:
		virtual const string _getUrl(const char * nUrl, const char * nName) = 0;
		void _setUrl(const char * nUrl);
	public:
		GetUrl();
		virtual ~GetUrl();
	private:
		string mUrl;
	};

}
