using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        List<string> list1 = new List<string>();
        List<string> selectedItems = new List<string>();
        public Form6(string text)
        {
            InitializeComponent();

            label1.Text = text;

            list1.Add("랜치");
            list1.Add("스위트 어니언");
            list1.Add("마요네즈");
            list1.Add("스위트 칠리");
            list1.Add("스모크 바베큐");
            list1.Add("핫 칠리");
            list1.Add("허니 머스터드");
            list1.Add("사우스웨스트 치폴레");
            list1.Add("홀스래디쉬");
            list1.Add("핫 칠리");
            list1.Add("올리브 오일");
            list1.Add("레드 와인 식초");
            list1.Add("소금");
            list1.Add("후추");
        }
        private void Form6_Load_1(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"..\..\소스\랜치.jpg");
            Bitmap bitmap1 = new Bitmap(@"..\..\소스\스위트 어니언.jpg");
            Bitmap bitmap2 = new Bitmap(@"..\..\소스\마요네즈.jpg");
            Bitmap bitmap3 = new Bitmap(@"..\..\소스\스위트 칠리.jpg");
            Bitmap bitmap4 = new Bitmap(@"..\..\소스\스모크 바베큐.jpg");
            Bitmap bitmap5 = new Bitmap(@"..\..\소스\핫칠리.jpg");
            Bitmap bitmap6 = new Bitmap(@"..\..\소스\허니 머스타드.jpg");
            Bitmap bitmap7 = new Bitmap(@"..\..\소스\사우스웨스트 치폴레.jpg");
            Bitmap bitmap8 = new Bitmap(@"..\..\소스\홀스래디쉬.jpg");
            Bitmap bitmap9 = new Bitmap(@"..\..\소스\머스타드.jpg");
            Bitmap bitmap10 = new Bitmap(@"..\..\소스\올리브 오일.jpg");
            Bitmap bitmap11 = new Bitmap(@"..\..\소스\레드 와인 식초.jpg");
            Bitmap bitmap12 = new Bitmap(@"..\..\소스\소금.jpg");
            Bitmap bitmap13 = new Bitmap(@"..\..\소스\후추.jpg");

            button2.BackgroundImage = bitmap;
            button3.BackgroundImage = bitmap1;
            button4.BackgroundImage = bitmap2;
            button5.BackgroundImage = bitmap3;
            button6.BackgroundImage = bitmap4;
            button7.BackgroundImage = bitmap5;
            button8.BackgroundImage = bitmap6;
            button9.BackgroundImage = bitmap7;
            button10.BackgroundImage = bitmap8;
            button11.BackgroundImage = bitmap9;
            button12.BackgroundImage = bitmap10;
            button13.BackgroundImage = bitmap11;
            button14.BackgroundImage = bitmap12;
            button15.BackgroundImage = bitmap13;

            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            button15.BackgroundImageLayout = ImageLayout.Stretch;

            button2.Text = list1[0];
            button3.Text = list1[1];
            button4.Text = list1[2];
            button5.Text = list1[3];
            button6.Text = list1[4];
            button7.Text = list1[5];
            button8.Text = list1[6];
            button9.Text = list1[7];
            button10.Text = list1[8];
            button11.Text = list1[9];
            button12.Text = list1[10];
            button13.Text = list1[11];
            button14.Text = list1[12];
            button15.Text = list1[13];

            button2.Click += msghandler;
            button3.Click += msghandler;
            button4.Click += msghandler;
            button5.Click += msghandler;
            button6.Click += msghandler;
            button7.Click += msghandler;
            button8.Click += msghandler;
            button9.Click += msghandler;
            button10.Click += msghandler;
            button11.Click += msghandler;
            button12.Click += msghandler;
            button13.Click += msghandler;
            button14.Click += msghandler;
            button15.Click += msghandler;
        }
        private void msghandler(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;

            if (listBox1.Items.Count >= 3)
            {
                MessageBox.Show("소스를 세 개 이상 선택할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBox1.Items.Contains(text))
            {
                MessageBox.Show($"{text}은(는) 이미 추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 버튼이 눌렸을 때 처리하는 코드 (예: listBox1에 추가)
            listBox1.Items.Add(text);

            // 선택된 값 리스트에 추가
            selectedItems.Add(text);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // button1이 클릭되면 선택된 값들을 Form2로 전달하고 폼을 닫음
            SelectionCompleted?.Invoke(this, new SelectionCompletedEventArgs(selectedItems.ToArray()));
            this.Close();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 마우스 더블 클릭 시 선택된 야채를 리스트에서 제거
            if (listBox1.SelectedIndex != -1)
            {
                string selectedVegetable = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedVegetable);
                selectedItems.Remove(selectedVegetable);

                // 마우스 더블 클릭 시 selectedItems 리스트에서도 제거
            }
        }
        public class SelectionCompletedEventArgs : EventArgs
        {
            public string[] SelectedItems { get; }

            public SelectionCompletedEventArgs(string[] selectedItems)
            {
                SelectedItems = selectedItems;
            }
        }

        // Form6에서 발생시킬 이벤트
        public event EventHandler<SelectionCompletedEventArgs> SelectionCompleted;

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}