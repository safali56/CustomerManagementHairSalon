namespace LAB3B
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHairdresser = new System.Windows.Forms.ComboBox();
            this.serviceBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chargedItems = new System.Windows.Forms.GroupBox();
            this.chargedItm = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.priceBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.totalBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.chargedItems.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // cmbHairdresser
            // 
            this.cmbHairdresser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHairdresser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHairdresser.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbHairdresser.FormattingEnabled = true;
            this.cmbHairdresser.Items.AddRange(new object[] {
            "Jane Samely",
            "Laura Renkins",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon"});
            this.cmbHairdresser.Location = new System.Drawing.Point(6, 29);
            this.cmbHairdresser.Name = "cmbHairdresser";
            this.cmbHairdresser.Size = new System.Drawing.Size(121, 21);
            this.cmbHairdresser.Sorted = true;
            this.cmbHairdresser.TabIndex = 5;
            this.cmbHairdresser.SelectedIndexChanged += new System.EventHandler(this.cmbHairdresser_SelectedIndexChanged);
            // 
            // serviceBox
            // 
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, Blow-dry, and Style",
            "Color",
            "Highlight",
            "Extension",
            "Up-do"});
            this.serviceBox.Location = new System.Drawing.Point(16, 29);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.serviceBox.Size = new System.Drawing.Size(135, 95);
            this.serviceBox.TabIndex = 6;
            this.serviceBox.SelectedIndexChanged += new System.EventHandler(this.serviceBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHairdresser);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Hairdresser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceBox);
            this.groupBox2.Location = new System.Drawing.Point(205, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select A Service";
            // 
            // chargedItems
            // 
            this.chargedItems.Controls.Add(this.chargedItm);
            this.chargedItems.Location = new System.Drawing.Point(382, 22);
            this.chargedItems.Name = "chargedItems";
            this.chargedItems.Size = new System.Drawing.Size(171, 145);
            this.chargedItems.TabIndex = 10;
            this.chargedItems.TabStop = false;
            this.chargedItems.Text = "ChargedItems";
            // 
            // chargedItm
            // 
            this.chargedItm.FormattingEnabled = true;
            this.chargedItm.Location = new System.Drawing.Point(23, 29);
            this.chargedItm.Name = "chargedItm";
            this.chargedItm.Size = new System.Drawing.Size(120, 95);
            this.chargedItm.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.priceBox);
            this.groupBox4.Location = new System.Drawing.Point(569, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 145);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(6, 29);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(101, 95);
            this.priceBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(549, 199);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 20);
            this.totalPrice.TabIndex = 13;
            // 
            // serviceBtn
            // 
            this.serviceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.serviceBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBtn.Location = new System.Drawing.Point(180, 258);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(121, 39);
            this.serviceBtn.TabIndex = 14;
            this.serviceBtn.Text = "Add Service";
            this.serviceBtn.UseVisualStyleBackColor = false;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // totalBtn
            // 
            this.totalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBtn.Location = new System.Drawing.Point(307, 258);
            this.totalBtn.Name = "totalBtn";
            this.totalBtn.Size = new System.Drawing.Size(121, 39);
            this.totalBtn.TabIndex = 15;
            this.totalBtn.Text = "Calculate Total";
            this.totalBtn.UseVisualStyleBackColor = false;
            this.totalBtn.Click += new System.EventHandler(this.totalBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(434, 258);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(121, 39);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(561, 258);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 39);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.totalBtn);
            this.Controls.Add(this.serviceBtn);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chargedItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Saloon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.chargedItems.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHairdresser;
        private System.Windows.Forms.ListBox serviceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox chargedItems;
        private System.Windows.Forms.ListBox chargedItm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.Button totalBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

