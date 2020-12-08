
namespace LanguageTrainer
{
    partial class SearchForm
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
            this.labelEnglishSearch = new System.Windows.Forms.Label();
            this.textBoxEnglishWordSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.labelBulgarianhSearch = new System.Windows.Forms.Label();
            this.textBoxBulgarianWordSearch = new System.Windows.Forms.TextBox();
            this.labelResultNumber = new System.Windows.Forms.Label();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnglishSearch
            // 
            this.labelEnglishSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnglishSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnglishSearch.Location = new System.Drawing.Point(40, 42);
            this.labelEnglishSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnglishSearch.Name = "labelEnglishSearch";
            this.labelEnglishSearch.Size = new System.Drawing.Size(180, 25);
            this.labelEnglishSearch.TabIndex = 0;
            this.labelEnglishSearch.Text = "English Word";
            this.labelEnglishSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEnglishWordSearch
            // 
            this.textBoxEnglishWordSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnglishWordSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEnglishWordSearch.Location = new System.Drawing.Point(224, 41);
            this.textBoxEnglishWordSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEnglishWordSearch.Name = "textBoxEnglishWordSearch";
            this.textBoxEnglishWordSearch.Size = new System.Drawing.Size(180, 26);
            this.textBoxEnglishWordSearch.TabIndex = 4;
            this.textBoxEnglishWordSearch.Click += new System.EventHandler(this.TextBoxSearchWord_Click);
            this.textBoxEnglishWordSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnglishWordSearch_KeyDown);
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSearchNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearchNext.Location = new System.Drawing.Point(411, 70);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(180, 30);
            this.buttonSearchNext.TabIndex = 2;
            this.buttonSearchNext.Text = "NEXT";
            this.buttonSearchNext.UseVisualStyleBackColor = false;
            this.buttonSearchNext.Click += new System.EventHandler(this.buttonSearchNext_Click);
            // 
            // labelBulgarianhSearch
            // 
            this.labelBulgarianhSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBulgarianhSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBulgarianhSearch.Location = new System.Drawing.Point(40, 71);
            this.labelBulgarianhSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBulgarianhSearch.Name = "labelBulgarianhSearch";
            this.labelBulgarianhSearch.Size = new System.Drawing.Size(180, 25);
            this.labelBulgarianhSearch.TabIndex = 1;
            this.labelBulgarianhSearch.Text = "Bulgarian Word";
            this.labelBulgarianhSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBulgarianWordSearch
            // 
            this.textBoxBulgarianWordSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBulgarianWordSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBulgarianWordSearch.Location = new System.Drawing.Point(224, 73);
            this.textBoxBulgarianWordSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBulgarianWordSearch.Name = "textBoxBulgarianWordSearch";
            this.textBoxBulgarianWordSearch.Size = new System.Drawing.Size(180, 26);
            this.textBoxBulgarianWordSearch.TabIndex = 4;
            // 
            // labelResultNumber
            // 
            this.labelResultNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResultNumber.Location = new System.Drawing.Point(41, 113);
            this.labelResultNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultNumber.Name = "labelResultNumber";
            this.labelResultNumber.Size = new System.Drawing.Size(179, 25);
            this.labelResultNumber.TabIndex = 1;
            this.labelResultNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCansel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonCansel.Location = new System.Drawing.Point(423, 277);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(231, 35);
            this.buttonCansel.TabIndex = 40;
            this.buttonCansel.Text = "CLOSE";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.ButtonCansel_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchButton.Location = new System.Drawing.Point(224, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 30);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "SEARCH WORD";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.ButtonSearchWord_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(668, 326);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.textBoxEnglishWordSearch);
            this.Controls.Add(this.labelEnglishSearch);
            this.Controls.Add(this.labelResultNumber);
            this.Controls.Add(this.textBoxBulgarianWordSearch);
            this.Controls.Add(this.buttonSearchNext);
            this.Controls.Add(this.labelBulgarianhSearch);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEnglishSearch;
        private System.Windows.Forms.TextBox textBoxEnglishWordSearch;
        private System.Windows.Forms.Button buttonSearchNext;
        private System.Windows.Forms.Label labelBulgarianhSearch;
        private System.Windows.Forms.TextBox textBoxBulgarianWordSearch;
        private System.Windows.Forms.Label labelResultNumber;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button searchButton;
    }
}