#pragma once

#include "ISave.h"
#include "../../Incpp.hpp"

#include <list>

namespace std {

	class SaveSingleton
	{
	public:
		void _registerSave(ISave * nSave);
		void _runSave();
		void _clearSave();
		SaveSingleton();
		~SaveSingleton();

	private:
		list<ISave *> mSaves;
	};

}
