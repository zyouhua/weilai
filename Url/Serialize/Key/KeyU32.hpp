#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyU32 : Stream
	{
	public:
		virtual __u32 _keyU32() = 0;
	};
	typedef shared_ptr<KeyU32> KeyU32Sptr;
	typedef weak_ptr<KeyU32> KeyU32Wptr;

}
