using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace DEPI
{
    public partial class FirstPageForm : Form
    {
        private Timer timer;
        private SoundPlayer player;

        public FirstPageForm()
        {
            InitializeComponent();
            using (player = new SoundPlayer(@".\Audio File\sally-aala-mohamed.wav"))
            {
                player.Play();
            }
            InitializeTimer();
            player = new SoundPlayer(@".\Audio File\sally-aala-mohamed.wav");
        }

        #region Code For running the audio file
        private void InitializeTimer()
        {
            timer = new Timer();
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

        private void StButton_Click(object sender, EventArgs e)
        {
            StsForm studentsForm = new StsForm();
            studentsForm.Show();
            studentsForm.Tag = this;
            this.Hide();
        }

        private void StCrsButton_Click(object sender, EventArgs e)
        {
            StCrsForm stCrsForm = new StCrsForm();
            stCrsForm.Show();
            stCrsForm.Tag = this;
            this.Hide();
        }

        private void InstButton_Click(object sender, EventArgs e)
        {
            InstsForm instsForm = new InstsForm();
            instsForm.Show();
            instsForm.Tag = this;
            this.Hide();
        }

        private void InstCrsButton_Click(object sender, EventArgs e)
        {
            InstCrsForm instCrsForm = new InstCrsForm();
            instCrsForm.Show();
            instCrsForm.Tag = this;
            this.Hide();
        }

        private void DeptButton_Click(Object sender, EventArgs e)
        {
            DeptsForm deptsForm = new DeptsForm();
            deptsForm.Show();
            deptsForm.Tag = this;
            this.Hide();
        }

        private void CrsButton_Click(object sender, EventArgs e)
        {
            CrsForm crsForm = new CrsForm();
            crsForm.Show();
            crsForm.Tag = this;
            this.Hide();
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            TopicsForm topicsForm = new TopicsForm();
            topicsForm.Show();
            topicsForm.Tag = this;
            this.Hide();
        }
    }
}
