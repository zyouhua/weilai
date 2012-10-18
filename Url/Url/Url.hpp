#pragma once

#include "Load.hpp"
#include "Save.hpp"

namespace std {

	class Url : public Load, public Save
	{
	public:
		Url();
		virtual ~Url();
	};

}
