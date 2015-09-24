using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace AuthLogic
{

    public interface IAuth
    {
        void OpenConnection(string path);
        void CloseConnection();
        bool AuthLogIn(string login, string password);
        void AuthSingUp(string login, string password, string key);

        bool RemoteAuthLogIn(string login, string password);
        void RemoteAuthSingUp(string login, string password, string key); 

        void OpenRemoteConnection(string serverPath);
        void CloseRemoteConnection(); 
    }
    public class Auth:IAuth
    {
        private SqlCeConnection connection;
        private SqlConnection remoteConnection; 
        private string tableName = "Autorization";

        public void OpenRemoteConnection(string serverPath)
        {
            remoteConnection = new SqlConnection(serverPath);
            remoteConnection.Open();
        }
        public void CloseRemoteConnection()
        {
            remoteConnection.Close();
        }
        public void OpenConnection(string path) 
        {
           connection = new SqlCeConnection(path);
           connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public bool AuthLogIn(string login,string password)  
        {
            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM "+tableName+" WHERE Login = '" + login + "'and Password = '" + password + "'", connection);
            SqlCeDataReader sdr;
            sdr = cmd.ExecuteReader();
            int count = 0;
            while (sdr.Read())
            {
                count++;
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public void AuthSingUp(string login, string password, string key)
        {
            DateTime dt = DateTime.Now;
            SqlCeCommand cmd = new SqlCeCommand("insert into "+tableName+"([Login], [Password], [Key], [Time]) values (@Login, @Password, @Key, @Time)", connection);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Key", key);
            cmd.Parameters.AddWithValue("@Time", dt);
            cmd.ExecuteNonQuery();
        }

        public bool RemoteAuthLogIn(string login, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName + " WHERE Login = '" + login + "'and Password = '" + password + "'", remoteConnection);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            int count = 0;
            while (sdr.Read())
            {
                count++;
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public void RemoteAuthSingUp(string login, string password, string key)
        {
            DateTime dt = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into " + tableName + "([Login], [Password], [Key], [Time]) values (@Login, @Password, @Key, @Time)", remoteConnection);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Key", key);
            cmd.Parameters.AddWithValue("@Time", dt);
            cmd.ExecuteNonQuery();
        }
    }
}
