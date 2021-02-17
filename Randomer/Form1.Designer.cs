
namespace Randomer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Picker = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editItems = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grouper = new System.Windows.Forms.TabPage();
            this.Sequencer = new System.Windows.Forms.TabPage();
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.File.SuspendLayout();
            this.Help.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Picker.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDown = this.File;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // File
            // 
            this.File.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveToFile});
            this.File.Name = "contextMenuStrip1";
            this.File.OwnerItem = this.toolStripMenuItem1;
            this.File.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.File.Size = new System.Drawing.Size(202, 52);
            this.File.Opening += new System.ComponentModel.CancelEventHandler(this.File_Opening);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(201, 24);
            this.openFile.Text = "Import-Open File";
            // 
            // saveToFile
            // 
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(201, 24);
            this.saveToFile.Text = "Export-Save to file";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDown = this.Help;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // Help
            // 
            this.Help.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Help.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.Help.Name = "contextMenuStrip1";
            this.Help.OwnerItem = this.toolStripMenuItem2;
            this.Help.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Help.Size = new System.Drawing.Size(120, 28);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(119, 24);
            this.About.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Picker);
            this.tabControl1.Controls.Add(this.Grouper);
            this.tabControl1.Controls.Add(this.Sequencer);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 536);
            this.tabControl1.TabIndex = 2;
            // 
            // Picker
            // 
            this.Picker.Controls.Add(this.groupBox2);
            this.Picker.Controls.Add(this.groupBox1);
            this.Picker.Location = new System.Drawing.Point(4, 29);
            this.Picker.Name = "Picker";
            this.Picker.Padding = new System.Windows.Forms.Padding(3);
            this.Picker.Size = new System.Drawing.Size(942, 503);
            this.Picker.TabIndex = 0;
            this.Picker.Text = "Picker";
            this.Picker.UseVisualStyleBackColor = true;
            this.Picker.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appearance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editItems);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Items name by:";
            // 
            // editItems
            // 
            this.editItems.Enabled = false;
            this.editItems.Location = new System.Drawing.Point(427, 54);
            this.editItems.Name = "editItems";
            this.editItems.Size = new System.Drawing.Size(339, 29);
            this.editItems.TabIndex = 16;
            this.editItems.Text = "Edit Items";
            this.editItems.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(295, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Numbers";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(656, 21);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(110, 27);
            this.numericUpDown2.TabIndex = 15;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(295, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 24);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Words";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(489, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 27);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "to";
            // 
            // Grouper
            // 
            this.Grouper.Location = new System.Drawing.Point(4, 29);
            this.Grouper.Name = "Grouper";
            this.Grouper.Padding = new System.Windows.Forms.Padding(3);
            this.Grouper.Size = new System.Drawing.Size(942, 503);
            this.Grouper.TabIndex = 1;
            this.Grouper.Text = "Grouper";
            this.Grouper.UseVisualStyleBackColor = true;
            // 
            // Sequencer
            // 
            this.Sequencer.Location = new System.Drawing.Point(4, 29);
            this.Sequencer.Name = "Sequencer";
            this.Sequencer.Padding = new System.Windows.Forms.Padding(3);
            this.Sequencer.Size = new System.Drawing.Size(942, 503);
            this.Sequencer.TabIndex = 2;
            this.Sequencer.Text = "Sequencer";
            this.Sequencer.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(181, 584);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(141, 31);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save setting to file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Import setting from file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Randomer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.File.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Picker.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Picker;
        private System.Windows.Forms.TabPage Grouper;
        private System.Windows.Forms.TabPage Sequencer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem saveToFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editItems;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

