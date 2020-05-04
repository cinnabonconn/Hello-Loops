namespace Hello_Loops
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.txtForLoop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(25, 30);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(245, 44);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While Loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(25, 89);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(245, 44);
            this.btnDoWhile.TabIndex = 1;
            this.btnDoWhile.Text = "Do While Loop";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(25, 212);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(245, 44);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For Loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // txtForLoop
            // 
            this.txtForLoop.Location = new System.Drawing.Point(276, 219);
            this.txtForLoop.Name = "txtForLoop";
            this.txtForLoop.Size = new System.Drawing.Size(145, 31);
            this.txtForLoop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many MessagBox\'s do you want?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtForLoop);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Hello Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.TextBox txtForLoop;
        private System.Windows.Forms.Label label1;
    }
}

