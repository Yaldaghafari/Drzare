namespace Stack_DS
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
            this.btnConvertToPostfix = new System.Windows.Forms.Button();
            this.btnConvertToInfix = new System.Windows.Forms.Button();
            this.txtPostfix = new System.Windows.Forms.TextBox();
            this.txtInfix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertToPostfix
            // 
            this.btnConvertToPostfix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConvertToPostfix.Location = new System.Drawing.Point(218, 195);
            this.btnConvertToPostfix.Name = "btnConvertToPostfix";
            this.btnConvertToPostfix.Size = new System.Drawing.Size(155, 44);
            this.btnConvertToPostfix.TabIndex = 0;
            this.btnConvertToPostfix.Text = "Convert to Postfix";
            this.btnConvertToPostfix.UseVisualStyleBackColor = false;
            this.btnConvertToPostfix.Click += new System.EventHandler(this.btnConvertToPostfix_Click);
            // 
            // btnConvertToInfix
            // 
            this.btnConvertToInfix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConvertToInfix.Location = new System.Drawing.Point(208, 101);
            this.btnConvertToInfix.Name = "btnConvertToInfix";
            this.btnConvertToInfix.Size = new System.Drawing.Size(155, 44);
            this.btnConvertToInfix.TabIndex = 1;
            this.btnConvertToInfix.Text = "Convert to Infix";
            this.btnConvertToInfix.UseVisualStyleBackColor = false;
            this.btnConvertToInfix.Click += new System.EventHandler(this.btnConvertToInfix_Click);
            // 
            // txtPostfix
            // 
            this.txtPostfix.Location = new System.Drawing.Point(103, 73);
            this.txtPostfix.Name = "txtPostfix";
            this.txtPostfix.Size = new System.Drawing.Size(156, 22);
            this.txtPostfix.TabIndex = 2;
            // 
            // txtInfix
            // 
            this.txtInfix.Location = new System.Drawing.Point(103, 167);
            this.txtInfix.Name = "txtInfix";
            this.txtInfix.Size = new System.Drawing.Size(149, 22);
            this.txtInfix.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfix);
            this.Controls.Add(this.txtPostfix);
            this.Controls.Add(this.btnConvertToInfix);
            this.Controls.Add(this.btnConvertToPostfix);
            this.Name = "Form1";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertToPostfix;
        private System.Windows.Forms.Button btnConvertToInfix;
        private System.Windows.Forms.TextBox txtPostfix;
        private System.Windows.Forms.TextBox txtInfix;
        private System.Windows.Forms.Label label1;
    }
}

