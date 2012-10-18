#pragma once

#include "GetUrl.hpp"
#include "Dirty.hpp"

namespace std {

	class Load : public virtual GetUrl, public virtual Dirty
	{
	public:
		void _runLoad(const char * nUrl, const char * nName);
		virtual void _runLoad(const char * nUrl);

		signal<void ()> m_tLoadInit;
	protected:
		virtual void _loadInit();
	public:
		Load();
		virtual ~Load();
	};

}
