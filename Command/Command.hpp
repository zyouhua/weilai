#pragma once

#include "ICommand.h"

namespace std {

    class Command
    {
	public:
		virtual void _runCommand() = 0;
		ICommand * _getCommand();
		Command();
		virtual ~Command();
	private:
		ICommand mCommand;
    };

}
