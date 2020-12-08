using System.Windows.Forms;

namespace LanguageTrainer
{
    partial class NewWordForm
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
            this.buttonOk = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubLevels = new System.Windows.Forms.ComboBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(289, 351);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(218, 35);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.ForeColor = System.Drawing.SystemColors.Info;
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
            this.labelBulgarian.ForeColor = System.Drawing.SystemColors.Info;
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
            this.buttonCansel.Location = new System.Drawing.Point(14, 351);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(231, 35);
            this.buttonCansel.TabIndex = 5;
            this.buttonCansel.Text = "CANCEL";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTheme.Location = new System.Drawing.Point(172, 202);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(58, 20);
            this.labelTheme.TabIndex = 6;
            this.labelTheme.Text = "Theme";
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(240, 199);
            this.comboBoxThemes.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(267, 28);
            this.comboBoxThemes.TabIndex = 7;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(240, 105);
            this.comboBoxLevels.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(267, 28);
            this.comboBoxLevels.TabIndex = 8;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLevel.Location = new System.Drawing.Point(184, 113);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(46, 20);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Text = "Level";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(240, 244);
            this.comboBoxTypes.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(267, 28);
            this.comboBoxTypes.TabIndex = 10;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.SystemColors.Info;
            this.labelType.Location = new System.Drawing.Point(187, 247);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(155, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "SubLevel";
            // 
            // comboBoxSubLevels
            // 
            this.comboBoxSubLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubLevels.FormattingEnabled = true;
            this.comboBoxSubLevels.Location = new System.Drawing.Point(240, 152);
            this.comboBoxSubLevels.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSubLevels.Name = "comboBoxSubLevels";
            this.comboBoxSubLevels.Size = new System.Drawing.Size(267, 28);
            this.comboBoxSubLevels.TabIndex = 13;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(240, 281);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(267, 28);
            this.buttonAddImage.TabIndex = 14;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.ButtonAddImage_Click);
            // 
            // NewWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.comboBoxSubLevels);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Word";
            this.Load += new System.EventHandler(this.FormInsertNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
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
        private Label label1;
        private ComboBox comboBoxSubLevels;
        private Button buttonAddImage;

        public ComboBox ComboBoxThemes { get => comboBoxThemes; set => comboBoxThemes = value; }
        public ComboBox ComboBoxLevels { get => comboBoxLevels; set => comboBoxLevels = value; }
        public ComboBox ComboBoxTypes { get => comboBoxTypes; set => comboBoxTypes = value; }
        public TextBox TextBoxEnglish { get => textBoxEnglish; set => textBoxEnglish = value; }
        public TextBox TextBoxBulgarian { get => textBoxBulgarian; set => textBoxBulgarian = value; }
        public Label LabelTheme { get => labelTheme; set => labelTheme = value; }
        public Label LabelType { get => labelType; set => labelType = value; }
    }
}