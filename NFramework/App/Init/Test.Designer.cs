namespace NFramework.App.Init
{
    partial class Test
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
            lbl_setup_screen = new Label();
            lbl_language = new Label();
            SuspendLayout();
            // 
            // lbl_setup_screen
            // 
            lbl_setup_screen.AutoSize = true;
            lbl_setup_screen.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_setup_screen.ForeColor = Color.Coral;
            lbl_setup_screen.Location = new Point(214, 69);
            lbl_setup_screen.Name = "lbl_setup_screen";
            lbl_setup_screen.Size = new Size(402, 38);
            lbl_setup_screen.TabIndex = 0;
            lbl_setup_screen.Text = "SYSTEM CONFIGURATION";
            // 
            // lbl_language
            // 
            lbl_language.AutoSize = true;
            lbl_language.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_language.ForeColor = SystemColors.ButtonHighlight;
            lbl_language.Location = new Point(303, 133);
            lbl_language.Name = "lbl_language";
            lbl_language.Size = new Size(207, 28);
            lbl_language.TabIndex = 1;
            lbl_language.Text = "Select Language";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_language);
            Controls.Add(lbl_setup_screen);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_setup_screen;
        private Label lbl_language;
    }
}