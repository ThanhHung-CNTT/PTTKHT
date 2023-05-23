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
    public partial class frmtimkiem : Form
    {
        Clsdatabase cls = new Clsdatabase();

        public frmtimkiem()
        {
            InitializeComponent();
        }

        
        int i = 0;
        
        

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan");
                }
                else
                {

                    if (i == 1)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 2);
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 3);
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where HoTen like N'" + textBox1.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 8);
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where CMTND like N'" + textBox1.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void btT_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where MaNV=N'" + textBox1.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where HoTen=N'" + textBox1.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan where CMTND=N'" + textBox1.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cls.loaddatagridview(dtgv, "select * from TblTTNVCoBan");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            i = 3;
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập vào từ khóa tìm kiếm")
            {
                textBox1.Text = "";
            }
        }
    }
}
