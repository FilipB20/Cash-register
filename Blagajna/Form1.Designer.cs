namespace Blagajna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 50);
            button1.Name = "button1";
            button1.Size = new Size(112, 110);
            button1.TabIndex = 0;
            button1.Text = "Kava + mlijeko";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(163, 50);
            button2.Name = "button2";
            button2.Size = new Size(126, 110);
            button2.TabIndex = 1;
            button2.Text = "Cedevita";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(295, 50);
            button3.Name = "button3";
            button3.Size = new Size(143, 110);
            button3.TabIndex = 2;
            button3.Text = "Pivo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(444, 50);
            button4.Name = "button4";
            button4.Size = new Size(125, 110);
            button4.TabIndex = 3;
            button4.Text = "Rakija";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(628, 416);
            button5.Name = "button5";
            button5.Size = new Size(205, 178);
            button5.TabIndex = 4;
            button5.Text = "Izdaj račun";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 439);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(628, 324);
            button6.Name = "button6";
            button6.Size = new Size(205, 86);
            button6.TabIndex = 7;
            button6.Text = "Ukupno";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(628, 228);
            button7.Name = "button7";
            button7.Size = new Size(205, 90);
            button7.TabIndex = 8;
            button7.Text = "Obrisi";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 630);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox listBox1;
        private Button button6;
        private Button button7;
    }
}