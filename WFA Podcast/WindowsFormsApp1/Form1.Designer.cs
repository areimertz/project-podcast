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
            this.btnChangePodcast = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnChangeCategory = new System.Windows.Forms.Button();
            this.BtnRemoveCategory = new System.Windows.Forms.Button();
            this.BtnPlayPodcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEpisodeDescription = new System.Windows.Forms.Label();
            this.LBoxPodcastDescription = new System.Windows.Forms.ListBox();
            this.LBoxEpisodeDescription = new System.Windows.Forms.ListBox();
            this.cblEpisode = new System.Windows.Forms.CheckedListBox();
            this.lChoosePodCat = new System.Windows.Forms.Label();
            this.cbChoosePodCat = new System.Windows.Forms.ComboBox();
            this.lChoosenewCat = new System.Windows.Forms.Label();
            this.LchoosePodcast = new System.Windows.Forms.Label();
            this.LChangePodcast = new System.Windows.Forms.Label();
            this.cbChoosePodcast = new System.Windows.Forms.ComboBox();
            this.tbNewIntervall = new System.Windows.Forms.TextBox();
            this.cbnewCategory = new System.Windows.Forms.ComboBox();
            this.lChoosePodcastIV = new System.Windows.Forms.Label();
            this.lChooseIV = new System.Windows.Forms.Label();
            this.cbChoosePocastIV = new System.Windows.Forms.ComboBox();
            this.cbChooseIV = new System.Windows.Forms.ComboBox();
            this.btnChangeIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBoxCategory
            // 
            this.LBoxCategory.FormattingEnabled = true;
            this.LBoxCategory.ItemHeight = 16;
            this.LBoxCategory.Location = new System.Drawing.Point(11, 31);
            this.LBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxCategory.Name = "LBoxCategory";
            this.LBoxCategory.Size = new System.Drawing.Size(212, 164);
            this.LBoxCategory.TabIndex = 0;
            this.LBoxCategory.SelectedIndexChanged += new System.EventHandler(this.LBoxCategory_SelectedIndexChanged);
            // 
            // LBoxPodcast
            // 
            this.LBoxPodcast.FormattingEnabled = true;
            this.LBoxPodcast.ItemHeight = 16;
            this.LBoxPodcast.Location = new System.Drawing.Point(228, 31);
            this.LBoxPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxPodcast.Name = "LBoxPodcast";
            this.LBoxPodcast.Size = new System.Drawing.Size(212, 164);
            this.LBoxPodcast.TabIndex = 1;
            this.LBoxPodcast.SelectedIndexChanged += new System.EventHandler(this.LBoxPodcast_SelectedIndexChanged);
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(11, 13);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(65, 17);
            this.LblCategory.TabIndex = 3;
            this.LblCategory.Text = "Category";
            this.LblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPodcast
            // 
            this.LblPodcast.AutoSize = true;
            this.LblPodcast.Location = new System.Drawing.Point(224, 13);
            this.LblPodcast.Name = "LblPodcast";
            this.LblPodcast.Size = new System.Drawing.Size(59, 17);
            this.LblPodcast.TabIndex = 4;
            this.LblPodcast.Text = "Podcast";
            // 
            // LblEpisode
            // 
            this.LblEpisode.AutoSize = true;
            this.LblEpisode.Location = new System.Drawing.Point(441, 13);
            this.LblEpisode.Name = "LblEpisode";
            this.LblEpisode.Size = new System.Drawing.Size(59, 17);
            this.LblEpisode.TabIndex = 5;
            this.LblEpisode.Text = "Episode";
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(679, 31);
            this.TBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(173, 22);
            this.TBoxName.TabIndex = 6;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(676, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 17);
            this.LblName.TabIndex = 7;
            this.LblName.Text = "Name";
            // 
            // TBoxChosenURL
            // 
            this.TBoxChosenURL.Location = new System.Drawing.Point(679, 87);
            this.TBoxChosenURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxChosenURL.Name = "TBoxChosenURL";
            this.TBoxChosenURL.Size = new System.Drawing.Size(173, 22);
            this.TBoxChosenURL.TabIndex = 8;
            // 
            // LblChosenURL
            // 
            this.LblChosenURL.AutoSize = true;
            this.LblChosenURL.Location = new System.Drawing.Point(677, 69);
            this.LblChosenURL.Name = "LblChosenURL";
            this.LblChosenURL.Size = new System.Drawing.Size(88, 17);
            this.LblChosenURL.TabIndex = 9;
            this.LblChosenURL.Text = "Chosen URL";
            // 
            // LblAddNewCategory
            // 
            this.LblAddNewCategory.AutoSize = true;
            this.LblAddNewCategory.Location = new System.Drawing.Point(884, 13);
            this.LblAddNewCategory.Name = "LblAddNewCategory";
            this.LblAddNewCategory.Size = new System.Drawing.Size(123, 17);
            this.LblAddNewCategory.TabIndex = 11;
            this.LblAddNewCategory.Text = "Add new Category";
            // 
            // TBoxAddNewCategory
            // 
            this.TBoxAddNewCategory.Location = new System.Drawing.Point(888, 31);
            this.TBoxAddNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxAddNewCategory.Name = "TBoxAddNewCategory";
            this.TBoxAddNewCategory.Size = new System.Drawing.Size(173, 22);
            this.TBoxAddNewCategory.TabIndex = 10;
            // 
            // CombBoxSelectAnExistingCategory
            // 
            this.CombBoxSelectAnExistingCategory.FormattingEnabled = true;
            this.CombBoxSelectAnExistingCategory.Location = new System.Drawing.Point(679, 156);
            this.CombBoxSelectAnExistingCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CombBoxSelectAnExistingCategory.Name = "CombBoxSelectAnExistingCategory";
            this.CombBoxSelectAnExistingCategory.Size = new System.Drawing.Size(173, 24);
            this.CombBoxSelectAnExistingCategory.TabIndex = 12;
            // 
            // LblSelectAnExistingCategory
            // 
            this.LblSelectAnExistingCategory.AutoSize = true;
            this.LblSelectAnExistingCategory.Location = new System.Drawing.Point(677, 137);
            this.LblSelectAnExistingCategory.Name = "LblSelectAnExistingCategory";
            this.LblSelectAnExistingCategory.Size = new System.Drawing.Size(179, 17);
            this.LblSelectAnExistingCategory.TabIndex = 13;
            this.LblSelectAnExistingCategory.Text = "Select an existing Category";
            // 
            // LblSelectYourUpdateInterval
            // 
            this.LblSelectYourUpdateInterval.AutoSize = true;
            this.LblSelectYourUpdateInterval.Location = new System.Drawing.Point(676, 199);
            this.LblSelectYourUpdateInterval.Name = "LblSelectYourUpdateInterval";
            this.LblSelectYourUpdateInterval.Size = new System.Drawing.Size(172, 17);
            this.LblSelectYourUpdateInterval.TabIndex = 15;
            this.LblSelectYourUpdateInterval.Text = "Select your update Inteval";
            this.LblSelectYourUpdateInterval.Click += new System.EventHandler(this.label8_Click);
            // 
            // CombBoxSelectYourUpdateInterval
            // 
            this.CombBoxSelectYourUpdateInterval.FormattingEnabled = true;
            this.CombBoxSelectYourUpdateInterval.Location = new System.Drawing.Point(679, 218);
            this.CombBoxSelectYourUpdateInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CombBoxSelectYourUpdateInterval.Name = "CombBoxSelectYourUpdateInterval";
            this.CombBoxSelectYourUpdateInterval.Size = new System.Drawing.Size(173, 24);
            this.CombBoxSelectYourUpdateInterval.TabIndex = 14;
            this.CombBoxSelectYourUpdateInterval.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BtnRemovePodcast
            // 
            this.BtnRemovePodcast.Location = new System.Drawing.Point(228, 199);
            this.BtnRemovePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemovePodcast.Name = "BtnRemovePodcast";
            this.BtnRemovePodcast.Size = new System.Drawing.Size(143, 41);
            this.BtnRemovePodcast.TabIndex = 18;
            this.BtnRemovePodcast.Text = "Remove Podcast";
            this.BtnRemovePodcast.UseVisualStyleBackColor = true;
            this.BtnRemovePodcast.Click += new System.EventHandler(this.BtnRemovePodcast_Click);
            // 
            // BtnAddPodcast
            // 
            this.BtnAddPodcast.Location = new System.Drawing.Point(680, 261);
            this.BtnAddPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddPodcast.Name = "BtnAddPodcast";
            this.BtnAddPodcast.Size = new System.Drawing.Size(114, 41);
            this.BtnAddPodcast.TabIndex = 19;
            this.BtnAddPodcast.Text = "Add Podcast";
            this.BtnAddPodcast.UseVisualStyleBackColor = true;
            this.BtnAddPodcast.Click += new System.EventHandler(this.BtnAddPodcast_Click);
            // 
            // btnChangePodcast
            // 
            this.btnChangePodcast.Location = new System.Drawing.Point(1113, 140);
            this.btnChangePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePodcast.Name = "btnChangePodcast";
            this.btnChangePodcast.Size = new System.Drawing.Size(123, 41);
            this.btnChangePodcast.TabIndex = 21;
            this.btnChangePodcast.Text = "Change Podcast";
            this.btnChangePodcast.UseVisualStyleBackColor = true;
            this.btnChangePodcast.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(887, 69);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(122, 41);
            this.BtnAddCategory.TabIndex = 20;
            this.BtnAddCategory.Text = "Add Category";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // BtnChangeCategory
            // 
            this.BtnChangeCategory.Location = new System.Drawing.Point(887, 261);
            this.BtnChangeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangeCategory.Name = "BtnChangeCategory";
            this.BtnChangeCategory.Size = new System.Drawing.Size(163, 41);
            this.BtnChangeCategory.TabIndex = 23;
            this.BtnChangeCategory.Text = "Change Category";
            this.BtnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveCategory
            // 
            this.BtnRemoveCategory.Location = new System.Drawing.Point(11, 199);
            this.BtnRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveCategory.Name = "BtnRemoveCategory";
            this.BtnRemoveCategory.Size = new System.Drawing.Size(150, 41);
            this.BtnRemoveCategory.TabIndex = 22;
            this.BtnRemoveCategory.Text = "Remove Category";
            this.BtnRemoveCategory.UseVisualStyleBackColor = true;
            this.BtnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // BtnPlayPodcast
            // 
            this.BtnPlayPodcast.Location = new System.Drawing.Point(11, 397);
            this.BtnPlayPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPlayPodcast.Name = "BtnPlayPodcast";
            this.BtnPlayPodcast.Size = new System.Drawing.Size(171, 41);
            this.BtnPlayPodcast.TabIndex = 28;
            this.BtnPlayPodcast.Text = "Play Podcast";
            this.BtnPlayPodcast.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Podcast Description";
            // 
            // LblEpisodeDescription
            // 
            this.LblEpisodeDescription.AutoSize = true;
            this.LblEpisodeDescription.Location = new System.Drawing.Point(340, 242);
            this.LblEpisodeDescription.Name = "LblEpisodeDescription";
            this.LblEpisodeDescription.Size = new System.Drawing.Size(134, 17);
            this.LblEpisodeDescription.TabIndex = 30;
            this.LblEpisodeDescription.Text = "Episode Description";
            // 
            // LBoxPodcastDescription
            // 
            this.LBoxPodcastDescription.FormattingEnabled = true;
            this.LBoxPodcastDescription.ItemHeight = 16;
            this.LBoxPodcastDescription.Location = new System.Drawing.Point(11, 261);
            this.LBoxPodcastDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxPodcastDescription.Name = "LBoxPodcastDescription";
            this.LBoxPodcastDescription.Size = new System.Drawing.Size(312, 132);
            this.LBoxPodcastDescription.TabIndex = 26;
            this.LBoxPodcastDescription.SelectedIndexChanged += new System.EventHandler(this.LBoxPodcastDescription_SelectedIndexChanged);
            // 
            // LBoxEpisodeDescription
            // 
            this.LBoxEpisodeDescription.FormattingEnabled = true;
            this.LBoxEpisodeDescription.ItemHeight = 16;
            this.LBoxEpisodeDescription.Location = new System.Drawing.Point(344, 261);
            this.LBoxEpisodeDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBoxEpisodeDescription.Name = "LBoxEpisodeDescription";
            this.LBoxEpisodeDescription.Size = new System.Drawing.Size(312, 132);
            this.LBoxEpisodeDescription.TabIndex = 27;
            this.LBoxEpisodeDescription.SelectedIndexChanged += new System.EventHandler(this.LBoxEpisodeDescription_SelectedIndexChanged);
            // 
            // cblEpisode
            // 
            this.cblEpisode.FormattingEnabled = true;
            this.cblEpisode.Location = new System.Drawing.Point(446, 31);
            this.cblEpisode.Name = "cblEpisode";
            this.cblEpisode.Size = new System.Drawing.Size(212, 157);
            this.cblEpisode.TabIndex = 31;
            this.cblEpisode.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lChoosePodCat
            // 
            this.lChoosePodCat.AutoSize = true;
            this.lChoosePodCat.Location = new System.Drawing.Point(885, 137);
            this.lChoosePodCat.Name = "lChoosePodCat";
            this.lChoosePodCat.Size = new System.Drawing.Size(111, 17);
            this.lChoosePodCat.TabIndex = 32;
            this.lChoosePodCat.Text = "Choose Podcast";
            this.lChoosePodCat.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbChoosePodCat
            // 
            this.cbChoosePodCat.FormattingEnabled = true;
            this.cbChoosePodCat.Location = new System.Drawing.Point(888, 157);
            this.cbChoosePodCat.Name = "cbChoosePodCat";
            this.cbChoosePodCat.Size = new System.Drawing.Size(173, 24);
            this.cbChoosePodCat.TabIndex = 33;
            // 
            // lChoosenewCat
            // 
            this.lChoosenewCat.AutoSize = true;
            this.lChoosenewCat.Location = new System.Drawing.Point(885, 199);
            this.lChoosenewCat.Name = "lChoosenewCat";
            this.lChoosenewCat.Size = new System.Drawing.Size(146, 17);
            this.lChoosenewCat.TabIndex = 34;
            this.lChoosenewCat.Text = "Choose new Category";
            this.lChoosenewCat.Click += new System.EventHandler(this.label3_Click);
            // 
            // LchoosePodcast
            // 
            this.LchoosePodcast.AutoSize = true;
            this.LchoosePodcast.Location = new System.Drawing.Point(1110, 13);
            this.LchoosePodcast.Name = "LchoosePodcast";
            this.LchoosePodcast.Size = new System.Drawing.Size(111, 17);
            this.LchoosePodcast.TabIndex = 36;
            this.LchoosePodcast.Text = "Choose Podcast";
            // 
            // LChangePodcast
            // 
            this.LChangePodcast.AutoSize = true;
            this.LChangePodcast.Location = new System.Drawing.Point(1110, 67);
            this.LChangePodcast.Name = "LChangePodcast";
            this.LChangePodcast.Size = new System.Drawing.Size(112, 17);
            this.LChangePodcast.TabIndex = 37;
            this.LChangePodcast.Text = "New Url Podcast";
            // 
            // cbChoosePodcast
            // 
            this.cbChoosePodcast.FormattingEnabled = true;
            this.cbChoosePodcast.Location = new System.Drawing.Point(1113, 29);
            this.cbChoosePodcast.Name = "cbChoosePodcast";
            this.cbChoosePodcast.Size = new System.Drawing.Size(161, 24);
            this.cbChoosePodcast.TabIndex = 38;
            // 
            // tbNewIntervall
            // 
            this.tbNewIntervall.Location = new System.Drawing.Point(1113, 87);
            this.tbNewIntervall.Name = "tbNewIntervall";
            this.tbNewIntervall.Size = new System.Drawing.Size(161, 22);
            this.tbNewIntervall.TabIndex = 39;
            // 
            // cbnewCategory
            // 
            this.cbnewCategory.FormattingEnabled = true;
            this.cbnewCategory.Location = new System.Drawing.Point(888, 218);
            this.cbnewCategory.Name = "cbnewCategory";
            this.cbnewCategory.Size = new System.Drawing.Size(173, 24);
            this.cbnewCategory.TabIndex = 40;
            // 
            // lChoosePodcastIV
            // 
            this.lChoosePodcastIV.AutoSize = true;
            this.lChoosePodcastIV.Location = new System.Drawing.Point(1110, 223);
            this.lChoosePodcastIV.Name = "lChoosePodcastIV";
            this.lChoosePodcastIV.Size = new System.Drawing.Size(111, 17);
            this.lChoosePodcastIV.TabIndex = 41;
            this.lChoosePodcastIV.Text = "Choose Podcast";
            // 
            // lChooseIV
            // 
            this.lChooseIV.AutoSize = true;
            this.lChooseIV.Location = new System.Drawing.Point(1110, 283);
            this.lChooseIV.Name = "lChooseIV";
            this.lChooseIV.Size = new System.Drawing.Size(138, 17);
            this.lChooseIV.TabIndex = 42;
            this.lChooseIV.Text = "Choose new Intervall";
            // 
            // cbChoosePocastIV
            // 
            this.cbChoosePocastIV.FormattingEnabled = true;
            this.cbChoosePocastIV.Location = new System.Drawing.Point(1113, 247);
            this.cbChoosePocastIV.Name = "cbChoosePocastIV";
            this.cbChoosePocastIV.Size = new System.Drawing.Size(161, 24);
            this.cbChoosePocastIV.TabIndex = 43;
            this.cbChoosePocastIV.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbChooseIV
            // 
            this.cbChooseIV.FormattingEnabled = true;
            this.cbChooseIV.Location = new System.Drawing.Point(1113, 303);
            this.cbChooseIV.Name = "cbChooseIV";
            this.cbChooseIV.Size = new System.Drawing.Size(161, 24);
            this.cbChooseIV.TabIndex = 44;
            // 
            // btnChangeIV
            // 
            this.btnChangeIV.Location = new System.Drawing.Point(1113, 344);
            this.btnChangeIV.Name = "btnChangeIV";
            this.btnChangeIV.Size = new System.Drawing.Size(135, 41);
            this.btnChangeIV.TabIndex = 45;
            this.btnChangeIV.Text = "Change Intervall";
            this.btnChangeIV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 526);
            this.Controls.Add(this.btnChangeIV);
            this.Controls.Add(this.cbChooseIV);
            this.Controls.Add(this.cbChoosePocastIV);
            this.Controls.Add(this.lChooseIV);
            this.Controls.Add(this.lChoosePodcastIV);
            this.Controls.Add(this.cbnewCategory);
            this.Controls.Add(this.tbNewIntervall);
            this.Controls.Add(this.cbChoosePodcast);
            this.Controls.Add(this.LChangePodcast);
            this.Controls.Add(this.LchoosePodcast);
            this.Controls.Add(this.lChoosenewCat);
            this.Controls.Add(this.cbChoosePodCat);
            this.Controls.Add(this.lChoosePodCat);
            this.Controls.Add(this.cblEpisode);
            this.Controls.Add(this.LblEpisodeDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlayPodcast);
            this.Controls.Add(this.LBoxEpisodeDescription);
            this.Controls.Add(this.LBoxPodcastDescription);
            this.Controls.Add(this.BtnChangeCategory);
            this.Controls.Add(this.BtnRemoveCategory);
            this.Controls.Add(this.btnChangePodcast);
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
        private System.Windows.Forms.Button btnChangePodcast;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnChangeCategory;
        private System.Windows.Forms.Button BtnRemoveCategory;
        private System.Windows.Forms.Button BtnPlayPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEpisodeDescription;
        private System.Windows.Forms.ListBox LBoxPodcastDescription;
        private System.Windows.Forms.ListBox LBoxEpisodeDescription;
        private System.Windows.Forms.CheckedListBox cblEpisode;
        private System.Windows.Forms.Label lChoosePodCat;
        private System.Windows.Forms.ComboBox cbChoosePodCat;
        private System.Windows.Forms.Label lChoosenewCat;
        private System.Windows.Forms.Label LchoosePodcast;
        private System.Windows.Forms.Label LChangePodcast;
        private System.Windows.Forms.ComboBox cbChoosePodcast;
        private System.Windows.Forms.TextBox tbNewIntervall;
        private System.Windows.Forms.ComboBox cbnewCategory;
        private System.Windows.Forms.Label lChoosePodcastIV;
        private System.Windows.Forms.Label lChooseIV;
        private System.Windows.Forms.ComboBox cbChoosePocastIV;
        private System.Windows.Forms.ComboBox cbChooseIV;
        private System.Windows.Forms.Button btnChangeIV;
    }
}

