QT += core
QT -= gui

TARGET = labUnix1
CONFIG += console
CONFIG -= app_bundle

TEMPLATE = app

SOURCES += main.cpp \
    thread.cpp \
    controller.cpp \
    test_function.cpp

HEADERS += \
    thread.h \
    controller.h \
    test_function.h

