
namespace OrderBox
{
    partial class ViewList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OpenOrder = new System.Windows.Forms.Button();
            this.listBox_BornOnDuty = new System.Windows.Forms.ListBox();
            this.lab_TodayBorn = new System.Windows.Forms.Label();
            this.ckb_BornOnDuty = new System.Windows.Forms.CheckBox();
            this.btn_Manage = new System.Windows.Forms.Button();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.comboBox_Dept = new System.Windows.Forms.ComboBox();
            this.lab_Tel = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Dept = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Menu = new System.Windows.Forms.DataGridView();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.lab_Dollars = new System.Windows.Forms.Label();
            this.lab_Price = new System.Windows.Forms.Label();
            this.lab_Item = new System.Windows.Forms.Label();
            this.lab_StoreName = new System.Windows.Forms.Label();
            this.btn_AllStore = new System.Windows.Forms.Button();
            this.btn_SelectStore = new System.Windows.Forms.Button();
            this.comboBox_Store = new System.Windows.Forms.ComboBox();
            this.lab_Store = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_OrderList = new System.Windows.Forms.DataGridView();
            this.lab_TotalMoney = new System.Windows.Forms.Label();
            this.but_Del = new System.Windows.Forms.Button();
            this.txt_DelItem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OpenOrder);
            this.groupBox1.Controls.Add(this.listBox_BornOnDuty);
            this.groupBox1.Controls.Add(this.lab_TodayBorn);
            this.groupBox1.Controls.Add(this.ckb_BornOnDuty);
            this.groupBox1.Controls.Add(this.btn_Manage);
            this.groupBox1.Controls.Add(this.txt_Tel);
            this.groupBox1.Controls.Add(this.comboBox_Name);
            this.groupBox1.Controls.Add(this.comboBox_Dept);
            this.groupBox1.Controls.Add(this.lab_Tel);
            this.groupBox1.Controls.Add(this.lab_Name);
            this.groupBox1.Controls.Add(this.lab_Dept);
            this.groupBox1.Location = new System.Drawing.Point(34, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購人資訊";
            // 
            // btn_OpenOrder
            // 
            this.btn_OpenOrder.Location = new System.Drawing.Point(26, 373);
            this.btn_OpenOrder.Name = "btn_OpenOrder";
            this.btn_OpenOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenOrder.TabIndex = 9;
            this.btn_OpenOrder.Text = "開啟訂購單";
            this.btn_OpenOrder.UseVisualStyleBackColor = true;
            this.btn_OpenOrder.Click += new System.EventHandler(this.btn_OpenOrder_Click);
            // 
            // listBox_BornOnDuty
            // 
            this.listBox_BornOnDuty.FormattingEnabled = true;
            this.listBox_BornOnDuty.ItemHeight = 15;
            this.listBox_BornOnDuty.Location = new System.Drawing.Point(150, 277);
            this.listBox_BornOnDuty.Name = "listBox_BornOnDuty";
            this.listBox_BornOnDuty.Size = new System.Drawing.Size(120, 94);
            this.listBox_BornOnDuty.TabIndex = 3;
            // 
            // lab_TodayBorn
            // 
            this.lab_TodayBorn.AutoSize = true;
            this.lab_TodayBorn.Location = new System.Drawing.Point(66, 279);
            this.lab_TodayBorn.Name = "lab_TodayBorn";
            this.lab_TodayBorn.Size = new System.Drawing.Size(67, 15);
            this.lab_TodayBorn.TabIndex = 8;
            this.lab_TodayBorn.Text = "今日值日生";
            // 
            // ckb_BornOnDuty
            // 
            this.ckb_BornOnDuty.AutoSize = true;
            this.ckb_BornOnDuty.Location = new System.Drawing.Point(71, 218);
            this.ckb_BornOnDuty.Name = "ckb_BornOnDuty";
            this.ckb_BornOnDuty.Size = new System.Drawing.Size(62, 19);
            this.ckb_BornOnDuty.TabIndex = 7;
            this.ckb_BornOnDuty.Text = "值日生";
            this.ckb_BornOnDuty.UseVisualStyleBackColor = true;
            // 
            // btn_Manage
            // 
            this.btn_Manage.Location = new System.Drawing.Point(105, 401);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(75, 23);
            this.btn_Manage.TabIndex = 6;
            this.btn_Manage.Text = "後台登入";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(80, 167);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 23);
            this.txt_Tel.TabIndex = 5;
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(80, 114);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Name.TabIndex = 4;
            // 
            // comboBox_Dept
            // 
            this.comboBox_Dept.FormattingEnabled = true;
            this.comboBox_Dept.Location = new System.Drawing.Point(80, 39);
            this.comboBox_Dept.Name = "comboBox_Dept";
            this.comboBox_Dept.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Dept.TabIndex = 3;
            // 
            // lab_Tel
            // 
            this.lab_Tel.AutoSize = true;
            this.lab_Tel.Location = new System.Drawing.Point(6, 157);
            this.lab_Tel.Name = "lab_Tel";
            this.lab_Tel.Size = new System.Drawing.Size(31, 15);
            this.lab_Tel.TabIndex = 2;
            this.lab_Tel.Text = "電話";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(7, 100);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(31, 15);
            this.lab_Name.TabIndex = 1;
            this.lab_Name.Text = "姓名";
            // 
            // lab_Dept
            // 
            this.lab_Dept.AutoSize = true;
            this.lab_Dept.Location = new System.Drawing.Point(7, 39);
            this.lab_Dept.Name = "lab_Dept";
            this.lab_Dept.Size = new System.Drawing.Size(31, 15);
            this.lab_Dept.TabIndex = 0;
            this.lab_Dept.Text = "班級";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Menu);
            this.groupBox2.Controls.Add(this.btn_AddOrder);
            this.groupBox2.Controls.Add(this.lab_Dollars);
            this.groupBox2.Controls.Add(this.lab_Price);
            this.groupBox2.Controls.Add(this.lab_Item);
            this.groupBox2.Controls.Add(this.lab_StoreName);
            this.groupBox2.Controls.Add(this.btn_AllStore);
            this.groupBox2.Controls.Add(this.btn_SelectStore);
            this.groupBox2.Controls.Add(this.comboBox_Store);
            this.groupBox2.Controls.Add(this.lab_Store);
            this.groupBox2.Location = new System.Drawing.Point(376, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "餐廳";
            // 
            // dataGridView_Menu
            // 
            this.dataGridView_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Menu.Location = new System.Drawing.Point(7, 105);
            this.dataGridView_Menu.Name = "dataGridView_Menu";
            this.dataGridView_Menu.RowTemplate.Height = 25;
            this.dataGridView_Menu.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_Menu.TabIndex = 9;
            this.dataGridView_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Menu_CellContentClick);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(300, 368);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(89, 23);
            this.btn_AddOrder.TabIndex = 8;
            this.btn_AddOrder.Text = "加入訂單列表";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // lab_Dollars
            // 
            this.lab_Dollars.AutoSize = true;
            this.lab_Dollars.Location = new System.Drawing.Point(266, 384);
            this.lab_Dollars.Name = "lab_Dollars";
            this.lab_Dollars.Size = new System.Drawing.Size(19, 15);
            this.lab_Dollars.TabIndex = 7;
            this.lab_Dollars.Text = "元";
            // 
            // lab_Price
            // 
            this.lab_Price.AutoSize = true;
            this.lab_Price.Location = new System.Drawing.Point(180, 384);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(31, 15);
            this.lab_Price.TabIndex = 6;
            this.lab_Price.Text = "價錢";
            // 
            // lab_Item
            // 
            this.lab_Item.AutoSize = true;
            this.lab_Item.Location = new System.Drawing.Point(74, 384);
            this.lab_Item.Name = "lab_Item";
            this.lab_Item.Size = new System.Drawing.Size(55, 15);
            this.lab_Item.TabIndex = 5;
            this.lab_Item.Text = "品項名稱";
            // 
            // lab_StoreName
            // 
            this.lab_StoreName.AutoSize = true;
            this.lab_StoreName.Location = new System.Drawing.Point(7, 356);
            this.lab_StoreName.Name = "lab_StoreName";
            this.lab_StoreName.Size = new System.Drawing.Size(55, 15);
            this.lab_StoreName.TabIndex = 4;
            this.lab_StoreName.Text = "餐廳名稱";
            // 
            // btn_AllStore
            // 
            this.btn_AllStore.Location = new System.Drawing.Point(268, 60);
            this.btn_AllStore.Name = "btn_AllStore";
            this.btn_AllStore.Size = new System.Drawing.Size(107, 23);
            this.btn_AllStore.TabIndex = 3;
            this.btn_AllStore.Text = "顯示所有餐廳";
            this.btn_AllStore.UseVisualStyleBackColor = true;
            this.btn_AllStore.Click += new System.EventHandler(this.btn_AllStore_Click);
            // 
            // btn_SelectStore
            // 
            this.btn_SelectStore.Location = new System.Drawing.Point(148, 61);
            this.btn_SelectStore.Name = "btn_SelectStore";
            this.btn_SelectStore.Size = new System.Drawing.Size(114, 23);
            this.btn_SelectStore.TabIndex = 2;
            this.btn_SelectStore.Text = "顯示選擇餐廳";
            this.btn_SelectStore.UseVisualStyleBackColor = true;
            this.btn_SelectStore.Click += new System.EventHandler(this.btn_SelectStore_Click);
            // 
            // comboBox_Store
            // 
            this.comboBox_Store.FormattingEnabled = true;
            this.comboBox_Store.Location = new System.Drawing.Point(7, 61);
            this.comboBox_Store.Name = "comboBox_Store";
            this.comboBox_Store.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Store.TabIndex = 1;
            // 
            // lab_Store
            // 
            this.lab_Store.AutoSize = true;
            this.lab_Store.Location = new System.Drawing.Point(7, 30);
            this.lab_Store.Name = "lab_Store";
            this.lab_Store.Size = new System.Drawing.Size(55, 15);
            this.lab_Store.TabIndex = 0;
            this.lab_Store.Text = "餐廳選擇";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_OrderList);
            this.groupBox3.Controls.Add(this.lab_TotalMoney);
            this.groupBox3.Controls.Add(this.but_Del);
            this.groupBox3.Controls.Add(this.txt_DelItem);
            this.groupBox3.Location = new System.Drawing.Point(823, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 415);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂單列表";
            // 
            // dataGridView_OrderList
            // 
            this.dataGridView_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderList.Location = new System.Drawing.Point(26, 79);
            this.dataGridView_OrderList.Name = "dataGridView_OrderList";
            this.dataGridView_OrderList.RowTemplate.Height = 25;
            this.dataGridView_OrderList.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_OrderList.TabIndex = 3;
            this.dataGridView_OrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderList_CellContentClick);
            // 
            // lab_TotalMoney
            // 
            this.lab_TotalMoney.AutoSize = true;
            this.lab_TotalMoney.Location = new System.Drawing.Point(285, 368);
            this.lab_TotalMoney.Name = "lab_TotalMoney";
            this.lab_TotalMoney.Size = new System.Drawing.Size(31, 15);
            this.lab_TotalMoney.TabIndex = 2;
            this.lab_TotalMoney.Text = "總共";
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(165, 326);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 1;
            this.but_Del.Text = "刪除品項";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // txt_DelItem
            // 
            this.txt_DelItem.Location = new System.Drawing.Point(26, 327);
            this.txt_DelItem.Name = "txt_DelItem";
            this.txt_DelItem.Size = new System.Drawing.Size(100, 23);
            this.txt_DelItem.TabIndex = 0;
            // 
            // ViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewList";
            this.Text = "訂餐系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lab_Tel;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Dept;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Dept;
        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Label lab_Dollars;
        private System.Windows.Forms.Label lab_Price;
        private System.Windows.Forms.Label lab_Item;
        private System.Windows.Forms.Label lab_StoreName;
        private System.Windows.Forms.Button btn_AllStore;
        private System.Windows.Forms.Button btn_SelectStore;
        private System.Windows.Forms.ComboBox comboBox_Store;
        private System.Windows.Forms.Label lab_Store;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.TextBox txt_DelItem;
        private System.Windows.Forms.Label lab_TotalMoney;
        private System.Windows.Forms.DataGridView dataGridView_Menu;
        private System.Windows.Forms.DataGridView dataGridView_OrderList;
        private System.Windows.Forms.Label lab_TodayBorn;
        private System.Windows.Forms.CheckBox ckb_BornOnDuty;
        private System.Windows.Forms.ListBox listBox_BornOnDuty;
        private System.Windows.Forms.Button btn_OpenOrder;
    }
}