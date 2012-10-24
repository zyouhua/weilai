#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyI8 : Stream
	{
	public:
		virtual __i8 _keyI8() = 0;
	};
	typedef shared_ptr<KeyI8> KeyI8Sptr;
	typedef weak_ptr<KeyI8> KeyI8Wptr;

}
