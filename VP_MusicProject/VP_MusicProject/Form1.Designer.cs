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
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSlow = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNewNotes = new System.Windows.Forms.Button();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
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
            this.PlaySample = new System.Windows.Forms.Button();
            this.GenerateHigherNotes = new System.Windows.Forms.Button();
            this.GenerateLowerNotes = new System.Windows.Forms.Button();
            this.EditComposition = new System.Windows.Forms.Button();
            this.gbLastSix = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.rbn12 = new System.Windows.Forms.RadioButton();
            this.rbn16 = new System.Windows.Forms.RadioButton();
            this.rbn13 = new System.Windows.Forms.RadioButton();
            this.rbn14 = new System.Windows.Forms.RadioButton();
            this.rbn15 = new System.Windows.Forms.RadioButton();
            this.rbn11 = new System.Windows.Forms.RadioButton();
            this.button11 = new System.Windows.Forms.Button();
            this.PlayLastSix = new System.Windows.Forms.Button();
            this.DeleteSelectedNote = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbTempo.SuspendLayout();
            this.gbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayButton)).BeginInit();
            this.gbLastSix.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
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
            this.gbTempo.Controls.Add(this.rbFast);
            this.gbTempo.Controls.Add(this.rbMedium);
            this.gbTempo.Controls.Add(this.rbSlow);
            this.gbTempo.Location = new System.Drawing.Point(21, 27);
            this.gbTempo.Name = "gbTempo";
            this.gbTempo.Size = new System.Drawing.Size(221, 51);
            this.gbTempo.TabIndex = 1;
            this.gbTempo.TabStop = false;
            this.gbTempo.Text = "Tempo";
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
            this.rbFast.CheckedChanged += new System.EventHandler(this.rbFast_CheckedChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNewNotes
            // 
            this.btnNewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNotes.Location = new System.Drawing.Point(324, 363);
            this.btnNewNotes.Name = "btnNewNotes";
            this.btnNewNotes.Size = new System.Drawing.Size(233, 30);
            this.btnNewNotes.TabIndex = 5;
            this.btnNewNotes.Text = "Generate New Notes";
            this.btnNewNotes.UseVisualStyleBackColor = true;
            this.btnNewNotes.Click += new System.EventHandler(this.btnNewNotes_Click);
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
            this.gbNotes.Location = new System.Drawing.Point(13, 283);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(544, 74);
            this.gbNotes.TabIndex = 6;
            this.gbNotes.TabStop = false;
            this.gbNotes.Text = "Next Note";
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
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
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
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
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
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
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
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
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
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
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
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.MidnightBlue;
            this.picGraph.Location = new System.Drawing.Point(23, 115);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(711, 82);
            this.picGraph.TabIndex = 4;
            this.picGraph.TabStop = false;
            // 
            // pbPlayButton
            // 
            this.pbPlayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayButton.Image")));
            this.pbPlayButton.Location = new System.Drawing.Point(444, 27);
            this.pbPlayButton.Name = "pbPlayButton";
            this.pbPlayButton.Size = new System.Drawing.Size(83, 82);
            this.pbPlayButton.TabIndex = 3;
            this.pbPlayButton.TabStop = false;
            this.pbPlayButton.Click += new System.EventHandler(this.pbPlayButton_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(13, 363);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(229, 30);
            this.btnAddNote.TabIndex = 7;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // PlaySample
            // 
            this.PlaySample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySample.Location = new System.Drawing.Point(272, 36);
            this.PlaySample.Name = "PlaySample";
            this.PlaySample.Size = new System.Drawing.Size(140, 38);
            this.PlaySample.TabIndex = 8;
            this.PlaySample.Text = "Play Sample";
            this.PlaySample.UseVisualStyleBackColor = true;
            this.PlaySample.Click += new System.EventHandler(this.PlaySample_Click);
            // 
            // GenerateHigherNotes
            // 
            this.GenerateHigherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateHigherNotes.Location = new System.Drawing.Point(563, 296);
            this.GenerateHigherNotes.Name = "GenerateHigherNotes";
            this.GenerateHigherNotes.Size = new System.Drawing.Size(171, 24);
            this.GenerateHigherNotes.TabIndex = 9;
            this.GenerateHigherNotes.Text = "Generate Higher Notes";
            this.GenerateHigherNotes.UseVisualStyleBackColor = true;
            this.GenerateHigherNotes.Click += new System.EventHandler(this.GenerateHigherNotes_Click_1);
            // 
            // GenerateLowerNotes
            // 
            this.GenerateLowerNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateLowerNotes.Location = new System.Drawing.Point(563, 330);
            this.GenerateLowerNotes.Name = "GenerateLowerNotes";
            this.GenerateLowerNotes.Size = new System.Drawing.Size(171, 26);
            this.GenerateLowerNotes.TabIndex = 10;
            this.GenerateLowerNotes.Text = "Generate Lower Notes";
            this.GenerateLowerNotes.UseVisualStyleBackColor = true;
            this.GenerateLowerNotes.Click += new System.EventHandler(this.GenerateLowerNotes_Click_1);
            // 
            // EditComposition
            // 
            this.EditComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditComposition.Location = new System.Drawing.Point(563, 36);
            this.EditComposition.Name = "EditComposition";
            this.EditComposition.Size = new System.Drawing.Size(146, 38);
            this.EditComposition.TabIndex = 11;
            this.EditComposition.Text = "Edit Composition";
            this.EditComposition.UseVisualStyleBackColor = true;
            this.EditComposition.Click += new System.EventHandler(this.EditComposition_Click);
            // 
            // gbLastSix
            // 
            this.gbLastSix.Controls.Add(this.button16);
            this.gbLastSix.Controls.Add(this.button15);
            this.gbLastSix.Controls.Add(this.button14);
            this.gbLastSix.Controls.Add(this.button13);
            this.gbLastSix.Controls.Add(this.button12);
            this.gbLastSix.Controls.Add(this.rbn12);
            this.gbLastSix.Controls.Add(this.rbn16);
            this.gbLastSix.Controls.Add(this.rbn13);
            this.gbLastSix.Controls.Add(this.rbn14);
            this.gbLastSix.Controls.Add(this.rbn15);
            this.gbLastSix.Controls.Add(this.rbn11);
            this.gbLastSix.Controls.Add(this.button11);
            this.gbLastSix.Location = new System.Drawing.Point(13, 203);
            this.gbLastSix.Name = "gbLastSix";
            this.gbLastSix.Size = new System.Drawing.Size(544, 74);
            this.gbLastSix.TabIndex = 21;
            this.gbLastSix.TabStop = false;
            this.gbLastSix.Text = "Last 6 notes";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Control;
            this.button16.Location = new System.Drawing.Point(457, 13);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 40);
            this.button16.TabIndex = 20;
            this.button16.Text = "no note";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(381, 13);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 40);
            this.button15.TabIndex = 19;
            this.button15.Text = "no note";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(305, 13);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 40);
            this.button14.TabIndex = 18;
            this.button14.Text = "no note";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(229, 13);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 40);
            this.button13.TabIndex = 17;
            this.button13.Text = "no note";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(153, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 40);
            this.button12.TabIndex = 16;
            this.button12.Text = "no note";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // rbn12
            // 
            this.rbn12.AutoSize = true;
            this.rbn12.Location = new System.Drawing.Point(181, 55);
            this.rbn12.Name = "rbn12";
            this.rbn12.Size = new System.Drawing.Size(14, 13);
            this.rbn12.TabIndex = 15;
            this.rbn12.TabStop = true;
            this.rbn12.UseVisualStyleBackColor = true;
            // 
            // rbn16
            // 
            this.rbn16.AutoSize = true;
            this.rbn16.Location = new System.Drawing.Point(486, 55);
            this.rbn16.Name = "rbn16";
            this.rbn16.Size = new System.Drawing.Size(14, 13);
            this.rbn16.TabIndex = 14;
            this.rbn16.TabStop = true;
            this.rbn16.UseVisualStyleBackColor = true;
            // 
            // rbn13
            // 
            this.rbn13.AutoSize = true;
            this.rbn13.Location = new System.Drawing.Point(259, 55);
            this.rbn13.Name = "rbn13";
            this.rbn13.Size = new System.Drawing.Size(14, 13);
            this.rbn13.TabIndex = 13;
            this.rbn13.TabStop = true;
            this.rbn13.UseVisualStyleBackColor = true;
            // 
            // rbn14
            // 
            this.rbn14.AutoSize = true;
            this.rbn14.Location = new System.Drawing.Point(333, 55);
            this.rbn14.Name = "rbn14";
            this.rbn14.Size = new System.Drawing.Size(14, 13);
            this.rbn14.TabIndex = 12;
            this.rbn14.TabStop = true;
            this.rbn14.UseVisualStyleBackColor = true;
            // 
            // rbn15
            // 
            this.rbn15.AutoSize = true;
            this.rbn15.Location = new System.Drawing.Point(409, 55);
            this.rbn15.Name = "rbn15";
            this.rbn15.Size = new System.Drawing.Size(14, 13);
            this.rbn15.TabIndex = 11;
            this.rbn15.TabStop = true;
            this.rbn15.UseVisualStyleBackColor = true;
            // 
            // rbn11
            // 
            this.rbn11.AutoSize = true;
            this.rbn11.Location = new System.Drawing.Point(101, 55);
            this.rbn11.Name = "rbn11";
            this.rbn11.Size = new System.Drawing.Size(14, 13);
            this.rbn11.TabIndex = 10;
            this.rbn11.TabStop = true;
            this.rbn11.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(73, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 40);
            this.button11.TabIndex = 4;
            this.button11.Text = "no note";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // PlayLastSix
            // 
            this.PlayLastSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLastSix.Location = new System.Drawing.Point(563, 207);
            this.PlayLastSix.Name = "PlayLastSix";
            this.PlayLastSix.Size = new System.Drawing.Size(171, 30);
            this.PlayLastSix.TabIndex = 22;
            this.PlayLastSix.Text = "Play last 6 notes";
            this.PlayLastSix.UseVisualStyleBackColor = true;
            this.PlayLastSix.Click += new System.EventHandler(this.PlayLastSix_Click);
            // 
            // DeleteSelectedNote
            // 
            this.DeleteSelectedNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedNote.Location = new System.Drawing.Point(562, 243);
            this.DeleteSelectedNote.Name = "DeleteSelectedNote";
            this.DeleteSelectedNote.Size = new System.Drawing.Size(171, 32);
            this.DeleteSelectedNote.TabIndex = 23;
            this.DeleteSelectedNote.Text = "Delete selected note";
            this.DeleteSelectedNote.UseVisualStyleBackColor = true;
            this.DeleteSelectedNote.Click += new System.EventHandler(this.DeleteSelectedNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 426);
            this.Controls.Add(this.DeleteSelectedNote);
            this.Controls.Add(this.PlayLastSix);
            this.Controls.Add(this.gbLastSix);
            this.Controls.Add(this.EditComposition);
            this.Controls.Add(this.GenerateLowerNotes);
            this.Controls.Add(this.GenerateHigherNotes);
            this.Controls.Add(this.PlaySample);
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
            this.gbLastSix.ResumeLayout(false);
            this.gbLastSix.PerformLayout();
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
        private System.Windows.Forms.Button PlaySample;
        private System.Windows.Forms.Button GenerateHigherNotes;
        private System.Windows.Forms.Button GenerateLowerNotes;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button EditComposition;
        private System.Windows.Forms.GroupBox gbLastSix;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.RadioButton rbn12;
        private System.Windows.Forms.RadioButton rbn16;
        private System.Windows.Forms.RadioButton rbn13;
        private System.Windows.Forms.RadioButton rbn14;
        private System.Windows.Forms.RadioButton rbn15;
        private System.Windows.Forms.RadioButton rbn11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button PlayLastSix;
        private System.Windows.Forms.Button DeleteSelectedNote;
    }
}

