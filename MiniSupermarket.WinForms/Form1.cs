using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CleanHouse.WinForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tài khoản và mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                var data = new
                {
                    username = username,
                    password = password
                };

                string json = JsonSerializer.Serialize(data);

                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PostAsync(
                    "https://localhost:7054/api/Auth/login",
                    content);

                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Đăng nhập thành công!",
                        "Clean House",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Sau này có thể mở Form chính tại đây
                    // FormMain main = new FormMain();
                    // main.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Đăng nhập thất bại!\n\n" + result,
                        "Clean House",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kết nối đến API.\n\n" +
                    "Hãy kiểm tra API đã chạy chưa.\n\n" +
                    ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}