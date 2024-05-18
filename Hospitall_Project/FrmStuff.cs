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
    public partial class FrmStuff : Form
    {
        public static string conStr = HospitalDatabase.conStr;  
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private bool isEdit=false;

        public FrmStuff()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadStuff();
        }
        public void LoadData()
        {
            gridStuff.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            

            com = new SqlCommand("GetPos", con);
            com.CommandType = CommandType.StoredProcedure;
            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
          
           
            cbxPosition.DisplayMember= "name";
            cbxPosition.ValueMember= "id";
            cbxPosition.DataSource = dt;


            


            com = new SqlCommand("GetViewStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridStuff.DataSource = dt;


        }

        public void LoadStuff()
        {
            gridStuff.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetStuff", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            LoadData();
        }
        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridStuff.BeginInvoke(new MethodInvoker(LoadStuff));
            }
            else
            {
                LoadStuff();
            }
        }


        private void FrmStuff_Load(object sender, EventArgs e)
        {

        }

        private void gridStuff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gridStuff.Rows[e.RowIndex].Cells[0].Value.ToString());
            com = new SqlCommand("SStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
           
            tbxId.Text = dt.Rows[0].ItemArray[0].ToString();
            tbxName.Text = dt.Rows[0].ItemArray[1].ToString();
            tpkDob.Text = dt.Rows[0].ItemArray[2].ToString();   
            tbxSex.Text = dt.Rows[0].ItemArray[3].ToString();
            cbxPosition.SelectedValue = dt.Rows[0].ItemArray[4];
            tbxPhone.Text = dt.Rows[0].ItemArray[5].ToString();
            tbxAddress.Text = dt.Rows[0].ItemArray[6].ToString();
            tbxSalary.Text = dt.Rows[0].ItemArray[7].ToString();

            isEdit = true;
            btnAddORSave.Text = "Save";
            btnDelete.Visible = true;

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void AddORSave(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                AddStuff();
            }
            else
            {
                SaveStuff();
                btnAddORSave.Text = "Add";
                isEdit=false;
                ClearTBX(); 
                btnDelete.Visible = false;
            }
        }
        private void AddStuff()
        {
            com = new SqlCommand("InsStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@sex", tbxSex.Text);
            com.Parameters.AddWithValue("@dob", tpkDob.Value);
            com.Parameters.AddWithValue("@pos", cbxPosition.SelectedValue);
            com.Parameters.AddWithValue("@phone", tbxPhone.Text);
            com.Parameters.AddWithValue("@add", tbxAddress.Text);
            com.Parameters.AddWithValue("@sa", float.Parse(tbxSalary.Text));
            com.ExecuteNonQuery();
            com.Dispose();
        }
        private void SaveStuff()
        {
            com = new SqlCommand("UpdateStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id",int.Parse(tbxId.Text));
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@sex", tbxSex.Text);
            com.Parameters.AddWithValue("@dob", tpkDob.Value);
            com.Parameters.AddWithValue("@pos", cbxPosition.SelectedValue);
            com.Parameters.AddWithValue("@phone", tbxPhone.Text);
            com.Parameters.AddWithValue("@add", tbxAddress.Text);
            com.Parameters.AddWithValue("@sa", float.Parse(tbxSalary.Text));
            com.ExecuteNonQuery();
            com.Dispose();
        }
        private void ClearTBX()
        {
            tbxId.Text = "";
            tbxName.Text = "";
            tbxSex.Text = "";
            tpkDob.Text = "";
            tbxAddress.Text = "";
            tbxPhone.Text = "";
            tbxSalary.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?", "ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                com = new SqlCommand("DeleteStuff", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id",int.Parse(tbxId.Text));
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("លុប ID : "+tbxId.Text);
                isEdit = false;
                btnAddORSave.Text = "Add";
                ClearTBX();
             }
            else
            {
                MessageBox.Show("ទិន្នន័យមិនត្រូវបានលុប");
            }

}
    }
}
