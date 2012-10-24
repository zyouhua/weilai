#pragma once

#include "../Headstream/Stream.hpp"

#include <string>

namespace std {

	class KeyStr : Stream
	{
	public:
		virtual std::wstring _keyStr() = 0;
	};
	typedef shared_ptr<KeyStr> KeyStrSptr;
	typedef weak_ptr<KeyStr> KeyStrWptr;

}
