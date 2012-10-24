#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyI16 : Stream
	{
	public:
		virtual __i16 _keyI16() = 0;
	};
	typedef shared_ptr<KeyI16> KeyI16Sptr;
	typedef weak_ptr<KeyI16> KeyI16Wptr;

}
