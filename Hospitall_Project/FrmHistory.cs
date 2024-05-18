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
    public partial class FrmHistory : Form
    {
        public static string conStr = HospitalDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        public FrmHistory()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadDataHistory();
        }

        public void LoadDataHistory()
        {
            gridView.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetViewHistory", con);
            com.CommandType = CommandType.StoredProcedure;



            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridView.DataSource = dt;

        }
    }
}
