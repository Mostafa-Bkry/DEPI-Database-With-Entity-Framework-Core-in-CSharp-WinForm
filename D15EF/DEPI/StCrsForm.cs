using DBModels;

namespace DEPI
{
    public partial class StCrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<StudCourse> stCourses;

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
    }
}
