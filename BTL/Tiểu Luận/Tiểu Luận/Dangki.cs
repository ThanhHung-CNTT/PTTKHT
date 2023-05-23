using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tiểu_Luận
{
    public partial class Dangki : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public Dangki()
        {
            InitializeComponent();
        }
        

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void btNL_Click(object sender, EventArgs e)
        {
            txtDN.Text = "";
            txtMK.Text = "";
            txtTT.Text = "";
            txtQ.Text = "";
        }

        private void btT_Click(object sender, EventArgs e)
        {
            try
            {
                dtNS.CustomFormat = "MM/dd/yyyy";
                string insert = "insert into tbuser values(N'" + txtDN.Text + "',N'" + txtMK.Text + "',N'" + txtQ.Text + "',N'" + txtTT.Text + "','" + dtNS.Text + "')";
                if (cls.kttrungkhoa(txtDN.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    cls.loaddatagridview(dtgv, "select * from tbuser");
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btS_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tbuser set Username=N'" + txtDN.Text + "',Pass=N'" + txtMK.Text + "',Quyen=N'" + txtQ.Text + "',Ten=N'" + txtTT.Text + "',Ngaysinh='" + dtNS.Text + "' where Username='" + txtDN.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dtgv, "select * from tbuser");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btX_Click(object sender, EventArgs e)
        {
            string delete = "delete from tbuser where Username=N'" + txtDN.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tbuser");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btTH_Click(object sender, EventArgs e)
        {
            txtDN.Text = "";
            txtMK.Text = "";
            txtTT.Text = "";
            txtQ.Text = "";
            this.Close();
        }

        private void Dangki_Load(object sender, EventArgs e)
        {
            dtNS.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dtgv, "select * from tbuser");
        }

        private void btTH_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtDN.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtMK.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                txtTT.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
                txtQ.Text = dtgv.Rows[hang].Cells[2].Value.ToString();


                dtNS.Text = dtgv.Rows[hang].Cells[4].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }
    }

}
