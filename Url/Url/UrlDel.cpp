#include "UrlDel.hpp"

namespace std {

	void UrlDel::_runDelete()
	{
		if (!m_tRunDel.empty())
		{
			m_tRunDel();
		}
	}

	UrlDel::UrlDel()
	{
		m_tRunDel.disconnect_all_slots();
	}

	UrlDel::~UrlDel()
	{
		m_tRunDel.disconnect_all_slots();
	}

}
