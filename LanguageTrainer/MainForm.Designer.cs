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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelEnglish = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.labelGuess = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonByThemes = new System.Windows.Forms.Button();
            this.buttonByTypes = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelGetBy = new System.Windows.Forms.Panel();
            this.buttonShowAnser = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelGetBy.SuspendLayout();
            this.panelMain.SuspendLayout();
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
            this.comboBoxLevels.Location = new System.Drawing.Point(0, 25);
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
            this.comboBoxTypes.Location = new System.Drawing.Point(381, 25);
            this.comboBoxTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(180, 28);
            this.comboBoxTypes.TabIndex = 5;
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(190, 25);
            this.comboBoxThemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(180, 28);
            this.comboBoxThemes.TabIndex = 6;
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
            this.menuStrip1.Size = new System.Drawing.Size(848, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWordToolStripMenuItem});
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.NewToolStripMenuItem.Text = "NEW";
            // 
            // NewWordToolStripMenuItem
            // 
            this.NewWordToolStripMenuItem.Name = "NewWordToolStripMenuItem";
            this.NewWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewWordToolStripMenuItem.Text = "NewWord";
            this.NewWordToolStripMenuItem.Click += new System.EventHandler(this.NewWordToolStripMenuItem_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(207, 162);
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
            this.labelResult.Location = new System.Drawing.Point(657, 80);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(156, 28);
            this.labelResult.TabIndex = 10;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonByLevel
            // 
            this.buttonByLevel.Location = new System.Drawing.Point(0, 5);
            this.buttonByLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByLevel.Name = "buttonByLevel";
            this.buttonByLevel.Size = new System.Drawing.Size(182, 35);
            this.buttonByLevel.TabIndex = 11;
            this.buttonByLevel.Text = "WORDS by Level";
            this.buttonByLevel.UseVisualStyleBackColor = true;
            this.buttonByLevel.Click += new System.EventHandler(this.buttonByLevel_Click);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(4, 0);
            this.labelLevels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(71, 20);
            this.labelLevels.TabIndex = 14;
            this.labelLevels.Text = "LEVELS";
            // 
            // labelThemes
            // 
            this.labelThemes.AutoSize = true;
            this.labelThemes.Location = new System.Drawing.Point(190, 0);
            this.labelThemes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThemes.Name = "labelThemes";
            this.labelThemes.Size = new System.Drawing.Size(76, 20);
            this.labelThemes.TabIndex = 15;
            this.labelThemes.Text = "THEMES";
            // 
            // labelTypes
            // 
            this.labelTypes.AutoSize = true;
            this.labelTypes.Location = new System.Drawing.Point(381, 0);
            this.labelTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(61, 20);
            this.labelTypes.TabIndex = 16;
            this.labelTypes.Text = "TYPES";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
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
            this.toolStrip1.Size = new System.Drawing.Size(848, 88);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonWords
            // 
            this.toolStripButtonWords.AutoSize = false;
            this.toolStripButtonWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWords.Name = "toolStripButtonWords";
            this.toolStripButtonWords.Size = new System.Drawing.Size(60, 54);
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
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 85);
            this.toolStripLabel1.Text = "IRREGULAR VERBS";
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
            this.buttonByThemes.Location = new System.Drawing.Point(190, 5);
            this.buttonByThemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByThemes.Name = "buttonByThemes";
            this.buttonByThemes.Size = new System.Drawing.Size(182, 35);
            this.buttonByThemes.TabIndex = 19;
            this.buttonByThemes.Text = "WORDS by Themes";
            this.buttonByThemes.UseVisualStyleBackColor = true;
            this.buttonByThemes.Click += new System.EventHandler(this.buttonByThemes_Click);
            // 
            // buttonByTypes
            // 
            this.buttonByTypes.Location = new System.Drawing.Point(381, 5);
            this.buttonByTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonByTypes.Name = "buttonByTypes";
            this.buttonByTypes.Size = new System.Drawing.Size(182, 35);
            this.buttonByTypes.TabIndex = 20;
            this.buttonByTypes.Text = "WORDS by Types";
            this.buttonByTypes.UseVisualStyleBackColor = true;
            this.buttonByTypes.Click += new System.EventHandler(this.buttonByTypes_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(657, 162);
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
            this.panelGetBy.Controls.Add(this.buttonByLevel);
            this.panelGetBy.Controls.Add(this.buttonByThemes);
            this.panelGetBy.Controls.Add(this.buttonByTypes);
            this.panelGetBy.Location = new System.Drawing.Point(129, 143);
            this.panelGetBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGetBy.Name = "panelGetBy";
            this.panelGetBy.Size = new System.Drawing.Size(562, 43);
            this.panelGetBy.TabIndex = 22;
            // 
            // buttonShowAnser
            // 
            this.buttonShowAnser.Location = new System.Drawing.Point(657, 122);
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
            this.panelMain.Controls.Add(this.comboBoxLevels);
            this.panelMain.Controls.Add(this.labelLevels);
            this.panelMain.Controls.Add(this.buttonShowAnser);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.labelThemes);
            this.panelMain.Controls.Add(this.comboBoxThemes);
            this.panelMain.Controls.Add(this.labelResult);
            this.panelMain.Controls.Add(this.buttonStart);
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
            this.panelMain.Size = new System.Drawing.Size(817, 268);
            this.panelMain.TabIndex = 24;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(657, 25);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 28);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 504);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelGetBy);
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
        private System.Windows.Forms.ComboBox comboBoxThemes;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
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
        private System.Windows.Forms.Button buttonStart;
    }
}