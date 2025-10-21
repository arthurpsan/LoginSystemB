using System;

namespace SistemaLoginB
{
    public partial class RegisterUser : Form
    {
        private static RegisterUser _Instance;
        private RegisterUser()
        {
            InitializeComponent();
        }

        public static RegisterUser GetInstance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new RegisterUser();
            }

            return _Instance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
