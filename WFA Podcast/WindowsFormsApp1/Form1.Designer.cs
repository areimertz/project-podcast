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
            this.btnChangeName = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnChangeCategory = new System.Windows.Forms.Button();
            this.BtnRemoveCategory = new System.Windows.Forms.Button();
            this.BtnPlayPodcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEpisodeDescription = new System.Windows.Forms.Label();
            this.cblEpisode = new System.Windows.Forms.CheckedListBox();
            this.lChoosePodCat = new System.Windows.Forms.Label();
            this.lChoosenewCat = new System.Windows.Forms.Label();
            this.LchooseCategory = new System.Windows.Forms.Label();
            this.LChangeCategory = new System.Windows.Forms.Label();
            this.cbChooseCategory = new System.Windows.Forms.ComboBox();
            this.tbNewCategory = new System.Windows.Forms.TextBox();
            this.cbnewCategory = new System.Windows.Forms.ComboBox();
            this.lChooseIV = new System.Windows.Forms.Label();
            this.cbChooseIV = new System.Windows.Forms.ComboBox();
            this.richTbDesc = new System.Windows.Forms.RichTextBox();
            this.rTbEpisode = new System.Windows.Forms.RichTextBox();
            this.lblloading = new System.Windows.Forms.Label();
            this.tbNewUrl = new System.Windows.Forms.TextBox();
            this.lNewUrl = new System.Windows.Forms.Label();
            this.tbPodcastChange = new System.Windows.Forms.TextBox();
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
            this.TBoxChosenURL.TextChanged += new System.EventHandler(this.TBoxChosenURL_TextChanged);
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
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(1113, 140);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(123, 41);
            this.btnChangeName.TabIndex = 21;
            this.btnChangeName.Text = "Change Category";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.button1_Click);
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
            this.BtnChangeCategory.Location = new System.Drawing.Point(885, 407);
            this.BtnChangeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangeCategory.Name = "BtnChangeCategory";
            this.BtnChangeCategory.Size = new System.Drawing.Size(163, 41);
            this.BtnChangeCategory.TabIndex = 23;
            this.BtnChangeCategory.Text = "Change Feed";
            this.BtnChangeCategory.UseVisualStyleBackColor = true;
            this.BtnChangeCategory.Click += new System.EventHandler(this.BtnChangeCategory_Click);
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
            this.BtnPlayPodcast.Click += new System.EventHandler(this.BtnPlayPodcast_Click);
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
            // cblEpisode
            // 
            this.cblEpisode.FormattingEnabled = true;
            this.cblEpisode.Location = new System.Drawing.Point(446, 31);
            this.cblEpisode.Name = "cblEpisode";
            this.cblEpisode.Size = new System.Drawing.Size(212, 123);
            this.cblEpisode.TabIndex = 31;
            this.cblEpisode.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lChoosePodCat
            // 
            this.lChoosePodCat.AutoSize = true;
            this.lChoosePodCat.Location = new System.Drawing.Point(885, 137);
            this.lChoosePodCat.Name = "lChoosePodCat";
            this.lChoosePodCat.Size = new System.Drawing.Size(129, 17);
            this.lChoosePodCat.TabIndex = 32;
            this.lChoosePodCat.Text = "New Podcast name";
            this.lChoosePodCat.Click += new System.EventHandler(this.label2_Click);
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
            // LchooseCategory
            // 
            this.LchooseCategory.AutoSize = true;
            this.LchooseCategory.Location = new System.Drawing.Point(1110, 13);
            this.LchooseCategory.Name = "LchooseCategory";
            this.LchooseCategory.Size = new System.Drawing.Size(117, 17);
            this.LchooseCategory.TabIndex = 36;
            this.LchooseCategory.Text = "Choose Category";
            // 
            // LChangeCategory
            // 
            this.LChangeCategory.AutoSize = true;
            this.LChangeCategory.Location = new System.Drawing.Point(1110, 67);
            this.LChangeCategory.Name = "LChangeCategory";
            this.LChangeCategory.Size = new System.Drawing.Size(137, 17);
            this.LChangeCategory.TabIndex = 37;
            this.LChangeCategory.Text = "New Category Name";
            // 
            // cbChooseCategory
            // 
            this.cbChooseCategory.FormattingEnabled = true;
            this.cbChooseCategory.Location = new System.Drawing.Point(1113, 29);
            this.cbChooseCategory.Name = "cbChooseCategory";
            this.cbChooseCategory.Size = new System.Drawing.Size(161, 24);
            this.cbChooseCategory.TabIndex = 38;
            // 
            // tbNewCategory
            // 
            this.tbNewCategory.Location = new System.Drawing.Point(1113, 103);
            this.tbNewCategory.Name = "tbNewCategory";
            this.tbNewCategory.Size = new System.Drawing.Size(161, 22);
            this.tbNewCategory.TabIndex = 39;
            // 
            // cbnewCategory
            // 
            this.cbnewCategory.FormattingEnabled = true;
            this.cbnewCategory.Location = new System.Drawing.Point(888, 218);
            this.cbnewCategory.Name = "cbnewCategory";
            this.cbnewCategory.Size = new System.Drawing.Size(173, 24);
            this.cbnewCategory.TabIndex = 40;
            // 
            // lChooseIV
            // 
            this.lChooseIV.AutoSize = true;
            this.lChooseIV.Location = new System.Drawing.Point(887, 328);
            this.lChooseIV.Name = "lChooseIV";
            this.lChooseIV.Size = new System.Drawing.Size(138, 17);
            this.lChooseIV.TabIndex = 42;
            this.lChooseIV.Text = "Choose new Intervall";
            // 
            // cbChooseIV
            // 
            this.cbChooseIV.FormattingEnabled = true;
            this.cbChooseIV.Location = new System.Drawing.Point(887, 357);
            this.cbChooseIV.Name = "cbChooseIV";
            this.cbChooseIV.Size = new System.Drawing.Size(174, 24);
            this.cbChooseIV.TabIndex = 44;
            // 
            // richTbDesc
            // 
            this.richTbDesc.Location = new System.Drawing.Point(11, 261);
            this.richTbDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTbDesc.Name = "richTbDesc";
            this.richTbDesc.Size = new System.Drawing.Size(304, 133);
            this.richTbDesc.TabIndex = 46;
            this.richTbDesc.Text = "";
            // 
            // rTbEpisode
            // 
            this.rTbEpisode.Location = new System.Drawing.Point(332, 261);
            this.rTbEpisode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTbEpisode.Name = "rTbEpisode";
            this.rTbEpisode.Size = new System.Drawing.Size(327, 133);
            this.rTbEpisode.TabIndex = 47;
            this.rTbEpisode.Text = "";
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.Location = new System.Drawing.Point(447, 178);
            this.lblloading.Name = "lblloading";
            this.lblloading.Size = new System.Drawing.Size(0, 17);
            this.lblloading.TabIndex = 48;
            // 
            // tbNewUrl
            // 
            this.tbNewUrl.Location = new System.Drawing.Point(888, 294);
            this.tbNewUrl.Name = "tbNewUrl";
            this.tbNewUrl.Size = new System.Drawing.Size(173, 22);
            this.tbNewUrl.TabIndex = 49;
            // 
            // lNewUrl
            // 
            this.lNewUrl.AutoSize = true;
            this.lNewUrl.Location = new System.Drawing.Point(893, 259);
            this.lNewUrl.Name = "lNewUrl";
            this.lNewUrl.Size = new System.Drawing.Size(57, 17);
            this.lNewUrl.TabIndex = 50;
            this.lNewUrl.Text = "New Url";
            // 
            // tbPodcastChange
            // 
            this.tbPodcastChange.Location = new System.Drawing.Point(888, 166);
            this.tbPodcastChange.Name = "tbPodcastChange";
            this.tbPodcastChange.Size = new System.Drawing.Size(173, 22);
            this.tbPodcastChange.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 526);
            this.Controls.Add(this.tbPodcastChange);
            this.Controls.Add(this.lNewUrl);
            this.Controls.Add(this.tbNewUrl);
            this.Controls.Add(this.lblloading);
            this.Controls.Add(this.rTbEpisode);
            this.Controls.Add(this.richTbDesc);
            this.Controls.Add(this.cbChooseIV);
            this.Controls.Add(this.lChooseIV);
            this.Controls.Add(this.cbnewCategory);
            this.Controls.Add(this.tbNewCategory);
            this.Controls.Add(this.cbChooseCategory);
            this.Controls.Add(this.LChangeCategory);
            this.Controls.Add(this.LchooseCategory);
            this.Controls.Add(this.lChoosenewCat);
            this.Controls.Add(this.lChoosePodCat);
            this.Controls.Add(this.cblEpisode);
            this.Controls.Add(this.LblEpisodeDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlayPodcast);
            this.Controls.Add(this.BtnChangeCategory);
            this.Controls.Add(this.BtnRemoveCategory);
            this.Controls.Add(this.btnChangeName);
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
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnChangeCategory;
        private System.Windows.Forms.Button BtnRemoveCategory;
        private System.Windows.Forms.Button BtnPlayPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEpisodeDescription;
        private System.Windows.Forms.CheckedListBox cblEpisode;
        private System.Windows.Forms.Label lChoosePodCat;
        private System.Windows.Forms.Label lChoosenewCat;
        private System.Windows.Forms.Label LchooseCategory;
        private System.Windows.Forms.Label LChangeCategory;
        private System.Windows.Forms.ComboBox cbChooseCategory;
        private System.Windows.Forms.TextBox tbNewCategory;
        private System.Windows.Forms.ComboBox cbnewCategory;
        private System.Windows.Forms.Label lChooseIV;
        private System.Windows.Forms.ComboBox cbChooseIV;
        private System.Windows.Forms.RichTextBox richTbDesc;
        private System.Windows.Forms.RichTextBox rTbEpisode;
        private System.Windows.Forms.Label lblloading;
        private System.Windows.Forms.TextBox tbNewUrl;
        private System.Windows.Forms.Label lNewUrl;
        private System.Windows.Forms.TextBox tbPodcastChange;
    }
}

