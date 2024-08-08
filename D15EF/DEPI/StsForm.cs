using DBModels;

namespace DEPI
{
    public partial class StsForm : Form
    {
        DEPIContext st = new DEPIContext();

        public StsForm()
        {
            InitializeComponent();
            StdGView.DataSource = st.Students
                .Select(s => new 
                    {s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super})
                .ToList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            if (Tag is FirstPageForm f1)
                f1.Show();
        }
    }
}
