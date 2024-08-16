using DBModels;

namespace DEPI
{
    public partial class InstsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Instructor> instructors;

        Instructor selectedInstructor = new Instructor();

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

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtInstName.Clear();
            txtDegree.Clear();
            txtSalary.Clear();
            txtDeptID.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInstName.Text))
                {
                    MessageBox.Show("Enter At Least The Instructor Name", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedInstructor.Ins_Id > 0)
                {
                    yesNo = MessageBox.Show($"YES: Insert New Instructor\n NO: Update The Instructor With ID = {selectedInstructor.Ins_Id}",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertInstructor() != null)
                    {
                        st.Instructors.Add(InsertInstructor());
                        st.SaveChanges();
                        MessageBox.Show("Added The Instructor Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Instructor", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateInstructor() != null)
                    {
                        Instructor? updatedInst = UpdateInstructor();

                        if (updatedInst.Ins_Name == selectedInstructor.Ins_Name &&
                            updatedInst.Ins_Degree == selectedInstructor.Ins_Degree &&
                            updatedInst.Salary == selectedInstructor.Salary &&
                            updatedInst.Dept_Id == selectedInstructor.Dept_Id)
                        {
                            MessageBox.Show("Faild To Update This Instructor Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldInst = st.Instructors.FirstOrDefault(i => i.Ins_Id == selectedInstructor.Ins_Id);
                        oldInst.Ins_Name = updatedInst.Ins_Name;
                        oldInst.Ins_Degree = updatedInst.Ins_Degree;
                        oldInst.Salary = updatedInst.Salary;
                        oldInst.Dept_Id = updatedInst.Dept_Id;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Instructor With Id: {selectedInstructor.Ins_Id} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Instructor", "Data Error", MessageBoxButtons.OK,
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
            instructors = st.Instructors.ToList();
            StdGView.DataSource = instructors
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList();
        }

        private Instructor? InsertInstructor()
        {
            try
            {
                Instructor newInst = new Instructor()
                {
                    Ins_Name = string.IsNullOrEmpty(txtInstName.Text) ? null : txtInstName.Text,
                    Ins_Degree = string.IsNullOrEmpty(txtDegree.Text) ? null : txtDegree.Text,
                };

                if (string.IsNullOrEmpty(txtSalary.Text))
                {
                    newInst.Salary = null;
                }
                else if (float.TryParse(txtSalary.Text, out float chkSalary) && chkSalary > 0)
                {
                    newInst.Salary = chkSalary;
                }
                else
                {
                    MessageBox.Show("Not Valid Salary Value", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSalary.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtDeptID.Text))
                {
                    newInst.Dept_Id = null;
                }
                else if (int.TryParse(txtDeptID.Text, out int chkDeptID))
                {
                    if (st.Departments.FirstOrDefault(d => d.Dept_Id == chkDeptID) != null)
                        newInst.Dept_Id = chkDeptID;
                    else
                    {
                        MessageBox.Show("Check Department ID (Not Found)", "Insertion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }


                return newInst;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private Instructor? UpdateInstructor()
        {
            try
            {
                Instructor updatedInst = new Instructor()
                {
                    Ins_Name = string.IsNullOrEmpty(txtInstName.Text) ? null : txtInstName.Text,
                    Ins_Degree = string.IsNullOrEmpty(txtDegree.Text) ? null : txtDegree.Text,
                };

                if (string.IsNullOrEmpty(txtSalary.Text))
                {
                    updatedInst.Salary = null;
                }
                else if (float.TryParse(txtSalary.Text, out float chkSalary) && chkSalary > 0)
                {
                    updatedInst.Salary = chkSalary;
                }
                else
                {
                    MessageBox.Show("Not Valid Salary Value", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSalary.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtDeptID.Text))
                {
                    updatedInst.Dept_Id = null;
                }
                else if (int.TryParse(txtDeptID.Text, out int chkDeptID))
                {
                    if (st.Departments.FirstOrDefault(d => d.Dept_Id == chkDeptID) != null)
                        updatedInst.Dept_Id = chkDeptID;
                    else
                    {
                        MessageBox.Show("Check Department ID (Not Found)", "Update Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return default;
                    }
                }


                return updatedInst;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void txtInstIdDel_TextChanged(object sender, EventArgs e)
        {
            var r = instructors.Where(i =>
                i.Ins_Id == (int.TryParse(txtInstIdDel.Text, out int check) ? check : -1))
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(txtInstIdDel.Text) ? instructors.Select(i => new
            { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList() : r;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtInstIdDel.Text, out int delID))
                {
                    var inst = st.Instructors.FirstOrDefault(i => i.Ins_Id == delID);
                    if (inst != null)
                    {
                        st.Instructors.Remove(inst);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Instructor With Id: {delID} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Instructor (Not Found)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Instructor (Check Input)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            instructors = st.Instructors.ToList();
            StdGView.DataSource = instructors
                .Select(i => new
                { i.Ins_Id, i.Ins_Name, i.Ins_Degree, i.Salary, i.Dept_Id }).ToList();
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
                selectedInstructor = instructors[e.Row.Index];
                txtInstName.Text = selectedInstructor.Ins_Name;
                txtDegree.Text = selectedInstructor.Ins_Degree;
                txtSalary.Text = selectedInstructor.Salary.ToString();
                txtDeptID.Text = selectedInstructor.Dept_Id.ToString();
            }
        }

        #endregion

        #endregion
    }
}
