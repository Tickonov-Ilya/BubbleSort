using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubbblesort
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
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    ctn.Text = numbers[i].ToString();
                }

            }

        }
        public int[] getNumbers()
        {
            string name = "label";
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    numbers[i] = Convert.ToInt32(ctn.Text);
                }

            }
            return numbers;
        }
        int[] generateNumbers()
        {
            int[] numbers = new int[4];
            Random random = new Random();
            for (int i = 0;i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 251);
            }
            return numbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         int[] numbers = generateNumbers();
            showNumbers(numbers);
        }

        void bubbleSort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = getNumbers();
            bubbleSort(numbers);
            showNumbers(numbers);
        }
    }
}

