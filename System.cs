using System;
using System.Security.Cryptography.X509Certificates;

namespace SistemaLoginB
{
    public partial class System : Form
    {
        private static System _instance;
        public Boolean IsWindowOpen = false;

        public System(User user)
        {
            InitializeComponent();

            Text = $"Sys - {user.Name} - Admin: {user.Credential.IsAdmin} - [BETA]";

            if (user.Credential.IsAdmin is false)
            {
                adminToolStripMenuItem.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
            }


        }

        public static System GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new(user);
            }

            return _instance;

        }

        private void MenuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginScreen.GetInstance().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen.GetInstance().Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser registerScreen = RegisterUser.GetInstance();
            registerScreen.MdiParent = this;
            registerScreen.WindowState = FormWindowState.Normal;
            registerScreen.Show();
        }

        
    }
}
