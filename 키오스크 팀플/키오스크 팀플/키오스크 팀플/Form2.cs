using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Dictionary<string, int> menu_dict = new Dictionary<string, int>();

        int all_payment;
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();


        public Form2()
        {
            InitializeComponent();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            
            list1.Add("스파이시 바비큐 샌드위치");
            list1.Add("스파이시 쉬림프 샌드위치");
            list1.Add("스파이시 이탈리안 샌드위치");
            list1.Add("스테이크 앤 치즈 샌드위치");
            list1.Add("치킨 베이컨 아보카드 샌드위치");
            list1.Add("쉬림프 샌드위치");
            list1.Add("로스트 치킨 샌드위치");
            list1.Add("K바비큐 샌드위치");
            list1.Add("로티세리 바비큐 치킨 샌드위치");
            list1.Add("풀드 포크 바비큐 샌드위치");
            list1.Add("Subway-Club™ 샌드위치");
            list1.Add("치킨 데리야끼 샌드위치");
            list1.Add("이탈리안 비엠티 샌드위치");
            list1.Add("B.L.T 샌드위치");
            list1.Add("치킨슬라이스 샌드위치");
            list1.Add("햄 샌드위치");

            list2.Add("스파이시 바비큐 샐러드");
            list2.Add("스파이시 쉬림프 샐러드");
            list2.Add("스파이시 이탈리안 샐러드");
            list2.Add("스테이크 앤 치즈 샐러드");
            list2.Add("치킨 베이컨 아보카드 샐러드");
            list2.Add("쉬림프 샐러드");
            list2.Add("로스트 치킨 샐러드");
            list2.Add("K바비큐 샐러드");
            list2.Add("로티세리 바비큐 치킨 샐러드");
            list2.Add("풀드 포크 바비큐 샐러드");
            list2.Add("Subway-Club™ 샐러드");
            list2.Add("치킨 데리야끼 샐러드");
            list2.Add("이탈리안 비엠티 샐러드");
            list2.Add("B.L.T 샐러드");
            list2.Add("치킨슬라이스 샐러드");
            list2.Add("햄 샐러드");

            list3.Add("탄산음료");
            list3.Add("커피");
            list3.Add("우유");
            list3.Add("더블초코칩");
            list3.Add("초코칩");
            list3.Add("라즈베리 치즈케익");
            list3.Add("화이트 초코 마카다미아");
            list3.Add("오트밀 레이즌");

            menu_dict.Add("스파이시 바비큐 샌드위치", 7500);
            menu_dict.Add("스파이시 쉬림프 샌드위치", 7900);
            menu_dict.Add("스파이시 이탈리안 샌드위치", 6900);
            menu_dict.Add("스테이크 앤 치즈 샌드위치", 7900);
            menu_dict.Add("치킨 베이컨 아보카드 샌드위치", 7900);
            menu_dict.Add("쉬림프 샌드위치", 7600);
            menu_dict.Add("로스트 치킨 샌드위치", 7300);
            menu_dict.Add("K바비큐 샌드위치", 7300);
            menu_dict.Add("로티세리 바비큐 치킨 샌드위치", 7300);
            menu_dict.Add("풀드 포크 바비큐 샌드위치", 7200);
            menu_dict.Add("Subway-Club™ 샌드위치", 7100);
            menu_dict.Add("치킨 데리야끼 샌드위치", 7000);
            menu_dict.Add("이탈리안 비엠티 샌드위치", 6700);
            menu_dict.Add("B.L.T 샌드위치", 6600);
            menu_dict.Add("치킨슬라이스 샌드위치", 6500);
            menu_dict.Add("햄 샌드위치", 5800);

            menu_dict.Add("스파이시 바비큐 샐러드", 9300);
            menu_dict.Add("스파이시 쉬림프 샐러드", 9700);
            menu_dict.Add("스파이시 이탈리안 샐러드", 8700);
            menu_dict.Add("스테이크 앤 치즈 샐러드", 9700);
            menu_dict.Add("치킨 베이컨 아보카드 샐러드", 9700);
            menu_dict.Add("쉬림프 샐러드", 9400);
            menu_dict.Add("로스트 치킨 샐러드", 9100);
            menu_dict.Add("K바비큐 샐러드", 9700);
            menu_dict.Add("로티세리 바비큐 치킨 샐러드", 9100);
            menu_dict.Add("풀드 포크 바비큐 샐러드", 9000);
            menu_dict.Add("Subway-Club™ 샐러드", 8900);
            menu_dict.Add("치킨 데리야끼 샐러드", 8800);
            menu_dict.Add("이탈리안 비엠티 샐러드", 8500);
            menu_dict.Add("B.L.T 샐러드", 8400);
            menu_dict.Add("치킨슬라이스 샐러드", 8300);
            menu_dict.Add("햄 샐러드", 7600);

            menu_dict.Add("탄산음료", 2000);
            menu_dict.Add("커피", 2500);
            menu_dict.Add("우유", 1500);
            menu_dict.Add("더블초코칩", 1300);
            menu_dict.Add("초코칩", 1300);
            menu_dict.Add("라즈베리 치즈케익", 1300);
            menu_dict.Add("화이트 초코 마카다미아", 1300);
            menu_dict.Add("오트밀 레이즌", 1300);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1_Click(button1, EventArgs.Empty);
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
            button16.Click += msghandler;
            button17.Click += msghandler;
            button18.Click += msghandler;
            button19.Click += msghandler;
            button20.Click += msghandler;
        }
        private void msghandler(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            listBox1.Items.Add($"{text}: {menu_dict[text]}원");
            if (list1.Contains(text))
            {
                
                // 등록된 이벤트 핸들러
                using (Form3 form3 = new Form3(text))
                {
                    // 등록된 이벤트 핸들러
                    form3.SelectionCompleted += (s, args) =>
                    {
                        string[] receivedData = args.SelectedItems.ToArray();
                        foreach (string item in receivedData)
                        {
                            listBox1.Items.Add("ㄴ"+item);
                        }
                        // 추가값을 받아서 더함
                        int additionalPrice = args.AdditionalPrice;
                        all_payment += additionalPrice;
                    };
                    this.Hide();
                    form3.ShowDialog();
                }
                using (Form4 form4 = new Form4(text))
                {
                    form4.CheeseSelectionCompleted += (s, args) =>
                    {
                        string selectedCheese = args.SelectedCheese;
                        listBox1.Items.Add("ㄴ치즈 : "+selectedCheese);
                    };

                    form4.ShowDialog();
                }
                using (Form5 form5 = new Form5(text))
                {
                    // Form5의 SelectionCompleted 이벤트 핸들러 추가
                    form5.SelectionCompleted += (s, args) =>
                    {
                        // Form5에서 전달된 값들을 listBox1에 추가
                        foreach (string item in args.SelectedItems)
                        {
                            listBox1.Items.Add("ㄴ야채 : "+item);
                        }
                    };
                    form5.ShowDialog();
                }
                using (Form6 form6 = new Form6(text))
                {
                    // Form6의 SelectionCompleted 이벤트 핸들러 추가
                    form6.SelectionCompleted += (s, args) =>
                    {
                        // Form6에서 전달된 값들을 listBox1에 추가
                        foreach (string item in args.SelectedItems)
                        {
                            listBox1.Items.Add("ㄴ소스 : " + item);
                        }
                    };
                    form6.ShowDialog();
                }
                this.Show();
            }
            all_payment += menu_dict[text];
        }
        //인기메뉴
        private void button1_Click(object sender, EventArgs e)
        {
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();

            Bitmap bitmap = new Bitmap(@"..\..\샌드위치 사진\0. 스파이시 바비큐.png");
            Bitmap bitmap1 = new Bitmap(@"..\..\샌드위치 사진\1. 스파이시 쉬림프.png");
            Bitmap bitmap2 = new Bitmap(@"..\..\샌드위치 사진\2. 스파이시 이탈리안.png");
            Bitmap bitmap3 = new Bitmap(@"..\..\샐러드\0. 스파이시 바비큐.png");
            Bitmap bitmap4 = new Bitmap(@"..\..\샐러드\1. 스파이시 쉬림프.png");
            Bitmap bitmap5 = new Bitmap(@"..\..\샐러드\2. 스파이시 이탈리안.png");
            Bitmap bitmap6 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\0. 탄산음료.png");
            Bitmap bitmap7 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\3. double_chocolate_chip.jpg");
            button5.BackgroundImage = bitmap;
            button6.BackgroundImage = bitmap1;
            button7.BackgroundImage = bitmap2;
            button8.BackgroundImage = bitmap3;
            button9.BackgroundImage = bitmap4;
            button10.BackgroundImage = bitmap5;
            button11.BackgroundImage = bitmap6;
            button12.BackgroundImage = bitmap7;

            button5.Text = list1[0];
            button6.Text = list1[1];
            button7.Text = list1[0];
            button8.Text = list1[1];
            button9.Text = list2[1];
            button10.Text = list2[2];
            button11.Text = list3[0];
            button12.Text = list3[3];
        }

        //샌드위치
        private void button2_Click(object sender, EventArgs e)
        {
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            Bitmap bitmap = new Bitmap(@"..\..\샌드위치 사진\0. 스파이시 바비큐.png");
            Bitmap bitmap1 = new Bitmap(@"..\..\샌드위치 사진\1. 스파이시 쉬림프.png");
            Bitmap bitmap2 = new Bitmap(@"..\..\샌드위치 사진\2. 스파이시 이탈리안.png");
            Bitmap bitmap3 = new Bitmap(@"..\..\샌드위치 사진\3. 스테이크 앤드 치즈.png");
            Bitmap bitmap4 = new Bitmap(@"..\..\샌드위치 사진\4. 치킨베이컨아보카도샌드위치.png");
            Bitmap bitmap5 = new Bitmap(@"..\..\샌드위치 사진\5. 쉬림프.png");
            Bitmap bitmap6 = new Bitmap(@"..\..\샌드위치 사진\6. 로스트 치킨.png");
            Bitmap bitmap7 = new Bitmap(@"..\..\샌드위치 사진\7. 로티세리 바비큐 치킨.png");
            Bitmap bitmap8 = new Bitmap(@"..\..\샌드위치 사진\8. K바비큐.png");
            Bitmap bitmap9 = new Bitmap(@"..\..\샌드위치 사진\9. Pulled-Pork+cheese.png");
            Bitmap bitmap10 = new Bitmap(@"..\..\샌드위치 사진\10. Subway-Club™.png");
            Bitmap bitmap11 = new Bitmap(@"..\..\샌드위치 사진\11. 치킨 데리야끼.png");
            Bitmap bitmap12 = new Bitmap(@"..\..\샌드위치 사진\12. Italian_B.M.T.png");
            Bitmap bitmap13 = new Bitmap(@"..\..\샌드위치 사진\13. B.L.T.png");
            Bitmap bitmap14 = new Bitmap(@"..\..\샌드위치 사진\14. 치킨슬라이스샌드위치.png");
            Bitmap bitmap15 = new Bitmap(@"..\..\샌드위치 사진\15. 햄.png");

            button5.BackgroundImage = bitmap;
            button6.BackgroundImage = bitmap1;
            button7.BackgroundImage = bitmap2;
            button8.BackgroundImage = bitmap3;
            button9.BackgroundImage = bitmap4;
            button10.BackgroundImage = bitmap5;
            button11.BackgroundImage = bitmap6;
            button12.BackgroundImage = bitmap7;
            button13.BackgroundImage = bitmap8;
            button14.BackgroundImage = bitmap9;
            button15.BackgroundImage = bitmap10;
            button16.BackgroundImage = bitmap11;
            button17.BackgroundImage = bitmap12;
            button18.BackgroundImage = bitmap13;
            button19.BackgroundImage = bitmap14;
            button20.BackgroundImage = bitmap15;


            button5.Text = list1[0];
            button6.Text = list1[1];
            button7.Text = list1[2];
            button8.Text = list1[3];
            button9.Text = list1[4];
            button10.Text = list1[5];
            button11.Text = list1[6];
            button12.Text = list1[7];
            button13.Text = list1[8];
            button14.Text = list1[9];
            button15.Text = list1[10];
            button16.Text = list1[11];
            button17.Text = list1[12];
            button18.Text = list1[13];
            button19.Text = list1[14];
            button20.Text = list1[15];
        }
        //샐러드
        private void button3_Click(object sender, EventArgs e)
        {
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            Bitmap bitmap = new Bitmap(@"..\..\샐러드\0. 스파이시 바비큐.png");
            Bitmap bitmap1 = new Bitmap(@"..\..\샐러드\1. 스파이시 쉬림프.png");
            Bitmap bitmap2 = new Bitmap(@"..\..\샐러드\2. 스파이시 이탈리안.png");
            Bitmap bitmap3 = new Bitmap(@"..\..\샐러드\3. 스테이크 앤드 치즈.png");
            Bitmap bitmap4 = new Bitmap(@"..\..\샐러드\4. 치킨 베이컨 아보카도.png");
            Bitmap bitmap5 = new Bitmap(@"..\..\샐러드\5. 쉬림프.png");
            Bitmap bitmap6 = new Bitmap(@"..\..\샐러드\6. 로스트 치킨.png");
            Bitmap bitmap7 = new Bitmap(@"..\..\샐러드\7. 로티세리 바비큐 치킨.png");
            Bitmap bitmap8 = new Bitmap(@"..\..\샐러드\8. K바비큐.png");
            Bitmap bitmap9 = new Bitmap(@"..\..\샐러드\9. 풀드 포크 바비큐.png");
            Bitmap bitmap10 = new Bitmap(@"..\..\샐러드\10. Subway Club™.png");
            Bitmap bitmap11 = new Bitmap(@"..\..\샐러드\11. 치킨데리야키.png");
            Bitmap bitmap12 = new Bitmap(@"..\..\샐러드\12. 이탈리안 비엠티.png");
            Bitmap bitmap13 = new Bitmap(@"..\..\샐러드\13. B.L.T.png");
            Bitmap bitmap14 = new Bitmap(@"..\..\샐러드\14. 치킨 슬라이스.png");
            Bitmap bitmap15 = new Bitmap(@"..\..\샐러드\15. 햄.png");

            button5.BackgroundImage = bitmap;
            button6.BackgroundImage = bitmap1;
            button7.BackgroundImage = bitmap2;
            button8.BackgroundImage = bitmap3;
            button9.BackgroundImage = bitmap4;
            button10.BackgroundImage = bitmap5;
            button11.BackgroundImage = bitmap6;
            button12.BackgroundImage = bitmap7;
            button13.BackgroundImage = bitmap8;
            button14.BackgroundImage = bitmap9;
            button15.BackgroundImage = bitmap10;
            button16.BackgroundImage = bitmap11;
            button17.BackgroundImage = bitmap12;
            button18.BackgroundImage = bitmap13;
            button19.BackgroundImage = bitmap14;
            button20.BackgroundImage = bitmap15;

            button5.Text = list2[0];
            button6.Text = list2[1];
            button7.Text = list2[2];
            button8.Text = list2[3];
            button9.Text = list2[4];
            button10.Text = list2[5];
            button11.Text = list2[6];
            button12.Text = list2[7];
            button13.Text = list2[8];
            button14.Text = list2[9];
            button15.Text = list2[10];
            button16.Text = list2[11];
            button17.Text = list2[12];
            button18.Text = list2[13];
            button19.Text = list2[14];
            button20.Text = list2[15];
        }

        //음료 및 쿠키
        private void button4_Click(object sender, EventArgs e)
        {
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();

            Bitmap bitmap = new Bitmap(@"..\..\추가선택(쿠키, 음료)\0. 탄산음료.png");
            Bitmap bitmap1 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\1. 커피.jpg");
            Bitmap bitmap2 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\2. 우유.jpg");
            Bitmap bitmap3 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\3. double_chocolate_chip.jpg");
            Bitmap bitmap4 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\4. chocolate_chip.jpg");
            Bitmap bitmap5 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\5. raspberry_cheese_cake.jpg");
            Bitmap bitmap6 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\6. white_choco_macadamia.jpg");
            Bitmap bitmap7 = new Bitmap(@"..\..\추가선택(쿠키, 음료)\7. oatmeal_rasin.jpg");

            button5.BackgroundImage = bitmap;
            button6.BackgroundImage = bitmap1;
            button7.BackgroundImage = bitmap2;
            button8.BackgroundImage = bitmap3;
            button9.BackgroundImage = bitmap4;
            button10.BackgroundImage = bitmap5;
            button11.BackgroundImage = bitmap6;
            button12.BackgroundImage = bitmap7;

            button5.Text = list3[0];
            button6.Text = list3[1];
            button7.Text = list3[2];
            button8.Text = list3[3];
            button9.Text = list3[4];
            button10.Text = list3[5];
            button11.Text = list3[6];
            button12.Text = list3[7];
        }
        //주문 취소
        /*
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(':');

                if (parts.Length == 2)
                {
                    string itemName = parts[0].Trim();
                    string itemPriceString = parts[1].Replace("원", "").Trim();

                    if (int.TryParse(itemPriceString, out int itemPrice))
                    {
                        DialogResult result = MessageBox.Show($"{itemName} 주문을 취소하시겠습니까?", "주문 취소 확인", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.OK)
                        {
                            // 주문 취소가 확인되면 해당 항목 제거 및 결제금액 조정
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                            all_payment -= itemPrice;
                        }
                    }
                }
            }
        }
        */
        private void button22_Click(object sender, EventArgs e)
        {
            all_payment = 0;
            listBox1.Items.Clear();
        }

        //결제창
        private void button21_Click(object sender, EventArgs e)
        {
            if (all_payment == 0)
            {
                MessageBox.Show("상품을 선택해주세요.", "확인", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("총 결제 금액 : " + all_payment + "원", "결제 확인", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    OpenForm8();
                }
            }
        }
        private void OpenForm8()
        {
            this.Hide();
            Form8 newForm8 = new Form8();
            newForm8.FormClosed += new FormClosedEventHandler(Form8_FormClosed);
            newForm8.ShowDialog();
        }
        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
