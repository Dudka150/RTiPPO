namespace Game
{
    partial class RegistrationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш ник";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(206, 143);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(189, 53);
            this.end.TabIndex = 2;
            this.end.Text = "Закончить";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(393, 143);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(183, 53);
            this.Next.TabIndex = 3;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.singUpGame_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button Next;
    }
}
