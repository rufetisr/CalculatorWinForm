namespace CalcForm
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.point_button = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.subs_button = new System.Windows.Forms.Button();
            this.mult_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.ce_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(31, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.operator_click);
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n1.Location = new System.Drawing.Point(31, 213);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(79, 48);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.button_click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n2.Location = new System.Drawing.Point(125, 214);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(79, 48);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.button_click);
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n3.Location = new System.Drawing.Point(219, 213);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(79, 48);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.button_click);
            // 
            // n8
            // 
            this.n8.AutoSize = true;
            this.n8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n8.Location = new System.Drawing.Point(125, 104);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(79, 48);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.button_click);
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n4.Location = new System.Drawing.Point(31, 157);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(79, 48);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.button_click);
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n5.Location = new System.Drawing.Point(125, 158);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(79, 48);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.button_click);
            // 
            // n6
            // 
            this.n6.AutoSize = true;
            this.n6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n6.Location = new System.Drawing.Point(219, 157);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(79, 48);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.button_click);
            // 
            // n0
            // 
            this.n0.AutoSize = true;
            this.n0.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n0.Location = new System.Drawing.Point(31, 267);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(173, 48);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.button_click);
            // 
            // point_button
            // 
            this.point_button.AutoSize = true;
            this.point_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.point_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.point_button.Location = new System.Drawing.Point(219, 267);
            this.point_button.Name = "point_button";
            this.point_button.Size = new System.Drawing.Size(79, 48);
            this.point_button.TabIndex = 1;
            this.point_button.Text = ".";
            this.point_button.UseVisualStyleBackColor = true;
            this.point_button.Click += new System.EventHandler(this.button_click);
            // 
            // n9
            // 
            this.n9.AutoSize = true;
            this.n9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n9.Location = new System.Drawing.Point(219, 104);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(79, 48);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.button_click);
            // 
            // n7
            // 
            this.n7.AutoSize = true;
            this.n7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.n7.Location = new System.Drawing.Point(31, 104);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(79, 48);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.button_click);
            // 
            // equal_button
            // 
            this.equal_button.AutoSize = true;
            this.equal_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equal_button.Location = new System.Drawing.Point(391, 214);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(79, 101);
            this.equal_button.TabIndex = 1;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = true;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.AutoSize = true;
            this.plus_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plus_button.Location = new System.Drawing.Point(306, 267);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(79, 48);
            this.plus_button.TabIndex = 1;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.operator_click);
            // 
            // subs_button
            // 
            this.subs_button.AutoSize = true;
            this.subs_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subs_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subs_button.Location = new System.Drawing.Point(306, 213);
            this.subs_button.Name = "subs_button";
            this.subs_button.Size = new System.Drawing.Size(79, 48);
            this.subs_button.TabIndex = 1;
            this.subs_button.Text = "-";
            this.subs_button.UseVisualStyleBackColor = true;
            this.subs_button.Click += new System.EventHandler(this.operator_click);
            // 
            // mult_button
            // 
            this.mult_button.AutoSize = true;
            this.mult_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mult_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mult_button.Location = new System.Drawing.Point(306, 158);
            this.mult_button.Name = "mult_button";
            this.mult_button.Size = new System.Drawing.Size(79, 48);
            this.mult_button.TabIndex = 1;
            this.mult_button.Text = "*";
            this.mult_button.UseVisualStyleBackColor = true;
            this.mult_button.Click += new System.EventHandler(this.operator_click);
            // 
            // div_button
            // 
            this.div_button.AutoSize = true;
            this.div_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.div_button.Location = new System.Drawing.Point(306, 104);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(79, 48);
            this.div_button.TabIndex = 1;
            this.div_button.Text = "/";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.operator_click);
            // 
            // ce_button
            // 
            this.ce_button.AutoSize = true;
            this.ce_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ce_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ce_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ce_button.Location = new System.Drawing.Point(391, 104);
            this.ce_button.Name = "ce_button";
            this.ce_button.Size = new System.Drawing.Size(79, 48);
            this.ce_button.TabIndex = 1;
            this.ce_button.Text = "CE";
            this.ce_button.UseVisualStyleBackColor = true;
            this.ce_button.Click += new System.EventHandler(this.ce_button_Click);
            // 
            // c_button
            // 
            this.c_button.AutoSize = true;
            this.c_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c_button.Location = new System.Drawing.Point(391, 157);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(79, 48);
            this.c_button.TabIndex = 1;
            this.c_button.Text = "C";
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.ce_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 22);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(511, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.point_button);
            this.Controls.Add(this.div_button);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.mult_button);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.subs_button);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.ce_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MinimumSize = new System.Drawing.Size(529, 412);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n8;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n0;
        private Button point_button;
        private Button n9;
        private Button n7;
        private Button equal_button;
        private Button plus_button;
        private Button subs_button;
        private Button mult_button;
        private Button div_button;
        private Button ce_button;
        private Button c_button;
        private Label label1;
    }
}