﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace pre_accounting_app {
    internal class button_return : Button {
        Panel panel_current, panel_next;
        form_main form_main;
        panel_top panel_top;
        internal button_return(form_main form_main, Panel panel_current, panel_top panel_top) { // Constructor.
            this.form_main = form_main;
            this.panel_current = panel_current;
            this.panel_top = panel_top;
            int vertical_gap, horizantal_gap;
            vertical_gap = (int)(panel_top.height * 0.6f);
            horizantal_gap = vertical_gap;
            Width = 80;
            Height = (int)(Width * 0.33f);
            Location = new Point(panel_top.width - horizantal_gap - Width, vertical_gap);
            Text = "Return";
            Font = new Font(Font.FontFamily, (int)(Height * 0.4f));
            Click += event_handler_click;
        }
        internal void event_handler_click(object sender, EventArgs e) { // Calling main form method for changing panel.
            if (panel_current.Name == "customers") panel_next = new panel_main(form_main, panel_top);
            else if (panel_current.Name == "products") panel_next = new panel_main(form_main, panel_top);
            else if (panel_current.Name == "receipts") panel_next = new panel_main(form_main, panel_top);
            else if (panel_current.Name == "add_customer") panel_next = new panel_customers(form_main, panel_top);
            else if (panel_current.Name == "add_product") panel_next = new panel_products(form_main, panel_top);
            else if (panel_current.Name == "add_receipt") panel_next = new panel_receipts(form_main, panel_top);
            ((form_main)Parent.Parent).open_new_panel(panel_current, panel_next);
        }
    }
}