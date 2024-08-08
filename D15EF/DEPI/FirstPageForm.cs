namespace DEPI
{
    public partial class FirstPageForm : Form
    {
        public FirstPageForm()
        {
            InitializeComponent();
        }

        private void StButton_Click(object sender, EventArgs e)
        {
            StsForm studentsForm = new StsForm();
            studentsForm.Show();
            studentsForm.Tag = this;
            this.Hide();
        }

        private void StCrsButton_Click(object sender, EventArgs e)
        {
            StCrsForm stCrsForm = new StCrsForm();
            stCrsForm.Show();
            stCrsForm.Tag = this;
            this.Hide();
        }

        private void InstButton_Click(object sender, EventArgs e)
        {
            InstsForm instsForm = new InstsForm();
            instsForm.Show();
            instsForm.Tag = this;
            this.Hide();
        }

        private void InstCrsButton_Click(object sender, EventArgs e)
        {
            InstCrsForm instCrsForm = new InstCrsForm();
            instCrsForm.Show();
            instCrsForm.Tag = this;
            this.Hide();
        }

        private void DeptButton_Click(Object sender, EventArgs e)
        {
            DeptsForm deptsForm = new DeptsForm();
            deptsForm.Show();
            deptsForm.Tag = this;
            this.Hide();
        }

        private void CrsButton_Click(object sender, EventArgs e)
        {
            CrsForm crsForm = new CrsForm();
            crsForm.Show();
            crsForm.Tag = this;
            this.Hide();
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            TopicsForm topicsForm = new TopicsForm();
            topicsForm.Show();
            topicsForm.Tag = this;
            this.Hide();
        }
    }
}
