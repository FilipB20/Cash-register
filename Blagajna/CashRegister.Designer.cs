namespace CashRegister
{
    partial class CashRegister
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
            CoffeeButton = new Button();
            CedevitaButton = new Button();
            BeerButton = new Button();
            RakijaButton = new Button();
            IssueButton = new Button();
            Receipt = new ListBox();
            TotalButton = new Button();
            EmptyButton = new Button();
            SuspendLayout();
            // 
            // CoffeeButton
            // 
            CoffeeButton.Location = new Point(45, 50);
            CoffeeButton.Name = "CoffeeButton";
            CoffeeButton.Size = new Size(112, 110);
            CoffeeButton.TabIndex = 0;
            CoffeeButton.Text = "Kava + mlijeko";
            CoffeeButton.UseVisualStyleBackColor = true;
            CoffeeButton.Click += CoffeeButton_Click;
            // 
            // CedevitaButton
            // 
            CedevitaButton.Location = new Point(163, 50);
            CedevitaButton.Name = "CedevitaButton";
            CedevitaButton.Size = new Size(126, 110);
            CedevitaButton.TabIndex = 1;
            CedevitaButton.Text = "Cedevita";
            CedevitaButton.UseVisualStyleBackColor = true;
            CedevitaButton.Click += CedevitaButton_Click;
            // 
            // BeerButton
            // 
            BeerButton.Location = new Point(295, 50);
            BeerButton.Name = "BeerButton";
            BeerButton.Size = new Size(143, 110);
            BeerButton.TabIndex = 2;
            BeerButton.Text = "Pivo";
            BeerButton.UseVisualStyleBackColor = true;
            BeerButton.Click += BeerButton_Click;
            // 
            // RakijaButton
            // 
            RakijaButton.Location = new Point(444, 50);
            RakijaButton.Name = "RakijaButton";
            RakijaButton.Size = new Size(125, 110);
            RakijaButton.TabIndex = 3;
            RakijaButton.Text = "Rakija";
            RakijaButton.UseVisualStyleBackColor = true;
            RakijaButton.Click += RakijaButton_Click;
            // 
            // IssueButton
            // 
            IssueButton.Location = new Point(628, 416);
            IssueButton.Name = "IssueButton";
            IssueButton.Size = new Size(205, 178);
            IssueButton.TabIndex = 4;
            IssueButton.Text = "Izdaj račun";
            IssueButton.UseVisualStyleBackColor = true;
            IssueButton.Click += IssueButton_Click;
            // 
            // Receipt
            // 
            Receipt.FormattingEnabled = true;
            Receipt.ItemHeight = 15;
            Receipt.Location = new Point(45, 182);
            Receipt.Name = "Receipt";
            Receipt.Size = new Size(524, 439);
            Receipt.TabIndex = 6;
            //ne treba Receipt.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // TotalButton
            // 
            TotalButton.Location = new Point(628, 324);
            TotalButton.Name = "TotalButton";
            TotalButton.Size = new Size(205, 86);
            TotalButton.TabIndex = 7;
            TotalButton.Text = "Ukupno";
            TotalButton.UseVisualStyleBackColor = true;
            TotalButton.Click += TotalButton_Click;
            // 
            // EmptyButton
            // 
            EmptyButton.Location = new Point(628, 228);
            EmptyButton.Name = "EmptyButton";
            EmptyButton.Size = new Size(205, 90);
            EmptyButton.TabIndex = 8;
            EmptyButton.Text = "Obrisi";
            EmptyButton.UseVisualStyleBackColor = true;
            EmptyButton.Click += EmptyButton_Click;
            // 
            // CashRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 630);
            Controls.Add(EmptyButton);
            Controls.Add(TotalButton);
            Controls.Add(Receipt);
            Controls.Add(IssueButton);
            Controls.Add(RakijaButton);
            Controls.Add(BeerButton);
            Controls.Add(CedevitaButton);
            Controls.Add(CoffeeButton);
            Name = "CashRegister";
            Text = "Blagajna";
            ResumeLayout(false);
        }

        #endregion

        private Button CoffeeButton;
        private Button CedevitaButton;
        private Button BeerButton;
        private Button RakijaButton;
        private Button IssueButton;
        private ListBox Receipt;
        private Button TotalButton;
        private Button EmptyButton;
    }
}