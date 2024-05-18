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
    public partial class FrmTool : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private bool isEdit = false;
        public FrmTool()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }
        public void LoadData()
        {
            gridTool.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetTool", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridTool.DataSource = dt;

        }


        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridTool.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void gridTool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridTool.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridTool.Rows[idx];
                tbxId.Text = row.Cells[0].Value.ToString();
                tbxName.Text = row.Cells[1].Value.ToString();
                tbxPrice.Text = row.Cells[2].Value.ToString();
                btnAddORSave.Text = "កែរ";
                isEdit = true;
                btnDelete.Visible = true;
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
            com = new SqlCommand("UpdateTool", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(tbxId.Text));
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@pu", float.Parse(tbxPrice.Text));
            com.ExecuteNonQuery();
            com.Dispose();


            btnAddORSave.Text = "ថែម";
            tbxName.Text = "";
            ClearTBX();


        }
        private void AddPosition()
        {
            com = new SqlCommand("InsTool", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@pu", float.Parse(tbxPrice.Text));
            com.ExecuteNonQuery();
            com.Dispose();
            ClearTBX();


        }

        private void ClearTBX()
        {
            tbxId.Text = "";
            tbxName.Text = "";
            tbxPrice.Text = "";
            btnDelete.Visible = false;
            isEdit = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?", "ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                com = new SqlCommand("DeleteTool", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", int.Parse(tbxId.Text));
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("ព័ត៏មានត្រូវបានលុបដោយជោគជ័យ");
                ClearTBX();

            }
            else
            {
                MessageBox.Show("ទិន្នន័យមិនត្រូវបានលុប");
            }
        }
    }
}
