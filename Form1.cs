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

namespace PraktikumWeek8
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();

        }
        static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;


        public string sqlQuery;


        private void comboBoxTim1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelManager1.Text = comboBoxTim1.SelectedValue.ToString();
        }

        private void comboBoxTim2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelManager2.Text = comboBoxTim2.SelectedValue.ToString();
        }


        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtTeam = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', team_is as 'ID Team' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBoxTim1.DataSource = dtTeam;
            comboBoxTim1.DisplayMember = "Nama Tim";
            comboBoxTim1.ValueMember = "ID Team";

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtPlayer = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', team_is as 'ID Team' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvPlayer.DataSource = dtPlayer;
        }
    }
}
