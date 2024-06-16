namespace FotoKlubas
{
    partial class Narys_Pagrindinis_Langas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Narys_Pagrindinis_Langas));
            pictureBox2 = new PictureBox();
            button_personalinfo = new Button();
            button_infologin = new Button();
            Photos = new Panel();
            button_upload = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 78);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button_personalinfo
            // 
            button_personalinfo.BackColor = Color.White;
            button_personalinfo.Cursor = Cursors.Hand;
            button_personalinfo.FlatAppearance.BorderSize = 0;
            button_personalinfo.FlatStyle = FlatStyle.Flat;
            button_personalinfo.Font = new Font("Century Gothic", 12F);
            button_personalinfo.Location = new Point(24, 218);
            button_personalinfo.Name = "button_personalinfo";
            button_personalinfo.Size = new Size(182, 30);
            button_personalinfo.TabIndex = 10;
            button_personalinfo.Text = "Personal information";
            button_personalinfo.TextAlign = ContentAlignment.MiddleLeft;
            button_personalinfo.UseVisualStyleBackColor = false;
            button_personalinfo.Click += button_personalinfo_Click;
            // 
            // button_infologin
            // 
            button_infologin.BackColor = Color.White;
            button_infologin.Cursor = Cursors.Hand;
            button_infologin.FlatAppearance.BorderSize = 0;
            button_infologin.FlatStyle = FlatStyle.Flat;
            button_infologin.Font = new Font("Century Gothic", 12F);
            button_infologin.Location = new Point(24, 171);
            button_infologin.Name = "button_infologin";
            button_infologin.Size = new Size(170, 30);
            button_infologin.TabIndex = 11;
            button_infologin.Text = "Login information";
            button_infologin.TextAlign = ContentAlignment.MiddleLeft;
            button_infologin.UseVisualStyleBackColor = false;
            button_infologin.Click += button_infologin_Click;
            // 
            // Photos
            // 
            Photos.BackColor = SystemColors.ControlDark;
            Photos.BorderStyle = BorderStyle.FixedSingle;
            Photos.Location = new Point(220, 38);
            Photos.Name = "Photos";
            Photos.Size = new Size(1589, 806);
            Photos.TabIndex = 12;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.White;
            button_upload.Cursor = Cursors.Hand;
            button_upload.FlatAppearance.BorderSize = 0;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Century Gothic", 12F);
            button_upload.Location = new Point(24, 122);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(170, 30);
            button_upload.TabIndex = 13;
            button_upload.Text = "Upload Photo";
            button_upload.TextAlign = ContentAlignment.MiddleLeft;
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 14;
            label1.Text = "Photos";
            // 
            // Narys_Pagrindinis_Langas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1821, 856);
            Controls.Add(label1);
            Controls.Add(button_upload);
            Controls.Add(Photos);
            Controls.Add(button_infologin);
            Controls.Add(button_personalinfo);
            Controls.Add(pictureBox2);
            Name = "Narys_Pagrindinis_Langas";
            ShowIcon = false;
            Text = "Pagrindinis";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button_personalinfo;
        private Button button_infologin;
        private Panel Photos;
        private Button button_upload;
        private Label label1;
    }
}