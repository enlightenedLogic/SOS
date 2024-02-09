using System;

namespace SOS
{



    public partial class Splash
    {
        public Splash()
        {
            InitializeComponent();
        }







        private void Splash_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // MainForm.Show()
            // Me.Hide()
            // Timer1.Enabled = False

            Timer1.Enabled = false;
            My.MyProject.Forms.Metro.Show();
            Hide();

        }
    }
}