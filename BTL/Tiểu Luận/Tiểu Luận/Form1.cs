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

namespace Tiểu_Luận
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            this.lbdtime.Text = DateTime.Now.ToString();


        }


        private void txtUS_TextChanged(object sender, EventArgs e)
        {
            if (txtUS.Text.Length == 0)
            {
                lbUS.Text = "Không Được Bỏ Trống Tên Đăng Nhập !!!";
                lbUS.ForeColor = Color.Red;
            }
            else
            {
                lbUS.Text = " ";
            }
        }

        private void btĐN_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=LAPTOP-6EA8ABAQ\SQLEXPRESS;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa;Password=123456");
            SqlDataAdapter dadn = new SqlDataAdapter("select * from tbuser where Username = N'" + txtUS.Text + "' and Pass = N'" + txtPW.Text + "'", cnt);
            DataTable tb = new DataTable();
            dadn.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                this.Hide();
                Quản_Lý_Nhân_Sự qlns = new Quản_Lý_Nhân_Sự(tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), tb.Rows[0][2].ToString(), tb.Rows[0][3].ToString());
                qlns.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("sai thông tin tài khoản");
            }
            
           

        }
        private void txtPW_TextChanged(object sender, EventArgs e)
        {

            txtPW.UseSystemPasswordChar = true;

            if (txtPW.Text.Length == 0)
            {
                lbPW.Text = "không Được Bỏ Trống Mật Khẩu !!!";
                lbPW.ForeColor = Color.Red;

            }
            else
            {
                lbPW.Text = "";

            }

        }
        private void cbHTMK_Click(object sender, EventArgs e)
        {
            if (cbHTMK.Checked == true)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = true;
            }

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbdtime.Text = dt.ToString("hh:mm:ss");
        }
    }
}
