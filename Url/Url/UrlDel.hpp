#pragma once

#include "GetUrl.hpp"
#include "Dirty.hpp"

namespace std {

	class UrlDel : public GetUrl, public Dirty
	{
	public:
		virtual void _beforeDelete();
		virtual void _runDelete();
	};

}
