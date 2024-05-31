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
using System.Data.SqlClient;

namespace Cinematrix
{
    public partial class frmMovieCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmMovieCategory()
        {
            InitializeComponent();
            for(int i = 1; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i, "1", "Movie ");
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=Cinematrix;Integrated Security=True;");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMovies frm = new frmMovies();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
