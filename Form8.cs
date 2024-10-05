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
    public partial class Form8 : Form
    {
        private Form1 form1;

        public Form8()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button2.Click += creditCardPaymentButton_Click;
            button3.Click += creditCardPaymentButton_Click;
            button4.Click += creditCardPaymentButton_Click;
            button5.Click += creditCardPaymentButton_Click;
            button6.Click += creditCardPaymentButton_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("현금 결제 하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("현금을 투입하세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                DialogResult receiptResult = MessageBox.Show("현금 영수증을 출력하시겠습니까?", "출력 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (receiptResult == DialogResult.Yes)
                {
                    
                    MessageBox.Show("현금 영수증을 출력합니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                }

                MessageBox.Show("감사합니다. 주문표를 받아가세요.", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ShowForm1();
            }
            else
            {
                
            }
        }

        private void creditCardPaymentButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                DialogResult paymentResult = MessageBox.Show("결제하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (paymentResult == DialogResult.Yes)
                {
                    MessageBox.Show("카드를 리더기에 삽입해주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult receiptResult = MessageBox.Show("영수증을 출력하시겠습니까?", "출력 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (receiptResult == DialogResult.Yes)
                    {
                        MessageBox.Show("영수증을 출력합니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                    }

                    MessageBox.Show("감사합니다. 주문표를 받아가세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowForm1();
                }
                else
                {
                    
                }
            }
        }

        private void ShowForm1()
        {
            this.Close();
        }
    }
}