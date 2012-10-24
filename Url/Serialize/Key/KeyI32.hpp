#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyI32 : Stream
	{
	public:
		virtual __i32 _keyI32() = 0;
	};
	typedef shared_ptr<KeyI32> KeyI32Sptr;
	typedef weak_ptr<KeyI32> KeyI32Wptr;

}
