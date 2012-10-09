#include "__signal.h"

#include <malloc.h>

void __signal_initialize(__signal * nSignal)
{
	nSignal->mHead = NULL;
	nSignal->mTail = NULL;
}

void __signal_push_back(__signal * nSignal, void * nData)
{
	__signal_node * signalnode = NULL;
	signalnode = (__signal_node *)calloc(1, sizeof(__signal_node));
	signalnode->mData = nData;
	signalnode->mNext = NULL;
	if (NULL == nSignal->mHead)
	{
		nSignal->mHead = signalnode;
		nSignal->mTail = signalnode;
	}
	else
	{
		nSignal->mTail->mNext = signalnode;
		nSignal->mTail = signalnode;
	}
}

void __signal_run(__signal * nSignal, _run_signal_t nRunSignal)
{
	__signal_node * signalnode = nSignal->mHead;
	for ( ; signalnode != NULL; signalnode = signalnode->mNext)
	{
		void * data = signalnode->mData;
		nRunSignal(data);
	}
}

void __signal_remove(__signal * nSignal, void * nData)
{
	__signal_node * prevnode = NULL;
	__signal_node * signalnode = nSignal->mHead;
	for ( ; signalnode != NULL; signalnode = signalnode->mNext)
	{
		void * data = signalnode->mData;
		if (nData != data)
		{
			prevnode = signalnode;
			continue;;
		}
		data = NULL;
		if (nSignal->mHead == nSignal->mTail)
		{
			free(signalnode);
			signalnode = NULL;
			nSignal->mHead = NULL;
			nSignal->mTail = NULL;
			break;
		}
		if (NULL == prevnode)
		{
			nSignal->mHead = signalnode->mNext;
			free(signalnode);
			signalnode = NULL;
			break;
		}
		if (NULL == signalnode->mNext)
		{
			nSignal->mTail = prevnode;
			free(signalnode);
			signalnode = NULL;
			break;
		}
		prevnode->mNext = signalnode->mNext;
		free(signalnode);
		signalnode = NULL;
		break;
	}
}

void __signal_uninitialized(__signal * nSignal)
{
	__signal_node * signalnode = nSignal->mHead;
	__signal_node * tempnode = NULL;
	for ( ; signalnode != NULL; )
	{
		void * data = signalnode->mData;
		data = NULL;
		tempnode = signalnode;
		signalnode = signalnode->mNext;
		free(tempnode);
		tempnode = NULL;
	}
	nSignal->mHead = NULL;
	nSignal->mTail = NULL;
}
