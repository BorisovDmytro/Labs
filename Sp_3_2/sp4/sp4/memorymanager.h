#ifndef MEMORYMANAGER_H
#define MEMORYMANAGER_H

#include <QMutex>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

class MemoryManager
{
private:
  typedef struct m_block {
    long size;
    m_block *next;
    bool isFree;
  } MemmoryBlock;
  typedef MemoryBlock* MemoryBlockPtr;
public:
  MemoryManager(long size = 4096);
  ~MemoryManager();

  void *newMemory(long size);
  void deleteMemory(void *ptr);
private:
  const int blockSize = sizeof(MemoryBlock);
  MemoryBlockPtr firstBlock;
  long lSize;
private:
  void mergeFreeBlock();
  MemoryBlockPtr findFreeBlock(long size);
  void resizeAllMemory(long size);
};

#endif // MEMORYMANAGER_H
