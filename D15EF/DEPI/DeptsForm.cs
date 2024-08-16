using DBModels;

namespace DEPI
{
    public partial class DeptsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Department> departments;

        Department selectedDepartment = new Department();

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

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtDeptName.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtManager.Clear();
            txtHireDate.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDeptName.Text))
                {
                    MessageBox.Show("Enter At Least The Department Name", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedDepartment.Dept_Id > 0)
                {
                    yesNo = MessageBox.Show("YES: Insert New Department\n NO: Update The Department",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertDepartment() != null)
                    {
                        st.Departments.Add(InsertDepartment());
                        st.SaveChanges();
                        MessageBox.Show("Added The Department Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Department", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateDepartment() != null)
                    {
                        Department? updatedDept = UpdateDepartment();

                        if (updatedDept.Dept_Name == selectedDepartment.Dept_Name &&
                            updatedDept.Dept_Desc == selectedDepartment.Dept_Desc &&
                            updatedDept.Dept_Location == selectedDepartment.Dept_Location &&
                            updatedDept.Dept_Manager == selectedDepartment.Dept_Manager &&
                            updatedDept.Manager_HireDate == selectedDepartment.Manager_HireDate)
                        {
                            MessageBox.Show("Faild To Update This Department Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldDept = st.Departments.FirstOrDefault(d => d.Dept_Id == selectedDepartment.Dept_Id);
                        oldDept.Dept_Name = updatedDept.Dept_Name;
                        oldDept.Dept_Desc = updatedDept.Dept_Desc;
                        oldDept.Dept_Location = updatedDept.Dept_Location;
                        oldDept.Dept_Manager = updatedDept.Dept_Manager;
                        oldDept.Manager_HireDate = updatedDept.Manager_HireDate;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Department With Id: {selectedDepartment.Dept_Id} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Department", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            departments = st.Departments.ToList();
            StdGView.DataSource = departments
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();
        }

        private Department? InsertDepartment()
        {
            try
            {
                Department newDept = new Department()
                {
                    Dept_Name = string.IsNullOrEmpty(txtDeptName.Text) ? null : txtDeptName.Text,
                    Dept_Desc = string.IsNullOrEmpty(txtDescription.Text) ? null : txtDescription.Text,
                    Dept_Location = string.IsNullOrEmpty(txtLocation.Text) ? null : txtLocation.Text,
                };

                if (string.IsNullOrEmpty(txtHireDate.Text))
                {
                    newDept.Manager_HireDate = null;
                }
                else if (DateTime.TryParse(txtHireDate.Text, out DateTime chkHiringDate))
                {
                    newDept.Manager_HireDate = chkHiringDate;
                }
                else
                {
                    MessageBox.Show("Not Valid Date Value", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtHireDate.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtManager.Text))
                {
                    newDept.Dept_Manager = null;
                }
                else if (int.TryParse(txtManager.Text, out int chkManagerID))
                {
                    if (st.Instructors.FirstOrDefault(i => i.Ins_Id == chkManagerID) != null)
                        newDept.Dept_Manager = chkManagerID;
                    else
                    {
                        MessageBox.Show("Check Manager ID (Not Found)", "Insertion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }

                return newDept;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private Department? UpdateDepartment()
        {
            try
            {
                Department updatedDept = new Department()
                {
                    Dept_Name = string.IsNullOrEmpty(txtDeptName.Text) ? null : txtDeptName.Text,
                    Dept_Desc = string.IsNullOrEmpty(txtDescription.Text) ? null : txtDescription.Text,
                    Dept_Location = string.IsNullOrEmpty(txtLocation.Text) ? null : txtLocation.Text,
                };

                if (string.IsNullOrEmpty(txtHireDate.Text))
                {
                    updatedDept.Manager_HireDate = null;
                }
                else if (DateTime.TryParse(txtHireDate.Text, out DateTime chkHiringDate))
                {
                    updatedDept.Manager_HireDate = chkHiringDate;
                }
                else
                {
                    MessageBox.Show("Not Valid Date Value", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtHireDate.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtManager.Text))
                {
                    updatedDept.Dept_Manager = null;
                }
                else if (int.TryParse(txtManager.Text, out int chkManagerID))
                {
                    if (st.Instructors.FirstOrDefault(i => i.Ins_Id == chkManagerID) != null)
                        updatedDept.Dept_Manager = chkManagerID;
                    else
                    {
                        MessageBox.Show("Check Manager ID (Not Found)", "Update Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }

                return updatedDept;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void txtStIdDel_TextChanged(object sender, EventArgs e)
        {
            var r = departments.Where(d =>
                d.Dept_Id == (int.TryParse(txtDeptIdDel.Text, out int check) ? check : -1))
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(txtDeptIdDel.Text) ? departments.Select(d => new
            { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate }).ToList() : r;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtDeptIdDel.Text, out int delID))
                {
                    var dept = st.Departments.FirstOrDefault(d => d.Dept_Id == delID);
                    if (dept != null)
                    {
                        st.Departments.Remove(dept);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Department With Id: {delID} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Department (Not Found)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Department (Check Input)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            departments = st.Departments.ToList();
            StdGView.DataSource = departments
                .Select(d => new
                { d.Dept_Id, d.Dept_Name, d.Dept_Desc, d.Dept_Location, d.Dept_Manager, d.Manager_HireDate })
                .ToList();
        }
        #endregion

        #region Row Selection in Grid View
        private void StdGView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (e.Row.Selected)
            {
                MessageBox.Show($"Row {e.Row.Index + 1} Fetched Successfully", "Fetch", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                selectedDepartment = departments[e.Row.Index];
                txtDeptName.Text = selectedDepartment.Dept_Name;
                txtDescription.Text = selectedDepartment.Dept_Desc;
                txtLocation.Text = selectedDepartment.Dept_Location;
                txtManager.Text = selectedDepartment.Dept_Manager.ToString();
                txtHireDate.Text = selectedDepartment.Manager_HireDate.ToString();
            }
        }

        #endregion

        #endregion
    }
}
