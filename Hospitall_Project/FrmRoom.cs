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
using System.Xml.Linq;

namespace Hospitall_Project
{
    public partial class FrmRoom : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private bool isEdit = false;
        private bool roomStatus=true;
        public FrmRoom()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }
        public void LoadData()
        {
            gridRoom.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetRoom", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridRoom.DataSource = dt;

        }


        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridRoom.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void gridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridRoom.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridRoom.Rows[idx];
                tbxId.Text = row.Cells[0].Value.ToString();
                roomStatus =bool.Parse(row.Cells[1].Value.ToString());
                //MessageBox.Show("Status is : "+row.Cells[1].Value.ToString());
                btnAddORSave.Text = "កែរ";
                isEdit = true;
                btnDelete.Visible = true;
                if(!roomStatus)
                {
                    radioBusy.Checked = true;
                    radioFree.Checked = false;
                }
                else
                {
                    radioBusy.Checked = false;
                    radioFree.Checked = true;
                }
            }
        }
        private void btnAddORSave_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                AddPosition();
            }
            else
            {
                UpdatePosition();
            }

        }
        private void UpdatePosition()
        {
            com = new SqlCommand("UpdateRoom", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(tbxId.Text));
            com.Parameters.AddWithValue("@s", radioFree.Checked);
            com.ExecuteNonQuery();
            com.Dispose();


            btnAddORSave.Text = "ថែម";
            ClearTBX();


        }
        private void AddPosition()
        {
            com = new SqlCommand("InsRoom", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@s", radioFree.Checked);
            com.ExecuteNonQuery();
            com.Dispose();
            ClearTBX();


        }

        private void ClearTBX()
        {
            tbxId.Text = "";
            btnDelete.Visible = false;
            isEdit = false;
            radioFree.Checked = true;
        }

        private void radioBusy_CheckedChanged(object sender, EventArgs e)
        {
            roomStatus = false;
        }

        private void radioFree_CheckedChanged(object sender, EventArgs e)
        {
            roomStatus = true;
        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
