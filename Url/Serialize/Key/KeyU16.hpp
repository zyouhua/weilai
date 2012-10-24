#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyU16 : Stream
	{
	public:
		virtual __u16 _keyU16() = 0;
	};
	typedef shared_ptr<KeyU16> KeyU16Sptr;
	typedef weak_ptr<KeyU16> KeyU16Wptr;

}
