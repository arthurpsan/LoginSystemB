using System.Security.Policy;

namespace SistemaLoginB
{
    public partial class LoginScreen : Form
    {
        private static LoginScreen _instance;

        private User _user;
        private LoginScreen()
        {
            InitializeComponent();

            Credential credential = new Credential()
            {
                Id = 1001,
                Username = "arthurpsan",
                Password = "123456",
                IsAdmin = false
            };

            _user = new User()
            {
                Id = 1001,
                Name = "Arthur Santos",
                Credential = credential
            };
        }

        public static LoginScreen GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginScreen();
            }

                return _instance;
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            // Validate user

            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == _user.Credential.Username 
                    && txtPassword.Text == _user.Credential.Password)
                {
                    // Success!

                    // Close login screen
                    Hide();

                    // Open System Screen
                    //new MenuScreen().Show();

                    System.GetInstance(_user).Show();

                    txtUser.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    lblAlert.Show();

                    txtUser.SelectAll();
                }
            }

            // Clean Fields

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.AliceBlue;
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.BackColor = SystemColors.Window;
        }
    }
}
