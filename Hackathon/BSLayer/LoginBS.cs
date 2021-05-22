using Hackathon.DBLayer;
using System.Data;

namespace Hackathon.BSLayer
{
    class LoginBS
    {
        DBMain dBMain;
        public LoginBS()
        {
            dBMain = new DBMain();
        }
        public string Login(string Username)
        {
            string sqlString = "SELECT [dbo].[Login_Scanner]('" + Username + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string Login(string Username, string Password)
        {
            string sqlString = "SELECT [dbo].[Login]('" + Username + "','" + Password + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string Get_Gmail(string Username)
        {
            string sqlString = "SELECT Gmail from Account Where Username = " + Username;
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
