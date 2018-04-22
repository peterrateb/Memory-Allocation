using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataTypes;

namespace MemoryAllocationProject
{
	public partial class Form1 : Form
	{
		List<block> freeBlocks = new List<block>();
		List<block> busyBlocks = new List<block>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			block[] blocks = new block[5];
			blocks[0].startaddress = 50;
			blocks[0].size = 100;
			blocks[1].startaddress = 200;
			blocks[1].size = 50;
			blocks[2].startaddress = 20;
			blocks[2].size = 30;
			blocks[3].startaddress = 350;
			blocks[3].size = 50;
			blocks[4].startaddress = 400;
			blocks[4].size = 50;
			for (int i = 0; i < 5; i++) {
				freeBlocks.Add(blocks[i]);
			}
			freeBlocks.Sort((x, y) => x.startaddress.CompareTo(y.startaddress));
			for (int i = 0; i < freeBlocks.Count; i++)
			{
				
					Console.WriteLine("/" + freeBlocks[i].startaddress+"--->"+freeBlocks[i].size + "/" );
				

			}
			allocationAlgorithms.combineContFreePlaces(freeBlocks);
			for (int i = 0; i < freeBlocks.Count; i++)
			{

				Console.WriteLine("/" + freeBlocks[i].startaddress + "--->" + freeBlocks[i].size + "/");


			}
		}
	}
}
