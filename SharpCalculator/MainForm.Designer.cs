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
            this.add.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(264, 211);
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
    }
}

