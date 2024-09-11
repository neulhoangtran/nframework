using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFramework.App.Init
{
    public partial class Start : Form
    {
        private float opacity = 0.0f;
        private int elapsed = 0;

        private Label lblAppName;
        private Label lblLocale;
        //private ComboBox cbLanguages;
        public Start()
        {
            InitializeComponent();
            timeStart.Interval = 100;
            timeStart.Tick += timeStart_Tick;
            timeStart.Start();
            btnStart.Visible = false;
            InitialNextSetupScreen();
        }

        private void timeStart_Tick(object sender, EventArgs e)
        {
            elapsed += timeStart.Interval;
            //lbl_wellcome.Visible = true;
            if (elapsed >= 6000)
            {
                // Thực hiện fade-in
                if (opacity < 1.0f)
                {
                    opacity += 0.05f; // Tăng độ mờ dần dần
                    panel_txt_welcome.Invalidate(); // Yêu cầu vẽ lại Panel
                }
                else
                {
                    timeStart.Stop(); // Dừng Timer khi đạt độ mờ tối đa
                    btnStart.Visible = true;
                }
            }
        }

        private void panel_txt_welcome_Paint(object sender, PaintEventArgs e)
        {
            // Tạo brush với độ mờ hiện tại
            using (Brush brush = new SolidBrush(Color.FromArgb((int)(opacity * 255), Color.White)))
            {
                // Đo kích thước của text để căn giữa
                string text = "WELCOME TO NFW";
                Font font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Tính toán vị trí để vẽ text ở giữa Panel
                float x = (panel_txt_welcome.Width - textSize.Width) / 2;
                float y = (panel_txt_welcome.Height - textSize.Height) / 2;

                // Vẽ text với vị trí căn giữa
                e.Graphics.DrawString(text, font, brush, new PointF(x, y));
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            panel_txt_welcome.Visible = false;
            pictureBoxStart.Visible = false;

            lblAppName.Visible = true;
            lblLocale.Visible = true;
        }

        private void InitialNextSetupScreen()
        {
            lblAppName = new Label
            {
                Text = "SYSTEM CONFIGURATION",
                Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Coral,
                Location = new Point(214, 69),
                AutoSize = true,
                Visible = false // hide after init
            };

            lblLocale = new Label
            {
                Text = "Select Language",
                Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(303, 133),
                AutoSize = true,
                Visible = false // hide after init
            };

            this.Controls.Add(lblAppName);
            this.Controls.Add(lblLocale);

        }
    }
}
