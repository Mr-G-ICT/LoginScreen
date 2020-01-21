using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen___Game
{
    public partial class SplashPage : Form
    {
        ProfileRoutines SingleUserProfile = new ProfileRoutines();

        public SplashPage(ProfileRoutines setupUserProfile)
        {
            InitializeComponent();
            SingleUserProfile = setupUserProfile;
        }


        private void SplashPage_Load(object sender, EventArgs e)
        {
            FirstnameLabel.Font = new Font("Century Gothic", 18);
            FirstnameLabel.Text = "Welcome " + SingleUserProfile.GetFirstname;
        }
    }
}
