using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /// <summary>
    /// Главный класс-форма MainForm
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор класса-формы MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Шифрование с помощью
        /// магического квадрата
        /// </summary>
        /// <param name="str">Переданная строка</param>
        /// <returns>Зашифрованная строка</returns>
        public string ShifrSquare(string str)
        {
            if (str.Length != 16)
            {
                return "Неверная строка\nВведите строку из 16 символов\nВы ввели строку c длиной: " + str.Length;
            }
            int i = 0;
            int j = 0;
            string res = "";
            while (i < magicSquare.GetLength(0))
            {
                while (j < magicSquare.GetLength(1))
                {
                    res += str[magicSquare[i, j] - 1];
                    j += 1;
                }
                j = 0;
                i += 1;
            }
            return res;
        }
        /// <summary>
        /// Дешифрование с помощью
        /// магического квадрата
        /// </summary>
        /// <param name="str">Зашифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string DeshifrSquare(string str)
        {
            int i = 0; int j = 0; int m = 0; int n = 0; int f = 0;
            int k = 0;
            char[,] shifr = new char[4, 4];
            while (n < magicSquare.GetLength(0))
            {
                while (f < magicSquare.GetLength(1))
                {
                    shifr[n, f] = str[k];
                    f += 1;
                    k++;
                }
                f = 0;
                n += 1;
            }
            i = 0;
            j = 0;
            string deshifr = "";
            while (m <= str.Length)
            {
                while (i < magicSquare.GetLength(0))
                {
                    while (j < magicSquare.GetLength(1))
                    {
                        if (magicSquare[i, j] == m)
                        {
                            deshifr += shifr[i, j];
                        }
                        j += 1;
                    }
                    i += 1;
                    j = 0;
                }
                i = 0;
                m += 1;
            }
            return deshifr;
        }
        /// <summary>
        /// Магический квадрат 4х4
        /// Следовательно шифруемые
        /// и дешифруемые сообщения должны
        /// состоять из 16 символов
        /// </summary>
        public int[,] magicSquare = new int[4, 4] { { 16, 3, 2, 13 }, { 5, 10, 11, 8 }, { 9, 6, 7, 12 }, { 4, 15, 14, 1 } };
        /// <summary>
        /// Алфавит для шифрования-дешифрования с помощью шифра Цезаря
        /// </summary>
        private const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        /// <summary>
        /// Метод для шифрования-дешифрования текста с помощью шифра Цезаря
        /// </summary>
        /// <param name="text">Шифруемый-дешифруемый текст</param>
        /// <param name="step">Ключ</param>
        /// <returns>Зашифрованный-расшифрованный текст</returns>
        private string CodeEncode(string text, int step)
        {
            string fullAlfabet = alfabet + alfabet.ToLower();
            int length = fullAlfabet.Length;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                int index = fullAlfabet.IndexOf(letter);
                if (index < 0)
                {
                    result += letter.ToString();
                }
                else
                {
                    int newIndex = (length + index + step) % length;
                    result += fullAlfabet[newIndex];
                }
            }

            return result;
        }
        /// <summary>
        /// Метод, вызываемый при нажатии на кнопку шифрования шифром Цезаря
        /// </summary>
        /// <param name="sender">Текущий объект</param>
        /// <param name="e">Событие</param>
        private void ButtonEncryptCaesar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDecrypt.Text = CodeEncode(richTextBoxEncrypt.Text, Convert.ToInt32(textBoxKey.Text));
                if (richTextBoxDecrypt.Text == richTextBoxEncrypt.Text)
                {
                    richTextBoxDecrypt.Text = "";
                    MessageBox.Show("Введите текст на русском языке!");
                }
            }
            catch
            {
                MessageBox.Show("Введите ключ для шифра Цезаря!");
            }
        }
        /// <summary>
        /// Метод, вызываемый при нажатии на кнпоку шифрования с помощью квадрата Полибия
        /// </summary>
        /// <param name="sender">Текущий объект</param>
        /// <param name="e">Событие</param>
        private void ButtonEncryptPol_Click(object sender, EventArgs e)
        {
            richTextBoxDecrypt.Text = ShifrSquare(richTextBoxEncrypt.Text);
        }
        /// <summary>
        /// Метод, вызываемый при нажатии на кнопку дешифрования шифром Цезаря
        /// </summary>
        /// <param name="sender">Текущий объект</param>
        /// <param name="e">Событие</param>
        private void ButtonDecryptCaesar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxEncrypt.Text = CodeEncode(richTextBoxDecrypt.Text, -Convert.ToInt32(textBoxKey.Text));
                if (richTextBoxEncrypt.Text == richTextBoxDecrypt.Text)
                {
                    richTextBoxEncrypt.Text = "";
                    MessageBox.Show("Введите текст на русском языке!");
                }
            }
            catch
            {
                MessageBox.Show("Введите ключ для шифра Цезаря!");
            }
        }
        /// <summary>
        /// Метод, вызываемый при нажатии на кнпоку дешифрования с помощью квадрата Полибия
        /// </summary>
        /// <param name="sender">Текущий объект</param>
        /// <param name="e">Событие</param>
        private void ButtonDecryptPol_Click(object sender, EventArgs e)
        {
                richTextBoxEncrypt.Text = DeshifrSquare(richTextBoxDecrypt.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxEncrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCaesar_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEncrypt_Click(object sender, EventArgs e)
        {

        }
    }
}
