#pragma once

#include "Create.hpp"
#include "UrlDel.hpp"
#include "ISave.h"

namespace std {

	class Save : public UrlDel, public Create
	{
	public:
		void _runSaveAs(const char * nUrl, const char * nName);
		void _runSaveAs(const char * nUrl);
		signal<void ()> m_tRunSave;
		virtual void _runSave();

		Save();
		virtual ~Save();
	private:
		ISave mSave;
	};

}
