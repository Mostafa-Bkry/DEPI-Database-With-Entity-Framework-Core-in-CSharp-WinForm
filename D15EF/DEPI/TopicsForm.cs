
using DBModels;

namespace DEPI
{
    public partial class TopicsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Topic> topics;

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
    }
}
