#include "memorymanager.h"

MemoryManager::MemoryManager(long size)
{
  this->lSize = size;
  this->firstBlock = (MemoryBlockPtr)malloc(size + blockSize);
  this->firstBlock->size = size;
  this->firstBlock->next = nullptr;
  this->firstBlock->isFree = true;
}

MemoryManager::~MemoryManager()
{
  free(this->firstBlock);
}

void *MemoryManager::newMemory(long size)
{
  MemoryBlockPtr ptr = findFreeBlock(size);
  if(ptr == nullptr) {
    resizeAllMemmory(size);
    ptr = findFreeBlock(size);
  }

  return (void*)((long)ptr + blockSize);
}

void MemoryManager::deleteMemory(void *ptr)
{
  MemoryBlockPtr block = (MemoryBlockPtr)((long)ptr - blockSize);
  block->isFree = true;
  mergeFreeBlock();
}

void MemoryManager::mergeFreeBlock()
{
  MemoryBlockPtr ptr = this->firstBlock;
  while(ptr->next != nullptr) {
    if(ptr->isFree && ptr->next->isFree) {
      ptr->next = ptr->next->next;
      ptr->size += ptr->next->size;
    }
  }
}

MemoryManager::MemoryBlockPtr MemoryManager::findFreeBlock(long size)
{
  if(this->lSize < size) {
    return nullptr;
  }
  MemoryBlockPtr current = this->firstBlock;
  long findSize = size + blockSize;
  while(current->next != nullptr) {
    if(current->isFree && current->size >= findSize) {
      MemoryBlockPtr newBlock = (MemoryBlockPtr)((long)current + blockSize +
                                                   current->size - findSize);
      current->size -= findSize;
      newBlock->size = size;
      newBlock->isFree = false;
      newBlock->next = current->next;
      current->next = newBlock;
      return newBlock;
    }
  }
  return nullptr;
}

void MemoryManager::resizeAllMemmory(long size)
{
  MemoryBlockPtr block = (MemoryBlockPtr)malloc(this->lSize + size
                                                  + blockSize);
  memcpy(block, this->firstBlock, this->lSize);
  this->firstBlock = block;

  MemoryBlockPtr blkEnd = this->firstBlock;
  while(blkEnd->next != nullptr) blkEnd = blkEnd->next;
  lSize += size + blockSize;
  blkEnd->size += size + blockSize;
}
