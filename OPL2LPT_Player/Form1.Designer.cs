namespace OPL2LPT_Player
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.systemBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RepeatAll = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.RepeatOne = new System.Windows.Forms.RadioButton();
            this.RandomAll = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LPTPort = new System.Windows.Forms.TextBox();
            this.AddDir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Magenta;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::OPL2LPT_Player.Properties.Resources.juke;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Perfect DOS VGA 437", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(54, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPL2LPT (Printer Port Adlib) Sound Card VGM Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Perfect DOS VGA 437", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(54, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playlist";
            // 
            // playlistBox
            // 
            this.playlistBox.BackColor = System.Drawing.Color.Black;
            this.playlistBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistBox.ForeColor = System.Drawing.Color.Cyan;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 20;
            this.playlistBox.Location = new System.Drawing.Point(58, 245);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(528, 584);
            this.playlistBox.Sorted = true;
            this.playlistBox.TabIndex = 3;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(592, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.Black;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.ForeColor = System.Drawing.Color.Cyan;
            this.titleBox.Location = new System.Drawing.Point(597, 276);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(372, 26);
            this.titleBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(592, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Author:";
            // 
            // authorBox
            // 
            this.authorBox.BackColor = System.Drawing.Color.Black;
            this.authorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorBox.ForeColor = System.Drawing.Color.Cyan;
            this.authorBox.Location = new System.Drawing.Point(597, 345);
            this.authorBox.Name = "authorBox";
            this.authorBox.ReadOnly = true;
            this.authorBox.Size = new System.Drawing.Size(372, 26);
            this.authorBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(591, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Game:";
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.Color.Black;
            this.gameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBox.ForeColor = System.Drawing.Color.Cyan;
            this.gameBox.Location = new System.Drawing.Point(596, 415);
            this.gameBox.Name = "gameBox";
            this.gameBox.ReadOnly = true;
            this.gameBox.Size = new System.Drawing.Size(372, 26);
            this.gameBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(592, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "System:";
            // 
            // systemBox
            // 
            this.systemBox.BackColor = System.Drawing.Color.Black;
            this.systemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemBox.ForeColor = System.Drawing.Color.Cyan;
            this.systemBox.Location = new System.Drawing.Point(597, 488);
            this.systemBox.Name = "systemBox";
            this.systemBox.ReadOnly = true;
            this.systemBox.Size = new System.Drawing.Size(191, 26);
            this.systemBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(794, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.Black;
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateBox.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.ForeColor = System.Drawing.Color.Cyan;
            this.dateBox.Location = new System.Drawing.Point(795, 488);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(174, 26);
            this.dateBox.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Cyan;
            this.AddButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(597, 533);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(191, 30);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add File";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Cyan;
            this.DeleteButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(597, 605);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(191, 30);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete File";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Cyan;
            this.LoadButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.Black;
            this.LoadButton.Location = new System.Drawing.Point(596, 641);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(191, 30);
            this.LoadButton.TabIndex = 16;
            this.LoadButton.Text = "Load List";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Cyan;
            this.SaveButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(596, 677);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(191, 30);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save List";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RepeatAll
            // 
            this.RepeatAll.AutoSize = true;
            this.RepeatAll.Checked = true;
            this.RepeatAll.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatAll.Location = new System.Drawing.Point(810, 556);
            this.RepeatAll.Name = "RepeatAll";
            this.RepeatAll.Size = new System.Drawing.Size(137, 24);
            this.RepeatAll.TabIndex = 18;
            this.RepeatAll.TabStop = true;
            this.RepeatAll.Text = "Repeat All";
            this.RepeatAll.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(806, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Playback Mode:";
            // 
            // RepeatOne
            // 
            this.RepeatOne.AutoSize = true;
            this.RepeatOne.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatOne.Location = new System.Drawing.Point(810, 586);
            this.RepeatOne.Name = "RepeatOne";
            this.RepeatOne.Size = new System.Drawing.Size(137, 24);
            this.RepeatOne.TabIndex = 20;
            this.RepeatOne.TabStop = true;
            this.RepeatOne.Text = "Repeat One";
            this.RepeatOne.UseVisualStyleBackColor = true;
            // 
            // RandomAll
            // 
            this.RandomAll.AutoSize = true;
            this.RandomAll.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomAll.Location = new System.Drawing.Point(810, 616);
            this.RandomAll.Name = "RandomAll";
            this.RandomAll.Size = new System.Drawing.Size(137, 24);
            this.RandomAll.TabIndex = 21;
            this.RandomAll.TabStop = true;
            this.RandomAll.Text = "Random All";
            this.RandomAll.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Magenta;
            this.PlayButton.Enabled = false;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.Black;
            this.PlayButton.Image = global::OPL2LPT_Player.Properties.Resources.play;
            this.PlayButton.Location = new System.Drawing.Point(596, 769);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(92, 50);
            this.PlayButton.TabIndex = 22;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Magenta;
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.Black;
            this.StopButton.Image = global::OPL2LPT_Player.Properties.Resources.stop;
            this.StopButton.Location = new System.Drawing.Point(695, 769);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(93, 50);
            this.StopButton.TabIndex = 23;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(593, 737);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "LPT port:";
            // 
            // LPTPort
            // 
            this.LPTPort.BackColor = System.Drawing.Color.Black;
            this.LPTPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LPTPort.Font = new System.Drawing.Font("Perfect DOS VGA 437", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPTPort.ForeColor = System.Drawing.Color.Cyan;
            this.LPTPort.Location = new System.Drawing.Point(707, 735);
            this.LPTPort.MaxLength = 3;
            this.LPTPort.Name = "LPTPort";
            this.LPTPort.Size = new System.Drawing.Size(81, 26);
            this.LPTPort.TabIndex = 25;
            this.LPTPort.Text = "378";
            this.LPTPort.TextChanged += new System.EventHandler(this.LPTPort_TextChanged);
            // 
            // AddDir
            // 
            this.AddDir.BackColor = System.Drawing.Color.Cyan;
            this.AddDir.Font = new System.Drawing.Font("Perfect DOS VGA 437", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDir.ForeColor = System.Drawing.Color.Black;
            this.AddDir.Location = new System.Drawing.Point(597, 569);
            this.AddDir.Name = "AddDir";
            this.AddDir.Size = new System.Drawing.Size(191, 30);
            this.AddDir.TabIndex = 26;
            this.AddDir.Text = "Add Directory";
            this.AddDir.UseVisualStyleBackColor = false;
            this.AddDir.Click += new System.EventHandler(this.AddDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(1016, 831);
            this.Controls.Add(this.AddDir);
            this.Controls.Add(this.LPTPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.RandomAll);
            this.Controls.Add(this.RepeatOne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RepeatAll);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.systemBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 858);
            this.MinimumSize = new System.Drawing.Size(1024, 858);
            this.Name = "Form1";
            this.Text = "OPT2LPT Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox systemBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton RepeatAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RepeatOne;
        private System.Windows.Forms.RadioButton RandomAll;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LPTPort;
        private System.Windows.Forms.Button AddDir;


    }
}

