using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelligent_Patient_Admission_Managment_System
{
    public partial class IPAMS_Main : Form
    {
        public IPAMS_Main()
        {
            InitializeComponent();

            
            guna2GradientPanel1.Height = guna2Button4.Height;
            guna2GradientPanel1.Top = guna2Button4.Top;
            guna2GradientPanel1.Left = guna2Button4.Left;
            guna2Button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void IPAMS_Main_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
         
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel_val.Text = "داشبورد";
            guna2HtmlLabel_val.ForeColor = Color.FromArgb(0, 126, 249); 
            guna2PictureBox_val.Image = Properties.Resources.home_white;
            slidmnupnl<IPAMS_Dashboard>();
            guna2GradientPanel1.Height = guna2Button4.Height;
            guna2GradientPanel1.Top = guna2Button4.Top;
            guna2GradientPanel1.Left = guna2Button4.Left;
            guna2Button4.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void container(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //container(new IPAMS_Main());

            if (guna2GradientPanel1.Width == 60)
            {
                guna2GradientPanel1.Visible = false;
                guna2GradientPanel1.Width = 186;
                PanelAnimator.ShowSync(guna2GradientPanel1);


            }
            else
            {
                guna2GradientPanel1.Visible = false;
                guna2GradientPanel1.Width = 60;
                PanelAnimator.ShowSync(guna2GradientPanel1);
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel_val.Text = "تقویم";
            guna2HtmlLabel_val.ForeColor = Color.FromArgb(0, 126, 249);
            guna2PictureBox_val.Image = Properties.Resources.calender_white;
            guna2GradientPanel1.Height = guna2Button6.Height;
            guna2GradientPanel1.Top = guna2Button6.Top;
            guna2Button6.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            slidmnupnl<IPAMS_Patient_Entery>();
            guna2HtmlLabel_val.Text = "بیمار پذیرش";
            guna2HtmlLabel_val.ForeColor = Color.FromArgb(0, 126, 249);
            guna2PictureBox_val.Image = Properties.Resources.person_calendar;
            guna2GradientPanel1.Height = guna2Button2.Height;
            guna2GradientPanel1.Top = guna2Button2.Top;
            guna2Button2.BackColor = Color.FromArgb(46, 51, 73);

           
                

            

        }
        private void slidmnupnl<IPAMS_Main>() where IPAMS_Main: Form, new()
        {
            Form pef;
            pef = guna2Panel_container.Controls.OfType<IPAMS_Main>().FirstOrDefault();
            if (pef == null)
            {
                pef = new IPAMS_Main();
                pef.TopLevel = false;
                pef.FormBorderStyle = FormBorderStyle.None;
                pef.Dock = DockStyle.Fill;
                this.guna2Panel_container.Controls.Add(pef);
                this.guna2Panel_container.Tag = pef;
                pef.Show();

            }
            else
            {
                pef.BringToFront();
            }

        }

      

       

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            
            
         
            Application.Exit();
        }

        private void Guna2Panel_container_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Guna2Button4_Leave(object sender, EventArgs e)
        {
            guna2Button4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Guna2Button6_Leave(object sender, EventArgs e)
        {
            guna2Button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel_val.Text = "گزارشات";
            guna2HtmlLabel_val.ForeColor = Color.FromArgb(0, 126, 249);
            guna2PictureBox_val.Image = Properties.Resources.Reports_White;
            guna2GradientPanel1.Height = guna2Button1.Height;
            guna2GradientPanel1.Top = guna2Button1.Top;
            guna2Button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel_val.Text = "ما درباره";
            guna2HtmlLabel_val.ForeColor = Color.FromArgb(0, 126, 249);
            guna2PictureBox_val.Image = Properties.Resources.About_us;
            guna2GradientPanel1.Height = guna2Button3.Height;
            guna2GradientPanel1.Top = guna2Button3.Top;
            guna2Button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Guna2Button2_Leave(object sender, EventArgs e)
        {
            guna2Button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Guna2Button1_Leave(object sender, EventArgs e)
        {
            guna2Button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Guna2Button3_Leave(object sender, EventArgs e)
        {
            guna2Button3.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
