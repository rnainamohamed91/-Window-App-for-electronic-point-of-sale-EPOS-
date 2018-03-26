namespace Assignment5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.managementButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ragle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.summary_Button = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.averageLable = new System.Windows.Forms.Label();
            this.totalNoTransLable = new System.Windows.Forms.Label();
            this.totalSaleValueLabel = new System.Windows.Forms.Label();
            this.totalBagelLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mealTabPage = new System.Windows.Forms.TabPage();
            this.deleteItem = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.compelteOrderButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantiryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeListBox = new System.Windows.Forms.ListBox();
            this.bagelListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.summaryTabPage.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.mealTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // managementButton
            // 
            this.managementButton.Location = new System.Drawing.Point(148, 31);
            this.managementButton.Name = "managementButton";
            this.managementButton.Size = new System.Drawing.Size(87, 23);
            this.managementButton.TabIndex = 0;
            this.managementButton.Text = "&Management";
            this.toolTip1.SetToolTip(this.managementButton, "click here to get the summary");
            this.managementButton.UseVisualStyleBackColor = true;
            this.managementButton.Click += new System.EventHandler(this.managementButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(591, 31);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clea&r";
            this.toolTip1.SetToolTip(this.clearButton, "click here to clear");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(696, 31);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "E&ND";
            this.toolTip1.SetToolTip(this.exit_Button, "click here to end ");
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ragle
            // 
            this.ragle.HeaderText = "Ragle";
            this.ragle.Name = "ragle";
            this.ragle.ReadOnly = true;
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("summaryTabPage.BackgroundImage")));
            this.summaryTabPage.Controls.Add(this.button2);
            this.summaryTabPage.Controls.Add(this.summary_Button);
            this.summaryTabPage.Controls.Add(this.toolStripContainer1);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 22);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTabPage.Size = new System.Drawing.Size(684, 527);
            this.summaryTabPage.TabIndex = 2;
            this.summaryTabPage.Text = "Summary";
            this.summaryTabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // summary_Button
            // 
            this.summary_Button.Location = new System.Drawing.Point(49, 32);
            this.summary_Button.Name = "summary_Button";
            this.summary_Button.Size = new System.Drawing.Size(75, 23);
            this.summary_Button.TabIndex = 19;
            this.summary_Button.Text = "&Summary";
            this.toolTip1.SetToolTip(this.summary_Button, "click here to get the summary");
            this.summary_Button.UseVisualStyleBackColor = true;
            this.summary_Button.Click += new System.EventHandler(this.summary_Button_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.averageLable);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalNoTransLable);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalSaleValueLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalBagelLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(614, 238);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(59, 117);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(614, 263);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // averageLable
            // 
            this.averageLable.BackColor = System.Drawing.Color.DarkGray;
            this.averageLable.Location = new System.Drawing.Point(267, 136);
            this.averageLable.Name = "averageLable";
            this.averageLable.Size = new System.Drawing.Size(122, 24);
            this.averageLable.TabIndex = 7;
            // 
            // totalNoTransLable
            // 
            this.totalNoTransLable.BackColor = System.Drawing.Color.DarkGray;
            this.totalNoTransLable.ForeColor = System.Drawing.Color.Black;
            this.totalNoTransLable.Location = new System.Drawing.Point(267, 99);
            this.totalNoTransLable.Name = "totalNoTransLable";
            this.totalNoTransLable.Size = new System.Drawing.Size(122, 26);
            this.totalNoTransLable.TabIndex = 6;
            // 
            // totalSaleValueLabel
            // 
            this.totalSaleValueLabel.BackColor = System.Drawing.Color.DarkGray;
            this.totalSaleValueLabel.Location = new System.Drawing.Point(267, 57);
            this.totalSaleValueLabel.Name = "totalSaleValueLabel";
            this.totalSaleValueLabel.Size = new System.Drawing.Size(122, 28);
            this.totalSaleValueLabel.TabIndex = 5;
            // 
            // totalBagelLabel
            // 
            this.totalBagelLabel.BackColor = System.Drawing.Color.Silver;
            this.totalBagelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalBagelLabel.Location = new System.Drawing.Point(267, 16);
            this.totalBagelLabel.Name = "totalBagelLabel";
            this.totalBagelLabel.Size = new System.Drawing.Size(122, 28);
            this.totalBagelLabel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "the average value of a transaction :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "total number of transactions :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "total sales value : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(96, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "number of bagels sold: ";
            // 
            // mealTabPage
            // 
            this.mealTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mealTabPage.BackgroundImage")));
            this.mealTabPage.Controls.Add(this.deleteItem);
            this.mealTabPage.Controls.Add(this.proceedButton);
            this.mealTabPage.Controls.Add(this.panel2);
            this.mealTabPage.Controls.Add(this.panel1);
            this.mealTabPage.Controls.Add(this.dataGridView1);
            this.mealTabPage.Location = new System.Drawing.Point(4, 22);
            this.mealTabPage.Name = "mealTabPage";
            this.mealTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mealTabPage.Size = new System.Drawing.Size(684, 527);
            this.mealTabPage.TabIndex = 0;
            this.mealTabPage.Text = "Meal Plan";
            this.mealTabPage.UseVisualStyleBackColor = true;
            this.mealTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(591, 322);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(75, 23);
            this.deleteItem.TabIndex = 12;
            this.deleteItem.Text = "&Delete Item";
            this.toolTip1.SetToolTip(this.deleteItem, "click here to delete the item in the row");
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(582, 382);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(99, 23);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "&Proceed ";
            this.toolTip1.SetToolTip(this.proceedButton, "click here to get the total");
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.compelteOrderButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Location = new System.Drawing.Point(7, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 100);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Price : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // compelteOrderButton
            // 
            this.compelteOrderButton.Location = new System.Drawing.Point(248, 23);
            this.compelteOrderButton.Name = "compelteOrderButton";
            this.compelteOrderButton.Size = new System.Drawing.Size(109, 23);
            this.compelteOrderButton.TabIndex = 18;
            this.compelteOrderButton.Text = "&Complete Order";
            this.toolTip1.SetToolTip(this.compelteOrderButton, "click here for confirm");
            this.compelteOrderButton.UseVisualStyleBackColor = true;
            this.compelteOrderButton.Click += new System.EventHandler(this.compelteOrderButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(401, 23);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(129, 23);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "&New Order";
            this.toolTip1.SetToolTip(this.newButton, "click here to new order");
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.White;
            this.totalPriceLabel.Location = new System.Drawing.Point(93, 21);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(130, 25);
            this.totalPriceLabel.TabIndex = 20;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantiryNumericUpDown);
            this.panel1.Controls.Add(this.sizeListBox);
            this.panel1.Controls.Add(this.bagelListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 226);
            this.panel1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.panel1, "click here get the total");
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // quantiryNumericUpDown
            // 
            this.quantiryNumericUpDown.Location = new System.Drawing.Point(338, 12);
            this.quantiryNumericUpDown.Name = "quantiryNumericUpDown";
            this.quantiryNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.quantiryNumericUpDown.TabIndex = 15;
            // 
            // sizeListBox
            // 
            this.sizeListBox.FormattingEnabled = true;
            this.sizeListBox.Items.AddRange(new object[] {
            "Small ",
            "Medium",
            "Regular",
            "Large",
            "Extra Large"});
            this.sizeListBox.Location = new System.Drawing.Point(201, 3);
            this.sizeListBox.Name = "sizeListBox";
            this.sizeListBox.Size = new System.Drawing.Size(79, 69);
            this.sizeListBox.TabIndex = 14;
            this.sizeListBox.SelectedIndexChanged += new System.EventHandler(this.sizeListBox_SelectedIndexChanged);
            // 
            // bagelListBox
            // 
            this.bagelListBox.FormattingEnabled = true;
            this.bagelListBox.Items.AddRange(new object[] {
            "Halloumi",
            "Bangkok",
            "Chicken Philly",
            "Classic Club",
            "Kiltimagh Special ",
            "Veggie",
            "Ploughmans",
            "Mexicana",
            "TripleCheese",
            "Atlantic Way",
            "Breakfast",
            "Maui",
            "Classic",
            "Chicken Caeser",
            "Student Surprise",
            "Cajun"});
            this.bagelListBox.Location = new System.Drawing.Point(41, 3);
            this.bagelListBox.Name = "bagelListBox";
            this.bagelListBox.Size = new System.Drawing.Size(121, 212);
            this.bagelListBox.TabIndex = 13;
            this.bagelListBox.SelectedIndexChanged += new System.EventHandler(this.bagelListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bagel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(405, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = " &ADD";
            this.toolTip1.SetToolTip(this.addButton, "Click here to add the items");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(7, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 133);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bagel";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "sizes";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Individual Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Collective Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mealTabPage);
            this.tabControl1.Controls.Add(this.summaryTabPage);
            this.tabControl1.Location = new System.Drawing.Point(60, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 691);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.managementButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.summaryTabPage.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.mealTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managementButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ragle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mealTabPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button compelteOrderButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox sizeListBox;
        private System.Windows.Forms.ListBox bagelListBox;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button summary_Button;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label averageLable;
        private System.Windows.Forms.Label totalNoTransLable;
        private System.Windows.Forms.Label totalSaleValueLabel;
        private System.Windows.Forms.Label totalBagelLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantiryNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

