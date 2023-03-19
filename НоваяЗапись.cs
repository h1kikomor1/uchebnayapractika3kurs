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
    public partial class НоваяЗапись : Form
    {
        DataBase dataBase = new DataBase();
        public НоваяЗапись()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var type = textBox_tiptov.Text;
            var count = textBox_kol.Text;
            var postav = textBox_post.Text;
            int price;

            if (int.TryParse(textBox_price.Text, out price))
            {
                var addQuery = $"insert into test_db (type_of, count_of, postavka, price) values ('{type}','{count}','{postav}','{price}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Усппех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }
    }
}
