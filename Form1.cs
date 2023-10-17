using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //insert 
            string sql = "insert into aluno (nome) values ('Herick')";

            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd='';database='uninove'");

            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery(); // insert / update / delete
            // cmd.ExecuteReader(); // para select


            MessageBox.Show("Dados inseridos com sucesso!");

            con.Close();
            con.Dispose();
            cmd.Dispose();

        }

        //delete

        private void buttonDeletar_Click(object sender, EventArgs e)
            {

            //delete
            string sql = "delete from aluno where 1";

            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd='';database='uninove'");

            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery(); // insert / update / delete
            // cmd.ExecuteReader(); // para select

            MessageBox.Show("Dados excluidos com sucesso!");

            con.Close();
            con.Dispose();
            cmd.Dispose();

        }

        // alterar
        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            //delete
            string sql = "update aluno set nome = 'Marcus'";

            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd='';database='uninove'");

            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery(); // insert / update / delete
            // cmd.ExecuteReader(); // para select

            MessageBox.Show("Dados alterados com sucesso!");

            con.Close();
            con.Dispose();
            cmd.Dispose();

        }


    }
}
