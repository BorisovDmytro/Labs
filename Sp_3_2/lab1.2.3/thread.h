#ifndef THREAD_H
#define THREAD_H

#define STACKSIZE 16384

#include <ucontext.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <time.h>

typedef void* (*run_func)(void* ) ;

enum State_Thread { RUN = 0, READY, FINESHED, SLEEP, MAIN };

typedef struct thread {
    State_Thread state;
    u_int32_t id;
    ucontext_t *context;
    run_func func;
    stack_t stack;
    void *data;
    void *res;
    int wake_time;
} thread_t;

u_int32_t create_thread(run_func func, void* data);
void thread_worker();
void exit_thread(thread_t *ptr);
void run_thread(thread_t *ptr);
void sleep_thread(int seconds);

#endif // THREAD_H
