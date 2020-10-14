using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Notepad : Form
    {
        public SaveFileDialog sfd;      //instance of savefiledialog to save files
        public OpenFileDialog ofd;      //instance of openfiledialog to open files
        public FontDialog fd;           //instance of fontdialog to change font
        public ColorDialog cl;          //instance of colordialog to change color
        public int index;
        public Notepad()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();
            fd = new FontDialog();
            cl = new ColorDialog();
        }

        #region "Context Menu"
        private void cm_Cut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void cm_Copy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void cm_Paste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        #endregion

        #region "File Menu"
        private void sm_New_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes to the current file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                sfd.InitialDirectory = "C:\\";
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                if (result == DialogResult.OK)
                { System.IO.File.WriteAllText(sfd.FileName, richTextBox.Text); }
                else if (result == DialogResult.No)
                { richTextBox.Clear(); }
                else { return; }
            }
            else { return; }
        }
        private void sm_NewWindow_Click(object sender, EventArgs e)
        {
            new Notepad().Show();
        }
        private void sm_Open_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == String.Empty)
            {
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                    richTextBox.Text = sr.ReadToEnd();
                }
            }
            else
            {
                DialogResult SaveResult = MessageBox.Show("Do you want to save changes to the current file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (SaveResult.Equals(DialogResult.Yes))          //If yes then save and open new file
                {
                    //Save file before open
                    sfd.InitialDirectory = "C:\\";
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 2;
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    { System.IO.File.WriteAllText(sfd.FileName, richTextBox.Text); }
                    //Open file
                    ofd.InitialDirectory = "C:\\";
                    ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.FilterIndex = 2;
                    ofd.RestoreDirectory = true;
                    if (ofd.ShowDialog().Equals(DialogResult.OK))
                    {
                        System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                        richTextBox.Text = sr.ReadToEnd();
                    }
                }
                else if (SaveResult.Equals(DialogResult.No))         //If no then chear and open file    
                {
                    //Open file
                    ofd.InitialDirectory = "C:\\";
                    ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.FilterIndex = 2;
                    ofd.RestoreDirectory = true;
                    if (ofd.ShowDialog().Equals(DialogResult.OK))
                    {
                        System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                        richTextBox.Text = sr.ReadToEnd();
                    }
                }
                else { return; }
                }
            }
        private void sm_Save_Click(object sender, EventArgs e)
        {
            if (sfd.FileName == "")
            {
                sfd.InitialDirectory = "C:\\";
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FilterIndex = 2;
                if (sfd.ShowDialog() == DialogResult.OK)
                { System.IO.File.WriteAllText(sfd.FileName, richTextBox.Text); }
            }
            else
            { System.IO.File.WriteAllText(sfd.FileName, richTextBox.Text); }
        }
        private void sm_SaveAs_Click(object sender, EventArgs e)
        {
            sfd.InitialDirectory = "C:\\";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, richTextBox.Text);
            }
        }
        private void sm_Exit_Click(object sender, EventArgs e)
        {
            if (richTextBox.Modified == true)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the file before exiting", "unsaved file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sfd.Title = "Save As";
                    sfd.Filter = "Text Document|*.txt";//applied filter
                    sfd.DefaultExt = "txt";//applied default extension    
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        this.Text = sfd.FileName;             
                    }
                    richTextBox.Modified = false;
                    Application.Exit();
                }
                else
                {
                    richTextBox.Modified = false;
                    Application.Exit();
                }
            }
        }
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox.Modified == true)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the file before exiting", "unsaved file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sfd.Title = "Save As";
                    sfd.Filter = "Text Document|*.txt";//applied filter
                    sfd.DefaultExt = "txt";//applied default extension    
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        this.Text = sfd.FileName;
                    }
                    richTextBox.Modified = false;
                    Application.Exit();
                }
                else
                {
                    richTextBox.Modified = false;
                    Application.Exit();
                }
            }
        }
        #endregion

        #region "Edit Menu"

        #region "Undo, Redo"
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }
        #endregion
        #region "Cut, copy, paste"       
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }
        #endregion
        #region "Find & Replace"
        private void sm_Find_Click(object sender, EventArgs e)
        {
            Find f = new Find(richTextBox);
            f.Show();
        }
        private void sm_Replace_Click(object sender, EventArgs e)
        {
            Replace r = new Replace(richTextBox);
            r.Show();
        }
        #endregion
        #region "Utilities"
        private void sm_Search_Click(object sender, EventArgs e)
        {
            string search = richTextBox.SelectedText;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + search);
        }
        private void sm_TimeDate_Click(object sender, EventArgs e)
        {
            richTextBox.Text = System.DateTime.Now.ToString();
        }
        #endregion

        #endregion

        #region "Font Menu"
        private void sm_WordWrap_Click(object sender, EventArgs e)
        {
            if (sm_WordWrap.Checked == false)
            {
                sm_WordWrap.Checked = true;
                richTextBox.WordWrap = true;
            }
            else
            {
                sm_WordWrap.Checked = false;
                richTextBox.WordWrap = false;
            }
        }
        private void sm_Font_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fd.Font;
                richTextBox.ForeColor = fd.Color;
            }
        }
        #region "Color"
        private void sm_ColorText_Click(object sender, EventArgs e)
        {
            if (cl.ShowDialog() == DialogResult.OK)
            { richTextBox.ForeColor = cl.Color; }
        }
        private void sm_ColorSelectText_Click(object sender, EventArgs e)
        {
            if (cl.ShowDialog() == DialogResult.OK)
            { richTextBox.SelectionColor = cl.Color; }
        }
        private void sm_ColorBackground_Click(object sender, EventArgs e)
        {
            if (cl.ShowDialog() == DialogResult.OK)
            { richTextBox.BackColor = cl.Color; }
        }
        #endregion
        #endregion

        #region "Help Menu"
        private void sm_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcuts for notepad \n \n" +
                            "Ctrl + N                    New\n" +
                            "Ctrl + Shift + N       New Window\n" +
                            "Ctrl + O                   Open\n" +
                            "Ctrl + S                    Save\n" +
                            "Ctrl + Shift + S       Save\n" +
                            "Ctrl + E                    Exit\n" +
                            "-------------------------------------------\n" +
                            "Ctrl + X                    Cut\n" +
                            "Ctrl + C                    Copy\n" +
                            "Ctrl + V                    Paste\n" +
                            "Ctrl + Z                    Undo\n" +
                            "Ctrl + Y                    Redo\n" +
                            "Ctrl + A                    Select All\n" +
                            "-------------------------------------------\n" +
                            "Ctrl + F                    Find\n" +
                            "Ctrl + Y                    Replace\n" 
                            , "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Form help = new Help();
            //help.Show();
        }

        private void sm_About_Click(object sender, EventArgs e)
        {

        }


        #endregion    
    }
}
