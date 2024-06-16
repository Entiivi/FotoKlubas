namespace FotoKlubas
{
    partial class Create_Account_Langas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Account_Langas));
            pictureBox2 = new PictureBox();
            textBox_name = new TextBox();
            textBox_lastname = new TextBox();
            textBox_password = new TextBox();
            textBox_email = new TextBox();
            textBox_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_tel = new TextBox();
            label7 = new Label();
            button_exit = new Button();
            button_create = new Button();
            label8 = new Label();
            textBox_tday = new DateTimePicker();
            comboBox_Mem = new ComboBox();
            label9 = new Label();
            textBox_adress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(169, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 78);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(169, 122);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(157, 23);
            textBox_name.TabIndex = 9;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(169, 174);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(157, 23);
            textBox_lastname.TabIndex = 10;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(169, 484);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(157, 23);
            textBox_password.TabIndex = 11;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(169, 228);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(157, 23);
            textBox_email.TabIndex = 12;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(169, 429);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(157, 23);
            textBox_username.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(80, 120);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(47, 172);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 16;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(87, 226);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(79, 286);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 18;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(28, 338);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 19;
            label5.Text = "Today's date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(56, 482);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 20;
            label6.Text = "Password";
            // 
            // textBox_tel
            // 
            textBox_tel.Location = new Point(169, 284);
            textBox_tel.Name = "textBox_tel";
            textBox_tel.Size = new Size(157, 23);
            textBox_tel.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(50, 429);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 22;
            label7.Text = "Username";
            label7.TextAlign = ContentAlignment.MiddleRight;
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
            button_exit.Location = new Point(215, 598);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(133, 40);
            button_exit.TabIndex = 24;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_create
            // 
            button_create.BackColor = Color.FromArgb(128, 255, 128);
            button_create.BackgroundImageLayout = ImageLayout.None;
            button_create.Cursor = Cursors.Hand;
            button_create.FlatAppearance.BorderColor = Color.Black;
            button_create.FlatAppearance.BorderSize = 0;
            button_create.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            button_create.FlatStyle = FlatStyle.Flat;
            button_create.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_create.Location = new Point(76, 598);
            button_create.Name = "button_create";
            button_create.Size = new Size(133, 40);
            button_create.TabIndex = 23;
            button_create.Text = "CREATE";
            button_create.UseVisualStyleBackColor = false;
            button_create.Click += button_create_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(3, 384);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 26;
            label8.Text = "FotoClub adress";
            // 
            // textBox_tday
            // 
            textBox_tday.Location = new Point(169, 336);
            textBox_tday.Name = "textBox_tday";
            textBox_tday.Size = new Size(157, 23);
            textBox_tday.TabIndex = 27;
            // 
            // comboBox_Mem
            // 
            comboBox_Mem.FormattingEnabled = true;
            comboBox_Mem.Items.AddRange(new object[] { "1", "2" });
            comboBox_Mem.Location = new Point(169, 532);
            comboBox_Mem.Name = "comboBox_Mem";
            comboBox_Mem.Size = new Size(157, 23);
            comboBox_Mem.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(32, 532);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 29;
            label9.Text = "Membership";
            // 
            // textBox_adress
            // 
            textBox_adress.Location = new Point(169, 382);
            textBox_adress.Name = "textBox_adress";
            textBox_adress.Size = new Size(157, 23);
            textBox_adress.TabIndex = 25;
            // 
            // Create_Account_Langas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 673);
            Controls.Add(label9);
            Controls.Add(comboBox_Mem);
            Controls.Add(textBox_tday);
            Controls.Add(label8);
            Controls.Add(textBox_adress);
            Controls.Add(button_exit);
            Controls.Add(button_create);
            Controls.Add(label7);
            Controls.Add(textBox_tel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_username);
            Controls.Add(textBox_email);
            Controls.Add(textBox_password);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_name);
            Controls.Add(pictureBox2);
            Name = "Create_Account_Langas";
            ShowIcon = false;
            Text = "Create Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox textBox_name;
        private TextBox textBox_lastname;
        private TextBox textBox_password;
        private TextBox textBox_email;
        private TextBox textBox_username;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_tel;
        private Label label7;
        private Button button_exit;
        private Button button_create;
        private Label label8;
        private DateTimePicker textBox_tday;
        private ComboBox comboBox_Mem;
        private Label label9;
        private TextBox textBox_adress;
    }
}