namespace MemoryAllocationProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.scale_button = new System.Windows.Forms.Button();
			this.scale_label = new System.Windows.Forms.Label();
			this.scale_textBox = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.holeclear = new System.Windows.Forms.Button();
			this.holeedit = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.holeaddresstextBox = new System.Windows.Forms.TextBox();
			this.holesizetextBox = new System.Windows.Forms.TextBox();
			this.holebutton = new System.Windows.Forms.Button();
			this.resetbutton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.memorybutton = new System.Windows.Forms.Button();
			this.memorytextBox3 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.allocatebutton = new System.Windows.Forms.Button();
			this.processsize = new System.Windows.Forms.TextBox();
			this.processname = new System.Windows.Forms.TextBox();
			this.processesbutton = new System.Windows.Forms.Button();
			this.deallocatebutton = new System.Windows.Forms.Button();
			this.compactbutton = new System.Windows.Forms.Button();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox5
			// 
			this.groupBox5.AutoSize = true;
			this.groupBox5.Controls.Add(this.scale_button);
			this.groupBox5.Controls.Add(this.scale_label);
			this.groupBox5.Controls.Add(this.scale_textBox);
			this.groupBox5.Location = new System.Drawing.Point(448, 22);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(294, 340);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Memory";
			// 
			// scale_button
			// 
			this.scale_button.Enabled = false;
			this.scale_button.Location = new System.Drawing.Point(69, 17);
			this.scale_button.Name = "scale_button";
			this.scale_button.Size = new System.Drawing.Size(75, 23);
			this.scale_button.TabIndex = 23;
			this.scale_button.Text = "Apply";
			this.scale_button.UseVisualStyleBackColor = true;
			this.scale_button.Visible = false;
			this.scale_button.Click += new System.EventHandler(this.scale_button_Click);
			// 
			// scale_label
			// 
			this.scale_label.AutoSize = true;
			this.scale_label.Location = new System.Drawing.Point(9, 21);
			this.scale_label.Name = "scale_label";
			this.scale_label.Size = new System.Drawing.Size(34, 13);
			this.scale_label.TabIndex = 22;
			this.scale_label.Text = "Scale";
			this.scale_label.Visible = false;
			// 
			// scale_textBox
			// 
			this.scale_textBox.Location = new System.Drawing.Point(45, 18);
			this.scale_textBox.Name = "scale_textBox";
			this.scale_textBox.Size = new System.Drawing.Size(22, 20);
			this.scale_textBox.TabIndex = 21;
			this.scale_textBox.Text = "1";
			this.scale_textBox.Visible = false;
			this.scale_textBox.TextChanged += new System.EventHandler(this.scale_textBox_TextChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.groupBox4.Controls.Add(this.holeclear);
			this.groupBox4.Controls.Add(this.holeedit);
			this.groupBox4.Controls.Add(this.dataGridView1);
			this.groupBox4.Location = new System.Drawing.Point(235, 23);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(193, 170);
			this.groupBox4.TabIndex = 17;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Memory Holes";
			// 
			// holeclear
			// 
			this.holeclear.Enabled = false;
			this.holeclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.holeclear.Location = new System.Drawing.Point(105, 131);
			this.holeclear.Name = "holeclear";
			this.holeclear.Size = new System.Drawing.Size(75, 23);
			this.holeclear.TabIndex = 13;
			this.holeclear.Text = "Clear";
			this.holeclear.UseVisualStyleBackColor = true;
			this.holeclear.Click += new System.EventHandler(this.holeclear_Click);
			// 
			// holeedit
			// 
			this.holeedit.Enabled = false;
			this.holeedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.holeedit.Location = new System.Drawing.Point(14, 131);
			this.holeedit.Name = "holeedit";
			this.holeedit.Size = new System.Drawing.Size(75, 23);
			this.holeedit.TabIndex = 11;
			this.holeedit.Text = "Edit";
			this.holeedit.UseVisualStyleBackColor = true;
			this.holeedit.Click += new System.EventHandler(this.holeedit_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(166, 106);
			this.dataGridView1.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.holeaddresstextBox);
			this.groupBox1.Controls.Add(this.holesizetextBox);
			this.groupBox1.Controls.Add(this.holebutton);
			this.groupBox1.Location = new System.Drawing.Point(12, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 88);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Memory Holes";
			// 
			// holeaddresstextBox
			// 
			this.holeaddresstextBox.Enabled = false;
			this.holeaddresstextBox.Location = new System.Drawing.Point(9, 28);
			this.holeaddresstextBox.Name = "holeaddresstextBox";
			this.holeaddresstextBox.Size = new System.Drawing.Size(100, 20);
			this.holeaddresstextBox.TabIndex = 2;
			this.holeaddresstextBox.Text = "Enter start address";
			this.holeaddresstextBox.Click += new System.EventHandler(this.holeaddresstextBox_Click);
			this.holeaddresstextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.holeaddresstextBox_KeyDown);
			this.holeaddresstextBox.Leave += new System.EventHandler(this.holeaddresstextBox_Leave);
			// 
			// holesizetextBox
			// 
			this.holesizetextBox.Enabled = false;
			this.holesizetextBox.Location = new System.Drawing.Point(9, 54);
			this.holesizetextBox.Name = "holesizetextBox";
			this.holesizetextBox.Size = new System.Drawing.Size(100, 20);
			this.holesizetextBox.TabIndex = 3;
			this.holesizetextBox.Text = "Enter size of hole";
			this.holesizetextBox.Enter += new System.EventHandler(this.holesizetextBox_Enter);
			this.holesizetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.holesizetextBox_KeyDown);
			this.holesizetextBox.Leave += new System.EventHandler(this.holesizetextBox_Leave);
			// 
			// holebutton
			// 
			this.holebutton.AutoSize = true;
			this.holebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.holebutton.Enabled = false;
			this.holebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.holebutton.Location = new System.Drawing.Point(117, 39);
			this.holebutton.Name = "holebutton";
			this.holebutton.Size = new System.Drawing.Size(75, 23);
			this.holebutton.TabIndex = 0;
			this.holebutton.Text = "Add Hole";
			this.holebutton.UseVisualStyleBackColor = false;
			this.holebutton.Click += new System.EventHandler(this.holebutton_Click);
			// 
			// resetbutton
			// 
			this.resetbutton.Enabled = false;
			this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.resetbutton.Location = new System.Drawing.Point(12, 333);
			this.resetbutton.Name = "resetbutton";
			this.resetbutton.Size = new System.Drawing.Size(77, 41);
			this.resetbutton.TabIndex = 18;
			this.resetbutton.Text = "Reset";
			this.resetbutton.UseVisualStyleBackColor = true;
			this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.memorybutton);
			this.groupBox2.Controls.Add(this.memorytextBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 78);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Memory Size";
			// 
			// memorybutton
			// 
			this.memorybutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.memorybutton.Enabled = false;
			this.memorybutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.memorybutton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.memorybutton.Location = new System.Drawing.Point(112, 49);
			this.memorybutton.Name = "memorybutton";
			this.memorybutton.Size = new System.Drawing.Size(75, 23);
			this.memorybutton.TabIndex = 1;
			this.memorybutton.Text = "Submit";
			this.memorybutton.UseVisualStyleBackColor = false;
			this.memorybutton.Click += new System.EventHandler(this.memorybutton_Click);
			// 
			// memorytextBox3
			// 
			this.memorytextBox3.Location = new System.Drawing.Point(21, 19);
			this.memorytextBox3.Name = "memorytextBox3";
			this.memorytextBox3.Size = new System.Drawing.Size(166, 20);
			this.memorytextBox3.TabIndex = 0;
			this.memorytextBox3.Text = "Enter Memory size";
			this.memorytextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.memorytextBox3.Click += new System.EventHandler(this.memorytextBox3_Click);
			this.memorytextBox3.TextChanged += new System.EventHandler(this.memorytextBox3_TextChanged);
			this.memorytextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memorytextBox3_KeyDown);
			this.memorytextBox3.Leave += new System.EventHandler(this.memorytextBox3_Leave);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Controls.Add(this.allocatebutton);
			this.groupBox3.Controls.Add(this.processsize);
			this.groupBox3.Controls.Add(this.processname);
			this.groupBox3.Controls.Add(this.processesbutton);
			this.groupBox3.Location = new System.Drawing.Point(12, 199);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(416, 117);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Add Process";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Select an algorithm";
			this.label1.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(21, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(206, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Visible = false;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// allocatebutton
			// 
			this.allocatebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.allocatebutton.Enabled = false;
			this.allocatebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.allocatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allocatebutton.Location = new System.Drawing.Point(312, 34);
			this.allocatebutton.Name = "allocatebutton";
			this.allocatebutton.Size = new System.Drawing.Size(91, 47);
			this.allocatebutton.TabIndex = 3;
			this.allocatebutton.Text = "Allocate";
			this.allocatebutton.UseVisualStyleBackColor = false;
			this.allocatebutton.Visible = false;
			this.allocatebutton.Click += new System.EventHandler(this.allocatebutton_Click);
			// 
			// processsize
			// 
			this.processsize.Location = new System.Drawing.Point(127, 76);
			this.processsize.Name = "processsize";
			this.processsize.Size = new System.Drawing.Size(100, 20);
			this.processsize.TabIndex = 2;
			this.processsize.Text = "Process Size";
			this.processsize.Visible = false;
			this.processsize.Enter += new System.EventHandler(this.processsize_Enter);
			this.processsize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.processsize_KeyDown);
			this.processsize.Leave += new System.EventHandler(this.processsize_Leave);
			// 
			// processname
			// 
			this.processname.Location = new System.Drawing.Point(21, 76);
			this.processname.Name = "processname";
			this.processname.Size = new System.Drawing.Size(100, 20);
			this.processname.TabIndex = 1;
			this.processname.Text = "Process name";
			this.processname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.processname.Visible = false;
			this.processname.Enter += new System.EventHandler(this.processname_Enter);
			this.processname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.processname_KeyDown);
			this.processname.Leave += new System.EventHandler(this.processname_Leave);
			// 
			// processesbutton
			// 
			this.processesbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.processesbutton.Enabled = false;
			this.processesbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.processesbutton.Location = new System.Drawing.Point(157, 47);
			this.processesbutton.Name = "processesbutton";
			this.processesbutton.Size = new System.Drawing.Size(100, 23);
			this.processesbutton.TabIndex = 0;
			this.processesbutton.Text = "Add processes";
			this.processesbutton.UseVisualStyleBackColor = false;
			this.processesbutton.Click += new System.EventHandler(this.processesbutton_Click);
			// 
			// deallocatebutton
			// 
			this.deallocatebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.deallocatebutton.Enabled = false;
			this.deallocatebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.deallocatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deallocatebutton.Location = new System.Drawing.Point(351, 333);
			this.deallocatebutton.Name = "deallocatebutton";
			this.deallocatebutton.Size = new System.Drawing.Size(77, 41);
			this.deallocatebutton.TabIndex = 19;
			this.deallocatebutton.Text = "Deallocate";
			this.deallocatebutton.UseVisualStyleBackColor = false;
			this.deallocatebutton.Visible = false;
			this.deallocatebutton.Click += new System.EventHandler(this.deallocatebutton_Click);
			// 
			// compactbutton
			// 
			this.compactbutton.Enabled = false;
			this.compactbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.compactbutton.Location = new System.Drawing.Point(95, 334);
			this.compactbutton.Name = "compactbutton";
			this.compactbutton.Size = new System.Drawing.Size(77, 40);
			this.compactbutton.TabIndex = 20;
			this.compactbutton.Text = "Compact";
			this.compactbutton.UseVisualStyleBackColor = true;
			this.compactbutton.Visible = false;
			this.compactbutton.Click += new System.EventHandler(this.compactbutton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(770, 399);
			this.Controls.Add(this.compactbutton);
			this.Controls.Add(this.deallocatebutton);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.resetbutton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox5);
			this.Name = "Form1";
			this.Text = "Memory Allocation";
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button holeclear;
		private System.Windows.Forms.Button holeedit;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox holeaddresstextBox;
		private System.Windows.Forms.TextBox holesizetextBox;
		private System.Windows.Forms.Button holebutton;
		private System.Windows.Forms.Button resetbutton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button memorybutton;
		private System.Windows.Forms.TextBox memorytextBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button allocatebutton;
		private System.Windows.Forms.TextBox processsize;
		private System.Windows.Forms.TextBox processname;
		private System.Windows.Forms.Button processesbutton;
		private System.Windows.Forms.Button deallocatebutton;
		private System.Windows.Forms.Button compactbutton;
		private System.Windows.Forms.TextBox scale_textBox;
		private System.Windows.Forms.Label scale_label;
		private System.Windows.Forms.Button scale_button;
	}
}

