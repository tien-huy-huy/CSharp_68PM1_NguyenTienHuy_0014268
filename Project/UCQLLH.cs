using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace Project
{
    public partial class UCQLLH : UserControl
    {
        DTBdbmlDataContext db = new DTBdbmlDataContext();

        private int currentPage = 1;
        private int pageSize = 1;
        private int totalPage = 0;
        public UCQLLH()
        {
            InitializeComponent();
            Load += UCQLLH_OnLoad;
        }

        private void UCQLLH_OnLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void LoadData()
        {
            string keyword = textBox5.Text.Trim();

            var query =
                from lh in db.tbl_lophocs
                select new
                {
                    lh.id,
                    lh.tenlop,
                    lh.malop,
                    lh.ghichu
                };

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
                    x.malop.Contains(keyword) ||
                    x.tenlop.Contains(keyword) ||
                    x.id.ToString().Contains(keyword));
            }

            totalPage = (int)Math.Ceiling((double)query.Count()/pageSize);

            dataGridView1.DataSource = query
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            button7.Enabled = currentPage > 1;
            button9.Enabled = currentPage < totalPage;
            button6.Enabled = !(currentPage == 1);
            button10.Enabled = !(currentPage == totalPage);

            label5.Text = $"Page {currentPage}/{totalPage}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
                currentPage++;
                LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
                currentPage--;
                LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            LoadData();
        }
    }
}
