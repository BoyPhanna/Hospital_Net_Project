using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitall_Project
{
    public partial class FrmCheckout : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        private static bool isCheckIn=false;
        private static bool isTool=false;
        private static bool isMedicine=false;
        private static int checkInId=-1;
        private static int Meid = -1;
        private static string Mename = "";
        private static int Meqty = -1;
        private static float Meprice = -1;
        private static int Tooid = -1;
        private static string Tooname = "";
        private static int Tooqty = -1;
        private static float Tooprice = -1;
        private static float total = 0;
        private static DataTable dtTool=new DataTable();
        private static DataTable dtMedicine=new DataTable();

        public FrmCheckout()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            isCheckIn = true;
            LoadDataCheckIn();
            gridView.Width = 600;
            dtMedicine = new DataTable();
            dtMedicine.Columns.Add("id", typeof(int));
            dtMedicine.Columns.Add("name", typeof(string));
            dtMedicine.Columns.Add("qty", typeof(int));
            dtMedicine.Columns.Add("price", typeof(float));
            dtMedicine.Columns.Add("amount", typeof(float));

            dtTool = new DataTable();
            dtTool.Columns.Add("id", typeof(int));
            dtTool.Columns.Add("name", typeof(string));
            dtTool.Columns.Add("qty", typeof(int));
            dtTool.Columns.Add("price", typeof(float));
            dtTool.Columns.Add("amount", typeof(float));

        }

        public void LoadDataCheckIn()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetViewCheckIn", con);
            com.CommandType = CommandType.StoredProcedure;

           

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }
        public void LoadDataTool()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetTool", con);
            com.CommandType = CommandType.StoredProcedure;

           

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        } public void LoadDataMedicine()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetMedicineChekout", con);
            com.CommandType = CommandType.StoredProcedure;

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }
        private void refresh()
        {
            isCheckIn = false;
            isTool = false;
            isMedicine = false; 
        }

        private void tbxCheckIn_Click(object sender, EventArgs e)
        {
            LoadDataCheckIn();
            gridView.Width= 600;
            gridView2.Visible=false;
            refresh();
            isCheckIn = true;

        }

        private void tbxTool_Click(object sender, EventArgs e)
        {
            if (!isTool)
            {
                gridView.Width = 300;
                gridView2.Visible = true;
                LoadDataTool();
                refresh();
                isTool = true;
                loadTool();
            }

        }

        private void tbxMedicine_Click(object sender, EventArgs e)
        {
            if (!isMedicine)
            {
                gridView.Width = 300;
                gridView2.Visible = true;
                LoadDataMedicine();
                refresh();
                isMedicine = true;
                loadMedicine();
            }
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

                if (isCheckIn)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    tbxCheckIn.Text = row.Cells[0].Value.ToString();
                    checkInId = int.Parse(row.Cells[0].Value.ToString());
                    tbxRoom.Text= row.Cells[1].Value.ToString();


                }
                else if (isTool)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    var id = row.Cells[0].Value;
                    Tooname = row.Cells[1].Value.ToString();
                    var price = row.Cells[2].Value;


                    Tooid = int.Parse(id.ToString());
                    Tooprice = float.Parse(price.ToString());
                    tbxTool.Text = Tooname;

                }
                else if (isMedicine)
                {
                    DataGridViewRow row = gridView.Rows[idx];
                    var id = row.Cells[0].Value;
                    Mename = row.Cells[1].Value.ToString();
                    var price=row.Cells[2].Value;

                    Meid = int.Parse(id.ToString());
                    Meprice = float.Parse(price.ToString());
                    //MessageBox.Show(id.ToString());
                    tbxMedicine.Text = Mename;

                }
            }
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("id" + Tooid.ToString() + "   qty  : " + tbxToolQty.Text);
            if (Tooid>0&&tbxToolQty.Text.Length>0)
            {
                int qty = int.Parse(tbxToolQty.Text);
                float amount = Tooprice * qty;
                dtTool.Rows.Add(Tooid,Tooname,qty,Tooprice,amount);
                loadTool();
                clearTool();
                total += amount;
                lbTotal.Text = total.ToString();
            }
        }

        private void loadTool()
        {
            gridView2.DataSource = null;
            gridView2.DataSource = dtTool;
        }
        private void loadMedicine()
        {
            gridView2.DataSource = null;
            gridView2.DataSource = dtMedicine;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("id" + Meid.ToString() + "   qty  : " + tbxMedicineQty.Text);
            if (Meid > 0 && tbxMedicineQty.Text.Length > 0)
            {
                int qty = int.Parse(tbxMedicineQty.Text);
                float amount = Meprice * qty;
                dtMedicine.Rows.Add(Meid, Mename, qty, Meprice, amount);
                loadMedicine();
                clearMedicine();
                total += amount;
                lbTotal.Text = total.ToString();
            }
        }
        private void clearMedicine()
        {
            tbxMedicine.Text = "";
            tbxMedicineQty.Text = "";
        } 
        private void clearTool()
        {
            tbxTool.Text = "";
            tbxToolQty.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("InsCheckout", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@chInId",checkInId);
            com.Parameters.AddWithValue("@date", DateTime.Now);
            com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            var chId = com.Parameters["@id"].Value;
            
            
            com = new SqlCommand("InsInvoice", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@chId", chId);
            com.Parameters.AddWithValue("@total", total);
            com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            var invoiceId = com.Parameters["@id"].Value;




            foreach (DataRow row in dtMedicine.Rows)
            {
                com = new SqlCommand("InsMedicinesDetail", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@inId", invoiceId);
                com.Parameters.AddWithValue("@meId", row["id"]);
                com.Parameters.AddWithValue("@qty", row["qty"]);
                com.Parameters.AddWithValue("@amount", row["amount"]);
                com.ExecuteNonQuery();
            }
            
            
            foreach (DataRow row in dtTool.Rows)
            {
                com = new SqlCommand("InsToolDetail", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@inId", invoiceId);
                com.Parameters.AddWithValue("@toId", row["id"]);
                com.Parameters.AddWithValue("@qty", row["qty"]);
                com.Parameters.AddWithValue("@amount", row["amount"]);
                com.ExecuteNonQuery();
            }


            com = new SqlCommand("UpdateRoom", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(tbxRoom.Text));
            com.Parameters.AddWithValue("@s", true);
            com.ExecuteNonQuery();
            com.Dispose();
            ClearALL();
        }

        private void ClearALL()
        {
            tbxRoom.Text = "";
            tbxCheckIn.Text = "";
            clearMedicine();
            clearTool();
            lbTotal.Text = "0";
            dtMedicine = null;
            dtTool= null;
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxTool_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxCheckIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
