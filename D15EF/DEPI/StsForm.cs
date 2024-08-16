using DBModels;

namespace DEPI
{
    public partial class StsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Student> students;

        Student selectedStudent = new Student();

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
            for (int row = 0; row < StdGView?.Rows?.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["St_Id"].Value?.ToString(), out int chkId) ?
                    chkId : -1;

                fName = StdGView?.Rows[row]?.Cells["Fname"]?.Value?.ToString() ?? "NA";
                lName = StdGView?.Rows[row]?.Cells["Sname"]?.Value?.ToString() ?? "NA";

                age =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Age"]?.Value?.ToString() ?? "NA", out int checkAge) ?
                    checkAge : -1;

                address = StdGView?.Rows[row]?.Cells["Address"]?.Value?.ToString() ?? "NA";

                deptId =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Dept_Id"]?.Value?.ToString() ?? "NA", out int chkDid) ?
                    chkDid : -1;

                superId =
                    int.TryParse(StdGView?.Rows[row]?.Cells["St_super"]?.Value?.ToString(), out int chkSuper) ?
                    chkSuper : null;

                stLst.Add(new Student()
                {
                    St_Id = id,
                    Fname = fName == "NA" ? null : fName,
                    Sname = lName == "NA" ? null : lName,
                    Age = age == -1 ? null : age,
                    Dept_Id = deptId == -1 ? null : deptId,
                    Address = address == "NA" ? null : address,
                    St_super = superId == -1 ? null : superId
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

            //students = st.Students.ToList();
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
                (s, sc) => new { s.St_Id, s.Fname, sc.Crs_Id, sc.Grade }).ToList();
            var crs = stCrs.Join(st.Courses, stc => stc.Crs_Id, c => c.Crs_Id,
                (stc, c) => new { stc.St_Id, stc.Fname, stc.Crs_Id, c.Crs_Name, stc.Grade });

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

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtDeptId.Clear();
            txtSuperId.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFName.Text))
                {
                    MessageBox.Show("Enter At Least The Student First Name", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedStudent.St_Id > 0)
                {
                    yesNo = MessageBox.Show($"YES: Insert New Student\n NO: Update The Student With ID = {selectedStudent.St_Id}",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertStudent() != null)
                    {
                        st.Students.Add(InsertStudent());
                        st.SaveChanges();
                        MessageBox.Show("Added The Student Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Student", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateStudent() != null)
                    {
                        Student? updatedSt = UpdateStudent();

                        if (updatedSt.Fname == selectedStudent.Fname && updatedSt.Sname == selectedStudent.Sname &&
                            updatedSt.Age == selectedStudent.Age && updatedSt.Address == selectedStudent.Address &&
                            updatedSt.Dept_Id == selectedStudent.Dept_Id && updatedSt.St_super == selectedStudent.St_super)
                        {
                            MessageBox.Show("Faild To Update This Student Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldStudent = st.Students.FirstOrDefault(s => s.St_Id == selectedStudent.St_Id);
                        oldStudent.Fname = updatedSt.Fname;
                        oldStudent.Sname = updatedSt.Sname;
                        oldStudent.Age = updatedSt.Age;
                        oldStudent.Address = updatedSt.Address;
                        oldStudent.Dept_Id = updatedSt.Dept_Id;
                        oldStudent.St_super = updatedSt.St_super;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Student With Id: {selectedStudent.St_Id} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Student", "Data Error", MessageBoxButtons.OK,
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
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

            //Show new data on gridview
            students = st.Students.ToList();
            StdGView.DataSource = students
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();
        }

        private Student? InsertStudent()
        {
            try
            {
                Student newStudent = new Student()
                {
                    Fname = string.IsNullOrEmpty(txtFName.Text) ? null : txtFName.Text,
                    Sname = string.IsNullOrEmpty(txtLName.Text) ? null : txtLName.Text,
                    Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text,
                };

                if (string.IsNullOrEmpty(txtAge.Text))
                {
                    newStudent.Age = null;
                }
                else if (int.TryParse(txtAge.Text, out int chkAge) && chkAge > 0)
                {
                    newStudent.Age = chkAge;
                }
                else
                {
                    MessageBox.Show("Not Valid Age Value", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtAge.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtDeptId.Text))
                {
                    newStudent.Dept_Id = null;
                }
                else if (int.TryParse(txtDeptId.Text, out int chkDeptId))
                {
                    if (st.Departments.FirstOrDefault(d => d.Dept_Id == chkDeptId) != null)
                        newStudent.Dept_Id = chkDeptId;
                    else
                    {
                        MessageBox.Show("Check Department ID (Not Found)", "Insertion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }

                if (string.IsNullOrEmpty(txtSuperId.Text))
                {
                    newStudent.St_super = null;
                }
                else if (int.TryParse(txtSuperId.Text, out int chkSuperId))
                {
                    if (students.FirstOrDefault(s => s.St_Id == chkSuperId) != null)
                        newStudent.St_super = chkSuperId;
                    else
                    {
                        MessageBox.Show("Check SuperVisor ID (Not Found)", "Insertion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }
                return newStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return null;
            }
        }

        private Student? UpdateStudent()
        {
            try
            {
                Student updatedStudent = new Student()
                {
                    Fname = string.IsNullOrEmpty(txtFName.Text) ? null : txtFName.Text,
                    Sname = string.IsNullOrEmpty(txtLName.Text) ? null : txtLName.Text,
                    Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text,
                };

                if (string.IsNullOrEmpty(txtAge.Text))
                {
                    updatedStudent.Age = null;
                }
                else if (int.TryParse(txtAge.Text, out int chkAge) && chkAge > 0)
                {
                    updatedStudent.Age = chkAge;
                }
                else
                {
                    MessageBox.Show("Not Valid Age Value", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtAge.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtDeptId.Text))
                {
                    updatedStudent.Dept_Id = null;
                }
                else if (int.TryParse(txtDeptId.Text, out int chkDeptId))
                {
                    if (st.Departments.FirstOrDefault(d => d.Dept_Id == chkDeptId) != null)
                        updatedStudent.Dept_Id = chkDeptId;
                    else
                    {
                        MessageBox.Show("Check Department ID (Not Found)", "Update Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }

                if (string.IsNullOrEmpty(txtSuperId.Text))
                {
                    updatedStudent.St_super = null;
                }
                else if (int.TryParse(txtSuperId.Text, out int chkSuperId))
                {
                    //check if the st_id exists && not supervisor supervise himself
                    if (students.FirstOrDefault(s => s.St_Id == chkSuperId) != null && selectedStudent.St_Id != chkSuperId)
                        updatedStudent.St_super = chkSuperId;
                    else
                    {
                        MessageBox.Show("Check SuperVisor ID (Not Found)", "Update Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }
                return updatedStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void txtStIdDel_TextChanged(object sender, EventArgs e)
        {
            var r = students.Where(s =>
                s.St_Id == (int.TryParse(txtStIdDel.Text, out int check) ? check : -1))
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(txtStIdDel.Text) ? students.Select(s => new
            { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super }).ToList() : r;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //int stIdToBeDeleted = int.TryParse(txtStIdDel.Text, out int delID) ? delID : -1;
            try
            {
                if (int.TryParse(txtStIdDel.Text, out int delID))
                {
                    var stud = st.Students.FirstOrDefault(s => s.St_Id == delID);
                    if (stud != null)
                    {
                        st.Students.Remove(stud);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Student With Id: {delID} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Student (Not Found)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Student (Check Input)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

            //Show new data on gridview
            students = st.Students.ToList();
            StdGView.DataSource = students
                .Select(s => new
                { s.St_Id, s.Fname, s.Sname, s.Age, s.Address, s.Dept_Id, s.St_super })
                .ToList();
        }
        #endregion

        #region Row Selection in Grid View
        private void StdGView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //only selected state will work on StdGView
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (e.Row.Selected)
            {
                MessageBox.Show($"Row {e.Row.Index + 1} Fetched Successfully", "Fetch", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                selectedStudent = students[e.Row.Index];
                txtFName.Text = selectedStudent.Fname;
                txtLName.Text = selectedStudent.Sname;
                txtAge.Text = selectedStudent.Age.ToString();
                txtAddress.Text = selectedStudent.Address;
                txtDeptId.Text = selectedStudent.Dept_Id.ToString();
                txtSuperId.Text = selectedStudent.St_super.ToString();
                //if (selectedStudent.St_super == null)
                //    txtSuperId.PlaceholderText = "NULL";
                //else
                //    txtSuperId.Text = selectedStudent.St_super.ToString();
            }
        }
        #endregion
        #endregion
    }
}
