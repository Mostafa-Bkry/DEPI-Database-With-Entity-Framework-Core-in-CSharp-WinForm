using DBModels;

namespace DEPI
{
    public partial class DeptsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Department> departments;

        public DeptsForm()
        {
            InitializeComponent();
            departments = st.Departments.ToList();

            StdGView.DataSource = departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList();
        }


        #region Buttons Logic
        public List<Department> CheckMethodForButtons()
        {
            List<Department> stLst = new List<Department>();
            int id; int? manager;
            string dName, dDesc, dLoc;
            DateTime hireDate;

            //d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Manager, d.Manager_HireDate 
            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["Dept_Id"].Value.ToString(), out int chkId) ?
                    chkId : -1;

                dName = StdGView.Rows[row].Cells["Dept_Name"].Value.ToString() ?? "NA";
                dDesc = StdGView.Rows[row].Cells["Dept_Desc"].Value.ToString() ?? "NA";
                dLoc = StdGView.Rows[row].Cells["Dept_Location"].Value.ToString() ?? "NA";

                manager =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Dept_Manager"]?.Value?.ToString(), out int chkManager) ?
                    chkManager : null;

                hireDate = DateTime.TryParse(StdGView.Rows[row].Cells["Manager_HireDate"].Value.ToString(), out DateTime chkDate) ?
                    chkDate : DateTime.MinValue;

                stLst.Add(new Department()
                {
                    Dept_Id = id,
                    Dept_Name = dName,
                    Dept_Desc = dDesc,
                    Dept_Location = dLoc,
                    Dept_Manager = manager,
                    Manager_HireDate = hireDate
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
            LocTBox.Clear();
            NameTBox.Clear();
            DescTBox.Clear();
            ManagerTBox.Clear();
            HireDateBox.Clear();

            StdGView.DataSource = departments
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Department>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new Department());
                StdGView.DataSource = result.Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Department?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new Department());
                StdGView.DataSource = result.Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
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
                   .DistinctBy(d => d.Dept_Name)
                   .Select(d => new
                   { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                   .ToList();

                StdGView.DataSource = r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


        }

        private void ShowStudButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = departments.Join(st.Students, d => d.Dept_Id, s => s.Dept_Id, (d, s)
                => new
                { d.Dept_Id, d.Dept_Name, s.St_Id, St_Name = string.Concat(s.Fname, ' ', s.Sname) }).ToList();
        }

        private void ShowManagerButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = departments.Join(st.Instructors, d => d.Dept_Manager, i => i.Ins_Id, (d, i)
                => new
                { d.Dept_Id, d.Dept_Name, Manager_Id = i.Ins_Id, Manager_Name = i.Ins_Name, d.Manager_HireDate })
                .ToList();
        }

        private void ShowInstButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = departments.Join(st.Instructors, d => d.Dept_Id, i => i.Dept_Id, (d, i)
                => new
                { d.Dept_Id, d.Dept_Name, i.Ins_Id, i.Ins_Name })
                .ToList();
        }
        #endregion

        #region TextBoxes Logic
        private void IdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Id == (int.TryParse(IdTBox.Text, out int check) ? check : -1))
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(IdTBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void NameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Name?.Contains(NameTBox.Text) ?? false)
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(NameTBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void DescTBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Desc?.Contains(DescTBox.Text) ?? false)
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(DescTBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void LocTBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Location?.Contains(LocTBox.Text) ?? false)
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(LocTBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void ManagerTBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Manager == (int.TryParse(ManagerTBox.Text, out int check) ? check : -1))
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(ManagerTBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void HireDateBox_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
               d.Manager_HireDate == (DateTime.TryParse(HireDateBox.Text, out DateTime check) ? check : DateTime.MinValue))
               .Select(d => new
               { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
               .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(HireDateBox.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }
        #endregion
    }
}
