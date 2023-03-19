using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Регистрация : Form
    {
        DataBase database = new DataBase();
        public Регистрация()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех");
                Авторизация авторизация = new Авторизация();
                this.Hide();
                авторизация.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
        }

        private Boolean checkuser()
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = {passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '#';
        }
    }
}
