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
            compareBtn = new Button();
            diffLabel = new Label();
            abtBtn = new Button();
            abtPanel = new Panel();
            textBox5 = new TextBox();
            abtPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(17, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Main String";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(624, 600);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(660, 70);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Compared String";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(624, 600);
            textBox2.TabIndex = 1;
            // 
            // compareBtn
            // 
            compareBtn.FlatStyle = FlatStyle.Flat;
            compareBtn.Location = new Point(186, 15);
            compareBtn.Name = "compareBtn";
            compareBtn.Size = new Size(112, 34);
            compareBtn.TabIndex = 4;
            compareBtn.Text = "Compare";
            compareBtn.UseVisualStyleBackColor = true;
            compareBtn.Click += compareBtn_Click;
            // 
            // diffLabel
            // 
            diffLabel.AutoSize = true;
            diffLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diffLabel.Location = new Point(345, 17);
            diffLabel.Name = "diffLabel";
            diffLabel.Size = new Size(78, 32);
            diffLabel.TabIndex = 5;
            diffLabel.Text = "label1";
            diffLabel.TextAlign = ContentAlignment.MiddleCenter;
            diffLabel.Visible = false;
            // 
            // abtBtn
            // 
            abtBtn.FlatStyle = FlatStyle.Flat;
            abtBtn.Location = new Point(17, 15);
            abtBtn.Name = "abtBtn";
            abtBtn.Size = new Size(112, 34);
            abtBtn.TabIndex = 7;
            abtBtn.Text = "About";
            abtBtn.UseVisualStyleBackColor = true;
            abtBtn.Click += abtBtn_Click;
            // 
            // abtPanel
            // 
            abtPanel.BorderStyle = BorderStyle.Fixed3D;
            abtPanel.Controls.Add(textBox5);
            abtPanel.Location = new Point(377, 118);
            abtPanel.Name = "abtPanel";
            abtPanel.Size = new Size(595, 522);
            abtPanel.TabIndex = 8;
            abtPanel.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(3, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.ScrollBars = ScrollBars.Both;
            textBox5.Size = new Size(585, 512);
            textBox5.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1297, 684);
            Controls.Add(abtPanel);
            Controls.Add(abtBtn);
            Controls.Add(diffLabel);
            Controls.Add(compareBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String Comparer";
            abtPanel.ResumeLayout(false);
            abtPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button compareBtn;
        private Label diffLabel;
        private Button abtBtn;
        private Panel abtPanel;
        private TextBox textBox5;
    }
}