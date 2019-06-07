using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArabComputersTask.Services;
using ArabComputersTask.API.Models;


namespace ArabComputersTask.HotelReservation
{
    public partial class Login : Form
    {
        UserServices _userServices = new UserServices();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin() {
                UserMailAddress = EmailTxt.Text,
                UserPassword = PasswordTxt.Text
            
            };
            User user=  _userServices.GetUser(userLogin);
            if (user != null)
            {
                bool UserIsAdmin = _userServices.UserIsAdmin(user.UserID);
                if (UserIsAdmin)
                {
                    this.Hide();
                    Form1 form1 =  new Form1(user);
                    
                    form1.ShowDialog();
                }
                else
                {
                    Messagelbl.Text = "make sure";
                }
            }
            else
            {
                Messagelbl.Text = "make sure";
            }
        }
    }
}
