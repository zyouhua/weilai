#pragma once

#include "../Headstream/Serialize.hpp"

namespace std {

	class XmlReader : public Serialize
	{
	public:
		//__b
		void _serialize(__b& nValue, const wchar_t * nName, __b nOptimal = false);
		//__i8
		void _serialize(__i8& nValue, const wchar_t * nName, __i8 nOptimal = -1);
		//__u8
		void _serialize(__u8& nValue, const wchar_t * nName, __u8 nOptimal = -1);
		//__i16
		void _serialize(__i16& nValue, const wchar_t * nName, __i16 nOptimal = -1);
		//__u16
		void _serialize(__u16& nValue, const wchar_t * nName, __u16 nOptimal = -1);
		//__i32
		void _serialize(__i32& nValue, const wchar_t * nName, __i32 nOptimal = -1);
		//__u32
		void _serialize(__u32& nValue, const wchar_t * nName, __u32 nOptimal = -1);
		//__i64
		void _serialize(__i64& nValue, const wchar_t * nName, __i64 nOptimal = -1);
		//__u64
		void _serialize(__u64& nValue, const wchar_t * nName, __u64 nOptimal = -1);
		//__s
		void _serialize(__s& nValue, const wchar_t * nName, const wchar_t * nOptimal = L"");
		//__f
		void _serialize(__f& nValue, const wchar_t * nName, __f nOptimal = 0.);
		//__d
		void _serialize(__d& nValue, const wchar_t * nName, __d nOptimal = 0.);
		//__t
		void _serialize(Stream * nValue, const wchar_t * nName);
		//ISerialize
		void _openUrl(string nUrl);
		SerializeIO_ _serializeIO();
		__i32 _pushStream(const wchar_t * nName);
		void _popStream();
		void _runClose();
	};

}
