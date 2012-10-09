#include "IUpdateSingleton.h"
#include "Update.hpp"

#include <iostream>

using namespace std;

class MyUpdate : public Update
{
public:
	void _runUpdate();
};

void MyUpdate::_runUpdate()
{
	std::cout << "hello world" << std::endl;
}

int main( int argc, char * argv[] )
{
	MyUpdate myupdate;
	UpdateSingleton_initialize();
	UpdateSingleton_registerUpdate(myupdate._getUpdate());
	UpdateSingleton_runUpdate();
	UpdateSingleton_uninitialized();
	cin.get();
	return 0;
}
