using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }

        }

        private AccountDAO() { }

        public bool DangNhap(string UserName, string PassWord)
        {
            string query = "SELECT * FROM Account WHERE UserName = N'" + UserName + "'" + "AND PassWord = N'" + PassWord + "'";
            DataTable result = DAO.DataProvider.Instance.ExcecuteQuery(query);
            return result.Rows.Count > 0;
        }
         public DTO.AccountDTO GetAccount(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = N'" + userName + "'";
            DataTable data = DAO.DataProvider.Instance.ExcecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new DTO.AccountDTO(item);

            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string passWord, string newPassWord)
        {
            int result = DAO.DataProvider.Instance.ExcecuteNonQuery("EXEC UpdateAccount @userName , @displayName , @passWord , @newPassWord", new object[] {userName, displayName, passWord, newPassWord });
            return result > 0;
        }

    }
}
