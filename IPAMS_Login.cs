using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPAMS_BLL;
using IPAMS_BE;


namespace Intelligent_Patient_Admission_Managment_System
{
    public partial class IPAMS_Login : Form
    {
        public IPAMS_Login()
        {
            InitializeComponent();
        }
        
        private void IPAMS_Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            
        }
        IPAMS_Login_Crud_BLL bllP = new IPAMS_Login_Crud_BLL();
        private void Guna2TextBox1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox_user.Text =="sajad")
            {
               
                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }
            if (guna2TextBox_user.Text == "111")
            {
              
                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }
            if (guna2TextBox_user.Text == "333")
            {
                guna2CirclePictureBox2_Prof.Image = Properties.Resources.father;
                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }

            else
            {
                guna2CirclePictureBox2_Prof.Visible = false;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (guna2Panel_sinup.FillColor.A == 200)
            {
                timer1.Stop();
                guna2Panel3.Visible = true;
            }
            guna2Panel_sinup.FillColor = Color.FromArgb(guna2Panel_sinup.FillColor.A + 5, 0, 0, 25);
        }
       
        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            
            guna2Panel3.Visible = false;
            guna2Panel_sinup.FillColor = Color.FromArgb(0, 255, 0, 0);
            IPAMS_User_Login_BE USL = new IPAMS_User_Login_BE();
            USL.User_Name = guna2TextBox3_usermane.Text;
            USL.Password = guna2TextBox4_password.Text;
            
            //Create

            MessageBox.Show(bllP.Create(USL).ToString());
            //h.Name = textBoxX1.Text;
            //h.Username = textBoxX2.Text;
            //h.Code = textBoxX3.Text;
            //h.Password = textBoxX4.Text;

            gunaLabel2.Visible = true;


        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gunaLabel2.Visible = false;
        }

        

        IPAMS_Login_Crud_BLL bll = new IPAMS_Login_Crud_BLL();
        private void Guna2Button1_Click(object sender, EventArgs e)

        {
            
                if (bll.Login(guna2TextBox_user.Text, guna2TextBox2_Password.Text) == 1)
            {
                gunaLabel3.Text = "خوش آمدید";
                IPAMS_Beginner_Loading m = new IPAMS_Beginner_Loading();
                m.Show();
                this.Hide();

            }
                else
            {
                gunaLabel3.Visible = true;
                gunaLabel3.Text = "نام کاربری و یا کلمه عبور اشتباه است";
            }
        }

        private void guna2TextBox_user_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_user.Text == "sajad")
            {
                guna2CirclePictureBox2_Prof.Image = Properties.Resources.sajad1;
                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }
            if (guna2TextBox_user.Text == "111")
                guna2CirclePictureBox2_Prof.Image = Properties.Resources.sajad2;
            {

                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }
            if (guna2TextBox_user.Text == "333")
            {
                guna2CirclePictureBox2_Prof.Image = Properties.Resources.father;
                guna2Transition1.Show(guna2CirclePictureBox2_Prof);
            }

            else
            {
                guna2CirclePictureBox2_Prof.Visible = false;
            }
        }
    }
}
       
    


