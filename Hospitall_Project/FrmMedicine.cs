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
    public partial class FrmMedicine : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private bool isEdit = false;
        private int id;
        public FrmMedicine()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }
        public void LoadData()
        {
            gridMedicine.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetMedicine", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridMedicine.DataSource = dt;

        }


        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridMedicine.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }
        private void label_Click(object sender, EventArgs e)
        {

        }

        private void gridMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridMedicine.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridMedicine.Rows[idx];
                tbxId.Text = row.Cells[0].Value.ToString();
                tbxName.Text = row.Cells[1].Value.ToString();
                tbxDecription.Text = row.Cells[2].Value.ToString();
                tbxQty.Text = row.Cells[3].Value.ToString();
                tbxPrice.Text = row.Cells[4].Value.ToString();
                id = int.Parse(row.Cells[0].Value.ToString());
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
            com = new SqlCommand("UpdateMedicine", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(tbxId.Text));
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@de", tbxDecription.Text);
            com.Parameters.AddWithValue("@qty", int.Parse(tbxQty.Text));
            com.Parameters.AddWithValue("@price", float.Parse(tbxPrice.Text));
            com.ExecuteNonQuery();
            com.Dispose();

            
            btnAddORSave.Text = "ថែម";
            tbxName.Text = "";
            id = -1;
            ClearTBX();


        }
        private void AddPosition()
        {
            com = new SqlCommand("InsMedicine", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", tbxName.Text);
            com.Parameters.AddWithValue("@de", tbxDecription.Text);
            com.Parameters.AddWithValue("@qty", int.Parse(tbxQty.Text));
            com.Parameters.AddWithValue("@price", float.Parse(tbxPrice.Text));
            com.ExecuteNonQuery();
            com.Dispose();
            ClearTBX();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?", "ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                com = new SqlCommand("DeleteMedicin", con);
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

        private void ClearTBX()
        {
            tbxId.Text = "";
            tbxName.Text = "";
            tbxDecription.Text = "";
            tbxQty.Text = "";
            tbxPrice.Text = "";
            btnDelete.Visible = false;
            isEdit = false;
        }

        private void FrmMedicine_Load(object sender, EventArgs e)
        {

        }

        private void gridMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
