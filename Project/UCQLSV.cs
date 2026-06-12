using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class UCQLSV : UserControl
    {
        DTBdbmlDataContext db = new DTBdbmlDataContext();

        private int currentPage = 1;
        private int pageSize = 1;
        private int totalPage = 0;
       
        public UCQLSV()
        {
            InitializeComponent();
            Load += UCQLSV_OnLoad;
        }

        private void UCQLSV_OnLoad(object sender, EventArgs e)
        {
            LoadData();
            comboBox1.DataSource = new List<String>
            {
                "Nam",
                "Nữ"
            };
            comboBox2.DataSource = db.tbl_lophocs.ToList();
            comboBox2.DisplayMember = "lop";
            comboBox2.ValueMember = "malop";
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
                from sv in db.tbl_sinhviens
                join lh in db.tbl_lophocs
                    on sv.malop equals lh.malop
                select new
                {
                    sv.mssv,
                    Gioitinh = sv.gioitinh ? "nam" : "nu",
                    sv.hovaten,
                    sv.ngaysinh,
                    sv.malop,
                    sv.ghichu
                };

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
                    x.hovaten.Contains(keyword) ||
                    x.malop.Contains(keyword) ||
                    x.mssv.ToString().Contains(keyword));
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
            tbl_sinhvien sv = new tbl_sinhvien();
            sv.mssv = int.Parse(textBox1.Text);
            sv.hovaten = textBox2.Text;
            sv.ngaysinh = DateTime.Parse(dateTimePicker1.Text);
            sv.gioitinh = comboBox1.SelectedValue.ToString() == "Nam" ? true : false;
            sv.malop = comboBox2.SelectedValue.ToString();

            try
            {
                db.tbl_sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();
                MessageBox.Show("Thêm sinh viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Column1"].Value?.ToString();
                textBox2.Text = row.Cells["Column2"].Value?.ToString();
                dateTimePicker1.Text = row.Cells["Column4"].Value?.ToString();
                comboBox1.Text = row.Cells["gioitinh"].Value?.ToString();
                comboBox2.Text = row.Cells["Column5"].Value?.ToString();
                textBox5.Text = row.Cells["ghichu"].Value?.ToString();
            }
        }
    }
}
