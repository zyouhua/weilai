#ifndef __signal_h__
#define __signal_h__

#include "__signal-.h"

#ifdef __cplusplus
extern "C" {
#endif

	__funapi void __signal_initialize(__signal * nSignal);
	__funapi void __signal_push_back(__signal * nSignal, void * nData);
	__funapi void __signal_run(__signal * nSignal, _run_signal_t nRunSignal);
	__funapi void __signal_remove(__signal * nSignal, void * nData);
	__funapi void __signal_uninitialized(__signal * nSignal);

#ifdef __cplusplus
}
#endif
#endif // __signal_h__
