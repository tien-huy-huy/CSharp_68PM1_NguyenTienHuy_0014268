using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Quanly : Form
    {
        public Quanly()
        {
            InitializeComponent();
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            quanlyToolStripMenuItem_Click(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH QLLH = new UCQLLH();
            panel1.Controls.Clear();
            panel1.Controls.Add(QLLH);
            btn_toolitem1.Font = new Font(btn_toolitem1.Font, FontStyle.Regular);
            btn_Toolitem2.Font = new Font(btn_Toolitem2.Font, FontStyle.Bold);
        }

        private void quanlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSV QLSV = new UCQLSV();
            panel1.Controls.Clear();
            panel1.Controls.Add(QLSV);
            btn_toolitem1.Font = new Font(btn_toolitem1.Font, FontStyle.Bold);
            btn_Toolitem2.Font = new Font(btn_Toolitem2.Font, FontStyle.Regular);
        }
    }
}
