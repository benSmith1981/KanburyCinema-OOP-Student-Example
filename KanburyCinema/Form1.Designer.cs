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
            this.Register = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
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
            this.labelRunningTime.Location = new System.Drawing.Point(119, 431);
            this.labelRunningTime.Name = "labelRunningTime";
            this.labelRunningTime.Size = new System.Drawing.Size(76, 13);
            this.labelRunningTime.TabIndex = 2;
            this.labelRunningTime.Text = "Running Time:";
            // 
            // textBoxRunningTime
            // 
            this.textBoxRunningTime.Location = new System.Drawing.Point(214, 428);
            this.textBoxRunningTime.Name = "textBoxRunningTime";
            this.textBoxRunningTime.Size = new System.Drawing.Size(120, 20);
            this.textBoxRunningTime.TabIndex = 3;
            // 
            // textBoxMainStar
            // 
            this.textBoxMainStar.Location = new System.Drawing.Point(214, 402);
            this.textBoxMainStar.Name = "textBoxMainStar";
            this.textBoxMainStar.Size = new System.Drawing.Size(92, 20);
            this.textBoxMainStar.TabIndex = 5;
            // 
            // labelMainStar
            // 
            this.labelMainStar.AutoSize = true;
            this.labelMainStar.Location = new System.Drawing.Point(119, 409);
            this.labelMainStar.Name = "labelMainStar";
            this.labelMainStar.Size = new System.Drawing.Size(55, 13);
            this.labelMainStar.TabIndex = 4;
            this.labelMainStar.Text = "Main Star:";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(214, 371);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(120, 20);
            this.textBoxDirector.TabIndex = 7;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(119, 378);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(47, 13);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Director:";
            // 
            // textBoxCertificate
            // 
            this.textBoxCertificate.Location = new System.Drawing.Point(214, 345);
            this.textBoxCertificate.Name = "textBoxCertificate";
            this.textBoxCertificate.Size = new System.Drawing.Size(120, 20);
            this.textBoxCertificate.TabIndex = 9;
            // 
            // labelCertificate
            // 
            this.labelCertificate.AutoSize = true;
            this.labelCertificate.Location = new System.Drawing.Point(119, 348);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(57, 13);
            this.labelCertificate.TabIndex = 8;
            this.labelCertificate.Text = "Certificate:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(214, 319);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(119, 319);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Movie Name:";
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMovie.Image = global::KanburyCinema.Properties.Resources.creed2;
            this.pictureBoxMovie.Location = new System.Drawing.Point(122, 12);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(246, 301);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovie.TabIndex = 12;
            this.pictureBoxMovie.TabStop = false;
            this.pictureBoxMovie.Click += new System.EventHandler(this.pictureBoxMovie_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(555, 244);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 13;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(539, 122);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(120, 20);
            this.userName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(539, 166);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 20);
            this.password.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(555, 204);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 18;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 527);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
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
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
    }
}

