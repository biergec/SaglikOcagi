using System.Data.SqlClient;
using System.Configuration;

namespace SaglikOcagi
{
    class SQLBaglanti
    {
        private static SqlConnection sqlBaglan;
        private static object _Lock = new object();
        
        protected SQLBaglanti() { }

        public static SqlConnection SqlBaglan()
        {
            if (sqlBaglan==null)
            {
                lock (_Lock)
                {
                    sqlBaglan = new SqlConnection();
                    SqlBaglan().ConnectionString = ConfigurationManager.ConnectionStrings["SOHTS"].ConnectionString;
                }
            }
            return sqlBaglan;
        }
    }
}
