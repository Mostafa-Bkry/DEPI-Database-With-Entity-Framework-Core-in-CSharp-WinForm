using DBModels;

namespace DEPI
{
    public partial class StsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Student> students;

        public StsForm()
        {
            InitializeComponent();
            students = st.Students.ToList();

            StdGView.DataSource = students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList();
        }


        #region Buttons Logic
        public List<Student> CheckMethodForButtons()
        {
            List<Student> stLst = new List<Student>();
            int id, age, deptId; int? superId;
            string fName, lName, address;

            //s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super
            for (int row = 0; row < StdGView.Rows.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["St_Id"].Value.ToString(), out int chkId) ?
                    chkId : -1;

                fName = StdGView.Rows[row].Cells["Fname"].Value.ToString() ?? "NA";
                lName = StdGView.Rows[row].Cells["Sname"].Value.ToString() ?? "NA";

                age =
                    int.TryParse(StdGView.Rows[row].Cells["Age"].Value.ToString(), out int checkAge) ?
                    checkAge : -1;

                address = StdGView.Rows[row].Cells["Address"].Value.ToString() ?? "NA";

                deptId =
                    int.TryParse(StdGView.Rows[row].Cells["Dept_Id"].Value.ToString(), out int chkDid) ?
                    chkDid : -1;

                superId =
                    int.TryParse(StdGView?.Rows[row]?.Cells["St_super"]?.Value?.ToString(), out int chkSuper) ?
                    chkSuper : null;

                stLst.Add(new Student()
                {
                    St_Id = id,
                    Fname = fName,
                    Sname = lName,
                    Age = age,
                    Dept_Id = deptId,
                    Address = address,
                    St_super = superId
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
            AgeTBox.Clear();
            SuperTBox.Clear();
            FNameTBox.Clear();
            LNameTBox.Clear();
            AddrTBox.Clear();
            DeptTBox.Clear();

            StdGView.DataSource = students
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Student>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new Student());
                StdGView.DataSource = result.Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Student?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new Student());
                StdGView.DataSource = result.Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            //List<Student> st = new List<Student>();
            //try
            //{
            //    st.Add(
            //        students.LastOrDefault()
            //        ?? new Student()
            //        {
            //            St_Id = -1,
            //            Fname = "NA",
            //            Sname = "NA",
            //            Age = -1,
            //            Address = "NA",
            //            Dept_Id = -1,
            //            St_super = -1,
            //        });

            //    StdGView.DataSource = st.Select(s => new
            //    { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void DistButton_Click(object sender, EventArgs e)
        {
            try
            {
                var r = CheckMethodForButtons()
                   .DistinctBy(s => s.Fname)
                   .Select(s => new
                   { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                   .ToList();

                StdGView.DataSource = r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


        }

        private void ShowStSuperButton_Click(object sender, EventArgs e)
        {
            var r = students.Join(students, y => y.St_super, x => x.St_Id, (x, y) =>
                new
                {
                    StudentID = x.St_Id,
                    StFullName = string.Concat(x.Fname, ' ', x.Sname),
                    SuperID = y.St_Id,
                    SuperFullName = string.Concat(y.Fname, ' ', y.Sname)
                });

            StdGView.DataSource = r.ToList();
        }

        private void ShowDeptButton_Click(object sender, EventArgs e)
        {
            var r = students.Join(st.Departments, s => s.Dept_Id, d => d.Dept_Id, (s, d) =>
                new
                {
                    StudentID = s.St_Id,
                    StFullName = string.Concat(s.Fname, ' ', s.Sname),
                    DepartmenttID = d.Dept_Id,
                    DepartmenttName = d.Dept_Name,
                    Description = d.Dept_Desc,
                });

            StdGView.DataSource = r.ToList();
        }

        private void ShowStCrsButton_Click(object sender, EventArgs e)
        {
            var stCrs = students.Join(st.StudCourses, s => s.St_Id, sc => sc.Stud_Id, 
                (s, sc) => new {s.St_Id, s.Fname, sc.Crs_Id}).ToList();
            var crs = stCrs.Join(st.Courses, stc => stc.Crs_Id, c => c.Crs_Id,
                (stc, c) => new { stc.St_Id, stc.Fname, stc.Crs_Id, c.Crs_Name });

            var r = crs.ToList();

            StdGView.DataSource = r;
        }
        #endregion


        #region TextBoxes Logic
        private void IdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.St_Id == (int.TryParse(IdTBox.Text, out int check) ? check : -1))
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(IdTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void FNameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.Fname?.Contains(FNameTBox.Text) ?? false)
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(FNameTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void LNameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.Sname?.Contains(LNameTBox.Text) ?? false)
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(LNameTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void AgeTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.Age == (int.TryParse(AgeTBox.Text, out int check) ? check : -1))
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(AgeTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void AddrTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.Address?.Contains(AddrTBox.Text) ?? false)
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(AddrTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void DeptTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.Dept_Id == (int.TryParse(DeptTBox.Text, out int check) ? check : -1))
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(DeptTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void SuperTBox_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.St_super == (int.TryParse(SuperTBox.Text, out int check) ? check : -1))
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(SuperTBox.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }
        #endregion

    }
}
