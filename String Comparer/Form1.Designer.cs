namespace String_Comparer
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
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_string_x = new System.Windows.Forms.TextBox();
            this.tbx_string_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(445, 306);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(154, 87);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click_1);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(29, 299);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(141, 101);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String Y";
            // 
            // tbx_string_x
            // 
            this.tbx_string_x.Location = new System.Drawing.Point(106, 68);
            this.tbx_string_x.Name = "tbx_string_x";
            this.tbx_string_x.Size = new System.Drawing.Size(271, 20);
            this.tbx_string_x.TabIndex = 2;
            this.tbx_string_x.TextChanged += new System.EventHandler(this.tbx_string_x_TextChanged);
            // 
            // tbx_string_y
            // 
            this.tbx_string_y.Location = new System.Drawing.Point(106, 137);
            this.tbx_string_y.Name = "tbx_string_y";
            this.tbx_string_y.Size = new System.Drawing.Size(271, 20);
            this.tbx_string_y.TabIndex = 2;
            this.tbx_string_y.TextChanged += new System.EventHandler(this.tbx_string_y_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "String Comparer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter strings and press calculate to see the longest substring which is shared be" +
    "tween both strings";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(431, 75);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_string_y);
            this.Controls.Add(this.tbx_string_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_help);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_string_x;
        private System.Windows.Forms.TextBox tbx_string_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label6;
    }
}

