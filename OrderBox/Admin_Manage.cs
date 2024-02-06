using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBox
{
    public partial class Admin_Manage : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public Admin_Manage()
        {
            InitializeComponent();
        }

        #region 快速填入部門

        void 快速填入部門()
        {
            comboBox_Insert_DeptName.Items.Clear();
            string strSQL = "Select Distinct class From member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_Insert_DeptName.Items.Add(reader["class"]);
            }

            reader.Close();
            con.Close();
        }

        #endregion

        #region 值日生介面
        void 值日生介面()
        {
            string strSQL = "Select * From member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_Duty.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 快速填入餐廳名稱
        void 快速填入餐廳名稱()
        {
            comboBox_InsertStore.Items.Clear();
            string strSQL = "Select Distinct eatName From restaurant";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_InsertStore.Items.Add(reader["eatName"]);
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 清空餐點欄位
        void 清空餐點欄位()
        {
            txt_MealsID.Text = "";
            txt_StoreName.Text = "";
            txt_MealsItem.Text = "";
            txt_MealsPrice.Text = "";
        }
        #endregion

        #region 清空人員欄位
        void 清空人員欄位()
        {
            txt_EmpID.Text = "";
            txt_EmpDept.Text = "";
            txt_EmpName.Text = "";
            txt_EmpTel.Text = "";
        }
        #endregion

        #region 餐廳選擇
        void 餐廳選擇()
        {
            comboBox_SelectStore.Items.Clear();
            string strSQL = "select distinct eatName from restaurant";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_SelectStore.Items.Add(reader["class"]);
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 部門選擇
        void 部門選擇()
        {
            comboBox_SelectDept.Items.Clear();
            string strSQL = "Select Distinct class From member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_SelectDept.Items.Add(reader["class"]);
            }
            reader.Close();
            con.Close();
        }
        #endregion

        #region 顯示所有餐廳
        void 顯示所有餐廳()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_StoreMenu.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 產生菜單
        void 產生菜單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant Where eatName = @NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", comboBox_SelectStore.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView_StoreMenu.DataSource = dt;
            }
        }
        #endregion

        #region 後台管理
        private void admin_manage_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "workDB";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            顯示所有餐廳();

            餐廳選擇();  // 加入餐廳名稱

            快速填入餐廳名稱();  // 右側的  快速填寫介面

            值日生介面();  // 右側的值日生介面
            
            部門選擇();

            快速填入部門();  // 右側的 快速填寫介面
        }
        #endregion

        #region 菜單
        private void dataGridView_StoreMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string strSelID = dataGridView_StoreMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant Where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txt_MealsID.Text = string.Format("{0}", reader["id"]);
                txt_StoreName.Text = string.Format("{0}", reader["eatName"]);
                txt_MealsItem.Text = string.Format("{0}", reader["item"]);
                txt_MealsPrice.Text = string.Format("{0}", reader["price"]);
            }
            else
            {
                MessageBox.Show("查無此品項");
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 清空餐點欄位
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            清空餐點欄位();
        }
        #endregion

        #region 新增餐點
        private void btn_AddMeals_Click(object sender, EventArgs e)
        {
            if ((txt_StoreName.Text != "") && (txt_MealsItem.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Insert Into restaurant Values(@eatName, @item, @price);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@eatName", txt_StoreName.Text);
                cmd.Parameters.AddWithValue("@item", txt_MealsItem.Text);
                cmd.Parameters.AddWithValue("@price", txt_MealsPrice.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料新增成功");
                餐廳選擇();
                快速填入餐廳名稱();
                顯示所有餐廳();

                txt_MealsItem.Text = "";
                txt_MealsPrice.Text = "";
                dataGridView_StoreMenu.ClearSelection();
            }
            else
            {
                MessageBox.Show("請填入所有欄位");
            }
        }
        #endregion

        #region 修改餐點
        private void btn_ChangMeals_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_MealsID.Text, out intID);

            if (intID > 0)
            {
                if ((txt_StoreName.Text != "") && (txt_MealsPrice.Text != "") && (txt_MealsItem.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update restaurant set eatName=@NewEatName, item=@NewItem , price=@newPrice where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewEatName", txt_StoreName.Text);
                    cmd.Parameters.AddWithValue("@NewItem", txt_MealsItem.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txt_MealsPrice.Text);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");

                    餐廳選擇();
                    快速填入餐廳名稱();
                    清空餐點欄位();
                    顯示所有餐廳();
                    dataGridView_StoreMenu.ClearSelection();
                }
                else
                {
                    MessageBox.Show("請填入所有欄位");
                }
            }
        }
        #endregion

        #region 刪除餐點
        private void btn_DelMeals_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_MealsID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Delete From restaurant Where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
                餐廳選擇();
                快速填入餐廳名稱();
                清空餐點欄位();
                顯示所有餐廳();
                dataGridView_StoreMenu.ClearSelection();
            }
        }
        #endregion

        #region 快速填入餐廳名稱(欄位)
        private void comboBox_InsertStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_StoreMenu.ClearSelection();
        }
        #endregion

        #region 填入餐廳名稱
        private void btn_InsertStore_Click(object sender, EventArgs e)
        {
            txt_StoreName.Text = comboBox_SelectStore.SelectedItem.ToString();
        }
        #endregion

        #region 顯示所有餐廳
        private void btn_AllStore_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_StoreMenu.DataSource = dt;
            }

            reader.Close();
            con.Close();
            dataGridView_StoreMenu.ClearSelection();
        }
        #endregion

        #region 值日生資料
        private void dataGridView_Duty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            { 
                return; 
            }

            string strSelID = dataGridView_Duty.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From member Where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txt_EmpID.Text = string.Format("{0}", reader["id"]);
                txt_DeptID.Text = string.Format("{0}", reader["id"]);
                txt_EmpDept.Text = string.Format("{0}", reader["class"]);
                txt_EmpName.Text = string.Format("{0}", reader["name"]);
                txt_EmpTel.Text = string.Format("{0}", reader["tel"]);
            }
            else
            {
                MessageBox.Show("查無此人員");
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 指定值日生
        private void btn_SpecifyDuty_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_EmpID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Update member Set 值日生狀態=@New值日生狀態 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@New值日生狀態", true);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料修改成功");
                值日生介面();
                dataGridView_Duty.ClearSelection();
            }
        }
        #endregion

        #region 取消值日生
        private void btn_CancelDuty_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_EmpID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Update member Set 值日生狀態=@New值日生狀態 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@New值日生狀態", false);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料修改成功");
                值日生介面();
            }
        }
        #endregion

        #region 清空人員欄位
        private void btn_ClearEmp_Click(object sender, EventArgs e)
        {
            清空人員欄位();
        }
        #endregion

        #region 新增人員-SQL語法有錯
        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            if ((txt_EmpDept.Text != "") && (txt_EmpName.Text != "") && (txt_EmpTel.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into member values(@eatName, @item, @price,0);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@", txt_EmpDept.Text);
                cmd.Parameters.AddWithValue("@", txt_EmpName.Text);
                cmd.Parameters.AddWithValue("@", txt_EmpTel.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料新增成功");
                值日生介面();
                快速填入部門();
                部門選擇();
                txt_EmpName.Text = "";
                txt_EmpTel.Text = "";
            }
            else
            {
                MessageBox.Show("請填入所有欄位");
            }
        }
        #endregion

        #region 修改人員
        private void btn_ChangeEmp_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_DeptID.Text, out intID);

            if (intID > 0)
            {
                if ((txt_EmpDept.Text != "") && (txt_EmpName.Text != "") && (txt_EmpTel.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "Update member Set class=@NewEatName, name=@NewItem , tel=@newPrice,值日生狀態=0 where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewEatName", txt_EmpDept.Text);
                    cmd.Parameters.AddWithValue("@NewItem", txt_EmpName.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txt_EmpTel.Text);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");
                    值日生介面();
                    清空人員欄位();
                    dataGridView_Duty.ClearSelection();
                }
                else
                {
                    MessageBox.Show("請填入所有欄位");
                }
            }
        }
        #endregion

        #region 刪除人員
        private void btn_DelEmp_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_DeptID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Delete From member Where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
                值日生介面();
                清空人員欄位();
                dataGridView_Duty.ClearSelection();
            }
        }
        #endregion

        #region 填入部門
        private void btn_Inser_DeptName_Click(object sender, EventArgs e)
        {
            txt_EmpDept.Text = comboBox_Insert_DeptName.SelectedItem.ToString();
        }
        #endregion

        #region 後台更新完成訊息
        private void Restart()
        {
            System.Threading.Thread thtmp = new System.Threading.Thread(new
            System.Threading.ParameterizedThreadStart(run));

            object appName = Application.ExecutablePath;
            System.Threading.Thread.Sleep(500);
            thtmp.Start(appName);
        }

        private void run(Object obj)
        {
            MessageBox.Show("後台已更新完成，重新載入表單");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }
        #endregion

        #region 顯示選擇餐廳
        private void btn_SelectStore_Click(object sender, EventArgs e)
        {
            產生菜單();
            dataGridView_StoreMenu.ClearSelection();
        }
        #endregion

        #region 顯示所有部門
        private void btn_AllDept_Click(object sender, EventArgs e)
        {
            值日生介面();
            dataGridView_Duty.ClearSelection();
        }
        #endregion

        #region 顯示選擇部門
        private void btn_SelectDept_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From member Where class = @NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", comboBox_SelectDept.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_Duty.DataSource = dt;
            }

            reader.Close();
            con.Close();
            dataGridView_Duty.ClearSelection();
        }
        #endregion

        #region 不知道作用
        private void admin_manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Restart();
        }
        #endregion
    }
}
