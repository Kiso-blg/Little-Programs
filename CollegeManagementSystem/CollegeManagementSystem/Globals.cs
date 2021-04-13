namespace CollegeManagementSystem
{
    // This class will make the logged user Id global everywhere in the application
    // Learn more here -> https://www.codeproject.com/Questions/233650/How-to-define-Global-veriable-in-Csharp-net

    public static class Globals
    {
        public static string ConnectionString { get; private set; }

        public static int GlobalCollegeId { get; private set; }

        public const int MaxSemesterId = 7;

        // Set Connection String
        public static void SetConnectionString(string connString)
        {
            ConnectionString = connString;
        }

        // Set College Id
        public static void SetGlobalCollegeId(int collegeId)
        {
            GlobalCollegeId = collegeId;
        }
    }
}