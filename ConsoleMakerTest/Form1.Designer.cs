namespace ConsoleMakerTest
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.conW = new System.Windows.Forms.RadioButton();
            this.diaW = new System.Windows.Forms.RadioButton();
            this.ee1 = new System.Windows.Forms.Timer(this.components);
            this.ee2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conW
            // 
            this.conW.AutoSize = true;
            this.conW.Location = new System.Drawing.Point(12, 13);
            this.conW.Name = "conW";
            this.conW.Size = new System.Drawing.Size(105, 17);
            this.conW.TabIndex = 2;
            this.conW.TabStop = true;
            this.conW.Text = "Console Window";
            this.conW.UseVisualStyleBackColor = true;
            // 
            // diaW
            // 
            this.diaW.AutoSize = true;
            this.diaW.Location = new System.Drawing.Point(12, 37);
            this.diaW.Name = "diaW";
            this.diaW.Size = new System.Drawing.Size(55, 17);
            this.diaW.TabIndex = 3;
            this.diaW.TabStop = true;
            this.diaW.Text = "Dialog";
            this.diaW.UseVisualStyleBackColor = true;
            // 
            // ee1
            // 
            this.ee1.Enabled = true;
            this.ee1.Interval = 30000;
            this.ee1.Tick += new System.EventHandler(this.ee1_Tick);
            // 
            // ee2
            // 
            this.ee2.Interval = 1000;
            this.ee2.Tick += new System.EventHandler(this.ee2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.diaW);
            this.Controls.Add(this.conW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton conW;
        private System.Windows.Forms.RadioButton diaW;
        private System.Windows.Forms.Timer ee1;
        private System.Windows.Forms.Timer ee2;
    }
}

