#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyDouble : Stream
	{
	public:
		virtual double _keyDouble() = 0;
	};
	typedef shared_ptr<KeyDouble> KeyDoubleSptr;
	typedef weak_ptr<KeyDouble> KeyDoubleWptr;

}
