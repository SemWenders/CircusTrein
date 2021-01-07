namespace CircusTrein
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
            this.button1 = new System.Windows.Forms.Button();
            this.cBFormaat = new System.Windows.Forms.ComboBox();
            this.cBDierType = new System.Windows.Forms.ComboBox();
            this.lBAlleDieren = new System.Windows.Forms.ListBox();
            this.lBContainers = new System.Windows.Forms.ListBox();
            this.lbContainerDieren = new System.Windows.Forms.ListBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add animal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBFormaat
            // 
            this.cBFormaat.FormattingEnabled = true;
            this.cBFormaat.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cBFormaat.Location = new System.Drawing.Point(5, 97);
            this.cBFormaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBFormaat.Name = "cBFormaat";
            this.cBFormaat.Size = new System.Drawing.Size(160, 24);
            this.cBFormaat.TabIndex = 2;
            // 
            // cBDierType
            // 
            this.cBDierType.FormattingEnabled = true;
            this.cBDierType.Items.AddRange(new object[] {
            "Meat",
            "Plants"});
            this.cBDierType.Location = new System.Drawing.Point(5, 64);
            this.cBDierType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBDierType.Name = "cBDierType";
            this.cBDierType.Size = new System.Drawing.Size(160, 24);
            this.cBDierType.TabIndex = 3;
            // 
            // lBAlleDieren
            // 
            this.lBAlleDieren.FormattingEnabled = true;
            this.lBAlleDieren.ItemHeight = 16;
            this.lBAlleDieren.Location = new System.Drawing.Point(5, 165);
            this.lBAlleDieren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lBAlleDieren.Name = "lBAlleDieren";
            this.lBAlleDieren.Size = new System.Drawing.Size(275, 292);
            this.lBAlleDieren.TabIndex = 4;
            // 
            // lBContainers
            // 
            this.lBContainers.FormattingEnabled = true;
            this.lBContainers.ItemHeight = 16;
            this.lBContainers.Location = new System.Drawing.Point(492, 229);
            this.lBContainers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lBContainers.Name = "lBContainers";
            this.lBContainers.Size = new System.Drawing.Size(205, 228);
            this.lBContainers.TabIndex = 5;
            this.lBContainers.SelectedIndexChanged += new System.EventHandler(this.lBContainers_SelectedIndexChanged);
            // 
            // lbContainerDieren
            // 
            this.lbContainerDieren.FormattingEnabled = true;
            this.lbContainerDieren.ItemHeight = 16;
            this.lbContainerDieren.Location = new System.Drawing.Point(769, 229);
            this.lbContainerDieren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerDieren.Name = "lbContainerDieren";
            this.lbContainerDieren.Size = new System.Drawing.Size(257, 228);
            this.lbContainerDieren.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(580, 64);
            this.btnBereken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(277, 111);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Calculate";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lbContainerDieren);
            this.Controls.Add(this.lBContainers);
            this.Controls.Add(this.lBAlleDieren);
            this.Controls.Add(this.cBDierType);
            this.Controls.Add(this.cBFormaat);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBFormaat;
        private System.Windows.Forms.ComboBox cBDierType;
        private System.Windows.Forms.ListBox lBAlleDieren;
        private System.Windows.Forms.ListBox lBContainers;
        private System.Windows.Forms.ListBox lbContainerDieren;
        private System.Windows.Forms.Button btnBereken;
    }
}

