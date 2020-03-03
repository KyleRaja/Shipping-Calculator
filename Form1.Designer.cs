namespace proj_06_KR_V1._0.zip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.appPanel = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.yesRadioBtn = new System.Windows.Forms.RadioButton();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.shipBox = new System.Windows.Forms.ComboBox();
            this.categBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.shipCostLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.appPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.exitToolStripMenuItem.Text = "Exit ";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem1.Text = "Exit ";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red Fern online Electronics ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping Calculator ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping Method ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of items \r\nWeight of Shipment ";
            // 
            // appPanel
            // 
            this.appPanel.Controls.Add(this.radioButton2);
            this.appPanel.Controls.Add(this.yesRadioBtn);
            this.appPanel.Location = new System.Drawing.Point(243, 238);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(200, 100);
            this.appPanel.TabIndex = 6;
            this.appPanel.TabStop = false;
            this.appPanel.Text = "Surcharge (HA or AL)";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.Location = new System.Drawing.Point(6, 31);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.yesRadioBtn.TabIndex = 9;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes ";
            this.yesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(63, 334);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(125, 79);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Calculate Shipping ";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // shipBox
            // 
            this.shipBox.FormattingEnabled = true;
            this.shipBox.Items.AddRange(new object[] {
            "Standard ",
            "Express",
            "One-Day "});
            this.shipBox.Location = new System.Drawing.Point(63, 166);
            this.shipBox.Name = "shipBox";
            this.shipBox.Size = new System.Drawing.Size(121, 21);
            this.shipBox.TabIndex = 7;
            // 
            // categBox
            // 
            this.categBox.FormattingEnabled = true;
            this.categBox.Items.AddRange(new object[] {
            "By Weight",
            "By Item "});
            this.categBox.Location = new System.Drawing.Point(285, 166);
            this.categBox.Name = "categBox";
            this.categBox.Size = new System.Drawing.Size(121, 21);
            this.categBox.TabIndex = 8;
            this.categBox.SelectedIndexChanged += new System.EventHandler(this.categBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(63, 269);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 9;
            // 
            // shipCostLbl
            // 
            this.shipCostLbl.AutoSize = true;
            this.shipCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipCostLbl.Location = new System.Drawing.Point(296, 341);
            this.shipCostLbl.Name = "shipCostLbl";
            this.shipCostLbl.Size = new System.Drawing.Size(126, 20);
            this.shipCostLbl.TabIndex = 10;
            this.shipCostLbl.Text = "Shipping Cost ";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(323, 376);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(39, 16);
            this.totalLbl.TabIndex = 11;
            this.totalLbl.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 467);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.shipCostLbl);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.categBox);
            this.Controls.Add(this.shipBox);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shipping Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.appPanel.ResumeLayout(false);
            this.appPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox appPanel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton yesRadioBtn;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.ComboBox shipBox;
        private System.Windows.Forms.ComboBox categBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label shipCostLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}

