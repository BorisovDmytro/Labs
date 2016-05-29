#include <QCoreApplication>

#include <QDebug>
#include "controller.h"
#include "test_function.h"



int main(int argc, char *argv[])
{
  QCoreApplication a(argc, argv);

  init_controller();

  for(int i = 0; i < 5; i++) {
    create_thread(func, new int(i));
  }

  start_controller();
  return a.exec();
}

