using DBModels;

namespace DEPI
{
    public partial class CrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Course> courses;

        Course selectedCourse = new Course();

        public CrsForm()
        {
            InitializeComponent();
            courses = st.Courses.ToList();

            StdGView.DataSource = courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList();
        }


        #region Buttons Logic
        public List<Course> CheckMethodForButtons()
        {
            List<Course> stLst = new List<Course>();
            int id; int? topic_Id, cDuration;
            string cName;

            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["Crs_Id"].Value.ToString(), out int chkId) ?
                    chkId : -1;

                cName = StdGView.Rows[row].Cells["Crs_Name"].Value.ToString() ?? "NA";

                topic_Id =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Topic_Id"]?.Value?.ToString(), out int chkTopId) ?
                    chkTopId : null;

                cDuration =
                    int.TryParse(StdGView?.Rows[row]?.Cells["Crs_Duration"]?.Value?.ToString(), out int chkDuration) ?
                    chkDuration : -1;


                stLst.Add(new Course()
                {
                    Crs_Id = id,
                    Crs_Name = cName,
                    Topic_Id = topic_Id,
                    Crs_Duration = cDuration
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
            NameTBox.Clear();
            DurationTBox.Clear();
            TopicTBox.Clear();

            StdGView.DataSource = courses
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Course>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new Course());
                StdGView.DataSource = result.Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Course?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new Course());
                StdGView.DataSource = result.Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
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
                   .DistinctBy(c => c.Crs_Name)
                   .Select(c => new
                   { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
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
            StdGView.DataSource = courses.Join(st.Topics, c => c.Topic_Id, t => t.Top_Id, (c, t)
                => new
                { c.Crs_Id, c.Crs_Name, t.Top_Id, t.Topic_Name }).ToList();
        }

        private void ShowInstsButton_Click(object sender, EventArgs e)
        {
            var instCrs = courses.Join(st.InstCourses, c => c.Crs_Id, ic => ic.Crs_Id,
                (c, ic) => new { c.Crs_Id, c.Crs_Name, ic.Ins_Id, ic.Evaluation }).ToList();
            var inst = instCrs.Join(st.Instructors, ic => ic.Ins_Id, i => i.Ins_Id,
                (ic, i) => new { ic.Crs_Id, ic.Crs_Name, ic.Ins_Id, i.Ins_Name, ic.Evaluation });

            var r = inst.ToList();

            StdGView.DataSource = r;
        }

        private void ShowStudButton_Click(object sender, EventArgs e)
        {
            var studCrs = courses.Join(st.StudCourses, c => c.Crs_Id, sc => sc.Crs_Id,
                (c, sc) => new { c.Crs_Id, c.Crs_Name, sc.Stud_Id, sc.Grade }).ToList();
            var stud = studCrs.Join(st.Students, sc => sc.Stud_Id, s => s.St_Id,
                (sc, s) => new { sc.Crs_Id, sc.Crs_Name, sc.Stud_Id, s.Fname, s.Sname, sc.Grade });

            var r = stud.ToList();

            StdGView.DataSource = r;
        }
        #endregion

        #region TextBoxes Logic
        private void IdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = courses.Where(c =>
                c.Crs_Id == (int.TryParse(IdTBox.Text, out int check) ? check : -1))
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(IdTBox.Text) ? courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList() : r;
        }

