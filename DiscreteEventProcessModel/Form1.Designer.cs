﻿namespace DiscreteEventProcessModel
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
            this.newDataGridView1 = new AdvDataGridView.NewDataGridView(this.components);
            this.newListBox3 = new AdvListBox.NewListBox(this.components);
            this.newListBox1 = new AdvListBox.NewListBox(this.components);
            this.newListBox2 = new AdvListBox.NewListBox(this.components);
            this.newListBox4 = new AdvListBox.NewListBox(this.components);
            this.DependsOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordPressCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joomlaCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drupalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newDataGridView1)).BeginInit();
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
            // newDataGridView1
            // 
            this.newDataGridView1.AutoGenerateColumns = false;
            this.newDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionalityDataGridViewTextBoxColumn,
            this.wordPressCostDataGridViewTextBoxColumn,
            this.joomlaCostDataGridViewTextBoxColumn,
            this.drupalCostDataGridViewTextBoxColumn,
            this.DependsOn});
            this.newDataGridView1.DataSource = this.simulationDataBindingSource;
            this.newDataGridView1.ListBoxCollection = new AdvListBox.NewListBox[] {
        this.newListBox4};
            this.newDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.newDataGridView1.Name = "newDataGridView1";
            this.newDataGridView1.Size = new System.Drawing.Size(861, 240);
            this.newDataGridView1.TabIndex = 3;
            this.newDataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.newDataGridView1_CellEnter);
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
            // DependsOn
            // 
            this.DependsOn.HeaderText = "DependsOn";
            this.DependsOn.Name = "DependsOn";
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
            // simulationDataBindingSource
            // 
            this.simulationDataBindingSource.DataSource = typeof(DiscreteEventProcessModel.SimulationData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 293);
            this.Controls.Add(this.newDataGridView1);
            this.Controls.Add(this.loadDatabutton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadDatabutton;
        private AdvDataGridView.NewDataGridView newDataGridView1;
        private AdvListBox.NewListBox newListBox1;
        private AdvListBox.NewListBox newListBox3;
        private AdvListBox.NewListBox newListBox2;
        private System.Windows.Forms.BindingSource simulationDataBindingSource;
        private AdvListBox.NewListBox newListBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordPressCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joomlaCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drupalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DependsOn;
    }
}

