namespace FizzBuzz
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
            this.inBrowse = new System.Windows.Forms.Button();
            this.inFilename = new System.Windows.Forms.TextBox();
            this.inFilenameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outFilename = new System.Windows.Forms.TextBox();
            this.outBrowse = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inBrowse
            // 
            this.inBrowse.Location = new System.Drawing.Point(341, 34);
            this.inBrowse.Name = "inBrowse";
            this.inBrowse.Size = new System.Drawing.Size(75, 23);
            this.inBrowse.TabIndex = 0;
            this.inBrowse.Text = "browse...";
            this.inBrowse.UseVisualStyleBackColor = true;
            this.inBrowse.Click += new System.EventHandler(this.inBrowse_Click);
            // 
            // inFilename
            // 
            this.inFilename.Location = new System.Drawing.Point(12, 35);
            this.inFilename.Name = "inFilename";
            this.inFilename.Size = new System.Drawing.Size(323, 22);
            this.inFilename.TabIndex = 1;
            // 
            // inFilenameLbl
            // 
            this.inFilenameLbl.AutoSize = true;
            this.inFilenameLbl.Location = new System.Drawing.Point(16, 16);
            this.inFilenameLbl.Name = "inFilenameLbl";
            this.inFilenameLbl.Size = new System.Drawing.Size(100, 17);
            this.inFilenameLbl.TabIndex = 2;
            this.inFilenameLbl.Text = "Input Filename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Filename";
            // 
            // outFilename
            // 
            this.outFilename.Location = new System.Drawing.Point(12, 84);
            this.outFilename.Name = "outFilename";
            this.outFilename.Size = new System.Drawing.Size(323, 22);
            this.outFilename.TabIndex = 4;
            // 
            // outBrowse
            // 
            this.outBrowse.Location = new System.Drawing.Point(341, 83);
            this.outBrowse.Name = "outBrowse";
            this.outBrowse.Size = new System.Drawing.Size(75, 23);
            this.outBrowse.TabIndex = 3;
            this.outBrowse.Text = "browse...";
            this.outBrowse.UseVisualStyleBackColor = true;
            this.outBrowse.Click += new System.EventHandler(this.outBrowse_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(180, 128);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 163);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outFilename);
            this.Controls.Add(this.outBrowse);
            this.Controls.Add(this.inFilenameLbl);
            this.Controls.Add(this.inFilename);
            this.Controls.Add(this.inBrowse);
            this.Name = "Form1";
            this.Text = "FizzBuzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inBrowse;
        private System.Windows.Forms.TextBox inFilename;
        private System.Windows.Forms.Label inFilenameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outFilename;
        private System.Windows.Forms.Button outBrowse;
        private System.Windows.Forms.Button startBtn;
    }
}

