namespace MatrixAdjoint
{
    partial class matrix2x2
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
            this.row1col1 = new System.Windows.Forms.TextBox();
            this.row1col2 = new System.Windows.Forms.TextBox();
            this.row2col1 = new System.Windows.Forms.TextBox();
            this.row2col2 = new System.Windows.Forms.TextBox();
            this.var1 = new System.Windows.Forms.TextBox();
            this.var2 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // row1col1
            // 
            this.row1col1.AcceptsTab = true;
            this.row1col1.AccessibleDescription = "";
            this.row1col1.Location = new System.Drawing.Point(102, 118);
            this.row1col1.Name = "row1col1";
            this.row1col1.Size = new System.Drawing.Size(56, 21);
            this.row1col1.TabIndex = 0;
            this.row1col1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row1col1_KeyPress);
            // 
            // row1col2
            // 
            this.row1col2.AcceptsTab = true;
            this.row1col2.AccessibleDescription = "";
            this.row1col2.Location = new System.Drawing.Point(164, 118);
            this.row1col2.Name = "row1col2";
            this.row1col2.Size = new System.Drawing.Size(56, 21);
            this.row1col2.TabIndex = 1;
            this.row1col2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row2col1_KeyPress);
            // 
            // row2col1
            // 
            this.row2col1.AcceptsTab = true;
            this.row2col1.AccessibleDescription = "";
            this.row2col1.Location = new System.Drawing.Point(102, 146);
            this.row2col1.Name = "row2col1";
            this.row2col1.Size = new System.Drawing.Size(56, 21);
            this.row2col1.TabIndex = 2;
            this.row2col1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row2col1_KeyPress);
            // 
            // row2col2
            // 
            this.row2col2.AcceptsTab = true;
            this.row2col2.AccessibleDescription = "";
            this.row2col2.Location = new System.Drawing.Point(164, 146);
            this.row2col2.Name = "row2col2";
            this.row2col2.Size = new System.Drawing.Size(56, 21);
            this.row2col2.TabIndex = 3;
            this.row2col2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row2col1_KeyPress);
            // 
            // var1
            // 
            this.var1.AcceptsTab = true;
            this.var1.AccessibleDescription = "";
            this.var1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.var1.Location = new System.Drawing.Point(240, 118);
            this.var1.MaxLength = 1;
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(56, 21);
            this.var1.TabIndex = 4;
            this.var1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1_KeyPress);
            // 
            // var2
            // 
            this.var2.AcceptsTab = true;
            this.var2.AccessibleDescription = "";
            this.var2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.var2.Location = new System.Drawing.Point(240, 146);
            this.var2.MaxLength = 1;
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(56, 21);
            this.var2.TabIndex = 5;
            this.var2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1_KeyPress);
            // 
            // result1
            // 
            this.result1.AcceptsTab = true;
            this.result1.AccessibleDescription = "";
            this.result1.Location = new System.Drawing.Point(342, 118);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(56, 21);
            this.result1.TabIndex = 6;
            this.result1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row2col1_KeyPress);
            // 
            // result2
            // 
            this.result2.AcceptsTab = true;
            this.result2.AccessibleDescription = "";
            this.result2.Location = new System.Drawing.Point(342, 146);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(56, 21);
            this.result2.TabIndex = 7;
            this.result2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.row2col1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Hoves Pro Trial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Matrix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Variable";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "A";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "B";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Column";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "2";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Row";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // matrix2x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Controls.Add(this.row2col2);
            this.Controls.Add(this.row2col1);
            this.Controls.Add(this.row1col2);
            this.Controls.Add(this.row1col1);
            this.Font = new System.Drawing.Font("TT Hoves Pro Trial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "matrix2x2";
            this.Text = "2 x 2 Matrix Calculator";
            this.Load += new System.EventHandler(this.matrix2x2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox row1col1;
        private System.Windows.Forms.TextBox row1col2;
        private System.Windows.Forms.TextBox row2col1;
        private System.Windows.Forms.TextBox row2col2;
        private System.Windows.Forms.TextBox var1;
        private System.Windows.Forms.TextBox var2;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}