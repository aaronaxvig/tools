namespace Axvig.Aaron.Service
{
    class SqlHelper
    {
        public static string GetConnString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        }
    }
}
