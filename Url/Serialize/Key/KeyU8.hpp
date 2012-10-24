#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyU8 : Stream
	{
	public:
		virtual __u8 _keyU8() = 0;
	};
	typedef shared_ptr<KeyU8> KeyU8Sptr;
	typedef weak_ptr<KeyU8> KeyU8Wptr;

}
