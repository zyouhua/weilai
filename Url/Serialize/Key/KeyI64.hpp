#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyI64 : Stream
	{
	public:
		virtual __i64 _keyI64() = 0;
	};
	typedef shared_ptr<KeyI64> KeyI64Sptr;
	typedef weak_ptr<KeyI64> KeyI64Wptr;

}
