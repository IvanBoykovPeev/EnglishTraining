using System.Windows.Forms;

namespace LanguageTrainer
{
    partial class FormInsertNew
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.labelBulgarian = new System.Windows.Forms.Label();
            this.textBoxBulgarian = new System.Windows.Forms.TextBox();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(291, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(169, 32);
            this.labelEnglish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(61, 20);
            this.labelEnglish.TabIndex = 1;
            this.labelEnglish.Text = "English";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(240, 26);
            this.textBoxEnglish.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(267, 26);
            this.textBoxEnglish.TabIndex = 2;
            // 
            // labelBulgarian
            // 
            this.labelBulgarian.AutoSize = true;
            this.labelBulgarian.Location = new System.Drawing.Point(154, 73);
            this.labelBulgarian.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBulgarian.Name = "labelBulgarian";
            this.labelBulgarian.Size = new System.Drawing.Size(76, 20);
            this.labelBulgarian.TabIndex = 3;
            this.labelBulgarian.Text = "Bulgarian";
            // 
            // textBoxBulgarian
            // 
            this.textBoxBulgarian.Location = new System.Drawing.Point(240, 67);
            this.textBoxBulgarian.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxBulgarian.Name = "textBoxBulgarian";
            this.textBoxBulgarian.Size = new System.Drawing.Size(267, 26);
            this.textBoxBulgarian.TabIndex = 4;
            // 
            // buttonCansel
            // 
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.Location = new System.Drawing.Point(24, 347);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(231, 35);
            this.buttonCansel.TabIndex = 5;
            this.buttonCansel.Text = "CANCEL";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(172, 155);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(58, 20);
            this.labelTheme.TabIndex = 6;
            this.labelTheme.Text = "Theme";
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(240, 147);
            this.comboBoxThemes.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(267, 28);
            this.comboBoxThemes.TabIndex = 7;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(240, 105);
            this.comboBoxLevels.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(267, 28);
            this.comboBoxLevels.TabIndex = 8;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(184, 113);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(46, 20);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Text = "Level";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(240, 191);
            this.comboBoxTypes.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(267, 28);
            this.comboBoxTypes.TabIndex = 10;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(187, 199);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Type";
            // 
            // FormInsertNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.comboBoxLevels);
            this.Controls.Add(this.comboBoxThemes);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.textBoxBulgarian);
            this.Controls.Add(this.labelBulgarian);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormInsertNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label labelBulgarian;
        private System.Windows.Forms.TextBox textBoxBulgarian;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxThemes;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Label labelType;

        public ComboBox ComboBoxThemes { get => comboBoxThemes; set => comboBoxThemes = value; }
        public ComboBox ComboBoxLevels { get => comboBoxLevels; set => comboBoxLevels = value; }
        public ComboBox ComboBoxTypes { get => comboBoxTypes; set => comboBoxTypes = value; }
        public TextBox TextBoxEnglish { get => textBoxEnglish; set => textBoxEnglish = value; }
        public TextBox TextBoxBulgarian { get => textBoxBulgarian; set => textBoxBulgarian = value; }
        public Label LabelTheme { get => labelTheme; set => labelTheme = value; }
        public Label LabelType { get => labelType; set => labelType = value; }
    }
}