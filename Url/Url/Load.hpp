#pragma once

#include "GetUrl.hpp"
#include "Dirty.hpp"

namespace std {

	class Load : public GetUrl, public Dirty
	{
	public:
		virtual void _runLoad(string nUrl);

		signal<void ()> m_tLoadInit;
		virtual void _loadInit();
	};

}
