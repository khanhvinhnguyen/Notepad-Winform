namespace notepad
{
    partial class Notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sm_File = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_New = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.sm_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sm_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sm_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sm_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sm_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_TimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_ColorText = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_ColorSelectText = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_ColorBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sm_About = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_File,
            this.sm_Edit,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sm_File
            // 
            this.sm_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_New,
            this.sm_NewWindow,
            this.sm_Open,
            this.toolStripSeparator,
            this.sm_Save,
            this.sm_SaveAs,
            this.toolStripSeparator1,
            this.sm_Exit});
            this.sm_File.Name = "sm_File";
            this.sm_File.Size = new System.Drawing.Size(37, 20);
            this.sm_File.Text = "&File";
            // 
            // sm_New
            // 
            this.sm_New.Image = ((System.Drawing.Image)(resources.GetObject("sm_New.Image")));
            this.sm_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_New.Name = "sm_New";
            this.sm_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.sm_New.Size = new System.Drawing.Size(220, 22);
            this.sm_New.Text = "&New";
            this.sm_New.Click += new System.EventHandler(this.sm_New_Click);
            // 
            // sm_NewWindow
            // 
            this.sm_NewWindow.Name = "sm_NewWindow";
            this.sm_NewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.sm_NewWindow.Size = new System.Drawing.Size(220, 22);
            this.sm_NewWindow.Text = "New Window";
            this.sm_NewWindow.Click += new System.EventHandler(this.sm_NewWindow_Click);
            // 
            // sm_Open
            // 
            this.sm_Open.Image = ((System.Drawing.Image)(resources.GetObject("sm_Open.Image")));
            this.sm_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_Open.Name = "sm_Open";
            this.sm_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.sm_Open.Size = new System.Drawing.Size(220, 22);
            this.sm_Open.Text = "&Open";
            this.sm_Open.Click += new System.EventHandler(this.sm_Open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(217, 6);
            // 
            // sm_Save
            // 
            this.sm_Save.Image = ((System.Drawing.Image)(resources.GetObject("sm_Save.Image")));
            this.sm_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_Save.Name = "sm_Save";
            this.sm_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sm_Save.Size = new System.Drawing.Size(220, 22);
            this.sm_Save.Text = "&Save";
            this.sm_Save.Click += new System.EventHandler(this.sm_Save_Click);
            // 
            // sm_SaveAs
            // 
            this.sm_SaveAs.Name = "sm_SaveAs";
            this.sm_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sm_SaveAs.Size = new System.Drawing.Size(220, 22);
            this.sm_SaveAs.Text = "Save &As";
            this.sm_SaveAs.Click += new System.EventHandler(this.sm_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // sm_Exit
            // 
            this.sm_Exit.Name = "sm_Exit";
            this.sm_Exit.Size = new System.Drawing.Size(220, 22);
            this.sm_Exit.Text = "E&xit";
            this.sm_Exit.Click += new System.EventHandler(this.sm_Exit_Click);
            // 
            // sm_Edit
            // 
            this.sm_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_Undo,
            this.sm_Redo,
            this.toolStripSeparator3,
            this.sm_Cut,
            this.sm_Copy,
            this.sm_Paste,
            this.sm_SelectAll,
            this.toolStripSeparator2,
            this.sm_Find,
            this.sm_Replace,
            this.toolStripSeparator4,
            this.sm_Search,
            this.sm_TimeDate});
            this.sm_Edit.Name = "sm_Edit";
            this.sm_Edit.Size = new System.Drawing.Size(39, 20);
            this.sm_Edit.Text = "Edit";
            // 
            // sm_Undo
            // 
            this.sm_Undo.Image = global::notepad.Properties.Resources.undo;
            this.sm_Undo.Name = "sm_Undo";
            this.sm_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.sm_Undo.Size = new System.Drawing.Size(218, 22);
            this.sm_Undo.Text = "&Undo";
            this.sm_Undo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // sm_Redo
            // 
            this.sm_Redo.Image = global::notepad.Properties.Resources.redo;
            this.sm_Redo.Name = "sm_Redo";
            this.sm_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.sm_Redo.Size = new System.Drawing.Size(218, 22);
            this.sm_Redo.Text = "&Redo";
            this.sm_Redo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // sm_Cut
            // 
            this.sm_Cut.Image = ((System.Drawing.Image)(resources.GetObject("sm_Cut.Image")));
            this.sm_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_Cut.Name = "sm_Cut";
            this.sm_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.sm_Cut.Size = new System.Drawing.Size(218, 22);
            this.sm_Cut.Text = "Cu&t";
            this.sm_Cut.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // sm_Copy
            // 
            this.sm_Copy.Image = ((System.Drawing.Image)(resources.GetObject("sm_Copy.Image")));
            this.sm_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_Copy.Name = "sm_Copy";
            this.sm_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.sm_Copy.Size = new System.Drawing.Size(218, 22);
            this.sm_Copy.Text = "&Copy";
            this.sm_Copy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // sm_Paste
            // 
            this.sm_Paste.Image = ((System.Drawing.Image)(resources.GetObject("sm_Paste.Image")));
            this.sm_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sm_Paste.Name = "sm_Paste";
            this.sm_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.sm_Paste.Size = new System.Drawing.Size(218, 22);
            this.sm_Paste.Text = "&Paste";
            this.sm_Paste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // sm_SelectAll
            // 
            this.sm_SelectAll.Name = "sm_SelectAll";
            this.sm_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.sm_SelectAll.Size = new System.Drawing.Size(218, 22);
            this.sm_SelectAll.Text = "Select &All";
            this.sm_SelectAll.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // sm_Find
            // 
            this.sm_Find.Image = global::notepad.Properties.Resources.searching_magnifying_glass;
            this.sm_Find.Name = "sm_Find";
            this.sm_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.sm_Find.Size = new System.Drawing.Size(218, 22);
            this.sm_Find.Text = "Find";
            this.sm_Find.Click += new System.EventHandler(this.sm_Find_Click);
            // 
            // sm_Replace
            // 
            this.sm_Replace.Name = "sm_Replace";
            this.sm_Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.sm_Replace.Size = new System.Drawing.Size(218, 22);
            this.sm_Replace.Text = "Replace";
            this.sm_Replace.Click += new System.EventHandler(this.sm_Replace_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // sm_Search
            // 
            this.sm_Search.Name = "sm_Search";
            this.sm_Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.sm_Search.Size = new System.Drawing.Size(218, 22);
            this.sm_Search.Text = "Search with Google";
            this.sm_Search.Click += new System.EventHandler(this.sm_Search_Click);
            // 
            // sm_TimeDate
            // 
            this.sm_TimeDate.Name = "sm_TimeDate";
            this.sm_TimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.sm_TimeDate.Size = new System.Drawing.Size(218, 22);
            this.sm_TimeDate.Text = "Time/ Date";
            this.sm_TimeDate.Click += new System.EventHandler(this.sm_TimeDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_WordWrap,
            this.sm_Font,
            this.sm_Color});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // sm_WordWrap
            // 
            this.sm_WordWrap.Name = "sm_WordWrap";
            this.sm_WordWrap.Size = new System.Drawing.Size(134, 22);
            this.sm_WordWrap.Text = "Word Wrap";
            this.sm_WordWrap.Click += new System.EventHandler(this.sm_WordWrap_Click);
            // 
            // sm_Font
            // 
            this.sm_Font.Name = "sm_Font";
            this.sm_Font.Size = new System.Drawing.Size(134, 22);
            this.sm_Font.Text = "Font";
            this.sm_Font.Click += new System.EventHandler(this.sm_Font_Click);
            // 
            // sm_Color
            // 
            this.sm_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_ColorText,
            this.sm_ColorSelectText,
            this.sm_ColorBackground});
            this.sm_Color.Name = "sm_Color";
            this.sm_Color.Size = new System.Drawing.Size(134, 22);
            this.sm_Color.Text = "Color";
            // 
            // sm_ColorText
            // 
            this.sm_ColorText.Name = "sm_ColorText";
            this.sm_ColorText.Size = new System.Drawing.Size(170, 22);
            this.sm_ColorText.Text = "Color Text";
            this.sm_ColorText.Click += new System.EventHandler(this.sm_ColorText_Click);
            // 
            // sm_ColorSelectText
            // 
            this.sm_ColorSelectText.Name = "sm_ColorSelectText";
            this.sm_ColorSelectText.Size = new System.Drawing.Size(170, 22);
            this.sm_ColorSelectText.Text = "Color Select Text";
            this.sm_ColorSelectText.Click += new System.EventHandler(this.sm_ColorSelectText_Click);
            // 
            // sm_ColorBackground
            // 
            this.sm_ColorBackground.Name = "sm_ColorBackground";
            this.sm_ColorBackground.Size = new System.Drawing.Size(170, 22);
            this.sm_ColorBackground.Text = "Color Background";
            this.sm_ColorBackground.Click += new System.EventHandler(this.sm_ColorBackground_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_Help,
            this.toolStripSeparator5,
            this.sm_About});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // sm_Help
            // 
            this.sm_Help.Name = "sm_Help";
            this.sm_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sm_Help.Size = new System.Drawing.Size(118, 22);
            this.sm_Help.Text = "Help";
            this.sm_Help.Click += new System.EventHandler(this.sm_Help_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(115, 6);
            // 
            // sm_About
            // 
            this.sm_About.Name = "sm_About";
            this.sm_About.Size = new System.Drawing.Size(118, 22);
            this.sm_About.Text = "&About...";
            this.sm_About.Click += new System.EventHandler(this.sm_About_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_Cut,
            this.cm_Copy,
            this.cm_Paste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 70);
            // 
            // cm_Cut
            // 
            this.cm_Cut.Name = "cm_Cut";
            this.cm_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cm_Cut.Size = new System.Drawing.Size(144, 22);
            this.cm_Cut.Text = "Cut";
            this.cm_Cut.Click += new System.EventHandler(this.cm_Cut_Click);
            // 
            // cm_Copy
            // 
            this.cm_Copy.Name = "cm_Copy";
            this.cm_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cm_Copy.Size = new System.Drawing.Size(144, 22);
            this.cm_Copy.Text = "Copy";
            this.cm_Copy.Click += new System.EventHandler(this.cm_Copy_Click);
            // 
            // cm_Paste
            // 
            this.cm_Paste.Name = "cm_Paste";
            this.cm_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cm_Paste.Size = new System.Drawing.Size(144, 22);
            this.cm_Paste.Text = "Paste";
            this.cm_Paste.Click += new System.EventHandler(this.cm_Paste_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 24);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(627, 426);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // Notepad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sm_File;
        private System.Windows.Forms.ToolStripMenuItem sm_New;
        private System.Windows.Forms.ToolStripMenuItem sm_NewWindow;
        private System.Windows.Forms.ToolStripMenuItem sm_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem sm_Save;
        private System.Windows.Forms.ToolStripMenuItem sm_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sm_Exit;
        private System.Windows.Forms.ToolStripMenuItem sm_Edit;
        private System.Windows.Forms.ToolStripMenuItem sm_Undo;
        private System.Windows.Forms.ToolStripMenuItem sm_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sm_Cut;
        private System.Windows.Forms.ToolStripMenuItem sm_Copy;
        private System.Windows.Forms.ToolStripMenuItem sm_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sm_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sm_WordWrap;
        private System.Windows.Forms.ToolStripMenuItem sm_Font;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sm_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sm_About;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cm_Cut;
        private System.Windows.Forms.ToolStripMenuItem cm_Copy;
        private System.Windows.Forms.ToolStripMenuItem cm_Paste;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem sm_Find;
        private System.Windows.Forms.ToolStripMenuItem sm_Replace;
        private System.Windows.Forms.ToolStripMenuItem sm_Color;
        private System.Windows.Forms.ToolStripMenuItem sm_ColorText;
        private System.Windows.Forms.ToolStripMenuItem sm_ColorSelectText;
        private System.Windows.Forms.ToolStripMenuItem sm_ColorBackground;
        private System.Windows.Forms.ToolStripMenuItem sm_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sm_TimeDate;
    }
}

