#ifndef Inc_h__
#define Inc_h__

#ifdef _MSC_VER
#define __pack
#else
#define __pack __attribute__((packed))
#endif

typedef char __i8;
typedef unsigned char __u8;

typedef short __i16;
typedef unsigned short __u16;

typedef long __i32;
typedef unsigned long __u32;

typedef __int64 __i64;
typedef unsigned __int64 __u64;

typedef double __d;

typedef float __f;

typedef bool __b;

#define NULL 0

#endif // Inc_h__
