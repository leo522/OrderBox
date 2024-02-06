
namespace OrderBox
{
    partial class Admin_Manage
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
            this.dataGridView_StoreMenu = new System.Windows.Forms.DataGridView();
            this.btn_AllStore = new System.Windows.Forms.Button();
            this.btn_SelectStore = new System.Windows.Forms.Button();
            this.comboBox_SelectStore = new System.Windows.Forms.ComboBox();
            this.lab_SelectStore = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_MealsID = new System.Windows.Forms.TextBox();
            this.btn_AddMeals = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_DelMeals = new System.Windows.Forms.Button();
            this.btn_ChangMeals = new System.Windows.Forms.Button();
            this.txt_MealsPrice = new System.Windows.Forms.TextBox();
            this.txt_MealsItem = new System.Windows.Forms.TextBox();
            this.lab_MealsPrice = new System.Windows.Forms.Label();
            this.lab_MealsItem = new System.Windows.Forms.Label();
            this.txt_StoreName = new System.Windows.Forms.TextBox();
            this.lab_Store_Name = new System.Windows.Forms.Label();
            this.lab_MealsID = new System.Windows.Forms.Label();
            this.comboBox_InsertStore = new System.Windows.Forms.ComboBox();
            this.btn_InsertStore = new System.Windows.Forms.Button();
            this.lab_StoreName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CancelDuty = new System.Windows.Forms.Button();
            this.btn_SpecifyDuty = new System.Windows.Forms.Button();
            this.txt_DeptID = new System.Windows.Forms.TextBox();
            this.lab_DeptID = new System.Windows.Forms.Label();
            this.dataGridView_Duty = new System.Windows.Forms.DataGridView();
            this.btn_AllDept = new System.Windows.Forms.Button();
            this.btn_SelectDept = new System.Windows.Forms.Button();
            this.comboBox_SelectDept = new System.Windows.Forms.ComboBox();
            this.lab_SelectDept = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_EmpTel = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpDept = new System.Windows.Forms.TextBox();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.btn_AddEmp = new System.Windows.Forms.Button();
            this.btn_ClearEmp = new System.Windows.Forms.Button();
            this.btn_DelEmp = new System.Windows.Forms.Button();
            this.btn_ChangeEmp = new System.Windows.Forms.Button();
            this.lab_Tel = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Dept = new System.Windows.Forms.Label();
            this.lab_EmpID = new System.Windows.Forms.Label();
            this.btn_Inser_DeptName = new System.Windows.Forms.Button();
            this.comboBox_Insert_DeptName = new System.Windows.Forms.ComboBox();
            this.lab_InsertDept = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StoreMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Duty)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_StoreMenu);
            this.groupBox1.Controls.Add(this.btn_AllStore);
            this.groupBox1.Controls.Add(this.btn_SelectStore);
            this.groupBox1.Controls.Add(this.comboBox_SelectStore);
            this.groupBox1.Controls.Add(this.lab_SelectStore);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐廳";
            // 
            // dataGridView_StoreMenu
            // 
            this.dataGridView_StoreMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StoreMenu.Location = new System.Drawing.Point(7, 193);
            this.dataGridView_StoreMenu.Name = "dataGridView_StoreMenu";
            this.dataGridView_StoreMenu.RowTemplate.Height = 25;
            this.dataGridView_StoreMenu.Size = new System.Drawing.Size(302, 267);
            this.dataGridView_StoreMenu.TabIndex = 4;
            this.dataGridView_StoreMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StoreMenu_CellContentClick);
            // 
            // btn_AllStore
            // 
            this.btn_AllStore.Location = new System.Drawing.Point(246, 64);
            this.btn_AllStore.Name = "btn_AllStore";
            this.btn_AllStore.Size = new System.Drawing.Size(87, 23);
            this.btn_AllStore.TabIndex = 3;
            this.btn_AllStore.Text = "顯示所有餐廳";
            this.btn_AllStore.UseVisualStyleBackColor = true;
            this.btn_AllStore.Click += new System.EventHandler(this.btn_AllStore_Click);
            // 
            // btn_SelectStore
            // 
            this.btn_SelectStore.Location = new System.Drawing.Point(134, 64);
            this.btn_SelectStore.Name = "btn_SelectStore";
            this.btn_SelectStore.Size = new System.Drawing.Size(106, 23);
            this.btn_SelectStore.TabIndex = 2;
            this.btn_SelectStore.Text = "顯示選擇餐廳";
            this.btn_SelectStore.UseVisualStyleBackColor = true;
            this.btn_SelectStore.Click += new System.EventHandler(this.btn_SelectStore_Click);
            // 
            // comboBox_SelectStore
            // 
            this.comboBox_SelectStore.FormattingEnabled = true;
            this.comboBox_SelectStore.Location = new System.Drawing.Point(7, 65);
            this.comboBox_SelectStore.Name = "comboBox_SelectStore";
            this.comboBox_SelectStore.Size = new System.Drawing.Size(121, 23);
            this.comboBox_SelectStore.TabIndex = 1;
            // 
            // lab_SelectStore
            // 
            this.lab_SelectStore.AutoSize = true;
            this.lab_SelectStore.Location = new System.Drawing.Point(7, 31);
            this.lab_SelectStore.Name = "lab_SelectStore";
            this.lab_SelectStore.Size = new System.Drawing.Size(55, 15);
            this.lab_SelectStore.TabIndex = 0;
            this.lab_SelectStore.Text = "餐廳選擇";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MealsID);
            this.groupBox2.Controls.Add(this.btn_AddMeals);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_DelMeals);
            this.groupBox2.Controls.Add(this.btn_ChangMeals);
            this.groupBox2.Controls.Add(this.txt_MealsPrice);
            this.groupBox2.Controls.Add(this.txt_MealsItem);
            this.groupBox2.Controls.Add(this.lab_MealsPrice);
            this.groupBox2.Controls.Add(this.lab_MealsItem);
            this.groupBox2.Controls.Add(this.txt_StoreName);
            this.groupBox2.Controls.Add(this.lab_Store_Name);
            this.groupBox2.Controls.Add(this.lab_MealsID);
            this.groupBox2.Controls.Add(this.comboBox_InsertStore);
            this.groupBox2.Controls.Add(this.btn_InsertStore);
            this.groupBox2.Controls.Add(this.lab_StoreName);
            this.groupBox2.Location = new System.Drawing.Point(370, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 610);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新增餐點";
            // 
            // txt_MealsID
            // 
            this.txt_MealsID.Location = new System.Drawing.Point(95, 109);
            this.txt_MealsID.Name = "txt_MealsID";
            this.txt_MealsID.ReadOnly = true;
            this.txt_MealsID.Size = new System.Drawing.Size(100, 23);
            this.txt_MealsID.TabIndex = 14;
            // 
            // btn_AddMeals
            // 
            this.btn_AddMeals.Location = new System.Drawing.Point(141, 442);
            this.btn_AddMeals.Name = "btn_AddMeals";
            this.btn_AddMeals.Size = new System.Drawing.Size(75, 23);
            this.btn_AddMeals.TabIndex = 13;
            this.btn_AddMeals.Text = "新增餐點";
            this.btn_AddMeals.UseVisualStyleBackColor = true;
            this.btn_AddMeals.Click += new System.EventHandler(this.btn_AddMeals_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(7, 443);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "清空欄位";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_DelMeals
            // 
            this.btn_DelMeals.Location = new System.Drawing.Point(141, 371);
            this.btn_DelMeals.Name = "btn_DelMeals";
            this.btn_DelMeals.Size = new System.Drawing.Size(75, 23);
            this.btn_DelMeals.TabIndex = 11;
            this.btn_DelMeals.Text = "刪除餐點";
            this.btn_DelMeals.UseVisualStyleBackColor = true;
            this.btn_DelMeals.Click += new System.EventHandler(this.btn_DelMeals_Click);
            // 
            // btn_ChangMeals
            // 
            this.btn_ChangMeals.Location = new System.Drawing.Point(7, 371);
            this.btn_ChangMeals.Name = "btn_ChangMeals";
            this.btn_ChangMeals.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangMeals.TabIndex = 10;
            this.btn_ChangMeals.Text = "修改餐點";
            this.btn_ChangMeals.UseVisualStyleBackColor = true;
            this.btn_ChangMeals.Click += new System.EventHandler(this.btn_ChangMeals_Click);
            // 
            // txt_MealsPrice
            // 
            this.txt_MealsPrice.Location = new System.Drawing.Point(95, 281);
            this.txt_MealsPrice.Name = "txt_MealsPrice";
            this.txt_MealsPrice.Size = new System.Drawing.Size(100, 23);
            this.txt_MealsPrice.TabIndex = 9;
            // 
            // txt_MealsItem
            // 
            this.txt_MealsItem.Location = new System.Drawing.Point(95, 230);
            this.txt_MealsItem.Name = "txt_MealsItem";
            this.txt_MealsItem.Size = new System.Drawing.Size(100, 23);
            this.txt_MealsItem.TabIndex = 8;
            // 
            // lab_MealsPrice
            // 
            this.lab_MealsPrice.AutoSize = true;
            this.lab_MealsPrice.Location = new System.Drawing.Point(7, 281);
            this.lab_MealsPrice.Name = "lab_MealsPrice";
            this.lab_MealsPrice.Size = new System.Drawing.Size(55, 15);
            this.lab_MealsPrice.TabIndex = 7;
            this.lab_MealsPrice.Text = "餐點價錢";
            // 
            // lab_MealsItem
            // 
            this.lab_MealsItem.AutoSize = true;
            this.lab_MealsItem.Location = new System.Drawing.Point(7, 230);
            this.lab_MealsItem.Name = "lab_MealsItem";
            this.lab_MealsItem.Size = new System.Drawing.Size(55, 15);
            this.lab_MealsItem.TabIndex = 6;
            this.lab_MealsItem.Text = "餐點項目";
            // 
            // txt_StoreName
            // 
            this.txt_StoreName.Location = new System.Drawing.Point(95, 168);
            this.txt_StoreName.Name = "txt_StoreName";
            this.txt_StoreName.Size = new System.Drawing.Size(100, 23);
            this.txt_StoreName.TabIndex = 5;
            // 
            // lab_Store_Name
            // 
            this.lab_Store_Name.AutoSize = true;
            this.lab_Store_Name.Location = new System.Drawing.Point(7, 168);
            this.lab_Store_Name.Name = "lab_Store_Name";
            this.lab_Store_Name.Size = new System.Drawing.Size(55, 15);
            this.lab_Store_Name.TabIndex = 4;
            this.lab_Store_Name.Text = "餐廳名稱";
            // 
            // lab_MealsID
            // 
            this.lab_MealsID.AutoSize = true;
            this.lab_MealsID.Location = new System.Drawing.Point(7, 109);
            this.lab_MealsID.Name = "lab_MealsID";
            this.lab_MealsID.Size = new System.Drawing.Size(43, 15);
            this.lab_MealsID.TabIndex = 3;
            this.lab_MealsID.Text = "餐點ID";
            // 
            // comboBox_InsertStore
            // 
            this.comboBox_InsertStore.FormattingEnabled = true;
            this.comboBox_InsertStore.Location = new System.Drawing.Point(7, 54);
            this.comboBox_InsertStore.Name = "comboBox_InsertStore";
            this.comboBox_InsertStore.Size = new System.Drawing.Size(121, 23);
            this.comboBox_InsertStore.TabIndex = 2;
            this.comboBox_InsertStore.SelectedIndexChanged += new System.EventHandler(this.comboBox_InsertStore_SelectedIndexChanged);
            // 
            // btn_InsertStore
            // 
            this.btn_InsertStore.Location = new System.Drawing.Point(154, 54);
            this.btn_InsertStore.Name = "btn_InsertStore";
            this.btn_InsertStore.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertStore.TabIndex = 1;
            this.btn_InsertStore.Text = "填入";
            this.btn_InsertStore.UseVisualStyleBackColor = true;
            this.btn_InsertStore.Click += new System.EventHandler(this.btn_InsertStore_Click);
            // 
            // lab_StoreName
            // 
            this.lab_StoreName.AutoSize = true;
            this.lab_StoreName.Location = new System.Drawing.Point(7, 23);
            this.lab_StoreName.Name = "lab_StoreName";
            this.lab_StoreName.Size = new System.Drawing.Size(103, 15);
            this.lab_StoreName.TabIndex = 0;
            this.lab_StoreName.Text = "快速填入餐廳名稱";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CancelDuty);
            this.groupBox3.Controls.Add(this.btn_SpecifyDuty);
            this.groupBox3.Controls.Add(this.txt_DeptID);
            this.groupBox3.Controls.Add(this.lab_DeptID);
            this.groupBox3.Controls.Add(this.dataGridView_Duty);
            this.groupBox3.Controls.Add(this.btn_AllDept);
            this.groupBox3.Controls.Add(this.btn_SelectDept);
            this.groupBox3.Controls.Add(this.comboBox_SelectDept);
            this.groupBox3.Controls.Add(this.lab_SelectDept);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(653, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 600);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "人員";
            // 
            // btn_CancelDuty
            // 
            this.btn_CancelDuty.Location = new System.Drawing.Point(151, 510);
            this.btn_CancelDuty.Name = "btn_CancelDuty";
            this.btn_CancelDuty.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelDuty.TabIndex = 8;
            this.btn_CancelDuty.Text = "取消值日生";
            this.btn_CancelDuty.UseVisualStyleBackColor = true;
            this.btn_CancelDuty.Click += new System.EventHandler(this.btn_CancelDuty_Click);
            // 
            // btn_SpecifyDuty
            // 
            this.btn_SpecifyDuty.Location = new System.Drawing.Point(33, 511);
            this.btn_SpecifyDuty.Name = "btn_SpecifyDuty";
            this.btn_SpecifyDuty.Size = new System.Drawing.Size(75, 23);
            this.btn_SpecifyDuty.TabIndex = 7;
            this.btn_SpecifyDuty.Text = "指定值日生";
            this.btn_SpecifyDuty.UseVisualStyleBackColor = true;
            this.btn_SpecifyDuty.Click += new System.EventHandler(this.btn_SpecifyDuty_Click);
            // 
            // txt_DeptID
            // 
            this.txt_DeptID.Location = new System.Drawing.Point(33, 466);
            this.txt_DeptID.Name = "txt_DeptID";
            this.txt_DeptID.ReadOnly = true;
            this.txt_DeptID.Size = new System.Drawing.Size(100, 23);
            this.txt_DeptID.TabIndex = 6;
            // 
            // lab_DeptID
            // 
            this.lab_DeptID.AutoSize = true;
            this.lab_DeptID.Location = new System.Drawing.Point(7, 475);
            this.lab_DeptID.Name = "lab_DeptID";
            this.lab_DeptID.Size = new System.Drawing.Size(19, 15);
            this.lab_DeptID.TabIndex = 5;
            this.lab_DeptID.Text = "ID";
            // 
            // dataGridView_Duty
            // 
            this.dataGridView_Duty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Duty.Location = new System.Drawing.Point(7, 172);
            this.dataGridView_Duty.Name = "dataGridView_Duty";
            this.dataGridView_Duty.RowTemplate.Height = 25;
            this.dataGridView_Duty.Size = new System.Drawing.Size(290, 267);
            this.dataGridView_Duty.TabIndex = 4;
            this.dataGridView_Duty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Duty_CellContentClick);
            // 
            // btn_AllDept
            // 
            this.btn_AllDept.Location = new System.Drawing.Point(213, 75);
            this.btn_AllDept.Name = "btn_AllDept";
            this.btn_AllDept.Size = new System.Drawing.Size(96, 23);
            this.btn_AllDept.TabIndex = 3;
            this.btn_AllDept.Text = "顯示所有部門";
            this.btn_AllDept.UseVisualStyleBackColor = true;
            this.btn_AllDept.Click += new System.EventHandler(this.btn_AllDept_Click);
            // 
            // btn_SelectDept
            // 
            this.btn_SelectDept.Location = new System.Drawing.Point(109, 75);
            this.btn_SelectDept.Name = "btn_SelectDept";
            this.btn_SelectDept.Size = new System.Drawing.Size(88, 23);
            this.btn_SelectDept.TabIndex = 2;
            this.btn_SelectDept.Text = "顯示選擇部門";
            this.btn_SelectDept.UseVisualStyleBackColor = true;
            this.btn_SelectDept.Click += new System.EventHandler(this.btn_SelectDept_Click);
            // 
            // comboBox_SelectDept
            // 
            this.comboBox_SelectDept.FormattingEnabled = true;
            this.comboBox_SelectDept.Location = new System.Drawing.Point(7, 76);
            this.comboBox_SelectDept.Name = "comboBox_SelectDept";
            this.comboBox_SelectDept.Size = new System.Drawing.Size(96, 23);
            this.comboBox_SelectDept.TabIndex = 1;
            // 
            // lab_SelectDept
            // 
            this.lab_SelectDept.AutoSize = true;
            this.lab_SelectDept.Location = new System.Drawing.Point(28, 44);
            this.lab_SelectDept.Name = "lab_SelectDept";
            this.lab_SelectDept.Size = new System.Drawing.Size(55, 15);
            this.lab_SelectDept.TabIndex = 0;
            this.lab_SelectDept.Text = "部門選擇";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_EmpTel);
            this.groupBox4.Controls.Add(this.txt_EmpName);
            this.groupBox4.Controls.Add(this.txt_EmpDept);
            this.groupBox4.Controls.Add(this.txt_EmpID);
            this.groupBox4.Controls.Add(this.btn_AddEmp);
            this.groupBox4.Controls.Add(this.btn_ClearEmp);
            this.groupBox4.Controls.Add(this.btn_DelEmp);
            this.groupBox4.Controls.Add(this.btn_ChangeEmp);
            this.groupBox4.Controls.Add(this.lab_Tel);
            this.groupBox4.Controls.Add(this.lab_Name);
            this.groupBox4.Controls.Add(this.lab_Dept);
            this.groupBox4.Controls.Add(this.lab_EmpID);
            this.groupBox4.Controls.Add(this.btn_Inser_DeptName);
            this.groupBox4.Controls.Add(this.comboBox_Insert_DeptName);
            this.groupBox4.Controls.Add(this.lab_InsertDept);
            this.groupBox4.Location = new System.Drawing.Point(999, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 590);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "新增人員";
            // 
            // txt_EmpTel
            // 
            this.txt_EmpTel.Location = new System.Drawing.Point(103, 265);
            this.txt_EmpTel.Name = "txt_EmpTel";
            this.txt_EmpTel.Size = new System.Drawing.Size(100, 23);
            this.txt_EmpTel.TabIndex = 14;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(103, 217);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(100, 23);
            this.txt_EmpName.TabIndex = 13;
            // 
            // txt_EmpDept
            // 
            this.txt_EmpDept.Location = new System.Drawing.Point(103, 171);
            this.txt_EmpDept.Name = "txt_EmpDept";
            this.txt_EmpDept.Size = new System.Drawing.Size(100, 23);
            this.txt_EmpDept.TabIndex = 12;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(103, 126);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.ReadOnly = true;
            this.txt_EmpID.Size = new System.Drawing.Size(100, 23);
            this.txt_EmpID.TabIndex = 11;
            // 
            // btn_AddEmp
            // 
            this.btn_AddEmp.Location = new System.Drawing.Point(143, 406);
            this.btn_AddEmp.Name = "btn_AddEmp";
            this.btn_AddEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_AddEmp.TabIndex = 10;
            this.btn_AddEmp.Text = "新增人員";
            this.btn_AddEmp.UseVisualStyleBackColor = true;
            this.btn_AddEmp.Click += new System.EventHandler(this.btn_AddEmp_Click);
            // 
            // btn_ClearEmp
            // 
            this.btn_ClearEmp.Location = new System.Drawing.Point(7, 405);
            this.btn_ClearEmp.Name = "btn_ClearEmp";
            this.btn_ClearEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearEmp.TabIndex = 9;
            this.btn_ClearEmp.Text = "清空欄位";
            this.btn_ClearEmp.UseVisualStyleBackColor = true;
            this.btn_ClearEmp.Click += new System.EventHandler(this.btn_ClearEmp_Click);
            // 
            // btn_DelEmp
            // 
            this.btn_DelEmp.Location = new System.Drawing.Point(143, 350);
            this.btn_DelEmp.Name = "btn_DelEmp";
            this.btn_DelEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_DelEmp.TabIndex = 8;
            this.btn_DelEmp.Text = "刪除人員";
            this.btn_DelEmp.UseVisualStyleBackColor = true;
            this.btn_DelEmp.Click += new System.EventHandler(this.btn_DelEmp_Click);
            // 
            // btn_ChangeEmp
            // 
            this.btn_ChangeEmp.Location = new System.Drawing.Point(7, 351);
            this.btn_ChangeEmp.Name = "btn_ChangeEmp";
            this.btn_ChangeEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeEmp.TabIndex = 7;
            this.btn_ChangeEmp.Text = "修改人員";
            this.btn_ChangeEmp.UseVisualStyleBackColor = true;
            this.btn_ChangeEmp.Click += new System.EventHandler(this.btn_ChangeEmp_Click);
            // 
            // lab_Tel
            // 
            this.lab_Tel.AutoSize = true;
            this.lab_Tel.Location = new System.Drawing.Point(18, 268);
            this.lab_Tel.Name = "lab_Tel";
            this.lab_Tel.Size = new System.Drawing.Size(55, 15);
            this.lab_Tel.TabIndex = 6;
            this.lab_Tel.Text = "電話號碼";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(18, 217);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(31, 15);
            this.lab_Name.TabIndex = 5;
            this.lab_Name.Text = "姓名";
            // 
            // lab_Dept
            // 
            this.lab_Dept.AutoSize = true;
            this.lab_Dept.Location = new System.Drawing.Point(18, 171);
            this.lab_Dept.Name = "lab_Dept";
            this.lab_Dept.Size = new System.Drawing.Size(31, 15);
            this.lab_Dept.TabIndex = 4;
            this.lab_Dept.Text = "部門";
            // 
            // lab_EmpID
            // 
            this.lab_EmpID.AutoSize = true;
            this.lab_EmpID.Location = new System.Drawing.Point(18, 126);
            this.lab_EmpID.Name = "lab_EmpID";
            this.lab_EmpID.Size = new System.Drawing.Size(43, 15);
            this.lab_EmpID.TabIndex = 3;
            this.lab_EmpID.Text = "人員ID";
            // 
            // btn_Inser_DeptName
            // 
            this.btn_Inser_DeptName.Location = new System.Drawing.Point(163, 66);
            this.btn_Inser_DeptName.Name = "btn_Inser_DeptName";
            this.btn_Inser_DeptName.Size = new System.Drawing.Size(75, 23);
            this.btn_Inser_DeptName.TabIndex = 2;
            this.btn_Inser_DeptName.Text = "填入";
            this.btn_Inser_DeptName.UseVisualStyleBackColor = true;
            this.btn_Inser_DeptName.Click += new System.EventHandler(this.btn_Inser_DeptName_Click);
            // 
            // comboBox_Insert_DeptName
            // 
            this.comboBox_Insert_DeptName.FormattingEnabled = true;
            this.comboBox_Insert_DeptName.Location = new System.Drawing.Point(7, 65);
            this.comboBox_Insert_DeptName.Name = "comboBox_Insert_DeptName";
            this.comboBox_Insert_DeptName.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Insert_DeptName.TabIndex = 1;
            // 
            // lab_InsertDept
            // 
            this.lab_InsertDept.AutoSize = true;
            this.lab_InsertDept.Location = new System.Drawing.Point(7, 33);
            this.lab_InsertDept.Name = "lab_InsertDept";
            this.lab_InsertDept.Size = new System.Drawing.Size(103, 15);
            this.lab_InsertDept.TabIndex = 0;
            this.lab_InsertDept.Text = "快速填入部門名稱";
            // 
            // Admin_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 756);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Manage";
            this.Text = "後台管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StoreMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Duty)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_StoreMenu;
        private System.Windows.Forms.Button btn_AllStore;
        private System.Windows.Forms.Button btn_SelectStore;
        private System.Windows.Forms.ComboBox comboBox_SelectStore;
        private System.Windows.Forms.Label lab_SelectStore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_InsertStore;
        private System.Windows.Forms.Button btn_InsertStore;
        private System.Windows.Forms.Label lab_StoreName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_MealsID;
        private System.Windows.Forms.Button btn_AddMeals;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_DelMeals;
        private System.Windows.Forms.Button btn_ChangMeals;
        private System.Windows.Forms.TextBox txt_MealsPrice;
        private System.Windows.Forms.TextBox txt_MealsItem;
        private System.Windows.Forms.Label lab_MealsPrice;
        private System.Windows.Forms.Label lab_MealsItem;
        private System.Windows.Forms.TextBox txt_StoreName;
        private System.Windows.Forms.Label lab_Store_Name;
        private System.Windows.Forms.ComboBox comboBox_SelectDept;
        private System.Windows.Forms.Label lab_SelectDept;
        private System.Windows.Forms.Button btn_AllDept;
        private System.Windows.Forms.Button btn_SelectDept;
        private System.Windows.Forms.DataGridView dataGridView_Duty;
        private System.Windows.Forms.TextBox txt_MealsID;
        private System.Windows.Forms.TextBox txt_DeptID;
        private System.Windows.Forms.Label lab_DeptID;
        private System.Windows.Forms.Button btn_CancelDuty;
        private System.Windows.Forms.Button btn_SpecifyDuty;
        private System.Windows.Forms.Button btn_Inser_DeptName;
        private System.Windows.Forms.ComboBox comboBox_Insert_DeptName;
        private System.Windows.Forms.Label lab_InsertDept;
        private System.Windows.Forms.Label lab_Tel;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Dept;
        private System.Windows.Forms.Label lab_EmpID;
        private System.Windows.Forms.Button btn_AddEmp;
        private System.Windows.Forms.Button btn_ClearEmp;
        private System.Windows.Forms.Button btn_DelEmp;
        private System.Windows.Forms.Button btn_ChangeEmp;
        private System.Windows.Forms.TextBox txt_EmpTel;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_EmpDept;
        private System.Windows.Forms.TextBox txt_EmpID;
    }
}