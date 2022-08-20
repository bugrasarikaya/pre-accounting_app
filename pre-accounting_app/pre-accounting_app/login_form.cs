﻿using System.Drawing;
using System.Windows.Forms;

namespace pre_accounting_app {
    internal class login_form : Form {
        internal login_form() { // Constructor.
            Width = 300;
            Height = 500;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            PictureBox logo_box = new PictureBox();
            string logo_address = "pictures\\logo.png";
            Image logo_image = Image.FromFile(logo_address);
            logo_box.Image = logo_image;
            float picturebox_width = Width * 0.6f;
            float scale = picturebox_width / logo_image.Width;
            logo_box.Size = new Size((int)picturebox_width, (int)(logo_image.Height * scale));
            logo_box.SizeMode = PictureBoxSizeMode.StretchImage;
            int initial_gap = 30;
            logo_box.Location = new Point((Width - logo_box.Size.Width) / 2, initial_gap);
            Controls.Add(new top_panel(this));
            Controls.Add(logo_box);
        }
    }
}