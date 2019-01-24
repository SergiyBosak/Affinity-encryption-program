using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfinKriptografi
{
    public partial class MainForm : Form
    {
        static string alfavit = " .,:;123456789abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя" + Environment.NewLine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void bntGenerateKeys_Click(object sender, EventArgs e)
        {
            int a, b;
            do
            {
                Random rdm = new Random();

                a = rdm.Next(10, 10000);
                b = rdm.Next(10, 10000);
            }
            while (NOD(a, alfavit.Length) != 1);
            tKey1.Text = a.ToString();
            tKey2.Text = b.ToString();
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);

            return a;
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            if (!CheckParams())
                return;

            if (!EnterAlfavit(tMessageIn.Text))
                MessageBox.Show(this, "Введите текст из диапазона алфавита", "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int num = 0;

            if (!(int.TryParse(tKey1.Text, out num) && int.TryParse(tKey2.Text, out num)))
            {
                MessageBox.Show(this, "Ключи должны быть целыми взаимно простыми числами", "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string text = tMessageIn.Text;           

            int key1 = Convert.ToInt32(tKey1.Text);

            int key2 = Convert.ToInt32(tKey2.Text);

            if (!(NOD(key1, alfavit.Length) == 1))
            {
                MessageBox.Show(this, "Ключ 1 и длинна алфавита должны быть взаимно простыми числами", "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            text = Encode(text, key1, key2);

            tMessageOut.Text = text;            
        }

        private void btnDecript_Click(object sender, EventArgs e)
        {
            if (!CheckParams())
                return;

            string text = tMessageOut.Text;

            int key1 = Convert.ToInt32(tKey1.Text);

            int key2 = Convert.ToInt32(tKey2.Text);

            text = Decode(text, key1, key2);

            tMessageOut.Text = text;
        }

        private bool CheckParams()
        {
            string errors = null;

            if (tMessageIn.Text == string.Empty)
            {
                errors = "Введите текст сообщения\n";
            }

            if (tKey1.Text == string.Empty)
            {
                errors = errors + "Введите ключ 1\n";
            }

            if (tKey2.Text == string.Empty)
            {
                errors = errors + "Введите ключ 2\n";
            }

            if (errors != null)
            {
                MessageBox.Show(this, errors, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }

        static string AfinChits(string text, int a, int b, bool decode = false)
        {
            int textLen = text.Length;
            int alfavitLen = alfavit.Length;
            int index = 0;
            char[] result = new char[textLen];
            for (int i = 0; i < textLen; i++)
            {
                for (int j = 0; j < alfavitLen; j++)
                {
                    if (text[i] == alfavit[j])
                    {
                        if (decode)
                        {
                            index = (modInverse(a, alfavitLen) * (j - b)) % alfavitLen;
                            if (index < 0)
                                index = index + alfavitLen;
                        }
                        else
                            index = (a * j + b) % alfavitLen;
                        result[i] = (char)(result[i] + alfavit[index]);
                        break;
                    }
                }
            }
            return new string(result);
        }

        static string getText(string text)
        {
            string result = null;

            while (true)
            {
                result = enterText(text);

                if (EnterAlfavit(result))
                    break;

                Console.WriteLine("Not ");
            }

            return result;
        }

        static bool EnterAlfavit(string text)
        {
            bool textYes = false;
            for (int i = 0; i < text.Length; i++)
            {
                textYes = false;

                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (text[i] == alfavit[j])
                    {
                        textYes = true;
                        break;
                    }
                }
                if (!textYes)
                    break;
            }
            return textYes;
        }

        static string Encode(string text, int a, int b)
        {
            return AfinChits(text, a, b);
        }

        static string Decode(string text, int a, int b)
        {
            return AfinChits(text, a, b, true);
        }

        static string enterText(string text)
        {
            string result = null;

            do
                Console.WriteLine(text);
            while ((result = Console.ReadLine().Trim()) == string.Empty);

            return result;
        }

        static int enterNumber(string text)
        {
            int num = 0;

            do
                Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out num));

            return num;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tMessageIn.Clear();
            tMessageOut.Clear();
            tKey1.Clear();
            tKey2.Clear();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            tMessageIn.Clear();
            tMessageIn.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tMessageOut.Text == string.Empty) || (tMessageOut.Text == null))
            {
                MessageBox.Show(this, "Поле пустое", "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            Clipboard.SetText(tMessageOut.Text);
        }
    }
}
