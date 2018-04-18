using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataTypes;
namespace MemoryAllocationProject
{
	class allocationAlgorithms
	{
		static private int firstBlockFit(List<block> freeBlocks, float size)
		{
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				if (freeBlocks[i].size >= size)
				{
					return i;
				}
			}
			return -1;
		}
		static private int bestBlockFit(List<block> freeBlocks, float size)
		{
			int minIndex = -1;
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				if (freeBlocks[i].size >= size)
				{
					if (minIndex != -1)
					{
						if (freeBlocks[i].size < freeBlocks[minIndex].size)
							minIndex = i;
					}
					else {
						minIndex = i;
					}
				}
			}
			return minIndex;
		}
		static private int worstBlockFit(List<block> freeBlocks, float size)
		{
			int maxIndex = 0;
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				if (freeBlocks[i].size <= size)
				{
					if (maxIndex != -1)
					{
						if (freeBlocks[i].size < freeBlocks[maxIndex].size)
							maxIndex = i;
					}
					else
					{
						maxIndex = i;
					}
				}
			}
			return maxIndex;
		}
		static private void allocate(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock, int freeBlockPlace) {
			block freePlace = freeBlocks[freeBlockPlace];
			allocatedBlock.startaddress = freePlace.startaddress;
			freePlace.size -= allocatedBlock.size;
			freePlace.startaddress += allocatedBlock.size;
			if (freePlace.size == 0)
			{
				freeBlocks.RemoveAt(freeBlockPlace);
			}
			else {
				freeBlocks[freeBlockPlace] = freePlace;
			}
			busyBlocks.Add(allocatedBlock);
		}
		static private void deallocate(List<block> freeBlocks, List<block> busyBlocks, string deallocatedBlockName)
		{
			int deallocatedBlockPlace = -1;
			for (int i = 0; i < busyBlocks.Count; i++) {
				if (busyBlocks[i].name == deallocatedBlockName)
				{
					deallocatedBlockPlace = i;
					break;
				}
			}
			block busyPlace = busyBlocks[deallocatedBlockPlace];
			busyBlocks.RemoveAt(deallocatedBlockPlace);
			block freePlace = busyPlace;
			freeBlocks.Add(freePlace);
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			combineContFreePlaces(freeBlocks);
		}
		static public void combineContFreePlaces (List<block> freeBlocks){
			block contFreePlace; float end1, start2;
			for (int i = 0; i < freeBlocks.Count; i++) {
				end1 = freeBlocks[i].startaddress + freeBlocks[i].size;
				start2 = freeBlocks[i+1].startaddress;
				contFreePlace= freeBlocks[i];
				contFreePlace.size += freeBlocks[i + 1].size;
				if (end1 == start2) {
					freeBlocks[i] = contFreePlace;
					freeBlocks.RemoveAt(i+1);

				}
			}
		}
		static public bool firstFit(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock) {
			int freeBlockPlace;
			freeBlockPlace = firstBlockFit(freeBlocks, allocatedBlock.size);
			if (freeBlockPlace != -1)
			{
				allocate(freeBlocks,busyBlocks, allocatedBlock, freeBlockPlace);
				return true;
			}
			else
				return false;
		}
		static public bool bestFit(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock)
		{
			int freeBlockPlace;
			freeBlockPlace = bestBlockFit(freeBlocks, allocatedBlock.size);
			if (freeBlockPlace != -1)
			{
				allocate(freeBlocks, busyBlocks, allocatedBlock, freeBlockPlace);
				return true;
			}
			else
				return false;
		}
		static public bool worstFit(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock)
		{
			int freeBlockPlace;
			freeBlockPlace = bestBlockFit(freeBlocks, allocatedBlock.size);
			if (freeBlockPlace != -1)
			{
				allocate(freeBlocks, busyBlocks, allocatedBlock, freeBlockPlace);
				return true;
			}
			else
				return false;
		}
	}
}
