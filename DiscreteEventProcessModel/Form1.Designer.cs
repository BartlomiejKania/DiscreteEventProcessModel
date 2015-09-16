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
            this.simulationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.functionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordPressCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joomlaCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drupalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketReactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(460, 258);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(413, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadDatabutton
            // 
            this.loadDatabutton.Location = new System.Drawing.Point(12, 258);
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
            // simulationDataBindingSource
            // 
            this.simulationDataBindingSource.DataSource = typeof(DiscreteEventProcessModel.SimulationData);
            // 
            // functionalityDataGridViewTextBoxColumn
            // 
            this.functionalityDataGridViewTextBoxColumn.DataPropertyName = "Functionality";
            this.functionalityDataGridViewTextBoxColumn.HeaderText = "Functionality";
            this.functionalityDataGridViewTextBoxColumn.Name = "functionalityDataGridViewTextBoxColumn";
            this.functionalityDataGridViewTextBoxColumn.Width = 400;
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
            this.ClientSize = new System.Drawing.Size(885, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadDatabutton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Discrete Event Process Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordPressCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joomlaCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drupalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketReactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource simulationDataBindingSource;
    }
}

