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
    public partial class frmluong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        public frmluong()
        {
            InitializeComponent();
        }

        

       
        

        

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show(dg2.Rows[i].Cells[0].Value.ToString());

            comboBox1.Text = dtgv2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dtgv2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dtgv2.Rows[i].Cells[2].Value.ToString();
            txt12.Text = dtgv2.Rows[i].Cells[3].Value.ToString();
            textBox1.Text = dtgv2.Rows[i].Cells[4].Value.ToString();
            txt15.Text = dtgv2.Rows[i].Cells[5].Value.ToString();
            dateTimePicker6.Text = dtgv2.Rows[i].Cells[6].Value.ToString();
            txt18.Text = dtgv2.Rows[i].Cells[7].Value.ToString();

        }

      

      

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

       

       
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmluong_Load(object sender, EventArgs e)
        {
            dateTimePicker6.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            DataSet ds1 = new DataSet();
            cls.loaddatagridview(dtgv, "select * from TblBangLuongCTy");
            cls.loaddatagridview1(dtgv2, ds1, "select * from TblTangLuong");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }

        private void btT_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangLuongCTy values(N'" + txt1.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + dateTimePicker1.Text + "',N'" + txt6.Text + "',N'" + dateTimePicker2.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + dateTimePicker3.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(txt1.Text, "select MaLuong from TblBangLuongCTy"))
                {
                    if (txt1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dtgv.Refresh();
                        cls.loaddatagridview(dtgv, "select * from TblBangLuongCTy");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Lương");
                }
                else
                    MessageBox.Show("Mã Lương này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblBangLuongCTy set LCB=N'" + txt4.Text + "',PCChucVu=N'" + txt5.Text + "',NgayNhap='" + dateTimePicker1.Text + "',LCBMoi=N'" + txt6.Text + "',NgaySua=N'" + dateTimePicker2.Text + "',LyDo=N'" + txt7.Text + "',PCCVuMoi='" + txt8.Text + "',NgaySuaPC=N'" + dateTimePicker3.Text + "',GhiChu=N'" + txt9.Text + "' where MaLuong=N'" + txt1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dtgv, "select * from TblBangLuongCTy");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btX_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblBangLuongCTy where MaLuong=N'" + txt1.Text + "'";
            string delete1 = "delete from TblSoBH where MaLuong=N'" + txt1.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete1);
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from TblBangLuongCTy");
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dtgv.Rows[i].Cells[0].Value.ToString();
            txt4.Text = dtgv.Rows[i].Cells[1].Value.ToString();
            txt5.Text = dtgv.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dtgv.Rows[i].Cells[3].Value.ToString();
            txt6.Text = dtgv.Rows[i].Cells[4].Value.ToString();
            dateTimePicker2.Text = dtgv.Rows[i].Cells[5].Value.ToString();
            txt7.Text = dtgv.Rows[i].Cells[6].Value.ToString();
            txt8.Text = dtgv.Rows[i].Cells[7].Value.ToString();
            dateTimePicker3.Text = dtgv.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dtgv.Rows[i].Cells[9].Value.ToString();
        }

        private void btM1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btS1_Click(object sender, EventArgs e)
        {
            try
            {

                string update = "update TblTangLuong set HoTen=N'" + txt10.Text + "',GioiTinh=N'" + txt11.Text + "',ChucVu=N'" + txt12.Text + "',MaLuongCu='" + textBox1.Text + "',MaLuongMoi=N'" + txt15.Text + "',NgayTang='" + dateTimePicker6.Text + "',LyDo=N'" + txt18.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dtgv2, ds1, "select * from TblTangLuong");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + txt15.Text + "' where MaNV='" + comboBox1.Text + "'";
            cls.thucthiketnoi(up);
            cls.loaddatagridview1(dtgv2, ds1, "select * from TblTangLuong");
        }

        private void btT1_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblTangLuong values(N'" + comboBox1.Text + "',N'" + txt10.Text + "',N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + textBox1.Text + "',N'" + txt15.Text + "',N'" + dateTimePicker6.Text + "',N'" + txt18.Text + "')";
                if (!cls.kttrungkhoa(comboBox1.Text, "select MaNV from TblTangLuong"))
                {
                    if (comboBox1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dtgv.Refresh();
                        cls.loaddatagridview(dtgv2, "select * from TblTangLuong");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa chọn mà nhân viên");
                }
                else
                    MessageBox.Show("Nhân viên này bạn đã nhập dữ liêu rồi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + txt15.Text + "' where MaNV='" + comboBox1.Text + "'";
            cls.thucthiketnoi(up);
            cls.loaddatagridview1(dtgv2, ds1, "select * from TblTangLuong");
        }

        private void btX1_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string delete = "delete from TblTangLuong where MaNV=N'" + comboBox1.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dtgv2, ds1, "select * from TblTangLuong");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cls.loadtextbox(txt10, "select HoTen from TblTTNVCoBan where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt11, "select GioiTinh from TblTTNVCoBan where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt12, "select ChucVu from TblTTNVCoBan where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(textBox1, "select MaLuong from TblCongKhoiDieuHanh where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt15, "select MaLuongMoi from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loadtextbox(txt18, "select LyDo from TblTangLuong where MaNV='" + comboBox1.Text + "'");
            cls.loaddatetime(dateTimePicker6, "select NgayTang from TblTangLuong where MaNV='" + comboBox1.Text + "'", 0);
        }
    }
}
