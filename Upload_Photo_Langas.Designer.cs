namespace FotoKlubas
{
    partial class Upload_Photo_Langas
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
            Photo = new Panel();
            button_upload = new Button();
            button_exit = new Button();
            aprasymas = new RichTextBox();
            Pavadinimas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_save = new Button();
            label3 = new Label();
            Photo.SuspendLayout();
            SuspendLayout();
            // 
            // Photo
            // 
            Photo.AutoSize = true;
            Photo.BackColor = SystemColors.ActiveBorder;
            Photo.CausesValidation = false;
            Photo.Controls.Add(label3);
            Photo.Location = new Point(393, 17);
            Photo.Margin = new Padding(4);
            Photo.Name = "Photo";
            Photo.Size = new Size(1241, 785);
            Photo.TabIndex = 0;
            // 
            // button_upload
            // 
            button_upload.BackColor = SystemColors.ActiveCaption;
            button_upload.Cursor = Cursors.Hand;
            button_upload.FlatAppearance.BorderSize = 0;
            button_upload.FlatAppearance.MouseOverBackColor = Color.Teal;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_upload.Location = new Point(13, 810);
            button_upload.Margin = new Padding(4);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(304, 90);
            button_upload.TabIndex = 1;
            button_upload.Text = "UPLOAD";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(255, 192, 128);
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_exit.Location = new Point(1339, 810);
            button_exit.Margin = new Padding(4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(304, 90);
            button_exit.TabIndex = 3;
            button_exit.Text = "BACK";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // aprasymas
            // 
            aprasymas.BorderStyle = BorderStyle.FixedSingle;
            aprasymas.Location = new Point(17, 112);
            aprasymas.Margin = new Padding(4);
            aprasymas.Name = "aprasymas";
            aprasymas.Size = new Size(361, 430);
            aprasymas.TabIndex = 4;
            aprasymas.Text = "";
            // 
            // Pavadinimas
            // 
            Pavadinimas.Location = new Point(17, 42);
            Pavadinimas.Margin = new Padding(4);
            Pavadinimas.Name = "Pavadinimas";
            Pavadinimas.Size = new Size(361, 27);
            Pavadinimas.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(17, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(17, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 7;
            label2.Text = "About";
            // 
            // button_save
            // 
            button_save.BackColor = Color.LightGreen;
            button_save.Cursor = Cursors.Hand;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatAppearance.MouseOverBackColor = Color.Teal;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_save.Location = new Point(325, 810);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(304, 90);
            button_save.TabIndex = 8;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 200.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(284, 173);
            label3.Name = "label3";
            label3.Size = new Size(712, 324);
            label3.TabIndex = 0;
            label3.Text = ".JPG";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Upload_Photo_Langas
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1651, 917);
            Controls.Add(button_upload);
            Controls.Add(button_save);
            Controls.Add(label2);
            Controls.Add(button_exit);
            Controls.Add(label1);
            Controls.Add(Pavadinimas);
            Controls.Add(aprasymas);
            Controls.Add(Photo);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            Name = "Upload_Photo_Langas";
            ShowIcon = false;
            Text = " ";
            Photo.ResumeLayout(false);
            Photo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel Photo;
        private Button button_upload;
        private Button button_exit;
        private RichTextBox aprasymas;
        private TextBox Pavadinimas;
        private Label label1;
        private Label label2;
        private Button button_save;
        private Label label3;
    }
}