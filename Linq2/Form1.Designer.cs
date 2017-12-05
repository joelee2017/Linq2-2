namespace Linq2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(129, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "查詢品名：";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(414, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.Location = new System.Drawing.Point(414, 133);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(96, 40);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "產品資料";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAsc.Location = new System.Drawing.Point(414, 196);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(96, 40);
            this.btnSortAsc.TabIndex = 4;
            this.btnSortAsc.Text = "遞增排序";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDesc.Location = new System.Drawing.Point(414, 264);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(96, 40);
            this.btnSortDesc.TabIndex = 5;
            this.btnSortDesc.Text = "遞減排序";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 226);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

