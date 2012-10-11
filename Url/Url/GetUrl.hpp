#pragma once

#include "../../Incpp.hpp"

namespace std {

	class GetUrl
	{
	public:
		string _getUrl();

	protected:
		void _setUrl(string nUrl);
	public:
		GetUrl();
		virtual ~GetUrl();
	private:
		string mUrl;
	};

}
