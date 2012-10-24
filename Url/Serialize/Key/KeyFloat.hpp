#pragma once

#include "../Headstream/Stream.hpp"

namespace std {

	class KeyFloat : Stream
	{
	public:
		virtual double _keyFloat() = 0;
	};
	typedef shared_ptr<KeyFloat> KeyFloatSptr;
	typedef weak_ptr<KeyFloat> KeyFloatWptr;

}
