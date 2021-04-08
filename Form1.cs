using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using System.IO;

namespace RSA.Algoritmas
{
    public partial class Form1 : Form
    {
        private string folder = @"C:\Users\valde\source\repos\RSA.Algoritmas\bin\Debug\";
        private string fileName = "encrypted.txt";

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
                decryptionFunc();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void validationBeforeEncrypt()
        {
            checkPAndQ();
            if(String.IsNullOrEmpty(TextTextBox.Text) == true || String.IsNullOrWhiteSpace(TextTextBox.Text) == true)
                throw new Exception("Text to encrypt must not be empty!");
        }

        private void checkPAndQ()
        {
            if (String.IsNullOrEmpty(PTextBox.Text) == true || String.IsNullOrWhiteSpace(PTextBox.Text) == true)
                throw new Exception("P value must not be empty!");
            if (String.IsNullOrEmpty(QTextBox.Text) == true || String.IsNullOrWhiteSpace(QTextBox.Text) == true)
                throw new Exception("Q value must not be empty!");
            try{ int.Parse(PTextBox.Text); }
                catch{ throw new Exception("P value must be number!"); }
            try{ int.Parse(QTextBox.Text); }
                catch{ throw new Exception("Q value must be number!"); }
            if(int.Parse(PTextBox.Text) == 0)
                throw new Exception("P number must be prime!");
            if (int.Parse(QTextBox.Text) == 0)
                throw new Exception("Q number must be prime!");
            for (int i = 2; i < int.Parse(PTextBox.Text); i++)
                if (int.Parse(PTextBox.Text) % i == 0)
                    throw new Exception("P number must be prime!");
            for (int i = 2; i < int.Parse(QTextBox.Text); i++)
                if (int.Parse(QTextBox.Text) % i == 0)
                    throw new Exception("Q number must be prime!");
        }

        private void validationBeforeDecrypt()
        {
            //checkPAndQ();
           // if (String.IsNullOrEmpty(EncryptedTextBox.Text) == true || String.IsNullOrWhiteSpace(EncryptedTextBox.Text) == true)
               // throw new Exception("Text to decrypt must not be empty!");
        }

        private void encryptionFunc(int p, int q, string plainText)
        {
            // count n
            int n = p * q;
            //Console.WriteLine($"n = {n}");

            //count fi
            int fi = (p - 1) * (q - 1);
            //Console.WriteLine($"fi = {fi}");

            //find co-prime
            int e = findCoPrime(fi);
            //Console.WriteLine($"e = {e}");

            encryptText(n, e, plainText);
        }

        private void encryptText(int n, int e, string plainText)
        {
            string encryptedText = null;
            foreach (int temp in getTextInts(plainText))
            {
                //Console.WriteLine(Math.Pow(temp, e) % n);
                encryptedText += (char)(Math.Pow(temp, e) % n);
            }
            EncryptedTextBox.Text = encryptedText;
            string toFile = $"{n}\n{e}\n{encryptedText}";

            string fullPath = folder + fileName;
            File.WriteAllText(fullPath, toFile);
        }

        private void decryptionFunc()
        {
            int n;
            int e;
            string encryptedText = null;
            string[] allLinesText;
            string fullPath = folder + fileName;
            try
            {
                try
                {
                    allLinesText = File.ReadAllLines(fullPath);
                }
                catch
                {
                    throw new Exception("File couldn't be found, try to encrypt some text!");
                }
                try 
                {
                    //Console.WriteLine(allLinesText.Length);
                    n = int.Parse(allLinesText[0]);
                    e = int.Parse(allLinesText[1]);
                    for(int i = 2; i < allLinesText.Length; i++)
                    {
                        encryptedText += allLinesText[i];
                    }
                }
                catch
                {
                    throw new Exception("File is corrupted!");
                }
            }
            catch(Exception exc)
            {
                throw new Exception(exc.Message);
            }

            int p = findP(n);
            int q = n / p;
            //count fi
            int fi = (p - 1) * (q - 1);
            //find d
            int d = dFindFunc(e, fi);

            decryptText(n, d, encryptedText);
        }

        private int findP(int n)
        {
            int p = 2;
            while(n % p != 0)
            {
                p++;
            }
            return p;
        }

        private void decryptText(int n, int d, string cyphText)
        {
            foreach (int temp in getTextInts(cyphText))
            {
                //Console.WriteLine(BigInteger.Pow(temp, d) % n);
                DecryptedTextBox.Text += (char)(BigInteger.Pow(temp, d) % n);
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
            int d = 2;
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
