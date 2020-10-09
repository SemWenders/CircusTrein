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
            this.button1.Location = new System.Drawing.Point(131, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dier toevoegen";
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
            this.cBFormaat.Location = new System.Drawing.Point(4, 79);
            this.cBFormaat.Name = "cBFormaat";
            this.cBFormaat.Size = new System.Drawing.Size(121, 21);
            this.cBFormaat.TabIndex = 2;
            // 
            // cBDierType
            // 
            this.cBDierType.FormattingEnabled = true;
            this.cBDierType.Items.AddRange(new object[] {
            "Vlees",
            "Planten"});
            this.cBDierType.Location = new System.Drawing.Point(4, 52);
            this.cBDierType.Name = "cBDierType";
            this.cBDierType.Size = new System.Drawing.Size(121, 21);
            this.cBDierType.TabIndex = 3;
            // 
            // lBAlleDieren
            // 
            this.lBAlleDieren.FormattingEnabled = true;
            this.lBAlleDieren.Location = new System.Drawing.Point(4, 134);
            this.lBAlleDieren.Name = "lBAlleDieren";
            this.lBAlleDieren.Size = new System.Drawing.Size(207, 238);
            this.lBAlleDieren.TabIndex = 4;
            // 
            // lBContainers
            // 
            this.lBContainers.FormattingEnabled = true;
            this.lBContainers.Location = new System.Drawing.Point(369, 186);
            this.lBContainers.Name = "lBContainers";
            this.lBContainers.Size = new System.Drawing.Size(155, 186);
            this.lBContainers.TabIndex = 5;
            this.lBContainers.SelectedIndexChanged += new System.EventHandler(this.lBContainers_SelectedIndexChanged);
            // 
            // lbContainerDieren
            // 
            this.lbContainerDieren.FormattingEnabled = true;
            this.lbContainerDieren.Location = new System.Drawing.Point(577, 186);
            this.lbContainerDieren.Name = "lbContainerDieren";
            this.lbContainerDieren.Size = new System.Drawing.Size(194, 186);
            this.lbContainerDieren.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(435, 52);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(208, 90);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lbContainerDieren);
            this.Controls.Add(this.lBContainers);
            this.Controls.Add(this.lBAlleDieren);
            this.Controls.Add(this.cBDierType);
            this.Controls.Add(this.cBFormaat);
            this.Controls.Add(this.button1);
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

