namespace LanguageTrainer
{
    partial class EditForm
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
            this.textBoxBulgarian = new System.Windows.Forms.TextBox();
            this.labelBulgarian = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.buttonSearchWord = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxFindedWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBulgarian
            // 
            this.textBoxBulgarian.Location = new System.Drawing.Point(240, 145);
            this.textBoxBulgarian.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxBulgarian.Name = "textBoxBulgarian";
            this.textBoxBulgarian.Size = new System.Drawing.Size(267, 26);
            this.textBoxBulgarian.TabIndex = 8;
            // 
            // labelBulgarian
            // 
            this.labelBulgarian.AutoSize = true;
            this.labelBulgarian.Location = new System.Drawing.Point(154, 148);
            this.labelBulgarian.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBulgarian.Name = "labelBulgarian";
            this.labelBulgarian.Size = new System.Drawing.Size(76, 20);
            this.labelBulgarian.TabIndex = 7;
            this.labelBulgarian.Text = "Bulgarian";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(240, 109);
            this.textBoxEnglish.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(267, 26);
            this.textBoxEnglish.TabIndex = 6;
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(169, 112);
            this.labelEnglish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(61, 20);
            this.labelEnglish.TabIndex = 5;
            this.labelEnglish.Text = "English";
            // 
            // buttonSearchWord
            // 
            this.buttonSearchWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSearchWord.Location = new System.Drawing.Point(50, 29);
            this.buttonSearchWord.Name = "buttonSearchWord";
            this.buttonSearchWord.Size = new System.Drawing.Size(180, 30);
            this.buttonSearchWord.TabIndex = 9;
            this.buttonSearchWord.Text = "SEARCH WORD";
            this.buttonSearchWord.UseVisualStyleBackColor = false;
            this.buttonSearchWord.Click += new System.EventHandler(this.ButtonSearchWord_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(240, 29);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(267, 26);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Seatch word";
            this.textBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonCansel.Location = new System.Drawing.Point(14, 351);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(231, 35);
            this.buttonCansel.TabIndex = 12;
            this.buttonCansel.Text = "CANCEL";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.ButtonCansel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonOk.Location = new System.Drawing.Point(289, 351);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(218, 35);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "EDIT";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonNext.Location = new System.Drawing.Point(50, 65);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(180, 30);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // textBoxFindedWord
            // 
            this.textBoxFindedWord.Location = new System.Drawing.Point(240, 65);
            this.textBoxFindedWord.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFindedWord.Name = "textBoxFindedWord";
            this.textBoxFindedWord.Size = new System.Drawing.Size(267, 26);
            this.textBoxFindedWord.TabIndex = 10;
            this.textBoxFindedWord.Text = "Find:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFindedWord);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearchWord);
            this.Controls.Add(this.textBoxBulgarian);
            this.Controls.Add(this.labelBulgarian);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.labelEnglish);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBulgarian;
        private System.Windows.Forms.Label labelBulgarian;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Button buttonSearchWord;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxFindedWord;
    }
}