using license.Models;

namespace license
{
    public partial class AdminFormDashboard : Form
    {
        public AdminFormDashboard()
        {

            InitializeComponent();
            usernamelogin.Text = UserLog_in_Data.usernamelogin;
        }

        private void AddPlacelbl_Click(object sender, EventArgs e)
        {
            Place_Details new_Place = new Place_Details();
            new_Place.ShowDialog();

        }

        private void AddClassificatiolbl_Click(object sender, EventArgs e)
        {
            Add_Classification classification = new Add_Classification();
            classification.ShowDialog();
        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void Reportslbl_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        private void AddUserlbl_Click(object sender, EventArgs e)
        {
            Add_User user = new Add_User();
            user.ShowDialog();
        }

        private void ChangePasslbl_Click(object sender, EventArgs e)
        {
            Update_User_Data_Password update_User = new Update_User_Data_Password();
            update_User.ShowDialog();
        }

        private void Closeimg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Close();
            register.Show();
        }

        private void Exitebtn_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Close();
            register.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}