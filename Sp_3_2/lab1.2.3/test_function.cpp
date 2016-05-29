#include "test_function.h"
#include <QDebug>

int fib(int i)

{
  if(i < 1) return 0;
  if(i == 1) return 1;
  return fib(i-1) + fib(i - 2);
}

void run_test(int index)
{
  qDebug( ) << "START THREAD " << index;
  for(int i = 0; i < 5; i++) {
      qDebug( ) << " THREAD " << index;
      fib(40);
  }
  qDebug( ) << "END THREAD " << index;
}

void *func(void *ptr)
{
  int index = *(int*)ptr;
  run_test(index);
  return ptr;
}

