using Hackathon.DBLayer;
using System.Data;

namespace Hackathon.BSLayer
{
    class ForgetPasswordBS
    {
        private DBMain dBMain;
        public ForgetPasswordBS()
        {
            dBMain = new DBMain();
        }
        public string Send_Mail_To(string Username)
        {
            string sqlString = "SELECT [dbo].[take_Gmail]('" + Username + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
        public bool Change_Password(string Username, string New_Password)
        {
            string sqlString = "Update Account Set Account.Password = " + New_Password + "FROM Account Where Username='" + Username + "'";
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
