using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    partial class Quanly
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
            menuStrip1 = new MenuStrip();
            btn_toolitem1 = new ToolStripMenuItem();
            btn_Toolitem2 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_toolitem1, btn_Toolitem2, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_toolitem1
            // 
            btn_toolitem1.Name = "btn_toolitem1";
            btn_toolitem1.Size = new Size(163, 29);
            btn_toolitem1.Text = "Quản lý sinh viên";
            btn_toolitem1.Click += quanlyToolStripMenuItem_Click;
            // 
            // btn_Toolitem2
            // 
            btn_Toolitem2.Font = new Font("Segoe UI", 9F);
            btn_Toolitem2.Name = "btn_Toolitem2";
            btn_Toolitem2.Size = new Size(154, 29);
            btn_Toolitem2.Text = "Quản lý lớp học";
            btn_Toolitem2.Click += quảnLýLớpHọcToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(109, 29);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 402);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Quanly";
            Text = "Quanly";
            WindowState = FormWindowState.Maximized;
            Load += Quanly_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_toolitem1;
        private ToolStripMenuItem btn_Toolitem2;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel1;
    }
}