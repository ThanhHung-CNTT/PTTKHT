using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiểu_Luận
{
    public partial class frmdoimatkhau : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmdoimatkhau()
        {
            InitializeComponent();
        }
       
                 

        

        private void btHT_Click(object sender, EventArgs e)
        {

            string update = "update tbuser set Pass='" + textBox3.Text + "' where(Username=N'" + textBox1.Text + "' and Pass='" + textBox2.Text + "')";
            string ten = textBox1.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (textBox3.Text == textBox4.Text)
                            {
                                cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btNL_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        
    }
}
