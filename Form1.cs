using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using System.Text;

namespace RSA.Algoritmas
{
    public partial class Form1 : Form
    {
        private Encoding encoding = Encoding.Unicode;

        public Form1()
        {
            InitializeComponent();
            PTextBox.Text = "61";
            QTextBox.Text = "53";
            //TextTextBox.Text = "Sveikas Lukai (~!@#$%^&*())!";
            TextTextBox.Text = "Sveikas!";
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try 
            {
                EncryptedTextBox.Clear();
                validationBeforeEncrypt();
                encryptionFunc(int.Parse(PTextBox.Text), int.Parse(QTextBox.Text), TextTextBox.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptedTextBox.Clear();
                validationBeforeDecrypt();
                decryptionFunc(int.Parse(PTextBox.Text), int.Parse(QTextBox.Text), EncryptedTextBox.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void validationBeforeEncrypt()
        {

        }

        private void validationBeforeDecrypt()
        {

        }

        private void encryptionFunc(int p, int q, string plainText)
        {
            // count n
            int n = p * q;
            Console.WriteLine($"n = {n}");

            //count fi
            int fi = (p - 1) * (q - 1);
            Console.WriteLine($"fi = {fi}");

            //find co-prime
            int e = findCoPrime(fi);
            Console.WriteLine($"e = {e}");

            //find d
            int d = dFindFunc(e, fi);
            Console.WriteLine($"d = {d}");

            encryptText(n, e, plainText);
        }

        private void decryptionFunc(int p, int q, string cyphText)
        {
            // count n
            int n = p * q;
            Console.WriteLine($"n = {n}");

            //count fi
            int fi = (p - 1) * (q - 1);
            Console.WriteLine($"fi = {fi}");

            //find co-prime
            int e = findCoPrime(fi);
            Console.WriteLine($"e = {e}");

            //find d
            int d = dFindFunc(e, fi);
            Console.WriteLine($"d = {d}");

            decryptText(n, d, cyphText);
        }

        private void decryptText(int n, int d, string cyphText)
        {
            foreach (int temp in getTextInts(cyphText))
            {
                Console.WriteLine(BigInteger.Pow(temp, d) % n);
                DecryptedTextBox.Text += (char)(BigInteger.Pow(temp, d) % n);
            }
        }

        private void encryptText(int n, int e, string plainText)
        {
            foreach (int temp in getTextInts(plainText))
            {
                Console.WriteLine(Math.Pow(temp, e) % n);
                EncryptedTextBox.Text += (char)(Math.Pow(temp, e) % n);
            }
        }

        private List<int> getTextInts(string text)
        {
            List<int> intList = new List<int>();
            foreach(char bt in text)
            {
                intList.Add(bt);
            }
            return intList;
        }

        private int dFindFunc(int e, int fi)
        {
            int d = 1;
            while((d * e) % fi != 1)
            {
                d++;
            }
            return d;
        }

        private int findCoPrime(int fi)
        {
            int res = 0;
            int j = fi - 1;
            while (j > 1)
            {
                if (DBD(fi, j) == 1)
                    res = j;

                j--;
            }
            return res;
        }

        private int DBD(int fi, int j)
        {
            if (j != 0)
                return DBD(j, fi % j);
            else
                return fi;
        }
    }
}
