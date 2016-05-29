QT += core
QT -= gui

CONFIG += c++11

TARGET = sp4
CONFIG += console
CONFIG -= app_bundle

TEMPLATE = app

SOURCES += main.cpp \
    memorymanager.cpp

HEADERS += \
    memorymanager.h
