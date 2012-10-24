#pragma once

#include "../../Url/Dirty.hpp"

namespace std {

	class Serialize;
	class Stream : public Dirty
	{
	public:
		virtual void _serialize(Serialize& nSerialize) = 0;
	};
	typedef shared_ptr<Stream> StreamSptr;
	typedef weak_ptr<Stream> StreamWptr;

}
