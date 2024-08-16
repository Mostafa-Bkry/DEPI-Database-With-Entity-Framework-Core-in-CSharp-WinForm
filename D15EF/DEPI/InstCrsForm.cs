using DBModels;

namespace DEPI
{
    public partial class InstCrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<InstCourse> intsCourses;

        InstCourse selectedInstCrs = new InstCourse();

        public InstCrsForm()
        {
            InitializeComponent();
            intsCourses = st.InstCourses.ToList();

            StdGView.DataSource = intsCourses.Select(icr => new
            { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList();
        }


        #region Buttons Logic
        public List<InstCourse> CheckMethodForButtons()
        {
            List<InstCourse> stLst = new List<InstCourse>();
            int instId, crsId;
            string evalu;

            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                instId =
                    int.TryParse(StdGView.Rows[row].Cells["Ins_Id"].Value.ToString(), out int chkInstId) ?
                    chkInstId : -1;

                crsId =
                    int.TryParse(StdGView.Rows[row].Cells["Crs_Id"].Value.ToString(), out int chkCrsId) ?
                    chkCrsId : -1;

                evalu = StdGView?.Rows[row]?.Cells["Evaluation"]?.Value?.ToString() ?? "NA";

                stLst.Add(new InstCourse()
                {
                    Ins_Id = instId,
                    Crs_Id = crsId,
                    Evaluation = evalu == "NA" ? null : evalu,
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
            InstIdTBox.Clear();
            CrsIdTBox.Clear();
            EvalTBox.Clear();

            StdGView.DataSource = intsCourses
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<InstCourse>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new InstCourse());
                StdGView.DataSource = result.Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<InstCourse?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new InstCourse());
                StdGView.DataSource = result.Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
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
                   .DistinctBy(icr => icr.Evaluation)
                   .Select(icr => new
                   { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
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
            var instCrs = intsCourses.Join(st.Instructors, icr => icr.Ins_Id, i => i.Ins_Id, (icr, i)
                => new { icr.Evaluation, icr.Ins_Id, i.Ins_Name, icr.Crs_Id, });
            var crs = instCrs.Join(st.Courses, icr => icr.Crs_Id, c => c.Crs_Id, (icr, c)
                => new { c.Crs_Id, c.Crs_Name, icr.Ins_Id, icr.Ins_Name, icr.Evaluation, });

            var r = crs.ToList();

            StdGView.DataSource = r;
        }
        #endregion

        #region TextBoxes Logic
        private void InstIdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = intsCourses.Where(icr =>
                icr.Ins_Id == (int.TryParse(InstIdTBox.Text, out int check) ? check : -1))
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(InstIdTBox.Text) ? intsCourses.Select(icr => new
            { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList() : r;
        }

        private void CrsIdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = intsCourses.Where(icr =>
                icr.Crs_Id == (int.TryParse(CrsIdTBox.Text, out int check) ? check : -1))
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(CrsIdTBox.Text) ? intsCourses.Select(icr => new
            { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList() : r;
        }

        private void EvalTBox_TextChanged(object sender, EventArgs e)
        {
            var r = intsCourses.Where(icr =>
                icr.Evaluation?.Contains(EvalTBox.Text) ?? false)
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(EvalTBox.Text) ? intsCourses.Select(icr => new
            { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList() : r;
        }
        #endregion

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtInstID.Clear();
            txtCrsID.Clear();
            txtEvalu.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInstID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Must Enter Instructor ID And Course ID", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                DialogResult yesNo = DialogResult.Yes;
                if (selectedInstCrs.Crs_Id > 0 && selectedInstCrs.Ins_Id > 0)
                {
                    yesNo = MessageBox.Show("YES: Insert Record\n NO: Update Record",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertInstCourse() != null)
                    {
                        if(st.Instructors.FirstOrDefault(i => i.Ins_Id == InsertInstCourse().Ins_Id) != null &&
                            st.Courses.FirstOrDefault(c => c.Crs_Id == InsertInstCourse().Crs_Id) != null)
                        {
                            st.InstCourses.Add(InsertInstCourse());
                            st.SaveChanges();
                            MessageBox.Show("Added The Instructor Course Successfully", "Done", MessageBoxButtons.OK,
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
                    if (UpdateInstCourse() != null)
                    {
                        InstCourse? updatedInstCrs = UpdateInstCourse();

                        if (updatedInstCrs.Ins_Id == selectedInstCrs.Ins_Id &&
                            updatedInstCrs.Crs_Id == selectedInstCrs.Crs_Id &&
                            updatedInstCrs.Evaluation == selectedInstCrs.Evaluation)
                        {
                            MessageBox.Show("Faild To Update This Record Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldInstCrs = st.InstCourses.FirstOrDefault
                            (icr => icr.Crs_Id == selectedInstCrs.Crs_Id && icr.Ins_Id == selectedInstCrs.Ins_Id);
                        oldInstCrs.Ins_Id = updatedInstCrs.Ins_Id;
                        oldInstCrs.Crs_Id = updatedInstCrs.Crs_Id;
                        oldInstCrs.Evaluation = updatedInstCrs.Evaluation;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Instructor Course With InstId: {selectedInstCrs.Ins_Id} And CrsId: {selectedInstCrs.Crs_Id} Successfully"
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
            intsCourses = st.InstCourses.ToList();
            StdGView.DataSource = intsCourses
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList();
        }

        private InstCourse? InsertInstCourse()
        {
            try
            {
                InstCourse newInstCourse = new InstCourse()
                {
                    Evaluation = string.IsNullOrEmpty(txtEvalu.Text) ? null : txtEvalu.Text,
                };

                if (string.IsNullOrEmpty(txtInstID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Not Valid Instructor ID or Course ID Values", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return default;
                }
                else if (int.TryParse(txtInstID.Text, out int chkInstID) && chkInstID > 0
                    && int.TryParse(txtCrsID.Text, out int chkCrsId) && chkCrsId > 0)
                {
                    if (st.InstCourses.FirstOrDefault(icr => (icr.Ins_Id == chkInstID) && (icr.Crs_Id == chkCrsId)) == null)
                    {
                        newInstCourse.Ins_Id = chkInstID;
                        newInstCourse.Crs_Id = chkCrsId;
                    }
                    else
                    {
                        MessageBox.Show("Check Instructor ID or Course ID (Not Found)", "Insertion Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInstID.Focus();
                        return default;
                    }
                }
                else
                {
                    MessageBox.Show("Not Valid Instructor ID or Course ID Values", "Insertion Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtInstID.Focus();
                    return default;
                }


                return newInstCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private InstCourse? UpdateInstCourse()
        {
            try
            {
                InstCourse updatedCourse = new InstCourse()
                {
                    Evaluation = string.IsNullOrEmpty(txtEvalu.Text) ? null : txtEvalu.Text,
                };

                if (string.IsNullOrEmpty(txtInstID.Text) || string.IsNullOrEmpty(txtCrsID.Text))
                {
                    MessageBox.Show("Not Valid Instructor ID or Course ID Values", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return default;
                }
                else if (int.TryParse(txtInstID.Text, out int chkInstID) && chkInstID > 0
                    && int.TryParse(txtCrsID.Text, out int chkCrsId) && chkCrsId > 0)
                {
                    if (st.InstCourses.FirstOrDefault(icr => icr.Ins_Id == chkInstID && icr.Crs_Id == chkCrsId) != null)
                    {
                        updatedCourse.Ins_Id = chkInstID;
                        updatedCourse.Crs_Id = chkCrsId;
                    }
                    else
                    {
                        MessageBox.Show("Check Instructor ID or Course ID (Not Found)", "Update Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInstID.Focus();
                        return default;
                    }
                }
                else
                {
                    MessageBox.Show("Not Valid Instructor ID or Course ID Values", "Update Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtInstID.Focus();
                    return default;
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
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtInstIdDel.Text, out int instID) && int.TryParse(txtCrsIDDel.Text, out int crsID))
                {
                    var instCrs = st.InstCourses.FirstOrDefault(icr => (icr.Ins_Id == instID) && (icr.Crs_Id == crsID));
                    if (instCrs != null)
                    {
                        st.InstCourses.Remove(instCrs);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Instructor Course With Id: {instID} Successfully", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Instructor Course (Not Found)", "Deletion Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Instructor Course (Check Inputs)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            intsCourses = st.InstCourses.ToList();
            StdGView.DataSource = intsCourses
                .Select(icr => new
                { icr.Ins_Id, icr.Crs_Id, icr.Evaluation }).ToList();
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
                selectedInstCrs = intsCourses[e.Row.Index];
                txtInstID.Text = selectedInstCrs.Ins_Id.ToString();
                txtCrsID.Text = selectedInstCrs.Crs_Id.ToString();
                txtEvalu.Text = selectedInstCrs.Evaluation;
            }
        }

        #endregion

        #endregion
    }
}
