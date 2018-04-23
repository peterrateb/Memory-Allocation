using dataTypes;
using MemoryAllocationProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryOSproject
{
    public partial class Form1 : Form
    {
        int memorysize;
        int holeno=0;
        int processno = 0;
        DataTable dtholes = new DataTable();
        DataTable dtprocess = new DataTable();
        List<block> freeBlocks = new List<block>();
        List<block> busyBlocks = new List<block>();
        Label[] memblock;
        Label[] memaddress;
        public Form1()
        {
            InitializeComponent();
            dtholes.Columns.Add("no", typeof(int));
            dtholes.Columns.Add("start", typeof(int));
            dtholes.Columns.Add("Size", typeof(int));
            dtprocess.Columns.Add("Process name", typeof(string));
            dtprocess.Columns.Add("Size", typeof(int));
            //dtholes.Columns.Add("Type", typeof(string));
            comboBox1.Items.Add("First Fit");
            comboBox1.Items.Add("Best Fit");
            comboBox1.Items.Add("Worst Fit");

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            memorysize = 0;
            holeno = 0;
            //processno = 0;
            dtholes.Clear();
            dtprocess.Clear();
            memorytextBox3.Text = "Enter Memory size";
            holeaddresstextBox.Text = "Enter start address";
            holesizetextBox.Text = "Enter size of hole";
            holebutton.Text = "Add hole";

            memorybutton.Enabled = true;
            memorytextBox3.Enabled = true;
            holeaddresstextBox.Enabled = false;
            holesizetextBox.Enabled = false;
            processesbutton.Enabled = false;
            holebutton.Enabled = false;
            //holebutton.Enabled = false;
            //holeaddresstextBox.Enabled = false;
            //holesizetextBox.Enabled = false;
            holeedit.Enabled = false;
            //holedelete.Enabled = false;
            holeclear.Enabled = false;
            processesbutton.Visible = true;
            processname.Visible = false;
            processsize.Visible = false;
            allocatebutton.Visible = false;
            allocatebutton.Enabled = false;
            label1.Visible = false;
            comboBox1.Visible = false;
            deleteMemory();
        }

        

        private void memorytextBox3_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(memorytextBox3.Text, out n))
            {
                memorybutton.Enabled = true;
            }
            else
                memorybutton.Enabled = false;
        }

        private void memorybutton_Click(object sender, EventArgs e)
        {
            bool parsed = Int32.TryParse(memorytextBox3.Text, out memorysize);
            if (!parsed)
            {
                MessageBox.Show("please Enter a positive integer size of memory", "Warning");
            }
            else
            {
                memorytextBox3.Enabled = false;
                memorybutton.Enabled = false;
                holeaddresstextBox.Enabled = true;
                holesizetextBox.Enabled = true;
                processesbutton.Enabled = true;
                holebutton.Enabled = true;
                holeedit.Enabled = true;
                holeclear.Enabled = true;

            }
        }

        private void memorytextBox3_Click(object sender, EventArgs e)
        {
            memorytextBox3.Clear();
        }

        private void memorytextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                memorybutton.PerformClick();
           
        }

        private void holeaddresstextBox_Click(object sender, EventArgs e)
        {
            if (holeaddresstextBox.Text == "Enter start address")
            holeaddresstextBox.Clear();
        }

        private void memorytextBox3_Leave(object sender, EventArgs e)
        {
            if (memorytextBox3.Text == "")
                memorytextBox3.Text = "Enter Memory size";
        }

        private void holeaddresstextBox_Leave(object sender, EventArgs e)
        {
            if (holeaddresstextBox.Text == "")
                holeaddresstextBox.Text = "Enter start address";
        }

        private void holesizetextBox_Enter(object sender, EventArgs e)
        {
            if(holesizetextBox.Text=="Enter size of hole")
                holesizetextBox.Clear();
        }

        private void holesizetextBox_Leave(object sender, EventArgs e)
        {
            if(holesizetextBox.Text=="")
                holesizetextBox.Text = "Enter size of hole";
        }

        private void holebutton_Click(object sender, EventArgs e)
        {
            int holestartaddrs;
            int holesize;
            bool parsedaddrs = Int32.TryParse(holeaddresstextBox.Text, out holestartaddrs);
            bool parsedsize = Int32.TryParse(holesizetextBox.Text, out holesize);
           
            if (!parsedaddrs || !parsedsize)
                MessageBox.Show("Hole start address and it's size must be positive integer value", "Error");
            else
            {
                validatehole(holestartaddrs, holesize);
            }
            //Console.WriteLine("/" + dtholes.Rows[0][1] + "--->" + dtholes.Rows[0][2] + "/");
            //Console.WriteLine("/" + dtholes.Rows[1][1] + "--->" + dtholes.Rows[1][2] + "/");
            if (holeno != 0)
            {
                holebutton.Text = "Add new hole";
                holeedit.Enabled = true;
                holeclear.Enabled = true;
                //holedelete.Enabled = true;

            }
        }
       
        private void holeaddresstextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                holebutton.PerformClick();
        }

        private void holesizetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                holebutton.PerformClick();
        }

        private void holeedit_Click(object sender, EventArgs e)
        {
            if (holeedit.Text == "Edit")
            {
                dataGridView1.ReadOnly = false;
                holeedit.Text = "Finish";
            }
            else if (holeedit.Text == "Finish")
            {
                dataGridView1.ReadOnly = true;
                holeedit.Text = "Edit";
            }
        }

        private void holeclear_Click(object sender, EventArgs e)
        {
            dtholes.Clear();
            holeno = 0;
        }

        private void processesbutton_Click(object sender, EventArgs e)
        {
            holebutton.Enabled = false;
            holeaddresstextBox.Enabled = false;
            holesizetextBox.Enabled = false;
            holeedit.Enabled = false;
            //holedelete.Enabled = false;
            holeclear.Enabled = false;
            processesbutton.Visible = false;
            processname.Visible = true;
            processsize.Visible = true;
            allocatebutton.Visible = true;
            label1.Visible = true;
            comboBox1.Visible = true;
            for (int i = 0; i < dtholes.Rows.Count; i++)
            {
                block freeblock = new block() ;
                Int32.TryParse(dtholes.Rows[i][1].ToString(), out freeblock.startaddress);
                Int32.TryParse((dtholes.Rows[i][2].ToString()),out freeblock.size);
                //string startadd = dtholes.Rows[i][1].ToString();
                //string size = dtholes.Rows[i][2].ToString();
                //int sizeint;
                //int startaddint;

                freeBlocks.Add(freeblock);
            }
            allocationAlgorithms.combineContFreePlaces(freeBlocks);
            DrawMemory(freeBlocks, memorysize, 1);

        }

        private void processname_Enter(object sender, EventArgs e)
        {
            if (processname.Text == "Process name")
                processname.Clear();
        }

        private void processname_Leave(object sender, EventArgs e)
        {
            if (processname.Text == "")
                processname.Text = "Process name";
        }

        private void processsize_Enter(object sender, EventArgs e)
        {
            if (processsize.Text == "Process Size")
                processsize.Clear();
         
        }

        private void processsize_Leave(object sender, EventArgs e)
        {
            if (processsize.Text == "")
                processsize.Text = "Process Size";
        }

        private void validatehole(int start, int size)
        {
            if (start > memorysize)
            {
                MessageBox.Show("please Enter start adress less than Memory size", "Error");
            }
            else if (start + size > memorysize)
            {
                MessageBox.Show("please, check hole size correctness", "Error");
            }
            else
            {
                holeno++;

                dtholes.Rows.Add(dtholes.Rows.Count, start, size);
                dataGridView1.DataSource = dtholes;

            }

        }

        private void takeprocessdata (string name , int size)
        {
            if (size > memorysize)
            {
                MessageBox.Show("process is out of range", "Memory Error");
            }
            else
            {
                processno++;
                dtprocess.Rows.Add(name, size);
                //dataGridView2.DataSource = dtprocess;
            }

        }

        private void allocatebutton_Click(object sender, EventArgs e)
        {

            string name;
            int size;
            name = processname.Text;
            bool parsedsize = Int32.TryParse(processsize.Text, out size);

            if (!parsedsize)
                MessageBox.Show("process size must be positive integer value", "Error");
            else if (name == "" || name == "Process name")
            {
                MessageBox.Show("Name of process missed", "Error");
            }
            else
            {
                takeprocessdata(name, size);
                processname.Text = "Process name";
                processsize.Text = "Process Size";
            }
            /*
            if (processno != 0)
            {
                processclear.Enabled = true;
                processedit.Enabled = true;

            }
             */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                allocatebutton.Enabled = true;

        }

        private void processname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                allocatebutton.PerformClick();
        }

        private void processsize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                allocatebutton.PerformClick();
        }

        int scale = 1;
        private void DrawMemory(List<block> free, int memosize , int s)
        {
            memaddress = new Label[freeBlocks.Count*2 + 2];
            memblock = new Label[freeBlocks.Count *2 + 1];
            int startpoint = 30;
            int address = 0;
            memaddress[0] = new Label();
            memaddress[0].Location = new Point(10 , startpoint-5); 
            memaddress[0].AutoSize = true;
            memaddress[0].BackColor = System.Drawing.Color.Transparent;
            memaddress[0].Text = "0";
            memaddress[0].Font = new Font("Microsoft Sans Serif", 9 + s / 2);
            memaddress[0].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.groupBox5.Controls.Add(memaddress[0]);
            for (int i = 0; i < freeBlocks.Count; i++)
            {
                int blackblockhieght = (freeBlocks[i].startaddress - address) * s;
                int holeblockhieght = (freeBlocks[i].size) * s;
                bool smallhieght = false;
                if (blackblockhieght < 20)
                {
                    blackblockhieght = 20;
                    smallhieght = true;
                }
                memblock[i * 2] = new Label();
                memblock[i * 2].Location = new Point(50,startpoint);
                memblock[i * 2].Size = new System.Drawing.Size(200, blackblockhieght);
                memblock[i * 2].BackColor = System.Drawing.Color.Black;

                startpoint += blackblockhieght;
                address = freeBlocks[i].startaddress;
                memaddress[i * 2 + 1] = new Label();
                memaddress[i * 2 + 1].Location = new Point(10, startpoint - 5); //startpoint here is the next start point
                memaddress[i * 2 + 1].AutoSize = true;
                memaddress[i * 2 + 1].BackColor = System.Drawing.Color.Transparent;
                memaddress[i * 2 + 1].Text = address.ToString();
                memaddress[i * 2 + 1].Font = new Font("Microsoft Sans Serif", 9 + s / 2);
                memaddress[i * 2 + 1].TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                memblock[i * 2 + 1] = new Label();
                memblock[i * 2 + 1].Location = new Point(50, startpoint);
                memblock[i * 2 + 1].Size = new System.Drawing.Size(200, holeblockhieght);
                memblock[i * 2 + 1].BackColor = System.Drawing.Color.White;
                startpoint += holeblockhieght;
                address += freeBlocks[i].size;
                memaddress[i * 2 + 2] = new Label();
                memaddress[i * 2 + 2].Location = new Point(10, startpoint - 5); //startpoint here is the next start point
                memaddress[i * 2 + 2].AutoSize = true;
                memaddress[i * 2 + 2].BackColor = System.Drawing.Color.Transparent;
                memaddress[i * 2 + 2].Text = address.ToString();
                memaddress[i * 2 + 2].Font = new Font("Microsoft Sans Serif", 9 + s / 2);
                memaddress[i * 2 + 2].TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                //memblock[i].Text = processname[i];
                //memblock[i].Font = new Font("Microsoft Sans Serif", 6);

                this.groupBox5.Controls.Add(memblock[i*2]);
                this.groupBox5.Controls.Add(memblock[i * 2+1]);
                this.groupBox5.Controls.Add(memaddress[i * 2 + 1]);
                this.groupBox5.Controls.Add(memaddress[i * 2 + 2]);
            }
            memblock[freeBlocks.Count * 2] = new Label();
            memblock[freeBlocks.Count * 2].Location = new Point(50, startpoint);
            memblock[freeBlocks.Count * 2].Size = new System.Drawing.Size(200, (memorysize-address) * s);
            memblock[freeBlocks.Count * 2].BackColor = System.Drawing.Color.Black;
            ///
            //Console.WriteLine("/" + freeBlocks.Count * 2 + "--->" + startpoint + "/");
            startpoint += (memorysize - address) * s;
            address = memorysize-1;
            memaddress[freeBlocks.Count * 2 + 1] = new Label();
            memaddress[freeBlocks.Count * 2 + 1].Location = new Point(10, startpoint - 5); //startpoint here is the next start point
            memaddress[freeBlocks.Count * 2 + 1].AutoSize = true;
            memaddress[freeBlocks.Count * 2 + 1].BackColor = System.Drawing.Color.Transparent;
            memaddress[freeBlocks.Count * 2 + 1].Text = address.ToString();
            memaddress[freeBlocks.Count * 2 + 1].Font = new Font("Microsoft Sans Serif", 9 + s / 2);
            memaddress[freeBlocks.Count * 2 + 1].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.groupBox5.Controls.Add(memblock[freeBlocks.Count * 2]);
            this.groupBox5.Controls.Add(memaddress[freeBlocks.Count * 2 + 1]);
            
        }

        private void deleteMemory()
        {
            this.groupBox5.Controls.Remove(memaddress[0]);
            this.groupBox5.Controls.Remove(memaddress[freeBlocks.Count * 2 + 1]);
            this.groupBox5.Controls.Remove(memblock[freeBlocks.Count * 2]);
            for (int i = 0; i < freeBlocks.Count*2; i++)
            {
                this.groupBox5.Controls.Remove(memblock[i]);
                this.groupBox5.Controls.Remove(memaddress[i + 1]);
            }
        }

        /*
        private void processedit_Click(object sender, EventArgs e)
        {
            if (processedit.Text == "Edit")
            {
                dataGridView2.ReadOnly = false;
                processedit.Text = "Finish";
            }
            else if (processedit.Text == "Finish")
            {
                dataGridView2.ReadOnly = true;
                processedit.Text = "Edit";
            }
        }

        private void processclear_Click(object sender, EventArgs e)
        {
            dtprocess.Clear();
            processno = 0;
        }
        */


    }
}
