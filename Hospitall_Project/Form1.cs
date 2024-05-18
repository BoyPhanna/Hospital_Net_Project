using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospitall_Project
{
    public partial class Form1 : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static   DataTable dt;
        public static SqlCommand com;
        private bool isEdit = false;
        private int id;
        public Form1()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            gridPosition.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetPos", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridPosition.DataSource = dt;

        }
      

        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridPosition.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
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
            com = new SqlCommand("UpdatePos", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@n", tbxPosition.Text);
            com.ExecuteNonQuery();
            com.Dispose();

            isEdit = false;
            btnAddORSave.Text = "ថែម";
            tbxPosition.Text = "";
            id = -1;

        }
        private void AddPosition()
        {
            com = new SqlCommand("InsPos", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", tbxPosition.Text);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        private void gridPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridPosition.RowCount>0)
            {
                idx= e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridPosition.Rows[idx];
                tbxPosition.Text = row.Cells[1].Value.ToString();
                id= int.Parse(row.Cells[0].Value.ToString());
                btnAddORSave.Text = "កែរ";
                isEdit = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           DialogResult answer= MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?","ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ",MessageBoxButtons.YesNo);
            if(answer == DialogResult.Yes) {
                com = new SqlCommand("DeletePos", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("ព័ត៏មានត្រូវបានលុបដោយជោគជ័យ");
            }
            else
            {
                MessageBox.Show("ទិន្នន័យមិនត្រូវបានលុប");
            }
            

        }
    }
}
