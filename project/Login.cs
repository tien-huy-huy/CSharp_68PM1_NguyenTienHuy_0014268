namespace project
{
    public partial class Login : Form
    {

        public Login()
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
                Form qly = new Quanly();
                qly.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
