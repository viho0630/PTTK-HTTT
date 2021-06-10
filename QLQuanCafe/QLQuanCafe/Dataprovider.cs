using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace QLQuanCafe
{
    class Dataprovider
    {
        #region ------------------------Khai báo biến-----------------------------------
        public static SqlConnection conn = null;
        public static DataTable dt;
        private static SqlCommand cm;
        private static SqlDataAdapter da;
        private static SqlCommandBuilder builder;
        #endregion

        #region ------------------------Connect Database------------------------------
        public static SqlConnection ketnoidulieu()
        {
            try
            {

                string[] kq;
                FileStream fs = new FileStream(@"ketnoi.ini", FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                String c = rd.ReadToEnd();
                string[] stringSeparators = new string[] { "\r\n" };
                kq = c.Split(stringSeparators, StringSplitOptions.None);
                string chuoiketnoi = "Data Source=" + kq[0].Trim() + ";Initial Catalog=" + kq[1].Trim() + ";Integrated Security=True";
                conn = new SqlConnection(chuoiketnoi);
                rd.Close();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        #endregion


        #region -----------------Đăng nhập---------------------
        public static DataTable dangnhap(string tk, string mk)
        {
            conn = ketnoidulieu();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            SqlCommand cm = new SqlCommand("NhanVien", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaNV", tk);
            cm.Parameters.AddWithValue("@MatKhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region -----------------Hàm xử lý dữ liệu ------------------------------
        // Hàm lấy dữ liệu theo câu truy vấn
        public static DataTable getDatatTable(string sql)
        {
            //dt.Clear();
            dt = new DataTable();
            conn = ketnoidulieu();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cm = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        //Hàm đọc cấu trúc bảng
        public static DataTable DocCauTruc(string tenbang)
        {
            try
            {
                dt.Clear();
                conn = ketnoidulieu();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                da = new SqlDataAdapter("select * from " + tenbang, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Hàm thêm - cập nhật dữ liệu
        public static int Update(DataTable table)
        {
            try
            {
                conn = ketnoidulieu();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(table);
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Xoá dữ liệu trên 1 dòng
        public static int Delete_Dong(string tenbang, string tencot, string idDel)
        {
            try
            {
                conn = ketnoidulieu();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand del = new SqlCommand("DELETE FROM " + tenbang + " WHERE " + tencot + "=" + "'" + idDel + "'", conn);
                del.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Cập nhật thay đổi trên dong
        public static int Update_Dong(DataRow dong, string tenbang)
        {
            int kq = 0;
            try
            {
                DataTable bang = dong.Table;
                if (bang.Rows.IndexOf(dong) < 0)
                {
                    bang.Rows.Add(dong);
                }
                else
                {
                    string chuoilenh = "Select * from " + tenbang;
                    da = new SqlDataAdapter(chuoilenh, conn);
                    builder = new SqlCommandBuilder(da);
                    return kq = da.Update(bang);
                }
                return kq;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
