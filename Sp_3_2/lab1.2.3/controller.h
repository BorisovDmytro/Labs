#ifndef CONTROLLER_H
#define CONTROLLER_H

#define NEXTTHREAD 1

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <time.h>

#include "thread.h"
#include <QList>

void shedule();
void add_thread(thread_t *ptr);
void add_sleep(thread_t *ptr);
void chek_speep();
void* main_func(void*);
void init_controller();
void start_controller();
void next_itr();
void timer_handler(int, siginfo_t*, void*);
void init_timer();
void timer_lock();
void timer_unlock();
thread_t *get_current();
void set_current(thread_t *ptr);
void run_thread(thread_t *ptr);

#endif // CONTROLLER_H
