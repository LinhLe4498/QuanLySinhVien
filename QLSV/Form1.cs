namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy dữ iệu từ các control đưa vào biến
            string name = txtName.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            int phone = int.Parse(txtPhone.Text.Trim());
            string gt = cboGender.SelectedItem.ToString();
            //Kết nối database
            sqlConnection con = new sqlConnection("Data Source=ADMIN-PC\\LOCALHOST;Initial Catalog=quanlysinhvien;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        }
    }
}
