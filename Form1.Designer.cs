namespace NameThatTune
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(104, 99);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(272, 85);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOptions.Location = new System.Drawing.Point(104, 190);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(272, 85);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(104, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(272, 85);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NameThatTune.Properties.Resources.Music;
            this.ClientSize = new System.Drawing.Size(484, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name That Tune";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
    }
}

