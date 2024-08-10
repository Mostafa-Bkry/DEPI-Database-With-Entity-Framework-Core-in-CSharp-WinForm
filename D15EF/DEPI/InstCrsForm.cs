using DBModels;

namespace DEPI
{
    public partial class InstCrsForm : Form
    {
        DEPIContext st = new DEPIContext();
        List<InstCourse> intsCourses;

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

                evalu = StdGView.Rows[row].Cells["Evaluation"].Value.ToString() ?? "NA";

                stLst.Add(new InstCourse()
                {
                    Ins_Id = instId,
                    Crs_Id = crsId,
                    Evaluation = evalu,
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
    }
}
