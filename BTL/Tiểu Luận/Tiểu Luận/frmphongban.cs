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
    public partial class frmphongban : Form
    {
        public frmphongban()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btM_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void frmphongban_Load(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dtgv, "select * from tblphongban");
            cls.loadcombobox(comboBox1, "select * from TblBoPhan", 0);
        }

        private void btT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(textBox2.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + dateTimePicker1.Text + "',N'" + textBox5.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dtgv, "select * from TblPhongBan");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblPhongBan set MaBoPhan=N'" + comboBox1.Text + "',TenPhong=N'" + textBox3.Text + "',NgayThanhLap=N'" + dateTimePicker1.Text + "',GhiChu=N'" + textBox5.Text + "' where MaPhong=N'" + textBox2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dtgv, "select * from TblPhongban");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btX_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from TblPhongBan where MaPhong=N'" + textBox2.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dtgv, "select * from tblphongban");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dtgv.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dtgv.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dtgv.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dtgv.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dtgv.Rows[i].Cells[4].Value.ToString();
        }
    }
}
