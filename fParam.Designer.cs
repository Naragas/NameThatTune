namespace NameThatTune
{
    partial class fParam
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.cbAllDirectories = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.lblGameDuration = new System.Windows.Forms.Label();
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.gbGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 199);
            this.listBox1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 205);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(94, 205);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // cbAllDirectories
            // 
            this.cbAllDirectories.AutoSize = true;
            this.cbAllDirectories.Location = new System.Drawing.Point(291, 204);
            this.cbAllDirectories.Name = "cbAllDirectories";
            this.cbAllDirectories.Size = new System.Drawing.Size(76, 17);
            this.cbAllDirectories.TabIndex = 3;
            this.cbAllDirectories.Text = "Subfolders";
            this.cbAllDirectories.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 347);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.cbRandomStart);
            this.gbGameSettings.Controls.Add(this.cbMusicDuration);
            this.gbGameSettings.Controls.Add(this.cbGameDuration);
            this.gbGameSettings.Controls.Add(this.lblMusicDuration);
            this.gbGameSettings.Controls.Add(this.lblGameDuration);
            this.gbGameSettings.Location = new System.Drawing.Point(13, 235);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(328, 164);
            this.gbGameSettings.TabIndex = 6;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Game Settings";
            // 
            // lblGameDuration
            // 
            this.lblGameDuration.AutoSize = true;
            this.lblGameDuration.Location = new System.Drawing.Point(7, 23);
            this.lblGameDuration.Name = "lblGameDuration";
            this.lblGameDuration.Size = new System.Drawing.Size(76, 13);
            this.lblGameDuration.TabIndex = 0;
            this.lblGameDuration.Text = "Game duration";
            this.lblGameDuration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Location = new System.Drawing.Point(7, 50);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(76, 13);
            this.lblMusicDuration.TabIndex = 1;
            this.lblMusicDuration.Text = "Music duration";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(90, 20);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(48, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "30";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.cbMusicDuration.Location = new System.Drawing.Point(90, 47);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(48, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "10";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(10, 117);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(146, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Random fragment of tune";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.gbGameSettings);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbAllDirectories);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox cbAllDirectories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label lblGameDuration;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.CheckBox cbRandomStart;
    }
}