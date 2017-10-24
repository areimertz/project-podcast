namespace WindowsFormsApp1
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
            this.LBoxCategory = new System.Windows.Forms.ListBox();
            this.LBoxPodcast = new System.Windows.Forms.ListBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblPodcast = new System.Windows.Forms.Label();
            this.LblEpisode = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TBoxChosenURL = new System.Windows.Forms.TextBox();
            this.LblChosenURL = new System.Windows.Forms.Label();
            this.LblAddNewCategory = new System.Windows.Forms.Label();
            this.TBoxAddNewCategory = new System.Windows.Forms.TextBox();
            this.CombBoxSelectAnExistingCategory = new System.Windows.Forms.ComboBox();
            this.LblSelectAnExistingCategory = new System.Windows.Forms.Label();
            this.LblSelectYourUpdateInterval = new System.Windows.Forms.Label();
            this.CombBoxSelectYourUpdateInterval = new System.Windows.Forms.ComboBox();
            this.BtnRemovePodcast = new System.Windows.Forms.Button();
            this.BtnAddPodcast = new System.Windows.Forms.Button();
            this.ChangePodcast = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnChangeCategory = new System.Windows.Forms.Button();
            this.BtnRemoveCategory = new System.Windows.Forms.Button();
            this.BtnPlayPodcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEpisodeDescription = new System.Windows.Forms.Label();
            this.LBoxPodcastDescription = new System.Windows.Forms.ListBox();
            this.LBoxEpisodeDescription = new System.Windows.Forms.ListBox();
            this.cblEpisode = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LchoosePodcast = new System.Windows.Forms.Label();
            this.LChangePodcast = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBoxCategory
            // 
            this.LBoxCategory.FormattingEnabled = true;
            this.LBoxCategory.ItemHeight = 20;
            this.LBoxCategory.Location = new System.Drawing.Point(12, 39);
            this.LBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxCategory.Name = "LBoxCategory";
            this.LBoxCategory.Size = new System.Drawing.Size(238, 204);
            this.LBoxCategory.TabIndex = 0;
            this.LBoxCategory.SelectedIndexChanged += new System.EventHandler(this.LBoxCategory_SelectedIndexChanged);
            // 
            // LBoxPodcast
            // 
            this.LBoxPodcast.FormattingEnabled = true;
            this.LBoxPodcast.ItemHeight = 20;
            this.LBoxPodcast.Location = new System.Drawing.Point(256, 39);
            this.LBoxPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxPodcast.Name = "LBoxPodcast";
            this.LBoxPodcast.Size = new System.Drawing.Size(238, 204);
            this.LBoxPodcast.TabIndex = 1;
            this.LBoxPodcast.SelectedIndexChanged += new System.EventHandler(this.LBoxPodcast_SelectedIndexChanged);
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(12, 16);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(73, 20);
            this.LblCategory.TabIndex = 3;
            this.LblCategory.Text = "Category";
            this.LblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPodcast
            // 
            this.LblPodcast.AutoSize = true;
            this.LblPodcast.Location = new System.Drawing.Point(252, 16);
            this.LblPodcast.Name = "LblPodcast";
            this.LblPodcast.Size = new System.Drawing.Size(67, 20);
            this.LblPodcast.TabIndex = 4;
            this.LblPodcast.Text = "Podcast";
            // 
            // LblEpisode
            // 
            this.LblEpisode.AutoSize = true;
            this.LblEpisode.Location = new System.Drawing.Point(496, 16);
            this.LblEpisode.Name = "LblEpisode";
            this.LblEpisode.Size = new System.Drawing.Size(67, 20);
            this.LblEpisode.TabIndex = 5;
            this.LblEpisode.Text = "Episode";
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(764, 39);
            this.TBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(194, 26);
            this.TBoxName.TabIndex = 6;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(760, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 20);
            this.LblName.TabIndex = 7;
            this.LblName.Text = "Name";
            // 
            // TBoxChosenURL
            // 
            this.TBoxChosenURL.Location = new System.Drawing.Point(764, 109);
            this.TBoxChosenURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxChosenURL.Name = "TBoxChosenURL";
            this.TBoxChosenURL.Size = new System.Drawing.Size(194, 26);
            this.TBoxChosenURL.TabIndex = 8;
            // 
            // LblChosenURL
            // 
            this.LblChosenURL.AutoSize = true;
            this.LblChosenURL.Location = new System.Drawing.Point(762, 86);
            this.LblChosenURL.Name = "LblChosenURL";
            this.LblChosenURL.Size = new System.Drawing.Size(101, 20);
            this.LblChosenURL.TabIndex = 9;
            this.LblChosenURL.Text = "Chosen URL";
            // 
            // LblAddNewCategory
            // 
            this.LblAddNewCategory.AutoSize = true;
            this.LblAddNewCategory.Location = new System.Drawing.Point(994, 16);
            this.LblAddNewCategory.Name = "LblAddNewCategory";
            this.LblAddNewCategory.Size = new System.Drawing.Size(139, 20);
            this.LblAddNewCategory.TabIndex = 11;
            this.LblAddNewCategory.Text = "Add new Category";
            // 
            // TBoxAddNewCategory
            // 
            this.TBoxAddNewCategory.Location = new System.Drawing.Point(999, 39);
            this.TBoxAddNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxAddNewCategory.Name = "TBoxAddNewCategory";
            this.TBoxAddNewCategory.Size = new System.Drawing.Size(194, 26);
            this.TBoxAddNewCategory.TabIndex = 10;
            // 
            // CombBoxSelectAnExistingCategory
            // 
            this.CombBoxSelectAnExistingCategory.FormattingEnabled = true;
            this.CombBoxSelectAnExistingCategory.Location = new System.Drawing.Point(764, 195);
            this.CombBoxSelectAnExistingCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CombBoxSelectAnExistingCategory.Name = "CombBoxSelectAnExistingCategory";
            this.CombBoxSelectAnExistingCategory.Size = new System.Drawing.Size(194, 28);
            this.CombBoxSelectAnExistingCategory.TabIndex = 12;
            // 
            // LblSelectAnExistingCategory
            // 
            this.LblSelectAnExistingCategory.AutoSize = true;
            this.LblSelectAnExistingCategory.Location = new System.Drawing.Point(762, 171);
            this.LblSelectAnExistingCategory.Name = "LblSelectAnExistingCategory";
            this.LblSelectAnExistingCategory.Size = new System.Drawing.Size(201, 20);
            this.LblSelectAnExistingCategory.TabIndex = 13;
            this.LblSelectAnExistingCategory.Text = "Select an existing Category";
            // 
            // LblSelectYourUpdateInterval
            // 
            this.LblSelectYourUpdateInterval.AutoSize = true;
            this.LblSelectYourUpdateInterval.Location = new System.Drawing.Point(760, 249);
            this.LblSelectYourUpdateInterval.Name = "LblSelectYourUpdateInterval";
            this.LblSelectYourUpdateInterval.Size = new System.Drawing.Size(193, 20);
            this.LblSelectYourUpdateInterval.TabIndex = 15;
            this.LblSelectYourUpdateInterval.Text = "Select your update Inteval";
            this.LblSelectYourUpdateInterval.Click += new System.EventHandler(this.label8_Click);
            // 
            // CombBoxSelectYourUpdateInterval
            // 
            this.CombBoxSelectYourUpdateInterval.FormattingEnabled = true;
            this.CombBoxSelectYourUpdateInterval.Location = new System.Drawing.Point(764, 272);
            this.CombBoxSelectYourUpdateInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CombBoxSelectYourUpdateInterval.Name = "CombBoxSelectYourUpdateInterval";
            this.CombBoxSelectYourUpdateInterval.Size = new System.Drawing.Size(194, 28);
            this.CombBoxSelectYourUpdateInterval.TabIndex = 14;
            this.CombBoxSelectYourUpdateInterval.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BtnRemovePodcast
            // 
            this.BtnRemovePodcast.Location = new System.Drawing.Point(256, 249);
            this.BtnRemovePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemovePodcast.Name = "BtnRemovePodcast";
            this.BtnRemovePodcast.Size = new System.Drawing.Size(161, 51);
            this.BtnRemovePodcast.TabIndex = 18;
            this.BtnRemovePodcast.Text = "Remove Podcast";
            this.BtnRemovePodcast.UseVisualStyleBackColor = true;
            this.BtnRemovePodcast.Click += new System.EventHandler(this.BtnRemovePodcast_Click);
            // 
            // BtnAddPodcast
            // 
            this.BtnAddPodcast.Location = new System.Drawing.Point(765, 326);
            this.BtnAddPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddPodcast.Name = "BtnAddPodcast";
            this.BtnAddPodcast.Size = new System.Drawing.Size(128, 51);
            this.BtnAddPodcast.TabIndex = 19;
            this.BtnAddPodcast.Text = "Add Podcast";
            this.BtnAddPodcast.UseVisualStyleBackColor = true;
            this.BtnAddPodcast.Click += new System.EventHandler(this.BtnAddPodcast_Click);
            // 
            // ChangePodcast
            // 
            this.ChangePodcast.Location = new System.Drawing.Point(1252, 175);
            this.ChangePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePodcast.Name = "ChangePodcast";
            this.ChangePodcast.Size = new System.Drawing.Size(138, 51);
            this.ChangePodcast.TabIndex = 21;
            this.ChangePodcast.Text = "Change Podcast";
            this.ChangePodcast.UseVisualStyleBackColor = true;
            this.ChangePodcast.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(998, 86);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(137, 51);
            this.BtnAddCategory.TabIndex = 20;
            this.BtnAddCategory.Text = "Add Category";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // BtnChangeCategory
            // 
            this.BtnChangeCategory.Location = new System.Drawing.Point(998, 326);
            this.BtnChangeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangeCategory.Name = "BtnChangeCategory";
            this.BtnChangeCategory.Size = new System.Drawing.Size(183, 51);
            this.BtnChangeCategory.TabIndex = 23;
            this.BtnChangeCategory.Text = "Change Category";
            this.BtnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveCategory
            // 
            this.BtnRemoveCategory.Location = new System.Drawing.Point(12, 249);
            this.BtnRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveCategory.Name = "BtnRemoveCategory";
            this.BtnRemoveCategory.Size = new System.Drawing.Size(169, 51);
            this.BtnRemoveCategory.TabIndex = 22;
            this.BtnRemoveCategory.Text = "Remove Category";
            this.BtnRemoveCategory.UseVisualStyleBackColor = true;
            this.BtnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // BtnPlayPodcast
            // 
            this.BtnPlayPodcast.Location = new System.Drawing.Point(12, 496);
            this.BtnPlayPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPlayPodcast.Name = "BtnPlayPodcast";
            this.BtnPlayPodcast.Size = new System.Drawing.Size(192, 51);
            this.BtnPlayPodcast.TabIndex = 28;
            this.BtnPlayPodcast.Text = "Play Podcast";
            this.BtnPlayPodcast.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Podcast Description";
            // 
            // LblEpisodeDescription
            // 
            this.LblEpisodeDescription.AutoSize = true;
            this.LblEpisodeDescription.Location = new System.Drawing.Point(382, 302);
            this.LblEpisodeDescription.Name = "LblEpisodeDescription";
            this.LblEpisodeDescription.Size = new System.Drawing.Size(151, 20);
            this.LblEpisodeDescription.TabIndex = 30;
            this.LblEpisodeDescription.Text = "Episode Description";
            // 
            // LBoxPodcastDescription
            // 
            this.LBoxPodcastDescription.FormattingEnabled = true;
            this.LBoxPodcastDescription.ItemHeight = 20;
            this.LBoxPodcastDescription.Location = new System.Drawing.Point(12, 326);
            this.LBoxPodcastDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxPodcastDescription.Name = "LBoxPodcastDescription";
            this.LBoxPodcastDescription.Size = new System.Drawing.Size(350, 164);
            this.LBoxPodcastDescription.TabIndex = 26;
            // 
            // LBoxEpisodeDescription
            // 
            this.LBoxEpisodeDescription.FormattingEnabled = true;
            this.LBoxEpisodeDescription.ItemHeight = 20;
            this.LBoxEpisodeDescription.Location = new System.Drawing.Point(387, 326);
            this.LBoxEpisodeDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxEpisodeDescription.Name = "LBoxEpisodeDescription";
            this.LBoxEpisodeDescription.Size = new System.Drawing.Size(350, 164);
            this.LBoxEpisodeDescription.TabIndex = 27;
            // 
            // cblEpisode
            // 
            this.cblEpisode.FormattingEnabled = true;
            this.cblEpisode.Location = new System.Drawing.Point(502, 39);
            this.cblEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cblEpisode.Name = "cblEpisode";
            this.cblEpisode.Size = new System.Drawing.Size(238, 214);
            this.cblEpisode.TabIndex = 31;
            this.cblEpisode.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(996, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(999, 196);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(996, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "New name for Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(998, 275);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 35;
            // 
            // LchoosePodcast
            // 
            this.LchoosePodcast.AutoSize = true;
            this.LchoosePodcast.Location = new System.Drawing.Point(1249, 16);
            this.LchoosePodcast.Name = "LchoosePodcast";
            this.LchoosePodcast.Size = new System.Drawing.Size(126, 20);
            this.LchoosePodcast.TabIndex = 36;
            this.LchoosePodcast.Text = "Choose Podcast";
            // 
            // LChangePodcast
            // 
            this.LChangePodcast.AutoSize = true;
            this.LChangePodcast.Location = new System.Drawing.Point(1249, 84);
            this.LChangePodcast.Name = "LChangePodcast";
            this.LChangePodcast.Size = new System.Drawing.Size(146, 20);
            this.LChangePodcast.TabIndex = 37;
            this.LChangePodcast.Text = "New name Podcast";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1252, 36);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 28);
            this.comboBox2.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1252, 109);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 26);
            this.textBox2.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 658);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LChangePodcast);
            this.Controls.Add(this.LchoosePodcast);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cblEpisode);
            this.Controls.Add(this.LblEpisodeDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlayPodcast);
            this.Controls.Add(this.LBoxEpisodeDescription);
            this.Controls.Add(this.LBoxPodcastDescription);
            this.Controls.Add(this.BtnChangeCategory);
            this.Controls.Add(this.BtnRemoveCategory);
            this.Controls.Add(this.ChangePodcast);
            this.Controls.Add(this.BtnAddCategory);
            this.Controls.Add(this.BtnAddPodcast);
            this.Controls.Add(this.BtnRemovePodcast);
            this.Controls.Add(this.LblSelectYourUpdateInterval);
            this.Controls.Add(this.CombBoxSelectYourUpdateInterval);
            this.Controls.Add(this.LblSelectAnExistingCategory);
            this.Controls.Add(this.CombBoxSelectAnExistingCategory);
            this.Controls.Add(this.LblAddNewCategory);
            this.Controls.Add(this.TBoxAddNewCategory);
            this.Controls.Add(this.LblChosenURL);
            this.Controls.Add(this.TBoxChosenURL);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.LblEpisode);
            this.Controls.Add(this.LblPodcast);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.LBoxPodcast);
            this.Controls.Add(this.LBoxCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBoxCategory;
        private System.Windows.Forms.ListBox LBoxPodcast;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblPodcast;
        private System.Windows.Forms.Label LblEpisode;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TBoxChosenURL;
        private System.Windows.Forms.Label LblChosenURL;
        private System.Windows.Forms.Label LblAddNewCategory;
        private System.Windows.Forms.TextBox TBoxAddNewCategory;
        private System.Windows.Forms.ComboBox CombBoxSelectAnExistingCategory;
        private System.Windows.Forms.Label LblSelectAnExistingCategory;
        private System.Windows.Forms.Label LblSelectYourUpdateInterval;
        private System.Windows.Forms.ComboBox CombBoxSelectYourUpdateInterval;
        private System.Windows.Forms.Button BtnRemovePodcast;
        private System.Windows.Forms.Button BtnAddPodcast;
        private System.Windows.Forms.Button ChangePodcast;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnChangeCategory;
        private System.Windows.Forms.Button BtnRemoveCategory;
        private System.Windows.Forms.Button BtnPlayPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEpisodeDescription;
        private System.Windows.Forms.ListBox LBoxPodcastDescription;
        private System.Windows.Forms.ListBox LBoxEpisodeDescription;
        private System.Windows.Forms.CheckedListBox cblEpisode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LchoosePodcast;
        private System.Windows.Forms.Label LChangePodcast;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

