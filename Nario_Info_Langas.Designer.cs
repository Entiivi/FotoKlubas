namespace FotoKlubas
{
    partial class Nario_Info_Langas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nario_Info_Langas));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label_user = new Label();
            label_pass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 78);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 53);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_user.Location = new Point(215, 19);
            label_user.Name = "label_user";
            label_user.Size = new Size(0, 21);
            label_user.TabIndex = 11;
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_pass.Location = new Point(215, 53);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(0, 21);
            label_pass.TabIndex = 12;
            // 
            // Nario_Info_Langas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 114);
            Controls.Add(label_pass);
            Controls.Add(label_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Nario_Info_Langas";
            ShowIcon = false;
            Text = "Login Information";
            Load += Nario_Info_Langas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label_user;
        private Label label_pass;
    }
}