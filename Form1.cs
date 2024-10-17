using System.Text.RegularExpressions;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text; 
            string password = textBox2.Text; 

            string emailMessage = IsValidEmail(email);
            string passwordMessage = IsValidPassword(password);

            MessageBox.Show($"{emailMessage}\n{passwordMessage}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(email, pattern))
            {
                return "Email hợp lệ.";
            }
            else
            {
                return "Email yêu cầu nhập đúng định dạng.";
            }
        }

        private string IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return "Mật khẩu hợp lệ.";
            }
            else
            {
               return "Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.";
            }
        }
    }
}
