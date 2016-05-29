#include "thread.h"
#include "controller.h"

#include <QDebug>

u_int32_t  _id = 0;

u_int32_t create_thread(run_func func, void* data) {
  //timer_lock();

  thread_t *ptr_thread = (thread_t *)malloc(sizeof(thread_t));
  ptr_thread->state = READY;
  ptr_thread->id = _id ++;
  ptr_thread->func = func;
  ptr_thread->data = data;

  ucontext_t *ptr_cntx = (ucontext_t *) malloc(sizeof(ucontext_t));
  getcontext(ptr_cntx);

  stack_t tmp_stack;
  memset(&tmp_stack, 0, sizeof(stack_t));
  tmp_stack.ss_sp = malloc(STACKSIZE);
  tmp_stack.ss_size = STACKSIZE;
  ptr_thread->stack = tmp_stack;

  ptr_cntx->uc_stack = ptr_thread->stack;

  ptr_thread->context = ptr_cntx;
  makecontext(ptr_thread->context, &thread_worker, 0);

  add_thread(ptr_thread);

  //timer_unlock();
  return ptr_thread->id;
}

void thread_worker() {
  thread_t *ptr = get_current();
  ptr->res = ptr->func(ptr->data);
  exit_thread(ptr);
}


void exit_thread(thread_t *ptr)
{
  ptr->state = FINESHED;
  shedule();
}

void run_thread(thread_t *ptr)
{
  ptr->state = RUN;
  thread_t *prev = get_current();
  set_current(ptr);
  if(prev->state == FINESHED) {
    free(prev->stack.ss_sp);
    free(prev->context);
    free(prev);
    setcontext(ptr->context);
  } else {
    swapcontext(prev->context, ptr->context);
  }
}

void sleep_thread(u_int32_t seconds)
{
  thread_t *ptr = get_current();
  ptr->state = SLEEP;
  ptr->wake_time = time(NULL) + seconds;
  add_sleep(ptr);
}
