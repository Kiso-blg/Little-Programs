namespace LibraryManagementSystem
{
    internal class Globals
    {
        public static int GlobalAdministrationId { get; private set; }

        public static string ConnectionString { get; private set; }

        // Get Administration Id.
        public static void SetGlobalAdministrationId(int AdministrationId)
        {
            GlobalAdministrationId = AdministrationId;
        }

        // Get Connection String.
        public static void SetConnectionString(string conString)
        {
            ConnectionString = conString;
        }
    }
}