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
    public partial class ViewList : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public ViewList()
        {
            InitializeComponent();
        }

        #region 顯示所有餐廳

        /// <summary>
        /// 顯示所有餐廳
        /// </summary>
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
                dataGridView_Menu.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 產生訂單
        /// <summary>
        /// 產生訂單
        /// </summary>
        void 產生訂單() 
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();

            string strSQL = "Select * From orders";
            SqlCommand cmd = new SqlCommand(strSQL,con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_OrderList.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 計算購物車價錢
        /// <summary>
        /// 計算購物車價錢
        /// </summary>
        void 計算購物車價錢()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();

            string strSQL = "Select Sum(price) as 總價 Form orders";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lab_TotalMoney.Text = string.Format("總共{0}元", reader["總價"]);
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 篩選餐廳
        /// <summary>
        /// 篩選餐廳
        /// </summary>
        void 篩選餐廳()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select Distinct eatName From restaurant";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_Store.Items.Add(reader["eatName"]);
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 產生菜單
        /// <summary>
        /// 產生菜單
        /// </summary>
        void 產生菜單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant Where eatName = @OnlyEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@OnlyEatName", comboBox_Store.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_Menu.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 篩選部門
        /// <summary>
        /// 篩選部門
        /// </summary>
        void 篩選部門()
        {
            comboBox_Dept.Items.Clear();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select Distinct class From member";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox_Dept.Items.Add(reader["class"]);
            }

            reader.Close();
            con.Close();
            comboBox_Dept.SelectedIndex = 0;
        }
        #endregion

        #region 篩選人員名稱
        /// <summary>
        /// 篩選人員名稱
        /// </summary>
        void 篩選人員名稱()
        {
            comboBox_Name.Items.Clear();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select name From member Where class = @selectClass";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@selectClass", comboBox_Dept.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox_Name.Items.Add(reader["name"]);

                comboBox_Name.SelectedIndex = 0;
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 值日生提醒
        /// <summary>
        /// 值日生提醒
        /// </summary>
        void 值日生提醒()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select class,name From member Where 值日生狀態 = 1";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox_BornOnDuty.Items.Add(reader["class"] + "" + reader["name"]);
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 產生人員電話號碼
        /// <summary>
        /// 產生人員電話號碼
        /// </summary>
        void 產生電話號碼()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select tel,值日生狀態 From member Where name = @selectName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@selectName", comboBox_Name.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txt_Tel.Text = string.Format("{0}", reader["tel"]);
                ckb_BornOnDuty.Checked = (bool)reader["值日生狀態"];
            }

            reader.Close();
            con.Close();
        }
        #endregion

        #region 登入讀取

        private void login_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"";
            scsb.InitialCatalog = "workDB";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            篩選部門();
            篩選人員名稱();
            篩選餐廳();
            顯示所有餐廳();
            產生訂單();
            計算購物車價錢();
            值日生提醒();

            comboBox_Store.SelectedIndex = 0;

            if (ckb_BornOnDuty.Checked == true)
            {
                btn_OpenOrder.Visible = true;
            }
            else
            {
                btn_OpenOrder.Visible = false;
            }

            dataGridView_Menu.ClearSelection();
            dataGridView_OrderList.ClearSelection();
        }
        #endregion

        #region 部門人員選擇

        private void combox_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            篩選人員名稱();
        }

        #endregion

        #region 值日生選擇
        private void ckb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            產生電話號碼();

            if (ckb_BornOnDuty.Checked == true)
            {
                btn_OpenOrder.Visible = true;
            }
            else
            {
                btn_OpenOrder.Visible = false;
            }
        }
        #endregion

        #region 加入訂單列
        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            if (lab_StoreName.Text != "餐廳名稱")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "Insert Into orders Values(@餐廳名稱, @餐點項目, @餐點價格,@點單人);";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@餐廳名稱", lab_StoreName.Text);
                cmd.Parameters.AddWithValue("@餐點項目", lab_Item.Text);
                cmd.Parameters.AddWithValue("@餐點價格", lab_Price.Text);
                cmd.Parameters.AddWithValue("@點單人", comboBox_Name.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("請點取選項再加入");
            }
        }
        #endregion

        #region 菜單

        private void dataGridView_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string strSelID = dataGridView_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From restaurant Where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            // ado.net特有的搜尋過濾 @SearchName
            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lab_StoreName.Text = string.Format("{0}", reader["eatName"]);
                lab_Item.Text = string.Format("{0}", reader["item"]);
                lab_Price.Text = string.Format("{0}", reader["price"]);
            }
            else
            {
                MessageBox.Show("查無此品項");
            }

            reader.Close();
            con.Close();
        }


        #endregion

        #region 訂單列表

        private void dataGridView_OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            { 
                return; 
            }

            string strSelID = dataGridView_OrderList.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Select * From orders Where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            // ado.net特有的搜尋過濾 @SearchName
            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txt_DelItem.Text = string.Format("{0}", reader["id"]);
            }

            reader.Close();
            con.Close();
        }


        #endregion

        #region 刪除品項
        private void but_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定要刪除此項目?", "刪除作業", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string strSQL = "Delete From orders Where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", txt_DelItem.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("刪除成功");

                產生訂單();
                計算購物車價錢();

                txt_DelItem.Text = dataGridView_OrderList.CurrentCell.Value.ToString();
                dataGridView_OrderList.ClearSelection();
            }
        }
        #endregion

        #region 後台登入

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            Admin_Login login = new Admin_Login();
            login.ShowDialog();
        }

        #endregion

        #region 開啟訂購單
        private void btn_OpenOrder_Click(object sender, EventArgs e)
        {
            buyItem openBuyItem = new buyItem();
            openBuyItem.ShowDialog();
        }
        #endregion

        #region 顯示所有餐廳
        private void btn_AllStore_Click(object sender, EventArgs e)
        {
            顯示所有餐廳();
            dataGridView_Menu.ClearSelection();
        }
        #endregion

        #region 顯示選擇餐廳
        private void btn_SelectStore_Click(object sender, EventArgs e)
        {
            產生菜單();
            dataGridView_Menu.ClearSelection();
        }
        #endregion
    }
}
