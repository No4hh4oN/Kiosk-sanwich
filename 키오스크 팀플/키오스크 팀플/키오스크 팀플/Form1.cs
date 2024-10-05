using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;

            // 타이머 설정
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;

            // 타이머 시작
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // PictureBox의 가시성을 토글
            pictureBox1.Visible = !pictureBox1.Visible;
            pictureBox2.Visible = !pictureBox2.Visible;
        }

        private void OpenForm7()
        {
            // 타이머 중지
            timer.Enabled = false;

            this.Hide();
            Form7 newForm7 = new Form7();
            newForm7.FormClosed += new FormClosedEventHandler(Form7_FormClosed);
            newForm7.ShowDialog();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 타이버 재시작
            timer.Enabled = true;
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox 클릭 이벤트 처리
            OpenForm7();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm7();
        }
    }
}
