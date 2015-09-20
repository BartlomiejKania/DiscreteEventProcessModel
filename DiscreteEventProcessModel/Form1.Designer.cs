namespace DiscreteEventProcessModel
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
            this.startButton = new System.Windows.Forms.Button();
            this.loadDatabutton = new System.Windows.Forms.Button();
            this.newListBox4 = new AdvListBox.NewListBox(this.components);
            this.newListBox3 = new AdvListBox.NewListBox(this.components);
            this.newListBox1 = new AdvListBox.NewListBox(this.components);
            this.newListBox2 = new AdvListBox.NewListBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.joomlaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.drupalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.wordPressNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drupalResultLabel = new System.Windows.Forms.Label();
            this.joomlaResultLabel = new System.Windows.Forms.Label();
            this.wordPressResultlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simulationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordPressCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joomlaCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drupalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketReactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joomlaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drupalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordPressNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(460, 446);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(413, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadDatabutton
            // 
            this.loadDatabutton.Location = new System.Drawing.Point(12, 446);
            this.loadDatabutton.Name = "loadDatabutton";
            this.loadDatabutton.Size = new System.Drawing.Size(442, 23);
            this.loadDatabutton.TabIndex = 2;
            this.loadDatabutton.Text = "Load data";
            this.loadDatabutton.UseVisualStyleBackColor = true;
            this.loadDatabutton.Click += new System.EventHandler(this.loadDatabutton_Click);
            // 
            // newListBox4
            // 
            this.newListBox4.ColumnIndex = 4;
            this.newListBox4.FormattingEnabled = true;
            this.newListBox4.Location = new System.Drawing.Point(0, 0);
            this.newListBox4.Name = "newListBox4";
            this.newListBox4.ScrollAlwaysVisible = true;
            this.newListBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.newListBox4.Size = new System.Drawing.Size(120, 95);
            this.newListBox4.TabIndex = 0;
            // 
            // newListBox3
            // 
            this.newListBox3.ColumnIndex = -1;
            this.newListBox3.Location = new System.Drawing.Point(0, 0);
            this.newListBox3.Name = "newListBox3";
            this.newListBox3.Size = new System.Drawing.Size(120, 95);
            this.newListBox3.TabIndex = 0;
            // 
            // newListBox1
            // 
            this.newListBox1.ColumnIndex = -1;
            this.newListBox1.Location = new System.Drawing.Point(0, 0);
            this.newListBox1.Name = "newListBox1";
            this.newListBox1.Size = new System.Drawing.Size(120, 95);
            this.newListBox1.TabIndex = 0;
            // 
            // newListBox2
            // 
            this.newListBox2.ColumnIndex = -1;
            this.newListBox2.Location = new System.Drawing.Point(0, 0);
            this.newListBox2.Name = "newListBox2";
            this.newListBox2.Size = new System.Drawing.Size(120, 95);
            this.newListBox2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.functionalityDataGridViewTextBoxColumn,
            this.wordPressCostDataGridViewTextBoxColumn,
            this.joomlaCostDataGridViewTextBoxColumn,
            this.drupalCostDataGridViewTextBoxColumn,
            this.marketReactionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // joomlaNumericUpDown
            // 
            this.joomlaNumericUpDown.Location = new System.Drawing.Point(93, 57);
            this.joomlaNumericUpDown.Name = "joomlaNumericUpDown";
            this.joomlaNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.joomlaNumericUpDown.TabIndex = 4;
            this.joomlaNumericUpDown.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // drupalNumericUpDown
            // 
            this.drupalNumericUpDown.Location = new System.Drawing.Point(93, 85);
            this.drupalNumericUpDown.Name = "drupalNumericUpDown";
            this.drupalNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.drupalNumericUpDown.TabIndex = 5;
            // 
            // wordPressNumericUpDown
            // 
            this.wordPressNumericUpDown.Location = new System.Drawing.Point(93, 31);
            this.wordPressNumericUpDown.Name = "wordPressNumericUpDown";
            this.wordPressNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.wordPressNumericUpDown.TabIndex = 6;
            this.wordPressNumericUpDown.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.drupalNumericUpDown);
            this.panel1.Controls.Add(this.wordPressNumericUpDown);
            this.panel1.Controls.Add(this.joomlaNumericUpDown);
            this.panel1.Location = new System.Drawing.Point(12, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 119);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drupal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Joomla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "WordPress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delay Time";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.drupalResultLabel);
            this.panel2.Controls.Add(this.joomlaResultLabel);
            this.panel2.Controls.Add(this.wordPressResultlabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(204, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 119);
            this.panel2.TabIndex = 8;
            this.panel2.Tag = "";
            // 
            // drupalResultLabel
            // 
            this.drupalResultLabel.AutoSize = true;
            this.drupalResultLabel.Location = new System.Drawing.Point(89, 87);
            this.drupalResultLabel.Name = "drupalResultLabel";
            this.drupalResultLabel.Size = new System.Drawing.Size(33, 13);
            this.drupalResultLabel.TabIndex = 14;
            this.drupalResultLabel.Text = "None";
            // 
            // joomlaResultLabel
            // 
            this.joomlaResultLabel.AutoSize = true;
            this.joomlaResultLabel.Location = new System.Drawing.Point(89, 59);
            this.joomlaResultLabel.Name = "joomlaResultLabel";
            this.joomlaResultLabel.Size = new System.Drawing.Size(33, 13);
            this.joomlaResultLabel.TabIndex = 13;
            this.joomlaResultLabel.Text = "None";
            // 
            // wordPressResultlabel
            // 
            this.wordPressResultlabel.AutoSize = true;
            this.wordPressResultlabel.Location = new System.Drawing.Point(89, 33);
            this.wordPressResultlabel.Name = "wordPressResultlabel";
            this.wordPressResultlabel.Size = new System.Drawing.Size(33, 13);
            this.wordPressResultlabel.TabIndex = 12;
            this.wordPressResultlabel.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Drupal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Joomla";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "WordPress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result";
            // 
            // simulationDataBindingSource
            // 
            this.simulationDataBindingSource.DataSource = typeof(DiscreteEventProcessModel.SimulationData);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 33;
            // 
            // functionalityDataGridViewTextBoxColumn
            // 
            this.functionalityDataGridViewTextBoxColumn.DataPropertyName = "Functionality";
            this.functionalityDataGridViewTextBoxColumn.HeaderText = "Functionality";
            this.functionalityDataGridViewTextBoxColumn.Name = "functionalityDataGridViewTextBoxColumn";
            this.functionalityDataGridViewTextBoxColumn.Width = 350;
            // 
            // wordPressCostDataGridViewTextBoxColumn
            // 
            this.wordPressCostDataGridViewTextBoxColumn.DataPropertyName = "WordPressCost";
            this.wordPressCostDataGridViewTextBoxColumn.HeaderText = "WordPressCost";
            this.wordPressCostDataGridViewTextBoxColumn.Name = "wordPressCostDataGridViewTextBoxColumn";
            // 
            // joomlaCostDataGridViewTextBoxColumn
            // 
            this.joomlaCostDataGridViewTextBoxColumn.DataPropertyName = "JoomlaCost";
            this.joomlaCostDataGridViewTextBoxColumn.HeaderText = "JoomlaCost";
            this.joomlaCostDataGridViewTextBoxColumn.Name = "joomlaCostDataGridViewTextBoxColumn";
            // 
            // drupalCostDataGridViewTextBoxColumn
            // 
            this.drupalCostDataGridViewTextBoxColumn.DataPropertyName = "DrupalCost";
            this.drupalCostDataGridViewTextBoxColumn.HeaderText = "DrupalCost";
            this.drupalCostDataGridViewTextBoxColumn.Name = "drupalCostDataGridViewTextBoxColumn";
            // 
            // marketReactionDataGridViewTextBoxColumn
            // 
            this.marketReactionDataGridViewTextBoxColumn.DataPropertyName = "MarketReaction";
            this.marketReactionDataGridViewTextBoxColumn.HeaderText = "MarketReaction";
            this.marketReactionDataGridViewTextBoxColumn.Name = "marketReactionDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadDatabutton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Discrete Event Process Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joomlaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drupalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordPressNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadDatabutton;
        private AdvListBox.NewListBox newListBox1;
        private AdvListBox.NewListBox newListBox3;
        private AdvListBox.NewListBox newListBox2;
        private AdvListBox.NewListBox newListBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown joomlaNumericUpDown;
        private System.Windows.Forms.NumericUpDown drupalNumericUpDown;
        private System.Windows.Forms.NumericUpDown wordPressNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label drupalResultLabel;
        private System.Windows.Forms.Label joomlaResultLabel;
        private System.Windows.Forms.Label wordPressResultlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource simulationDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordPressCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joomlaCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drupalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketReactionDataGridViewTextBoxColumn;
    }
}

