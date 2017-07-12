using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharpCalculator
{
    partial class MainForm
    {
        private Button abs;
        private Button add;
        private Button angle;
        private Button arccos;
        private Button arccosGrad;
        private Button arcsin;
        private Button arcsinGrad;
        private Button arctg;
        private Button arith;

        /// <summary>
        ///     Обязательная переменная конструктора.
        /// </summary>
        private readonly IContainer components = null;

        private Button cos;
        private Button cosGrad;
        private Button ctg;
        private Button divide;
        private Button exp;
        private Button exp_xy;
        private Button exp_xy_rev;
        private Button exp10;
        private Button exp2;
        private TextBox firstInputField;
        private Button geom;
        private Button gradToRad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button integer;
        private Button invert;
        private Button lg;
        private Button ln;
        private Button log;
        private Button logxy;
        private Button maximum;
        private Button minimum;
        private Button multiply;
        private TextBox outputField;
        private Button radius;
        private Button radToGrad;
        private Button remain;
        private Button rev;
        private TextBox secondInputField;
        private Button sin;
        private Button sinGrad;
        private Button sqr;
        private Button sqrt;
        private Button substract;
        private Button tg;

        /// <summary>
        ///     Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        ///     Требуемый метод для поддержки конструктора — не изменяйте
        ///     содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            firstInputField = new TextBox();
            secondInputField = new TextBox();
            outputField = new TextBox();
            groupBox1 = new GroupBox();
            invert = new Button();
            sqr = new Button();
            lg = new Button();
            log = new Button();
            ln = new Button();
            sqrt = new Button();
            radToGrad = new Button();
            gradToRad = new Button();
            exp10 = new Button();
            exp2 = new Button();
            exp = new Button();
            arccosGrad = new Button();
            arcsinGrad = new Button();
            cosGrad = new Button();
            sinGrad = new Button();
            cos = new Button();
            tg = new Button();
            ctg = new Button();
            rev = new Button();
            arcsin = new Button();
            arccos = new Button();
            arctg = new Button();
            abs = new Button();
            sin = new Button();
            groupBox2 = new GroupBox();
            arith = new Button();
            geom = new Button();
            integer = new Button();
            maximum = new Button();
            remain = new Button();
            minimum = new Button();
            exp_xy = new Button();
            logxy = new Button();
            add = new Button();
            angle = new Button();
            exp_xy_rev = new Button();
            divide = new Button();
            radius = new Button();
            multiply = new Button();
            substract = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // firstInputField
            // 
            firstInputField.AllowDrop = true;
            firstInputField.CharacterCasing = CharacterCasing.Lower;
            firstInputField.Location = new Point(12, 31);
            firstInputField.Name = "firstInputField";
            firstInputField.Size = new Size(200, 20);
            firstInputField.TabIndex = 1;
            // 
            // secondInputField
            // 
            secondInputField.AllowDrop = true;
            secondInputField.CharacterCasing = CharacterCasing.Lower;
            secondInputField.Location = new Point(12, 61);
            secondInputField.Name = "secondInputField";
            secondInputField.Size = new Size(200, 20);
            secondInputField.TabIndex = 2;
            // 
            // outputField
            // 
            outputField.Location = new Point(12, 91);
            outputField.Name = "outputField";
            outputField.ReadOnly = true;
            outputField.Size = new Size(200, 20);
            outputField.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(invert);
            groupBox1.Controls.Add(sqr);
            groupBox1.Controls.Add(lg);
            groupBox1.Controls.Add(log);
            groupBox1.Controls.Add(ln);
            groupBox1.Controls.Add(sqrt);
            groupBox1.Controls.Add(radToGrad);
            groupBox1.Controls.Add(gradToRad);
            groupBox1.Controls.Add(exp10);
            groupBox1.Controls.Add(exp2);
            groupBox1.Controls.Add(exp);
            groupBox1.Controls.Add(arccosGrad);
            groupBox1.Controls.Add(arcsinGrad);
            groupBox1.Controls.Add(cosGrad);
            groupBox1.Controls.Add(sinGrad);
            groupBox1.Controls.Add(cos);
            groupBox1.Controls.Add(tg);
            groupBox1.Controls.Add(ctg);
            groupBox1.Controls.Add(rev);
            groupBox1.Controls.Add(arcsin);
            groupBox1.Controls.Add(arccos);
            groupBox1.Controls.Add(arctg);
            groupBox1.Controls.Add(abs);
            groupBox1.Controls.Add(sin);
            groupBox1.Location = new Point(230, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 222);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "One argument";
            // 
            // invert
            // 
            invert.Location = new Point(321, 79);
            invert.Name = "invert";
            invert.Size = new Size(100, 20);
            invert.TabIndex = 56;
            invert.Text = "-x";
            invert.UseVisualStyleBackColor = true;
            invert.Click += OneArgumentOperationButtonClick;
            // 
            // sqr
            // 
            sqr.Location = new Point(321, 169);
            sqr.Name = "sqr";
            sqr.Size = new Size(100, 20);
            sqr.TabIndex = 55;
            sqr.Text = "x^2";
            sqr.UseVisualStyleBackColor = true;
            sqr.Click += OneArgumentOperationButtonClick;
            // 
            // lg
            // 
            lg.Location = new Point(216, 169);
            lg.Name = "lg";
            lg.Size = new Size(100, 20);
            lg.TabIndex = 54;
            lg.Text = "lg(x)";
            lg.UseVisualStyleBackColor = true;
            lg.Click += OneArgumentOperationButtonClick;
            // 
            // log
            // 
            log.Location = new Point(111, 169);
            log.Name = "log";
            log.Size = new Size(100, 20);
            log.TabIndex = 53;
            log.Text = "log2(x)";
            log.UseVisualStyleBackColor = true;
            log.Click += OneArgumentOperationButtonClick;
            // 
            // ln
            // 
            ln.Location = new Point(6, 169);
            ln.Name = "ln";
            ln.Size = new Size(100, 20);
            ln.TabIndex = 52;
            ln.Text = "ln(x)";
            ln.UseVisualStyleBackColor = true;
            ln.Click += OneArgumentOperationButtonClick;
            // 
            // sqrt
            // 
            sqrt.Location = new Point(321, 139);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(100, 20);
            sqrt.TabIndex = 51;
            sqrt.Text = "√x";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += OneArgumentOperationButtonClick;
            // 
            // radToGrad
            // 
            radToGrad.Location = new Point(321, 109);
            radToGrad.Name = "radToGrad";
            radToGrad.Size = new Size(100, 20);
            radToGrad.TabIndex = 50;
            radToGrad.Text = "rad to grad";
            radToGrad.UseVisualStyleBackColor = true;
            radToGrad.Click += OneArgumentOperationButtonClick;
            // 
            // gradToRad
            // 
            gradToRad.Location = new Point(216, 109);
            gradToRad.Name = "gradToRad";
            gradToRad.Size = new Size(100, 20);
            gradToRad.TabIndex = 49;
            gradToRad.Text = "grad to rad";
            gradToRad.UseVisualStyleBackColor = true;
            gradToRad.Click += OneArgumentOperationButtonClick;
            // 
            // exp10
            // 
            exp10.Location = new Point(216, 139);
            exp10.Name = "exp10";
            exp10.Size = new Size(100, 20);
            exp10.TabIndex = 48;
            exp10.Text = "10^x";
            exp10.UseVisualStyleBackColor = true;
            exp10.Click += OneArgumentOperationButtonClick;
            // 
            // exp2
            // 
            exp2.Location = new Point(111, 139);
            exp2.Name = "exp2";
            exp2.Size = new Size(100, 20);
            exp2.TabIndex = 47;
            exp2.Text = "2^x";
            exp2.UseVisualStyleBackColor = true;
            exp2.Click += OneArgumentOperationButtonClick;
            // 
            // exp
            // 
            exp.Location = new Point(6, 139);
            exp.Name = "exp";
            exp.Size = new Size(100, 20);
            exp.TabIndex = 46;
            exp.Text = "e^x";
            exp.UseVisualStyleBackColor = true;
            exp.Click += OneArgumentOperationButtonClick;
            // 
            // arccosGrad
            // 
            arccosGrad.Location = new Point(321, 49);
            arccosGrad.Name = "arccosGrad";
            arccosGrad.Size = new Size(100, 20);
            arccosGrad.TabIndex = 45;
            arccosGrad.Text = "arccosGrad(x)";
            arccosGrad.UseVisualStyleBackColor = true;
            arccosGrad.Click += OneArgumentOperationButtonClick;
            // 
            // arcsinGrad
            // 
            arcsinGrad.Location = new Point(321, 19);
            arcsinGrad.Name = "arcsinGrad";
            arcsinGrad.Size = new Size(100, 20);
            arcsinGrad.TabIndex = 44;
            arcsinGrad.Text = "arcsinGrad(x)";
            arcsinGrad.UseVisualStyleBackColor = true;
            arcsinGrad.Click += OneArgumentOperationButtonClick;
            // 
            // cosGrad
            // 
            cosGrad.Location = new Point(111, 49);
            cosGrad.Name = "cosGrad";
            cosGrad.Size = new Size(100, 20);
            cosGrad.TabIndex = 43;
            cosGrad.Text = "cosGrad(x)";
            cosGrad.UseVisualStyleBackColor = true;
            cosGrad.Click += OneArgumentOperationButtonClick;
            // 
            // sinGrad
            // 
            sinGrad.Location = new Point(111, 19);
            sinGrad.Name = "sinGrad";
            sinGrad.Size = new Size(100, 20);
            sinGrad.TabIndex = 42;
            sinGrad.Text = "sinGrad(x)";
            sinGrad.UseVisualStyleBackColor = true;
            sinGrad.Click += OneArgumentOperationButtonClick;
            // 
            // cos
            // 
            cos.Location = new Point(6, 49);
            cos.Name = "cos";
            cos.Size = new Size(100, 20);
            cos.TabIndex = 41;
            cos.Text = "cos(x)";
            cos.UseVisualStyleBackColor = true;
            cos.Click += OneArgumentOperationButtonClick;
            // 
            // tg
            // 
            tg.Location = new Point(6, 79);
            tg.Name = "tg";
            tg.Size = new Size(100, 20);
            tg.TabIndex = 40;
            tg.Text = "tg(x)";
            tg.UseVisualStyleBackColor = true;
            tg.Click += OneArgumentOperationButtonClick;
            // 
            // ctg
            // 
            ctg.Location = new Point(111, 79);
            ctg.Name = "ctg";
            ctg.Size = new Size(100, 20);
            ctg.TabIndex = 39;
            ctg.Text = "ctg(x)";
            ctg.UseVisualStyleBackColor = true;
            ctg.Click += OneArgumentOperationButtonClick;
            // 
            // rev
            // 
            rev.Location = new Point(111, 109);
            rev.Name = "rev";
            rev.Size = new Size(100, 20);
            rev.TabIndex = 38;
            rev.Text = "1/x";
            rev.UseVisualStyleBackColor = true;
            rev.Click += OneArgumentOperationButtonClick;
            // 
            // arcsin
            // 
            arcsin.Location = new Point(216, 19);
            arcsin.Name = "arcsin";
            arcsin.Size = new Size(100, 20);
            arcsin.TabIndex = 37;
            arcsin.Text = "arcsin(x)";
            arcsin.UseVisualStyleBackColor = true;
            arcsin.Click += OneArgumentOperationButtonClick;
            // 
            // arccos
            // 
            arccos.Location = new Point(216, 49);
            arccos.Name = "arccos";
            arccos.Size = new Size(100, 20);
            arccos.TabIndex = 36;
            arccos.Text = "arccos(x)";
            arccos.UseVisualStyleBackColor = true;
            arccos.Click += OneArgumentOperationButtonClick;
            // 
            // arctg
            // 
            arctg.Location = new Point(216, 79);
            arctg.Name = "arctg";
            arctg.Size = new Size(100, 20);
            arctg.TabIndex = 35;
            arctg.Text = "arctg(x)";
            arctg.UseVisualStyleBackColor = true;
            arctg.Click += OneArgumentOperationButtonClick;
            // 
            // abs
            // 
            abs.Location = new Point(6, 109);
            abs.Name = "abs";
            abs.Size = new Size(100, 20);
            abs.TabIndex = 34;
            abs.Text = "|x|";
            abs.UseVisualStyleBackColor = true;
            abs.Click += OneArgumentOperationButtonClick;
            // 
            // sin
            // 
            sin.Location = new Point(6, 19);
            sin.Name = "sin";
            sin.Size = new Size(100, 20);
            sin.TabIndex = 33;
            sin.Text = "sin(x)";
            sin.UseVisualStyleBackColor = true;
            sin.Click += OneArgumentOperationButtonClick;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(arith);
            groupBox2.Controls.Add(geom);
            groupBox2.Controls.Add(integer);
            groupBox2.Controls.Add(maximum);
            groupBox2.Controls.Add(remain);
            groupBox2.Controls.Add(minimum);
            groupBox2.Controls.Add(exp_xy);
            groupBox2.Controls.Add(logxy);
            groupBox2.Controls.Add(add);
            groupBox2.Controls.Add(angle);
            groupBox2.Controls.Add(exp_xy_rev);
            groupBox2.Controls.Add(divide);
            groupBox2.Controls.Add(radius);
            groupBox2.Controls.Add(multiply);
            groupBox2.Controls.Add(substract);
            groupBox2.Location = new Point(230, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 191);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Two arguments";
            // 
            // arith
            // 
            arith.Cursor = Cursors.Hand;
            arith.Location = new Point(109, 115);
            arith.Name = "arith";
            arith.Size = new Size(95, 20);
            arith.TabIndex = 54;
            arith.Text = "Arith";
            arith.UseVisualStyleBackColor = true;
            arith.Click += TwoArgumentOperationButtonClick;
            // 
            // geom
            // 
            geom.Cursor = Cursors.Hand;
            geom.Location = new Point(210, 115);
            geom.Name = "geom";
            geom.Size = new Size(95, 20);
            geom.TabIndex = 53;
            geom.Text = "Geom";
            geom.UseVisualStyleBackColor = true;
            geom.Click += TwoArgumentOperationButtonClick;
            // 
            // integer
            // 
            integer.Cursor = Cursors.Hand;
            integer.Location = new Point(11, 115);
            integer.Name = "integer";
            integer.Size = new Size(95, 20);
            integer.TabIndex = 52;
            integer.Text = "Integer";
            integer.UseVisualStyleBackColor = true;
            integer.Click += TwoArgumentOperationButtonClick;
            // 
            // maximum
            // 
            maximum.Cursor = Cursors.Hand;
            maximum.Location = new Point(311, 59);
            maximum.Name = "maximum";
            maximum.Size = new Size(95, 20);
            maximum.TabIndex = 51;
            maximum.Text = "Max";
            maximum.UseVisualStyleBackColor = true;
            maximum.Click += TwoArgumentOperationButtonClick;
            // 
            // remain
            // 
            remain.Cursor = Cursors.Hand;
            remain.Location = new Point(311, 89);
            remain.Name = "remain";
            remain.Size = new Size(95, 20);
            remain.TabIndex = 50;
            remain.Text = "Remain";
            remain.UseVisualStyleBackColor = true;
            remain.Click += TwoArgumentOperationButtonClick;
            // 
            // minimum
            // 
            minimum.Cursor = Cursors.Hand;
            minimum.Location = new Point(311, 29);
            minimum.Name = "minimum";
            minimum.Size = new Size(95, 20);
            minimum.TabIndex = 49;
            minimum.Text = "Min";
            minimum.UseVisualStyleBackColor = true;
            minimum.Click += TwoArgumentOperationButtonClick;
            // 
            // exp_xy
            // 
            exp_xy.Cursor = Cursors.Hand;
            exp_xy.Location = new Point(210, 29);
            exp_xy.Name = "exp_xy";
            exp_xy.Size = new Size(95, 20);
            exp_xy.TabIndex = 44;
            exp_xy.Text = "x ^ y";
            exp_xy.UseVisualStyleBackColor = true;
            exp_xy.Click += TwoArgumentOperationButtonClick;
            // 
            // logxy
            // 
            logxy.Cursor = Cursors.Hand;
            logxy.Location = new Point(210, 59);
            logxy.Name = "logxy";
            logxy.Size = new Size(95, 20);
            logxy.TabIndex = 46;
            logxy.Text = "logx(y)";
            logxy.UseVisualStyleBackColor = true;
            logxy.Click += TwoArgumentOperationButtonClick;
            // 
            // add
            // 
            add.Cursor = Cursors.Hand;
            add.Location = new Point(11, 29);
            add.Name = "add";
            add.Size = new Size(95, 20);
            add.TabIndex = 40;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += TwoArgumentOperationButtonClick;
            // 
            // angle
            // 
            angle.Cursor = Cursors.Hand;
            angle.Location = new Point(109, 89);
            angle.Name = "angle";
            angle.Size = new Size(95, 20);
            angle.TabIndex = 48;
            angle.Text = "angle (polar)";
            angle.UseVisualStyleBackColor = true;
            angle.Click += TwoArgumentOperationButtonClick;
            // 
            // exp_xy_rev
            // 
            exp_xy_rev.Cursor = Cursors.Hand;
            exp_xy_rev.Location = new Point(210, 89);
            exp_xy_rev.Name = "exp_xy_rev";
            exp_xy_rev.Size = new Size(95, 20);
            exp_xy_rev.TabIndex = 45;
            exp_xy_rev.Text = "x ^ (1 / y)";
            exp_xy_rev.UseVisualStyleBackColor = true;
            exp_xy_rev.Click += TwoArgumentOperationButtonClick;
            // 
            // divide
            // 
            divide.Cursor = Cursors.Hand;
            divide.Location = new Point(111, 59);
            divide.Name = "divide";
            divide.Size = new Size(95, 20);
            divide.TabIndex = 43;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += TwoArgumentOperationButtonClick;
            // 
            // radius
            // 
            radius.Cursor = Cursors.Hand;
            radius.Location = new Point(11, 89);
            radius.Name = "radius";
            radius.Size = new Size(95, 20);
            radius.TabIndex = 47;
            radius.Text = "radius (polar)";
            radius.UseVisualStyleBackColor = true;
            radius.Click += TwoArgumentOperationButtonClick;
            // 
            // multiply
            // 
            multiply.Cursor = Cursors.Hand;
            multiply.Location = new Point(111, 29);
            multiply.Name = "multiply";
            multiply.Size = new Size(95, 20);
            multiply.TabIndex = 42;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += TwoArgumentOperationButtonClick;
            // 
            // substract
            // 
            substract.Cursor = Cursors.Hand;
            substract.Location = new Point(11, 59);
            substract.Name = "substract";
            substract.Size = new Size(95, 20);
            substract.TabIndex = 41;
            substract.Text = "-";
            substract.UseVisualStyleBackColor = true;
            substract.Click += TwoArgumentOperationButtonClick;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(669, 441);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(outputField);
            Controls.Add(secondInputField);
            Controls.Add(firstInputField);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}