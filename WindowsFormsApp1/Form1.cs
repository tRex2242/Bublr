using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void showNumbers(int[] numbers)
        {
            string name = "label";
            for (int i = 0; i < numbers.Length; i++)
            {
                Control cnt = this.Controls[name + (i + 1)];
                if (cnt != null)
                {
                    cnt.Text = numbers[i].ToString();
                }
            }
        }

        public int[] getNumbers()
        {
            string name = "label";
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Control cnt = this.Controls[name + (i + 1)];
                if (cnt != null)
                {
                    numbers[i] = Convert.ToInt32(cnt.Text);
                }
            }
            return numbers;
        }

        int[] generateNumbers()
        {
            int[] numbers = new int[4];
            Random random = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 1001);
            }
            return numbers;
        }

        void bubbleSort(int[] array)
        {
            bool swapped = true;
            for (int j = 0; (j < array.Length) && (swapped); j++)
            {
                swapped = false;
                for(int i = 1; i < array.Length - j; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        swapped = true;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = getNumbers();
            bubbleSort(numbers);
            showNumbers(numbers);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = generateNumbers();
            showNumbers(numbers);
        }
    }
}
