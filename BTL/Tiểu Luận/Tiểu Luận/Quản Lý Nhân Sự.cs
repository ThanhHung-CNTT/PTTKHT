using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Tiểu_Luận
{
    public partial class Quản_Lý_Nhân_Sự : Form
    {
        string Username = "", Pass = "", Quyen = "", Ten = "";
        public Quản_Lý_Nhân_Sự()
        {
            InitializeComponent();
           
           
        }
        public Quản_Lý_Nhân_Sự(string Username, string Pass, string Quyen, string Ten)
        {
            InitializeComponent();
            this.Username = Username;
            this.Pass = Pass;
            this.Quyen = Quyen;
            this.Ten = Ten;
            
        }
        private void Quản_Lý_Nhân_Sự_Load(object sender, EventArgs e)
        {
            lbTĐ.Text = btNS.Text;
            Frmcoban fc = new Frmcoban();
            pnForm.Controls.Clear();

            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fc);
            fc.FormBorderStyle = FormBorderStyle.None;
            fc.Show();
            timer1.Start();
           
            if (Quyen== "nhanvien12")
            {
                btBC.Visible = false;
                pnBC.Visible = false;
                btLNV.Visible = false;
                btBL.Visible = false;
                btQLTK.Visible = false;
                
                

              
                
            }
            lbName.Text = Ten.ToString();
            
        }
        private void btTNV_Click(object sender, EventArgs e)
        {
            pnDM.Height = (pnDM.Height == 40) ? 240 : 40;
            pnQL.Height = 40;
            pnCN.Height = 40;
            pnDM.BackColor = (pnDM.BackColor == Color.WhiteSmoke) ? pnDM.BackColor = Color.White : pnDM.BackColor = Color.WhiteSmoke;
        }
        private void btTG_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btTG.Text;
            Trợ_Giúp tg = new Trợ_Giúp();
            tg.TopLevel = false;
            pnForm.Controls.Clear();
            pnForm.Controls.Add(tg);
            tg.FormBorderStyle = FormBorderStyle.None;
            tg.Show();
        }

        private void btNS_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btNS.Text;
            Frmcoban fc = new Frmcoban();
            pnForm.Controls.Clear();
           
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fc);
            fc.FormBorderStyle = FormBorderStyle.None;
            fc.Show();
        }

        private void btTTCN_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btTTCN.Text;
            frmthongtincainhan ft = new frmthongtincainhan();

          
            pnForm.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            pnForm.Controls.Add(ft);
            ft.FormBorderStyle = FormBorderStyle.None;
            ft.Show();
        }

        private void btCD_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btCD.Text;
            frmchedo fcd = new frmchedo();
            
            pnForm.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fcd);
            fcd.FormBorderStyle = FormBorderStyle.None;
            fcd.Show();
        }

        private void btHSTV_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btHSTV.Text;
            frmhosothuviec bag = new frmhosothuviec();
           
            pnForm.Controls.Clear();
            bag.TopLevel = false;
            bag.Dock = DockStyle.Fill;
            pnForm.Controls.Add(bag);
            bag.FormBorderStyle = FormBorderStyle.None;
            bag.Show();
        }

        private void btBC_Click(object sender, EventArgs e)
        {
            pnBC.Height = (pnBC.Height == 40) ? 130 : 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btBC.Text;
            bcnv a = new bcnv();
            
            pnForm.Controls.Clear();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            pnForm.Controls.Add(a);
            a.FormBorderStyle = FormBorderStyle.None;
            a.Show();
        }

        private void btL_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btL.Text;
            bcl a = new bcl();
            
            pnForm.Controls.Clear();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            pnForm.Controls.Add(a);
            a.FormBorderStyle = FormBorderStyle.None;
            a.Show();
        }
        private void btCN_Click(object sender, EventArgs e)
        {
            pnCN.Height = (pnCN.Height == 40) ? 360 : 40;
            pnCN.BackColor = (pnCN.BackColor ==Color.WhiteSmoke) ? pnCN.BackColor = Color.White : pnCN.BackColor = Color.WhiteSmoke;
            pnDM.Height = 40;
            pnQL.Height = 40;
            

        }

        private void btTC_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btTC.Text;
            frmtimkiem ftk = new frmtimkiem();
            
            pnForm.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            pnForm.Controls.Add(ftk);
            ftk.FormBorderStyle = FormBorderStyle.None;
            ftk.Show();
        }

        private void btPB_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btPB.Text;
            frmphongban fpb = new frmphongban();
           
            pnForm.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fpb);
            fpb.FormBorderStyle = FormBorderStyle.None;
            fpb.Show();
        }

        private void btBP_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btBP.Text;
            frmbophan frb = new frmbophan();
            
            pnForm.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            pnForm.Controls.Add(frb);
            frb.FormBorderStyle = FormBorderStyle.None;
            frb.Show();
        }

        private void btLNV_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btLNV.Text;
            frmbangcong fhtv = new frmbangcong();
            pnForm.Controls.Clear();
            pnForm.Show();
            fhtv.TopLevel = false;
            fhtv.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fhtv);
            fhtv.FormBorderStyle = FormBorderStyle.None;
            fhtv.Show();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            pnQL.Height = (pnQL.Height == 40) ? 260 : 40;
            pnDM.Height = 40;
            pnCN.Height = 40;
            pnQL.BackColor = (pnQL.BackColor == Color.WhiteSmoke) ? pnQL.BackColor = Color.White : pnQL.BackColor = Color.WhiteSmoke;
        }

       

      
     
        private void btT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btQLTK.Text;
            Dangki b = new Dangki();
            pnForm.Show();
            pnForm.Controls.Clear();
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            pnForm.Controls.Add(b);
            b.FormBorderStyle = FormBorderStyle.None;
            b.Show();
        }

        private void btDX_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbgio.Text = dt.ToString("HH:mm:ss");
            this.lbthu.Text = dt.ToString("dddd");
            this.lbngay.Text = dt.ToString("dd/MM/yyyy");
        }

       

       
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            pnMENU.Width = 40;
            
        }

        private void btDMK_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btDMK.Text;
            frmdoimatkhau fdm = new frmdoimatkhau();
            fdm.FormBorderStyle = FormBorderStyle.None;
            pnForm.Show();
            pnForm.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            pnForm.Controls.Add(fdm);
            fdm.Show();
        }

        private void pnMENU_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btBL_Click(object sender, EventArgs e)
        {
            lbTĐ.Text = btBL.Text;
            frmluong aa = new frmluong();
            pnForm.Controls.Clear();
            pnForm.Show();
            aa.TopLevel = false;
            aa.Dock = DockStyle.Fill;
            pnForm.Controls.Add(aa);
            aa.FormBorderStyle = FormBorderStyle.None;
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnMENU.Width = (pnMENU.Width == 40) ? 240 : 40;
        }
        private void lbName_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
