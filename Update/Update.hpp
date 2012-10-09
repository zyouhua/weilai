#pragma once

#include "IUpdate.h"

namespace std {

	class Update
	{
	public:
		virtual void _runUpdate() = 0;
		IUpdate * _getUpdate();
		Update();
		virtual ~Update();
	private:
		IUpdate mUpdate;
	};

}
