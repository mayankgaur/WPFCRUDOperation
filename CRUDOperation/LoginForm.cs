using System;
using System.Windows.Forms;

namespace CRUDOperation
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginForm(IAuthenticationService authenticationService)
        {
            InitializeComponent();
            _authenticationService = authenticationService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_authenticationService.IsValidUser(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
            }
        }
    }
}
