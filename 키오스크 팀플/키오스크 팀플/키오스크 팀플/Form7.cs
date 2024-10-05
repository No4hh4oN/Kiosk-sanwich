using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private CultureInfo currentCulture;
        public Form7()
        {
            InitializeComponent();
            currentCulture = CultureInfo.CurrentCulture;
        }

        private void OpenForm2()
        {
            this.Hide();
            Form2 newForm2 = new Form2();
            newForm2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            newForm2.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("직원을 호출하시겠습니까?", "직원 호출", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("직원을 호출했습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}