#pragma once

#include "../../Incpp.hpp"

namespace std {

	class Dirty
	{
	public:
		signal<bool ()> m_tIsDirty;
		virtual bool _isDirty();
		void _runDirty();

	protected:
		void _saveDirty();

	public:
		Dirty();
		virtual ~Dirty();

	private:
		bool mIsDirtied;
	};

}
