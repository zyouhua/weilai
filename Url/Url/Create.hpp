#pragma once

#include "GetUrl.hpp"
#include "Dirty.hpp"

namespace std {

	class Create : public GetUrl, public Dirty
	{
	public:
		virtual void _runCreate(string nUrl);

		virtual void _runCreate(string nUrl, string nName);
	};

}
