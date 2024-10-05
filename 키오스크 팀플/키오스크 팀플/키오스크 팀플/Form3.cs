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
    public partial class Form3 : Form
    {
        public event EventHandler<Form3EventArgs> SelectionCompleted;
        private string[] selectedValues = new string[] { "", "", "" };

        List<string> list1 = new List<string>();

        private int additional_price = 0;
        public Form3(string text)
        {
            InitializeComponent();
            label1.Text = text;

            selectedValues[0] = text;
            list1.Add("허니오트");
            list1.Add("위트");
            list1.Add("하티");
            list1.Add("파마산 오레가노");
            list1.Add("화이트");
            list1.Add("플랫브레드");
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"..\..\빵\허니오트.jpg");
            Bitmap bitmap1 = new Bitmap(@"..\..\빵\위트.jpg");
            Bitmap bitmap2 = new Bitmap(@"..\..\빵\하티.jpg");
            Bitmap bitmap3 = new Bitmap(@"..\..\빵\파마산 오레가노.jpg");
            Bitmap bitmap4 = new Bitmap(@"..\..\빵\화이트.jpg");
            Bitmap bitmap5 = new Bitmap(@"..\..\빵\플랫브레드.jpg");
            
            button5.BackgroundImage = bitmap;
            button6.BackgroundImage = bitmap1;
            button7.BackgroundImage = bitmap2;
            button8.BackgroundImage = bitmap3;
            button9.BackgroundImage = bitmap4;
            button10.BackgroundImage = bitmap5;
            
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            
            button5.Text = list1[0];
            button6.Text = list1[1];
            button7.Text = list1[2];
            button8.Text = list1[3];
            button9.Text = list1[4];
            button10.Text = list1[5];

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
            selectedValues[2]=text;
        }

        // 빵 길이, 토스팅 여부 선택 확인
        private bool RadioButtonSelected_1()
        {
            return radioButton1.Checked || radioButton2.Checked;
        }
        private bool RadioButtonSelected_2()
        {
            return radioButton3.Checked || radioButton4.Checked;
        }

        // Form3에서 Form2로 값을 전달하기 위한 EventArgs 클래스 정의
        public class Form3EventArgs : EventArgs
        {
            public List<string> SelectedItems { get; private set; }
            public int AdditionalPrice { get; private set; }

            public Form3EventArgs(List<string> selectedItems, int additionalPrice)
            {
                SelectedItems = selectedItems;
                AdditionalPrice = additionalPrice;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonSelected_1() && RadioButtonSelected_2())
            {
                SelectionCompleted?.Invoke(this, new Form3EventArgs(selectedValues.ToList(), additional_price));
                this.Close(); // Form3를 닫음
            }
            else if(RadioButtonSelected_1() == true && RadioButtonSelected_2() == false)
            {
                MessageBox.Show("토스팅 여부를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RadioButtonSelected_1() == false && RadioButtonSelected_2() == true)
            {
                MessageBox.Show("빵 길이를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("빵 길이를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedValues[0] = radioButton1.Text;
            additional_price = 0; // 추가 가격 설정
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedValues[0] = radioButton2.Text;
            additional_price = 4000; // 추가 가격 설정
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedValues[1] = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selectedValues[1] = radioButton4.Text;
        }
    }
}

