using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPAMS_BE;


namespace Intelligent_Patient_Admission_Managment_System
{
    public partial class IPAMS_Beginner_Loading : Form
    {
        public IPAMS_Beginner_Loading()
        {
            InitializeComponent();
        }
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.01;
            bunifuCircleProgress1.Value += 1;
            bunifuCircleProgress1.Text = bunifuCircleProgress1.Value.ToString();
            if (bunifuCircleProgress1.Value == 100) 
            timer1.Stop();
            timer2.Start();

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if(this.Opacity==0)
            {
                timer2.Stop();
                IPAMS_Main main = new IPAMS_Main();
                main.Show();
                this.Close();
            }
        }
        IPAMS_User_Login_BE us = new IPAMS_User_Login_BE();
      
        private void IPAMS_Beginner_Loading_Load(object sender, EventArgs e)

        {
            labelusername.Text = us.User_Name;
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress1.Minimum = 0;
            bunifuCircleProgress1.Maximum = 100;
            //this.Opacity = 0.0;
            timer1.Start();
          
        }

        private void BunifuPanel2_Click(object sender, EventArgs e)
        {
            labelusername.Text = us.User_Name.ToString();
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress1.Minimum = 0;
            bunifuCircleProgress1.Maximum = 100;
            //this.Opacity = 0.0;
            timer1.Start();

        }
    }
}
