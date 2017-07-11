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
            this.firstInputField = new System.Windows.Forms.TextBox();
            this.secondInputField = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqr = new System.Windows.Forms.Button();
            this.lg = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.radToGrad = new System.Windows.Forms.Button();
            this.gradToRad = new System.Windows.Forms.Button();
            this.exp10 = new System.Windows.Forms.Button();
            this.exp2 = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.arccosGrad = new System.Windows.Forms.Button();
            this.arcsinGrad = new System.Windows.Forms.Button();
            this.cosGrad = new System.Windows.Forms.Button();
            this.sinGrad = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.rev = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exp_xy = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.radius = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.exp_xy_rev = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstInputField
            // 
            this.firstInputField.AllowDrop = true;
            this.firstInputField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.firstInputField.Location = new System.Drawing.Point(12, 31);
            this.firstInputField.Name = "firstInputField";
            this.firstInputField.Size = new System.Drawing.Size(200, 20);
            this.firstInputField.TabIndex = 1;
            // 
            // secondInputField
            // 
            this.secondInputField.AllowDrop = true;
            this.secondInputField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.secondInputField.Location = new System.Drawing.Point(12, 61);
            this.secondInputField.Name = "secondInputField";
            this.secondInputField.Size = new System.Drawing.Size(200, 20);
            this.secondInputField.TabIndex = 2;
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(12, 91);
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(200, 20);
            this.outputField.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.sqr);
            this.groupBox1.Controls.Add(this.lg);
            this.groupBox1.Controls.Add(this.log);
            this.groupBox1.Controls.Add(this.ln);
            this.groupBox1.Controls.Add(this.sqrt);
            this.groupBox1.Controls.Add(this.radToGrad);
            this.groupBox1.Controls.Add(this.gradToRad);
            this.groupBox1.Controls.Add(this.exp10);
            this.groupBox1.Controls.Add(this.exp2);
            this.groupBox1.Controls.Add(this.exp);
            this.groupBox1.Controls.Add(this.arccosGrad);
            this.groupBox1.Controls.Add(this.arcsinGrad);
            this.groupBox1.Controls.Add(this.cosGrad);
            this.groupBox1.Controls.Add(this.sinGrad);
            this.groupBox1.Controls.Add(this.cos);
            this.groupBox1.Controls.Add(this.tg);
            this.groupBox1.Controls.Add(this.ctg);
            this.groupBox1.Controls.Add(this.rev);
            this.groupBox1.Controls.Add(this.arcsin);
            this.groupBox1.Controls.Add(this.arccos);
            this.groupBox1.Controls.Add(this.arctg);
            this.groupBox1.Controls.Add(this.abs);
            this.groupBox1.Controls.Add(this.sin);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 222);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "One argument";
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(321, 169);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(100, 20);
            this.sqr.TabIndex = 55;
            this.sqr.Text = "x^2";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // lg
            // 
            this.lg.Location = new System.Drawing.Point(216, 169);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(100, 20);
            this.lg.TabIndex = 54;
            this.lg.Text = "lg(x)";
            this.lg.UseVisualStyleBackColor = true;
            this.lg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(111, 169);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 20);
            this.log.TabIndex = 53;
            this.log.Text = "log2(x)";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(6, 169);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(100, 20);
            this.ln.TabIndex = 52;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(321, 139);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(100, 20);
            this.sqrt.TabIndex = 51;
            this.sqrt.Text = "√x";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // radToGrad
            // 
            this.radToGrad.Location = new System.Drawing.Point(321, 109);
            this.radToGrad.Name = "radToGrad";
            this.radToGrad.Size = new System.Drawing.Size(100, 20);
            this.radToGrad.TabIndex = 50;
            this.radToGrad.Text = "rad to grad";
            this.radToGrad.UseVisualStyleBackColor = true;
            this.radToGrad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // gradToRad
            // 
            this.gradToRad.Location = new System.Drawing.Point(216, 109);
            this.gradToRad.Name = "gradToRad";
            this.gradToRad.Size = new System.Drawing.Size(100, 20);
            this.gradToRad.TabIndex = 49;
            this.gradToRad.Text = "grad to rad";
            this.gradToRad.UseVisualStyleBackColor = true;
            this.gradToRad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // exp10
            // 
            this.exp10.Location = new System.Drawing.Point(216, 139);
            this.exp10.Name = "exp10";
            this.exp10.Size = new System.Drawing.Size(100, 20);
            this.exp10.TabIndex = 48;
            this.exp10.Text = "10^x";
            this.exp10.UseVisualStyleBackColor = true;
            this.exp10.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // exp2
            // 
            this.exp2.Location = new System.Drawing.Point(111, 139);
            this.exp2.Name = "exp2";
            this.exp2.Size = new System.Drawing.Size(100, 20);
            this.exp2.TabIndex = 47;
            this.exp2.Text = "2^x";
            this.exp2.UseVisualStyleBackColor = true;
            this.exp2.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(6, 139);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(100, 20);
            this.exp.TabIndex = 46;
            this.exp.Text = "e^x";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arccosGrad
            // 
            this.arccosGrad.Location = new System.Drawing.Point(321, 49);
            this.arccosGrad.Name = "arccosGrad";
            this.arccosGrad.Size = new System.Drawing.Size(100, 20);
            this.arccosGrad.TabIndex = 45;
            this.arccosGrad.Text = "arccosGrad(x)";
            this.arccosGrad.UseVisualStyleBackColor = true;
            this.arccosGrad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arcsinGrad
            // 
            this.arcsinGrad.Location = new System.Drawing.Point(321, 19);
            this.arcsinGrad.Name = "arcsinGrad";
            this.arcsinGrad.Size = new System.Drawing.Size(100, 20);
            this.arcsinGrad.TabIndex = 44;
            this.arcsinGrad.Text = "arcsinGrad(x)";
            this.arcsinGrad.UseVisualStyleBackColor = true;
            this.arcsinGrad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // cosGrad
            // 
            this.cosGrad.Location = new System.Drawing.Point(111, 49);
            this.cosGrad.Name = "cosGrad";
            this.cosGrad.Size = new System.Drawing.Size(100, 20);
            this.cosGrad.TabIndex = 43;
            this.cosGrad.Text = "cosGrad(x)";
            this.cosGrad.UseVisualStyleBackColor = true;
            this.cosGrad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // sinGrad
            // 
            this.sinGrad.Location = new System.Drawing.Point(111, 19);
            this.sinGrad.Name = "sinGrad";
            this.sinGrad.Size = new System.Drawing.Size(100, 20);
            this.sinGrad.TabIndex = 42;
            this.sinGrad.Text = "sinGrad(x)";
            this.sinGrad.UseVisualStyleBackColor = true;
            this.sinGrad.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(6, 49);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(100, 20);
            this.cos.TabIndex = 41;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(6, 79);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(100, 20);
            this.tg.TabIndex = 40;
            this.tg.Text = "tg(x)";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(111, 79);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(100, 20);
            this.ctg.TabIndex = 39;
            this.ctg.Text = "ctg(x)";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // rev
            // 
            this.rev.Location = new System.Drawing.Point(111, 109);
            this.rev.Name = "rev";
            this.rev.Size = new System.Drawing.Size(100, 20);
            this.rev.TabIndex = 38;
            this.rev.Text = "1/x";
            this.rev.UseVisualStyleBackColor = true;
            this.rev.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(216, 19);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(100, 20);
            this.arcsin.TabIndex = 37;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(216, 49);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(100, 20);
            this.arccos.TabIndex = 36;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(216, 79);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(100, 20);
            this.arctg.TabIndex = 35;
            this.arctg.Text = "arctg(x)";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // abs
            // 
            this.abs.Location = new System.Drawing.Point(6, 109);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(100, 20);
            this.abs.TabIndex = 34;
            this.abs.Text = "|x|";
            this.abs.UseVisualStyleBackColor = true;
            this.abs.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(6, 19);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(100, 20);
            this.sin.TabIndex = 33;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperationButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.exp_xy);
            this.groupBox2.Controls.Add(this.logxy);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.angle);
            this.groupBox2.Controls.Add(this.exp_xy_rev);
            this.groupBox2.Controls.Add(this.divide);
            this.groupBox2.Controls.Add(this.radius);
            this.groupBox2.Controls.Add(this.multiply);
            this.groupBox2.Controls.Add(this.substract);
            this.groupBox2.Location = new System.Drawing.Point(230, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 191);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Two arguments";
            // 
            // exp_xy
            // 
            this.exp_xy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exp_xy.Location = new System.Drawing.Point(210, 29);
            this.exp_xy.Name = "exp_xy";
            this.exp_xy.Size = new System.Drawing.Size(95, 20);
            this.exp_xy.TabIndex = 44;
            this.exp_xy.Text = "x ^ y";
            this.exp_xy.UseVisualStyleBackColor = true;
            this.exp_xy.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(11, 29);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 20);
            this.add.TabIndex = 40;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // angle
            // 
            this.angle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.angle.Location = new System.Drawing.Point(109, 89);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(95, 20);
            this.angle.TabIndex = 48;
            this.angle.Text = "angle (polar)";
            this.angle.UseVisualStyleBackColor = true;
            this.angle.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // substract
            // 
            this.substract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.substract.Location = new System.Drawing.Point(11, 59);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(95, 20);
            this.substract.TabIndex = 41;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // radius
            // 
            this.radius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radius.Location = new System.Drawing.Point(11, 89);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(95, 20);
            this.radius.TabIndex = 47;
            this.radius.Text = "radius (polar)";
            this.radius.UseVisualStyleBackColor = true;
            this.radius.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // multiply
            // 
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Location = new System.Drawing.Point(111, 29);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(95, 20);
            this.multiply.TabIndex = 42;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // logxy
            // 
            this.logxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logxy.Location = new System.Drawing.Point(210, 59);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(95, 20);
            this.logxy.TabIndex = 46;
            this.logxy.Text = "logx(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // exp_xy_rev
            // 
            this.exp_xy_rev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exp_xy_rev.Location = new System.Drawing.Point(210, 89);
            this.exp_xy_rev.Name = "exp_xy_rev";
            this.exp_xy_rev.Size = new System.Drawing.Size(95, 20);
            this.exp_xy_rev.TabIndex = 45;
            this.exp_xy_rev.Text = "x ^ (1 / y)";
            this.exp_xy_rev.UseVisualStyleBackColor = true;
            this.exp_xy_rev.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // divide
            // 
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Location = new System.Drawing.Point(111, 59);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(95, 20);
            this.divide.TabIndex = 43;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.TwoArgumentOperationButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(669, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.secondInputField);
            this.Controls.Add(this.firstInputField);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstInputField;
        private System.Windows.Forms.TextBox secondInputField;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button radToGrad;
        private System.Windows.Forms.Button gradToRad;
        private System.Windows.Forms.Button exp10;
        private System.Windows.Forms.Button exp2;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button arccosGrad;
        private System.Windows.Forms.Button arcsinGrad;
        private System.Windows.Forms.Button cosGrad;
        private System.Windows.Forms.Button sinGrad;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button rev;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arctg;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exp_xy;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button angle;
        private System.Windows.Forms.Button exp_xy_rev;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button radius;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button substract;
    }
}

