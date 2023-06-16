namespace StringComparer
{
    partial class Main
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            progressBar1 = new ProgressBar();
            compareBtn = new Button();
            diffLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Main String";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(555, 368);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(739, 76);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Compared String";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(555, 368);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 605);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Difference";
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(1211, 213);
            textBox3.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(83, 565);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1211, 34);
            progressBar1.TabIndex = 3;
            // 
            // compareBtn
            // 
            compareBtn.Location = new Point(593, 465);
            compareBtn.Name = "compareBtn";
            compareBtn.Size = new Size(187, 53);
            compareBtn.TabIndex = 4;
            compareBtn.Text = "Compare";
            compareBtn.UseVisualStyleBackColor = true;
            compareBtn.Click += compareBtn_Click;
            // 
            // diffLabel
            // 
            diffLabel.AutoSize = true;
            diffLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diffLabel.Location = new Point(88, 524);
            diffLabel.Name = "diffLabel";
            diffLabel.Size = new Size(78, 32);
            diffLabel.TabIndex = 5;
            diffLabel.Text = "label1";
            diffLabel.TextAlign = ContentAlignment.MiddleCenter;
            diffLabel.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1378, 844);
            Controls.Add(diffLabel);
            Controls.Add(compareBtn);
            Controls.Add(progressBar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String Comparer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ProgressBar progressBar1;
        private Button compareBtn;
        private Label diffLabel;
    }
}