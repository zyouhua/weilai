#pragma once

#include "../../Incpp.hpp"

namespace std {

	class Dirty
	{
	public:
		void _runDirty();

		signal<bool ()> m_tIsDirty;
		virtual bool _isDirty();

	protected:
		void _saveDirty();

	public:
		Dirty();
		~Dirty();

	private:
		bool mIsDirtied;
	};

}
