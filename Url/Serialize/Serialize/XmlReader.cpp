#include "XmlReader.hpp"

#include "rapidxml.hpp"

namespace std {

	void XmlReader::_serialize( __b& nValue, const wchar_t * nName, __b nOptimal /*= false*/ )
	{
		nValue = nOptimal;
		XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
		if (null == xmlAttribute_)
		{
			return;
		}
		string text_ = xmlAttribute_.InnerText;
		if (@"true" == text_)
		{
			nValue = true;
		}
		else if (@"false" == text_)
		{
			nValue = false;
		}
		else
		{
			nValue = nOptimal;
		}
	}

	void XmlReader::_serialize( __i8& nValue, const wchar_t * nName, __i8 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __u8& nValue, const wchar_t * nName, __u8 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __i16& nValue, const wchar_t * nName, __i16 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __u16& nValue, const wchar_t * nName, __u16 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __i32& nValue, const wchar_t * nName, __i32 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __u32& nValue, const wchar_t * nName, __u32 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __i64& nValue, const wchar_t * nName, __i64 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __u64& nValue, const wchar_t * nName, __u64 nOptimal /*= -1*/ )
	{

	}

	void XmlReader::_serialize( __s& nValue, const wchar_t * nName, const wchar_t * nOptimal /*= L""*/ )
	{

	}

	void XmlReader::_serialize( __f& nValue, const wchar_t * nName, __f nOptimal /*= 0.*/ )
	{

	}

	void XmlReader::_serialize( __d& nValue, const wchar_t * nName, __d nOptimal /*= 0.*/ )
	{

	}

	void XmlReader::_serialize( Stream * nValue, const wchar_t * nName )
	{

	}

	void XmlReader::_openUrl( string nUrl )
	{

	}

	std::SerializeIO_ XmlReader::_serializeIO()
	{

	}

	__i32 XmlReader::_pushStream( const wchar_t * nName )
	{

	}

	void XmlReader::_popStream()
	{

	}

	void XmlReader::_runClose()
	{

	}

}
