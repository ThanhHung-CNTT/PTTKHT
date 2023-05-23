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
    public partial class bcnv : Form
    {
        public bcnv()
        {
            InitializeComponent();
        }

        private void bcnv_Load(object sender, EventArgs e)
        {
            //this.TblTTNVCoBanTableAdapter.Fill(this.QLNSDataSet.TblTTNVCoBan);
            this.TblTTNVCoBanTableAdapter.Fill(this.QLNSDataSet.TblTTNVCoBan);
            this.reportViewer1.RefreshReport(); 
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
