namespace passgen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxLowerCaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.checkBoxMemorizeable = new System.Windows.Forms.CheckBox();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.checkBoxMultiple = new System.Windows.Forms.CheckBox();
            this.labelHowMany = new System.Windows.Forms.Label();
            this.numericUpDownCharacters = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHowMany = new System.Windows.Forms.NumericUpDown();
            this.textBoxPasswordList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHowMany)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Location = new System.Drawing.Point(12, 12);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDigits.TabIndex = 0;
            this.checkBoxDigits.Text = "Digits";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCaseLetters
            // 
            this.checkBoxUpperCaseLetters.AutoSize = true;
            this.checkBoxUpperCaseLetters.Location = new System.Drawing.Point(12, 35);
            this.checkBoxUpperCaseLetters.Name = "checkBoxUpperCaseLetters";
            this.checkBoxUpperCaseLetters.Size = new System.Drawing.Size(112, 17);
            this.checkBoxUpperCaseLetters.TabIndex = 1;
            this.checkBoxUpperCaseLetters.Text = "Upper case letters";
            this.checkBoxUpperCaseLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCaseLetters
            // 
            this.checkBoxLowerCaseLetters.AutoSize = true;
            this.checkBoxLowerCaseLetters.Location = new System.Drawing.Point(12, 58);
            this.checkBoxLowerCaseLetters.Name = "checkBoxLowerCaseLetters";
            this.checkBoxLowerCaseLetters.Size = new System.Drawing.Size(112, 17);
            this.checkBoxLowerCaseLetters.TabIndex = 2;
            this.checkBoxLowerCaseLetters.Text = "Lower case letters";
            this.checkBoxLowerCaseLetters.UseVisualStyleBackColor = true;
            this.checkBoxLowerCaseLetters.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxSpecialCharacters
            // 
            this.checkBoxSpecialCharacters.AutoSize = true;
            this.checkBoxSpecialCharacters.Location = new System.Drawing.Point(12, 81);
            this.checkBoxSpecialCharacters.Name = "checkBoxSpecialCharacters";
            this.checkBoxSpecialCharacters.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSpecialCharacters.TabIndex = 3;
            this.checkBoxSpecialCharacters.Text = "Special characters";
            this.checkBoxSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxMemorizeable
            // 
            this.checkBoxMemorizeable.AutoSize = true;
            this.checkBoxMemorizeable.Location = new System.Drawing.Point(12, 104);
            this.checkBoxMemorizeable.Name = "checkBoxMemorizeable";
            this.checkBoxMemorizeable.Size = new System.Drawing.Size(85, 17);
            this.checkBoxMemorizeable.TabIndex = 4;
            this.checkBoxMemorizeable.Text = "Memorizable";
            this.checkBoxMemorizeable.UseVisualStyleBackColor = true;
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(149, 13);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(61, 13);
            this.labelCharacters.TabIndex = 5;
            this.labelCharacters.Text = "Characters:";
            this.labelCharacters.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(197, 123);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 7;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiple
            // 
            this.checkBoxMultiple.AutoSize = true;
            this.checkBoxMultiple.Location = new System.Drawing.Point(12, 127);
            this.checkBoxMultiple.Name = "checkBoxMultiple";
            this.checkBoxMultiple.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMultiple.TabIndex = 8;
            this.checkBoxMultiple.Text = "Multiple";
            this.checkBoxMultiple.UseVisualStyleBackColor = true;
            // 
            // labelHowMany
            // 
            this.labelHowMany.AutoSize = true;
            this.labelHowMany.Location = new System.Drawing.Point(149, 59);
            this.labelHowMany.Name = "labelHowMany";
            this.labelHowMany.Size = new System.Drawing.Size(60, 13);
            this.labelHowMany.TabIndex = 9;
            this.labelHowMany.Text = "How many:";
            this.labelHowMany.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDownCharacters
            // 
            this.numericUpDownCharacters.Location = new System.Drawing.Point(152, 34);
            this.numericUpDownCharacters.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownCharacters.Name = "numericUpDownCharacters";
            this.numericUpDownCharacters.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCharacters.TabIndex = 11;
            // 
            // numericUpDownHowMany
            // 
            this.numericUpDownHowMany.Location = new System.Drawing.Point(152, 80);
            this.numericUpDownHowMany.Name = "numericUpDownHowMany";
            this.numericUpDownHowMany.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHowMany.TabIndex = 12;
            // 
            // textBoxPasswordList
            // 
            this.textBoxPasswordList.Location = new System.Drawing.Point(12, 164);
            this.textBoxPasswordList.Multiline = true;
            this.textBoxPasswordList.Name = "textBoxPasswordList";
            this.textBoxPasswordList.Size = new System.Drawing.Size(260, 185);
            this.textBoxPasswordList.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBoxPasswordList);
            this.Controls.Add(this.numericUpDownHowMany);
            this.Controls.Add(this.numericUpDownCharacters);
            this.Controls.Add(this.labelHowMany);
            this.Controls.Add(this.checkBoxMultiple);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelCharacters);
            this.Controls.Add(this.checkBoxMemorizeable);
            this.Controls.Add(this.checkBoxSpecialCharacters);
            this.Controls.Add(this.checkBoxLowerCaseLetters);
            this.Controls.Add(this.checkBoxUpperCaseLetters);
            this.Controls.Add(this.checkBoxDigits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PassGen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHowMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxUpperCaseLetters;
        private System.Windows.Forms.CheckBox checkBoxLowerCaseLetters;
        private System.Windows.Forms.CheckBox checkBoxSpecialCharacters;
        private System.Windows.Forms.CheckBox checkBoxMemorizeable;
        private System.Windows.Forms.Label labelCharacters;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.CheckBox checkBoxMultiple;
        private System.Windows.Forms.Label labelHowMany;
        private System.Windows.Forms.NumericUpDown numericUpDownCharacters;
        private System.Windows.Forms.NumericUpDown numericUpDownHowMany;
        private System.Windows.Forms.TextBox textBoxPasswordList;
    }
}

