namespace KanburyCinema
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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelRunningTime = new System.Windows.Forms.Label();
            this.textBoxRunningTime = new System.Windows.Forms.TextBox();
            this.textBoxMainStar = new System.Windows.Forms.TextBox();
            this.labelMainStar = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxCertificate = new System.Windows.Forms.TextBox();
            this.labelCertificate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(-7, 477);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(62, 38);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(214, 465);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 50);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelRunningTime
            // 
            this.labelRunningTime.AutoSize = true;
            this.labelRunningTime.Location = new System.Drawing.Point(64, 448);
            this.labelRunningTime.Name = "labelRunningTime";
            this.labelRunningTime.Size = new System.Drawing.Size(76, 13);
            this.labelRunningTime.TabIndex = 2;
            this.labelRunningTime.Text = "Running Time:";
            // 
            // textBoxRunningTime
            // 
            this.textBoxRunningTime.Location = new System.Drawing.Point(177, 459);
            this.textBoxRunningTime.Name = "textBoxRunningTime";
            this.textBoxRunningTime.Size = new System.Drawing.Size(120, 20);
            this.textBoxRunningTime.TabIndex = 3;
            // 
            // textBoxMainStar
            // 
            this.textBoxMainStar.Location = new System.Drawing.Point(153, 406);
            this.textBoxMainStar.Name = "textBoxMainStar";
            this.textBoxMainStar.Size = new System.Drawing.Size(92, 20);
            this.textBoxMainStar.TabIndex = 5;
            // 
            // labelMainStar
            // 
            this.labelMainStar.AutoSize = true;
            this.labelMainStar.Location = new System.Drawing.Point(45, 409);
            this.labelMainStar.Name = "labelMainStar";
            this.labelMainStar.Size = new System.Drawing.Size(55, 13);
            this.labelMainStar.TabIndex = 4;
            this.labelMainStar.Text = "Main Star:";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(177, 371);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(120, 20);
            this.textBoxDirector.TabIndex = 7;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(30, 374);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(47, 13);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Director:";
            // 
            // textBoxCertificate
            // 
            this.textBoxCertificate.Location = new System.Drawing.Point(138, 345);
            this.textBoxCertificate.Name = "textBoxCertificate";
            this.textBoxCertificate.Size = new System.Drawing.Size(120, 20);
            this.textBoxCertificate.TabIndex = 9;
            // 
            // labelCertificate
            // 
            this.labelCertificate.AutoSize = true;
            this.labelCertificate.Location = new System.Drawing.Point(64, 352);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(57, 13);
            this.labelCertificate.TabIndex = 8;
            this.labelCertificate.Text = "Certificate:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 300);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 300);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Movie Name:";
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMovie.Location = new System.Drawing.Point(122, 12);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(246, 301);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovie.TabIndex = 12;
            this.pictureBoxMovie.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 527);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCertificate);
            this.Controls.Add(this.labelCertificate);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxMainStar);
            this.Controls.Add(this.labelMainStar);
            this.Controls.Add(this.textBoxRunningTime);
            this.Controls.Add(this.labelRunningTime);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureBoxMovie);
            this.Name = "Form1";
            this.Text = "Kambury Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelRunningTime;
        private System.Windows.Forms.TextBox textBoxRunningTime;
        private System.Windows.Forms.TextBox textBoxMainStar;
        private System.Windows.Forms.Label labelMainStar;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxCertificate;
        private System.Windows.Forms.Label labelCertificate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
    }
}

