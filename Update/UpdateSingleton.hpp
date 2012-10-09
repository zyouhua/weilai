#pragma once

#include "IUpdate.h"

#include <list>

namespace std {

	class UpdateSingleton
	{
	public:
		void _registerUpdate(IUpdate * nUpdate);
		void _runUpdate();
		void _clearUpdate();
		UpdateSingleton();
		~UpdateSingleton();
	private:
		list<IUpdate *> mUpdates;
	};
}
