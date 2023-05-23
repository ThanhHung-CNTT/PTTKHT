using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Tiểu_Luận
{
    public partial class Trợ_Giúp : Form
    {
        public Trợ_Giúp()
        {
            InitializeComponent();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Trợ_Giúp_Load(object sender, EventArgs e)
        {
            link.Text = "Facebook";
            link.Links.Add(0, 8, "https://www.facebook.com/hug.IT61");

        }
        void guiemailhotro(string to, string message)
        {
           
        }

        private void btguitrogiup_Click(object sender, EventArgs e)
        {
           
        }

        private void txtMESS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
