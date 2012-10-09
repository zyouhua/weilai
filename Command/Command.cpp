#include "Command.hpp"

namespace std {

	static void _runCommand(ICommand * nCommand)
	{
		Command * command = reinterpret_cast<Command *>(nCommand->mCommand);
		command->_runCommand();
	}

	ICommand * Command::_getCommand()
	{
		return (&mCommand);
	}

	Command::Command()
	{
		mCommand.mCommand = reinterpret_cast<void *>(this);
		mCommand.mRunCommand = std::_runCommand;
	}

	Command::~Command()
	{
		mCommand.mCommand = NULL;
		mCommand.mRunCommand = NULL;
	}

}
