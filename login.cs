using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using MySql.Data.MySqlClient;

namespace kokonut
{
    public partial class login : Form
    {
        string conString;
        public static string userId;
        public login()
        {
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }

        private void l_openRegister_Click(object sender, EventArgs e)
        {
            register forOpenForm = new register();
            forOpenForm.Show();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection dbConnection = new MySqlConnection())
                {
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        this.Cursor = Cursors.WaitCursor;
                        dbConnection.ConnectionString = conString;
                        dbConnection.Open();
                        string quarry =
                            "SELECT id, password " +
                            "FROM user";
                        cmd.CommandText = quarry;
                        cmd.Connection = dbConnection;
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if(t_idInput.Text == reader.GetString(0) && t_passwordInput.Text == reader.GetString(1))
                                {
                                    MessageBox.Show("로그인 성공!");
                                    this.Cursor = Cursors.Default;
                                    dbConnection.Close();
                                    userId = t_idInput.Text;
                                    chatForm forShow = new chatForm();
                                    forShow.Show();
                                    return;
                                }
                            }
                            MessageBox.Show("로그인 실패!");
                        }
                        this.Cursor = Cursors.Default;
                        dbConnection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "\n\nligin.cs : b_login_Click");
            }
        }
    }
}
