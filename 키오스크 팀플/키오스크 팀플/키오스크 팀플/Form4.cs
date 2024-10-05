using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public event EventHandler<Form4EventArgs> CheeseSelectionCompleted;

        List<string> list1 = new List<string>();
        private string selectedCheese;  // 선택한 치즈 정보를 저장할 변수 추가

        public Form4(string text)
        {
            InitializeComponent();

            label1.Text = text;

            list1.Add("모차렐라 치즈");
            list1.Add("슈레드치즈");
            list1.Add("아메리칸 치즈");
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"..\..\치즈\모차렐라 치즈.jpg");
            Bitmap bitmap1 = new Bitmap(@"..\..\치즈\슈레드치즈.jpg");
            Bitmap bitmap2 = new Bitmap(@"..\..\치즈\아메리칸 치즈.jpg");

            button2.BackgroundImage = bitmap;
            button3.BackgroundImage = bitmap1;
            button4.BackgroundImage = bitmap2;

            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button4.BackgroundImageLayout = ImageLayout.Stretch;

            button2.Text = list1[0];
            button3.Text = list1[1];
            button4.Text = list1[2];

            button2.Click += msghandler;
            button3.Click += msghandler;
            button4.Click += msghandler;
        }
        private void msghandler(object sender, EventArgs e)
        {
            selectedCheese = ((Button)sender).Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheeseSelectionCompleted?.Invoke(this, new Form4EventArgs(selectedCheese));
            this.Close();
        }
        public class Form4EventArgs : EventArgs
        {
            public string SelectedCheese { get; private set; }

            public Form4EventArgs(string selectedCheese)
            {
                SelectedCheese = selectedCheese;
            }
        }
    }
}
