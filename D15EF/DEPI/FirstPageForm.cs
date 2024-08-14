using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace DEPI
{
    public partial class FirstPageForm : Form
    {
        private Timer timer = new Timer();
        private SoundPlayer player = new SoundPlayer(@".\Audio File\sally-aala-mohamed.wav");

        public FirstPageForm()
        {
            InitializeComponent();

            PlayWavFile();
            InitializeTimer();
        }

        #region Code For running the audio file
        private void InitializeTimer()
        {
            timer.Interval = 60000; // 1 minute = 60000 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PlayWavFile();
        }

        private void PlayWavFile()
        {
            try
            {
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }
        #endregion

        #region Buttons Logic
        private void NavigateToForms(Form form)
        {
            form.Show();
            form.Tag = this;
            this.Hide();
        }

        private void StButton_Click(object sender, EventArgs e)
        {
            StsForm studentsForm = new StsForm();
            NavigateToForms(studentsForm);
        }

        private void StCrsButton_Click(object sender, EventArgs e)
        {
            StCrsForm stCrsForm = new StCrsForm();
            NavigateToForms(stCrsForm);
        }

        private void InstButton_Click(object sender, EventArgs e)
        {
            InstsForm instsForm = new InstsForm();
            NavigateToForms(instsForm);
        }

        private void InstCrsButton_Click(object sender, EventArgs e)
        {
            InstCrsForm instCrsForm = new InstCrsForm();
            NavigateToForms(instCrsForm);
        }

        private void DeptButton_Click(Object sender, EventArgs e)
        {
            DeptsForm deptsForm = new DeptsForm();
            NavigateToForms(deptsForm);
        }

        private void CrsButton_Click(object sender, EventArgs e)
        {
            CrsForm crsForm = new CrsForm();
            NavigateToForms(crsForm);
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            TopicsForm topicsForm = new TopicsForm();
            NavigateToForms(topicsForm);
        }
        #endregion
    }
}
