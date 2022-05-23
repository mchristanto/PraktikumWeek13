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

namespace PraktikumWeek13
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84 ; uid = student; pwd = isbmantap; database = premier_league";
        MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        MySqlCommand sqlCommand = new MySqlCommand(sqlConnection);
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtTeamNumber = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtNationality = new DataTable();

        int posisiNow = 0;


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM player_mtc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            IsiDataPemain(0);

            sqlQuery = "SELECT t.team_name as 'team name', t.team_id as 'team id'  from team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cboxTeam.DataSource = dtTeam;
            cboxTeam.DisplayMember = "team name";
            cboxTeam.ValueMember = "team id";
            IsiDataPemain(0);

            sqlQuery = "SELECT n.nation as 'nationality', n.nationality_id as 'nationality id'  from team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            cboxTeam.DataSource = dtNationality;
            cboxTeam.DisplayMember = "nationality";
            cboxTeam.ValueMember = "nationality id";
            IsiDataPemain(0);
        }


        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            tboxPlayerID.Text = dtPemain.Rows[Posisi][0].ToString();
            tboxPlayerName.Text = dtPemain.Rows[Posisi][2].ToString();
            dtBirthdate.Text = dtPemain.Rows[Posisi][7].ToString();
            cboxNationality.Text = dtPemain.Rows[Posisi][3].ToString();
            cboxTeam.Text = dtPemain.Rows[Posisi][8].ToString();
            numTeamNumber.Text = dtPemain.Rows[Posisi][1].ToString();
            posisiNow = Posisi;
        }


        private void btnKiri1_Click(object sender, EventArgs e)
        {
            if (posisiNow > 0)
            {
                posisiNow--;
                IsiDataPemain(posisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnKanan1_Click(object sender, EventArgs e)
        {
            if (posisiNow < dtPemain.Rows.Count - 1)
            {
                posisiNow++;
                IsiDataPemain(posisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btnKiri2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnKanan2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO pelajar VALUES('" + tboxPlayerID.Text + "', '" + tboxPlayerName.Text + "', '" + dtBirthdate.Value.ToString ("yyyyMMdd") + "', '" + cboxNationality.Text + "', '" + cboxTeam.Text + "', '" + numTeamNumber.Text + "', 0)";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Player " + tboxPlayerName.Text + " has been saved.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void cboxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
