
using DBModels;

namespace DEPI
{
    public partial class TopicsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Topic> topics;

        Topic selectedTopic = new Topic();

        public TopicsForm()
        {
            InitializeComponent();
            topics = st.Topics.ToList();

            StdGView.DataSource = topics.Select(t => new
            { t.Top_Id, t.Topic_Name }).ToList();
        }


        #region Buttons Logic
        public List<Topic> CheckMethodForButtons()
        {
            List<Topic> stLst = new List<Topic>();
            int id;
            string tName;

            for (int row = 0; row < StdGView?.Rows.Count; row++)
            {
                id =
                    int.TryParse(StdGView.Rows[row].Cells["Top_Id"].Value.ToString(), out int chkId) ?
                    chkId : -1;

                tName = StdGView.Rows[row].Cells["Topic_Name"].Value.ToString() ?? "NA";

                stLst.Add(new Topic()
                {
                    Top_Id = id,
                    Topic_Name = tName,
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

            StdGView.DataSource = topics
                .Select(t => new
                { t.Top_Id, t.Topic_Name })
                .ToList();
        }

        private void FstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Topic>();

            try
            {
                result.Add(CheckMethodForButtons()?.FirstOrDefault() ?? new Topic());
                StdGView.DataSource = result.Select(t => new
                { t.Top_Id, t.Topic_Name })
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void LstButton_Click(object sender, EventArgs e)
        {
            var result = new List<Topic?>();

            try
            {
                result.Add(CheckMethodForButtons()?.LastOrDefault() ?? new Topic());
                StdGView.DataSource = result.Select(t => new
                { t.Top_Id, t.Topic_Name })
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
                   .DistinctBy(t => t.Topic_Name)
                   .Select(t => new
                   { t.Top_Id, t.Topic_Name })
                   .ToList();

                StdGView.DataSource = r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


        }

        private void ShowTopicButton_Click(object sender, EventArgs e)
        {
            StdGView.DataSource = topics.Join(st.Courses, t => t.Top_Id, c => c.Topic_Id, (t, c)
                => new
                { t.Top_Id, t.Topic_Name, c.Crs_Id, c.Crs_Name }).ToList();
        }
        #endregion

        #region TextBoxes Logic
        private void IdTBox_TextChanged(object sender, EventArgs e)
        {
            var r = topics.Where(t =>
                t.Top_Id == (int.TryParse(IdTBox.Text, out int check) ? check : -1))
                .Select(t => new
                { t.Top_Id, t.Topic_Name })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(IdTBox.Text) ? topics.Select(t => new
            { t.Top_Id, t.Topic_Name }).ToList() : r;
        }

        private void NameTBox_TextChanged(object sender, EventArgs e)
        {
            var r = topics.Where(t =>
                t.Topic_Name?.Contains(NameTBox.Text) ?? false)
                .Select(t => new
                { t.Top_Id, t.Topic_Name })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(NameTBox.Text) ? topics.Select(t => new
            { t.Top_Id, t.Topic_Name }).ToList() : r;
        }
        #endregion

        #region CRUD Operations
        private void ResetCRUDFields()
        {
            txtTopicName.Clear();
        }

        #region Insert & Update
        private void InsertUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtTopicName.Text))
                //{
                //    DialogResult dia = MessageBox.Show("Do you want to add new Topic without name?", "Data Error", MessageBoxButtons.YesNoCancel,
                //            MessageBoxIcon.Warning);
                //    if (dia == DialogResult.Yes)
                //    {
                //        st.Topics.Add(InsertTopic());
                //        st.SaveChanges();
                //        MessageBox.Show("Added The Topic Successfully", "Done", MessageBoxButtons.OK,
                //            MessageBoxIcon.Information);
                //        ResetCRUDFields();
                //    }
                //    topics = st.Topics.ToList();
                //    StdGView.DataSource = topics
                //        .Select(t => new
                //        { t.Top_Id, t.Topic_Name }).ToList();

                //    return;
                //}

                DialogResult yesNo = DialogResult.Yes;
                if (selectedTopic.Top_Id > 0)
                {
                    yesNo = MessageBox.Show("YES: Insert New Topic\n NO: Update The Topic",
                        "Insert OR Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                //Insert
                if (yesNo == DialogResult.Yes)
                {
                    if (InsertTopic() != null)
                    {
                        st.Topics.Add(InsertTopic());
                        st.SaveChanges();
                        MessageBox.Show("Added The Topic Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Insert This Topic", "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                //Update
                else if (yesNo == DialogResult.No)
                {
                    if (UpdateTopic() != null)
                    {
                        Topic? updatedTopic = UpdateTopic();

                        if (updatedTopic.Topic_Name == selectedTopic.Topic_Name)
                        {
                            MessageBox.Show("Faild To Update This Topic Because you never updated any of data", "Data Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var oldTopic = st.Topics.FirstOrDefault(t => t.Top_Id == selectedTopic.Top_Id);
                        oldTopic.Topic_Name = updatedTopic.Topic_Name;
                        st.SaveChanges();
                        MessageBox.Show($"Updated Topic With Id: {selectedTopic.Top_Id} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetCRUDFields();
                    }
                    else
                    {
                        MessageBox.Show("Faild To Update This Topic", "Data Error", MessageBoxButtons.OK,
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
            topics = st.Topics.ToList();
            StdGView.DataSource = topics
                .Select(t => new
                { t.Top_Id, t.Topic_Name }).ToList();
        }

        private Topic? InsertTopic()
        {
            try
            {
                return new Topic()
                {
                    Topic_Name = string.IsNullOrEmpty(txtTopicName.Text) ? null : txtTopicName.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private Topic? UpdateTopic()
        {
            try
            {
                return new Topic()
                {
                    Topic_Name = string.IsNullOrEmpty(txtTopicName.Text) ? null : txtTopicName.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Delete
        private void txtTopicIdDel_TextChanged(object sender, EventArgs e)
        {
            var r = topics.Where(t =>
                t.Top_Id == (int.TryParse(txtTopicIdDel.Text, out int check) ? check : -1))
                .Select(t => new
                { t.Top_Id, t.Topic_Name })
                .ToList();

            StdGView.DataSource = string.IsNullOrEmpty(txtTopicIdDel.Text) ? topics.Select(t => new
            { t.Top_Id, t.Topic_Name }).ToList() : r;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtTopicIdDel.Text, out int delID))
                {
                    var topic = st.Topics.FirstOrDefault(t => t.Top_Id == delID);
                    if (topic != null)
                    {
                        st.Topics.Remove(topic);
                        st.SaveChanges();
                        MessageBox.Show($"Deleted The Topic With Id: {delID} Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Delete This Topic (Not Found)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Topic (Check Input)", "Deletion Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Show new data on gridview
            topics = st.Topics.ToList();
            StdGView.DataSource = topics
                .Select(t => new
                { t.Top_Id, t.Topic_Name }).ToList();
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
                selectedTopic = topics[e.Row.Index];
                txtTopicName.Text = selectedTopic.Topic_Name;
            }
        }

        #endregion

        #endregion
    }
}
