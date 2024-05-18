using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitall_Project
{
    public partial class FrmCheckIn : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private static int roomId =-1;
        private static int StuffId = -1;
        private static int clientId = -1;
        private static DataTable dtDiseases=new DataTable();
        private bool isEdit = false;
        private bool isDiseases = false;
        private bool isClient = false;
        private bool isStuff = false;
        private bool isRoom=false;

        private void refresh()
        {
            isDiseases=false; isStuff=false; isClient=false;isRoom=false;
        }
        public FrmCheckIn()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            isClient = true;
            LoadDataClient();
            dtDiseases = new DataTable();
            dtDiseases.Columns.Add("name", typeof(string));
        }

        public void LoadDataClient()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetClient", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChangeClient);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }
        public void OnChangeClient(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridView.BeginInvoke(new MethodInvoker(LoadDataClient));
            }
            else
            {
                LoadDataClient();
            }
        }
        public void LoadDataRoom()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetFreeRoom", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChangeRoom);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }
        public void OnChangeRoom(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridView.BeginInvoke(new MethodInvoker(LoadDataRoom));
            }
            else
            {
                LoadDataRoom();
            }
        }
        public void LoadDataDoctor()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetViewStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }public void LoadDataStuff()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetStuff", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChangeDoctor);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            LoadDataDoctor();


        }
        public void OnChangeDoctor(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridView.BeginInvoke(new MethodInvoker(LoadDataStuff));
            }
            else
            {
                LoadDataStuff();
            }
        }

        private void tbxRoom_Click(object sender, EventArgs e)
        {
            refresh();
            isRoom = true;
            LoadDataRoom();
        }

        private void tbxClient_Click(object sender, EventArgs e)

        {
            refresh();
            isClient = true;
            LoadDataClient();
        }

        private void tbxDoctor_Click(object sender, EventArgs e)

        {
            refresh();
            isStuff=true;
            LoadDataDoctor();
        }

        private void tbxAddNewClient_Click(object sender, EventArgs e)
        {
           
            FrmClien f=new FrmClien();
            f.ShowDialog();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridView.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                if(isClient)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    tbxClient.Text = row.Cells[1].Value.ToString();
                    clientId = int.Parse(row.Cells[0].Value.ToString());
                    
                    
                }
                else if(isStuff)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    tbxDoctor.Text = row.Cells[1].Value.ToString();
                    StuffId = int.Parse(row.Cells[0].Value.ToString());
                }else if(isRoom)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    tbxRoom.Text = row.Cells[0].Value.ToString();
                    roomId = int.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

   

        private void tbxDiseases_Click(object sender, EventArgs e)
        {
            refresh();
            isDiseases = true;
            gridView.DataSource = null;
            gridView.DataSource = dtDiseases;
        }

        private void tbxDiseases_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (tbxDiseases.Text.Length > 0)
                {
                    dtDiseases.Rows.Add(tbxDiseases.Text);
                    tbxDiseases.Text = "";
                    gridView.DataSource = null;
                    gridView.DataSource = dtDiseases;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (roomId > 0 && clientId > 0 && StuffId > 0)
            {
                com = new SqlCommand("InsCheckIn", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cId", clientId);
                com.Parameters.AddWithValue("@date", DateTime.Now);
                com.Parameters.AddWithValue("@stId", StuffId);
                com.Parameters.AddWithValue("@rId", roomId);
                com.Parameters.Add("@inId", SqlDbType.Int).Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();
                var chId = com.Parameters["@inId"].Value;
                foreach (DataRow row in dtDiseases.Rows)
                {
                    com = new SqlCommand("InDiseases", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@n", row["name"]);
                    com.Parameters.AddWithValue("@chId",chId);
                    com.ExecuteNonQuery();
                }
                com = new SqlCommand("UpdateRoom", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id",roomId);
                com.Parameters.AddWithValue("@s", false);
                com.ExecuteNonQuery();
                com.Dispose();
                ClearALL();
            }
        }

        private void ClearALL()
        {
            gridView.DataSource = null; 
            dtDiseases = null;
            tbxClient.Text = "";
            tbxDiseases.Text = "";
            tbxRoom.Text="";
            tbxDoctor.Text = "";
            clientId = -1;
            roomId = -1;
            StuffId = -1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
          
        }

        private void tbxClient_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetClientByName", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n",tbxClient.Text);

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChangeClient);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;
        }
    }
}
