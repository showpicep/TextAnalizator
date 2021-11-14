using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TextAnalyzator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream =openFile.OpenFile()) != null)
                {
                string fileText = File.ReadAllText(openFile.FileName);
                richTextBox1.Text = fileText;
                }
                
            }
        }

        private string WordsCount()
        {
            int res = Regex.Split(richTextBox1.Text, @"\w+").Count() - 1;
            return "Кол-во слов: " + res + "\n" ;
        }

        // private string[] FrequentWord()
        //  {
        //     char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        //    string words = richTextBox1.Text;
        //
        //   string orderedWords = words
        //      .GroupBy(x => x)
        //      .Select(x => new {
        //          KeyField = x.Key,
        //         Count = x.Count()
        //     })
        //     .OrderByDescending(x => x.Count)
        //     .Take(10);    
        // }

        public Dictionary<string,int> FrequentWord()
        {
            string text = richTextBox1.Text;
            var delimiterChars = new char[] { ' ', ',', ':', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/', '-' };
            //return "oa";
            return text
                .Split(delimiterChars)
                .Where(x => x.Length > 0) // без данного условия почему то в тексте появляется "" и является самым частом символом 
                .Select(x => x.ToLower())
                .GroupBy(x => x)
                .Select(x => new { Word = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .Take(10)
                .ToDictionary(x => x.Word, x => x.Count);
        }
        private Dictionary<string, int> TheLongestWord()
        {
            string text = richTextBox1.Text;
            var delimiterChars = new char[] { ' ', ',', ':', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/', '-' };
            return text.Split(delimiterChars)
                .GroupBy(x => x)
                .Select(x => new {Word = x.Key, Length = x.Key.Length })
                .OrderByDescending(x => x.Length) //сортируем по убыванию длинны            
                .Take(10) //берем первую группу 
                .ToDictionary(x => x.Word, x => x.Length);
        }

        private string PrintFrequent()
        {
            Dictionary<string, int> help = FrequentWord();
            int count = 1;
            string res = "";
            foreach (KeyValuePair<string, int> keyValue in help)
            {
                if (count <= 9)
                    res += keyValue.Key + ": " + keyValue.Value + "\n";
                count++;
            }
            return res;
        }

        private string PrintTheLongestWord()
        {
            string res= "";
            Dictionary<string, int> help = TheLongestWord();
            int count = 1;

            foreach (KeyValuePair<string, int> keyValue in help)
            {
                if (count <= 10)
                    res += keyValue.Key + ": " + keyValue.Value + "\n";
                count++;
            }
            return res;
        }

        private string ProcentWords_2()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int words = Regex.Split(richTextBox1.Text, @"\p{L}").Count() - 1;
            string res = "";

            for (int i = 0; i < alphabet.Length; i++)
            {
                string pattern = "" + alphabet[i];
                double chisl = Regex.Split(richTextBox1.Text, pattern, RegexOptions.IgnoreCase).Count() - 1;
                res += alphabet[i] + ": " + Math.Round((chisl * 100 / words), 2) + "%\n";
            }
            return res;

        }
        private string ProcentWords()
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int words = Regex.Split(richTextBox1.Text, @"\p{L}").Count() - 1;
            string res = "";

            for (int i = 0; i < alphabet.Length; i++)
            {
                string pattern = "" + alphabet[i];
                double chisl = Regex.Split(richTextBox1.Text, pattern, RegexOptions.IgnoreCase).Count() - 1;
                res += alphabet[i] + ": " + Math.Round((chisl * 100 / words),2) + "%\n";
            }
            return res;
        }

        private string SymbolsCount()
        {
            int res = Regex.Split(richTextBox1.Text,@"\w").Count()-1;
            return "Кол-во символов: " + res;
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            
            Words.Text = WordsCount();
            Symbol.Text = SymbolsCount();
            prentashWords.Text = ProcentWords() + ProcentWords_2();
            FrequentTWORD.Text = PrintFrequent();
            tHeLonGestWORDS.Text = PrintTheLongestWord();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = "Result.txt";
            string res = "Кол-во слов в тексте: " + WordsCount()
                    + "\n Кол-во символов в тексет: " + SymbolsCount()
                    + "\n" + "Процентаж русских букв в тексте: \n" +ProcentWords() + "\n"
                    + "Процентаж английских букв в тексте: \n" + ProcentWords_2() + "\n"
                    + "10 самых частых слов в тексте: \n" + PrintFrequent() + "\n"
                    + "10 самых длинны слов в тексте: \n" + PrintTheLongestWord();
            File.WriteAllText(path, res);
            MessageBox.Show("Данные успешно записаны!");
        }
    }
}
