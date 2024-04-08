namespace Kalkulator
{
    partial class Kalkulator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            changeSign = new Button();
            zero = new Button();
            point = new Button();
            equal = new Button();
            jeden = new Button();
            dwa = new Button();
            trzy = new Button();
            add = new Button();
            cztery = new Button();
            piec = new Button();
            szesc = new Button();
            minus = new Button();
            siedem = new Button();
            mianownik = new Button();
            osiem = new Button();
            kwadrat = new Button();
            dziewiec = new Button();
            clear = new Button();
            multiply = new Button();
            divide = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // changeSign
            // 
            changeSign.BackColor = Color.LightPink;
            changeSign.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            changeSign.Location = new Point(2, 506);
            changeSign.Name = "changeSign";
            changeSign.Size = new Size(90, 60);
            changeSign.TabIndex = 0;
            changeSign.Text = "+/-";
            changeSign.UseVisualStyleBackColor = false;
            changeSign.Click += changeSign_Click;
            // 
            // zero
            // 
            zero.BackColor = Color.LightPink;
            zero.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zero.Location = new Point(98, 506);
            zero.Name = "zero";
            zero.Size = new Size(90, 60);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += number_Click;
            // 
            // point
            // 
            point.BackColor = Color.LightPink;
            point.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            point.Location = new Point(194, 506);
            point.Name = "point";
            point.Size = new Size(90, 60);
            point.TabIndex = 2;
            point.Text = ",";
            point.UseVisualStyleBackColor = false;
            point.Click += point_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.LightPink;
            equal.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            equal.Location = new Point(290, 506);
            equal.Name = "equal";
            equal.Size = new Size(90, 60);
            equal.TabIndex = 3;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += result_Click;
            // 
            // jeden
            // 
            jeden.BackColor = Color.LightPink;
            jeden.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            jeden.Location = new Point(2, 440);
            jeden.Name = "jeden";
            jeden.Size = new Size(90, 60);
            jeden.TabIndex = 4;
            jeden.Text = "1";
            jeden.UseVisualStyleBackColor = false;
            jeden.Click += number_Click;
            // 
            // dwa
            // 
            dwa.BackColor = Color.LightPink;
            dwa.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dwa.Location = new Point(98, 440);
            dwa.Name = "dwa";
            dwa.Size = new Size(90, 60);
            dwa.TabIndex = 5;
            dwa.Text = "2";
            dwa.UseVisualStyleBackColor = false;
            dwa.Click += number_Click;
            // 
            // trzy
            // 
            trzy.BackColor = Color.LightPink;
            trzy.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            trzy.Location = new Point(194, 440);
            trzy.Name = "trzy";
            trzy.Size = new Size(90, 60);
            trzy.TabIndex = 6;
            trzy.Text = "3";
            trzy.UseVisualStyleBackColor = false;
            trzy.Click += number_Click;
            // 
            // add
            // 
            add.BackColor = Color.LightPink;
            add.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            add.Location = new Point(290, 440);
            add.Name = "add";
            add.Size = new Size(90, 60);
            add.TabIndex = 7;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // cztery
            // 
            cztery.BackColor = Color.LightPink;
            cztery.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cztery.Location = new Point(2, 374);
            cztery.Name = "cztery";
            cztery.Size = new Size(90, 60);
            cztery.TabIndex = 8;
            cztery.Text = "4";
            cztery.UseVisualStyleBackColor = false;
            cztery.Click += number_Click;
            // 
            // piec
            // 
            piec.BackColor = Color.LightPink;
            piec.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            piec.Location = new Point(98, 374);
            piec.Name = "piec";
            piec.Size = new Size(90, 60);
            piec.TabIndex = 9;
            piec.Text = "5";
            piec.UseVisualStyleBackColor = false;
            piec.Click += number_Click;
            // 
            // szesc
            // 
            szesc.BackColor = Color.LightPink;
            szesc.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            szesc.Location = new Point(194, 374);
            szesc.Name = "szesc";
            szesc.Size = new Size(90, 60);
            szesc.TabIndex = 10;
            szesc.Text = "6";
            szesc.UseVisualStyleBackColor = false;
            szesc.Click += number_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.LightPink;
            minus.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            minus.Location = new Point(290, 374);
            minus.Name = "minus";
            minus.Size = new Size(90, 60);
            minus.TabIndex = 11;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += substract_Click;
            // 
            // siedem
            // 
            siedem.BackColor = Color.LightPink;
            siedem.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            siedem.Location = new Point(2, 308);
            siedem.Name = "siedem";
            siedem.Size = new Size(90, 60);
            siedem.TabIndex = 12;
            siedem.Text = "7";
            siedem.UseVisualStyleBackColor = false;
            siedem.Click += number_Click;
            // 
            // mianownik
            // 
            mianownik.BackColor = Color.LightPink;
            mianownik.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mianownik.Location = new Point(2, 242);
            mianownik.Name = "mianownik";
            mianownik.Size = new Size(90, 60);
            mianownik.TabIndex = 13;
            mianownik.Text = "1/x";
            mianownik.UseVisualStyleBackColor = false;
            mianownik.Click += mianownik_Click;
            // 
            // osiem
            // 
            osiem.BackColor = Color.LightPink;
            osiem.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            osiem.Location = new Point(98, 308);
            osiem.Name = "osiem";
            osiem.Size = new Size(90, 60);
            osiem.TabIndex = 14;
            osiem.Text = "8";
            osiem.UseVisualStyleBackColor = false;
            osiem.Click += number_Click;
            // 
            // kwadrat
            // 
            kwadrat.BackColor = Color.LightPink;
            kwadrat.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kwadrat.Location = new Point(98, 242);
            kwadrat.Name = "kwadrat";
            kwadrat.Size = new Size(90, 60);
            kwadrat.TabIndex = 15;
            kwadrat.Text = "x^2";
            kwadrat.UseVisualStyleBackColor = false;
            kwadrat.Click += kwadrat_Click;
            // 
            // dziewiec
            // 
            dziewiec.BackColor = Color.LightPink;
            dziewiec.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dziewiec.Location = new Point(194, 308);
            dziewiec.Name = "dziewiec";
            dziewiec.Size = new Size(90, 60);
            dziewiec.TabIndex = 16;
            dziewiec.Text = "9";
            dziewiec.UseVisualStyleBackColor = false;
            dziewiec.Click += number_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.LightPink;
            clear.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            clear.Location = new Point(194, 242);
            clear.Name = "clear";
            clear.Size = new Size(90, 60);
            clear.TabIndex = 17;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.LightPink;
            multiply.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            multiply.Location = new Point(290, 308);
            multiply.Name = "multiply";
            multiply.Size = new Size(90, 60);
            multiply.TabIndex = 18;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.LightPink;
            divide.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            divide.ForeColor = Color.Black;
            divide.Location = new Point(290, 242);
            divide.Name = "divide";
            divide.Size = new Size(90, 60);
            divide.TabIndex = 19;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.LavenderBlush;
            textBox.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(359, 172);
            textBox.TabIndex = 20;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Kalkulator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(383, 571);
            Controls.Add(textBox);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(clear);
            Controls.Add(dziewiec);
            Controls.Add(kwadrat);
            Controls.Add(osiem);
            Controls.Add(mianownik);
            Controls.Add(siedem);
            Controls.Add(minus);
            Controls.Add(szesc);
            Controls.Add(piec);
            Controls.Add(cztery);
            Controls.Add(add);
            Controls.Add(trzy);
            Controls.Add(dwa);
            Controls.Add(jeden);
            Controls.Add(equal);
            Controls.Add(point);
            Controls.Add(zero);
            Controls.Add(changeSign);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Kalkulator";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeSign;
        private Button zero;
        private Button point;
        private Button equal;
        private Button jeden;
        private Button dwa;
        private Button trzy;
        private Button add;
        private Button cztery;
        private Button piec;
        private Button szesc;
        private Button minus;
        private Button siedem;
        private Button mianownik;
        private Button osiem;
        private Button kwadrat;
        private Button dziewiec;
        private Button clear;
        private Button multiply;
        private Button divide;
        private TextBox textBox;
    }
}
