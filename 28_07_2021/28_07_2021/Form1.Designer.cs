
namespace _28_07_2021
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
            this.Lbl1_Login = new System.Windows.Forms.Label();
            this.Lbl2_Username = new System.Windows.Forms.Label();
            this.Lbl3_Password = new System.Windows.Forms.Label();
            this.TextBox1_Username = new System.Windows.Forms.TextBox();
            this.TextBox2_Password = new System.Windows.Forms.TextBox();
            this.Lbl4_Check_Login = new System.Windows.Forms.Label();
            this.Btn1_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl1_Login
            // 
            this.Lbl1_Login.AutoSize = true;
            this.Lbl1_Login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1_Login.Font = new System.Drawing.Font("Engravers MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1_Login.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl1_Login.Location = new System.Drawing.Point(329, 62);
            this.Lbl1_Login.Name = "Lbl1_Login";
            this.Lbl1_Login.Size = new System.Drawing.Size(235, 56);
            this.Lbl1_Login.TabIndex = 2;
            this.Lbl1_Login.Text = "Login";
            // 
            // Lbl2_Username
            // 
            this.Lbl2_Username.AutoSize = true;
            this.Lbl2_Username.BackColor = System.Drawing.Color.Transparent;
            this.Lbl2_Username.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2_Username.ForeColor = System.Drawing.Color.White;
            this.Lbl2_Username.Location = new System.Drawing.Point(272, 163);
            this.Lbl2_Username.Name = "Lbl2_Username";
            this.Lbl2_Username.Size = new System.Drawing.Size(108, 26);
            this.Lbl2_Username.TabIndex = 3;
            this.Lbl2_Username.Text = "Username";
            // 
            // Lbl3_Password
            // 
            this.Lbl3_Password.AutoSize = true;
            this.Lbl3_Password.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3_Password.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3_Password.ForeColor = System.Drawing.Color.White;
            this.Lbl3_Password.Location = new System.Drawing.Point(272, 238);
            this.Lbl3_Password.Name = "Lbl3_Password";
            this.Lbl3_Password.Size = new System.Drawing.Size(100, 26);
            this.Lbl3_Password.TabIndex = 4;
            this.Lbl3_Password.Text = "Password";
            // 
            // TextBox1_Username
            // 
            this.TextBox1_Username.Location = new System.Drawing.Point(277, 192);
            this.TextBox1_Username.MaxLength = 10;
            this.TextBox1_Username.Name = "TextBox1_Username";
            this.TextBox1_Username.Size = new System.Drawing.Size(351, 22);
            this.TextBox1_Username.TabIndex = 0;
            this.TextBox1_Username.TextChanged += new System.EventHandler(this.TextBox1_Username_TextChanged);
            // 
            // TextBox2_Password
            // 
            this.TextBox2_Password.Location = new System.Drawing.Point(277, 267);
            this.TextBox2_Password.MaxLength = 10;
            this.TextBox2_Password.Name = "TextBox2_Password";
            this.TextBox2_Password.PasswordChar = '*';
            this.TextBox2_Password.Size = new System.Drawing.Size(351, 22);
            this.TextBox2_Password.TabIndex = 1;
            this.TextBox2_Password.TextChanged += new System.EventHandler(this.TextBox1_Username_TextChanged);
            // 
            // Lbl4_Check_Login
            // 
            this.Lbl4_Check_Login.AutoSize = true;
            this.Lbl4_Check_Login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl4_Check_Login.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4_Check_Login.ForeColor = System.Drawing.Color.Red;
            this.Lbl4_Check_Login.Location = new System.Drawing.Point(284, 306);
            this.Lbl4_Check_Login.Name = "Lbl4_Check_Login";
            this.Lbl4_Check_Login.Size = new System.Drawing.Size(0, 23);
            this.Lbl4_Check_Login.TabIndex = 5;
            this.Lbl4_Check_Login.Visible = false;
            // 
            // Btn1_Login
            // 
            this.Btn1_Login.AutoSize = true;
            this.Btn1_Login.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btn1_Login.Enabled = false;
            this.Btn1_Login.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_Login.ForeColor = System.Drawing.Color.White;
            this.Btn1_Login.Location = new System.Drawing.Point(277, 344);
            this.Btn1_Login.Name = "Btn1_Login";
            this.Btn1_Login.Size = new System.Drawing.Size(351, 50);
            this.Btn1_Login.TabIndex = 6;
            this.Btn1_Login.Text = "Login";
            this.Btn1_Login.UseVisualStyleBackColor = false;
            this.Btn1_Login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn1_Login_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_28_07_2021.Properties.Resources.usernae;
            this.pictureBox1.Location = new System.Drawing.Point(215, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::_28_07_2021.Properties.Resources.pas;
            this.pictureBox2.Location = new System.Drawing.Point(215, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_28_07_2021.Properties.Resources.asdfg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 529);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn1_Login);
            this.Controls.Add(this.Lbl4_Check_Login);
            this.Controls.Add(this.TextBox2_Password);
            this.Controls.Add(this.TextBox1_Username);
            this.Controls.Add(this.Lbl3_Password);
            this.Controls.Add(this.Lbl2_Username);
            this.Controls.Add(this.Lbl1_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1_Login;
        private System.Windows.Forms.Label Lbl2_Username;
        private System.Windows.Forms.Label Lbl3_Password;
        private System.Windows.Forms.TextBox TextBox1_Username;
        private System.Windows.Forms.TextBox TextBox2_Password;
        private System.Windows.Forms.Label Lbl4_Check_Login;
        private System.Windows.Forms.Button Btn1_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

