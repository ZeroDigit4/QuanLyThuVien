using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DTO
{
    public class AccountDTO
    {

        public AccountDTO(string userName, string displayName, string type, string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = this.type;
            this.PassWord = passWord;

        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = row["type"].ToString();
            this.PassWord = row["passWord"].ToString();
        }

        private string userName;

        public string UserName { get { return userName; } set { userName = value; } }
        private string passWord;
        public string PassWord { get { return passWord; } set { passWord = value; } }
        
        private string displayName;
        public string DisplayName { get { return displayName; } set { displayName = value; } }

       
        private string type;
        public string Type { get { return type; } set { type = value; } }       

    }
}
