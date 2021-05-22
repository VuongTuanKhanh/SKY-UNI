using Hackathon.DBLayer;
using System.Data;

namespace Hackathon.BSLayer
{
    class RegisterBS
    {
        private DBMain dBMain;

        public RegisterBS()
        {
            dBMain = new DBMain();
        }

        public void Regist(string Username, string Password, string Gmail)
        {
            string sqlString = "EXEC New_Account '" + Username + "','" + Password + "','" + Gmail + "'";
            dBMain.ExecuteScalar_void(sqlString, CommandType.Text);
        }
        public string Check_Username(string Username)
        {
            string sqlString = "SELECT dbo.Check_Username('" + Username + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
