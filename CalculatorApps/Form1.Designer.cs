namespace CalculatorApps
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fntextBox = new System.Windows.Forms.TextBox();
            this.setextBox = new System.Windows.Forms.TextBox();
            this.retextBox = new System.Windows.Forms.TextBox();
            this.aButton = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.mButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // fntextBox
            // 
            this.fntextBox.Location = new System.Drawing.Point(140, 21);
            this.fntextBox.Name = "fntextBox";
            this.fntextBox.Size = new System.Drawing.Size(100, 20);
            this.fntextBox.TabIndex = 3;
            // 
            // setextBox
            // 
            this.setextBox.Location = new System.Drawing.Point(140, 59);
            this.setextBox.Name = "setextBox";
            this.setextBox.Size = new System.Drawing.Size(100, 20);
            this.setextBox.TabIndex = 4;
            // 
            // retextBox
            // 
            this.retextBox.Location = new System.Drawing.Point(140, 113);
            this.retextBox.Name = "retextBox";
            this.retextBox.Size = new System.Drawing.Size(100, 20);
            this.retextBox.TabIndex = 5;
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(10, 178);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(75, 23);
            this.aButton.TabIndex = 6;
            this.aButton.Text = "Add";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(91, 178);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(75, 23);
            this.sButton.TabIndex = 7;
            this.sButton.Text = "Subtract";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(174, 178);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(75, 23);
            this.dButton.TabIndex = 8;
            this.dButton.Text = "Divide";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // mButton
            // 
            this.mButton.Location = new System.Drawing.Point(272, 178);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(75, 23);
            this.mButton.TabIndex = 9;
            this.mButton.Text = "Multypl";
            this.mButton.UseVisualStyleBackColor = true;
            this.mButton.Click += new System.EventHandler(this.mButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.retextBox);
            this.Controls.Add(this.setextBox);
            this.Controls.Add(this.fntextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fntextBox;
        private System.Windows.Forms.TextBox setextBox;
        private System.Windows.Forms.TextBox retextBox;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button mButton;
    }
}

