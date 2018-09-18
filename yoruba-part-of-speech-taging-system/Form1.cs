using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoruba_part_of_speech_taging_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taggingbox.Clear();
        }


        private List<string> ParseInput(String allInput)
        {
            List<string> listSentence = new List<string>();

            char[] delimiter = ";".ToCharArray();
            var sentences = allInput.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());

            foreach (var s in sentences)
                listSentence.Add(s);

            return listSentence;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string allInput = taggingbox.Text;

            List<string> listWord = new List<string>();
            List<string> listSentence = new List<string>();

            HashSet<string> nounList = new HashSet<string>(getDBList("nounList.txt"));
            HashSet<string> verbList = new HashSet<string>(getDBList("verbList.txt"));
            HashSet<string> adjectiveList = new HashSet<string>(getDBList("adjectiveList.txt"));
            HashSet<string> adverbList = new HashSet<string>(getDBList("adverbList.txt"));

            char[] separator = new char[] { ' ', '\t', '\n', ','};

            listSentence = ParseInput(allInput);                                                                                                                                                                                                                                                          

            foreach (string sentence in listSentence)
            {
                foreach (string word in sentence.Split(separator))
                    if (word.Trim() != "")
                        listWord.Add(word);
            }

            string testPOS = "";

            foreach (string word in listWord)
            {
                if (nounList.Contains(word.ToLowerInvariant()))
                    testPOS += "noun ";
                else if (verbList.Contains(word.ToLowerInvariant()))
                    testPOS += "verb ";
                else if (adjectiveList.Contains(word.ToLowerInvariant()))
                    testPOS += "adj ";
                else if (adverbList.Contains(word.ToLowerInvariant()))
                    testPOS += "adv ";

            }
                 tokenbox.Text = testPOS;
        //  dataGridView1 = testPOS; 
        }

        private IEqualityComparer<string> getDBList(string v)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    private IEqualityComparer<string> getDBList(string v)
        {
            throw new NotImplementedException();
        }
    }
}