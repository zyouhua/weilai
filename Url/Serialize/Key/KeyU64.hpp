#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyU64 : Stream
	{
	public:
		virtual __u64 _keyU64() = 0;
	};
	typedef shared_ptr<KeyU64> KeyU64Sptr;
	typedef weak_ptr<KeyU64> KeyU64Wptr;

}
