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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.funcionalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(373, 258);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(353, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Enabled = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadDatabutton
            // 
            this.loadDatabutton.Location = new System.Drawing.Point(12, 258);
            this.loadDatabutton.Name = "loadDatabutton";
            this.loadDatabutton.Size = new System.Drawing.Size(355, 23);
            this.loadDatabutton.TabIndex = 2;
            this.loadDatabutton.Text = "Load data";
            this.loadDatabutton.UseVisualStyleBackColor = true;
            this.loadDatabutton.Click += new System.EventHandler(this.loadDatabutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionalityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // funcionalityBindingSource
            // 
            this.funcionalityBindingSource.DataSource = typeof(DiscreteEventProcessModel.Funcionality);
            // 
            // automationBindingSource
            // 
            this.automationBindingSource.DataSource = typeof(DiscreteEventProcessModel.Automation);
            // 
            // automationBindingSource1
            // 
            this.automationBindingSource1.DataSource = typeof(DiscreteEventProcessModel.Automation);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 600;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadDatabutton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.BindingSource automationBindingSource;
        private System.Windows.Forms.Button loadDatabutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource automationBindingSource1;
        private System.Windows.Forms.BindingSource funcionalityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}

