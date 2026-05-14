namespace project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            if (text1 == "nanithe123456@gmail.com" && text2 == "0014268")
            {
                MessageBox.Show("Đăng nhập thành công!");

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
