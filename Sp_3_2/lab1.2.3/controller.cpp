#include "controller.h"
#include <QDebug>

QList<thread_t *> l_threads;
QList<thread_t *> l_sleep;
thread_t *curent;
thread_t *main_thread;

void timer_handler(int arg, siginfo_t *inf, void *ptr)
{
  shedule();
}

void next_itr()
{
  thread_t *ptr = get_current();
  if(ptr->state == RUN) {
    ptr->state = READY;
    l_threads.append(ptr);
  }
  alarm(NEXTTHREAD);
  thread_t *next;
  if(l_threads.size() == 0) {
    next = main_thread;
  } else {
    next = l_threads.takeFirst();
  }
  run_thread(next);
}

void init_controller()
{
  create_thread(main_func, NULL);
  main_thread = l_threads.takeFirst();
  main_thread->state = MAIN;
  curent = main_thread;
  init_timer();
}

void init_timer() {
  struct sigaction sa;
  memset(&sa, 0, sizeof(struct sigaction));
  sa.sa_sigaction = timer_handler;
  sa.sa_flags = SA_SIGINFO | SA_NODEFER;
  sigaction(SIGALRM, &sa, NULL);
}

void timer_lock(){
  sigset_t set;
  sigemptyset(&set);
  sigaddset(&set, SIGALRM);
  sigprocmask(SIG_BLOCK, &set, NULL);
}
void timer_unlock(){
  sigset_t set;
  sigemptyset(&set);
  sigaddset(&set, SIGALRM);
  sigprocmask(SIG_UNBLOCK, &set, NULL);
}

thread_t *get_current()
{
  return curent;
}

void *main_func(void *)
{
  qDebug() << "RUN CONTROLLER";
  while (1) {}
  return NULL;
}

void start_controller()
{
  qDebug() << "start_controller";
  alarm(NEXTTHREAD);
  setcontext(main_thread->context);
}

void set_current(thread_t *ptr)
{
  curent = ptr;
}

void add_thread(thread_t *ptr)
{
  l_threads.append(ptr);
}

void shedule()
{
  chek_speep();
  next_itr();
}

void add_sleep(thread_t *ptr)
{
  l_sleep.append(ptr);
}

void chek_speep()
{
  for (int i = 0; i < l_sleep.size(); ++i) {
    thread_t *ptr = l_sleep.at(i);
    if(ptr->wake_time > time(NULL)) {
      ptr->state = READY;
      l_sleep.removeAt(i);
      l_threads.append(ptr);
    }
  }
}
