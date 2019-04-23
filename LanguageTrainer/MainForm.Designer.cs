namespace LanguageTrainer
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
            this.labelEnglishWord = new System.Windows.Forms.Label();
            this.textBoxEnglishWord = new System.Windows.Forms.TextBox();
            this.labelGuessWord = new System.Windows.Forms.Label();
            this.textBoxGuessWord = new System.Windows.Forms.TextBox();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonWords = new System.Windows.Forms.Button();
            this.buttonPhrases = new System.Windows.Forms.Button();
            this.buttonIrregularVerbs = new System.Windows.Forms.Button();
            this.labelLevels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEnglishWord
            // 
            this.labelEnglishWord.AutoSize = true;
            this.labelEnglishWord.Location = new System.Drawing.Point(10, 104);
            this.labelEnglishWord.Name = "labelEnglishWord";
            this.labelEnglishWord.Size = new System.Drawing.Size(70, 13);
            this.labelEnglishWord.TabIndex = 0;
            this.labelEnglishWord.Text = "English Word";
            // 
            // textBoxEnglishWord
            // 
            this.textBoxEnglishWord.Location = new System.Drawing.Point(86, 101);
            this.textBoxEnglishWord.Name = "textBoxEnglishWord";
            this.textBoxEnglishWord.Size = new System.Drawing.Size(265, 20);
            this.textBoxEnglishWord.TabIndex = 1;
            // 
            // labelGuessWord
            // 
            this.labelGuessWord.AutoSize = true;
            this.labelGuessWord.Location = new System.Drawing.Point(14, 131);
            this.labelGuessWord.Name = "labelGuessWord";
            this.labelGuessWord.Size = new System.Drawing.Size(66, 13);
            this.labelGuessWord.TabIndex = 2;
            this.labelGuessWord.Text = "Guess Word";
            // 
            // textBoxGuessWord
            // 
            this.textBoxGuessWord.Location = new System.Drawing.Point(86, 128);
            this.textBoxGuessWord.Name = "textBoxGuessWord";
            this.textBoxGuessWord.Size = new System.Drawing.Size(265, 20);
            this.textBoxGuessWord.TabIndex = 3;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(86, 74);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLevels.TabIndex = 4;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(340, 74);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypes.TabIndex = 5;
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(213, 74);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxThemes.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem});
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.nEWToolStripMenuItem.Text = "NEW";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(86, 154);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(167, 137);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 10;
            // 
            // buttonWords
            // 
            this.buttonWords.Location = new System.Drawing.Point(86, 234);
            this.buttonWords.Name = "buttonWords";
            this.buttonWords.Size = new System.Drawing.Size(75, 23);
            this.buttonWords.TabIndex = 11;
            this.buttonWords.Text = "WORDS";
            this.buttonWords.UseVisualStyleBackColor = true;
            this.buttonWords.Click += new System.EventHandler(this.buttonWords_Click);
            // 
            // buttonPhrases
            // 
            this.buttonPhrases.Location = new System.Drawing.Point(170, 234);
            this.buttonPhrases.Name = "buttonPhrases";
            this.buttonPhrases.Size = new System.Drawing.Size(75, 23);
            this.buttonPhrases.TabIndex = 12;
            this.buttonPhrases.Text = "PHRASES";
            this.buttonPhrases.UseVisualStyleBackColor = true;
            // 
            // buttonIrregularVerbs
            // 
            this.buttonIrregularVerbs.Location = new System.Drawing.Point(251, 234);
            this.buttonIrregularVerbs.Name = "buttonIrregularVerbs";
            this.buttonIrregularVerbs.Size = new System.Drawing.Size(131, 23);
            this.buttonIrregularVerbs.TabIndex = 13;
            this.buttonIrregularVerbs.Text = "IRREGULAR VERBS";
            this.buttonIrregularVerbs.UseVisualStyleBackColor = true;
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(86, 55);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(47, 13);
            this.labelLevels.TabIndex = 14;
            this.labelLevels.Text = "LEVELS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "THEMES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "TYPES";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 154);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(67, 23);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLevels);
            this.Controls.Add(this.buttonIrregularVerbs);
            this.Controls.Add(this.buttonPhrases);
            this.Controls.Add(this.buttonWords);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxThemes);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.comboBoxLevels);
            this.Controls.Add(this.textBoxGuessWord);
            this.Controls.Add(this.labelGuessWord);
            this.Controls.Add(this.textBoxEnglishWord);
            this.Controls.Add(this.labelEnglishWord);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnglishWord;
        private System.Windows.Forms.TextBox textBoxEnglishWord;
        private System.Windows.Forms.Label labelGuessWord;
        private System.Windows.Forms.TextBox textBoxGuessWord;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.ComboBox comboBoxThemes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonWords;
        private System.Windows.Forms.Button buttonPhrases;
        private System.Windows.Forms.Button buttonIrregularVerbs;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
    }
}