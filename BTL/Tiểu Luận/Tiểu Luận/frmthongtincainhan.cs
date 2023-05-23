using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Tiểu_Luận
{
    public partial class frmthongtincainhan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmthongtincainhan()
        {
            InitializeComponent();
        }
        private void btM_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btS_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set Manv=N'" + comboBox1.Text + "',Noisinh=N'" + textBox2.Text + "',NguyenQuan=N'" + textBox3.Text + "',DCThuongChu=N'" + textBox4.Text + "',DCTamChu=N'" + textBox5.Text + "',SDT=N'" + textBox6.Text + "',DanToc=N'" + textBox7.Text + "',TonGiao=N'" + textBox8.Text + "',QuocTich=N'" + textBox9.Text + "',HocVan=N'" + textBox12.Text + "',GhiChu=N'" + textBox17.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dtgv, "select * from TblTTCaNhan");
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
                string delete = "delete from TblTTCaNhan where MaNV=N'" + comboBox1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dtgv, "select * from TblTTCaNhan");
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(textBox1, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 1);
            cls.loadtextboxchiso(textBox2, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 2);
            cls.loadtextboxchiso(textBox3, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 3);
            cls.loadtextboxchiso(textBox4, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 4);
            cls.loadtextboxchiso(textBox5, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 5);
            cls.loadtextboxchiso(textBox6, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 6);
            cls.loadtextboxchiso(textBox7, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 7);
            cls.loadtextboxchiso(textBox8, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 8);
            cls.loadtextboxchiso(textBox9, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 9);
            cls.loadtextboxchiso(textBox12, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 10);
            cls.loadtextboxchiso(textBox17, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 11);
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                comboBox1.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                textBox1.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                textBox2.Text = dtgv.Rows[hang].Cells[2].Value.ToString();
                textBox3.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
                textBox4.Text = dtgv.Rows[hang].Cells[4].Value.ToString();
                textBox5.Text = dtgv.Rows[hang].Cells[5].Value.ToString();
                textBox6.Text = dtgv.Rows[hang].Cells[6].Value.ToString();
                textBox7.Text = dtgv.Rows[hang].Cells[7].Value.ToString();
                textBox8.Text = dtgv.Rows[hang].Cells[8].Value.ToString();
                textBox9.Text = dtgv.Rows[hang].Cells[9].Value.ToString();
                textBox12.Text = dtgv.Rows[hang].Cells[10].Value.ToString();
                textBox17.Text = dtgv.Rows[hang].Cells[11].Value.ToString();
                //

            }
            catch (Exception)
            { }
        }

        private void frmthongtincainhan_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from TblTTCaNhan");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
