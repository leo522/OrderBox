
namespace OrderBox
{
    partial class buyItem
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
            this.lab_SelectStore = new System.Windows.Forms.Label();
            this.comboBox_SelectStore = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lab_TotalPrice = new System.Windows.Forms.Label();
            this.lab_Total = new System.Windows.Forms.Label();
            this.btn_Saved = new System.Windows.Forms.Button();
            this.lbox_ListOrder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lab_SelectStore
            // 
            this.lab_SelectStore.AutoSize = true;
            this.lab_SelectStore.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_SelectStore.Location = new System.Drawing.Point(671, 130);
            this.lab_SelectStore.Name = "lab_SelectStore";
            this.lab_SelectStore.Size = new System.Drawing.Size(73, 20);
            this.lab_SelectStore.TabIndex = 0;
            this.lab_SelectStore.Text = "餐廳選擇";
            // 
            // comboBox_SelectStore
            // 
            this.comboBox_SelectStore.FormattingEnabled = true;
            this.comboBox_SelectStore.Location = new System.Drawing.Point(671, 169);
            this.comboBox_SelectStore.Name = "comboBox_SelectStore";
            this.comboBox_SelectStore.Size = new System.Drawing.Size(121, 23);
            this.comboBox_SelectStore.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(878, 168);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 46);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lab_TotalPrice
            // 
            this.lab_TotalPrice.AutoSize = true;
            this.lab_TotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_TotalPrice.Location = new System.Drawing.Point(900, 292);
            this.lab_TotalPrice.Name = "lab_TotalPrice";
            this.lab_TotalPrice.Size = new System.Drawing.Size(49, 20);
            this.lab_TotalPrice.TabIndex = 6;
            this.lab_TotalPrice.Text = "xxx元";
            // 
            // lab_Total
            // 
            this.lab_Total.AutoSize = true;
            this.lab_Total.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_Total.Location = new System.Drawing.Point(810, 292);
            this.lab_Total.Name = "lab_Total";
            this.lab_Total.Size = new System.Drawing.Size(41, 20);
            this.lab_Total.TabIndex = 4;
            this.lab_Total.Text = "總共";
            // 
            // btn_Saved
            // 
            this.btn_Saved.Location = new System.Drawing.Point(810, 360);
            this.btn_Saved.Name = "btn_Saved";
            this.btn_Saved.Size = new System.Drawing.Size(118, 73);
            this.btn_Saved.TabIndex = 5;
            this.btn_Saved.Text = "儲存檔案";
            this.btn_Saved.UseVisualStyleBackColor = true;
            this.btn_Saved.Click += new System.EventHandler(this.btn_Saved_Click);
            // 
            // lbox_ListOrder
            // 
            this.lbox_ListOrder.FormattingEnabled = true;
            this.lbox_ListOrder.ItemHeight = 15;
            this.lbox_ListOrder.Location = new System.Drawing.Point(60, 95);
            this.lbox_ListOrder.Name = "lbox_ListOrder";
            this.lbox_ListOrder.Size = new System.Drawing.Size(441, 349);
            this.lbox_ListOrder.TabIndex = 7;
            this.lbox_ListOrder.SelectedIndexChanged += new System.EventHandler(this.lbox_ListOrder_SelectedIndexChanged);
            // 
            // buyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 790);
            this.Controls.Add(this.lbox_ListOrder);
            this.Controls.Add(this.btn_Saved);
            this.Controls.Add(this.lab_Total);
            this.Controls.Add(this.lab_TotalPrice);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.comboBox_SelectStore);
            this.Controls.Add(this.lab_SelectStore);
            this.Name = "buyItem";
            this.Text = "訂單資訊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_SelectStore;
        private System.Windows.Forms.ComboBox comboBox_SelectStore;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lab_TotalPrice;
        private System.Windows.Forms.Label lab_Total;
        private System.Windows.Forms.Button btn_Saved;
        private System.Windows.Forms.ListBox lbox_ListOrder;
    }
}