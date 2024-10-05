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
    public partial class Form5 : Form
    {
        List<string> list1 = new List<string>();
        List<string> selectedItems = new List<string>();
        public Form5(string text)
        {
            InitializeComponent();

            label1.Text = text;

            list1.Add("양상추");
            list1.Add("토마토");
            list1.Add("오이");
            list1.Add("피망");
            list1.Add("양파");
            list1.Add("피클");
            list1.Add("올리브");
            list1.Add("할라피뇨");
            list1.Add("아보카도");
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"..\..\야채\양상추.jpg");
            Bitmap bitmap1 = new Bitmap(@"..\..\야채\토마토.jpg");
            Bitmap bitmap2 = new Bitmap(@"..\..\야채\오이.jpg");
            Bitmap bitmap3 = new Bitmap(@"..\..\야채\피망.jpg");
            Bitmap bitmap4 = new Bitmap(@"..\..\야채\양파.jpg");
            Bitmap bitmap5 = new Bitmap(@"..\..\야채\피클.jpg");
            Bitmap bitmap6 = new Bitmap(@"..\..\야채\올리브.jpg");
            Bitmap bitmap7 = new Bitmap(@"..\..\야채\할라피뇨.jpg");
            Bitmap bitmap8 = new Bitmap(@"..\..\야채\아보카도1.jpg");

            button2.BackgroundImage = bitmap;
            button3.BackgroundImage = bitmap1;
            button4.BackgroundImage = bitmap2;
            button4.BackgroundImage = bitmap2;
            button5.BackgroundImage = bitmap3;
            button6.BackgroundImage = bitmap4;
            button7.BackgroundImage = bitmap5;
            button8.BackgroundImage = bitmap6;
            button9.BackgroundImage = bitmap7;
            button10.BackgroundImage = bitmap8;

            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button10.BackgroundImageLayout = ImageLayout.Stretch;

            button2.Text = list1[0];
            button3.Text = list1[1];
            button4.Text = list1[2];
            button5.Text = list1[3];
            button6.Text = list1[4];
            button7.Text = list1[5];
            button8.Text = list1[6];
            button9.Text = list1[7];
            button10.Text = list1[8];

            button2.Click += msghandler;
            button3.Click += msghandler;
            button4.Click += msghandler;
            button5.Click += msghandler;
            button6.Click += msghandler;
            button7.Click += msghandler;
            button8.Click += msghandler;
            button9.Click += msghandler;
            button10.Click += msghandler;
        }
        private void msghandler(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;

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
        private void button1_Click(object sender, EventArgs e)
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
        // Form5에서 전달할 값들을 담은 이벤트 아규먼트 클래스
        public class SelectionCompletedEventArgs : EventArgs
        {
            public string[] SelectedItems { get; }

            public SelectionCompletedEventArgs(string[] selectedItems)
            {
                SelectedItems = selectedItems;
            }
        }

        // Form5에서 발생시킬 이벤트
        public event EventHandler<SelectionCompletedEventArgs> SelectionCompleted;

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
