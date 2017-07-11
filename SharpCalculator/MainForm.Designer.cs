namespace SharpCalculator
{
    partial class MainForm
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
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.firstInputField = new System.Windows.Forms.TextBox();
            this.secondInputField = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.TextBox();
            this.sin = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.rev = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(35, 90);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 20);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // substract
            // 
            this.substract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.substract.Location = new System.Drawing.Point(35, 120);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(75, 20);
            this.substract.TabIndex = 4;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // multiply
            // 
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Location = new System.Drawing.Point(150, 90);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 20);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // divide
            // 
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Location = new System.Drawing.Point(150, 120);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 20);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // firstInputField
            // 
            this.firstInputField.AllowDrop = true;
            this.firstInputField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.firstInputField.Location = new System.Drawing.Point(30, 30);
            this.firstInputField.Name = "firstInputField";
            this.firstInputField.Size = new System.Drawing.Size(200, 20);
            this.firstInputField.TabIndex = 1;
            // 
            // secondInputField
            // 
            this.secondInputField.AllowDrop = true;
            this.secondInputField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.secondInputField.Location = new System.Drawing.Point(30, 60);
            this.secondInputField.Name = "secondInputField";
            this.secondInputField.Size = new System.Drawing.Size(200, 20);
            this.secondInputField.TabIndex = 2;
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(30, 150);
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(200, 20);
            this.outputField.TabIndex = 7;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(35, 177);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 8;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // abs
            // 
            this.abs.Location = new System.Drawing.Point(150, 263);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(75, 23);
            this.abs.TabIndex = 10;
            this.abs.Text = "|x|";
            this.abs.UseVisualStyleBackColor = true;
            this.abs.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(150, 234);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 11;
            this.arctg.Text = "arctg(x)";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(150, 205);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 12;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(150, 176);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 13;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // rev
            // 
            this.rev.Location = new System.Drawing.Point(35, 293);
            this.rev.Name = "rev";
            this.rev.Size = new System.Drawing.Size(75, 23);
            this.rev.TabIndex = 14;
            this.rev.Text = "1/x";
            this.rev.UseVisualStyleBackColor = true;
            this.rev.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(35, 264);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(75, 23);
            this.ctg.TabIndex = 15;
            this.ctg.Text = "ctg(x)";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(35, 235);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 16;
            this.tg.Text = "tg(x)";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(35, 206);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 17;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 336);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.rev);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.abs);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.secondInputField);
            this.Controls.Add(this.firstInputField);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox firstInputField;
        private System.Windows.Forms.TextBox secondInputField;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button arctg;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button rev;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button cos;
    }
}

