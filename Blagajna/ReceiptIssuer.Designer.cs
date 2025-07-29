namespace CashRegister
{
    partial class ReceiptIssuer
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
            FinalReceipt = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // FinalReceipt
            // 
            FinalReceipt.ItemHeight = 15;
            FinalReceipt.Location = new Point(15, 12);
            FinalReceipt.Name = "FinalReceipt";
            FinalReceipt.Size = new Size(221, 319);
            FinalReceipt.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(242, 60);
            button1.Name = "button1";
            button1.Size = new Size(175, 140);
            button1.TabIndex = 1;
            button1.Text = "TotalReceipt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReceiptIssuer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 375);
            Controls.Add(button1);
            Controls.Add(FinalReceipt);
            Name = "ReceiptIssuer";
            Text = "Izdavanje_racuna";
            ResumeLayout(false);
        }

        #endregion

        private ListBox FinalReceipt;
        private Button button1;
    }
}