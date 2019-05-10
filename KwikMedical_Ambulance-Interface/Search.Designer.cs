namespace KwikMedical_Ambulance_Interface
{
    partial class Search
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_Instruction1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_Hospital = new System.Windows.Forms.ComboBox();
            this.data_searchResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_searchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(92, 89);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(180, 22);
            this.tb_search.TabIndex = 0;
            // 
            // lbl_Instruction1
            // 
            this.lbl_Instruction1.AutoSize = true;
            this.lbl_Instruction1.Location = new System.Drawing.Point(30, 47);
            this.lbl_Instruction1.Name = "lbl_Instruction1";
            this.lbl_Instruction1.Size = new System.Drawing.Size(352, 17);
            this.lbl_Instruction1.TabIndex = 1;
            this.lbl_Instruction1.Text = "Please enter NHS Registration No. or select a Hospital";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(120, 240);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_Hospital
            // 
            this.cb_Hospital.FormattingEnabled = true;
            this.cb_Hospital.Location = new System.Drawing.Point(80, 147);
            this.cb_Hospital.Name = "cb_Hospital";
            this.cb_Hospital.Size = new System.Drawing.Size(205, 24);
            this.cb_Hospital.TabIndex = 4;
            // 
            // data_searchResults
            // 
            this.data_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_searchResults.Location = new System.Drawing.Point(437, 36);
            this.data_searchResults.Name = "data_searchResults";
            this.data_searchResults.ReadOnly = true;
            this.data_searchResults.RowTemplate.Height = 24;
            this.data_searchResults.Size = new System.Drawing.Size(533, 249);
            this.data_searchResults.TabIndex = 5;
            this.data_searchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_searchResults_CellClick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 308);
            this.Controls.Add(this.data_searchResults);
            this.Controls.Add(this.cb_Hospital);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_Instruction1);
            this.Controls.Add(this.tb_search);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.data_searchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_Instruction1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_Hospital;
        private System.Windows.Forms.DataGridView data_searchResults;
    }
}