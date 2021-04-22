using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Contacts
{
    
    public partial class From1 : Form
    {
        string connection = "server=remotemysql.com;user=Me6WqT7uk1;database=Me6WqT7uk1;password=S9IderbQKm;";
        
        private void WriteDateOnBd(string name, string surname, string position, string phoneNumber)
        {
            MySqlConnection conn = new MySqlConnection(connection);           
            conn.Open();

            string sql = $"SELECT MAX(id) from baseNumber";
         
            MySqlCommand command = new MySqlCommand(sql, conn);
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());

            sql = $"INSERT INTO baseNumber(id, name, surname, position, phonenumber) VALUES({++id}, '{name}', '{surname}', '{position}', '{phoneNumber}')";
            command = new MySqlCommand(sql, conn);
            
            command.ExecuteNonQuery();
            conn.Clone();
            //INSERT INTO `Me6WqT7uk1`.`baseNumber` (`id`, `name`, `surname`, `position`, `phone number`) VALUES('0', 'Andrew', 'Chupakhin', 'engineer', '89224441122');

        }

        private void ReadOnBd()
        {

          

            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();

            string sql = $"SELECT name, surname, position, phonenumber from baseNumber";

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader mySqlData = command.ExecuteReader();
            mySqlData.Read();
            mySqlData.Read();
            mySqlData.Read();
            while (mySqlData.Read())
            {
             
                    dataGridView1.Rows.Add(mySqlData[0].ToString(), mySqlData[1].ToString(), mySqlData[2].ToString(), mySqlData[3].ToString());
            }
            conn.Clone();
        }

        public From1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("column-1", "Name");
            dataGridView1.Columns.Add("column-2", "surname");
            dataGridView1.Columns.Add("column-3", "position");
            dataGridView1.Columns.Add("column-4", "phone number");

            ReadOnBd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && surname.Text != "" && position.Text != "" && phone.Text != "")
            {
                
                    WriteDateOnBd(name.Text, surname.Text, position.Text, phone.Text);
            }
            ReadOnBd();
        }


    }
}
