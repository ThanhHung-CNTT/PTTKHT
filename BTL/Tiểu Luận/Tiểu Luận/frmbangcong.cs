using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace Tiểu_Luận
{
    public partial class frmbangcong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmbangcong()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }
        private void tl_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int pc = Convert.ToInt32(txt11.Text);
            int pck = Convert.ToInt32(txt12.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int lt = Convert.ToInt32(txt17.Text);
            int th = Convert.ToInt32(textBox1.Text);
            int kl = Convert.ToInt32(textBox2.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txt52.Text = luong.ToString();
        }
        private void cb1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt2, "select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='" + cb1.Text + "'", 2);
            cls.loadtextboxchiso(txtTBP, "select * from TblBoPhan,TblPhongBan where TblPhongBan.MaBoPhan=TblBoPhan.MaBoPhan and TenPhong=N'" + txt2.Text + "'", 1);
            cls.loadtextboxchiso(txt3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 3);
            cls.loadtextboxchiso(txt4, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 4);
            cls.loadtextboxchiso(txt5, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 5);
            cls.loadtextboxchiso(txt6, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 6);
            cls.loadtextboxchiso(txt7, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 7);
            cls.loadtextboxchiso(txt8, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 8);
            cls.loadtextboxchiso(textBox3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 9);
            cls.loadtextboxchiso(txt9, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 10);
        }

        private void txt4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtTBP.Text = dtgv.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dtgv.Rows[i].Cells[1].Value.ToString();
            cb1.Text = dtgv.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dtgv.Rows[i].Cells[3].Value.ToString();
            txt4.Text = dtgv.Rows[i].Cells[4].Value.ToString();
            txt5.Text = dtgv.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dtgv.Rows[i].Cells[6].Value.ToString();
            txt7.Text = dtgv.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dtgv.Rows[i].Cells[8].Value.ToString();
            textBox3.Text = dtgv.Rows[i].Cells[9].Value.ToString();
            txt9.Text = dtgv.Rows[i].Cells[10].Value.ToString();
        }

        private void frmbangcong_Load_1(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source = LAPTOP-6EA8ABAQ\SQLEXPRESS; Initial Catalog = QLNS; Persist Security Info = True; User ID = sa; Password = 123456";

            cls.loadcombobox(cb1, "select MaNVTV from TblHoSoThuViec", 0);


            frmbangcong.FillCombo("SELECT TenPhong FROM TblPhongBan", comboBox10, "TenPhong", "TenPhong");
            comboBox10.SelectedIndex = -1;

            cls.loaddatagridview1(dtgv, ds1, "select * from TblBangCongThuViec");
        }
        private void btM_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btT_Click_1(object sender, EventArgs e)
        {
            //try
            //{

            string insert = "insert into TblBangCongThuViec values(N'" + txtTBP.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + textBox3.Text + "',N'" + txt9.Text + "')";
            if (!cls.kttrungkhoa(cb1.Text, "select MaNVTV from TblBangCongThuViec"))
            {
                if (cb1.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dtgv.Refresh();
                    cls.loaddatagridview1(dtgv, ds1, "select * from TblBangCongThuViec");

                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
            //}
        }

        private void btS_Click_1(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txtTBP.Text + "',TenPhong=N'" + txt2.Text + "',LuongTViec=N'" + txt3.Text + "',Thang=N'" + txt4.Text + "',Nam='" + txt5.Text + "',SoNgayCong=N'" + txt6.Text + "',SoNgayNghi=N'" + txt7.Text + "',SoGioLamThem=N'" + txt8.Text + "',Luong=N'" + textBox3.Text + "',GhiChu='" + txt9.Text + "' where MaNVTV=N'" + cb1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dtgv, ds1, "select * from TblBangCongThuViec");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btX_Click_1(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblBangCongThuViec where MaNVTV=N'" + cb1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dtgv, ds1, "select * from TblBangCongThuViec");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btTL_Click_1(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(txt3.Text);
            int nc = Convert.ToInt32(txt6.Text);
            int lt = Convert.ToInt32(txt8.Text);
            float luong = ((l / 26) * nc + (lt * 40000));
            textBox3.Text = luong.ToString();
        }

        private void btTH_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                string update = "update TblCongKhoiDieuHanh set MaNV='" + cb2.Text + "', MaLuong=N'" + txt50.Text + "',TenPhong=N'" + comboBox10.Text + "', HoTen=N'" + txt53.Text + "',LCB=N'" + txt10.Text + "',PCChucVu=N'" + txt11.Text + "',PCapKhac=N'" + txt12.Text + "',Thuong=N'" + textBox1.Text + "',KyLuat='" + textBox2.Text + "',Thang=N'" + txt13.Text + "',Nam='" + txt14.Text + "',SoNgayCongThang=N'" + txt15.Text + "',SoNgayNghi=N'" + txt16.Text + "',SoGioLamThem=N'" + txt17.Text + "',Luong=N'" + txt52.Text + "',GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dtgv2, ds2, "select * from TblCongKhoiDieuHanh where TenPhong=N'" + comboBox10.SelectedValue + "'");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btX1_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cb2.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dtgv2, ds2, "select * from TblCongKhoiDieuHanh");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btTL1_Click(object sender, EventArgs e)
        {

            int lcb = Convert.ToInt32(txt10.Text);
            int pc = Convert.ToInt32(txt11.Text);
            int pck = Convert.ToInt32(txt12.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int lt = Convert.ToInt32(txt17.Text);
            int th = Convert.ToInt32(textBox1.Text);
            int kl = Convert.ToInt32(textBox2.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txt52.Text = luong.ToString();
        }

        private void btTH1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dtgv2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dtgv2.Rows[i].Cells[4].Value.ToString();
            txt53.Text = dtgv2.Rows[i].Cells[2].Value.ToString();
            txt50.Text = dtgv2.Rows[i].Cells[3].Value.ToString();
            comboBox10.Text = dtgv2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dtgv2.Rows[i].Cells[5].Value.ToString();
            txt12.Text = dtgv2.Rows[i].Cells[6].Value.ToString();
            textBox1.Text = dtgv2.Rows[i].Cells[7].Value.ToString();
            textBox2.Text = dtgv2.Rows[i].Cells[8].Value.ToString();
            txt13.Text = dtgv2.Rows[i].Cells[9].Value.ToString();
            txt14.Text = dtgv2.Rows[i].Cells[10].Value.ToString();
            txt15.Text = dtgv2.Rows[i].Cells[11].Value.ToString();
            txt16.Text = dtgv2.Rows[i].Cells[12].Value.ToString();
            txt17.Text = dtgv2.Rows[i].Cells[13].Value.ToString();
            txt52.Text = dtgv2.Rows[i].Cells[14].Value.ToString();
            txt18.Text = dtgv2.Rows[i].Cells[15].Value.ToString();
        }

        private void cb2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            cls.loadtextboxchiso(txt50, "select * from TblTTNVCoBan where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt10, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 1);
            cls.loadtextboxchiso(txt11, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 2);
            cls.loadtextboxchiso(txt53, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 2);
            cls.loadtextboxchiso(txt12, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(textBox1, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(textBox2, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt13, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 9);
            cls.loadtextboxchiso(txt14, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 10);
            cls.loadtextboxchiso(txt15, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 11);
            cls.loadtextboxchiso(txt16, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 12);
            cls.loadtextboxchiso(txt17, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 13);
            cls.loadtextboxchiso(txt52, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 14);
            cls.loadtextboxchiso(txt18, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 15);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

            frmbangcong.FillCombo("select MaNV from TblCongKhoiDieuHanh where TenPhong=(select top(1) TenPhong from TblPhongBan a, TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.TenPhong=N'" + comboBox10.SelectedValue + "' group by TenPhong)", cb2, "MaNV", "MaNV");
            cb2.DisplayMember = "MaNV";
            cb2.ValueMember = "MaNV";
            cls.loaddatagridview1(dtgv2, ds2, "select * from TblCongKhoiDieuHanh b where b.TenPhong=N'" + comboBox10.SelectedValue + "'");
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
              e.Handled = true;
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}








