using DBModels;

namespace DEPI
{
    public partial class StCrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<StudCourse> stCourses;

        StudCourse selectedStCrs = new StudCourse();

        public StCrsForm()
        {
            InitializeComponent();
            stCourses = st.StudCourses.ToList();

            StdGView.DataSource = stCourses.Select(scr => new
            { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList();
        }


        #region Buttons Logic
        public List<StudCourse> CheckMethodForButtons()
        {
            List<StudCourse> stLst = new List<StudCourse>();
            int studId, crsId;
            int? grade;

            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                studId =
                    int.TryParse(StdGView.Rows[row].Cells["Stud_Id"].Value.ToString(), out int chkstId) ?
                    chkstId : -1;

                crsId =
                    int.TryParse(StdGView.Rows[row].Cells["Crs_Id"].Value.ToString(), out int chkCrsId) ?
                    chkCrsId : -1;

                grade =
                    int.TryParse(StdGView.Rows[row].Cells["Grade"].Value.ToString(), out int chkGrade) ?
                    chkGrade : -1;

                stLst.Add(new StudCourse()
                {
                    Stud_Id = studId,
                    Crs_Id = crsId,
                    Grade = grade,
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
            StIdTBox.Clear();
            CrsIdTBox.Clear();
            GradeTBox.Clear();

            StdGView.DataSource = stCourses
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<StudCourse>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new StudCourse());
                StdGView.DataSource = result.Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<StudCourse?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new StudCourse());
                StdGView.DataSource = result.Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
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
                   .DistinctBy(scr => scr.Grade)
                   .Select(scr => new
                   { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                   .ToList();

                StdGView.DataSource = r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


        }

        private void ShowDetailButton_Click(object sender, EventArgs e)
        {
            var stCrs = stCourses.Join(st.Students, scr => scr.Stud_Id, s => s.St_Id, (scr, s)
                => new { scr.Crs_Id, s.Fname, s.Sname, scr.Grade, scr.Stud_Id, });
            var crs = stCrs.Join(st.Courses, scr => scr.Crs_Id, c => c.Crs_Id, (scr, c)
                => new { c.Crs_Id, c.Crs_Name, scr.Stud_Id, scr.Fname, scr.Sname, scr.Grade, });

            var r = crs.ToList();

            StdGView.DataSource = r;
        }
        #endregion

        #region TextBoxes Logic
        private void StIdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = stCourses.Where(scr =>
                scr.Stud_Id == (int.TryParse(StIdTBox.Text, out int check) ? check : -1))
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(StIdTBox.Text) ? stCourses.Select(scr => new
            { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList() : r;
        }

        private void GradeTBox_TextChanged(object sender, EventArgs e)
        {
            var r = stCourses.Where(scr =>
                scr.Grade == (int.TryParse(GradeTBox.Text, out int check) ? check : -1))
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(GradeTBox.Text) ? stCourses.Select(scr => new
            { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList() : r;
        }

        private void CrsIdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = stCourses.Where(scr =>
                scr.Crs_Id == (int.TryParse(CrsIdTBox.Text, out int check) ? check : -1))
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(CrsIdTBox.Text) ? stCourses.Select(scr => new
            { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList() : r;
        }

        #endregion

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtStudID.Clear();
            txtCrsID.Clear();
            txtGrade.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStudID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Must Enter Student ID And Course ID", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedStCrs.Crs_Id > 0 && selectedStCrs.Stud_Id > 0)
                {
                    yesNo = MessageBox.Show(
                        $"YES: Insert Record\n NO: Update Record With CourseID = {selectedStCrs.Crs_Id} And With StudentID = {selectedStCrs.Stud_Id}",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertStudCrs() != null)
                    {
                        if (st.Students.FirstOrDefault(s => s.St_Id == InsertStudCrs().Stud_Id) != null &&
                            st.Courses.FirstOrDefault(c => c.Crs_Id == InsertStudCrs().Crs_Id) != null)
                        {
                            st.StudCourses.Add(InsertStudCrs());
                            st.SaveChanges();
                            MessageBox.Show("Added The Student Course Successfully", "Done", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetCRUDFields();
                        }
                        else
                        {
                            MessageBox.Show("Faild To Insert (Instructor ID Not Exists) OR (Course ID Not Exists)",
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Instructor Course", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateStudCrs() != null)
                    {
                        StudCourse? updatedInstCrs = UpdateStudCrs();

                        if (updatedInstCrs.Stud_Id == selectedStCrs.Stud_Id &&
                            updatedInstCrs.Crs_Id == selectedStCrs.Crs_Id &&
                            updatedInstCrs.Grade == selectedStCrs.Grade)
                        {
                            MessageBox.Show("Faild To Update This Record Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldInstCrs = st.StudCourses.FirstOrDefault
                            (stc => stc.Crs_Id == selectedStCrs.Crs_Id && stc.Stud_Id == selectedStCrs.Stud_Id);
                        oldInstCrs.Stud_Id = updatedInstCrs.Stud_Id;
                        oldInstCrs.Crs_Id = updatedInstCrs.Crs_Id;
                        oldInstCrs.Grade = updatedInstCrs.Grade;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Student Course With InstId: {selectedStCrs.Stud_Id} And CrsId: {selectedStCrs.Crs_Id} Successfully"
                            , "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Instructor Course", "Data Error", MessageBoxButtons.OK,
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
            stCourses = st.StudCourses.ToList();
            StdGView.DataSource = stCourses
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList();
        }

        private StudCourse? InsertStudCrs()
        {
            try
            {
                StudCourse newStudCourse = new StudCourse();

                if (string.IsNullOrEmpty(txtGrade.Text))
                {
                    newStudCourse.Grade = null;
                }
                else if (int.TryParse(txtGrade.Text, out int chkGrade) && chkGrade > 0)
                {
                    newStudCourse.Grade = chkGrade;
                }
                else
                {
                    MessageBox.Show("Not Valid Grade Value", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtGrade.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtStudID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Not Valid Student ID or Course ID Values", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return default;
                }
                else if (int.TryParse(txtStudID.Text, out int chkStudID) && chkStudID > 0
                    && int.TryParse(txtCrsID.Text, out int chkCrsId) && chkCrsId > 0)
                {
                    if (st.InstCourses.FirstOrDefault(icr => (icr.Ins_Id == chkStudID) && (icr.Crs_Id == chkCrsId)) == null)
                    {
                        newStudCourse.Stud_Id = chkStudID;
                        newStudCourse.Crs_Id = chkCrsId;
                    }
                    else
                    {
                        MessageBox.Show("Check Student ID or Course ID (Not Found)", "Insertion Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudID.Focus();
                        return default;
                    }
                }
                else
                {
                    MessageBox.Show("Not Valid Student ID or Course ID Values", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtStudID.Focus();
                    return default;
                }


                return newStudCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private StudCourse? UpdateStudCrs()
        {
            try
            {
                StudCourse updatedStudCourse = new StudCourse();

                if (string.IsNullOrEmpty(txtGrade.Text))
                {
                    updatedStudCourse.Grade = null;
                }
                else if (int.TryParse(txtGrade.Text, out int chkGrade) && chkGrade > 0)
                {
                    updatedStudCourse.Grade = chkGrade;
                }
                else
                {
                    MessageBox.Show("Not Valid Grade Value", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtGrade.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtStudID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Not Valid Student ID or Course ID Values", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return default;
                }
                else if (int.TryParse(txtStudID.Text, out int chkStudID) && chkStudID > 0
                    && int.TryParse(txtCrsID.Text, out int chkCrsId) && chkCrsId > 0)
                {
                    if (st.StudCourses.FirstOrDefault(stc => stc.Stud_Id == chkStudID && stc.Crs_Id == chkCrsId) != null)
                    {
                        updatedStudCourse.Stud_Id = chkStudID;
                        updatedStudCourse.Crs_Id = chkCrsId;
                    }
                    else
                    {
                        MessageBox.Show("Check Student ID or Course ID (Not Found)", "Update Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudID.Focus();
                        return default;
                    }
                }
                else
                {
                    MessageBox.Show("Not Valid Student ID or Course ID Values", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtStudID.Focus();
                    return default;
                }


                return updatedStudCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtStIdDel.Text, out int studID) && int.TryParse(txtCrsIDDel.Text, out int crsID))
                {
                    var studCrs = st.StudCourses.FirstOrDefault(stc => (stc.Stud_Id == studID) && (stc.Crs_Id == crsID));
                    if (studCrs != null)
                    {
                        st.StudCourses.Remove(studCrs);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Student Course With Id: {studID} Successfully", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Student Course (Not Found)", "Deletion Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Student Course (Check Inputs)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            stCourses = st.StudCourses.ToList();
            StdGView.DataSource = stCourses
                .Select(scr => new
                { scr.Stud_Id, scr.Crs_Id, scr.Grade }).ToList();
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
                selectedStCrs = stCourses[e.Row.Index];
                txtStudID.Text = selectedStCrs.Stud_Id.ToString();
                txtCrsID.Text = selectedStCrs.Crs_Id.ToString();
                txtGrade.Text = selectedStCrs.Grade.ToString();
            }
        }

        #endregion

        #endregion
    }
}
