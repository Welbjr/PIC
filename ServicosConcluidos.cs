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
    public partial class ServicosConcluidos : Form
    {
        public ServicosConcluidos()
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
            string CommandText = "select * from concluidos";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView_Concluidos.DataSource = DT;
            sql_con.Close();
        }

        private void button_ConcluidosEditar_Click(object sender, EventArgs e)
        {
            string txtQuery =
                "update concluidos set " +
                "NomeAnimal='" + textBox_NomeAnimal.Text + "'," +
                "NomeDono='" + textBox_NomeDono.Text + "'," +
                "Tel='" + textBox_Tel.Text + "'," +
                "Sex='" + textBox_Sexo.Text + "'," +
                "Obs='" + textBox_Obs.Text + "'," +
                "DataInicio='" + dateTimePicker_Inicio.Text + "'," +
                "DataFim='" + dateTimePicker_Conclusao.Text +
                "'where Id='" + textBox_Id.Text + "'";

            ExecuteQuery(txtQuery); LoadData();
        }

        private void button_ConcluidosDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir Serviço?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            string txtQuery = "delete from concluidos where Id='" + textBox_Id.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
            }
        }

        private void button_ConcluidosSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Concluidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_Concluidos.SelectedRows[0].Cells[0].Value.ToString();
            textBox_NomeAnimal.Text = dataGridView_Concluidos.SelectedRows[0].Cells[1].Value.ToString();
            textBox_NomeDono.Text = dataGridView_Concluidos.SelectedRows[0].Cells[2].Value.ToString();
            textBox_Tel.Text = dataGridView_Concluidos.SelectedRows[0].Cells[3].Value.ToString();
            textBox_Sexo.Text = dataGridView_Concluidos.SelectedRows[0].Cells[4].Value.ToString();
            textBox_Obs.Text = dataGridView_Concluidos.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
