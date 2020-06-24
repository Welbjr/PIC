using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIC6
{
    public partial class NovoServico : Form
    {
        public NovoServico()
        {
            InitializeComponent();
            textBox_Id.Enabled = false;
            LoadData();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=servicos.db;Version=3;New=False;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from servicos";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewEmAndamento.DataSource = DT;
            sql_con.Close();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into servicos (NomeAnimal,NomeDono,Tel,Sex,Obs,DataInicio)" +
                "values('"+ textBox_NomeAnimal.Text +"','" + textBox_NomeDono.Text + "','" + textBox_Tel.Text + "','" + textBox_Sexo.Text + "','" + textBox_Obs.Text + "','" + dateTimePicker_Inicio.Text + "')";

            ExecuteQuery(txtQuery);     LoadData();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            string txtQuery =
                "update servicos set " +
                "NomeAnimal='"  + textBox_NomeAnimal.Text + "'," +
                "NomeDono='"    + textBox_NomeDono.Text +   "'," +
                "Tel='"         + textBox_Tel.Text +        "'," +
                "Sex='"         + textBox_Sexo.Text +       "'," +
                "Obs='"         + textBox_Obs.Text +        "'," +
                "DataInicio='"  + dateTimePicker_Inicio.Text +
                "'where Id='" + textBox_Id.Text + "'";

            ExecuteQuery(txtQuery);     LoadData();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewEmAndamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            textBox_Id.Text         = dataGridViewEmAndamento.SelectedRows[0].Cells[0].Value.ToString();
            textBox_NomeAnimal.Text = dataGridViewEmAndamento.SelectedRows[0].Cells[1].Value.ToString();
            textBox_NomeDono.Text   = dataGridViewEmAndamento.SelectedRows[0].Cells[2].Value.ToString();
            textBox_Tel.Text        = dataGridViewEmAndamento.SelectedRows[0].Cells[3].Value.ToString();
            textBox_Sexo.Text       = dataGridViewEmAndamento.SelectedRows[0].Cells[4].Value.ToString();
            textBox_Obs.Text        = dataGridViewEmAndamento.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button_Deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir Serviço?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string txtQuery = "delete from servicos where Id='" + textBox_Id.Text + "'";
                ExecuteQuery(txtQuery);
                LoadData();
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = null;
            textBox_NomeAnimal.Text = null;
            textBox_NomeDono.Text = null;
            textBox_Obs.Text = null;
            textBox_Sexo.Text = null;
            textBox_Tel.Text = null;
        }

        private void button_Concluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Concluir Serviço?", "Concluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string txtQuery = "insert into concluidos (NomeAnimal,NomeDono,Tel,Sex,Obs,DataInicio,DataFim)" +
                "values('" + textBox_NomeAnimal.Text + "','" + textBox_NomeDono.Text + "','" + textBox_Tel.Text + "','" + textBox_Sexo.Text + "','" + textBox_Obs.Text + "','" + dateTimePicker_Inicio.Text + "','" + dateTimePicker_Conclusao.Text + "')";

                string txtQueryDelete = "delete from servicos where Id='" + textBox_Id.Text + "'";

                ExecuteQuery(txtQuery); ExecuteQuery(txtQueryDelete); LoadData();
            }
        }
    }
}
