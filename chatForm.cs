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
    public partial class chatForm : Form
    {
        string conString;
        public chatForm()
        {
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            try
            {
                using (MySqlConnection dbConnection = new MySqlConnection())
                {
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        this.Cursor = Cursors.WaitCursor;
                        dbConnection.ConnectionString = conString;
                        cmd.Connection = dbConnection;
                        dbConnection.Open();
                        string inputID = login.userId;
                        string quarry =
                            "INSERT INTO userListInChat(userId) " +
                            "VALUES('" + inputID + "')";
                        cmd.CommandText = quarry;
                        cmd.ExecuteNonQuery();
                        quarry =
                            "SELECT userId " +
                            "FROM userListInChat";
                        cmd.CommandText = quarry;
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                l_userList.Items.Add(reader.GetString(0));
                            }
                        }
                        dbConnection.Close();
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "\n\nchatForm 생성자");
            }
        }

        private void b_exitChat_Click(object sender, EventArgs e)
        {
            using(MySqlConnection dbConnection = new MySqlConnection())
            {
                using(MySqlCommand cmd = new MySqlCommand())
                {
                    this.Cursor = Cursors.WaitCursor;
                    dbConnection.ConnectionString = conString;
                    cmd.Connection = dbConnection;
                    dbConnection.Open();
                    // 리스트 삭제 추가
                    dbConnection.Close();
                    this.Cursor = Cursors.Default;
                }
            }
        }
    }
}
