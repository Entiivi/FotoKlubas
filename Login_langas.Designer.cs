namespace FotoKlubas
{
    partial class Prisijungimas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisijungimas));
            button_login = new Button();
            button_exit = new Button();
            textBox_pass = new TextBox();
            textBox_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button_createaccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(128, 255, 128);
            button_login.BackgroundImageLayout = ImageLayout.None;
            button_login.Cursor = Cursors.Hand;
            button_login.FlatAppearance.BorderColor = Color.Black;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.Location = new Point(268, 301);
            button_login.Name = "button_login";
            button_login.Size = new Size(133, 40);
            button_login.TabIndex = 0;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(255, 128, 128);
            button_exit.BackgroundImageLayout = ImageLayout.None;
            button_exit.Cursor = Cursors.Hand;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatAppearance.MouseOverBackColor = Color.Brown;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_exit.Location = new Point(407, 301);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(133, 40);
            button_exit.TabIndex = 1;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += Exit_Click;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(268, 240);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(272, 23);
            textBox_pass.TabIndex = 2;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(268, 200);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(272, 23);
            textBox_username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 200);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 238);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button_createaccount
            // 
            button_createaccount.BackColor = SystemColors.ButtonFace;
            button_createaccount.Cursor = Cursors.Hand;
            button_createaccount.FlatAppearance.BorderSize = 0;
            button_createaccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_createaccount.FlatStyle = FlatStyle.Flat;
            button_createaccount.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_createaccount.Location = new Point(407, 269);
            button_createaccount.Name = "button_createaccount";
            button_createaccount.Size = new Size(142, 23);
            button_createaccount.TabIndex = 7;
            button_createaccount.Text = "Create an account";
            button_createaccount.TextAlign = ContentAlignment.MiddleRight;
            button_createaccount.UseVisualStyleBackColor = false;
            button_createaccount.Click += button_createaccount_Click;
            // 
            // Prisijungimas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_createaccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_username);
            Controls.Add(textBox_pass);
            Controls.Add(button_exit);
            Controls.Add(button_login);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Prisijungimas";
            ShowIcon = false;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_login;
        private Button button_exit;
        private TextBox textBox_pass;
        private TextBox textBox_username;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button_createaccount;
    }
}
