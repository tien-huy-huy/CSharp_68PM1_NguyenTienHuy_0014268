using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //paginate and search function
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

            totalPage = (int)Math.Ceiling((double)query.Count() / pageSize);

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
        //paginate
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

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_lophoc lh = new tbl_lophoc();
            lh.id = int.Parse(textBox1.Text);
            lh.malop = textBox2.Text;
            lh.tenlop = textBox3.Text;
            lh.ghichu = textBox4.Text;

            try
            {
                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();
                MessageBox.Show("Them thanh cong");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["id"].Value?.ToString();
                textBox2.Text = row.Cells["malop"].Value?.ToString();
                textBox3.Text = row.Cells["tenlop"].Value?.ToString();
                textBox4.Text = row.Cells["ghichu"].Value?.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tbl_lophoc lh = new tbl_lophoc();
            //lh.id = int.Parse(textBox1.Text);
            //lh.malop = textBox2.Text;
            //lh.tenlop = textBox3.Text;
            //lh.ghichu = textBox4.Text;

            //var lophoc = db.tbl_lophocs.FirstOrDefault(s => s.id == lh.id);

            //if (lophoc != null)
            //{
            //    lophoc.malop = lh.malop;
            //    lophoc.tenlop = lh.tenlop;
            //    lophoc.ghichu = lh.ghichu;
            //    db.SubmitChanges();
            //    MessageBox.Show("Cập nhật thành công");
            //    LoadData();
            //}
        }
    }
}