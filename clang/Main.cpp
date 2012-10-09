#include "__signal.h"

#include <iostream>

typedef void (*_fun_t)();

struct IFun
{
	__signal mFuns;
};

void _fun0()
{
	std::cout << "fun0" << std::endl;
}

void _fun1()
{
	std::cout << "fun1" << std::endl;
}

void _fun2()
{
	std::cout << "fun2" << std::endl;
}

void _run(void * data)
{
	_fun_t fun = (_fun_t)data;
	fun();
}

int main( int argc, char * argv[] )
{
	IFun fun;
	__signal * signal_ = &(fun.mFuns);
	__signal_initialize(signal_);
	__signal_push_back(signal_, _fun0);
	__signal_push_back(signal_, _fun1);
	__signal_push_back(signal_, _fun2);
	__signal_run(signal_, _run);
	__signal_remove(signal_, _fun1);
	__signal_run(signal_, _run);
	__signal_uninitialized(signal_);
	__signal_run(signal_, _run);
	std::cin.get();
	return 0;
}
