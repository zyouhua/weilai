#include "Dirty.hpp"

namespace std {

	void Dirty::_runDirty()
	{
		mIsDirtied = true;
	}

	void Dirty::_saveDirty()
	{
		mIsDirtied = false;
	}

	bool Dirty::_isDirty()
	{
		if (mIsDirtied)
		{
			return true;
		}
		if (m_tIsDirty.empty())
		{
			return false;
		}
		return this->m_tIsDirty();
	}

	Dirty::Dirty()
		:mIsDirtied(false)
	{
		m_tIsDirty.disconnect_all_slots();
	}

	Dirty::~Dirty()
	{
		m_tIsDirty.disconnect_all_slots();
		mIsDirtied = false;
	}

}
