namespace project
{
    partial class quanlysinhvien
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
            quanlyToolStripMenuItem = new ToolStripMenuItem();
            quanlylophocToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dangxuatToolStripMenuItem = new ToolStripMenuItem();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quanlyToolStripMenuItem, quanlylophocToolStripMenuItem, dangxuatToolStripMenuItem });
            menuStrip1.Location = new Point(10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1888, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quanlyToolStripMenuItem
            // 
            quanlyToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quanlyToolStripMenuItem.Name = "quanlyToolStripMenuItem";
            quanlyToolStripMenuItem.Size = new Size(175, 29);
            quanlyToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            quanlylophocToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            quanlylophocToolStripMenuItem.Size = new Size(154, 29);
            quanlylophocToolStripMenuItem.Text = "Quản lý lớp học";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(778, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1048, 609);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(53, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 464);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel1.Location = new Point(20, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 416);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0, 0, 0, 10);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 35);
            textBox1.Margin = new Padding(0, 0, 0, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(607, 31);
            textBox1.TabIndex = 1;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 76);
            label2.Margin = new Padding(0, 0, 0, 10);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 111);
            textBox2.Margin = new Padding(0, 0, 0, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(607, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 152);
            label3.Margin = new Padding(0, 0, 0, 10);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 239);
            label4.Margin = new Padding(0, 0, 0, 10);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 6;
            label4.Text = "Giới Tính";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3281336F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3281364F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6874542F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3281364F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3281364F));
            tableLayoutPanel2.Controls.Add(button10, 4, 0);
            tableLayoutPanel2.Controls.Add(button9, 3, 0);
            tableLayoutPanel2.Controls.Add(button7, 1, 0);
            tableLayoutPanel2.Controls.Add(button6, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 2, 0);
            tableLayoutPanel2.Location = new Point(778, 871);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(674, 80);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(76, 80);
            button6.TabIndex = 0;
            button6.Text = "<<";
            button6.UseVisualStyleBackColor = false;
            
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(76, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(76, 80);
            button7.TabIndex = 1;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(520, 0);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(76, 80);
            button9.TabIndex = 3;
            button9.Text = ">";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonFace;
            button10.Dock = DockStyle.Fill;
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatAppearance.BorderSize = 2;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(596, 0);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(78, 80);
            button10.TabIndex = 4;
            button10.Text = ">>";
            button10.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(155, 0);
            label5.Name = "label5";
            label5.Size = new Size(362, 80);
            label5.TabIndex = 5;
            label5.Text = "Trang 1/1 | 3 bản ghi";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(778, 96);
            label6.Name = "label6";
            label6.Size = new Size(250, 25);
            label6.TabIndex = 8;
            label6.Text = "Tìm kiếm (Tên/ Mã SV/Lớp):";
            
            // 
            // textBox5
            // 
            textBox5.Location = new Point(778, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(459, 31);
            textBox5.TabIndex = 9;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkSlateBlue;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(1277, 122);
            button8.Name = "button8";
            button8.Size = new Size(167, 80);
            button8.TabIndex = 10;
            button8.Text = "Tìm";
            button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(10, 10);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(308, 66);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(338, 10);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(308, 66);
            button2.TabIndex = 6;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 9F);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(10, 96);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(308, 66);
            button3.TabIndex = 7;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 9F);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(338, 96);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(308, 66);
            button4.TabIndex = 8;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
           
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(53, 658);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(657, 172);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 313);
            label7.Margin = new Padding(0, 0, 0, 10);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 8;
            label7.Text = "Lớp";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(604, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(604, 33);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 351);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(604, 33);
            comboBox2.TabIndex = 12;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            dangxuatToolStripMenuItem.Size = new Size(109, 29);
            dangxuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SV";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ và Tên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới Tính";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày sinh";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Lớp";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // quanlysinhvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button8);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "quanlysinhvien";
            Padding = new Padding(10, 0, 0, 0);
            Text = "quanlysinhvien";
            WindowState = FormWindowState.Maximized;
            
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quanlyToolStripMenuItem;
        private ToolStripMenuItem quanlylophocToolStripMenuItem;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button6;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ToolStripMenuItem dangxuatToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewComboBoxColumn Column5;
    }
}