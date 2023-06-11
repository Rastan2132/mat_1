using System;
using System.Windows.Forms;

namespace mat_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private void PrimeFactorization(int n, Label label1)
        {
            string factorsString = "";

            if (IsPrime(n))
            {
                factorsString = "Liczba " + n + " jest liczbą pierwszą.";
            }
            else
            {
                int factor = 2;

                while (n > 1)
                {
                    if (n % factor == 0)
                    {
                        factorsString += factor.ToString() + " ";
                        n /= factor;
                    }
                    else
                    {
                        factor++;
                    }
                }
            }

            label1.Text = "Rozłożenie liczby " + n + " na czynniki: " + factorsString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            int number;
            if (int.TryParse(cueTextBox1.Text, out number))
            {
                PrimeFactorization(number, label1);
            }
            else
            {
                label1.Text = "Nieprawidłowa liczba!";
            }
        }
    }
}
