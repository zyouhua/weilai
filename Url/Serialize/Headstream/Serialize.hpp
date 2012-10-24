#pragma once

#include "../Key/KeyValue.hpp"
#include "SerializeIO_ .hpp"

#include <string>
#include <vector>
#include <map>

namespace std {

	class Serialize
	{
	public:
		//__bool
		virtual void _serialize(bool& nValue, const wchar_t * nName, bool nOptimal = false) = 0;
		//__i8
		virtual void _serialize(__i8& nValue, const wchar_t * nName, __i8 nOptimal = -1) = 0;
		//__u8
		virtual void _serialize(__u8& nValue, const wchar_t * nName, __u8 nOptimal = -1) = 0;
		//__i16
		virtual void _serialize(__i16& nValue, const wchar_t * nName, __i16 nOptimal = -1) = 0;
		//__u16
		virtual void _serialize(__u16& nValue, const wchar_t * nName, __u16 nOptimal = -1) = 0;
		//__i32
		virtual void _serialize(__i32& nValue, const wchar_t * nName, __i32 nOptimal = -1) = 0;
		//__u32
		virtual void _serialize(__u32& nValue, const wchar_t * nName, __u32 nOptimal = -1) = 0;
		//__i64
		virtual void _serialize(__i64& nValue, const wchar_t * nName, __i64 nOptimal = -1) = 0;
		//__u64
		virtual void _serialize(__u64& nValue, const wchar_t * nName, __u64 nOptimal = -1) = 0;
		//__s
		virtual void _serialize(__s& nValue, const wchar_t * nName, const wchar_t * nOptimal = L"") = 0;
		//__float
		virtual void _serialize(__f& nValue, const wchar_t * nName, float nOptimal = 0.) = 0;
		//__double
		virtual void _serialize(__d& nValue, const wchar_t * nName, __d nOptimal = 0.) = 0;
		//__t
		virtual void _serialize(Stream * nValue, const wchar_t * nName) = 0;
		//ISerialize
		virtual void _openUrl(string nUrl) = 0;
		virtual SerializeIO_ _serializeIO() = 0;
		virtual __i32 _pushStream(const wchar_t * nName) = 0;
		virtual void _popStream() = 0;
		virtual void _runClose() = 0;
	};

}
