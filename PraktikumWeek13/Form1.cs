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
        DataTable dtTeam = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtNumeric = new DataTable();

        int posisiNow = 0;


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id ";
           // sqlQuery = "SELECT *from player_mtc";
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

            sqlQuery = "SELECT n.`nation` as 'nationality', n.nationality_id as 'nationality id'  from nationality n";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            cboxNationality.DataSource = dtNationality;
            cboxNationality.DisplayMember = "nationality";
            cboxNationality.ValueMember = "nationality id";
            IsiDataPemain(0);
        }


        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            tboxPlayerID.Text = dtPemain.Rows[Posisi][0].ToString();
            tboxPlayerName.Text = dtPemain.Rows[Posisi][1].ToString();
            dtBirthdate.Text = dtPemain.Rows[Posisi][2].ToString();
            cboxNationality.Text = dtPemain.Rows[Posisi][3].ToString();
            cboxTeam.Text = dtPemain.Rows[Posisi][4].ToString();
            numTeamNumber.Text = dtPemain.Rows[Posisi][5].ToString();
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
          if(lblAvailability.Text == "Available")
            {
                sqlQuery = $"UPDATE player_mtc SET player_name = '" + tboxPlayerName.Text + "', team_number = '" + numTeamNumber.Value.ToString() + "', nationality_id = '" + cboxNationality.SelectedValue.ToString() + "', team_id = '" + cboxTeam.SelectedValue.ToString() + "' where player_id = '" + tboxPlayerID.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data Player " + tboxPlayerName.Text + " has been saved.");

            }
          else if (lblAvailability.Text == "Not Available")
            {
                MessageBox.Show("Player Not Available");
            }


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

        private void numTeamNumber_ValueChanged(object sender, EventArgs e)
        {

            sqlQuery = $"SELECT * FROM player WHERE team_id='{cboxTeam.SelectedValue}' and team_number={numTeamNumber.Value}";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNumeric);

            if (dtNumeric.Rows.Count > 0)
            {
                lblAvailability.Text = "Not Available";
            }
            else
            {
                lblAvailability.Text = "Available";
            }

        }
    }
}
