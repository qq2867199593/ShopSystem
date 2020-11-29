using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class loginForm : Form
    {
        private DBConnect dbconn = new DBConnect();
        private bool _isAdmin = false;

        public loginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin(object sender, EventArgs e)
        {
            var box = dbconn.AccountFind(account.Text, password.Text);
            if (box.Item1)
            {
                MessageBox.Show("登入成功");
                if (box.Item2)
                {
                    MessageBox.Show("管理员");
                }
                else
                {
                    MessageBox.Show("用户");
                }
                this.Hide();
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        public bool GetAdmin()
        {
            return _isAdmin;
        }
    }
}
