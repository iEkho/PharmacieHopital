using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace Pharmacie
{
    abstract class DAO<T>
    {
        public static SqlConnection laConnection = null;
        public static SqlConnection seConnecter()
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018PPEpharmacieFDAL; User ID=desprez; password=desprez";
                laConnection.Open();
            }
            return laConnection;
        }
        public static bool seDeconnecter()
        {
            if (laConnection != null)
            {
                laConnection.Close();
                laConnection = null;
            }
            return true;
        }
        public abstract Boolean create(T objet);
        public abstract T find(Int32 id);
        public abstract Boolean update(T objet);
        public abstract Boolean delete(T objet);
    }
}
