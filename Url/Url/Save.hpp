#pragma once

#include "Dirty.hpp"
#include "ISave.h"

namespace std {

	class Save : public Dirty
	{
	public:
		signal<void ()> m_tRunSave;
		virtual void _runSave();

		Save();
		virtual ~Save();
	private:
		ISave mSave;
	};

}
