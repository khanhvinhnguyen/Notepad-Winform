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
    public partial class Replace : Form
    {
        public Notepad ntp;
        public Find find;
        public String fstring;
        public String freplace;
        public RichTextBox richTextBox;
        public int index = 0;
        public Replace(RichTextBox richTextBox1)
        {
            InitializeComponent();
            richTextBox = richTextBox1;
        }

        #region "Find"
        private void btn_Find_Click(object sender, EventArgs e)
        {
            fstring = txb_Find.Text;
            FindWord(richTextBox);
        }
        #region "Prepare"
        public String getFindWord()
        {
            return fstring;
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
        #endregion
        #region "Replace"
        private void btn_Replace_Click(object sender, EventArgs e)
        {
            freplace = txb_Replace.Text;
            richTextBox.SelectedText = freplace;
        }
        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            fstring = txb_Find.Text;
            freplace = txb_Replace.Text;
            ReplaceAll(richTextBox);
        }
        private void ReplaceAll(RichTextBox rtb)
        {
            String findText = fstring;
            String replaceText = freplace;
            if (findText != "" && replaceText != "")
            {
                rtb.Text = rtb.Text.Replace(findText, replaceText);
                MessageBox.Show("Done", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Nothing to replace", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region "Close"
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            fstring = "";
            freplace = "";
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
            this.Close();
        }

        private void Replace_FormClosed(object sender, FormClosedEventArgs e)
        {
            fstring = "";
            freplace = "";
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }
        #endregion
    }
}
