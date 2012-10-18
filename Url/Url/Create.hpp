#pragma once

#include "GetUrl.hpp"
#include "Dirty.hpp"

namespace std {

	class Create : public virtual GetUrl, public virtual Dirty
	{
	public:
		void _runCreate(const char * nUrl, const char * nName);
		virtual void _runCreate(const char * nUrl);

		Create();
		virtual ~Create();
	};

}
