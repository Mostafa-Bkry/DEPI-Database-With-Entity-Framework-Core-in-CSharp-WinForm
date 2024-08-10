using DBModels;

namespace DEPI
{
    public partial class CrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<Course> courses;

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
    }
}
