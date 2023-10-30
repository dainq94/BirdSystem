using BirdService;
using BusinessObjects.Models;

namespace Bird.APP
{
    public partial class LoginForm : Form
    {
        private readonly IUserService userService = null;
        private string ADMIN_ROLE = "AD";

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {

                if (txtUsername.Text.Length == 0)
                    throw new Exception("Please enter the email/username/phone!");
                if (txtPassword.Text.Length == 0)
                    throw new Exception("Please enter the password!");

                user = userService.GetUserByEmail(txtUsername.Text);
                if (user != null)
                {
                    GlobalData.AuthenticatedUser = user;
                    if (user.Role.Equals("US")) // CUSTOMER
                    {
                        CustomerForm customerFrom = new CustomerForm();
                        //regis.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "!";

                        //Custo.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //this.Hide();
                        //frmCustomer.Show();

                    }
                    else if (user.Role.Equals("STAFF")) // STAFF
                    {
                        //frmStaff frmStaff = new frmStaff();
                        //frmStaff.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();

                        //};
                        //frmStaff.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [Staff Mode]";
                        //this.Hide();
                        //frmStaff.Show();
                    }
                    else if (user.Role.Equals(ADMIN_ROLE)) //ADMIN
                    {
                        CustomerForm customerFrom = new CustomerForm();
                        customerFrom.ShowDialog();
                        //var form = new frmAdmin();
                        //form.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [ADMIN Mode]";
                        //this.Hide();
                        //form.Show();
                    }
                    else if (user.Role.Equals("SHIPPER"))
                    {
                        //var form = new frmShipper();
                        //form.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [SHIPPER Mode]";
                        //this.Hide();
                        //form.Show();


                    }
                }
                else
                {
                    MessageBox.Show("Wrong email or password!!!", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Fail");
            }
        }
    }

}
