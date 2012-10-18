#pragma once

#include "../../Incpp.hpp"

namespace std {

	class UrlDel
	{
	public:
		signal<void ()> m_tRunDel;
		virtual void _runDelete();

		UrlDel();
		virtual ~UrlDel();
	};

}
