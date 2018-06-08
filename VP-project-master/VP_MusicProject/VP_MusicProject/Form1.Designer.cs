namespace VP_MusicProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTempo = new System.Windows.Forms.GroupBox();
            this.btnTempo = new System.Windows.Forms.Button();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSlow = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNewNotes = new System.Windows.Forms.Button();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.rbN2 = new System.Windows.Forms.RadioButton();
            this.rbN3 = new System.Windows.Forms.RadioButton();
            this.rbN4 = new System.Windows.Forms.RadioButton();
            this.rbN5 = new System.Windows.Forms.RadioButton();
            this.rbN6 = new System.Windows.Forms.RadioButton();
            this.rbN1 = new System.Windows.Forms.RadioButton();
            this.btnN1 = new System.Windows.Forms.Button();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.pbPlayButton = new System.Windows.Forms.PictureBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbTempo.SuspendLayout();
            this.gbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::VP_MusicProject.Properties.Resources.new_file;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::VP_MusicProject.Properties.Resources.images;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::VP_MusicProject.Properties.Resources.save_all;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Image = global::VP_MusicProject.Properties.Resources.qmImage;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // gbTempo
            // 
            this.gbTempo.Controls.Add(this.btnTempo);
            this.gbTempo.Controls.Add(this.rbFast);
            this.gbTempo.Controls.Add(this.rbMedium);
            this.gbTempo.Controls.Add(this.rbSlow);
            this.gbTempo.Location = new System.Drawing.Point(21, 27);
            this.gbTempo.Name = "gbTempo";
            this.gbTempo.Size = new System.Drawing.Size(221, 82);
            this.gbTempo.TabIndex = 1;
            this.gbTempo.TabStop = false;
            this.gbTempo.Text = "Tempo";
            // 
            // btnTempo
            // 
            this.btnTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempo.Location = new System.Drawing.Point(128, 50);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(87, 30);
            this.btnTempo.TabIndex = 3;
            this.btnTempo.Text = "Save choice";
            this.btnTempo.UseVisualStyleBackColor = true;
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFast.Location = new System.Drawing.Point(152, 19);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(48, 19);
            this.rbFast.TabIndex = 2;
            this.rbFast.Text = "Fast";
            this.rbFast.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(74, 19);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(71, 19);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSlow
            // 
            this.rbSlow.AutoSize = true;
            this.rbSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSlow.Location = new System.Drawing.Point(15, 19);
            this.rbSlow.Name = "rbSlow";
            this.rbSlow.Size = new System.Drawing.Size(52, 19);
            this.rbSlow.TabIndex = 0;
            this.rbSlow.Text = "Slow";
            this.rbSlow.UseVisualStyleBackColor = true;
            this.rbSlow.CheckedChanged += new System.EventHandler(this.rbSlow_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNewNotes
            // 
            this.btnNewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNotes.Location = new System.Drawing.Point(324, 359);
            this.btnNewNotes.Name = "btnNewNotes";
            this.btnNewNotes.Size = new System.Drawing.Size(233, 34);
            this.btnNewNotes.TabIndex = 5;
            this.btnNewNotes.Text = "Generate New Notes";
            this.btnNewNotes.UseVisualStyleBackColor = true;
            this.btnNewNotes.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbNotes
            // 
            this.gbNotes.Controls.Add(this.btnN6);
            this.gbNotes.Controls.Add(this.btnN5);
            this.gbNotes.Controls.Add(this.btnN4);
            this.gbNotes.Controls.Add(this.btnN3);
            this.gbNotes.Controls.Add(this.btnN2);
            this.gbNotes.Controls.Add(this.rbN2);
            this.gbNotes.Controls.Add(this.rbN3);
            this.gbNotes.Controls.Add(this.rbN4);
            this.gbNotes.Controls.Add(this.rbN5);
            this.gbNotes.Controls.Add(this.rbN6);
            this.gbNotes.Controls.Add(this.rbN1);
            this.gbNotes.Controls.Add(this.btnN1);
            this.gbNotes.Location = new System.Drawing.Point(13, 270);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(544, 74);
            this.gbNotes.TabIndex = 6;
            this.gbNotes.TabStop = false;
            this.gbNotes.Text = "Next Note";
            // 
            // rbN2
            // 
            this.rbN2.AutoSize = true;
            this.rbN2.Location = new System.Drawing.Point(181, 55);
            this.rbN2.Name = "rbN2";
            this.rbN2.Size = new System.Drawing.Size(14, 13);
            this.rbN2.TabIndex = 15;
            this.rbN2.TabStop = true;
            this.rbN2.UseVisualStyleBackColor = true;
            // 
            // rbN3
            // 
            this.rbN3.AutoSize = true;
            this.rbN3.Location = new System.Drawing.Point(486, 55);
            this.rbN3.Name = "rbN3";
            this.rbN3.Size = new System.Drawing.Size(14, 13);
            this.rbN3.TabIndex = 14;
            this.rbN3.TabStop = true;
            this.rbN3.UseVisualStyleBackColor = true;
            this.rbN3.CheckedChanged += new System.EventHandler(this.rbN3_CheckedChanged);
            // 
            // rbN4
            // 
            this.rbN4.AutoSize = true;
            this.rbN4.Location = new System.Drawing.Point(259, 55);
            this.rbN4.Name = "rbN4";
            this.rbN4.Size = new System.Drawing.Size(14, 13);
            this.rbN4.TabIndex = 13;
            this.rbN4.TabStop = true;
            this.rbN4.UseVisualStyleBackColor = true;
            this.rbN4.CheckedChanged += new System.EventHandler(this.rbN4_CheckedChanged);
            // 
            // rbN5
            // 
            this.rbN5.AutoSize = true;
            this.rbN5.Location = new System.Drawing.Point(333, 55);
            this.rbN5.Name = "rbN5";
            this.rbN5.Size = new System.Drawing.Size(14, 13);
            this.rbN5.TabIndex = 12;
            this.rbN5.TabStop = true;
            this.rbN5.UseVisualStyleBackColor = true;
            // 
            // rbN6
            // 
            this.rbN6.AutoSize = true;
            this.rbN6.Location = new System.Drawing.Point(409, 55);
            this.rbN6.Name = "rbN6";
            this.rbN6.Size = new System.Drawing.Size(14, 13);
            this.rbN6.TabIndex = 11;
            this.rbN6.TabStop = true;
            this.rbN6.UseVisualStyleBackColor = true;
            // 
            // rbN1
            // 
            this.rbN1.AutoSize = true;
            this.rbN1.Location = new System.Drawing.Point(101, 55);
            this.rbN1.Name = "rbN1";
            this.rbN1.Size = new System.Drawing.Size(14, 13);
            this.rbN1.TabIndex = 10;
            this.rbN1.TabStop = true;
            this.rbN1.UseVisualStyleBackColor = true;
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.SystemColors.Control;
            this.btnN1.Location = new System.Drawing.Point(73, 13);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(70, 40);
            this.btnN1.TabIndex = 4;
            this.btnN1.Text = "noteName1";
            this.btnN1.UseVisualStyleBackColor = true;
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.MidnightBlue;
            this.picGraph.Location = new System.Drawing.Point(23, 115);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(711, 137);
            this.picGraph.TabIndex = 4;
            this.picGraph.TabStop = false;
            // 
            // pbPlayButton
            // 
            this.pbPlayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayButton.Image")));
            this.pbPlayButton.Location = new System.Drawing.Point(520, 27);
            this.pbPlayButton.Name = "pbPlayButton";
            this.pbPlayButton.Size = new System.Drawing.Size(82, 82);
            this.pbPlayButton.TabIndex = 3;
            this.pbPlayButton.TabStop = false;
            this.pbPlayButton.Click += new System.EventHandler(this.pbPlayButton_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(13, 359);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(229, 34);
            this.btnAddNote.TabIndex = 7;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "play sample";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate Higher Notes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(563, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Generate Lower Notes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.SystemColors.Control;
            this.btnN2.Location = new System.Drawing.Point(153, 13);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(70, 40);
            this.btnN2.TabIndex = 16;
            this.btnN2.Text = "noteName2";
            this.btnN2.UseVisualStyleBackColor = true;
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.SystemColors.Control;
            this.btnN3.Location = new System.Drawing.Point(229, 13);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(70, 40);
            this.btnN3.TabIndex = 17;
            this.btnN3.Text = "noteName3";
            this.btnN3.UseVisualStyleBackColor = true;
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.SystemColors.Control;
            this.btnN4.Location = new System.Drawing.Point(305, 13);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(70, 40);
            this.btnN4.TabIndex = 18;
            this.btnN4.Text = "noteName4";
            this.btnN4.UseVisualStyleBackColor = true;
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.SystemColors.Control;
            this.btnN5.Location = new System.Drawing.Point(381, 13);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(70, 40);
            this.btnN5.TabIndex = 19;
            this.btnN5.Text = "noteName5";
            this.btnN5.UseVisualStyleBackColor = true;
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.SystemColors.Control;
            this.btnN6.Location = new System.Drawing.Point(457, 13);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(70, 40);
            this.btnN6.TabIndex = 20;
            this.btnN6.Text = "noteName6";
            this.btnN6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 428);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.gbNotes);
            this.Controls.Add(this.btnNewNotes);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.pbPlayButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbTempo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTempo.ResumeLayout(false);
            this.gbTempo.PerformLayout();
            this.gbNotes.ResumeLayout(false);
            this.gbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTempo;
        private System.Windows.Forms.Button btnTempo;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSlow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pbPlayButton;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Button btnNewNotes;
        private System.Windows.Forms.GroupBox gbNotes;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.RadioButton rbN2;
        private System.Windows.Forms.RadioButton rbN3;
        private System.Windows.Forms.RadioButton rbN4;
        private System.Windows.Forms.RadioButton rbN5;
        private System.Windows.Forms.RadioButton rbN6;
        private System.Windows.Forms.RadioButton rbN1;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
    }
}

