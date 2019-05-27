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
using System.Speech;
using System.Speech.Synthesis;

namespace MyDictionary
{
    public partial class MyDictionary : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public MyDictionary()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Adding.Visible = false;
            bool IsExist = false;
            if (word.Text == "" || word.Text == " " || word.Text == "  ")
            {
                MessageBox.Show("Please Enter Your Word Before Searching", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Word = word.Text;
                string NewWord = Word.ToLower();
                string[] st = File.ReadAllLines("MyDictionary.txt");
                FileStream fs = new FileStream("MyDictionary.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                int i = 0;
                while (i < st.Length)
                {
                    i++;
                    string[] s = sr.ReadLine().Split(':');
                    if (s[0] == NewWord)
                    {
                        Meaning.Text = s[1];
                        IsExist = true;
                        break;
                    }
                    else
                        continue;

                }
                sr.Close();
                fs.Close();
                if (IsExist == false)
                {
                    Meaning.Text = "None";
                    MessageBox.Show("The Meaning of This Word IS Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Do You Need To Add The Meaning of This In The Dictionary", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        bunifuTransition1.ShowSync(Adding);
                    }

                }
            }
        }

        private void word_sound_Click(object sender, EventArgs e)
        {
            if (word.Text != "" || word.Text != " ")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(word.Text);
            }
            else
            {
                MessageBox.Show("No Words Found!!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void meaning_sound_Click(object sender, EventArgs e)
        {
            if (Meaning.Text != "" || Meaning.Text != " ")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(Meaning.Text);
            }
            else
            {
                MessageBox.Show("No Words Found!!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("MyDictionary.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string s = "";
            s += word.Text;
            s += ": ";
            s += MeaninigNeeded.Text;
            char[] st = new char[s.Length];
            s.CopyTo(0, st, 0, st.Length);
            sw.WriteLine(st);
            MessageBox.Show("The Word and It's Meaning Is Successfully Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Adding.Visible = false;
            sw.Close();
            fs.Close();
        }

        private void exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
