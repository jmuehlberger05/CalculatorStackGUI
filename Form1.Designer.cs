
namespace CalculatorStackGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.real = new System.Windows.Forms.NumericUpDown();
            this.real_label = new System.Windows.Forms.Label();
            this.imag_label = new System.Windows.Forms.Label();
            this.imag = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            this.push = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.Button();
            this.dup = new System.Windows.Forms.Button();
            this.pop = new System.Windows.Forms.Button();
            this.init = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.error_msg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quad = new System.Windows.Forms.Button();
            this.konj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.real)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complex Calculator";
            // 
            // real
            // 
            this.real.Location = new System.Drawing.Point(18, 35);
            this.real.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.real.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(120, 22);
            this.real.TabIndex = 1;
            // 
            // real_label
            // 
            this.real_label.AutoSize = true;
            this.real_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.real_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.real_label.Location = new System.Drawing.Point(14, 13);
            this.real_label.Name = "real_label";
            this.real_label.Size = new System.Drawing.Size(54, 18);
            this.real_label.TabIndex = 2;
            this.real_label.Text = "Realteil";
            // 
            // imag_label
            // 
            this.imag_label.AutoSize = true;
            this.imag_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imag_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imag_label.Location = new System.Drawing.Point(155, 13);
            this.imag_label.Name = "imag_label";
            this.imag_label.Size = new System.Drawing.Size(77, 18);
            this.imag_label.TabIndex = 4;
            this.imag_label.Text = "Imaginärteil";
            // 
            // imag
            // 
            this.imag.Location = new System.Drawing.Point(159, 35);
            this.imag.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.imag.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.imag.Name = "imag";
            this.imag.Size = new System.Drawing.Size(120, 22);
            this.imag.TabIndex = 3;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(18, 81);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // push
            // 
            this.push.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.push.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push.Location = new System.Drawing.Point(297, 32);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 28);
            this.push.TabIndex = 4;
            this.push.Text = "Push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(110, 81);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 29);
            this.sub.TabIndex = 8;
            this.sub.Text = "Sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(204, 81);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 29);
            this.mul.TabIndex = 9;
            this.mul.Text = "Mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(297, 81);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 29);
            this.div.TabIndex = 10;
            this.div.Text = "Div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // rez
            // 
            this.rez.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rez.Location = new System.Drawing.Point(18, 130);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(75, 29);
            this.rez.TabIndex = 11;
            this.rez.Text = "Rec";
            this.rez.UseVisualStyleBackColor = true;
            this.rez.Click += new System.EventHandler(this.rez_Click);
            // 
            // dup
            // 
            this.dup.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dup.Location = new System.Drawing.Point(110, 130);
            this.dup.Name = "dup";
            this.dup.Size = new System.Drawing.Size(75, 29);
            this.dup.TabIndex = 12;
            this.dup.Text = "Dup";
            this.dup.UseVisualStyleBackColor = true;
            this.dup.Click += new System.EventHandler(this.dup_Click);
            // 
            // pop
            // 
            this.pop.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop.Location = new System.Drawing.Point(110, 178);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(77, 29);
            this.pop.TabIndex = 13;
            this.pop.Text = "Pop";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // init
            // 
            this.init.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(203, 178);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(169, 29);
            this.init.TabIndex = 14;
            this.init.Text = "Init";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.output.Location = new System.Drawing.Point(11, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(117, 41);
            this.output.TabIndex = 15;
            this.output.Text = "Output";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.output_label.Location = new System.Drawing.Point(18, 80);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(46, 18);
            this.output_label.TabIndex = 16;
            this.output_label.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(439, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stack";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(19, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 288);
            this.listBox1.TabIndex = 19;
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_msg.Location = new System.Drawing.Point(14, 13);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(99, 20);
            this.error_msg.TabIndex = 20;
            this.error_msg.Text = "ErrorMessage";
            this.error_msg.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.inv);
            this.panel1.Controls.Add(this.quad);
            this.panel1.Controls.Add(this.konj);
            this.panel1.Controls.Add(this.real);
            this.panel1.Controls.Add(this.real_label);
            this.panel1.Controls.Add(this.imag);
            this.panel1.Controls.Add(this.imag_label);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.init);
            this.panel1.Controls.Add(this.push);
            this.panel1.Controls.Add(this.pop);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Controls.Add(this.dup);
            this.panel1.Controls.Add(this.mul);
            this.panel1.Controls.Add(this.rez);
            this.panel1.Controls.Add(this.div);
            this.panel1.Location = new System.Drawing.Point(22, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 234);
            this.panel1.TabIndex = 21;
            // 
            // quad
            // 
            this.quad.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quad.Location = new System.Drawing.Point(204, 130);
            this.quad.Name = "quad";
            this.quad.Size = new System.Drawing.Size(75, 29);
            this.quad.TabIndex = 15;
            this.quad.Text = "^2";
            this.quad.UseVisualStyleBackColor = true;
            this.quad.Click += new System.EventHandler(this.quad_Click);
            // 
            // konj
            // 
            this.konj.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konj.Location = new System.Drawing.Point(297, 130);
            this.konj.Name = "konj";
            this.konj.Size = new System.Drawing.Size(75, 29);
            this.konj.TabIndex = 16;
            this.konj.Text = "Konj";
            this.konj.UseVisualStyleBackColor = true;
            this.konj.Click += new System.EventHandler(this.konj_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(443, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 324);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.output);
            this.panel3.Location = new System.Drawing.Point(22, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 66);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(18, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Controls";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.error_msg);
            this.panel4.Location = new System.Drawing.Point(22, 454);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 45);
            this.panel4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(18, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Message";
            // 
            // inv
            // 
            this.inv.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv.Location = new System.Drawing.Point(18, 178);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(75, 29);
            this.inv.TabIndex = 17;
            this.inv.Text = "Inv";
            this.inv.UseVisualStyleBackColor = true;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Complex Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.real)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown real;
        private System.Windows.Forms.Label real_label;
        private System.Windows.Forms.Label imag_label;
        private System.Windows.Forms.NumericUpDown imag;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button rez;
        private System.Windows.Forms.Button dup;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quad;
        private System.Windows.Forms.Button konj;
        private System.Windows.Forms.Button inv;
    }
}

