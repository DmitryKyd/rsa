using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace My_RSA
{
    public partial class Form1 : Form
    {
        public char[] Алфавит = new char[] {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 
                                            'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
                                            'э', 'ю', 'я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                            '8', '9', '0', ',', '.', '!', ':', ';', '-', '?'};


        public Form1()
        {
            InitializeComponent();
        }

        public long p;
        public long q;

        public int[] ПростыеЧисла = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            p = ПростыеЧисла[random.Next(0, ПростыеЧисла.Length)];
            ПолеP.Text = p.ToString();
            q = ПростыеЧисла[random.Next(0, ПростыеЧисла.Length)];
            ПолеQ.Text = q.ToString();
        }

        private void КнопкаСгенерировать_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            p = ПростыеЧисла[random.Next(0, ПростыеЧисла.Length)];
            ПолеP.Text = p.ToString();
            q = ПростыеЧисла[random.Next(0, ПростыеЧисла.Length)];
            ПолеQ.Text = q.ToString();
        }

        private void КнопкаЗашифровать_Click(object sender, EventArgs e)
        {
            if ((ПолеP.Text.Length > 0) && (ПолеQ.Text.Length > 0))
            {
                p = Convert.ToInt64(ПолеP.Text);
                q = Convert.ToInt64(ПолеQ.Text);

                if (ПроверкаПростоты(p) && ПроверкаПростоты(q))
                {
                    string s = "";
                    try
                    {
                        string Текст = Convert.ToString(Text1.Text);

                        s = Текст.ToString();

                        s = s.ToLower();

                        long n = p * q;
                        long m = (p - 1) * (q - 1);
                        long d = Вычисление_d(m);
                        long e_ = Вычисление_e(d, m);

                        List<string> result = RSA_Зашифровка(s, e_, n);
                        
                        StreamWriter sw = new StreamWriter("зашифрованый.txt");

                        foreach (string item in result)
                        {
                            sw.WriteLine(item);
                            for (long i = 0; i < item.Length; i++)
                            {
                                Text2.Text += item.ToString() + "\r\n";
                                i += 999999999999999999;
                            }

                        }
                        
                        sw.Close();

                        

                        ПолеD.Text = d.ToString();
                        ПолеN.Text = n.ToString();

                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Отсутствует файл для шифрования!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void КнопкаРасшифровать_Click(object sender, EventArgs e)
        {
            if ((ПолеD.Text.Length > 0) && (ПолеN.Text.Length > 0))
            {
                long d = Convert.ToInt64(ПолеD.Text);
                long n = Convert.ToInt64(ПолеN.Text);

                List<string> input = new List<string>();

                StreamReader sr = new StreamReader("зашифрованый.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());

                }

                sr.Close();

                string result = RSA_Расшифровка(input, d, n);

                StreamWriter sw = new StreamWriter("расшифрованый.txt");
                {
                    Text3.Text = result.ToString();
                    sw.WriteLine(result);
                }
                sw.Close();

            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }


        private bool ПроверкаПростоты(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        private List<string> RSA_Зашифровка(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(Алфавит, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        private string RSA_Расшифровка(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += Алфавит[index].ToString();
            }

            return result;
        }

        private long Вычисление_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        private long Вычисление_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        private void УдалитьДанныеText1_Click(object sender, EventArgs e)
        {
            Text1.Clear();
        }

        private void УдалитьДанныеText2_Click(object sender, EventArgs e)
        {
            Text2.Clear();
        }

        private void УдалитьДанныеText3_Click(object sender, EventArgs e)
        {
            Text3.Clear();
        }
    }
}
