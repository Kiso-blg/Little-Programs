namespace Csharp_Manage_Contacts
{
    // This class will make the logged user Id global everywhere in the application
    // Learn more here -> https://www.codeproject.com/Questions/233650/How-to-define-Global-veriable-in-Csharp-net
    class Globals
    {
        public static int GlobalUserId { get; private set; }

        public static string ConnectionString { get; private set; }

        // Get User Id
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }

        // Get Connection String
        public static void SetConnectionString(string conString)
        {
            ConnectionString = conString;
        }
    }
}