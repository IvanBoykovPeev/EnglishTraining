﻿namespace LanguageTrainer
{
    partial class MainForm
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
            this.labelEnglish = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.labelGuess = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonByLevel = new System.Windows.Forms.Button();
            this.labelLevels = new System.Windows.Forms.Label();
            this.labelThemes = new System.Windows.Forms.Label();
            this.labelTypes = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonWords = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonByThemes = new System.Windows.Forms.Button();
            this.buttonByTypes = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelGetBy = new System.Windows.Forms.Panel();
            this.buttonBySubLevel = new System.Windows.Forms.Button();
            this.buttonShowAnser = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelGuessVerb = new System.Windows.Forms.Label();
            this.labelVerbPastSimple = new System.Windows.Forms.Label();
            this.textBoxGuessPastSimple = new System.Windows.Forms.TextBox();
            this.textBoxPastSimple = new System.Windows.Forms.TextBox();
            this.labelSubLevel = new System.Windows.Forms.Label();
            this.comboBoxSubLevels = new System.Windows.Forms.ComboBox();
            this.labelWordType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxThemes = new System.Windows.Forms.ListBox();
            this.newIrregularVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelGetBy.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnglish
            // 
            this.labelEnglish.Location = new System.Drawing.Point(8, 84);
            this.labelEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(191, 20);
            this.labelEnglish.TabIndex = 0;
            this.labelEnglish.Text = "English Word";
            this.labelEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnglish.Location = new System.Drawing.Point(207, 82);
            this.textBoxEnglish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.ReadOnly = true;
            this.textBoxEnglish.Size = new System.Drawing.Size(442, 26);
            this.textBoxEnglish.TabIndex = 1;
            // 
            // labelGuess
            // 
            this.labelGuess.Location = new System.Drawing.Point(8, 126);
            this.labelGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(191, 20);
            this.labelGuess.TabIndex = 2;
            this.labelGuess.Text = "Guess Word";
            this.labelGuess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGuess.Location = new System.Drawing.Point(207, 124);
            this.textBoxGuess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(442, 26);
            this.textBoxGuess.TabIndex = 3;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(207, 26);
            this.comboBoxLevels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(180, 28);
            this.comboBoxLevels.TabIndex = 4;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(395, 26);
            this.comboBoxTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(180, 28);
            this.comboBoxTypes.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1139, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWordToolStripMenuItem,
            this.newPhraseToolStripMenuItem,
            this.newThemeToolStripMenuItem,
            this.newIrregularVerbToolStripMenuItem});
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.NewToolStripMenuItem.Text = "NEW";
            // 
            // NewWordToolStripMenuItem
            // 
            this.NewWordToolStripMenuItem.Name = "NewWordToolStripMenuItem";
            this.NewWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewWordToolStripMenuItem.Text = "New Word";
            this.NewWordToolStripMenuItem.Click += new System.EventHandler(this.NewWordToolStripMenuItem_Click);
            // 
            // newPhraseToolStripMenuItem
            // 
            this.newPhraseToolStripMenuItem.Name = "newPhraseToolStripMenuItem";
            this.newPhraseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newPhraseToolStripMenuItem.Text = "New Phrase";
            this.newPhraseToolStripMenuItem.Click += new System.EventHandler(this.newPhraseToolStripMenuItem_Click);
            // 
            // newThemeToolStripMenuItem
            // 
            this.newThemeToolStripMenuItem.Name = "newThemeToolStripMenuItem";
            this.newThemeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newThemeToolStripMenuItem.Text = "New Theme";
            this.newThemeToolStripMenuItem.Click += new System.EventHandler(this.newThemeToolStripMenuItem_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(657, 122);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(156, 28);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.Control;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Location = new System.Drawing.Point(657, 82);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(156, 28);
            this.labelResult.TabIndex = 10;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonByLevel
            // 
            this.buttonByLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonByLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonByLevel.Location = new System.Drawing.Point(7, 5);
            this.buttonByLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByLevel.Name = "buttonByLevel";
            this.buttonByLevel.Size = new System.Drawing.Size(182, 35);
            this.buttonByLevel.TabIndex = 11;
            this.buttonByLevel.Text = "WORDS by Level";
            this.buttonByLevel.UseVisualStyleBackColor = false;
            this.buttonByLevel.Click += new System.EventHandler(this.buttonByLevel_Click);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(203, 1);
            this.labelLevels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(71, 20);
            this.labelLevels.TabIndex = 14;
            this.labelLevels.Text = "LEVELS";
            // 
            // labelThemes
            // 
            this.labelThemes.AutoSize = true;
            this.labelThemes.Location = new System.Drawing.Point(871, 186);
            this.labelThemes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThemes.Name = "labelThemes";
            this.labelThemes.Size = new System.Drawing.Size(76, 20);
            this.labelThemes.TabIndex = 15;
            this.labelThemes.Text = "THEMES";
            // 
            // labelTypes
            // 
            this.labelTypes.AutoSize = true;
            this.labelTypes.Location = new System.Drawing.Point(455, 1);
            this.labelTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(61, 20);
            this.labelTypes.TabIndex = 16;
            this.labelTypes.Text = "TYPES";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonWords,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1139, 88);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "IRREGULAR VERBS";
            // 
            // toolStripButtonWords
            // 
            this.toolStripButtonWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWords.Name = "toolStripButtonWords";
            this.toolStripButtonWords.Size = new System.Drawing.Size(52, 85);
            this.toolStripButtonWords.Text = "WORDS";
            this.toolStripButtonWords.Click += new System.EventHandler(this.toolStripButtonWords_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 88);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 85);
            this.toolStripButton2.Text = "PHRASES";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 88);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 85);
            this.toolStripLabel1.Text = "IRREGULAR VERBS";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 88);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 85);
            this.toolStripLabel2.Text = "NOUNS PLURAL";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 88);
            // 
            // buttonByThemes
            // 
            this.buttonByThemes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonByThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonByThemes.Location = new System.Drawing.Point(875, 150);
            this.buttonByThemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByThemes.Name = "buttonByThemes";
            this.buttonByThemes.Size = new System.Drawing.Size(251, 35);
            this.buttonByThemes.TabIndex = 19;
            this.buttonByThemes.Text = "WORDS by Themes";
            this.buttonByThemes.UseVisualStyleBackColor = false;
            this.buttonByThemes.Click += new System.EventHandler(this.buttonByThemes_Click);
            // 
            // buttonByTypes
            // 
            this.buttonByTypes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonByTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonByTypes.Location = new System.Drawing.Point(195, 5);
            this.buttonByTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByTypes.Name = "buttonByTypes";
            this.buttonByTypes.Size = new System.Drawing.Size(182, 35);
            this.buttonByTypes.TabIndex = 20;
            this.buttonByTypes.Text = "WORDS by Types";
            this.buttonByTypes.UseVisualStyleBackColor = false;
            this.buttonByTypes.Click += new System.EventHandler(this.buttonByTypes_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(657, 160);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(156, 28);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelGetBy
            // 
            this.panelGetBy.Controls.Add(this.buttonBySubLevel);
            this.panelGetBy.Controls.Add(this.buttonByLevel);
            this.panelGetBy.Controls.Add(this.buttonByTypes);
            this.panelGetBy.Location = new System.Drawing.Point(216, 142);
            this.panelGetBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGetBy.Name = "panelGetBy";
            this.panelGetBy.Size = new System.Drawing.Size(619, 43);
            this.panelGetBy.TabIndex = 22;
            // 
            // buttonBySubLevel
            // 
            this.buttonBySubLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBySubLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonBySubLevel.Location = new System.Drawing.Point(383, 5);
            this.buttonBySubLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBySubLevel.Name = "buttonBySubLevel";
            this.buttonBySubLevel.Size = new System.Drawing.Size(182, 35);
            this.buttonBySubLevel.TabIndex = 21;
            this.buttonBySubLevel.Text = "WORDS by SubLevel";
            this.buttonBySubLevel.UseVisualStyleBackColor = false;
            this.buttonBySubLevel.Click += new System.EventHandler(this.buttonBySubLevel_Click);
            // 
            // buttonShowAnser
            // 
            this.buttonShowAnser.Location = new System.Drawing.Point(657, 198);
            this.buttonShowAnser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowAnser.Name = "buttonShowAnser";
            this.buttonShowAnser.Size = new System.Drawing.Size(156, 28);
            this.buttonShowAnser.TabIndex = 23;
            this.buttonShowAnser.Text = "SHOW ANSER";
            this.buttonShowAnser.UseVisualStyleBackColor = true;
            this.buttonShowAnser.Click += new System.EventHandler(this.buttonAnser_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelGuessVerb);
            this.panelMain.Controls.Add(this.labelVerbPastSimple);
            this.panelMain.Controls.Add(this.textBoxGuessPastSimple);
            this.panelMain.Controls.Add(this.textBoxPastSimple);
            this.panelMain.Controls.Add(this.labelSubLevel);
            this.panelMain.Controls.Add(this.comboBoxSubLevels);
            this.panelMain.Controls.Add(this.labelWordType);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.comboBoxLevels);
            this.panelMain.Controls.Add(this.labelLevels);
            this.panelMain.Controls.Add(this.buttonShowAnser);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.labelResult);
            this.panelMain.Controls.Add(this.buttonCheck);
            this.panelMain.Controls.Add(this.comboBoxTypes);
            this.panelMain.Controls.Add(this.labelTypes);
            this.panelMain.Controls.Add(this.labelEnglish);
            this.panelMain.Controls.Add(this.textBoxEnglish);
            this.panelMain.Controls.Add(this.textBoxGuess);
            this.panelMain.Controls.Add(this.labelGuess);
            this.panelMain.Location = new System.Drawing.Point(18, 195);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(817, 403);
            this.panelMain.TabIndex = 24;
            // 
            // labelGuessVerb
            // 
            this.labelGuessVerb.Location = new System.Drawing.Point(9, 202);
            this.labelGuessVerb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuessVerb.Name = "labelGuessVerb";
            this.labelGuessVerb.Size = new System.Drawing.Size(191, 20);
            this.labelGuessVerb.TabIndex = 31;
            this.labelGuessVerb.Text = "Guess Verb";
            this.labelGuessVerb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVerbPastSimple
            // 
            this.labelVerbPastSimple.Location = new System.Drawing.Point(9, 164);
            this.labelVerbPastSimple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerbPastSimple.Name = "labelVerbPastSimple";
            this.labelVerbPastSimple.Size = new System.Drawing.Size(191, 20);
            this.labelVerbPastSimple.TabIndex = 30;
            this.labelVerbPastSimple.Text = "Past Simple";
            this.labelVerbPastSimple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGuessPastSimple
            // 
            this.textBoxGuessPastSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGuessPastSimple.Location = new System.Drawing.Point(207, 200);
            this.textBoxGuessPastSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGuessPastSimple.Name = "textBoxGuessPastSimple";
            this.textBoxGuessPastSimple.Size = new System.Drawing.Size(442, 26);
            this.textBoxGuessPastSimple.TabIndex = 29;
            // 
            // textBoxPastSimple
            // 
            this.textBoxPastSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPastSimple.Location = new System.Drawing.Point(207, 162);
            this.textBoxPastSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPastSimple.Name = "textBoxPastSimple";
            this.textBoxPastSimple.Size = new System.Drawing.Size(442, 26);
            this.textBoxPastSimple.TabIndex = 28;
            // 
            // labelSubLevel
            // 
            this.labelSubLevel.AutoSize = true;
            this.labelSubLevel.Location = new System.Drawing.Point(579, 1);
            this.labelSubLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubLevel.Name = "labelSubLevel";
            this.labelSubLevel.Size = new System.Drawing.Size(75, 20);
            this.labelSubLevel.TabIndex = 27;
            this.labelSubLevel.Text = "SubLevel";
            // 
            // comboBoxSubLevels
            // 
            this.comboBoxSubLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubLevels.FormattingEnabled = true;
            this.comboBoxSubLevels.Location = new System.Drawing.Point(583, 26);
            this.comboBoxSubLevels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubLevels.Name = "comboBoxSubLevels";
            this.comboBoxSubLevels.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSubLevels.TabIndex = 26;
            this.comboBoxSubLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubLevels_SelectedIndexChanged);
            // 
            // labelWordType
            // 
            this.labelWordType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelWordType.Location = new System.Drawing.Point(44, 26);
            this.labelWordType.Name = "labelWordType";
            this.labelWordType.Size = new System.Drawing.Size(156, 28);
            this.labelWordType.TabIndex = 25;
            this.labelWordType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(657, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxThemes
            // 
            this.listBoxThemes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxThemes.FormattingEnabled = true;
            this.listBoxThemes.ItemHeight = 20;
            this.listBoxThemes.Location = new System.Drawing.Point(875, 209);
            this.listBoxThemes.Name = "listBoxThemes";
            this.listBoxThemes.Size = new System.Drawing.Size(253, 244);
            this.listBoxThemes.TabIndex = 25;
            // 
            // newIrregularVerbToolStripMenuItem
            // 
            this.newIrregularVerbToolStripMenuItem.Name = "newIrregularVerbToolStripMenuItem";
            this.newIrregularVerbToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newIrregularVerbToolStripMenuItem.Text = "New Irregular Verb";
            this.newIrregularVerbToolStripMenuItem.Click += new System.EventHandler(this.NewIrregularVerbToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 612);
            this.Controls.Add(this.buttonByThemes);
            this.Controls.Add(this.listBoxThemes);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelGetBy);
            this.Controls.Add(this.labelThemes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelGetBy.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWordToolStripMenuItem;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonByLevel;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.Label labelThemes;
        private System.Windows.Forms.Label labelTypes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonWords;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button buttonByThemes;
        private System.Windows.Forms.Button buttonByTypes;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelGetBy;
        private System.Windows.Forms.Button buttonShowAnser;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox listBoxThemes;
        private System.Windows.Forms.ToolStripMenuItem newPhraseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem newThemeToolStripMenuItem;
        private System.Windows.Forms.Label labelWordType;
        private System.Windows.Forms.Button buttonBySubLevel;
        private System.Windows.Forms.Label labelSubLevel;
        private System.Windows.Forms.ComboBox comboBoxSubLevels;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.Label labelGuessVerb;
        private System.Windows.Forms.Label labelVerbPastSimple;
        private System.Windows.Forms.TextBox textBoxGuessPastSimple;
        private System.Windows.Forms.TextBox textBoxPastSimple;
        private System.Windows.Forms.ToolStripMenuItem newIrregularVerbToolStripMenuItem;
    }
}