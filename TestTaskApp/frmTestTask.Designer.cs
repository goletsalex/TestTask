namespace TestTaskApp
{
    partial class frmTestTask
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
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTimestampTitle = new System.Windows.Forms.Label();
            this.lblTimestampValue = new System.Windows.Forms.Label();
            this.lblOutputValueTitle = new System.Windows.Forms.Label();
            this.lblOutputValueValue = new System.Windows.Forms.Label();
            this.dgvSymbolResults = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbolResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(32, 40);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(338, 35);
            this.dtpDateTime.TabIndex = 0;
            this.dtpDateTime.ValueChanged += new System.EventHandler(this.dtpDateTime_ValueChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(407, 37);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(168, 44);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTimestampTitle
            // 
            this.lblTimestampTitle.AutoSize = true;
            this.lblTimestampTitle.Location = new System.Drawing.Point(27, 117);
            this.lblTimestampTitle.Name = "lblTimestampTitle";
            this.lblTimestampTitle.Size = new System.Drawing.Size(140, 29);
            this.lblTimestampTitle.TabIndex = 2;
            this.lblTimestampTitle.Text = "Timestamp:";
            // 
            // lblTimestampValue
            // 
            this.lblTimestampValue.AutoSize = true;
            this.lblTimestampValue.Location = new System.Drawing.Point(191, 117);
            this.lblTimestampValue.Name = "lblTimestampValue";
            this.lblTimestampValue.Size = new System.Drawing.Size(79, 29);
            this.lblTimestampValue.TabIndex = 3;
            this.lblTimestampValue.Text = "label2";
            // 
            // lblOutputValueTitle
            // 
            this.lblOutputValueTitle.AutoSize = true;
            this.lblOutputValueTitle.Location = new System.Drawing.Point(27, 188);
            this.lblOutputValueTitle.Name = "lblOutputValueTitle";
            this.lblOutputValueTitle.Size = new System.Drawing.Size(157, 29);
            this.lblOutputValueTitle.TabIndex = 4;
            this.lblOutputValueTitle.Text = "Output Value:";
            // 
            // lblOutputValueValue
            // 
            this.lblOutputValueValue.Location = new System.Drawing.Point(191, 188);
            this.lblOutputValueValue.Name = "lblOutputValueValue";
            this.lblOutputValueValue.Size = new System.Drawing.Size(384, 228);
            this.lblOutputValueValue.TabIndex = 5;
            this.lblOutputValueValue.Text = "label4";
            // 
            // dgvSymbolResults
            // 
            this.dgvSymbolResults.AllowUserToAddRows = false;
            this.dgvSymbolResults.AllowUserToDeleteRows = false;
            this.dgvSymbolResults.AllowUserToResizeColumns = false;
            this.dgvSymbolResults.AllowUserToResizeRows = false;
            this.dgvSymbolResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymbolResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Count});
            this.dgvSymbolResults.Location = new System.Drawing.Point(32, 442);
            this.dgvSymbolResults.MultiSelect = false;
            this.dgvSymbolResults.Name = "dgvSymbolResults";
            this.dgvSymbolResults.ReadOnly = true;
            this.dgvSymbolResults.RowHeadersVisible = false;
            this.dgvSymbolResults.RowHeadersWidth = 92;
            this.dgvSymbolResults.RowTemplate.Height = 37;
            this.dgvSymbolResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSymbolResults.Size = new System.Drawing.Size(543, 419);
            this.dgvSymbolResults.TabIndex = 6;
            // 
            // Symbol
            // 
            this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.MinimumWidth = 11;
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 11;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmTestTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 892);
            this.Controls.Add(this.dgvSymbolResults);
            this.Controls.Add(this.lblOutputValueValue);
            this.Controls.Add(this.lblOutputValueTitle);
            this.Controls.Add(this.lblTimestampValue);
            this.Controls.Add(this.lblTimestampTitle);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dtpDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTestTask";
            this.Text = "Test Task";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbolResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTimestampTitle;
        private System.Windows.Forms.Label lblTimestampValue;
        private System.Windows.Forms.Label lblOutputValueTitle;
        private System.Windows.Forms.Label lblOutputValueValue;
        private System.Windows.Forms.DataGridView dgvSymbolResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

