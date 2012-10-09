#ifndef __singleton_h__
#define __singleton_h__

namespace std {

	template<class __t>
	class __singleton
	{
	public:
		static __t& __instance()
		{
			static __t t;
			return t;
		}
	};

}
#endif // __singleton_h__
