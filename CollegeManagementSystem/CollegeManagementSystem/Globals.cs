// <copyright file="Globals.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    //// This class will make the logged user Id global everywhere in the application
    //// Learn more here -> https://www.codeproject.com/Questions/233650/How-to-define-Global-veriable-in-Csharp-net

    /// <summary>
    /// The main Global class.
    /// Contains static properties and methods.
    /// </summary>
    public static class Globals
    {
        /// <summary>
        /// Contains the maximum semester level.
        /// </summary>
        public const int MaxSemesterId = 7;

        /// <summary>
        /// Gets SQL connection string.
        /// </summary>
        public static string ConnectionString { get; private set; }

        /// <summary>
        /// Gets the logged in college id.
        /// </summary>
        public static int GlobalCollegeId { get; private set; }

        /// <summary>
        /// Set Connection String
        /// </summary>
        /// <param name="connString">String containing connection string.</param>
        public static void SetConnectionString(string connString)
        {
            ConnectionString = connString;
        }

        /// <summary>
        /// Set College Id
        /// </summary>
        /// <param name="collegeId">Integer containing college Id.</param>
        public static void SetGlobalCollegeId(int collegeId)
        {
            GlobalCollegeId = collegeId;
        }
    }
}
