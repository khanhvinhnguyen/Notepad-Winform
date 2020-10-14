using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Find : Form
    {
        public Notepad ntp;
        public String findWord;
        public RichTextBox richTextBox;
        public int index = 0;
        public Find(RichTextBox richTextBox1)
        {
            InitializeComponent();
            richTextBox = richTextBox1;
        }

        private void btn_FindNext_Click(object sender, EventArgs e)
        {
            findWord = txb_Find.Text;
            FindWord(richTextBox);
        }
        #region "Close"
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            findWord = "";
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
            this.Close();
        }
        private void Find_FormClosed(object sender, FormClosedEventArgs e)
        {
            findWord = "";
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }
        #endregion
        #region "Prepare"
        public String getFindWord()
        {
            return findWord;
        }
        private void FindWord(RichTextBox rtb)
        {
            index = rtb.Text.IndexOf(getFindWord(), index);
            if (index != -1)
            {
                rtb.Select(index, getFindWord().Length);
                rtb.SelectionBackColor = Color.Yellow;
                index++;
            }
            else { MessageBox.Show("End of file"); index = 0; }
        }
        #endregion  
    }
}
