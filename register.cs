using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using System.Configuration;

namespace kokonut
{
    public partial class register : Form
    {
        string conString;
        public register()
        {
            InitializeComponent();
            c_list.SelectedIndex = 0;
            conString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_creat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(t_cheakPassword.Text) || string.IsNullOrEmpty(t_inputId.Text) || string.IsNullOrEmpty(t_inputPassword.Text) || string.IsNullOrEmpty(t_listInput.Text))
            {
                MessageBox.Show("빈 칸이 있습니다");
                return;
            }
            if(t_inputPassword.Text != t_cheakPassword.Text)
            {
                MessageBox.Show("비밀번호 확인이 일치하지 않습니다!");
                return;
            }
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlConnection connectionDB = new MySqlConnection())
                    {
                        this.Cursor = Cursors.WaitCursor;
                        connectionDB.ConnectionString = conString; // t스토리에 남겨라 : 연결 문자열은 open보다 상위에 있어야만 한다 당연한건데!
                        connectionDB.Open();
                        cmd.Connection = connectionDB;
                        string readerQuarry =
                            "SELECT id " +
                            "FROM user";
                        cmd.CommandText = readerQuarry;
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string getDbId = reader.GetString(0);
                                if(t_inputId.Text == getDbId)
                                {
                                    MessageBox.Show("이미 가입된 아이디 입니다.\n다른 아이디를 입력하세요.","중복된 아이디",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                    return;
                                }
                            }
                        }
                        string quarry =
                            "INSERT INTO " +
                            "user(id, password, select_int, answer) " +
                            "VALUES('" + t_inputId.Text + "','" + t_inputPassword.Text + "','" + c_list.SelectedIndex + "','" + t_listInput.Text + "')";
                        cmd.CommandText = quarry;
                        cmd.ExecuteNonQuery();
                        connectionDB.Close();
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("가입 완료!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