        private void NameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = courses.Where(c =>
                c.Crs_Name?.Contains(NameTBox.Text) ?? false)
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(NameTBox.Text) ? courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList() : r;
        }

        private void DurationTBox_TextChanged(object sender, EventArgs e)
        {
            var r = courses.Where(c =>
                c.Crs_Duration == (int.TryParse(DurationTBox.Text, out int check) ? check : -1))
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(DurationTBox.Text) ? courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList() : r;
        }

        private void TopicTBox_TextChanged(object sender, EventArgs e)
        {
            var r = courses.Where(c =>
                c.Topic_Id == (int.TryParse(TopicTBox.Text, out int check) ? check : -1))
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(TopicTBox.Text) ? courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList() : r;
        }
        #endregion

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtCrsName.Clear();
            txtDuration.Clear();
            txtTopicID.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCrsName.Text))
                {
                    MessageBox.Show("Enter At Least The Course Name", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedCourse.Crs_Id > 0)
                {
                    yesNo = MessageBox.Show($"YES: Insert New Course\n NO: Update The Course With ID = {selectedCourse.Crs_Id}",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertCourse() != null)
                    {
                        st.Courses.Add(InsertCourse());
                        st.SaveChanges();
                        MessageBox.Show("Added The Course Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Course", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateCourse() != null)
                    {
                        Course? updatedCourse = UpdateCourse();

                        if (updatedCourse.Crs_Name == selectedCourse.Crs_Name &&
                            updatedCourse.Crs_Duration == selectedCourse.Crs_Duration &&
                            updatedCourse.Topic_Id == selectedCourse.Topic_Id)
                        {
                            MessageBox.Show("Faild To Update This Course Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldCourse = st.Courses.FirstOrDefault(c => c.Crs_Id == selectedCourse.Crs_Id);
                        oldCourse.Crs_Name = updatedCourse.Crs_Name;
                        oldCourse.Crs_Duration = updatedCourse.Crs_Duration;
                        oldCourse.Topic_Id = updatedCourse.Topic_Id;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Course With Id: {selectedCourse.Crs_Id} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Course", "Data Error", MessageBoxButtons.OK,
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
            courses = st.Courses.ToList();
            StdGView.DataSource = courses
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList();
        }

        private Course? InsertCourse()
        {
            try
            {
                Course newCourse = new Course()
                {
                    Crs_Name = string.IsNullOrEmpty(txtCrsName.Text) ? null : txtCrsName.Text,
                };

                if (string.IsNullOrEmpty(txtDuration.Text))
                {
                    newCourse.Crs_Duration = null;
                }
                else if (int.TryParse(txtDuration.Text, out int chkDuration) && chkDuration >= 0)
                {
                    newCourse.Crs_Duration = chkDuration;
                }
                else
                {
                    MessageBox.Show("Not Valid Duration Value", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtDuration.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtTopicID.Text))
                {
                    newCourse.Topic_Id = null;
                }
                else if (int.TryParse(txtTopicID.Text, out int chkTopicID))
                {
                    if (st.Topics.FirstOrDefault(t => t.Top_Id == chkTopicID) != null)
                        newCourse.Topic_Id = chkTopicID;
                    else
                    {
                        MessageBox.Show("Check Topic ID (Not Found)", "Insertion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtTopicID.Focus();
                        return default;
                    }
                }

                return newCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private Course? UpdateCourse()
        {
            try
            {
                Course updatedCourse = new Course()
                {
                    Crs_Name = string.IsNullOrEmpty(txtCrsName.Text) ? null : txtCrsName.Text,
                };

                if (string.IsNullOrEmpty(txtDuration.Text))
                {
                    updatedCourse.Crs_Duration = null;
                }
                else if (int.TryParse(txtDuration.Text, out int chkDuration) && chkDuration >= 0)
                {
                    updatedCourse.Crs_Duration = chkDuration;
                }
                else
                {
                    MessageBox.Show("Not Valid Duration Value", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtDuration.Focus();
                    return default;
                }

                if (string.IsNullOrEmpty(txtTopicID.Text))
                {
                    updatedCourse.Topic_Id = null;
                }
                else if (int.TryParse(txtTopicID.Text, out int chkTopicID))
                {
                    if (st.Topics.FirstOrDefault(t => t.Top_Id == chkTopicID) != null)
                        updatedCourse.Topic_Id = chkTopicID;
                    else
                    {
                        MessageBox.Show("Check Topic ID (Not Found)", "Update Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtTopicID.Focus();
                        return default;
                    }
                }

                return updatedCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void txtCrsIdDel_TextChanged(object sender, EventArgs e)
        {
            var r = courses.Where(c =>
                c.Crs_Id == (int.TryParse(txtCrsIdDel.Text, out int check) ? check : -1))
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(txtCrsIdDel.Text) ? courses.Select(c => new
            { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id }).ToList() : r;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtCrsIdDel.Text, out int delID))
                {
                    var crs = st.Courses.FirstOrDefault(c => c.Crs_Id == delID);
                    if (crs != null)
                    {
                        st.Courses.Remove(crs);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Course With Id: {delID} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Course (Not Found)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Course (Check Input)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            courses = st.Courses.ToList();
            StdGView.DataSource = courses
                .Select(c => new
                { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Topic_Id })
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
                selectedCourse = courses[e.Row.Index];
                txtCrsName.Text = selectedCourse.Crs_Name;
                txtDuration.Text = selectedCourse.Crs_Duration.ToString();
                txtTopicID.Text = selectedCourse.Topic_Id.ToString();
            }
        }

        #endregion

        #endregion
    }
}
