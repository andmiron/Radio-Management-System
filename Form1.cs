using PublicUtilitiesLoginScreen;

namespace PublicUtilities
{
    public partial class LOGIN_FORM : Form
    {
        public LOGIN_FORM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginUsernameInput.Focus();
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = loginUsernameInput.Text.Trim();
            string password = loginPasswordInput.Text;

            AuthService authService = new AuthService();

            if (authService.AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                RADIO mainForm = new RADIO();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginPasswordInput.Clear();
                loginUsernameInput.Clear();
                loginUsernameInput.Focus();
            }
        }
    }
}
