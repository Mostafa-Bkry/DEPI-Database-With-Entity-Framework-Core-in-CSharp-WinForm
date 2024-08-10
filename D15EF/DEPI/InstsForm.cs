using DBModels;

namespace DEPI
{
    public partial class InstsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Instructor> instructors;

        public InstsForm()
        {
            InitializeComponent();
            instructors = st.Instructors.ToList();

            StdGView.DataSource = instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList();
        }


        #region Buttons Logic
        public List<Instructor> CheckMethodForButtons()
        {
            List<Instructor> stLst = new List<Instructor>();
            int id; int? dept_Id;
            string iName, iDegree;
            double salary;

            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["Ins_Id"].Value.ToString(), out int chkId) ?
                    chkId : -1;

                iName = StdGView.Rows[row].Cells["Ins_Name"].Value.ToString() ?? "NA";
                iDegree = StdGView.Rows[row].Cells["Ins_Degree"].Value.ToString() ?? "NA";

                dept_Id =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Dept_Id"]?.Value?.ToString(), out int chkManager) ?
                    chkManager : null;

                salary =
                    double.TryParse(StdGView?.Rows[row].Cells["Salary"].Value.ToString() ?? "NA", out double chkSal) ?
                    chkSal : -1;


                stLst.Add(new Instructor()
                {
                    Ins_Id = id,
                    Ins_Name = iName,
                    Ins_Degree = iDegree,
                    Dept_Id = dept_Id,
                    Salary = salary
                });
            }

            return stLst;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            if (Tag is FirstPageForm f1)
                f1.Show();
        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            IdTBox.Clear();
            SalTBox.Clear();
            NameTBox.Clear();
            DegreeTBox.Clear();
            DeptTBox.Clear();

            StdGView.DataSource = instructors
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Instructor>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new Instructor());
                StdGView.DataSource = result.Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Instructor?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new Instructor());
                StdGView.DataSource = result.Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void DistButton_Click(object sender, EventArgs e)
        {
            try
            {
                var r = CheckMethodForButtons()
                   .DistinctBy(i => i.Ins_Name)
                   .Select(i => new
                   { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                   .ToList();

                StdGView.DataSource = r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


        }

        private void ShowManagedButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = instructors.Join(st.Departments, i => i.Ins_Id, d => d.Dept_Manager, (i, d)
                => new
                { i.Ins_Id, i.Ins_Name, i.Dept_Id, d.Dept_Name }).ToList();
        }

        private void ShowDeptsButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = instructors.Join(st.Departments, i => i.Dept_Id, d => d.Dept_Id, (i, d)
                => new
                { i.Ins_Id, i.Ins_Name, i.Dept_Id, d.Dept_Name })
                .ToList();
        }

        private void ShowICrsButton_Click(object sender, EventArgs e)
        {
            var instCrs = instructors.Join(st.InstCourses, i => i.Ins_Id, ic => ic.Ins_Id,
                (i, ic) => new { i.Ins_Id, i.Ins_Name, ic.Crs_Id, ic.Evaluation }).ToList();
            var crs = instCrs.Join(st.Courses, ic => ic.Crs_Id, c => c.Crs_Id,
                (ic, c) => new { ic.Ins_Id, ic.Ins_Name, ic.Crs_Id, c.Crs_Name, ic.Evaluation });

            var r = crs.ToList();

            StdGView.DataSource = r;
        }
        #endregion

        #region TextBoxes Logic
        private void IdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Ins_Id == (int.TryParse(IdTBox.Text, out int check) ? check : -1))
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(IdTBox.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }

        private void NameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Ins_Name?.Contains(NameTBox.Text) ?? false)
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(NameTBox.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }

        private void DeptTBox_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Dept_Id == (int.TryParse(DeptTBox.Text, out int check) ? check : -1))
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(DeptTBox.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }

        private void SalTBox_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Salary == (double.TryParse(SalTBox.Text, out double check) ? check : -1))
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(SalTBox.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }

        private void DegreeTBox_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Ins_Degree?.Contains(DegreeTBox.Text) ?? false)
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(DegreeTBox.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }
        #endregion
    }
}
