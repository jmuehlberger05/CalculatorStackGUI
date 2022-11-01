
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
            ((System.ComponentModel.ISupportInitialize)(this.real)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complex Calculator";
            // 
            // real
            // 
            this.real.Location = new System.Drawing.Point(22, 170);
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
            this.real_label.Location = new System.Drawing.Point(18, 148);
            this.real_label.Name = "real_label";
            this.real_label.Size = new System.Drawing.Size(56, 19);
            this.real_label.TabIndex = 2;
            this.real_label.Text = "Realteil";
            // 
            // imag_label
            // 
            this.imag_label.AutoSize = true;
            this.imag_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imag_label.Location = new System.Drawing.Point(159, 148);
            this.imag_label.Name = "imag_label";
            this.imag_label.Size = new System.Drawing.Size(81, 19);
            this.imag_label.TabIndex = 4;
            this.imag_label.Text = "Imaginärteil";
            // 
            // imag
            // 
            this.imag.Location = new System.Drawing.Point(163, 170);
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
            this.add.Location = new System.Drawing.Point(22, 216);
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
            this.push.Location = new System.Drawing.Point(301, 167);
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
            this.sub.Location = new System.Drawing.Point(114, 216);
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
            this.mul.Location = new System.Drawing.Point(208, 216);
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
            this.div.Location = new System.Drawing.Point(301, 216);
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
            this.rez.Location = new System.Drawing.Point(22, 265);
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
            this.dup.Location = new System.Drawing.Point(114, 265);
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
            this.pop.Location = new System.Drawing.Point(208, 265);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 29);
            this.pop.TabIndex = 13;
            this.pop.Text = "Pop";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // init
            // 
            this.init.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(301, 265);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 29);
            this.init.TabIndex = 14;
            this.init.Text = "Init";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.output.Location = new System.Drawing.Point(14, 94);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(117, 41);
            this.output.TabIndex = 15;
            this.output.Text = "Output";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.Location = new System.Drawing.Point(18, 77);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(52, 19);
            this.output_label.TabIndex = 16;
            this.output_label.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stack";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(420, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 228);
            this.listBox1.TabIndex = 19;
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_msg.Location = new System.Drawing.Point(22, 315);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(99, 20);
            this.error_msg.TabIndex = 20;
            this.error_msg.Text = "ErrorMessage";
            this.error_msg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(967, 584);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.output);
            this.Controls.Add(this.init);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.dup);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.push);
            this.Controls.Add(this.add);
            this.Controls.Add(this.imag_label);
            this.Controls.Add(this.imag);
            this.Controls.Add(this.real_label);
            this.Controls.Add(this.real);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Complex Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.real)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).EndInit();
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
    }
}

