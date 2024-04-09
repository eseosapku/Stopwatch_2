using System.Reflection.Emit;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true; // Resume the stopwatch
        }

        private void Start_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button1stop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;

                if (timeCs >= 60)
                {
                    timeSec++;
                    timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            seconds.Text = String.Format("{00:00}", timeCs);
            minute.Text = String.Format("{00:00}", timeSec);
            hour.Text = String.Format("{00:00}", timeMin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
            isActive = false; // Pause the stopwatch
        }
    }
}