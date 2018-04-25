using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataTypes;
namespace MemoryAllocationProject
{
	class allocationAlgorithms
	{
		static private int firstBlockFit(List<block> freeBlocks, int size)
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
		static private int bestBlockFit(List<block> freeBlocks, int size)
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
					else
					{
						minIndex = i;
					}
				}
			}
			return minIndex;
		}
		static private int worstBlockFit(List<block> freeBlocks, int size)
		{
			int maxIndex = -1;
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				if (freeBlocks[i].size >= size)
				{
					if (maxIndex != -1)
					{
						if (freeBlocks[i].size > freeBlocks[maxIndex].size)
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
		static private void allocate(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock, int freeBlockPlace)
		{
			block freePlace = freeBlocks[freeBlockPlace];
			allocatedBlock.startaddress = freePlace.startaddress;
			freePlace.size -= allocatedBlock.size;
			freePlace.startaddress += allocatedBlock.size;
			if (freePlace.size == 0)
			{
				freeBlocks.RemoveAt(freeBlockPlace);
			}
			else
			{
				freeBlocks[freeBlockPlace] = freePlace;
			}
			busyBlocks.Add(allocatedBlock);
		}
        static public void deallocate(List<block> freeBlocks, List<block> busyBlocks, int deallocatedBlockPlace)
		{
			//int deallocatedBlockPlace = -1;
			block busyPlace = busyBlocks[deallocatedBlockPlace];
			busyBlocks.RemoveAt(deallocatedBlockPlace);
			block freePlace = busyPlace;
			freeBlocks.Add(freePlace);
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			combineContFreePlaces(freeBlocks);
			
		}
		static public void compact(List<block> freeBlocks, List<block> busyBlocks, int memorySize)
		{
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			busyBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			for (int i = 0; i < freeBlocks.Count; i++) {
				Console.WriteLine(freeBlocks[i].startaddress+"--->"+ freeBlocks[i].size);
			}
			Console.WriteLine("*************");
			for (int i = 0; i < busyBlocks.Count; i++)
			{
				Console.WriteLine(busyBlocks[i].startaddress + "--->" + busyBlocks[i].size);
			}
			Console.WriteLine("*************");
			int freeblocksize = 0;
			int count = freeBlocks.Count;
			for (int i = 0; i < count; i++)
			{
				freeblocksize += freeBlocks[i].size;
			}
			freeBlocks.Clear();
			Console.WriteLine("freeblocksize="+freeblocksize);
			block freeblock;
			freeblock.name = "";
			freeblock.startaddress = memorySize - freeblocksize;
			freeblock.size = freeblocksize;
			freeBlocks.Add(freeblock);
			block busyblock;

			for (int i = 0; i < busyBlocks.Count; i++)
			{
				if (i == 0)
				{
					busyblock.size = busyBlocks[0].size;
					busyblock.startaddress = 0;
					busyblock.name = busyBlocks[0].name;
					busyBlocks[0] = busyblock;
				}
				else
				{
					busyblock.size = busyBlocks[i].size;
					busyblock.startaddress = busyBlocks[i - 1].startaddress + busyBlocks[i - 1].size;
					busyblock.name = busyBlocks[i].name;
					busyBlocks[i] = busyblock;
				}
			}
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				Console.WriteLine(freeBlocks[i].startaddress + "--->" + freeBlocks[i].size);
			}
			Console.WriteLine("*************");
			for (int i = 0; i < busyBlocks.Count; i++)
			{
				Console.WriteLine(busyBlocks[i].startaddress + "--->" + busyBlocks[i].size);
			}

		}
		static public void combineContFreePlaces(List<block> freeBlocks)
		{
			block contFreePlace; int end1, start2;
			for (int i = 0; i < freeBlocks.Count - 1; i++)
			{
				end1 = freeBlocks[i].startaddress + freeBlocks[i].size;
				start2 = freeBlocks[i + 1].startaddress;
				contFreePlace = freeBlocks[i];
				contFreePlace.size += freeBlocks[i + 1].size;
				if (end1 == start2)
				{
					freeBlocks[i] = contFreePlace;
					freeBlocks.RemoveAt(i + 1);

				}
			}
		}
		static public bool firstFit(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock)
		{
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			int freeBlockPlace;
			freeBlockPlace = firstBlockFit(freeBlocks, allocatedBlock.size);
			if (freeBlockPlace != -1)
			{
				allocate(freeBlocks, busyBlocks, allocatedBlock, freeBlockPlace);
				return true;
			}
			else
				return false;
		}
		static public bool bestFit(List<block> freeBlocks, List<block> busyBlocks, block allocatedBlock)
		{
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
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
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			int freeBlockPlace;
			freeBlockPlace = worstBlockFit(freeBlocks, allocatedBlock.size);
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
